Imports System.Data.SqlClient
Module VBFUNCTIONS

    Function ValidateExistenceFM(ByVal SFID As Integer, ByVal FM As Integer) As Integer
        Dim sql As String = <s>
        SELECT RECID FROM M_FM_SUBFIELD WHERE 
        FARMMANID = <%= FM %> AND SUBFIELDID = <%= SFID %> AND ISACTIVE = 1 AND COID = '<%= Comp %>'
                            </s>
        Dim EXIST As Integer = 0
        ExeReader(sql)
        While dr.Read
            EXIST = dr.Item("RECID")
        End While
        dr.Close()
        Conn.Close()
        Return EXIST
    End Function

    Function ValidateExistenceFA(ByVal SFID As Integer, ByVal FA As Integer) As Integer
        Dim sql As String = <s>
        SELECT RECID FROM M_FA_SUBFIELD WHERE 
        FARMASSTID = <%= FA %> AND SUBFIELDID = <%= SFID %> AND ISACTIVE = 1 AND COID = '<%= Comp %>'
                            </s>
        Dim EXIST As Integer = 0
        ExeReader(sql)
        While dr.Read
            EXIST = dr.Item("RECID")
        End While
        dr.Close()
        Conn.Close()
        Return EXIST
    End Function
    Function ValidateFM(ByVal FM As String) As Integer
        Dim sql As String = <s>
 select EmployeeId from vwEmployee where Position like '%Farm Manager%' and isActive = 1
        and Employee = '<%= FM %>'
                            </s>
        Dim Id As Integer = 0
        ExeReader(sql)
        While dr.Read
            Id = dr.Item("EmployeeId")
        End While
        dr.Close()
        Conn.Close()

        Return Id
    End Function

    Function ValidateFA(ByVal FA As String) As Integer
        Dim sql As String = <s>
 select EmployeeId from vwEmployee where Position like '%Farm Assistant%' and isActive = 1
        and Employee = '<%= FA %>'
                            </s>
        Dim Id As Integer = 0
        ExeReader(sql)
        While dr.Read
            Id = dr.Item("EmployeeId")
        End While
        dr.Close()
        Conn.Close()

        Return Id
    End Function

    Public Function FindStatusID(StatusDescri As String) As Integer
        Dim TransStatusID As Integer = 0
        Dim query As String = "Exec IMS_FindTransStatusID " & StatusDescri
        ConnecttoDb()
        Conn.Open()
        cmd = New SqlCommand(query, Conn)
        dr = cmd.ExecuteReader()

        While dr.Read
            TransStatusID = dr.Item("TransStatusID")
            Exit While
        End While
        dr.Close()

        Conn.Close()

        Return TransStatusID
    End Function

    Public Function FindMRTransStatus(MRHeaderID As Integer, isDescription As Integer) As String
        Dim TransOutput As String = ""
        Dim query As String = "Exec IMS_MR_FindMRTransStatus " & MRHeaderID
        ConnecttoDb()
        Conn.Open()
        cmd = New SqlCommand(query, Conn)
        dr = cmd.ExecuteReader()

        While dr.Read
            Dim Find As String = ""
            If isDescription = 1 Then
                Find = "TransDescription"
            Else
                Find = "TransStatusID"
            End If
            TransOutput = dr.Item(Find)
            Exit While
        End While
        dr.Close()

        Conn.Close()

        Return TransOutput
    End Function

    Public Function POPULATEAX()
        Dim isFROMAX As Integer = 0
        Dim SQL As String = <s>
        SELECT VALUE FROM M_GENERAL_SETUP WHERE DESCRIPTION = 'ISAX' AND COID = '<%= Comp %>'                        
                            </s>
        ExeReader(SQL)
        While dr.Read
            isFROMAX = Convert.ToInt32(dr.Item("value"))
        End While
        dr.Close()
        Conn.Close()
        Return isFROMAX
    End Function

    Public Function POPULATEIMMIS()
        Dim isFROMIMMIS As Integer = 0
        Dim SQL As String = <s>
        SELECT VALUE FROM M_GENERAL_SETUP WHERE DESCRIPTION = 'ISIMMIS' AND COID = '<%= Comp %>'                        
                            </s>
        ExeReader(SQL)
        While dr.Read
            isFROMIMMIS = Convert.ToInt32(dr.Item("value"))
        End While
        dr.Close()
        Conn.Close()
        Return isFROMIMMIS
    End Function
End Module
