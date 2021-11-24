Imports C1.Win.C1FlexGrid
Public Class FRMWORKORDERS

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
        EXEC VIEW_WORKORDERS '<%= Comp %>'
                            </s>
        SelectQuery(sql)
        With DGWORKORDER
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols("SUBFIELDID").Visible = False
            .Cols("CROPCLASSDETAILID").Visible = False
            .Cols("SUBFIELDNO").Caption = "SUB FIELD"
            .Cols("SUBFIELDNO").Width = 300
            .Cols("WOCODE").Caption = "WORK ORDER CODE"
            .Cols("WOCODE").Width = 300
            .Cols("CROPCLASSDETAIL").Caption = "CROP CLASS"
            .Cols("CROPCLASSDETAIL").Width = 300
            .Cols("TRANSDATE").Caption = "TRANSACTION DATE"
            .Cols("TRANSDATE").Width = 200
            .Cols("SEASONID").Caption = "SEASON"
            .Cols("SEASONID").Width = 200
            .Cols("CLOSEDBY").Caption = "CLOSED BY"
            .Cols("CLOSEDBY").Width = 200
            .Cols("CLOSEDDATE").Caption = "CLOSING DATE"
            .Cols("CLOSEDDATE").Width = 200

        End With
    End Sub
    Private Sub FRMWORKORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareUser()
        POPULATEWORKORDER()
    End Sub

    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click
        MAINTAB.TabPages.Remove(Dashboard)
        MAINTAB.TabPages.Remove(Overview)
        MAINTAB.TabPages.Remove(Details)
        MAINTAB.TabPages.Add(Dashboard)
    End Sub

    Private Sub BTNWORKORDER_Click(sender As Object, e As EventArgs) Handles BTNWORKORDER.Click
        MAINTAB.TabPages.Remove(Dashboard)
        MAINTAB.TabPages.Remove(Overview)
        MAINTAB.TabPages.Remove(Details)
        MAINTAB.TabPages.Add(Overview)
        MAINTAB.TabPages.Add(Details)

    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click






    End Sub
End Class
