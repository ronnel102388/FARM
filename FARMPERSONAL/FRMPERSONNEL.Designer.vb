<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPERSONNEL
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPERSONNEL))
        Me.PANELHEADER = New System.Windows.Forms.Panel()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RbnBuildNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnExeCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnDev = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel15 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel16 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnConnName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel17 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel18 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel19 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PANELBORDERFOOTER = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGFIELDS = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.XSELECTALL = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNZOOMIN = New System.Windows.Forms.Button()
        Me.BTNZOOMOUT = New System.Windows.Forms.Button()
        Me.PANELLINEAFTERFILTER = New System.Windows.Forms.Panel()
        Me.XFARMASSISTANT = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XFARMMANAGER = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.XNUMROWS = New System.Windows.Forms.NumericUpDown()
        Me.BTNSELECTTOP = New System.Windows.Forms.Button()
        Me.XROWS = New System.Windows.Forms.Label()
        Me.PANELHEADER.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGFIELDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.XNUMROWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PANELHEADER
        '
        Me.PANELHEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PANELHEADER.Controls.Add(Me.Panel8)
        Me.PANELHEADER.Controls.Add(Me.BTEXPORT)
        Me.PANELHEADER.Controls.Add(Me.btAdd)
        Me.PANELHEADER.Controls.Add(Me.bTpRINT)
        Me.PANELHEADER.Controls.Add(Me.btCancelUpdate)
        Me.PANELHEADER.Controls.Add(Me.BtSave)
        Me.PANELHEADER.Controls.Add(Me.BtRefresh)
        Me.PANELHEADER.Controls.Add(Me.Panel10)
        Me.PANELHEADER.Controls.Add(Me.BtDelete)
        Me.PANELHEADER.Controls.Add(Me.BtEdit)
        Me.PANELHEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.PANELHEADER.Location = New System.Drawing.Point(0, 28)
        Me.PANELHEADER.Name = "PANELHEADER"
        Me.PANELHEADER.Size = New System.Drawing.Size(1251, 73)
        Me.PANELHEADER.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.XSEARCH)
        Me.Panel8.Controls.Add(Me.BTSEARCHLINE)
        Me.Panel8.Location = New System.Drawing.Point(865, 14)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(367, 43)
        Me.Panel8.TabIndex = 123155
        Me.ToolTip1.SetToolTip(Me.Panel8, "Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sub Field," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cluster," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Province," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Municipality and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barangay Here...")
        '
        'XSEARCH
        '
        Me.XSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.XSEARCH.Font = New System.Drawing.Font("Century Gothic", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XSEARCH.Location = New System.Drawing.Point(6, 10)
        Me.XSEARCH.Name = "XSEARCH"
        Me.XSEARCH.Size = New System.Drawing.Size(317, 24)
        Me.XSEARCH.TabIndex = 123147
        Me.ToolTip1.SetToolTip(Me.XSEARCH, "Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sub Field," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cluster," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Province," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Municipality and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barangay Here...")
        '
        'BTSEARCHLINE
        '
        Me.BTSEARCHLINE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTSEARCHLINE.BackColor = System.Drawing.Color.White
        Me.BTSEARCHLINE.FlatAppearance.BorderSize = 0
        Me.BTSEARCHLINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTSEARCHLINE.Image = CType(resources.GetObject("BTSEARCHLINE.Image"), System.Drawing.Image)
        Me.BTSEARCHLINE.Location = New System.Drawing.Point(326, 3)
        Me.BTSEARCHLINE.Name = "BTSEARCHLINE"
        Me.BTSEARCHLINE.Size = New System.Drawing.Size(38, 36)
        Me.BTSEARCHLINE.TabIndex = 123146
        Me.ToolTip1.SetToolTip(Me.BTSEARCHLINE, "Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sub Field," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cluster," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Province," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Municipality and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barangay Here...")
        Me.BTSEARCHLINE.UseVisualStyleBackColor = False
        '
        'BTEXPORT
        '
        Me.BTEXPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTEXPORT.FlatAppearance.BorderSize = 0
        Me.BTEXPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTEXPORT.Image = CType(resources.GetObject("BTEXPORT.Image"), System.Drawing.Image)
        Me.BTEXPORT.Location = New System.Drawing.Point(340, 19)
        Me.BTEXPORT.Name = "BTEXPORT"
        Me.BTEXPORT.Size = New System.Drawing.Size(38, 36)
        Me.BTEXPORT.TabIndex = 123154
        Me.ToolTip1.SetToolTip(Me.BTEXPORT, "Export to Excel")
        Me.BTEXPORT.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAdd.Enabled = False
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(12, 19)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(38, 36)
        Me.btAdd.TabIndex = 123153
        Me.ToolTip1.SetToolTip(Me.btAdd, "Add")
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'bTpRINT
        '
        Me.bTpRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bTpRINT.Enabled = False
        Me.bTpRINT.FlatAppearance.BorderSize = 0
        Me.bTpRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTpRINT.Image = CType(resources.GetObject("bTpRINT.Image"), System.Drawing.Image)
        Me.bTpRINT.Location = New System.Drawing.Point(252, 19)
        Me.bTpRINT.Name = "bTpRINT"
        Me.bTpRINT.Size = New System.Drawing.Size(38, 36)
        Me.bTpRINT.TabIndex = 123152
        Me.ToolTip1.SetToolTip(Me.bTpRINT, "Print")
        Me.bTpRINT.UseVisualStyleBackColor = False
        '
        'btCancelUpdate
        '
        Me.btCancelUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCancelUpdate.FlatAppearance.BorderSize = 0
        Me.btCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelUpdate.Image = CType(resources.GetObject("btCancelUpdate.Image"), System.Drawing.Image)
        Me.btCancelUpdate.Location = New System.Drawing.Point(145, 19)
        Me.btCancelUpdate.Name = "btCancelUpdate"
        Me.btCancelUpdate.Size = New System.Drawing.Size(38, 36)
        Me.btCancelUpdate.TabIndex = 123151
        Me.ToolTip1.SetToolTip(Me.btCancelUpdate, "Cancel")
        Me.btCancelUpdate.UseVisualStyleBackColor = False
        '
        'BtSave
        '
        Me.BtSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtSave.Enabled = False
        Me.BtSave.FlatAppearance.BorderSize = 0
        Me.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSave.Image = CType(resources.GetObject("BtSave.Image"), System.Drawing.Image)
        Me.BtSave.Location = New System.Drawing.Point(101, 19)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(38, 36)
        Me.BtSave.TabIndex = 123150
        Me.ToolTip1.SetToolTip(Me.BtSave, "Save")
        Me.BtSave.UseVisualStyleBackColor = False
        '
        'BtRefresh
        '
        Me.BtRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtRefresh.Enabled = False
        Me.BtRefresh.FlatAppearance.BorderSize = 0
        Me.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRefresh.Image = CType(resources.GetObject("BtRefresh.Image"), System.Drawing.Image)
        Me.BtRefresh.Location = New System.Drawing.Point(296, 19)
        Me.BtRefresh.Name = "BtRefresh"
        Me.BtRefresh.Size = New System.Drawing.Size(38, 36)
        Me.BtRefresh.TabIndex = 123149
        Me.ToolTip1.SetToolTip(Me.BtRefresh, "Refresh")
        Me.BtRefresh.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel10.Enabled = False
        Me.Panel10.Location = New System.Drawing.Point(239, 19)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(2, 32)
        Me.Panel10.TabIndex = 123148
        '
        'BtDelete
        '
        Me.BtDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtDelete.Enabled = False
        Me.BtDelete.FlatAppearance.BorderSize = 0
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDelete.Image = CType(resources.GetObject("BtDelete.Image"), System.Drawing.Image)
        Me.BtDelete.Location = New System.Drawing.Point(189, 19)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(38, 36)
        Me.BtDelete.TabIndex = 123147
        Me.ToolTip1.SetToolTip(Me.BtDelete, "Delete")
        Me.BtDelete.UseVisualStyleBackColor = False
        '
        'BtEdit
        '
        Me.BtEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtEdit.FlatAppearance.BorderSize = 0
        Me.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEdit.Image = CType(resources.GetObject("BtEdit.Image"), System.Drawing.Image)
        Me.BtEdit.Location = New System.Drawing.Point(58, 19)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(38, 36)
        Me.BtEdit.TabIndex = 123146
        Me.ToolTip1.SetToolTip(Me.BtEdit, "Edit")
        Me.BtEdit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1251, 28)
        Me.MenuStrip1.TabIndex = 1
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo, Me.ToolStripStatusLabel7, Me.RbnExeCode, Me.ToolStripStatusLabel11, Me.RbnDev, Me.ToolStripStatusLabel13, Me.RbnStatus, Me.ToolStripStatusLabel15, Me.RbnUser, Me.ToolStripStatusLabel16, Me.RbnConnName, Me.ToolStripStatusLabel17, Me.RbnCN, Me.ToolStripStatusLabel18, Me.RbnIP, Me.ToolStripStatusLabel19, Me.RbnCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 722)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1251, 24)
        Me.StatusStrip1.TabIndex = 244
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
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel7.Text = "|"
        '
        'RbnExeCode
        '
        Me.RbnExeCode.Name = "RbnExeCode"
        Me.RbnExeCode.Size = New System.Drawing.Size(112, 19)
        Me.RbnExeCode.Text = "SubModuleCode"
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
        'RbnStatus
        '
        Me.RbnStatus.Name = "RbnStatus"
        Me.RbnStatus.Size = New System.Drawing.Size(525, 19)
        Me.RbnStatus.Spring = True
        Me.RbnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel15
        '
        Me.ToolStripStatusLabel15.Name = "ToolStripStatusLabel15"
        Me.ToolStripStatusLabel15.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel15.Text = "|"
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
        'ToolStripStatusLabel19
        '
        Me.ToolStripStatusLabel19.Name = "ToolStripStatusLabel19"
        Me.ToolStripStatusLabel19.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel19.Text = "|"
        '
        'RbnCompany
        '
        Me.RbnCompany.Name = "RbnCompany"
        Me.RbnCompany.Size = New System.Drawing.Size(93, 19)
        Me.RbnCompany.Text = "RbnCompany"
        '
        'PANELBORDERFOOTER
        '
        Me.PANELBORDERFOOTER.BackColor = System.Drawing.Color.DimGray
        Me.PANELBORDERFOOTER.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PANELBORDERFOOTER.Location = New System.Drawing.Point(0, 720)
        Me.PANELBORDERFOOTER.Name = "PANELBORDERFOOTER"
        Me.PANELBORDERFOOTER.Size = New System.Drawing.Size(1251, 2)
        Me.PANELBORDERFOOTER.TabIndex = 245
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 159)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1251, 561)
        Me.TabControl1.TabIndex = 123160
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGFIELDS)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1243, 532)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGFIELDS
        '
        Me.DGFIELDS.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DGFIELDS.AllowFiltering = True
        Me.DGFIELDS.BackColor = System.Drawing.Color.White
        Me.DGFIELDS.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DGFIELDS.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.DGFIELDS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGFIELDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGFIELDS.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.DGFIELDS.Location = New System.Drawing.Point(0, 38)
        Me.DGFIELDS.Margin = New System.Windows.Forms.Padding(4)
        Me.DGFIELDS.Name = "DGFIELDS"
        Me.DGFIELDS.Rows.DefaultSize = 21
        Me.DGFIELDS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DGFIELDS.Size = New System.Drawing.Size(1243, 494)
        Me.DGFIELDS.StyleInfo = resources.GetString("DGFIELDS.StyleInfo")
        Me.DGFIELDS.TabIndex = 300
        Me.DGFIELDS.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.XROWS)
        Me.Panel2.Controls.Add(Me.BTNSELECTTOP)
        Me.Panel2.Controls.Add(Me.XNUMROWS)
        Me.Panel2.Controls.Add(Me.XSELECTALL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1243, 38)
        Me.Panel2.TabIndex = 301
        '
        'XSELECTALL
        '
        Me.XSELECTALL.AutoSize = True
        Me.XSELECTALL.Location = New System.Drawing.Point(12, 10)
        Me.XSELECTALL.Name = "XSELECTALL"
        Me.XSELECTALL.Size = New System.Drawing.Size(117, 21)
        Me.XSELECTALL.TabIndex = 0
        Me.XSELECTALL.Text = "SELECT TOP "
        Me.XSELECTALL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTNZOOMIN)
        Me.Panel1.Controls.Add(Me.BTNZOOMOUT)
        Me.Panel1.Controls.Add(Me.PANELLINEAFTERFILTER)
        Me.Panel1.Controls.Add(Me.XFARMASSISTANT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.XFARMMANAGER)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 58)
        Me.Panel1.TabIndex = 123161
        '
        'BTNZOOMIN
        '
        Me.BTNZOOMIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNZOOMIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTNZOOMIN.FlatAppearance.BorderSize = 0
        Me.BTNZOOMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNZOOMIN.Image = CType(resources.GetObject("BTNZOOMIN.Image"), System.Drawing.Image)
        Me.BTNZOOMIN.Location = New System.Drawing.Point(1203, 11)
        Me.BTNZOOMIN.Name = "BTNZOOMIN"
        Me.BTNZOOMIN.Size = New System.Drawing.Size(38, 36)
        Me.BTNZOOMIN.TabIndex = 123156
        Me.ToolTip1.SetToolTip(Me.BTNZOOMIN, "Zoom Out")
        Me.BTNZOOMIN.UseVisualStyleBackColor = False
        Me.BTNZOOMIN.Visible = False
        '
        'BTNZOOMOUT
        '
        Me.BTNZOOMOUT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNZOOMOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTNZOOMOUT.FlatAppearance.BorderSize = 0
        Me.BTNZOOMOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNZOOMOUT.Image = CType(resources.GetObject("BTNZOOMOUT.Image"), System.Drawing.Image)
        Me.BTNZOOMOUT.Location = New System.Drawing.Point(1159, 11)
        Me.BTNZOOMOUT.Name = "BTNZOOMOUT"
        Me.BTNZOOMOUT.Size = New System.Drawing.Size(38, 36)
        Me.BTNZOOMOUT.TabIndex = 123155
        Me.ToolTip1.SetToolTip(Me.BTNZOOMOUT, "Zoom In")
        Me.BTNZOOMOUT.UseVisualStyleBackColor = False
        Me.BTNZOOMOUT.Visible = False
        '
        'PANELLINEAFTERFILTER
        '
        Me.PANELLINEAFTERFILTER.BackColor = System.Drawing.Color.DimGray
        Me.PANELLINEAFTERFILTER.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PANELLINEAFTERFILTER.Location = New System.Drawing.Point(0, 56)
        Me.PANELLINEAFTERFILTER.Name = "PANELLINEAFTERFILTER"
        Me.PANELLINEAFTERFILTER.Size = New System.Drawing.Size(1251, 2)
        Me.PANELLINEAFTERFILTER.TabIndex = 4
        '
        'XFARMASSISTANT
        '
        Me.XFARMASSISTANT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.XFARMASSISTANT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.XFARMASSISTANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.26957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XFARMASSISTANT.FormattingEnabled = True
        Me.XFARMASSISTANT.Location = New System.Drawing.Point(755, 14)
        Me.XFARMASSISTANT.Name = "XFARMASSISTANT"
        Me.XFARMASSISTANT.Size = New System.Drawing.Size(335, 30)
        Me.XFARMASSISTANT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.26957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FARM ASSISTANT :"
        '
        'XFARMMANAGER
        '
        Me.XFARMMANAGER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.XFARMMANAGER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.XFARMMANAGER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.26957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XFARMMANAGER.FormattingEnabled = True
        Me.XFARMMANAGER.Location = New System.Drawing.Point(194, 14)
        Me.XFARMMANAGER.Name = "XFARMMANAGER"
        Me.XFARMMANAGER.Size = New System.Drawing.Size(352, 30)
        Me.XFARMMANAGER.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.26957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FARM MANAGER :"
        '
        'XNUMROWS
        '
        Me.XNUMROWS.Location = New System.Drawing.Point(128, 9)
        Me.XNUMROWS.Name = "XNUMROWS"
        Me.XNUMROWS.Size = New System.Drawing.Size(56, 22)
        Me.XNUMROWS.TabIndex = 1
        Me.XNUMROWS.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'BTNSELECTTOP
        '
        Me.BTNSELECTTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTNSELECTTOP.FlatAppearance.BorderSize = 0
        Me.BTNSELECTTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSELECTTOP.Image = CType(resources.GetObject("BTNSELECTTOP.Image"), System.Drawing.Image)
        Me.BTNSELECTTOP.Location = New System.Drawing.Point(197, 1)
        Me.BTNSELECTTOP.Name = "BTNSELECTTOP"
        Me.BTNSELECTTOP.Size = New System.Drawing.Size(38, 36)
        Me.BTNSELECTTOP.TabIndex = 123156
        Me.ToolTip1.SetToolTip(Me.BTNSELECTTOP, "Proceed Selection")
        Me.BTNSELECTTOP.UseVisualStyleBackColor = False
        '
        'XROWS
        '
        Me.XROWS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XROWS.Location = New System.Drawing.Point(979, 8)
        Me.XROWS.Name = "XROWS"
        Me.XROWS.Size = New System.Drawing.Size(252, 21)
        Me.XROWS.TabIndex = 123157
        Me.XROWS.Text = "(0) TOTAL ROWS"
        Me.XROWS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMPERSONNEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 746)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PANELBORDERFOOTER)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PANELHEADER)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMPERSONNEL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farm Personnel Tagging"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PANELHEADER.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGFIELDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.XNUMROWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PANELHEADER As Panel
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RbnBuildNo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents RbnExeCode As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As ToolStripStatusLabel
    Friend WithEvents RbnDev As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As ToolStripStatusLabel
    Friend WithEvents RbnStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel15 As ToolStripStatusLabel
    Friend WithEvents RbnUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel16 As ToolStripStatusLabel
    Friend WithEvents RbnConnName As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel17 As ToolStripStatusLabel
    Friend WithEvents RbnCN As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel18 As ToolStripStatusLabel
    Friend WithEvents RbnIP As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel19 As ToolStripStatusLabel
    Friend WithEvents RbnCompany As ToolStripStatusLabel
    Friend WithEvents PANELBORDERFOOTER As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGFIELDS As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents XFARMASSISTANT As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents XFARMMANAGER As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PANELLINEAFTERFILTER As Panel
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTNZOOMIN As Button
    Friend WithEvents BTNZOOMOUT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents XSELECTALL As CheckBox
    Friend WithEvents BTNSELECTTOP As Button
    Friend WithEvents XNUMROWS As NumericUpDown
    Friend WithEvents XROWS As Label
End Class
