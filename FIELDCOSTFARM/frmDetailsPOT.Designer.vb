<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsPOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsPOT))
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
        Me.LBLAGE = New System.Windows.Forms.Label()
        Me.LBLPLANTINGDATE = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLASOFBUDGET = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLREMARKS = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LBLLASTACTIVITY = New System.Windows.Forms.Label()
        Me.LBLFARMMODEL = New System.Windows.Forms.Label()
        Me.LBLAREA = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.LBLVARIANCE = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LBLSUBFIELDNO = New System.Windows.Forms.Label()
        Me.LBLACTUAL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLFARMLOCATION = New System.Windows.Forms.Label()
        Me.LBLLANDOWNER = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LBLBUDGET = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLFARMMANAGER = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.dgFieldInfo = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.xCROPCLASS = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgFIELDCOST = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.XGRANDTOTAL = New System.Windows.Forms.Label()
        Me.xLBLLABORHAUL = New System.Windows.Forms.Label()
        Me.xLBLACTUALCOST = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFieldInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgFIELDCOST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 740)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1340, 22)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1340, 28)
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
        Me.PanelHeader.Size = New System.Drawing.Size(1340, 64)
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
        Me.Panel7.Size = New System.Drawing.Size(1340, 2)
        Me.Panel7.TabIndex = 8
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.LBLAGE)
        Me.Panel13.Controls.Add(Me.LBLPLANTINGDATE)
        Me.Panel13.Controls.Add(Me.Label7)
        Me.Panel13.Controls.Add(Me.Label8)
        Me.Panel13.Controls.Add(Me.LBLASOFBUDGET)
        Me.Panel13.Controls.Add(Me.Label4)
        Me.Panel13.Controls.Add(Me.Panel1)
        Me.Panel13.Controls.Add(Me.Panel2)
        Me.Panel13.Controls.Add(Me.LBLREMARKS)
        Me.Panel13.Controls.Add(Me.Label35)
        Me.Panel13.Controls.Add(Me.LBLLASTACTIVITY)
        Me.Panel13.Controls.Add(Me.LBLFARMMODEL)
        Me.Panel13.Controls.Add(Me.LBLAREA)
        Me.Panel13.Controls.Add(Me.Label49)
        Me.Panel13.Controls.Add(Me.Label38)
        Me.Panel13.Controls.Add(Me.Label51)
        Me.Panel13.Controls.Add(Me.LBLVARIANCE)
        Me.Panel13.Controls.Add(Me.Label24)
        Me.Panel13.Controls.Add(Me.Label26)
        Me.Panel13.Controls.Add(Me.LBLSUBFIELDNO)
        Me.Panel13.Controls.Add(Me.LBLACTUAL)
        Me.Panel13.Controls.Add(Me.Label13)
        Me.Panel13.Controls.Add(Me.LBLFARMLOCATION)
        Me.Panel13.Controls.Add(Me.LBLLANDOWNER)
        Me.Panel13.Controls.Add(Me.Label16)
        Me.Panel13.Controls.Add(Me.Label18)
        Me.Panel13.Controls.Add(Me.LBLBUDGET)
        Me.Panel13.Controls.Add(Me.Label6)
        Me.Panel13.Controls.Add(Me.LBLFARMMANAGER)
        Me.Panel13.Controls.Add(Me.Label1)
        Me.Panel13.Controls.Add(Me.Panel12)
        Me.Panel13.Location = New System.Drawing.Point(0, 92)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1340, 180)
        Me.Panel13.TabIndex = 123158
        Me.Panel13.Visible = False
        '
        'LBLAGE
        '
        Me.LBLAGE.AutoSize = True
        Me.LBLAGE.Location = New System.Drawing.Point(635, 47)
        Me.LBLAGE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLAGE.Name = "LBLAGE"
        Me.LBLAGE.Size = New System.Drawing.Size(101, 17)
        Me.LBLAGE.TabIndex = 123203
        Me.LBLAGE.Text = "AGE OF CANE"
        '
        'LBLPLANTINGDATE
        '
        Me.LBLPLANTINGDATE.AutoSize = True
        Me.LBLPLANTINGDATE.Location = New System.Drawing.Point(635, 16)
        Me.LBLPLANTINGDATE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLPLANTINGDATE.Name = "LBLPLANTINGDATE"
        Me.LBLPLANTINGDATE.Size = New System.Drawing.Size(114, 17)
        Me.LBLPLANTINGDATE.TabIndex = 123205
        Me.LBLPLANTINGDATE.Text = "PLANTINGDATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(511, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 123202
        Me.Label7.Text = "AGE OF CANE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(511, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 123204
        Me.Label8.Text = "PLANTING DATE:"
        '
        'LBLASOFBUDGET
        '
        Me.LBLASOFBUDGET.AutoSize = True
        Me.LBLASOFBUDGET.Location = New System.Drawing.Point(1107, 46)
        Me.LBLASOFBUDGET.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLASOFBUDGET.Name = "LBLASOFBUDGET"
        Me.LBLASOFBUDGET.Size = New System.Drawing.Size(103, 17)
        Me.LBLASOFBUDGET.TabIndex = 123201
        Me.LBLASOFBUDGET.Text = "ASOFBUDGET"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(986, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 123200
        Me.Label4.Text = "AS OF BUDGET:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(497, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 152)
        Me.Panel1.TabIndex = 123199
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(977, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 155)
        Me.Panel2.TabIndex = 123198
        '
        'LBLREMARKS
        '
        Me.LBLREMARKS.AutoSize = True
        Me.LBLREMARKS.Location = New System.Drawing.Point(1107, 141)
        Me.LBLREMARKS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLREMARKS.Name = "LBLREMARKS"
        Me.LBLREMARKS.Size = New System.Drawing.Size(75, 17)
        Me.LBLREMARKS.TabIndex = 123197
        Me.LBLREMARKS.Text = "REMARKS"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(986, 140)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(79, 17)
        Me.Label35.TabIndex = 123196
        Me.Label35.Text = "REMARKS:"
        '
        'LBLLASTACTIVITY
        '
        Me.LBLLASTACTIVITY.AutoSize = True
        Me.LBLLASTACTIVITY.Location = New System.Drawing.Point(635, 140)
        Me.LBLLASTACTIVITY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLLASTACTIVITY.Name = "LBLLASTACTIVITY"
        Me.LBLLASTACTIVITY.Size = New System.Drawing.Size(107, 17)
        Me.LBLLASTACTIVITY.TabIndex = 123172
        Me.LBLLASTACTIVITY.Text = "LAST ACTIVITY"
        '
        'LBLFARMMODEL
        '
        Me.LBLFARMMODEL.AutoSize = True
        Me.LBLFARMMODEL.Location = New System.Drawing.Point(635, 108)
        Me.LBLFARMMODEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFARMMODEL.Name = "LBLFARMMODEL"
        Me.LBLFARMMODEL.Size = New System.Drawing.Size(99, 17)
        Me.LBLFARMMODEL.TabIndex = 123171
        Me.LBLFARMMODEL.Text = "FARM MODEL"
        '
        'LBLAREA
        '
        Me.LBLAREA.AutoSize = True
        Me.LBLAREA.Location = New System.Drawing.Point(635, 77)
        Me.LBLAREA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLAREA.Name = "LBLAREA"
        Me.LBLAREA.Size = New System.Drawing.Size(45, 17)
        Me.LBLAREA.TabIndex = 123193
        Me.LBLAREA.Text = "AREA"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(511, 107)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(103, 17)
        Me.Label49.TabIndex = 123168
        Me.Label49.Text = "FARM MODEL:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(511, 77)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 17)
        Me.Label38.TabIndex = 123190
        Me.Label38.Text = "AREA:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(511, 141)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(111, 17)
        Me.Label51.TabIndex = 123170
        Me.Label51.Text = "LAST ACTIVITY:"
        '
        'LBLVARIANCE
        '
        Me.LBLVARIANCE.AutoSize = True
        Me.LBLVARIANCE.Location = New System.Drawing.Point(1107, 109)
        Me.LBLVARIANCE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLVARIANCE.Name = "LBLVARIANCE"
        Me.LBLVARIANCE.Size = New System.Drawing.Size(76, 17)
        Me.LBLVARIANCE.TabIndex = 123186
        Me.LBLVARIANCE.Text = "VARIANCE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(986, 108)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 17)
        Me.Label24.TabIndex = 123185
        Me.Label24.Text = "VARIANCE:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(19, 78)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 17)
        Me.Label26.TabIndex = 123182
        Me.Label26.Text = "SUBFIELD NO:"
        '
        'LBLSUBFIELDNO
        '
        Me.LBLSUBFIELDNO.AutoSize = True
        Me.LBLSUBFIELDNO.Location = New System.Drawing.Point(164, 79)
        Me.LBLSUBFIELDNO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLSUBFIELDNO.Name = "LBLSUBFIELDNO"
        Me.LBLSUBFIELDNO.Size = New System.Drawing.Size(95, 17)
        Me.LBLSUBFIELDNO.TabIndex = 123179
        Me.LBLSUBFIELDNO.Text = "SUBFIELDNO"
        '
        'LBLACTUAL
        '
        Me.LBLACTUAL.AutoSize = True
        Me.LBLACTUAL.Location = New System.Drawing.Point(1107, 77)
        Me.LBLACTUAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLACTUAL.Name = "LBLACTUAL"
        Me.LBLACTUAL.Size = New System.Drawing.Size(62, 17)
        Me.LBLACTUAL.TabIndex = 123175
        Me.LBLACTUAL.Text = "ACTUAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(986, 76)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 17)
        Me.Label13.TabIndex = 123174
        Me.Label13.Text = "ACTUAL COST:"
        '
        'LBLFARMLOCATION
        '
        Me.LBLFARMLOCATION.AutoEllipsis = True
        Me.LBLFARMLOCATION.Location = New System.Drawing.Point(164, 109)
        Me.LBLFARMLOCATION.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFARMLOCATION.Name = "LBLFARMLOCATION"
        Me.LBLFARMLOCATION.Size = New System.Drawing.Size(310, 49)
        Me.LBLFARMLOCATION.TabIndex = 123172
        Me.LBLFARMLOCATION.Text = "FARM LOCATION"
        '
        'LBLLANDOWNER
        '
        Me.LBLLANDOWNER.AutoSize = True
        Me.LBLLANDOWNER.Location = New System.Drawing.Point(164, 16)
        Me.LBLLANDOWNER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLLANDOWNER.Name = "LBLLANDOWNER"
        Me.LBLLANDOWNER.Size = New System.Drawing.Size(98, 17)
        Me.LBLLANDOWNER.TabIndex = 123171
        Me.LBLLANDOWNER.Text = "LANDOWNER"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 17)
        Me.Label16.TabIndex = 123168
        Me.Label16.Text = "FARM MANAGER:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 109)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 17)
        Me.Label18.TabIndex = 123170
        Me.Label18.Text = "FARM LOCATION:"
        '
        'LBLBUDGET
        '
        Me.LBLBUDGET.AutoSize = True
        Me.LBLBUDGET.Location = New System.Drawing.Point(1107, 16)
        Me.LBLBUDGET.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBUDGET.Name = "LBLBUDGET"
        Me.LBLBUDGET.Size = New System.Drawing.Size(66, 17)
        Me.LBLBUDGET.TabIndex = 123164
        Me.LBLBUDGET.Text = "BUDGET"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(986, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 123163
        Me.Label6.Text = "BUDGET COST:"
        '
        'LBLFARMMANAGER
        '
        Me.LBLFARMMANAGER.AutoSize = True
        Me.LBLFARMMANAGER.Location = New System.Drawing.Point(164, 47)
        Me.LBLFARMMANAGER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFARMMANAGER.Name = "LBLFARMMANAGER"
        Me.LBLFARMMANAGER.Size = New System.Drawing.Size(123, 17)
        Me.LBLFARMMANAGER.TabIndex = 123160
        Me.LBLFARMMANAGER.Text = "FARM MANAGER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 123157
        Me.Label1.Text = "LAND OWNER:"
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(17, 175)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1311, 2)
        Me.Panel12.TabIndex = 123156
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'dgFieldInfo
        '
        Me.dgFieldInfo.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgFieldInfo.AllowEditing = False
        Me.dgFieldInfo.AllowFiltering = True
        Me.dgFieldInfo.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.dgFieldInfo.ColumnInfo = "2,0,0,0,0,105,Columns:"
        Me.dgFieldInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFieldInfo.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.dgFieldInfo.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgFieldInfo.Location = New System.Drawing.Point(3, 18)
        Me.dgFieldInfo.Name = "dgFieldInfo"
        Me.dgFieldInfo.Rows.DefaultSize = 21
        Me.dgFieldInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgFieldInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgFieldInfo.Size = New System.Drawing.Size(369, 375)
        Me.dgFieldInfo.StyleInfo = resources.GetString("dgFieldInfo.StyleInfo")
        Me.dgFieldInfo.TabIndex = 123160
        '
        'xCROPCLASS
        '
        Me.xCROPCLASS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xCROPCLASS.FormattingEnabled = True
        Me.xCROPCLASS.Location = New System.Drawing.Point(111, 12)
        Me.xCROPCLASS.Name = "xCROPCLASS"
        Me.xCROPCLASS.Size = New System.Drawing.Size(264, 24)
        Me.xCROPCLASS.TabIndex = 123161
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.X)
        Me.Panel3.Controls.Add(Me.xCROPCLASS)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1340, 50)
        Me.Panel3.TabIndex = 123206
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(12, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1318, 2)
        Me.Panel5.TabIndex = 123172
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Location = New System.Drawing.Point(5, 15)
        Me.X.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(99, 17)
        Me.X.TabIndex = 123171
        Me.X.Text = "CROP CLASS:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox3)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 142)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(375, 598)
        Me.Panel6.TabIndex = 123208
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgFieldInfo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 396)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FIELD INFO"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(375, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 598)
        Me.Panel4.TabIndex = 123209
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgFIELDCOST)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(965, 598)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OVER VIEW"
        '
        'dgFIELDCOST
        '
        Me.dgFIELDCOST.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgFIELDCOST.AllowEditing = False
        Me.dgFIELDCOST.AllowFiltering = True
        Me.dgFIELDCOST.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.dgFIELDCOST.BackColor = System.Drawing.Color.White
        Me.dgFIELDCOST.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.dgFIELDCOST.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.dgFIELDCOST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFIELDCOST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgFIELDCOST.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dgFIELDCOST.Location = New System.Drawing.Point(3, 18)
        Me.dgFIELDCOST.Margin = New System.Windows.Forms.Padding(4)
        Me.dgFIELDCOST.Name = "dgFIELDCOST"
        Me.dgFIELDCOST.Rows.DefaultSize = 21
        Me.dgFIELDCOST.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.dgFIELDCOST.Size = New System.Drawing.Size(959, 577)
        Me.dgFIELDCOST.StyleInfo = resources.GetString("dgFIELDCOST.StyleInfo")
        Me.dgFIELDCOST.TabIndex = 300
        Me.dgFIELDCOST.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.XGRANDTOTAL)
        Me.GroupBox3.Controls.Add(Me.xLBLLABORHAUL)
        Me.GroupBox3.Controls.Add(Me.xLBLACTUALCOST)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 202)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LABOR HAUL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 123173
        Me.Label2.Text = "ACTUAL COST:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 123174
        Me.Label3.Text = "LABOR HAUL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 123175
        Me.Label5.Text = "GRAND TOTAL:"
        '
        'XGRANDTOTAL
        '
        Me.XGRANDTOTAL.AutoSize = True
        Me.XGRANDTOTAL.Location = New System.Drawing.Point(162, 74)
        Me.XGRANDTOTAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.XGRANDTOTAL.Name = "XGRANDTOTAL"
        Me.XGRANDTOTAL.Size = New System.Drawing.Size(112, 17)
        Me.XGRANDTOTAL.TabIndex = 123178
        Me.XGRANDTOTAL.Text = "GRAND TOTAL:"
        '
        'xLBLLABORHAUL
        '
        Me.xLBLLABORHAUL.AutoSize = True
        Me.xLBLLABORHAUL.Location = New System.Drawing.Point(162, 50)
        Me.xLBLLABORHAUL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.xLBLLABORHAUL.Name = "xLBLLABORHAUL"
        Me.xLBLLABORHAUL.Size = New System.Drawing.Size(100, 17)
        Me.xLBLLABORHAUL.TabIndex = 123177
        Me.xLBLLABORHAUL.Text = "LABOR HAUL:"
        '
        'xLBLACTUALCOST
        '
        Me.xLBLACTUALCOST.AutoSize = True
        Me.xLBLACTUALCOST.Location = New System.Drawing.Point(162, 27)
        Me.xLBLACTUALCOST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.xLBLACTUALCOST.Name = "xLBLACTUALCOST"
        Me.xLBLACTUALCOST.Size = New System.Drawing.Size(108, 17)
        Me.xLBLACTUALCOST.TabIndex = 123176
        Me.xLBLACTUALCOST.Text = "ACTUAL COST:"
        '
        'frmDetailsPOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 762)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetailsPOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIELD COST DETAILS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFieldInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgFIELDCOST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents LBLFARMMANAGER As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLBUDGET As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents LBLREMARKS As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LBLLASTACTIVITY As System.Windows.Forms.Label
    Friend WithEvents LBLFARMMODEL As System.Windows.Forms.Label
    Friend WithEvents LBLAREA As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents LBLVARIANCE As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LBLSUBFIELDNO As System.Windows.Forms.Label
    Friend WithEvents LBLACTUAL As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LBLFARMLOCATION As System.Windows.Forms.Label
    Friend WithEvents LBLLANDOWNER As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLASOFBUDGET As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLAGE As Label
    Friend WithEvents LBLPLANTINGDATE As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgFieldInfo As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents xCROPCLASS As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents X As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgFIELDCOST As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents XGRANDTOTAL As Label
    Friend WithEvents xLBLLABORHAUL As Label
    Friend WithEvents xLBLACTUALCOST As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
