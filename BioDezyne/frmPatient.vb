Imports System.Xml
Imports System.IO

Public Class frmPatient

#Region "Private Member"

    Private Enum MajStatus
        NewPatient = 0
        ExistPatient = 1
        None = 2
    End Enum

    Private Enum MinStatus
        None = 0
        NewVisit = 1
        Saved = 2
    End Enum

    Private m_UserID As Integer
    Private m_UserLogin As String
    Private m_LogEvents As Boolean
    Private m_ConditionList As List(Of Integer)
    Private m_MajorStatus As MajStatus = MajStatus.None
    Private m_MinorStatus As MinStatus = MinStatus.None
    Private objDALPatient As New DAL.PatientData
    Private objDALVisit As New DAL.VisitHistory
    Private objDALEvent As New DAL.Events
    Private m_PatientID As Integer = 0
    Private m_VisitID As Integer = 0
    Private m_Path As String = ""
    Private m_UseDexa As Boolean
    Private m_DexaPatientID As String = ""
    Private m_DexaVisitID As String = ""
    Private m_LastVisitID As Integer = 0

#End Region

#Region "Public Properties"
    Public Property PatientID() As Integer
        Get
            Return m_PatientID
        End Get
        Set(ByVal value As Integer)
            m_PatientID = value
        End Set
    End Property
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

    Public Property LogEvents() As Boolean
        Get
            Return m_LogEvents
        End Get
        Set(ByVal value As Boolean)
            m_LogEvents = value
        End Set
    End Property
    Public Property UseDexa() As Boolean
        Get
            Return m_UseDexa
        End Get
        Set(ByVal value As Boolean)
            m_UseDexa = value
        End Set
    End Property
