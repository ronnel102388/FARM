Public Class FRMCHECKACTIVITYDATE
    Private Sub FRMCHECKACTIVITYDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Format(Now, "Short date")

        Dim sql As String = ""


        sql = <s>
        SELECT WorkOrderCode, ActivityDate, IsActive, IsClose
        FROM  dbo.t_FarmActivityWorkOrder
        WHERE (IsActive = 1) AND (IsClose = 0) and WorkOrderCode >='<%= TextBox1.Text %>'

              </s>

        SelectQuery(sql)
        With grid1
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            '.Cols("RECID").Caption = "ID"
            .AutoSizeCols()

        End With


    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

    End Sub
End Class