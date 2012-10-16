<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Secure.aspx.cs" Inherits="Secure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-size: large" 
            Text="Welcome..."></asp:Label>
        <br />
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Log Out" />
    </form>
</body>
</html>
