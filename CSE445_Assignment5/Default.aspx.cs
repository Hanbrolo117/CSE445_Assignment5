﻿using System;
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

        }

        //Member Page Button:
        //------------------------------------------------
        protected void member_button_Click(object sender, EventArgs e)
        {
            if ((Session["username"] != null) && (Session["password"] != null))
            {
                Response.Redirect("GUI/Member/Member");
            }
            else
            {
                Response.Redirect("GUI/Member/MemberLogin");
            }
        }

        //Staff Page Button:
        //------------------------------------------------
        protected void staff_button_Click(object sender, EventArgs e)
        {
            if ((Session["username"] != null) && (Session["password"] != null))
            {
                Response.Redirect("GUI/Staff/Staff");
            }
            else {
                Response.Redirect("GUI/Staff/StaffLogin");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUI/CryptionTryIt");
        }
    }
}