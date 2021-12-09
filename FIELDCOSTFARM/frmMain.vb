Imports C1.Win.C1FlexGrid
Imports Configuration
Public Class frmMain
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")
    Public SelectedPPEID As Integer
    Dim ISFROMAX As Boolean
    Dim ISFROMIMMIS As Boolean
    Public DeptId As Integer
    Dim CURRENTTAB As Integer

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
        If checkstate <> "True" Then
            ConTools.SetStatusBar(RbnIP, RbnCN, RbnUser, RbnExeCode, RbnBuildNo, RbnDev)
        End If
        RbnConnName.Text = PrimCom
        RbnBuildNo.Text = "PROGEN 5.0 as of " & System.IO.File.GetLastWriteTime(Application.ExecutablePath)

        Username = RbnUser.Text
        If QueryCompanyCode(Username) = "" Then
            RbnCompany.Text = "GFI2"
        Else
            RbnCompany.Text = QueryCompanyCode(Username)
        End If

        Comp = RbnCompany.Text

        CompName = RbnCN.Text
        MyDept = "Information Technology"
        DeptId = 1
        EmpID = FindEmID(Username)
    End Sub
    Sub SuggestAppend()
        Dim AutoComp As New AutoCompleteStringCollection()

        Dim sql As String = <s>
                        SELECT DISTINCT EmployeeID,Employee FROM vwEmployee EMP 
                        INNER JOIN M_FM_SUBFIELD FM
                        ON EMP.EmployeeID = FM.FARMMANID
                        WHERE FM.ISACTIVE = 1 
                        AND EMP.IsActive = 1 
                            </s>

        ExeReader(sql)

        While dr.Read
            AutoComp.Add(dr.Item("Employee"))

            ' AutoComp.Add(dr.Item("DEPTCODE"))
            '  AutoComp.Add(dr.Item("DEPARTMENT"))

        End While

        dr.Close()
        Conn.Close()

        XLINESEARCH.AutoCompleteMode = AutoCompleteMode.Suggest
        XLINESEARCH.AutoCompleteSource = AutoCompleteSource.CustomSource
        XLINESEARCH.AutoCompleteCustomSource = AutoComp
    End Sub
    Function ValidateFarmManager(ByVal FM As String) As String
        Dim sql As String = <s>
                select Employee from vwEmployee where Position like '%Farm Manager%' and isActive = 1
and Employee = '<%= FM %>'                        
                            </s>
        Dim FarmMan As String = ""
        ExeReader(sql)
        While dr.Read
            FarmMan = dr.Item("Employee")
        End While
        dr.Close()
        Conn.Close()
        Return FarmMan
    End Function

#End Region
#Region "FILTER"
    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click

        If LBLFARMMANAGER.Text.Replace(" ", "") <> "------------------" Then
            If ValidateFarmManager(LBLFARMMANAGER.Text) = "" Then
                MsgBox("Invalid Farm Manager!", vbCritical, "Error")
                Exit Sub
            End If
            If CURRENTTAB = 0 Then
                CURRENTTAB = 1
            End If
            POPULATEALL()
        End If
    End Sub
    Private Sub XLINESEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles XLINESEARCH.KeyDown
        If e.KeyCode = 13 Then
            If XLINESEARCH.Text <> "" Then
                If ValidateFarmManager(XLINESEARCH.Text) = "" Then
                    MsgBox("Invalid Farm Manager!", vbCritical, "Error")
                    Exit Sub
                End If
                LBLFARMMANAGER.Text = XLINESEARCH.Text.Replace("'", "''").ToUpper
                XLINESEARCH.Text = ""
            End If
        End If
    End Sub
