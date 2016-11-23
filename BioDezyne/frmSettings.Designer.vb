<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.chkDexa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnDexa = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtDexa = New RFIControls.TextPlus
        Me.btnclose = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtWeb = New RFIControls.TextPlus
        Me.lbl2312 = New System.Windows.Forms.Label
        Me.lbl22 = New System.Windows.Forms.Label
        Me.lable33 = New System.Windows.Forms.Label
        Me.txtPhone = New RFIControls.TextPlus
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSlogan = New RFIControls.TextPlus
        Me.txtAddress = New RFIControls.TextPlus
        Me.txtFax = New RFIControls.TextPlus
        Me.txtName = New RFIControls.TextPlus
        Me.lbl332 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnLog = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton
        Me.btnRequire = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.btnclose)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup3)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(382, 508)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(20, 377)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.chkDexa)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnDexa)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtDexa)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(343, 88)
        Me.KryptonHeaderGroup2.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup2.TabIndex = 5
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Dexa Database"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'chkDexa
        '
        Me.chkDexa.Checked = False
        Me.chkDexa.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDexa.Location = New System.Drawing.Point(10, 13)
        Me.chkDexa.Name = "chkDexa"
        Me.chkDexa.Size = New System.Drawing.Size(153, 16)
        Me.chkDexa.TabIndex = 4
        Me.chkDexa.Text = "Use Dexa Scan Database"
        Me.chkDexa.Values.ExtraText = ""
        Me.chkDexa.Values.Image = Nothing
        Me.chkDexa.Values.Text = "Use Dexa Scan Database"
        '
        'btnDexa
        '
        Me.btnDexa.Enabled = False
        Me.btnDexa.Location = New System.Drawing.Point(254, 33)
        Me.btnDexa.Name = "btnDexa"
        Me.btnDexa.Size = New System.Drawing.Size(75, 25)
        Me.btnDexa.TabIndex = 3
        Me.btnDexa.Text = "Locate Dexa"
        Me.btnDexa.Values.ExtraText = ""
        Me.btnDexa.Values.Image = Nothing
        Me.btnDexa.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnDexa.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnDexa.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnDexa.Values.Text = "Locate Dexa"
        '
        'txtDexa
        '
        Me.txtDexa.Enabled = False
        Me.txtDexa.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtDexa.FocusFontColor = System.Drawing.Color.Blue
        Me.txtDexa.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtDexa.Location = New System.Drawing.Point(10, 35)
        Me.txtDexa.Name = "txtDexa"
        Me.txtDexa.Size = New System.Drawing.Size(238, 20)
        Me.txtDexa.TabIndex = 2
        Me.txtDexa.TabOnEnter = False
        Me.txtDexa.TextType = RFIControls.enumTextType.Normal
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(146, 471)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(90, 25)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.Values.ExtraText = ""
        Me.btnclose.Values.Image = Nothing
        Me.btnclose.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnclose.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnclose.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnclose.Values.Text = "Close"
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup3.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(20, 79)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtWeb)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.lbl2312)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.lbl22)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.lable33)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtPhone)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtSlogan)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtAddress)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtFax)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtName)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.lbl332)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(343, 292)
        Me.KryptonHeaderGroup3.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup3.TabIndex = 2
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Clinic Contact Info"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'txtWeb
        '
        Me.txtWeb.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtWeb.FocusFontColor = System.Drawing.Color.Blue
        Me.txtWeb.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtWeb.Location = New System.Drawing.Point(12, 237)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(317, 20)
        Me.txtWeb.TabIndex = 6
        Me.txtWeb.TabOnEnter = False
        Me.txtWeb.TextType = RFIControls.enumTextType.Normal
        '
        'lbl2312
        '
        Me.lbl2312.BackColor = System.Drawing.Color.Transparent
        Me.lbl2312.Location = New System.Drawing.Point(9, 217)
        Me.lbl2312.Name = "lbl2312"
        Me.lbl2312.Size = New System.Drawing.Size(82, 17)
        Me.lbl2312.TabIndex = 16
        Me.lbl2312.Text = "Home Page"
        Me.lbl2312.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl22
        '
        Me.lbl22.BackColor = System.Drawing.Color.Transparent
        Me.lbl22.Location = New System.Drawing.Point(9, 174)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(82, 17)
        Me.lbl22.TabIndex = 12
        Me.lbl22.Text = "Phone"
        Me.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lable33
        '
        Me.lable33.BackColor = System.Drawing.Color.Transparent
        Me.lable33.Location = New System.Drawing.Point(9, 93)
        Me.lable33.Name = "lable33"
        Me.lable33.Size = New System.Drawing.Size(82, 17)
        Me.lable33.TabIndex = 14
        Me.lable33.Text = "Address"
        Me.lable33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhone
        '
        Me.txtPhone.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtPhone.FocusFontColor = System.Drawing.Color.Blue
        Me.txtPhone.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtPhone.Location = New System.Drawing.Point(12, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 20)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.TabOnEnter = False
        Me.txtPhone.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Slogan (opional)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSlogan
        '
        Me.txtSlogan.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtSlogan.FocusFontColor = System.Drawing.Color.Blue
        Me.txtSlogan.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtSlogan.Location = New System.Drawing.Point(12, 70)
        Me.txtSlogan.Name = "txtSlogan"
        Me.txtSlogan.Size = New System.Drawing.Size(317, 20)
        Me.txtSlogan.TabIndex = 2
        Me.txtSlogan.TabOnEnter = False
        Me.txtSlogan.TextType = RFIControls.enumTextType.Normal
        '
        'txtAddress
        '
        Me.txtAddress.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtAddress.FocusFontColor = System.Drawing.Color.Blue
        Me.txtAddress.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtAddress.Location = New System.Drawing.Point(12, 113)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(317, 58)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.TabOnEnter = False
        Me.txtAddress.TextType = RFIControls.enumTextType.Normal
        '
        'txtFax
        '
        Me.txtFax.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtFax.FocusFontColor = System.Drawing.Color.Blue
        Me.txtFax.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtFax.Location = New System.Drawing.Point(179, 194)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(150, 20)
        Me.txtFax.TabIndex = 5
        Me.txtFax.TabOnEnter = False
        Me.txtFax.TextType = RFIControls.enumTextType.NumbersOnly
        '
        'txtName
        '
        Me.txtName.FocusBGColor = System.Drawing.Color.LightYellow
        Me.txtName.FocusFontColor = System.Drawing.Color.Blue
        Me.txtName.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtName.Location = New System.Drawing.Point(12, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(317, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.TabOnEnter = False
        Me.txtName.TextType = RFIControls.enumTextType.Normal
        '
        'lbl332
        '
        Me.lbl332.BackColor = System.Drawing.Color.Transparent
        Me.lbl332.Location = New System.Drawing.Point(176, 174)
        Me.lbl332.Name = "lbl332"
        Me.lbl332.Size = New System.Drawing.Size(82, 17)
        Me.lbl332.TabIndex = 13
        Me.lbl332.Text = "Fax"
        Me.lbl332.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup1.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(20, 12)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnLog)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnRequire)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(343, 61)
        Me.KryptonHeaderGroup1.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeaderGroup1.TabIndex = 3
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Login Options"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnLog
        '
        Me.btnLog.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnLog.Checked = True
        Me.btnLog.Enabled = False
        Me.btnLog.Location = New System.Drawing.Point(179, 7)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(134, 25)
        Me.btnLog.TabIndex = 1
        Me.btnLog.Text = "Log System Events"
        Me.btnLog.Values.ExtraText = ""
        Me.btnLog.Values.Image = Nothing
        Me.btnLog.Values.Text = "Log System Events"
        '
        'btnRequire
        '
        Me.btnRequire.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnRequire.Checked = True
        Me.btnRequire.Location = New System.Drawing.Point(28, 7)
        Me.btnRequire.Name = "btnRequire"
        Me.btnRequire.Size = New System.Drawing.Size(134, 25)
        Me.btnRequire.TabIndex = 0
        Me.btnRequire.Text = "Require User Logins"
        Me.btnRequire.Values.ExtraText = ""
        Me.btnRequire.Values.Image = Nothing
        Me.btnRequire.Values.Text = "Require User Logins"
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "Dexa Database| *.mdb"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Settings"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lbl22 As System.Windows.Forms.Label
    Friend WithEvents lable33 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As RFIControls.TextPlus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSlogan As RFIControls.TextPlus
    Friend WithEvents txtAddress As RFIControls.TextPlus
    Friend WithEvents txtFax As RFIControls.TextPlus
    Friend WithEvents lbl332 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeb As RFIControls.TextPlus
    Friend WithEvents lbl2312 As System.Windows.Forms.Label
    Friend WithEvents txtName As RFIControls.TextPlus
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnLog As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents btnRequire As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents btnclose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnDexa As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtDexa As RFIControls.TextPlus
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkDexa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
