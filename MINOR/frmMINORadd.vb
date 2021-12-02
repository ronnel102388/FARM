Public Class frmMINORadd
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If FindIfExist("MINORACTIVITY", "M_POT_MINORACTIVITY", "MINORACTIVITY", MINORACTIVITY.Text) = MINORACTIVITY.Text Then
            MsgBox("Minor Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If


        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If


        Dim sql As String = ""
        sql = <s>
                         INSERT INTO [M_POT_MINORACTIVITY]
           ([MINORACTIVITY]
      ,[COID]
      ,[ISACTIVE]
      ,[CREATEDBY]
      ,[CREATIONDATE]
        )
     VALUES
           ('<%= MINORACTIVITY.Text %>'
            ,'<%= frmMinor.RbnCompany.Text %>'
           ,1
            ,'<%= frmMinor.RbnUser.Text %>'
            ,getdate()
                  )


                      </s>
        ExeQuery(sql)

        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        frmMinor.BtRefresh.PerformClick()
        btCancelUpdate.PerformClick()
    End Sub

    Private Sub MINORACTIVITY_TextChanged(sender As Object, e As EventArgs) Handles MINORACTIVITY.TextChanged
        If Not MINORACTIVITY.Text = "" Then
            BtSave.Enabled = True
        Else
            BtSave.Enabled = False
        End If
    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        MINORACTIVITY.Text = ""
    End Sub
End Class