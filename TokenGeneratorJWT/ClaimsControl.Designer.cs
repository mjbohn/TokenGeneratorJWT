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
            textBoxClaim = new TextBox();
            textBoxValue = new TextBox();
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
            // ClaimsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxValue);
            Controls.Add(textBoxClaim);
            Name = "ClaimsControl";
            Size = new Size(212, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxClaim;
        public TextBox textBoxValue;
    }
}
