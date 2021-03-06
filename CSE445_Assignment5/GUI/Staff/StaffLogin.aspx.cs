﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using TeamLibrary;

namespace CSE445_Assignment5.GUI
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie access Control
            //------------------------------------------------
            if (Request.Cookies["staffMember"] != null)
            {
                Response.Redirect("Staff");
            }
            if (Request.Cookies["member"] != null)
            {
                Response.Redirect("~/GUI/Member/Member");
            }
            //------------------------------------------------

            //Login Component Subscription:
            //------------------------------------------------
            this.signIn.subscribeToLoginButton(this.LoginHandler);
            this.signIn.subscribeToRegisterButton(this.RegisterHandler);
            //------------------------------------------------
        }


        //Login Component (Signin) Event Handler:
        //------------------------------------------------
        public void LoginHandler(string username, string password, EventArgs e)
        {
            //TODO:: ENCRYPT PASSWORD BEFORE COMPARISON

            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\Staff.xml");
            XmlNode node = XMLProccess.findUser(fLocation, username);
            if(!username.Equals("Admin"))
            {
                password = Crypto.encryption(password);
            }
            if (node == null)
            {
                alert.Text = "User does not exist";
            }
            else if (string.Compare(node["password"].InnerText, password) != 0)
            {
                alert.Text = "wrong Password";
            }
            else
            {
                //Create A login Cookie for managing the session:
                HttpCookie loginCookie;
                if (username.Equals("Admin"))
                {
                    loginCookie = new HttpCookie("admin");//Create Staff Cookie.
                }
                else
                    loginCookie = new HttpCookie("staffMember");

                loginCookie["username"] = username;//Set Staff Cookie username.
                loginCookie.Expires = DateTime.Now.AddMonths(1);//Set Cookie Expiration for 1 month.
                Response.Cookies.Add(loginCookie);

                alert.Text = "Login Sucess!";
                Response.Redirect("Staff");
            }
        }

        //Login Component (Register) Event Handler:
        //------------------------------------------------
        public void RegisterHandler(string username, string password, EventArgs e)
        {
            if (Request.Cookies["admin"] != null)
                Response.Redirect("StaffRegister");
            else
                alert.Text = "Only Admin can add new staff!";
        }
    }
}