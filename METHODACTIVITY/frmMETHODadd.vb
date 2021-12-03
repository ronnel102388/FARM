Public Class frmMETHODadd
    Private Sub METHODACTIVITY_TextChanged(sender As Object, e As EventArgs) Handles METHODACTIVITY.TextChanged

        If Not METHODACTIVITY.Text = "" Then
            BtSave.Enabled = True
        Else
            BtSave.Enabled = False
        End If
    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        METHODACTIVITY.Text = ""
        BtSave.Enabled = False
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If FindIfExist("METHODACTIVITY", "M_POT_METHODOFACTIVITY", "METHODACTIVITY", METHODACTIVITY.Text) = METHODACTIVITY.Text Then
            MsgBox("Method of Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If


        Dim sql As String = ""
        sql = <s>
                         INSERT INTO [M_POT_METHODOFACTIVITY]
           ([METHODACTIVITY]
      ,[COID]
      ,[ISACTIVE]
      ,[CREATEDBY]
      ,[CREATIONDATE]
        )
     VALUES
           ('<%= METHODACTIVITY.Text %>'
            ,'<%= frmMETHOD.RbnCompany.Text %>'
           ,1
            ,'<%= frmMETHOD.RbnUser.Text %>'
            ,getdate()
                  )


                      </s>
        ExeQuery(sql)

        MsgBox("Success.", MsgBoxStyle.Information, "Information")


        btCancelUpdate.PerformClick()
        frmMETHOD.BtRefresh.PerformClick()
    End Sub
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
End Class