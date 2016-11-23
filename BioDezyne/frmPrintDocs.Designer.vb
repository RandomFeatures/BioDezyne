<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintDocs
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnPrint = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnOpen = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.chbDocList = New System.Windows.Forms.CheckedListBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PrintDiag = New System.Windows.Forms.PrintDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(611, 441)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnPrint, Me.btnOpen, Me.btnClose})
        Me.KryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonHeaderGroup1.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup1.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chbDocList)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(587, 417)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Select Documents"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Global.BioDezyne.My.Resources.Resources.fileopen
        '
        'btnPrint
        '
        Me.btnPrint.ExtraText = ""
        Me.btnPrint.Image = Nothing
        Me.btnPrint.Text = "Print Selected"
        Me.btnPrint.ToolTipImage = Nothing
        Me.btnPrint.UniqueName = "FD8496E3D556468BFD8496E3D556468B"
        '
        'btnOpen
        '
        Me.btnOpen.ExtraText = ""
        Me.btnOpen.Image = Nothing
        Me.btnOpen.Text = "Open Selected"
        Me.btnOpen.ToolTipImage = Nothing
        Me.btnOpen.UniqueName = "F6A61582C3A24862F6A61582C3A24862"
        '
        'btnClose
        '
        Me.btnClose.ExtraText = ""
        Me.btnClose.Image = Nothing
        Me.btnClose.Text = "Close"
        Me.btnClose.ToolTipImage = Nothing
        Me.btnClose.UniqueName = "7F293427F98B4E547F293427F98B4E54"
        Me.btnClose.Visible = False
        '
        'chbDocList
        '
        Me.chbDocList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbDocList.CheckOnClick = True
        Me.chbDocList.ColumnWidth = 225
        Me.chbDocList.FormattingEnabled = True
        Me.chbDocList.IntegralHeight = False
        Me.chbDocList.Location = New System.Drawing.Point(4, 7)
        Me.chbDocList.MultiColumn = True
        Me.chbDocList.Name = "chbDocList"
        Me.chbDocList.Size = New System.Drawing.Size(576, 349)
        Me.chbDocList.TabIndex = 0
        '
        'PrintDiag
        '
        Me.PrintDiag.AllowPrintToFile = False
        Me.PrintDiag.UseEXDialog = True
        '
        'frmPrintDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPrintDocs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Addition Documents"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnPrint As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents chbDocList As System.Windows.Forms.CheckedListBox
    Friend WithEvents PrintDiag As System.Windows.Forms.PrintDialog
    Friend WithEvents btnOpen As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
