Imports C1.Win.C1FlexGrid
Public Class FRMWORKORDERS
    Dim CURRENTTAB As Integer
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")

#Region "ROUTINE"
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
#End Region
#Region "POPULATE"
    Sub POPULATEMAINWORKORDER()
        Dim search As String = XSEARCH.Text.Replace("'", "")
        Dim sql As String = <s>     
                                 EXEC WORKORDER_LIST_MAINWORKORDER '<%= search %>'
                            </s>
        SelectQuery(sql)
        With dgMAINWO
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .AutoSizeCols()

            For x As Integer = 0 To .Cols.Count - 1
                If .Cols(x).Caption.Contains("ID") Or .Cols(x).Caption.Contains("Id") Then
                    .Cols(x).Visible = False
                Else
                    .Cols(x).Visible = True
                End If
            Next
            .Cols("MAINWO").Visible = False
            .Cols.Frozen = 4
        End With

    End Sub
    Sub POPULATEFIELDDETAILS(ByVal sf As String)
        Dim sql As String = <s>
                                EXEC WORKORDER_LIST_FIELDDETAILS '<%= sf %>'
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
                              EXEC  WORKORDER_LIST_WORKORDERHEADER <%= MWOID %>
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
                            EXEC WORKORDER_LIST_WORKORDERDETAIL <%= WOID %>
                            </s>
        SelectQuery(SQL)
        With dgWORes
            .DataSource = ds
            .DataMember = "table"
            .Cols.Fixed = 0
            .Rows(0).Height = 50

            For i As Integer = 0 To .Cols.Count - 1
                If .Cols(i).Caption.Contains("ID") Or .Cols(i).Caption = "ISACTIVE" Or .Cols(i).Caption.Contains("CODE") Then
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
#Region "FORM CONTROL"
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


#End Region
#Region "FILTER"
    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        POPULATEMAINWORKORDER()
    End Sub
#End Region
#Region "ACTION_MAIN"
    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If CURRENTTAB = 2 Then
            FRMCREATIONWORKORDERS.ShowDialog()
        End If
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
    Private Sub dgMAINWO_DoubleClick(sender As Object, e As EventArgs) Handles dgMAINWO.DoubleClick
        BtEdit.PerformClick()
    End Sub
#End Region
#Region "ACTION_DETIAL"
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
#End Region


    Private Sub FRMWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        BTNDASHBOARD.PerformClick()

        If putch_Count() = 0 Then
            xLBLCOUNT.Visible = False
        Else
            xLBLCOUNT.Visible = True
        End If
        xLBLCOUNT.Text = putch_Count()
    End Sub
    Private Sub BTNNOTIF_Click(sender As Object, e As EventArgs) Handles BTNNOTIF.Click
        FRMWORKORDERDASHBOARD.ShowDialog()
    End Sub
    Private Sub BTNSETTING_Click(sender As Object, e As EventArgs) Handles BTNSETTING.Click
        FRMARCHIVE.ShowDialog()
    End Sub


End Class
