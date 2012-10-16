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
        SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString

            );
        con.Open();
        string cmdStr="select count(*) from user where UserEmail=\'+ TextBox1.Text +\'";

        SqlCommand Checkuser=new SqlCommand(cmdStr,con);
        int temp=Convert.ToInt32(Checkuser.ExecuteScalar().ToString());
        if(temp==1){
            string cmdStr2="select UserPassword from user where UserEmail=\'+TextBox1.Text+\'";
            SqlCommand pass=new SqlCommand(cmdStr2,con);
            string password =pass.ExecuteScalar().ToString();

            con.Close();
            if(password==TextBox2.Text){
                Session["New"]=TextBox1.Text;
                Response.Redirect("Secure.aspx");

            }
            else{
                
                Label1.Visible=true;
                Label1.Text="Invalid Password...!!";

            }
        }
        else{
            Label1.Visible=true;
            Label1.Text="Invalid UserEmail...!!";
        }
    }
}