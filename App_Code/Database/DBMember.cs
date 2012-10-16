using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;

/// <summary>
/// Summary description for DBMember
/// </summary>
public class DBMember : DBBasic
{
    public DBMember()
        : base("member")
    {

    }

   public DataTable GetAllRecordsDataTable()
    {
        String strSQL;

        strSQL = " SELECT * FROM member ";

        return MyDatabaseManager().GetDataTableBySqlCommand (strSQL);

    }

    //Admin Login
   public String login(String txtEmail, String txtPassword)
   {
       String strSQL;
       DataTable userData;
       String userType;

       strSQL = "SELECT UserType FROM user WHERE UserEmail = '" + txtEmail + "' and UserPassword = '" + txtPassword + "'";
       userData = MyDatabaseManager().GetDataTableBySqlCommand(strSQL);
       if (userData.Rows.Count == 1)
       {
           userType = (String)userData.Rows[0].ItemArray[0];
           return userType;
       }
       return "";


       // strSQL = "SELECT email, password FROM user where email = '" + txtEmail + "' and password = '" + txtPassword + "'";
       //MyDatabaseManager().ExecuteNonQuery(strSQL);
   }
}



