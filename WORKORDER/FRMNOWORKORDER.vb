Public Class FRMNOWORKORDER
    Private Sub frmNoWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtRefresh.PerformClick()
        populate()
        WordOrder()
    End Sub
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            WorkOrder.Text = ""
            DFARID.Text = ""
            TRANSMITTALNO.Text = ""
            SUBFIELDNO.Text = ""
            MAJORACTIVITY.Text = ""
            MINORACTIVITY.Text = ""
            SUBWAREHOUSE.Text = ""
            METHODOFACTIVITY.Text = ""
            TEAMLEADER.Text = ""
            CONTRACTOR.Text = ""
            FARMMANAGER.Text = ""
            FARMASSISTANT.Text = ""
            STATUS.Text = ""
            WORKORDERID.Text = ""



        Else
            e.Cancel = True
        End If
    End Sub
    Sub populate()
        Dim sql As String = ""
        Dim search As String = xsearch.Text.Replace(" ", "")

        sql = <s>
                  SELECT * from r_DAILYFIELDACTIVITYREPORT where isactive ='true' and status='NO WORKORDER' 
                  
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
    Public Sub WordOrder()
        Dim sql As String = <s>
                        SELECT
WORKORDERCODE FROM
t_FarmActivityWorkOrder WO
INNER JOIN
t_FarmActivityMainWorkOrder MWO
ON WO.MainWOID = MWO.MainWOID
WHERE WO.IsClose = 0 AND WO.IsCancelled = 0
AND WO.IsActive = 1
AND MWO.IsActive = 1
AND MWO.IsClosed = 0
AND WO.SUBFIELDNO='<%= SUBFIELDNO.Text %>'
                            </s>

        ExeReader(sql)
        WorkOrder.Items.Clear()
        While dr.Read
            WorkOrder.Items.Add(dr.Item("WORKORDERCODE"))
        End While
        dr.Close()
        Conn.Close()
    End Sub




    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
        WorkOrder.Text = ""
        DFARID.Text = ""
        TRANSMITTALNO.Text = ""
        SUBFIELDNO.Text = ""
        MAJORACTIVITY.Text = ""
        MINORACTIVITY.Text = ""
        SUBWAREHOUSE.Text = ""
        METHODOFACTIVITY.Text = ""
        TEAMLEADER.Text = ""
        CONTRACTOR.Text = ""
        FARMMANAGER.Text = ""
        FARMASSISTANT.Text = ""
        STATUS.Text = ""
        WORKORDERID.Text = ""
        FindMajorActivity.Text = ""
        FindMinorActivity.Text = ""
        FindMethodOfActivity.Text = ""

        populate()
        WordOrder()
        FRMWORKORDERDASHBOARD.Button1.PerformClick()
        BtEdit.Enabled = True
        BtSave.Enabled = False
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            DFARID.Text = grid1.Item(i, "DFARID").ToString
            TRANSMITTALNO.Text = grid1.Item(i, "TRANSMITTALNO").ToString
            SUBFIELDNO.Text = grid1.Item(i, "SUBFIELDNO").ToString
            MAJORACTIVITY.Text = grid1.Item(i, "MAJORACTIVITY").ToString
            MINORACTIVITY.Text = grid1.Item(i, "MINORACTIVITY").ToString
            SUBWAREHOUSE.Text = grid1.Item(i, "SUBWAREHOUSE").ToString
            METHODOFACTIVITY.Text = grid1.Item(i, "METHODOFACTIVITY").ToString
            TEAMLEADER.Text = grid1.Item(i, "TEAMLEADER").ToString
            CONTRACTOR.Text = grid1.Item(i, "CONTRACTOR").ToString
            FARMMANAGER.Text = grid1.Item(i, "FARMMANAGER").ToString
            FARMASSISTANT.Text = grid1.Item(i, "FARMASSISTANT").ToString
            STATUS.Text = grid1.Item(i, "STATUS").ToString
        End If
        WordOrder()
        BtSave.Enabled = True
        btnrefreshworkorder.PerformClick()
    End Sub

    Private Sub WorkOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WorkOrder.SelectedIndexChanged

        WORKORDERID.Text = FindID("WorkOrderID", "vwAAA", "WorkOrderCode", WorkOrder.Text)

        FindMajorActivity.Text = FindActivity("MajorActivity", "WorkOrderCode", WorkOrder.Text)
        FindMinorActivity.Text = FindActivity("MinorActivity", "WorkOrderCode", WorkOrder.Text)
        FindMethodOfActivity.Text = FindActivity("MethodOfActivity", "WorkOrderCode", WorkOrder.Text)

    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click


        If WorkOrder.Text = "" Then
            MsgBox("Please select WorkOrder!", MsgBoxStyle.Critical, "warning...")
            Exit Sub
        End If

        If Not FindMajorActivity.Text = MAJORACTIVITY.Text And Not FindMinorActivity.Text = MINORACTIVITY.Text And Not FindMethodOfActivity.Text = METHODOFACTIVITY.Text Then
            MsgBox("Can't proceed!, Please check MajorActivity, MinorActivity, MethodOfActivity fields.", MsgBoxStyle.Critical, "warning...")
            Exit Sub
        End If


        Dim Sql As String = <s>
                          UPDATE R_DAILYFIELDACTIVITYREPORT
                               SET [WORKORDERID] =  '<%= WORKORDERID.Text %>'
                                ,[WorkOrderCode]='<%= WorkOrder.Text %>'
                                ,[STATUS]='WITH WORKORDER'
                                ,[MODIFIEDBY]='<%= FRMWORKORDERDASHBOARD.RbnUser %>'
                                ,[MODIFICATIONDATE]=getdate()
                             WHERE DFARID = <%= DFARID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("SUCCESS.", MsgBoxStyle.Information, "Information...")

        BtRefresh.PerformClick()
        FRMWORKORDERDASHBOARD.Button1.PerformClick()
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

    Public Sub btnrefreshworkorder_Click(sender As Object, e As EventArgs) Handles btnrefreshworkorder.Click
        WordOrder()
    End Sub


    Private Sub grid1_Click(sender As Object, e As EventArgs) Handles grid1.Click
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            DFARID.Text = grid1.Item(i, "DFARID").ToString
            TRANSMITTALNO.Text = grid1.Item(i, "TRANSMITTALNO").ToString
            SUBFIELDNO.Text = grid1.Item(i, "SUBFIELDNO").ToString
            MAJORACTIVITY.Text = grid1.Item(i, "MAJORACTIVITY").ToString
            MINORACTIVITY.Text = grid1.Item(i, "MINORACTIVITY").ToString
            SUBWAREHOUSE.Text = grid1.Item(i, "SUBWAREHOUSE").ToString
            METHODOFACTIVITY.Text = grid1.Item(i, "METHODOFACTIVITY").ToString
            TEAMLEADER.Text = grid1.Item(i, "TEAMLEADER").ToString
            CONTRACTOR.Text = grid1.Item(i, "CONTRACTOR").ToString
            FARMMANAGER.Text = grid1.Item(i, "FARMMANAGER").ToString
            FARMASSISTANT.Text = grid1.Item(i, "FARMASSISTANT").ToString
            STATUS.Text = grid1.Item(i, "STATUS").ToString
        End If

        BtSave.Enabled = True
        BtEdit.Enabled = False
        WordOrder()
    End Sub


End Class