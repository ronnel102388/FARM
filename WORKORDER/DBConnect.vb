Imports System.Data.SqlClient
Imports Configuration
Module DBConnect
    Public ConTools As Configuration.FUNCTIONS = New Configuration.FUNCTIONS
    Public IniCon As New IniFile("Progen.ini")
    Public PrimCom As String = IniCon.ReadString("COMPANY", "COMPANYNAME")
    Public SConn As String = "Persist Security Info=True; Password=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "PWD")) & "; User ID=" & FUNCTIONS.DecryptString(IniCon.ReadString(PrimCom, "UserID")) & "; Initial Catalog=" & IniCon.ReadString(PrimCom, "Database") & ";Data Source=" & IniCon.ReadString(PrimCom, "Server") & ""
    Public Conn As New SqlConnection()

    Dim checkstate = IniCon.ReadString("CheckState", "UnderDevelopment")

    Public cmd As New SqlCommand
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public LocalQuery As String

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
        '  MsgBox(SConn)
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
    Public Sub SaveAuditTrail(ByVal UserName As String, ByVal CompName As String,
                              ByVal IpAdd As String,
                              ByVal ConnName As String, ByVal FacCode As String,
                              ByVal TransType As String, ByVal TransRefID As String,
                              ByVal TransRefNum As String,
                              ByVal TransStatus As String, ByVal ActionMade As String)
        Dim InsertStr As String = <s>
            INSERT INTO [A_GLOB_AUDITTRAIL]
          ([COID]
          ,[UserName]
          ,[ComputerName]
          ,[IPAddress]
          ,[ConnName]
          ,[FacilityCode]
          ,[TransType]
          ,[TransRefID]
          ,[TransRefno]
          ,[TransStatus]
          ,[ActionMade]
          ,[DateTimeMade])
     VALUES
           ('<%= Comp %>',
            '<%= UserName %>',
            '<%= CompName %>',
            '<%= IpAdd %>',
            '<%= ConnName %>',
            '<%= FacCode %>',
            '<%= TransType %>',
            '<%= TransRefID %>',
            '<%= TransRefNum %>',
            '<%= TransStatus %>',
            '<%= ActionMade %>',
            getdate())
                      </s>

        ExeQuery(InsertStr)
    End Sub
    Function GenerateSequence(ByVal Category As String) As String
        Dim NewPRID As String
        Dim str = <s>
                      Select NumSeqNext,NumSeqPrefix from M_GLOB_NUMSEQUENCE where IsActive=1 
                      and COID =  '<%= Comp %>' and NumberSequenceCode = '<%= Category %>'
                  </s>

        DTPopulate = ConTools.DataReader(SConn, str)
        If DTPopulate.Rows.Count > 0 Then
            If DTPopulate(0)("NumSeqNext").ToString.Length() = 1 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "0000000" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 2 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "000000" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 3 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "00000" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 4 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "0000" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 5 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "000" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 6 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "00" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 7 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & "0" & DTPopulate(0)("NumSeqNext").ToString()
            ElseIf DTPopulate(0)("NumSeqNext").ToString.Length() = 8 Then
                NewPRID = DTPopulate(0)("NumSeqPrefix") & DTPopulate(0)("NumSeqNext").ToString()
            End If
        Else
            NewPRID = "NotGenerated"
        End If

        Return NewPRID
    End Function
    Public Sub SaveNewSeries(ByVal Category As String)
        Dim UpdateStr As String
        UpdateStr = "Update M_GLOB_NUMSEQUENCE set NumSeqNext += 1 where " &
            "COID = '" & Comp & "' and NumberSequenceCode = '" & Category & "'"

        ExeQuery(UpdateStr)

    End Sub
    Function FindID(ByVal ToFind As String, ByVal Table As String, ByVal ColtoFind As String, ByVal ValToFind As String) As Integer
        Dim sql As String = <s>
                                SELECT <%= ToFind %> FROM <%= Table %> WHERE <%= ColtoFind %> = '<%= ValToFind %>' --AND ISACTIVE = 1
                            </s>
        ' MsgBox(sql)
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item(ToFind)
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function CountExist(ByVal Number As String, ByVal Table As String, ByVal ToFind As String, ByVal isUpdate As Boolean, ByVal CurID As Integer) As Integer
        Dim Sql As String = <s>
            SELECT COUNT(RECID) as Counter FROM <%= Table %>
            WHERE <%= ToFind %> = '<%= Number %>' AND COID = '<%= Comp %>'          
                  </s>

        If isUpdate = True Then
            Sql += " AND RECID <> " & CurID & " "
        End If

        ExeReader(Sql)
        Dim Count As Integer = 0
        While dr.Read
            Count = dr.Item("Counter")
        End While
        dr.Close()
        Conn.Close()

        Return Count
    End Function
    Public Sub FillCombo(ByVal Column As String, Combo As ComboBox, ByVal Table As String, ByVal Others As String)
        Dim sql As String = <s>
        SELECT <%= Column %> FROM <%= Table %> WHERE ISACTIVE = 1 AND COID = '<%= Comp %>'                        
                            </s>
        If Others <> "" Then
            sql = sql + " and " + Others
        End If
        ExeReader(sql)
        Combo.Items.Clear()
        While dr.Read
            Combo.Items.Add(dr.Item(Column))
        End While
        dr.Close()
        Conn.Close()
    End Sub
    Function ValidateSeries(ByVal Series As String)
        Dim sql As String = <s>
        select NumberSequenceCode from M_GLOB_NUMSEQUENCE where NumberSequenceCode = '<%= Series %>'
        and COID = '<%= Comp %>' and ISACTIVE = 1                       
                            </s>
        ExeReader(sql)
        Dim Code As String = ""
        While dr.Read
            Code = dr.Item("NumberSequenceCode")
        End While
        dr.Close()
        Conn.Close()

        Return Code
    End Function
    Function GetSetupValue(ByVal Descri As String) As String
        Dim sql As String = <s>
        SELECT VALUE FROM M_GENERAL_SETUP WHERE DESCRIPTION = '<%= Descri %>' AND COID = '<%= Comp %>'
                            </s>
        ExeReader(sql)
        Dim strValue As String = ""

        While dr.Read
            strValue = dr.Item("VALUE").ToString
        End While

        dr.Close()
        Conn.Close()

        Return strValue
    End Function

    '--putch
    Function FindActivity(ByVal ToFind As String, ByVal ColtoFind As String, ByVal ValToFind As String) As String
        Dim sql As String = <s>
                                 
                                SELECT <%= ToFind %>
                                      FROM [vwAAA] WHERE <%= ColtoFind %>='<%= ValToFind %>'
                            </s>
        'MsgBox(sql)
        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item(ToFind)
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function FindID(ByVal Number As String, ByVal Table As String, ByVal ToFind As String) As Integer
        Dim Sql As String = <s>
        SELECT RECID FROM <%= Table %> WHERE <%= ToFind %> = '<%= Number %>' AND COID = '<%= Comp %>'                        
                            </s>

        ExeReader(Sql)
        Dim ReciD As Integer = 0
        While dr.Read
            ReciD = dr.Item("RECID")
        End While
        dr.Close()
        Conn.Close()

        Return ReciD
    End Function
    '--putch
End Module

