Public Class FRMARCHIVE
    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
        RECID.Text = ""
        DAYSTOARCHIVE.Text = 0
        INTERVALDAYSTOARCHIVE.Text = 0
        EFFECTIVITYDATE.Text = ""
        populate()
    End Sub

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FRMARCHIVE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        EFFECTIVITYDATE.Format = DateTimePickerFormat.Custom
        EFFECTIVITYDATE.CustomFormat = "MM/dd/yyyy"
    End Sub
    Sub populate()
        Dim sql As String = ""


        sql = <s>
                SELECT TOP (1) RECID, DAYSTOARCHIVE, INTERVALDAYSTOARCHIVE, EFFECTIVITYDATE, CREATEDBY, CREATIONDATE, ISACTIVE
FROM  dbo.M_WORKORDER_ARCHIVE_SETTINGS where isactive=1
ORDER BY CREATIONDATE DESC
                  
              </s>

        SelectQuery(sql)
        With grid1
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            .Cols("RECID").Caption = "ID"
            .AutoSizeCols()

        End With


    End Sub
    Private Sub DAYSTOARCHIVE_ValueChanged(sender As Object, e As EventArgs) Handles DAYSTOARCHIVE.ValueChanged
        If Not DAYSTOARCHIVE.Value = 0 Then
            btAdd.Enabled = True
        Else
            btAdd.Enabled = False
        End If
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim sql As String = ""
        sql = <s>
                         INSERT INTO [M_WORKORDER_ARCHIVE_SETTINGS]
           ([DAYSTOARCHIVE]
            ,[INTERVALDAYSTOARCHIVE]
            ,[EFFECTIVITYDATE]
            ,[CREATEDBY]
            ,[CREATIONDATE]
            
            ,[ISACTIVE]
            
        )
     VALUES
           ('<%= DAYSTOARCHIVE.Text %>'
            ,'<%= INTERVALDAYSTOARCHIVE.Text %>'
            ,'<%= EFFECTIVITYDATE.Text %>'
            ,'<%= FRMWORKORDERDASHBOARD.RbnUser.Text %>'
            ,getdate()
            
            ,1
           )


                      </s>
        ExeQuery(sql)

        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        BtRefresh.PerformClick()
    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click
        Dim i As Integer = grid1.RowSel
        If grid1.Rows.Count - 1 > 0 Then
            RECID.Text = grid1.Item(i, "RECID").ToString
        End If

        If RECID.Text = "" Then
            Exit Sub
        End If






        Dim Sql As String = <s>
                          UPDATE T_DateToArchive
                               SET [ISACTIVE] = '0'
                             WHERE RECID = <%= RECID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "Validation")
        BtRefresh.PerformClick()
    End Sub
End Class