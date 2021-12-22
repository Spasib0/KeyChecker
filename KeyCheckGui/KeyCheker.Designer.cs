
namespace KeyCheckGui
{
    partial class KeyChecker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceList = new System.Windows.Forms.ListView();
            this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.productColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.deviceIdColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.hardwareIdLabel = new System.Windows.Forms.Label();
            this.deviceIdInfo = new System.Windows.Forms.Label();
            this.deviceNameInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.graphicsNameInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deviceTypeInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.graphicsSizeInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.graphicsVersionInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.osInfo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.processorInfo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.elementInfo = new System.Windows.Forms.GroupBox();
            this.pricessorGroup = new System.Windows.Forms.GroupBox();
            this.ramGroup = new System.Windows.Forms.GroupBox();
            this.ramInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.graphicsGroup = new System.Windows.Forms.GroupBox();
            this.deviceGroup = new System.Windows.Forms.GroupBox();
            this.chekKeyGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.authIcon = new System.Windows.Forms.Label();
            this.serversBox = new System.Windows.Forms.ComboBox();
            this.keyGroup = new System.Windows.Forms.GroupBox();
            this.updateDevicesButton = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.devicesGroup = new System.Windows.Forms.GroupBox();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.errorText = new System.Windows.Forms.Label();
            this.statusIcon = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.elementInfo.SuspendLayout();
            this.pricessorGroup.SuspendLayout();
            this.ramGroup.SuspendLayout();
            this.graphicsGroup.SuspendLayout();
            this.deviceGroup.SuspendLayout();
            this.chekKeyGroup.SuspendLayout();
            this.serverGroup.SuspendLayout();
            this.keyGroup.SuspendLayout();
            this.devicesGroup.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.AllowColumnReorder = true;
            this.deviceList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.productColumnHeader,
            this.deviceIdColumnHeader});
            this.deviceList.FullRowSelect = true;
            this.deviceList.HideSelection = false;
            this.deviceList.Location = new System.Drawing.Point(12, 22);
            this.deviceList.MultiSelect = false;
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(480, 421);
            this.deviceList.TabIndex = 2;
            this.deviceList.UseCompatibleStateImageBehavior = false;
            this.deviceList.View = System.Windows.Forms.View.Details;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.OnDeviceListItemSelected);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "   Id";
            // 
            // productColumnHeader
            // 
            this.productColumnHeader.Text = "Product";
            this.productColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productColumnHeader.Width = 120;
            // 
            // deviceIdColumnHeader
            // 
            this.deviceIdColumnHeader.Text = "Hardware Id";
            this.deviceIdColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deviceIdColumnHeader.Width = 295;
            // 
            // hardwareIdLabel
            // 
            this.hardwareIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hardwareIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hardwareIdLabel.Location = new System.Drawing.Point(6, 19);
            this.hardwareIdLabel.Name = "hardwareIdLabel";
            this.hardwareIdLabel.Size = new System.Drawing.Size(80, 23);
            this.hardwareIdLabel.TabIndex = 5;
            this.hardwareIdLabel.Text = "Hardware id :";
            this.hardwareIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hardwareIdLabel.UseMnemonic = false;
            // 
            // deviceIdInfo
            // 
            this.deviceIdInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceIdInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceIdInfo.Location = new System.Drawing.Point(92, 19);
            this.deviceIdInfo.Name = "deviceIdInfo";
            this.deviceIdInfo.Size = new System.Drawing.Size(252, 23);
            this.deviceIdInfo.TabIndex = 6;
            this.deviceIdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceNameInfo
            // 
            this.deviceNameInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceNameInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceNameInfo.Location = new System.Drawing.Point(92, 88);
            this.deviceNameInfo.Name = "deviceNameInfo";
            this.deviceNameInfo.Size = new System.Drawing.Size(252, 23);
            this.deviceNameInfo.TabIndex = 10;
            this.deviceNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.UseMnemonic = false;
            // 
            // modelInfo
            // 
            this.modelInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modelInfo.AutoSize = true;
            this.modelInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelInfo.Location = new System.Drawing.Point(92, 115);
            this.modelInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.modelInfo.Name = "modelInfo";
            this.modelInfo.Size = new System.Drawing.Size(0, 15);
            this.modelInfo.TabIndex = 8;
            this.modelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Model :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.UseMnemonic = false;
            // 
            // graphicsNameInfo
            // 
            this.graphicsNameInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsNameInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsNameInfo.Location = new System.Drawing.Point(86, 19);
            this.graphicsNameInfo.Name = "graphicsNameInfo";
            this.graphicsNameInfo.Size = new System.Drawing.Size(252, 23);
            this.graphicsNameInfo.TabIndex = 14;
            this.graphicsNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.UseMnemonic = false;
            // 
            // deviceTypeInfo
            // 
            this.deviceTypeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceTypeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceTypeInfo.Location = new System.Drawing.Point(92, 42);
            this.deviceTypeInfo.Name = "deviceTypeInfo";
            this.deviceTypeInfo.Size = new System.Drawing.Size(158, 23);
            this.deviceTypeInfo.TabIndex = 12;
            this.deviceTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Type :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.UseMnemonic = false;
            // 
            // graphicsSizeInfo
            // 
            this.graphicsSizeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsSizeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsSizeInfo.Location = new System.Drawing.Point(86, 42);
            this.graphicsSizeInfo.Name = "graphicsSizeInfo";
            this.graphicsSizeInfo.Size = new System.Drawing.Size(252, 23);
            this.graphicsSizeInfo.TabIndex = 18;
            this.graphicsSizeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Size :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.UseMnemonic = false;
            // 
            // graphicsVersionInfo
            // 
            this.graphicsVersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsVersionInfo.AutoSize = true;
            this.graphicsVersionInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsVersionInfo.Location = new System.Drawing.Point(86, 69);
            this.graphicsVersionInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.graphicsVersionInfo.Name = "graphicsVersionInfo";
            this.graphicsVersionInfo.Size = new System.Drawing.Size(0, 15);
            this.graphicsVersionInfo.TabIndex = 16;
            this.graphicsVersionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(6, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "Version :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.UseMnemonic = false;
            // 
            // osInfo
            // 
            this.osInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osInfo.AutoSize = true;
            this.osInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osInfo.Location = new System.Drawing.Point(92, 69);
            this.osInfo.MaximumSize = new System.Drawing.Size(252, 15);
            this.osInfo.Name = "osInfo";
            this.osInfo.Size = new System.Drawing.Size(0, 15);
            this.osInfo.TabIndex = 20;
            this.osInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "OS :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.UseMnemonic = false;
            // 
            // processorInfo
            // 
            this.processorInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.processorInfo.AutoSize = true;
            this.processorInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processorInfo.Location = new System.Drawing.Point(86, 23);
            this.processorInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.processorInfo.Name = "processorInfo";
            this.processorInfo.Size = new System.Drawing.Size(0, 15);
            this.processorInfo.TabIndex = 22;
            this.processorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(6, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 23);
            this.label20.TabIndex = 21;
            this.label20.Text = "Name :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.UseMnemonic = false;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(253, 21);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(153, 23);
            this.checkButton.TabIndex = 26;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.OnCheckKey);
            // 
            // productBox
            // 
            this.productBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(92, 21);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(142, 23);
            this.productBox.TabIndex = 27;
            // 
            // elementInfo
            // 
            this.elementInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.elementInfo.Controls.Add(this.pricessorGroup);
            this.elementInfo.Controls.Add(this.ramGroup);
            this.elementInfo.Controls.Add(this.graphicsGroup);
            this.elementInfo.Controls.Add(this.deviceGroup);
            this.elementInfo.Location = new System.Drawing.Point(505, 22);
            this.elementInfo.Name = "elementInfo";
            this.elementInfo.Size = new System.Drawing.Size(422, 421);
            this.elementInfo.TabIndex = 28;
            this.elementInfo.TabStop = false;
            this.elementInfo.Text = "Information";
            // 
            // pricessorGroup
            // 
            this.pricessorGroup.Controls.Add(this.processorInfo);
            this.pricessorGroup.Controls.Add(this.label20);
            this.pricessorGroup.Location = new System.Drawing.Point(6, 351);
            this.pricessorGroup.Name = "pricessorGroup";
            this.pricessorGroup.Size = new System.Drawing.Size(409, 55);
            this.pricessorGroup.TabIndex = 19;
            this.pricessorGroup.TabStop = false;
            this.pricessorGroup.Text = "Processor";
            // 
            // ramGroup
            // 
            this.ramGroup.Controls.Add(this.ramInfo);
            this.ramGroup.Controls.Add(this.label4);
            this.ramGroup.Location = new System.Drawing.Point(6, 290);
            this.ramGroup.Name = "ramGroup";
            this.ramGroup.Size = new System.Drawing.Size(409, 55);
            this.ramGroup.TabIndex = 23;
            this.ramGroup.TabStop = false;
            this.ramGroup.Text = "RAM";
            // 
            // ramInfo
            // 
            this.ramInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ramInfo.AutoSize = true;
            this.ramInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramInfo.Location = new System.Drawing.Point(86, 23);
            this.ramInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.Size = new System.Drawing.Size(0, 15);
            this.ramInfo.TabIndex = 22;
            this.ramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Size :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.UseMnemonic = false;
            // 
            // graphicsGroup
            // 
            this.graphicsGroup.Controls.Add(this.graphicsSizeInfo);
            this.graphicsGroup.Controls.Add(this.label10);
            this.graphicsGroup.Controls.Add(this.graphicsNameInfo);
            this.graphicsGroup.Controls.Add(this.label16);
            this.graphicsGroup.Controls.Add(this.graphicsVersionInfo);
            this.graphicsGroup.Controls.Add(this.label14);
            this.graphicsGroup.Location = new System.Drawing.Point(6, 180);
            this.graphicsGroup.Name = "graphicsGroup";
            this.graphicsGroup.Size = new System.Drawing.Size(409, 104);
            this.graphicsGroup.TabIndex = 5;
            this.graphicsGroup.TabStop = false;
            this.graphicsGroup.Text = "Graphics";
            // 
            // deviceGroup
            // 
            this.deviceGroup.Controls.Add(this.hardwareIdLabel);
            this.deviceGroup.Controls.Add(this.osInfo);
            this.deviceGroup.Controls.Add(this.deviceTypeInfo);
            this.deviceGroup.Controls.Add(this.deviceNameInfo);
            this.deviceGroup.Controls.Add(this.label18);
            this.deviceGroup.Controls.Add(this.modelInfo);
            this.deviceGroup.Controls.Add(this.label12);
            this.deviceGroup.Controls.Add(this.label6);
            this.deviceGroup.Controls.Add(this.deviceIdInfo);
            this.deviceGroup.Controls.Add(this.label8);
            this.deviceGroup.Location = new System.Drawing.Point(6, 22);
            this.deviceGroup.Name = "deviceGroup";
            this.deviceGroup.Size = new System.Drawing.Size(409, 152);
            this.deviceGroup.TabIndex = 0;
            this.deviceGroup.TabStop = false;
            this.deviceGroup.Text = "Device";
            // 
            // chekKeyGroup
            // 
            this.chekKeyGroup.Controls.Add(this.label1);
            this.chekKeyGroup.Controls.Add(this.productBox);
            this.chekKeyGroup.Controls.Add(this.checkButton);
            this.chekKeyGroup.Location = new System.Drawing.Point(13, 533);
            this.chekKeyGroup.Name = "chekKeyGroup";
            this.chekKeyGroup.Size = new System.Drawing.Size(429, 59);
            this.chekKeyGroup.TabIndex = 29;
            this.chekKeyGroup.TabStop = false;
            this.chekKeyGroup.Text = "Check key for product";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseMnemonic = false;
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.authorizationButton);
            this.serverGroup.Controls.Add(this.authIcon);
            this.serverGroup.Controls.Add(this.serversBox);
            this.serverGroup.Location = new System.Drawing.Point(13, 13);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(479, 57);
            this.serverGroup.TabIndex = 30;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "Select server and authorize";
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(260, 21);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(213, 24);
            this.authorizationButton.TabIndex = 23;
            this.authorizationButton.Text = "Authorization";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.OnAuthorizationClick);
            // 
            // authIcon
            // 
            this.authIcon.AutoSize = true;
            this.authIcon.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authIcon.ForeColor = System.Drawing.Color.Crimson;
            this.authIcon.Location = new System.Drawing.Point(230, 22);
            this.authIcon.Name = "authIcon";
            this.authIcon.Size = new System.Drawing.Size(23, 24);
            this.authIcon.TabIndex = 22;
            this.authIcon.Text = "X";
            // 
            // serversBox
            // 
            this.serversBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serversBox.FormattingEnabled = true;
            this.serversBox.Location = new System.Drawing.Point(6, 22);
            this.serversBox.Name = "serversBox";
            this.serversBox.Size = new System.Drawing.Size(218, 23);
            this.serversBox.TabIndex = 21;
            this.serversBox.SelectedIndexChanged += new System.EventHandler(this.OnChangeServer);
            // 
            // keyGroup
            // 
            this.keyGroup.Controls.Add(this.updateDevicesButton);
            this.keyGroup.Controls.Add(this.keyBox);
            this.keyGroup.Location = new System.Drawing.Point(499, 13);
            this.keyGroup.Name = "keyGroup";
            this.keyGroup.Size = new System.Drawing.Size(435, 57);
            this.keyGroup.TabIndex = 31;
            this.keyGroup.TabStop = false;
            this.keyGroup.Text = "Enter the key to get his devices";
            // 
            // updateDevicesButton
            // 
            this.updateDevicesButton.Enabled = false;
            this.updateDevicesButton.Location = new System.Drawing.Point(225, 21);
            this.updateDevicesButton.Name = "updateDevicesButton";
            this.updateDevicesButton.Size = new System.Drawing.Size(204, 24);
            this.updateDevicesButton.TabIndex = 1;
            this.updateDevicesButton.Text = "Update devices";
            this.updateDevicesButton.UseVisualStyleBackColor = true;
            this.updateDevicesButton.Click += new System.EventHandler(this.OnUpdateDevices);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(6, 21);
            this.keyBox.Name = "keyBox";
            this.keyBox.PlaceholderText = "Enter key for check";
            this.keyBox.Size = new System.Drawing.Size(213, 23);
            this.keyBox.TabIndex = 0;
            this.keyBox.TextChanged += new System.EventHandler(this.OnKeyChanged);
            // 
            // devicesGroup
            // 
            this.devicesGroup.Controls.Add(this.deviceList);
            this.devicesGroup.Controls.Add(this.elementInfo);
            this.devicesGroup.Location = new System.Drawing.Point(13, 77);
            this.devicesGroup.Name = "devicesGroup";
            this.devicesGroup.Size = new System.Drawing.Size(921, 451);
            this.devicesGroup.TabIndex = 32;
            this.devicesGroup.TabStop = false;
            this.devicesGroup.Text = "Devices for {KEY}";
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.errorText);
            this.resultGroup.Controls.Add(this.statusIcon);
            this.resultGroup.Controls.Add(this.statusLabel);
            this.resultGroup.Location = new System.Drawing.Point(449, 535);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(491, 57);
            this.resultGroup.TabIndex = 33;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Check {KEY} for {PRODUCT}";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(94, 28);
            this.errorText.MaximumSize = new System.Drawing.Size(0, 30);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(38, 15);
            this.errorText.TabIndex = 3;
            this.errorText.Text = "label2";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorText.Visible = false;
            // 
            // statusIcon
            // 
            this.statusIcon.AutoSize = true;
            this.statusIcon.Location = new System.Drawing.Point(50, 28);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(57, 15);
            this.statusIcon.TabIndex = 1;
            this.statusIcon.Text = "unknown";
            this.statusIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 28);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 15);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // KeyChecker
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 604);
            this.Controls.Add(this.resultGroup);
            this.Controls.Add(this.devicesGroup);
            this.Controls.Add(this.keyGroup);
            this.Controls.Add(this.serverGroup);
            this.Controls.Add(this.chekKeyGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KeyChecker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyChecker";
            this.elementInfo.ResumeLayout(false);
            this.pricessorGroup.ResumeLayout(false);
            this.pricessorGroup.PerformLayout();
            this.ramGroup.ResumeLayout(false);
            this.ramGroup.PerformLayout();
            this.graphicsGroup.ResumeLayout(false);
            this.graphicsGroup.PerformLayout();
            this.deviceGroup.ResumeLayout(false);
            this.deviceGroup.PerformLayout();
            this.chekKeyGroup.ResumeLayout(false);
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.keyGroup.ResumeLayout(false);
            this.keyGroup.PerformLayout();
            this.devicesGroup.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView deviceList;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader productColumnHeader;
        private System.Windows.Forms.ColumnHeader deviceIdColumnHeader;
        private System.Windows.Forms.Label hardwareIdLabel;
        private System.Windows.Forms.Label deviceIdInfo;
        private System.Windows.Forms.Label deviceNameInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modelInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label graphicsNameInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label deviceTypeInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label graphicsSizeInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label graphicsVersionInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label osInfo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label processorInfo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.GroupBox elementInfo;
        private System.Windows.Forms.GroupBox deviceGroup;
        private System.Windows.Forms.GroupBox pricessorGroup;
        private System.Windows.Forms.GroupBox graphicsGroup;
        private System.Windows.Forms.GroupBox chekKeyGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.ComboBox serversBox;
        private System.Windows.Forms.Label authIcon;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.GroupBox keyGroup;
        private System.Windows.Forms.Button updateDevicesButton;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.GroupBox devicesGroup;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusIcon;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.GroupBox ramGroup;
        private System.Windows.Forms.Label ramInfo;
        private System.Windows.Forms.Label label4;
    }
}