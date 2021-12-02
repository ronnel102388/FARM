Public Class frmMAJORADD
    Private Sub TxtMAJORACTIVITY_TextChanged(sender As Object, e As EventArgs) Handles MAJORACTIVITY.TextChanged
        If Not MAJORACTIVITY.Text = "" Then
            BtSave.Enabled = True
        Else
            BtSave.Enabled = False
        End If
    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        MAJORACTIVITY.Text = ""
        BtSave.Enabled = False
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If MAJORACTIVITY.Text = "" Then
            MsgBox("Please Add Major Activity", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If FindIfExist("MAJORACTIVITY", "M_POT_MAJORACTIVITY", "MAJORACTIVITY", MAJORACTIVITY.Text) >= 1 Then
            MsgBox("Major Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim sql As String = ""


        sql = <s>
                         INSERT INTO [M_POT_MAJORACTIVITY]
                        ([MAJORACTIVITY]
                        ,[COID]
                        ,[ISACTIVE]
                        ,[CREATEDBY]
                        ,[CREATIONDATE]
        ,[MODIFICATIONDATE])
                        VALUES
                        ('<%= MAJORACTIVITY.Text %>'
                        ,'<%= frmMAJOR.RbnCompany.Text %>'      
                        ,1
                        ,'<%= frmMAJOR.RbnUser.Text %>'
                        ,getdate()
                        ,getdate())
                      </s>

        ExeQuery(sql)
        MsgBox("Transaction successfully saved", MsgBoxStyle.Information, "Information")
        frmMAJOR.BtRefresh.PerformClick()
        btCancelUpdate.PerformClick()
    End Sub
End Class