using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient ;
/// <summary>
/// Summary description for DBFood
/// </summary>
public class DBFood : DBBasic
{
    public DBFood()
        : base("Food")
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Boolean addPicture(Food objFood, byte[] Picture) 
    {
        // special case, adding picture require us to use parameterized query. 

        MySqlCommand sqlcommand = MyDatabaseManager().getNewCommand();
        
        String strSQL = "UPDATE Food SET FoodImage = @image WHERE FoodRestaurantID = @id AND FoodName = @name ";

        sqlcommand.CommandText = strSQL;
        sqlcommand.Parameters.AddWithValue("image", Picture);
        sqlcommand.Parameters.AddWithValue("id", objFood.RestaurantID);
        sqlcommand.Parameters.AddWithValue("name", objFood.Name);
        sqlcommand.Connection.Open();
        
        int result = sqlcommand.ExecuteNonQuery();

        sqlcommand.Connection.Close();

        return result == 1;

    }

    public Boolean insertFood(Food objFood)
    {

        String strSQL = " INSERT INTO Food(FoodName, FoodDescription, FoodRemark, FoodPrice, FoodRestaurantID) ";
           strSQL += " VALUES ('{0}', '{1}', '{2}', {3}, '{4}')";

          strSQL = String.Format(strSQL, objFood.Name, objFood.Description, objFood.Remark, objFood.Price, objFood.RestaurantID);

          return MyDatabaseManager().ExecuteNonQuery(strSQL) == 1;
 
        
    }

    public Food getFoodByEmail(String email, String FoodType)
    {

        String strSQL = "SELECT * FROM Food WHERE FoodEmail = '{0}' AND FoodType = '{1}'";

        strSQL = String.Format(strSQL, email, FoodType);

        ArrayList FoodList = null;//= UniversalGetRecords(strSQL);

        if (FoodList == null)
            return null;

        return (Food)FoodList[0];


    }

    /*private ArrayList UniversalGetRecords(String pstrSQL)
    {
        DataTable tempDataTable;



        tempDataTable = MyDatabaseManager().GetDataTableBySqlCommand(pstrSQL);


        if (tempDataTable.Rows.Count == 0)
            return null;


        int intTotalColumn = 6;

        String[] ColumnName = new String[intTotalColumn];
        Boolean[] ColumnExist = new Boolean[intTotalColumn];

        ColumnName[0] = "FoodEmail";
        ColumnName[1] = "FoodDisplayName";
        ColumnName[2] = "FoodGender";
        ColumnName[3] = "FoodDOB";
        ColumnName[4] = "FoodPassword";
        ColumnName[5] = "FoodType";

        for (int i = 0; i < intTotalColumn; i++)
            ColumnExist[i] = DatabaseManager.HasColumn(tempDataTable, ColumnName[i]);


        Food Food;


        ArrayList tempArrayList = new ArrayList();

        int index = 0;

        foreach (DataRow objDataRow in tempDataTable.Rows)
        {

            Food = new Food();
            index = 0;

            if (ColumnExist[index])
            {
                Food.Email = (String)objDataRow[ColumnName[index]];
            }

            index++;

            if (ColumnExist[index])
            {
                Food.Name = (String)objDataRow[ColumnName[index]];
            }



            index++;

            if (ColumnExist[index])
            {
                Food.Gender = (String)objDataRow[ColumnName[index]];
            }


            index++;

            if (ColumnExist[index])
            {
                Food.DOB = ((MySql.Data.Types.MySqlDateTime)objDataRow[ColumnName[index]]).GetDateTime();
            }


            index++;

            if (ColumnExist[index])
            {
                Food.Password = (String)objDataRow[ColumnName[index]];
            }

            index++;

            if (ColumnExist[index])
            {
                Food.Type = (String)objDataRow[ColumnName[index]];
            }


            tempArrayList.Add(Food);

        }

        return tempArrayList;
    } */
}
