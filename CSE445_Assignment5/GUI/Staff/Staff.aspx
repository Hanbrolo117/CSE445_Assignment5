<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="CSE445_Assignment5.Staff.Staff" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Staff user list:"></asp:Label>
        <br />
        <asp:TextBox ID="txtStaffs" runat="server" Height="146px" ReadOnly="True" TextMode="MultiLine" Width="116px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddStaff" runat="server" OnClick="btnAddStaff_Click" Text="Add New Staff" />
        <asp:Label ID="Label2" runat="server" Text="(For admin use only)"></asp:Label>
    </div>
</asp:Content>
