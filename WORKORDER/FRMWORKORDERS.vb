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

    Sub POPULATEWORKORDER()
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


        POPULATEWORKORDER()
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
End Class
