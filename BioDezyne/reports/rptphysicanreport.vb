Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptphysicanreport
Inherits ActiveReport

    Private m_BodyType As Integer
    Private m_PatientID As Integer
    Private m_VisitID As Integer
    
    Public Property PatientID() As Integer
        Get
            Return m_PatientID
        End Get
        Set(ByVal value As Integer)
            m_PatientID = value
        End Set
    End Property

    Public Property VisitID() As Integer
        Get
            Return m_VisitID
        End Get
        Set(ByVal value As Integer)
            m_VisitID = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        InitializeReport()
    End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture
	Private Picture1 As DataDynamics.ActiveReports.Picture
	Private lblPatientName As DataDynamics.ActiveReports.Label
	Private lblPrintDate As DataDynamics.ActiveReports.Label
	Private lblClinic As DataDynamics.ActiveReports.Label
	Private Label16 As DataDynamics.ActiveReports.Label
	Private Label17 As DataDynamics.ActiveReports.Label
	Private Label18 As DataDynamics.ActiveReports.Label
	Private Label19 As DataDynamics.ActiveReports.Label
	Private Label20 As DataDynamics.ActiveReports.Label
	Private Label21 As DataDynamics.ActiveReports.Label
	Private lblName As DataDynamics.ActiveReports.Label
	Private lblGender As DataDynamics.ActiveReports.Label
	Private lbldob As DataDynamics.ActiveReports.Label
	Private lblweight As DataDynamics.ActiveReports.Label
	Private lblheight As DataDynamics.ActiveReports.Label
	Private lblage As DataDynamics.ActiveReports.Label
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private txtBMI As DataDynamics.ActiveReports.Label
	Private txtIBW As DataDynamics.ActiveReports.Label
	Private txtHip As DataDynamics.ActiveReports.Label
	Private txtDWeight As DataDynamics.ActiveReports.Label
	Private txtPelvic As DataDynamics.ActiveReports.Label
	Private txtClavical As DataDynamics.ActiveReports.Label
	Private Label12 As DataDynamics.ActiveReports.Label
	Private Label13 As DataDynamics.ActiveReports.Label
	Private Label14 As DataDynamics.ActiveReports.Label
	Private Label15 As DataDynamics.ActiveReports.Label
	Private Label22 As DataDynamics.ActiveReports.Label
	Private Label23 As DataDynamics.ActiveReports.Label
	Private txtWaist As DataDynamics.ActiveReports.Label
	Private txtRMR As DataDynamics.ActiveReports.Label
	Private txtVO2 As DataDynamics.ActiveReports.Label
	Private txtExercise As DataDynamics.ActiveReports.Label
	Private txtBodyType As DataDynamics.ActiveReports.Label
	Private txtBP As DataDynamics.ActiveReports.Label
	Private Label30 As DataDynamics.ActiveReports.Label
	Private Label31 As DataDynamics.ActiveReports.Label
	Private Label32 As DataDynamics.ActiveReports.Label
	Private Label33 As DataDynamics.ActiveReports.Label
	Private Label34 As DataDynamics.ActiveReports.Label
	Private Label35 As DataDynamics.ActiveReports.Label
	Private txtTC As DataDynamics.ActiveReports.Label
	Private txtHDL As DataDynamics.ActiveReports.Label
	Private txtTRG As DataDynamics.ActiveReports.Label
	Private txtLDL As DataDynamics.ActiveReports.Label
	Private txtnonHDL As DataDynamics.ActiveReports.Label
	Private txtTCHDL As DataDynamics.ActiveReports.Label
	Private Label42 As DataDynamics.ActiveReports.Label
	Private Label43 As DataDynamics.ActiveReports.Label
	Private Label44 As DataDynamics.ActiveReports.Label
	Private Label45 As DataDynamics.ActiveReports.Label
	Private Label46 As DataDynamics.ActiveReports.Label
	Private Label47 As DataDynamics.ActiveReports.Label
	Private txtFat As DataDynamics.ActiveReports.Label
	Private txtmuscle As DataDynamics.ActiveReports.Label
	Private txtTScore As DataDynamics.ActiveReports.Label
	Private txtbone As DataDynamics.ActiveReports.Label
	Private txtfluid As DataDynamics.ActiveReports.Label
	Private txtGlucose As DataDynamics.ActiveReports.Label
	Private Label54 As DataDynamics.ActiveReports.Label
	Private Label55 As DataDynamics.ActiveReports.Label
	Private txtAST As DataDynamics.ActiveReports.Label
	Private txtALT As DataDynamics.ActiveReports.Label
	Private Label58 As DataDynamics.ActiveReports.Label
	Private Label60 As DataDynamics.ActiveReports.Label
	Private Label61 As DataDynamics.ActiveReports.Label
	Private Label62 As DataDynamics.ActiveReports.Label
	Private Label63 As DataDynamics.ActiveReports.Label
	Private txtPhaseAngle As DataDynamics.ActiveReports.Label
	Private txtBMR As DataDynamics.ActiveReports.Label
	Private txtFATper As DataDynamics.ActiveReports.Label
	Private txtCapa As DataDynamics.ActiveReports.Label
	Private txtfatp As DataDynamics.ActiveReports.Label
	Private Label70 As DataDynamics.ActiveReports.Label
	Private Label71 As DataDynamics.ActiveReports.Label
	Private Label72 As DataDynamics.ActiveReports.Label
	Private Label73 As DataDynamics.ActiveReports.Label
	Private Label74 As DataDynamics.ActiveReports.Label
	Private Label75 As DataDynamics.ActiveReports.Label
	Private txtFFM As DataDynamics.ActiveReports.Label
	Private txtBCM As DataDynamics.ActiveReports.Label
	Private txtECM As DataDynamics.ActiveReports.Label
	Private txtFFMp As DataDynamics.ActiveReports.Label
	Private txtBCMp As DataDynamics.ActiveReports.Label
	Private txtECMp As DataDynamics.ActiveReports.Label
	Private Label82 As DataDynamics.ActiveReports.Label
	Private Label83 As DataDynamics.ActiveReports.Label
	Private Label84 As DataDynamics.ActiveReports.Label
	Private Label85 As DataDynamics.ActiveReports.Label
	Private Label86 As DataDynamics.ActiveReports.Label
	Private Label87 As DataDynamics.ActiveReports.Label
	Private txtTBW As DataDynamics.ActiveReports.Label
	Private txtICW As DataDynamics.ActiveReports.Label
	Private txtECW As DataDynamics.ActiveReports.Label
	Private txtTBWliters As DataDynamics.ActiveReports.Label
	Private txtICWLiters As DataDynamics.ActiveReports.Label
	Private txtECWLiters As DataDynamics.ActiveReports.Label
	Private Label96 As DataDynamics.ActiveReports.Label
	Private Label99 As DataDynamics.ActiveReports.Label
	Private txtResist As DataDynamics.ActiveReports.Label
	Private txtReact As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private txtRiskAss As DataDynamics.ActiveReports.Label
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "BioDezyne.rptphysicanreport.rpx")
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.Picture = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.Picture)
		Me.Picture1 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Picture)
		Me.lblPatientName = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.lblPrintDate = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.lblClinic = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.GroupHeader1.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label17 = CType(Me.GroupHeader1.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label18 = CType(Me.GroupHeader1.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label19 = CType(Me.GroupHeader1.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label20 = CType(Me.GroupHeader1.Controls(4),DataDynamics.ActiveReports.Label)
		Me.Label21 = CType(Me.GroupHeader1.Controls(5),DataDynamics.ActiveReports.Label)
		Me.lblName = CType(Me.GroupHeader1.Controls(6),DataDynamics.ActiveReports.Label)
		Me.lblGender = CType(Me.GroupHeader1.Controls(7),DataDynamics.ActiveReports.Label)
		Me.lbldob = CType(Me.GroupHeader1.Controls(8),DataDynamics.ActiveReports.Label)
		Me.lblweight = CType(Me.GroupHeader1.Controls(9),DataDynamics.ActiveReports.Label)
		Me.lblheight = CType(Me.GroupHeader1.Controls(10),DataDynamics.ActiveReports.Label)
		Me.lblage = CType(Me.GroupHeader1.Controls(11),DataDynamics.ActiveReports.Label)
		Me.Label = CType(Me.GroupHeader1.Controls(12),DataDynamics.ActiveReports.Label)
		Me.Label1 = CType(Me.GroupHeader1.Controls(13),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.GroupHeader1.Controls(14),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.GroupHeader1.Controls(15),DataDynamics.ActiveReports.Label)
		Me.Label4 = CType(Me.GroupHeader1.Controls(16),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.GroupHeader1.Controls(17),DataDynamics.ActiveReports.Label)
		Me.txtBMI = CType(Me.GroupHeader1.Controls(18),DataDynamics.ActiveReports.Label)
		Me.txtIBW = CType(Me.GroupHeader1.Controls(19),DataDynamics.ActiveReports.Label)
		Me.txtHip = CType(Me.GroupHeader1.Controls(20),DataDynamics.ActiveReports.Label)
		Me.txtDWeight = CType(Me.GroupHeader1.Controls(21),DataDynamics.ActiveReports.Label)
		Me.txtPelvic = CType(Me.GroupHeader1.Controls(22),DataDynamics.ActiveReports.Label)
		Me.txtClavical = CType(Me.GroupHeader1.Controls(23),DataDynamics.ActiveReports.Label)
		Me.Label12 = CType(Me.GroupHeader1.Controls(24),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.GroupHeader1.Controls(25),DataDynamics.ActiveReports.Label)
		Me.Label14 = CType(Me.GroupHeader1.Controls(26),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.GroupHeader1.Controls(27),DataDynamics.ActiveReports.Label)
		Me.Label22 = CType(Me.GroupHeader1.Controls(28),DataDynamics.ActiveReports.Label)
		Me.Label23 = CType(Me.GroupHeader1.Controls(29),DataDynamics.ActiveReports.Label)
		Me.txtWaist = CType(Me.GroupHeader1.Controls(30),DataDynamics.ActiveReports.Label)
		Me.txtRMR = CType(Me.GroupHeader1.Controls(31),DataDynamics.ActiveReports.Label)
		Me.txtVO2 = CType(Me.GroupHeader1.Controls(32),DataDynamics.ActiveReports.Label)
		Me.txtExercise = CType(Me.GroupHeader1.Controls(33),DataDynamics.ActiveReports.Label)
		Me.txtBodyType = CType(Me.GroupHeader1.Controls(34),DataDynamics.ActiveReports.Label)
		Me.txtBP = CType(Me.GroupHeader1.Controls(35),DataDynamics.ActiveReports.Label)
		Me.Label30 = CType(Me.GroupHeader1.Controls(36),DataDynamics.ActiveReports.Label)
		Me.Label31 = CType(Me.GroupHeader1.Controls(37),DataDynamics.ActiveReports.Label)
		Me.Label32 = CType(Me.GroupHeader1.Controls(38),DataDynamics.ActiveReports.Label)
		Me.Label33 = CType(Me.GroupHeader1.Controls(39),DataDynamics.ActiveReports.Label)
		Me.Label34 = CType(Me.GroupHeader1.Controls(40),DataDynamics.ActiveReports.Label)
		Me.Label35 = CType(Me.GroupHeader1.Controls(41),DataDynamics.ActiveReports.Label)
		Me.txtTC = CType(Me.GroupHeader1.Controls(42),DataDynamics.ActiveReports.Label)
		Me.txtHDL = CType(Me.GroupHeader1.Controls(43),DataDynamics.ActiveReports.Label)
		Me.txtTRG = CType(Me.GroupHeader1.Controls(44),DataDynamics.ActiveReports.Label)
		Me.txtLDL = CType(Me.GroupHeader1.Controls(45),DataDynamics.ActiveReports.Label)
		Me.txtnonHDL = CType(Me.GroupHeader1.Controls(46),DataDynamics.ActiveReports.Label)
		Me.txtTCHDL = CType(Me.GroupHeader1.Controls(47),DataDynamics.ActiveReports.Label)
		Me.Label42 = CType(Me.GroupHeader1.Controls(48),DataDynamics.ActiveReports.Label)
		Me.Label43 = CType(Me.GroupHeader1.Controls(49),DataDynamics.ActiveReports.Label)
		Me.Label44 = CType(Me.GroupHeader1.Controls(50),DataDynamics.ActiveReports.Label)
		Me.Label45 = CType(Me.GroupHeader1.Controls(51),DataDynamics.ActiveReports.Label)
		Me.Label46 = CType(Me.GroupHeader1.Controls(52),DataDynamics.ActiveReports.Label)
		Me.Label47 = CType(Me.GroupHeader1.Controls(53),DataDynamics.ActiveReports.Label)
		Me.txtFat = CType(Me.GroupHeader1.Controls(54),DataDynamics.ActiveReports.Label)
		Me.txtmuscle = CType(Me.GroupHeader1.Controls(55),DataDynamics.ActiveReports.Label)
		Me.txtTScore = CType(Me.GroupHeader1.Controls(56),DataDynamics.ActiveReports.Label)
		Me.txtbone = CType(Me.GroupHeader1.Controls(57),DataDynamics.ActiveReports.Label)
		Me.txtfluid = CType(Me.GroupHeader1.Controls(58),DataDynamics.ActiveReports.Label)
		Me.txtGlucose = CType(Me.GroupHeader1.Controls(59),DataDynamics.ActiveReports.Label)
		Me.Label54 = CType(Me.GroupHeader1.Controls(60),DataDynamics.ActiveReports.Label)
		Me.Label55 = CType(Me.GroupHeader1.Controls(61),DataDynamics.ActiveReports.Label)
		Me.txtAST = CType(Me.GroupHeader1.Controls(62),DataDynamics.ActiveReports.Label)
		Me.txtALT = CType(Me.GroupHeader1.Controls(63),DataDynamics.ActiveReports.Label)
		Me.Label58 = CType(Me.GroupHeader1.Controls(64),DataDynamics.ActiveReports.Label)
		Me.Label60 = CType(Me.GroupHeader1.Controls(65),DataDynamics.ActiveReports.Label)
		Me.Label61 = CType(Me.GroupHeader1.Controls(66),DataDynamics.ActiveReports.Label)
		Me.Label62 = CType(Me.GroupHeader1.Controls(67),DataDynamics.ActiveReports.Label)
		Me.Label63 = CType(Me.GroupHeader1.Controls(68),DataDynamics.ActiveReports.Label)
		Me.txtPhaseAngle = CType(Me.GroupHeader1.Controls(69),DataDynamics.ActiveReports.Label)
		Me.txtBMR = CType(Me.GroupHeader1.Controls(70),DataDynamics.ActiveReports.Label)
		Me.txtFATper = CType(Me.GroupHeader1.Controls(71),DataDynamics.ActiveReports.Label)
		Me.txtCapa = CType(Me.GroupHeader1.Controls(72),DataDynamics.ActiveReports.Label)
		Me.txtfatp = CType(Me.GroupHeader1.Controls(73),DataDynamics.ActiveReports.Label)
		Me.Label70 = CType(Me.GroupHeader1.Controls(74),DataDynamics.ActiveReports.Label)
		Me.Label71 = CType(Me.GroupHeader1.Controls(75),DataDynamics.ActiveReports.Label)
		Me.Label72 = CType(Me.GroupHeader1.Controls(76),DataDynamics.ActiveReports.Label)
		Me.Label73 = CType(Me.GroupHeader1.Controls(77),DataDynamics.ActiveReports.Label)
		Me.Label74 = CType(Me.GroupHeader1.Controls(78),DataDynamics.ActiveReports.Label)
		Me.Label75 = CType(Me.GroupHeader1.Controls(79),DataDynamics.ActiveReports.Label)
		Me.txtFFM = CType(Me.GroupHeader1.Controls(80),DataDynamics.ActiveReports.Label)
		Me.txtBCM = CType(Me.GroupHeader1.Controls(81),DataDynamics.ActiveReports.Label)
		Me.txtECM = CType(Me.GroupHeader1.Controls(82),DataDynamics.ActiveReports.Label)
		Me.txtFFMp = CType(Me.GroupHeader1.Controls(83),DataDynamics.ActiveReports.Label)
		Me.txtBCMp = CType(Me.GroupHeader1.Controls(84),DataDynamics.ActiveReports.Label)
		Me.txtECMp = CType(Me.GroupHeader1.Controls(85),DataDynamics.ActiveReports.Label)
		Me.Label82 = CType(Me.GroupHeader1.Controls(86),DataDynamics.ActiveReports.Label)
		Me.Label83 = CType(Me.GroupHeader1.Controls(87),DataDynamics.ActiveReports.Label)
		Me.Label84 = CType(Me.GroupHeader1.Controls(88),DataDynamics.ActiveReports.Label)
		Me.Label85 = CType(Me.GroupHeader1.Controls(89),DataDynamics.ActiveReports.Label)
		Me.Label86 = CType(Me.GroupHeader1.Controls(90),DataDynamics.ActiveReports.Label)
		Me.Label87 = CType(Me.GroupHeader1.Controls(91),DataDynamics.ActiveReports.Label)
		Me.txtTBW = CType(Me.GroupHeader1.Controls(92),DataDynamics.ActiveReports.Label)
		Me.txtICW = CType(Me.GroupHeader1.Controls(93),DataDynamics.ActiveReports.Label)
		Me.txtECW = CType(Me.GroupHeader1.Controls(94),DataDynamics.ActiveReports.Label)
		Me.txtTBWliters = CType(Me.GroupHeader1.Controls(95),DataDynamics.ActiveReports.Label)
		Me.txtICWLiters = CType(Me.GroupHeader1.Controls(96),DataDynamics.ActiveReports.Label)
		Me.txtECWLiters = CType(Me.GroupHeader1.Controls(97),DataDynamics.ActiveReports.Label)
		Me.Label96 = CType(Me.GroupHeader1.Controls(98),DataDynamics.ActiveReports.Label)
		Me.Label99 = CType(Me.GroupHeader1.Controls(99),DataDynamics.ActiveReports.Label)
		Me.txtResist = CType(Me.GroupHeader1.Controls(100),DataDynamics.ActiveReports.Label)
		Me.txtReact = CType(Me.GroupHeader1.Controls(101),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.GroupHeader1.Controls(102),DataDynamics.ActiveReports.Label)
		Me.txtRiskAss = CType(Me.GroupHeader1.Controls(103),DataDynamics.ActiveReports.Label)
	End Sub

	#End Region

 
    Private Sub rptphysicanreport_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim objDS As DataSet
        Dim objRow As DataRow
        Dim objDALPatient As New DAL.PatientData
        Dim objDALVisit As New DAL.VisitHistory


        'Patient data
        objDS = objDALPatient.GetPatientData(m_PatientID)
        If objDS.Tables(0).Rows.Count > 0 Then
            objRow = objDS.Tables(0).Rows(0)
            lblPatientName.Text = objRow.Item("FirstName").ToString & " " & objRow.Item("LastName").ToString
            lblName.Text = lblPatientName.Text
            lblPrintDate.Text = Now.ToShortDateString
            lblClinic.Text = My.Settings.ClinicName
            If My.Settings.Slogan.Trim <> "" Then
                lblClinic.Text = lblClinic.Text & vbCrLf & My.Settings.Slogan
            End If
            If My.Settings.Web.Trim <> "" Then
                lblClinic.Text = lblClinic.Text & vbCrLf & My.Settings.Web
            End If
            lblGender.Text = objRow.Item("Gender").ToString
            lblage.Text = GetAge(objRow.Item("DOB"))
            lbldob.Text = CType(objRow.Item("DOB"), DateTime).ToShortDateString
            'txtPhone.Text = FormatPhoneNum(iRow.Item("Phone").ToString)
            'txtEmail.Text = iRow.Item("Email").ToString
            'txtAddress.Text = iRow.Item("Address").ToString
        End If
        'clean up 
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        objDS = objDALVisit.GetVisitDetails(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then

            objRow = objDS.Tables(0).Rows(0)

            txtBMI.Text = CType(objRow.Item("BMI"), Double).ToString("##0.00")
            txtPelvic.Text = CType(objRow.Item("PelvicWidth"), Double).ToString("##0.00")
            txtClavical.Text = CType(objRow.Item("ClavicalWidth"), Double).ToString("##0.00")
            lblweight.Text = CType(objRow.Item("Weight"), Double).ToString("##0.00")
            lblheight.Text = CType(objRow.Item("Height"), Double).ToString("##0.00")
            txtHip.Text = CType(objRow.Item("Hip"), Double).ToString("##0.00")
            txtWaist.Text = CType(objRow.Item("Waist"), Double).ToString("##0.00")
            txtBP.Text = objRow.Item("BPSystolic") & "/" & objRow.Item("BPDiastolic")
            txtIBW.Text = objRow.Item("IBW")
            txtDWeight.Text = objRow.Item("DBWeight")

            Select Case objRow.Item("BodyType")
                Case 0
                    txtBodyType.Text = "BioDézyne 1"
                Case 1
                    txtBodyType.Text = "BioDézyne 2"
                Case 2
                    txtBodyType.Text = "BioDézyne 3"
                Case 3
                    txtBodyType.Text = "BioDézyne 4"
            End Select

            Select Case objRow.Item("Exercise")
                Case 0
                    txtExercise.Text = "Very Light"
                Case 1
                    txtExercise.Text = "Light"
                Case 2
                    txtExercise.Text = "Moderate"
                Case 3
                    txtExercise.Text = "Vigorous"
                Case 4
                    txtExercise.Text = "Elite Athlete"
            End Select
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
            txtFATper.Text = CType(objRow.Item("FAT"), Double).ToString("##0.00")
            txtECM.Text = CType(objRow.Item("ECM"), Double).ToString("##0.00")
            txtFFM.Text = CType(objRow.Item("FFM"), Double).ToString("##0.00")
            txtBMR.Text = CType(objRow.Item("BMR"), Double).ToString("##0.00")
            txtICW.Text = CType(objRow.Item("ICW"), Double).ToString("##0.00")
            txtECW.Text = CType(objRow.Item("ECW"), Double).ToString("##0.00")
            txtTBW.Text = CType(objRow.Item("TBW"), Double).ToString("##0.00")
            txtPhaseAngle.Text = CType(objRow.Item("PhaseAngle"), Double).ToString("##0.00")
            txtCapa.Text = CType(objRow.Item("Capacitance"), Double).ToString("##0.00")
            txtfatp.Text = CType(objRow.Item("FatPounds"), Double).ToString("##0.00")

            txtBCMp.Text = CType(objRow.Item("BCMPounds"), Double).ToString("##0.00")
            txtECMp.Text = CType(objRow.Item("ECMPounds"), Double).ToString("##0.00")
            txtFFMp.Text = CType(objRow.Item("FFMPounds"), Double).ToString("##0.00")
            txtTBWliters.Text = CType(objRow.Item("TBWLiters"), Double).ToString("##0.00")
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
            'dateCholTest.Value = Date.Parse(objRow.Item("TestDate").ToString)
            txtLDL.Text = objRow.Item("LDL").ToString
            txtHDL.Text = objRow.Item("HDL").ToString
            txtTRG.Text = objRow.Item("Triglyc").ToString
            txtnonHDL.Text = CType(objRow.Item("NonHDL"), Double).ToString("##0.00")
            txtTCHDL.Text = CType(objRow.Item("TCHDL"), Double).ToString("##0.00")
            txtTC.Text = objRow.Item("TotalChol").ToString
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
            'cbGlucoseTest.SelectedIndex = objRow.Item("GluTestType")
            txtGlucose.Text = objRow.Item("Glucose").ToString
            'txtTime.Text = objRow.Item("GluTime").ToString
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
            txtbone.Text = objRow.Item("Bone").ToString
            txtmuscle.Text = objRow.Item("Muscle").ToString
            txtfluid.Text = objRow.Item("Fluid").ToString
            txtTScore.Text = objRow.Item("Density").ToString
        End If
        objRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        ''ConditionNotes
        'objDS = objDALVisit.GetConditionNotes(m_PatientID, m_VisitID)
        'If objDS.Tables(0).Rows.Count > 0 Then
        '    objRow = objDS.Tables(0).Rows(0)

        '    txtConditonInfo.Text = objRow.Item("Notes").ToString
        'End If
        'objRow = Nothing
        'objDS.Clear()
        'objDS.Dispose()
        'objDS = Nothing


        ''Conditions
        'objDS = objDALVisit.GetConditions(m_PatientID, m_VisitID)

        'For Each objRow In objDS.Tables(0).Rows
        '    listrConditions.SetItemChecked(m_ConditionList.IndexOf(objRow.Item("ConditionID")), True)
        'Next

        'objRow = Nothing
        'objDS.Clear()
        'objDS.Dispose()
        'objDS = Nothing
    End Sub
End Class
