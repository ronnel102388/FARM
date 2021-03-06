Imports System.Data.SqlClient
Imports Configuration
Module DBConnect
    Public ConTools As Configuration.FUNCTIONS = New Configuration.FUNCTIONS
    Public IniCon As New IniFile("Progen.ini")
    Public PrimCom As String = IniCon.ReadString("COMPANY", "COMPANYNAME")
    Public SConn As String = "Persist Security Info=True; Password=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "PWD")) & "; User ID=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "UserID")) & "; Initial Catalog=" & IniCon.ReadString(PrimCom, "Database") & ";Data Source=" & IniCon.ReadString(PrimCom, "Server") & ""
    Public Conn As New SqlConnection()
    Public checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")
    Public cmd As New SqlCommand
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public LocalQuery As String
    Public isaprub, isredyek, isaktibdfar, isklos, isaktibwo, iskansel, isklosmeynwo, isaktibrcvd As String 'Wag na to
    Public Comp, Username, CompName, MyDept As String
    Public EmpID As Integer
    Public DTPopulate As DataTable
    Function QueryCompanyCode(ByVal UserNeym As String) As String
        Dim CompanCode As String = ""
        Dim str = <s>
                    select CompanyCode from a_LoginLogs Where UserName='<%= UserNeym %>' 
                  </s>
        ExeReader(str)
        While dr.Read
            CompanCode = dr.Item("CompanyCode")
        End While
        dr.Close()
        Conn.Close()
        Return CompanCode
    End Function
    Public Sub ConnecttoDb()

        Conn = New SqlConnection(SConn)
        Try
            Conn.Open()
            'MsgBox("Connected")
            Conn.Close()
        Catch ex As Exception
            MsgBox("Not Connected: " & ex.Message, vbCritical)
        End Try
    End Sub
    Public Sub SelectQuery(ByVal query As String)
        ConnecttoDb()
        Conn.Open()
        da = New SqlDataAdapter(query, Conn)
        ds = New DataSet
        da.Fill(ds, "table")
        Conn.Close()
    End Sub
    Public Sub ExeQuery(ByVal query As String)
        ConnecttoDb()
        Conn.Open()
        cmd = New SqlCommand(query, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Public Sub ExeReader(ByVal query As String)
        ConnecttoDb()
        Conn.Open()
        cmd = New SqlCommand(query, Conn)
        dr = cmd.ExecuteReader()
    End Sub


End Module
