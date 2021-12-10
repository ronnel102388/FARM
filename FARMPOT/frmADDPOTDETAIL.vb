Imports C1.Win.C1FlexGrid
Public Class frmADDPOTDETAIL
    Dim RECID, MAJAID, MINAID, METHAID, RESID, RESTYPEID, UOMID, POTORDER As Integer
    Public VERID As Integer
    Public EFFECTIVITYDATE As Date
    Public VER, CCCODE As String
#Region "ROUTINE"

    Function GENERATECODE(ByVal ver As String, ByVal ccCode As String, ByVal verid As Integer) As String
        Dim sql As String = <s>
                                DECLARE @CODE AS NVARCHAR(50) = (SELECT '<%= ver %>'+'<%= ccCode %>' + REPLACE(STR(ISNULL(COUNT(RECID),0) + 1,
                                CASE WHEN LEN(ISNULL(COUNT(RECID),0)) > 5 THEN LEN(ISNULL(COUNT(RECID),0)) ELSE 5 END 
                                ,0),' ','0') Code 
                                FROM M_FARM_POT_VERSION_DETAIL
                                WHERE VERSIONID = <%= verid %>
                                )
                               
                               SELECT @CODE AS CODE

                            </s>
        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item("CODE").ToString
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Sub ControlEvents(bool As Boolean)
        tsNew.Enabled = bool
        tsEdit.Enabled = bool
        tsSave.Enabled = Not bool
        tsCancel.Enabled = Not bool
        tsDelete.Enabled = bool
        xpanelentry.Enabled = Not bool
    End Sub
    Sub Clear()
        RECID = 0
        MAJAID = 0
        MINAID = 0
        METHAID = 0
        RESID = 0
        RESTYPEID = 0
        UOMID = 0
        CCCODE = ""
        POTORDER = 0

        xRECID.Text = ""
        xDETAILCODE.Text = "System Generated"

        xCC.Text = ""
        xCC.SelectedIndex = -1
        xMAJA.Text = ""
        xMAJA.SelectedIndex = -1
        xMINA.Text = ""
        xMINA.SelectedIndex = -1
        xMETHA.Text = ""
        xMETHA.SelectedIndex = -1
        xCALCATEGORY.Text = ""
        xCALCATEGORY.SelectedIndex = -1
        xchkISESSENTIAL.Checked = False

        xRESOURCES.Text = ""
        xRESOURCETYPE.Text = ""
        xQTY.Value = 0
        xUOM.Text = ""
        xUOM.SelectedIndex = -1
        xPORORDER.Text = "0"
        xchkISMAINMETHOD.Checked = False
        xchkISALTERNATIVE.Checked = False

        xECMANUAL.Value = 0
        xERMANUAL.Value = 0
        xNRMANUAL.Value = 0
        xNCMANUAL.Value = 0
        xNRMECHANICAL.Value = 0
        xNCMECHANICAL.Value = 0

        xAXPUR.Text = ""
        xAXCOST.Text = ""
    End Sub
    Sub ResClear()
        xRESOURCES.Text = ""
        xRESOURCETYPE.Text = ""
        xQTY.Value = 0
        xUOM.Text = ""
        xUOM.SelectedIndex = -1
        xPORORDER.Text = "0"
        xchkISMAINMETHOD.Checked = False
        xchkISALTERNATIVE.Checked = False

        xECMANUAL.Value = 0
        xERMANUAL.Value = 0
        xNRMANUAL.Value = 0
        xNCMANUAL.Value = 0
        xNRMECHANICAL.Value = 0
        xNCMECHANICAL.Value = 0

        xAXPUR.Text = ""
        xAXCOST.Text = ""
    End Sub
