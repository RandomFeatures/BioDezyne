<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvents))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnReset = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtVisitID = New RFIControls.TextPlus
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPatientID = New RFIControls.TextPlus
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gridEvents = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.btnHidenSeach = New System.Windows.Forms.Button
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.gpname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpvisit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpgender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpheight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdexaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.gridEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.btnHidenSeach)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(812, 540)
        Me.KryptonPanel.TabIndex = 0
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
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(15, 12)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtVisitID)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtEnd)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtStart)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtPatientID)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label49)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLastName)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(780, 160)
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Event Search"
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
        'txtVisitID
        '
        Me.txtVisitID.FocusBGColor = System.Drawing.Color.Empty
        Me.txtVisitID.FocusFontColor = System.Drawing.Color.Empty
        Me.txtVisitID.Location = New System.Drawing.Point(371, 58)
        Me.txtVisitID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVisitID.MaxLength = 6
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.Size = New System.Drawing.Size(60, 22)
        Me.txtVisitID.TabIndex = 26
        Me.txtVisitID.TabOnEnter = False
        Me.txtVisitID.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'dtEnd
        '
        Me.dtEnd.CustomFormat = "MMMM dd, yyyy"
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEnd.Location = New System.Drawing.Point(536, 58)
        Me.dtEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(216, 22)
        Me.dtEnd.TabIndex = 25
        '
        'dtStart
        '
        Me.dtStart.CustomFormat = "MMMM dd, yyyy"
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStart.Location = New System.Drawing.Point(536, 14)
        Me.dtStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(216, 22)
        Me.dtStart.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(459, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "End Date"
        '
        'txtPatientID
        '
        Me.txtPatientID.FocusBGColor = System.Drawing.Color.Empty
        Me.txtPatientID.FocusFontColor = System.Drawing.Color.Empty
        Me.txtPatientID.Location = New System.Drawing.Point(201, 58)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPatientID.MaxLength = 6
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(60, 22)
        Me.txtPatientID.TabIndex = 3
        Me.txtPatientID.TabOnEnter = False
        Me.txtPatientID.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(455, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(117, 63)
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
        Me.Label49.Location = New System.Drawing.Point(309, 63)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(49, 16)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "Visit ID"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(201, 14)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(229, 22)
        Me.txtLastName.TabIndex = 1
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonHeaderGroup2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup2.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(15, 180)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.gridEvents)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(780, 348)
        Me.KryptonHeaderGroup2.TabIndex = 3
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Search Results"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'gridEvents
        '
        Me.gridEvents.AllowUserToAddRows = False
        Me.gridEvents.AllowUserToDeleteRows = False
        Me.gridEvents.AllowUserToResizeRows = False
        Me.gridEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpname, Me.gpvisit, Me.gpdob, Me.gpgender, Me.gpWeight, Me.gpheight, Me.gpdexaid})
        Me.gridEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEvents.Location = New System.Drawing.Point(0, 0)
        Me.gridEvents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridEvents.MultiSelect = False
        Me.gridEvents.Name = "gridEvents"
        Me.gridEvents.ReadOnly = True
        Me.gridEvents.RowHeadersVisible = False
        Me.gridEvents.RowTemplate.ReadOnly = True
        Me.gridEvents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEvents.Size = New System.Drawing.Size(778, 321)
        Me.gridEvents.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gridEvents.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEvents.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEvents.TabIndex = 23
        '
        'btnHidenSeach
        '
        Me.btnHidenSeach.Location = New System.Drawing.Point(636, 154)
        Me.btnHidenSeach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHidenSeach.Name = "btnHidenSeach"
        Me.btnHidenSeach.Size = New System.Drawing.Size(13, 14)
        Me.btnHidenSeach.TabIndex = 4
        Me.btnHidenSeach.TabStop = False
        Me.btnHidenSeach.UseVisualStyleBackColor = True
        '
        'gpname
        '
        Me.gpname.HeaderText = "Visit ID"
        Me.gpname.Name = "gpname"
        Me.gpname.ReadOnly = True
        Me.gpname.Width = 80
        '
        'gpvisit
        '
        Me.gpvisit.HeaderText = "Patient Name"
        Me.gpvisit.Name = "gpvisit"
        Me.gpvisit.ReadOnly = True
        Me.gpvisit.Width = 175
        '
        'gpdob
        '
        Me.gpdob.HeaderText = "Event"
        Me.gpdob.Name = "gpdob"
        Me.gpdob.ReadOnly = True
        Me.gpdob.Width = 150
        '
        'gpgender
        '
        Me.gpgender.HeaderText = "User ID"
        Me.gpgender.Name = "gpgender"
        Me.gpgender.ReadOnly = True
        Me.gpgender.Width = 55
        '
        'gpWeight
        '
        Me.gpWeight.HeaderText = "Event Date"
        Me.gpWeight.Name = "gpWeight"
        Me.gpWeight.ReadOnly = True
        Me.gpWeight.Width = 175
        '
        'gpheight
        '
        Me.gpheight.HeaderText = "Visit Date"
        Me.gpheight.Name = "gpheight"
        Me.gpheight.ReadOnly = True
        Me.gpheight.Width = 175
        '
        'gpdexaid
        '
        Me.gpdexaid.HeaderText = "dexaID"
        Me.gpdexaid.Name = "gpdexaid"
        Me.gpdexaid.ReadOnly = True
        Me.gpdexaid.Visible = False
        '
        'frmEvents
        '
        Me.AcceptButton = Me.btnHidenSeach
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEvents"
        Me.Text = "System Events"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.gridEvents, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnReset As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtPatientID As RFIControls.TextPlus
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnHidenSeach As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents gridEvents As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtVisitID As RFIControls.TextPlus
    Friend WithEvents gpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpvisit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpgender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpheight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdexaid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
