<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="adminMain.aspx.cs" Inherits="_Default" %>

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
          <asp:Label ID="lblMemberEmail" runat="server" Text="MemberEmail"></asp:Label>
        <asp:TextBox ID="txtMemberEmail" runat="server" ></asp:TextBox>
      
        <br />
          <asp:Label ID="lblMemberName" runat="server" Text="MemberNamessword"></asp:Label>
        <asp:TextBox ID="txtMemberName" runat="server" style="margin-top: 3px"></asp:TextBox>
        <br />

          <asp:Button ID="" runat="server" Text="Login" OnClick="btnLogin_Click" />
          <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
