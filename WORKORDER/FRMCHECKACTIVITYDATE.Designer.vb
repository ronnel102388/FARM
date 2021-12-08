<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMCHECKACTIVITYDATE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMCHECKACTIVITYDATE))
        Me.grid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.grid1.Location = New System.Drawing.Point(0, 122)
        Me.grid1.Margin = New System.Windows.Forms.Padding(4)
        Me.grid1.Name = "grid1"
        Me.grid1.Rows.DefaultSize = 21
        Me.grid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.grid1.Size = New System.Drawing.Size(787, 325)
        Me.grid1.StyleInfo = resources.GetString("grid1.StyleInfo")
        Me.grid1.TabIndex = 123188
        Me.grid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(738, 79)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(38, 36)
        Me.btAdd.TabIndex = 123189
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 123190
        '
        'FRMCHECKACTIVITYDATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.grid1)
        Me.Name = "FRMCHECKACTIVITYDATE"
        Me.Text = "FRMCHECKACTIVITYDATE"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btAdd As Button
    Friend WithEvents TextBox1 As TextBox
End Class
