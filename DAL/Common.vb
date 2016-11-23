Imports System.text



Module Common

    Public Const _SELECT = " SELECT "
    Public Const _WHERE = " WHERE "
    Public Const _FROM = " FROM "
    Public Const _AND = " AND "
    Public Const _INSERT = " INSERT INTO "
    Public Const _VALUES = " VALUES "
    Public Const _UPDATE = " UPDATE "
    Public Const _SET = " SET "
    Public Const _DELETE = " DELETE "
    Public Const _ORDERBY = " ORDER BY "
    Public Const _SPACE = " "
    Public Const _JOIN = " JOIN "
    Public Const _LJOIN = " LEFT JOIN "
    Public Const _ON = " ON "
    Public Const _IDENTITY = "SELECT @@IDENTITY"


    Public m_Connection As System.Data.SQLite.SQLiteConnection


    Public Function GetDataset(ByVal objReader As SQLite.SQLiteDataReader) As DataSet
        Dim m_Table As New DataTable
        Dim objDS As New DataSet

        m_Table.TableName = objReader.GetSchemaTable().TableName

        'Add Tabel to Dataset
        objDS.Tables.Add(m_Table)
        'create DataSet
        objDS.Load(objReader, LoadOption.OverwriteChanges, m_Table)

        Return objDS

    End Function

    Public Function ExecuteReader(ByVal strSQLText As String) As DataSet
        Dim objCommand As New SQLite.SQLiteCommand(m_Connection)
        Dim objReader As SQLite.SQLiteDataReader

        objCommand.CommandText = strSQLText.ToString
        objReader = objCommand.ExecuteReader()

        Return GetDataset(objReader)
    End Function

    Public Function GetIdentity() As Integer
        Dim objCommand As New SQLite.SQLiteCommand(m_Connection)

        objCommand.CommandText = "SELECT last_insert_rowid();"
        Return Convert.ToInt32(objCommand.ExecuteScalar)
    End Function

    Public Sub ExecuteNonQuery(ByVal strSQLText As String)
        Dim objCommand As New SQLite.SQLiteCommand(m_Connection)
        objCommand.CommandText = strSQLText.ToString
        objCommand.ExecuteNonQuery()
    End Sub

    Public Function dbSafe(ByVal tmpStr As String) As String
        Return tmpStr.Replace("'", "")
    End Function
End Module

