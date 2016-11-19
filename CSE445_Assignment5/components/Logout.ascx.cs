using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5.components
{
    public partial class Logout : System.Web.UI.UserControl
    {
        public delegate void LogoutEvent(string membertype, EventArgs e);
        public event LogoutEvent logout_instance;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.Cookies["staffMember"] == null) && (Request.Cookies["member"] == null))
            {
                this.logout_button.Visible = false;
            }
            else {
                this.logout_button.Visible = true;
            }
        }

        public void subscribeToLogoutButton(Action<string, EventArgs> app_handler)
        {
            //Subscribe to a register event:
            this.logout_instance += new LogoutEvent(app_handler);
        }


        protected void logout_button_Click(object sender, EventArgs e)
        {
            string memberType = "";
            if (Request.Cookies["staffMember"] != null)
            {
                HttpCookie logoutCookie = Request.Cookies["staffMember"];
                logoutCookie.Expires = DateTime.Now.AddMonths(-1);
                Response.Cookies.Add(logoutCookie);
                memberType = "staff";
            }
            else if (Request.Cookies["member"] != null) {
                HttpCookie logoutCookie = Request.Cookies["member"];
                logoutCookie.Expires = DateTime.Now.AddMonths(-1);
                Response.Cookies.Add(logoutCookie);
                memberType = "member";
            }

            this.logout_instance(memberType, e);
        }
    }
}