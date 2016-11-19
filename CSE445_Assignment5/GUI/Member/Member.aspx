<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CSE445_Assignment5.GUI.Member.Member" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" id="weather_service" style="margin-top:50px;">
        <div class="col-md-6" style="top: 3px; left: -8px; height: 100%; margin-bottom:100px;">   
            <h4 ID="h3" runat="server" style="margin-bottom:10px; padding-right:50px;">TRY-IT Links for Web Services:<a href="http://webstrar26.fulton.asu.edu/">http://webstrar26.fulton.asu.edu/</a></h4>

            <h2 ID="h1" runat="server" Text="Weather Services" style="margin-bottom:10px; padding-right:50px;">Weather Services</h2>
            <br />
            <h5 ID="weather_service_link" runat="server" style="margin-bottom:10px; padding-right:50px;">Service link:<a href="http://webstrar26.fulton.asu.edu/page0/WeatherService.svc">http://webstrar26.fulton.asu.edu/page0/WeatherService.svc</a></h5>
            <br />            
            <hr />
            <br />
            <h4 ID="H2" runat="server" Text="Local Weather" style="margin-bottom:10px; margin-top:20px; padding-right:50px;">Local Weather</h4>
            <br />  
            <h5 ID="forecast_descript" runat="server" style="margin-bottom:10px; padding-right:50px;">Takes in a location name or address and returns current Weather conditions as well as the 10 day forecast starting from the current day.</h5>
            <br />
            <h5 ID="current_conditions_method_signature" runat="server" style="margin-bottom:10px; padding-right:50px;">Conditions getCurrentCondition(String location)</h5>
            <br />   
            <h5 ID="forecast_method_signature" runat="server" style="margin-bottom:10px; padding-right:50px;">List&lt;Condition&gt; getForeCast(String location)</h5>
            <br />   
            <asp:Label ID="location_input_label" runat="server" Text="Enter Location:" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <asp:TextBox ID="location_input" runat="server" style="margin-top:15px;"></asp:TextBox>
            <br />  
            <asp:Button ID="get_local_weather" runat="server" Text="Get location Weather" style="margin-bottom:10px; margin-top:20px; padding-right:50px;" OnClick="get_local_weather_Click" />            
            <hr />
            <asp:Label ID="Location_output_label" runat="server" Text="Current Location:" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <asp:Label ID="location_output" runat="server" Text="Not Defined" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <br />
            <asp:Label ID="condition_output_label" runat="server" Text="Current Condition:" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <asp:Label ID="condition_output" runat="server" Text="Not Defined" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <br />
            <asp:Label ID="current_temp_output_label" runat="server" Text="Current Temp:" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <asp:Label ID="current_temp_output" runat="server" Text="Not Defined" style="margin-bottom:10px; margin-top:20px; padding-right:50px;"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="F"></asp:Label>


            <br />
            <asp:PlaceHolder ID="forecast_place_holder" runat="server"></asp:PlaceHolder>
        </div>

    </div>

</asp:Content>
