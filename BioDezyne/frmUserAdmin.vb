Imports DAL 
Imports System.Data

Public Class frmUserAdmin
    Private m_UserID As Integer
    Private m_UserLogin As String
    Private m_Mode As UserMode
    Private objDALUser As DAL.Users
    Private m_localID As Integer

    Enum UserMode
        AddNew
        Edit
        None
    End Enum

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

#End Region

#Region "Private Functions"

    '*******************************************************************************
    ' Create New Objects
    '*******************************************************************************
    Public Sub Init()
        objDALUser = New DAL.Users
    End Sub

    '*******************************************************************************
    ' Load the current user list
    '*******************************************************************************
    Private Sub LoadUserGrid()
        Dim objDS As DataSet
        Dim objDSRow As DataRow
        Dim strRights As String
        Dim strUsers(3) As String
        Dim MyRow As DataGridViewRow

        gridUserList.Rows.Clear()

        objDS = objDALUser.GetUserList()

        For Each objDSRow In objDS.Tables(0).Rows
            If (btnShowAll.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked) Or _
               (objDSRow.Item("isActive")) Then

                If objDSRow.Item("Admin").ToString.ToLower = "true" Then
                    strRights = "Admin"
                Else
                    strRights = "User"
                End If
                strUsers(0) = objDSRow.Item("UserID").ToString
                strUsers(1) = objDSRow.Item("FirstName").ToString
                strUsers(2) = objDSRow.Item("LastName").ToString
                strUsers(3) = strRights

                MyRow = New DataGridViewRow()
                MyRow.CreateCells(gridUserList, strUsers)
                gridUserList.Rows.Add(MyRow)

                MyRow = Nothing
            End If
        Next

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


    End Sub

    '*******************************************************************************
    ' Setup for a new user
    '*******************************************************************************
    Public Sub AddNew()
        gpUserData.Enabled = True
        txtFirstName.Focus()
        m_Mode = UserMode.AddNew
        chkActive.Checked = True
    End Sub

    '*******************************************************************************
    ' Load and edit a given user
    '*******************************************************************************
    Public Sub Edit(ByVal iUserID As Integer)
        Dim objDS As DataSet

        m_Mode = UserMode.Edit
        gpUserData.Enabled = True
        ClearAll()

        objDS = objDALUser.GetUserData(iUserID)
        txtFirstName.Text = objDS.Tables(0).Rows(0).Item("firstname").ToString
        txtLastName.Text = objDS.Tables(0).Rows(0).Item("lastname").ToString
        txtLogin.Text = objDS.Tables(0).Rows(0).Item("login").ToString
        txtPassword.Text = objDS.Tables(0).Rows(0).Item("password").ToString
        chkAdmin.Checked = objDS.Tables(0).Rows(0).Item("admin")
        chkActive.Checked = objDS.Tables(0).Rows(0).Item("isActive")
        txtFirstName.Focus()

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

    End Sub

    '*******************************************************************************
    ' reset the form to the default mode
    '*******************************************************************************
    Private Sub Reset()
        gpUserData.Enabled = False
        m_Mode = UserMode.None
        m_localID = 0
        ClearAll()
    End Sub

    '*******************************************************************************
    ' Clear all data
    '*******************************************************************************
    Private Sub ClearAll()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        chkAdmin.Checked = False
        chkActive.Checked = False
    End Sub

    '*******************************************************************************
    ' Setup and show this form
    '*******************************************************************************
    Public Sub ShowMe()
        LoadUserGrid()
        Reset()
        Me.Show()
    End Sub

    '*******************************************************************************
    ' BuildPassword: simple password suggestion
    '*******************************************************************************
    Private Function BuildPassword(ByVal strpass As String)
        Dim tmpPass As String
        Dim tmpRnd As Integer

        Randomize()
        tmpRnd = CInt(Int((Now.Second * Rnd()) + 1))

        tmpPass = strpass

        If (tmpRnd Mod 2) <> 0 Then tmpPass = tmpPass.Replace("s", "$")
        If (tmpRnd Mod 2) = 0 Then tmpPass = tmpPass.Replace("e", "3")
        If (tmpRnd Mod 2) <> 0 Then tmpPass = tmpPass.Replace("o", "0")
        If (tmpRnd Mod 2) = 0 Then tmpPass = tmpPass.Replace("i", "1")
        If (tmpRnd Mod 2) <> 0 Then tmpPass = tmpPass.Replace("n", "#")
        If (tmpRnd Mod 2) = 0 Then tmpPass = tmpPass.Replace("l", "!")
        If (tmpRnd Mod 2) <> 0 Then tmpPass = tmpPass.Replace("r", "+")
        If (tmpRnd Mod 2) = 0 Then tmpPass = tmpPass.Replace("b", "6")
        If (tmpRnd Mod 2) <> 0 Then tmpPass = tmpPass.Replace("g", "9")

        Return tmpPass
    End Function
