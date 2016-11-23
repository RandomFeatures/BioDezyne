Public Class frmSearch
    Private m_UserID As Integer
    Private m_UserLogin As String

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

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPatientID.Text = ""
        txtXref.Text = ""
        txtLastName.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub LoadPatientList(ByVal objDS As DataSet)
        Dim iRow As DataRow
        Dim strPatient(6) As String
        Dim MyRow As DataGridViewRow

        gridPatients.Rows.Clear()

        For Each iRow In objDS.Tables(0).Rows

            strPatient(0) = iRow.Item("PatientID").ToString
            strPatient(1) = iRow.Item("LastName").ToString & ", " & iRow.Item("FirstName").ToString
            strPatient(3) = CType(iRow.Item("DOB"), DateTime).ToShortDateString
            strPatient(2) = iRow.Item("Gender").ToString
            strPatient(4) = iRow.Item("Phone").ToString
            strPatient(5) = iRow.Item("Email").ToString

            MyRow = New DataGridViewRow()
            MyRow.CreateCells(gridPatients, strPatient)
            gridPatients.Rows.Add(MyRow)

            MyRow = Nothing
        Next
    End Sub

    Public Sub NewSearch()
        txtPatientID.Text = ""
        txtXref.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        Search()
    End Sub

    Public Sub Search()
        Dim objDALPatient As New DAL.PatientData
        Dim objDS As DataSet
        Dim iSearch As Integer

        If txtPatientID.Text = "" Then
            iSearch = 0
        Else
            iSearch = txtPatientID.Text
        End If
        objDS = objDALPatient.SearchPatient(iSearch, txtXref.Text, txtLastName.Text, txtFirstName.Text)
        LoadPatientList(objDS)
    End Sub
    Private Sub frmSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim tmpID As String

        If gridPatients.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridPatients.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            frmMain.ViewPatient(tmpID)
        End If
    End Sub

    Private Sub btnHidenSeach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHidenSeach.Click
        btnSearch_Click(sender, e)
    End Sub

    Private Sub gridPatients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPatients.DoubleClick
        btnView_Click(sender, e)
    End Sub


    Private Sub btnDeletePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePatient.Click
        Dim tmpID As String
        Dim objDALPatient As New DAL.PatientData

        If gridPatients.SelectedRows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure you want to delete this patient?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            tmpID = gridPatients.SelectedRows.Item(0).Cells(0).Value
            If tmpID <> "" Then
                objDALPatient.DeletePatient(tmpID)
            End If
        End If
        Search()
    End Sub
End Class
