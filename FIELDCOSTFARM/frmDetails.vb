Imports C1.Win.C1FlexGrid
Imports Configuration
Public Class frmDetails
    Public CC, TP, ACT As String
    Public isCB, MWOID, TEMPID As Integer
    Public subfield, landowner, faddress, fmanager, cropclass, fmodel, fclustes, plantingdate, age, gap As String
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")

    Private Sub BTpRINT_Click(sender As Object, e As EventArgs) Handles bTpRINT.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(frmMain.RbnUser.Text, frmMain.RbnExeCode.Text, "IsPrint") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If
        Dim sql As String = <s>
                                 EXEC FM_SF_LIST_DETAIL '<%= CC %>','<%= isCB %>','<%= TP %>',<%= MWOID %>,<%= TEMPID %>
                            </s>
        Dim dtPrint As DataTable = ConTools.DataReader(SConn, sql)
        Dim sFileName As String = My.Application.Info.DirectoryPath & "\FMREPORTS.xml"
        C1Report1.Load(sFileName, "FARMMAN_DETAILS")
        C1Report1.DataSource.ConnectionString = "Provider=SQLOLEDB.1;Password=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "PWD")) & "; User ID=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "UserID")) & "; Initial Catalog=" & IniCon.ReadString(PrimCom, "Database") & ";Data Source=" & IniCon.ReadString(PrimCom, "Server") & ""
        C1Report1.DataSource.RecordSource = sql

        C1Report1.Fields("LANDOWNERCtl").Text = landowner
        C1Report1.Fields("SUBFIELDNOCtl").Text = subfield


        C1Report1.Fields("CROPCLASSDETAILCtl").Text = cropclass

        C1Report1.Fields("FARMMANAGERCtl").Text = fmanager
        C1Report1.Fields("FARMADDRESSCtl").Text = faddress

        C1Report1.Fields("PLANTINGDATECtl").Text = plantingdate
        C1Report1.Fields("AGEOFCANECtl").Text = age

        C1Report1.Fields("PLANTEDAREACtl").Text = gap
        C1Report1.Fields("FARMMODELCtl").Text = fmodel



        Try
            frmPreview.C1PrintPreviewControl1.Document = C1Report1
            'frmPreview.TopMost = True
            frmPreview.ShowDialog()
        Catch ex As Exception
            MsgBox("Print out not successfully rendered. Please Print Again", MsgBoxStyle.Information, "")
        End Try
    End Sub

    Sub POPULATEDETAILS()
        Dim SQL As String = <s>
        EXEC FM_SF_LIST_DETAIL '<%= CC %>','<%= isCB %>','<%= TP %>',<%= MWOID %>,<%= TEMPID %>
                            </s>

        SelectQuery(SQL)
        With dgFIELDCOSTDETAILS
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols("COSTINPUTS").Caption = "MATERIAL"
            .Cols("COSTTRACTOR").Caption = "EQUIPMENT"
            .Cols("COSTLABOR").Caption = "LABOR"
            .Cols("AccomplishmentUnit").Caption = "ACCOMP. UNIT"
            .Cols("AccomplishmentDone").Caption = "ACCOMP. DONE"
            .Cols("AccomplishmentDone").Format = "N2"
            .Cols("Quantity").Format = "N2"
            .Cols("COSTINPUTS").Format = "N0"
            .Cols("COSTTRACTOR").Format = "N0"
            .Cols("COSTLABOR").Format = "N0"
            .Cols("TOTALCOST").Format = "N0"
        End With

        setgrid()
    End Sub

    Sub setgrid()
        With dgFIELDCOSTDETAILS
            .Tree.Style = TreeStyleFlags.Complete
            .Subtotal(AggregateEnum.None, -1, -1, -1, "TOTAL")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("TOTALCOST").Index, "{0}")
            .Cols.Frozen = 2
            .AutoSizeCols()
        End With
    End Sub
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLACTIVITY.Text = ACT
        POPULATEDETAILS()
    End Sub

    Private Sub BTEXPORT_Click(sender As Object, e As EventArgs) Handles BTEXPORT.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(frmMain.RbnUser.Text, frmMain.RbnExeCode.Text, "IsExport") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If

        Dim sfd As New SaveFileDialog

        With sfd
            .Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls|All Files|*.*"
            .FileName = "FIELDCOSTDETAILS-" & Format(Now, "MMddyyyy") & "-FM " & fmanager
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                dgFIELDCOSTDETAILS.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Exit Sub
            End If
        End With
    End Sub


End Class