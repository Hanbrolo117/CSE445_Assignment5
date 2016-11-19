using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Assignment5
{
    public partial class Register : System.Web.UI.UserControl
    {

        public delegate void RegisterEvent(string username, string password, string confirmPassword, EventArgs e);
        public event RegisterEvent register_instance;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void subscribeToRegisterButton(Action<string, string, string, EventArgs> app_handler)
        {
            //Subscribe to a register event:
            this.register_instance += new RegisterEvent(app_handler);
        }

        protected void register_event_Click(object sender, EventArgs e)
        {
            //May have entered in username and password, pass this to event handler and fill register fields with this as a suggestion to save time:
            string username = "";
            string password = "";
            string passwordConfirm = "";
            if (this.username_input.Text.Length > 0)
            {
                username = this.username_input.Text;
            }
            if (this.password_input.Text.Length > 0)
            {
                password = this.password_input.Text;
            }
            if (this.password_confirm_input.Text.Length > 0)
            {
                passwordConfirm = this.password_confirm_input.Text;
            }

            //Emit Register Event to subscribers:
            this.register_instance(username, password, passwordConfirm, e);
        }
    }
}