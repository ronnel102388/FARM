<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMWORKORDERDASHBOARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMWORKORDERDASHBOARD))
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnConnName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel14 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnDev = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xrecordcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FilterDGV = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOpenNWO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RbnExeCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.xsearch = New System.Windows.Forms.TextBox()
        Me.btSearch = New System.Windows.Forms.Button()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RbnBuildNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuscheck = New System.Windows.Forms.TextBox()
        Me.TabPage1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'RbnStatus
        '
        Me.RbnStatus.Name = "RbnStatus"
        Me.RbnStatus.Size = New System.Drawing.Size(576, 19)
        Me.RbnStatus.Spring = True
        Me.RbnStatus.Text = "Status"
        Me.RbnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel8.Text = "|"
        '
        'RbnUser
        '
        Me.RbnUser.Name = "RbnUser"
        Me.RbnUser.Size = New System.Drawing.Size(47, 19)
        Me.RbnUser.Text = "Admin"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel10.Text = "|"
        '
        'RbnConnName
        '
        Me.RbnConnName.Name = "RbnConnName"
        Me.RbnConnName.Size = New System.Drawing.Size(35, 19)
        Me.RbnConnName.Text = "CoN"
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel12.Text = "|"
        '
        'RbnCN
        '
        Me.RbnCN.Name = "RbnCN"
        Me.RbnCN.Size = New System.Drawing.Size(27, 19)
        Me.RbnCN.Text = "CN"
        '
        'ToolStripStatusLabel14
        '
        Me.ToolStripStatusLabel14.Name = "ToolStripStatusLabel14"
        Me.ToolStripStatusLabel14.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel14.Text = "|"
        '
        'RbnIP
        '
        Me.RbnIP.Name = "RbnIP"
        Me.RbnIP.Size = New System.Drawing.Size(20, 19)
        Me.RbnIP.Text = "IP"
        '
        'RbnDev
        '
        Me.RbnDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnDev.ForeColor = System.Drawing.Color.Red
        Me.RbnDev.Name = "RbnDev"
        Me.RbnDev.Size = New System.Drawing.Size(73, 19)
        Me.RbnDev.Text = "DevCode"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'xrecordcount
        '
        Me.xrecordcount.Name = "xrecordcount"
        Me.xrecordcount.Size = New System.Drawing.Size(16, 19)
        Me.xrecordcount.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'RbnCompany
        '
        Me.RbnCompany.Name = "RbnCompany"
        Me.RbnCompany.Size = New System.Drawing.Size(93, 19)
        Me.RbnCompany.Text = "RbnCompany"
        '
        'FilterDGV
        '
        Me.FilterDGV.FormattingEnabled = True
        Me.FilterDGV.Items.AddRange(New Object() {"NO WORKORDER", "WITH WORKORDER", "VIEW ALL"})
        Me.FilterDGV.Location = New System.Drawing.Point(56, 98)
        Me.FilterDGV.Name = "FilterDGV"
        Me.FilterDGV.Size = New System.Drawing.Size(222, 24)
        Me.FilterDGV.TabIndex = 123185
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1434, 592)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "OverView"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.grid1.AllowEditing = False
        Me.grid1.AllowFiltering = True
        Me.grid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid1.BackColor = System.Drawing.Color.White
        Me.grid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.grid1.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.grid1.Location = New System.Drawing.Point(3, 3)
        Me.grid1.Margin = New System.Windows.Forms.Padding(4)
        Me.grid1.Name = "grid1"
        Me.grid1.Rows.DefaultSize = 21
        Me.grid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.grid1.Size = New System.Drawing.Size(1428, 586)
        Me.grid1.StyleInfo = resources.GetString("grid1.StyleInfo")
        Me.grid1.TabIndex = 302
        Me.grid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 123188
        Me.Label2.Text = "Filter:"
        '
        'btnOpenNWO
        '
        Me.btnOpenNWO.Image = Global.WORKORDER.My.Resources.Resources.bell
        Me.btnOpenNWO.Location = New System.Drawing.Point(1369, 98)
        Me.btnOpenNWO.Name = "btnOpenNWO"
        Me.btnOpenNWO.Size = New System.Drawing.Size(40, 35)
        Me.btnOpenNWO.TabIndex = 123187
        Me.btnOpenNWO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1414, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 123186
        Me.Label1.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1442, 621)
        Me.TabControl1.TabIndex = 123184
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 19)
        Me.ToolStripStatusLabel1.Text = "Total Records"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(284, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 123190
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RbnExeCode
        '
        Me.RbnExeCode.Name = "RbnExeCode"
        Me.RbnExeCode.Size = New System.Drawing.Size(112, 19)
        Me.RbnExeCode.Text = "SubModuleCode"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel6)
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
        Me.PanelHeader.Size = New System.Drawing.Size(1439, 64)
        Me.PanelHeader.TabIndex = 123181
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.xsearch)
        Me.Panel6.Controls.Add(Me.btSearch)
        Me.Panel6.Location = New System.Drawing.Point(1057, 11)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(367, 43)
        Me.Panel6.TabIndex = 123148
        '
        'xsearch
        '
        Me.xsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xsearch.Font = New System.Drawing.Font("Century Gothic", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xsearch.Location = New System.Drawing.Point(6, 10)
        Me.xsearch.Name = "xsearch"
        Me.xsearch.Size = New System.Drawing.Size(317, 24)
        Me.xsearch.TabIndex = 123147
        '
        'btSearch
        '
        Me.btSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSearch.BackColor = System.Drawing.Color.White
        Me.btSearch.FlatAppearance.BorderSize = 0
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.Location = New System.Drawing.Point(326, 3)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(38, 36)
        Me.btSearch.TabIndex = 123146
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'BTEXPORT
        '
        Me.BTEXPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTEXPORT.Enabled = False
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
        Me.Panel7.Size = New System.Drawing.Size(1439, 2)
        Me.Panel7.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1439, 28)
        Me.MenuStrip1.TabIndex = 123182
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LinesToolStripMenuItem
        '
        Me.LinesToolStripMenuItem.Name = "LinesToolStripMenuItem"
        Me.LinesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LinesToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.LinesToolStripMenuItem.Text = "Lines"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo, Me.ToolStripStatusLabel2, Me.RbnExeCode, Me.ToolStripStatusLabel4, Me.RbnDev, Me.ToolStripStatusLabel6, Me.RbnStatus, Me.ToolStripStatusLabel8, Me.RbnUser, Me.ToolStripStatusLabel10, Me.RbnConnName, Me.ToolStripStatusLabel12, Me.RbnCN, Me.ToolStripStatusLabel14, Me.RbnIP, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.xrecordcount, Me.ToolStripStatusLabel5, Me.RbnCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 765)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1439, 24)
        Me.StatusStrip1.TabIndex = 123183
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
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'statuscheck
        '
        Me.statuscheck.Location = New System.Drawing.Point(324, 98)
        Me.statuscheck.Name = "statuscheck"
        Me.statuscheck.Size = New System.Drawing.Size(100, 22)
        Me.statuscheck.TabIndex = 123189
        Me.statuscheck.Visible = False
        '
        'FRMWORKORDERDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 789)
        Me.Controls.Add(Me.FilterDGV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenNWO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.statuscheck)
        Me.Name = "FRMWORKORDERDASHBOARD"
        Me.Text = "FRMWORKORDERDASHBOARD"
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents RbnStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents RbnUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents RbnConnName As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As ToolStripStatusLabel
    Friend WithEvents RbnCN As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel14 As ToolStripStatusLabel
    Friend WithEvents RbnIP As ToolStripStatusLabel
    Friend WithEvents RbnDev As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents xrecordcount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents RbnCompany As ToolStripStatusLabel
    Friend WithEvents FilterDGV As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents grid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOpenNWO As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents RbnExeCode As ToolStripStatusLabel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents xsearch As TextBox
    Friend WithEvents btSearch As Button
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RbnBuildNo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents statuscheck As TextBox
End Class