#End Region



    Private Sub frmPatient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 8 colors for when the tab is not selected
        Dim _normal = New Color() {Color.FromArgb(156, 193, 182), Color.FromArgb(247, 184, 134), _
                                    Color.FromArgb(217, 173, 194), Color.FromArgb(246, 250, 125), _
                                    Color.FromArgb(179, 166, 190), Color.FromArgb(234, 214, 163), _
                                   Color.FromArgb(165, 194, 215), Color.FromArgb(188, 168, 225), _
                                    Color.FromArgb(156, 193, 182), Color.FromArgb(247, 184, 134)}

        ' 8 colors for when the tab is selected
        Dim _select = New Color() {Color.FromArgb(200, 221, 215), Color.FromArgb(251, 216, 188), _
                                    Color.FromArgb(234, 210, 221), Color.FromArgb(250, 252, 183), _
                                    Color.FromArgb(213, 206, 219), Color.FromArgb(244, 232, 204), _
                                    Color.FromArgb(205, 221, 233), Color.FromArgb(218, 207, 239), _
                                    Color.FromArgb(200, 221, 215), Color.FromArgb(251, 216, 188)}
        Dim iLoop As Integer

        For iLoop = 0 To MainNavigator.Pages.Count - 1

            ' Get the colors to use for this new page
            Dim normal As Color = _normal(iLoop)
            Dim selected As Color = _select(iLoop)

            ' Set the page colors
            MainNavigator.Pages(iLoop).StateNormal.Page.Color1 = selected
            MainNavigator.Pages(iLoop).StateNormal.Page.Color2 = normal
            MainNavigator.Pages(iLoop).StateNormal.Tab.Back.Color2 = normal
            MainNavigator.Pages(iLoop).StateSelected.Tab.Back.Color2 = selected
            MainNavigator.Pages(iLoop).StateTracking.Tab.Back.Color2 = Color.FromArgb(255, 240, 200)
            MainNavigator.Pages(iLoop).StatePressed.Tab.Back.Color2 = Color.FromArgb(255, 240, 200)


            ' We want the page drawn as a gradient with colors relative to its own area
            MainNavigator.Pages(iLoop).StateCommon.Page.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local
            MainNavigator.Pages(iLoop).StateCommon.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.QuarterPhase

        Next

        Dim NextColor As Integer = iLoop
        For iLoop = 0 To patientNav.Pages.Count - 1

            ' Get the colors to use for this new page
            Dim normal As Color = _normal(NextColor)
            Dim selected As Color = _select(NextColor)

            ' Set the page colors
            patientNav.Pages(iLoop).StateNormal.Page.Color1 = selected
            patientNav.Pages(iLoop).StateNormal.Page.Color2 = normal
            patientNav.Pages(iLoop).StateNormal.Tab.Back.Color2 = normal
            patientNav.Pages(iLoop).StateNormal.Tab.Back.Color1 = normal

            patientNav.Pages(iLoop).StateSelected.Tab.Back.Color1 = selected
            patientNav.Pages(iLoop).StateSelected.Tab.Back.Color2 = selected
            patientNav.Pages(iLoop).StateTracking.Tab.Back.Color2 = Color.FromArgb(255, 240, 200)
            patientNav.Pages(iLoop).StatePressed.Tab.Back.Color2 = Color.FromArgb(255, 240, 200)


            ' We want the page drawn as a gradient with colors relative to its own area
            patientNav.Pages(iLoop).StateCommon.Page.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local
            patientNav.Pages(iLoop).StateCommon.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.QuarterPhase
            'NextColor += 1
        Next

        m_Path = Path.GetDirectoryName(Application.ExecutablePath)


        m_UseDexa = My.Settings.UseDexa


        MainNavigator.SelectedPage = pgHistory
        patientNav.SelectedPage = pgPatient

        m_ConditionList = New List(Of Integer)

        LoadConditionList()

        Dim tmpYear As DateTime = Now
        For iLoop = 0 To 99
            cbDobyyyy.Items.Add((tmpYear.Year - iLoop).ToString)
        Next
    End Sub

    Private Sub LoadConditionList()
        Dim objDS As DataSet
        Dim objDALUI As New DAL.UIData
        Dim objRow As DataRow
        Dim strCondition(3) As String
        Dim MyRow As DataGridViewRow

        objDS = objDALUI.GetConditionList()
        dgConditions.Rows.Clear()


        For Each objRow In objDS.Tables(0).Rows
            m_ConditionList.Add(objRow.Item("ID"))
            strCondition(0) = "false"
            strCondition(1) = "false"
            strCondition(2) = objRow.Item("Desc")

            MyRow = New DataGridViewRow()
            MyRow.CreateCells(dgConditions, strCondition)
            dgConditions.Rows.Add(MyRow)

            MyRow = Nothing
        Next

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing
    End Sub


    Public Sub NewPatient()
        Dim msgrlt As MsgBoxResult = MsgBoxResult.Yes

        If m_MinorStatus <> MinStatus.None Or m_MajorStatus <> MajStatus.None Then
            msgrlt = MsgBox("It appears that you are currently editing a patient. If you continue all unsaved changes will be lost. Do you wish to continue?", MsgBoxStyle.YesNo)
        End If
        If msgrlt = MsgBoxResult.Yes Then
            My.Forms.frmMain.btnCurrentPatient.Enabled = True
            m_MajorStatus = MajStatus.NewPatient
            m_MinorStatus = MinStatus.None
            m_PatientID = 0
            m_VisitID = 0
            gridVisitHistory.Rows.Clear()
            ClearVisitFields()
            ClearPatientFields()
            SetVistitFieldsStatus(True)
            patientNav.SelectedPage = pgPatient
            MainNavigator.SelectedPage = pgQuestion
            txtFirstName.Focus()
        End If

    End Sub

    Public Sub LoadPatient(ByVal iPatientID As Integer)
        Dim objDS As DataSet
        Dim iRow As DataRow

        My.Forms.frmMain.btnCurrentPatient.Enabled = True
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        m_PatientID = iPatientID
        m_MajorStatus = MajStatus.ExistPatient
        m_MinorStatus = MinStatus.None

        ClearVisitFields()
        ClearPatientFields()
        SetVistitFieldsStatus(False)
        patientNav.SelectedPage = pgPatient
        MainNavigator.SelectedPage = pgHistory

        'Patient data
        objDS = objDalPatient.GetPatientData(iPatientID)
        iRow = objDS.Tables(0).Rows(0)
        gbMain.ValuesSecondary.Description = "Patient ID: " & iPatientID.ToString
        m_DexaPatientID = iRow.Item("XRef").ToString
        txtFirstName.Text = iRow.Item("FirstName").ToString
        txtLastName.Text = iRow.Item("LastName").ToString
        txtMI.Text = iRow.Item("Middle").ToString
        If iRow.Item("DOB").ToShortDateString <> "01/01/1900" Then
            cbDOBmm.SelectedIndex = CType(iRow.Item("DOB"), DateTime).Month - 1
            txtDobdd.Text = CType(iRow.Item("DOB"), DateTime).Day.ToString("0#")
            cbDobyyyy.SelectedIndex = cbDobyyyy.FindStringExact(CType(iRow.Item("DOB"), DateTime).Year.ToString("####"))
        End If
        txtDobdd.ForeColor = Color.BlueViolet
        cbDOBmm.ForeColor = Color.BlueViolet
        txtPhone.Text = FormatPhoneNum(iRow.Item("Phone").ToString)
        txtEmail.Text = iRow.Item("Email").ToString
        txtAddress.Text = iRow.Item("Address").ToString
        cbGender.SelectedIndex = cbGender.Items.IndexOf(iRow.Item("Gender").ToString)

        'clean up 
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

        loadVisitHistory(iPatientID)
        Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub loadVisitHistory(ByVal iPatientID As Integer)
        Dim objDS As DataSet
        Dim MyRow As DataGridViewRow
        Dim iRow As DataRow
        Dim strVisits(5) As String

        m_LastVisitID = 0
        gridVisitHistory.Rows.Clear()
        'load visit history                       
        objDS = objDALVisit.GetPatientVisitHistory(iPatientID)

        For Each iRow In objDS.Tables(0).Rows

            strVisits(0) = iRow.Item("VisitID").ToString
            strVisits(1) = CType(iRow.Item("VisitDate"), DateTime).ToShortDateString
            strVisits(2) = CType(iRow.Item("Weight"), Double).ToString("##0.00")
            strVisits(3) = iRow.Item("BPSystolic").ToString & "/" & iRow.Item("BPDiastolic").ToString
            strVisits(4) = iRow.Item("TotalChol").ToString
            strVisits(5) = iRow.Item("Glucose").ToString

            If iRow.Item("VisitID") > m_LastVisitID Then
                m_LastVisitID = iRow.Item("VisitID")
            End If

            MyRow = New DataGridViewRow()
            MyRow.CreateCells(gridVisitHistory, strVisits)
            gridVisitHistory.Rows.Add(MyRow)

            MyRow = Nothing
        Next

        'clean up 
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing
    End Sub

    Private Function SavePatient() As Boolean
        Dim bError As Boolean = False
        Dim rtn As Boolean = True
        Dim tmpStr As String

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If txtFirstName.Text.Trim = "" Then
            lblFirst.ForeColor = Color.Red
            bError = True
        Else
            lblFirst.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If

        If txtLastName.Text.Trim = "" Then
            lblLast.ForeColor = Color.Red
            bError = True
        Else
            lblLast.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
        If cbGender.Text.Trim = "" Then
            lblGender.ForeColor = Color.Red
            bError = True
        Else
            lblGender.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
        If cbDOBmm.SelectedIndex = -1 Or txtDobdd.Text.Trim = "" Or cbDobyyyy.SelectedIndex = -1 Then
            lblDob.ForeColor = Color.Red
            bError = True
        Else
            lblDob.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If

        Label75.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

        If txtEmail.Text.Trim <> "" Then
            If Not ValidEmail(txtEmail.Text.Trim) Then
                Label75.ForeColor = Color.Red
                bError = True
                MsgBox("An email address is not required but if you choose to include one then it must be a valid email address.")
            End If
        End If

        If bError Then
            patientNav.SelectedPage = pgPatient
            MsgBox("Some required fields are missi You will need to complete all required fields before you can save.")
            Return False
            Exit Function
        End If

        tmpStr = cbDobyyyy.Text & "-" & (cbDOBmm.SelectedIndex + 1).ToString("0#") & "-" & txtDobdd.Text
        Try
            If m_PatientID = 0 Then
                m_PatientID = objDALPatient.InsertPatientData(m_DexaPatientID, txtFirstName.Text.Trim, txtMI.Text.Trim, txtLastName.Text.Trim, cbGender.Text.Trim, tmpStr, UnFormatPhoneNum(txtPhone.Text), txtEmail.Text.Trim, txtAddress.Text.Trim)
                gbMain.ValuesSecondary.Description = "Patient ID: " & m_PatientID.ToString
                If m_MinorStatus <> MinStatus.Saved And m_LogEvents Then
                    objDALEvent.InsertNewEvent(m_PatientID, 0, m_UserID, 100, "")
                End If
            Else
                objDALPatient.UpdatePatientData(m_PatientID, m_DexaPatientID, txtFirstName.Text.Trim, txtMI.Text.Trim, txtLastName.Text.Trim, cbGender.Text.Trim, tmpStr, UnFormatPhoneNum(txtPhone.Text), txtEmail.Text.Trim, txtAddress.Text.Trim)
                If m_MinorStatus <> MinStatus.Saved And m_LogEvents Then
                    objDALEvent.InsertNewEvent(m_PatientID, 0, m_UserID, 300, "")
                End If
            End If
        Catch ex As Exception
            'TODO Error Log
            MsgBox(ex.ToString)
            rtn = False
        End Try
        Windows.Forms.Cursor.Current = Cursors.Default

        Return rtn
    End Function

    Private Function SaveVisitHistory() As Boolean
        Dim iLoop As Integer
        Dim rtn As Boolean = True
        Dim strQuestions As String
        Dim objDS As DataSet
        If m_PatientID = 0 Then Exit Function

        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        strQuestions = BuildQuestionXML()
        Try
            If m_VisitID = 0 Then
                m_VisitID = objDALVisit.InsertVisitDetails(m_PatientID, m_UserID, m_DexaVisitID, cbBodyType.SelectedIndex, txtBMI.Text, txtPelvic.Text, txtClavical.Text, txtWeight.Text, txtHeight.Text, txtWaist.Text, txtHip.Text, txtbp1.Text, txtbp2.Text, txtIBW.Text, txtDesirWeight.Text, cbExercise.SelectedIndex)
                If m_VisitID > 0 Then
                    Try
                        objDALVisit.InsertMiscData(m_PatientID, m_VisitID, txtALT.Text, txtAST.Text, cbGlucoseTest.SelectedIndex, txtGlucosResult.Text, txtTime.Text, txtRMR.Text, txtVO2.Text)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                    Try
                        objDALVisit.InsertCholesterol(m_PatientID, m_VisitID, dateCholTest.Value.ToString("yyyy-MM-dd hh:mm:ss"), txtTotalChol.Text, txtLDL.Text, txtHDL.Text, txtTrg.Text, txtNonHDL.Text, txtTCHDL.Text, txtRiskAss.Text.Trim)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                    Try
                        objDALVisit.InsertBCAData(m_PatientID, m_VisitID, txtFatper.Text, txtBCM.Text, txtECM.Text, txtFFM.Text, txtBMR.Text, txtICW.Text, txtECW.Text, txtTBW.Text, txtPhaseAngle.Text, txtCapa.Text, txtFatp.Text, txtBCMp.Text, txtECMp.Text, txtFFMp.Text, txtTBWLiters.Text, txtICWLiters.Text, txtECWLiters.Text, txtResist.Text, txtReact.Text)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                    Try
                        objDALVisit.InsertComposition(m_PatientID, m_VisitID, txtFat.Text, txtBone.Text, txtMuscle.Text, txtFluid.Text, txtDensity.Text)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                    Try
                        objDALVisit.InsertConditionNotes(m_PatientID, m_VisitID, txtConditonInfo.Text.Trim)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                    Try
                        objDALVisit.InsertQuestions(m_PatientID, m_VisitID, strQuestions)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        rtn = False
                    End Try
                End If

                If m_MinorStatus <> MinStatus.Saved And m_LogEvents Then
                    objDALEvent.InsertNewEvent(m_PatientID, m_VisitID, m_UserID, 400, "")
                End If
            Else
                objDALVisit.UpdateVisitDetails(m_VisitID, cbBodyType.SelectedIndex, txtBMI.Text, txtPelvic.Text, txtClavical.Text, txtWeight.Text, txtHeight.Text, txtWaist.Text, txtHip.Text, txtbp1.Text, txtbp2.Text, txtIBW.Text, txtDesirWeight.Text, cbExercise.SelectedIndex)

                objDS = objDALVisit.GetMiscData(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateMiscData(m_PatientID, m_VisitID, txtALT.Text, txtAST.Text, cbGlucoseTest.SelectedIndex, txtGlucosResult.Text, txtTime.Text, txtRMR.Text, txtVO2.Text)
                Else
                    objDALVisit.InsertMiscData(m_PatientID, m_VisitID, txtALT.Text, txtAST.Text, cbGlucoseTest.SelectedIndex, txtGlucosResult.Text, txtTime.Text, txtRMR.Text, txtVO2.Text)
                End If

                objDS = objDALVisit.GetCholesterol(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateCholesterol(m_PatientID, m_VisitID, dateCholTest.Value.ToString("yyyy-MM-dd hh:mm:ss"), txtTotalChol.Text, txtLDL.Text, txtHDL.Text, txtTrg.Text, txtNonHDL.Text, txtTCHDL.Text, txtRiskAss.Text.Trim)
                Else
                    objDALVisit.InsertCholesterol(m_PatientID, m_VisitID, dateCholTest.Value.ToString("yyyy-MM-dd hh:mm:ss"), txtTotalChol.Text, txtLDL.Text, txtHDL.Text, txtTrg.Text, txtNonHDL.Text, txtTCHDL.Text, txtRiskAss.Text.Trim)
                End If

                objDS = objDALVisit.GetBCAData(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateBCAData(m_PatientID, m_VisitID, txtFatper.Text, txtBCM.Text, txtECM.Text, txtFFM.Text, txtBMR.Text, txtICW.Text, txtECW.Text, txtTBW.Text, txtPhaseAngle.Text, txtCapa.Text, txtFatp.Text, txtBCMp.Text, txtECMp.Text, txtFFMp.Text, txtTBWLiters.Text, txtICWLiters.Text, txtECWLiters.Text, txtResist.Text, txtReact.Text)
                Else
                    objDALVisit.InsertBCAData(m_PatientID, m_VisitID, txtFatper.Text, txtBCM.Text, txtECM.Text, txtFFM.Text, txtBMR.Text, txtICW.Text, txtECW.Text, txtTBW.Text, txtPhaseAngle.Text, txtCapa.Text, txtFatp.Text, txtBCMp.Text, txtECMp.Text, txtFFMp.Text, txtTBWLiters.Text, txtICWLiters.Text, txtECWLiters.Text, txtResist.Text, txtReact.Text)
                End If

                objDS = objDALVisit.GetComposition(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateComposition(m_PatientID, m_VisitID, txtFat.Text, txtBone.Text, txtMuscle.Text, txtFluid.Text, txtDensity.Text)
                Else
                    objDALVisit.InsertComposition(m_PatientID, m_VisitID, txtFat.Text, txtBone.Text, txtMuscle.Text, txtFluid.Text, txtDensity.Text)
                End If

                objDS = objDALVisit.GetConditionNotes(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateConditionNotes(m_PatientID, m_VisitID, txtConditonInfo.Text.Trim)
                Else
                    objDALVisit.InsertConditionNotes(m_PatientID, m_VisitID, txtConditonInfo.Text.Trim)
                End If

                objDS = objDALVisit.GetQuestions(m_PatientID, m_VisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    objDALVisit.UpdateQuestions(m_PatientID, m_VisitID, strQuestions)
                Else
                    objDALVisit.InsertQuestions(m_PatientID, m_VisitID, strQuestions)
                End If

                If m_MinorStatus <> MinStatus.Saved And m_LogEvents Then
                    objDALEvent.InsertNewEvent(m_PatientID, m_VisitID, m_UserID, 500, "")
                End If

                objDALVisit.DeleteCondition(m_PatientID, m_VisitID)
            End If


                'insert checked conditions
                For iLoop = 0 To dgConditions.Rows.Count - 1
                    If dgConditions.Rows(iLoop).Cells(0).Value = True Then
                    objDALVisit.InsertCondition(m_PatientID, m_VisitID, m_ConditionList(iLoop), False)
                    End If
                    If dgConditions.Rows(iLoop).Cells(1).Value = True Then
                    objDALVisit.InsertCondition(m_PatientID, m_VisitID, m_ConditionList(iLoop), True)
                    End If
                Next

                m_MinorStatus = MinStatus.Saved

                loadVisitHistory(m_PatientID)
                Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString)
            rtn = False
        End Try

        Return rtn

    End Function

    Private Function BuildQuestionXML() As String
        Dim QuestXML As New XmlDocument
        Dim XMLQuestion As XmlNode


        QuestXML.Load(m_Path & "\xml\questions.xml")
        QuestXML.SelectSingleNode("/questionnaire/date").InnerText = dtQuestDate.Value.ToShortDateString

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""1""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest1.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""2""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest2.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""3""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest3.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""4""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest4.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""5""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest5.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""6""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest6.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""7""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest7.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""8""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest8.Text.Trim & "]]>"

        XMLQuestion = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""9""]")
        XMLQuestion.InnerXml = "<![CDATA[" & txtQuest9.Text.Trim & "]]>"

        Return QuestXML.InnerXml.ToString()

    End Function


    Private Sub LoadVisit(ByVal iVisitID As Integer)
        Dim objDS As DataSet
        Dim objRow As DataRow
        Dim indx As Integer

        m_VisitID = iVisitID

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'Visit Details
        objDS = objDALVisit.GetVisitDetails(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then

            objRow = objDS.Tables(0).Rows(0)

            cbBodyType.SelectedIndex = objRow.Item("BodyType")
            m_DexaVisitID = objRow.Item("DexaVisitID").ToString
            txtBMI.Text = CType(objRow.Item("BMI"), Double).ToString("##0.00")
            txtBMI2.Text = CType(objRow.Item("BMI"), Double).ToString("##0.00")
            txtPelvic.Text = CType(objRow.Item("PelvicWidth"), Double).ToString("##0.00")
            txtClavical.Text = CType(objRow.Item("ClavicalWidth"), Double).ToString("##0.00")
            txtWeight.Text = CType(objRow.Item("Weight"), Double).ToString("##0.00")
            txtHeight.Text = CType(objRow.Item("Height"), Double).ToString("##0.00")
            txtHip.Text = CType(objRow.Item("Hip"), Double).ToString("##0.00")
            txtWaist.Text = CType(objRow.Item("Waist"), Double).ToString("##0.00")
            txtbp1.Text = objRow.Item("BPSystolic")
            txtbp2.Text = objRow.Item("BPDiastolic")
            txtIBW.Text = objRow.Item("IBW")
            txtDesirWeight.Text = objRow.Item("DBWeight")
            cbExercise.SelectedIndex = objRow.Item("Exercise")
        End If

        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'BCA Data
        objDS = objDALVisit.GetBCAData(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then

            objRow = objDS.Tables(0).Rows(0)


            txtBCM.Text = CType(objRow.Item("BCM"), Double).ToString("##0.00")
            txtFatper.Text = CType(objRow.Item("FAT"), Double).ToString("##0.00")
            txtECM.Text = CType(objRow.Item("ECM"), Double).ToString("##0.00")
            txtFFM.Text = CType(objRow.Item("FFM"), Double).ToString("##0.00")
            txtBMR.Text = CType(objRow.Item("BMR"), Double).ToString("##0.00")
            txtICW.Text = CType(objRow.Item("ICW"), Double).ToString("##0.00")
            txtECW.Text = CType(objRow.Item("ECW"), Double).ToString("##0.00")
            txtTBW.Text = CType(objRow.Item("TBW"), Double).ToString("##0.00")
            txtPhaseAngle.Text = CType(objRow.Item("PhaseAngle"), Double).ToString("##0.00")
            txtCapa.Text = CType(objRow.Item("Capacitance"), Double).ToString("##0.00")
            txtFatp.Text = CType(objRow.Item("FatPounds"), Double).ToString("##0.00")

            txtBCMp.Text = CType(objRow.Item("BCMPounds"), Double).ToString("##0.00")
            txtECMp.Text = CType(objRow.Item("ECMPounds"), Double).ToString("##0.00")
            txtFFMp.Text = CType(objRow.Item("FFMPounds"), Double).ToString("##0.00")
            txtTBWLiters.Text = CType(objRow.Item("TBWLiters"), Double).ToString("##0.00")
            txtICWLiters.Text = CType(objRow.Item("ICWLiters"), Double).ToString("##0.00")
            txtECWLiters.Text = CType(objRow.Item("ECWLiters"), Double).ToString("##0.00")
            txtResist.Text = CType(objRow.Item("Resistance"), Double).ToString("##0.00")
            txtReact.Text = CType(objRow.Item("Reactance"), Double).ToString("##0.00")

        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'Cholesterol
        objDS = objDALVisit.GetCholesterol(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            objRow = objDS.Tables(0).Rows(0)
            dateCholTest.Value = Date.Parse(objRow.Item("TestDate").ToString)
            txtLDL.Text = objRow.Item("LDL").ToString
            txtHDL.Text = objRow.Item("HDL").ToString
            txtTrg.Text = objRow.Item("Triglyc").ToString
            txtNonHDL.Text = CType(objRow.Item("NonHDL"), Double).ToString("##0.00")
            txtTCHDL.Text = CType(objRow.Item("TCHDL"), Double).ToString("##0.00")
            txtTotalChol.Text = objRow.Item("TotalChol").ToString
            txtRiskAss.Text = objRow.Item("AddInfo").ToString
        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing



        'Misc Data
        objDS = objDALVisit.GetMiscData(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            objRow = objDS.Tables(0).Rows(0)

            txtALT.Text = objRow.Item("LiverALT").ToString
            txtAST.Text = objRow.Item("LiverAST").ToString
            cbGlucoseTest.SelectedIndex = objRow.Item("GluTestType")
            txtGlucosResult.Text = objRow.Item("Glucose").ToString
            txtTime.Text = objRow.Item("GluTime").ToString
            txtRMR.Text = CType(objRow.Item("RMR"), Double).ToString("##0.00")
            txtVO2.Text = CType(objRow.Item("VO2"), Double).ToString("##0.00")
        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'Composition Data
        objDS = objDALVisit.GetComposition(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            objRow = objDS.Tables(0).Rows(0)

            txtFat.Text = objRow.Item("Fat").ToString
            txtBone.Text = objRow.Item("Bone").ToString
            txtMuscle.Text = objRow.Item("Muscle").ToString
            txtFluid.Text = objRow.Item("Fluid").ToString
            txtDensity.Text = objRow.Item("Density").ToString
        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'ConditionNotes
        objDS = objDALVisit.GetConditionNotes(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            objRow = objDS.Tables(0).Rows(0)

            txtConditonInfo.Text = objRow.Item("Notes").ToString
        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'Conditions
        objDS = objDALVisit.GetConditions(m_PatientID, m_VisitID)

        For Each objRow In objDS.Tables(0).Rows
            indx = m_ConditionList.IndexOf(objRow.Item("ConditionID"))
            If objRow.Item("Past") = False Then
                dgConditions.Rows(indx).Cells(0).Value = True
            Else
                dgConditions.Rows(indx).Cells(1).Value = True
            End If
        Next

        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

        LoadQuestions()

        Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub LoadQuestions()
        Dim QuestXML As New XmlDocument
        Dim objDS As DataSet

        If m_PatientID = 0 Then Exit Sub

        objDS = objDALVisit.GetQuestions(m_PatientID, m_VisitID)

        If objDS.Tables(0).Rows.Count > 0 Then
            QuestXML.LoadXml(objDS.Tables(0).Rows(0).Item("XMLShort").ToString())
            dtQuestDate.Value = DateTime.Parse(QuestXML.SelectSingleNode("/questionnaire/date").InnerText)

            txtQuest1.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""1""]").InnerText.ToString

            txtQuest2.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""2""]").InnerText.ToString

            txtQuest3.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""3""]").InnerText.ToString

            txtQuest4.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""4""]").InnerText.ToString

            txtQuest5.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""5""]").InnerText.ToString

            txtQuest6.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""6""]").InnerText.ToString

            txtQuest7.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""7""]").InnerText.ToString

            txtQuest8.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""8""]").InnerText.ToString

            txtQuest9.Text = QuestXML.SelectSingleNode("/questionnaire/questions/quest[@id=""9""]").InnerText.ToString

        End If

        QuestXML = Nothing
    End Sub


    Private Sub SetVistitFieldsStatus(ByVal stat As Boolean)
        KryptonHeaderGroup2.Enabled = stat
        KryptonHeaderGroup3.Enabled = stat
        KryptonHeaderGroup4.Enabled = stat
        KryptonHeaderGroup5.Enabled = stat
        KryptonHeaderGroup6.Enabled = stat
        KryptonHeaderGroup8.Enabled = stat
        KryptonHeaderGroup7.Enabled = stat
        KryptonHeaderGroup9.Enabled = stat
        KryptonHeaderGroup13.Enabled = stat
        KryptonHeaderGroup10.Enabled = stat
        KryptonHeaderGroup14.Enabled = stat
        dgConditions.Enabled = stat
    End Sub

    Private Sub ClearPatientFields()
        gbMain.ValuesSecondary.Description = ""
        cbGender.SelectedIndex = -1
        cbDOBmm.SelectedIndex = 0
        cbDOBmm.ForeColor = Color.Silver
        txtDobdd.Text = "dd"
        txtDobdd.ForeColor = Color.Silver
        cbDobyyyy.SelectedIndex = -1
        txtFirstName.Text = ""
        txtMI.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
    End Sub

    Private Sub ClearVisitFields()
        Dim iLoop As Integer
        txtHeight.Text = "0.00"
        txtWeight.Text = "0.00"
        txtDesirWeight.Text = "0"
        txtIBW.Text = "0"
        txtBMI.Text = "0.00"
        txtPelvic.Text = "0.00"
        txtClavical.Text = "0.00"
        txtWaist.Text = "0.00"
        txtHip.Text = "0.00"
        txtbp1.Text = "0"
        txtbp2.Text = "0"
        txtRMR.Text = "0.00"
        txtVO2.Text = "0.00"
        txtTotalChol.Text = "0"
        txtTrg.Text = "0"
        txtNonHDL.Text = "0.00"
        txtHDL.Text = "0"
        txtLDL.Text = "0"
        txtTCHDL.Text = "0.00"
        txtFat.Text = "0"
        txtBone.Text = "0"
        txtMuscle.Text = "0"
        txtFluid.Text = "0"
        txtDensity.Text = "0"
        txtTime.Text = "0"
        txtGlucosResult.Text = "0"
        txtALT.Text = "0"
        txtAST.Text = "0"
        txtRiskAss.Text = ""
        txtPhaseAngle.Text = "0.00"
        txtCapa.Text = "0.00"
        txtBMR.Text = "0.00"
        txtFatper.Text = "0.00"
        txtFatp.Text = "0.00"
        txtFFM.Text = "0.00"
        txtFFMp.Text = "0.00"
        txtBCM.Text = "0.00"
        txtBCMp.Text = "0.00"
        txtECM.Text = "0.00"
        txtECMp.Text = "0.00"
        txtTBW.Text = "0.00"
        txtTBWLiters.Text = "0.00"
        txtICW.Text = "0.00"
        txtICWLiters.Text = "0.00"
        txtECW.Text = "0.00"
        txtECWLiters.Text = "0.00"
        txtResist.Text = "0.00"
        txtReact.Text = "0.00"
        txtConditonInfo.Text = ""
        cbExercise.SelectedIndex = -1
        cbBodyType.SelectedIndex = -1
        cbGlucoseTest.SelectedIndex = -1
        dateCholTest.Value = Now

        txtQuest1.Text = ""
        txtQuest2.SelectedIndex = -1
        txtQuest3.Text = ""
        txtQuest4.Text = ""
        txtQuest5.SelectedIndex = -1
        txtQuest6.Text = ""
        txtQuest7.SelectedIndex = -1
        txtQuest8.Text = ""
        txtQuest9.Text = ""
        KryptonHeaderGroup14.Panel.ScrollControlIntoView(Label72)
        KryptonHeaderGroup10.Panel.ScrollControlIntoView(Label36)
        dgConditions.Rows(0).DataGridView.FirstDisplayedScrollingRowIndex = 0
        KryptonHeaderGroup3.Panel.ScrollControlIntoView(Label1)
        KryptonHeaderGroup4.Panel.ScrollControlIntoView(Label6)
        KryptonHeaderGroup5.Panel.ScrollControlIntoView(Label10)
        pgCholesterol.ScrollControlIntoView(Label49)
        pgScanData.ScrollControlIntoView(Label50)
        pgBCA.ScrollControlIntoView(Label51)

        For iLoop = 0 To dgConditions.Rows.Count - 1
            dgConditions.Rows(iLoop).Cells(0).Value = False
            dgConditions.Rows(iLoop).Cells(1).Value = False
        Next
    End Sub

    Private Sub LoadContainer()
        'txtReact.se()
    End Sub
    Private Sub Control_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVO2.Leave, txtRiskAss.Leave, txtReact.Leave, txtQuest9.Leave, cbDobyyyy.Leave, txtAddress.Leave, txtConditonInfo.Leave

        If MoveNext() Then
            If sender Is txtVO2 Then
                MainNavigator.SelectedPage = pgCholesterol
                txtTotalChol.Focus()
            ElseIf sender Is txtRiskAss Then
                MainNavigator.SelectedPage = pgBCA
                txtPhaseAngle.Focus()
                'ElseIf sender Is txtReact Then
                '    MainNavigator.SelectedPage = pgQuestion
            ElseIf sender Is txtQuest9 Then
                MainNavigator.SelectedPage = pgCondition
            ElseIf sender Is cbDobyyyy Then
                patientNav.SelectedPage = pgContact
                txtPhone.Focus()
            ElseIf sender Is dgConditions Then
                txtConditonInfo.Focus()
            ElseIf sender Is txtConditonInfo Then
                MainNavigator.SelectedPage = pgScanData
            ElseIf sender Is txtAddress Then
                If m_UseDexa Then
                    FindDexaData()
                End If
                patientNav.SelectedPage = pgPatient
                If m_PatientID = 0 Then
                    txtHeight.Focus()
                Else
                    txtFirstName.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub MainNavigator_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainNavigator.SelectedPageChanged
        Select Case MainNavigator.SelectedIndex
            Case 1
                txtHeight.Focus()
            Case 2
                txtTotalChol.Focus()
            Case 3
                txtPhaseAngle.Focus()
            Case 4
                txtQuest1.Focus()
            Case 5
                dgConditions.Focus()
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        txtFirstName.Focus()
        If SavePatient() Then
            SaveVisitHistory()
            btnPrint.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            btnPre.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        End If
    End Sub

    Private Sub txtDobdd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDobdd.Enter
        If txtDobdd.Text = "dd" Then
            txtDobdd.Text = ""
            txtDobdd.ForeColor = Color.BlueViolet
        End If
    End Sub

    Private Sub btnNewVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewVisit.Click
        Dim objDS As DataSet
        Dim objDALDexa As DAL.Dexa

        ClearVisitFields()
        SetVistitFieldsStatus(True)
        MainNavigator.SelectedPage = pgQuestion
        If m_LastVisitID > 0 Then
            'prefill the fields
            LoadVisit(m_LastVisitID)
        End If
        m_VisitID = 0
        m_MinorStatus = MinStatus.NewVisit

        If m_UseDexa Then 'get dexa data
            If My.Forms.frmDexaVerify.VistSelectionOnly(m_DexaPatientID) Then
                My.Forms.frmDexaVerify.ShowDialog()
                If My.Forms.frmDexaVerify.DexaID <> "" Then
                    m_DexaVisitID = My.Forms.frmDexaVerify.ScanID
                End If
                objDALDexa = New DAL.Dexa(My.Settings.DexaLocation)
                m_DexaVisitID = My.Forms.frmDexaVerify.ScanID
                objDS = objDALDexa.GetDexaData(m_DexaPatientID, m_DexaVisitID)
                'visit data
                If objDS.Tables(0).Rows.Count > 0 Then
                    txtHeight.Text = FormatDouble(objDS.Tables(0).Rows(0).Item("Height").ToString)
                    txtWeight.Text = FormatDouble(objDS.Tables(0).Rows(0).Item("Weight").ToString)
                    'txtBMI.Text = objDS.Tables(0).Rows(0).Item("BMI").ToString
                    objDS.Clear()
                    objDS.Dispose()
                    objDS = Nothing
                End If
                'tscore
                objDS = objDALDexa.GetDexaTScore(m_DexaPatientID, m_DexaVisitID)
                If objDS.Tables(0).Rows.Count > 0 Then
                    txtDensity.Text = objDS.Tables(0).Rows(0).Item("T_Score").ToString
                    objDS.Clear()
                    objDS.Dispose()
                    objDS = Nothing
                End If
                objDALDexa = Nothing

            End If
        End If

        txtHeight.Focus()
        txtHeight.SelectAll()
    End Sub

    Private Sub btnEditVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditVisit.Click, gridVisitHistory.DoubleClick
        Dim tmpID As String

        If gridVisitHistory.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridVisitHistory.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            m_MinorStatus = MinStatus.None
            ClearVisitFields()
            SetVistitFieldsStatus(True)
            LoadVisit(tmpID)
            btnPrint.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            btnPre.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            MainNavigator.SelectedPage = pgQuestion
            txtHeight.Focus()
        End If
    End Sub

    Private Sub txtPhone_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Enter
        txtPhone.Text = UnFormatPhoneNum(txtPhone.Text)
    End Sub

    Private Sub txtPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Leave
        txtPhone.Text = FormatPhoneNum(txtPhone.Text)
    End Sub


    Private Sub txtDobdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDobdd.Leave
        Dim iDay As Integer

        If txtDobdd.Text.Trim = "" Then Exit Sub
        Try

        
            iDay = Integer.Parse(txtDobdd.Text)
            'make sure it is one of 31 days
            If iDay > 31 Or iDay < 1 Then
                lblDob.ForeColor = Color.Red
                txtDobdd.ForeColor = Color.Red
            Else
                lblDob.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                txtDobdd.ForeColor = Color.BlueViolet
                txtDobdd.Text = iDay.ToString("0#")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbDobyyyy_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDobyyyy.Leave
        Dim tmpDate As DateTime
        Dim fp As IFormatProvider
        fp = New System.Globalization.CultureInfo("en-US")
        Try 'make sure that this month has this many days
            tmpDate = DateTime.ParseExact(cbDobyyyy.Text & "-" & (cbDOBmm.SelectedIndex + 1).ToString("0#") & "-" & txtDobdd.Text, "yyyy-MM-dd", fp)
            lblDob.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            cbDOBmm.ForeColor = Color.BlueViolet
            txtDobdd.ForeColor = Color.BlueViolet
        Catch ex As Exception
            lblDob.ForeColor = Color.Red
            txtDobdd.ForeColor = Color.Red
            cbDOBmm.ForeColor = Color.Red
        End Try
        fp = Nothing
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Leave

        Label75.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

        If txtEmail.Text.Trim <> "" Then
            If Not ValidEmail(txtEmail.Text.Trim) Then
                Label75.ForeColor = Color.Red
            End If
        End If

    End Sub





    Private Sub FindDexaData()
        Dim objDALDexa As New DAL.Dexa(My.Settings.DexaLocation)
        Dim objDS As DataSet

        If txtFirstName.Text.Trim <> "" And txtLastName.Text.Trim <> "" Then
            'make sure this patient is in the dexa database
            If My.Forms.frmDexaVerify.LoadPatientData(txtFirstName.Text, txtLastName.Text) Then
                'verify the correct patient
                My.Forms.frmDexaVerify.ShowDialog()
                If My.Forms.frmDexaVerify.DexaID <> "" Then
                    m_DexaPatientID = My.Forms.frmDexaVerify.DexaID
                    m_DexaVisitID = My.Forms.frmDexaVerify.ScanID
                    objDS = objDALDexa.GetDexaData(m_DexaPatientID, m_DexaVisitID)
                    'visit data
                    If objDS.Tables(0).Rows.Count > 0 Then
                        txtHeight.Text = FormatDouble(objDS.Tables(0).Rows(0).Item("Height").ToString)
                        txtWeight.Text = FormatDouble(objDS.Tables(0).Rows(0).Item("Weight").ToString)
                        ' txtBMI.Text = FormatDouble(objDS.Tables(0).Rows(0).Item("BMI").ToString)
                        objDS.Clear()
                        objDS.Dispose()
                        objDS = Nothing
                    End If
                    'tscore
                    objDS = objDALDexa.GetDexaTScore(m_DexaPatientID, m_DexaVisitID)
                    If objDS.Tables(0).Rows.Count > 0 Then
                        txtDensity.Text = objDS.Tables(0).Rows(0).Item("T_Score").ToString
                        objDS.Clear()
                        objDS.Dispose()
                        objDS = Nothing
                    End If

                End If
            End If
        End If

        objDALDexa = Nothing
    End Sub


    Private Sub txtIBW_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIBW.Enter, txtHeight.Leave
        Dim iHeight As Double
        Dim iIBW As Integer = 0

        If txtHeight.Text <> "" And txtHeight.Text <> "0.00" And cbGender.SelectedIndex > -1 Then
            Try
                iHeight = Double.Parse(txtHeight.Text)
                iHeight = iHeight - 60

                If cbGender.SelectedIndex = 1 Then
                    iIBW = 100
                    iIBW += (iHeight * 5)
                Else
                    iIBW = 106
                    iIBW += (iHeight * 6)
                End If
                txtIBW.Text = iIBW.ToString
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBMI_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBMI.Enter, txtWeight.Leave
        Dim iHeight As Double
        Dim iWeight As Double
        Dim iBMI As Double = 0.0

        If txtHeight.Text <> "" And txtHeight.Text <> "0.00" And txtWeight.Text <> "" And txtWeight.Text <> "0.00" Then
            Try
                iHeight = Double.Parse(txtHeight.Text)
                iWeight = Double.Parse(txtWeight.Text)

                iBMI = (iWeight / (iHeight * iHeight)) * 703
                txtBMI.Text = iBMI.ToString("##0.00")
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub txtWaist_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWaist.Leave, cbBodyType.Enter
        Dim iClavical As Double
        Dim iPelvic As Double
        Dim iWaist As Double
        Dim iCWPW As Double = 0.0
        Dim iBodyType = 3
        Dim iRatioTotal As Double = 0.0

        If txtWaist.Text <> "" And txtWaist.Text <> "0.00" And txtClavical.Text <> "" And txtClavical.Text <> "0.00" And txtPelvic.Text <> "" And txtPelvic.Text <> "0.00" Then
            Try
                iClavical = Double.Parse(txtClavical.Text)
                iPelvic = Double.Parse(txtPelvic.Text)
                iWaist = Double.Parse(txtWaist.Text)
                iCWPW = iClavical / iPelvic
                iRatioTotal = iClavical + iPelvic + iWaist

                If iRatioTotal = (iClavical * 3) Then
                    iBodyType = 3
                ElseIf iCWPW = 1 Then
                    iBodyType = 0
                ElseIf iCWPW < 1 Then
                    iBodyType = 1
                ElseIf iCWPW > 1 Then
                    iBodyType = 2
                End If
                cbBodyType.SelectedIndex = iBodyType
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnVPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPrint.Click
        Dim tmpID As String

        If gridVisitHistory.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridVisitHistory.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            PrintVisit(tmpID)
        End If
    End Sub

    Private Sub PreviewPatientReport(ByVal iVisitID As Integer)
        Dim rptPatient As New rptpatientmain
        Dim rptPhysican As New rptphysicanreport
        Dim PrintMore As New frmPrintDocs
        Dim msgRes As MsgBoxResult


        'Patient Report
        rptPatient.PageSettings.Margins.Left = 0.5
        rptPatient.PageSettings.Margins.Right = 0.5
        rptPatient.PageSettings.Margins.Top = 0.5
        rptPatient.PageSettings.Margins.Bottom = 0.5

        rptPatient.PatientID = m_PatientID
        rptPatient.VisitID = iVisitID
        rptPatient.Run(False)

        My.Forms.frmPrintPreview.rptViewer.Document = rptPatient.Document
        My.Forms.frmPrintPreview.ShowDialog()

        msgRes = MsgBox("Do you wish to print the rest of the documents at this time?", MsgBoxStyle.YesNo, "Continue Printing?")
        If msgRes = MsgBoxResult.Yes Then

            'Print BodyType and PHase Docs
            PrintStaticDoc(rptPatient.BodyType, rptPatient.Phase)

            'Physican Report
            rptPhysican.PageSettings.Margins.Left = 0.5
            rptPhysican.PageSettings.Margins.Right = 0.5
            rptPhysican.PageSettings.Margins.Top = 0.5
            rptPhysican.PageSettings.Margins.Bottom = 0.5

            rptPhysican.PatientID = m_PatientID
            rptPhysican.VisitID = iVisitID
            rptPhysican.Run(False)

            rptPhysican.Document.Print(False, False, False)
            'My.Forms.frmPrintPreview.rptViewer.Document = rptPhysican.Document
            'My.Forms.frmPrintPreview.ShowDialog()

            rptPhysican.Document.Dispose()
            rptPhysican.Dispose()

            'print additional documents
            PrintMore.Init()
            PrintMore.LoadDocumentList()
            PrintMore.btnClose.Visible = True
            PrintMore.ShowDialog()
            PrintMore = Nothing

            If m_LogEvents Then
                objDALEvent.InsertNewEvent(m_PatientID, iVisitID, m_UserID, 700, "")
            End If
        End If

        rptPatient.Document.Dispose()
        rptPatient.Dispose()

    End Sub

    Private Sub PrintVisit(ByVal iVisitID As Integer)
        Dim rptPatient As New rptpatientmain
        Dim rptPhysican As New rptphysicanreport
        Dim PrintMore As New frmPrintDocs

        'Patient Report
        rptPatient.PageSettings.Margins.Left = 0.5
        rptPatient.PageSettings.Margins.Right = 0.5
        rptPatient.PageSettings.Margins.Top = 0.5
        rptPatient.PageSettings.Margins.Bottom = 0.5

        rptPatient.PatientID = m_PatientID
        rptPatient.VisitID = iVisitID
        rptPatient.Run(False)

        rptPatient.Document.Print(False, False, False)

        'Exit Sub
        'testing only
        'PdfExport.Export(rptPatient.Document, m_Path & "\PrintTest\PatientRpt.pdf")

        'Print BodyType and PHase Docs
        PrintStaticDoc(rptPatient.BodyType, rptPatient.Phase)

        rptPatient.Document.Dispose()
        rptPatient.Dispose()

        'Physican Report
        rptPhysican.PageSettings.Margins.Left = 0.5
        rptPhysican.PageSettings.Margins.Right = 0.5
        rptPhysican.PageSettings.Margins.Top = 0.5
        rptPhysican.PageSettings.Margins.Bottom = 0.5

        rptPhysican.PatientID = m_PatientID
        rptPhysican.VisitID = iVisitID
        rptPhysican.Run(False)

        rptPhysican.Document.Print(False, False, False)

        'testing only
        'PdfExport.Export(rptPhysican.Document, m_Path & "\PrintTest\PhysicanRpt.pdf")

        rptPhysican.Document.Dispose()
        rptPhysican.Dispose()


        'print additional documents
        PrintMore.Init()
        PrintMore.LoadDocumentList()
        PrintMore.btnClose.Visible = True
        PrintMore.ShowDialog()
        PrintMore = Nothing

        If m_LogEvents Then
            objDALEvent.InsertNewEvent(m_PatientID, iVisitID, m_UserID, 700, "")
        End If
    End Sub

    Private Sub PrintStaticDoc(ByVal iBodyType As Integer, ByVal iPhase As Integer)
        Dim BioFileName As String
        Dim PhaseFileName As String
        Dim DocPath As String

        DocPath = Path.GetDirectoryName(Application.ExecutablePath) & My.Settings.docpath

        BioFileName = """" & DocPath & "\BioOne.pdf" & """"
        'BodyType
        Select Case iBodyType
            Case 1
                BioFileName = """" & DocPath & "\BioOne.pdf" & """"
            Case 2
                BioFileName = """" & DocPath & "\BioTwo.pdf" & """"
            Case 3
                BioFileName = """" & DocPath & "\BioThree.pdf" & """"
            Case 4
                BioFileName = """" & DocPath & "\BioFour.pdf" & """"
        End Select
        'Shell("pdfp " & " " & FileName, AppWinStyle.Hide, False)

        PhaseFileName = ""
        'Phase
        Select Case iPhase
            Case 1
                PhaseFileName = """" & DocPath & "\Phase_One_Patient.pdf" & """"
            Case 2
                PhaseFileName = """" & DocPath & "\Phase_Two_Patient.pdf" & """"
            Case 3
                PhaseFileName = """" & DocPath & "\Phase_Three_Patient.pdf" & """"
            Case 4
                PhaseFileName = """" & DocPath & "\Phase_Four_Patient.pdf" & """"
            Case 5
                PhaseFileName = """" & DocPath & "\Phase_Five_Patient.pdf" & """"
            Case 6
                PhaseFileName = """" & DocPath & "\Phase_Six_Patient.pdf" & """"
            Case 7
                PhaseFileName = """" & DocPath & "\Phase_Seven_Patient.pdf" & """"
        End Select
        If PhaseFileName = "" Then
            Shell("pdfp " & " " & BioFileName, AppWinStyle.Hide, False)
        Else
            Shell("pdfp " & " " & BioFileName & " " & PhaseFileName, AppWinStyle.Hide, False)
        End If

    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        txtFirstName.Focus()
        If SavePatient() Then
            SaveVisitHistory()
            PrintVisit(m_VisitID)
        End If
    End Sub

    Private Sub dgConditions_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgConditions.CellClick
        Dim iColIndx As Integer
        Dim iRowIndx As Integer

        iColIndx = e.ColumnIndex
        iRowIndx = e.RowIndex

        If iColIndx = 0 Then
            If dgConditions.Rows(iRowIndx).Cells(0).Value = False Then
                dgConditions.Rows(iRowIndx).Cells(0).Value = True
                dgConditions.Rows(iRowIndx).Cells(1).Value = False
            Else
                dgConditions.Rows(iRowIndx).Cells(0).Value = False
            End If
        End If

        If iColIndx = 1 Then
            If dgConditions.Rows(iRowIndx).Cells(1).Value = False Then
                dgConditions.Rows(iRowIndx).Cells(1).Value = True
                dgConditions.Rows(iRowIndx).Cells(0).Value = False
            Else
                dgConditions.Rows(iRowIndx).Cells(1).Value = False
            End If
        End If


    End Sub


    Private Sub txtDensity_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDensity.KeyUp
        If e.KeyValue = 189 Then
            If txtDensity.Text.IndexOf("-") = -1 Then
                txtDensity.Text = "-" & txtDensity.Text
            End If
        End If
    End Sub

    Private Sub txtBMI_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBMI.Leave
        txtBMI2.Text = txtBMI.Text
    End Sub

    Private Sub txtBMI2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBMI2.Leave
        txtBMI.Text = txtBMI2.Text
    End Sub


    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim tmpID As String

        If gridVisitHistory.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridVisitHistory.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            PreviewPatientReport(tmpID)
        End If
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        txtFirstName.Focus()
        If SavePatient() Then
            SaveVisitHistory()
            PreviewPatientReport(m_VisitID)
        End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim tmpID As String

        If gridVisitHistory.SelectedRows.Count = 0 Then Exit Sub
        tmpID = gridVisitHistory.SelectedRows.Item(0).Cells(0).Value
        If tmpID <> "" Then
            ExportVisit(tmpID)
        End If

    End Sub

    Private Sub ExportVisit(ByVal iVisitID As Integer)

        Dim objDS As DataSet
        Dim objRow As DataRow
        Dim strHeader As String
        Dim strData As String

        If iVisitID = 0 Then Exit Sub

        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            Windows.Forms.Cursor.Current = Cursors.WaitCursor


            strHeader = "Frist Name,Last Name"
            strData = txtFirstName.Text & "," & txtLastName.Text

            'Visit Details
            objDS = objDALVisit.GetVisitDetails(m_PatientID, iVisitID)
            objRow = objDS.Tables(0).Rows(0)
            strHeader += ",Body Type"

            strData += "," & (objRow.Item("BodyType") + 1).ToString

            strHeader += ",BMI"
            strData += "," & CType(objRow.Item("BMI"), Double).ToString("##0.00")
            strHeader += ",Pelvic Width"
            strData += "," & CType(objRow.Item("PelvicWidth"), Double).ToString("##0.00")
            strHeader += ",Clavical Width"
            strData += "," & CType(objRow.Item("ClavicalWidth"), Double).ToString("##0.00")
            strHeader += ",Weight"
            strData += "," & CType(objRow.Item("Weight"), Double).ToString("##0.00")
            strHeader += ",Height"
            strData += "," & CType(objRow.Item("Height"), Double).ToString("##0.00")
            strHeader += ",Hip"
            strData += "," & CType(objRow.Item("Hip"), Double).ToString("##0.00")
            strHeader += ",Waist"
            strData += "," & CType(objRow.Item("Waist"), Double).ToString("##0.00")
            strHeader += ",BP Systolic"
            strData += "," & objRow.Item("BPSystolic").ToString
            strHeader += ",BP Diastolic"
            strData += "," & objRow.Item("BPDiastolic").ToString
            strHeader += ",IBW"
            strData += "," & objRow.Item("IBW").ToString
            strHeader += ",DB Weight"
            strData += "," & objRow.Item("DBWeight").ToString

            objRow = Nothing
            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing


            'BCA Data
            objDS = objDALVisit.GetBCAData(m_PatientID, iVisitID)
            If objDS.Tables(0).Rows.Count > 0 Then

                objRow = objDS.Tables(0).Rows(0)


                strHeader += ",BCM"
                strData += "," & CType(objRow.Item("BCM"), Double).ToString("##0.00")
                strHeader += ",FAT"
                strData += "," & CType(objRow.Item("FAT"), Double).ToString("##0.00")
                strHeader += ",ECM"
                strData += "," & CType(objRow.Item("ECM"), Double).ToString("##0.00")
                strHeader += ",FFM"
                strData += "," & CType(objRow.Item("FFM"), Double).ToString("##0.00")
                strHeader += ",BMR"
                strData += "," & CType(objRow.Item("BMR"), Double).ToString("##0.00")
                strHeader += ",ICW"
                strData += "," & CType(objRow.Item("ICW"), Double).ToString("##0.00")
                strHeader += ",ECW"
                strData += "," & CType(objRow.Item("ECW"), Double).ToString("##0.00")
                strHeader += ",BMI"
                strData += "," & CType(objRow.Item("TBW"), Double).ToString("##0.00")
                strHeader += ",Phase Angle"
                strData += "," & CType(objRow.Item("PhaseAngle"), Double).ToString("##0.00")
                strHeader += ",Capacitance"
                strData += "," & CType(objRow.Item("Capacitance"), Double).ToString("##0.00")
                strHeader += ",Fat Pounds"
                strData += "," & CType(objRow.Item("FatPounds"), Double).ToString("##0.00")

                strHeader += ",BCM Pounds"
                strData += "," & CType(objRow.Item("BCMPounds"), Double).ToString("##0.00")
                strHeader += ",ECM Pounds"
                strData += "," & CType(objRow.Item("ECMPounds"), Double).ToString("##0.00")
                strHeader += ",FFM Pounds"
                strData += "," & CType(objRow.Item("FFMPounds"), Double).ToString("##0.00")
                strHeader += ",TBW Liters"
                strData += "," & CType(objRow.Item("TBWLiters"), Double).ToString("##0.00")
                strHeader += ",ICW Liters"
                strData += "," & CType(objRow.Item("ICWLiters"), Double).ToString("##0.00")
                strHeader += ",ECW Liters"
                strData += "," & CType(objRow.Item("ECWLiters"), Double).ToString("##0.00")
                strHeader += ",Resistance"
                strData += "," & CType(objRow.Item("Resistance"), Double).ToString("##0.00")
                strHeader += ",Reactance"
                strData += "," & CType(objRow.Item("Reactance"), Double).ToString("##0.00")

            End If
            objRow = Nothing
            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing


            'Cholesterol
            objDS = objDALVisit.GetCholesterol(m_PatientID, iVisitID)
            If objDS.Tables(0).Rows.Count > 0 Then
                objRow = objDS.Tables(0).Rows(0)
                strHeader += ",TestDate"
                strData += "," & objRow.Item("TestDate").ToString
                strHeader += ",LDL"
                strData += "," & objRow.Item("LDL").ToString
                strHeader += ",HDL"
                strData += "," & objRow.Item("HDL").ToString
                strHeader += ",Triglyc"
                strData += "," & objRow.Item("Triglyc").ToString
                strHeader += ",NonHDL"
                strData += "," & CType(objRow.Item("NonHDL"), Double).ToString("##0.00")
                strHeader += ",TCHDL"
                strData += "," & CType(objRow.Item("TCHDL"), Double).ToString("##0.00")
                strHeader += ",TC"
                strData += "," & objRow.Item("TotalChol").ToString
            End If
            objRow = Nothing
            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing



            'Misc Data
            objDS = objDALVisit.GetMiscData(m_PatientID, iVisitID)
            If objDS.Tables(0).Rows.Count > 0 Then
                objRow = objDS.Tables(0).Rows(0)

                strHeader += ",Liver ALT"
                strData += "," & objRow.Item("LiverALT").ToString
                strHeader += ",Liver AST"
                strData += "," & objRow.Item("LiverAST").ToString
                strHeader += ",Glucose"
                strData += "," & objRow.Item("Glucose").ToString
                strHeader += ",GluTime"
                strData += "," & objRow.Item("GluTime").ToString
                strHeader += ",RMR"
                strData += "," & CType(objRow.Item("RMR"), Double).ToString("##0.00")
                strHeader += ",VO2"
                strData += "," & CType(objRow.Item("VO2"), Double).ToString("##0.00")
            End If
            objRow = Nothing
            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing


            'Composition Data
            objDS = objDALVisit.GetComposition(m_PatientID, iVisitID)
            If objDS.Tables(0).Rows.Count > 0 Then
                objRow = objDS.Tables(0).Rows(0)

                strHeader += ",Fat"
                strData += "," & objRow.Item("Fat").ToString
                strHeader += ",Bone"
                strData += "," & objRow.Item("Bone").ToString
                strHeader += ",Muscle"
                strData += "," & objRow.Item("Muscle").ToString
                strHeader += ",Fluid"
                strData += "," & objRow.Item("Fluid").ToString
                strHeader += ",Density"
                strData += "," & objRow.Item("Density").ToString
            End If
            objRow = Nothing
            objDS.Clear()
            objDS.Dispose()
            objDS = Nothing

            Windows.Forms.Cursor.Current = Cursors.Default

            Dim fs As New FileStream(SaveFileDialog.FileName, FileMode.Create, FileAccess.Write)
            'declaring a FileStream and creating a word document file named file with
            'access mode of writing
            Dim s As New StreamWriter(fs)
            'creating a new StreamWriter and passing the filestream object fs as argument
            s.BaseStream.Seek(0, SeekOrigin.End)
            'the seek method is used to move the cursor to next position to avoid text to be
            'overwritten
            s.WriteLine(strHeader)
            s.WriteLine(strData)
            'writing text to the newly created file
            s.Close()
        End If

    End Sub

    Private Sub btnDeleteVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteVisit.Click
        Dim tmpID As String
        If gridVisitHistory.SelectedRows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure you want to delete this visit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            tmpID = gridVisitHistory.SelectedRows.Item(0).Cells(0).Value
            If tmpID <> "" Then
                objDALVisit.DeleteVisit(m_PatientID, tmpID)
            End If
            loadVisitHistory(m_PatientID)
        End If
        m_VisitID = 0
        ClearVisitFields()
        SetVistitFieldsStatus(False)
    End Sub
End Class
