<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDexaVerify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDexaVerify))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.Group2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gridDexaScan = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.gAnalysis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gscan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gSerialn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gsWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gscnid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Group1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gridDexaVisit = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.gpname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpvisit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpgender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpheight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpdexaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.Group2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group2.Panel.SuspendLayout()
        Me.Group2.SuspendLayout()
        CType(Me.gridDexaScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group1.Panel.SuspendLayout()
        Me.Group1.SuspendLayout()
        CType(Me.gridDexaVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Group2)
        Me.KryptonPanel.Controls.Add(Me.Group1)
        Me.KryptonPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(507, 310)
        Me.KryptonPanel.TabIndex = 0
        '
        'Group2
        '
        Me.Group2.Enabled = False
        Me.Group2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.Group2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.Group2.HeaderVisiblePrimary = False
        Me.Group2.Location = New System.Drawing.Point(6, 128)
        Me.Group2.Name = "Group2"
        '
        'Group2.Panel
        '
        Me.Group2.Panel.Controls.Add(Me.gridDexaScan)
        Me.Group2.Size = New System.Drawing.Size(488, 145)
        Me.Group2.TabIndex = 29
        Me.Group2.Text = "Heading"
        Me.Group2.ValuesPrimary.Description = ""
        Me.Group2.ValuesPrimary.Heading = "Heading"
        Me.Group2.ValuesPrimary.Image = CType(resources.GetObject("Group2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.Group2.ValuesSecondary.Description = ""
        Me.Group2.ValuesSecondary.Heading = "Please select correct scan by clicking on the row of the one you wish to use."
        Me.Group2.ValuesSecondary.Image = Nothing
        '
        'gridDexaScan
        '
        Me.gridDexaScan.AllowUserToAddRows = False
        Me.gridDexaScan.AllowUserToDeleteRows = False
        Me.gridDexaScan.AllowUserToResizeRows = False
        Me.gridDexaScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDexaScan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gAnalysis, Me.gscan, Me.gSerialn, Me.gsWeight, Me.gscnid})
        Me.gridDexaScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDexaScan.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridDexaScan.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDexaScan.HideOuterBorders = True
        Me.gridDexaScan.Location = New System.Drawing.Point(0, 0)
        Me.gridDexaScan.MultiSelect = False
        Me.gridDexaScan.Name = "gridDexaScan"
        Me.gridDexaScan.ReadOnly = True
        Me.gridDexaScan.RowHeadersVisible = False
        Me.gridDexaScan.RowTemplate.ReadOnly = True
        Me.gridDexaScan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDexaScan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridDexaScan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDexaScan.Size = New System.Drawing.Size(486, 126)
        Me.gridDexaScan.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDexaScan.TabIndex = 27
        '
        'gAnalysis
        '
        Me.gAnalysis.HeaderText = "Analysis Date"
        Me.gAnalysis.Name = "gAnalysis"
        Me.gAnalysis.ReadOnly = True
        '
        'gscan
        '
        Me.gscan.HeaderText = "Scan Date"
        Me.gscan.Name = "gscan"
        Me.gscan.ReadOnly = True
        '
        'gSerialn
        '
        Me.gSerialn.HeaderText = "Serial Number"
        Me.gSerialn.Name = "gSerialn"
        Me.gSerialn.ReadOnly = True
        '
        'gsWeight
        '
        Me.gsWeight.HeaderText = "Weight"
        Me.gsWeight.Name = "gsWeight"
        Me.gsWeight.ReadOnly = True
        '
        'gscnid
        '
        Me.gscnid.HeaderText = "Scan ID"
        Me.gscnid.Name = "gscnid"
        Me.gscnid.ReadOnly = True
        '
        'Group1
        '
        Me.Group1.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.Group1.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.Group1.HeaderVisiblePrimary = False
        Me.Group1.Location = New System.Drawing.Point(6, 4)
        Me.Group1.Name = "Group1"
        '
        'Group1.Panel
        '
        Me.Group1.Panel.Controls.Add(Me.gridDexaVisit)
        Me.Group1.Size = New System.Drawing.Size(489, 118)
        Me.Group1.TabIndex = 28
        Me.Group1.Text = "Heading"
        Me.Group1.ValuesPrimary.Description = ""
        Me.Group1.ValuesPrimary.Heading = "Heading"
        Me.Group1.ValuesPrimary.Image = CType(resources.GetObject("Group1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.Group1.ValuesSecondary.Description = ""
        Me.Group1.ValuesSecondary.Heading = "Please select a patient by clicking on the row of the one you  wish to use."
        Me.Group1.ValuesSecondary.Image = Nothing
        '
        'gridDexaVisit
        '
        Me.gridDexaVisit.AllowUserToAddRows = False
        Me.gridDexaVisit.AllowUserToDeleteRows = False
        Me.gridDexaVisit.AllowUserToResizeRows = False
        Me.gridDexaVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDexaVisit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpname, Me.gpvisit, Me.gpdob, Me.gpgender, Me.gpWeight, Me.gpheight, Me.gpdexaid})
        Me.gridDexaVisit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDexaVisit.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.gridDexaVisit.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDexaVisit.HideOuterBorders = True
        Me.gridDexaVisit.Location = New System.Drawing.Point(0, 0)
        Me.gridDexaVisit.MultiSelect = False
        Me.gridDexaVisit.Name = "gridDexaVisit"
        Me.gridDexaVisit.ReadOnly = True
        Me.gridDexaVisit.RowHeadersVisible = False
        Me.gridDexaVisit.RowTemplate.ReadOnly = True
        Me.gridDexaVisit.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDexaVisit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridDexaVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDexaVisit.Size = New System.Drawing.Size(487, 99)
        Me.gridDexaVisit.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1
        Me.gridDexaVisit.TabIndex = 22
        '
        'gpname
        '
        Me.gpname.HeaderText = "Name"
        Me.gpname.Name = "gpname"
        Me.gpname.ReadOnly = True
        Me.gpname.Width = 102
        '
        'gpvisit
        '
        Me.gpvisit.HeaderText = "Visit Date"
        Me.gpvisit.Name = "gpvisit"
        Me.gpvisit.ReadOnly = True
        '
        'gpdob
        '
        Me.gpdob.HeaderText = "Date of Birth"
        Me.gpdob.Name = "gpdob"
        Me.gpdob.ReadOnly = True
        '
        'gpgender
        '
        Me.gpgender.HeaderText = "Gender"
        Me.gpgender.Name = "gpgender"
        Me.gpgender.ReadOnly = True
        Me.gpgender.Width = 75
        '
        'gpWeight
        '
        Me.gpWeight.HeaderText = "Weight"
        Me.gpWeight.Name = "gpWeight"
        Me.gpWeight.ReadOnly = True
        Me.gpWeight.Width = 50
        '
        'gpheight
        '
        Me.gpheight.HeaderText = "Height"
        Me.gpheight.Name = "gpheight"
        Me.gpheight.ReadOnly = True
        Me.gpheight.Width = 60
        '
        'gpdexaid
        '
        Me.gpdexaid.HeaderText = "dexaID"
        Me.gpdexaid.Name = "gpdexaid"
        Me.gpdexaid.ReadOnly = True
        Me.gpdexaid.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 279)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(507, 31)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(208, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "Close"
        Me.btnOK.Values.ExtraText = ""
        Me.btnOK.Values.Image = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOK.Values.Text = "Close"
        '
        'frmDexaVerify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDexaVerify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dexa Patient Verification"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.Group2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group2.Panel.ResumeLayout(False)
        CType(Me.Group2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group2.ResumeLayout(False)
        CType(Me.gridDexaScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.Panel.ResumeLayout(False)
        CType(Me.Group1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        CType(Me.gridDexaVisit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Group1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Group2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents gridDexaScan As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gAnalysis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gscan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gSerialn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gsWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gscnid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridDexaVisit As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents gpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpvisit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpgender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpheight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpdexaid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
