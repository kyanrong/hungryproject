using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DBMember dbmember = new DBMember();
        GridView1.DataSource = (Object)dbmember.GetAllRecordsDataTable();
        GridView1.DataBind();
    }
}