#End Region
#Region "DASHBOARD"
    Sub POPULATEDASHBOARD()
        XTOTALALLAREA.Text = ""

        XNPAREA.Text = ""
        XNPTOTALFIELDS.Text = ""
        XNPFIELDWIN.Text = ""
        XNPFIELDOVER.Text = ""
        XNPTOTALBUDGET.Text = ""
        XNPBUDGET.Text = ""
        XNPACTUAL.Text = ""
        XNPREMAINING.Text = ""
        XNPLABORHAUL.Text = ""

        XRNAREA.Text = ""
        XRNTOTALFIELDS.Text = ""
        XRNFIELDWIN.Text = ""
        XRNFIELDOVER.Text = ""
        XRNTOTALBUDGET.Text = ""
        XRNBUDGET.Text = ""
        XRNACTUAL.Text = ""
        XRNREMAINING.Text = ""
        XRNLABORHAUL.Text = ""



        Dim TYPE As String = ""
        If XTYPE.Text <> "ALL" Then
            TYPE = XTYPE.Text
        End If

        Dim SQL As String = <s>
        EXEC FM_SF_LIST_DASHOBOARD '<%= LBLFARMMANAGER.Text %>', <%= Convert.ToInt32(XCUTBACK.CheckState) %>, '<%= TYPE %>'
                            </s>
        ExeReader(SQL)
        While dr.Read
            XTOTALALLAREA.Text = Format(dr.Item("TOTALAREA"), "n2")


            XNPTOTALFIELDS.Text = Val(dr.Item("NPTOTALFIELDS").ToString) & " FIELD(S)"
            XNPAREA.Text = Format(dr.Item("NPTOTALAREA"), "n2") & " Ha.(s)"
            XNPFIELDWIN.Text = Val(dr.Item("NPFIELDSINBUDGET").ToString) & " FIELD(S)"
            XNPFIELDOVER.Text = Val(dr.Item("NPFIELDSOUTBUDGET").ToString) & " FIELD(S)"

            XNPTOTALBUDGET.Text = Format(dr.Item("NPTOTALBUDGET"), "n0")
            XNPBUDGET.Text = Format(dr.Item("NPASOFBUDGET"), "n0")
            XNPACTUAL.Text = Format(dr.Item("NPTOTALCOST"), "n0")
            XNPREMAINING.Text = Format(dr.Item("NPVARIANCE"), "n0")
            XNPLABORHAUL.Text = Format(dr.Item("NPLABORHAUL"), "n0")
            'RATOON
            XRNTOTALFIELDS.Text = Val(dr.Item("RNTOTALFIELDS").ToString) & " FIELD(S)"
            XRNAREA.Text = Format(dr.Item("RNTOTALAREA"), "n2") & " Ha.(s)"
            XRNFIELDWIN.Text = Val(dr.Item("RNFIELDSINBUDGET").ToString) & " FIELD(S)"
            XRNFIELDOVER.Text = Val(dr.Item("RNFIELDSOUTBUDGET").ToString) & " FIELD(S)"

            XRNTOTALBUDGET.Text = Format(dr.Item("RNTOTALBUDGET"), "n0")
            XRNBUDGET.Text = Format(dr.Item("RNASOFBUDGET"), "n0")
            XRNACTUAL.Text = Format(dr.Item("RNTOTALCOST"), "n0")
            XRNREMAINING.Text = Format(dr.Item("RNVARIANCE"), "n0")
            XRNLABORHAUL.Text = Format(dr.Item("RNLABORHAUL"), "n0")
        End While

        dr.Close()
        Conn.Close()

    End Sub
    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click, BTNICONDASH.Click
        TabControl1.TabPages.Remove(TabPage1)
        TabControl1.TabPages.Add(TabPage1)
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage3)

        CURRENTTAB = 1
        POPULATEALL()
    End Sub
