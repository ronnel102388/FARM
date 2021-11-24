<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMNOWORKORDER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMNOWORKORDER))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FindMethodOfActivity = New System.Windows.Forms.TextBox()
        Me.FindMinorActivity = New System.Windows.Forms.TextBox()
        Me.FindMajorActivity = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnrefreshworkorder = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.WORKORDERID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.STATUS = New System.Windows.Forms.TextBox()
        Me.FARMASSISTANT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FARMMANAGER = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CONTRACTOR = New System.Windows.Forms.TextBox()
        Me.TEAMLEADER = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.METHODOFACTIVITY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SUBWAREHOUSE = New System.Windows.Forms.TextBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.xsearch = New System.Windows.Forms.TextBox()
        Me.grid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.BTEXPORT = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.bTpRINT = New System.Windows.Forms.Button()
        Me.btCancelUpdate = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtRefresh = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.MINORACTIVITY = New System.Windows.Forms.TextBox()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WorkOrder = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SUBFIELDNO = New System.Windows.Forms.TextBox()
        Me.TRANSMITTALNO = New System.Windows.Forms.TextBox()
        Me.DFARID = New System.Windows.Forms.TextBox()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.MAJORACTIVITY = New System.Windows.Forms.TextBox()
        Me.Panel6.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(501, 618)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 17)
        Me.Label18.TabIndex = 123225
        Me.Label18.Text = "MINORACTIVITY:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(464, 646)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 17)
        Me.Label17.TabIndex = 123224
        Me.Label17.Text = "METHODOFACTIVITY:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(501, 590)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 17)
        Me.Label16.TabIndex = 123223
        Me.Label16.Text = "MAJORACTIVITY:"
        '
        'FindMethodOfActivity
        '
        Me.FindMethodOfActivity.Enabled = False
        Me.FindMethodOfActivity.Location = New System.Drawing.Point(641, 646)
        Me.FindMethodOfActivity.Name = "FindMethodOfActivity"
        Me.FindMethodOfActivity.Size = New System.Drawing.Size(186, 22)
        Me.FindMethodOfActivity.TabIndex = 123222
        '
        'FindMinorActivity
        '
        Me.FindMinorActivity.Enabled = False
        Me.FindMinorActivity.Location = New System.Drawing.Point(641, 618)
        Me.FindMinorActivity.Name = "FindMinorActivity"
        Me.FindMinorActivity.Size = New System.Drawing.Size(186, 22)
        Me.FindMinorActivity.TabIndex = 123221
        '
        'FindMajorActivity
        '
        Me.FindMajorActivity.Enabled = False
        Me.FindMajorActivity.Location = New System.Drawing.Point(641, 590)
        Me.FindMajorActivity.Name = "FindMajorActivity"
        Me.FindMajorActivity.Size = New System.Drawing.Size(186, 22)
        Me.FindMajorActivity.TabIndex = 123220
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 816)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1345, 22)
        Me.StatusStrip1.TabIndex = 123219
        Me.StatusStrip1.Tag = "XC"
        Me.StatusStrip1.Text = "PROGEN 1.2.x as of DateTime"
        '
        'btnrefreshworkorder
        '
        Me.btnrefreshworkorder.Image = CType(resources.GetObject("btnrefreshworkorder.Image"), System.Drawing.Image)
        Me.btnrefreshworkorder.Location = New System.Drawing.Point(430, 560)
        Me.btnrefreshworkorder.Name = "btnrefreshworkorder"
        Me.btnrefreshworkorder.Size = New System.Drawing.Size(34, 28)
        Me.btnrefreshworkorder.TabIndex = 123218
        Me.btnrefreshworkorder.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(523, 562)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 17)
        Me.Label15.TabIndex = 123217
        Me.Label15.Text = "WorkOrder ID:"
        '
        'WORKORDERID
        '
        Me.WORKORDERID.Enabled = False
        Me.WORKORDERID.Location = New System.Drawing.Point(641, 562)
        Me.WORKORDERID.Name = "WORKORDERID"
        Me.WORKORDERID.Size = New System.Drawing.Size(186, 22)
        Me.WORKORDERID.TabIndex = 123216
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1073, 782)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 123215
        Me.Label12.Text = "STATUS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1014, 754)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 123214
        Me.Label13.Text = "FARMASSISTANT:"
        '
        'STATUS
        '
        Me.STATUS.Enabled = False
        Me.STATUS.Location = New System.Drawing.Point(1146, 782)
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(175, 22)
        Me.STATUS.TabIndex = 123213
        '
        'FARMASSISTANT
        '
        Me.FARMASSISTANT.Enabled = False
        Me.FARMASSISTANT.Location = New System.Drawing.Point(1146, 754)
        Me.FARMASSISTANT.Name = "FARMASSISTANT"
        Me.FARMASSISTANT.Size = New System.Drawing.Size(175, 22)
        Me.FARMASSISTANT.TabIndex = 123212
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1014, 729)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 17)
        Me.Label14.TabIndex = 123211
        Me.Label14.Text = "FARMMANAGER:"
        '
        'FARMMANAGER
        '
        Me.FARMMANAGER.Enabled = False
        Me.FARMMANAGER.Location = New System.Drawing.Point(1146, 726)
        Me.FARMMANAGER.Name = "FARMMANAGER"
        Me.FARMMANAGER.Size = New System.Drawing.Size(175, 22)
        Me.FARMMANAGER.TabIndex = 123210
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(710, 785)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 17)
        Me.Label9.TabIndex = 123209
        Me.Label9.Text = "CONTRACTOR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(714, 757)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 123208
        Me.Label10.Text = "TEAMLEADER:"
        '
        'CONTRACTOR
        '
        Me.CONTRACTOR.Enabled = False
        Me.CONTRACTOR.Location = New System.Drawing.Point(825, 785)
        Me.CONTRACTOR.Name = "CONTRACTOR"
        Me.CONTRACTOR.Size = New System.Drawing.Size(175, 22)
        Me.CONTRACTOR.TabIndex = 123207
        '
        'TEAMLEADER
        '
        Me.TEAMLEADER.Enabled = False
        Me.TEAMLEADER.Location = New System.Drawing.Point(825, 757)
        Me.TEAMLEADER.Name = "TEAMLEADER"
        Me.TEAMLEADER.Size = New System.Drawing.Size(175, 22)
        Me.TEAMLEADER.TabIndex = 123206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(668, 729)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 17)
        Me.Label11.TabIndex = 123205
        Me.Label11.Text = "METHODOFACTIVITY:"
        '
        'METHODOFACTIVITY
        '
        Me.METHODOFACTIVITY.Enabled = False
        Me.METHODOFACTIVITY.Location = New System.Drawing.Point(825, 729)
        Me.METHODOFACTIVITY.Name = "METHODOFACTIVITY"
        Me.METHODOFACTIVITY.Size = New System.Drawing.Size(175, 22)
        Me.METHODOFACTIVITY.TabIndex = 123204
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 700)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 123203
        Me.Label8.Text = "Identification:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(114, 708)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 1)
        Me.Panel1.TabIndex = 123202
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 785)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 123201
        Me.Label4.Text = "SUBWAREHOUSE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 757)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 123200
        Me.Label5.Text = "MINORACTIVITY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 729)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 123199
        Me.Label6.Text = "MAJORACTIVITY:"
        '
        'SUBWAREHOUSE
        '
        Me.SUBWAREHOUSE.Enabled = False
        Me.SUBWAREHOUSE.Location = New System.Drawing.Point(477, 785)
        Me.SUBWAREHOUSE.Name = "SUBWAREHOUSE"
        Me.SUBWAREHOUSE.Size = New System.Drawing.Size(185, 22)
        Me.SUBWAREHOUSE.TabIndex = 123198
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
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.xsearch)
        Me.Panel6.Controls.Add(Me.btSearch)
        Me.Panel6.Location = New System.Drawing.Point(963, 11)
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
        'grid1
        '
        Me.grid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.grid1.AllowEditing = False
        Me.grid1.AllowFiltering = True
        Me.grid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.grid1.BackColor = System.Drawing.Color.White
        Me.grid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.grid1.ColumnInfo = "0,0,0,0,0,105,Columns:"
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.grid1.Location = New System.Drawing.Point(0, 64)
        Me.grid1.Margin = New System.Windows.Forms.Padding(4)
        Me.grid1.Name = "grid1"
        Me.grid1.Rows.DefaultSize = 21
        Me.grid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.grid1.Size = New System.Drawing.Size(1345, 481)
        Me.grid1.StyleInfo = resources.GetString("grid1.StyleInfo")
        Me.grid1.TabIndex = 123187
        Me.grid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
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
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(9, 13)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(38, 36)
        Me.btAdd.TabIndex = 123144
        Me.btAdd.UseVisualStyleBackColor = False
        Me.btAdd.Visible = False
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
        'MINORACTIVITY
        '
        Me.MINORACTIVITY.Enabled = False
        Me.MINORACTIVITY.Location = New System.Drawing.Point(477, 757)
        Me.MINORACTIVITY.Name = "MINORACTIVITY"
        Me.MINORACTIVITY.Size = New System.Drawing.Size(185, 22)
        Me.MINORACTIVITY.TabIndex = 123197
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1345, 2)
        Me.Panel7.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 562)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 17)
        Me.Label7.TabIndex = 123195
        Me.Label7.Text = "SELECT WORKORDER:"
        '
        'WorkOrder
        '
        Me.WorkOrder.FormattingEnabled = True
        Me.WorkOrder.Location = New System.Drawing.Point(201, 562)
        Me.WorkOrder.Name = "WorkOrder"
        Me.WorkOrder.Size = New System.Drawing.Size(223, 24)
        Me.WorkOrder.TabIndex = 123194
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 785)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 123193
        Me.Label3.Text = "SUBFIELDNO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 757)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 123192
        Me.Label2.Text = "TRANSMITTALNO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 729)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 123191
        Me.Label1.Text = "DFARID:"
        '
        'SUBFIELDNO
        '
        Me.SUBFIELDNO.Enabled = False
        Me.SUBFIELDNO.Location = New System.Drawing.Point(142, 785)
        Me.SUBFIELDNO.Name = "SUBFIELDNO"
        Me.SUBFIELDNO.Size = New System.Drawing.Size(189, 22)
        Me.SUBFIELDNO.TabIndex = 123190
        '
        'TRANSMITTALNO
        '
        Me.TRANSMITTALNO.Enabled = False
        Me.TRANSMITTALNO.Location = New System.Drawing.Point(142, 757)
        Me.TRANSMITTALNO.Name = "TRANSMITTALNO"
        Me.TRANSMITTALNO.Size = New System.Drawing.Size(189, 22)
        Me.TRANSMITTALNO.TabIndex = 123189
        '
        'DFARID
        '
        Me.DFARID.Enabled = False
        Me.DFARID.Location = New System.Drawing.Point(142, 729)
        Me.DFARID.Name = "DFARID"
        Me.DFARID.Size = New System.Drawing.Size(189, 22)
        Me.DFARID.TabIndex = 123188
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
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1345, 64)
        Me.PanelHeader.TabIndex = 123186
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
        Me.BtEdit.TabIndex = 123135
        Me.BtEdit.UseVisualStyleBackColor = False
        '
        'MAJORACTIVITY
        '
        Me.MAJORACTIVITY.Enabled = False
        Me.MAJORACTIVITY.Location = New System.Drawing.Point(477, 729)
        Me.MAJORACTIVITY.Name = "MAJORACTIVITY"
        Me.MAJORACTIVITY.Size = New System.Drawing.Size(185, 22)
        Me.MAJORACTIVITY.TabIndex = 123196
        '
        'FRMNOWORKORDER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 838)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.FindMethodOfActivity)
        Me.Controls.Add(Me.FindMinorActivity)
        Me.Controls.Add(Me.FindMajorActivity)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnrefreshworkorder)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.WORKORDERID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.STATUS)
        Me.Controls.Add(Me.FARMASSISTANT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.FARMMANAGER)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CONTRACTOR)
        Me.Controls.Add(Me.TEAMLEADER)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.METHODOFACTIVITY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SUBWAREHOUSE)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.MINORACTIVITY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WorkOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SUBFIELDNO)
        Me.Controls.Add(Me.TRANSMITTALNO)
        Me.Controls.Add(Me.DFARID)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MAJORACTIVITY)
        Me.Name = "FRMNOWORKORDER"
        Me.Text = "FRMNOWORKORDER"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents FindMethodOfActivity As TextBox
    Friend WithEvents FindMinorActivity As TextBox
    Friend WithEvents FindMajorActivity As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnrefreshworkorder As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents WORKORDERID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents STATUS As TextBox
    Friend WithEvents FARMASSISTANT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents FARMMANAGER As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CONTRACTOR As TextBox
    Friend WithEvents TEAMLEADER As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents METHODOFACTIVITY As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SUBWAREHOUSE As TextBox
    Friend WithEvents btSearch As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents xsearch As TextBox
    Friend WithEvents grid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents BTEXPORT As Button
    Friend WithEvents btAdd As Button
    Friend WithEvents bTpRINT As Button
    Friend WithEvents btCancelUpdate As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BtRefresh As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents MINORACTIVITY As TextBox
    Friend WithEvents BtDelete As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents WorkOrder As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SUBFIELDNO As TextBox
    Friend WithEvents TRANSMITTALNO As TextBox
    Friend WithEvents DFARID As TextBox
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents BtEdit As Button
    Friend WithEvents MAJORACTIVITY As TextBox
End Class