#End Region
#Region "POPULATE"
    Sub PopulateCC()
        Dim sql As String = <s>
                                SELECT CROPCLASS FROM M_FARMCROPCLASS WHERE ISACTIVE =  1
                            </s>
        ExeReader(sql)
        xCC.Items.Clear()
        xcboFilter.Items.Clear()
        While dr.Read
            xCC.Items.Add(dr.Item("CROPCLASS"))
            xcboFilter.Items.Add(dr.Item("CROPCLASS"))
        End While
        dr.Close()
        Conn.Close()
    End Sub
    Sub PopulateMAJA()
        Dim sql As String = <s>
                                SELECT MAJORACTIVITY FROM M_FARMMAJORACTIVITY WHERE ISACTIVE = 1
                            </s>
        ExeReader(sql)
        xMAJA.Items.Clear()
        While dr.Read
            xMAJA.Items.Add(dr.Item("MAJORACTIVITY").ToString)
        End While
        dr.Close()
        Conn.Close()
    End Sub
    Sub PopulateMINA(ByVal majaID As Integer)
        Dim sql As String = <s>
                                SELECT MINORACTIVITY FROM M_FARMMINORACTIVITY WHERE ISACTIVE = 1 AND MAJORACTIVITYID = <%= majaID %>
                            </s>
        ExeReader(sql)
        xMINA.Items.Clear()
        While dr.Read
            xMINA.Items.Add(dr.Item("MINORACTIVITY").ToString)
        End While
        dr.Close()
        Conn.Close()
    End Sub
    Sub PopulateMETHA(ByVal minaID As Integer)
        Dim sql As String = <s>
                                SELECT METHODOFACTIVITY FROM M_FARMMETHODOFACTIVITY WHERE ISACTIVE = 1 AND MINORACTIVITYID = <%= minaID %>
                            </s>
        ExeReader(sql)
        xMETHA.Items.Clear()
        While dr.Read
            xMETHA.Items.Add(dr.Item("METHODOFACTIVITY").ToString)
        End While
        dr.Close()
        Conn.Close()
    End Sub

    Sub PopulateUOM()
        Dim sql As String = <s>
                                SELECT UOM FROM M_FARMUNITOFMEASURE WHERE ISACTIVE = 1 AND METRICCATEGORYID  =  10
                            </s>
        ExeReader(sql)
        xUOM.Items.Clear()
        While dr.Read
            xUOM.Items.Add(dr.Item("UOM"))
        End While
        dr.Close()
        Conn.Close()

    End Sub
    Sub PopulateRESOURCES()
        Dim sql As String = <s>
                                SELECT RESOURCE FROM M_FARMRESOURCE WHERE ISACTIVE = 1
                            </s>
        ExeReader(sql)
        xRESOURCES.Items.Clear()
        While dr.Read
            xRESOURCES.Items.Add(dr.Item("RESOURCE"))
        End While
        dr.Close()
        Conn.Close()
    End Sub
    Sub PopulatePOT()
        Dim SEARCH As String = xsearch.Text.Replace("'", "")

        Dim sql As String = <s>
                               SELECT [RECID]
                                      ,[VERSIONID]
                                  
                                      ,[CROPCLASS]
                                
                                      ,[EFFECTIVITYDATE]
                                      ,[MAJORACTIVITYID]
                                      ,[MAJORACTIVITY]
                                      ,[MINORACTIVITYID]
                                      ,[MINORACTIVITY]

                                      ,[DETAILCODE]
        
                                      ,[POT_ORDER]
                                      ,[METHODOFACTIVITYID]
                                      ,[METHODOFACTIVITY]
                                      ,[CALCULATIONCATEGORY]
                                      ,[RESOURCETYPEID]
                                      ,[RESOURCETYPE]
                                      ,[RESOURCEID]
                                      ,[RESOURCE]
                                      ,[STANDARDQTY]
                                      ,[UOMID]
                                      ,[UOM]
                                      ,[ISMAINMETHOD]
                                      ,[ISALTERNATIVE]
                                      ,[ISESSENTIAL]
                                      ,[TYPE]
                                      ,[EXISTINGRATEMANUAL]
                                      ,[EXISTINGCOSTMANUAL]
                                      ,[NEWRATEMANUAL]
                                      ,[NEWCOSTMANUAL]
                                      ,[NEWRATEMECHANICAL]
                                      ,[NEWCOSTMECHANICAL]
                                      ,[AXCOSTCENTER]
                                      ,[AXPURPOSE]
                                      ,[ISACTIVE]
                                      ,[COID]
                                      ,[CREATEDBY]
                                      ,[CREATIONDATE]
                                      ,[MODIFIEDBY]
                                      ,[MODIFICATIONDATE]
                              FROM [M_FARM_POT_VERSION_DETAIL]
                              WHERE ISACTIVE = 1 --AND COID = '<%= frmPOT.RbnStatus.Text %>'
                             AND (MAJORACTIVITY LIKE '%<%= SEARCH %>%'
                                OR MINORACTIVITY LIKE '%<%= SEARCH %>%'
                                OR METHODOFACTIVITY LIKE '%<%= SEARCH %>%'
                                OR RESOURCE LIKE '%<%= SEARCH %>%' )
                             AND CROPCLASS = '<%= xcboFilter.Text %>'
                             AND VERSIONID = <%= VERID %>
                             ORDER BY CROPCLASS,POT_ORDER ASC
                            </s>
        SelectQuery(sql)
        With dgPOTD
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .AllowEditing = False
            .Cols.Fixed = 0
            .AutoSizeCols()
            .Cols("EXISTINGRATEMANUAL").Format = "n0"
            .Cols("EXISTINGCOSTMANUAL").Format = "n0"
            .Cols("NEWRATEMANUAL").Format = "n0"
            .Cols("NEWCOSTMANUAL").Format = "n0"
            .Cols("NEWRATEMECHANICAL").Format = "n0"
            .Cols("NEWCOSTMECHANICAL").Format = "n0"

            For i As Integer = 0 To .Cols.Count - 1
                If .Cols(i).Caption.Contains("ID") Then
                    .Cols(i).Visible = False
                Else
                    .Cols(i).Visible = True
                End If
            Next
            '.Cols("EFFECTIVITYDATE").Visible = False
            '.Cols("RECID").Visible = True
        End With

        setgrid()
    End Sub
    Sub setgrid()
        With dgPOTD
            .Tree.Style = TreeStyleFlags.Complete
            .Cols(0).Visible = False
            .Cols(1).Visible = False
            .Cols(2).Visible = False
            .Cols(3).Visible = False
            .Cols(4).Visible = False
            .Cols(5).Visible = False
            .Cols(6).Visible = False
            .Cols(7).Visible = False
            .Tree.Column = 8

            .Subtotal(AggregateEnum.None, 0, .Cols("CROPCLASS").Index, .Cols("CROPCLASS").Index, "{0}")
            .Subtotal(AggregateEnum.None, 1, .Cols("MAJORACTIVITY").Index, .Cols("MAJORACTIVITY").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, 1, .Cols("MAJORACTIVITY").Index, .Cols("NEWRATEMANUAL").Index, "{0}")
            .Subtotal(AggregateEnum.Sum, 1, .Cols("MAJORACTIVITY").Index, .Cols("NEWCOSTMANUAL").Index, "{0}")
            .Subtotal(AggregateEnum.None, 2, .Cols("MINORACTIVITY").Index, .Cols("MINORACTIVITY").Index, "{0}")


            '.Subtotal(AggregateEnum.None, -1, -1, -1, "TOTAL")
            .AutoSizeCols()
        End With
    End Sub
