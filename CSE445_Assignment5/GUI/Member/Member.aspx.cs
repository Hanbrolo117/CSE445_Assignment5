using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace CSE445_Assignment5.GUI.Member
{
    public partial class Member : System.Web.UI.Page
    {

        StringBuilder table = new StringBuilder();


        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie access Control:
            //------------------------------------------------
            if (Request.Cookies["member"] == null) {
                Response.Redirect("MemberLogin.aspx");
            }
            //------------------------------------------------
        }


        //Weather Service Web Service use!
        //------------------------------------------------
        protected void get_local_weather_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherServiceClient weatherService = new WeatherService.WeatherServiceClient();
            if (this.location_input.Text != "")
            {
                WeatherService.Conditions todays_condish = weatherService.getCurrentCondition(this.location_input.Text);
                if (todays_condish != null)
                {
                    WeatherService.Conditions[] forcast = weatherService.getForeCast(this.location_input.Text);
                    //Setup data view for today's current condition and temp:
                    this.location_output.Text = this.location_input.Text;
                    this.condition_output.Text = todays_condish.Condition;
                    this.current_temp_output.Text = todays_condish.TempF;

                    //Setup data view for the 10 day forcast:
                    table.Append("<table border='1'>");

                    //Setup forcast day headers:
                    table.Append("<tr>");
                    foreach (WeatherService.Conditions condish in forcast)
                    {
                        table.Append(string.Format("<th style=\"widthL 250px; text-algin: center;\">{0} <br /> [{1}]", condish.DayOfWeek, condish.Date));
                    }
                    table.Append("</tr>");
                    table.Append("<tr>");
                    int id = 0;
                    foreach (WeatherService.Conditions condish in forcast)
                    {
                        table.Append("<td style=\"width: 250px; height: 100px;\">");
                        table.Append(string.Format("<p ID=\"condition{0}\" runat=\"server\" style=\"margin - bottom:10px; margin - top:20px; padding - right:50px; \">Expected Condition: {1}</p>", id, condish.Condition));
                        table.Append("<br />");
                        table.Append(string.Format("<p ID=\"temp{0}\" runat=\"server\" style=\"margin - bottom:10px; margin - top:20px; padding - right:50px; \">Expected Temp: {1}</p>", id, condish.TempF));
                        table.Append("<br />");
                        table.Append(string.Format("<p ID=\"high{0}\" runat=\"server\" style=\"margin - bottom:10px; margin - top:20px; padding - right:50px; \">Expected High: {1}</p>", id, condish.High));
                        table.Append("<br />");
                        table.Append(string.Format("<p ID=\"low{0}\" runat=\"server\" style=\"margin - bottom:10px; margin - top:20px; padding - right:50px; \">Expected Low: {1}</p>", id, condish.Low));
                        table.Append("<br />");
                        table.Append("</td>");
                        //Increment identifier:
                        id += 1;
                    }
                    table.Append("</tr>");
                    table.Append("</table>");
                    forecast_place_holder.Controls.Add(new Literal { Text = table.ToString() });
                }
                else
                {//Not found
                    this.location_output.Text = "Location Not Found.";
                    this.condition_output.Text = "Not Defined.";
                    this.current_temp_output.Text = "Not Defined.";
                }
            }
        }


        protected void ProcessButton_Click(object sender, EventArgs e)  //Processes Alt Fuel Service Request
        {
            AltFuelService.Service1Client altfuel = new AltFuelService.Service1Client();
            StationsTextBox.Text = altfuel.ProcessResponse(CityTextBox.Text, StateTextBox.Text);

        }
    }
}