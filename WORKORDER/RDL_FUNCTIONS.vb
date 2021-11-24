Module RDL_FUNCTIONS



    Public Sub drl_FillCombo(ByVal Column As String, Combo As ComboBox, ByVal Table As String, ByVal Others As String)
        Dim sql As String = <s>
        SELECT <%= Column %> FROM <%= Table %> WHERE ISACTIVE = 1                    
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
