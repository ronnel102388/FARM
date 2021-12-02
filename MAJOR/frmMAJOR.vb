Imports C1.Win.C1FlexGrid
Public Class frmMAJOR
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
        If checkstate <> "True" Then
            ConTools.SetStatusBar(RbnIP, RbnCN, RbnUser, RbnExeCode, RbnBuildNo, RbnDev)
        End If
        RbnConnName.Text = PrimCom
        RbnBuildNo.Text = "PROGEN 5.0 as of " & System.IO.File.GetLastWriteTime(Application.ExecutablePath)

        Username = RbnUser.Text
        If QueryCompanyCode(Username) = "" Then
            RbnCompany.Text = "1REI"
        Else
            RbnCompany.Text = QueryCompanyCode(Username)
        End If
        ' RbnCompany.Text = "1REI"

        Comp = RbnCompany.Text

        CompName = RbnCN.Text
        MyDept = "Information Technology"
        'DeptId = 1
        'EmpID = FindEmID(Username)
    End Sub

    Sub ControlsEvent(ByVal Bool)
        BtSave.Enabled = Not Bool
        btCancelUpdate.Enabled = Not Bool
        panelentry.Enabled = Not Bool

        btAdd.Enabled = Bool
        BtEdit.Enabled = Bool
        BtDelete.Enabled = Bool
    End Sub
#End Region


#Region "POPULATE"
    Sub PopulateMajor()
        Dim sql As String = ""
        Dim search As String = XSEARCH.Text.Replace("'", "")

        sql = <s>
                  SELECT [RECID]
                      ,[MAJORACTIVITY]
                      ,[COID]
                      ,[ISACTIVE]
                      ,[CREATEDBY]
                      ,convert(varchar,[CREATIONDATE],0) CREATIONDATE
                      ,[MODIFIEDBY]
                      ,convert(varchar,[MODIFICATIONDATE],0) MODIFICATIONDATE
                  FROM [M_POT_MAJORACTIVITY]
                  WHERE MAJORACTIVITY LIKE '%<%= search %>%'
                  ORDER BY RECID DESC
              </s>

        SelectQuery(sql)
        With dgMajor
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            .Cols("RECID").Caption = "ID"
            .AutoSizeCols()
        End With
        'xrecordcount.Text = grid1.Rows.Count
    End Sub
#End Region
    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
        'xRECID.Text = ""
        xMAJORACTIVITY.Text = ""

        PopulateMajor()
    End Sub
    Private Sub FrmMAJOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()

        '================CLEAR
        xRECID.Text = ""
        xMAJORACTIVITY.Text = ""

        '================CONTROL
        ControlsEvent(True)

        '================POPULATE
        PopulateMajor()
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsAdd") = False Then
                MsgBox("You have no access to Add in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If
        '================CLEAR
        'xRECID.Text = ""
        'xMAJORACTIVITY.Text = ""
        frmMAJORADD.ShowDialog()
        '================CONTROL
        'ControlsEvent(False)

    End Sub
    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsEdit") = False Then
                MsgBox("You have no access to Edit in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If
        If xRECID.Text = "" Or Val(xRECID.Text) = 0 Then
            MsgBox("Please select transaction first.", vbExclamation, "VALIDATION")
            Exit Sub
        End If
        ControlsEvent(False)
    End Sub

    Private Sub dgMajor_Click(sender As Object, e As EventArgs) Handles dgMajor.Click
        If dgMajor.Rows.Count = 1 Then
            Exit Sub
        End If

        If BtSave.Enabled = True Then
            Exit Sub
        End If

        Dim i As Integer = dgMajor.RowSel

        If dgMajor.Rows.Count - 1 > 0 Then
            xRECID.Text = dgMajor.Item(i, "RECID").ToString
            xMAJORACTIVITY.Text = dgMajor.Item(i, "MAJORACTIVITY").ToString
            isActive.Text = dgMajor.Item(i, "isActive").ToString
        End If



    End Sub

    Private Sub dgMajor_DoubleClick(sender As Object, e As EventArgs) Handles dgMajor.DoubleClick
        BtEdit.PerformClick()
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If isActive.Text = "False" Then
            MsgBox("Can't proceed item is not active." & vbCrLf & "Please contact administrator.", vbExclamation, "VALIDATION")
            Exit Sub
        End If






        If xMAJORACTIVITY.Text = "" Then
            MsgBox("Please Add Major Activity", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If FindIfExist("MAJORACTIVITY", "M_POT_MAJORACTIVITY", "MAJORACTIVITY", xMAJORACTIVITY.Text) >= 1 Then
            MsgBox("Major Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim sql As String = ""



        sql = <s>
                    UPDATE M_POT_MAJORACTIVITY
                        SET [MAJORACTIVITY] = '<%= xMAJORACTIVITY.Text %>'
                        ,[COID] = '<%= RbnCompany.Text %>'
                        ,[ISACTIVE] = 1
                        ,[MODIFIEDBY] = '<%= RbnUser.Text %>'
                        ,[MODIFICATIONDATE] = getdate()
                    WHERE RECID = <%= xRECID.Text %>
                  </s>

        ExeQuery(sql)
        MsgBox("Transaction successfully saved", MsgBoxStyle.Information, "Information")

        xRECID.Text = ""
        xMAJORACTIVITY.Text = ""
        ControlsEvent(True)
        PopulateMajor()

    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsAdd") = False Then
                MsgBox("You have no access to delete in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If


        If isActive.Text = "False" Then
            MsgBox("Item Already deactivated.", vbExclamation, "VALIDATION")
            Exit Sub
        End If




        If dgMajor.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMajor.RowSel

        If i = 0 Then
            MsgBox("Please select transaction first.", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim Sql As String = <s>
                            UPDATE M_POT_MAJORACTIVITY
                               SET [ISACTIVE] = 0
                             WHERE RECID = <%= dgMajor.Item(i, "RECID") %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "VALIDATION")
        PopulateMajor()
        xRECID.Text = ""
        xMAJORACTIVITY.Text = ""
    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click

        xRECID.Text = ""
        xMAJORACTIVITY.Text = ""
        ControlsEvent(True)
        isActive.Text = ""
        PopulateMajor()
    End Sub

    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        PopulateMajor()
    End Sub

    Private Sub BTEXPORT_Click(sender As Object, e As EventArgs) Handles BTEXPORT.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsExport") = False Then
                MsgBox("You have no access to Export into MSExcel in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If

        Dim sfd As New SaveFileDialog
        Me.Cursor = Cursors.WaitCursor
        With sfd
            .Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*"
            .FileName = "FARM POT MAJOR ACTIVITY LIST -" & Format(Now, "MMddyyyy")
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                dgMajor.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End With
    End Sub
End Class
