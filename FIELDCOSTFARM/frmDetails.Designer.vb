<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetails))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BTEXPORT = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.bTpRINT = New System.Windows.Forms.Button()
        Me.btCancelUpdate = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtRefresh = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.LBLACTIVITY = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgFIELDCOSTDETAILS = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgFIELDCOSTDETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1200, 22)
        Me.StatusStrip1.TabIndex = 508
        Me.StatusStrip1.Tag = "XC"
        Me.StatusStrip1.Text = "PROGEN 1.2.x as of DateTime"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 28)
        Me.MenuStrip1.TabIndex = 509
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Enabled = False
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Enabled = False
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LinesToolStripMenuItem
        '
        Me.LinesToolStripMenuItem.Name = "LinesToolStripMenuItem"
        Me.LinesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LinesToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.LinesToolStripMenuItem.Text = "Lines"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.BTEXPORT)
        Me.PanelHeader.Controls.Add(Me.btAdd)
        Me.PanelHeader.Controls.Add(Me.bTpRINT)
        Me.PanelHeader.Controls.Add(Me.btCancelUpdate)
        Me.PanelHeader.Controls.Add(Me.BtSave)
        Me.PanelHeader.Controls.Add(Me.BtRefresh)
        Me.PanelHeader.Controls.Add(Me.Panel10)
        Me.PanelHeader.Controls.Add(Me.BtDelete)
        Me.PanelHeader.Controls.Add(Me.BtEdit)
        Me.PanelHeader.Controls.Add(Me.Panel7)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 28)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1200, 64)
        Me.PanelHeader.TabIndex = 510
        '
        'BTEXPORT
        '
        Me.BTEXPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTEXPORT.FlatAppearance.BorderSize = 0
        Me.BTEXPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTEXPORT.Image = CType(resources.GetObject("BTEXPORT.Image"), System.Drawing.Image)
        Me.BTEXPORT.Location = New System.Drawing.Point(337, 13)
        Me.BTEXPORT.Name = "BTEXPORT"
        Me.BTEXPORT.Size = New System.Drawing.Size(38, 36)
        Me.BTEXPORT.TabIndex = 123145
        Me.BTEXPORT.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAdd.Enabled = False
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(9, 13)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(38, 36)
        Me.btAdd.TabIndex = 123144
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'bTpRINT
        '
        Me.bTpRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bTpRINT.FlatAppearance.BorderSize = 0
        Me.bTpRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTpRINT.Image = CType(resources.GetObject("bTpRINT.Image"), System.Drawing.Image)
        Me.bTpRINT.Location = New System.Drawing.Point(249, 13)
        Me.bTpRINT.Name = "bTpRINT"
        Me.bTpRINT.Size = New System.Drawing.Size(38, 36)
        Me.bTpRINT.TabIndex = 123143
        Me.bTpRINT.UseVisualStyleBackColor = False
        '
        'btCancelUpdate
        '
        Me.btCancelUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCancelUpdate.Enabled = False
        Me.btCancelUpdate.FlatAppearance.BorderSize = 0
        Me.btCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelUpdate.Image = CType(resources.GetObject("btCancelUpdate.Image"), System.Drawing.Image)
        Me.btCancelUpdate.Location = New System.Drawing.Point(142, 13)
        Me.btCancelUpdate.Name = "btCancelUpdate"
        Me.btCancelUpdate.Size = New System.Drawing.Size(38, 36)
        Me.btCancelUpdate.TabIndex = 123140
        Me.btCancelUpdate.UseVisualStyleBackColor = False
        '
        'BtSave
        '
        Me.BtSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtSave.Enabled = False
        Me.BtSave.FlatAppearance.BorderSize = 0
        Me.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSave.Image = CType(resources.GetObject("BtSave.Image"), System.Drawing.Image)
        Me.BtSave.Location = New System.Drawing.Point(98, 13)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(38, 36)
        Me.BtSave.TabIndex = 123139
        Me.BtSave.UseVisualStyleBackColor = False
        '
        'BtRefresh
        '
        Me.BtRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtRefresh.Enabled = False
        Me.BtRefresh.FlatAppearance.BorderSize = 0
        Me.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRefresh.Image = CType(resources.GetObject("BtRefresh.Image"), System.Drawing.Image)
        Me.BtRefresh.Location = New System.Drawing.Point(293, 13)
        Me.BtRefresh.Name = "BtRefresh"
        Me.BtRefresh.Size = New System.Drawing.Size(38, 36)
        Me.BtRefresh.TabIndex = 123138
        Me.BtRefresh.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel10.Enabled = False
        Me.Panel10.Location = New System.Drawing.Point(236, 13)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(2, 32)
        Me.Panel10.TabIndex = 123137
        '
        'BtDelete
        '
        Me.BtDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtDelete.Enabled = False
        Me.BtDelete.FlatAppearance.BorderSize = 0
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDelete.Image = CType(resources.GetObject("BtDelete.Image"), System.Drawing.Image)
        Me.BtDelete.Location = New System.Drawing.Point(186, 13)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(38, 36)
        Me.BtDelete.TabIndex = 123136
        Me.BtDelete.UseVisualStyleBackColor = False
        '
        'BtEdit
        '
        Me.BtEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtEdit.Enabled = False
        Me.BtEdit.FlatAppearance.BorderSize = 0
        Me.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEdit.Image = CType(resources.GetObject("BtEdit.Image"), System.Drawing.Image)
        Me.BtEdit.Location = New System.Drawing.Point(55, 13)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(38, 36)
        Me.BtEdit.TabIndex = 123135
        Me.BtEdit.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1200, 2)
        Me.Panel7.TabIndex = 8
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.LBLACTIVITY)
        Me.Panel13.Controls.Add(Me.Label1)
        Me.Panel13.Controls.Add(Me.Panel12)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 92)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1200, 51)
        Me.Panel13.TabIndex = 123158
        '
        'LBLACTIVITY
        '
        Me.LBLACTIVITY.AutoSize = True
        Me.LBLACTIVITY.Location = New System.Drawing.Point(93, 15)
        Me.LBLACTIVITY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLACTIVITY.Name = "LBLACTIVITY"
        Me.LBLACTIVITY.Size = New System.Drawing.Size(68, 17)
        Me.LBLACTIVITY.TabIndex = 123160
        Me.LBLACTIVITY.Text = "ACTIVITY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 123157
        Me.Label1.Text = "ACTIVITY:"
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(16, 45)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1171, 2)
        Me.Panel12.TabIndex = 123156
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 143)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1200, 557)
        Me.TabControl1.TabIndex = 123159
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgFIELDCOSTDETAILS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1192, 528)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgFIELDCOSTDETAILS
        '
        Me.dgFIELDCOSTDETAILS.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgFIELDCOSTDETAILS.AllowEditing = False
        Me.dgFIELDCOSTDETAILS.AllowFiltering = True
        Me.dgFIELDCOSTDETAILS.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.dgFIELDCOSTDETAILS.BackColor = System.Drawing.Color.White
        Me.dgFIELDCOSTDETAILS.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.dgFIELDCOSTDETAILS.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.dgFIELDCOSTDETAILS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFIELDCOSTDETAILS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgFIELDCOSTDETAILS.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgFIELDCOSTDETAILS.Location = New System.Drawing.Point(0, 0)
        Me.dgFIELDCOSTDETAILS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgFIELDCOSTDETAILS.Name = "dgFIELDCOSTDETAILS"
        Me.dgFIELDCOSTDETAILS.Rows.DefaultSize = 21
        Me.dgFIELDCOSTDETAILS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgFIELDCOSTDETAILS.Size = New System.Drawing.Size(1192, 528)
        Me.dgFIELDCOSTDETAILS.StyleInfo = resources.GetString("dgFIELDCOSTDETAILS.StyleInfo")
        Me.dgFIELDCOSTDETAILS.TabIndex = 299
        Me.dgFIELDCOSTDETAILS.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 722)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIELD COST DETAILS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgFIELDCOSTDETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents BTEXPORT As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents bTpRINT As System.Windows.Forms.Button
    Friend WithEvents btCancelUpdate As System.Windows.Forms.Button
    Friend WithEvents BtSave As System.Windows.Forms.Button
    Friend WithEvents BtRefresh As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents BtDelete As System.Windows.Forms.Button
    Friend WithEvents BtEdit As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgFIELDCOSTDETAILS As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents LBLACTIVITY As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
End Class
