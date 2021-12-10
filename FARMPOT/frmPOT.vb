Public Class frmPOT



#Region "Routine"

    Sub ControlEvents(bool As Boolean)
        tsNew.Enabled = bool
        tsEdit.Enabled = bool
        tsSave.Enabled = Not bool
        tsCancel.Enabled = Not bool
        tsDelete.Enabled = bool

        panelentryPOT.Enabled = Not bool
    End Sub
    Function FindID(ByVal tupaynd As String, ByVal teyboL As String, ByVal koltupaynd As String, ByVal valtupaynd As String) As Integer
        Dim sql As String = <s>
                                SELECT <%= tupaynd %> FROM <%= teyboL %> WHERE <%= koltupaynd %> = '<%= valtupaynd %>'
                            </s>
        ExeReader(sql)
        Dim Find As Integer = 0
        While dr.Read
            Find = dr.Item(tupaynd)
        End While
        dr.Close()
        Conn.Close()

        Return Find
    End Function

    Sub POPULATEPOT()
        Dim search As String = xsearch.Text.Replace("'", "''")
        Dim sql As String = <s>
                                SELECT [RECID]
                                            ,[VERSION]
                                            ,[EFFECTIVITYDATE]
                                            ,ISNULL([ISDEFAULT],0) AS ISDEFAULT
                                            ,ISNULL([ISPOSTED],0) AS ISPOSTED
                                            ,[ISACTIVE]
                                            ,[CREATEDBY]
                                            ,CONVERT(VARCHAR,[CREATIONDATE])  AS CREATIONDATE
                                            ,[MODIFIEDBY]
                                            ,CONVERT(VARCHAR,[MODIFICATIONDATE]) AS MODIFICATIONDATE
                                        FROM [M_FARM_POT_VERSION]
                                    WHERE VERSION LIKE  '%<%= search %>%'
                                    AND ISACTIVE =  1
                            </s>
        SelectQuery(sql)
        With dgMainPOT
            .DataSource = ds
            .DataMember = "table"
            .Rows(0).Height = 50
            .Cols.Fixed = 0
            .AutoSizeCols()
        End With
    End Sub
