using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for Connection
/// </summary>
public class ConnectionHeader
{
        bool blnCreated = false;

    MySqlConnection objConn;
    MySqlCommand objCmd;
    String CONNSTRING = "server={0}; user id=[USER]; password=[PASSWORD]; " +
                            "database=[DATABASE]; pooling=true; port={1}; allow zero datetime=true";

    static MySqlDataAdapter objDataAdapter;

    public  MySqlConnection MySqlConnection {
      get {
          CreateConnection();
          return objConn;
      }
    }

    public MySqlCommand MySqlCommand {
      get {
       CreateConnection();
          return objCmd;
      }
    }
       
     void CreateConnection() {
        CreateConnection(CONNSTRING);
        }
     void CreateConnection(String MyConnString ) {
        if (blnCreated )
            return;
        

        MyConnString = String.Format(MyConnString, "localhost", 3306);
        MyConnString = MyConnString.Replace("[USER]", "cs2102user");
        MyConnString = MyConnString.Replace("[PASSWORD]", "12345678");
        MyConnString = MyConnString.Replace("[DATABASE]", "cs2102");

        objConn = new MySqlConnection(MyConnString);
        objCmd = objConn.CreateCommand();

        objDataAdapter = new MySqlDataAdapter();
        objDataAdapter.SelectCommand = objCmd;

        blnCreated = true;
     } 

      public MySqlDataAdapter  MySqlDataAdapter  {
        get {
            CreateConnection();
            return objDataAdapter;
        }
      }

	public ConnectionHeader()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}



  

   
