using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for DatabaseTransaction
/// </summary>
public class DatabaseTransaction
{
    ArrayList pList;
    DatabaseManager objDatabaseManager;

    Boolean blnTransactionStarted = false;


    public DatabaseTransaction()
    {
        pList = new ArrayList();
        objDatabaseManager = new DatabaseManager("Transaction");
    }



    void AddDatabaseClass(DBBasic objDBBasic)
    {
        pList.Add(objDBBasic);
        objDBBasic.SwitchDatabaseManagerTo(objDatabaseManager, this);

    }

    void RemoveDatabaseClass(DBBasic objDBBasic)
    {
        objDBBasic.SwitchDatabaseManagerToDefault();
        pList.Remove(objDBBasic);
    }


    bool Has(DBBasic objDBBasic)
    {
        return pList.IndexOf(objDBBasic) >= 0;
    }


    void ClearDatabaseClass()
    {
        SwitchToDefaultDatabaseManager();
        pList.Clear();

    }

    void SwitchToDefaultDatabaseManager()
    {
        //DBBasic objDBBasic; 

        foreach (DBBasic objDBBasic in pList)
            objDBBasic.SwitchDatabaseManagerToDefault();

        //DBPrimaryKeyValue.SwitchDatabaseManagerToDefault();
    }

    public void CommitTransaction() {
        if (!blnTransactionStarted)
            throw new Exception("Transaction didn't start");
        
        blnTransactionStarted = false;

        objDatabaseManager.CommitTransaction();
        ClearDatabaseClass();

    }

    void Rollback()
    {

        if (!blnTransactionStarted)
            throw new Exception("Transaction didn't start");

        blnTransactionStarted = false;

        objDatabaseManager.RollBackTransaction();

        ClearDatabaseClass();
    }


    void BeginTransaction()
    {
        blnTransactionStarted = true;

        //DBPrimaryKeyValue.SwitchDatabaseManagerTo(objDatabaseManager)

        objDatabaseManager.BeginTransaction();

    }
}




