
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO

Public Class Events
    Public Sub New()
        Dim fact As DbProviderFactory
        Dim myReader As StreamReader

        If m_Connection Is Nothing Then
            fact = DbProviderFactories.GetFactory("Local.System.Data.SQLite")
            m_Connection = fact.CreateConnection()
            If File.Exists("config.dat") Then
                myReader = New StreamReader("config.dat")
                m_Connection.ConnectionString = "Data Source=" & myReader.ReadLine() & "\database\bioDezyne.db3"
                myReader.Close()
                myReader = Nothing
            Else
                m_Connection.ConnectionString = "Data Source=database/bioDezyne.db3"
            End If
            m_Connection.Open()
        End If
    End Sub

    Public Sub InsertNewEvent(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal iUserID As Integer, ByVal iEventCode As Integer, ByVal strComment As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblEventHistory([VisitID], [PatientID], [UserID], [EventCode], [EventDateTime], [Comment])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & "," & iUserID.ToString & "," & iEventCode.ToString & ",'" & Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & strComment & "'" & ")")
        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetPatientEvents(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal dStartDate As String, ByVal dEndDate As String, ByVal strLastName As String) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("h.[VisitID], h.[PatientID], p.[LastName], p.[FirstName], v.[VisitDate], h.[UserID], u.[Login], h.[EventCode], e.[EventDesc], h.[EventDateTime], h.[Comment]")
        strSQL.Append(_FROM)
        strSQL.Append("tblEventHistory h ")

        'events
        strSQL.Append(_JOIN)
        strSQL.Append("tblEvents e ")
        strSQL.Append(_ON)
        strSQL.Append("e.[EventCode] = h.[EventCode]")

        'users
        strSQL.Append(_JOIN)
        strSQL.Append("tblUsers u ")
        strSQL.Append(_ON)
        strSQL.Append("h.[UserID] = u.[UserID]")

        'Patient
        strSQL.Append(_JOIN)
        strSQL.Append("tblPatientData p ")
        strSQL.Append(_ON)
        strSQL.Append("h.[PatientID] = p.[PatientID]")

        'Visit
        strSQL.Append(_JOIN)
        strSQL.Append("tblVisitHistory v ")
        strSQL.Append(_ON)
        strSQL.Append("h.[VisitID] = v.[VisitID]")


        strSQL.Append(_WHERE)
        strSQL.Append("1=1")
        If iPatientID > 0 Then
            strSQL.Append(_AND)
            strSQL.Append("h.[PatientID]=" & iPatientID.ToString)
        End If

        If strLastName <> "" Then
            strSQL.Append(_AND)
            strSQL.Append("p.[LastName] Like '" & dbSafe(strLastName) & "%'")
        End If

        If iVisitID > 0 Then
            strSQL.Append(_AND)
            strSQL.Append("h.[VisitID] = " & iVisitID.ToString)
        End If

        If dStartDate <> "" And dEndDate <> "" And dStartDate <> dEndDate Then
            strSQL.Append(_AND)
            strSQL.Append("h.[EventDateTime] > '" & dStartDate & " 12:00:00'")
            strSQL.Append(_AND)
            strSQL.Append("h.[EventDateTime] < '" & dEndDate & " 12:00:00'")
        End If

        Return ExecuteReader(strSQL.ToString)

    End Function


End Class
