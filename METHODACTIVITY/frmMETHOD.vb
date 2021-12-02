Imports C1.Win.C1FlexGrid
Public Class frmMETHOD
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
    Sub populate()
        Dim sql As String = ""
        Dim search As String = XSEARCH.Text.Replace(" ", "")

        sql = <s>
                  select * from M_POT_METHODOFACTIVITY WHERE METHODACTIVITY LIKE '%<%= search %>%'
                  ORDER BY RECID DESC

              </s>

        SelectQuery(sql)
        With dgMethod
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            .Cols("RECID").Caption = "ID"
            .AutoSizeCols()

        End With
        'xrecordcount.Text = grid1.Rows.Count

    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs)
        RECID.Text = ""
        METHODACTIVITY.Text = ""
        btAdd.Enabled = False
        BtSave.Enabled = False

        populate()
    End Sub

    Private Sub FrmMAJOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        populate()
    End Sub






    Private Sub grid1_DoubleClick(sender As Object, e As EventArgs) Handles dgMethod.DoubleClick
        BtEdit.PerformClick()
    End Sub




    Private Sub BtDelete_Click(sender As Object, e As EventArgs)
        If dgMethod.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = dgMethod.RowSel

        If dgMethod.Rows.Count - 1 > 0 Then
            RECID.Text = dgMethod.Item(i, "RECID").ToString
        End If



        Dim Sql As String = <s>
                          UPDATE M_POT_METHODOFACTIVITY
                               SET [ISACTIVE] = '0'
                             WHERE RECID = <%= RECID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "Validation")
        BtRefresh.PerformClick()
    End Sub



    Private Sub BtAdd_Click_1(sender As Object, e As EventArgs) Handles btAdd.Click
        frmMETHODadd.ShowDialog()
    End Sub

    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        populate()
    End Sub

    Private Sub BtRefresh_Click_1(sender As Object, e As EventArgs) Handles BtRefresh.Click
        populate()
        'RECID.Text = ""
        METHODACTIVITY.Text = ""
    End Sub

    Private Sub BtEdit_Click_1(sender As Object, e As EventArgs) Handles BtEdit.Click
        If checkstate <> "True" Then
            If ConTools.CheckAccess(RbnUser.Text, RbnExeCode.Text, "IsEdit") = False Then
                MsgBox("You have no access to Edit in this facility", MsgBoxStyle.Information, "Contact System Administrator")
                Exit Sub
            End If
        End If

        If RECID.Text = "" Or Val(RECID.Text) = 0 Then
            MsgBox("Please select transaction first.", vbExclamation, "VALIDATION")
            Exit Sub
        End If





        METHODACTIVITY.Enabled = True
        BtEdit.Enabled = False
        btCancelUpdate.Enabled = True
        BtSave.Enabled = True
        btAdd.Enabled = False
        BtDelete.Enabled = False



    End Sub

    Private Sub BtSave_Click_1(sender As Object, e As EventArgs) Handles BtSave.Click
        If isActive.Text = "False" Then
            MsgBox("Can't proceed item is not active." & vbCrLf & "Please contact administrator.", vbExclamation, "VALIDATION")
            Exit Sub
        End If





        If METHODACTIVITY.Text = "" Then
            MsgBox("Please Add Major Activity", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If FindIfExist("METHODACTIVITY", "M_POT_METHODOFACTIVITY", "METHODACTIVITY", METHODACTIVITY.Text) = METHODACTIVITY.Text Then
            MsgBox("Major Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If


        Dim Sql As String = <s>
                          UPDATE M_POT_METHODOFACTIVITY
                               SET [METHODACTIVITY] =  '<%= METHODACTIVITY.Text %>'
                                ,[COID]='<%= RbnCompany.Text %>'
                               ,[ISACTIVE] = 1
                               ,[MODIFIEDBY]='<%= RbnUser.Text %>'
                                ,[MODIFICATIONDATE]=getdate()
                             WHERE RECID = <%= RECID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        BtRefresh.PerformClick()
        METHODACTIVITY.Enabled = False
        btCancelUpdate.PerformClick()

    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        RECID.Text = ""
        METHODACTIVITY.Text = ""
        METHODACTIVITY.Enabled = False
        BtEdit.Enabled = True
        btCancelUpdate.Enabled = False
        BtSave.Enabled = False
        btAdd.Enabled = True
        BtDelete.Enabled = True
    End Sub

    Private Sub Grid1_Click(sender As Object, e As EventArgs) Handles dgMethod.Click
        If dgMethod.Rows.Count = 1 Then
            Exit Sub
        End If

        If BtSave.Enabled = True Then
            Exit Sub
        End If



        Dim i As Integer = dgMethod.RowSel

        If dgMethod.Rows.Count - 1 > 0 Then
            RECID.Text = dgMethod.Item(i, "RECID").ToString
            METHODACTIVITY.Text = dgMethod.Item(i, "METHODACTIVITY").ToString
            isActive.Text = dgMethod.Item(i, "isActive").ToString
        End If
    End Sub

    Private Sub BtDelete_Click_1(sender As Object, e As EventArgs) Handles BtDelete.Click
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



        If dgMethod.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMethod.RowSel

        If i = 0 Then
            MsgBox("Please select transaction first.", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim Sql As String = <s>
                            UPDATE M_POT_METHODOFACTIVITY
                               SET [ISACTIVE] = 0
                             WHERE RECID = <%= dgMethod.Item(i, "RECID") %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "VALIDATION")
        populate()
        RECID.Text = ""
        METHODACTIVITY.Text = ""
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
            .FileName = "FARM POT METHOD OF ACTIVITY LIST -" & Format(Now, "MMddyyyy")
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                dgMethod.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
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
