
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO

Public Class Documents



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

    Public Function GetDocumentList() As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[id], [doctitle], [filename]")
        strSQL.Append(_FROM)
        strSQL.Append("tblDocuments")

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Sub AddDocument(ByVal strTitle As String, ByVal strFileName As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblDocuments([doctitle], [filename])")
        strSQL.Append(_VALUES)
        strSQL.Append("('" & dbSafe(strTitle) & "','" & dbSafe(strFileName) & "')")

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Sub UpdateDocument(ByVal id As Integer, ByVal strTitle As String, ByVal strFileName As String)
        Dim strSQL As New StringBuilder


        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblDocuments")
        strSQL.Append(_SET)
        strSQL.Append("[doctitle]='" & dbSafe(strTitle) & "',")
        strSQL.Append("[filename]='" & dbSafe(strFileName) & "'")
        strSQL.Append(_WHERE)
        strSQL.Append("[id]=" & id.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetDocument(ByVal iID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[doctitle], [filename]")
        strSQL.Append(_FROM)
        strSQL.Append("tblDocuments")
        strSQL.Append(_WHERE)
        strSQL.Append("[id]=" & iID.ToString)


        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Sub DeleteDocument(ByVal iID As Integer)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_DELETE)
        strSQL.Append(_FROM)
        strSQL.Append("tblDocuments")
        strSQL.Append(_WHERE)
        strSQL.Append("[id]=" & iID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub


End Class