#End Region


#Region "Button Clicks"
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearAll()
        AddNew()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim tmpID As String

        If gridUserList.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridUserList.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            m_localID = tmpID
            Edit(m_localID)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bError As Boolean = False

        If txtFirstName.Text.Trim = "" Then
            Label1.ForeColor = Color.Red
            bError = True
        End If
        If txtLastName.Text.Trim = "" Then
            Label3.ForeColor = Color.Red
            bError = True
        End If
        If txtLogin.Text.Trim = "" Then
            Label2.ForeColor = Color.Red
            bError = True
        End If
        If txtPassword.Text.Trim = "" Then
            Label4.ForeColor = Color.Red
            bError = True
        End If

        If bError Then
            MsgBox("All fields are required")
            Exit Sub
        End If

        Select Case m_Mode
            Case UserMode.AddNew
                objDALUser.AddUser(txtFirstName.Text.Trim, txtLastName.Text.Trim, txtLogin.Text.Trim.ToLower, txtPassword.Text.Trim, chkAdmin.Checked, chkActive.Checked)
            Case UserMode.Edit
                objDALUser.UpdateUser(m_localID, txtFirstName.Text.Trim, txtLastName.Text.Trim, txtLogin.Text.Trim.ToLower, txtPassword.Text.Trim, chkAdmin.Checked, chkActive.Checked)
        End Select
        LoadUserGrid()
        Reset()
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black

    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        LoadUserGrid()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Reset()
    End Sub
#End Region

#Region "Object Events"

    '*******************************************************************************
    ' double click on the main grid
    '*******************************************************************************
    Private Sub gridUserList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridUserList.CellMouseDoubleClick
        Dim tmpID As String

        If gridUserList.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridUserList.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            m_localID = tmpID
            Edit(m_localID)
        End If
    End Sub

    Private Sub txtLastName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.Leave
        Dim strLogin As String = ""

        'dont change and existing loging
        If txtLogin.Text <> "" Then Exit Sub
        'a last name is imporant here so dont bother without one
        If txtLastName.Text = "" Then Exit Sub
        Try
            'create the login from 1st letter of the first name
            If txtFirstName.Text <> "" Then
                strLogin = txtFirstName.Text.Substring(0, 1)
            End If
            'and the first seven letters of the last name
            If txtLastName.Text.Length < 10 Then
                strLogin += txtLastName.Text.Substring(0, txtLastName.Text.Length)
            Else
                strLogin += txtLastName.Text.Substring(0, 10)
            End If
            'all logins are currently Lower case
            txtLogin.Text = strLogin.Trim.ToLower

            txtPassword.Text = BuildPassword(strLogin.Trim.ToLower)
        Catch ecp As Exception
            MsgBox("Error constucting a login. " & Chr(13) & Chr(10) & ecp.ToString)
        End Try
    End Sub

    Private Sub frmUserAdmin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        objDALUser = Nothing
    End Sub
#End Region

End Class
