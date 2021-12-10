<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOTCONN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOTCONN))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.xsearch = New System.Windows.Forms.TextBox()
        Me.tsSearch = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tsRefresh = New System.Windows.Forms.Button()
        Me.tsEdit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.dgCON = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RbnBuildNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel12)
        Me.PanelHeader.Controls.Add(Me.Panel7)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 28)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(849, 64)
        Me.PanelHeader.TabIndex = 506
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.xsearch)
        Me.Panel12.Controls.Add(Me.tsSearch)
        Me.Panel12.Location = New System.Drawing.Point(474, 11)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(367, 43)
        Me.Panel12.TabIndex = 123151
        '
        'xsearch
        '
        Me.xsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xsearch.Font = New System.Drawing.Font("Century Gothic", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xsearch.Location = New System.Drawing.Point(6, 10)
        Me.xsearch.Name = "xsearch"
        Me.xsearch.Size = New System.Drawing.Size(317, 25)
        Me.xsearch.TabIndex = 123147
        '
        'tsSearch
        '
        Me.tsSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsSearch.BackColor = System.Drawing.Color.White
        Me.tsSearch.FlatAppearance.BorderSize = 0
        Me.tsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.Location = New System.Drawing.Point(326, 3)
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(38, 36)
        Me.tsSearch.TabIndex = 123146
        Me.tsSearch.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(849, 2)
        Me.Panel7.TabIndex = 8
        '
        'tsRefresh
        '
        Me.tsRefresh.BackColor = System.Drawing.Color.Transparent
        Me.tsRefresh.FlatAppearance.BorderSize = 0
        Me.tsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsRefresh.Location = New System.Drawing.Point(6, 25)
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(134, 36)
        Me.tsRefresh.TabIndex = 123144
        Me.tsRefresh.Text = "   REFRESH"
        Me.tsRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tsRefresh.UseVisualStyleBackColor = False
        '
        'tsEdit
        '
        Me.tsEdit.BackColor = System.Drawing.Color.Transparent
        Me.tsEdit.FlatAppearance.BorderSize = 0
        Me.tsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsEdit.Location = New System.Drawing.Point(6, 67)
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(134, 36)
        Me.tsEdit.TabIndex = 123135
        Me.tsEdit.Text = "    DETAIL"
        Me.tsEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tsEdit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(849, 28)
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
        Me.TabControl1.Controls.Add(Me.dgCON)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(708, 522)
        Me.TabControl1.TabIndex = 507
        '
        'dgCON
        '
        Me.dgCON.Location = New System.Drawing.Point(4, 25)
        Me.dgCON.Name = "dgCON"
        Me.dgCON.Padding = New System.Windows.Forms.Padding(3)
        Me.dgCON.Size = New System.Drawing.Size(700, 493)
        Me.dgCON.TabIndex = 1
        Me.dgCON.Text = "General"
        Me.dgCON.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 614)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(849, 2)
        Me.Panel9.TabIndex = 525
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RbnBuildNo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 616)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(849, 24)
        Me.StatusStrip1.TabIndex = 526
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tsEdit)
        Me.Panel1.Controls.Add(Me.tsRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(708, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 522)
        Me.Panel1.TabIndex = 527
        '
        'frmPOTCONN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 640)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOTCONN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW POT Conection to OLD POT"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents tsRefresh As System.Windows.Forms.Button
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
    Friend WithEvents dgCON As System.Windows.Forms.TabPage
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RbnBuildNo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents xsearch As TextBox
    Friend WithEvents tsSearch As Button
    Friend WithEvents Panel1 As Panel
End Class
