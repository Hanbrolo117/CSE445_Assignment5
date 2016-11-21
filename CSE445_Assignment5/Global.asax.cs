using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CSE445_Assignment5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Keep track of how many users have accessed a session
            Application["userCount"] = 0; //Initialize to 0
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Add 1 to usercount due to new session being started
            Application["userCount"] = Convert.ToInt32(Application["userCount"]) + 1;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Subtract 1 to usercount due to a session being closed
            Application["userCount"] = Convert.ToInt32(Application["userCount"]) - 1;
        }
    }
}