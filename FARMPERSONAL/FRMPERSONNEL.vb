Imports C1.Win.C1FlexGrid

Public Class FRMPERSONNEL
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

        Comp = RbnCompany.Text

        CompName = RbnCN.Text
        MyDept = "Information Technology"
        'DeptId = 1
        EmpID = FindEmID(Username)
    End Sub
    Sub POPULATEFARMMAN()
        Dim sql As String = <s>
        select Employee from vwEmployee where Position like '%Farm Manager%' and isActive = 1
         </s>
        Try
            ExeReader(sql)

            XFARMMANAGER.Items.Clear()

            While dr.Read
                XFARMMANAGER.Items.Add(dr.Item("Employee"))
            End While

            dr.Close()
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Something went wrong!")
        End Try

    End Sub

    Sub POPULATEFARMASS()
        Dim sql As String = <s>
        select Employee from vwEmployee where Position like '%Farm Assistant%' and isActive = 1
         </s>
        Try
            ExeReader(sql)

            XFARMASSISTANT.Items.Clear()

            While dr.Read
                XFARMASSISTANT.Items.Add(dr.Item("Employee"))
            End While

            dr.Close()
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Something went wrong!")
        End Try

    End Sub

    Sub POPULATE(ByVal FM As Integer, ByVal FA As Integer)
        XSELECTALL.Checked = False
        Dim sql As String = <s>
        EXEC FARM_PERSONNEL_SUBFIELD <%= FM %>,<%= FA %>,'<%= Comp %>','<%= XSEARCH.Text %>'

                            </s>
        Try
            SelectQuery(sql)
            With DGFIELDS
                .DataSource = ds
                .DataMember = "table"
                .Rows(0).Height = 50
                .Cols("SUBFIELDID").Visible = False
                .Cols("TAG").Width = 50
                .Cols("SUBFIELDNO").Width = 200
                .Cols("MAINFIELDNO").Width = 200
                ' .Cols("ADDRESS").Width = .Width - Val(.Cols("TAG").Width + .Cols("SUBFIELDNO").Width + .Cols("MAINFIELDNO").Width)
                ' .AutoSizeCols()
                .Cols("TAG").Sort = True

                For I = 2 To .Cols.Count - 1
                    .Cols(I).AllowEditing = False
                    .Cols(I).Caption = .Cols(I).Caption.ToUpper
                Next
                XROWS.Text = "(" & .Rows.Count - 1 & ") TOTAL ROWS"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Something went wrong!")
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        BtEdit.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        BtSave.PerformClick()
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        btCancelUpdate.PerformClick()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        bTpRINT.PerformClick()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        BTEXPORT.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub FRMPERSONNEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        POPULATEFARMMAN()
        POPULATEFARMASS()
        POPULATE(0, 0)
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        If XFARMMANAGER.SelectedIndex = -1 And XFARMASSISTANT.SelectedIndex = -1 Then
            MsgBox("Invalid Entries![FARM MANAGER & FARM ASSISTANT]", vbCritical, "Error")
            Exit Sub
        End If
        Dim FMID As Integer = ValidateFM(XFARMMANAGER.Text)
        If FMID = 0 Then
            MsgBox("Invalid Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If

        Dim FAID As Integer = ValidateFA(XFARMASSISTANT.Text)
        If FAID = 0 Then
            MsgBox("Invalid Farm Assistant!", vbCritical, "Error")
            Exit Sub
        End If

        ' MsgBox(FMID & "-" & FAID & "-" & Comp)
        POPULATE(FMID, FAID)



    End Sub

    Private Sub BtCancelUpdate_Click(sender As Object, e As EventArgs) Handles btCancelUpdate.Click
        XFARMMANAGER.SelectedIndex = -1
        XFARMASSISTANT.SelectedIndex = -1
        XSEARCH.Text = ""
        XSELECTALL.Checked = False
        BTSEARCHLINE.PerformClick()
    End Sub

    Private Sub BTSEARCHLINE_Click(sender As Object, e As EventArgs) Handles BTSEARCHLINE.Click
        Dim FAID As Integer = ValidateFA(XFARMASSISTANT.Text)
        Dim FMID As Integer = ValidateFM(XFARMMANAGER.Text)
        ' BtEdit.PerformClick()
        POPULATE(FMID, FAID)
    End Sub

    Private Sub XSEARCH_TextChanged(sender As Object, e As EventArgs) Handles XSEARCH.TextChanged

    End Sub

    Private Sub XSEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles XSEARCH.KeyDown
        If e.KeyCode = 13 Then
            BTSEARCHLINE.PerformClick()
        End If
    End Sub



    Sub UPDATETABLE(ByVal FMID As Integer, ByVal FAID As Integer, ByVal SFID As Integer, ByVal TAG As Integer)
        Me.Cursor = Cursors.WaitCursor
        Dim ExistinFa As Integer = ValidateExistenceFA(SFID, FAID)
        Dim ExistinFm As Integer = ValidateExistenceFM(SFID, FMID)
        Dim ExistSubfieldFM As Integer = ValidateSubfield(SFID, "M_FM_SUBFIELD")
        ' Dim ExistSubfieldFA As Integer = ValidateSubfield(SFID, "M_FA_SUBFIELD")
        'MsgBox(ExistinFm & "--" & ExistinFa)

        ' Exit Sub
        If ExistSubfieldFM > 0 Then
            MsgBox("Sub field Exist in other Farm Managers!", vbCritical, "Error")
            Exit Sub
        End If

        'If ExistSubfieldFA > 0 Then
        '    MsgBox("Sub field Exist in other Farm Assistant!", vbCritical, "Error")
        '    Exit Sub
        'End If

        Dim sql As String = ""
        '===INSERT NEW FM
        Dim sqlfmInsert As String = <s>
        INSERT INTO M_FM_SUBFIELD (TAG,FARMMANID,SUBFIELDID,MODIFIEDBY,COID) VALUES
        (<%= TAG %>,<%= FMID %>,<%= SFID %>,'<%= RbnUser.Text %>','<%= Comp %>')

        INSERT INTO M_FM_SUBFIELD_HISTORY (TAG,FARMMANID,SUBFIELDID,CREATEDBY,CREATIONDATE,COID) VALUES
        (<%= TAG %>,<%= FMID %>,<%= SFID %>,'<%= RbnUser.Text %>',GETDATE(),'<%= Comp %>')
                              </s>

        '===INSERT NEW FA
        Dim sqlfaInsert As String = <s>
        INSERT INTO M_FA_SUBFIELD (TAG,FARMASSTID,SUBFIELDID,MODIFIEDBY,COID) VALUES
        (<%= TAG %>,<%= FAID %>,<%= SFID %>,'<%= RbnUser.Text %>','<%= Comp %>')

        INSERT INTO M_FA_SUBFIELD_HISTORY (TAG,FARMASSTID,SUBFIELDID,CREATEDBY,CREATIONDATE,COID) VALUES
        (<%= TAG %>,<%= FAID %>,<%= SFID %>,'<%= RbnUser.Text %>',GETDATE(),'<%= Comp %>')
                              </s>

        '===UPDATE FM
        Dim sqlfmUpdate As String = <s>
        UPDATE M_FM_SUBFIELD SET FARMMANID = <%= FMID %>,SUBFIELDID = <%= SFID %>,TAG = <%= TAG %>
        WHERE RECID = <%= ExistinFm %>

        INSERT INTO M_FM_SUBFIELD_HISTORY (TAG,FARMMANID,SUBFIELDID,CREATEDBY,CREATIONDATE,COID) VALUES
        (<%= TAG %>,<%= FMID %>,<%= SFID %>,'<%= RbnUser.Text %>',GETDATE(),'<%= Comp %>')
                                    </s>

        '===UPDATE FA
        Dim sqlfAUpdate As String = <s>
        UPDATE M_FA_SUBFIELD SET FARMASSTID = <%= FAID %>,SUBFIELDID = <%= SFID %>,TAG = <%= TAG %>
        WHERE RECID = <%= ExistinFa %>

        INSERT INTO M_FA_SUBFIELD_HISTORY (TAG,FARMASSTID,SUBFIELDID,CREATEDBY,CREATIONDATE,COID) VALUES
        (<%= TAG %>,<%= FAID %>,<%= SFID %>,'<%= RbnUser.Text %>',GETDATE(),'<%= Comp %>')
                                    </s>


        If ExistinFm = 0 Then
            sql = sqlfmInsert
        Else
            sql = sqlfmUpdate
        End If
        ExeQuery(sql)

        If ExistinFa = 0 Then
            sql = sqlfaInsert
        Else
            sql = sqlfAUpdate
        End If
        ExeQuery(sql)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DGFIELDS_AfterEdit(sender As Object, e As RowColEventArgs) Handles DGFIELDS.AfterEdit
        Try
            Dim COL As Integer = DGFIELDS.ColSel

            If COL = 1 Then
                Dim FMID As Integer = ValidateFM(XFARMMANAGER.Text)
                Dim FAID As Integer = ValidateFA(XFARMASSISTANT.Text)

                If FMID = 0 Or FAID = 0 Then
                    Exit Sub
                End If
                Dim i As Integer = DGFIELDS.RowSel

                'MsgBox(FAID)
                UPDATETABLE(FMID, FAID, DGFIELDS.Item(i, "SUBFIELDID"), Convert.ToInt32(DGFIELDS.Item(i, "TAG")))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Something Went Wrong!!")
        End Try



    End Sub

    Private Sub DGFIELDS_Click(sender As Object, e As EventArgs) Handles DGFIELDS.Click
        'Dim I As Integer = DGFIELDS.RowSel
        'If DGFIELDS.Item(i, "tag") = False Then
        '    XSELECTALL.CheckState = Windows.Forms.CheckState.Unchecked
        'Else
        '    XSELECTALL.CheckState = Windows.Forms.CheckState.Checked
        '    For g = 1 To DGFIELDS.Rows.Count - 1
        '        If DGFIELDS.Item(g, "tag") = False Then
        '            XSELECTALL.CheckState = Windows.Forms.CheckState.Unchecked
        '            Exit For
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub XSELECTALL_CheckedChanged(sender As Object, e As EventArgs) Handles XSELECTALL.CheckedChanged

    End Sub

    Private Sub XSELECTALL_Click(sender As Object, e As EventArgs) Handles XSELECTALL.Click


    End Sub


    Private Sub BTEXPORT_Click(sender As Object, e As EventArgs) Handles BTEXPORT.Click
        If XFARMASSISTANT.SelectedIndex = -1 Then
            MsgBox("Select Farm Assistant!", vbCritical, "Error")
            Exit Sub
        End If
        If XFARMMANAGER.SelectedIndex = -1 Then
            MsgBox("Select Farm Manager!", vbCritical, "Error")
            Exit Sub
        End If
        If DGFIELDS.Rows.Count = 1 Then
            MsgBox("Nothing to export!", vbCritical, "Error")
            Exit Sub
        End If
        Dim sfd As New SaveFileDialog

        With sfd
            .Filter = "Excel Files (*.xls)|*.xls|All Files|*.*"
            .FileName = "FARM_PERSONNEL_TAG_FM_" & XFARMMANAGER.Text & "_FA_" & XFARMASSISTANT.Text
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                DGFIELDS.SaveExcel(.FileName, "", FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges + FileFlags.AsDisplayed)
                MessageBox.Show("File was Successfully Exported.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub BTNZOOMOUT_Click(sender As Object, e As EventArgs) Handles BTNZOOMOUT.Click
        'With DGFIELDS
        '    For i = 0 To .Cols.Count - 1
        '        .Cols(i).Width += 1
        '    Next

        '    For i = 0 To .Rows.Count - 1
        '        .Rows(i).Height += 1
        '    Next


        'End With
    End Sub

    Private Sub BTNZOOMIN_Click(sender As Object, e As EventArgs) Handles BTNZOOMIN.Click
        'With DGFIELDS
        '    For i = 0 To .Cols.Count - 1
        '        .Cols(i).Width -= 1
        '    Next

        '    For i = 0 To .Rows.Count - 1
        '        .Rows(i).Height -= 1
        '    Next
        'End With
    End Sub

    Private Sub BTNSELECTTOP_Click(sender As Object, e As EventArgs) Handles BTNSELECTTOP.Click
        Try

            Dim IDSTRING As String = ""
            Dim FMID As Integer = ValidateFM(XFARMMANAGER.Text)
            Dim FAID As Integer = ValidateFA(XFARMASSISTANT.Text)

            If FMID = 0 Or FAID = 0 Then
                MsgBox("Select | Farm Manager and Farm Assistant | !", vbCritical, "Error")
                If XSELECTALL.Checked = True Then
                    XSELECTALL.Checked = False
                Else
                    XSELECTALL.Checked = True
                End If
                Exit Sub
            End If
            Dim lastnum As Integer = Convert.ToInt32(XNUMROWS.Value)
            For i = 1 To lastnum
                If XSELECTALL.CheckState = Windows.Forms.CheckState.Checked Then
                    DGFIELDS.Item(i, "Tag") = True
                Else
                    DGFIELDS.Item(i, "Tag") = False
                End If
                If i = 1 Then

                    IDSTRING = "(" & DGFIELDS.Item(i, "SUBFIELDID").ToString & ")"

                Else

                    IDSTRING = IDSTRING & ",(" & DGFIELDS.Item(i, "SUBFIELDID").ToString & ")"

                End If
            Next

            'Dim CheckCounter As Integer = 0
            'For i = 1 To lastnum
            '    CheckCounter += 1
            'Next
            'If CheckCounter = 0 Then
            '    MsgBox("No selected")
            'End If
            Cursor = Cursors.WaitCursor

            Dim TAG As Integer = Convert.ToInt32(XSELECTALL.CheckState)
            Dim NUMROWS As Integer = DGFIELDS.Rows.Count - 1
            Dim sql As String = <s>
            EXEC FARM_PERSONNEL_MULTIPLE_SELECT <%= FAID %>,<%= FMID %>,<%= TAG %>,'<%= Comp %>','<%= RbnUser.Text %>',<%= NUMROWS %>,'<%= IDSTRING %>'
                                </s>
            ExeQuery(sql)
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Something Went Wrong!!")
        End Try
    End Sub
End Class
