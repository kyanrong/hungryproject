<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 133px;
            font-size: medium;
        }
        .style3
        {
            width: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700; font-size: x-large">
    
        Login Page<br />
        <asp:Label ID="Label1" runat="server" style="font-size: medium" Visible="False"></asp:Label>
        <br />
        <table class="style1">
            <tr>
                <td class="style2" style="font-size: medium">
                    Email</td>
                <td class="style3">
                    <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Email is blank." style="font-size: medium" 
                        ControlToValidate="txtUserEmail"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td class="style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Password is blank." style="font-size: medium" 
                        ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
