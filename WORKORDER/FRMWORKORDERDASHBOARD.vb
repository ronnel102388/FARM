Public Class FRMWORKORDERDASHBOARD



    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub

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


    End Sub
#End Region
    Private Sub FRMWORKORDERDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        Label1.Text = x()
        FilterDGV.Text = "NO WORKORDER"
    End Sub
    Function x() As Integer
        Dim sql As String = <s>
 SELECT COUNT(WORKORDERCODE) as Count
FROM R_DAILYFIELDACTIVITYREPORT
WHERE STATUS='NO WORKORDER' and ISACTIVE ='true'
                            </s>
        ExeReader(sql)
        Dim find As Integer = 0
        While dr.Read
            find = dr.Item("count").ToString
        End While

        dr.Close()
        Conn.Close()

        Return find
    End Function



    Private Sub btnOpenNWO_Click(sender As Object, e As EventArgs) Handles btnOpenNWO.Click
        FRMNOWORKORDER.Show()
        FRMNOWORKORDER.BtRefresh.PerformClick()
    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click

        FilterDGV.Text = "NO WORKORDER"
        Dim sql As String = ""
        Dim search As String = FilterDGV.Text.Replace(" ", "")

        sql = <s>
                  SELECT * from R_DAILYFIELDACTIVITYREPORT where isactive ='true' and Status like '%<%= FilterDGV.Text %>%'

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
        Label1.Text = x()

    End Sub








    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim sql As String = ""
        Dim search As String = xsearch.Text.Replace(" ", "")

        sql = <s>
                  SELECT * from R_DAILYFIELDACTIVITYREPORT where isactive ='true' and status='NO WORKORDER'  and DFARNO like '%<%= search %>%'
                  
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



    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        FRMARCHIVE.ShowDialog()
    End Sub

    Private Sub FilterDGV_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles FilterDGV.SelectedIndexChanged
        If FilterDGV.Text = "VIEW ALL" Then
            Dim sql As String = ""
            Dim search As String = FilterDGV.Text.Replace(" ", "")

            sql = <s>
                  SELECT * from R_DAILYFIELDACTIVITYREPORT where isactive ='true'

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
            'xrecordcount.Text = grid1.Rows.Count - 1
            Label1.Text = x()
        Else

            Dim sql As String = ""
            Dim search As String = FilterDGV.Text.Replace(" ", "")

            sql = <s>
                  SELECT * from R_DAILYFIELDACTIVITYREPORT where isactive ='true' and Status like '%<%= FilterDGV.Text %>%'

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
            ' xrecordcount.Text = grid1.Rows.Count - 1
            Label1.Text = x()
        End If
    End Sub



    Private Sub grid1_DoubleClick(sender As Object, e As EventArgs) Handles grid1.DoubleClick
        FRMCREATION_NO_WORKORDER.Show()
        FRMCREATION_NO_WORKORDER.xCBOSUBFIELDNO.Enabled = False
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            SubFieldNum.Text = grid1.Item(i, "subfieldno").ToString
            MajorActivity.Text = grid1.Item(i, "MajorActivity").ToString
            MinorActivity.Text = grid1.Item(i, "MinorActivity").ToString
        End If

        FRMCREATION_NO_WORKORDER.xCBOSUBFIELDNO.Text = SubFieldNum.Text
        FRMCREATION_NO_WORKORDER.Button1.PerformClick()

        FRMCREATION_NO_WORKORDER.xCBOMAJORACTIVITY.Text = MajorActivity.Text
        FRMCREATION_NO_WORKORDER.xCBOMINORACTIVITY.Text = MinorActivity.Text



        'If FilterDGV.Text = "VIEW ALL" Or FilterDGV.Text = "NO WORKORDER" Or FilterDGV.Text = "WITH WORKORDER" Then
        '    Dim ii As Integer = grid1.RowSel

        '    If grid1.Rows.Count - 1 > 0 Then
        '        statuscheck.Text = grid1.Item(ii, "STATUS").ToString

        '        If statuscheck.Text = "NO WORKORDER" Then

        '            FRMNOWORKORDER.Show()

        '            Dim i As Integer = grid1.RowSel

        '            If grid1.Rows.Count - 1 > 0 Then
        '                FRMNOWORKORDER.DFARID.Text = grid1.Item(i, "DFARID").ToString
        '                FRMNOWORKORDER.TRANSMITTALNO.Text = grid1.Item(i, "TRANSMITTALNO").ToString
        '                FRMNOWORKORDER.SUBFIELDNO.Text = grid1.Item(i, "SUBFIELDNO").ToString
        '                FRMNOWORKORDER.MAJORACTIVITY.Text = grid1.Item(i, "MAJORACTIVITY").ToString
        '                FRMNOWORKORDER.MINORACTIVITY.Text = grid1.Item(i, "MINORACTIVITY").ToString
        '                FRMNOWORKORDER.SUBWAREHOUSE.Text = grid1.Item(i, "SUBWAREHOUSE").ToString
        '                FRMNOWORKORDER.METHODOFACTIVITY.Text = grid1.Item(i, "METHODOFACTIVITY").ToString
        '                FRMNOWORKORDER.TEAMLEADER.Text = grid1.Item(i, "TEAMLEADER").ToString
        '                FRMNOWORKORDER.CONTRACTOR.Text = grid1.Item(i, "CONTRACTOR").ToString
        '                FRMNOWORKORDER.FARMMANAGER.Text = grid1.Item(i, "FARMMANAGER").ToString
        '                FRMNOWORKORDER.FARMASSISTANT.Text = grid1.Item(i, "FARMASSISTANT").ToString
        '                FRMNOWORKORDER.STATUS.Text = grid1.Item(i, "STATUS").ToString
        '            End If
        '            FRMNOWORKORDER.btnrefreshworkorder.PerformClick()
        '            FRMNOWORKORDER.BtEdit.Enabled = False
        '            FRMNOWORKORDER.BtSave.Enabled = True
        '        Else
        '            MsgBox("Item already have WorkOrder.", MsgBoxStyle.Critical, "warning...")
        '        End If
        '    End If


        'End If

    End Sub

    Private Sub Grid1_Click(sender As Object, e As EventArgs) Handles grid1.Click

    End Sub
End Class
