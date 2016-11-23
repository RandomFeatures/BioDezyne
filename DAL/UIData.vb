Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO
Public Class UIData

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

    Public Function GetConditionList() As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[ID], [Desc]")
        strSQL.Append(_FROM)
        strSQL.Append("tblConditionList")
        strSQL.Append(_ORDERBY)
        strSQL.Append("[Desc]")

        Return ExecuteReader(strSQL.ToString)

    End Function
End Class