#End Region
#Region "FIELD COST SUMMARY"
    Sub POPULATECOSTPERFIELD()

        Dim TYPE As String = ""
        If XTYPE.Text <> "ALL" Then
            TYPE = XTYPE.Text
        End If

        Dim SQL As String = <S>
                             EXEC FM_SF_LIST '<%= LBLFARMMANAGER.Text %>', <%= Convert.ToInt32(XCUTBACK.Checked) %>, '<%= TYPE %>'
                            </S>
        SelectQuery(SQL)
        With DGCOSTPERFIELD
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50

            '.Cols("farmmanager").Visible = False
            '.Cols("farmassistant").Visible = False
            .Cols("cropclassdetail").Caption = "CROP CLASS"
            .Cols("cropyear").Visible = False
            .Cols("subfieldno").Width = 160
            .Cols("FARMMODELCODE").Width = 160
            .Cols("farmmodel").Visible = False
            .Cols("FARMCLUSTER").Visible = False
            .Cols("ageofcanedays").Visible = False
            .Cols("cropclass").Visible = False
            .Cols("FARMADDRESS").Width = 160
            .Cols("FARMADDRESS").Caption = "LOCATION"
            .Cols("productivearea").Caption = "GAP"
            .Cols("productivearea").Width = 100
            .Cols("subfieldno").Width = 160
            .Cols("ageofcanemonth").TextAlign = TextAlignEnum.CenterCenter
            .Cols("landowner").Width = 200
            .Cols("productivearea").Width = 150
            .Cols("productivearea").Format = "n2"
            .Cols("lastactivity").Width = 200
            .Cols("lastdateofactivity").Width = 200
            .Cols("budgetcost").Format = "n0"
            .Cols("budgetcost").Width = 150

            .Cols("ASOFBUDGET").Format = "n0"
            .Cols("ASOFBUDGET").Width = 150

            .Cols("actualcost").Format = "n0"
            .Cols("actualcost").Width = 150

            .Cols("LABORHAUL").Format = "n0"
            .Cols("LABORHAUL").Width = 150

            .Cols("VARIANCE").Format = "n0"

            .Cols("VARIANCE").Width = 150
            .Cols("LANDOWNERFIRST").Visible = False
            .Cols("TEMPID").Visible = False
            .AutoSizeCols()

            COLORREMARKS()
            SETGRIDFDSUMM()
        End With


    End Sub
    Sub SETGRIDFDSUMM()
        With DGCOSTPERFIELD
            .Tree.Style = TreeStyleFlags.Complete
            .Tree.Column = 0
            .Subtotal(AggregateEnum.None, -1, -1, -1, "TOTAL")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("ACTUALCOST").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("LABORHAUL").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("BUDGETCOST").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("ASOFBUDGET").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, -1, -1, -1, .Cols("VARIANCE").Index, "{0}")
            .Cols.Frozen = 2
            .AutoSizeCols()

        End With
    End Sub
    Sub COLORREMARKS()
        With DGCOSTPERFIELD

            For i = 1 To .Rows.Count - 1

                If .Item(i, "REMARKS") = False Then
                    Dim NewStyle2 As C1.Win.C1FlexGrid.CellStyle
                    NewStyle2 = .Styles.Add("NewStyle2")
                    NewStyle2.ForeColor = Color.White
                    NewStyle2.BackColor = System.Drawing.Color.Red
                    NewStyle2.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
                    .SetCellStyle(i, "REMARKS", NewStyle2)
                ElseIf .Item(i, "REMARKS") = True Then
                    Dim NewStyle3 As C1.Win.C1FlexGrid.CellStyle
                    NewStyle3 = .Styles.Add("NewStyle3")
                    NewStyle3.ForeColor = Color.White
                    NewStyle3.BackColor = System.Drawing.Color.Green
                    NewStyle3.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
                    .SetCellStyle(i, "REMARKS", NewStyle3)
                End If

            Next
        End With
    End Sub
    Private Sub DGCOSTPERFIELD_DoubleClick(sender As Object, e As EventArgs) Handles DGCOSTPERFIELD.DoubleClick
        If DGCOSTPERFIELD.Rows.Count = 1 Then
            MsgBox("Nothing to select!", vbCritical, "Error")
            Exit Sub
        End If
        Dim i As Integer = DGCOSTPERFIELD.RowSel
        If i = 1 Then
            Exit Sub
        End If


        Dim TYPE As String = ""
        If XTYPE.Text <> "ALL" Then
            TYPE = XTYPE.Text
        End If
        With frmDetailsPOT
            .FM = DGCOSTPERFIELD.Item(i, "FARMMANAGER").ToString
            '.FA = DGCOSTPERFIELD.Item(i, "FARMASSISTANT").ToString
            .CY = DGCOSTPERFIELD.Item(i, "CROPYEAR").ToString
            .CC = DGCOSTPERFIELD.Item(i, "cropclassdetail").ToString
            .SF = DGCOSTPERFIELD.Item(i, "SUBFIELDNO").ToString
            .AREA = DGCOSTPERFIELD.Item(i, "PRODUCTIVEAREA").ToString
            .TP = TYPE
            .isCB = Convert.ToInt32(XCUTBACK.Checked)
            .vACTUAL = DGCOSTPERFIELD.Item(i, "ACTUALCOST").ToString
            .vLABORHAUL = DGCOSTPERFIELD.Item(i, "LABORHAUL").ToString

            .ShowDialog()

        End With
    End Sub
    Private Sub BTEXPORTCOSTPERFIELD_Click(sender As Object, e As EventArgs) Handles BTEXPORTCOSTPERFIELD.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsExport") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If

        Dim sfd As New SaveFileDialog

        With sfd
            .Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls|All Files|*.*"
            .FileName = "COST PER FIELD-" & Format(Now, "MMddyyyy") & "-FM " & LBLFARMMANAGER.Text.ToUpper
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                DGCOSTPERFIELD.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Exit Sub
            End If
        End With
    End Sub
    Private Sub BTPRINTPERFIELD_Click(sender As Object, e As EventArgs) Handles BTPRINTPERFIELD.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsPrint") = False Then
                MsgBox("You have no access to " & sender.text & " in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If
        If ValidateFarmManager(LBLFARMMANAGER.Text) = "" Then
            MsgBox("Invalid Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If
        Dim TYPE As String = ""
        If XTYPE.Text <> "ALL" Then
            TYPE = XTYPE.Text
        End If
        Dim sql As String = <s>
                      EXEC FM_SF_LIST '<%= LBLFARMMANAGER.Text %>', <%= Convert.ToInt32(XCUTBACK.Checked) %>, '<%= TYPE %>'
                                     </s>
        Dim dtPrint As DataTable = ConTools.DataReader(SConn, sql)
        Dim sFileName As String = My.Application.Info.DirectoryPath & "\FMREPORTS.xml"
        C1Report1.Load(sFileName, "FARMMAN_HEADER")
        C1Report1.DataSource.ConnectionString = "Provider=SQLOLEDB.1;Password=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "PWD")) & "; User ID=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "UserID")) & "; Initial Catalog=" & IniCon.ReadString(PrimCom, "Database") & ";Data Source=" & IniCon.ReadString(PrimCom, "Server") & ""
        C1Report1.DataSource.RecordSource = sql

        Try
            frmPreview.C1PrintPreviewControl1.Document = C1Report1
            frmPreview.ShowDialog()
        Catch ex As Exception
            MsgBox("Print out not successfully rendered. Please Print Again", MsgBoxStyle.Information, "")
        End Try
    End Sub
