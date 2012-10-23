<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFood.aspx.cs" Inherits="User_AddFood" %>

<%@ Register assembly="System.Web.DynamicData, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.DynamicData" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 159px;
        }
        .style2
        {
            width: 377px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ForeColor="Black" />
    <br />
    Add Food
       <table width="800" border="1">
  <tr>
    <td class="style1">Food Name</td>
    <td class="style2">
        <asp:TextBox ID="txtFoodName" runat="server" ValidationGroup="Group1" 
            Width="310px"></asp:TextBox>
      </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtFoodName" Display="None" 
            ErrorMessage="Food Name is required"></asp:RequiredFieldValidator>
        <br />
      </td>
  </tr>
  <tr>
    <td class="style1">Description</td>
    <td class="style2">
        <asp:TextBox ID="txtDescription" runat="server" Height="67px" 
            TextMode="MultiLine" Width="258px"></asp:TextBox>
      </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtDescription" Display="None" 
            ErrorMessage="Description is required"></asp:RequiredFieldValidator>
      </td>
  </tr>
  <tr>
    <td class="style1">Restaurant </td>
    <td class="style2">
        <asp:TextBox ID="txtRestaurantID" runat="server"></asp:TextBox>
        select a restaurant</td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtRestaurantID" Display="None" 
            ErrorMessage="Please select a restaurant"></asp:RequiredFieldValidator>
      </td>
  </tr>
  <tr>
    <td class="style1">Price</td>
    <td class="style2">
        <asp:TextBox ID="txtPrice" runat="server">0</asp:TextBox>
      </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtFoodName" Display="None" 
            ErrorMessage="Please enter the food's price"></asp:RequiredFieldValidator>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToValidate="txtPrice" ErrorMessage="Please enter a valid price" 
            Operator="GreaterThan" Type="Currency" ValueToCompare="0"></asp:CompareValidator>
      </td>
  </tr>
  <tr>
    <td class="style1">Remark</td>
    <td class="style2">
        <asp:TextBox ID="txtRemark" runat="server" Height="67px" TextMode="MultiLine" 
            Width="258px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style1">Picture</td>
    <td class="style2">
        <asp:FileUpload ID="fluPicture" runat="server" />
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style1">&nbsp;</td>
    <td class="style2">
        <asp:Button ID="btnSave" runat="server" onclick="Button1_Click" 
            style="height: 26px" Text="Save" />
      </td>
    <td>&nbsp;</td>
  </tr>
</table>
    
    </div>
    </form>
</body>
</html>
