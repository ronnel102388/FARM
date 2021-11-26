Imports C1.Win.C1FlexGrid
Public Class FRMWORKORDERS
    Dim CURRENTTAB As Integer
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")
    Function FindEmID(ByVal Username As String) As Integer
        Dim sql As String = <s>
         SELECT EmployeeID FROM a_Employee where UserName = '<%= Username %>'                       
                            </s>

        ExeReader(sql)
        Dim EmployeeID As Integer = 0
        While dr.Read
            EmployeeID = dr.Item("EmployeeID")
        End While
        dr.Close()
        Conn.Close()

        Return EmployeeID
    End Function
    Public Sub PrepareUser()
        'If checkstate <> "True" Then
        '    ConTools.SetStatusBar(RbnIP, RbnCN, RbnUser, RbnExeCode, RbnBuildNo, RbnDev)
        'End If
        RbnConnName.Text = PrimCom
        RbnBuildNo.Text = "PROGEN 5.0 as of " & System.IO.File.GetLastWriteTime(Application.ExecutablePath)

        Username = RbnUser.Text
        'If QueryCompanyCode(Username) = "" Then
        '    RbnCompany.Text = "1REI"
        'Else
        '    RbnCompany.Text = QueryCompanyCode(Username)
        'End If
        RbnCompany.Text = "1REI"

        Comp = RbnCompany.Text

        CompName = RbnCN.Text
        MyDept = "Information Technology"
        'DeptId = 1
        'EmpID = FindEmID(Username)
    End Sub
