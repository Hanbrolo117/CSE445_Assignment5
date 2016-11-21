using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using TeamLibrary;

namespace CSE445_Assignment5.GUI.Staff
{
    public partial class StaffRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie access Control:
            //------------------------------------------------
            if (Request.Cookies["staffMember"] != null)
            {
                Response.Redirect("Staff");
            }
            if (Request.Cookies["member"] != null) {
                Response.Redirect("~/GUI/Member/Member");
            }
            //------------------------------------------------


            //Rgister component subscription:
            //------------------------------------------------
            this.Register.subscribeToRegisterButton(this.RegisterHandler);
            //------------------------------------------------
        }

        //Register Component Register Handler:
        //------------------------------------------------
        public void RegisterHandler(string username, string password, string confirmPassword, EventArgs e)
        {
            if (password.Equals(confirmPassword))
            {
                string encryptedPassword = TeamLibrary.Crypto.encryption(password);
                //Insert New User:
                string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\Staff.xml");

                if (XMLProccess.findUser(fLocation, username) == null)
                {
                    XMLProccess.addUser(fLocation, username, encryptedPassword);
                    //Create A login Cookie for managing the session:
                    HttpCookie loginCookie = new HttpCookie("staffMember");//Create Staff Cookie.
                    loginCookie["username"] = username;//Set Staff Cookie username.
                    loginCookie.Expires = DateTime.Now.AddMonths(1);//Set Cookie Expiration for 1 month.
                    Response.Cookies.Add(loginCookie);

                    alert.Text = "Login Sucess!";
                    Response.Redirect("Staff");
                }
                else
                    alert.Text = "Username already exist";
            }
            else
            {
                alert.Text = "Passwords did not match!";
            }
        }
    }
}