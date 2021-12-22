using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;



namespace KeyCheckGui
{
    public partial class AuthDialog : Form
    {
        private string _login;
        private string _password;
        private string _serverName;
        private Action<string> onAuth;
        
        private string Url => _serverName + AUTH_URL;
        private const string AUTH_ERROR = "Не удалось авторизоваться";
        private const string AUTH_URL = "pub/admin/login";

        public AuthDialog(string serverName, Action<string> action)
        {
            InitializeComponent();
            onAuth = action;
            SetServerName(serverName);
        }

        public void SetServerName(string name)
        {
            _serverName = name;
            Text = _serverName;
        }

        private void OnLoginChanged(object sender, EventArgs e)
        {
            _login = loginField.Text;
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            _password = passwordField.Text;
        }

        private void OnAuthClick(object sender, EventArgs e)
        {
            var request = new LoginRequest(_login, _password);
            var toSend = JsonSerializer.Serialize(request);

            var responce = KeyChecker.Client.PostAsync(Url, new StringContent(toSend, Encoding.UTF8, "application/json")).Result;

            if (!responce.IsSuccessStatusCode)
            {
                MessageBox.Show(responce.StatusCode.ToString(), AUTH_ERROR, MessageBoxButtons.OK);
            }
            else
            {
                var loginResponce = JsonSerializer.Deserialize<LoginResponse>(responce.Content.ReadAsStringAsync().Result);
                onAuth(loginResponce.token);
                Close();
            }
        }

        public class LoginRequest
        {
            public LoginRequest(string login, string pass)
            {
                username = login;
                password = pass;
                browser = new Browser();
            }

            public string username { get; set; }
            public string password { get; set; }
            public Browser browser { get; set; }
        }

        public class Browser
        {
            public Browser()
            {
                browser = "KeyChekGuiApp";
                os = "Windows";
                userAgent = "KeyChekGuiApp version 1";
                language = "Russian";
                ip = "0.0.0.0";
            }

            public string browser { get; set; }
            public string language { get; set; }
            public string os { get; set; }
            public string userAgent { get; set; }
            public string ip { get; set; }
        }

        private class LoginResponse
        {
            public string token { get; set; }
            public string refreshToken { get; set; }
            public string[] authorities { get; set; }
        }
    }
}
