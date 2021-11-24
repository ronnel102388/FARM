Public Class FRMCREATIONWORKORDERS

#Region "ROUTINE"
    Sub Clear()
        xCBOSUBFIELDNO.Text = ""
        xCBOSUBFIELDNO.SelectedIndex = -1
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
        xAREAOFACTIVITY.Value = 0
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
                                    INNER JOIN 
                                    M_FM_SUBFIELD FMS ON FMS.SUBFIELDID = SF.SUBFIELDID
                                    INNER JOIN 
                                    M_FA_SUBFIELD FAS ON FAS.SUBFIELDID = SF.SUBFIELDID

                                    WHERE SF.ISACTIVE = 1 
                                    AND CFI.ISACTIVE = 1 AND CFI.ISACCEPTED = 1
                                    AND CI.ISACTIVE = 1 AND ISNULL( CI.ISFORRENEWAL,0) = 0
                                    AND FM.ISACTIVE = 1
                                    AND LO.ISACTIVE = 1
                                    AND MF.ISACTIVE = 1 
                                    AND FMS.TAG = 1 AND FMS.ISACTIVE = 1
                                    AND FAS.TAG = 1 AND FAS.ISACTIVE = 1

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
#End Region
    Private Sub FRMCREATEWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        drl_FillCombo("SUBFIELDNO", xCBOSUBFIELDNO, "T_SUBFIELDNO", " CONTRACTEDFIELDID IN (SELECT CONTRACTEDFIELDID FROM T_CONTRACTFIELDINFORMATION WHERE ISACTIVE = 1)")
    End Sub

    Private Sub XCBOSUBFIELDNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCBOSUBFIELDNO.SelectedIndexChanged
        If xCBOSUBFIELDNO.Text = "" Or xCBOSUBFIELDNO.SelectedIndex = -1 Then
            POPULATEFIELDDETAILS("")
        Else
            POPULATEFIELDDETAILS(xCBOSUBFIELDNO.Text)
        End If

    End Sub
End Class