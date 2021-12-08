Imports C1.Win.C1FlexGrid
Public Class FRM_UPDATE_WORKORDERS
    Dim vMAJAID, vMINAID, vVERSIONID, vWORESID As Integer
    Public vMAINWOID, vWOID As Integer
    Public vSUBFIELDNO, vMAJOR, vMINOR, vWOCODE As String
    Public vACTDATE As Date
    Public vWITHDFAR As Boolean

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
            .Cols("WORKORDERRESOURCECODE").Visible = False
            .Cols("STATUS").TextAlign = TextAlignEnum.CenterCenter
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
        drl_FillCombo("MINORACTIVITY", xCBOMINORACTIVITY, "M_FARM_POT_VERSION_DETAIL", "MAJORACTIVITYID = '" & vMAJAID & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp &
                      "' AND (MINORACTIVITY not in  (SELECT MINORACTIVITY FROM T_FARMACTIVITYWORKORDER WHERE MAINWOID = " & vMAINWOID & ") OR MINORACTIVITY = '" & vMINOR & "')")
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

        With dgWOres
            For x As Integer = 1 To .Rows.Count - 1
                If .Rows(x).IsNode = False Then
                    If .Item(x, "TAG").ToString = True Then
                        If .Rows.Count = 0 Then
                            MsgBox("Please select MethodActivity / Resource.", vbInformation, "VALIDATION")
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End With

        '======================UPDATE ADDITIONAL VALIDATION

        Dim vJUSTIFIATION As String = ""
        If vWITHDFAR = True Then
            vJUSTIFIATION = InputBox("JUSTIFICATION", "UPDATE", "")

            If vJUSTIFIATION = "" Then
                MsgBox("Please input justification.", vbInformation, "")
                Exit Sub
            End If
        End If

        'Dim vremarkInput As String = ""
        'If vMINOR <> xCBOMINORACTIVITY.Text Then
        '    vremarkInput = InputBox("Enter your justification:", "JUSTIFICATION", "")
        '    If vremarkInput = "" Then
        '        MsgBox("Please input justification", MsgBoxStyle.Exclamation, "ERROR")
        '        Exit Sub
        '    End If
        'End If


        If MsgBox("Do you want to save the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If



        If vWOID <> 0 Then
            Dim sql As String = <s>
                                    EXEC WORKORDER_HEADER_ACTION
                                        <%= vWOID %>
                                        ,<%= vMAINWOID %> -- MAINWOID
                                        ,'<%= xCBOSUBFIELDNO.Text %>' -- SUBFIELDNO
                                        ,'<%= xWOCODE.Text %>' -- WORKORDERCODE
                                        ,'<%= xLANDOWNER.Text %>' -- LANDOWNER
                                        ,'<%= xFARMMODEL.Text %>' -- FARMMODEL

                                        ,'<%= drl_GetLastDayOfWeek(xDTPWOACTIVITYDATE.Value) %>' -- WEEKENDING
                                        ,'<%= Val(xARABLEAREA.Text) %>' -- ARABLEAREA
                                        ,'<%= Val(xPLANTEDAREA.Text) %>' -- PLANTEDAREA

                                        ,'<%= xCROPYEAR.Text %>' -- CROPYEAR
                                        ,'<%= xPLANTINGDATE.Text %>' -- PLANTINGDATE
                                        ,'<%= xCROPCLASS.Text %>' -- CROPCLASS
                                        ,'<%= xCROPCLASSDETAIL.Text %>' -- CROPCLASSDETAIL

                                        ,'<%= xFARMMANAGER.Text %>' -- FARMMANAGER
                                        ,'<%= xFARMASSISTANT.Text %>' -- FARMASSISTANT
                                        ,'<%= xFARMADDRESS.Text %>' -- FARMADDRESS

                                        ,'<%= xDTPWOACTIVITYDATE.Value.ToShortDateString %>' -- WORK ORDER ACTIVITY DATE
                                        ,'<%= Val(xAREAOFACTIVITY.Text) %>' -- AREAOFACTIVITY
                                        ,'<%= xCBOMAJORACTIVITY.Text %>' -- MAJORACTIVITY
                                        ,'<%= xCBOMINORACTIVITY.Text %>' -- MINORACTIVITY
                                        ,'<%= xVERSION.Text %>' -- VERSION
                                        
                                        ,'' -- CANCELLATIONREMARKS
                                        ,'' -- REOPENWOREMARKS
                                        ,'<%= vJUSTIFIATION %>' -- UPDATEJUSTIFICATION

                                        ,'' -- DEACTIVATIONREMARKS
                                        ,'<%= FRMWORKORDERS.RbnUser.Text %>'

                                        ,0 -- FURROWDISTANCE 
                                        ,0 -- TOTALSTALKWEIGHT
                                        ,0 --EQUIVALENTTONS
                                        ,0 -- YIELD
                                        ,0 -- ISMANUAL
                                        ,'' -- CROPLOGREMARKS
                                        ,'UPDATE'
                                </s>
            ExeQuery(sql)


            If vMINOR <> xCBOMINORACTIVITY.Text Then
                Dim sqlx As String = <s>
                                        EXEC WORKORDER_DETAIL_ACTION
                                         0
                                        ,'' -- WORKORDERRESOURCECODE
                                        ,<%= vWOID %> -- WORKORDERID
                                        ,'' -- WORKORDERCODE
                                        ,0 -- PLANQTY
                                        ,0 -- POTID
                                        ,0 -- UNITPRICE
                                        ,0 -- COSTPRICE
                                        ,'' -- JUSTIFICATION
                                        ,'' -- DEACTIVATIONREMARKS
                                        ,'<%= FRMWORKORDERS.RbnUser.Text %>' -- CREATEDBY
                                        ,0 -- ISACTIVE
                                        ,'UPDATE'
                                     </s>
                ExeQuery(sqlx)
            End If


            Dim sqly As String = ""
            With dgWOres
                For x As Integer = 1 To .Rows.Count - 1
                    If .Rows(x).IsNode = False Then
                        If .Item(x, "STATUS") = "INSERT" Then
                            Dim vWORESCODE As String = drl_GenerateCodeWORESOURCE()
                            sqly = <s>
                                                EXEC WORKORDER_DETAIL_ACTION
                                                 0  
                                                ,'<%= vWORESCODE %>' -- WORKORDERRESOURCECODE
                                                ,<%= vWOID %>-- WORKORDERID
                                                ,'<%= xWOCODE.Text %>' -- WORKORDERCODE
                                                ,<%= .Item(x, "PLANQTY") %> -- PLANQTY
                                                ,<%= .Item(x, "POTID") %> -- POTID
                                                ,'<%= .Item(x, "UNITPRICE") %>' -- UNITPRICE
                                                ,'<%= .Item(x, "COSTPRICE") %>' -- COSTPRICE
                                                ,'<%= .Item(x, "JUSTIFICATION") %>' -- JUSTIFICATION
                                                ,'<%= .Item(x, "DEACTIVATIONREMARKS") %>' -- DEACTIVATIONREMARKS
                                                ,'<%= FRMWORKORDERS.RbnUser.Text %>' -- CREATEDBY
                                                ,1
                                                ,'INSERT'
                                             </s>
                            ExeQuery(sqly)
                        ElseIf .Item(x, "STATUS") = "CHANGED" Then
                            sqly = <s>
                                                EXEC WORKORDER_DETAIL_ACTION
                                                 <%= .Item(x, "WORKORDERRESOURCEID") %> -- WORKORDERRESOURCEID
                                                ,'<%= .Item(x, "WORKORDERRESOURCECODE") %>' -- WORKORDERRESOURCECODE
                                                ,<%= vWOID %>-- WORKORDERID
                                                ,'<%= xWOCODE.Text %>' -- WORKORDERCODE
                                                ,<%= .Item(x, "PLANQTY") %> -- PLANQTY
                                                ,<%= .Item(x, "POTID") %> -- POTID
                                                ,'<%= .Item(x, "UNITPRICE") %>' -- UNITPRICE
                                                ,'<%= .Item(x, "COSTPRICE") %>' -- COSTPRICE
                                                ,'<%= .Item(x, "JUSTIFICATION") %>' -- JUSTIFICATION
                                                ,'<%= .Item(x, "DEACTIVATIONREMARKS") %>' -- DEACTIVATIONREMARKS
                                                ,'<%= FRMWORKORDERS.RbnUser.Text %>' -- CREATEDBY
                                                ,'<%= Convert.ToInt32(.Item(x, "TAG")) %>' -- ISACTIVE
                                                ,'CHANGED'
                                       </s>
                            ExeQuery(sqly)
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

            If vMINOR = xCBOMINORACTIVITY.Text Then
                If .Item(x, "TAG").ToString = True Then
                    If drl_VALIDATECHANGED(vWOID, .Item(x, "POTID"), 1) = 1 Then
                        .Item(x, "STATUS") = "---"
                    Else
                        .Item(x, "STATUS") = "CHANGED"
                    End If
                Else
                    If drl_VALIDATECHANGED(vWOID, .Item(x, "POTID"), 0) = 0 Then
                        .Item(x, "STATUS") = "CHANGED"
                    Else
                        .Item(x, "STATUS") = "---"
                    End If
                End If
            Else
                If .Item(x, "TAG").ToString = True And .Item(x, "WORKORDERRESOURCEID") <> 0 Then
                    .Item(x, "STATUS") = "CHANGED"
                ElseIf .Item(x, "TAG").ToString = True And .Item(x, "WORKORDERRESOURCEID") = 0 Then
                    .Item(x, "STATUS") = "INSERT"
                Else
                    .Item(x, "STATUS") = "---"
                End If
            End If


            .AutoSizeCols()

        End With
    End Sub
#End Region
    Private Sub FRM_UPDATE_WORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        vVERSIONID = drl_FINDDefault()
        xVERSION.Text = drl_FINDDescription("VERSION", "M_FARM_POT_VERSION", "RECID =" & vVERSIONID)

        '=================================SUBFIELDNO
        drl_FillCombo("SUBFIELDNO", xCBOSUBFIELDNO, "T_SUBFIELDNO", " CONTRACTEDFIELDID IN (SELECT CONTRACTEDFIELDID FROM T_CONTRACTFIELDINFORMATION WHERE ISACTIVE = 1 AND ISACCEPTED = 1)")
        xCBOSUBFIELDNO.Text = vSUBFIELDNO
        xCBOSUBFIELDNO_LostFocus(sender, e)

        xCBOSUBFIELDNO.Enabled = False
        xWOCODE.Text = vWOCODE

        '==================================ACTIVITY

        xCBOMAJORACTIVITY.Text = vMAJOR
        XCBOMAJORACTIVITY_SelectedIndexChanged(sender, e)

        xCBOMINORACTIVITY.Text = vMINOR
        XCBOMINORACTIVITY_SelectedIndexChanged(sender, e)

        xDTPWOACTIVITYDATE.Value = vACTDATE

    End Sub
    Private Sub FRM_UPDATE_WORKORDERS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class