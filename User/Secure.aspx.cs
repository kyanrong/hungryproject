﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HUser user = HUser.getLoginUser(Session);

        if (user != null)
        {
            Label1.Text += user.Name;

        }
        else {
            Response.Redirect("Login.aspx");

        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Login.aspx");
    }
}