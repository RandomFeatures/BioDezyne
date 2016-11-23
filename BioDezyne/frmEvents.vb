Public Class frmEvents
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
        txtVisitID.Text = ""
        txtLastName.Text = ""
        txtPatientID.Text = ""
        txtLastName.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objDALEvent As New DAL.Events
        Dim objDS As DataSet
        Dim iPatientID As Integer = 0
        Dim iVisitID As Integer = 0
        Dim StartDate As String
        Dim EndDate As String


        StartDate = dtStart.Value.ToString("yyyy-MM-dd")
        EndDate = dtEnd.Value.ToString("yyyy-MM-dd")

        If txtPatientID.Text <> "" Then
            Try
                iPatientID = Integer.Parse(txtPatientID.Text)
            Catch ex As Exception
            End Try
        End If

        If txtVisitID.Text <> "" Then
            Try
                iVisitID = Integer.Parse(txtVisitID.Text)
            Catch ex As Exception
            End Try
        End If

        objDS = objDALEvent.GetPatientEvents(iPatientID, iVisitID, StartDate, EndDate, txtLastName.Text.Trim)
        LoadEventList(objDS)

    End Sub

    Private Sub LoadEventList(ByVal objDS As DataSet)
        Dim iRow As DataRow
        Dim strEvent(5) As String
        Dim MyRow As DataGridViewRow

        gridEvents.Rows.Clear()

        For Each iRow In objDS.Tables(0).Rows

            strEvent(0) = iRow.Item("VisitID").ToString
            strEvent(1) = iRow.Item("LastName").ToString & ", " & iRow.Item("FirstName").ToString
            strEvent(2) = iRow.Item("EventDesc").ToString
            strEvent(3) = iRow.Item("Login").ToString
            strEvent(4) = CType(iRow.Item("EventDateTime"), DateTime).ToShortDateString
            strEvent(5) = CType(iRow.Item("VisitDate"), DateTime).ToShortDateString

            MyRow = New DataGridViewRow()
            MyRow.CreateCells(gridEvents, strEvent)
            gridEvents.Rows.Add(MyRow)

            MyRow = Nothing
        Next
    End Sub
End Class
