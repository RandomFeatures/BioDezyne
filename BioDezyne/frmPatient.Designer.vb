<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatient
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatient))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gbMain = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnPrint = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnPre = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.patientNav = New ComponentFactory.Krypton.Navigator.KryptonNavigator
        Me.pgPatient = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.cbDOBmm = New RFIControls.ComboPlus
        Me.cbDobyyyy = New RFIControls.ComboPlus
        Me.txtDobdd = New RFIControls.TextPlus
        Me.cbGender = New RFIControls.ComboPlus
        Me.lblFirst = New System.Windows.Forms.Label
        Me.txtFirstName = New RFIControls.TextPlus
        Me.txtMI = New RFIControls.TextPlus
        Me.txtLastName = New RFIControls.TextPlus
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblMI = New System.Windows.Forms.Label
        Me.lblDob = New System.Windows.Forms.Label
        Me.lblLast = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.pgContact = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.txtAddress = New RFIControls.TextPlus
        Me.Label76 = New System.Windows.Forms.Label
        Me.txtPhone = New RFIControls.TextPlus
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.txtEmail = New RFIControls.TextPlus
        Me.MainNavigator = New ComponentFactory.Krypton.Navigator.KryptonNavigator
        Me.pgHistory = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.btnDeleteVisit = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnExport = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnPreview = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.gridVisitHistory = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.gpname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpvisit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpgender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpheight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdexaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnVPrint = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnEditVisit = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnNewVisit = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pgQuestion = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.KryptonHeaderGroup14 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtQuest5 = New RFIControls.ComboPlus
        Me.dtQuestDate = New System.Windows.Forms.DateTimePicker
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.txtQuest7 = New System.Windows.Forms.ComboBox
        Me.txtQuest9 = New RFIControls.TextPlus
        Me.txtQuest8 = New RFIControls.TextPlus
        Me.txtQuest6 = New RFIControls.TextPlus
        Me.txtQuest4 = New RFIControls.TextPlus
        Me.txtQuest3 = New RFIControls.TextPlus
        Me.txtQuest2 = New System.Windows.Forms.ComboBox
        Me.txtQuest1 = New RFIControls.TextPlus
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.pgCondition = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.dgConditions = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtConditonInfo = New RFIControls.TextPlus
        Me.pgScanData = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.KryptonHeaderGroup5 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cbExercise = New RFIControls.ComboPlus
        Me.cbBodyType = New RFIControls.ComboPlus
        Me.Label66 = New System.Windows.Forms.Label
        Me.txtRMR = New RFIControls.TextPlus
        Me.Label67 = New System.Windows.Forms.Label
        Me.txtVO2 = New RFIControls.TextPlus
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtbp2 = New RFIControls.TextPlus
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtbp1 = New RFIControls.TextPlus
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtClavical = New RFIControls.TextPlus
        Me.txtHip = New RFIControls.TextPlus
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtWaist = New RFIControls.TextPlus
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPelvic = New RFIControls.TextPlus
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIBW = New RFIControls.TextPlus
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWeight = New RFIControls.TextPlus
        Me.txtDesirWeight = New RFIControls.TextPlus
        Me.txtBMI = New RFIControls.TextPlus
        Me.txtHeight = New RFIControls.TextPlus
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.pgCholesterol = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.KryptonHeaderGroup13 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtDensity = New RFIControls.TextPlus
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtFluid = New RFIControls.TextPlus
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtFat = New RFIControls.TextPlus
        Me.txtMuscle = New RFIControls.TextPlus
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtBone = New RFIControls.TextPlus
        Me.KryptonHeaderGroup9 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtRiskAss = New RFIControls.TextPlus
        Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cbGlucoseTest = New RFIControls.ComboPlus
        Me.Label77 = New System.Windows.Forms.Label
        Me.txtTime = New RFIControls.TextPlus
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtGlucosResult = New RFIControls.TextPlus
        Me.Label23 = New System.Windows.Forms.Label
        Me.KryptonHeaderGroup7 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtALT = New RFIControls.TextPlus
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtAST = New RFIControls.TextPlus
        Me.KryptonHeaderGroup6 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Label73 = New System.Windows.Forms.Label
        Me.dateCholTest = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtTotalChol = New RFIControls.TextPlus
        Me.txtTrg = New RFIControls.TextPlus
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtTCHDL = New RFIControls.TextPlus
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNonHDL = New RFIControls.TextPlus
        Me.txtLDL = New RFIControls.TextPlus
        Me.txtHDL = New RFIControls.TextPlus
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.pgBCA = New ComponentFactory.Krypton.Navigator.KryptonPage
        Me.KryptonHeaderGroup10 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtBMI2 = New RFIControls.TextPlus
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtReact = New RFIControls.TextPlus
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtResist = New RFIControls.TextPlus
        Me.Label69 = New System.Windows.Forms.Label
        Me.txtECWLiters = New RFIControls.TextPlus
        Me.Label68 = New System.Windows.Forms.Label
        Me.txtICWLiters = New RFIControls.TextPlus
        Me.txtCapa = New RFIControls.TextPlus
        Me.txtTBWLiters = New RFIControls.TextPlus
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtFatper = New RFIControls.TextPlus
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtFFMp = New RFIControls.TextPlus
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtPhaseAngle = New RFIControls.TextPlus
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtTBW = New RFIControls.TextPlus
        Me.txtECMp = New RFIControls.TextPlus
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtBCMp = New RFIControls.TextPlus
        Me.txtECW = New RFIControls.TextPlus
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtFatp = New RFIControls.TextPlus
        Me.txtICW = New RFIControls.TextPlus
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtBMR = New RFIControls.TextPlus
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtFFM = New RFIControls.TextPlus
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtECM = New RFIControls.TextPlus
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtBCM = New RFIControls.TextPlus
        Me.Label51 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.PdfExport = New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        Me.TextBox26 = New RFIControls.TextPlus
        Me.TextBox28 = New RFIControls.TextPlus
        Me.TextBox29 = New RFIControls.TextPlus
        Me.TextBox30 = New RFIControls.TextPlus
        Me.TextBox31 = New RFIControls.TextPlus
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMain.Panel.SuspendLayout()
        Me.gbMain.SuspendLayout()
        CType(Me.patientNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.patientNav.SuspendLayout()
        CType(Me.pgPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgPatient.SuspendLayout()
        CType(Me.pgContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgContact.SuspendLayout()
        CType(Me.MainNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainNavigator.SuspendLayout()
        CType(Me.pgHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgHistory.SuspendLayout()
        CType(Me.gridVisitHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgQuestion.SuspendLayout()
        CType(Me.KryptonHeaderGroup14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup14.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup14.Panel.SuspendLayout()
        Me.KryptonHeaderGroup14.SuspendLayout()
        CType(Me.pgCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCondition.SuspendLayout()
        CType(Me.dgConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.pgScanData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgScanData.SuspendLayout()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup5.Panel.SuspendLayout()
        Me.KryptonHeaderGroup5.SuspendLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.pgCholesterol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCholesterol.SuspendLayout()
        CType(Me.KryptonHeaderGroup13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup13.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup13.Panel.SuspendLayout()
        Me.KryptonHeaderGroup13.SuspendLayout()
        CType(Me.KryptonHeaderGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup9.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup9.Panel.SuspendLayout()
        Me.KryptonHeaderGroup9.SuspendLayout()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup8.Panel.SuspendLayout()
        Me.KryptonHeaderGroup8.SuspendLayout()
        CType(Me.KryptonHeaderGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup7.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup7.Panel.SuspendLayout()
        Me.KryptonHeaderGroup7.SuspendLayout()
        CType(Me.KryptonHeaderGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup6.Panel.SuspendLayout()
        Me.KryptonHeaderGroup6.SuspendLayout()
        CType(Me.pgBCA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgBCA.SuspendLayout()
        CType(Me.KryptonHeaderGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup10.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup10.Panel.SuspendLayout()
        Me.KryptonHeaderGroup10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gbMain)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(815, 544)
        Me.KryptonPanel.TabIndex = 0
        '
        'gbMain
        '
        Me.gbMain.AllowButtonSpecToolTips = True
        Me.gbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMain.AutoCollapseArrow = False
        Me.gbMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSave, Me.btnPrint, Me.btnPre})
        Me.gbMain.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.gbMain.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.gbMain.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.gbMain.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.gbMain.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.gbMain.Location = New System.Drawing.Point(16, 6)
        Me.gbMain.Margin = New System.Windows.Forms.Padding(4)
        Me.gbMain.Name = "gbMain"
        '
        'gbMain.Panel
        '
        Me.gbMain.Panel.Controls.Add(Me.patientNav)
        Me.gbMain.Panel.Controls.Add(Me.MainNavigator)
        Me.gbMain.Panel.Controls.Add(Me.PictureBox1)
        Me.gbMain.Panel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gbMain.Size = New System.Drawing.Size(783, 532)
        Me.gbMain.TabIndex = 1
        Me.gbMain.ValuesPrimary.Description = ""
        Me.gbMain.ValuesPrimary.Heading = ""
        Me.gbMain.ValuesPrimary.Image = Nothing
        Me.gbMain.ValuesSecondary.Description = ""
        Me.gbMain.ValuesSecondary.Heading = "Patient Data"
        Me.gbMain.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.stock_people
        '
        'btnSave
        '
        Me.btnSave.ExtraText = ""
        Me.btnSave.Image = Nothing
        Me.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipImage = Nothing
        Me.btnSave.UniqueName = "10B7991B9B4F4AEC10B7991B9B4F4AEC"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btnPrint.ExtraText = ""
        Me.btnPrint.Image = Nothing
        Me.btnPrint.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnPrint.Text = "Print Visit"
        Me.btnPrint.ToolTipImage = Nothing
        Me.btnPrint.UniqueName = "DEC950E3263A4F1CDEC950E3263A4F1C"
        '
        'btnPre
        '
        Me.btnPre.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btnPre.ExtraText = ""
        Me.btnPre.Image = Nothing
        Me.btnPre.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnPre.Text = "Print Preview"
        Me.btnPre.ToolTipImage = Nothing
        Me.btnPre.UniqueName = "DC26B96C220344B8DC26B96C220344B8"
        '
        'patientNav
        '
        Me.patientNav.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.patientNav.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop
        Me.patientNav.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight
        Me.patientNav.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedEqualSmall
        Me.patientNav.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.OneNote
        '
        '
        '
        Me.patientNav.Button.CloseButton.ExtraText = ""
        Me.patientNav.Button.CloseButton.Image = Nothing
        Me.patientNav.Button.CloseButton.Text = ""
        Me.patientNav.Button.CloseButton.ToolTipImage = Nothing
        Me.patientNav.Button.CloseButton.UniqueName = "1473435559B148A11473435559B148A1"
        Me.patientNav.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        '
        '
        '
        Me.patientNav.Button.ContextButton.ExtraText = ""
        Me.patientNav.Button.ContextButton.Image = Nothing
        Me.patientNav.Button.ContextButton.Text = ""
        Me.patientNav.Button.ContextButton.ToolTipImage = Nothing
        Me.patientNav.Button.ContextButton.UniqueName = "58645856A2C549A458645856A2C549A4"
        Me.patientNav.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.patientNav.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.None
        Me.patientNav.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None
        '
        '
        '
        Me.patientNav.Button.NextButton.ExtraText = ""
        Me.patientNav.Button.NextButton.Image = Nothing
        Me.patientNav.Button.NextButton.Text = ""
        Me.patientNav.Button.NextButton.ToolTipImage = Nothing
        Me.patientNav.Button.NextButton.UniqueName = "CB0678AAF48C4D3ACB0678AAF48C4D3A"
        '
        '
        '
        Me.patientNav.Button.PreviousButton.ExtraText = ""
        Me.patientNav.Button.PreviousButton.Image = Nothing
        Me.patientNav.Button.PreviousButton.Text = ""
        Me.patientNav.Button.PreviousButton.ToolTipImage = Nothing
        Me.patientNav.Button.PreviousButton.UniqueName = "71A97AFCD8234A6071A97AFCD8234A60"
        Me.patientNav.Header.HeaderValuesPrimary.Description = ""
        Me.patientNav.Header.HeaderValuesPrimary.Heading = "(Empty)"
        Me.patientNav.Header.HeaderValuesPrimary.Image = Nothing
        Me.patientNav.Header.HeaderValuesSecondary.Description = ""
        Me.patientNav.Header.HeaderValuesSecondary.Heading = " "
        Me.patientNav.Header.HeaderValuesSecondary.Image = Nothing
        Me.patientNav.Location = New System.Drawing.Point(129, 5)
        Me.patientNav.Margin = New System.Windows.Forms.Padding(4)
        Me.patientNav.Name = "patientNav"
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.Pages.Add(Me.pgPatient)
        Me.patientNav.Pages.Add(Me.pgContact)
        Me.patientNav.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary
        Me.patientNav.SelectedIndex = 0
        Me.patientNav.Size = New System.Drawing.Size(625, 140)
        Me.patientNav.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.Panel.Color1 = System.Drawing.Color.Transparent
        Me.patientNav.StateNormal.Panel.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.patientNav.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.StateNormal.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.patientNav.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.patientNav.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.patientNav.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.patientNav.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.patientNav.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.patientNav.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.patientNav.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.patientNav.TabIndex = 26
        '
        'pgPatient
        '
        Me.pgPatient.Controls.Add(Me.cbDOBmm)
        Me.pgPatient.Controls.Add(Me.cbDobyyyy)
        Me.pgPatient.Controls.Add(Me.txtDobdd)
        Me.pgPatient.Controls.Add(Me.cbGender)
        Me.pgPatient.Controls.Add(Me.lblFirst)
        Me.pgPatient.Controls.Add(Me.txtFirstName)
        Me.pgPatient.Controls.Add(Me.txtMI)
        Me.pgPatient.Controls.Add(Me.txtLastName)
        Me.pgPatient.Controls.Add(Me.lblGender)
        Me.pgPatient.Controls.Add(Me.lblMI)
        Me.pgPatient.Controls.Add(Me.lblDob)
        Me.pgPatient.Controls.Add(Me.lblLast)
        Me.pgPatient.Controls.Add(Me.Label48)
        Me.pgPatient.Controls.Add(Me.Label47)
        Me.pgPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.pgPatient.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgPatient.Name = "pgPatient"
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.Size = New System.Drawing.Size(573, 138)
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgPatient.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgPatient.Text = "Patient"
        Me.pgPatient.ToolTipTitle = "Page ToolTip"
        Me.pgPatient.UniqueName = "814454F0217D46B3814454F0217D46B3"
        '
        'cbDOBmm
        '
        Me.cbDOBmm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDOBmm.FlayStyle = False
        Me.cbDOBmm.FocusBGColor = System.Drawing.Color.Empty
        Me.cbDOBmm.FocusFontColor = System.Drawing.Color.Empty
        Me.cbDOBmm.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbDOBmm.FormattingEnabled = True
        Me.cbDOBmm.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbDOBmm.Location = New System.Drawing.Point(279, 86)
        Me.cbDOBmm.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDOBmm.Name = "cbDOBmm"
        Me.cbDOBmm.Size = New System.Drawing.Size(120, 24)
        Me.cbDOBmm.TabIndex = 5
        '
        'cbDobyyyy
        '
        Me.cbDobyyyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDobyyyy.FlayStyle = False
        Me.cbDobyyyy.FocusBGColor = System.Drawing.Color.Empty
        Me.cbDobyyyy.FocusFontColor = System.Drawing.Color.Empty
        Me.cbDobyyyy.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbDobyyyy.FormattingEnabled = True
        Me.cbDobyyyy.Location = New System.Drawing.Point(471, 86)
        Me.cbDobyyyy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDobyyyy.Name = "cbDobyyyy"
        Me.cbDobyyyy.Size = New System.Drawing.Size(80, 24)
        Me.cbDobyyyy.TabIndex = 7
        '
        'txtDobdd
        '
        Me.txtDobdd.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtDobdd.FocusFontColor = System.Drawing.Color.Blue
        Me.txtDobdd.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtDobdd.Location = New System.Drawing.Point(413, 86)
        Me.txtDobdd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDobdd.MaxLength = 2
        Me.txtDobdd.Name = "txtDobdd"
        Me.txtDobdd.Size = New System.Drawing.Size(45, 22)
        Me.txtDobdd.TabIndex = 6
        Me.txtDobdd.TabOnEnter = False
        Me.txtDobdd.Text = "dd"
        Me.txtDobdd.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FlayStyle = False
        Me.cbGender.FocusBGColor = System.Drawing.Color.LightYellow
        Me.cbGender.FocusFontColor = System.Drawing.Color.Blue
        Me.cbGender.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(279, 26)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(272, 24)
        Me.cbGender.TabIndex = 4
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.BackColor = System.Drawing.Color.Transparent
        Me.lblFirst.Location = New System.Drawing.Point(8, 6)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(73, 16)
        Me.lblFirst.TabIndex = 20
        Me.lblFirst.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFirstName.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFirstName.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFirstName.Location = New System.Drawing.Point(12, 26)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(185, 22)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.TabOnEnter = False
        Me.txtFirstName.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'txtMI
        '
        Me.txtMI.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtMI.FocusFontColor = System.Drawing.Color.Blue
        Me.txtMI.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtMI.Location = New System.Drawing.Point(207, 26)
        Me.txtMI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMI.MaxLength = 1
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(37, 22)
        Me.txtMI.TabIndex = 2
        Me.txtMI.TabOnEnter = False
        Me.txtMI.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'txtLastName
        '
        Me.txtLastName.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtLastName.FocusFontColor = System.Drawing.Color.Blue
        Me.txtLastName.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtLastName.Location = New System.Drawing.Point(12, 86)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(232, 22)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.TabOnEnter = False
        Me.txtLastName.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Location = New System.Drawing.Point(275, 6)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(53, 16)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender"
        '
        'lblMI
        '
        Me.lblMI.AutoSize = True
        Me.lblMI.BackColor = System.Drawing.Color.Transparent
        Me.lblMI.Location = New System.Drawing.Point(207, 6)
        Me.lblMI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMI.Name = "lblMI"
        Me.lblMI.Size = New System.Drawing.Size(22, 16)
        Me.lblMI.TabIndex = 18
        Me.lblMI.Text = "MI"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.BackColor = System.Drawing.Color.Transparent
        Me.lblDob.Location = New System.Drawing.Point(275, 66)
        Me.lblDob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(165, 16)
        Me.lblDob.TabIndex = 14
        Me.lblDob.Text = "Date of Birth (mm/dd/yyyy)"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.BackColor = System.Drawing.Color.Transparent
        Me.lblLast.Location = New System.Drawing.Point(8, 66)
        Me.lblLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(73, 16)
        Me.lblLast.TabIndex = 16
        Me.lblLast.Text = "Last Name"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Location = New System.Drawing.Point(459, 91)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(12, 16)
        Me.Label48.TabIndex = 24
        Me.Label48.Text = "/"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Location = New System.Drawing.Point(399, 91)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(12, 16)
        Me.Label47.TabIndex = 23
        Me.Label47.Text = "/"
        '
        'pgContact
        '
        Me.pgContact.Controls.Add(Me.txtAddress)
        Me.pgContact.Controls.Add(Me.Label76)
        Me.pgContact.Controls.Add(Me.txtPhone)
        Me.pgContact.Controls.Add(Me.Label75)
        Me.pgContact.Controls.Add(Me.Label74)
        Me.pgContact.Controls.Add(Me.txtEmail)
        Me.pgContact.Margin = New System.Windows.Forms.Padding(4)
        Me.pgContact.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgContact.Name = "pgContact"
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.Size = New System.Drawing.Size(571, 138)
        Me.pgContact.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgContact.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgContact.Text = "Contact"
        Me.pgContact.ToolTipTitle = "Page ToolTip"
        Me.pgContact.UniqueName = "AE44C1BD6656424FAE44C1BD6656424F"
        '
        'txtAddress
        '
        Me.txtAddress.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtAddress.FocusFontColor = System.Drawing.Color.Blue
        Me.txtAddress.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtAddress.Location = New System.Drawing.Point(9, 69)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(539, 62)
        Me.txtAddress.TabIndex = 9
        Me.txtAddress.TabOnEnter = False
        Me.txtAddress.TextType = RFIControls.enumTextType.Normal
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Location = New System.Drawing.Point(7, 52)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(59, 16)
        Me.Label76.TabIndex = 27
        Me.Label76.Text = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtPhone.FocusFontColor = System.Drawing.Color.Blue
        Me.txtPhone.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtPhone.Location = New System.Drawing.Point(9, 26)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.MaxLength = 20
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(216, 22)
        Me.txtPhone.TabIndex = 7
        Me.txtPhone.TabOnEnter = False
        Me.txtPhone.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Location = New System.Drawing.Point(241, 7)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(96, 16)
        Me.Label75.TabIndex = 25
        Me.Label75.Text = "Email Address"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Location = New System.Drawing.Point(5, 7)
        Me.Label74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(98, 16)
        Me.Label74.TabIndex = 23
        Me.Label74.Text = "Phone Number"
        '
        'txtEmail
        '
        Me.txtEmail.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtEmail.FocusFontColor = System.Drawing.Color.Blue
        Me.txtEmail.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtEmail.Location = New System.Drawing.Point(245, 26)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(303, 22)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.TabOnEnter = False
        Me.txtEmail.TextType = RFIControls.enumTextType.Normal
        '
        'MainNavigator
        '
        Me.MainNavigator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainNavigator.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote
        Me.MainNavigator.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.OneNote
        '
        '
        '
        Me.MainNavigator.Button.CloseButton.ExtraText = ""
        Me.MainNavigator.Button.CloseButton.Image = Nothing
        Me.MainNavigator.Button.CloseButton.Text = ""
        Me.MainNavigator.Button.CloseButton.ToolTipImage = Nothing
        Me.MainNavigator.Button.CloseButton.UniqueName = "BBF17B4552EE49E3BBF17B4552EE49E3"
        Me.MainNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        '
        '
        '
        Me.MainNavigator.Button.ContextButton.ExtraText = ""
        Me.MainNavigator.Button.ContextButton.Image = Nothing
        Me.MainNavigator.Button.ContextButton.Text = ""
        Me.MainNavigator.Button.ContextButton.ToolTipImage = Nothing
        Me.MainNavigator.Button.ContextButton.UniqueName = "403BAA41957A44F7403BAA41957A44F7"
        Me.MainNavigator.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None
        Me.MainNavigator.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.MainNavigator.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None
        '
        '
        '
        Me.MainNavigator.Button.NextButton.ExtraText = ""
        Me.MainNavigator.Button.NextButton.Image = Nothing
        Me.MainNavigator.Button.NextButton.Text = ""
        Me.MainNavigator.Button.NextButton.ToolTipImage = Nothing
        Me.MainNavigator.Button.NextButton.UniqueName = "4A03EE32AB964D1A4A03EE32AB964D1A"
        '
        '
        '
        Me.MainNavigator.Button.PreviousButton.ExtraText = ""
        Me.MainNavigator.Button.PreviousButton.Image = Nothing
        Me.MainNavigator.Button.PreviousButton.Text = ""
        Me.MainNavigator.Button.PreviousButton.ToolTipImage = Nothing
        Me.MainNavigator.Button.PreviousButton.UniqueName = "8470E179E5DD410A8470E179E5DD410A"
        Me.MainNavigator.Header.HeaderValuesPrimary.Description = ""
        Me.MainNavigator.Header.HeaderValuesPrimary.Heading = "(Empty)"
        Me.MainNavigator.Header.HeaderValuesPrimary.Image = Nothing
        Me.MainNavigator.Header.HeaderValuesSecondary.Description = ""
        Me.MainNavigator.Header.HeaderValuesSecondary.Heading = " "
        Me.MainNavigator.Header.HeaderValuesSecondary.Image = Nothing
        Me.MainNavigator.Location = New System.Drawing.Point(8, 154)
        Me.MainNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.MainNavigator.Name = "MainNavigator"
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.Pages.Add(Me.pgHistory)
        Me.MainNavigator.Pages.Add(Me.pgQuestion)
        Me.MainNavigator.Pages.Add(Me.pgCondition)
        Me.MainNavigator.Pages.Add(Me.pgScanData)
        Me.MainNavigator.Pages.Add(Me.pgCholesterol)
        Me.MainNavigator.Pages.Add(Me.pgBCA)
        Me.MainNavigator.SelectedIndex = 0
        Me.MainNavigator.Size = New System.Drawing.Size(756, 312)
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.Panel.Color1 = System.Drawing.Color.Transparent
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.MainNavigator.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.MainNavigator.TabIndex = 0
        Me.MainNavigator.Text = "KryptonNavigator1"
        '
        'pgHistory
        '
        Me.pgHistory.AutoScroll = True
        Me.pgHistory.Controls.Add(Me.btnDeleteVisit)
        Me.pgHistory.Controls.Add(Me.btnExport)
        Me.pgHistory.Controls.Add(Me.btnPreview)
        Me.pgHistory.Controls.Add(Me.gridVisitHistory)
        Me.pgHistory.Controls.Add(Me.btnVPrint)
        Me.pgHistory.Controls.Add(Me.btnEditVisit)
        Me.pgHistory.Controls.Add(Me.btnNewVisit)
        Me.pgHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.pgHistory.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgHistory.Name = "pgHistory"
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.Size = New System.Drawing.Size(754, 285)
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.StateNormal.Tab.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgHistory.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgHistory.Text = "Visit History"
        Me.pgHistory.ToolTipTitle = "Page ToolTip"
        Me.pgHistory.UniqueName = "493685AA50544AF4493685AA50544AF4"
        '
        'btnDeleteVisit
        '
        Me.btnDeleteVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteVisit.Location = New System.Drawing.Point(637, 205)
        Me.btnDeleteVisit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteVisit.Name = "btnDeleteVisit"
        Me.btnDeleteVisit.Size = New System.Drawing.Size(108, 31)
        Me.btnDeleteVisit.TabIndex = 26
        Me.btnDeleteVisit.Text = "Delete Visit"
        Me.btnDeleteVisit.Values.ExtraText = ""
        Me.btnDeleteVisit.Values.Image = Nothing
        Me.btnDeleteVisit.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnDeleteVisit.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnDeleteVisit.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnDeleteVisit.Values.Text = "Delete Visit"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(637, 166)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(108, 31)
        Me.btnExport.TabIndex = 25
        Me.btnExport.Text = "Export"
        Me.btnExport.Values.ExtraText = ""
        Me.btnExport.Values.Image = Nothing
        Me.btnExport.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExport.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExport.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExport.Values.Text = "Export"
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(637, 88)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(108, 31)
        Me.btnPreview.TabIndex = 24
        Me.btnPreview.Text = "Print Preview"
        Me.btnPreview.Values.ExtraText = ""
        Me.btnPreview.Values.Image = Nothing
        Me.btnPreview.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnPreview.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnPreview.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnPreview.Values.Text = "Print Preview"
        '
        'gridVisitHistory
        '
        Me.gridVisitHistory.AllowUserToAddRows = False
        Me.gridVisitHistory.AllowUserToDeleteRows = False
        Me.gridVisitHistory.AllowUserToResizeRows = False
        Me.gridVisitHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridVisitHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpname, Me.gpvisit, Me.gpWeight, Me.gpdob, Me.gpgender, Me.gpheight, Me.gpdexaid})
        Me.gridVisitHistory.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridVisitHistory.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridVisitHistory.Location = New System.Drawing.Point(11, 12)
        Me.gridVisitHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.gridVisitHistory.MultiSelect = False
        Me.gridVisitHistory.Name = "gridVisitHistory"
        Me.gridVisitHistory.ReadOnly = True
        Me.gridVisitHistory.RowHeadersVisible = False
        Me.gridVisitHistory.RowTemplate.ReadOnly = True
        Me.gridVisitHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridVisitHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridVisitHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridVisitHistory.Size = New System.Drawing.Size(616, 261)
        Me.gridVisitHistory.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridVisitHistory.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridVisitHistory.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridVisitHistory.TabIndex = 23
        '
        'gpname
        '
        Me.gpname.HeaderText = "ID"
        Me.gpname.Name = "gpname"
        Me.gpname.ReadOnly = True
        Me.gpname.Width = 50
        '
        'gpvisit
        '
        Me.gpvisit.HeaderText = "Visit Date"
        Me.gpvisit.Name = "gpvisit"
        Me.gpvisit.ReadOnly = True
        Me.gpvisit.Width = 125
        '
        'gpWeight
        '
        Me.gpWeight.HeaderText = "Weight"
        Me.gpWeight.Name = "gpWeight"
        Me.gpWeight.ReadOnly = True
        Me.gpWeight.Width = 80
        '
        'gpdob
        '
        Me.gpdob.HeaderText = "Blood Preasure"
        Me.gpdob.Name = "gpdob"
        Me.gpdob.ReadOnly = True
        Me.gpdob.Width = 150
        '
        'gpgender
        '
        Me.gpgender.HeaderText = "Cholesterol"
        Me.gpgender.Name = "gpgender"
        Me.gpgender.ReadOnly = True
        '
        'gpheight
        '
        Me.gpheight.HeaderText = "Glucose"
        Me.gpheight.Name = "gpheight"
        Me.gpheight.ReadOnly = True
        Me.gpheight.Width = 90
        '
        'gpdexaid
        '
        Me.gpdexaid.HeaderText = "scanid"
        Me.gpdexaid.Name = "gpdexaid"
        Me.gpdexaid.ReadOnly = True
        Me.gpdexaid.Visible = False
        '
        'btnVPrint
        '
        Me.btnVPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVPrint.Location = New System.Drawing.Point(637, 127)
        Me.btnVPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVPrint.Name = "btnVPrint"
        Me.btnVPrint.Size = New System.Drawing.Size(108, 31)
        Me.btnVPrint.TabIndex = 3
        Me.btnVPrint.Text = "Print"
        Me.btnVPrint.Values.ExtraText = ""
        Me.btnVPrint.Values.Image = Nothing
        Me.btnVPrint.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnVPrint.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnVPrint.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnVPrint.Values.Text = "Print"
        '
        'btnEditVisit
        '
        Me.btnEditVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditVisit.Location = New System.Drawing.Point(637, 49)
        Me.btnEditVisit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditVisit.Name = "btnEditVisit"
        Me.btnEditVisit.Size = New System.Drawing.Size(108, 31)
        Me.btnEditVisit.TabIndex = 2
        Me.btnEditVisit.Text = "Edit Selected"
        Me.btnEditVisit.Values.ExtraText = ""
        Me.btnEditVisit.Values.Image = Nothing
        Me.btnEditVisit.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnEditVisit.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnEditVisit.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnEditVisit.Values.Text = "Edit Selected"
        '
        'btnNewVisit
        '
        Me.btnNewVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewVisit.Location = New System.Drawing.Point(637, 11)
        Me.btnNewVisit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewVisit.Name = "btnNewVisit"
        Me.btnNewVisit.Size = New System.Drawing.Size(108, 31)
        Me.btnNewVisit.TabIndex = 1
        Me.btnNewVisit.Text = "New Visit"
        Me.btnNewVisit.Values.ExtraText = ""
        Me.btnNewVisit.Values.Image = Nothing
        Me.btnNewVisit.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNewVisit.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNewVisit.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNewVisit.Values.Text = "New Visit"
        '
        'pgQuestion
        '
        Me.pgQuestion.AutoScroll = True
        Me.pgQuestion.Controls.Add(Me.KryptonHeaderGroup14)
        Me.pgQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.pgQuestion.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgQuestion.Name = "pgQuestion"
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.Size = New System.Drawing.Size(754, 285)
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgQuestion.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgQuestion.Text = "Questionnaire"
        Me.pgQuestion.ToolTipTitle = "Page ToolTip"
        Me.pgQuestion.UniqueName = "96ECF6999AB0449B96ECF6999AB0449B"
        '
        'KryptonHeaderGroup14
        '
        Me.KryptonHeaderGroup14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup14.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup14.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup14.Location = New System.Drawing.Point(13, 11)
        Me.KryptonHeaderGroup14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup14.Name = "KryptonHeaderGroup14"
        '
        'KryptonHeaderGroup14.Panel
        '
        Me.KryptonHeaderGroup14.Panel.AutoScroll = True
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest5)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.dtQuestDate)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label72)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label64)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest7)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest9)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest8)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest6)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest4)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest3)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest2)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.txtQuest1)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label65)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label63)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label62)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label61)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label60)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label59)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label58)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label57)
        Me.KryptonHeaderGroup14.Panel.Controls.Add(Me.Label56)
        Me.KryptonHeaderGroup14.Size = New System.Drawing.Size(728, 264)
        Me.KryptonHeaderGroup14.TabIndex = 0
        Me.KryptonHeaderGroup14.Text = "Patient Questions"
        Me.KryptonHeaderGroup14.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup14.ValuesPrimary.Heading = "Patient Questions"
        Me.KryptonHeaderGroup14.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup14.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup14.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup14.ValuesSecondary.Heading = "Patient Questions"
        Me.KryptonHeaderGroup14.ValuesSecondary.Image = Nothing
        '
        'txtQuest5
        '
        Me.txtQuest5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtQuest5.FlayStyle = False
        Me.txtQuest5.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest5.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQuest5.FormattingEnabled = True
        Me.txtQuest5.Items.AddRange(New Object() {"None", "Very Light", "Light", "Moderate", "Vigorous", "Elite Athlete"})
        Me.txtQuest5.Location = New System.Drawing.Point(19, 319)
        Me.txtQuest5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest5.Name = "txtQuest5"
        Me.txtQuest5.Size = New System.Drawing.Size(160, 24)
        Me.txtQuest5.TabIndex = 5
        '
        'dtQuestDate
        '
        Me.dtQuestDate.Location = New System.Drawing.Point(19, 26)
        Me.dtQuestDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtQuestDate.Name = "dtQuestDate"
        Me.dtQuestDate.Size = New System.Drawing.Size(265, 22)
        Me.dtQuestDate.TabIndex = 21
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Location = New System.Drawing.Point(15, 6)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(125, 16)
        Me.Label72.TabIndex = 20
        Me.Label72.Text = "Date  of Completion"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Location = New System.Drawing.Point(15, 606)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(23, 16)
        Me.Label64.TabIndex = 19
        Me.Label64.Text = "     "
        '
        'txtQuest7
        '
        Me.txtQuest7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtQuest7.FormattingEnabled = True
        Me.txtQuest7.Items.AddRange(New Object() {"Yes", "No"})
        Me.txtQuest7.Location = New System.Drawing.Point(19, 437)
        Me.txtQuest7.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest7.Name = "txtQuest7"
        Me.txtQuest7.Size = New System.Drawing.Size(160, 24)
        Me.txtQuest7.TabIndex = 7
        '
        'txtQuest9
        '
        Me.txtQuest9.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest9.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest9.Location = New System.Drawing.Point(19, 555)
        Me.txtQuest9.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest9.MaxLength = 1000
        Me.txtQuest9.Multiline = True
        Me.txtQuest9.Name = "txtQuest9"
        Me.txtQuest9.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest9.TabIndex = 9
        Me.txtQuest9.TabOnEnter = False
        Me.txtQuest9.TextType = RFIControls.enumTextType.Normal
        '
        'txtQuest8
        '
        Me.txtQuest8.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest8.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest8.Location = New System.Drawing.Point(19, 496)
        Me.txtQuest8.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest8.MaxLength = 1000
        Me.txtQuest8.Multiline = True
        Me.txtQuest8.Name = "txtQuest8"
        Me.txtQuest8.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest8.TabIndex = 8
        Me.txtQuest8.TabOnEnter = False
        Me.txtQuest8.TextType = RFIControls.enumTextType.Normal
        '
        'txtQuest6
        '
        Me.txtQuest6.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest6.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest6.Location = New System.Drawing.Point(19, 378)
        Me.txtQuest6.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest6.MaxLength = 1000
        Me.txtQuest6.Multiline = True
        Me.txtQuest6.Name = "txtQuest6"
        Me.txtQuest6.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest6.TabIndex = 6
        Me.txtQuest6.TabOnEnter = False
        Me.txtQuest6.TextType = RFIControls.enumTextType.Normal
        '
        'txtQuest4
        '
        Me.txtQuest4.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest4.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest4.Location = New System.Drawing.Point(19, 260)
        Me.txtQuest4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest4.MaxLength = 1000
        Me.txtQuest4.Multiline = True
        Me.txtQuest4.Name = "txtQuest4"
        Me.txtQuest4.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest4.TabIndex = 4
        Me.txtQuest4.TabOnEnter = False
        Me.txtQuest4.TextType = RFIControls.enumTextType.Normal
        '
        'txtQuest3
        '
        Me.txtQuest3.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest3.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest3.Location = New System.Drawing.Point(19, 201)
        Me.txtQuest3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest3.MaxLength = 1000
        Me.txtQuest3.Multiline = True
        Me.txtQuest3.Name = "txtQuest3"
        Me.txtQuest3.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest3.TabIndex = 3
        Me.txtQuest3.TabOnEnter = False
        Me.txtQuest3.TextType = RFIControls.enumTextType.Normal
        '
        'txtQuest2
        '
        Me.txtQuest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtQuest2.FormattingEnabled = True
        Me.txtQuest2.Items.AddRange(New Object() {"Yes", "No"})
        Me.txtQuest2.Location = New System.Drawing.Point(19, 142)
        Me.txtQuest2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest2.Name = "txtQuest2"
        Me.txtQuest2.Size = New System.Drawing.Size(160, 24)
        Me.txtQuest2.TabIndex = 2
        '
        'txtQuest1
        '
        Me.txtQuest1.FocusBGColor = System.Drawing.Color.Empty
        Me.txtQuest1.FocusFontColor = System.Drawing.Color.Empty
        Me.txtQuest1.Location = New System.Drawing.Point(19, 82)
        Me.txtQuest1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuest1.MaxLength = 1000
        Me.txtQuest1.Multiline = True
        Me.txtQuest1.Name = "txtQuest1"
        Me.txtQuest1.Size = New System.Drawing.Size(401, 25)
        Me.txtQuest1.TabIndex = 1
        Me.txtQuest1.TabOnEnter = False
        Me.txtQuest1.TextType = RFIControls.enumTextType.Normal
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Location = New System.Drawing.Point(15, 476)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(333, 16)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "What foods do you like that cause digestive problems?"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Location = New System.Drawing.Point(15, 535)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(528, 16)
        Me.Label63.TabIndex = 7
        Me.Label63.Text = "Pretend you have no health concerns and can have any meal or food. What would it " & _
            "be? "
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Location = New System.Drawing.Point(15, 417)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(300, 16)
        Me.Label62.TabIndex = 6
        Me.Label62.Text = "Do you typically eat breakfast, lunch, and dinner? "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Location = New System.Drawing.Point(15, 122)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(142, 16)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "Are you a vegetarian? "
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Location = New System.Drawing.Point(15, 358)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(248, 16)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "Do you consider your lifestyle stressful?  "
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Location = New System.Drawing.Point(15, 299)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(258, 16)
        Me.Label59.TabIndex = 3
        Me.Label59.Text = "Do you have a regular exercise program? "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Location = New System.Drawing.Point(15, 240)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(335, 16)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "How many bowel movements do you have in one day? "
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Location = New System.Drawing.Point(15, 181)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(348, 16)
        Me.Label57.TabIndex = 1
        Me.Label57.Text = "Please list any supplements/ medications you are taking. "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Location = New System.Drawing.Point(15, 63)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(277, 16)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "What are your major nutritional/ health goals? "
        '
        'pgCondition
        '
        Me.pgCondition.AutoScroll = True
        Me.pgCondition.Controls.Add(Me.dgConditions)
        Me.pgCondition.Controls.Add(Me.KryptonHeaderGroup2)
        Me.pgCondition.Margin = New System.Windows.Forms.Padding(4)
        Me.pgCondition.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgCondition.Name = "pgCondition"
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.Size = New System.Drawing.Size(754, 285)
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCondition.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCondition.Text = "Conditions"
        Me.pgCondition.ToolTipTitle = "Page ToolTip"
        Me.pgCondition.UniqueName = "252CF83EE0564DE1252CF83EE0564DE1"
        '
        'dgConditions
        '
        Me.dgConditions.AllowUserToAddRows = False
        Me.dgConditions.AllowUserToDeleteRows = False
        Me.dgConditions.AllowUserToResizeColumns = False
        Me.dgConditions.AllowUserToResizeRows = False
        Me.dgConditions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgConditions.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.dgConditions.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.dgConditions.Location = New System.Drawing.Point(7, 6)
        Me.dgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.dgConditions.MultiSelect = False
        Me.dgConditions.Name = "dgConditions"
        Me.dgConditions.ReadOnly = True
        Me.dgConditions.RowHeadersVisible = False
        Me.dgConditions.RowTemplate.ReadOnly = True
        Me.dgConditions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConditions.Size = New System.Drawing.Size(429, 275)
        Me.dgConditions.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.dgConditions.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgConditions.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgConditions.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Present"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Past"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Condition"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(447, 6)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtConditonInfo)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(295, 275)
        Me.KryptonHeaderGroup2.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Additional Info:"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'txtConditonInfo
        '
        Me.txtConditonInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtConditonInfo.FocusBGColor = System.Drawing.Color.Empty
        Me.txtConditonInfo.FocusFontColor = System.Drawing.Color.Empty
        Me.txtConditonInfo.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtConditonInfo.Location = New System.Drawing.Point(11, 7)
        Me.txtConditonInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConditonInfo.MaxLength = 1000
        Me.txtConditonInfo.Multiline = True
        Me.txtConditonInfo.Name = "txtConditonInfo"
        Me.txtConditonInfo.Size = New System.Drawing.Size(269, 236)
        Me.txtConditonInfo.TabIndex = 1
        Me.txtConditonInfo.TabOnEnter = False
        Me.txtConditonInfo.TextType = RFIControls.enumTextType.Normal
        '
        'pgScanData
        '
        Me.pgScanData.AutoScroll = True
        Me.pgScanData.Controls.Add(Me.KryptonHeaderGroup5)
        Me.pgScanData.Controls.Add(Me.KryptonHeaderGroup4)
        Me.pgScanData.Controls.Add(Me.KryptonHeaderGroup3)
        Me.pgScanData.Controls.Add(Me.Label50)
        Me.pgScanData.Margin = New System.Windows.Forms.Padding(4)
        Me.pgScanData.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgScanData.Name = "pgScanData"
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.Size = New System.Drawing.Size(754, 285)
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgScanData.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgScanData.Text = "Measurements"
        Me.pgScanData.ToolTipTitle = "Page ToolTip"
        Me.pgScanData.UniqueName = "3C978FFDBD9B4CD73C978FFDBD9B4CD7"
        '
        'KryptonHeaderGroup5
        '
        Me.KryptonHeaderGroup5.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup5.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup5.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup5.Location = New System.Drawing.Point(466, 11)
        Me.KryptonHeaderGroup5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup5.Name = "KryptonHeaderGroup5"
        '
        'KryptonHeaderGroup5.Panel
        '
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.cbExercise)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.cbBodyType)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label66)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtRMR)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label67)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtVO2)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label13)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtbp2)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label12)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label10)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.Label11)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtbp1)
        Me.KryptonHeaderGroup5.Size = New System.Drawing.Size(272, 252)
        Me.KryptonHeaderGroup5.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup5.TabIndex = 3
        Me.KryptonHeaderGroup5.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup5.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup5.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup5.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup5.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup5.ValuesSecondary.Heading = "Other"
        Me.KryptonHeaderGroup5.ValuesSecondary.Image = Nothing
        '
        'cbExercise
        '
        Me.cbExercise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExercise.FlayStyle = False
        Me.cbExercise.FocusBGColor = System.Drawing.Color.Empty
        Me.cbExercise.FocusFontColor = System.Drawing.Color.Empty
        Me.cbExercise.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbExercise.FormattingEnabled = True
        Me.cbExercise.Items.AddRange(New Object() {"None", "Very Light", "Light", "Moderate", "Vigorous", "Elite Athlete"})
        Me.cbExercise.Location = New System.Drawing.Point(136, 14)
        Me.cbExercise.Margin = New System.Windows.Forms.Padding(4)
        Me.cbExercise.Name = "cbExercise"
        Me.cbExercise.Size = New System.Drawing.Size(116, 24)
        Me.cbExercise.TabIndex = 10
        '
        'cbBodyType
        '
        Me.cbBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodyType.FlayStyle = False
        Me.cbBodyType.FocusBGColor = System.Drawing.Color.LightYellow
        Me.cbBodyType.FocusFontColor = System.Drawing.Color.Blue
        Me.cbBodyType.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbBodyType.FormattingEnabled = True
        Me.cbBodyType.Items.AddRange(New Object() {"BioDézyne 1", "BioDézyne 2 ", "BioDézyne 3 ", "BioDézyne 4 "})
        Me.cbBodyType.Location = New System.Drawing.Point(136, 47)
        Me.cbBodyType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBodyType.Name = "cbBodyType"
        Me.cbBodyType.Size = New System.Drawing.Size(116, 24)
        Me.cbBodyType.TabIndex = 11
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Location = New System.Drawing.Point(9, 150)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(120, 21)
        Me.Label66.TabIndex = 35
        Me.Label66.Text = "VO2 (min)"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRMR
        '
        Me.txtRMR.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtRMR.FocusFontColor = System.Drawing.Color.Blue
        Me.txtRMR.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtRMR.Location = New System.Drawing.Point(136, 114)
        Me.txtRMR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRMR.Name = "txtRMR"
        Me.txtRMR.Size = New System.Drawing.Size(116, 22)
        Me.txtRMR.TabIndex = 14
        Me.txtRMR.TabOnEnter = False
        Me.txtRMR.TextType = RFIControls.enumTextType.Currency
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Location = New System.Drawing.Point(9, 117)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(120, 21)
        Me.Label67.TabIndex = 34
        Me.Label67.Text = "RMR"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVO2
        '
        Me.txtVO2.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtVO2.FocusFontColor = System.Drawing.Color.Blue
        Me.txtVO2.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtVO2.Location = New System.Drawing.Point(136, 148)
        Me.txtVO2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVO2.Name = "txtVO2"
        Me.txtVO2.Size = New System.Drawing.Size(116, 22)
        Me.txtVO2.TabIndex = 15
        Me.txtVO2.TabOnEnter = False
        Me.txtVO2.TextType = RFIControls.enumTextType.Currency
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(187, 85)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "/"
        '
        'txtbp2
        '
        Me.txtbp2.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtbp2.FocusFontColor = System.Drawing.Color.Blue
        Me.txtbp2.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtbp2.Location = New System.Drawing.Point(207, 80)
        Me.txtbp2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbp2.Name = "txtbp2"
        Me.txtbp2.Size = New System.Drawing.Size(45, 22)
        Me.txtbp2.TabIndex = 13
        Me.txtbp2.TabOnEnter = False
        Me.txtbp2.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(9, 82)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 21)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Blood Pressure"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(9, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 21)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Exercise Level"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(9, 49)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 21)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Body Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbp1
        '
        Me.txtbp1.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtbp1.FocusFontColor = System.Drawing.Color.Blue
        Me.txtbp1.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtbp1.Location = New System.Drawing.Point(136, 80)
        Me.txtbp1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbp1.Name = "txtbp1"
        Me.txtbp1.Size = New System.Drawing.Size(45, 22)
        Me.txtbp1.TabIndex = 12
        Me.txtbp1.TabOnEnter = False
        Me.txtbp1.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup4.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup4.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(242, 11)
        Me.KryptonHeaderGroup4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.Label7)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtClavical)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtHip)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.Label6)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.Label8)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtWaist)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.Label9)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtPelvic)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(208, 252)
        Me.KryptonHeaderGroup4.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup4.TabIndex = 2
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup4.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = "Measurements"
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(15, 49)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Clavical Width"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtClavical
        '
        Me.txtClavical.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtClavical.FocusFontColor = System.Drawing.Color.Blue
        Me.txtClavical.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtClavical.Location = New System.Drawing.Point(127, 47)
        Me.txtClavical.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClavical.Name = "txtClavical"
        Me.txtClavical.Size = New System.Drawing.Size(63, 22)
        Me.txtClavical.TabIndex = 7
        Me.txtClavical.TabOnEnter = False
        Me.txtClavical.TextType = RFIControls.enumTextType.Currency
        '
        'txtHip
        '
        Me.txtHip.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtHip.FocusFontColor = System.Drawing.Color.Blue
        Me.txtHip.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtHip.Location = New System.Drawing.Point(127, 113)
        Me.txtHip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(63, 22)
        Me.txtHip.TabIndex = 9
        Me.txtHip.TabOnEnter = False
        Me.txtHip.TextType = RFIControls.enumTextType.Currency
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pelvic Width"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 73)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 35)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Waist Circumference"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWaist
        '
        Me.txtWaist.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtWaist.FocusFontColor = System.Drawing.Color.Blue
        Me.txtWaist.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtWaist.Location = New System.Drawing.Point(127, 80)
        Me.txtWaist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(63, 22)
        Me.txtWaist.TabIndex = 8
        Me.txtWaist.TabOnEnter = False
        Me.txtWaist.TextType = RFIControls.enumTextType.Currency
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(15, 108)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 32)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Hip Circumference"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPelvic
        '
        Me.txtPelvic.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtPelvic.FocusFontColor = System.Drawing.Color.Blue
        Me.txtPelvic.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtPelvic.Location = New System.Drawing.Point(127, 14)
        Me.txtPelvic.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPelvic.Name = "txtPelvic"
        Me.txtPelvic.Size = New System.Drawing.Size(63, 22)
        Me.txtPelvic.TabIndex = 6
        Me.txtPelvic.TabOnEnter = False
        Me.txtPelvic.TextType = RFIControls.enumTextType.Currency
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup3.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(9, 11)
        Me.KryptonHeaderGroup3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label5)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtIBW)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtWeight)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtDesirWeight)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtBMI)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtHeight)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label4)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(217, 252)
        Me.KryptonHeaderGroup3.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup3.TabIndex = 1
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Height/Weight"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "IBW"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Desired Weight"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIBW
        '
        Me.txtIBW.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtIBW.FocusFontColor = System.Drawing.Color.Blue
        Me.txtIBW.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtIBW.Location = New System.Drawing.Point(133, 148)
        Me.txtIBW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIBW.Name = "txtIBW"
        Me.txtIBW.Size = New System.Drawing.Size(63, 22)
        Me.txtIBW.TabIndex = 5
        Me.txtIBW.TabOnEnter = False
        Me.txtIBW.TextType = RFIControls.enumTextType.Currency
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Weight"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWeight
        '
        Me.txtWeight.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtWeight.FocusFontColor = System.Drawing.Color.Blue
        Me.txtWeight.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtWeight.Location = New System.Drawing.Point(133, 47)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(63, 22)
        Me.txtWeight.TabIndex = 2
        Me.txtWeight.TabOnEnter = False
        Me.txtWeight.TextType = RFIControls.enumTextType.Currency
        '
        'txtDesirWeight
        '
        Me.txtDesirWeight.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtDesirWeight.FocusFontColor = System.Drawing.Color.Blue
        Me.txtDesirWeight.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtDesirWeight.Location = New System.Drawing.Point(133, 80)
        Me.txtDesirWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesirWeight.Name = "txtDesirWeight"
        Me.txtDesirWeight.Size = New System.Drawing.Size(63, 22)
        Me.txtDesirWeight.TabIndex = 3
        Me.txtDesirWeight.TabOnEnter = False
        Me.txtDesirWeight.TextType = RFIControls.enumTextType.Currency
        '
        'txtBMI
        '
        Me.txtBMI.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBMI.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBMI.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBMI.Location = New System.Drawing.Point(133, 113)
        Me.txtBMI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(63, 22)
        Me.txtBMI.TabIndex = 4
        Me.txtBMI.TabOnEnter = False
        Me.txtBMI.TextType = RFIControls.enumTextType.Currency
        '
        'txtHeight
        '
        Me.txtHeight.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtHeight.FocusFontColor = System.Drawing.Color.Blue
        Me.txtHeight.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtHeight.Location = New System.Drawing.Point(133, 14)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(63, 22)
        Me.txtHeight.TabIndex = 1
        Me.txtHeight.TabOnEnter = False
        Me.txtHeight.TextType = RFIControls.enumTextType.Currency
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "BMI"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Height (inches)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(4, 7)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 16)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = " "
        '
        'pgCholesterol
        '
        Me.pgCholesterol.AutoScroll = True
        Me.pgCholesterol.Controls.Add(Me.KryptonHeaderGroup13)
        Me.pgCholesterol.Controls.Add(Me.KryptonHeaderGroup9)
        Me.pgCholesterol.Controls.Add(Me.KryptonHeaderGroup8)
        Me.pgCholesterol.Controls.Add(Me.KryptonHeaderGroup7)
        Me.pgCholesterol.Controls.Add(Me.KryptonHeaderGroup6)
        Me.pgCholesterol.Controls.Add(Me.Label49)
        Me.pgCholesterol.Margin = New System.Windows.Forms.Padding(4)
        Me.pgCholesterol.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgCholesterol.Name = "pgCholesterol"
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.Size = New System.Drawing.Size(754, 285)
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgCholesterol.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgCholesterol.Text = "Cholesterol"
        Me.pgCholesterol.ToolTipTitle = "Page ToolTip"
        Me.pgCholesterol.UniqueName = "737AC7E92F6040E2737AC7E92F6040E2"
        '
        'KryptonHeaderGroup13
        '
        Me.KryptonHeaderGroup13.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup13.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup13.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup13.Location = New System.Drawing.Point(444, 9)
        Me.KryptonHeaderGroup13.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup13.Name = "KryptonHeaderGroup13"
        '
        'KryptonHeaderGroup13.Panel
        '
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.txtDensity)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.Label43)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.txtFluid)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.Label42)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.txtFat)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.txtMuscle)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.Label44)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.Label45)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.Label46)
        Me.KryptonHeaderGroup13.Panel.Controls.Add(Me.txtBone)
        Me.KryptonHeaderGroup13.Size = New System.Drawing.Size(293, 133)
        Me.KryptonHeaderGroup13.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup13.TabIndex = 2
        Me.KryptonHeaderGroup13.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup13.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup13.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup13.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup13.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup13.ValuesSecondary.Heading = "Composition (Dexa)"
        Me.KryptonHeaderGroup13.ValuesSecondary.Image = Nothing
        '
        'txtDensity
        '
        Me.txtDensity.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtDensity.FocusFontColor = System.Drawing.Color.Blue
        Me.txtDensity.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtDensity.Location = New System.Drawing.Point(218, 58)
        Me.txtDensity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDensity.Name = "txtDensity"
        Me.txtDensity.Size = New System.Drawing.Size(56, 22)
        Me.txtDensity.TabIndex = 11
        Me.txtDensity.TabOnEnter = False
        Me.txtDensity.TextType = RFIControls.enumTextType.Currency
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(155, 59)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(60, 21)
        Me.Label43.TabIndex = 18
        Me.Label43.Text = "T-Score"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFluid
        '
        Me.txtFluid.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFluid.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFluid.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFluid.Location = New System.Drawing.Point(222, 88)
        Me.txtFluid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFluid.Name = "txtFluid"
        Me.txtFluid.Size = New System.Drawing.Size(56, 22)
        Me.txtFluid.TabIndex = 10
        Me.txtFluid.TabOnEnter = False
        Me.txtFluid.TextType = RFIControls.enumTextType.NumbersOnly
        Me.txtFluid.Visible = False
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(163, 89)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(55, 21)
        Me.Label42.TabIndex = 16
        Me.Label42.Text = "Fluid "
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label42.Visible = False
        '
        'txtFat
        '
        Me.txtFat.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFat.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFat.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFat.Location = New System.Drawing.Point(86, 16)
        Me.txtFat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(56, 22)
        Me.txtFat.TabIndex = 7
        Me.txtFat.TabOnEnter = False
        Me.txtFat.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'txtMuscle
        '
        Me.txtMuscle.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtMuscle.FocusFontColor = System.Drawing.Color.Blue
        Me.txtMuscle.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtMuscle.Location = New System.Drawing.Point(218, 16)
        Me.txtMuscle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMuscle.Name = "txtMuscle"
        Me.txtMuscle.Size = New System.Drawing.Size(56, 22)
        Me.txtMuscle.TabIndex = 9
        Me.txtMuscle.TabOnEnter = False
        Me.txtMuscle.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Location = New System.Drawing.Point(17, 17)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(55, 21)
        Me.Label44.TabIndex = 10
        Me.Label44.Text = "Fat "
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Location = New System.Drawing.Point(155, 17)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(60, 21)
        Me.Label45.TabIndex = 14
        Me.Label45.Text = "Muscle "
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Location = New System.Drawing.Point(17, 59)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(57, 21)
        Me.Label46.TabIndex = 11
        Me.Label46.Text = "Bone "
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBone
        '
        Me.txtBone.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBone.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBone.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBone.Location = New System.Drawing.Point(86, 58)
        Me.txtBone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBone.Name = "txtBone"
        Me.txtBone.Size = New System.Drawing.Size(56, 22)
        Me.txtBone.TabIndex = 8
        Me.txtBone.TabOnEnter = False
        Me.txtBone.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'KryptonHeaderGroup9
        '
        Me.KryptonHeaderGroup9.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup9.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup9.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup9.Location = New System.Drawing.Point(374, 146)
        Me.KryptonHeaderGroup9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup9.Name = "KryptonHeaderGroup9"
        '
        'KryptonHeaderGroup9.Panel
        '
        Me.KryptonHeaderGroup9.Panel.Controls.Add(Me.txtRiskAss)
        Me.KryptonHeaderGroup9.Size = New System.Drawing.Size(363, 122)
        Me.KryptonHeaderGroup9.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup9.TabIndex = 5
        Me.KryptonHeaderGroup9.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup9.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup9.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup9.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup9.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup9.ValuesSecondary.Heading = "Additional Info:"
        Me.KryptonHeaderGroup9.ValuesSecondary.Image = Nothing
        '
        'txtRiskAss
        '
        Me.txtRiskAss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRiskAss.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtRiskAss.FocusFontColor = System.Drawing.Color.Blue
        Me.txtRiskAss.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtRiskAss.Location = New System.Drawing.Point(11, 7)
        Me.txtRiskAss.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRiskAss.MaxLength = 1000
        Me.txtRiskAss.Multiline = True
        Me.txtRiskAss.Name = "txtRiskAss"
        Me.txtRiskAss.Size = New System.Drawing.Size(337, 83)
        Me.txtRiskAss.TabIndex = 17
        Me.txtRiskAss.TabOnEnter = False
        Me.txtRiskAss.TextType = RFIControls.enumTextType.Normal
        '
        'KryptonHeaderGroup8
        '
        Me.KryptonHeaderGroup8.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup8.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup8.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(9, 146)
        Me.KryptonHeaderGroup8.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
        '
        'KryptonHeaderGroup8.Panel
        '
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.cbGlucoseTest)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.Label77)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.txtTime)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.Label22)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.txtGlucosResult)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.Label23)
        Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(203, 122)
        Me.KryptonHeaderGroup8.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup8.TabIndex = 3
        Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup8.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Heading = "Glucose"
        Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
        '
        'cbGlucoseTest
        '
        Me.cbGlucoseTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGlucoseTest.FlayStyle = False
        Me.cbGlucoseTest.FocusBGColor = System.Drawing.Color.Empty
        Me.cbGlucoseTest.FocusFontColor = System.Drawing.Color.Empty
        Me.cbGlucoseTest.ForeColor = System.Drawing.Color.BlueViolet
        Me.cbGlucoseTest.FormattingEnabled = True
        Me.cbGlucoseTest.Items.AddRange(New Object() {"Fasting", "Post-Prandial", "Unknown"})
        Me.cbGlucoseTest.Location = New System.Drawing.Point(63, 7)
        Me.cbGlucoseTest.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGlucoseTest.Name = "cbGlucoseTest"
        Me.cbGlucoseTest.Size = New System.Drawing.Size(129, 24)
        Me.cbGlucoseTest.TabIndex = 12
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Location = New System.Drawing.Point(7, 41)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(53, 21)
        Me.Label77.TabIndex = 24
        Me.Label77.Text = "Time"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTime
        '
        Me.txtTime.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTime.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTime.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTime.Location = New System.Drawing.Point(63, 38)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(129, 22)
        Me.txtTime.TabIndex = 13
        Me.txtTime.TabOnEnter = False
        Me.txtTime.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(7, 71)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 21)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Result"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGlucosResult
        '
        Me.txtGlucosResult.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtGlucosResult.FocusFontColor = System.Drawing.Color.Blue
        Me.txtGlucosResult.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtGlucosResult.Location = New System.Drawing.Point(63, 69)
        Me.txtGlucosResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGlucosResult.Name = "txtGlucosResult"
        Me.txtGlucosResult.Size = New System.Drawing.Size(129, 22)
        Me.txtGlucosResult.TabIndex = 14
        Me.txtGlucosResult.TabOnEnter = False
        Me.txtGlucosResult.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(7, 10)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 21)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Type"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KryptonHeaderGroup7
        '
        Me.KryptonHeaderGroup7.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup7.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup7.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup7.Location = New System.Drawing.Point(223, 146)
        Me.KryptonHeaderGroup7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup7.Name = "KryptonHeaderGroup7"
        '
        'KryptonHeaderGroup7.Panel
        '
        Me.KryptonHeaderGroup7.Panel.Controls.Add(Me.Label19)
        Me.KryptonHeaderGroup7.Panel.Controls.Add(Me.txtALT)
        Me.KryptonHeaderGroup7.Panel.Controls.Add(Me.Label21)
        Me.KryptonHeaderGroup7.Panel.Controls.Add(Me.txtAST)
        Me.KryptonHeaderGroup7.Size = New System.Drawing.Size(139, 122)
        Me.KryptonHeaderGroup7.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup7.TabIndex = 4
        Me.KryptonHeaderGroup7.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup7.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup7.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup7.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup7.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup7.ValuesSecondary.Heading = "Liver"
        Me.KryptonHeaderGroup7.ValuesSecondary.Image = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(13, 43)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 21)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "AST"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtALT
        '
        Me.txtALT.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtALT.FocusFontColor = System.Drawing.Color.Blue
        Me.txtALT.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtALT.Location = New System.Drawing.Point(63, 7)
        Me.txtALT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtALT.Name = "txtALT"
        Me.txtALT.Size = New System.Drawing.Size(56, 22)
        Me.txtALT.TabIndex = 15
        Me.txtALT.TabOnEnter = False
        Me.txtALT.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(13, 10)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 21)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "ALT"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAST
        '
        Me.txtAST.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtAST.FocusFontColor = System.Drawing.Color.Blue
        Me.txtAST.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtAST.Location = New System.Drawing.Point(63, 41)
        Me.txtAST.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAST.Name = "txtAST"
        Me.txtAST.Size = New System.Drawing.Size(56, 22)
        Me.txtAST.TabIndex = 16
        Me.txtAST.TabOnEnter = False
        Me.txtAST.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'KryptonHeaderGroup6
        '
        Me.KryptonHeaderGroup6.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup6.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup6.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup6.Location = New System.Drawing.Point(9, 9)
        Me.KryptonHeaderGroup6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup6.Name = "KryptonHeaderGroup6"
        '
        'KryptonHeaderGroup6.Panel
        '
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label73)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.dateCholTest)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label20)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtTotalChol)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtTrg)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label14)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label18)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtTCHDL)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label17)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label16)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtNonHDL)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtLDL)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.txtHDL)
        Me.KryptonHeaderGroup6.Panel.Controls.Add(Me.Label15)
        Me.KryptonHeaderGroup6.Size = New System.Drawing.Size(427, 133)
        Me.KryptonHeaderGroup6.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup6.TabIndex = 1
        Me.KryptonHeaderGroup6.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup6.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup6.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup6.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup6.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup6.ValuesSecondary.Heading = "Cholestech"
        Me.KryptonHeaderGroup6.ValuesSecondary.Image = Nothing
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label73.Location = New System.Drawing.Point(16, 7)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(43, 21)
        Me.Label73.TabIndex = 23
        Me.Label73.Text = "Date"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateCholTest
        '
        Me.dateCholTest.Location = New System.Drawing.Point(66, 6)
        Me.dateCholTest.Margin = New System.Windows.Forms.Padding(4)
        Me.dateCholTest.Name = "dateCholTest"
        Me.dateCholTest.Size = New System.Drawing.Size(343, 22)
        Me.dateCholTest.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(137, 43)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 21)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "TRG"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalChol
        '
        Me.txtTotalChol.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTotalChol.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTotalChol.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTotalChol.Location = New System.Drawing.Point(66, 39)
        Me.txtTotalChol.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalChol.Name = "txtTotalChol"
        Me.txtTotalChol.Size = New System.Drawing.Size(56, 22)
        Me.txtTotalChol.TabIndex = 1
        Me.txtTotalChol.TabOnEnter = False
        Me.txtTotalChol.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'txtTrg
        '
        Me.txtTrg.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTrg.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTrg.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTrg.Location = New System.Drawing.Point(190, 39)
        Me.txtTrg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrg.Name = "txtTrg"
        Me.txtTrg.Size = New System.Drawing.Size(56, 22)
        Me.txtTrg.TabIndex = 3
        Me.txtTrg.TabOnEnter = False
        Me.txtTrg.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(270, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Non-HDL"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(16, 42)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 21)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "TC"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTCHDL
        '
        Me.txtTCHDL.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTCHDL.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTCHDL.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTCHDL.Location = New System.Drawing.Point(352, 71)
        Me.txtTCHDL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTCHDL.Name = "txtTCHDL"
        Me.txtTCHDL.Size = New System.Drawing.Size(56, 22)
        Me.txtTCHDL.TabIndex = 6
        Me.txtTCHDL.TabOnEnter = False
        Me.txtTCHDL.TextType = RFIControls.enumTextType.Currency
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(137, 75)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 21)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "LDL"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(270, 74)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 21)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "TC/HDL"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNonHDL
        '
        Me.txtNonHDL.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtNonHDL.FocusFontColor = System.Drawing.Color.Blue
        Me.txtNonHDL.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtNonHDL.Location = New System.Drawing.Point(352, 38)
        Me.txtNonHDL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNonHDL.Name = "txtNonHDL"
        Me.txtNonHDL.Size = New System.Drawing.Size(56, 22)
        Me.txtNonHDL.TabIndex = 5
        Me.txtNonHDL.TabOnEnter = False
        Me.txtNonHDL.TextType = RFIControls.enumTextType.Currency
        '
        'txtLDL
        '
        Me.txtLDL.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtLDL.FocusFontColor = System.Drawing.Color.Blue
        Me.txtLDL.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtLDL.Location = New System.Drawing.Point(190, 70)
        Me.txtLDL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLDL.Name = "txtLDL"
        Me.txtLDL.Size = New System.Drawing.Size(56, 22)
        Me.txtLDL.TabIndex = 4
        Me.txtLDL.TabOnEnter = False
        Me.txtLDL.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'txtHDL
        '
        Me.txtHDL.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtHDL.FocusFontColor = System.Drawing.Color.Blue
        Me.txtHDL.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtHDL.Location = New System.Drawing.Point(66, 74)
        Me.txtHDL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHDL.Name = "txtHDL"
        Me.txtHDL.Size = New System.Drawing.Size(56, 22)
        Me.txtHDL.TabIndex = 2
        Me.txtHDL.TabOnEnter = False
        Me.txtHDL.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(16, 76)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "HDL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Location = New System.Drawing.Point(5, 6)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 16)
        Me.Label49.TabIndex = 6
        Me.Label49.Text = " "
        '
        'pgBCA
        '
        Me.pgBCA.AutoScroll = True
        Me.pgBCA.Controls.Add(Me.KryptonHeaderGroup10)
        Me.pgBCA.Controls.Add(Me.Label51)
        Me.pgBCA.Margin = New System.Windows.Forms.Padding(4)
        Me.pgBCA.MinimumSize = New System.Drawing.Size(67, 62)
        Me.pgBCA.Name = "pgBCA"
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.OverrideFocus.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.Size = New System.Drawing.Size(754, 285)
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StateCommon.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StateDisabled.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StateNormal.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StatePressed.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StateSelected.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.BackColor1 = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.BackColor2 = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.BackColor3 = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.BackColor4 = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.BackColor5 = System.Drawing.Color.Empty
        Me.pgBCA.StateTracking.RibbonTab.TabDraw.TextColor = System.Drawing.Color.Empty
        Me.pgBCA.Text = "BCA"
        Me.pgBCA.ToolTipTitle = "Page ToolTip"
        Me.pgBCA.UniqueName = "7D6206183C4A45E97D6206183C4A45E9"
        '
        'KryptonHeaderGroup10
        '
        Me.KryptonHeaderGroup10.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup10.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup10.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup10.Location = New System.Drawing.Point(11, 9)
        Me.KryptonHeaderGroup10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup10.Name = "KryptonHeaderGroup10"
        '
        'KryptonHeaderGroup10.Panel
        '
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtBMI2)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label52)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label71)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtReact)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label70)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtResist)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label69)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtECWLiters)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label68)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtICWLiters)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtCapa)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtTBWLiters)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label37)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label55)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtFatper)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label54)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtFFMp)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label35)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtPhaseAngle)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label36)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label41)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtTBW)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtECMp)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label34)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label40)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtBCMp)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtECW)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label39)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label33)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtFatp)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtICW)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label38)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label32)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtBMR)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label31)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtFFM)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label30)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtECM)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.Label29)
        Me.KryptonHeaderGroup10.Panel.Controls.Add(Me.txtBCM)
        Me.KryptonHeaderGroup10.Size = New System.Drawing.Size(733, 260)
        Me.KryptonHeaderGroup10.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup10.TabIndex = 1
        Me.KryptonHeaderGroup10.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup10.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup10.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup10.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup10.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup10.ValuesSecondary.Heading = "Body Composition"
        Me.KryptonHeaderGroup10.ValuesSecondary.Image = Nothing
        '
        'txtBMI2
        '
        Me.txtBMI2.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBMI2.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBMI2.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBMI2.Location = New System.Drawing.Point(624, 170)
        Me.txtBMI2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBMI2.Name = "txtBMI2"
        Me.txtBMI2.Size = New System.Drawing.Size(87, 22)
        Me.txtBMI2.TabIndex = 39
        Me.txtBMI2.TabOnEnter = False
        Me.txtBMI2.TextType = RFIControls.enumTextType.Currency
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(503, 170)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 21)
        Me.Label52.TabIndex = 38
        Me.Label52.Text = "BMI"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Location = New System.Drawing.Point(503, 140)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(104, 25)
        Me.Label71.TabIndex = 37
        Me.Label71.Text = "Reactance"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReact
        '
        Me.txtReact.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtReact.FocusFontColor = System.Drawing.Color.Blue
        Me.txtReact.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtReact.Location = New System.Drawing.Point(624, 140)
        Me.txtReact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReact.Name = "txtReact"
        Me.txtReact.Size = New System.Drawing.Size(87, 22)
        Me.txtReact.TabIndex = 18
        Me.txtReact.TabOnEnter = False
        Me.txtReact.TextType = RFIControls.enumTextType.Currency
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Location = New System.Drawing.Point(503, 106)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(104, 25)
        Me.Label70.TabIndex = 35
        Me.Label70.Text = "Resistance"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResist
        '
        Me.txtResist.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtResist.FocusFontColor = System.Drawing.Color.Blue
        Me.txtResist.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtResist.Location = New System.Drawing.Point(624, 106)
        Me.txtResist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResist.Name = "txtResist"
        Me.txtResist.Size = New System.Drawing.Size(87, 22)
        Me.txtResist.TabIndex = 17
        Me.txtResist.TabOnEnter = False
        Me.txtResist.TextType = RFIControls.enumTextType.Currency
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Location = New System.Drawing.Point(503, 74)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(104, 25)
        Me.Label69.TabIndex = 33
        Me.Label69.Text = "ECW (liters)"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtECWLiters
        '
        Me.txtECWLiters.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtECWLiters.FocusFontColor = System.Drawing.Color.Blue
        Me.txtECWLiters.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtECWLiters.Location = New System.Drawing.Point(624, 74)
        Me.txtECWLiters.Margin = New System.Windows.Forms.Padding(4)
        Me.txtECWLiters.Name = "txtECWLiters"
        Me.txtECWLiters.Size = New System.Drawing.Size(87, 22)
        Me.txtECWLiters.TabIndex = 16
        Me.txtECWLiters.TabOnEnter = False
        Me.txtECWLiters.TextType = RFIControls.enumTextType.Currency
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Location = New System.Drawing.Point(503, 10)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(104, 25)
        Me.Label68.TabIndex = 31
        Me.Label68.Text = "ICW (liters)"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtICWLiters
        '
        Me.txtICWLiters.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtICWLiters.FocusFontColor = System.Drawing.Color.Blue
        Me.txtICWLiters.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtICWLiters.Location = New System.Drawing.Point(624, 10)
        Me.txtICWLiters.Margin = New System.Windows.Forms.Padding(4)
        Me.txtICWLiters.Name = "txtICWLiters"
        Me.txtICWLiters.Size = New System.Drawing.Size(87, 22)
        Me.txtICWLiters.TabIndex = 14
        Me.txtICWLiters.TabOnEnter = False
        Me.txtICWLiters.TextType = RFIControls.enumTextType.Currency
        '
        'txtCapa
        '
        Me.txtCapa.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtCapa.FocusFontColor = System.Drawing.Color.Blue
        Me.txtCapa.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtCapa.Location = New System.Drawing.Point(128, 42)
        Me.txtCapa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCapa.Name = "txtCapa"
        Me.txtCapa.Size = New System.Drawing.Size(84, 22)
        Me.txtCapa.TabIndex = 1
        Me.txtCapa.TabOnEnter = False
        Me.txtCapa.TextType = RFIControls.enumTextType.Currency
        '
        'txtTBWLiters
        '
        Me.txtTBWLiters.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTBWLiters.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTBWLiters.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTBWLiters.Location = New System.Drawing.Point(381, 170)
        Me.txtTBWLiters.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTBWLiters.Name = "txtTBWLiters"
        Me.txtTBWLiters.Size = New System.Drawing.Size(87, 22)
        Me.txtTBWLiters.TabIndex = 12
        Me.txtTBWLiters.TabOnEnter = False
        Me.txtTBWLiters.TextType = RFIControls.enumTextType.Currency
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(13, 42)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 25)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Capacitance"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(263, 170)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(104, 25)
        Me.Label55.TabIndex = 29
        Me.Label55.Text = "TBW (liters)"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFatper
        '
        Me.txtFatper.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFatper.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFatper.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFatper.Location = New System.Drawing.Point(128, 106)
        Me.txtFatper.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFatper.Name = "txtFatper"
        Me.txtFatper.Size = New System.Drawing.Size(84, 22)
        Me.txtFatper.TabIndex = 3
        Me.txtFatper.TabOnEnter = False
        Me.txtFatper.TextType = RFIControls.enumTextType.Currency
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(4, 106)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(105, 25)
        Me.Label54.TabIndex = 27
        Me.Label54.Text = "FAT %"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFFMp
        '
        Me.txtFFMp.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFFMp.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFFMp.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFFMp.Location = New System.Drawing.Point(128, 202)
        Me.txtFFMp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFFMp.Name = "txtFFMp"
        Me.txtFFMp.Size = New System.Drawing.Size(84, 22)
        Me.txtFFMp.TabIndex = 6
        Me.txtFFMp.TabOnEnter = False
        Me.txtFFMp.TextType = RFIControls.enumTextType.Currency
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Location = New System.Drawing.Point(263, 138)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 25)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = "TBW %"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhaseAngle
        '
        Me.txtPhaseAngle.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtPhaseAngle.FocusFontColor = System.Drawing.Color.Blue
        Me.txtPhaseAngle.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtPhaseAngle.Location = New System.Drawing.Point(128, 10)
        Me.txtPhaseAngle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhaseAngle.Name = "txtPhaseAngle"
        Me.txtPhaseAngle.Size = New System.Drawing.Size(84, 22)
        Me.txtPhaseAngle.TabIndex = 0
        Me.txtPhaseAngle.TabOnEnter = False
        Me.txtPhaseAngle.TextType = RFIControls.enumTextType.Currency
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(13, 10)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 25)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "Phase Angle"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(4, 202)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(105, 25)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "FFM (pounds)"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTBW
        '
        Me.txtTBW.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtTBW.FocusFontColor = System.Drawing.Color.Blue
        Me.txtTBW.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtTBW.Location = New System.Drawing.Point(381, 138)
        Me.txtTBW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTBW.Name = "txtTBW"
        Me.txtTBW.Size = New System.Drawing.Size(87, 22)
        Me.txtTBW.TabIndex = 11
        Me.txtTBW.TabOnEnter = False
        Me.txtTBW.TextType = RFIControls.enumTextType.Currency
        '
        'txtECMp
        '
        Me.txtECMp.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtECMp.FocusFontColor = System.Drawing.Color.Blue
        Me.txtECMp.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtECMp.Location = New System.Drawing.Point(381, 106)
        Me.txtECMp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtECMp.Name = "txtECMp"
        Me.txtECMp.Size = New System.Drawing.Size(87, 22)
        Me.txtECMp.TabIndex = 10
        Me.txtECMp.TabOnEnter = False
        Me.txtECMp.TextType = RFIControls.enumTextType.Currency
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Location = New System.Drawing.Point(503, 42)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 25)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "ECW %"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(263, 106)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 25)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "ECM (pounds)"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBCMp
        '
        Me.txtBCMp.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBCMp.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBCMp.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBCMp.Location = New System.Drawing.Point(381, 42)
        Me.txtBCMp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBCMp.Name = "txtBCMp"
        Me.txtBCMp.Size = New System.Drawing.Size(87, 22)
        Me.txtBCMp.TabIndex = 8
        Me.txtBCMp.TabOnEnter = False
        Me.txtBCMp.TextType = RFIControls.enumTextType.Currency
        '
        'txtECW
        '
        Me.txtECW.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtECW.FocusFontColor = System.Drawing.Color.Blue
        Me.txtECW.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtECW.Location = New System.Drawing.Point(624, 42)
        Me.txtECW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtECW.Name = "txtECW"
        Me.txtECW.Size = New System.Drawing.Size(87, 22)
        Me.txtECW.TabIndex = 15
        Me.txtECW.TabOnEnter = False
        Me.txtECW.TextType = RFIControls.enumTextType.Currency
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Location = New System.Drawing.Point(263, 42)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(104, 25)
        Me.Label39.TabIndex = 14
        Me.Label39.Text = "BCM (pounds)"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(263, 202)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 25)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "ICW %"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFatp
        '
        Me.txtFatp.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFatp.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFatp.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFatp.Location = New System.Drawing.Point(128, 138)
        Me.txtFatp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFatp.Name = "txtFatp"
        Me.txtFatp.Size = New System.Drawing.Size(84, 22)
        Me.txtFatp.TabIndex = 4
        Me.txtFatp.TabOnEnter = False
        Me.txtFatp.TextType = RFIControls.enumTextType.Currency
        '
        'txtICW
        '
        Me.txtICW.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtICW.FocusFontColor = System.Drawing.Color.Blue
        Me.txtICW.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtICW.Location = New System.Drawing.Point(381, 202)
        Me.txtICW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtICW.Name = "txtICW"
        Me.txtICW.Size = New System.Drawing.Size(87, 22)
        Me.txtICW.TabIndex = 13
        Me.txtICW.TabOnEnter = False
        Me.txtICW.TextType = RFIControls.enumTextType.Currency
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Location = New System.Drawing.Point(4, 138)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(105, 25)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Fat (pounds)"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(4, 74)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(105, 25)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "BMR "
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBMR
        '
        Me.txtBMR.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBMR.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBMR.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBMR.Location = New System.Drawing.Point(128, 74)
        Me.txtBMR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBMR.Name = "txtBMR"
        Me.txtBMR.Size = New System.Drawing.Size(84, 22)
        Me.txtBMR.TabIndex = 2
        Me.txtBMR.TabOnEnter = False
        Me.txtBMR.TextType = RFIControls.enumTextType.Currency
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(4, 170)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(105, 25)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "FFM %"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFFM
        '
        Me.txtFFM.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFFM.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFFM.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFFM.Location = New System.Drawing.Point(128, 170)
        Me.txtFFM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFFM.Name = "txtFFM"
        Me.txtFFM.Size = New System.Drawing.Size(84, 22)
        Me.txtFFM.TabIndex = 5
        Me.txtFFM.TabOnEnter = False
        Me.txtFFM.TextType = RFIControls.enumTextType.Currency
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(263, 74)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 25)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "ECM %"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtECM
        '
        Me.txtECM.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtECM.FocusFontColor = System.Drawing.Color.Blue
        Me.txtECM.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtECM.Location = New System.Drawing.Point(381, 74)
        Me.txtECM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtECM.Name = "txtECM"
        Me.txtECM.Size = New System.Drawing.Size(87, 22)
        Me.txtECM.TabIndex = 9
        Me.txtECM.TabOnEnter = False
        Me.txtECM.TextType = RFIControls.enumTextType.Currency
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(263, 10)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 25)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "BCM %"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBCM
        '
        Me.txtBCM.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtBCM.FocusFontColor = System.Drawing.Color.Blue
        Me.txtBCM.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtBCM.Location = New System.Drawing.Point(381, 10)
        Me.txtBCM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBCM.Name = "txtBCM"
        Me.txtBCM.Size = New System.Drawing.Size(87, 22)
        Me.txtBCM.TabIndex = 7
        Me.txtBCM.TabOnEnter = False
        Me.txtBCM.TextType = RFIControls.enumTextType.Currency
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(5, 8)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(11, 16)
        Me.Label51.TabIndex = 2
        Me.Label51.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 139)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(57, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 17)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "IBW"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(14, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 17)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Desired Weight"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(13, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 17)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Height (inches)"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(60, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 17)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "BMI"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(13, 46)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 17)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Weight"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PdfExport
        '
        Me.PdfExport.Security.Permissions = CType(((((((DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowPrint Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowModifyContents) _
                    Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowCopy) _
                    Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowModifyAnnotations) _
                    Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowFillIn) _
                    Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowAccessibleReaders) _
                    Or DataDynamics.ActiveReports.Export.Pdf.PdfPermissions.AllowAssembly), DataDynamics.ActiveReports.Export.Pdf.PdfPermissions)
        '
        'TextBox26
        '
        Me.TextBox26.FocusBGColor = System.Drawing.Color.Empty
        Me.TextBox26.FocusFontColor = System.Drawing.Color.Empty
        Me.TextBox26.Location = New System.Drawing.Point(109, 102)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(35, 20)
        Me.TextBox26.TabIndex = 7
        Me.TextBox26.TabOnEnter = False
        Me.TextBox26.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'TextBox28
        '
        Me.TextBox28.FocusBGColor = System.Drawing.Color.Empty
        Me.TextBox28.FocusFontColor = System.Drawing.Color.Empty
        Me.TextBox28.Location = New System.Drawing.Point(109, 73)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(35, 20)
        Me.TextBox28.TabIndex = 9
        Me.TextBox28.TabOnEnter = False
        Me.TextBox28.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'TextBox29
        '
        Me.TextBox29.FocusBGColor = System.Drawing.Color.Empty
        Me.TextBox29.FocusFontColor = System.Drawing.Color.Empty
        Me.TextBox29.Location = New System.Drawing.Point(109, 19)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(35, 20)
        Me.TextBox29.TabIndex = 5
        Me.TextBox29.TabOnEnter = False
        Me.TextBox29.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'TextBox30
        '
        Me.TextBox30.FocusBGColor = System.Drawing.Color.Empty
        Me.TextBox30.FocusFontColor = System.Drawing.Color.Empty
        Me.TextBox30.Location = New System.Drawing.Point(109, 128)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(35, 20)
        Me.TextBox30.TabIndex = 8
        Me.TextBox30.TabOnEnter = False
        Me.TextBox30.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'TextBox31
        '
        Me.TextBox31.FocusBGColor = System.Drawing.Color.Empty
        Me.TextBox31.FocusFontColor = System.Drawing.Color.Empty
        Me.TextBox31.Location = New System.Drawing.Point(109, 45)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(35, 20)
        Me.TextBox31.TabIndex = 6
        Me.TextBox31.TabOnEnter = False
        Me.TextBox31.TextType = RFIControls.enumTextType.AlphaNumeric
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "*.csv"
        Me.SaveFileDialog.Filter = "Excel(*.csv)|*.csv"
        Me.SaveFileDialog.Title = "Export Patient Data"
        '
        'frmPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Visit Data"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gbMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMain.Panel.ResumeLayout(False)
        CType(Me.gbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMain.ResumeLayout(False)
        CType(Me.patientNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.patientNav.ResumeLayout(False)
        CType(Me.pgPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgPatient.ResumeLayout(False)
        Me.pgPatient.PerformLayout()
        CType(Me.pgContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgContact.ResumeLayout(False)
        Me.pgContact.PerformLayout()
        CType(Me.MainNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainNavigator.ResumeLayout(False)
        CType(Me.pgHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgHistory.ResumeLayout(False)
        CType(Me.gridVisitHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgQuestion.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup14.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup14.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup14.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup14.ResumeLayout(False)
        CType(Me.pgCondition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCondition.ResumeLayout(False)
        CType(Me.dgConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.pgScanData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgScanData.ResumeLayout(False)
        Me.pgScanData.PerformLayout()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup5.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup4.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.pgCholesterol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCholesterol.ResumeLayout(False)
        Me.pgCholesterol.PerformLayout()
        CType(Me.KryptonHeaderGroup13.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup13.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup13.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup13.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup9.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup9.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup9.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup9.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup8.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup7.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup7.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup7.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup7.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup6.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup6.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup6.ResumeLayout(False)
        CType(Me.pgBCA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgBCA.ResumeLayout(False)
        Me.pgBCA.PerformLayout()
        CType(Me.KryptonHeaderGroup10.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup10.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup10.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup10.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents MainNavigator As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents pgScanData As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents gbMain As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtFirstName As RFIControls.TextPlus
    Friend WithEvents txtLastName As RFIControls.TextPlus
    Friend WithEvents txtMI As RFIControls.TextPlus
    Friend WithEvents pgCholesterol As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents pgBCA As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents pgCondition As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents pgHistory As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents txtHeight As RFIControls.TextPlus
    Friend WithEvents txtDesirWeight As RFIControls.TextPlus
    Friend WithEvents txtBMI As RFIControls.TextPlus
    Friend WithEvents txtIBW As RFIControls.TextPlus
    Friend WithEvents txtWeight As RFIControls.TextPlus
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHip As RFIControls.TextPlus
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWaist As RFIControls.TextPlus
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtClavical As RFIControls.TextPlus
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPelvic As RFIControls.TextPlus
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtbp2 As RFIControls.TextPlus
    Friend WithEvents txtbp1 As RFIControls.TextPlus
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTrg As RFIControls.TextPlus
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalChol As RFIControls.TextPlus
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLDL As RFIControls.TextPlus
    Friend WithEvents txtNonHDL As RFIControls.TextPlus
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTCHDL As RFIControls.TextPlus
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtHDL As RFIControls.TextPlus
    Friend WithEvents txtRiskAss As RFIControls.TextPlus
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtALT As RFIControls.TextPlus
    Friend WithEvents txtAST As RFIControls.TextPlus
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtGlucosResult As RFIControls.TextPlus
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As RFIControls.TextPlus
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox28 As RFIControls.TextPlus
    Friend WithEvents TextBox29 As RFIControls.TextPlus
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox30 As RFIControls.TextPlus
    Friend WithEvents TextBox31 As RFIControls.TextPlus
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup5 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup7 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup6 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup9 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup10 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTBW As RFIControls.TextPlus
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtECW As RFIControls.TextPlus
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtICW As RFIControls.TextPlus
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtBMR As RFIControls.TextPlus
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtFFM As RFIControls.TextPlus
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtECM As RFIControls.TextPlus
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtBCM As RFIControls.TextPlus
    Friend WithEvents txtCapa As RFIControls.TextPlus
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtPhaseAngle As RFIControls.TextPlus
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtFFMp As RFIControls.TextPlus
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtECMp As RFIControls.TextPlus
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtBCMp As RFIControls.TextPlus
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtFatp As RFIControls.TextPlus
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents KryptonHeaderGroup13 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtDensity As RFIControls.TextPlus
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtFluid As RFIControls.TextPlus
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtFat As RFIControls.TextPlus
    Friend WithEvents txtMuscle As RFIControls.TextPlus
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtBone As RFIControls.TextPlus
    Friend WithEvents btnEditVisit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNewVisit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblMI As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pgQuestion As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents KryptonHeaderGroup14 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtQuest1 As RFIControls.TextPlus
    Friend WithEvents txtQuest4 As RFIControls.TextPlus
    Friend WithEvents txtQuest3 As RFIControls.TextPlus
    Friend WithEvents txtQuest2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuest7 As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuest9 As RFIControls.TextPlus
    Friend WithEvents txtQuest8 As RFIControls.TextPlus
    Friend WithEvents txtQuest6 As RFIControls.TextPlus
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents btnVPrint As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnPrint As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtVO2 As RFIControls.TextPlus
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtConditonInfo As RFIControls.TextPlus
    Friend WithEvents txtFatper As RFIControls.TextPlus
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtTBWLiters As RFIControls.TextPlus
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtECWLiters As RFIControls.TextPlus
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtICWLiters As RFIControls.TextPlus
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtReact As RFIControls.TextPlus
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtResist As RFIControls.TextPlus
    Friend WithEvents dtQuestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents dateCholTest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As RFIControls.TextPlus
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As RFIControls.TextPlus
    Friend WithEvents patientNav As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents pgPatient As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents pgContact As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents txtAddress As RFIControls.TextPlus
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txtTime As RFIControls.TextPlus
    Friend WithEvents txtRMR As RFIControls.TextPlus
    Friend WithEvents cbGender As RFIControls.ComboPlus
    Friend WithEvents cbExercise As RFIControls.ComboPlus
    Friend WithEvents cbBodyType As RFIControls.ComboPlus
    Friend WithEvents cbGlucoseTest As RFIControls.ComboPlus
    Friend WithEvents cbDobyyyy As RFIControls.ComboPlus
    Friend WithEvents txtDobdd As RFIControls.TextPlus
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cbDOBmm As RFIControls.ComboPlus
    Friend WithEvents gridVisitHistory As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtQuest5 As RFIControls.ComboPlus
    Friend WithEvents gpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpvisit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpgender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpheight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdexaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdfExport As DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Friend WithEvents dgConditions As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtBMI2 As RFIControls.TextPlus
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnPre As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnExport As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnDeleteVisit As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
