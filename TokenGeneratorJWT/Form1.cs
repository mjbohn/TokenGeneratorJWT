using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;



namespace TokenGeneratorJWT
{
    public partial class Form1 : Form
    {
        private int expires = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxJwtToken.Focus();
        }

        private void buttonBuildToken_Click(object sender, EventArgs e)
        {
            textBoxJwtToken.Clear();

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(textBoxSecurityKey.Text));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, textBoxUserId.Text),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var token = new JwtSecurityToken(
                issuer: textBoxIssuer.Text,
                audience: textBoxAudience.Text,
                claims: claims,
                expires: expires > 0 ? DateTime.Now.AddMinutes(expires) : null,
                signingCredentials: credentials);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            
            string PayloadJSON = token.Payload.SerializeToJson();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(tokenString);
            sb.AppendLine("");
            sb.AppendLine(PayloadJSON);
           
            textBoxJwtToken.Text = sb.ToString();

        }

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

        private void ShowKeylength(TextBox tb)
        {
            textBoxKeyLength.Text = (tb.Text.Length * 8).ToString() + " bit";
        }

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
    }
}
