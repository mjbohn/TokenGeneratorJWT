using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace TokenGeneratorJWT
{
    public partial class Form1 : Form
    {
        private int expires = 0;
        private string TokenString;
        private string PayloadJSON;
        private int MinKeyLength = 256;

        private string SecurityAlgorithm = SecurityAlgorithms.HmacSha256;

        public Form1()
        {
            InitializeComponent();
            SetParamsForKeyAlgorithm(SecurityAlgorithm, MinKeyLength);
            StatusLabelVersion.Text = GetVersion();
        }

        private void buttonBuildToken_Click(object sender, EventArgs e)
        {
            textBoxJwtToken.Clear();
            SymmetricSecurityKey securityKey = null;

            try
            {
                securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(textBoxSecurityKey.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithm);

            var claims = new List<Claim>()
            {
            new Claim(JwtRegisteredClaimNames.Sub, textBoxUserId.Text),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString())
            };

            // add custom claims
            foreach (Control control in flowLayoutPanelClaims.Controls)
            {
                if (control.GetType().Equals(typeof(ClaimsControl)))
                {
                    ClaimsControl ctrl = (ClaimsControl)control;
                    if (!string.IsNullOrEmpty(ctrl.textBoxClaim.Text))
                    {
                        claims.Add(new Claim(ctrl.textBoxClaim.Text, ctrl.textBoxValue.Text));
                    }
                }
            }


            var token = new JwtSecurityToken(
                issuer: textBoxIssuer.Text,
                audience: textBoxAudience.Text,
                claims: claims.ToArray(),
                expires: expires > 0 ? DateTime.Now.AddMinutes(expires) : null,
                //notBefore: DateTime.Now, 

                signingCredentials: credentials);


            try
            {
                TokenString = new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PayloadJSON = JsonNode.Parse(token.Payload.SerializeToJson()).ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TokenString);
            sb.AppendLine("");
            sb.AppendLine(PayloadJSON);

            textBoxJwtToken.Text = sb.ToString();

        }

        private void buttonAddClaim_Click(object sender, EventArgs e)
        {
            ClaimsControl cc = new ClaimsControl();
            flowLayoutPanelClaims.Controls.Add(cc);
        }

        #region TextBoxValidations
        private void textBoxSecurityKey_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text.Length < MinKeyLength / 8)
            {
                errorProvider1.SetError(textBoxSecurityKey, $"Key must be >= {MinKeyLength} bits ({MinKeyLength / 8} char)");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                //buttonBuildToken.Enabled = true;
            }

            buttonBuildToken.Enabled = (tb.TextLength >= MinKeyLength / 8);
            buildTokenToolStripMenuItem.Enabled = (tb.TextLength >= MinKeyLength / 8);

            ShowKeylength(tb);
        }
        private void textBoxExpires_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!int.TryParse(tb.Text, out this.expires))
            {
                //textBoxExpires.SelectAll();
                e.Cancel = true;
                if (MessageBox.Show("Expires must be INT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    tb.Focus();
                    tb.SelectAll();
                }

            }

        }

        #endregion // TextBoxValidations

        #region TextBoxEvents
        private void textBoxSecurityKey_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            ShowKeylength(tb);
        }
        private void textBoxSecurityKey_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            ShowKeylength(tb);
        }
        private void textBoxEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        private void textBoxMouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        #endregion // TextBoxEvents

        #region ContextMenuTextBox
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TokenString))
            {
                Clipboard.SetText(TokenString);
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PayloadJSON))
            {
                Clipboard.SetText(PayloadJSON);
            }
        }

        private void copyBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxJwtToken.Text))
            {
                Clipboard.SetText(textBoxJwtToken.Text);
            }
        }

        #endregion // ContextMenuTextBox

        #region MenuEvents
        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAddClaim_Click(this, EventArgs.Empty);
        }

        private void buildTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonBuildToken_Click(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion // MenuEvents

        #region Helper
        private void ShowKeylength(TextBox tb)
        {
            textBoxKeyLength.Text = (tb.Text.Length * 8).ToString() + " bit";
        }

        private void SetInfoLabel()
        {
            labelKeyInfo.Text = string.Format("Key must be >= {0} bits ({1} char)", MinKeyLength, MinKeyLength / 8);
        }

        private void SetParamsForKeyAlgorithm(string securityAlgorithm, int minKeyLength)
        {
            SecurityAlgorithm = securityAlgorithm;
            //MessageBox.Show("Algorithm set to " + securityAlgorithm, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MinKeyLength = minKeyLength;
            SetInfoLabel();
            StatusLabelSecurityAlgorithm.Text = securityAlgorithm;
        }

        private void SetEncryptionAlgorithm(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            switch (menuItem.Name)
            {
                case "MenuHamacSha256":
                    SetParamsForKeyAlgorithm(SecurityAlgorithms.HmacSha256, 256);
                    break;
                case "MenuHamacSha384":
                    SetParamsForKeyAlgorithm(SecurityAlgorithms.HmacSha384, 384);
                    break;
                case "MenuHamacSha512":
                    SetParamsForKeyAlgorithm(SecurityAlgorithms.HmacSha512, 512);
                    break;
                default:
                    break;
            }
        }
        
        private string GetVersion()
        { 
            return $"v{Assembly.GetEntryAssembly().GetName().Version.Major}" +
                   $".{Assembly.GetEntryAssembly().GetName().Version.Minor}" +
                   $".{Assembly.GetEntryAssembly().GetName().Version.Build}";
        }
        #endregion //helper
    }
}
