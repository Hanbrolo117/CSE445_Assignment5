<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="CSE445_Assignment5.GUI.StaffLogin" %>

<%@ Register Src="~/components/signIn.ascx" TagPrefix="uc1" TagName="signIn" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:signIn runat="server" ID="signIn" />
   <asp:Label ID="alert" runat="server" Text="Waiting for event to happen." style="margin-right:10px;"></asp:Label>
</asp:Content>
