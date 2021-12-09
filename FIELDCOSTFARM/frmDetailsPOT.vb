Imports C1.Win.C1FlexGrid
Imports Configuration
Public Class frmDetailsPOT
    Public FM, CY, CC, SF, TP As String
    Public AREA As Double
    Public isCB, TMPID As Integer
    Public vACTUAL, vLABORHAUL As Double
    Dim dtINFO As DataTable
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")

    Sub POPULATECROPCLASS(ByVal SF As String)
        Try
            Dim sql As String = <s>
                              
                                    /*------------------------MWO-----------------------------------*/
                                    SELECT distinct CROPLCLASSDETAIL +' | '+ 
                                    CASE 
                                    WHEN ISNULL(Cropyear,'') = '' THEN 
                                    (SELECT CropYear FROM t_SubFieldNo SF WHERE SF.SubFieldNo = x.FIELDNO AND IsActive =1 )
                                    ELSE
                                    CropYear
                                    END
                                    AS LIST
                                    ,FieldNo
                                    ,CroplClassDetail
                                    ,CropYear
                                    INTO #TEMP_MWO
                                    FROM T_FARMACTIVITYMAINWORKORDER  X

                                    /*------------------------WO-----------------------------------*/
                                    SELECT MainWOID 
                                    ,SUBFIELDNO
                                    ,CropClassDetail
                                    ,CASE 
                                    WHEN ISNULL(Cropyear,'') = '' THEN 
                                    (SELECT CropYear FROM t_SubFieldNo SF WHERE SF.SubFieldNo = x.SubFieldNo AND IsActive =1 )
                                    ELSE
                                    CropYear
                                    END
                                    AS CropYear
                                    ,ActivityDate
                                    INTO #TEMP_WO
                                    FROM T_FARMACTIVITYWORKORDER  X


                                    select * 
                                    ,(SELECT TOP 1 ACTIVITYDATE FROM #TEMP_WO x WHERE x.SubFieldNo = a.FieldNo AND x.CropClassDetail = a.CroplClassDetail  
                                    AND X.CropYear = A.CropYear    ORDER BY ACTIVITYDATE DESC) AS ACTIVITYDATE
                                    from #TEMP_MWO a
                                    where
                                    FieldNo = '<%= SF %>'
                                    order by ACTIVITYDATE desc

                                    drop table #TEMP_MWO,#TEMP_WO
                                </s>
            ExeReader(sql)
        xCROPCLASS.Items.Clear()
        While dr.Read
            xCROPCLASS.Items.Add(dr.Item("LIST"))
        End While
        dr.Close()
        Conn.Close()

        xCROPCLASS.SelectedIndex = 0
        Catch ex As Exception
        MsgBox("No Data Input.", MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub
    Sub FIELDINFO(ByVal fm As String, sf As String, ByVal iscb As Integer, ByVal type As String, ByVal cc As String, ByVal cy As String)
        Dim sql As String = <S>
                              EXEC FM_LIST_POT_DETAIL '<%= fm %>','<%= cc %>', '<%= sf %>', <%= iscb %>, '<%= type %>', '<%= cy %>'
                            </S>

        dtINFO = ConTools.DataReader(SConn, sql)
    End Sub
    Sub POPULATEDETAILS(ByVal fmd As String, ByVal ccd As String, ByVal iscbd As String, ByVal tpd As String, ByVal sfd As String, ByVal aread As Double)
        Dim SQL As String = <s>
                                     EXEC FM_SF_LIST_POT '<%= fmd %>','<%= ccd %>', <%= iscbd %>, '<%= tpd %>','<%= sfd %>','<%= aread %>'
                            </s>
        SelectQuery(SQL)
        With dgFIELDCOST
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .AutoSizeCols()
            .Cols("BUDGETQTY").Format = "N2"
            .Cols("BUDGETQTY").TextAlign = TextAlignEnum.CenterCenter
            .Cols("ACTUALQTY").Format = "N2"
            .Cols("ACTUALQTY").TextAlign = TextAlignEnum.CenterCenter

            .Cols("ACCOMPLISHMENTDONE").Visible = False
            .Cols("BUDGETCOST").Format = "N0"
            .Cols("BUDGETCOST").TextAlign = TextAlignEnum.CenterCenter
            .Cols("ACTUALCOST").Format = "N0"
            .Cols("ACTUALCOST").TextAlign = TextAlignEnum.CenterCenter

            .Cols("RESOURCE").Width = 400
            .Cols("DFARSERIES").Visible = False

            .Cols("POT_ORDER").Visible = False
            .Cols("SUBFIELDNO").Visible = False

            .Cols("ACTIVITYDATE").TextAlign = TextAlignEnum.CenterCenter
        End With


        setgrid()

    End Sub

    Sub setgrid()
        With dgFIELDCOST
            .Tree.Style = TreeStyleFlags.Complete
            .Cols(0).Visible = False
            .Cols(1).Visible = False
            .Cols(2).Visible = False
            .Cols(3).Visible = False
            .Cols(4).Visible = False
            .Tree.Column = 5
            .Subtotal(AggregateEnum.None, 0, .Cols("CROPCLASS").Index, .Cols("CROPCLASS").Index, "{0}")
            .Subtotal(AggregateEnum.None, 1, .Cols("MAJORACTIVITY").Index, .Cols("MAJORACTIVITY").Index, "{0}")
            .Subtotal(AggregateEnum.None, 2, .Cols("MINORACTIVITY").Index, .Cols("MINORACTIVITY").Index, "{0}")
            .Subtotal(AggregateEnum.None, 3, .Cols("METHODOFACTIVITY").Index, .Cols("METHODOFACTIVITY").Index, "{0}")
            .Subtotal(AggregateEnum.None, -1, -1, -1, "TOTAL")


            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("ACTUALCOST").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("BUDGETCOST").Index, "{0}")
            '.Cols.Frozen = 4
            '.AutoSizeCols()
        End With
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POPULATECROPCLASS(SF)
        LBLFARMMANAGER.Text = FM.ToUpper


        'POPULATEDETAILS()
    End Sub
    Private Sub BTEXPORT_Click(sender As Object, e As EventArgs) Handles BTEXPORT.Click
        If CheckState <> "True" Then
            If ConTools.CheckAccess(frmMain.RbnUser.Text, frmMain.RbnExeCode.Text, "IsExport") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If

        Dim sfd As New SaveFileDialog

        With sfd
            .Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls|All Files|*.*"
            .FileName = "FIELDCOSTDETAILS-" & Format(Now, "MMddyyyy") & "-FM " & LBLFARMMANAGER.Text.ToUpper
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                dgFIELDCOST.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Exit Sub
            End If
        End With
    End Sub
    Private Sub bTpRINT_Click(sender As Object, e As EventArgs) Handles bTpRINT.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(frmMain.RbnUser.Text, frmMain.RbnExeCode.Text, "IsPrint") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If
        If FM = "" Then
            MsgBox("Invalid Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If
        If SF = "" Then
            MsgBox("Invalid Sub Field Number!", vbCritical, "Error")
            Exit Sub
        End If
        Dim CROPCLASS As String = ""
        If CC <> "All" Then
            CROPCLASS = CC
        End If
        Dim sql As String = <s>
                         EXEC FM_SF_LIST_POT '<%= FM %>','<%= dtINFO(0)("CROPCLASS").ToString %>', <%= isCB %>, '<%= TP %>','<%= SF %>','<%= dtINFO(0)("AREA") %>'
                            </s>
        Dim dtPrint As DataTable = ConTools.DataReader(SConn, sql)
        Dim sFileName As String = My.Application.Info.DirectoryPath & "\FMREPORTS.xml"
        C1Report1.Load(sFileName, "FARMMAN_POT")
        C1Report1.DataSource.ConnectionString = "Provider=SQLOLEDB.1;Password=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "PWD")) & "; User ID=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "UserID")) & "; Initial Catalog=" & IniCon.ReadString(PrimCom, "Database") & ";Data Source=" & IniCon.ReadString(PrimCom, "Server") & ""
        C1Report1.DataSource.RecordSource = sql

        With dtINFO
            C1Report1.Fields("LANDOWNERCtl").Text = dtINFO(0)("LANDOWNER").ToString
            C1Report1.Fields("SUBFIELDNOCtl").Text = dtINFO(0)("SUBFIELDNO").ToString

            C1Report1.Fields("CROPCLASSCtl").Text = dtINFO(0)("CROPCLASS").ToString

            C1Report1.Fields("FARMMANAGERCtl").Text = dtINFO(0)("FARMMANAGER").ToString
            C1Report1.Fields("FARMLOCATIONCtl").Text = dtINFO(0)("FARMADDRESS").ToString

            C1Report1.Fields("PLANTINGDATECtl").Text = dtINFO(0)("PLANTINGDATE").ToString
            C1Report1.Fields("AGECtl").Text = IIf(xCROPCLASS.SelectedIndex = 0, dtINFO(0)("AGEOFCANEMONTH").ToString, 0)

            C1Report1.Fields("AREACtl").Text = dtINFO(0)("AREA").ToString
            C1Report1.Fields("FARMMODELCtl").Text = dtINFO(0)("FARMMODEL").ToString

            C1Report1.Fields("LASTACTIVITYCtl").Text = dtINFO(0)("LASTACTIVITY").ToString

            C1Report1.Fields("BUDGETCOSTCtl1").Text = Format(dtINFO(0)("BUDGETCOST"), "N0")

            C1Report1.Fields("ACTUALCOSTCtl1").Text = Format(dtINFO(0)("ACTUALCOST"), "N0")
            C1Report1.Fields("VARIANCECtl").Text = Format(dtINFO(0)("VARIANCE"), "N0")

            C1Report1.Fields("REMARKSCtl").Text = dtINFO(0)("REMARKS").ToString

        End With


        Try
            frmPreview.C1PrintPreviewControl1.Document = C1Report1

            frmPreview.ShowDialog()
        Catch ex As Exception
            MsgBox("Print out not successfully rendered. Please Print Again", MsgBoxStyle.Information, "")
        End Try
    End Sub
    Private Sub xCROPCLASS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCROPCLASS.SelectedIndexChanged
        Try

            FIELDINFO(FM, SF, isCB, TP, xCROPCLASS.Text, CY)
            With dgFieldInfo
                .Rows.Count = 0
            For x As Integer = 0 To dtINFO.Rows.Count - 1
                For i As Integer = 0 To dtINFO.Columns.Count - 1
                    If xCROPCLASS.SelectedIndex <> 0 Then
                        If dtINFO.Columns(i).Caption = "MAINWOID" Or dtINFO.Columns(i).Caption = "WORKORDERID" Or dtINFO.Columns(i).Caption = "AGEOFCANEMONTH" Or
                                dtINFO.Columns(i).Caption.Contains("COST") Or dtINFO.Columns(i).Caption = "VARIANCE" Or dtINFO.Columns(i).Caption = "REMARKS" Then
                                xLBLACTUALCOST.Text = Format(dtINFO(x)("ACTUALCOST"), "N0")
                                xLBLLABORHAUL.Text = Format(dtINFO(x)("LABORHAULCOST"), "n0")
                                XGRANDTOTAL.Text = Format(Val(dtINFO(x)("ACTUALCOST")) + Val(dtINFO(x)("LABORHAULCOST")), "n0")
                            Else
                            .Rows.Add()
                            .Item(.Rows.Count - 1, 0) = dtINFO.Columns(i).Caption
                            .Item(.Rows.Count - 1, 1) = ":" & dtINFO(x)(i).ToString
                        End If
                    Else
                        If dtINFO.Columns(i).Caption = "MAINWOID" Or dtINFO.Columns(i).Caption = "WORKORDERID" Or
                                            dtINFO.Columns(i).Caption.Contains("COST") Or dtINFO.Columns(i).Caption = "VARIANCE" Or dtINFO.Columns(i).Caption = "REMARKS" Then
                                xLBLACTUALCOST.Text = Format(dtINFO(x)("ACTUALCOST"), "N0")
                                xLBLLABORHAUL.Text = Format(dtINFO(x)("LABORHAULCOST"), "n0")
                                XGRANDTOTAL.Text = Format(Val(dtINFO(x)("ACTUALCOST")) + Val(dtINFO(x)("LABORHAULCOST")), "n0")
                            Else
                            .Rows.Add()
                            .Item(.Rows.Count - 1, 0) = dtINFO.Columns(i).Caption
                            .Item(.Rows.Count - 1, 1) = ":" & dtINFO(x)(i).ToString
                        End If
                    End If
                Next
            Next
            .AutoSizeCols()
                .ExtendLastCol = True
            End With
            POPULATEDETAILS(FM, dtINFO(0)("CROPCLASS").ToString, isCB, TP, SF, dtINFO(0)("AREA"))


        Catch ex As Exception
        POPULATEDETAILS(FM, "", isCB, TP, SF, 0)
        MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgFIELDCOST_DoubleClick(sender As Object, e As EventArgs) Handles dgFIELDCOST.DoubleClick
        If dgFIELDCOST.Rows.Count = 1 Then
            MsgBox("Nothing to select!", vbCritical, "Error")
            Exit Sub
        End If

        Dim i As Integer = dgFIELDCOST.RowSel

        If dgFIELDCOST.Rows(i).IsNode = True Then
            Exit Sub
        Else
            If i = 1 Then
                Exit Sub
            End If

            With frmDetails
                .CC = dtINFO(0)("CROPCLASS").ToString
                .TP = TP
                .isCB = isCB
                '.MWOID = dtINFO(0)("MAINWOID").ToString
                .TEMPID = dgFIELDCOST.Item(i, "RECID").ToString
                .ACT = dgFIELDCOST.Item(i, "MINORACTIVITY").ToString

                .landowner = dtINFO(0)("LANDOWNER").ToString
                .subfield = dtINFO(0)("SUBFIELDNO").ToString

                .cropclass = dtINFO(0)("CROPCLASS").ToString

                .fmanager = dtINFO(0)("FARMMANAGER").ToString
                .faddress = dtINFO(0)("FARMADDRESS").ToString

                .plantingdate = dtINFO(0)("PLANTINGDATE").ToString
                .age = IIf(xCROPCLASS.SelectedIndex = 0, dtINFO(0)("AGEOFCANEMONTH").ToString, 0)

                .gap = dtINFO(0)("AREA").ToString
                .fmodel = dtINFO(0)("FARMMODEL").ToString

                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub frmDetailsPOT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class