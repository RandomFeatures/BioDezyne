Imports System.IO

Public Class frmManageDoc

#Region "Private Members"
    Private m_UserID As Integer
    Private m_UserLogin As String
    Private m_Mode As DocMode
    Private objDALDocs As DAL.Documents
    Private m_localID As Integer
    Private m_DocPath As String

    Enum DocMode
        AddNew
        Edit
        None
    End Enum

#End Region

#Region "Public Properties"
    Public Property UserID() As Integer
        Get
            Return m_UserID
        End Get
        Set(ByVal value As Integer)
            m_UserID = value
        End Set
    End Property

    Public Property UserLogin() As String
        Get
            Return m_UserLogin
        End Get
        Set(ByVal value As String)
            m_UserLogin = value
        End Set
    End Property

    Private Sub btnFindDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If OpenFile.ShowDialog Then
            txtDocFileName.Text = OpenFile.FileName
            txtDocTitle.Text = Path.GetFileNameWithoutExtension(OpenFile.FileName)
        End If
    End Sub
#End Region

#Region "Private Functions"

    '*******************************************************************************
    ' Create New Objects
    '*******************************************************************************
    Public Sub Init()
        Dim myReader As StreamReader
        objDALDocs = New DAL.Documents

        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) & "\config.dat") Then
            myReader = New StreamReader(Path.GetDirectoryName(Application.ExecutablePath) & "\config.dat")
            m_DocPath = myReader.ReadLine() & My.Settings.docpath
            myReader.Close()
            myReader = Nothing
        Else
            m_DocPath = Path.GetDirectoryName(Application.ExecutablePath) & My.Settings.docpath
        End If
    End Sub

    '*******************************************************************************
    ' Load the current Document list
    '*******************************************************************************
    Private Sub LoadDocumentGrid()
        Dim objDS As DataSet
        Dim objDSRow As DataRow
        Dim strUsers(2) As String
        Dim MyRow As DataGridViewRow

        gridDocList.Rows.Clear()

        objDS = objDALDocs.GetDocumentList()

        For Each objDSRow In objDS.Tables(0).Rows

            strUsers(0) = objDSRow.Item("ID").ToString
            strUsers(1) = objDSRow.Item("DocTitle").ToString
            strUsers(2) = objDSRow.Item("FileName").ToString

            MyRow = New DataGridViewRow()
            MyRow.CreateCells(gridDocList, strUsers)
            gridDocList.Rows.Add(MyRow)

            MyRow = Nothing
        Next

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


    End Sub

    '*******************************************************************************
    ' Setup for a new user
    '*******************************************************************************
    Public Sub AddNew()
        gpDocument.Enabled = True
        txtDocTitle.Focus()
        m_Mode = DocMode.AddNew
    End Sub

    '*******************************************************************************
    ' Load and edit a given user
    '*******************************************************************************
    Public Sub Edit(ByVal iUserID As Integer)
        Dim objDS As DataSet

        m_Mode = DocMode.Edit
        gpDocument.Enabled = True
        ClearAll()

        objDS = objDALDocs.GetDocument(iUserID)
        txtDocTitle.Text = objDS.Tables(0).Rows(0).Item("doctitle").ToString
        txtDocFileName.Text = m_DocPath & "\" & objDS.Tables(0).Rows(0).Item("filename").ToString
        txtDocTitle.Focus()

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

    End Sub

    '*******************************************************************************
    ' reset the form to the default mode
    '*******************************************************************************
    Private Sub Reset()
        gpDocument.Enabled = False
        m_Mode = DocMode.None
        m_localID = 0
        ClearAll()
    End Sub

    '*******************************************************************************
    ' Clear all data
    '*******************************************************************************
    Private Sub ClearAll()
        txtDocTitle.Text = ""
        txtDocFileName.Text = ""
    End Sub

    '*******************************************************************************
    ' Setup and show this form
    '*******************************************************************************
    Public Sub ShowMe()
        LoadDocumentGrid()
        Reset()
        Me.Show()
    End Sub

#End Region

#Region "Object Events"

    '*******************************************************************************
    ' double click on the main grid
    '*******************************************************************************
    Private Sub gridDocList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridDocList.CellMouseDoubleClick
        Dim tmpID As String

        If gridDocList.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridDocList.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            m_localID = tmpID
            Edit(m_localID)
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearAll()
        AddNew()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim tmpID As String

        If gridDocList.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridDocList.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            m_localID = tmpID
            Edit(m_localID)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim tmpID As String
        Dim mRes As MsgBoxResult
        Dim tmpFileName As String
        If gridDocList.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridDocList.SelectedRows.Item(0).Cells(0).Value
        tmpFileName = gridDocList.SelectedRows.Item(0).Cells(2).Value
        If tmpID <> "" Then
            mRes = MsgBox("Are you sure you want to delete " & gridDocList.SelectedRows.Item(0).Cells(1).Value & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo)
            If mRes = MsgBoxResult.Yes Then
                If File.Exists(m_DocPath & "\" & tmpFileName) Then
                    File.Delete(m_DocPath & "\" & tmpFileName)
                End If
                objDALDocs.DeleteDocument(tmpID)
                LoadDocumentGrid()
                Reset()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bError As Boolean
        Dim tmpFileName As String
        Dim msgResult As MsgBoxResult
        If txtDocTitle.Text.Trim = "" Then
            Label2.ForeColor = Color.Red
            bError = True
        End If

        If txtDocFileName.Text.Trim = "" Then
            Label1.ForeColor = Color.Red
            bError = True
        End If

        If txtDocTitle.Text.IndexOf("'") > 0 Then
            txtDocTitle.Text = txtDocTitle.Text.Replace("'", "")
        End If

        If bError Then
            MsgBox("All fields are required")
            Exit Sub
        End If

        tmpFileName = "document" & (gridDocList.Rows.Count + 1).ToString & ".pdf"
        'tmpFileName = Path.GetFileName(txtDocFileName.Text)

        If File.Exists(txtDocFileName.Text) Then


            If (txtDocFileName.Text.Trim <> m_DocPath & "\" & tmpFileName) Then
                If File.Exists(m_DocPath & "\" & tmpFileName) And (m_Mode = DocMode.Edit) Then
                    'overwrite existing files in edit mode
                    File.Delete(m_DocPath & "\" & tmpFileName)
                ElseIf File.Exists(m_DocPath & "\" & tmpFileName) And (m_Mode = DocMode.AddNew) Then
                    'no repeat names can be added
                    msgResult = MsgBox("A file named " & tmpFileName & " already exists in the system. You must rename the new file or delete the existing one before you can continue")
                    Exit Sub
                End If
                'copy the file to the system directory
                File.Copy(txtDocFileName.Text, m_DocPath & "\" & tmpFileName)
            End If

            Select Case m_Mode
                Case DocMode.AddNew
                    objDALDocs.AddDocument(txtDocTitle.Text.Trim, tmpFileName)
                Case DocMode.Edit
                    objDALDocs.UpdateDocument(m_localID, txtDocTitle.Text.Trim, tmpFileName)
            End Select
            LoadDocumentGrid()
            Reset()
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
        Else
            MsgBox(txtDocFileName.Text & " does not exist or is not accessable at this time")
        End If

    End Sub

    Private Sub frmManageDoc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        objDALDocs = Nothing
    End Sub

#End Region

End Class