#End Region
#Region "FUNCTION"
    Function FindID(ByVal ColFindID As String, ByVal Table As String, ByVal ColToFind As String, ByVal ValToFind As String, ByVal AddColToFind As String, ByVal AddValToFind As String) As Integer
        Dim sql As String = <s>
                                SELECT <%= ColFindID %> FROM <%= Table %> 
                                WHERE ISACTIVE = 1 AND <%= ColToFind %> = '<%= ValToFind %>'
                            </s>
        If AddColToFind <> "" Then
            sql = sql & " AND " & AddColToFind & " = " & AddValToFind
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
    Function FindIfMainMethod(ByVal minaID As Integer, ByVal methodID As Integer) As Boolean
        Dim sql As String = <S>
                                SELECT ISMAINMETHOD FROM M_FARMMETHODOFACTIVITY WHERE ISACTIVE = 1 AND MINORACTIVITYID = <%= minaID %> and METHODOFACTIVITYID = <%= methodID %>
                            </S>

        ExeReader(sql)
        Dim Find As Boolean = False
        While dr.Read
            Find = dr.Item("ISMAINMETHOD")
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function FindIfExist(ByVal ColFindCount As String, ByVal Table As String, ByVal ColToFind As String, ByVal ValToFind As String, ByVal ADDCON As String, ByVal AddValID As Integer) As Integer
        Dim sql As String = <s>
                                SELECT COUNT(<%= ColFindCount %>) AS COUNTID FROM <%= Table %>
                                WHERE <%= ColToFind %> = '<%= ValToFind %>' AND ISACTIVE =  1
                            </s>
        If ADDCON = "MINA" Then
            sql = sql + " AND MAJORACTIVITYID =" & AddValID
        ElseIf ADDCON = "METHA" Then
            sql = sql + " AND MINORACTIVITYID =" & AddValID
        End If
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item("COUNTID").ToString
        End While
        dr.Close()
        Conn.Close()

        Return Find

    End Function
    Function FindResType(ByVal val As String, ByVal res As String, ByVal var As String) As String
        Dim sql As String = <s>
                                    SELECT <%= var %>.<%= val %> FROM M_FARMRESOURCE A
                                    INNER JOIN M_FARMRESOURCETYPE B ON B.RESOURCETYPEID = A.RESOURCETYPEID
                                    WHERE RESOURCE = '<%= res %>' AND A.ISACTIVE =  1 AND B.ISACTIVE = 1
                            </s>

        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item(val)
        End While
        dr.Close()
        Conn.Close()

        Return Find

    End Function
    Function FindUOM(ByVal val As String, ByVal uom As String) As String
        Dim sql As String = <s>
                                SELECT <%= val %> FROM m_FarmUnitOfMeasure WHERE METRICCATEGORYID = 10 AND UOM ='<%= uom %>' AND ISACTIVE =  1
                            </s>
        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item(val)
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
    Function FindCCCode(ByVal cc As String) As String
        Dim sql As String = <s>
                                SELECT CROPCLASSCODE FROM M_FARMCROPCLASS WHERE CROPCLASS = '<%= cc %>' AND ISACTIVE = 1
                            </s>
        ExeReader(sql)
        Dim Find As String = ""
        While dr.Read
            Find = dr.Item("CROPCLASSCODE").ToString
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function


    Function FindLastOrder(ByVal versionid As String) As Integer
        Dim sql As String = <s>
                                SELECT TOP 1 POT_ORDER + 1 as COUNT FROM M_FARM_POT_VERSION_DETAIL WHERE VERSIONID = <%= versionid %> ORDER BY POT_ORDER DESC
                            </s>
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item("COUNT")
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function
#End Region
    Private Sub frmADDPOTDETAIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCC()
        xcboFilter.SelectedIndex = 0
        PopulatePOT()

        PopulateMAJA()
        PopulateUOM()
        PopulateRESOURCES()
        ControlEvents(True)
        Clear()
    End Sub
