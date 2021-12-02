Imports C1.Win.C1FlexGrid
Public Class frmRESOURCES
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
                  select * from M_POT_RESOURCES WHERE RESOURCES LIKE '%<%= search %>%'
                  ORDER BY RECID DESC

              </s>

        SelectQuery(sql)
        With dgResources
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
        txtResources.Text = ""
        btAdd.Enabled = False
        BtSave.Enabled = False

        populate()
    End Sub

    Private Sub FrmMAJOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        populate()
    End Sub













    Private Sub BtAdd_Click_1(sender As Object, e As EventArgs) Handles btAdd.Click
        frmRESOURCESadd.ShowDialog()
    End Sub

    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        populate()
    End Sub

    Private Sub BtRefresh_Click_1(sender As Object, e As EventArgs) Handles BtRefresh.Click
        'RECID.Text = ""
        txtResources.Text = ""

        populate()
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

        BtSave.Enabled = True
        btAdd.Enabled = False
        BtEdit.Enabled = False
        txtResources.Enabled = True
        BtDelete.Enabled = False

    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click

        RECID.Text = ""
        txtResources.Text = ""
        txtResources.Enabled = False
        BtSave.Enabled = False
        BtEdit.Enabled = True
        BtDelete.Enabled = True
        populate()
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
            .FileName = "FARM POT RESOURCES LIST -" & Format(Now, "MMddyyyy")
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                dgResources.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End With
    End Sub

    Private Sub DgResources_Click(sender As Object, e As EventArgs) Handles dgResources.Click
        If dgResources.Rows.Count = 1 Then
            Exit Sub
        End If

        If BtSave.Enabled = True Then
            Exit Sub
        End If



        Dim i As Integer = dgResources.RowSel

        If dgResources.Rows.Count - 1 > 0 Then
            RECID.Text = dgResources.Item(i, "RECID").ToString
            txtResources.Text = dgResources.Item(i, "RESOURCES").ToString
            isActive.Text = dgResources.Item(i, "isActive").ToString
        End If
    End Sub

    Private Sub dgResources_DoubleClick(sender As Object, e As EventArgs) Handles dgResources.DoubleClick
        BtEdit.PerformClick()
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click

        If isActive.Text = "False" Then
            MsgBox("Can't proceed item is not active." & vbCrLf & "Please contact administrator.", vbExclamation, "VALIDATION")
            Exit Sub
        End If




        If txtResources.Text = "" Then
            MsgBox("Please Add Major Activity", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If FindIfExist("RESOURCES", "M_POT_RESOURCES", "RESOURCES", txtResources.Text) = txtResources.Text Then
            MsgBox("Major Activity is already exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are your sure you want to saved the transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim sql As String = ""


        sql = <s>
                    UPDATE M_POT_RESOURCES
                        SET [RESOURCES] = '<%= txtResources.Text %>'
                        ,[COID] = '<%= RbnCompany.Text %>'
                        ,[ISACTIVE] = 1
                        ,[MODIFIEDBY] = '<%= RbnUser.Text %>'
                        ,[MODIFICATIONDATE] = getdate()
                    WHERE RECID = <%= RECID.Text %>
              </s>

        ExeQuery(sql)
        MsgBox("Transaction successfully saved", MsgBoxStyle.Information, "Information")

        RECID.Text = ""
        txtResources.Text = ""
        btCancelUpdate.PerformClick()
        populate()
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



        If dgResources.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgResources.RowSel

        If i = 0 Then
            MsgBox("Please select transaction first.", vbExclamation, "VALIDATION")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "VALIDATION") = vbNo Then
            Exit Sub
        End If

        Dim Sql As String = <s>
                            UPDATE M_POT_RESOURCES
                               SET [ISACTIVE] = 0
                             WHERE RECID = <%= dgResources.Item(i, "RECID") %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "VALIDATION")
        populate()
        RECID.Text = ""
        txtResources.Text = ""
    End Sub
End Class
