
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO

Public Class Users
    

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

    Public Function GetUserList() As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[userid], [firstname], [lastname], [admin], [isActive]")
        strSQL.Append(_FROM)
        strSQL.Append("tblusers")

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Sub AddUser(ByVal strFirstName As String, ByVal strLastName As String, ByVal strLogin As String, ByVal strPass As String, ByVal bAdmin As Boolean, ByVal bActive As Boolean)
        Dim iActive As Integer = 0
        Dim iAdmin As Integer = 0
        Dim strSQL As New StringBuilder

        If bActive Then iActive = 1
        If bAdmin Then iAdmin = 1

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblusers([firstname], [lastname], [login], [password], [admin], [isactive])")
        strSQL.Append(_VALUES)
        strSQL.Append("('" & dbSafe(strFirstName) & "','" & dbSafe(strLastName) & "','" & dbSafe(strLogin) & "','" & dbSafe(strPass) & "'," & iAdmin.ToString & "," & iActive.ToString & ")")

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Sub UpdateUser(ByVal iUserID As Integer, ByVal strFirstName As String, ByVal strLastName As String, ByVal strLogin As String, ByVal strPass As String, ByVal bAdmin As Boolean, ByVal bActive As Boolean)
        Dim iActive As Integer = 0
        Dim iAdmin As Integer = 0
        Dim strSQL As New StringBuilder

        If bActive Then iActive = 1
        If bAdmin Then iAdmin = 1

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblusers ")
        strSQL.Append(_SET)
        strSQL.Append("[firstname]='" & dbSafe(strFirstName) & "',")
        strSQL.Append("[lastname]='" & dbSafe(strLastName) & "',")
        strSQL.Append("[login]='" & dbSafe(strLogin) & "',")
        strSQL.Append("[password]='" & dbSafe(strPass) & "',")
        strSQL.Append("[admin]=" & iAdmin.ToString & ",")
        strSQL.Append("[isActive]=" & iActive.ToString)
        strSQL.Append(_WHERE)
        strSQL.Append("[userid] = " & iUserID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetUserData(ByVal iUserID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[firstname], [lastname], [login], [password], [admin], [isActive]")
        strSQL.Append(_FROM)
        strSQL.Append("tblusers")
        strSQL.Append(_WHERE)
        strSQL.Append("[userid] = " & iUserID.ToString)

        
        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function GetUserLogin(ByVal strUserName As String, ByVal strPassword As String) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[userid], [firstname], [lastname], [admin], [isActive]")
        strSQL.Append(_FROM)
        strSQL.Append("tblusers")
        strSQL.Append(_WHERE)
        strSQL.Append("[login] = '" & dbSafe(strUserName.ToString) & "'")
        strSQL.Append(_AND)
        strSQL.Append("[password] = '" & dbSafe(strPassword.ToString) & "'")

        Return ExecuteReader(strSQL.ToString)
    End Function

End Class