#Region "POPULATE"
    Sub POPULATEMAINWORKORDER()
        Dim search As String = XSEARCH.Text.Replace("'", "")
        Dim sql As String = <s>     

                    SELECT TOP 100 [MainWOID]
                          ,[MainWO]
                          ,[FieldID]
                          ,[FieldNo]
                          ,[CropClassDetailID]
                          ,[CroplClassDetail]
                          ,[CropYear]
                          ,isnull([IsClosed],0) AS IsClosed
                          ,[ClosedDate]
                          ,[ClosedBy]
                          ,[Remarks]
                          ,isnull([IsReOpen],0) AS IsReOpen
                          ,[ReOpenBy]
                          ,[ReOpenDate]
                          ,[ReOpenMainWORemarks]
                          ,[IsActive]
                          ,[CreatedBy]
                          ,[CreationDate]
                          ,[ModifiedBy]
                          ,[ModificationDate]
                          ,[PreviousModifiedBy]
                          ,[PreviousModificationDate]
                          ,[IsCropLogged]
                          ,[DateCropLogged]
                      FROM [GENESISr5].[dbo].[t_FarmActivityMainWorkOrder]
                      WHERE ISACTIVE = 1
                      AND (FIELDNO LIKE '%<%= search %>%')
                    ORDER BY isnull([IsClosed],0) ASC, MAINWOID DESC
                            </s>
        SelectQuery(sql)
        With dgMAINWO
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .AutoSizeCols()
            '.Cols("SUBFIELDID").Visible = False
            '.Cols("CROPCLASSDETAILID").Visible = False
            '.Cols("SUBFIELDNO").Caption = "SUB FIELD"
            '.Cols("SUBFIELDNO").Width = 300
            '.Cols("WOCODE").Caption = "WORK ORDER CODE"
            '.Cols("WOCODE").Width = 300
            '.Cols("CROPCLASSDETAIL").Caption = "CROP CLASS"
            '.Cols("CROPCLASSDETAIL").Width = 300
            '.Cols("TRANSDATE").Caption = "TRANSACTION DATE"
            '.Cols("TRANSDATE").Width = 200
            '.Cols("SEASONID").Caption = "SEASON"
            '.Cols("SEASONID").Width = 200
            '.Cols("CLOSEDBY").Caption = "CLOSED BY"
            '.Cols("CLOSEDBY").Width = 200
            '.Cols("CLOSEDDATE").Caption = "CLOSING DATE"
            '.Cols("CLOSEDDATE").Width = 200

            For x As Integer = 0 To .Cols.Count - 1
                If .Cols(x).Caption.Contains("ID") Or .Cols(x).Caption.Contains("Id") Then
                    .Cols(x).Visible = False
                Else
                    .Cols(x).Visible = True
                End If
            Next

        End With
    End Sub
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
    Sub POPULATEWOHEADER(ByVal MWOID As Integer)
        Dim sql As String = <s>
                                SELECT [WORKORDERID]
                                      ,[MAINWOID]
                                      ,[WORKORDERCODE]
                                      ,[LANDOWNERID]
                                      ,[LANDOWNER]
                                      ,[FARMMODELID]
                                      ,[FARMMODEL]
                                      ,[SUBFIELDID]
                                      ,[SUBFIELDNO]
                                        
                                      ,[MAJORACTIVITY]
                                      ,[MINORACTIVITY]

                                      ,[ACTIVITYDATE]
                                      ,[WEEKENDING]
                                      ,[ARABLEAREA]
                                      ,[PLANTEDAREA]
                                      ,[AREAOFACTIVITY]
                                      ,[CROPYEAR]
                                      ,[PLANTINGDATE]
                                      ,[CROPCLASS]
                                      ,[CROPCLASSDETAIL]
                                      ,[VERSION]
                                      ,[FARMACTIVITYCODE]

                                      ,[FARMMANAGERID]
                                      ,[FARMMANAGER]
                                      ,[FARMASSISTANTID]
                                      ,[FARMASSISTANT]
                                      ,[FARMBARANGAYID]
                                      ,[FARMADDRESS]
                                      ,[ISCLOSE]
                                      ,[CLOSEDATE]
                                      ,[ISCANCELLED]
                                      ,[CANCELLEDBY]
                                      ,[CANCELDATE]
                                      ,[CANCELLATIONREMARKS]
                                      ,[DEACTIVATIONREMARKS]
                                      ,[ISACTIVE]
                                      ,[CREATEDBY]
                                      ,[CREATIONDATE]
                                      ,[MODIFIEDBY]
                                      ,[MODIFICATIONDATE]
                                      ,[PREVIOUSMODIFIEDBY]
                                      ,[PREVIOUSMODIFICATIONDATE]
                                  FROM [T_FARMACTIVITYWORKORDER]
                                  WHERE MAINWOID = <%= MWOID %>
                                  ORDER BY ACTIVITYDATE DESC
                            </s>
        SelectQuery(sql)
        With dgWOHeader
            .DataSource = ds
            .DataMember = "table"
            .Cols.Fixed = 0
            .Rows(0).Height = 50
            .AutoSizeCols()

            For i As Integer = 0 To .Cols.Count - 1
                If .Cols(i).Caption.Contains("ID") Or .Cols(i).Caption.Contains("Id") Then
                    .Cols(i).Visible = False
                Else
                    .Cols(i).Visible = True
                End If
            Next
            .Cols("LANDOWNER").Visible = False
            .Cols("SUBFIELDNO").Visible = False
            .Cols("FARMMODEL").Visible = False
            .Cols("ARABLEAREA").Visible = False
            .Cols("PLANTEDAREA").Visible = False
            .Cols("CROPYEAR").Visible = False
            .Cols("CROPCLASS").Visible = False
            .Cols("CROPCLASSDETAIL").Visible = False
            .Cols("PLANTEDAREA").Visible = False
            .Cols("FARMMANAGER").Visible = False
            .Cols("FARMASSISTANT").Visible = False
            .Cols("FARMADDRESS").Visible = False

            .Cols.Frozen = 11

        End With

        RowColor(dgWOHeader, "ISCANCELLED", "ISCLOSE")
    End Sub
    Sub RowColor(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal cancelcol As String, ByVal closecol As String)
        Dim rngx As C1.Win.C1FlexGrid.CellRange
        If fg.Rows.Count - 1 > 0 Then
            With fg
                For i As Integer = 1 To .Rows.Count - 1
                    If .Rows(i).IsNode = False Then
                        If .Item(i, cancelcol).ToString = "True" Then
                            rngx = fg.GetCellRange(i, 11, i, fg.Cols.Count - 1)
                            rngx.StyleNew.BackColor = Color.FromArgb(160, 51, 58)
                            rngx.StyleNew.ForeColor = Color.White
                        ElseIf .Item(i, closecol).ToString = "True" Then
                            rngx = fg.GetCellRange(i, 11, i, fg.Cols.Count - 1)
                            rngx.StyleNew.BackColor = Color.FromArgb(67, 112, 88)
                            rngx.StyleNew.ForeColor = Color.White
                        Else
                            rngx = fg.GetCellRange(i, 11, i, fg.Cols.Count - 1)
                            rngx.StyleNew.BackColor = Color.White
                            rngx.StyleNew.ForeColor = Color.Black
                        End If
                    End If
                Next
            End With
        End If
    End Sub

    Sub POPULATEWODETAIL(ByVal WOID As Integer)
        Dim SQL As String = <s>
                                SELECT [MethodOfActivity]
                                      ,[Resource]
                                      ,[Quantity]
                                      ,[UnitPrice]
                                      ,[CostPrice]
                                      ,[UOMId]
                                      ,[UOM]
                                      ,[IsMainMethod]
                                      ,[IsAlternative]
                                      ,[IsAccumulatedAreaDone]
                                      ,[DeactivationRemarks]
                                      ,[IsActive]
                                      ,[WorkOrderResourceId]
                                      ,[WorkOrderResourceCode]
                                      ,[WorkOrderId]
                                      ,[WorkOrderCode]
                                      ,[MethodOfActivityId]
                                      ,[ResourceId]
                                      ,[FarmActivityResourceId]
                                  FROM [t_FarmActivityWorkOrderResources]
                                  WHERE WorkOrderId = <%= WOID %>
                            </s>
        SelectQuery(SQL)
        With dgWORes
            .DataSource = ds
            .DataMember = "table"
            .Cols.Fixed = 0
            .Rows(0).Height = 50

            For i As Integer = 0 To .Cols.Count - 1
                If .Cols(i).Caption.Contains("ID") Or .Cols(i).Caption.Contains("Id") Or .Cols(i).Caption.Contains("IsActive") Then
                    .Cols(i).Visible = False
                Else
                    .Cols(i).Visible = True
                End If
            Next
            .Cols("METHODOFACTIVITY").Visible = False
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

    Private Sub FRMWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        BTNDASHBOARD.PerformClick()
        'POPULATEWORKORDER()
    End Sub

    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click
        MAINTAB.TabPages.Remove(Overview)
        MAINTAB.TabPages.Remove(Details)
        MAINTAB.TabPages.Remove(Dashboard)

        MAINTAB.TabPages.Add(Dashboard)

        CURRENTTAB = 1
    End Sub

    Private Sub BTNWORKORDER_Click(sender As Object, e As EventArgs) Handles BTNWORKORDER.Click
        MAINTAB.TabPages.Remove(Dashboard)
        MAINTAB.TabPages.Remove(Overview)
        MAINTAB.TabPages.Remove(Details)
        MAINTAB.TabPages.Add(Overview)
        MAINTAB.TabPages.Add(Details)


        POPULATEMAINWORKORDER()
        CURRENTTAB = 2
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If CURRENTTAB = 2 Then
            FRMCREATIONWORKORDERS.ShowDialog()
        End If
    End Sub

    Private Sub btAddHeader_Click(sender As Object, e As EventArgs) Handles btAddHeader.Click

        If dgMAINWO.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim x As Integer = dgMAINWO.RowSel

        If x = 0 Then
            Exit Sub
        End If

        With dgMAINWO
            If .Item(x, "MAINWOID") <> 0 And .Item(x, "ISCLOSED") = 0 Then
                If MsgBox("Do you want to add Work Order Activities in this SubField No. " & .Item(x, "FIELDNO") & " ?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
                    Exit Sub
                End If
            Else
                MsgBox("Cannot create or add Work Order Activities in this Subfield No. " & .Item(x, "FIELDNO") & " because the Main Work Order is already closed." & vbNewLine & "Please select other transaction.", vbExclamation, "VALIDATION")
                Exit Sub
            End If
        End With

        With FRMCREATIONWORKORDERS
            .vMAINWOID = dgMAINWO.Item(x, "MAINWOID")
            .vSUBFIELDNO = dgMAINWO.Item(x, "FIELDNO").ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub DgMAINWO_Click(sender As Object, e As EventArgs) Handles dgMAINWO.Click

    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        With dgMAINWO
            If .Rows.Count = 1 Then
                Exit Sub
            End If

            Dim x As Integer = .RowSel

            If x = 0 Then
                Exit Sub
            End If

            xSUBFIELDNO.Text = .Item(x, "FIELDNO")
            POPULATEFIELDDETAILS(.Item(x, "FIELDNO"))
            POPULATEWOHEADER(.Item(x, "MAINWOID"))

        End With

        MAINTAB.SelectedTab = Details()
        btAddHeader.Select()
    End Sub

    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        POPULATEMAINWORKORDER()
    End Sub

    Private Sub DgWOHeader_Click(sender As Object, e As EventArgs) Handles dgWOHeader.Click
        With dgWOHeader
            If .Rows.Count = 1 Then
                Exit Sub
            End If

            Dim x As Integer = .RowSel

            If x = 0 Then
                Exit Sub
            End If

            POPULATEWODETAIL(.Item(x, "WORKORDERID"))
        End With

    End Sub
End Class
