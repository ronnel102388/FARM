Imports C1.Win.C1FlexGrid
Public Class FRMCREATIONWORKORDERS
    Dim vMAJAID, vMINAID, vVERSIONID As Integer
    Public vMAINWOID As Integer
    Public vSUBFIELDNO As String

#Region "ROUTINE"
    Sub Clear()
        'xCBOSUBFIELDNO.Text = ""
        'xCBOSUBFIELDNO.SelectedIndex = -1
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
        xCHKSELECTALL.Checked = False


    End Sub
#End Region
#Region "POPULATE"
    Sub POPULATEFIELDDETAILS(ByVal sf As String)
        Dim sql As String = <s>
                                                                      SELECT DISTINCT
                                    CC.CROPCLASS
                                    ,CCD.CROPCLASSDETAIL
                                    ,LO.LANDOWNER
                                    ,FM.FARMMODEL
                                    ,MF.MAINFIELDNO
                                    ,MF.RECRUITEDAREA AS CONTRACTEDAREA
                                    ,SF.CROPYEAR
                                    ,SF.ARABLEAREA
                                    ,SF.PLANTEDAREA
                                    ,CASE WHEN SF.PLANTINGDATE = '1900-01-01' THEN '' ELSE CONVERT(VARCHAR,SF.PLANTINGDATE,0) END PLANTINGDATE
                                    ,CASE 
	                                    WHEN CONVERT(DATE,SF.PLANTINGDATE) = CONVERT(DATE,'1900-01-01') THEN
			                                     'IDLE'                                                                                                     
	                                    ELSE 
			                                    CONVERT(VARCHAR,CASE WHEN DATEPART (DAY,SF.PLANTINGDATE) > DATEPART (DAY,GETDATE()) THEN 
					                                    DATEDIFF(MONTH,SF.PLANTINGDATE,GETDATE()) - 1 
	                                    ELSE DATEDIFF(MONTH,SF.PLANTINGDATE,GETDATE()) END) 
	                                    END [AGEOFCANEMONTH]
                                    ,FBS.FARMCLUSTER
                                    ,FBS.FARMADDRESS
                                    ,CASE WHEN SF.ISNURSERY=0 THEN 'Full Term' ELSE 'Nursery' END [FARMINGCLASSIFICATION]   
                                    ,(SELECT TOP 1 MILLINGSEASON FROM M_FARMCROPYEAR ORDER BY CROPYEARID DESC) [MILLINGSEASON]  
                                    ,CI.FAS
                                    ,FBS.LAAS
                                    ,(SELECT Employee FROM vwEmployee X WHERE X.EmployeeID = FMS.FARMMANID) AS FARMMANAGER
                                    FROM 
                                    T_SUBFIELDNO SF
                                    INNER JOIN 
                                    M_FARMCROPCLASSDETAIL CCD ON CCD.CROPCLASSDETAILID = SF.CROPCLASSDETAILID
                                    INNER JOIN 
                                    M_FARMCROPCLASS CC ON CC.CROPCLASSID = CCD.CROPCLASSID
                                    INNER JOIN
                                    T_CONTRACTFIELDINFORMATION CFI ON CFI.CONTRACTEDFIELDID = SF.CONTRACTEDFIELDID 
                                    LEFT JOIN 
                                    T_CONTRACTINFORMATION CI ON CI.CONTRACTID = CFI.CONTRACTID 
                                    INNER JOIN 
                                    M_LANDOWNERINFORMATION LO ON LO.LANDOWNERID = CI.LANDOWNERID
                                    INNER JOIN 
                                    M_FARMMODEL FM ON FM.FARMMODELID = CI.FARMMODELID 
                                    INNER JOIN 
                                    M_LANDMAINFIELDNO  MF ON MF.MAINFIELDID =  CFI.MAINFIELDID
                                    INNER JOIN 
                                    VWFARMBARANGAYSETUP FBS ON FBS.FARMBARANGAYID = CI.FARMBARANGAYID
                                    LEFT JOIN 
                                    M_FM_SUBFIELD FMS ON FMS.SUBFIELDID = SF.SUBFIELDID AND FMS.TAG = 1 AND FMS.ISACTIVE = 1
                                    LEFT JOIN 
                                    M_FA_SUBFIELD FAS ON FAS.SUBFIELDID = SF.SUBFIELDID AND FAS.TAG = 1 AND FAS.ISACTIVE = 1
                                    WHERE SF.ISACTIVE = 1 
                                    AND CFI.ISACTIVE = 1 AND CFI.ISACCEPTED = 1
                                    AND CI.ISACTIVE = 1 AND ISNULL( CI.ISFORRENEWAL,0) = 0
                                    AND FM.ISACTIVE = 1
                                    AND LO.ISACTIVE = 1
                                    AND MF.ISACTIVE = 1 
       
                                    
                                    AND SUBFIELDNO ='<%= sf %>'

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
    Sub POPULATE_METHODOFACTIVITY_RESOURCE(ByVal VERID As Integer, ByVal MAJID As Integer, ByVal MINID As Integer, ByVal CC As String, ByVal Area As Double)
        Dim sql As String = <s>
                                SELECT DISTINCT CONVERT(BIT,0) AS TAG
                                ,METHODOFACTIVITY
                                ,RESOURCE
                                ,RESOURCETYPE
                          
                                ,(STANDARDQTY * <%= Area %>) AS PLANQTY
                                ,STANDARDQTY
                                ,UOM
                                ,ISNULL(ISMAINMETHOD,0) AS ISMAINMETHOD
                                ,ISNULL(ISALTERNATIVE,0) AS ISALTERNATIVE
                                ,RECID
                                ,DETAILCODE
                                ,METHODOFACTIVITYID
                                ,RESOURCEID
                                FROM 
                                M_FARM_POT_VERSION_DETAIL
                                WHERE ISACTIVE = 1
                                AND VERSIONID = <%= VERID %>
                                AND CROPCLASS = '<%= CC %>'
                                AND COID = '<%= Comp %>'
                                AND MAJORACTIVITYID = <%= MAJID %>
                                AND MINORACTIVITYID = <%= MINID %>
                            </s>
        SelectQuery(sql)
        With dgWOres
            .DataSource = ds
            .DataMember = "table"
            .Cols.Fixed = 0
            .Rows(0).Height = 50
            .Cols("RECID").Visible = False
            .Cols("DETAILCODE").Visible = False
            .Cols("METHODOFACTIVITYID").Visible = False
            .Cols("METHODOFACTIVITY").Visible = False
            .Cols("RESOURCEID").Visible = False
            .Cols("PLANQTY").Format = "N2"
            .Cols("STANDARDQTY").Format = "N2"

            .Tree.Column = .Cols("RESOURCE").Index
            .Tree.Style = TreeStyleFlags.Complete
            .Subtotal(AggregateEnum.None, 0, .Cols("METHODOFACTIVITY").Index, .Cols("METHODOFACTIVITY").Index, "{0}")
            .Tree.Show(1)
            .AutoSizeCols()

            .Cols.Frozen = 3
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
        drl_FillCombo("MINORACTIVITY", xCBOMINORACTIVITY, "M_FARM_POT_VERSION_DETAIL", "MAJORACTIVITYID = '" & vMAJAID & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "'")
    End Sub

    Private Sub XCBOMINORACTIVITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCBOMINORACTIVITY.SelectedIndexChanged
        If xCBOMINORACTIVITY.SelectedIndex = -1 Or xCBOMINORACTIVITY.Text = "" Then
            vMINAID = 0
        Else
            vMINAID = drl_FindID("MINORACTIVITYID", "M_FARM_POT_VERSION_DETAIL", "MINORACTIVITY = '" & xCBOMINORACTIVITY.Text & "' AND VERSIONID = " & vVERSIONID & " AND COID = '" & Comp & "'")
        End If
        POPULATE_METHODOFACTIVITY_RESOURCE(vVERSIONID, vMAJAID, vMINAID, xCROPCLASS.Text, IIf(Val(xPLANTEDAREA.Text) <> 0, Val(xPLANTEDAREA.Text), Val(xARABLEAREA.Text)))
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
#End Region
    Private Sub FRMCREATEWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        vVERSIONID = drl_FINDDefault()
        xVERSION.Text = drl_FINDDescription("VERSION", "M_FARM_POT_VERSION", "RECID =" & vVERSIONID)

        '=================================SUBFIELDNO
        drl_FillCombo("SUBFIELDNO", xCBOSUBFIELDNO, "T_SUBFIELDNO", " CONTRACTEDFIELDID IN (SELECT CONTRACTEDFIELDID FROM T_CONTRACTFIELDINFORMATION WHERE ISACTIVE = 1 AND ISACCEPTED = 1)")
        xCBOSUBFIELDNO.Text = vSUBFIELDNO
        xCBOSUBFIELDNO_LostFocus(sender, e)

        If vSUBFIELDNO <> "" And vMAINWOID <> 0 Then
            xCBOSUBFIELDNO.Enabled = False
        End If

        '=================================METHOD AND RESOURCE
        POPULATE_METHODOFACTIVITY_RESOURCE(vVERSIONID, 0, 0, "", 0)

    End Sub


End Class