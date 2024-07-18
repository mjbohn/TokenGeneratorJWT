using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace TokenGeneratorJWT
{
    public partial class Form1 : Form
    {
        private int expires = 0;
        private string TokenString { get; set; }
        private string PayloadJSON { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuildToken_Click(object sender, EventArgs e)
        {
            textBoxJwtToken.Clear();

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(textBoxSecurityKey.Text));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

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


            TokenString = new JwtSecurityTokenHandler().WriteToken(token);

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

            if (tb.Text.Length < 32)
            {
                errorProvider1.SetError(textBoxSecurityKey, "Key must be >= 256 bits (32 char)");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                buttonBuildToken.Enabled = true;
            }

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
        #endregion

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
        #endregion

        private void ShowKeylength(TextBox tb)
        {
            textBoxKeyLength.Text = (tb.Text.Length * 8).ToString() + " bit";
        }

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
        #endregion



    }
}
