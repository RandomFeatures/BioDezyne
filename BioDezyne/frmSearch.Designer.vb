<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnView = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.gridPatients = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.gAnalysis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gscan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gSerialn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gsWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gscnid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnReset = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtPatientID = New RFIControls.TextPlus
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtXref = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.btnHidenSeach = New System.Windows.Forms.Button
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnDeletePatient = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.gridPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.btnHidenSeach)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(815, 543)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnView, Me.btnDeletePatient})
        Me.KryptonHeaderGroup2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonHeaderGroup2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup2.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(16, 182)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.gridPatients)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(783, 348)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Search Results"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.agt_family1
        '
        'btnView
        '
        Me.btnView.ExtraText = ""
        Me.btnView.Image = Nothing
        Me.btnView.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnView.Text = "View Patient"
        Me.btnView.ToolTipBody = "Open the selected patient record in the patient editor"
        Me.btnView.ToolTipImage = Nothing
        Me.btnView.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.btnView.ToolTipTitle = "View Patient"
        Me.btnView.UniqueName = "4F73E21C2C2E42444F73E21C2C2E4244"
        '
        'gridPatients
        '
        Me.gridPatients.AllowUserToAddRows = False
        Me.gridPatients.AllowUserToDeleteRows = False
        Me.gridPatients.AllowUserToResizeRows = False
        Me.gridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPatients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gAnalysis, Me.gscan, Me.gSerialn, Me.gsWeight, Me.gscnid, Me.Column1})
        Me.gridPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPatients.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridPatients.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridPatients.HideOuterBorders = True
        Me.gridPatients.Location = New System.Drawing.Point(0, 0)
        Me.gridPatients.Margin = New System.Windows.Forms.Padding(4)
        Me.gridPatients.MultiSelect = False
        Me.gridPatients.Name = "gridPatients"
        Me.gridPatients.ReadOnly = True
        Me.gridPatients.RowHeadersVisible = False
        Me.gridPatients.RowTemplate.ReadOnly = True
        Me.gridPatients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridPatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridPatients.Size = New System.Drawing.Size(781, 296)
        Me.gridPatients.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridPatients.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPatients.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPatients.TabIndex = 28
        '
        'gAnalysis
        '
        Me.gAnalysis.HeaderText = "ID"
        Me.gAnalysis.Name = "gAnalysis"
        Me.gAnalysis.ReadOnly = True
        Me.gAnalysis.Width = 50
        '
        'gscan
        '
        Me.gscan.HeaderText = "Name"
        Me.gscan.Name = "gscan"
        Me.gscan.ReadOnly = True
        Me.gscan.Width = 175
        '
        'gSerialn
        '
        Me.gSerialn.HeaderText = "Gender"
        Me.gSerialn.Name = "gSerialn"
        Me.gSerialn.ReadOnly = True
        Me.gSerialn.Width = 90
        '
        'gsWeight
        '
        Me.gsWeight.HeaderText = "Date of Birth"
        Me.gsWeight.Name = "gsWeight"
        Me.gsWeight.ReadOnly = True
        Me.gsWeight.Width = 160
        '
        'gscnid
        '
        Me.gscnid.HeaderText = "Phone"
        Me.gscnid.Name = "gscnid"
        Me.gscnid.ReadOnly = True
        Me.gscnid.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Email"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 175
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSearch, Me.btnReset})
        Me.KryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonHeaderGroup1.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup1.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(16, 15)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtPatientID)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label49)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtXref)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFirstName)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLastName)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(780, 160)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Patient Search"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.find
        '
        'btnSearch
        '
        Me.btnSearch.ExtraText = ""
        Me.btnSearch.Image = Nothing
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTipBody = resources.GetString("btnSearch.ToolTipBody")
        Me.btnSearch.ToolTipImage = Nothing
        Me.btnSearch.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.btnSearch.ToolTipTitle = "Search"
        Me.btnSearch.UniqueName = "70CAE38B8CF2413370CAE38B8CF24133"
        '
        'btnReset
        '
        Me.btnReset.ExtraText = ""
        Me.btnReset.Image = Nothing
        Me.btnReset.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnReset.Text = "Reset"
        Me.btnReset.ToolTipBody = "Clear all search fields "
        Me.btnReset.ToolTipImage = Nothing
        Me.btnReset.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.btnReset.ToolTipTitle = "Reset"
        Me.btnReset.UniqueName = "83B603E14C8E443083B603E14C8E4430"
        '
        'txtPatientID
        '
        Me.txtPatientID.FocusBGColor = System.Drawing.Color.Empty
        Me.txtPatientID.FocusFontColor = System.Drawing.Color.Empty
        Me.txtPatientID.Location = New System.Drawing.Point(201, 57)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.MaxLength = 6
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(183, 22)
        Me.txtPatientID.TabIndex = 3
        Me.txtPatientID.TabOnEnter = False
        Me.txtPatientID.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(421, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "External Reference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(117, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Patient ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(117, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Last Name"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Location = New System.Drawing.Point(476, 18)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(73, 16)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "First Name"
        '
        'txtXref
        '
        Me.txtXref.Location = New System.Drawing.Point(556, 55)
        Me.txtXref.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXref.MaxLength = 50
        Me.txtXref.Name = "txtXref"
        Me.txtXref.Size = New System.Drawing.Size(183, 22)
        Me.txtXref.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(556, 14)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(183, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(201, 14)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(183, 22)
        Me.txtLastName.TabIndex = 1
        '
        'btnHidenSeach
        '
        Me.btnHidenSeach.Location = New System.Drawing.Point(656, 155)
        Me.btnHidenSeach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHidenSeach.Name = "btnHidenSeach"
        Me.btnHidenSeach.Size = New System.Drawing.Size(13, 14)
        Me.btnHidenSeach.TabIndex = 2
        Me.btnHidenSeach.TabStop = False
        Me.btnHidenSeach.UseVisualStyleBackColor = True
        '
        'btnDeletePatient
        '
        Me.btnDeletePatient.ExtraText = ""
        Me.btnDeletePatient.Image = Nothing
        Me.btnDeletePatient.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnDeletePatient.Text = "Delete Patient"
        Me.btnDeletePatient.ToolTipBody = "Delete the selected Patient"
        Me.btnDeletePatient.ToolTipImage = Nothing
        Me.btnDeletePatient.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.btnDeletePatient.ToolTipTitle = "Delete Patient"
        Me.btnDeletePatient.UniqueName = "F411BDD1DB044E2AF411BDD1DB044E2A"
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnHidenSeach
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Existing Patient"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.gridPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtXref As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnReset As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnView As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtPatientID As RFIControls.TextPlus
    Friend WithEvents btnHidenSeach As System.Windows.Forms.Button
    Friend WithEvents gridPatients As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gAnalysis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gscan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gSerialn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gsWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gscnid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDeletePatient As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
