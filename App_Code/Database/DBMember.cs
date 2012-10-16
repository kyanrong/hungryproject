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
}


    //Public Function InsertRecord(ByVal objPHUser As PHUser) As Integer

    //    Dim strSQL As String = ""

    //    strSQL &= " INSERT INTO PHUser (strPHUserName, strPHUserFullName, strPHUserPassword) "
    //    strSQL &= " Values ('{0}', '{1}', '{2}') "

    //    strSQL = String.Format(strSQL, DatabaseManager.EscapeSQLQuery(objPHUser.UserName), _
    //                                   DatabaseManager.EscapeSQLQuery(objPHUser.FullName), _
    //                                   DatabaseManager.EscapeSQLQuery(objPHUser.Password))

    //    If MyDatabaseManager.ExecuteNonQuery(strSQL) = 1 Then

    //        If DBPrimaryKeyValue.AddLastKey("INVOICENO") Then
    //            Return MyDatabaseManager.ExecuteScalar("Select @@IDENTITY")
    //        End If

    //    End If
    //End Function


    //Public Function DeleteRecord(ByVal objPHUser As PHUser) As Boolean

    //    Dim strSQL As String = ""

    //    strSQL &= " DELETE FROM PHUser"
    //    strSQL &= " WHERE intPHUserID = {0}"

    //    strSQL = String.Format(strSQL, objPHUser.ID)

    //    Return MyDatabaseManager.ExecuteNonQuery(strSQL) > 0

    //End Function

    //Public Function UpdateRecord(ByVal objPHUser As PHUser) As Boolean

    //    Dim strSQL As String = ""

    //    strSQL &= " UPDATE PHUser SET strPHUserName = '{0}', strPHUserFullName= '{1}', strPHUserPassword= '{2}' "
    //    strSQL &= " WHERE intPHUserID = {3}"

    //    strSQL = String.Format(strSQL, DatabaseManager.EscapeSQLQuery(objPHUser.UserName), _
    //                                   DatabaseManager.EscapeSQLQuery(objPHUser.FullName), _
    //                                   DatabaseManager.EscapeSQLQuery(objPHUser.Password), _
    //                                   objPHUser.ID)

    //    Return MyDatabaseManager.ExecuteNonQuery(strSQL) > 0

    //End Function
    //Public Function UpdateRecordWithoutPassword(ByVal objPHUser As PHUser) As Boolean

    //    Dim strSQL As String = ""

    //    strSQL &= " UPDATE PHUser SET strPHUserName = '{0}', strPHUserFullName= '{1}' "
    //    strSQL &= " WHERE intPHUserID = {2}"

    //    strSQL = String.Format(strSQL, DatabaseManager.EscapeSQLQuery(objPHUser.UserName), _
    //                                   DatabaseManager.EscapeSQLQuery(objPHUser.FullName), _
    //                                   objPHUser.ID)

    //    Return MyDatabaseManager.ExecuteNonQuery(strSQL) > 0

    //End Function

    //Public Function GetAllRecordsPrimaryKey() As ArrayList
    //    Dim strSQL As String

    //    strSQL = " SELECT intPHUserID FROM PHUser "

    //    Return GetRecords(strSQL)

    //End Function


    //Public Function GetAllRecordsDataSet() As DataSet
    //    Dim strSQL As String

    //    strSQL = " SELECT * FROM PHUser "

    //    Return MyDatabaseManager.GetDataSetBySqlCommand(strSQL)

    //End Function
    //Public Function GetRecordByID(ByVal intPHUserID As Integer) As PHUser

    //    Dim strSQL As String = ""

    //    strSQL = " SELECT * FROM PHUser where intPHUserID = {0} "


    //    strSQL = String.Format(strSQL, intPHUserID)


    //    Return CType(GetRecord(strSQL), PHUser)

    //End Function


    //Public Function getUserByUserName(ByVal strUserName As String) As PHUser

    //    Dim strSQL As String = ""

    //    strSQL = " SELECT * FROM PHUser where strPHUserName = '{0}' "


    //    strSQL = String.Format(strSQL, DatabaseManager.EscapeSQLQuery(strUserName))


    //    Return CType(GetRecord(strSQL), PHUser)

    //End Function

    //Overrides Function GetRecords(ByVal pstrSQL As String) As ArrayList
    //    Dim tempDataTable As DataTable

    //    Try
    //        tempDataTable = MyDatabaseManager.GetDataTableBySqlCommand(pstrSQL)
    //    Catch ex As Exception
    //        Return Nothing
    //    End Try

    //    If tempDataTable.Rows.Count = 0 Then
    //        Return Nothing
    //    End If

    //    Dim intTotalColumn As Integer = 4

    //    Dim ColumnName(intTotalColumn - 1) As String
    //    Dim ColumnExist(intTotalColumn - 1) As Boolean

    //    ColumnName(0) = "intPHUserID"
    //    ColumnName(1) = "strPHUSerName"
    //    ColumnName(2) = "strPHUserFullName"
    //    ColumnName(3) = "strPHUserPassword"


    //    Dim i As Integer

    //    For i = 0 To intTotalColumn - 1

    //        ColumnExist(i) = DatabaseManager.HasColumn(tempDataTable, ColumnName(i))

    //    Next

    //    Dim objDataRow As DataRow

    //    Dim objPHUser As PHUser


    //    Dim tempArrayList As New ArrayList

    //    For Each objDataRow In tempDataTable.Rows
    //        objPHUser = New PHUser
    //        i = 0

    //        If ColumnExist(i) Then
    //            objPHUser.ID = CType(objDataRow.Item(ColumnName(i)), Integer)

    //        End If

    //        i += 1

    //        If ColumnExist(i) Then
    //            objPHUser.UserName = CType(objDataRow.Item(ColumnName(i)), String)

    //        End If
    //        i += 1


    //        If ColumnExist(i) Then
    //            objPHUser.FullName = CType(objDataRow.Item(ColumnName(i)), String)

    //        End If

    //        i += 1
    //        If ColumnExist(i) Then
    //            objPHUser.Password = CType(objDataRow.Item(ColumnName(i)), String)
    //        End If

    //        tempArrayList.Add(objPHUser)

    //    Next

    //    Return tempArrayList

    //End Function


