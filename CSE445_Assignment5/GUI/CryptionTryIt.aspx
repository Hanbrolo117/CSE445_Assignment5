<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CryptionTryIt.aspx.cs" Inherits="CSE445_Assignment5.CryptionTryIt" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="password_label" runat="server" Text="Text to encrypt & decrypt:" style="margin-right:10px;"></asp:Label>
    <asp:TextBox ID="plaintext_input" runat="server" style="margin-top:15px;" ></asp:TextBox>
    <br />
    <asp:Button ID="endecrypt" runat="server" Text="Login" style="margin-bottom:10px; margin-top:20px; padding-right:50px; text-align:center;" OnClick="endecrypt_Click" />
    <br />
    <asp:Label ID="encrypt_label" runat="server" Text="Encryption:" style="margin-right:10px;"></asp:Label>
        <asp:Label ID="cipherText" runat="server" Text="" style="margin-right:10px;"></asp:Label>
    <br />
    <asp:Label ID="decrypt_label" runat="server" Text="Decryption:" style="margin-right:10px;"></asp:Label>
        <asp:Label ID="plaintext" runat="server" Text="" style="margin-right:10px;"></asp:Label>


</asp:Content>
