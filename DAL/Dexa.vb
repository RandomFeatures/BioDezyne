Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.Data.SqlClient
Imports System.IO
Public Class Dexa


    Private m_Connection As OleDb.OleDbConnection

    Public Sub New(ByVal strDexaFile As String)
        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source="

        If File.Exists(strDexaFile) Then
            ConnectionString += strDexaFile

            m_Connection = New OleDb.OleDbConnection(ConnectionString)
            m_Connection.Open()
        End If

    End Sub

    Public Function FindPatient(ByVal strFirstName As String, ByVal strLastName As String) As DataSet
        Dim objCommand As OleDb.OleDbCommand
        Dim objReader As OleDb.OleDbDataReader
        Dim objDS As New DataSet
        Dim strSQL As New StringBuilder
        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("Last_Name, First_Name, BirthDate, Sex, Weight, Height, Last_Update, Patient_Key")
        strSQL.Append(_FROM)
        strSQL.Append("patient")
        strSQL.Append(_WHERE)
        strSQL.Append("Last_Name='" & strLastName & "'")
        strSQL.Append(_AND)
        strSQL.Append("First_Name='" & strFirstName & "'")


        If m_Connection.State = ConnectionState.Open Then

            objCommand = New OleDb.OleDbCommand(strSQL.ToString, m_Connection)
            objReader = objCommand.ExecuteReader()
            objDS = GetDataset(objReader)
            objReader.Close()

        End If

        Return objDS
    End Function

    Public Function GetScanData(ByVal strDexaPatientID As String) As DataSet
        Dim objCommand As OleDb.OleDbCommand
        Dim objReader As OleDb.OleDbDataReader
        Dim objDS As New DataSet
        Dim strSQL As New StringBuilder
        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("ScanID, Serial_Number, Analysis_Date, Scan_Date, Weight")
        strSQL.Append(_FROM)
        strSQL.Append("ScanAnalysis")
        strSQL.Append(_WHERE)
        strSQL.Append("Patient_Key='" & strDexaPatientID & "'")


        If m_Connection.State = ConnectionState.Open Then

            objCommand = New OleDb.OleDbCommand(strSQL.ToString, m_Connection)
            objReader = objCommand.ExecuteReader()
            objDS = GetDataset(objReader)
            objReader.Close()

        End If

        Return objDS
    End Function

    Public Function GetDexaData(ByVal strDexaPatientID As String, ByVal strDexaScanID As String) As DataSet
        Dim objCommand As OleDb.OleDbCommand
        Dim objReader As OleDb.OleDbDataReader
        Dim objDS As New DataSet
        Dim strSQL As New StringBuilder
        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("Weight, Height, BMI")
        strSQL.Append(_FROM)
        strSQL.Append("ScanAnalysis")
        strSQL.Append(_WHERE)
        strSQL.Append("Patient_Key='" & strDexaPatientID & "'")
        strSQL.Append(_AND)
        strSQL.Append("ScanID='" & strDexaScanID & "'")

        If m_Connection.State = ConnectionState.Open Then

            objCommand = New OleDb.OleDbCommand(strSQL.ToString, m_Connection)
            objReader = objCommand.ExecuteReader()
            objDS = GetDataset(objReader)
            objReader.Close()

        End If

        Return objDS
    End Function

    Public Function GetDexaTScore(ByVal strDexaPatientID As String, ByVal strDexaScanID As String) As DataSet
        Dim objCommand As OleDb.OleDbCommand
        Dim objReader As OleDb.OleDbDataReader
        Dim objDS As New DataSet
        Dim strSQL As New StringBuilder
        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("T_Score")
        strSQL.Append(_FROM)
        strSQL.Append("ReferenceResults")
        strSQL.Append(_WHERE)
        strSQL.Append("Patient_Key='" & strDexaPatientID & "'")
        strSQL.Append(_AND)
        strSQL.Append("ScanID='" & strDexaScanID & "'")

        If m_Connection.State = ConnectionState.Open Then

            objCommand = New OleDb.OleDbCommand(strSQL.ToString, m_Connection)
            objReader = objCommand.ExecuteReader()
            objDS = GetDataset(objReader)
            objReader.Close()

        End If

        Return objDS
    End Function

    Private Function GetDataset(ByVal objReader As OleDb.OleDbDataReader) As DataSet
        Dim m_Table As New DataTable
        Dim objDS As New DataSet

        m_Table.TableName = objReader.GetSchemaTable().TableName

        'Add Tabel to Dataset
        objDS.Tables.Add(m_Table)
        'create DataSet
        objDS.Load(objReader, LoadOption.OverwriteChanges, m_Table)

        Return objDS

    End Function

End Class
