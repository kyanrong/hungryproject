using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DBBasic
/// </summary>
public class DBBasic
{

    DatabaseManager BasicDatabaseManager;
    DatabaseManager MyTempDatabaseManager;
    DatabaseTransaction mDatabaseTransactionParent;


    public DatabaseTransaction DatabaseTransactionParent
    {
        get
        {
            return mDatabaseTransactionParent;
        }
    }


    public DBBasic(String TableName)
    {
        BasicDatabaseManager = new DatabaseManager(TableName);
        MyTempDatabaseManager = BasicDatabaseManager;

    }
    protected DatabaseManager MyDatabaseManager()
    {
        return BasicDatabaseManager;
    }


    public void SwitchDatabaseManagerTo(DatabaseManager objDatabaseManager, DatabaseTransaction objDatabaseTransaction)
    {
        BasicDatabaseManager = objDatabaseManager;
        mDatabaseTransactionParent = objDatabaseTransaction;
    }

    public void SwitchDatabaseManagerToDefault()
    {
        BasicDatabaseManager = MyTempDatabaseManager;
        mDatabaseTransactionParent = null;
    }




    public ArrayList GetRecords(String pstrSQL)
    {
        return null;
    }



    Object GetRecord(String pstrSQL)
    {


        ArrayList arrObject = GetRecords(pstrSQL);

        if (!(arrObject == null))
            return arrObject[0];

        return null;

    }

    public DBBasic()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}





