namespace TokenGeneratorJWT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelSecKey = new Label();
            textBoxSecurityKey = new TextBox();
            buttonBuildToken = new Button();
            textBoxUserId = new TextBox();
            labelSub = new Label();
            labelIss = new Label();
            textBoxIssuer = new TextBox();
            labelAud = new Label();
            textBoxAudience = new TextBox();
            textBoxJwtToken = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            copyBothToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            labelKeyInfo = new Label();
            textBoxKeyLength = new TextBox();
            labelExp = new Label();
            textBoxExpires = new TextBox();
            groupBox1 = new GroupBox();
            buttonAddClaim = new Button();
            flowLayoutPanelClaims = new FlowLayoutPanel();
            claimsControl2 = new ClaimsControl();
            menuStripMainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            buildTokenToolStripMenuItem = new ToolStripMenuItem();
            addClaimToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            keyEncToolStripMenuItem = new ToolStripMenuItem();
            MenuHamacSha256 = new ToolStripMenuItem();
            MenuHamacSha384 = new ToolStripMenuItem();
            MenuHamacSha512 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            StatusLabelSecurityAlgorithm = new ToolStripStatusLabel();
            StatusLabelVersion = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanelClaims.SuspendLayout();
            menuStripMainMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSecKey
            // 
            labelSecKey.AutoSize = true;
            labelSecKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSecKey.Location = new Point(17, 28);
            labelSecKey.Name = "labelSecKey";
            labelSecKey.Size = new Size(80, 15);
            labelSecKey.TabIndex = 0;
            labelSecKey.Text = "Security Key:";
            // 
            // textBoxSecurityKey
            // 
            textBoxSecurityKey.Location = new Point(109, 25);
            textBoxSecurityKey.Name = "textBoxSecurityKey";
            textBoxSecurityKey.Size = new Size(211, 23);
            textBoxSecurityKey.TabIndex = 1;
            textBoxSecurityKey.TextChanged += textBoxSecurityKey_TextChanged;
            textBoxSecurityKey.Enter += textBoxSecurityKey_Enter;
            textBoxSecurityKey.Validating += textBoxSecurityKey_Validating;
            // 
            // buttonBuildToken
            // 
            buttonBuildToken.Enabled = false;
            buttonBuildToken.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            buttonBuildToken.Location = new Point(12, 293);
            buttonBuildToken.Name = "buttonBuildToken";
            buttonBuildToken.Size = new Size(192, 23);
            buttonBuildToken.TabIndex = 6;
            buttonBuildToken.Text = "build token (F5)";
            buttonBuildToken.UseVisualStyleBackColor = true;
            buttonBuildToken.Click += buttonBuildToken_Click;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(99, 25);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(100, 23);
            textBoxUserId.TabIndex = 2;
            textBoxUserId.MouseClick += textBoxMouseClick;
            textBoxUserId.Enter += textBoxEnter;
            // 
            // labelSub
            // 
            labelSub.AutoSize = true;
            labelSub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSub.Location = new Point(7, 28);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(52, 15);
            labelSub.TabIndex = 5;
            labelSub.Text = "Subject:";
            // 
            // labelIss
            // 
            labelIss.AutoSize = true;
            labelIss.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIss.Location = new Point(7, 57);
            labelIss.Name = "labelIss";
            labelIss.Size = new Size(43, 15);
            labelIss.TabIndex = 7;
            labelIss.Text = "Issuer:";
            // 
            // textBoxIssuer
            // 
            textBoxIssuer.Location = new Point(99, 54);
            textBoxIssuer.Name = "textBoxIssuer";
            textBoxIssuer.Size = new Size(100, 23);
            textBoxIssuer.TabIndex = 3;
            textBoxIssuer.MouseClick += textBoxMouseClick;
            textBoxIssuer.Enter += textBoxEnter;
            // 
            // labelAud
            // 
            labelAud.AutoSize = true;
            labelAud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAud.Location = new Point(7, 86);
            labelAud.Name = "labelAud";
            labelAud.Size = new Size(62, 15);
            labelAud.TabIndex = 9;
            labelAud.Text = "Audience:";
            // 
            // textBoxAudience
            // 
            textBoxAudience.Location = new Point(99, 83);
            textBoxAudience.Name = "textBoxAudience";
            textBoxAudience.Size = new Size(100, 23);
            textBoxAudience.TabIndex = 4;
            textBoxAudience.MouseClick += textBoxMouseClick;
            textBoxAudience.Enter += textBoxEnter;
            // 
            // textBoxJwtToken
            // 
            textBoxJwtToken.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxJwtToken.ContextMenuStrip = contextMenuStrip1;
            textBoxJwtToken.Location = new Point(12, 322);
            textBoxJwtToken.Multiline = true;
            textBoxJwtToken.Name = "textBoxJwtToken";
            textBoxJwtToken.ReadOnly = true;
            textBoxJwtToken.ScrollBars = ScrollBars.Both;
            textBoxJwtToken.Size = new Size(580, 219);
            textBoxJwtToken.TabIndex = 0;
            textBoxJwtToken.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripSeparator1, toolStripMenuItem1, toolStripMenuItem2, copyBothToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 100);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 22);
            toolStripTextBox1.Text = "Copy to clipboard";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(160, 22);
            toolStripMenuItem1.Text = "copy token";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(160, 22);
            toolStripMenuItem2.Text = "copy JSON";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // copyBothToolStripMenuItem
            // 
            copyBothToolStripMenuItem.Name = "copyBothToolStripMenuItem";
            copyBothToolStripMenuItem.Size = new Size(160, 22);
            copyBothToolStripMenuItem.Text = "copy both";
            copyBothToolStripMenuItem.Click += copyBothToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // labelKeyInfo
            // 
            labelKeyInfo.AutoSize = true;
            labelKeyInfo.Font = new Font("Segoe UI", 7F);
            labelKeyInfo.Location = new Point(109, 51);
            labelKeyInfo.Name = "labelKeyInfo";
            labelKeyInfo.Size = new Size(154, 12);
            labelKeyInfo.TabIndex = 3;
            labelKeyInfo.Text = "Key must be >= 256 bits (32 char)";
            // 
            // textBoxKeyLength
            // 
            textBoxKeyLength.Location = new Point(340, 25);
            textBoxKeyLength.Name = "textBoxKeyLength";
            textBoxKeyLength.ReadOnly = true;
            textBoxKeyLength.Size = new Size(41, 23);
            textBoxKeyLength.TabIndex = 0;
            textBoxKeyLength.TabStop = false;
            // 
            // labelExp
            // 
            labelExp.AutoSize = true;
            labelExp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelExp.Location = new Point(7, 115);
            labelExp.Name = "labelExp";
            labelExp.Size = new Size(82, 15);
            labelExp.TabIndex = 14;
            labelExp.Text = "Expires (min):";
            // 
            // textBoxExpires
            // 
            textBoxExpires.Location = new Point(99, 112);
            textBoxExpires.Name = "textBoxExpires";
            textBoxExpires.Size = new Size(100, 23);
            textBoxExpires.TabIndex = 5;
            textBoxExpires.Text = "0";
            textBoxExpires.MouseClick += textBoxMouseClick;
            textBoxExpires.Enter += textBoxEnter;
            textBoxExpires.Validating += textBoxExpires_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddClaim);
            groupBox1.Controls.Add(flowLayoutPanelClaims);
            groupBox1.Controls.Add(textBoxIssuer);
            groupBox1.Controls.Add(textBoxUserId);
            groupBox1.Controls.Add(textBoxExpires);
            groupBox1.Controls.Add(labelSub);
            groupBox1.Controls.Add(labelExp);
            groupBox1.Controls.Add(labelIss);
            groupBox1.Controls.Add(textBoxAudience);
            groupBox1.Controls.Add(labelAud);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 221);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Claims";
            // 
            // buttonAddClaim
            // 
            buttonAddClaim.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            buttonAddClaim.Location = new Point(14, 151);
            buttonAddClaim.Name = "buttonAddClaim";
            buttonAddClaim.Size = new Size(185, 20);
            buttonAddClaim.TabIndex = 16;
            buttonAddClaim.Text = "add claim (F2)";
            buttonAddClaim.UseVisualStyleBackColor = true;
            buttonAddClaim.Click += buttonAddClaim_Click;
            // 
            // flowLayoutPanelClaims
            // 
            flowLayoutPanelClaims.AutoScroll = true;
            flowLayoutPanelClaims.Controls.Add(claimsControl2);
            flowLayoutPanelClaims.Location = new Point(216, 18);
            flowLayoutPanelClaims.Name = "flowLayoutPanelClaims";
            flowLayoutPanelClaims.Size = new Size(277, 188);
            flowLayoutPanelClaims.TabIndex = 15;
            // 
            // claimsControl2
            // 
            claimsControl2.Location = new Point(3, 3);
            claimsControl2.Name = "claimsControl2";
            claimsControl2.Size = new Size(247, 31);
            claimsControl2.TabIndex = 1;
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, keyEncToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(604, 24);
            menuStripMainMenu.TabIndex = 16;
            menuStripMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buildTokenToolStripMenuItem, addClaimToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // buildTokenToolStripMenuItem
            // 
            buildTokenToolStripMenuItem.Enabled = false;
            buildTokenToolStripMenuItem.Name = "buildTokenToolStripMenuItem";
            buildTokenToolStripMenuItem.ShortcutKeys = Keys.F5;
            buildTokenToolStripMenuItem.Size = new Size(153, 22);
            buildTokenToolStripMenuItem.Text = "&Build token";
            buildTokenToolStripMenuItem.Click += buildTokenToolStripMenuItem_Click;
            // 
            // addClaimToolStripMenuItem
            // 
            addClaimToolStripMenuItem.Name = "addClaimToolStripMenuItem";
            addClaimToolStripMenuItem.ShortcutKeys = Keys.F2;
            addClaimToolStripMenuItem.Size = new Size(153, 22);
            addClaimToolStripMenuItem.Text = "&Add claim";
            addClaimToolStripMenuItem.Click += addClaimToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(153, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // keyEncToolStripMenuItem
            // 
            keyEncToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuHamacSha256, MenuHamacSha384, MenuHamacSha512 });
            keyEncToolStripMenuItem.Name = "keyEncToolStripMenuItem";
            keyEncToolStripMenuItem.Size = new Size(57, 20);
            keyEncToolStripMenuItem.Text = "KeyEnc";
            // 
            // MenuHamacSha256
            // 
            MenuHamacSha256.Name = "MenuHamacSha256";
            MenuHamacSha256.Size = new Size(167, 22);
            MenuHamacSha256.Text = "HAMAC SHA-256";
            MenuHamacSha256.Click += SetEncryptionAlgorithm;
            // 
            // MenuHamacSha384
            // 
            MenuHamacSha384.Name = "MenuHamacSha384";
            MenuHamacSha384.Size = new Size(167, 22);
            MenuHamacSha384.Text = "HAMAC SHA-384";
            MenuHamacSha384.Click += SetEncryptionAlgorithm;
            // 
            // MenuHamacSha512
            // 
            MenuHamacSha512.Name = "MenuHamacSha512";
            MenuHamacSha512.Size = new Size(167, 22);
            MenuHamacSha512.Text = "HAMAC SHA-512";
            MenuHamacSha512.Click += SetEncryptionAlgorithm;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabelSecurityAlgorithm, toolStripStatusLabel1, StatusLabelVersion });
            statusStrip1.Location = new Point(0, 544);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(604, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelSecurityAlgorithm
            // 
            StatusLabelSecurityAlgorithm.Name = "StatusLabelSecurityAlgorithm";
            StatusLabelSecurityAlgorithm.Size = new Size(0, 17);
            // 
            // StatusLabelVersion
            // 
            StatusLabelVersion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            StatusLabelVersion.Name = "StatusLabelVersion";
            StatusLabelVersion.Size = new Size(45, 17);
            StatusLabelVersion.Text = "version";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(513, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CausesValidation = false;
            ClientSize = new Size(604, 566);
            Controls.Add(statusStrip1);
            Controls.Add(menuStripMainMenu);
            Controls.Add(groupBox1);
            Controls.Add(textBoxSecurityKey);
            Controls.Add(textBoxKeyLength);
            Controls.Add(labelSecKey);
            Controls.Add(textBoxJwtToken);
            Controls.Add(labelKeyInfo);
            Controls.Add(buttonBuildToken);
            MainMenuStrip = menuStripMainMenu;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JWT Generator";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanelClaims.ResumeLayout(false);
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecKey;
        private TextBox textBoxSecurityKey;
        private Button buttonBuildToken;
        private TextBox textBoxUserId;
        private Label labelSub;
        private Label labelIss;
        private TextBox textBoxIssuer;
        private Label labelAud;
        private TextBox textBoxAudience;
        private TextBox textBoxJwtToken;
        private ErrorProvider errorProvider1;
        private Label labelKeyInfo;
        private TextBox textBoxKeyLength;
        private Label labelExp;
        private TextBox textBoxExpires;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem copyBothToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanelClaims;
        private Button buttonAddClaim;
        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem buildTokenToolStripMenuItem;
        private ToolStripMenuItem addClaimToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ClaimsControl claimsControl2;
        private ToolStripMenuItem keyEncToolStripMenuItem;
        private ToolStripMenuItem MenuHamacSha256;
        private ToolStripMenuItem MenuHamacSha384;
        private ToolStripMenuItem MenuHamacSha512;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabelSecurityAlgorithm;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StatusLabelVersion;
    }
}
