using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class KeyChecker : Form
    {
        public static HttpClient Client => client;
        
        private static readonly HttpClient client = new HttpClient();
        private AuthDialog _authDialog;
        private UserHardware[] _hardwares;
        private string Key => keyBox.Text;
        private string CurrentServer => serversBox.Text;
        private string Product => productBox.Text;

        private readonly string[] _servers = new string[] { "https://nau-mag.com/", "https://savanto.me/" };
        private Dictionary<string, string> _tokens = new Dictionary<string, string>();

        private bool TokenAvalible => _tokens != null && _tokens.TryGetValue(CurrentServer, out string token) && !string.IsNullOrEmpty(token);
        private string DevicesGroupText => string.Format("Devices used on \"{0}\" key", Key);
        private string ResultGroupText => string.Format("Check [{0}] for [{1}]", Key, Product);
        public string KeyUrl => string.Format("{0}pub/school", CurrentServer);
        private string UserDataUrl => string.Format("{0}pub/school/user/{1}", CurrentServer, Key);

        public KeyChecker()
        {
            InitializeComponent();
            InitServersBox();
            productBox.Items.AddRange(Enum.GetNames(typeof(StatisticsProduct)));
            UpdateAuth();
        }

        private void InitServersBox()
        {
            serversBox.Items.AddRange(_servers);
            serversBox.SelectedIndex = 0;
        }

        private void UpdateAuth()
        {
            SetButtonState(authorizationButton, !TokenAvalible, authIcon);
            UpdateClientHeaders();
        }

        private void SetButtonState(Button button, bool state, Label icon = null)
        {
            button.Enabled = state;

            if (icon != null)
            {
                icon.Text = state ?  "X" : "✓";
                icon.ForeColor = state ? Color.Red : Color.Green;
            }
        }
        
        private void SetStatusIcon(bool state)
        {
            statusIcon.Text = state ? "OK" : "FAIL";
            statusIcon.ForeColor = state ? Color.Green : Color.Red;
        }

        private void SetErrorLabels(bool state, string text)
        {
            errorText.Visible = state;
            errorText.Text = text;
        }

        private void OnAuth(string token)
        {
            _tokens[CurrentServer] = token;
            UpdateAuth();
        }

        private void UpdateClientHeaders()
        {
            client.DefaultRequestHeaders.Clear();

            if (TokenAvalible)
                client.DefaultRequestHeaders.Add("Authorization", _tokens[CurrentServer]);
        }

        public void UpdateDevicesList(string server, string key, UserHardware[] hardwares)
        {
            _hardwares = hardwares;
            devicesGroup.Text = DevicesGroupText;

            deviceList.Items.Clear();
            FillDevices();
        }

        private void FillDevices()
        {
            deviceList.Items.AddRange(_hardwares.Select(hardware => new ListViewItem(hardware.ToArray())).ToArray());
            deviceList.Items[0].Selected = true;
        }

        private void OnDeviceListItemSelected(object sender, EventArgs e)
        {
            if (deviceList.SelectedItems.Count > 0)
            {
                SetDeviceInfo(GetSelectedHardware());
            }
        }

        private UserHardware GetSelectedHardware()
        {
            return _hardwares.FirstOrDefault(hardware => hardware.deviceId.ToString() == deviceList.SelectedItems[0].Text);
        }

        private void SetDeviceInfo(UserHardware hardware)
        {
            elementInfo.Text = "ID:" + hardware.deviceId.ToString();
            deviceIdInfo.Text = hardware.id;
            modelInfo.Text = hardware.deviceModel;
            deviceNameInfo.Text = hardware.deviceName;
            deviceTypeInfo.Text = hardware.deviceType;
            osInfo.Text = hardware.operatingSystem;
            ramInfo.Text = hardware.systemMemorySize;
            processorInfo.Text = hardware.processorType;
            graphicsNameInfo.Text = hardware.graphicsDeviceName;
            graphicsSizeInfo.Text = hardware.graphicsMemorySize;
            graphicsVersionInfo.Text = hardware.graphicsDeviceVersion;
            productBox.SelectedIndex = productBox.FindString(hardware.product);
        }

        private void OnCheckKey(object sender, EventArgs e)
        {
            var toSend = JsonSerializer.Serialize(new KeyRequest(Product, Key, GetSelectedHardware()));
            var response = client.PostAsync(KeyUrl, new StringContent(toSend, Encoding.UTF8, "application/json")).Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString(), "KEY_CHEK_ERROR", MessageBoxButtons.OK);
                OnAuth(null);
            }
            else
            {
                var keyResponse = JsonSerializer.Deserialize<KeyResponse>(response.Content.ReadAsStringAsync().Result);
                SetCheckResult(keyResponse.value, keyResponse.details);
            }
        }

        private void SetCheckResult(string value, string text)
        {
            resultGroup.Text = ResultGroupText;

            bool isOk = value == "ok";

            SetStatusIcon(isOk);
            SetErrorLabels(!isOk, text);
        }

        private void OnChangeServer(object sender, EventArgs e)
        {
            if (_authDialog != null)
            {
                _authDialog.SetServerName(serversBox.Text);
            }

            UpdateAuth();
        }

        private void OnAuthorizationClick(object sender, EventArgs e)
        {
            if (_authDialog == null || !_authDialog.CanFocus)
            {
                _authDialog = new AuthDialog(CurrentServer, OnAuth);
                _authDialog.Show();
            }
            else
            {
                _authDialog.Focus();
            }
        }

        private void OnKeyChanged(object sender, EventArgs e)
        {
            SetButtonState(updateDevicesButton, TokenAvalible && !string.IsNullOrEmpty(Key));
        }

        private void OnUpdateDevices(object sender, EventArgs e)
        {
            var response = client.GetAsync(UserDataUrl).Result;
            SetButtonState(checkButton, response.IsSuccessStatusCode);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString(), "UPDATE_DEVICES_ERROR", MessageBoxButtons.OK);
                OnAuth(null);
            }
            else
            {
                var userData = JsonSerializer.DeserializeAsync<UserData>(response.Content.ReadAsStreamAsync().Result).Result;

                UpdateDevicesList(CurrentServer, Key, userData.user.hardwares);
            }
        }

        private enum StatisticsProduct
        {
            school,
            cards_app,
            cards_app_school,
            logopedia,
            school_japan,
            robot_key,
            vna_labs,
            expedition_magnet,
            school_demo
        }

        private class KeyRequest
        {
            public KeyRequest(string productName, string key, UserHardware userHardware)
            {
                username = key;
                password = "";
                product = productName;
                version = 0;
                hardware = new Hardware(userHardware);
                master = false;
                isTeacher = false;
            }

            public string username { get; set; }
            public string password { get; set; }
            public string product { get; set; }
            public int version { get; set; }
            public Hardware hardware { get; set; }
            public bool master { get; set; }
            public bool isTeacher { get; set; }
        }

        private class KeyResponse
        {
            public string value { get; set; }
            public string details { get; set; }
            public int delay { get; set; }
        }

        public class UserData
        {
            public User user { get; set; }
            public School school { get; set; }
        }

        public class User
        {
            public string username { get; set; }
            public bool enabled { get; set; }
            public string registred { get; set; }
            public bool verified { get; set; }
            public bool isBounced { get; set; }
            public UserHardware[] hardwares { get; set; }
            public Purchase[] purchases { get; set; }
            public bool bounced { get; set; }
        }

        public class School
        {
            public string username { get; set; }
            public string name { get; set; }
            public string city { get; set; }
            public string address { get; set; }
            public string association { get; set; }
            public string description { get; set; }
            public bool master { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string region { get; set; }
            public string contact { get; set; }
            public string position { get; set; }
            public int devices { get; set; }
            public int additionalComputers { get; set; }
            public string[] licenses { get; set; }
            public string[] trials { get; set; }
            public Dictionary<string, object> expire { get; set; }
            public bool bounced { get; set; }
            public Teacher[] teachers { get; set; }
        }

        public class UserHardware
        {
            public string save { get; set; }
            public string settings { get; set; }
            public string id { get; set; }
            public string deviceModel { get; set; }
            public string deviceName { get; set; }
            public string deviceType { get; set; }
            public string operatingSystem { get; set; }
            public string processorType { get; set; }
            public string systemMemorySize { get; set; }
            public string graphicsDeviceID { get; set; }
            public string graphicsDeviceName { get; set; }
            public string graphicsDeviceVersion { get; set; }
            public string graphicsMemorySize { get; set; }
            public int emailBounceAttempts { get; set; }
            public string product { get; set; }
            public bool authorized { get; set; }
            public string duplicatedId { get; set; }
            public string token { get; set; }
            public string refreshToken { get; set; }
            public string previousToken { get; set; }
            public int deviceId { get; set; }

            public string[] ToArray()
            {
                return new string[] { deviceId.ToString(), product, id, deviceName };
            }
        }

        public class Purchase
        {
            public int id { get; set; }
            public string username { get; set; }
            public string dlc { get; set; }
            public string date { get; set; }
            public float price { get; set; }
            public string save { get; set; }
            public string seller { get; set; }
            public bool canceled { get; set; }
            public string canceler { get; set; }
            public string canceldate { get; set; }
        }

        public class Hardware
        {
            public Hardware(UserHardware hardware)
            {
                id = hardware.id;
                deviceModel = hardware.deviceModel;
                deviceName = hardware.deviceName;
                deviceType = hardware.deviceType;
                operatingSystem = hardware.operatingSystem;
                processorCount = hardware.processorType;
                processorFrequency = "";
                processorType = hardware.processorType;
                systemMemorySize = hardware.systemMemorySize;
                graphicsDeviceID = hardware.graphicsDeviceID;
                graphicsDeviceName = hardware.graphicsDeviceName;
                graphicsDeviceType = "";
                graphicsDeviceVendor = "";
                graphicsDeviceVendorID = "";
                graphicsDeviceVersion = "";
                graphicsMemorySize = hardware.graphicsMemorySize;
                graphicsMultiThreaded = "";
                graphicsShaderLevel = "";
                maxTextureSize = "";
                npotSupport = "";
            }

            public string id { get; set; }
            public string deviceModel { get; set; }
            public string deviceName { get; set; }
            public string deviceType { get; set; }
            public string operatingSystem { get; set; }
            public string processorCount { get; set; }
            public string processorFrequency { get; set; }
            public string processorType { get; set; }
            public string systemMemorySize { get; set; }
            public string graphicsDeviceID { get; set; }
            public string graphicsDeviceName { get; set; }
            public string graphicsDeviceType { get; set; }
            public string graphicsDeviceVendor { get; set; }
            public string graphicsDeviceVendorID { get; set; }
            public string graphicsDeviceVersion { get; set; }
            public string graphicsMemorySize { get; set; }
            public string graphicsMultiThreaded { get; set; }
            public string graphicsShaderLevel { get; set; }
            public string maxTextureSize { get; set; }
            public string npotSupport { get; set; }
        }

        public class Teacher
        {
            public string name { get; set; }
            public string teacher { get; set; }
        }

    }
}

