using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for DatabaseManager
/// </summary>
public class DatabaseManager
{

    String mTableName;
    MySqlCommand pSqlCommand;
    MySqlConnection pSqlConnection;
    MySqlDataAdapter pSqlDataAdapter;

    MySqlTransaction MyTransaction;

    enum TransactionStatus { BEGINTRANSACTION = 1, NONE = 2 };

    TransactionStatus pTransactionStatus;


    public void BeginTransaction()
    {


        pSqlConnection.Open();
        MyTransaction = pSqlConnection.BeginTransaction();

        pSqlCommand.Transaction = MyTransaction;
        pTransactionStatus = TransactionStatus.BEGINTRANSACTION;
    }


    public void CommitTransaction()
    {
        if (pTransactionStatus == TransactionStatus.BEGINTRANSACTION)
        {

            MyTransaction.Commit();
            pSqlConnection.Close();
            pTransactionStatus = TransactionStatus.NONE;

        }

    }

    //public DatabaseManager(String myTableName, MYSQLConnectionHeader objConnectionHeader) {
    //    mTableName = myTableName;

    //    pSqlCommand = objConnectionHeader.MySqlCommand;
    //    pSqlConnection = objConnectionHeader.MySqlConnection;
    //    pSqlDataAdapter = objConnectionHeader.MySqlDataAdapater;
    //    pTransactionStatus = TransactionStatus.NONE;

    //}

    public DatabaseManager(String myTableName)
    {
        mTableName = myTableName;

        ConnectionHeader objConnectionHeader = new ConnectionHeader();

        pSqlCommand = objConnectionHeader.MySqlCommand;
        pSqlConnection = objConnectionHeader.MySqlConnection;
        pSqlDataAdapter = objConnectionHeader.MySqlDataAdapter;

        pTransactionStatus = TransactionStatus.NONE;

    }

    public void RollBackTransaction()
    {
        if (pTransactionStatus == TransactionStatus.BEGINTRANSACTION)
        {
            MyTransaction.Rollback();
            pSqlConnection.Close();
            pTransactionStatus = TransactionStatus.NONE;
        }
    }



    public static String EscapeSQLQuery(String value)
    {

        if (value.Equals(""))
            return "";


        value = value.Replace("'", "''");
        value = value.Replace("\\", "\\\\");

        return value;

    }

    public String EscapeSQLQueryLIKE(String value)
    {
        value = EscapeSQLQuery(value);
        value = value.Replace("%", "\\%");
        value = value.Replace("_", "\\_");

        return value;
    }


    public String FormatSqlDate(DateTime value)
    {
        return value.ToString("yyyy-MM-dd");
    }


    public String TableName
    {
        get
        {
            return mTableName;
        }
        set
        {
            mTableName = value;
        }
    }

    public DataTable GetDataTableBySqlCommand(String strSQL)
    {

        return GetDataSetBySqlCommand(strSQL).Tables[0];

    }
    public DataSet GetDataSetBySqlCommand(String strSQL)
    {
        DataSet tempDataSet = new DataSet();


        lock (pSqlConnection)
        {

            pSqlCommand.CommandText = strSQL;
            if (TableName.Equals(""))
                pSqlDataAdapter.Fill(tempDataSet);
            else
                pSqlDataAdapter.Fill(tempDataSet, TableName);


            if (pTransactionStatus == TransactionStatus.NONE)
                pSqlConnection.Close();


        }

        return tempDataSet;

    }



    public int ExecuteNonQuery(String strSQL)
    {
        int intResult = -1;

        lock (pSqlConnection)
        {
            pSqlCommand.CommandText = strSQL;
            try
            {

                if (pTransactionStatus == TransactionStatus.NONE)
                    pSqlConnection.Open();


                intResult = pSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                //PHLog.WriteLocalLog(ex.ToString  + " " + ex.Message);

            }
            finally
            {

                if (pTransactionStatus == TransactionStatus.NONE)
                    pSqlConnection.Close();

            }
        }

        return intResult;
    }


    public int ExecuteScalar(String strSQL)
    {

        int intResult = -1;

        lock (pSqlConnection)
        {
            pSqlCommand.CommandText = strSQL;
            try
            {

                if (pTransactionStatus == TransactionStatus.NONE)
                    pSqlConnection.Open();

                intResult = (int)pSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //PHLog.WriteLocalLog(ex.ToString & " " & ex.Message)
            }
            finally
            {

                if (pTransactionStatus == TransactionStatus.NONE)
                    pSqlConnection.Close();

            }
        }

        return intResult;
    }

    public bool HasColumn(DataTable MyDataTable, String pColumnName) {


        

            int length;
        length = MyDataTable.Columns.Count;

        for (int i = 0; i < length; i++) {



            if (MyDataTable.Columns[i].ColumnName.Equals(pColumnName, StringComparison.OrdinalIgnoreCase))
                return true;            
        }

        return false;
        }

    public DatabaseManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}