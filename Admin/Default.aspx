﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 215px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
      
        <br />
          <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="margin-top: 3px"></asp:TextBox>
        <br />

          <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
          <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
