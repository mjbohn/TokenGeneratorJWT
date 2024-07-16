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
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            label6 = new Label();
            fontDialog1 = new FontDialog();
            textBoxKeyLength = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            buttonBuildToken.Location = new Point(234, 178);
            buttonBuildToken.Name = "buttonBuildToken";
            buttonBuildToken.Size = new Size(75, 23);
            buttonBuildToken.TabIndex = 2;
            buttonBuildToken.Text = "build token";
            buttonBuildToken.UseVisualStyleBackColor = true;
            buttonBuildToken.Click += buttonBuildToken_Click;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(109, 103);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(100, 23);
            textBoxUserId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Claim User-ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 152);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Issuer:";
            // 
            // textBoxIssuer
            // 
            textBoxIssuer.Location = new Point(109, 149);
            textBoxIssuer.Name = "textBoxIssuer";
            textBoxIssuer.Size = new Size(100, 23);
            textBoxIssuer.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(17, 181);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Audience:";
            // 
            // textBoxAudience
            // 
            textBoxAudience.Location = new Point(109, 178);
            textBoxAudience.Name = "textBoxAudience";
            textBoxAudience.Size = new Size(100, 23);
            textBoxAudience.TabIndex = 8;
            // 
            // textBoxJwtToken
            // 
            textBoxJwtToken.Location = new Point(12, 238);
            textBoxJwtToken.Multiline = true;
            textBoxJwtToken.Name = "textBoxJwtToken";
            textBoxJwtToken.ReadOnly = true;
            textBoxJwtToken.Size = new Size(510, 69);
            textBoxJwtToken.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 76);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 11;
            label5.Text = "Key-Length: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(109, 51);
            label6.Name = "label6";
            label6.Size = new Size(147, 12);
            label6.TabIndex = 12;
            label6.Text = "Key must have 256 bits (32 char)";
            // 
            // textBoxKeyLength
            // 
            textBoxKeyLength.Location = new Point(176, 73);
            textBoxKeyLength.Name = "textBoxKeyLength";
            textBoxKeyLength.ReadOnly = true;
            textBoxKeyLength.Size = new Size(41, 23);
            textBoxKeyLength.TabIndex = 13;
            textBoxKeyLength.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CausesValidation = false;
            ClientSize = new Size(534, 350);
            Controls.Add(textBoxSecurityKey);
            Controls.Add(textBoxKeyLength);
            Controls.Add(label1);
            Controls.Add(textBoxJwtToken);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBoxAudience);
            Controls.Add(label2);
            Controls.Add(textBoxIssuer);
            Controls.Add(label3);
            Controls.Add(textBoxUserId);
            Controls.Add(buttonBuildToken);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JWT Generator";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Label label5;
        private Label label6;
        private FontDialog fontDialog1;
        private TextBox textBoxKeyLength;
    }
}