#End Region
#Region "CONTROL EVENTS"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage3)
        PrepareUser()
        SuggestAppend()
        CURRENTTAB = 0

        XTYPE.SelectedIndex = 1
        XCUTBACK.Checked = False
        POPULATEALL()

    End Sub
    Sub POPULATEALL()
        If CURRENTTAB = 1 Then
            Me.Cursor = Cursors.WaitCursor
            POPULATEDASHBOARD()
            Me.Cursor = Cursors.Default
        ElseIf CURRENTTAB = 2 Then
            Me.Cursor = Cursors.WaitCursor
            POPULATEDASHBOARD()
            POPULATECOSTPERFIELD()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub BTPROCEED_Click(sender As Object, e As EventArgs) Handles BTPROCEED.Click
        If ValidateFarmManager(LBLFARMMANAGER.Text) = "" Then
            MsgBox("Invalid Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If
        If CURRENTTAB = 0 Then
            CURRENTTAB = 1
        End If
        POPULATEALL()
    End Sub
    Private Sub btCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        XTOTALALLAREA.Text = "0.00"
        XNPAREA.Text = "0.00 Ha.(s)"
        XNPTOTALFIELDS.Text = "0 FIELDS"
        XNPFIELDWIN.Text = "0 FIELDS"
        XNPFIELDOVER.Text = "0 FIELDS"
        XNPTOTALBUDGET.Text = "0.00"
        XNPBUDGET.Text = "0.00"
        XNPACTUAL.Text = "0.00"
        XNPREMAINING.Text = "0.00"
        XRNAREA.Text = "0.00 Ha.(s)"
        XRNTOTALFIELDS.Text = "0 FIELDS"
        XRNFIELDWIN.Text = "0 FIELDS"
        XRNFIELDOVER.Text = "0 FIELDS"
        XRNTOTALBUDGET.Text = "0.00"
        XRNBUDGET.Text = "0.00"
        XRNACTUAL.Text = "0.00"
        XRNREMAINING.Text = "0.00"




        LBLFARMMANAGER.Text = "------------------"
        CURRENTTAB = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CURRENTTAB = 1 Then
            POPULATEALL()
        End If
    End Sub

    Private Sub BTNCOST_Click(sender As Object, e As EventArgs) Handles BTNCOST.Click

        If ValidateFarmManager(LBLFARMMANAGER.Text) = "" Then
            MsgBox("Invalid Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Add(TabPage2)
        TabControl1.TabPages.Remove(TabPage1)
        TabControl1.TabPages.Remove(TabPage3)

        CURRENTTAB = 2
        POPULATEALL()
    End Sub

    Private Sub DGCOSTPOT_Click(sender As Object, e As EventArgs) Handles DGCOSTPOT.Click

    End Sub

    Private Sub DGCOSTPOT_DoubleClick(sender As Object, e As EventArgs) Handles DGCOSTPOT.DoubleClick

    End Sub

    Private Sub DGCOSTPERFIELD_Click(sender As Object, e As EventArgs) Handles DGCOSTPERFIELD.Click

    End Sub

#End Region
End Class
