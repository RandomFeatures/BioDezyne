<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageDoc
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
        Dim btnFindDoc As ComponentFactory.Krypton.Toolkit.KryptonButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageDoc))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gpDocument = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDocTitle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDocFileName = New System.Windows.Forms.TextBox
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNew = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnEdit = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnDelete = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.gridDocList = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.gpname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpvisit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdob = New System.Windows.Forms.DataGridViewTextBoxColumn
        btnFindDoc = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gpDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpDocument.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDocument.Panel.SuspendLayout()
        Me.gpDocument.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.gridDocList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFindDoc
        '
        btnFindDoc.Location = New System.Drawing.Point(700, 53)
        btnFindDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        btnFindDoc.Name = "btnFindDoc"
        btnFindDoc.Size = New System.Drawing.Size(32, 24)
        btnFindDoc.TabIndex = 9
        btnFindDoc.Text = "..."
        btnFindDoc.Values.ExtraText = ""
        btnFindDoc.Values.Image = Nothing
        btnFindDoc.Values.ImageStates.ImageCheckedNormal = Nothing
        btnFindDoc.Values.ImageStates.ImageCheckedPressed = Nothing
        btnFindDoc.Values.ImageStates.ImageCheckedTracking = Nothing
        btnFindDoc.Values.Text = "..."
        AddHandler btnFindDoc.Click, AddressOf Me.btnFindDoc_Click
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gpDocument)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(815, 543)
        Me.KryptonPanel.TabIndex = 0
        '
        'gpDocument
        '
        Me.gpDocument.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSave})
        Me.gpDocument.Enabled = False
        Me.gpDocument.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.gpDocument.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.gpDocument.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.gpDocument.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.gpDocument.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.gpDocument.Location = New System.Drawing.Point(16, 366)
        Me.gpDocument.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDocument.Name = "gpDocument"
        '
        'gpDocument.Panel
        '
        Me.gpDocument.Panel.Controls.Add(Me.PictureBox1)
        Me.gpDocument.Panel.Controls.Add(Me.Label2)
        Me.gpDocument.Panel.Controls.Add(Me.txtDocTitle)
        Me.gpDocument.Panel.Controls.Add(btnFindDoc)
        Me.gpDocument.Panel.Controls.Add(Me.Label1)
        Me.gpDocument.Panel.Controls.Add(Me.txtDocFileName)
        Me.gpDocument.Size = New System.Drawing.Size(780, 162)
        Me.gpDocument.TabIndex = 3
        Me.gpDocument.ValuesPrimary.Description = ""
        Me.gpDocument.ValuesPrimary.Heading = ""
        Me.gpDocument.ValuesPrimary.Image = Nothing
        Me.gpDocument.ValuesSecondary.Description = ""
        Me.gpDocument.ValuesSecondary.Heading = "Document"
        Me.gpDocument.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.package_editors
        '
        'btnSave
        '
        Me.btnSave.ExtraText = ""
        Me.btnSave.Image = Nothing
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipImage = Nothing
        Me.btnSave.UniqueName = "CD8A970F145942FDCD8A970F145942FD"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 87)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(124, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Document Title"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocTitle
        '
        Me.txtDocTitle.Location = New System.Drawing.Point(256, 17)
        Me.txtDocTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocTitle.Name = "txtDocTitle"
        Me.txtDocTitle.Size = New System.Drawing.Size(475, 22)
        Me.txtDocTitle.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(124, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocFileName
        '
        Me.txtDocFileName.Location = New System.Drawing.Point(256, 54)
        Me.txtDocFileName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocFileName.Name = "txtDocFileName"
        Me.txtDocFileName.Size = New System.Drawing.Size(435, 22)
        Me.txtDocFileName.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNew, Me.btnEdit, Me.btnDelete})
        Me.KryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonHeaderGroup1.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup1.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(16, 15)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.gridDocList)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(780, 343)
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Active Documents"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.mydocuments1
        '
        'btnNew
        '
        Me.btnNew.ExtraText = ""
        Me.btnNew.Image = Nothing
        Me.btnNew.Text = "New Document"
        Me.btnNew.ToolTipImage = Nothing
        Me.btnNew.UniqueName = "5F9B3229C30E4C855F9B3229C30E4C85"
        '
        'btnEdit
        '
        Me.btnEdit.ExtraText = ""
        Me.btnEdit.Image = Nothing
        Me.btnEdit.Text = "Edit Selected"
        Me.btnEdit.ToolTipImage = Nothing
        Me.btnEdit.UniqueName = "26B428474991460F26B428474991460F"
        '
        'btnDelete
        '
        Me.btnDelete.ExtraText = ""
        Me.btnDelete.Image = Nothing
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.ToolTipImage = Nothing
        Me.btnDelete.UniqueName = "530D2558B9904621530D2558B9904621"
        '
        'gridDocList
        '
        Me.gridDocList.AllowUserToAddRows = False
        Me.gridDocList.AllowUserToDeleteRows = False
        Me.gridDocList.AllowUserToResizeRows = False
        Me.gridDocList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpname, Me.gpvisit, Me.gpdob})
        Me.gridDocList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocList.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridDocList.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDocList.HideOuterBorders = True
        Me.gridDocList.Location = New System.Drawing.Point(0, 0)
        Me.gridDocList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridDocList.MultiSelect = False
        Me.gridDocList.Name = "gridDocList"
        Me.gridDocList.ReadOnly = True
        Me.gridDocList.RowHeadersVisible = False
        Me.gridDocList.RowTemplate.ReadOnly = True
        Me.gridDocList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDocList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridDocList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDocList.Size = New System.Drawing.Size(778, 293)
        Me.gridDocList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDocList.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocList.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocList.TabIndex = 24
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "PDF Document| *.pdf"
        '
        'gpname
        '
        Me.gpname.HeaderText = "Doc ID"
        Me.gpname.Name = "gpname"
        Me.gpname.ReadOnly = True
        Me.gpname.Visible = False
        Me.gpname.Width = 102
        '
        'gpvisit
        '
        Me.gpvisit.HeaderText = "Document Title"
        Me.gpvisit.Name = "gpvisit"
        Me.gpvisit.ReadOnly = True
        Me.gpvisit.Width = 424
        '
        'gpdob
        '
        Me.gpdob.HeaderText = "File Name"
        Me.gpdob.Name = "gpdob"
        Me.gpdob.ReadOnly = True
        Me.gpdob.Width = 360
        '
        'frmManageDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmManageDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Documents"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gpDocument.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDocument.Panel.ResumeLayout(False)
        Me.gpDocument.Panel.PerformLayout()
        CType(Me.gpDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDocument.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.gridDocList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gpDocument As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocFileName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDocTitle As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNew As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnEdit As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnDelete As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gridDocList As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpvisit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdob As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
