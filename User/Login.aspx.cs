using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (HUser.doLogin(txtUserEmail.Text, txtPassword.Text))
        {
            HUser.doRegisterUser(Session, txtUserEmail.Text);

            Response.Redirect("Secure.aspx");
        

        }
        else
        {
            Label1.Text = "Your email and password do not match.";
            Label1.Visible = true;

        }

    }
}