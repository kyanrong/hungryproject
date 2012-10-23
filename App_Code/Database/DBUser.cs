using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
/// <summary>
/// Summary description for DBUser
/// </summary>
public class DBUser : DBBasic
{
    public DBUser() :     base("user")
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public HUser getUserByEmail(String email, String userType)
    {

        String strSQL = "SELECT * FROM User WHERE UserEmail = '{0}' AND UserType = '{1}'";

        strSQL = String.Format(strSQL, email, userType);

        ArrayList userList = UniversalGetRecords(strSQL);

        if (userList == null)
            return null;

        return (HUser)userList[0];


    }

    private ArrayList UniversalGetRecords(String pstrSQL)
    {
        DataTable tempDataTable;



            tempDataTable = MyDatabaseManager().GetDataTableBySqlCommand(pstrSQL);


        if (tempDataTable.Rows.Count == 0)
            return null;


        int intTotalColumn = 6;

        String[] ColumnName = new String[intTotalColumn ];
        Boolean[] ColumnExist = new Boolean[intTotalColumn ];

        ColumnName[0] = "UserEmail";
        ColumnName[1] = "UserDisplayName";
        ColumnName[2] = "UserGender";
        ColumnName[3] = "UserDOB";
        ColumnName[4] = "UserPassword";
        ColumnName[5] = "UserType";
        
        for (int i = 0; i < intTotalColumn; i++)
            ColumnExist[i] = DatabaseManager.HasColumn(tempDataTable, ColumnName[i]);

        
        HUser user;


        ArrayList tempArrayList = new ArrayList();

        int index = 0;

        foreach (DataRow objDataRow in tempDataTable.Rows)
        {

            user = new HUser();
            index = 0;

            if (ColumnExist[index])
            {
                user.Email = (String)objDataRow[ColumnName[index]];
            }

            index++;

            if (ColumnExist[index])
            {
                user.Name = (String)objDataRow[ColumnName[index]];
            }



            index++;

            if (ColumnExist[index])
            {
                user.Gender= (String)objDataRow[ColumnName[index]];
            }


            index++;

            if (ColumnExist[index])
            {
                user.DOB = ((MySql.Data.Types.MySqlDateTime)objDataRow[ColumnName[index]]).GetDateTime();
            }


            index++;

            if (ColumnExist[index])
            {
                user.Password= (String )objDataRow[ColumnName[index]];
            }

            index++;

            if (ColumnExist[index])
            {
                user.Type = (String)objDataRow[ColumnName[index]];
            }


            tempArrayList.Add(user);

        }

        return tempArrayList;
    }
}
