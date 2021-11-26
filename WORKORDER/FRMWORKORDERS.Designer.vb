<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMWORKORDERS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMWORKORDERS))
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTNNOTIF = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.XSEARCH = New System.Windows.Forms.TextBox()
        Me.BTSEARCHLINE = New System.Windows.Forms.Button()
        Me.BTEXPORT = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.bTpRINT = New System.Windows.Forms.Button()
        Me.btCancelUpdate = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtRefresh = New System.Windows.Forms.Button()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.BTNDASHBOARD = New System.Windows.Forms.Button()
        Me.BTNWORKORDER = New System.Windows.Forms.Button()
        Me.btAddHeader = New System.Windows.Forms.Button()
        Me.btCancelHeader = New System.Windows.Forms.Button()
        Me.btSaveHeader = New System.Windows.Forms.Button()
        Me.btDeleteHeader = New System.Windows.Forms.Button()
        Me.btEditHeader = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANELHEADER = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MAINTAB = New System.Windows.Forms.TabControl()
        Me.Dashboard = New System.Windows.Forms.TabPage()
        Me.Overview = New System.Windows.Forms.TabPage()
        Me.dgMAINWO = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Details = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.xAREAOFACTIVITY = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.xVERSION = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xWOCODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.xPLANTINGDATE = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.xAGE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.xCROPCLASS = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.xCROPYEAR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.xFARMASSISTANT = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.xFARMMANAGER = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.xCROPCLASSDETAIL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xLAAS = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.xFAS = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.xFARMCLUSTER = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.xMILLINGSEASON = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.xCONTRACTEDTAREA = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.xFARMCLASSIFICATION = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.xFARMADDRESS = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xPLANTEDAREA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xARABLEAREA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.xMAINFIELDNO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xFARMMODEL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xLANDOWNER = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xSUBFIELDNO = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PANELHEADER.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MAINTAB.SuspendLayout()
        Me.Overview.SuspendLayout()
        CType(Me.dgMAINWO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Details.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo, Me.ToolStripStatusLabel7, Me.RbnExeCode, Me.ToolStripStatusLabel11, Me.RbnDev, Me.ToolStripStatusLabel13, Me.RbnStatus, Me.ToolStripStatusLabel15, Me.RbnUser, Me.ToolStripStatusLabel16, Me.RbnConnName, Me.ToolStripStatusLabel17, Me.RbnCN, Me.ToolStripStatusLabel18, Me.RbnIP, Me.ToolStripStatusLabel19, Me.RbnCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1031)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1566, 24)
        Me.StatusStrip1.TabIndex = 245
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
        Me.RbnStatus.Size = New System.Drawing.Size(840, 19)
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
        'BTNNOTIF
        '
        Me.BTNNOTIF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNNOTIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNNOTIF.FlatAppearance.BorderSize = 0
        Me.BTNNOTIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNNOTIF.Image = CType(resources.GetObject("BTNNOTIF.Image"), System.Drawing.Image)
        Me.BTNNOTIF.Location = New System.Drawing.Point(1136, 19)
        Me.BTNNOTIF.Name = "BTNNOTIF"
        Me.BTNNOTIF.Size = New System.Drawing.Size(38, 36)
        Me.BTNNOTIF.TabIndex = 123156
        Me.ToolTip1.SetToolTip(Me.BTNNOTIF, "Notification")
        Me.BTNNOTIF.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.XSEARCH)
        Me.Panel8.Controls.Add(Me.BTSEARCHLINE)
        Me.Panel8.Location = New System.Drawing.Point(1180, 14)
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
        'BtDelete
        '
        Me.BtDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'BTNDASHBOARD
        '
        Me.BTNDASHBOARD.BackColor = System.Drawing.Color.DimGray
        Me.BTNDASHBOARD.FlatAppearance.BorderSize = 0
        Me.BTNDASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDASHBOARD.ForeColor = System.Drawing.Color.White
        Me.BTNDASHBOARD.Image = CType(resources.GetObject("BTNDASHBOARD.Image"), System.Drawing.Image)
        Me.BTNDASHBOARD.Location = New System.Drawing.Point(5, 4)
        Me.BTNDASHBOARD.Name = "BTNDASHBOARD"
        Me.BTNDASHBOARD.Size = New System.Drawing.Size(152, 64)
        Me.BTNDASHBOARD.TabIndex = 123153
        Me.BTNDASHBOARD.Text = "   Dashboard"
        Me.BTNDASHBOARD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BTNDASHBOARD, "Dashboard")
        Me.BTNDASHBOARD.UseVisualStyleBackColor = False
        '
        'BTNWORKORDER
        '
        Me.BTNWORKORDER.BackColor = System.Drawing.Color.DimGray
        Me.BTNWORKORDER.FlatAppearance.BorderSize = 0
        Me.BTNWORKORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNWORKORDER.ForeColor = System.Drawing.Color.White
        Me.BTNWORKORDER.Image = CType(resources.GetObject("BTNWORKORDER.Image"), System.Drawing.Image)
        Me.BTNWORKORDER.Location = New System.Drawing.Point(163, 4)
        Me.BTNWORKORDER.Name = "BTNWORKORDER"
        Me.BTNWORKORDER.Size = New System.Drawing.Size(152, 64)
        Me.BTNWORKORDER.TabIndex = 123154
        Me.BTNWORKORDER.Text = "   Work Orders"
        Me.BTNWORKORDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BTNWORKORDER, "Work Order")
        Me.BTNWORKORDER.UseVisualStyleBackColor = False
        '
        'btAddHeader
        '
        Me.btAddHeader.BackColor = System.Drawing.Color.Transparent
        Me.btAddHeader.FlatAppearance.BorderSize = 0
        Me.btAddHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAddHeader.Image = CType(resources.GetObject("btAddHeader.Image"), System.Drawing.Image)
        Me.btAddHeader.Location = New System.Drawing.Point(13, 10)
        Me.btAddHeader.Name = "btAddHeader"
        Me.btAddHeader.Size = New System.Drawing.Size(38, 36)
        Me.btAddHeader.TabIndex = 123158
        Me.ToolTip1.SetToolTip(Me.btAddHeader, "Add")
        Me.btAddHeader.UseVisualStyleBackColor = False
        '
        'btCancelHeader
        '
        Me.btCancelHeader.BackColor = System.Drawing.Color.Transparent
        Me.btCancelHeader.FlatAppearance.BorderSize = 0
        Me.btCancelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelHeader.Image = CType(resources.GetObject("btCancelHeader.Image"), System.Drawing.Image)
        Me.btCancelHeader.Location = New System.Drawing.Point(146, 10)
        Me.btCancelHeader.Name = "btCancelHeader"
        Me.btCancelHeader.Size = New System.Drawing.Size(38, 36)
        Me.btCancelHeader.TabIndex = 123157
        Me.ToolTip1.SetToolTip(Me.btCancelHeader, "Cancel")
        Me.btCancelHeader.UseVisualStyleBackColor = False
        '
        'btSaveHeader
        '
        Me.btSaveHeader.BackColor = System.Drawing.Color.Transparent
        Me.btSaveHeader.FlatAppearance.BorderSize = 0
        Me.btSaveHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSaveHeader.Image = CType(resources.GetObject("btSaveHeader.Image"), System.Drawing.Image)
        Me.btSaveHeader.Location = New System.Drawing.Point(102, 10)
        Me.btSaveHeader.Name = "btSaveHeader"
        Me.btSaveHeader.Size = New System.Drawing.Size(38, 36)
        Me.btSaveHeader.TabIndex = 123156
        Me.ToolTip1.SetToolTip(Me.btSaveHeader, "Save")
        Me.btSaveHeader.UseVisualStyleBackColor = False
        '
        'btDeleteHeader
        '
        Me.btDeleteHeader.BackColor = System.Drawing.Color.Transparent
        Me.btDeleteHeader.FlatAppearance.BorderSize = 0
        Me.btDeleteHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDeleteHeader.Image = CType(resources.GetObject("btDeleteHeader.Image"), System.Drawing.Image)
        Me.btDeleteHeader.Location = New System.Drawing.Point(190, 10)
        Me.btDeleteHeader.Name = "btDeleteHeader"
        Me.btDeleteHeader.Size = New System.Drawing.Size(38, 36)
        Me.btDeleteHeader.TabIndex = 123155
        Me.ToolTip1.SetToolTip(Me.btDeleteHeader, "Delete")
        Me.btDeleteHeader.UseVisualStyleBackColor = False
        '
        'btEditHeader
        '
        Me.btEditHeader.BackColor = System.Drawing.Color.Transparent
        Me.btEditHeader.FlatAppearance.BorderSize = 0
        Me.btEditHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditHeader.Image = CType(resources.GetObject("btEditHeader.Image"), System.Drawing.Image)
        Me.btEditHeader.Location = New System.Drawing.Point(59, 10)
        Me.btEditHeader.Name = "btEditHeader"
        Me.btEditHeader.Size = New System.Drawing.Size(38, 36)
        Me.btEditHeader.TabIndex = 123154
        Me.ToolTip1.SetToolTip(Me.btEditHeader, "Edit")
        Me.btEditHeader.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1566, 28)
        Me.MenuStrip1.TabIndex = 246
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
        'PANELHEADER
        '
        Me.PANELHEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PANELHEADER.Controls.Add(Me.BTNNOTIF)
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
        Me.PANELHEADER.Size = New System.Drawing.Size(1566, 73)
        Me.PANELHEADER.TabIndex = 249
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.BTNWORKORDER)
        Me.Panel1.Controls.Add(Me.BTNDASHBOARD)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1566, 73)
        Me.Panel1.TabIndex = 250
        '
        'MAINTAB
        '
        Me.MAINTAB.Controls.Add(Me.Dashboard)
        Me.MAINTAB.Controls.Add(Me.Overview)
        Me.MAINTAB.Controls.Add(Me.Details)
        Me.MAINTAB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAINTAB.Location = New System.Drawing.Point(0, 174)
        Me.MAINTAB.Name = "MAINTAB"
        Me.MAINTAB.SelectedIndex = 0
        Me.MAINTAB.Size = New System.Drawing.Size(1566, 857)
        Me.MAINTAB.TabIndex = 251
        '
        'Dashboard
        '
        Me.Dashboard.Location = New System.Drawing.Point(4, 25)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.Dashboard.Size = New System.Drawing.Size(1558, 828)
        Me.Dashboard.TabIndex = 0
        Me.Dashboard.Text = "Dashboard"
        Me.Dashboard.UseVisualStyleBackColor = True
        '
        'Overview
        '
        Me.Overview.Controls.Add(Me.dgMAINWO)
        Me.Overview.Location = New System.Drawing.Point(4, 25)
        Me.Overview.Name = "Overview"
        Me.Overview.Padding = New System.Windows.Forms.Padding(3)
        Me.Overview.Size = New System.Drawing.Size(1558, 828)
        Me.Overview.TabIndex = 1
        Me.Overview.Text = "Work Orders"
        Me.Overview.UseVisualStyleBackColor = True
        '
        'dgMAINWO
        '
        Me.dgMAINWO.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgMAINWO.AllowEditing = False
        Me.dgMAINWO.AllowFiltering = True
        Me.dgMAINWO.BackColor = System.Drawing.Color.White
        Me.dgMAINWO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.dgMAINWO.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.dgMAINWO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMAINWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgMAINWO.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgMAINWO.Location = New System.Drawing.Point(3, 3)
        Me.dgMAINWO.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMAINWO.Name = "dgMAINWO"
        Me.dgMAINWO.Rows.DefaultSize = 21
        Me.dgMAINWO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgMAINWO.Size = New System.Drawing.Size(1552, 822)
        Me.dgMAINWO.StyleInfo = resources.GetString("dgMAINWO.StyleInfo")
        Me.dgMAINWO.TabIndex = 301
        Me.dgMAINWO.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Details
        '
        Me.Details.Controls.Add(Me.Panel6)
        Me.Details.Controls.Add(Me.Panel2)
        Me.Details.Controls.Add(Me.Panel11)
        Me.Details.Controls.Add(Me.Panel13)
        Me.Details.Controls.Add(Me.C1FlexGrid2)
        Me.Details.Controls.Add(Me.Panel5)
        Me.Details.Location = New System.Drawing.Point(4, 25)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(1558, 828)
        Me.Details.TabIndex = 2
        Me.Details.Text = "Details"
        Me.Details.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.C1FlexGrid1)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(504, 205)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1054, 265)
        Me.Panel6.TabIndex = 2
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1FlexGrid1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 53)
        Me.C1FlexGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 21
        Me.C1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1054, 212)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 302
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Label37)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1054, 53)
        Me.Panel7.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(147, 27)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(882, 1)
        Me.Panel9.TabIndex = 25
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(14, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(119, 17)
        Me.Label37.TabIndex = 24
        Me.Label37.Text = "Method of Activity"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.xAREAOFACTIVITY)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.xVERSION)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.xWOCODE)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(504, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 151)
        Me.Panel2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.Location = New System.Drawing.Point(731, 30)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(107, 22)
        Me.TextBox3.TabIndex = 114
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(242, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(226, 22)
        Me.TextBox1.TabIndex = 93
        '
        'xAREAOFACTIVITY
        '
        Me.xAREAOFACTIVITY.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xAREAOFACTIVITY.Location = New System.Drawing.Point(731, 57)
        Me.xAREAOFACTIVITY.Name = "xAREAOFACTIVITY"
        Me.xAREAOFACTIVITY.ReadOnly = True
        Me.xAREAOFACTIVITY.Size = New System.Drawing.Size(95, 22)
        Me.xAREAOFACTIVITY.TabIndex = 113
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.Location = New System.Drawing.Point(242, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(226, 22)
        Me.TextBox2.TabIndex = 92
        '
        'xVERSION
        '
        Me.xVERSION.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xVERSION.Location = New System.Drawing.Point(242, 58)
        Me.xVERSION.Name = "xVERSION"
        Me.xVERSION.ReadOnly = True
        Me.xVERSION.Size = New System.Drawing.Size(107, 22)
        Me.xVERSION.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Version:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(568, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Area of Activity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(565, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "WO Activity Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Minor Activity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Major Activity:"
        '
        'xWOCODE
        '
        Me.xWOCODE.BackColor = System.Drawing.SystemColors.Info
        Me.xWOCODE.Location = New System.Drawing.Point(242, 31)
        Me.xWOCODE.Name = "xWOCODE"
        Me.xWOCODE.ReadOnly = True
        Me.xWOCODE.Size = New System.Drawing.Size(173, 22)
        Me.xWOCODE.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Work Order Code:"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(107, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(932, 1)
        Me.Panel4.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Informations"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Label38)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(504, 470)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1054, 50)
        Me.Panel11.TabIndex = 303
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(174, 24)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(852, 1)
        Me.Panel12.TabIndex = 25
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(14, 15)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(157, 17)
        Me.Label38.TabIndex = 24
        Me.Label38.Text = "Work Order of Activities"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel13.Controls.Add(Me.btAddHeader)
        Me.Panel13.Controls.Add(Me.btCancelHeader)
        Me.Panel13.Controls.Add(Me.btSaveHeader)
        Me.Panel13.Controls.Add(Me.btDeleteHeader)
        Me.Panel13.Controls.Add(Me.btEditHeader)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(504, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1054, 54)
        Me.Panel13.TabIndex = 38
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid2.AllowFiltering = True
        Me.C1FlexGrid2.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid2.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.C1FlexGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1FlexGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1FlexGrid2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.C1FlexGrid2.Location = New System.Drawing.Point(504, 520)
        Me.C1FlexGrid2.Margin = New System.Windows.Forms.Padding(4)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.Rows.DefaultSize = 21
        Me.C1FlexGrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid2.Size = New System.Drawing.Size(1054, 308)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 304
        Me.C1FlexGrid2.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.xPLANTINGDATE)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.xAGE)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.xCROPCLASS)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.xCROPYEAR)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.xFARMASSISTANT)
        Me.Panel5.Controls.Add(Me.Label36)
        Me.Panel5.Controls.Add(Me.xFARMMANAGER)
        Me.Panel5.Controls.Add(Me.Label35)
        Me.Panel5.Controls.Add(Me.xCROPCLASSDETAIL)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.xLAAS)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.xFAS)
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.xFARMCLUSTER)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.xMILLINGSEASON)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.xCONTRACTEDTAREA)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.xFARMCLASSIFICATION)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.xFARMADDRESS)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.xPLANTEDAREA)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.xARABLEAREA)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.xMAINFIELDNO)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.xFARMMODEL)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.xLANDOWNER)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.xSUBFIELDNO)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(504, 828)
        Me.Panel5.TabIndex = 1
        '
        'xPLANTINGDATE
        '
        Me.xPLANTINGDATE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xPLANTINGDATE.Location = New System.Drawing.Point(198, 304)
        Me.xPLANTINGDATE.Name = "xPLANTINGDATE"
        Me.xPLANTINGDATE.ReadOnly = True
        Me.xPLANTINGDATE.Size = New System.Drawing.Size(113, 22)
        Me.xPLANTINGDATE.TabIndex = 138
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(32, 307)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 17)
        Me.Label24.TabIndex = 137
        Me.Label24.Text = "Planting Date:"
        '
        'xAGE
        '
        Me.xAGE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xAGE.Location = New System.Drawing.Point(198, 331)
        Me.xAGE.Name = "xAGE"
        Me.xAGE.ReadOnly = True
        Me.xAGE.Size = New System.Drawing.Size(95, 22)
        Me.xAGE.TabIndex = 136
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 334)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 17)
        Me.Label16.TabIndex = 135
        Me.Label16.Text = "Age of Cane Month:"
        '
        'xCROPCLASS
        '
        Me.xCROPCLASS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xCROPCLASS.Location = New System.Drawing.Point(198, 60)
        Me.xCROPCLASS.Name = "xCROPCLASS"
        Me.xCROPCLASS.ReadOnly = True
        Me.xCROPCLASS.Size = New System.Drawing.Size(113, 22)
        Me.xCROPCLASS.TabIndex = 134
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(32, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 17)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Crop Class:"
        '
        'xCROPYEAR
        '
        Me.xCROPYEAR.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xCROPYEAR.Location = New System.Drawing.Point(198, 223)
        Me.xCROPYEAR.Name = "xCROPYEAR"
        Me.xCROPYEAR.ReadOnly = True
        Me.xCROPYEAR.Size = New System.Drawing.Size(95, 22)
        Me.xCROPYEAR.TabIndex = 132
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 17)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "Crop Year:"
        '
        'xFARMASSISTANT
        '
        Me.xFARMASSISTANT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMASSISTANT.Location = New System.Drawing.Point(198, 584)
        Me.xFARMASSISTANT.Name = "xFARMASSISTANT"
        Me.xFARMASSISTANT.ReadOnly = True
        Me.xFARMASSISTANT.Size = New System.Drawing.Size(224, 22)
        Me.xFARMASSISTANT.TabIndex = 130
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(32, 587)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(105, 17)
        Me.Label36.TabIndex = 129
        Me.Label36.Text = "Farm Assistant:"
        '
        'xFARMMANAGER
        '
        Me.xFARMMANAGER.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMMANAGER.Location = New System.Drawing.Point(198, 557)
        Me.xFARMMANAGER.Name = "xFARMMANAGER"
        Me.xFARMMANAGER.ReadOnly = True
        Me.xFARMMANAGER.Size = New System.Drawing.Size(224, 22)
        Me.xFARMMANAGER.TabIndex = 128
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(32, 560)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 17)
        Me.Label35.TabIndex = 127
        Me.Label35.Text = "Farm Manager:"
        '
        'xCROPCLASSDETAIL
        '
        Me.xCROPCLASSDETAIL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xCROPCLASSDETAIL.Location = New System.Drawing.Point(198, 87)
        Me.xCROPCLASSDETAIL.Name = "xCROPCLASSDETAIL"
        Me.xCROPCLASSDETAIL.ReadOnly = True
        Me.xCROPCLASSDETAIL.Size = New System.Drawing.Size(113, 22)
        Me.xCROPCLASSDETAIL.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Crop Class Detail:"
        '
        'xLAAS
        '
        Me.xLAAS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xLAAS.Location = New System.Drawing.Point(198, 529)
        Me.xLAAS.Name = "xLAAS"
        Me.xLAAS.ReadOnly = True
        Me.xLAAS.Size = New System.Drawing.Size(224, 22)
        Me.xLAAS.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(32, 532)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 17)
        Me.Label33.TabIndex = 125
        Me.Label33.Text = "LAAS:"
        '
        'xFAS
        '
        Me.xFAS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFAS.Location = New System.Drawing.Point(198, 502)
        Me.xFAS.Name = "xFAS"
        Me.xFAS.ReadOnly = True
        Me.xFAS.Size = New System.Drawing.Size(224, 22)
        Me.xFAS.TabIndex = 124
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(32, 504)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 17)
        Me.Label32.TabIndex = 123
        Me.Label32.Text = "FAS:"
        '
        'xFARMCLUSTER
        '
        Me.xFARMCLUSTER.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMCLUSTER.Location = New System.Drawing.Point(198, 358)
        Me.xFARMCLUSTER.Name = "xFARMCLUSTER"
        Me.xFARMCLUSTER.ReadOnly = True
        Me.xFARMCLUSTER.Size = New System.Drawing.Size(113, 22)
        Me.xFARMCLUSTER.TabIndex = 122
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(32, 361)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 17)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "Farm Cluster:"
        '
        'xMILLINGSEASON
        '
        Me.xMILLINGSEASON.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xMILLINGSEASON.Location = New System.Drawing.Point(198, 474)
        Me.xMILLINGSEASON.Name = "xMILLINGSEASON"
        Me.xMILLINGSEASON.ReadOnly = True
        Me.xMILLINGSEASON.Size = New System.Drawing.Size(129, 22)
        Me.xMILLINGSEASON.TabIndex = 120
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(32, 477)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 17)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "Milling Season:"
        '
        'xCONTRACTEDTAREA
        '
        Me.xCONTRACTEDTAREA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xCONTRACTEDTAREA.Location = New System.Drawing.Point(198, 196)
        Me.xCONTRACTEDTAREA.Name = "xCONTRACTEDTAREA"
        Me.xCONTRACTEDTAREA.ReadOnly = True
        Me.xCONTRACTEDTAREA.Size = New System.Drawing.Size(95, 22)
        Me.xCONTRACTEDTAREA.TabIndex = 118
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(32, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 17)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "Contracted Area:"
        '
        'xFARMCLASSIFICATION
        '
        Me.xFARMCLASSIFICATION.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMCLASSIFICATION.Location = New System.Drawing.Point(198, 447)
        Me.xFARMCLASSIFICATION.Name = "xFARMCLASSIFICATION"
        Me.xFARMCLASSIFICATION.ReadOnly = True
        Me.xFARMCLASSIFICATION.Size = New System.Drawing.Size(113, 22)
        Me.xFARMCLASSIFICATION.TabIndex = 116
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 450)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 17)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "Farm Classification:"
        '
        'xFARMADDRESS
        '
        Me.xFARMADDRESS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMADDRESS.Location = New System.Drawing.Point(198, 385)
        Me.xFARMADDRESS.Multiline = True
        Me.xFARMADDRESS.Name = "xFARMADDRESS"
        Me.xFARMADDRESS.ReadOnly = True
        Me.xFARMADDRESS.Size = New System.Drawing.Size(274, 57)
        Me.xFARMADDRESS.TabIndex = 114
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 388)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 17)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "Farm Address:"
        '
        'xPLANTEDAREA
        '
        Me.xPLANTEDAREA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xPLANTEDAREA.Location = New System.Drawing.Point(198, 277)
        Me.xPLANTEDAREA.Name = "xPLANTEDAREA"
        Me.xPLANTEDAREA.ReadOnly = True
        Me.xPLANTEDAREA.Size = New System.Drawing.Size(95, 22)
        Me.xPLANTEDAREA.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 17)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "Planted Area:"
        '
        'xARABLEAREA
        '
        Me.xARABLEAREA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xARABLEAREA.Location = New System.Drawing.Point(198, 250)
        Me.xARABLEAREA.Name = "xARABLEAREA"
        Me.xARABLEAREA.ReadOnly = True
        Me.xARABLEAREA.Size = New System.Drawing.Size(95, 22)
        Me.xARABLEAREA.TabIndex = 110
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 17)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Arable Area:"
        '
        'xMAINFIELDNO
        '
        Me.xMAINFIELDNO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xMAINFIELDNO.Location = New System.Drawing.Point(198, 169)
        Me.xMAINFIELDNO.Name = "xMAINFIELDNO"
        Me.xMAINFIELDNO.ReadOnly = True
        Me.xMAINFIELDNO.Size = New System.Drawing.Size(173, 22)
        Me.xMAINFIELDNO.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Main Field No:"
        '
        'xFARMMODEL
        '
        Me.xFARMMODEL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xFARMMODEL.Location = New System.Drawing.Point(198, 142)
        Me.xFARMMODEL.Name = "xFARMMODEL"
        Me.xFARMMODEL.ReadOnly = True
        Me.xFARMMODEL.Size = New System.Drawing.Size(239, 22)
        Me.xFARMMODEL.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Farm Model:"
        '
        'xLANDOWNER
        '
        Me.xLANDOWNER.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xLANDOWNER.Location = New System.Drawing.Point(198, 115)
        Me.xLANDOWNER.Name = "xLANDOWNER"
        Me.xLANDOWNER.ReadOnly = True
        Me.xLANDOWNER.Size = New System.Drawing.Size(239, 22)
        Me.xLANDOWNER.TabIndex = 104
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 17)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "Land Owner:"
        '
        'xSUBFIELDNO
        '
        Me.xSUBFIELDNO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xSUBFIELDNO.Location = New System.Drawing.Point(198, 32)
        Me.xSUBFIELDNO.Name = "xSUBFIELDNO"
        Me.xSUBFIELDNO.ReadOnly = True
        Me.xSUBFIELDNO.Size = New System.Drawing.Size(274, 22)
        Me.xSUBFIELDNO.TabIndex = 87
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(32, 37)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(93, 17)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Sub Field No:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(109, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 1)
        Me.Panel3.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Field Details"
        '
        'FRMWORKORDERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1566, 1055)
        Me.Controls.Add(Me.MAINTAB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PANELHEADER)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMWORKORDERS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PANELHEADER.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MAINTAB.ResumeLayout(False)
        Me.Overview.ResumeLayout(False)
        CType(Me.dgMAINWO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Details.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PANELHEADER As Panel
    Friend WithEvents BTNNOTIF As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNDASHBOARD As Button
    Friend WithEvents BTNWORKORDER As Button
    Friend WithEvents MAINTAB As TabControl
    Friend WithEvents Dashboard As TabPage
    Friend WithEvents Overview As TabPage
    Friend WithEvents dgMAINWO As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Details As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents xSUBFIELDNO As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btAddHeader As Button
    Friend WithEvents btCancelHeader As Button
    Friend WithEvents btSaveHeader As Button
    Friend WithEvents btDeleteHeader As Button
    Friend WithEvents btEditHeader As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents xAREAOFACTIVITY As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents xVERSION As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents xWOCODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xPLANTINGDATE As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents xAGE As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents xCROPCLASS As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents xCROPYEAR As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents xFARMASSISTANT As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents xFARMMANAGER As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents xCROPCLASSDETAIL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xLAAS As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents xFAS As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents xFARMCLUSTER As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents xMILLINGSEASON As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents xCONTRACTEDTAREA As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents xFARMCLASSIFICATION As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents xFARMADDRESS As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents xPLANTEDAREA As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents xARABLEAREA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents xMAINFIELDNO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xFARMMODEL As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xLANDOWNER As TextBox
    Friend WithEvents Label14 As Label
End Class