#End Region
    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        ControlEvents(False)
        xVERSION.Text = ""
        xRECID.Text = ""
    End Sub
    Private Sub frmPOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POPULATEPOT()
        ControlEvents(True)
        xVERSION.Text = ""
        xRECID.Text = ""
    End Sub
    Private Sub xsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xsearch.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            POPULATEPOT()
        End If
    End Sub
    Private Sub tsCancel_Click(sender As Object, e As EventArgs) Handles tsCancel.Click
        ControlEvents(True)
        xVERSION.Text = ""
        xRECID.Text = ""
    End Sub
    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        If dgMainPOT.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMainPOT.RowSel
        If i <= 0 Then
            MsgBox("Please select record first.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        With dgMainPOT
            xRECID.Text = .Item(i, "RECID").ToString
            xVERSION.Text = .Item(i, "VERSION").ToString
            xdtpEFFECTIVITY.Value = xdtpEFFECTIVITY.Value.ToShortDateString
        End With
        ControlEvents(False)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If xVERSION.Text = "" Then
            MsgBox("Invalid Version!", MsgBoxStyle.Information, "ERROR")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to save this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "VALIDATION") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim sql As String = ""
        'NOT DONE YET
        If xRECID.Text.Replace(" ", "") = "" Or Val(xRECID.Text) = 0 Then
            sql = <s>
                                    INSERT INTO [M_FARM_POT_VERSION]
                                           ([VERSION]
                                           ,[EFFECTIVITYDATE]
                                           ,[ISACTIVE]
                                           ,[CREATEDBY]
                                           ,[CREATIONDATE])
                                     VALUES
                                           (/*VERSION, nvarchar(50)*/'<%= xVERSION.Text %>'
                                           ,/*EFFECTIVITYDATE, date*/'<%= xdtpEFFECTIVITY.Value.ToShortDateString %>'
                                           ,/*ISACTIVE, bit*/1
                                           ,/*CREATEDBY, nvarchar(50)*/'<%= RbnUser.Text %>'
                                           ,/*CREATIONDATE, datetime*/GETDATE())
                                </s>
        Else
            sql = <s>
                                  UPDATE [M_FARM_POT_VERSION]
                                    SET [VERSION] = '<%= xVERSION.Text %>'
                                        ,[EFFECTIVITYDATE] = '<%= xdtpEFFECTIVITY.Value.ToShortDateString %>'
                                        ,[ISACTIVE] = 1
                                        ,[MODIFIEDBY] ='<%= RbnUser.Text %>'
                                        ,[MODIFICATIONDATE] = GETDATE()
                                WHERE RECID = <%= xRECID.Text %>
                  </s>
        End If
        ExeQuery(sql)

        MsgBox("Transaction successfully saved.", MsgBoxStyle.Information, "VALIDATION")
        ControlEvents(True)
        xVERSION.Text = ""
        xRECID.Text = ""
    End Sub
    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        If dgMainPOT.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim i As Integer = dgMainPOT.RowSel
        If i = 0 Then
            MsgBox("Please select record first.", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = <s>
                                    UPDATE M_FARM_POT_VERSION  SET
                                    ISACTIVE  = 0
                                    WHERE RECID = <%= dgMainPOT.Item(i, "RECID").ToString %>
                            </s>
        ExeQuery(sql)
        Me.Cursor = Cursors.Default
        POPULATEPOT()
        MsgBox("Successfully delete the transaction.", MsgBoxStyle.Information, "VALIDATION")
    End Sub

    Private Sub dgMainPOT_DoubleClick(sender As Object, e As EventArgs) Handles dgMainPOT.DoubleClick
        If dgMainPOT.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMainPOT.RowSel

        With frmADDPOTDETAIL
            .Text = dgMainPOT.Item(i, "VERSION").ToString
            .VERID = dgMainPOT.Item(i, "RECID").ToString
            .EFFECTIVITYDATE = dgMainPOT.Item(i, "EFFECTIVITYDATE").ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnPOST_Click(sender As Object, e As EventArgs) Handles btnPOST.Click
        If dgMainPOT.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMainPOT.RowSel
        If i <= 0 Then
            MsgBox("Please select record first.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If


        Dim sql As String = <s>
                                UPDATE M_FARM_POT_VERSION SET
                                        ISPOSTED  = 1
                                WHERE RECID = <%= dgMainPOT.Item(i, "RECID").ToString %>
                            </s>
        ExeQuery(sql)
        Me.Cursor = Cursors.Default
        POPULATEPOT()
        MsgBox("Successfully post " & dgMainPOT.Item(i, "VERSION").ToString & " the transaction.", MsgBoxStyle.Information, "VALIDATION")
    End Sub

    Private Sub BtnDEFAULT_Click(sender As Object, e As EventArgs) Handles btnDEFAULT.Click
        If dgMainPOT.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim i As Integer = dgMainPOT.RowSel
        If i <= 0 Then
            MsgBox("Please select record first.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If


        Dim sql As String = <s>
                                UPDATE M_FARM_POT_VERSION SET
                                        ISDEFAULT  = 1
                                WHERE RECID = <%= dgMainPOT.Item(i, "RECID").ToString %>

                               UPDATE M_FARM_POT_VERSION SET
                                        ISDEFAULT  = 0
                                WHERE RECID != <%= dgMainPOT.Item(i, "RECID").ToString %>
                            </s>
        ExeQuery(sql)
        Me.Cursor = Cursors.Default
        POPULATEPOT()
        MsgBox("Successfully default " & dgMainPOT.Item(i, "VERSION").ToString & " the transaction.", MsgBoxStyle.Information, "VALIDATION")
    End Sub
End Class
