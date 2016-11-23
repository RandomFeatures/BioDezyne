Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO

Public Class PatientData

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

    Public Function InsertPatientData(ByVal strXRef As String, ByVal strFirstName As String, ByVal strMiddle As String, ByVal strLastName As String, ByVal strGender As String, ByVal strDoB As String, ByVal strPhone As String, ByVal strEmail As String, ByVal strAddress As String) As Integer
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblPatientData([XRef], [FirstName], [Middle], [LastName], [Gender], [DOB], [LastUpdate], [Phone], [Email], [Address], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("('" & dbSafe(strXRef) & "','" & dbSafe(strFirstName) & "','" & dbSafe(strMiddle) & "','" & dbSafe(strLastName) & "','" & strGender & "','" & strDoB & " 12:00:00','" & Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dbSafe(strPhone) & "','" & dbSafe(strEmail) & "','" & dbSafe(strAddress) & "', 'true')")
        ExecuteNonQuery(strSQL.ToString)
        Return GetIdentity()

    End Function

    Public Sub UpdatePatientData(ByVal iPatientID As Integer, ByVal strXRef As String, ByVal strFirstName As String, ByVal strMiddle As String, ByVal strLastName As String, ByVal strGender As String, ByVal strDoB As String, ByVal strPhone As String, ByVal strEMail As String, ByVal strAddress As String)
        Dim strSQL As New StringBuilder


        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientData")
        strSQL.Append(_SET)
        strSQL.Append("[XRef]='" & dbSafe(strXRef) & "',")
        strSQL.Append("[FirstName]='" & dbSafe(strFirstName) & "',")
        strSQL.Append("[Middle]='" & dbSafe(strMiddle) & "',")
        strSQL.Append("[LastName]='" & dbSafe(strLastName) & "',")
        strSQL.Append("[Gender]='" & strGender & "',")
        strSQL.Append("[DOB]='" & strDoB & " 12:00:00',")
        strSQL.Append("[LastUpdate]='" & Now.ToString("yyyy-MM-dd hh:mm:ss") & "',")
        strSQL.Append("[Phone]='" & dbSafe(strPhone) & "',")
        strSQL.Append("[Email]='" & dbSafe(strEMail) & "',")
        strSQL.Append("[Address]='" & dbSafe(strAddress) & "'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID]=" & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub

    Public Sub DeletePatient(ByVal iPatientID As Integer)
        Dim strSQL As StringBuilder

        'SQL Code here
        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientData")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblVisitHistory")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblBCA")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)


        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblCholesterol")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblComposition")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblConditionNotes")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblMisc")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub

    Public Function GetPatientData(ByVal iPatientID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[XRef], [FirstName], [Middle], [LastName], [Gender], [DOB], [LastUpdate], [Phone], [Email], [Address]")
        strSQL.Append(_FROM)
        strSQL.Append("tblPatientData")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID]=" & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")

        Return ExecuteReader(strSQL.ToString)
    End Function


    Public Function SearchPatient(ByVal iPatientID As Integer, ByVal strXRef As String, ByVal strLastName As String, ByVal strFirstName As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[PatientID], [FirstName], [Middle], [LastName], [Gender], [DOB], [LastUpdate], [Phone], [Email] ")
        strSQL.Append(_FROM)
        strSQL.Append("tblPatientData")
        strSQL.Append(_WHERE)
        strSQL.Append("[isActive]='true'")
        If iPatientID > 0 Then
            strSQL.Append(_AND)
            strSQL.Append("[PatientID]=" & iPatientID.ToString)
        End If
        If strXRef <> "" Then
            strSQL.Append(_AND)
            strSQL.Append("[XRef] Like '" & dbSafe(strXRef) & "%'")
        End If
        If strLastName <> "" Then
            strSQL.Append(_AND)
            strSQL.Append("[LastName] Like '" & dbSafe(strLastName) & "%'")
        End If
        If strFirstName <> "" Then
            strSQL.Append(_AND)
            strSQL.Append("[FirstName] Like '" & dbSafe(strFirstName) & "%'")
        End If


        Return ExecuteReader(strSQL.ToString)

    End Function

End Class
