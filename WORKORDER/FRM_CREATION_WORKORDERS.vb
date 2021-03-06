Imports C1.Win.C1FlexGrid
Public Class FRM_CREATION_WORKORDERS
    Dim vMAJAID, vMINAID, vVERSIONID, vWOID, vWORESID As Integer
    Public vMAINWOID As Integer
    Public vSUBFIELDNO, vMAJOR, vMINOR As String

#Region "ROUTINE"
    Sub Clear()
        '===================================== VARIALBLES
        vMAJAID = 0
        vMINAID = 0


        '===================================== TOOLS
        xCROPCLASS.Text = ""
        xCROPCLASSDETAIL.Text = ""
        xLANDOWNER.Text = ""
        xFARMMODEL.Text = ""
        xMAINFIELDNO.Text = ""
        xCONTRACTEDTAREA.Text = ""
        xCROPYEAR.Text = ""
        xARABLEAREA.Text = "0.00"
        xPLANTEDAREA.Text = "0.00"
        xPLANTINGDATE.Text = ""
        xAGE.Text = "0.00"
        xFARMCLUSTER.Text = ""
        xFARMADDRESS.Text = ""
        xFARMCLASSIFICATION.Text = ""
        xMILLINGSEASON.Text = ""
        xFAS.Text = ""
        xLAAS.Text = ""
        xFARMMANAGER.Text = ""
        xFARMASSISTANT.Text = ""
        xWOCODE.Text = "System Generated"
        xCBOMAJORACTIVITY.Text = ""
        xCBOMAJORACTIVITY.SelectedIndex = -1
        xCBOMINORACTIVITY.Text = ""
        xCBOMINORACTIVITY.SelectedIndex = -1

        xDTPWOACTIVITYDATE.Value = Date.Now
        xAREAOFACTIVITY.Text = 0


    End Sub
#End Region
#Region "POPULATE"
    Sub POPULATEFIELDDETAILS(ByVal sf As String)
        Dim sql As String = <s>
                                   EXEC WORKORDER_LIST_FIELDDETAILS'<%= sf %>'
                            </s>
        ExeReader(sql)
        With dr
            While .Read
                xCROPCLASS.Text = .Item("CROPCLASS").ToString
                xCROPCLASSDETAIL.Text = .Item("CROPCLASSDETAIL").ToString
                xLANDOWNER.Text = .Item("LANDOWNER").ToString
                xFARMMODEL.Text = .Item("FARMMODEL").ToString
                xMAINFIELDNO.Text = .Item("MAINFIELDNO").ToString
                xCONTRACTEDTAREA.Text = .Item("CONTRACTEDAREA").ToString
                xCROPYEAR.Text = .Item("CROPYEAR").ToString
                xARABLEAREA.Text = .Item("ARABLEAREA").ToString
                xPLANTEDAREA.Text = .Item("PLANTEDAREA").ToString
                xPLANTINGDATE.Text = .Item("PLANTINGDATE").ToString
                xAGE.Text = .Item("AGEOFCANEMONTH").ToString
                xFARMCLUSTER.Text = .Item("FARMCLUSTER").ToString
                xFARMADDRESS.Text = .Item("FARMADDRESS").ToString
                xFARMCLASSIFICATION.Text = .Item("FARMINGCLASSIFICATION").ToString
                xMILLINGSEASON.Text = .Item("MILLINGSEASON").ToString
                xFAS.Text = .Item("FAS").ToString
                xLAAS.Text = .Item("LAAS").ToString
                xFARMMANAGER.Text = .Item("FARMMANAGER").ToString
                xFARMASSISTANT.Text = ""
            End While
        End With
        dr.Close()
        Conn.Close()
    End Sub
    Sub POPULATE_METHODOFACTIVITY_RESOURCE(ByVal VERID As Integer, ByVal MAJID As Integer, ByVal MINID As Integer, ByVal CC As String, ByVal ActDate As Date, ByVal Area As Double)
        Dim sql As String = <s>

                                EXEC WORKORDER_SELECTION_WORKORDERDETAIL  '<%= VERID %>', <%= MAJID %>, <%= MINID %>, '<%= CC %>', '<%= ActDate %>','<%= Area %>', '<%= Comp %>'

                            </s>
        SelectQuery(sql)
        With dgWOres
            .DataSource = ds
            .DataMember = "table"
            .Cols.Fixed = 0
            .Rows(0).Height = 50
            .Cols("METHODOFACTIVITY").Visible = False
            .Cols("PLANQTY").Format = "N2"
            .Cols("STANDARDQTY").Format = "N2"
            .Cols("UNITPRICE").Visible = False
            .Cols("COSTPRICE").Visible = False
            .Cols("RESOURCEGROUP").Visible = False
            .Cols("POTID").Visible = False
            .Cols("WORKORDERRESOURCEID").Visible = False
            .Tree.Column = .Cols("RESOURCE").Index
            .Tree.Style = TreeStyleFlags.Complete
            .Subtotal(AggregateEnum.None, 0, .Cols("METHODOFACTIVITY").Index, .Cols("METHODOFACTIVITY").Index, "{0}")
            .Tree.Show(1)
            .AutoSizeCols()

            .Cols.Frozen = 4
            '.Cols("RESOURCETYPE").Style.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
            '.Styles(CellStyleEnum.Subtotal0).Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        End With
    End Sub
