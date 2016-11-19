<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="CSE445_Assignment5.GUI.Member.MemberRegister" %>


<%@ Register Src="~/components/Register.ascx" TagPrefix="uc1" TagName="Register" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Register runat="server" id="Register" />
    <asp:Label ID="alert" runat="server" Text="Waiting for event to happen." style="margin-right:10px;"></asp:Label>
</asp:Content>