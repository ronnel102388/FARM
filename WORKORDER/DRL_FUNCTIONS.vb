﻿Module DRL_FUNCTIONS


    Function drl_GenerateCodeMAINWO() As String
        Dim sql As String = <s>
                                    declare @code as varchar(100) = (
                                    select 
                                    'MWO' + replace(CONVERT(varchar,convert(date,GETDATE())),'-','') 
                                    + '-' + Replace(Str(isnull(COUNT(MainWOID),0) + 1,
                                    case when LEN(isnull(COUNT(MainWOID),0)) > 5 then len(isnull(COUNT(MainWOID),0)) else 5 end 
                                    ,0),' ','0') Code 
                                    from t_FarmActivityMainWorkOrder 
                                    )

                                    select @code as MAINWOCODE
                            </s>
        ExeReader(sql)
        Dim Code As String = ""
        While dr.Read
            Code = dr.Item("MAINWOCODE")
        End While
        dr.Close()
        Conn.Close()

        Return Code
    End Function

    Function drl_GenerateCodeWORKORDER() As String
        Dim sql As String = <s>
                                    declare @code as varchar(100) = (
                                    select 
                                    'WO' + replace(CONVERT(varchar,convert(date,GETDATE())),'-','') 
                                    + '-' + Replace(Str(isnull(COUNT(WorkOrderId),0) + 1,
                                    case when LEN(isnull(COUNT(WorkOrderId),0)) > 5 then len(isnull(COUNT(WorkOrderId),0)) else 5 end 
                                    ,0),' ','0') Code 
                                    from t_FarmActivityWorkOrder 
                                    )
                                
                                    select @code as WOCODE
                            </s>
        ExeReader(sql)
        Dim Code As String = ""
        While dr.Read
            Code = dr.Item("WOCODE")
        End While
        dr.Close()
        Conn.Close()

        Return Code
    End Function

    Function drl_GenerateCodeWORESOURCE() As String
        Dim sql As String = <s>
                                        declare @code as varchar(100) = (
                                        select 
                                        'WOR' + replace(CONVERT(varchar,convert(date,GETDATE())),'-','') 
                                        + '-' + Replace(Str(isnull(COUNT(WorkOrderResourceId),0) + 1,
                                        case when LEN(isnull(COUNT(WorkOrderResourceId),0)) > 5 then len(isnull(COUNT(WorkOrderResourceId),0)) else 5 end 
                                        ,0),' ','0') Code 
                                        from t_FarmActivityWorkOrderResources 
                                        )
                                
                                        select @code AS WORESCODE
                            </s>
        ExeReader(sql)
        Dim Code As String = ""
        While dr.Read
            Code = dr.Item("WORESCODE")
        End While
        dr.Close()
        Conn.Close()

        Return Code
    End Function
    Function drl_GetLastDayOfWeek(ByVal dt As Date) As Date
        Dim dayOfWeek = dt.DayOfWeek

        If dayOfWeek <> 0 Then
            dt = dt.AddDays(7 - dayOfWeek)
        End If

        Return dt
    End Function

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
