Public Class frmRESOURCESadd
    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        xRESOURCES.Text = ""
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If FindIfExist("RESOURCES", "M_POT_RESOURCES", "RESOURCES", xRESOURCES.Text) = xRESOURCES.Text Then
            MsgBox("Minor Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If


        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If


        Dim sql As String = ""
        sql = <s>
                         INSERT INTO [M_POT_RESOURCES]
           ([RESOURCES]
      ,[COID]
      ,[ISACTIVE]
      ,[CREATEDBY]
      ,[CREATIONDATE]
        )
     VALUES
           ('<%= xRESOURCES.Text %>'
            ,'<%= frmRESOURCES.RbnCompany.Text %>'
           ,1
            ,'<%= frmRESOURCES.RbnUser.Text %>'
            ,getdate()
                  )


                      </s>
        ExeQuery(sql)

        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        frmRESOURCES.BtRefresh.PerformClick()
        btCancelUpdate.PerformClick()
        frmRESOURCES.BtRefresh.PerformClick()
    End Sub

    Private Sub TxtRESOURCES_TextChanged(sender As Object, e As EventArgs) Handles xRESOURCES.TextChanged

        If Not xRESOURCES.Text = "" Then
            BtSave.Enabled = True
        Else
            BtSave.Enabled = False
        End If
    End Sub

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
End Class