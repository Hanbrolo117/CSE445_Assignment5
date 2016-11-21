using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using TeamLibrary;

namespace CSE445_Assignment5.GUI.Member
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie access Control:
            //------------------------------------------------
            if (Request.Cookies["member"] != null) {
                Response.Redirect("Member.aspx");
            }
            else if (Request.Cookies["staffMember"] != null)
            {
                Response.Redirect("~/GUI/Staff/Staff");
            }
            //------------------------------------------------


            //Signin Component Subscription:
            //------------------------------------------------
            this.signIn.subscribeToLoginButton(this.LoginHandler);
            this.signIn.subscribeToRegisterButton(this.RegisterHandler);
            //------------------------------------------------
        }

        //Login Component (Register) Event Handler:
        //------------------------------------------------
        public void RegisterHandler(string username, string password, EventArgs e)
        {
            Response.Redirect("MemberRegister");
        }
        //------------------------------------------------


        //Login Component (Signin) Event Handler:
        //------------------------------------------------
        public void LoginHandler(string username, string password, EventArgs e) {
            //ENCRYPT PASSWORD BEFORE COMPARISON
            string encryptedPassword = TeamLibrary.Crypto.encryption(password);

            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\Member.xml");
            XmlNode node = XMLProccess.findUser(fLocation, username);
            if (node == null)
            {
                alert.Text = "User does not exist";
            }
            else if (string.Compare(node["password"].InnerText, encryptedPassword) != 0)
            {
                alert.Text = "wrong Password";
            }
            else
            {
                //Create A login Cookie for managing the session:
                HttpCookie loginCookie = new HttpCookie("member");//Create Member Cookie.
                loginCookie["username"] = username;//Set Member Cookie username.
                loginCookie.Expires = DateTime.Now.AddMonths(1);//Set Cookie Expiration for 1 month.
                Response.Cookies.Add(loginCookie);

                alert.Text = "Login Success!";
                Response.Redirect("Member");
            }
        }

    }
}