#Region "FORM CONTROLS"

#End Region
    Private Sub xMAJA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xMAJA.SelectedIndexChanged
        If xMAJA.SelectedIndex = -1 Or xMAJA.Text = "" Then
            PopulateMINA(0)
            PopulateMETHA(0)
            xMINA.Text = ""
            xMETHA.Text = ""
        Else
            MAJAID = FindID("MAJORACTIVITYID", "M_FARMMAJORACTIVITY", "MAJORACTIVITY", xMAJA.Text, "", "")
            PopulateMINA(MAJAID)
            PopulateMETHA(0)
            xMINA.Text = ""
            xMETHA.Text = ""
        End If
    End Sub
    Private Sub xMINA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xMINA.SelectedIndexChanged
        If xMINA.SelectedIndex = -1 Or xMINA.Text = "" Then
            PopulateMETHA(0)
            xMETHA.Text = ""
        Else
            MINAID = FindID("MINORACTIVITYID", "M_FARMMINORACTIVITY", "MINORACTIVITY", xMINA.Text, "MAJORACTIVITYID", MAJAID)
            PopulateMETHA(MINAID)
            xMETHA.Text = ""
        End If

    End Sub
    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        ControlEvents(False)
        TabControl1.SelectedTab = TabPage2()
        Clear()
        xPORORDER.Text = FindLastOrder(VERID)
    End Sub
    Private Sub xPORORDER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPORORDER.KeyPress
        ConTools.NumericKeyPressEvent(sender, e)
    End Sub


    Private Sub XRESOURCES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xRESOURCES.SelectedIndexChanged
        xRESOURCETYPE.Text = FindResType("RESOURCETYPE", xRESOURCES.Text, "B")
        RESTYPEID = Val(FindResType("RESOURCETYPEID", xRESOURCES.Text, "A"))
        RESID = Val(FindResType("RESOURCEID", xRESOURCES.Text, "A"))
    End Sub

    Private Sub XNRMANUAL_ValueChanged(sender As Object, e As EventArgs) Handles xNRMANUAL.ValueChanged
        xNCMANUAL.Value = (xQTY.Value * xNRMANUAL.Value)
    End Sub
    Private Sub XNRMECHANICAL_ValueChanged(sender As Object, e As EventArgs) Handles xNRMECHANICAL.ValueChanged
        xNCMECHANICAL.Value = (xQTY.Value * xNRMECHANICAL.Value)
    End Sub

    Private Sub XERMANUAL_ValueChanged(sender As Object, e As EventArgs) Handles xERMANUAL.ValueChanged
        xECMANUAL.Value = (xQTY.Value * xERMANUAL.Value)
    End Sub

    Private Sub TsSearch_Click(sender As Object, e As EventArgs) Handles tsSearch.Click
        PopulatePOT()
    End Sub

    Private Sub XcboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xcboFilter.SelectedIndexChanged
        PopulatePOT()
    End Sub

    Private Sub XchkISMAINMETHOD_CheckedChanged(sender As Object, e As EventArgs) Handles xchkISMAINMETHOD.CheckedChanged
        If FindIfMainMethod(MINAID, METHAID) <> xchkISMAINMETHOD.Checked Then
            xchkISMAINMETHOD.Checked = FindIfMainMethod(MINAID, METHAID)
        End If
    End Sub

    Private Sub XMETHA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xMETHA.SelectedIndexChanged
        If xMETHA.SelectedIndex = -1 Or xMETHA.Text = "" Then
            METHAID = 0
            FindIfMainMethod(0, 0)
        Else
            METHAID = FindID("METHODOFACTIVITYID", "M_FARMMETHODOFACTIVITY", "METHODOFACTIVITY", xMETHA.Text, "MINORACTIVITYID", MINAID)
            xchkISMAINMETHOD.Checked = FindIfMainMethod(MINAID, METHAID)
        End If
    End Sub

    Private Sub XCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xCC.SelectedIndexChanged
        If xCC.Text <> "" Then
            CCCODE = FindCCCode(xCC.Text)
        End If
    End Sub
    Private Sub XUOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xUOM.SelectedIndexChanged
        If xUOM.Text <> "" Then
            UOMID = FindUOM("UOMID", xUOM.Text)
        End If
    End Sub
    Private Sub TsCancel_Click(sender As Object, e As EventArgs) Handles tsCancel.Click
        ControlEvents(True)
        Clear()
        TabControl1.SelectedTab = TabPage1()
    End Sub
    Private Sub TsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        If dgPOTD.Rows.Count > 1 Then
            Exit Sub
        End If

        If tsSave.Enabled = False Then
            Exit Sub
        End If

        Dim x As Integer = dgPOTD.RowSel

        If x = 0 Then
            MsgBox("Please select record first.", MsgBoxStyle.Exclamation, "VALIDATION")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to deactivate this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim sql As String = ""

        sql = <s>
              </s>

        ExeQuery(sql)
        MsgBox("Transaction successfully deactivated.", MsgBoxStyle.Information, "VALIDATION")
        PopulatePOT()
        Clear()
        ControlEvents(True)
    End Sub
    Private Sub TsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        If dgPOTD.Rows.Count = 1 Then
            Exit Sub
        End If

        If tsSave.Enabled = True Then
            Exit Sub
        End If

        Dim x As Integer = dgPOTD.RowSel

        If dgPOTD.Item(x, "RECID") = 0 Then
            MsgBox("Please Select Record First", MsgBoxStyle.Exclamation, "VALIDATION")
            Exit Sub
        End If

        With dgPOTD
            RECID = .Item(x, "RECID").ToString
            xRECID.Text = .Item(x, "RECID").ToString
            xDETAILCODE.Text = .Item(x, "DETAILCODE").ToString
            xCC.Text = .Item(x, "CROPCLASS").ToString
            MAJAID = .Item(x, "MAJORACTIVITYID").ToString
            xMAJA.Text = .Item(x, "MAJORACTIVITY").ToString
            MINAID = .Item(x, "MINORACTIVITYID").ToString
            xMINA.Text = .Item(x, "MINORACTIVITY").ToString
            METHAID = .Item(x, "METHODOFACTIVITYID").ToString
            xMETHA.Text = .Item(x, "METHODOFACTIVITY").ToString
            xCALCATEGORY.Text = .Item(x, "CALCULATIONCATEGORY").ToString
            xchkISESSENTIAL.Checked = .Item(x, "ISESSENTIAL").ToString
            RESID = .Item(x, "RESOURCEID").ToString
            xRESOURCES.Text = .Item(x, "RESOURCE").ToString
            RESTYPEID = .Item(x, "RESOURCETYPEID").ToString
            xRESOURCETYPE.Text = .Item(x, "RESOURCETYPE").ToString
            xQTY.Value = .Item(x, "STANDARDQTY").ToString
            UOMID = .Item(x, "UOMID").ToString
            xUOM.Text = .Item(x, "UOM").ToString
            xPORORDER.Text = .Item(x, "POT_ORDER").ToString
            POTORDER = .Item(x, "POT_ORDER").ToString
            xchkISMAINMETHOD.Checked = .Item(x, "ISMAINMETHOD").ToString
            xchkISALTERNATIVE.Checked = .Item(x, "ISALTERNATIVE").ToString
            xECMANUAL.Value = .Item(x, "EXISTINGCOSTMANUAL").ToString
            xERMANUAL.Value = .Item(x, "EXISTINGRATEMANUAL").ToString
            xNRMANUAL.Text = .Item(x, "NEWRATEMANUAL").ToString
            xNCMANUAL.Text = .Item(x, "NEWCOSTMANUAL").ToString
            xNRMECHANICAL.Text = .Item(x, "NEWRATEMECHANICAL").ToString
            xNCMECHANICAL.Text = .Item(x, "NEWCOSTMECHANICAL").ToString
            xAXPUR.Text = .Item(x, "AXPURPOSE").ToString
            xAXCOST.Text = .Item(x, "AXCOSTCENTER").ToString

        End With

        ControlEvents(False)
        TabControl1.SelectedTab = TabPage2()
    End Sub
    Private Sub TsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If xCC.Text.Replace(" ", "") = "" Then
            MsgBox("Please input Crop Class.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If FindIfExist("MAJORACTIVITYID", "M_FARMMAJORACTIVITY", "MAJORACTIVITY", xMAJA.Text, "", 0) = 0 Then
            MsgBox("Major Activity is not exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If xMAJA.Text.Replace(" ", "") = "" Then
            MsgBox("Please input Major Activity.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If FindIfExist("MINORACTIVITYID", "M_FARMMINORACTIVITY", "MINORACTIVITY", xMINA.Text, "MINA", MAJAID) = 0 Then
            MsgBox("Minor Activity is not exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If xMINA.Text.Replace(" ", "") = "" Then
            MsgBox("Please input Minor Activity.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If FindIfExist("METHODOFACTIVITYID", "M_FARMMETHODOFACTIVITY", "METHODOFACTIVITY", xMETHA.Text, "METHA", MINAID) = 0 Then
            MsgBox("Method of Activity is not exist.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If xMETHA.Text.Replace(" ", "") = "" Then
            MsgBox("Please input Method of Activity.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If xCALCATEGORY.Text.Replace(" ", "") = "" Then
            MsgBox("Please input Type.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If xPORORDER.Text.Replace(" ", "") = "" Or Val(xPORORDER.Text) = 0 Then
            MsgBox("Please input POT Order.", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to save this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "VALIDATION") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim x As String = <s>
                              SELECT * FROM M_FARM_POT_VERSION_DETAIL
                              WHERE POT_ORDER >= <%= Val(xPORORDER.Text) %> AND CROPCLASS = '<%= xCC.Text %>'
                          </s>
        Dim dtx As DataTable = ConTools.DataReader(SConn, x)


        If dtx.Rows.Count > 0 Then
            For z As Integer = 0 To dtx.Rows.Count - 1
                Dim sqlx As String = <s>
                                         UPDATE M_FARM_POT_VERSION_DETAIL SET
                                         POT_ORDER  = POt_ORDER + <%= Val(xPORORDER.Text) - POTORDER %>
                                         WHERE RECID  = <%= dtx(z)("RECID") %> AND CROPCLASS = '<%= xCC.Text %>'
                                     </s>
                ExeQuery(sqlx)
            Next
        End If


        If xRECID.Text = "" Or Val(xRECID.Text) = 0 Then
            xDETAILCODE.Text = GENERATECODE(VER, CCCODE, VERID)
        End If

        Dim sql As String = ""
        sql = <s>
                                      EXEC POT_ACTION <%= Val(xRECID.Text) %> 
                                                ,'<%= VERID %>'
                                                ,'<%= EFFECTIVITYDATE %>'
                                                ,<%= MAJAID %>
                                                ,'<%= xMAJA.Text %>'
                                                ,<%= MINAID %>
                                                ,'<%= xMINA.Text %>'
                                                ,<%= METHAID %>
                                                ,'<%= xMETHA.Text %>'
                                                ,'<%= xDETAILCODE.Text %>'
                                                ,'<%= xCC.Text %>'
                                                ,<%= xPORORDER.Text %>
                                                ,<%= Convert.ToInt32(xchkISESSENTIAL.Checked) %>
                                                ,<%= IIf(xchkISESSENTIAL.Checked = True, "ESSENTIAL", "OPTIONAL") %>
                                                ,<%= Convert.ToInt32(xchkISMAINMETHOD.Checked) %>
                                                ,<%= Convert.ToInt32(xchkISALTERNATIVE.Checked) %>
                                                ,'<%= xERMANUAL.Value %>'
                                                ,'<%= xECMANUAL.Value %>'
                                                ,'<%= xNRMANUAL.Value %>'
                                                ,'<%= xNCMANUAL.Value %>'
                                                ,'<%= xNRMECHANICAL.Value %>'
                                                ,'<%= xNCMECHANICAL.Value %>'
                                                ,<%= RESTYPEID %>
                                                ,'<%= xRESOURCETYPE.Text %>'
                                                 ,<%= RESID %>
                                                ,'<%= xRESOURCES.Text %>'
                                                ,<%= UOMID %>
                                                ,'<%= xUOM.Text %>'
                                                ,'<%= xAXCOST.Text %>'
                                                ,'<%= xAXPUR.Text %>'
                                                ,'<%= xQTY.Value %>'
                                                ,'<%= xCALCATEGORY.Text %>'
                                                ,'<%= frmPOT.RbnStatus.Text %>'
                                                ,'<%= frmPOT.RbnUser.Text %>'
                                                
                                </s>
        ExeQuery(sql)
        MsgBox("Transaction is sucessfully saved.", MsgBoxStyle.Information, "VALIDATION")



        If MsgBox("Do you want to add resource again?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "VALIDATION") = MsgBoxResult.No Then
            Clear()
            ControlEvents(True)
        Else
            ResClear()
            ControlEvents(False)
            xPORORDER.Text = FindLastOrder(VERID)
            xRECID.Text = ""
            xDETAILCODE.Text = "System Generated"

        End If

        PopulatePOT()

    End Sub
    Private Sub dgPOTD_DoubleClick(sender As Object, e As EventArgs) Handles dgPOTD.DoubleClick
        tsEdit.PerformClick()
    End Sub
End Class