namespace TokenGeneratorJWT
{
    partial class ClaimsControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimsControl));
            textBoxClaim = new TextBox();
            textBoxValue = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxClaim
            // 
            textBoxClaim.Location = new Point(3, 3);
            textBoxClaim.Name = "textBoxClaim";
            textBoxClaim.PlaceholderText = "claim";
            textBoxClaim.Size = new Size(100, 23);
            textBoxClaim.TabIndex = 2;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(109, 3);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.PlaceholderText = "value";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(215, 2);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClaimsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxClaim);
            Name = "ClaimsControl";
            Size = new Size(247, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxClaim;
        public TextBox textBoxValue;
        private Button button1;
    }
}
