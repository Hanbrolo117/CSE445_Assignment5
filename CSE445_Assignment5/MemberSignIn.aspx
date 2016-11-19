<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberSignIn.aspx.cs" Inherits="CSE445_Assignment5.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <th colspan="3">
            Login</th>
    </tr>
    <tr>
        <td>
            Username
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" />
        </td>
        <td>
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtUsername"
                runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Password
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
        </td>
        <td>
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPassword"
                runat="server" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button Text="Submit" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" ID="Button1" />
        <asp:Button ID="Button2" runat="server" Text="Register" Font-Bold="True" Font-Size="Medium" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>
