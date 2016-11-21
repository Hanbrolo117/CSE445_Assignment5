using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5.GUI.Member
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie access Control:
            //------------------------------------------------
            if (Request.Cookies["member"] != null)
            {
                Response.Redirect("Member.aspx");
            }
            //------------------------------------------------

            //Register Component Subscription:
            //------------------------------------------------
            this.Register.subscribeToRegisterButton(this.RegisterHandler);
            //------------------------------------------------
        }

        //Register Component Event Handler:
        //------------------------------------------------
        public void RegisterHandler(string username, string password, string confirmPassword, EventArgs e) {
            if (password.Equals(confirmPassword))
            {
                string encryptedPassword = TeamLibrary.Crypto.encryption(password);
                //Insert New User:
                //Create A login Cookie for managing the session:
                HttpCookie loginCookie = new HttpCookie("member");//Create Staff Cookie.
                loginCookie["username"] = username;//Set Staff Cookie username.
                loginCookie.Expires = DateTime.Now.AddMonths(1);//Set Cookie Expiration for 1 month.
                Response.Cookies.Add(loginCookie);

                alert.Text = "Login Sucess!";
                Response.Redirect("Member");
            }
            else {
                alert.Text = "Passwords did not match!";
            }
        }

    }
}