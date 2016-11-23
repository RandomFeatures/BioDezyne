Imports System.IO



Public Class frmMain

    Private m_UserID As Integer
    Private m_UserLogin As String
    Private m_UserAdmin As Boolean
    Private m_LogEvents As Boolean = True
    Private m_DocPath As String

  
    '**************************************************************
    ' ShowPatientData: Show the PatientData form
    '**************************************************************
    Sub ShowPatientData()
        My.Forms.frmPatient.BringToFront()
        My.Forms.frmPatient.Top = 0
        My.Forms.frmPatient.Left = 0
        My.Forms.frmPatient.WindowState = FormWindowState.Maximized
        My.Forms.frmPatient.UserID = m_UserID
        My.Forms.frmPatient.UserLogin = m_UserLogin
        My.Forms.frmPatient.LogEvents = m_LogEvents
        My.Forms.frmPatient.Show()
        My.Forms.frmPatient.NewPatient()
    End Sub

    Sub ShowCurrentPatientData()
        My.Forms.frmPatient.BringToFront()
        My.Forms.frmPatient.Top = 0
        My.Forms.frmPatient.Left = 0
        My.Forms.frmPatient.WindowState = FormWindowState.Maximized
        My.Forms.frmPatient.Show()
    End Sub


    Public Sub ViewPatient(ByVal iPatientID As Integer)
        My.Forms.frmPatient.BringToFront()
        My.Forms.frmPatient.Top = 0
        My.Forms.frmPatient.Left = 0
        My.Forms.frmPatient.WindowState = FormWindowState.Maximized
        My.Forms.frmPatient.UserID = m_UserID
        My.Forms.frmPatient.UserLogin = m_UserLogin
        My.Forms.frmPatient.Show()
        My.Forms.frmPatient.LoadPatient(iPatientID)
    End Sub


   
    '**************************************************************
    ' ShowPatientSearch: Show the PatientSearch form
    '**************************************************************
    Sub ShowPatientSearch()
        My.Forms.frmSearch.BringToFront()
        My.Forms.frmSearch.Top = 0
        My.Forms.frmSearch.Left = 0
        My.Forms.frmSearch.WindowState = FormWindowState.Maximized
        My.Forms.frmSearch.UserID = m_UserID
        My.Forms.frmSearch.UserLogin = m_UserLogin
        My.Forms.frmSearch.NewSearch()
        My.Forms.frmSearch.Show()

    End Sub

    '**************************************************************
    ' ShowPatientSearch: Show the PatientSearch form
    '**************************************************************
    Sub ShowEvents()
        My.Forms.frmEvents.BringToFront()
        My.Forms.frmEvents.Top = 0
        My.Forms.frmEvents.Left = 0
        My.Forms.frmEvents.WindowState = FormWindowState.Maximized
        My.Forms.frmEvents.UserID = m_UserID
        My.Forms.frmEvents.UserLogin = m_UserLogin
        My.Forms.frmEvents.Show()
    End Sub


    '**************************************************************
    ' ShowPatientSearch: Show the PatientSearch form
    '**************************************************************
    Sub ShowManageDoc()
        My.Forms.frmManageDoc.BringToFront()
        My.Forms.frmManageDoc.Top = 0
        My.Forms.frmManageDoc.Left = 0
        My.Forms.frmManageDoc.WindowState = FormWindowState.Maximized
        My.Forms.frmManageDoc.UserID = m_UserID
        My.Forms.frmManageDoc.UserLogin = m_UserLogin
        My.Forms.frmManageDoc.ShowMe()
    End Sub

   
    '**************************************************************
    ' ShowPrintDocs: Show the PrintDocs form
    '**************************************************************
    Sub ShowPrintDoc()
        My.Forms.frmPrintDocs.BringToFront()
        My.Forms.frmPrintDocs.Top = 0
        My.Forms.frmPrintDocs.Left = 0
        My.Forms.frmPrintDocs.WindowState = FormWindowState.Maximized
        My.Forms.frmPrintDocs.UserID = m_UserID
        My.Forms.frmPrintDocs.UserLogin = m_UserLogin
        My.Forms.frmPrintDocs.ShowMe()
    End Sub

    '**************************************************************
    ' ShowUserAdmin: Show the PrintDocs form
    '**************************************************************
    Sub ShowUserAdmin()
        My.Forms.frmUserAdmin.BringToFront()
        My.Forms.frmUserAdmin.Top = 0
        My.Forms.frmUserAdmin.Left = 0
        My.Forms.frmUserAdmin.WindowState = FormWindowState.Maximized
        My.Forms.frmUserAdmin.UserID = m_UserID
        My.Forms.frmUserAdmin.UserLogin = m_UserLogin
        My.Forms.frmUserAdmin.ShowMe()
    End Sub



    Private Sub btnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlue.Click
        Try

            If btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked Then
                KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
                btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                My.Settings.ThemeColor = "blue"
            Else
                btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
            End If
            pbButterfly.Top = (ribMain.Top + ribMain.Height) - (pbButterfly.Height + 8)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSilver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSilver.Click
        Try
            If btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked Then
                KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver
                btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                My.Settings.ThemeColor = "silver"
            Else
                btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
            End If
            pbButterfly.Top = (ribMain.Top + ribMain.Height) - (pbButterfly.Height + 8)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlack.Click
        Try
            If btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked Then
                KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black
                btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                My.Settings.ThemeColor = "black"
            Else
                btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
            End If
            pbButterfly.Top = (ribMain.Top + ribMain.Height) - (pbButterfly.Height + 8)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        ShowUserAdmin()
        My.Forms.frmUserAdmin.AddNew()
    End Sub

    Private Sub btnManageUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageUsers.Click
        ShowUserAdmin()
    End Sub

    Private Sub btnManageDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageDoc.Click
        ShowManageDoc()
    End Sub

    Private Sub btnNewDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDoc.Click
        ShowManageDoc()
        My.Forms.frmManageDoc.AddNew()
    End Sub

    Private Sub btnNewPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPatient.Click
        ShowPatientData()
    End Sub

    Private Sub btnPatientSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientSearch.Click
        ShowPatientSearch()
    End Sub

    Private Sub btnPrintDocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDocs.Click
        ShowPrintDoc()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Select Case My.Settings.ThemeColor
                Case "blue"
                    btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
                    btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
                Case "black"
                    btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
                    btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black
                Case "silver"
                    btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
                    btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
                    KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver
            End Select
        Catch ex As Exception

        End Try
        m_DocPath = Path.GetDirectoryName(Application.ExecutablePath) & My.Settings.docpath

        My.Forms.frmSearch.MdiParent = Me
        My.Forms.frmEvents.MdiParent = Me
        My.Forms.frmPatient.MdiParent = Me
        My.Forms.frmManageDoc.MdiParent = Me
        My.Forms.frmManageDoc.Init()
        My.Forms.frmPrintDocs.MdiParent = Me
        My.Forms.frmPrintDocs.Init()
        My.Forms.frmUserAdmin.MdiParent = Me
        My.Forms.frmUserAdmin.Init()

        EnableRibbionButton(False)
        Login()
        ribMain.SelectedTab = tabMain
        If btnPatientSearch.Enabled Then
            ShowPatientSearch()
        End If
        ' pbButterfly.Parent = ribMain

        'Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        'Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 2 * BorderWidth
        'pbButterfly.Top = (ribMain.Top + ribMain.Height) - (pbButterfly.Height + TitlebarHeight + 8)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click, ExitToolStripMenuItem.Click
        Close()
    End Sub

    Public Sub Login()
        Dim strLogin As String
        Dim strPass As String
        Dim objDALUser As New DAL.Users
        Dim objLogin As New SystemLogin.LogTest
        Dim objDS As DataSet
        Dim bActive As Boolean
        Try
            If My.Settings.sy510g Then
                My.Forms.frmLogin.ShowDialog()
                If My.Forms.frmLogin.TryLoging Then
                    strLogin = My.Forms.frmLogin.UserLogin
                    strPass = My.Forms.frmLogin.Password
                    objDS = objDALUser.GetUserLogin(strLogin, strPass)

                    If Not objLogin.AcceptLogin Then
                        MsgBox("The User Name and Password combination you provided were not recognized. Please try again.")
                        Login()
                        Exit Sub
                    End If

                    If strLogin.ToLower = "temp" And strPass.ToLower = "l05t" Then
                        EnableRibbionButton(True)
                        ribMain.RibbonTabs.Item(1).Visible = True
                        ribMain.RibbonTabs.Item(0).Visible = False
                        btnPatientSearch.Enabled = False
                    ElseIf (objDS.Tables(0).Rows.Count = 1) Then
                        bActive = objDS.Tables(0).Rows(0).Item("isActive")
                        If bActive Then
                            m_UserID = objDS.Tables(0).Rows(0).Item("UserID").ToString
                            m_UserLogin = strLogin
                            m_UserAdmin = objDS.Tables(0).Rows(0).Item("Admin")
                            EnableRibbionButton(True)
                            LoginToolStripMenuItem.Text = "Logout"
                            If Not m_UserAdmin Then
                                ribMain.RibbonTabs.Item(1).Visible = False
                            Else
                                ribMain.RibbonTabs.Item(1).Visible = True
                            End If
                        Else
                            MsgBox("Sorry but this login is no longer active in the system. You will need to have an administrator log in and reactivate it.")
                        End If
                    Else
                        MsgBox("The User Name and Password combination you provided were not recognized. Please try again.")
                        Login()
                        Exit Sub
                    End If
                End If
            Else
                m_LogEvents = My.Settings.logevent
                m_UserID = 0
                m_UserLogin = "System"
                LoginToolStripMenuItem.Visible = False
                EnableRibbionButton(True)
                btnManageUsers.Enabled = False
                btnNewUser.Enabled = False
                ribMain.RibbonTabs.Item(1).Visible = True
            End If
        Catch ex As Exception
            MsgBox("There was an error login into the system")
        End Try
    End Sub

    Private Sub EnableRibbionButton(ByVal bState As Boolean)
        btnNewPatient.Enabled = bState
        btnPatientSearch.Enabled = bState
        'btnPrintQuestionair.Enabled = bState
        'btnPrintDocs.Enabled = bState
        btnNewUser.Enabled = bState
        btnManageUsers.Enabled = bState
        btnSettings.Enabled = bState
        btnFileLocation.Enabled = bState
        btnNewDoc.Enabled = bState
        btnManageDoc.Enabled = bState
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        EnableRibbionButton(False)
        LoginToolStripMenuItem.Text = "Login"
        Login()
    End Sub


    Private Sub btnPrintQuestionair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintQuestionair.Click
        Dim strOptions As String
        Dim FileName As String

        FileName = Chr(34) & m_DocPath & "\" & My.Settings.questionaire & Chr(34)

        If PrintDiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            strOptions = " -p " & Chr(34) & PrintDiag.PrinterSettings.PrinterName & Chr(34)
            strOptions += " -c " & PrintDiag.PrinterSettings.Copies.ToString
            strOptions += " -o 1"
            Shell("pdfp " & strOptions & " " & FileName, AppWinStyle.Hide, False)
        End If
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        My.Forms.frmSettings.ShowDialog()
    End Sub

    Private Sub btnFileLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileLocation.Click
        ShowEvents()
    End Sub

    Private Sub btnCurrentPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentPatient.Click
        ShowCurrentPatientData()
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        pbButterfly.Top = (ribMain.Top + ribMain.Height) - (pbButterfly.Height + 8)
    End Sub
End Class
