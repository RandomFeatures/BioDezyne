Public Class frmDexaVerify

    Private m_DexaID As String
    Private m_ScanID As String

    Public Property DexaID() As String
        Get
            Return m_DexaID
        End Get
        Set(ByVal value As String)
            m_DexaID = value
        End Set
    End Property

    Public Property ScanID() As String
        Get
            return m_ScanID
        End Get
        Set(ByVal value As String)
            m_ScanID = value
        End Set
    End Property


    Public Function LoadPatientData(ByVal strFirstName As String, ByVal strLastName As String) As Boolean
        Dim MyRow As DataGridViewRow
        Dim objDALDexa As New DAL.Dexa(My.Settings.DexaLocation)
        Dim iRow As DataRow
        Dim objDS As DataSet
        Dim strPatients(6) As String
        Dim bRtn As Boolean = False

        objDS = objDALDexa.FindPatient(strFirstName, strLastName)
        If objDS.Tables(0).Rows.Count > 0 Then
            bRtn = True
            gridDexaVisit.Rows.Clear()
            For Each iRow In objDS.Tables(0).Rows
                strPatients(0) = iRow.Item("Last_Name").ToString & ", " & iRow.Item("First_Name").ToString
                strPatients(1) = CType(iRow.Item("Last_Update"), DateTime).ToShortDateString
                strPatients(2) = CType(iRow.Item("BirthDate"), DateTime).ToShortDateString
                strPatients(3) = iRow.Item("Sex").ToString
                strPatients(4) = iRow.Item("Weight").ToString
                strPatients(5) = iRow.Item("Height").ToString
                strPatients(6) = iRow.Item("Patient_Key").ToString

                MyRow = New DataGridViewRow()
                MyRow.CreateCells(gridDexaVisit, strPatients)
                gridDexaVisit.Rows.Add(MyRow)

                MyRow = Nothing
            Next

            If gridDexaVisit.Rows.Count = 1 Then
                gridDexaVisit.Rows(0).Selected = True
                LoadVisiData(gridDexaVisit.SelectedRows(0).Cells(6).Value)
            End If

            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing
        End If

        objDALDexa = Nothing
        Return bRtn
    End Function

    Public Function VistSelectionOnly(ByVal strDexaPatienID) As Boolean
        Group1.Enabled = False
        Return LoadVisiData(strDexaPatienID)
    End Function

    Private Function LoadVisiData(ByVal strDexaPatienID) As Boolean
        Dim objDALDexa As New DAL.Dexa(My.Settings.DexaLocation)
        Dim MyRow As DataGridViewRow
        Dim iRow As DataRow
        Dim objDS As DataSet
        Dim strPatients(4) As String
        Dim bRtn As Boolean = False

        '        strSQL.Append("ScanID, Serial_Number, Analysis_Date, Scan_Date, Weight")
        Group2.Enabled = True
        objDS = objDALDexa.GetScanData(strDexaPatienID)
        If objDS.Tables(0).Rows.Count > 0 Then
            bRtn = True
            gridDexaScan.Rows.Clear()
            For Each iRow In objDS.Tables(0).Rows
                strPatients(0) = CType(iRow.Item("Analysis_Date"), DateTime).ToShortDateString
                strPatients(1) = CType(iRow.Item("Scan_Date"), DateTime).ToShortDateString
                strPatients(2) = iRow.Item("Serial_Number").ToString
                strPatients(3) = iRow.Item("Weight").ToString
                strPatients(4) = iRow.Item("ScanID").ToString

                MyRow = New DataGridViewRow()
                MyRow.CreateCells(gridDexaScan, strPatients)
                gridDexaScan.Rows.Add(MyRow)

                MyRow = Nothing
            Next

            If gridDexaScan.SelectedRows.Count > 0 Then
                gridDexaScan.SelectedRows(0).Selected = False
            End If

            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing
        End If

        objDALDexa = Nothing
        Return bRtn
    End Function


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        m_DexaID = ""
        'If gridDexaVisit.SelectedRows.Count = 0 Then Exit Sub

        If gridDexaVisit.SelectedRows.Count = 1 Then
            m_DexaID = gridDexaVisit.SelectedRows(0).Cells(6).Value
        End If

        If gridDexaScan.SelectedRows.Count = 1 Then
            m_ScanID = gridDexaScan.SelectedRows(0).Cells(4).Value
        End If

        Close()
    End Sub

    Private Sub gridDexaVisit_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridDexaVisit.CellMouseClick
        If gridDexaVisit.SelectedRows.Count > 0 Then
            LoadVisiData(gridDexaVisit.SelectedRows(0).Cells(6).Value)
        End If
    End Sub

 
    Private Sub frmDexaVerify_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If gridDexaScan.SelectedRows.Count > 0 Then
            gridDexaScan.SelectedRows(0).Selected = False
        End If
    End Sub

 
End Class
