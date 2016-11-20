<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Assignment5._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Location Data</h1>
        <p class="lead">This is a Great Application for users to find important information of a location. Everything from local weather to local alternative fuel stations.</p>
        <p class="lead">If you are the Admin or a Staff Member, use your username an password to sign-in to use the application AND optionally add other staff members.</p>
        <p class="lead">If you are a Member or want to sign up as a member, just click on the Members button!!</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Button ID="member_button" runat="server" Text="Members >>" style="margin-bottom:10px; margin-top:20px; padding-right:50px; text-align:center;" CssClass="btn btn-primary btn-lg" OnClick="member_button_Click"/>
        </div>
        <div class="col-md-4">
            <asp:Button ID="staff_button" runat="server" Text="Staff >>" style="margin-bottom:10px; margin-top:20px; padding-right:50px; text-align:center;" CssClass="btn btn-primary btn-lg" OnClick="staff_button_Click"/>
        </div>
    </div>
    <div class="row" style="margin-top:30px;">
        <div class="col-md-12">
          <h1>Group 14 Web app Services & Controls</h1>
          <h4>This page is deployed at: <a href="">TODO: add link here once link is determined</a></h4>
          <h4>This project is developed By: Kyle Ferguson, Nguyen Dao, and Khalid Rast</h4>
        </div>

    </div>
      <table id="service_table" style="border: 1px solid black;">
      <tbody><tr style="border: 1px solid black; background-color: gray; color: white;">
        <th style="border-left: 1px solid black; border-right: 1px solid black;">Provider Name</th>
        <th style="border-left: 1px solid black; border-right: 1px solid black;">Service Name with output types</th>
        <th style="border-left: 1px solid black; border-right: 1px solid black;">TryIt Link</th>
        <th style="border-left: 1px solid black; border-right: 1px solid black;">Service Description</th>
        <th style="border-left: 1px solid black; border-right: 1px solid black;">Type</th>
      </tr>
      <tr style="border: 1px solid black;">
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;">
          <b>SignIn Component</b></span>:
          <br>
            <b>input:</b><br>
            username:String<br>
            password:String<br>
            <b>output:</b>void<br>
        </td>
        <td style="border: 1px solid black;">To test, make sure you are logged out. Then click the "Members" or "Staff" button. You will be redirected to a signin page at which point you can test it.</td>
        <td style="border: 1px solid black;">
          This user component makes creating a signin sheet a breeze. The Component has a username and password textbox input with a signin and register button. When implemented into a page
          an application builder just has to write login and register handlers and subscribe them to the component's login event and register event. This allows developers to customize the functionality of
          this component any way they please.
        </td>
        <td style="border: 1px solid black;">
          User Control Component.
        </td>
      </tr>

      <tr style="border: 1px solid black;">
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;">
          <b>Logout Component</b></span>:
          <br>
            <b>input:</b><br>
            ClickEvent<br>
            <b>output:</b>void<br>
        </td>
        <td style="border: 1px solid black;">To test, make sure you are logged in as either a Member or a Staff Member. Then click the logout button at the top of the page (any page). You will be logged out and redirected to the Default page.</td>
        <td style="border: 1px solid black;">
          This user component makes creating a logout function a breeze. The Component has a single logout button. When implemented into a page an application builder just has to write a
          logout handler and subscribe them to the component's logout event. This allows developers to customize the functionality of this component any way they please.
        </td>
        <td style="border: 1px solid black;">
          User Control Component.
        </td>
      </tr>

      <tr style="border: 1px solid black;">
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;">
          <b>Register Component</b></span>:
          <br>
          <b>input:</b><br>
          username:String<br>
          password:String<br>
          passwordConfirm:String<br>
          <b>output:</b>void<br>
        </td>
        <td style="border: 1px solid black;">
          To test, make sure you are logged out. Then click the "Members" or "Staff" button. You will be redirected to a signin page at which point you will press the Register button from the signin component.
          You will then be redirected to the Respective Member type's register page at which point you can test the Register Component.
        </td>
        <td style="border: 1px solid black;">
          This user component makes creating a register sheet a breeze. The Component has a username, password, and confirm password (for verification functionality) textbox input with a register button. When implemented into a page
          an application builder just has to write aregister handler and subscribe them to the component's register event. This allows developers to customize the functionality of
          this component any way they please.
        </td>
        <td style="border: 1px solid black;">
          User Control Component.
        </td>
      </tr>

      <tr>
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;"><b>Weather Service</b></span>:
        <br><b>getCurrentConditions:</b><br><b>input:</b><br>location:String<br><b>output:</b><br>location:String<br>conditionLabel:String<br>currentTemp:Double<br>
        <br><b>getForeCast:</b><br><b>input:</b><br>location:String<br><b>output:</b><br>forecast:List&lt;Conditions&gt;</td>
        <td style="border: 1px solid black;">
            <a href="http://webstrar26.fulton.asu.edu/page2/WeatherServiceTryIt.aspx">http://webstrar26.fulton.asu.edu/page2/WeatherServiceTryIt.aspx</a>
            <br>
            Alternatively, sigin as a Member or Staff member and use the service on the member/staff member page.
        </td>
        <td style="border: 1px solid black;">
          <b>getCurrentConditions</b><br>Given a location name, grabs the current tempurature, the condition label (i.e. sunny, cloudy, etc.) and location name.<br>
          <b>getForeCast</b><br>Given a location name, gets a list of 10 Conditions objects which, by contract hold expected low,avg, and high temperatures, expected condition label, and date.
        </td>
        <td style="border: 1px solid black;">
          Web Service (Created by Kyle Ferguson) from Assignment 3.
          <!--Weather data is pulled and parsed from Yahoo's query service yql <a href="https://developer.yahoo.com/yql/">https://developer.yahoo.com/yql/</a>-->
        </td>
      </tr>
      <tr>
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;">
          <b>Redirection and Access Control component via Cookies</b></span>:
          <br>
          A Cookie from the Client. (Why one must use "Request" to access potential values in it).
        </td>
        <td style="border: 1px solid black;">
          To Test the Cookie Redirection and Access Control, navigate through our website both as a Guest and as a User to see the full range of the control.
        </td>
        <td style="border: 1px solid black;">
          This control is a control feature used throughout the web application and is used to redirect users based on the access/authentication of the user. That is, if a user is not signed in, they will be
          redirected to the signin page of the respective page the user attempted to access. If the user IS signed in, the control allows the user to proceed to the page they were attempting to access.
          This project assumes the user allows Cookies in their browser. If Cookies are not enabled, users guest or otherwise, will not be able to access their accounts.
        </td>
        <td style="border: 1px solid black;">
          Server Control Component.
        </td>
      </tr>
      <tr>
        <td style="border: 1px solid black;">Kyle Ferguson</td>
        <td style="border: 1px solid black;"><span style="font-size: 1.2em;">
          <b>Default page</b></span>:
          <br>
          <b>input:</b><br>
          Click Events By User<br>
          <b>output:</b><br>
          void<br>
        </td>
        <td style="border: 1px solid black;">
          To test the Default page, regardless of the page you are on, simply click on the home button which will take you to the Default page. From there, you can click the various buttons to use the page.
        </td>
        <td style="border: 1px solid black;">
          The Default page is the landing page for the Location Services web application. This page allows users to navigate to the Members page or the staff page. Furthermore, they can view a service directory that outlines
          the component and web services that the developers created to build out the Location Services Web App.
        </td>
        <td style="border: 1px solid black;">
          Web Page.
        </td>
      </tr>
      <tr style="border: 1px solid black;">
            <td style="border: 1px solid black;">Khalid Rast</td>
            <td style="border: 1px solid black;"><span style="font-size: 1.2em;"><b>Alternative Fuel Stations Services</b></span>:
              <br><b>input:</b><br>city:string<br>state:string<br><b>output:</b><br>e85stations:string<br>
            <td style="border: 1px solid black;">
                <a href="http://group14.mobicloud.asu.edu/page1/AltFuel.aspx">http://group14.mobicloud.asu.edu/page1/AltFuel.aspx</a>
                <br>
                Alternatively, sigin as a Member or Staff member and use the service on the member/staff member page.
            </td>
            <td style="border: 1px solid black;">
              <b>getE85</b><br>Calculates how many E85 stations there are in a given city and state.<br>
            </td>
            <td style="border: 1px solid black;">
                Web Page
            </td>
      </tr>
      <tr style="border: 1px solid black;">
            <td style="border: 1px solid black;">Nguyen Dao</td>
            <td style="border: 1px solid black;"><span style="font-size: 1.2em;"><b>XML process: get user list</b></span>:<br />
                <strong>input:<br />
                </strong>xmlPath:string<br />
                <strong>output:</strong><br />
                userList:string[]<td style="border: 1px solid black;">
                In staff page, when the page load, the list of Staff will be generated</td>
            <td style="border: 1px solid black;">
                Return a list of users for user of the given xml</td>
            <td style="border: 1px solid black;">
                DLL Function</td>
      </tr>
      <tr style="border: 1px solid black;">
            <td style="border: 1px solid black;">Nguyen<br />
                Dao</td>
            <td style="border: 1px solid black;"><span style="font-size: 1.2em;"><b>XML process: search user</b></span>:<br />
                <strong>input:<br />
                </strong>xmlPath: string<br />
                userName:string<br />
                <strong>output:</strong><br />
                user: XmlNode<td style="border: 1px solid black;">
                When loggin in, the usernam entered will be searched angainst the xml.</td>
            <td style="border: 1px solid black;">
                Return a xml node that contain username and password</td>
            <td style="border: 1px solid black;">
                DLL Fucntion</td>
      </tr>
      <tr style="border: 1px solid black;">
            <td style="border: 1px solid black;">Nguyen Dao</td>
            <td style="border: 1px solid black;"><span style="font-size: 1.2em;"><b>Celebrity Birthday Service</b></span>:<br />
                <strong>input:<br />
                </strong>date: string<br />
                maxReturn: int<br />
                <strong>output:</strong><br />
                celebs: string[]<td style="border: 1px solid black;">
                Tryit function in Member page</td>
            <td style="border: 1px solid black;">
                Return list of celebs born on give date</td>
            <td style="border: 1px solid black;">
                Web Service</td>
      </tr>
  </tbody></table>
</asp:Content>
