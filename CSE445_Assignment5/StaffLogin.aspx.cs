using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using CryptionLibrary;

namespace CSE445_Assignment5
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.signIn.subscribeToLoginButton(this.LoginHandler);
            this.signIn.subscribeToRegisterButton(this.RegisterHandler);
        }

        public void LoginHandler(string username, string password, EventArgs e)
        {
            /*string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\Staff.xml");
            XmlNode node = XMLProccess.findUser(fLocation, username);
            if (node == null)
            {
                alert.Text = "User does not exist";
            }
            else if (string.Compare(node["password"].InnerText, password) != 0)
            {
                alert.Text = "wrong Password";
            }
            else
                alert.Text = "Login Sucess!";  */
        }

        public void RegisterHandler(string username, string password, EventArgs e)
        {
            this.alert.Text = string.Format("Registering! username: {0} | password: {1}", username, password);
        }
    }
}