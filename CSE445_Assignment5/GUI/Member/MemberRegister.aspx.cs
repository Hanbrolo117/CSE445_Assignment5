using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamLibrary;

namespace CSE445_Assignment5.GUI.Member
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["member"] != null)
            {
                Response.Redirect("Member.aspx");
            }
            this.Register.subscribeToRegisterButton(this.RegisterHandler);
        }


        public void RegisterHandler(string username, string password, string confirmPassword, EventArgs e) {
            if (password.Equals(confirmPassword))
            {
                string encryptedPassword = Crypto.encryption(password);
                //Insert New User:
                string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\Member.xml");

                if (XMLProccess.findUser(fLocation, username) == null)
                {
                    XMLProccess.addUser(fLocation, username, encryptedPassword);
                    //Create A login Cookie for managing the session:
                    HttpCookie loginCookie = new HttpCookie("member");//Create Staff Cookie.
                    loginCookie["username"] = username;//Set Staff Cookie username.
                    loginCookie.Expires = DateTime.Now.AddMonths(1);//Set Cookie Expiration for 1 month.
                    Response.Cookies.Add(loginCookie);
                    alert.Text = "Login Sucess!";
                    Response.Redirect("Member");
                }
                else
                    alert.Text = "Username already exists!";
            }
            else {
                alert.Text = "Passwords did not match!";
            }
        }

    }
}