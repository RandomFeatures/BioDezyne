<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAdmin))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gpUserData = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.chkActive = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkAdmin = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNew = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnEdit = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnShowAll = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.gridUserList = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.gpname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpvisit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpgender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gpUserData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpUserData.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpUserData.Panel.SuspendLayout()
        Me.gpUserData.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.gridUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gpUserData)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(815, 543)
        Me.KryptonPanel.TabIndex = 0
        '
        'gpUserData
        '
        Me.gpUserData.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSave, Me.btnCancel})
        Me.gpUserData.Enabled = False
        Me.gpUserData.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.gpUserData.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.gpUserData.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.gpUserData.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.gpUserData.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.gpUserData.Location = New System.Drawing.Point(16, 311)
        Me.gpUserData.Margin = New System.Windows.Forms.Padding(4)
        Me.gpUserData.Name = "gpUserData"
        '
        'gpUserData.Panel
        '
        Me.gpUserData.Panel.Controls.Add(Me.chkActive)
        Me.gpUserData.Panel.Controls.Add(Me.chkAdmin)
        Me.gpUserData.Panel.Controls.Add(Me.PictureBox1)
        Me.gpUserData.Panel.Controls.Add(Me.Label4)
        Me.gpUserData.Panel.Controls.Add(Me.Label3)
        Me.gpUserData.Panel.Controls.Add(Me.Label2)
        Me.gpUserData.Panel.Controls.Add(Me.Label1)
        Me.gpUserData.Panel.Controls.Add(Me.txtPassword)
        Me.gpUserData.Panel.Controls.Add(Me.txtLogin)
        Me.gpUserData.Panel.Controls.Add(Me.txtLastName)
        Me.gpUserData.Panel.Controls.Add(Me.txtFirstName)
        Me.gpUserData.Size = New System.Drawing.Size(780, 219)
        Me.gpUserData.TabIndex = 1
        Me.gpUserData.ValuesPrimary.Description = ""
        Me.gpUserData.ValuesPrimary.Heading = ""
        Me.gpUserData.ValuesPrimary.Image = Nothing
        Me.gpUserData.ValuesSecondary.Description = ""
        Me.gpUserData.ValuesSecondary.Heading = " User Data"
        Me.gpUserData.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.edit_user1
        '
        'btnSave
        '
        Me.btnSave.ExtraText = ""
        Me.btnSave.Image = Nothing
        Me.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipImage = Nothing
        Me.btnSave.UniqueName = "CD8A970F145942FDCD8A970F145942FD"
        '
        'btnCancel
        '
        Me.btnCancel.ExtraText = ""
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ToolTipImage = Nothing
        Me.btnCancel.UniqueName = "89B829E69A534FAE89B829E69A534FAE"
        '
        'chkActive
        '
        Me.chkActive.Checked = False
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkActive.Location = New System.Drawing.Point(552, 119)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(54, 16)
        Me.chkActive.TabIndex = 13
        Me.chkActive.Text = "Active"
        Me.chkActive.Values.ExtraText = ""
        Me.chkActive.Values.Image = Nothing
        Me.chkActive.Values.Text = "Active"
        '
        'chkAdmin
        '
        Me.chkAdmin.Checked = False
        Me.chkAdmin.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkAdmin.Location = New System.Drawing.Point(253, 119)
        Me.chkAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(156, 16)
        Me.chkAdmin.TabIndex = 12
        Me.chkAdmin.Text = "This user has admin rights"
        Me.chkAdmin.Values.ExtraText = ""
        Me.chkAdmin.Values.Image = Nothing
        Me.chkAdmin.Values.Text = "This user has admin rights"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(459, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(455, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(141, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(141, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(552, 75)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(192, 22)
        Me.txtPassword.TabIndex = 3
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(253, 75)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogin.MaxLength = 50
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(192, 22)
        Me.txtLogin.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(552, 20)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(192, 22)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(253, 20)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(192, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNew, Me.btnEdit, Me.btnShowAll})
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.gridUserList)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(780, 289)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Active User"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.edit_group1
        '
        'btnNew
        '
        Me.btnNew.ExtraText = ""
        Me.btnNew.Image = Nothing
        Me.btnNew.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnNew.Text = "New User"
        Me.btnNew.ToolTipImage = Nothing
        Me.btnNew.UniqueName = "DA6B9E9EC1054679DA6B9E9EC1054679"
        '
        'btnEdit
        '
        Me.btnEdit.ExtraText = ""
        Me.btnEdit.Image = Nothing
        Me.btnEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.btnEdit.Text = "Edit User"
        Me.btnEdit.ToolTipImage = Nothing
        Me.btnEdit.UniqueName = "3BD371DCA7E0414A3BD371DCA7E0414A"
        '
        'btnShowAll
        '
        Me.btnShowAll.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
        Me.btnShowAll.ExtraText = ""
        Me.btnShowAll.Image = Nothing
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.ToolTipImage = Nothing
        Me.btnShowAll.UniqueName = "7E26A2367DEA470C7E26A2367DEA470C"
        '
        'gridUserList
        '
        Me.gridUserList.AllowUserToAddRows = False
        Me.gridUserList.AllowUserToDeleteRows = False
        Me.gridUserList.AllowUserToResizeRows = False
        Me.gridUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpname, Me.gpvisit, Me.gpdob, Me.gpgender})
        Me.gridUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUserList.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridUserList.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridUserList.HideOuterBorders = True
        Me.gridUserList.Location = New System.Drawing.Point(0, 0)
        Me.gridUserList.Margin = New System.Windows.Forms.Padding(4)
        Me.gridUserList.MultiSelect = False
        Me.gridUserList.Name = "gridUserList"
        Me.gridUserList.ReadOnly = True
        Me.gridUserList.RowHeadersVisible = False
        Me.gridUserList.RowTemplate.ReadOnly = True
        Me.gridUserList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridUserList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridUserList.Size = New System.Drawing.Size(778, 237)
        Me.gridUserList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridUserList.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridUserList.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridUserList.TabIndex = 24
        '
        'gpname
        '
        Me.gpname.HeaderText = "UserID"
        Me.gpname.Name = "gpname"
        Me.gpname.ReadOnly = True
        Me.gpname.Visible = False
        Me.gpname.Width = 102
        '
        'gpvisit
        '
        Me.gpvisit.HeaderText = "First Name"
        Me.gpvisit.Name = "gpvisit"
        Me.gpvisit.ReadOnly = True
        Me.gpvisit.Width = 250
        '
        'gpdob
        '
        Me.gpdob.HeaderText = "Last Name"
        Me.gpdob.Name = "gpdob"
        Me.gpdob.ReadOnly = True
        Me.gpdob.Width = 250
        '
        'gpgender
        '
        Me.gpgender.HeaderText = "Rights"
        Me.gpgender.Name = "gpgender"
        Me.gpgender.ReadOnly = True
        Me.gpgender.Width = 230
        '
        'frmUserAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Admin"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gpUserData.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpUserData.Panel.ResumeLayout(False)
        Me.gpUserData.Panel.PerformLayout()
        CType(Me.gpUserData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpUserData.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.gridUserList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNew As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnEdit As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnShowAll As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents gpUserData As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gridUserList As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents chkActive As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAdmin As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents gpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpvisit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpgender As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
