using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.signIn.subscribeToLoginButton(this.LoginHandler);
            this.signIn.subscribeToRegisterButton(this.RegisterHandler);
        }
        public void LoginHandler(string username, string password, EventArgs e)
        {
            this.lor.Text = string.Format("Logged in! username: {0} | password: {1}", username, password);
            CryptionLibrary.Crypto encrypt = new CryptionLibrary.Crypto();
            string cipertext = CryptionLibrary.Crypto.encryption(password);
            string plaintext = CryptionLibrary.Crypto.decryption(cipertext);
            this.cryptTest.Text = string.Format("Encrypted Password: {0} | Decrypted Password: {1}", cipertext, plaintext);
        }

        public void RegisterHandler(string username, string password, EventArgs e)
        {
            this.lor.Text = string.Format("Registering! username: {0} | password: {1}", username, password);
        }
    }
}