using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
   
 
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String userType;
        DBMember dbmember = new DBMember();
        userType = dbmember.login(txtEmail.Text, txtPassword.Text);
        if (userType.Equals("admin"))
        {
            Response.Redirect("adminMain.aspx");
        }
        else
        {
            Response.Redirect("invalid.aspx");
        }
    }
}
