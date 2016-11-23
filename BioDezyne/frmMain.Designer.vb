<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pbButterfly = New System.Windows.Forms.PictureBox
        Me.ribMain = New ComponentFactory.Krypton.Ribbon.KryptonRibbon
        Me.btnBlue = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.btnSilver = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.btnBlack = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.tabMain = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
        Me.KryptonRibbonGroup1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnNewPatient = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnPatientSearch = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnCurrentPatient = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.KryptonRibbonGroup2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple6 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnPrintQuestionair = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnPrintDocs = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.KryptonRibbonGroup6 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnExit = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.tabAdmin = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
        Me.KryptonRibbonGroup4 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnNewUser = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnManageUsers = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.KryptonRibbonGroup3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple5 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnNewDoc = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnManageDoc = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.KryptonRibbonGroup5 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Me.KryptonRibbonGroupTriple4 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Me.btnSettings = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.btnFileLocation = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Me.PrintDiag = New System.Windows.Forms.PrintDialog
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbButterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 644)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(815, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 644)
        Me.KryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(815, 0)
        Me.KryptonPanel1.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 54)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = Global.BioDezyne.My.Resources.Resources.locked
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(96, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.BioDezyne.My.Resources.Resources.logout
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'pbButterfly
        '
        Me.pbButterfly.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbButterfly.BackColor = System.Drawing.Color.AliceBlue
        Me.pbButterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbButterfly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbButterfly.Image = CType(resources.GetObject("pbButterfly.Image"), System.Drawing.Image)
        Me.pbButterfly.Location = New System.Drawing.Point(715, 24)
        Me.pbButterfly.Margin = New System.Windows.Forms.Padding(4)
        Me.pbButterfly.Name = "pbButterfly"
        Me.pbButterfly.Size = New System.Drawing.Size(91, 79)
        Me.pbButterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbButterfly.TabIndex = 4
        Me.pbButterfly.TabStop = False
        '
        'ribMain
        '
        Me.ribMain.AllowButtonSpecToolTips = True
        Me.ribMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnBlue, Me.btnSilver, Me.btnBlack})
        Me.ribMain.Name = "ribMain"
        Me.ribMain.OverrideFocus.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.OverrideFocus.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.OverrideFocus.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.OverrideFocus.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.OverrideFocus.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.OverrideFocus.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.QATLocation = ComponentFactory.Krypton.Ribbon.QATLocation.Hidden
        Me.ribMain.QATUserChange = False
        Me.ribMain.RibbonAppButton.AppButtonImage = Global.BioDezyne.My.Resources.Resources.ksirtet
        Me.ribMain.RibbonAppButton.AppButtonToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.ribMain.RibbonTabs.Add(Me.tabMain)
        Me.ribMain.RibbonTabs.Add(Me.tabAdmin)
        Me.ribMain.SelectedTab = Me.tabMain
        Me.ribMain.Size = New System.Drawing.Size(815, 109)
        Me.ribMain.StateCheckedNormal.RibbonGroupArea.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonGroupArea.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonGroupArea.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonGroupArea.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonGroupArea.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedNormal.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCheckedTracking.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonAppButton.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonAppButton.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonAppButton.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonAppButton.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonAppButton.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.DisabledDark = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.DisabledLight = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.GroupDialogDark = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.GroupDialogLight = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.GroupSeparatorDark = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.GroupSeparatorLight = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.MinimizeBarDarkColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.MinimizeBarLightColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.QATButtonDarkColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.QATButtonLightColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.TabSeparatorColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGeneral.TabSeparatorContextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupArea.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupArea.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupArea.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupArea.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupArea.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCheckBoxText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedFrameBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupCollapsedText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupLabelText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonGroupRadioButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATFullbar.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATFullbar.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATFullbar.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATFullbar.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATFullbar.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarActive.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarActive.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarActive.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarActive.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarActive.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarInactive.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarInactive.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarInactive.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarInactive.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATMinibarInactive.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATOverflow.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATOverflow.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATOverflow.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATOverflow.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonQATOverflow.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateCommon.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonGroupArea.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonGroupArea.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonGroupArea.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonGroupArea.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonGroupArea.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedNormal.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextCheckedTracking.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedFrameBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupCollapsedText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextNormal.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedFrameBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupCollapsedText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateContextTracking.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateDisabled.RibbonGroupButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateDisabled.RibbonGroupCheckBoxText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateDisabled.RibbonGroupLabelText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateDisabled.RibbonGroupRadioButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonAppButton.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonAppButton.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonAppButton.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonAppButton.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonAppButton.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCheckBoxText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedFrameBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupCollapsedText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupLabelText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonGroupRadioButtonText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateNormal.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StatePressed.RibbonAppButton.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StatePressed.RibbonAppButton.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StatePressed.RibbonAppButton.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StatePressed.RibbonAppButton.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StatePressed.RibbonAppButton.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonAppButton.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonAppButton.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonAppButton.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonAppButton.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonAppButton.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBack.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBack.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBack.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBack.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBack.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedFrameBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupCollapsedText.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalBorder.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalBorder.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalBorder.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalBorder.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalBorder.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.BackColor1 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.BackColor2 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.BackColor3 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.BackColor4 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.ribMain.StateTracking.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.ribMain.TabIndex = 1
        '
        'btnBlue
        '
        Me.btnBlue.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.btnBlue.ExtraText = ""
        Me.btnBlue.Image = Nothing
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.ToolTipImage = Nothing
        Me.btnBlue.UniqueName = "E7566B80395D49DDE7566B80395D49DD"
        '
        'btnSilver
        '
        Me.btnSilver.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
        Me.btnSilver.ExtraText = ""
        Me.btnSilver.Image = Nothing
        Me.btnSilver.Text = "Silver"
        Me.btnSilver.ToolTipImage = Nothing
        Me.btnSilver.UniqueName = "A7F7A8DF98684A4DA7F7A8DF98684A4D"
        '
        'btnBlack
        '
        Me.btnBlack.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.btnBlack.ExtraText = ""
        Me.btnBlack.Image = Nothing
        Me.btnBlack.Text = "Black"
        Me.btnBlack.ToolTipImage = Nothing
        Me.btnBlack.UniqueName = "67872CA780AF45F267872CA780AF45F2"
        '
        'tabMain
        '
        Me.tabMain.Groups.Add(Me.KryptonRibbonGroup1)
        Me.tabMain.Groups.Add(Me.KryptonRibbonGroup2)
        Me.tabMain.Groups.Add(Me.KryptonRibbonGroup6)
        Me.tabMain.Tag = Nothing
        Me.tabMain.Text = "Main Menu"
        '
        'KryptonRibbonGroup1
        '
        Me.KryptonRibbonGroup1.AllowCollapsed = False
        Me.KryptonRibbonGroup1.DialogBoxLauncher = False
        Me.KryptonRibbonGroup1.Image = CType(resources.GetObject("KryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup1.Items.Add(Me.KryptonRibbonGroupTriple1)
        Me.KryptonRibbonGroup1.KeyTipGroup = "PATIENT"
        Me.KryptonRibbonGroup1.Tag = Nothing
        Me.KryptonRibbonGroup1.TextLine1 = "Patient"
        '
        'KryptonRibbonGroupTriple1
        '
        Me.KryptonRibbonGroupTriple1.Items.Add(Me.btnNewPatient)
        Me.KryptonRibbonGroupTriple1.Items.Add(Me.btnPatientSearch)
        Me.KryptonRibbonGroupTriple1.Items.Add(Me.btnCurrentPatient)
        Me.KryptonRibbonGroupTriple1.Tag = Nothing
        '
        'btnNewPatient
        '
        Me.btnNewPatient.ImageLarge = Global.BioDezyne.My.Resources.Resources.agt_family
        Me.btnNewPatient.ImageSmall = CType(resources.GetObject("btnNewPatient.ImageSmall"), System.Drawing.Image)
        Me.btnNewPatient.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnNewPatient.Tag = Nothing
        Me.btnNewPatient.TextLine1 = "New Patient"
        Me.btnNewPatient.ToolTipBody = "Create and save new" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "patient in the system"
        Me.btnNewPatient.ToolTipImage = Global.BioDezyne.My.Resources.Resources.agt_family
        Me.btnNewPatient.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnNewPatient.ToolTipTitle = "New Patient"
        '
        'btnPatientSearch
        '
        Me.btnPatientSearch.ImageLarge = Global.BioDezyne.My.Resources.Resources.fnd_family
        Me.btnPatientSearch.ImageSmall = CType(resources.GetObject("btnPatientSearch.ImageSmall"), System.Drawing.Image)
        Me.btnPatientSearch.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnPatientSearch.Tag = Nothing
        Me.btnPatientSearch.TextLine1 = "Existing Patient"
        Me.btnPatientSearch.ToolTipBody = "Search for existing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "patients in the system"
        Me.btnPatientSearch.ToolTipImage = Global.BioDezyne.My.Resources.Resources.fnd_family
        Me.btnPatientSearch.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnPatientSearch.ToolTipTitle = "Existing Patients"
        '
        'btnCurrentPatient
        '
        Me.btnCurrentPatient.Enabled = False
        Me.btnCurrentPatient.ImageLarge = Global.BioDezyne.My.Resources.Resources.stock_people1
        Me.btnCurrentPatient.ImageSmall = CType(resources.GetObject("btnCurrentPatient.ImageSmall"), System.Drawing.Image)
        Me.btnCurrentPatient.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnCurrentPatient.Tag = Nothing
        Me.btnCurrentPatient.TextLine1 = "Current Patient"
        Me.btnCurrentPatient.ToolTipBody = "If you have to leave the patient edit screen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this button will allow you to retu" & _
            "rn without " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "loosing data."
        Me.btnCurrentPatient.ToolTipImage = Global.BioDezyne.My.Resources.Resources.stock_people1
        Me.btnCurrentPatient.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnCurrentPatient.ToolTipTitle = "Current Patient"
        '
        'KryptonRibbonGroup2
        '
        Me.KryptonRibbonGroup2.AllowCollapsed = False
        Me.KryptonRibbonGroup2.DialogBoxLauncher = False
        Me.KryptonRibbonGroup2.Image = CType(resources.GetObject("KryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup2.Items.Add(Me.KryptonRibbonGroupTriple6)
        Me.KryptonRibbonGroup2.KeyTipGroup = "PRINT"
        Me.KryptonRibbonGroup2.Tag = Nothing
        Me.KryptonRibbonGroup2.TextLine1 = "Print"
        '
        'KryptonRibbonGroupTriple6
        '
        Me.KryptonRibbonGroupTriple6.Items.Add(Me.btnPrintQuestionair)
        Me.KryptonRibbonGroupTriple6.Items.Add(Me.btnPrintDocs)
        Me.KryptonRibbonGroupTriple6.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium
        Me.KryptonRibbonGroupTriple6.Tag = Nothing
        '
        'btnPrintQuestionair
        '
        Me.btnPrintQuestionair.ImageLarge = Global.BioDezyne.My.Resources.Resources.lists
        Me.btnPrintQuestionair.ImageSmall = CType(resources.GetObject("btnPrintQuestionair.ImageSmall"), System.Drawing.Image)
        Me.btnPrintQuestionair.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnPrintQuestionair.Tag = Nothing
        Me.btnPrintQuestionair.TextLine1 = "Questionnaire"
        Me.btnPrintQuestionair.ToolTipBody = "Print the questionnaire " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the default printer"
        Me.btnPrintQuestionair.ToolTipImage = Global.BioDezyne.My.Resources.Resources.lists
        Me.btnPrintQuestionair.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnPrintQuestionair.ToolTipTitle = "Questionnaire"
        '
        'btnPrintDocs
        '
        Me.btnPrintDocs.ImageLarge = Global.BioDezyne.My.Resources.Resources.folder_print
        Me.btnPrintDocs.ImageSmall = CType(resources.GetObject("btnPrintDocs.ImageSmall"), System.Drawing.Image)
        Me.btnPrintDocs.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnPrintDocs.Tag = Nothing
        Me.btnPrintDocs.TextLine1 = "Documents"
        Me.btnPrintDocs.ToolTipBody = "Display list of all documents in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the system that can be printed"
        Me.btnPrintDocs.ToolTipImage = Global.BioDezyne.My.Resources.Resources.folder_print
        Me.btnPrintDocs.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnPrintDocs.ToolTipTitle = "Documents"
        '
        'KryptonRibbonGroup6
        '
        Me.KryptonRibbonGroup6.AllowCollapsed = False
        Me.KryptonRibbonGroup6.DialogBoxLauncher = False
        Me.KryptonRibbonGroup6.Image = CType(resources.GetObject("KryptonRibbonGroup6.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup6.Items.Add(Me.KryptonRibbonGroupTriple2)
        Me.KryptonRibbonGroup6.Tag = Nothing
        Me.KryptonRibbonGroup6.TextLine1 = "System"
        '
        'KryptonRibbonGroupTriple2
        '
        Me.KryptonRibbonGroupTriple2.Items.Add(Me.btnExit)
        Me.KryptonRibbonGroupTriple2.Tag = Nothing
        '
        'btnExit
        '
        Me.btnExit.ImageLarge = Global.BioDezyne.My.Resources.Resources.sys_exit
        Me.btnExit.ImageSmall = CType(resources.GetObject("btnExit.ImageSmall"), System.Drawing.Image)
        Me.btnExit.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnExit.Tag = Nothing
        Me.btnExit.TextLine1 = "Exit Now"
        Me.btnExit.ToolTipBody = "Exiting will loose all unsaved data"
        Me.btnExit.ToolTipImage = Global.BioDezyne.My.Resources.Resources.sys_exit
        Me.btnExit.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnExit.ToolTipTitle = "Exit Now"
        '
        'tabAdmin
        '
        Me.tabAdmin.Groups.Add(Me.KryptonRibbonGroup4)
        Me.tabAdmin.Groups.Add(Me.KryptonRibbonGroup3)
        Me.tabAdmin.Groups.Add(Me.KryptonRibbonGroup5)
        Me.tabAdmin.Tag = Nothing
        Me.tabAdmin.Text = "Admin"
        '
        'KryptonRibbonGroup4
        '
        Me.KryptonRibbonGroup4.AllowCollapsed = False
        Me.KryptonRibbonGroup4.DialogBoxLauncher = False
        Me.KryptonRibbonGroup4.Image = CType(resources.GetObject("KryptonRibbonGroup4.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup4.Items.Add(Me.KryptonRibbonGroupTriple3)
        Me.KryptonRibbonGroup4.Tag = Nothing
        Me.KryptonRibbonGroup4.TextLine1 = "User Admin"
        '
        'KryptonRibbonGroupTriple3
        '
        Me.KryptonRibbonGroupTriple3.Items.Add(Me.btnNewUser)
        Me.KryptonRibbonGroupTriple3.Items.Add(Me.btnManageUsers)
        Me.KryptonRibbonGroupTriple3.Tag = Nothing
        '
        'btnNewUser
        '
        Me.btnNewUser.ImageLarge = Global.BioDezyne.My.Resources.Resources.edit_user
        Me.btnNewUser.ImageSmall = CType(resources.GetObject("btnNewUser.ImageSmall"), System.Drawing.Image)
        Me.btnNewUser.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnNewUser.Tag = Nothing
        Me.btnNewUser.TextLine1 = "New User"
        Me.btnNewUser.ToolTipBody = "Create a new user in the system"
        Me.btnNewUser.ToolTipImage = Global.BioDezyne.My.Resources.Resources.edit_user1
        Me.btnNewUser.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnNewUser.ToolTipTitle = "New User"
        '
        'btnManageUsers
        '
        Me.btnManageUsers.ImageLarge = Global.BioDezyne.My.Resources.Resources.edit_group
        Me.btnManageUsers.ImageSmall = Nothing
        Me.btnManageUsers.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnManageUsers.Tag = Nothing
        Me.btnManageUsers.TextLine1 = "User Manager"
        Me.btnManageUsers.ToolTipBody = "Manage system user accounts"
        Me.btnManageUsers.ToolTipImage = Global.BioDezyne.My.Resources.Resources.edit_group1
        Me.btnManageUsers.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnManageUsers.ToolTipTitle = "User Manager"
        '
        'KryptonRibbonGroup3
        '
        Me.KryptonRibbonGroup3.AllowCollapsed = False
        Me.KryptonRibbonGroup3.DialogBoxLauncher = False
        Me.KryptonRibbonGroup3.Image = CType(resources.GetObject("KryptonRibbonGroup3.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup3.Items.Add(Me.KryptonRibbonGroupTriple5)
        Me.KryptonRibbonGroup3.Tag = Nothing
        Me.KryptonRibbonGroup3.TextLine1 = "Documents"
        '
        'KryptonRibbonGroupTriple5
        '
        Me.KryptonRibbonGroupTriple5.Items.Add(Me.btnNewDoc)
        Me.KryptonRibbonGroupTriple5.Items.Add(Me.btnManageDoc)
        Me.KryptonRibbonGroupTriple5.Tag = Nothing
        '
        'btnNewDoc
        '
        Me.btnNewDoc.ImageLarge = Global.BioDezyne.My.Resources.Resources.mydocuments
        Me.btnNewDoc.ImageSmall = CType(resources.GetObject("btnNewDoc.ImageSmall"), System.Drawing.Image)
        Me.btnNewDoc.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnNewDoc.Tag = Nothing
        Me.btnNewDoc.TextLine1 = "New Document"
        Me.btnNewDoc.ToolTipBody = "Add a new document in the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document management system"
        Me.btnNewDoc.ToolTipImage = Global.BioDezyne.My.Resources.Resources.mydocuments1
        Me.btnNewDoc.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnNewDoc.ToolTipTitle = "New Document"
        '
        'btnManageDoc
        '
        Me.btnManageDoc.ImageLarge = Global.BioDezyne.My.Resources.Resources.kaddressbook
        Me.btnManageDoc.ImageSmall = CType(resources.GetObject("btnManageDoc.ImageSmall"), System.Drawing.Image)
        Me.btnManageDoc.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnManageDoc.Tag = Nothing
        Me.btnManageDoc.TextLine1 = "Document List"
        Me.btnManageDoc.ToolTipBody = "Manage system documents"
        Me.btnManageDoc.ToolTipImage = Global.BioDezyne.My.Resources.Resources.kaddressbook
        Me.btnManageDoc.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnManageDoc.ToolTipTitle = "Document List"
        '
        'KryptonRibbonGroup5
        '
        Me.KryptonRibbonGroup5.AllowCollapsed = False
        Me.KryptonRibbonGroup5.DialogBoxLauncher = False
        Me.KryptonRibbonGroup5.Image = CType(resources.GetObject("KryptonRibbonGroup5.Image"), System.Drawing.Image)
        Me.KryptonRibbonGroup5.Items.Add(Me.KryptonRibbonGroupTriple4)
        Me.KryptonRibbonGroup5.Tag = Nothing
        Me.KryptonRibbonGroup5.TextLine1 = "System Admin"
        '
        'KryptonRibbonGroupTriple4
        '
        Me.KryptonRibbonGroupTriple4.Items.Add(Me.btnSettings)
        Me.KryptonRibbonGroupTriple4.Items.Add(Me.btnFileLocation)
        Me.KryptonRibbonGroupTriple4.Tag = Nothing
        '
        'btnSettings
        '
        Me.btnSettings.ImageLarge = Global.BioDezyne.My.Resources.Resources.ksysguard
        Me.btnSettings.ImageSmall = CType(resources.GetObject("btnSettings.ImageSmall"), System.Drawing.Image)
        Me.btnSettings.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnSettings.Tag = Nothing
        Me.btnSettings.TextLine1 = "System Settings"
        Me.btnSettings.ToolTipBody = "Update and save all " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "optional system settings"
        Me.btnSettings.ToolTipImage = Global.BioDezyne.My.Resources.Resources.ksysguard
        Me.btnSettings.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnSettings.ToolTipTitle = "System Setting"
        '
        'btnFileLocation
        '
        Me.btnFileLocation.ImageLarge = Global.BioDezyne.My.Resources.Resources.list
        Me.btnFileLocation.ImageSmall = CType(resources.GetObject("btnFileLocation.ImageSmall"), System.Drawing.Image)
        Me.btnFileLocation.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.btnFileLocation.Tag = Nothing
        Me.btnFileLocation.TextLine1 = "System Events"
        Me.btnFileLocation.ToolTipBody = "Search and view all event that " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are logged in the system"
        Me.btnFileLocation.ToolTipImage = Global.BioDezyne.My.Resources.Resources.list
        Me.btnFileLocation.ToolTipImageTransparentColor = System.Drawing.Color.Empty
        Me.btnFileLocation.ToolTipTitle = "System Event"
        '
        'PrintDiag
        '
        Me.PrintDiag.AllowPrintToFile = False
        Me.PrintDiag.UseEXDialog = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(815, 666)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.pbButterfly)
        Me.Controls.Add(Me.ribMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BioDezyne"
        Me.TextExtra = ""
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbButterfly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ribMain As ComponentFactory.Krypton.Ribbon.KryptonRibbon
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents tabMain As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents KryptonRibbonGroup1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupTriple1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnNewPatient As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroup2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents tabAdmin As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents KryptonRibbonGroup4 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroup5 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroup6 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupTriple2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnExit As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroup3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupTriple3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnManageUsers As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroupTriple6 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnPrintQuestionair As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnPrintDocs As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroupTriple5 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnNewDoc As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnManageDoc As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroupTriple4 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnSettings As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnFileLocation As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnPatientSearch As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnBlue As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnSilver As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnBlack As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnNewUser As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents pbButterfly As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDiag As System.Windows.Forms.PrintDialog
    Friend WithEvents btnCurrentPatient As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton

End Class
