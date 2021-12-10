<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOT))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.xsearch = New System.Windows.Forms.TextBox()
        Me.tsSearch = New System.Windows.Forms.Button()
        Me.tsNew = New System.Windows.Forms.Button()
        Me.tsCancel = New System.Windows.Forms.Button()
        Me.tsSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tsDelete = New System.Windows.Forms.Button()
        Me.tsEdit = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnPOST = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgMainPOT = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelentryPOT = New System.Windows.Forms.Panel()
        Me.xdtpEFFECTIVITY = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xRECID = New System.Windows.Forms.TextBox()
        Me.xVERSION = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RbnBuildNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnExeCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnDev = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xrecordcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbnCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDEFAULT = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgMainPOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelentryPOT.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel6)
        Me.PanelHeader.Controls.Add(Me.tsNew)
        Me.PanelHeader.Controls.Add(Me.tsCancel)
        Me.PanelHeader.Controls.Add(Me.tsSave)
        Me.PanelHeader.Controls.Add(Me.Panel4)
        Me.PanelHeader.Controls.Add(Me.tsDelete)
        Me.PanelHeader.Controls.Add(Me.tsEdit)
        Me.PanelHeader.Controls.Add(Me.Panel7)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 28)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(779, 64)
        Me.PanelHeader.TabIndex = 506
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.xsearch)
        Me.Panel6.Controls.Add(Me.tsSearch)
        Me.Panel6.Location = New System.Drawing.Point(505, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(270, 43)
        Me.Panel6.TabIndex = 123149
        '
        'xsearch
        '
        Me.xsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xsearch.Font = New System.Drawing.Font("Century Gothic", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xsearch.Location = New System.Drawing.Point(6, 10)
        Me.xsearch.Name = "xsearch"
        Me.xsearch.Size = New System.Drawing.Size(222, 25)
        Me.xsearch.TabIndex = 123147
        '
        'tsSearch
        '
        Me.tsSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsSearch.BackColor = System.Drawing.Color.White
        Me.tsSearch.FlatAppearance.BorderSize = 0
        Me.tsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.Location = New System.Drawing.Point(229, 3)
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(38, 36)
        Me.tsSearch.TabIndex = 123146
        Me.tsSearch.UseVisualStyleBackColor = False
        '
        'tsNew
        '
        Me.tsNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsNew.FlatAppearance.BorderSize = 0
        Me.tsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.Location = New System.Drawing.Point(9, 13)
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(38, 36)
        Me.tsNew.TabIndex = 123144
        Me.tsNew.UseVisualStyleBackColor = False
        '
        'tsCancel
        '
        Me.tsCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsCancel.FlatAppearance.BorderSize = 0
        Me.tsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsCancel.Image = CType(resources.GetObject("tsCancel.Image"), System.Drawing.Image)
        Me.tsCancel.Location = New System.Drawing.Point(142, 13)
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(38, 36)
        Me.tsCancel.TabIndex = 123140
        Me.tsCancel.UseVisualStyleBackColor = False
        '
        'tsSave
        '
        Me.tsSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsSave.Enabled = False
        Me.tsSave.FlatAppearance.BorderSize = 0
        Me.tsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.Location = New System.Drawing.Point(98, 13)
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(38, 36)
        Me.tsSave.TabIndex = 123139
        Me.tsSave.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(236, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 32)
        Me.Panel4.TabIndex = 123137
        '
        'tsDelete
        '
        Me.tsDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsDelete.Enabled = False
        Me.tsDelete.FlatAppearance.BorderSize = 0
        Me.tsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.Location = New System.Drawing.Point(186, 13)
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(38, 36)
        Me.tsDelete.TabIndex = 123136
        Me.tsDelete.UseVisualStyleBackColor = False
        '
        'tsEdit
        '
        Me.tsEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsEdit.FlatAppearance.BorderSize = 0
        Me.tsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.Location = New System.Drawing.Point(55, 13)
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(38, 36)
        Me.tsEdit.TabIndex = 123135
        Me.tsEdit.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(779, 2)
        Me.Panel7.TabIndex = 8
        '
        'btnPOST
        '
        Me.btnPOST.BackColor = System.Drawing.Color.Transparent
        Me.btnPOST.FlatAppearance.BorderSize = 0
        Me.btnPOST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOST.Image = CType(resources.GetObject("btnPOST.Image"), System.Drawing.Image)
        Me.btnPOST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOST.Location = New System.Drawing.Point(628, 122)
        Me.btnPOST.Name = "btnPOST"
        Me.btnPOST.Size = New System.Drawing.Size(145, 36)
        Me.btnPOST.TabIndex = 123151
        Me.btnPOST.Text = "     POST"
        Me.btnPOST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPOST.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 28)
        Me.MenuStrip1.TabIndex = 505
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ExitToolStripMenuItem})
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
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.Location = New System.Drawing.Point(0, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(622, 414)
        Me.TabControl1.TabIndex = 507
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgMainPOT)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.panelentryPOT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(614, 385)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overview"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgMainPOT
        '
        Me.dgMainPOT.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgMainPOT.AllowEditing = False
        Me.dgMainPOT.AllowFiltering = True
        Me.dgMainPOT.BackColor = System.Drawing.Color.White
        Me.dgMainPOT.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.dgMainPOT.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.dgMainPOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMainPOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgMainPOT.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgMainPOT.Location = New System.Drawing.Point(3, 106)
        Me.dgMainPOT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMainPOT.Name = "dgMainPOT"
        Me.dgMainPOT.Rows.DefaultSize = 21
        Me.dgMainPOT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgMainPOT.Size = New System.Drawing.Size(608, 276)
        Me.dgMainPOT.StyleInfo = resources.GetString("dgMainPOT.StyleInfo")
        Me.dgMainPOT.TabIndex = 295
        Me.dgMainPOT.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 276)
        Me.Panel1.TabIndex = 296
        '
        'panelentryPOT
        '
        Me.panelentryPOT.Controls.Add(Me.xdtpEFFECTIVITY)
        Me.panelentryPOT.Controls.Add(Me.Label2)
        Me.panelentryPOT.Controls.Add(Me.xRECID)
        Me.panelentryPOT.Controls.Add(Me.xVERSION)
        Me.panelentryPOT.Controls.Add(Me.Panel5)
        Me.panelentryPOT.Controls.Add(Me.Label8)
        Me.panelentryPOT.Controls.Add(Me.Label1)
        Me.panelentryPOT.Controls.Add(Me.Panel3)
        Me.panelentryPOT.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelentryPOT.Location = New System.Drawing.Point(3, 3)
        Me.panelentryPOT.Name = "panelentryPOT"
        Me.panelentryPOT.Size = New System.Drawing.Size(608, 103)
        Me.panelentryPOT.TabIndex = 297
        '
        'xdtpEFFECTIVITY
        '
        Me.xdtpEFFECTIVITY.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xdtpEFFECTIVITY.Location = New System.Drawing.Point(208, 69)
        Me.xdtpEFFECTIVITY.Name = "xdtpEFFECTIVITY"
        Me.xdtpEFFECTIVITY.Size = New System.Drawing.Size(114, 22)
        Me.xdtpEFFECTIVITY.TabIndex = 533
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 532
        Me.Label2.Text = "Effectivity Date: "
        '
        'xRECID
        '
        Me.xRECID.Location = New System.Drawing.Point(363, 38)
        Me.xRECID.Name = "xRECID"
        Me.xRECID.Size = New System.Drawing.Size(68, 22)
        Me.xRECID.TabIndex = 531
        '
        'xVERSION
        '
        Me.xVERSION.Location = New System.Drawing.Point(208, 38)
        Me.xVERSION.Name = "xVERSION"
        Me.xVERSION.Size = New System.Drawing.Size(149, 22)
        Me.xVERSION.TabIndex = 530
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(104, 18)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(411, 1)
        Me.Panel5.TabIndex = 529
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 528
        Me.Label8.Text = "Identification"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 526
        Me.Label1.Text = "Version: "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(608, 2)
        Me.Panel3.TabIndex = 525
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo, Me.ToolStripStatusLabel2, Me.RbnExeCode, Me.ToolStripStatusLabel4, Me.RbnDev, Me.ToolStripStatusLabel6, Me.RbnStatus, Me.ToolStripStatusLabel8, Me.RbnUser, Me.ToolStripStatusLabel10, Me.RbnConnName, Me.ToolStripStatusLabel12, Me.RbnCN, Me.ToolStripStatusLabel14, Me.RbnIP, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.xrecordcount, Me.ToolStripStatusLabel5, Me.RbnCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(779, 24)
        Me.StatusStrip1.TabIndex = 508
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
        'RbnExeCode
        '
        Me.RbnExeCode.Name = "RbnExeCode"
        Me.RbnExeCode.Size = New System.Drawing.Size(112, 19)
        Me.RbnExeCode.Text = "SubModuleCode"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'RbnDev
        '
        Me.RbnDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnDev.ForeColor = System.Drawing.Color.Red
        Me.RbnDev.Name = "RbnDev"
        Me.RbnDev.Size = New System.Drawing.Size(73, 19)
        Me.RbnDev.Text = "DevCode"
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
        Me.RbnStatus.Size = New System.Drawing.Size(146, 19)
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
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(11, 19)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 17)
        Me.ToolStripStatusLabel1.Text = "Total Records"
        '
        'xrecordcount
        '
        Me.xrecordcount.Name = "xrecordcount"
        Me.xrecordcount.Size = New System.Drawing.Size(16, 17)
        Me.xrecordcount.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'RbnCompany
        '
        Me.RbnCompany.Name = "RbnCompany"
        Me.RbnCompany.Size = New System.Drawing.Size(93, 17)
        Me.RbnCompany.Text = "RbnCompany"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 506)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(779, 2)
        Me.Panel9.TabIndex = 524
        '
        'btnDEFAULT
        '
        Me.btnDEFAULT.BackColor = System.Drawing.Color.Transparent
        Me.btnDEFAULT.FlatAppearance.BorderSize = 0
        Me.btnDEFAULT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDEFAULT.Image = CType(resources.GetObject("btnDEFAULT.Image"), System.Drawing.Image)
        Me.btnDEFAULT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDEFAULT.Location = New System.Drawing.Point(627, 170)
        Me.btnDEFAULT.Name = "btnDEFAULT"
        Me.btnDEFAULT.Size = New System.Drawing.Size(145, 36)
        Me.btnDEFAULT.TabIndex = 123152
        Me.btnDEFAULT.Text = "   DEFAULT"
        Me.btnDEFAULT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDEFAULT.UseVisualStyleBackColor = False
        '
        'frmPOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 532)
        Me.Controls.Add(Me.btnDEFAULT)
        Me.Controls.Add(Me.btnPOST)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1REI |  Farm Operation and Management | Farm Package of Technology"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgMainPOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelentryPOT.ResumeLayout(False)
        Me.panelentryPOT.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents btnPOST As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents xsearch As System.Windows.Forms.TextBox
    Friend WithEvents tsSearch As System.Windows.Forms.Button
    Friend WithEvents tsNew As System.Windows.Forms.Button
    Friend WithEvents tsCancel As System.Windows.Forms.Button
    Friend WithEvents tsSave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tsDelete As System.Windows.Forms.Button
    Friend WithEvents tsEdit As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RbnBuildNo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnExeCode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnDev As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnConnName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnCN As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel14 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnIP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents xrecordcount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbnCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents dgMainPOT As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelentryPOT As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xVERSION As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xRECID As System.Windows.Forms.TextBox
    Friend WithEvents xdtpEFFECTIVITY As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDEFAULT As Button
End Class
