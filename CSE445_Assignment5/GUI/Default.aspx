<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Assignment5._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Location Data</h1>
        <p class="lead">This is a Great Application for users to find important information of a location. Everything from local weather to local crime rates.</p>
        <p class="lead">If you are the Admin or a Staff Member, use your username an password to sign-in to use the application AND optionally add other staff members.</p>
        <p class="lead">If you are a Member or want to sign up as a member, just click on the Members button!!</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Button ID="member_button" runat="server" Text="Members >>" style="margin-bottom:10px; margin-top:20px; padding-right:50px; text-align:center;" CssClass="btn btn-primary btn-lg" OnClick="member_button_Click"/>
        </div>
        <div class="col-md-4">
            <asp:Button ID="Button1" runat="server" Text="Staff >>" style="margin-bottom:10px; margin-top:20px; padding-right:50px; text-align:center;" CssClass="btn btn-primary btn-lg" OnClick="Button1_Click"/>
        </div>
    </div>

</asp:Content>
