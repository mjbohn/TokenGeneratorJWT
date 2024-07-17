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
            label1 = new Label();
            textBoxSecurityKey = new TextBox();
            buttonBuildToken = new Button();
            textBoxUserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxIssuer = new TextBox();
            label4 = new Label();
            textBoxAudience = new TextBox();
            textBoxJwtToken = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            copyBothToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            fontDialog1 = new FontDialog();
            textBoxKeyLength = new TextBox();
            label7 = new Label();
            textBoxExpires = new TextBox();
            groupBox1 = new GroupBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Security Key:";
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
            buttonBuildToken.Text = "build token";
            buttonBuildToken.UseVisualStyleBackColor = true;
            buttonBuildToken.Click += buttonBuildToken_Click;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(99, 25);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(100, 23);
            textBoxUserId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(7, 28);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "User-ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Issuer:";
            // 
            // textBoxIssuer
            // 
            textBoxIssuer.Location = new Point(99, 54);
            textBoxIssuer.Name = "textBoxIssuer";
            textBoxIssuer.Size = new Size(100, 23);
            textBoxIssuer.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(7, 86);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Audience:";
            // 
            // textBoxAudience
            // 
            textBoxAudience.Location = new Point(99, 83);
            textBoxAudience.Name = "textBoxAudience";
            textBoxAudience.Size = new Size(100, 23);
            textBoxAudience.TabIndex = 4;
            // 
            // textBoxJwtToken
            // 
            textBoxJwtToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxJwtToken.ContextMenuStrip = contextMenuStrip1;
            textBoxJwtToken.Location = new Point(12, 322);
            textBoxJwtToken.Multiline = true;
            textBoxJwtToken.Name = "textBoxJwtToken";
            textBoxJwtToken.ReadOnly = true;
            textBoxJwtToken.ScrollBars = ScrollBars.Both;
            textBoxJwtToken.Size = new Size(580, 127);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(109, 51);
            label6.Name = "label6";
            label6.Size = new Size(154, 12);
            label6.TabIndex = 3;
            label6.Text = "Key must be >= 256 bits (32 char)";
            // 
            // textBoxKeyLength
            // 
            textBoxKeyLength.Location = new Point(326, 25);
            textBoxKeyLength.Name = "textBoxKeyLength";
            textBoxKeyLength.ReadOnly = true;
            textBoxKeyLength.Size = new Size(41, 23);
            textBoxKeyLength.TabIndex = 0;
            textBoxKeyLength.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(7, 115);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 14;
            label7.Text = "Expires (min):";
            // 
            // textBoxExpires
            // 
            textBoxExpires.Location = new Point(99, 112);
            textBoxExpires.Name = "textBoxExpires";
            textBoxExpires.Size = new Size(100, 23);
            textBoxExpires.TabIndex = 5;
            textBoxExpires.Text = "0";
            textBoxExpires.Validating += textBoxExpires_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxIssuer);
            groupBox1.Controls.Add(textBoxUserId);
            groupBox1.Controls.Add(textBoxExpires);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxAudience);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 221);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Claims";
            // 
            // Form1
            // 
            AcceptButton = buttonBuildToken;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CausesValidation = false;
            ClientSize = new Size(604, 461);
            Controls.Add(groupBox1);
            Controls.Add(textBoxSecurityKey);
            Controls.Add(textBoxKeyLength);
            Controls.Add(label1);
            Controls.Add(textBoxJwtToken);
            Controls.Add(label6);
            Controls.Add(buttonBuildToken);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JWT Generator";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSecurityKey;
        private Button buttonBuildToken;
        private TextBox textBoxUserId;
        private Label label3;
        private Label label2;
        private TextBox textBoxIssuer;
        private Label label4;
        private TextBox textBoxAudience;
        private TextBox textBoxJwtToken;
        private ErrorProvider errorProvider1;
        private Label label6;
        private FontDialog fontDialog1;
        private TextBox textBoxKeyLength;
        private Label label7;
        private TextBox textBoxExpires;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem copyBothToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private GroupBox groupBox1;
    }
}
