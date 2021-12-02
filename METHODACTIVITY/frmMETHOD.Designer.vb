<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMETHOD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMETHOD))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgMethod = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RECID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.METHODACTIVITY = New System.Windows.Forms.TextBox()
        Me.ToolStripStatusLabel19 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnDev = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnExeCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel16 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnConnName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel17 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel18 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel15 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RbnBuildNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.XSEARCH = New System.Windows.Forms.TextBox()
        Me.BTSEARCHLINE = New System.Windows.Forms.Button()
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
        Me.isActive = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 534)
        Me.TabControl1.TabIndex = 123240
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgMethod)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgMethod
        '
        Me.dgMethod.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgMethod.AllowEditing = False
        Me.dgMethod.AllowFiltering = True
        Me.dgMethod.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.dgMethod.BackColor = System.Drawing.Color.White
        Me.dgMethod.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.dgMethod.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.dgMethod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgMethod.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgMethod.Location = New System.Drawing.Point(3, 103)
        Me.dgMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMethod.Name = "dgMethod"
        Me.dgMethod.Rows.DefaultSize = 21
        Me.dgMethod.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgMethod.Size = New System.Drawing.Size(919, 399)
        Me.dgMethod.StyleInfo = resources.GetString("dgMethod.StyleInfo")
        Me.dgMethod.TabIndex = 123235
        Me.dgMethod.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.isActive)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RECID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.METHODACTIVITY)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 100)
        Me.Panel1.TabIndex = 123242
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(107, 21)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(384, 1)
        Me.Panel12.TabIndex = 123247
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(16, 10)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(87, 17)
        Me.Label38.TabIndex = 123246
        Me.Label38.Text = "Identification"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(894, 2)
        Me.Panel2.TabIndex = 123245
        '
        'RECID
        '
        Me.RECID.Enabled = False
        Me.RECID.Location = New System.Drawing.Point(462, 41)
        Me.RECID.Name = "RECID"
        Me.RECID.Size = New System.Drawing.Size(106, 22)
        Me.RECID.TabIndex = 1
        Me.RECID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 123241
        Me.Label2.Text = "Method of Activity:"
        '
        'METHODACTIVITY
        '
        Me.METHODACTIVITY.Enabled = False
        Me.METHODACTIVITY.Location = New System.Drawing.Point(185, 41)
        Me.METHODACTIVITY.Name = "METHODACTIVITY"
        Me.METHODACTIVITY.Size = New System.Drawing.Size(262, 22)
        Me.METHODACTIVITY.TabIndex = 2
        '
        'ToolStripStatusLabel19
        '
        Me.ToolStripStatusLabel19.Name = "ToolStripStatusLabel19"
        Me.ToolStripStatusLabel19.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel19.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel7.Text = "|"
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel11.Text = "|"
        '
        'RbnDev
        '
        Me.RbnDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnDev.ForeColor = System.Drawing.Color.Black
        Me.RbnDev.Name = "RbnDev"
        Me.RbnDev.Size = New System.Drawing.Size(73, 19)
        Me.RbnDev.Text = "DevCode"
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel13.Text = "|"
        '
        'RbnExeCode
        '
        Me.RbnExeCode.Name = "RbnExeCode"
        Me.RbnExeCode.Size = New System.Drawing.Size(112, 19)
        Me.RbnExeCode.Text = "SubModuleCode"
        '
        'RbnStatus
        '
        Me.RbnStatus.Name = "RbnStatus"
        Me.RbnStatus.Size = New System.Drawing.Size(207, 19)
        Me.RbnStatus.Spring = True
        Me.RbnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RbnUser
        '
        Me.RbnUser.Name = "RbnUser"
        Me.RbnUser.Size = New System.Drawing.Size(47, 19)
        Me.RbnUser.Text = "Admin"
        '
        'ToolStripStatusLabel16
        '
        Me.ToolStripStatusLabel16.Name = "ToolStripStatusLabel16"
        Me.ToolStripStatusLabel16.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel16.Text = "|"
        '
        'RbnConnName
        '
        Me.RbnConnName.Name = "RbnConnName"
        Me.RbnConnName.Size = New System.Drawing.Size(35, 19)
        Me.RbnConnName.Text = "CoN"
        '
        'ToolStripStatusLabel17
        '
        Me.ToolStripStatusLabel17.Name = "ToolStripStatusLabel17"
        Me.ToolStripStatusLabel17.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel17.Text = "|"
        '
        'RbnCN
        '
        Me.RbnCN.Name = "RbnCN"
        Me.RbnCN.Size = New System.Drawing.Size(27, 19)
        Me.RbnCN.Text = "CN"
        '
        'ToolStripStatusLabel18
        '
        Me.ToolStripStatusLabel18.Name = "ToolStripStatusLabel18"
        Me.ToolStripStatusLabel18.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel18.Text = "|"
        '
        'RbnIP
        '
        Me.RbnIP.Name = "RbnIP"
        Me.RbnIP.Size = New System.Drawing.Size(20, 19)
        Me.RbnIP.Text = "IP"
        '
        'ToolStripStatusLabel15
        '
        Me.ToolStripStatusLabel15.Name = "ToolStripStatusLabel15"
        Me.ToolStripStatusLabel15.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel15.Text = "|"
        '
        'RbnCompany
        '
        Me.RbnCompany.Name = "RbnCompany"
        Me.RbnCompany.Size = New System.Drawing.Size(93, 19)
        Me.RbnCompany.Text = "RbnCompany"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo, Me.ToolStripStatusLabel7, Me.RbnExeCode, Me.ToolStripStatusLabel11, Me.RbnDev, Me.ToolStripStatusLabel13, Me.RbnStatus, Me.ToolStripStatusLabel15, Me.RbnUser, Me.ToolStripStatusLabel16, Me.RbnConnName, Me.ToolStripStatusLabel17, Me.RbnCN, Me.ToolStripStatusLabel18, Me.RbnIP, Me.ToolStripStatusLabel19, Me.RbnCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 626)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(933, 24)
        Me.StatusStrip1.TabIndex = 123239
        Me.StatusStrip1.Tag = "XC"
        Me.StatusStrip1.Text = "PROGEN 1.2.x as of DateTime"
        '
        'RbnBuildNo
        '
        Me.RbnBuildNo.Image = CType(resources.GetObject("RbnBuildNo.Image"), System.Drawing.Image)
        Me.RbnBuildNo.Name = "RbnBuildNo"
        Me.RbnBuildNo.Size = New System.Drawing.Size(211, 19)
        Me.RbnBuildNo.Text = "PROGEN 5.0 as of DateTime"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 28)
        Me.MenuStrip1.TabIndex = 123247
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CancelToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExportToExcelToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel8)
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
        Me.PanelHeader.Size = New System.Drawing.Size(933, 64)
        Me.PanelHeader.TabIndex = 123248
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.XSEARCH)
        Me.Panel8.Controls.Add(Me.BTSEARCHLINE)
        Me.Panel8.Location = New System.Drawing.Point(629, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(296, 43)
        Me.Panel8.TabIndex = 123156
        '
        'XSEARCH
        '
        Me.XSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.XSEARCH.Font = New System.Drawing.Font("Century Gothic", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XSEARCH.Location = New System.Drawing.Point(6, 10)
        Me.XSEARCH.Name = "XSEARCH"
        Me.XSEARCH.Size = New System.Drawing.Size(236, 24)
        Me.XSEARCH.TabIndex = 123147
        '
        'BTSEARCHLINE
        '
        Me.BTSEARCHLINE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTSEARCHLINE.BackColor = System.Drawing.Color.White
        Me.BTSEARCHLINE.FlatAppearance.BorderSize = 0
        Me.BTSEARCHLINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTSEARCHLINE.Image = CType(resources.GetObject("BTSEARCHLINE.Image"), System.Drawing.Image)
        Me.BTSEARCHLINE.Location = New System.Drawing.Point(255, 3)
        Me.BTSEARCHLINE.Name = "BTSEARCHLINE"
        Me.BTSEARCHLINE.Size = New System.Drawing.Size(38, 36)
        Me.BTSEARCHLINE.TabIndex = 123146
        Me.BTSEARCHLINE.UseVisualStyleBackColor = False
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
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(9, 13)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(38, 36)
        Me.btAdd.TabIndex = 3
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'bTpRINT
        '
        Me.bTpRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bTpRINT.Enabled = False
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
        Me.btCancelUpdate.TabIndex = 6
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
        Me.BtSave.TabIndex = 5
        Me.BtSave.UseVisualStyleBackColor = False
        '
        'BtRefresh
        '
        Me.BtRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtRefresh.FlatAppearance.BorderSize = 0
        Me.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRefresh.Image = CType(resources.GetObject("BtRefresh.Image"), System.Drawing.Image)
        Me.BtRefresh.Location = New System.Drawing.Point(293, 13)
        Me.BtRefresh.Name = "BtRefresh"
        Me.BtRefresh.Size = New System.Drawing.Size(38, 36)
        Me.BtRefresh.TabIndex = 8
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
        Me.BtDelete.FlatAppearance.BorderSize = 0
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDelete.Image = CType(resources.GetObject("BtDelete.Image"), System.Drawing.Image)
        Me.BtDelete.Location = New System.Drawing.Point(186, 13)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(38, 36)
        Me.BtDelete.TabIndex = 7
        Me.BtDelete.UseVisualStyleBackColor = False
        '
        'BtEdit
        '
        Me.BtEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtEdit.FlatAppearance.BorderSize = 0
        Me.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEdit.Image = CType(resources.GetObject("BtEdit.Image"), System.Drawing.Image)
        Me.BtEdit.Location = New System.Drawing.Point(55, 13)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(38, 36)
        Me.BtEdit.TabIndex = 4
        Me.BtEdit.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(933, 2)
        Me.Panel7.TabIndex = 8
        '
        'isActive
        '
        Me.isActive.Enabled = False
        Me.isActive.Location = New System.Drawing.Point(574, 41)
        Me.isActive.Name = "isActive"
        Me.isActive.Size = New System.Drawing.Size(106, 22)
        Me.isActive.TabIndex = 123248
        Me.isActive.Visible = False
        '
        'frmMETHOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMETHOD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "METHOD ACTIVITY"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents METHODACTIVITY As TextBox
    Friend WithEvents RECID As TextBox
    Friend WithEvents dgMethod As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStripStatusLabel19 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As ToolStripStatusLabel
    Friend WithEvents RbnDev As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As ToolStripStatusLabel
    Friend WithEvents RbnExeCode As ToolStripStatusLabel
    Friend WithEvents RbnStatus As ToolStripStatusLabel
    Friend WithEvents RbnUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel16 As ToolStripStatusLabel
    Friend WithEvents RbnConnName As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel17 As ToolStripStatusLabel
    Friend WithEvents RbnCN As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel18 As ToolStripStatusLabel
    Friend WithEvents RbnIP As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel15 As ToolStripStatusLabel
    Friend WithEvents RbnCompany As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RbnBuildNo As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents XSEARCH As TextBox
    Friend WithEvents BTSEARCHLINE As Button
    Friend WithEvents BTEXPORT As Button
    Friend WithEvents btAdd As Button
    Friend WithEvents bTpRINT As Button
    Friend WithEvents btCancelUpdate As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BtRefresh As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtDelete As Button
    Friend WithEvents BtEdit As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents isActive As TextBox
End Class