#End Region
#Region "CONTROL EVENTS TOP "
    Private Sub btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseEnter, btnmax.MouseEnter, btnmin.MouseEnter
        sender.backcolor = Color.Gainsboro
    End Sub
    Private Sub btnclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseLeave, btnmax.MouseLeave, btnmin.MouseLeave
        sender.backcolor = Color.FromArgb(224, 224, 224)
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        If MsgBox("Are You Sure You Want to Close this Application", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Close Application") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub
    Private Sub btnmax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DgWOres_Click(sender As Object, e As EventArgs) Handles dgWOres.Click

    End Sub
#End Region
#Region "FORM CONTROL EVENTS"
    Private Sub XCBOMAJORACTIVITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCBOMAJORACTIVITY.SelectedIndexChanged
        If xCBOMAJORACTIVITY.SelectedIndex = -1 Or xCBOMAJORACTIVITY.Text = "" Then
            vMAJAID = 0
            xCBOMINORACTIVITY.Text = ""
            xCBOMINORACTIVITY.SelectedIndex = -1
        Else
            vMAJAID = drl_FindID("MAJORACTIVITYID", "M_FARM_POT_VERSION_DETAIL", "MAJORACTIVITY = '" & xCBOMAJORACTIVITY.Text & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "'")
            xCBOMINORACTIVITY.Text = ""
            xCBOMINORACTIVITY.SelectedIndex = -1
        End If
        drl_FillCombo("MINORACTIVITY", xCBOMINORACTIVITY, "M_FARM_POT_VERSION_DETAIL", "MAJORACTIVITYID = '" & vMAJAID & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "' AND MINORACTIVITY not in  (SELECT MINORACTIVITY FROM T_FARMACTIVITYWORKORDER WHERE MAINWOID = " & vMAINWOID & ")")
    End Sub
    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        If xCBOMAJORACTIVITY.Text <> "" Then
            If MsgBox("Are you sure you want to cancel the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
                Exit Sub
            End If
        End If
        Clear()
        Me.Dispose()
    End Sub

    Private Sub XCBOSUBFIELDNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCBOSUBFIELDNO.SelectedIndexChanged

    End Sub

    Private Sub XCBOMINORACTIVITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCBOMINORACTIVITY.SelectedIndexChanged
        If xCBOMINORACTIVITY.SelectedIndex = -1 Or xCBOMINORACTIVITY.Text = "" Then
            vMINAID = 0
        Else
            vMINAID = drl_FindID("MINORACTIVITYID", "M_FARM_POT_VERSION_DETAIL", "MINORACTIVITY = '" & xCBOMINORACTIVITY.Text & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "'")
        End If
        POPULATE_METHODOFACTIVITY_RESOURCE(vVERSIONID, vMAJAID, vMINAID, xCROPCLASS.Text, xDTPWOACTIVITYDATE.Value, IIf(Val(xPLANTEDAREA.Text) <> 0, Val(xPLANTEDAREA.Text), Val(xARABLEAREA.Text)))
    End Sub
    Public Sub xCBOSUBFIELDNO_LostFocus(sender As Object, e As EventArgs) Handles xCBOSUBFIELDNO.LostFocus
        If xCBOSUBFIELDNO.Text = "" Or xCBOSUBFIELDNO.SelectedIndex = -1 Then
            POPULATEFIELDDETAILS("")
            Clear()
        Else
            POPULATEFIELDDETAILS(xCBOSUBFIELDNO.Text)
            xCBOMAJORACTIVITY.Text = ""
            xCBOMAJORACTIVITY.SelectedIndex = -1
            xCBOMINORACTIVITY.Text = ""
            xCBOMINORACTIVITY.SelectedIndex = -1
        End If
        If Val(xPLANTEDAREA.Text) <> 0 Then
            xAREAOFACTIVITY.Text = xPLANTEDAREA.Text
        Else
            xAREAOFACTIVITY.Text = xARABLEAREA.Text
        End If
        drl_FillCombo("MAJORACTIVITY", xCBOMAJORACTIVITY, "M_FARM_POT_VERSION_DETAIL", "CROPCLASS = '" & xCROPCLASS.Text & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "'")
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If xCBOMAJORACTIVITY.Text = "" And xCBOMAJORACTIVITY.SelectedIndex = -1 Then
            MsgBox("Please Add Major Activity", vbInformation, "VALIDATION")
            Exit Sub
        End If

        If vMAJAID = 0 Then
            MsgBox("Major Activity is not exist.", vbInformation, "VALIDATION")
        End If

        If xCBOMINORACTIVITY.Text = "" And xCBOMINORACTIVITY.SelectedIndex = -1 Then
            MsgBox("Please Add Minor Activity", vbInformation, "VALIDATION")
            Exit Sub
        End If

        If vMINAID = 0 Then
            MsgBox("Minor Activity is not exist", vbInformation, "VALIDATION")
            Exit Sub
        End If

        If Val(xAREAOFACTIVITY.Text) = 0 Then
            MsgBox("Invalid Area of Activity.", vbInformation, "VALIDATION")
            Exit Sub
        End If


        With dgWOres
            For x As Integer = 1 To .Rows.Count - 1
                If .Rows(x).IsNode = False Then
                    If .Item(x, "TAG").ToString = False Then
                        If .Rows.Count = 0 Then
                            MsgBox("Please select MethodActivity / Resource.", vbInformation, "VALIDATION")
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End With


        If MsgBox("Do you want to save the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If


        If vMAINWOID = 0 Then
            Dim vMAINWOCODE As String = drl_GenerateCodeMAINWO()
            vMAINWOID = drl_MAIN_EXECUTE_INSERT(0, 'MAINWOID
                                     vMAINWOCODE, 'MAINWOCODE
                                     xCBOSUBFIELDNO.Text, 'SUBFIELDNO
                                     xCROPCLASSDETAIL.Text, 'CROPCLASSDETAIL
                                     xCROPYEAR.Text, 'CROPYEAR
                                     "", 'REMARKS
                                     "", 'REOPENREMARKS
                                     FRMWORKORDERS.RbnUser.Text, 'USERNAME
                                     "INSERT" 'TRANS
                                     )
        End If

        If vWOID = 0 Then
            xWOCODE.Text = drl_GenerateCodeWORKORDER()
            vWOID = drl_HEADER_EXECUTE_INSERT(vWOID, 'WOID
                            vMAINWOID, 'MAINWOID
                           xCBOSUBFIELDNO.Text, 'SUBFIELDNO
                           xWOCODE.Text,  'WORKORDECODE
                           xLANDOWNER.Text,  'LANDOWNER
                           xFARMMODEL.Text,  'FARMMODEL
                           drl_GetLastDayOfWeek(xDTPWOACTIVITYDATE.Value),  'WEEKENDING
                           xARABLEAREA.Text,  'ARABLEAREA
                           xPLANTEDAREA.Text,  'PLANTEDAREA
                           xCROPYEAR.Text,  'CROPYEAR
                           xPLANTINGDATE.Text,  'PLANTINGDATE
                           xCROPCLASS.Text,  'CROPCLASS
                           xCROPCLASSDETAIL.Text,  'CROPCLASSDETAIL
                           xFARMMANAGER.Text,  'FARMMANAGER
                           xFARMASSISTANT.Text,  'FARMASSISTANT
                           xFARMADDRESS.Text,  'FARMADDRESS
                           xDTPWOACTIVITYDATE.Value.ToShortDateString,  'WORK ORDER ACTIVITY DATE
                           xAREAOFACTIVITY.Text,  'AREAOFACTIVITY
                           xCBOMAJORACTIVITY.Text,  'MAJORACTIVITY
                           xCBOMINORACTIVITY.Text,  'MINORACTIVITY
                           xVERSION.Text,  'VERSION
                           "",  'CANCELLATIONREMARKS
                           "",  'REOPENREMARKS
                           "",  'UPDATEJUSTIFICATION
                           "",  'DEACTIVATIONREMARKS
                           FRMWORKORDERS.RbnUser.Text,  'USERNAME
                           "",  'FURROWDISTANCE
                           "",  'TOTALSTALKWEIGHT
                           "",  'EQUIVALENTTONS
                           "",  'YIELD
                           "",  'ISMANUAL
                           "",  'CROPLOGREMARKS
                           "INSERT") 'TRANS
            With dgWOres
                For x As Integer = 1 To .Rows.Count - 1
                    If .Rows(x).IsNode = False Then
                        If .Item(x, "STATUS") = "INSERT" Then
                            Dim vWORESCODE As String = drl_GenerateCodeWORESOURCE()
                            drl_DETAIL_EXECUTE_INSERT(0,
                                                 vWORESCODE, 'WORKORDERRESOURCECODE
                                                 vWOID, 'WORKORDERID
                                                 xWOCODE.Text, 'WORKORDERCODE
                                                 .Item(x, "PLANQTY"), 'PLANQTY
                                                 .Item(x, "POTID"), 'POTID
                                                 .Item(x, "UNITPRICE"), 'UNITPRICE
                                                 .Item(x, "COSTPRICE"), 'COSTPRICE
                                                 .Item(x, "JUSTIFICATION"), 'JUSTIFICATION
                                                 .Item(x, "DEACTIVATIONREMARKS"), 'DEACTIVATIONREMARKS
                                                 FRMWORKORDERS.RbnUser.Text, 'CREATEDBY
                                                 1, 'ISACTIVE
                                                "INSERT" 'TRANS             
                                                     )
                        End If
                    End If
                Next
            End With

        End If

        MsgBox("WorkOrder SuccessFully Saved", vbInformation, "VALIDATION")

        With FRMWORKORDERS
            .xSUBFIELDNO.Text = xCBOSUBFIELDNO.Text
            .POPULATEFIELDDETAILS(xCBOSUBFIELDNO.Text)
            .POPULATEMAINWORKORDER()
            .POPULATEWOHEADER(vMAINWOID)
            .POPULATEWODETAIL(vWOID)
        End With

        Clear()
        Me.Dispose()
    End Sub
    Private Sub dgWOres_AfterEdit(sender As Object, e As RowColEventArgs) Handles dgWOres.AfterEdit
        With dgWOres
            Dim x As Integer = .RowSel
            If .Item(x, "TAG").ToString = True Then
                .Item(x, "STATUS") = "INSERT"
            Else
                .Item(x, "STATUS") = "---"
            End If
            .AutoSizeCols()
        End With
    End Sub

#End Region
    Private Sub FRMCREATEWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        vVERSIONID = drl_FINDDefault()
        xVERSION.Text = drl_FINDDescription("VERSION", "M_FARM_POT_VERSION", "RECID =" & vVERSIONID)

        '=================================SUBFIELDNO
        drl_FillCombo("SUBFIELDNO", xCBOSUBFIELDNO, "T_SUBFIELDNO", " CONTRACTEDFIELDID IN (SELECT CONTRACTEDFIELDID FROM T_CONTRACTFIELDINFORMATION WHERE ISACTIVE = 1 AND ISACCEPTED = 1)")
        xCBOSUBFIELDNO.Text = vSUBFIELDNO
        xCBOSUBFIELDNO_LostFocus(sender, e)

        If vSUBFIELDNO <> "" Then
            xCBOSUBFIELDNO.Enabled = False
        End If
    End Sub
    Private Sub FRM_CREATION_WORKORDERS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class