Module PUTCH_FUNCTIONS
    Function putch_Count() As Integer
        Dim sql As String = <s>
                SELECT COUNT(WORKORDERCODE) as COUNT
                FROM R_DAILYFIELDACTIVITYREPORT
                WHERE STATUS='NO WORKORDER' and ISACTIVE ='true'
                            </s>
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item("COUNT").ToString
        End While

        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function FindActivity(ByVal ToFind As String, ByVal ColtoFind As String, ByVal ValToFind As String) As String
        Dim sql As String = <s>
                                 
                                SELECT <%= ToFind %>
                                      FROM [vwFindWorkOrder] WHERE <%= ColtoFind %>='<%= ValToFind %>'
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
End Module
