Public Class FRMWORKORDERDASHBOARD
#Region "Populate"
    Sub populate()
        Dim sql As String = ""
        Dim search As String = xsearch.Text.Replace(" ", "")

        sql = <s>
                  SELECT * from R_DAILYFIELDACTIVITYREPORT where isactive ='1' AND STATUS='NO WORKORDER'
                  
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
        xrecordcount.Text = grid1.Rows.Count

    End Sub
#End Region
    Private Sub FRMWORKORDERDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
End Class