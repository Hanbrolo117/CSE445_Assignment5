using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["staffMember"] == null)
            {
                Response.Redirect("StaffLogin");
            }

        }

        public void logoutHandler(string memberType, EventArgs e) {
            if (memberType.Equals("staff"))
            {
                Response.Redirect("StaffLogin");
            }
            else if (memberType.Equals("member")) {
                Response.Redirect("~/Member/MemberLogin.aspx");
            }
        }

        protected void btnAddStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffRegister");
        }
    }
}