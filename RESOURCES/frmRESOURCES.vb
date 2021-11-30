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
        ' Dim search As String = xsearch.Text.Replace(" ", "")

        sql = <s>
                  select * from M_POT_RESOURCES where isactive=1

              </s>

        SelectQuery(sql)
        With grid1
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            .Cols("RECID").Caption = "ID"
            .AutoSizeCols()

        End With
        'xrecordcount.Text = grid1.Rows.Count

    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
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



    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If FindIfExist("RESOURCES", "M_POT_RESOURCES", "RESOURCES", txtResources.Text) = txtResources.Text Then
            MsgBox("item  is existed or deactivated.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If




        Dim sql As String = ""
        sql = <s>
                         INSERT INTO [M_POT_RESOURCES]
           ([RESOURCES]
      ,[COID]
      ,[ISACTIVE]
      ,[CREATEDBY]
      ,[CREATIONDATE]
        )
     VALUES
           ('<%= txtResources.Text %>'
            ,'<%= RbnCompany.Text %>'
           ,1
            ,'<%= RbnUser.Text %>'
            ,getdate()
                  )


                      </s>
        ExeQuery(sql)

        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        BtRefresh.PerformClick()

    End Sub


    Private Sub grid1_DoubleClick(sender As Object, e As EventArgs) Handles grid1.DoubleClick
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            RECID.Text = grid1.Item(i, "RECID").ToString
            txtResources.Text = grid1.Item(i, "RESOURCES").ToString
        End If

        BtSave.Enabled = True
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If FindIfExist("RESOURCES", "M_POT_RESOURCES", "RESOURCES", txtResources.Text) = txtResources.Text Then
            MsgBox("item  is existed or deactivated.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If


        Dim Sql As String = <s>
                          UPDATE M_POT_RESOURCES
                               SET [RESOURCES] =  '<%= txtResources.Text %>'
                                ,[COID]='<%= RbnCompany.Text %>'
                               ,[MODIFIEDBY]='<%= RbnUser.Text %>'
                                ,[MODIFICATIONDATE]=getdate()
                             WHERE RECID = <%= RECID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Success.", MsgBoxStyle.Information, "Information")
        BtRefresh.PerformClick()
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            RECID.Text = grid1.Item(i, "RECID").ToString
            txtResources.Text = grid1.Item(i, "RESOURCES").ToString
        End If

        BtSave.Enabled = True
        btAdd.Enabled = False
    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click
        If grid1.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = grid1.RowSel

        If grid1.Rows.Count - 1 > 0 Then
            RECID.Text = grid1.Item(i, "RECID").ToString
        End If



        Dim Sql As String = <s>
                          UPDATE M_POT_RESOURCES
                               SET [ISACTIVE] = '0'
                             WHERE RECID = <%= RECID.Text %>
                            </s>
        ExeQuery(Sql)
        MsgBox("Transaction is successfully deactivated.", MsgBoxStyle.Information, "Validation")
        BtRefresh.PerformClick()
    End Sub

    Private Sub TxtResources_TextChanged(sender As Object, e As EventArgs) Handles txtResources.TextChanged
        If Not RECID.Text = "" Then
            Exit Sub
        End If

        If Not txtResources.Text = "" Then
            btAdd.Enabled = True
        Else
            btAdd.Enabled = False
        End If
    End Sub
End Class
