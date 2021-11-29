<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(1044, 760)
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 760)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
End Class
