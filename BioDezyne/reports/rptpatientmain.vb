Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports RFIControls
Imports System.IO

Public Class rptpatientmain
Inherits ActiveReport

    Private m_BodyType As Integer
    Private m_PatientID As Integer
    Private m_VisitID As Integer
    Private m_RiskList As New TStringList
    Private m_Phase As Integer

    Public ReadOnly Property BodyType() As Integer
        Get
            Return m_BodyType
        End Get
    End Property

    Public ReadOnly Property Phase() As Integer
        Get
            Return m_Phase
        End Get
    End Property

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
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents GroupHeader3 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter3 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture
	Private Picture1 As DataDynamics.ActiveReports.Picture
	Private lblPatientName As DataDynamics.ActiveReports.Label
	Private lblPrintDate As DataDynamics.ActiveReports.Label
	Private lblClinic As DataDynamics.ActiveReports.Label
	Private pbackground As DataDynamics.ActiveReports.Picture
	Private Picture7 As DataDynamics.ActiveReports.Picture
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private pButterfly0 As DataDynamics.ActiveReports.Picture
	Private pButterfly1 As DataDynamics.ActiveReports.Picture
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private pButterfly2 As DataDynamics.ActiveReports.Picture
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Label7 As DataDynamics.ActiveReports.Label
	Private pButterfly3 As DataDynamics.ActiveReports.Picture
	Private Label8 As DataDynamics.ActiveReports.Label
	Private Label9 As DataDynamics.ActiveReports.Label
	Private pButterfly4 As DataDynamics.ActiveReports.Picture
	Private Label10 As DataDynamics.ActiveReports.Label
	Private Label11 As DataDynamics.ActiveReports.Label
	Private pButterfly5 As DataDynamics.ActiveReports.Picture
	Private Label12 As DataDynamics.ActiveReports.Label
	Private Label13 As DataDynamics.ActiveReports.Label
	Private pButterfly6 As DataDynamics.ActiveReports.Picture
	Private Label14 As DataDynamics.ActiveReports.Label
	Private pButterfly7 As DataDynamics.ActiveReports.Picture
	Private Label15 As DataDynamics.ActiveReports.Label
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
	Private PageBreak As DataDynamics.ActiveReports.PageBreak
	Private lblBodyType As DataDynamics.ActiveReports.Label
	Private lblBodyDetails As DataDynamics.ActiveReports.Label
	Private Picture4 As DataDynamics.ActiveReports.Picture
	Private Shape3 As DataDynamics.ActiveReports.Shape
	Private Shape As DataDynamics.ActiveReports.Shape
	Private ChartControl As DataDynamics.ActiveReports.ChartControl
	Private PageBreak1 As DataDynamics.ActiveReports.PageBreak
	Private Picture2 As DataDynamics.ActiveReports.Picture
	Private pBMIArrow As DataDynamics.ActiveReports.Picture
	Private Label23 As DataDynamics.ActiveReports.Label
	Private lblBMI As DataDynamics.ActiveReports.Label
	Private Label24 As DataDynamics.ActiveReports.Label
	Private Label25 As DataDynamics.ActiveReports.Label
	Private Label28 As DataDynamics.ActiveReports.Label
	Private Label37 As DataDynamics.ActiveReports.Label
	Private Label38 As DataDynamics.ActiveReports.Label
	Private Label39 As DataDynamics.ActiveReports.Label
	Private Label40 As DataDynamics.ActiveReports.Label
	Private Shape2 As DataDynamics.ActiveReports.Shape
	Private Label30 As DataDynamics.ActiveReports.Label
	Private lblFat As DataDynamics.ActiveReports.Label
	Private lblECM As DataDynamics.ActiveReports.Label
	Private lblFFM As DataDynamics.ActiveReports.Label
	Private lblPhaseAngle As DataDynamics.ActiveReports.Label
	Private lblWaist As DataDynamics.ActiveReports.Label
	Private Label29 As DataDynamics.ActiveReports.Label
	Private Label31 As DataDynamics.ActiveReports.Label
	Private Label32 As DataDynamics.ActiveReports.Label
	Private Label33 As DataDynamics.ActiveReports.Label
	Private Label34 As DataDynamics.ActiveReports.Label
	Private Label35 As DataDynamics.ActiveReports.Label
	Private Label36 As DataDynamics.ActiveReports.Label
	Private lblTC As DataDynamics.ActiveReports.Label
	Private lbltrig As DataDynamics.ActiveReports.Label
	Private lblglu As DataDynamics.ActiveReports.Label
	Private lblhdl As DataDynamics.ActiveReports.Label
	Private lblLDL As DataDynamics.ActiveReports.Label
	Private lblRat As DataDynamics.ActiveReports.Label
	Private Label44 As DataDynamics.ActiveReports.Label
	Private Shape6 As DataDynamics.ActiveReports.Shape
	Private Shape5 As DataDynamics.ActiveReports.Shape
	Private Line6 As DataDynamics.ActiveReports.Line
	Private Line5 As DataDynamics.ActiveReports.Line
	Private Line4 As DataDynamics.ActiveReports.Line
	Private Line3 As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Line As DataDynamics.ActiveReports.Line
	Private Shape1 As DataDynamics.ActiveReports.Shape
	Private Shape4 As DataDynamics.ActiveReports.Shape
	Private Label26 As DataDynamics.ActiveReports.Label
	Private lblRisk As DataDynamics.ActiveReports.Label
	Private Label27 As DataDynamics.ActiveReports.Label
	Private lbldexa As DataDynamics.ActiveReports.Label
	Private lblBodyHeader As DataDynamics.ActiveReports.Label
	Private lblStim As DataDynamics.ActiveReports.Label
	Private lblImbal As DataDynamics.ActiveReports.Label
	Private Label43 As DataDynamics.ActiveReports.Label
	Private lblSym1 As DataDynamics.ActiveReports.Label
	Private lblSym3 As DataDynamics.ActiveReports.Label
	Private lblSym2 As DataDynamics.ActiveReports.Label
	Private lblSym4 As DataDynamics.ActiveReports.Label
	Private lblSym6 As DataDynamics.ActiveReports.Label
	Private lblSym5 As DataDynamics.ActiveReports.Label
	Private lblSym7 As DataDynamics.ActiveReports.Label
	Private lblSym9 As DataDynamics.ActiveReports.Label
	Private lblSym8 As DataDynamics.ActiveReports.Label
	Private lblSym10 As DataDynamics.ActiveReports.Label
	Private lblSym12 As DataDynamics.ActiveReports.Label
	Private lblSym11 As DataDynamics.ActiveReports.Label
	Private lblSym13 As DataDynamics.ActiveReports.Label
	Private lblSym15 As DataDynamics.ActiveReports.Label
	Private lblSym14 As DataDynamics.ActiveReports.Label
	Private Shape7 As DataDynamics.ActiveReports.Shape
	Private Shape8 As DataDynamics.ActiveReports.Shape
	Private Picture3 As DataDynamics.ActiveReports.Picture
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "BioDezyne.rptpatientmain.rpx")
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"),DataDynamics.ActiveReports.GroupHeader)
		Me.GroupHeader2 = CType(Me.Sections("GroupHeader2"),DataDynamics.ActiveReports.GroupHeader)
		Me.GroupHeader3 = CType(Me.Sections("GroupHeader3"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter3 = CType(Me.Sections("GroupFooter3"),DataDynamics.ActiveReports.GroupFooter)
		Me.GroupFooter2 = CType(Me.Sections("GroupFooter2"),DataDynamics.ActiveReports.GroupFooter)
		Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.Picture = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.Picture)
		Me.Picture1 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Picture)
		Me.lblPatientName = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.lblPrintDate = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.lblClinic = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.pbackground = CType(Me.GroupHeader1.Controls(0),DataDynamics.ActiveReports.Picture)
		Me.Picture7 = CType(Me.GroupHeader1.Controls(1),DataDynamics.ActiveReports.Picture)
		Me.Label = CType(Me.GroupHeader1.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label1 = CType(Me.GroupHeader1.Controls(3),DataDynamics.ActiveReports.Label)
		Me.pButterfly0 = CType(Me.GroupHeader1.Controls(4),DataDynamics.ActiveReports.Picture)
		Me.pButterfly1 = CType(Me.GroupHeader1.Controls(5),DataDynamics.ActiveReports.Picture)
		Me.Label2 = CType(Me.GroupHeader1.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.GroupHeader1.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label4 = CType(Me.GroupHeader1.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.GroupHeader1.Controls(9),DataDynamics.ActiveReports.Label)
		Me.pButterfly2 = CType(Me.GroupHeader1.Controls(10),DataDynamics.ActiveReports.Picture)
		Me.Label6 = CType(Me.GroupHeader1.Controls(11),DataDynamics.ActiveReports.Label)
		Me.Label7 = CType(Me.GroupHeader1.Controls(12),DataDynamics.ActiveReports.Label)
		Me.pButterfly3 = CType(Me.GroupHeader1.Controls(13),DataDynamics.ActiveReports.Picture)
		Me.Label8 = CType(Me.GroupHeader1.Controls(14),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.GroupHeader1.Controls(15),DataDynamics.ActiveReports.Label)
		Me.pButterfly4 = CType(Me.GroupHeader1.Controls(16),DataDynamics.ActiveReports.Picture)
		Me.Label10 = CType(Me.GroupHeader1.Controls(17),DataDynamics.ActiveReports.Label)
		Me.Label11 = CType(Me.GroupHeader1.Controls(18),DataDynamics.ActiveReports.Label)
		Me.pButterfly5 = CType(Me.GroupHeader1.Controls(19),DataDynamics.ActiveReports.Picture)
		Me.Label12 = CType(Me.GroupHeader1.Controls(20),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.GroupHeader1.Controls(21),DataDynamics.ActiveReports.Label)
		Me.pButterfly6 = CType(Me.GroupHeader1.Controls(22),DataDynamics.ActiveReports.Picture)
		Me.Label14 = CType(Me.GroupHeader1.Controls(23),DataDynamics.ActiveReports.Label)
		Me.pButterfly7 = CType(Me.GroupHeader1.Controls(24),DataDynamics.ActiveReports.Picture)
		Me.Label15 = CType(Me.GroupHeader1.Controls(25),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.GroupHeader1.Controls(26),DataDynamics.ActiveReports.Label)
		Me.Label17 = CType(Me.GroupHeader1.Controls(27),DataDynamics.ActiveReports.Label)
		Me.Label18 = CType(Me.GroupHeader1.Controls(28),DataDynamics.ActiveReports.Label)
		Me.Label19 = CType(Me.GroupHeader1.Controls(29),DataDynamics.ActiveReports.Label)
		Me.Label20 = CType(Me.GroupHeader1.Controls(30),DataDynamics.ActiveReports.Label)
		Me.Label21 = CType(Me.GroupHeader1.Controls(31),DataDynamics.ActiveReports.Label)
		Me.lblName = CType(Me.GroupHeader1.Controls(32),DataDynamics.ActiveReports.Label)
		Me.lblGender = CType(Me.GroupHeader1.Controls(33),DataDynamics.ActiveReports.Label)
		Me.lbldob = CType(Me.GroupHeader1.Controls(34),DataDynamics.ActiveReports.Label)
		Me.lblweight = CType(Me.GroupHeader1.Controls(35),DataDynamics.ActiveReports.Label)
		Me.lblheight = CType(Me.GroupHeader1.Controls(36),DataDynamics.ActiveReports.Label)
		Me.lblage = CType(Me.GroupHeader1.Controls(37),DataDynamics.ActiveReports.Label)
		Me.PageBreak = CType(Me.GroupHeader1.Controls(38),DataDynamics.ActiveReports.PageBreak)
		Me.lblBodyType = CType(Me.GroupHeader1.Controls(39),DataDynamics.ActiveReports.Label)
		Me.lblBodyDetails = CType(Me.GroupHeader1.Controls(40),DataDynamics.ActiveReports.Label)
		Me.Picture4 = CType(Me.GroupHeader1.Controls(41),DataDynamics.ActiveReports.Picture)
		Me.Shape3 = CType(Me.GroupHeader2.Controls(0),DataDynamics.ActiveReports.Shape)
		Me.Shape = CType(Me.GroupHeader2.Controls(1),DataDynamics.ActiveReports.Shape)
		Me.ChartControl = CType(Me.GroupHeader2.Controls(2),DataDynamics.ActiveReports.ChartControl)
		Me.PageBreak1 = CType(Me.GroupHeader2.Controls(3),DataDynamics.ActiveReports.PageBreak)
		Me.Picture2 = CType(Me.GroupHeader2.Controls(4),DataDynamics.ActiveReports.Picture)
		Me.pBMIArrow = CType(Me.GroupHeader2.Controls(5),DataDynamics.ActiveReports.Picture)
		Me.Label23 = CType(Me.GroupHeader2.Controls(6),DataDynamics.ActiveReports.Label)
		Me.lblBMI = CType(Me.GroupHeader2.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label24 = CType(Me.GroupHeader2.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label25 = CType(Me.GroupHeader2.Controls(9),DataDynamics.ActiveReports.Label)
		Me.Label28 = CType(Me.GroupHeader2.Controls(10),DataDynamics.ActiveReports.Label)
		Me.Label37 = CType(Me.GroupHeader2.Controls(11),DataDynamics.ActiveReports.Label)
		Me.Label38 = CType(Me.GroupHeader2.Controls(12),DataDynamics.ActiveReports.Label)
		Me.Label39 = CType(Me.GroupHeader2.Controls(13),DataDynamics.ActiveReports.Label)
		Me.Label40 = CType(Me.GroupHeader2.Controls(14),DataDynamics.ActiveReports.Label)
		Me.Shape2 = CType(Me.GroupHeader2.Controls(15),DataDynamics.ActiveReports.Shape)
		Me.Label30 = CType(Me.GroupHeader2.Controls(16),DataDynamics.ActiveReports.Label)
		Me.lblFat = CType(Me.GroupHeader2.Controls(17),DataDynamics.ActiveReports.Label)
		Me.lblECM = CType(Me.GroupHeader2.Controls(18),DataDynamics.ActiveReports.Label)
		Me.lblFFM = CType(Me.GroupHeader2.Controls(19),DataDynamics.ActiveReports.Label)
		Me.lblPhaseAngle = CType(Me.GroupHeader2.Controls(20),DataDynamics.ActiveReports.Label)
		Me.lblWaist = CType(Me.GroupHeader2.Controls(21),DataDynamics.ActiveReports.Label)
		Me.Label29 = CType(Me.GroupHeader2.Controls(22),DataDynamics.ActiveReports.Label)
		Me.Label31 = CType(Me.GroupHeader2.Controls(23),DataDynamics.ActiveReports.Label)
		Me.Label32 = CType(Me.GroupHeader2.Controls(24),DataDynamics.ActiveReports.Label)
		Me.Label33 = CType(Me.GroupHeader2.Controls(25),DataDynamics.ActiveReports.Label)
		Me.Label34 = CType(Me.GroupHeader2.Controls(26),DataDynamics.ActiveReports.Label)
		Me.Label35 = CType(Me.GroupHeader2.Controls(27),DataDynamics.ActiveReports.Label)
		Me.Label36 = CType(Me.GroupHeader2.Controls(28),DataDynamics.ActiveReports.Label)
		Me.lblTC = CType(Me.GroupHeader2.Controls(29),DataDynamics.ActiveReports.Label)
		Me.lbltrig = CType(Me.GroupHeader2.Controls(30),DataDynamics.ActiveReports.Label)
		Me.lblglu = CType(Me.GroupHeader2.Controls(31),DataDynamics.ActiveReports.Label)
		Me.lblhdl = CType(Me.GroupHeader2.Controls(32),DataDynamics.ActiveReports.Label)
		Me.lblLDL = CType(Me.GroupHeader2.Controls(33),DataDynamics.ActiveReports.Label)
		Me.lblRat = CType(Me.GroupHeader2.Controls(34),DataDynamics.ActiveReports.Label)
		Me.Label44 = CType(Me.GroupHeader3.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Shape6 = CType(Me.GroupHeader3.Controls(1),DataDynamics.ActiveReports.Shape)
		Me.Shape5 = CType(Me.GroupHeader3.Controls(2),DataDynamics.ActiveReports.Shape)
		Me.Line6 = CType(Me.GroupHeader3.Controls(3),DataDynamics.ActiveReports.Line)
		Me.Line5 = CType(Me.GroupHeader3.Controls(4),DataDynamics.ActiveReports.Line)
		Me.Line4 = CType(Me.GroupHeader3.Controls(5),DataDynamics.ActiveReports.Line)
		Me.Line3 = CType(Me.GroupHeader3.Controls(6),DataDynamics.ActiveReports.Line)
		Me.Line2 = CType(Me.GroupHeader3.Controls(7),DataDynamics.ActiveReports.Line)
		Me.Line1 = CType(Me.GroupHeader3.Controls(8),DataDynamics.ActiveReports.Line)
		Me.Line = CType(Me.GroupHeader3.Controls(9),DataDynamics.ActiveReports.Line)
		Me.Shape1 = CType(Me.GroupHeader3.Controls(10),DataDynamics.ActiveReports.Shape)
		Me.Shape4 = CType(Me.GroupHeader3.Controls(11),DataDynamics.ActiveReports.Shape)
		Me.Label26 = CType(Me.GroupHeader3.Controls(12),DataDynamics.ActiveReports.Label)
		Me.lblRisk = CType(Me.GroupHeader3.Controls(13),DataDynamics.ActiveReports.Label)
		Me.Label27 = CType(Me.GroupHeader3.Controls(14),DataDynamics.ActiveReports.Label)
		Me.lbldexa = CType(Me.GroupHeader3.Controls(15),DataDynamics.ActiveReports.Label)
		Me.lblBodyHeader = CType(Me.GroupHeader3.Controls(16),DataDynamics.ActiveReports.Label)
		Me.lblStim = CType(Me.GroupHeader3.Controls(17),DataDynamics.ActiveReports.Label)
		Me.lblImbal = CType(Me.GroupHeader3.Controls(18),DataDynamics.ActiveReports.Label)
		Me.Label43 = CType(Me.GroupHeader3.Controls(19),DataDynamics.ActiveReports.Label)
		Me.lblSym1 = CType(Me.GroupHeader3.Controls(20),DataDynamics.ActiveReports.Label)
		Me.lblSym3 = CType(Me.GroupHeader3.Controls(21),DataDynamics.ActiveReports.Label)
		Me.lblSym2 = CType(Me.GroupHeader3.Controls(22),DataDynamics.ActiveReports.Label)
		Me.lblSym4 = CType(Me.GroupHeader3.Controls(23),DataDynamics.ActiveReports.Label)
		Me.lblSym6 = CType(Me.GroupHeader3.Controls(24),DataDynamics.ActiveReports.Label)
		Me.lblSym5 = CType(Me.GroupHeader3.Controls(25),DataDynamics.ActiveReports.Label)
		Me.lblSym7 = CType(Me.GroupHeader3.Controls(26),DataDynamics.ActiveReports.Label)
		Me.lblSym9 = CType(Me.GroupHeader3.Controls(27),DataDynamics.ActiveReports.Label)
		Me.lblSym8 = CType(Me.GroupHeader3.Controls(28),DataDynamics.ActiveReports.Label)
		Me.lblSym10 = CType(Me.GroupHeader3.Controls(29),DataDynamics.ActiveReports.Label)
		Me.lblSym12 = CType(Me.GroupHeader3.Controls(30),DataDynamics.ActiveReports.Label)
		Me.lblSym11 = CType(Me.GroupHeader3.Controls(31),DataDynamics.ActiveReports.Label)
		Me.lblSym13 = CType(Me.GroupHeader3.Controls(32),DataDynamics.ActiveReports.Label)
		Me.lblSym15 = CType(Me.GroupHeader3.Controls(33),DataDynamics.ActiveReports.Label)
		Me.lblSym14 = CType(Me.GroupHeader3.Controls(34),DataDynamics.ActiveReports.Label)
		Me.Shape7 = CType(Me.GroupHeader3.Controls(35),DataDynamics.ActiveReports.Shape)
		Me.Shape8 = CType(Me.GroupHeader3.Controls(36),DataDynamics.ActiveReports.Shape)
		Me.Picture3 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.Picture)
	End Sub

#End Region

    Public Sub SetPhase(ByVal iPhase As Integer)
        Select Case iPhase
            Case 0
                pButterfly0.Visible = True
            Case 1
                pButterfly1.Visible = True
            Case 2
                pButterfly2.Visible = True
            Case 3
                pButterfly3.Visible = True
            Case 4
                pButterfly4.Visible = True
            Case 5
                pButterfly5.Visible = True
            Case 6
                pButterfly6.Visible = True
            Case 7
                pButterfly7.Visible = True
        End Select
    End Sub


    Private Sub rptpatientmain_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim objDS As DataSet
        Dim iRow As DataRow
        Dim objDALPatient As New DAL.PatientData
        Dim objDALVisit As New DAL.VisitHistory
        'Dim iBodyType As Integer = 1
        ' Dim iPhase As Integer = 0
        Dim tmpPhase As Integer = 0
        Dim dBMI As Double = 0.0
        Dim tmpBMI As Double = 0.0
        Dim tmpBMIPercent As Double
        Dim tmpDistancePercent As Double
        Dim strBMI As String = ""
        'caculated data
        Dim dcBodyWeight As Double
        Dim dcBMI As Double
        Dim dcBPSystolic As Double
        Dim dcBPDiastolic As Double
        Dim dcWaistHip As Double
        Dim dcFat As Double
        Dim dcBCM As Double
        Dim dcECM As Double
        Dim dcFFM As Double

        Dim dcFatp As Double
        Dim dcECMp As Double
        Dim dcFFMp As Double
        Dim dcTBW As Double

        Dim icTC As Integer
        Dim icIBW As Integer
        Dim icTrig As Integer
        Dim icLDL As Integer
        Dim icHDL As Integer
        Dim dcNonHDL As Double
        Dim dcTCHDL As Double
        Dim icGlucose As Integer
        Dim icLiverALT As Integer
        Dim icLiverAST As Integer
        Dim strGender As String = ""
        Dim strBloodDef As String
        Dim strTCDef As String
        Dim strTrigDef As String
        Dim strLDLDef As String
        Dim strHDLDef As String
        Dim strNonHDLDef As String
        Dim strLiverDef As String
        Dim strGlucoseDef As String
        Dim strBMIDef As String
        Dim pTBF As Double

        m_BodyType = 1
        m_Phase = 0

        'Patient data
        objDS = objDalPatient.GetPatientData(m_PatientID)
        If objDS.Tables(0).Rows.Count > 0 Then
            iRow = objDS.Tables(0).Rows(0)
            lblPatientName.Text = iRow.Item("FirstName").ToString & " " & iRow.Item("LastName").ToString
            lblName.Text = lblPatientName.Text
            lblPrintDate.Text = Now.ToShortDateString
            lblClinic.Text = My.Settings.ClinicName
            If My.Settings.Slogan.Trim <> "" Then
                lblClinic.Text = lblClinic.Text & vbCrLf & My.Settings.Slogan
            End If
            If My.Settings.Web.Trim <> "" Then
                lblClinic.Text = lblClinic.Text & vbCrLf & My.Settings.Web
            End If
            lblGender.Text = iRow.Item("Gender").ToString
            strGender = iRow.Item("Gender").ToString
            lblage.Text = GetAge(iRow.Item("DOB"))
            lbldob.Text = CType(iRow.Item("DOB"), DateTime).ToShortDateString
            'txtPhone.Text = FormatPhoneNum(iRow.Item("Phone").ToString)
            'txtEmail.Text = iRow.Item("Email").ToString
            'txtAddress.Text = iRow.Item("Address").ToString
        End If
        'clean up 
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

        objDS = objDALVisit.GetVisitDetails(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            iRow = objDS.Tables(0).Rows(0)
            dBMI = iRow.Item("BMI")
            lblBodyType.Text = (iRow.Item("BodyType") + 1).ToString
            lbldexa.Text = lbldexa.Text.Replace("###", (iRow.Item("BodyType") + 1).ToString)
            m_BodyType = (iRow.Item("BodyType") + 1)
            lblweight.Text = CType(iRow.Item("Weight"), Double).ToString("##0.00") & " lbs"
            lblheight.Text = CType(iRow.Item("Height"), Double).ToString("##0.00") & " in"
            ' lblWaist.Text = lblWaist.Text.Replace("##1", CType(iRow.Item("waist"), Double).ToString("##0.00"))
            ' lblWaist.Text = lblWaist.Text.Replace("##2", CType(iRow.Item("hip"), Double).ToString("##0.00"))
            ' lblWaist.Text = lblWaist.Text.Replace("##3", (CType(iRow.Item("waist"), Double) / CType(iRow.Item("hip"), Double)).ToString("##0.00"))

            'caculated
            dcBodyWeight = iRow.Item("Weight")
            dcBMI = iRow.Item("BMI")
            dcBPSystolic = iRow.Item("BPSystolic")
            dcBPDiastolic = iRow.Item("BPDiastolic")
            icIBW = iRow.Item("IBW")
            dcWaistHip = CType(iRow.Item("waist"), Double) / CType(iRow.Item("hip"), Double)
        End If
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

        If dBMI < 18.5 Then
            strBMI = "Underweight"
        ElseIf dBMI < 25 Then
            strBMI = "Normal"
        ElseIf dBMI < 30 Then
            strBMI = "Overweight"
        ElseIf dBMI > 29 Then
            strBMI = "Obese"
        End If
        lblBMI.Text = "BMI = " & dBMI.ToString("##0.00") & " Classification = " & strBMI
        lblPhaseAngle.Text = lblPhaseAngle.Text.Replace("##3", dBMI.ToString("##0.00"))

        '10 - 40
        '3.625
        If dBMI <= 10 Then
            pBMIArrow.Left = 3.75
        ElseIf dBMI >= 40 Then
            pBMIArrow.Left = 7.375
        Else
            ' tmpBMI = dBMI - 10
            If dBMI = 25 Then
                pBMIArrow.Left = 5.5625
            ElseIf dBMI > 25 Then
                If dBMI = 30 Then
                    pBMIArrow.Left = 6.47125
                ElseIf dBMI > 30 Then '30-40
                    tmpBMIPercent = (dBMI - 30) / 10
                    tmpDistancePercent = 0.90625 * tmpBMIPercent
                    pBMIArrow.Left = 6.47125 + tmpDistancePercent
                ElseIf dBMI < 30 Then '25-30
                    tmpBMIPercent = (dBMI - 25) / 5
                    tmpDistancePercent = 0.90625 * tmpBMIPercent
                    pBMIArrow.Left = 5.5625 + tmpDistancePercent
                End If
            ElseIf dBMI < 25 Then
                If dBMI = 18.5 Then
                    pBMIArrow.Left = 4.65625
                ElseIf dBMI > 18.5 Then '18.5 - 25
                    tmpBMIPercent = (dBMI - 18.5) / 6.5
                    tmpDistancePercent = 0.90625 * tmpBMIPercent
                    pBMIArrow.Left = 4.65625 + tmpDistancePercent
                ElseIf dBMI < 18.5 Then '10 - 18.5
                    tmpBMIPercent = (dBMI - 10) / 8.5
                    tmpDistancePercent = 0.90625 * tmpBMIPercent
                    pBMIArrow.Left = 3.75 + tmpDistancePercent
                End If
            End If

        End If

        'Composition Data
        objDS = objDALVisit.GetBCAData(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            iRow = objDS.Tables(0).Rows(0)

            ChartControl.Series.Item(0).Points(0).YValues.Item(0) = iRow.Item("FAT")
            ChartControl.Series.Item(0).Points(1).YValues.Item(0) = iRow.Item("ECM")
            ChartControl.Series.Item(0).Points(2).YValues.Item(0) = iRow.Item("BCM")

            dcFatp = iRow.Item("FATPounds")
            dcECMp = iRow.Item("ECMPounds")
            dcFFMp = iRow.Item("FFMPounds")
            dcTBW = iRow.Item("TBW")

            '***old way
            'lblFat.Text = lblFat.Text.Replace("###", iRow.Item("FATPounds").ToString())
            'lblECM.Text = lblECM.Text.Replace("###", iRow.Item("ECMPounds").ToString())
            'lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString())

            '***new way
            If dcBodyWeight <= (icIBW * 0.8) Then
                lblFat.Text = lblFat.Text.Replace("###", iRow.Item("FATPounds").ToString() & " Below minium for good health.")
            ElseIf dcBodyWeight >= (icIBW * 1.2) Then
                lblFat.Text = lblFat.Text.Replace("###", iRow.Item("FATPounds").ToString() & " Exceeds maxium for good health.")
            Else
                lblFat.Text = lblFat.Text.Replace("###", iRow.Item("FATPounds").ToString() & " Optimal range for good health.")
            End If

            If dcTBW < 55 Then
                lblECM.Text = lblECM.Text.Replace("###", iRow.Item("ECMPounds").ToString() & " Below minium for good health.")
            ElseIf dcTBW > 65 Then
                lblECM.Text = lblECM.Text.Replace("###", iRow.Item("ECMPounds").ToString() & "  Exceeds maxium for good health.")
            Else
                lblECM.Text = lblECM.Text.Replace("###", iRow.Item("ECMPounds").ToString() & " Optimal range for good health.")
            End If

            'Male
            pTBF = (dcFFMp / dcBodyWeight)
            If strGender = "Male" Then
                If pTBF > 0.9 Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Athelete")
                End If
                If (pTBF > 0.85) And (pTBF <= 0.9) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Lean")
                End If
                If (pTBF > 0.82) And (pTBF <= 0.85) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Normal")
                End If
                If (pTBF > 0.8) And (pTBF <= 0.82) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Above avg.")
                End If
                If (pTBF > 0.75) And (pTBF <= 0.8) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Over fat")
                End If
                If (pTBF <= 0.75) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Obese")
                End If
            Else 'female
                If (pTBF > 0.83) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Athelete")
                End If
                If (pTBF > 0.78) And (pTBF <= 0.83) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Lean")
                End If
                If (pTBF > 0.75) And (pTBF <= 0.78) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Normal")
                End If
                If (pTBF > 0.71) And (pTBF <= 0.75) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Above avg.")
                End If
                If (pTBF > 0.65) And (pTBF <= 0.71) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Over fat")
                End If
                If (pTBF <= 0.65) Then
                    lblFFM.Text = lblFFM.Text.Replace("###", iRow.Item("FFMPounds").ToString() & " Obese")
                End If
            End If

            lblPhaseAngle.Text = lblPhaseAngle.Text.Replace("##1", CType(iRow.Item("PhaseAngle"), Double).ToString("##0.00"))
            lblPhaseAngle.Text = lblPhaseAngle.Text.Replace("##2", CType(iRow.Item("Capacitance"), Double).ToString("##0.00"))

            'caculated
            dcFat = iRow.Item("FAT")
            dcECM = iRow.Item("ECM")
            dcFFM = iRow.Item("FFM")
            dcBCM = iRow.Item("BCM")


        End If
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        objDS = objDALVisit.GetCholesterol(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            iRow = objDS.Tables(0).Rows(0)
            lblLDL.Text = iRow.Item("LDL").ToString
            lblhdl.Text = iRow.Item("HDL").ToString
            lbltrig.Text = iRow.Item("Triglyc").ToString
            lblRat.Text = iRow.Item("TCHDL").ToString
            If iRow.Item("TotalChol").ToString = "0" Then
                lblTC.Text = "150" '"N/A"
            Else
                lblTC.Text = iRow.Item("TotalChol").ToString
            End If

            'caculated
            icTC = iRow.Item("TotalChol")
            icTrig = iRow.Item("Triglyc")
            icLDL = iRow.Item("LDL")
            icHDL = iRow.Item("HDL")
            dcNonHDL = iRow.Item("NonHDL")
            dcTCHDL = iRow.Item("TCHDL")

        End If
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        'Misc Data
        objDS = objDALVisit.GetMiscData(m_PatientID, m_VisitID)
        If objDS.Tables(0).Rows.Count > 0 Then
            iRow = objDS.Tables(0).Rows(0)
            If iRow.Item("Glucose").ToString = "0" Then
                lblglu.Text = "7"
            Else
                lblglu.Text = iRow.Item("Glucose").ToString
            End If
            'caculated 

            icGlucose = iRow.Item("Glucose")
            icLiverALT = iRow.Item("LiverALT")
            icLiverAST = iRow.Item("LiverAST")

        End If
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing


        objDS = objDALVisit.GetPhaseConditions(m_PatientID, m_VisitID, m_BodyType)
        If objDS.Tables(0).Rows.Count > 0 Then
            For Each iRow In objDS.Tables(0).Rows
                tmpPhase = iRow.Item("Phase")
                If tmpPhase > m_Phase Then
                    m_Phase = tmpPhase
                End If
            Next
        End If
        iRow = Nothing
        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing

        objDALPatient = Nothing
        objDALVisit = Nothing

        SetPhase(m_Phase)
        'Load Picture
        Picture7.Image = System.Drawing.Image.FromFile(GetImageName(dBMI, m_BodyType, strGender))


        Select Case m_BodyType
            Case 1
                lblBodyHeader.Text = "BioDézyne Body Type One"
                lblBodyDetails.Text = "The result of your body scan indicates that you fit in the BioDézyne Type One category. This type relates to that part of the endocrine system most influenced by poorly digested sugars and most carbohydrates. Although you may be drawn to other foods besides the ones mentioned bio-chemical individualism takes into consideration all of a person’s unique qualities and lack of specific carbohydrate digestive enzymes."
                lblStim.Text = "Endocrine system over stimulated by: Sugars and simple carbohydrates"
                lblImbal.Text = "Primary glandular imbalance: Thyroid gland"
                lblSym1.Text = "Fatigue"
                lblSym2.Text = "Nervousness"
                lblSym3.Text = "Depression"
                lblSym4.Text = "Weight imbalance"
                lblSym5.Text = "Allergies"
                lblSym6.Text = "Insomnia"
                lblSym7.Text = "Skin problems"
                lblSym8.Text = "Heart palpitations"
                lblSym9.Text = "Restlessness"
                lblSym10.Text = "Cold hands and feet"
                lblSym11.Text = "Leg cramps"
                lblSym12.Text = "Lethargy"
                lblSym13.Text = "Hypoglycemia"
                lblSym14.Text = "Headaches"
                lblSym15.Text = "Mood swings"


            Case 2
                lblBodyHeader.Text = "BioDézyne Body Type Two"
                lblBodyDetails.Text = "The result of your body scan indicates that you fit in the BioDézyne Type Two category. This type relates to that part of the endocrine system most influenced by poorly digested fried, fatty, ethnic and starchy foods. Although you may be drawn to other foods besides the ones mentioned bio-chemical individualism takes into consideration all of a person’s unique qualities and lack of specific enzymes for proper breakdown of fats."
                lblStim.Text = "Endocrine system over stimulated by: Fried, fatty, ethnic and starchy foods"
                lblImbal.Text = "Primary glandular imbalance: Reproductive Organs"
                lblSym1.Text = "Arthritis"
                lblSym2.Text = "Bladder conditions"
                lblSym3.Text = "High cholesterol"
                lblSym4.Text = "Acne"
                lblSym5.Text = "Gallbladder problems"
                lblSym6.Text = "Urinary conditions"
                lblSym7.Text = "Esophageal reflux"
                lblSym8.Text = "Psoriasis"
                lblSym9.Text = "Prostate disorders"
                lblSym10.Text = "Hormonal problems"
                lblSym11.Text = "Cystitis"
                lblSym12.Text = "Diabetes"
                lblSym13.Text = "Osteoporosis"
                lblSym14.Text = "Cardiovascular conditions"
                lblSym15.Text = "Digestive disorders"
            Case 3
                lblBodyHeader.Text = "BioDézyne Body Type Three"
                lblBodyDetails.Text = "The result of your body scan indicates that you fit in the BioDézyne Type Three category. This type relates to that part of the endocrine system most influenced by poorly digested proteins. Although you may be drawn to other foods besides the ones mentioned, bio-chemical individualism takes into consideration all of a person’s unique qualities and lack of specific protein digestive enzymes."
                lblStim.Text = "Endocrine system over stimulated by: Proteins"
                lblImbal.Text = "Primary glandular imbalance: Adrenal gland"
                lblSym1.Text = "Fatigue from stress"
                lblSym2.Text = "High blood pressure"
                lblSym3.Text = "Insomnia"
                lblSym4.Text = "Kidney conditions"
                lblSym5.Text = "Constipation"
                lblSym6.Text = "Poor mineralization of fluids"
                lblSym7.Text = "Body aches"
                lblSym8.Text = "Osteoporosis"
                lblSym9.Text = "Pain behind the left shoulder"
                lblSym10.Text = "Gout"
                lblSym11.Text = "Loss of hearing"
                lblSym12.Text = "Cardiovascular disease"
                lblSym13.Text = ""
                lblSym14.Text = ""
                lblSym15.Text = ""
            Case 4
                lblBodyHeader.Text = "BioDézyne Body Type Four"
                lblBodyDetails.Text = "The result of your body scan indicates that you fit in the BioDézyne Type Four category. This type relates to that part of the endocrine system most influenced by poorly digested dairy, sugar and fatty foods. Although you may be drawn to other foods besides the ones mentioned, bio-chemical individualism takes into consideration all of a person’s unique qualities and lack of specific digestive enzymes."
                lblStim.Text = "Endocrine system over stimulated by: Dairy, sugar, and fatty foods"
                lblImbal.Text = "Primary glandular imbalance: Pituitary hormones"
                lblSym1.Text = "Allergies"
                lblSym2.Text = "Aching knees"
                lblSym3.Text = "Irritable bowel syndrome"
                lblSym4.Text = "Bloating"
                lblSym5.Text = "Milk intolerance"
                lblSym6.Text = "Cholesterol imbalance"
                lblSym7.Text = "Anxiety"
                lblSym8.Text = "Diarrhea"
                lblSym9.Text = "Fatigue"
                lblSym10.Text = "Skin conditions"
                lblSym11.Text = "Nervousness"
                lblSym12.Text = "Gas"
                lblSym13.Text = "Type II Diabetes"
                lblSym14.Text = "Diverticulitis"
                lblSym15.Text = "Weak constitution"
        End Select




        strTCDef = "Total Cholesterol.....Cholesterol comes from two sources: your liver and food; vital to cell membranes, nerve fibers, bile salts and sex hormones." & vbCrLf
        strTrigDef = "Triglyceride Levels....Fats used as fuel by body, and as an energy source for metabolism." & vbCrLf
        strLDLDef = "LDL....The 'Bad Cholesterol' which carries cholesterol for cell building needs, but leaves behind any excess on artery walls and in tissues." & vbCrLf
        strHDLDef = "HDL....The 'Good Cholesterol' which helps to prevent narrowing of artery walls by removing the excess cholesterol and transporting it to the liver for excretion." & vbCrLf
        strNonHDLDef = "Non-HDL....Any cholesterol that is NOT associated with HDL particles, calculated by subtracting HDL from Total Cholesterol.  Particularly helpful in people with high triglycerides.  Non-HDL is better predictor of who will develop heart disease.  AMA suggest females aim for level of 130 mg/Dl."
        strLiverDef = "Liver Profile.....ALT/AST are enzymes found in the liver and are markers for liver injury." & vbCrLf
        strGlucoseDef = "Blood Glucose.....Chief source of energy for all living organisms.  If level is elevated even in a non-fasting setting, one must be concerned that there is risk for developing diabetes if above 124." & vbCrLf
        strBloodDef = "Blood Pressure.....Is the force exerted by circulating blood on the walls of blood vessels.  It is generated by the heart pumping blood into the arteries and is regulated by the response by the arteries to the flow of blood.  The systolic blood pressure number (top number, 90-120) represents the pressure in the arteries as the muscle of the heart contracts and pumps blood into them.  The diastolic pressure (bottom number, 60-80) represents the pressure in the arteries as the muscle of the heart relaxes after it contracts." & vbCrLf
        strBMIDef = "BMI....Body Mass Index is the relationship between weight, height that is associated with body fat and health risk factors for disease and conditions associated with obesity"


        'caculate risk 
        m_RiskList.Clear()

        'Blood Pressure
        If dcBPSystolic <= 109 And dcBPDiastolic <= 69 Then
            'low blood pressure
            If m_BodyType = 1 Then
                m_RiskList.Add(strBloodDef & "Low blood pressure (hypotension) causes symptoms due to low flow of blood through the arteries and veins.  When the flow of blood is too low to deliver enough oxygen and nutrients to vital organs such as the brain, heart and kidney, the organs do not function normally.", 75)
            Else
                m_RiskList.Add(strBloodDef & "Low blood pressure (hypotension) causes symptoms due to low flow of blood through the arteries and veins.  When the flow of blood is too low to deliver enough oxygen and nutrients to vital organs such as the brain, heart and kidney, the organs do not function normally.", 50)
            End If
        ElseIf dcBPSystolic >= 160 And dcBPDiastolic >= 100 Then
            'stage 2
            m_RiskList.Add(strBloodDef & "High blood pressure (hypertension) increases risk of developing heart or kidney disease, hardening of the arteries, eye damage and stroke", 77)

        ElseIf dcBPSystolic >= 140 And dcBPDiastolic >= 90 Then
            'stage 1
            m_RiskList.Add(strBloodDef & "High blood pressure (hypertension) increases risk of developing heart or kidney disease, hardening of the arteries, eye damage and stroke", 76)
        ElseIf dcBPSystolic >= 110 And dcBPDiastolic >= 70 Then
            'pre hybertension
            m_RiskList.Add(strBloodDef & "High blood pressure (hypertension) increases risk of developing heart or kidney disease, hardening of the arteries, eye damage and stroke", 25)
        End If

        ''IBW
        'If dcBodyWeight <= icIBW - (icIBW * 0.2) Then
        '    'under weight
        '    m_RiskList.Add("You have the propensity for IBW", 78)

        'ElseIf dcBodyWeight >= icIBW + (icIBW * 0.2) Then
        '    'overweight
        '    m_RiskList.Add("You have the propensity for IBW", 26)
        'ElseIf dcBodyWeight >= icIBW + 100 Then
        '    'morbid obesity
        '    m_RiskList.Add("You have the propensity for IBW", 79)
        'ElseIf dcBodyWeight >= icIBW + 55 Then
        '    'obese
        '    m_RiskList.Add("You have the propensity for IBW", 51)
        'End If

        'BMI

        If dcBMI > 0 Then
            If dcBMI > 18.5 Then
                'underweight
                m_RiskList.Add(strBMIDef, 52)
            ElseIf dcBMI > 35 Then
                'morbid obesity
                m_RiskList.Add(strBMIDef, 80)
            ElseIf dcBMI > 30 Then
                'obese
                m_RiskList.Add(strBMIDef, 53)
            ElseIf dcBMI > 25 Then
                'overeweight
                m_RiskList.Add(strBMIDef, 27)
            End If
        End If

        'waist hip ratio

        'If strGender = "Male" Then
        '    'men
        '    If dcWaistHip > 0.9 Then
        '        m_RiskList.Add("You have the propensity for Waist/Hip ratio", 82)
        '    End If
        'Else
        '    'women
        '    If dcWaistHip > 0.8 Then
        '        m_RiskList.Add("You have the propensity for Waist/Hip ratio", 81)
        '    End If
        'End If




        'Total Cholesterol
        If icTC > 0 Then
            If icTC < 120 Then
                'very low
                m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ": May be indicative to link with hormonal disturbance, premature births and/or cancer.  Indicates malabsorption or carbohydrate sensitivity.", 83)
            ElseIf icTC < 150 Then
                'low
                m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 28)
            ElseIf icTC >= 240 Then
                'high risk
                m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 85)
            ElseIf icTC >= 221 Then
                'at risk
                If m_BodyType = 1 Or m_BodyType = 4 Then
                    m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 55)
                Else
                    m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 84)
                End If
            ElseIf icTC > 181 Then
                'borderline
                If m_BodyType = 1 Or m_BodyType = 4 Then
                    m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 29)
                Else
                    m_RiskList.Add(strTCDef & "Your result " & icTC.ToString & ":  Indicative of your risk factor that increases chance of developing heart disease and/or stroke.  Indicates diet high in carbohydrate/sugars", 54)
                End If
            End If
        End If


        'triglyceride
        If icTrig > 0 Then

            If icTrig >= 200 Then
                'high
                m_RiskList.Add(strTrigDef & "Your result " & icTrig.ToString & ":  Almost always sign of too much fried foods and glucose intake.", 86)
            ElseIf icTrig >= 151 Then
                'borderline
                m_RiskList.Add(strTrigDef & "Your result " & icTrig.ToString & ":  Almost always sign of too much fried foods and glucose intake.", 29)
            End If
        End If

        'ldl
        If icLDL > 0 Then

            If icLDL >= 160 Then
                'high
                m_RiskList.Add(strLDLDef & "Your result " & icLDL.ToString & ":  Increased risk for heart disease, strokes and kidney disease.", 87)
            ElseIf icLDL >= 130 Then
                'borderline
                m_RiskList.Add(strLDLDef & "Your result " & icLDL.ToString & ":  Increased risk for heart disease, strokes and kidney disease.", 56)
            ElseIf icLDL >= 100 Then
                'near optimal
                'm_RiskList.Add("You have the propensity for LDL", 30)
            End If
        End If

        'hdl
        If icHDL > 0 Then
            If strGender = "Male" Then

                If icHDL < 50 Then
                    'high risk
                    m_RiskList.Add(strHDLDef & "Your result " & icHDL.ToString & ":  frequently indicates diets high in refined carbohydrates and or carbohydrate sensitivity. Overweight and High Triglycerides", 88)
                End If
            Else
                If icHDL < 40 Then
                    'high risk
                    m_RiskList.Add(strHDLDef & "Your result " & icHDL.ToString & ":  frequently indicates diets high in refined carbohydrates and or carbohydrate sensitivity. Overweight and High Triglycerides", 89)
                End If
            End If
        End If

        'non HDL
        If dcNonHDL > 0 Then
            If dcNonHDL >= 5.1 Then
                'at risk
                m_RiskList.Add(strNonHDLDef, 91)
            ElseIf dcNonHDL >= 3.6 Then
                'out of range
                If m_BodyType = 1 Or m_BodyType = 4 Then
                    m_RiskList.Add(strNonHDLDef, 31)
                Else
                    m_RiskList.Add(strNonHDLDef, 36)
                End If
            End If
        End If

        'Liver ALT
        If icLiverALT > 0 Then

            If icLiverALT > 65 Then
                'red
                m_RiskList.Add(strLiverDef & "Your result " & icLiverALT.ToString & ":  Indication of liver injury, hepatitis, large intake of alcohol, certain drugs can affect results", 92)

            ElseIf icLiverALT >= 41 Then
                'yellow
                'm_RiskList.Add("You have the propensity for Liver ALT", 32)
            End If
        End If

        'Liver AST
        If icLiverAST > 0 Then
            If icLiverAST > 50 Then
                'red
                m_RiskList.Add(strLiverDef & "Your result " & icLiverALT.ToString & ":  Indication of liver injury, hepatitis, large intake of alcohol, certain drugs can affect results", 93)
            ElseIf icLiverAST > 31 Then
                'yellow
                'm_RiskList.Add("You have the propensity for Liver AST", 33)
            End If
        End If

        'TCHDL
        'If dcTCHDL >= 5.1 Then
        '    'at risk
        '    m_RiskList.Add("You have the propensity for Liver AST", 91)
        'ElseIf dcTCHDL > 3.6 Then
        '    'out of range
        '    m_RiskList.Add("You have the propensity for Liver AST", 35)
        'End If

        GetRiskText()
    End Sub

    Private Function GetImageName(ByVal dBMI As Double, ByVal iBodyType As Integer, ByVal strGender As String) As String
        Dim rntStr As String = ""
        Dim MyPath As String

        myPath = Path.GetDirectoryName(Application.ExecutablePath)
        If dBMI = 0 Then
            dBMI = 17.5
        End If
        If iBodyType = 0 Then
            iBodyType = 1
        End If

        If strGender = "Male" Then
            If dBMI < 18.5 Then
                ' "Underweight"
                Select Case iBodyType
                    Case 1
                        rntStr = "Skinny_Man_NS_NH.png"
                    Case 2
                        rntStr = "Skinny_Man_NS_WH.png"
                    Case 3
                        rntStr = "Skinny_Man_WS_NH.png"
                    Case 4
                        rntStr = "Skinny_Man_WS_WH.png"
                End Select

            ElseIf dBMI < 25 Then
                ' "Normal"
                Select Case iBodyType
                    Case 1
                        rntStr = "Normal_Man_NS_NH.png"
                    Case 2
                        rntStr = "Normal_Man_NS_WH.png"
                    Case 3
                        rntStr = "Normal_Man_WS_NH.png"
                    Case 4
                        rntStr = "Normal_Man_WS_WH.png"
                End Select

            ElseIf dBMI < 30 Then
                ' "Overweight"
                Select Case iBodyType
                    Case 1
                        rntStr = "Fat_Man_NS_NH.png"
                    Case 2
                        rntStr = "Fat_Man_NS_WH.png"
                    Case 3
                        rntStr = "Fat_Man_WS_NH.png"
                    Case 4
                        rntStr = "Fat_Man_WS_WH.png"
                End Select
            ElseIf dBMI > 29 Then
                '"Obese"
                Select Case iBodyType
                    Case 1
                        rntStr = "Obese_Man_NS_NH.png"
                    Case 2
                        rntStr = "Obese_Man_NS_WH.png"
                    Case 3
                        rntStr = "Obese_Man_WS_NH.png"
                    Case 4
                        rntStr = "Obese_Man_WS_WH.png"
                End Select
            End If
            rntStr = MyPath & "\images\male\" & rntStr
        Else 'female
            If dBMI < 18.5 Then
                ' "Underweight"
                Select Case iBodyType
                    Case 1
                        rntStr = "Skinny_Woman_NS_NH.png"
                    Case 2
                        rntStr = "Skinny_Woman_NS_WH.png"
                    Case 3
                        rntStr = "Skinny_Woman_WS_NH.png"
                    Case 4
                        rntStr = "Skinny_Woman_WS_WH.png"
                End Select

            ElseIf dBMI < 25 Then
                ' "Normal"
                Select Case iBodyType
                    Case 1
                        rntStr = "Normal_Woman_NS_NH.png"
                    Case 2
                        rntStr = "Normal_Woman_NS_WH.png"
                    Case 3
                        rntStr = "Normal_Woman_WS_NH.png"
                    Case 4
                        rntStr = "Normal_Woman_WS_WH.png"
                End Select

            ElseIf dBMI < 30 Then
                ' "Overweight"
                Select Case iBodyType
                    Case 1
                        rntStr = "Fat_Woman_NS_NH.png"
                    Case 2
                        rntStr = "Fat_Woman_NS_WH.png"
                    Case 3
                        rntStr = "Fat_Woman_WS_NH.png"
                    Case 4
                        rntStr = "Fat_Woman_WS_WH.png"
                End Select
            ElseIf dBMI > 29 Then
                '"Obese"
                Select Case iBodyType
                    Case 1
                        rntStr = "Obese_Woman_NS_NH.png"
                    Case 2
                        rntStr = "Obese_Woman_NS_WH.png"
                    Case 3
                        rntStr = "Obese_Woman_WS_NH.png"
                    Case 4
                        rntStr = "Obese_Woman_WS_WH.png"
                End Select
            End If
            rntStr = MyPath & "\images\female\" & rntStr
        End If
        Return rntStr
    End Function

    Private Sub GetRiskText()
        Dim iLoop As Integer
        Dim iIndx As Integer
        Dim oLoop As Integer

        For oLoop = 1 To 4
            iIndx = 0
            For iLoop = 1 To m_RiskList.Count - 1
                If CType(m_RiskList.GetValue(iLoop), Integer) > CType(m_RiskList.GetValue(iIndx), Integer) Then
                    iIndx = iLoop
                End If
            Next
            If m_RiskList.GetName(iIndx) <> "" Then
                lblRisk.Text = lblRisk.Text & oLoop.ToString & ". " & m_RiskList.GetName(iIndx) & vbCrLf
                If m_RiskList.Count > 0 Then
                    m_RiskList.DeleteItem(iIndx)
                End If
            End If
        Next

    End Sub



End Class
