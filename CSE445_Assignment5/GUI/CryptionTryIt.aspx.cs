using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5
{
    public partial class CryptionTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void endecrypt_Click(object sender, EventArgs e)
        {
            if (this.plaintext_input.Text.Length > 0)
            {
                this.cipherText.Text = TeamLibrary.Crypto.encryption(this.plaintext_input.Text);//Encrypt user plaintext
                this.plaintext.Text = TeamLibrary.Crypto.decryption(this.cipherText.Text);//Decrypt ciphertext generated from encryption of user plaintext
            }
            else {
                this.cipherText.Text = "ERROR: Enter text to encrypt!";//Warning
            }
        }
    }
}