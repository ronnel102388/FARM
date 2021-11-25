Module DRL_FUNCTIONS


    Function drl_FINDDefault() As Integer
        Dim sql As String = <s>
                                 SELECT RECID FROM  M_FARM_POT_VERSION WHERE ISACTIVE =  1 AND ISDEFAULT = 1 AND ISPOSTED = 1 
                             </s>
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item("RECID")
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function

    Function drl_FINDDescription(ByVal Column As String, ByVal Table As String, ByVal Others As String) As String
        Dim sql As String = <s>
                                SELECT
                                <%= Column %>           
                                FROM 
                                <%= Table %>
                                WHERE ISACTIVE = 1
                            </s>
        If Others <> "" Then
            sql = sql + " AND " + Others
        End If
        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item(Column)
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function drl_FindID(ByVal ColFindID As String, ByVal Table As String, ByVal Others As String) As Integer
        Dim sql As String = <s>
                                SELECT DISTINCT <%= ColFindID %> FROM <%= Table %> 
                                WHERE ISACTIVE = 1 
                            </s>
        If Others <> "" Then
            sql = sql + " AND " + Others
        End If
        Dim Find As Integer = 0

        ExeReader(sql)

        While dr.Read
            Find = Val(dr.Item(ColFindID))
        End While

        dr.Close()
        Conn.Close()

        Return Find
    End Function

    Public Sub drl_FillCombo(ByVal Column As String, Combo As ComboBox, ByVal Table As String, ByVal Others As String)
        Dim sql As String = <s>
        SELECT DISTINCT <%= Column %> FROM <%= Table %> WHERE ISACTIVE = 1                    
                            </s>
        If Others <> "" Then
            sql = sql + " AND " + Others
        End If
        ExeReader(sql)
        Combo.Items.Clear()
        While dr.Read
            Combo.Items.Add(dr.Item(Column))
        End While
        dr.Close()
        Conn.Close()
    End Sub
End Module
