namespace WeiXin.Tools.Win
{
    partial class StartForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.TagBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.GrbUsers = new DevExpress.XtraEditors.GroupControl();
            this.cobUserName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.GrbGetAccessToken = new DevExpress.XtraEditors.GroupControl();
            this.BtnAccessToken = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAccessToken = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.GrbDeveloperXml = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAppSecret = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAppId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.GrbServerXml = new DevExpress.XtraEditors.GroupControl();
            this.TxtToken = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TagCustomMenu = new DevExpress.XtraTab.XtraTabPage();
            this.PrgCreate = new DevExpress.XtraWaitForm.ProgressPanel();
            this.PrgSelect = new DevExpress.XtraWaitForm.ProgressPanel();
            this.BtnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.GrbCreateCustomMenu = new DevExpress.XtraEditors.GroupControl();
            this.MenuCreate = new DevExpress.XtraEditors.MemoEdit();
            this.GrbSelectCustomMenu = new DevExpress.XtraEditors.GroupControl();
            this.MenuSelect = new DevExpress.XtraEditors.MemoEdit();
            this.TagUpload = new DevExpress.XtraTab.XtraTabPage();
            this.GrbDownload = new DevExpress.XtraEditors.GroupControl();
            this.GrbUpload = new DevExpress.XtraEditors.GroupControl();
            this.PrgUpload = new DevExpress.XtraWaitForm.ProgressPanel();
            this.BtnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUploadResult = new DevExpress.XtraEditors.TextEdit();
            this.TxtUploadUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.TagBaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrbUsers)).BeginInit();
            this.GrbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbGetAccessToken)).BeginInit();
            this.GrbGetAccessToken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccessToken.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbDeveloperXml)).BeginInit();
            this.GrbDeveloperXml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAppSecret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAppId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbServerXml)).BeginInit();
            this.GrbServerXml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToken.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrl.Properties)).BeginInit();
            this.TagCustomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrbCreateCustomMenu)).BeginInit();
            this.GrbCreateCustomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbSelectCustomMenu)).BeginInit();
            this.GrbSelectCustomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSelect.Properties)).BeginInit();
            this.TagUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbUpload)).BeginInit();
            this.GrbUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUploadResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUploadUrl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Location = new System.Drawing.Point(69, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.TagBaseInfo;
            this.xtraTabControl.Size = new System.Drawing.Size(884, 562);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TagBaseInfo,
            this.TagCustomMenu,
            this.TagUpload});
            // 
            // TagBaseInfo
            // 
            this.TagBaseInfo.AutoScroll = true;
            this.TagBaseInfo.Controls.Add(this.GrbUsers);
            this.TagBaseInfo.Controls.Add(this.GrbGetAccessToken);
            this.TagBaseInfo.Controls.Add(this.GrbDeveloperXml);
            this.TagBaseInfo.Controls.Add(this.GrbServerXml);
            this.TagBaseInfo.Name = "TagBaseInfo";
            this.TagBaseInfo.Size = new System.Drawing.Size(878, 533);
            this.TagBaseInfo.Text = "配置信息";
            // 
            // GrbUsers
            // 
            this.GrbUsers.Controls.Add(this.cobUserName);
            this.GrbUsers.Controls.Add(this.labelControl8);
            this.GrbUsers.Location = new System.Drawing.Point(13, 15);
            this.GrbUsers.Name = "GrbUsers";
            this.GrbUsers.Size = new System.Drawing.Size(849, 84);
            this.GrbUsers.TabIndex = 4;
            this.GrbUsers.Text = "帐号信息";
            // 
            // cobUserName
            // 
            this.cobUserName.EditValue = "zlb218@163.com";
            this.cobUserName.Location = new System.Drawing.Point(81, 42);
            this.cobUserName.Name = "cobUserName";
            this.cobUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cobUserName.Properties.Items.AddRange(new object[] {
            "zlb218@163.com",
            "3101143131@qq.com"});
            this.cobUserName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cobUserName.Size = new System.Drawing.Size(221, 20);
            this.cobUserName.TabIndex = 1;
            this.cobUserName.SelectedIndexChanged += new System.EventHandler(this.cobUserName_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "微信帐号：";
            // 
            // GrbGetAccessToken
            // 
            this.GrbGetAccessToken.Controls.Add(this.BtnAccessToken);
            this.GrbGetAccessToken.Controls.Add(this.TxtAccessToken);
            this.GrbGetAccessToken.Controls.Add(this.labelControl6);
            this.GrbGetAccessToken.Location = new System.Drawing.Point(13, 410);
            this.GrbGetAccessToken.Name = "GrbGetAccessToken";
            this.GrbGetAccessToken.Size = new System.Drawing.Size(849, 100);
            this.GrbGetAccessToken.TabIndex = 2;
            this.GrbGetAccessToken.Text = "获取access_token";
            // 
            // BtnAccessToken
            // 
            this.BtnAccessToken.AllowFocus = false;
            this.BtnAccessToken.Location = new System.Drawing.Point(783, 49);
            this.BtnAccessToken.Name = "BtnAccessToken";
            this.BtnAccessToken.Size = new System.Drawing.Size(57, 23);
            this.BtnAccessToken.TabIndex = 2;
            this.BtnAccessToken.Text = "获取";
            this.BtnAccessToken.Click += new System.EventHandler(this.BtnAccessToken_Click);
            // 
            // TxtAccessToken
            // 
            this.TxtAccessToken.Location = new System.Drawing.Point(107, 52);
            this.TxtAccessToken.Name = "TxtAccessToken";
            this.TxtAccessToken.Properties.ReadOnly = true;
            this.TxtAccessToken.Size = new System.Drawing.Size(664, 20);
            this.TxtAccessToken.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "access_token：";
            // 
            // GrbDeveloperXml
            // 
            this.GrbDeveloperXml.Controls.Add(this.BtnSave);
            this.GrbDeveloperXml.Controls.Add(this.TxtAppSecret);
            this.GrbDeveloperXml.Controls.Add(this.labelControl3);
            this.GrbDeveloperXml.Controls.Add(this.TxtAppId);
            this.GrbDeveloperXml.Controls.Add(this.labelControl4);
            this.GrbDeveloperXml.Location = new System.Drawing.Point(13, 260);
            this.GrbDeveloperXml.Name = "GrbDeveloperXml";
            this.GrbDeveloperXml.Size = new System.Drawing.Size(849, 100);
            this.GrbDeveloperXml.TabIndex = 1;
            this.GrbDeveloperXml.Text = "开发者ID";
            // 
            // BtnSave
            // 
            this.BtnSave.AllowFocus = false;
            this.BtnSave.Location = new System.Drawing.Point(783, 47);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(57, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "保存";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtAppSecret
            // 
            this.TxtAppSecret.Location = new System.Drawing.Point(404, 48);
            this.TxtAppSecret.Name = "TxtAppSecret";
            this.TxtAppSecret.Size = new System.Drawing.Size(367, 20);
            this.TxtAppSecret.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(325, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "AppSecret：";
            // 
            // TxtAppId
            // 
            this.TxtAppId.Location = new System.Drawing.Point(61, 48);
            this.TxtAppId.Name = "TxtAppId";
            this.TxtAppId.Size = new System.Drawing.Size(241, 20);
            this.TxtAppId.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "AppId：";
            // 
            // GrbServerXml
            // 
            this.GrbServerXml.Controls.Add(this.TxtToken);
            this.GrbServerXml.Controls.Add(this.labelControl2);
            this.GrbServerXml.Controls.Add(this.TxtUrl);
            this.GrbServerXml.Controls.Add(this.labelControl1);
            this.GrbServerXml.Location = new System.Drawing.Point(13, 131);
            this.GrbServerXml.Name = "GrbServerXml";
            this.GrbServerXml.Size = new System.Drawing.Size(849, 100);
            this.GrbServerXml.TabIndex = 0;
            this.GrbServerXml.Text = "服务器配置";
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(574, 47);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(254, 20);
            this.TxtToken.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(512, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Token：";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(57, 50);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(416, 20);
            this.TxtUrl.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "URL：";
            // 
            // TagCustomMenu
            // 
            this.TagCustomMenu.AutoScroll = true;
            this.TagCustomMenu.Controls.Add(this.PrgCreate);
            this.TagCustomMenu.Controls.Add(this.PrgSelect);
            this.TagCustomMenu.Controls.Add(this.BtnCreate);
            this.TagCustomMenu.Controls.Add(this.BtnSelect);
            this.TagCustomMenu.Controls.Add(this.GrbCreateCustomMenu);
            this.TagCustomMenu.Controls.Add(this.GrbSelectCustomMenu);
            this.TagCustomMenu.Name = "TagCustomMenu";
            this.TagCustomMenu.Size = new System.Drawing.Size(878, 533);
            this.TagCustomMenu.Text = "自定义菜单";
            // 
            // PrgCreate
            // 
            this.PrgCreate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PrgCreate.Appearance.Options.UseBackColor = true;
            this.PrgCreate.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrgCreate.AppearanceCaption.Options.UseFont = true;
            this.PrgCreate.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PrgCreate.AppearanceDescription.Options.UseFont = true;
            this.PrgCreate.Caption = "创建中......";
            this.PrgCreate.Description = "";
            this.PrgCreate.Location = new System.Drawing.Point(453, 488);
            this.PrgCreate.Name = "PrgCreate";
            this.PrgCreate.ShowDescription = false;
            this.PrgCreate.Size = new System.Drawing.Size(350, 36);
            this.PrgCreate.TabIndex = 12;
            this.PrgCreate.Visible = false;
            // 
            // PrgSelect
            // 
            this.PrgSelect.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PrgSelect.Appearance.Options.UseBackColor = true;
            this.PrgSelect.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrgSelect.AppearanceCaption.Options.UseFont = true;
            this.PrgSelect.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PrgSelect.AppearanceDescription.Options.UseFont = true;
            this.PrgSelect.Caption = "查询中......";
            this.PrgSelect.Description = "";
            this.PrgSelect.Location = new System.Drawing.Point(11, 488);
            this.PrgSelect.Name = "PrgSelect";
            this.PrgSelect.ShowDescription = false;
            this.PrgSelect.Size = new System.Drawing.Size(350, 36);
            this.PrgSelect.TabIndex = 11;
            this.PrgSelect.Visible = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.AllowFocus = false;
            this.BtnCreate.Location = new System.Drawing.Point(812, 496);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(57, 23);
            this.BtnCreate.TabIndex = 10;
            this.BtnCreate.Text = "创建";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.AllowFocus = false;
            this.BtnSelect.Location = new System.Drawing.Point(374, 496);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(57, 23);
            this.BtnSelect.TabIndex = 9;
            this.BtnSelect.Text = "查询";
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // GrbCreateCustomMenu
            // 
            this.GrbCreateCustomMenu.Controls.Add(this.MenuCreate);
            this.GrbCreateCustomMenu.Location = new System.Drawing.Point(453, 12);
            this.GrbCreateCustomMenu.Name = "GrbCreateCustomMenu";
            this.GrbCreateCustomMenu.Size = new System.Drawing.Size(418, 467);
            this.GrbCreateCustomMenu.TabIndex = 1;
            this.GrbCreateCustomMenu.Text = "创建自定义菜单";
            // 
            // MenuCreate
            // 
            this.MenuCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuCreate.Location = new System.Drawing.Point(2, 22);
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.Size = new System.Drawing.Size(414, 443);
            this.MenuCreate.TabIndex = 0;
            this.MenuCreate.UseOptimizedRendering = true;
            // 
            // GrbSelectCustomMenu
            // 
            this.GrbSelectCustomMenu.Controls.Add(this.MenuSelect);
            this.GrbSelectCustomMenu.Location = new System.Drawing.Point(10, 12);
            this.GrbSelectCustomMenu.Name = "GrbSelectCustomMenu";
            this.GrbSelectCustomMenu.Size = new System.Drawing.Size(423, 467);
            this.GrbSelectCustomMenu.TabIndex = 0;
            this.GrbSelectCustomMenu.Text = "查询自定义菜单";
            // 
            // MenuSelect
            // 
            this.MenuSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSelect.EditValue = "";
            this.MenuSelect.Location = new System.Drawing.Point(2, 22);
            this.MenuSelect.Name = "MenuSelect";
            this.MenuSelect.Properties.ReadOnly = true;
            this.MenuSelect.Size = new System.Drawing.Size(419, 443);
            this.MenuSelect.TabIndex = 0;
            this.MenuSelect.UseOptimizedRendering = true;
            // 
            // TagUpload
            // 
            this.TagUpload.Controls.Add(this.GrbDownload);
            this.TagUpload.Controls.Add(this.GrbUpload);
            this.TagUpload.Name = "TagUpload";
            this.TagUpload.Size = new System.Drawing.Size(878, 533);
            this.TagUpload.Text = "上传多媒体文件";
            // 
            // GrbDownload
            // 
            this.GrbDownload.Location = new System.Drawing.Point(11, 309);
            this.GrbDownload.Name = "GrbDownload";
            this.GrbDownload.Size = new System.Drawing.Size(860, 207);
            this.GrbDownload.TabIndex = 1;
            this.GrbDownload.Text = "下载多媒体";
            // 
            // GrbUpload
            // 
            this.GrbUpload.Controls.Add(this.PrgUpload);
            this.GrbUpload.Controls.Add(this.BtnUpload);
            this.GrbUpload.Controls.Add(this.BtnBrowser);
            this.GrbUpload.Controls.Add(this.TxtUploadResult);
            this.GrbUpload.Controls.Add(this.TxtUploadUrl);
            this.GrbUpload.Controls.Add(this.labelControl7);
            this.GrbUpload.Controls.Add(this.labelControl5);
            this.GrbUpload.Location = new System.Drawing.Point(11, 51);
            this.GrbUpload.Name = "GrbUpload";
            this.GrbUpload.Size = new System.Drawing.Size(860, 191);
            this.GrbUpload.TabIndex = 0;
            this.GrbUpload.Text = "上传多媒体";
            // 
            // PrgUpload
            // 
            this.PrgUpload.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PrgUpload.Appearance.Options.UseBackColor = true;
            this.PrgUpload.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrgUpload.AppearanceCaption.Options.UseFont = true;
            this.PrgUpload.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PrgUpload.AppearanceDescription.Options.UseFont = true;
            this.PrgUpload.Caption = "上传中......";
            this.PrgUpload.Description = "";
            this.PrgUpload.Location = new System.Drawing.Point(20, 28);
            this.PrgUpload.Name = "PrgUpload";
            this.PrgUpload.ShowDescription = false;
            this.PrgUpload.Size = new System.Drawing.Size(817, 48);
            this.PrgUpload.TabIndex = 6;
            this.PrgUpload.Visible = false;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(762, 141);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnUpload.TabIndex = 5;
            this.BtnUpload.Text = "上传";
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(762, 90);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowser.TabIndex = 4;
            this.BtnBrowser.Text = "浏览";
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // TxtUploadResult
            // 
            this.TxtUploadResult.Location = new System.Drawing.Point(120, 142);
            this.TxtUploadResult.Name = "TxtUploadResult";
            this.TxtUploadResult.Properties.ReadOnly = true;
            this.TxtUploadResult.Size = new System.Drawing.Size(610, 20);
            this.TxtUploadResult.TabIndex = 3;
            // 
            // TxtUploadUrl
            // 
            this.TxtUploadUrl.Location = new System.Drawing.Point(120, 91);
            this.TxtUploadUrl.Name = "TxtUploadUrl";
            this.TxtUploadUrl.Properties.ReadOnly = true;
            this.TxtUploadUrl.Size = new System.Drawing.Size(610, 20);
            this.TxtUploadUrl.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(30, 145);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 14);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "返回结果：";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(20, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "多媒体路径：";
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(0, 0);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(75, 23);
            this.BtnImage.TabIndex = 0;
            // 
            // StartForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.xtraTabControl);
            this.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HtmlText = "微信工具";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.TagBaseInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrbUsers)).EndInit();
            this.GrbUsers.ResumeLayout(false);
            this.GrbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbGetAccessToken)).EndInit();
            this.GrbGetAccessToken.ResumeLayout(false);
            this.GrbGetAccessToken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccessToken.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbDeveloperXml)).EndInit();
            this.GrbDeveloperXml.ResumeLayout(false);
            this.GrbDeveloperXml.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAppSecret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAppId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbServerXml)).EndInit();
            this.GrbServerXml.ResumeLayout(false);
            this.GrbServerXml.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToken.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrl.Properties)).EndInit();
            this.TagCustomMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrbCreateCustomMenu)).EndInit();
            this.GrbCreateCustomMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbSelectCustomMenu)).EndInit();
            this.GrbSelectCustomMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSelect.Properties)).EndInit();
            this.TagUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrbUpload)).EndInit();
            this.GrbUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtUploadResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUploadUrl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage TagBaseInfo;
        private DevExpress.XtraTab.XtraTabPage TagCustomMenu;
        private DevExpress.XtraEditors.GroupControl GrbDeveloperXml;
        private DevExpress.XtraEditors.GroupControl GrbServerXml;
        private DevExpress.XtraEditors.TextEdit TxtUrl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtAppSecret;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAppId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtToken;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl GrbGetAccessToken;
        private DevExpress.XtraEditors.TextEdit TxtAccessToken;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BtnAccessToken;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.GroupControl GrbCreateCustomMenu;
        private DevExpress.XtraEditors.GroupControl GrbSelectCustomMenu;
        private DevExpress.XtraEditors.MemoEdit MenuSelect;
        private DevExpress.XtraEditors.MemoEdit MenuCreate;
        private DevExpress.XtraWaitForm.ProgressPanel PrgCreate;
        private DevExpress.XtraWaitForm.ProgressPanel PrgSelect;
        private DevExpress.XtraEditors.SimpleButton BtnCreate;
        private DevExpress.XtraEditors.SimpleButton BtnSelect;
        private DevExpress.XtraTab.XtraTabPage TagUpload;
        private DevExpress.XtraEditors.SimpleButton BtnImage;
        private DevExpress.XtraEditors.GroupControl GrbDownload;
        private DevExpress.XtraEditors.GroupControl GrbUpload;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnUpload;
        private DevExpress.XtraEditors.SimpleButton BtnBrowser;
        private DevExpress.XtraEditors.TextEdit TxtUploadResult;
        private DevExpress.XtraEditors.TextEdit TxtUploadUrl;
        private DevExpress.XtraWaitForm.ProgressPanel PrgUpload;
        private DevExpress.XtraEditors.GroupControl GrbUsers;
        private DevExpress.XtraEditors.ComboBoxEdit cobUserName;
        private DevExpress.XtraEditors.LabelControl labelControl8;







    }
}