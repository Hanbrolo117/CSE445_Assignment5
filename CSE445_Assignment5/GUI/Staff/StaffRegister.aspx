﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffRegister.aspx.cs" Inherits="CSE445_Assignment5.GUI.Staff.StaffRegister" %>

<%@ Register Src="~/components/Register.ascx" TagPrefix="uc1" TagName="Register" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Register runat="server" id="Register" />

</asp:Content>
