Public Class form_add_edit_item_Game_info
    Dim trigger As String

    Sub RELOAD_TABLE_GAME_INFO()
        table_game_info.Clear()
        table_view_game_info.Clear()
        table_view_order_game_info.Clear()
        game_info_adapter.Fill(table_game_info)
        game_info_adapter.Fill(table_view_game_info)
        game_info_adapter.Fill(table_view_order_game_info)
        game_info_adapter.Fill(table_view_purchase_history_game_info)
        DG_ADD_EDIT_ITEM_GAME_INFO.DataSource = table_game_info
        form_View_item.DG_VIEW_ITEM_GAME_INFO.DataSource = table_view_game_info
    End Sub

    Sub MIDDLE_OF_ADD()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtKODE_GAME.Enabled = True
        txtGAME_NAME.Enabled = True
        txtSEARCH_KODE.Enabled = False

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""

        cboLANGUAGE.Enabled = True
        cboPLATFORM.Enabled = True
        cboREGION.Enabled = True

        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""

        dtmRELEASE_DATE.Enabled = True

        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = False

        chADD_LANGUAGE.Enabled = False
        chDELETE_LANGUAGE.Enabled = False
        chADD_PLATFORM.Enabled = False
        chDELETE_PLATFORM.Enabled = False
        chADD_REGION.Enabled = False
        chDELETE_REGION.Enabled = False

        
        txtKODE_GAME.Focus()
    End Sub

    Sub MIDDLE_OF_EDIT()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtKODE_GAME.Enabled = True
        txtGAME_NAME.Enabled = True
        txtSEARCH_KODE.Enabled = False

        cboLANGUAGE.Enabled = True
        cboPLATFORM.Enabled = True
        cboREGION.Enabled = True

        dtmRELEASE_DATE.Enabled = True

        txtKODE_GAME.Focus()

        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = False

        chADD_LANGUAGE.Enabled = False
        chDELETE_LANGUAGE.Enabled = False
        chADD_PLATFORM.Enabled = False
        chDELETE_PLATFORM.Enabled = False
        chADD_REGION.Enabled = False
        chDELETE_REGION.Enabled = False

    End Sub

    Sub NOT_IN_ADD_OR_EDIT()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtKODE_GAME.Enabled = False
        txtGAME_NAME.Enabled = False
        txtSEARCH_KODE.Enabled = True

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""

        cboLANGUAGE.Enabled = False
        cboPLATFORM.Enabled = False
        cboREGION.Enabled = False

        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""

        dtmRELEASE_DATE.Enabled = False
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = True

        chADD_LANGUAGE.Enabled = True
        chDELETE_LANGUAGE.Enabled = True
        chADD_PLATFORM.Enabled = True
        chDELETE_PLATFORM.Enabled = True
        chADD_REGION.Enabled = True
        chDELETE_REGION.Enabled = True


    End Sub

    Sub AFTER_ADD_OR_EDIT_OR_DELETE()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtKODE_GAME.Enabled = False
        txtGAME_NAME.Enabled = False
        txtSEARCH_KODE.Enabled = True



        cboLANGUAGE.Enabled = False
        cboPLATFORM.Enabled = False
        cboREGION.Enabled = False

        dtmRELEASE_DATE.Enabled = False
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = True

        chADD_LANGUAGE.Enabled = True
        chDELETE_LANGUAGE.Enabled = True
        chADD_PLATFORM.Enabled = True
        chDELETE_PLATFORM.Enabled = True
        chADD_REGION.Enabled = True
        chDELETE_REGION.Enabled = True

    End Sub

    Sub PLATFORM_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboPLATFORM.Enabled = True
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = False

        chADD_PLATFORM.Enabled = True
        chDELETE_PLATFORM.Enabled = True
        chADD_LANGUAGE.Enabled = False
        chDELETE_LANGUAGE.Enabled = False
        chADD_REGION.Enabled = False
        chDELETE_REGION.Enabled = False



        cboPLATFORM.Focus()
    End Sub

    Sub PLATFORM_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboPLATFORM.Enabled = False
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = True
        chADD_LANGUAGE.Enabled = True
        chDELETE_LANGUAGE.Enabled = True
        chADD_REGION.Enabled = True
        chDELETE_REGION.Enabled = True

    End Sub

    Sub REGION_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboREGION.Enabled = True
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = False

        chADD_PLATFORM.Enabled = False
        chDELETE_PLATFORM.Enabled = False
        chADD_LANGUAGE.Enabled = False
        chDELETE_LANGUAGE.Enabled = False
        chADD_REGION.Enabled = True
        chDELETE_REGION.Enabled = True



        cboPLATFORM.Focus()
    End Sub

    Sub REGION_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboREGION.Enabled = False
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = True
        chADD_LANGUAGE.Enabled = True
        chDELETE_LANGUAGE.Enabled = True
        chADD_PLATFORM.Enabled = True
        chDELETE_PLATFORM.Enabled = True

    End Sub

    Sub LANGUAGE_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboLANGUAGE.Enabled = True
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = False

        chADD_PLATFORM.Enabled = False
        chDELETE_PLATFORM.Enabled = False
        chADD_LANGUAGE.Enabled = True
        chDELETE_LANGUAGE.Enabled = True
        chADD_REGION.Enabled = False
        chDELETE_REGION.Enabled = False



        cboPLATFORM.Focus()
    End Sub

    Sub LANGUAGE_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtKODE_GAME.Text = ""
        txtGAME_NAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboLANGUAGE.Enabled = False
        cboLANGUAGE.Text = ""
        cboPLATFORM.Text = ""
        cboREGION.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO.Enabled = True
        chADD_REGION.Enabled = True
        chDELETE_REGION.Enabled = True
        chADD_PLATFORM.Enabled = True
        chDELETE_PLATFORM.Enabled = True

    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click

        If txtKODE_GAME.Text = "" Or txtGAME_NAME.Text = "" Or cboPLATFORM.Text = "" Or cboREGION.Text = "" Or cboLANGUAGE.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO GAME_INFO (KODE_GAME,GAME_NAME,PLATFORM,REGION,LANGUAGES,RELEASE_DATE)"
                    sql_command = sql_command + "VALUES('" & Trim(UCase(txtKODE_GAME.Text)) & "','" & Trim(UCase(txtGAME_NAME.Text)) & "','" & Trim(UCase(cboPLATFORM.Text)) & "','" _
                     & Trim(UCase(cboREGION.Text)) & "','" & Trim(UCase(cboLANGUAGE.Text)) & "','" & dtmRELEASE_DATE.Text & "')"

                    With game_info_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            else
                Try
                    sql_command = "UPDATE GAME_INFO SET"
                    sql_command = sql_command & " GAME_NAME= '" & Trim(UCase(txtGAME_NAME.Text)) & "',"
                    sql_command = sql_command & " PLATFORM = '" & Trim(UCase(cboPLATFORM.Text)) & "',"
                    sql_command = sql_command & " REGION = '" & Trim(UCase(cboREGION.Text)) & "',"
                    sql_command = sql_command & " LANGUAGES = '" & Trim(UCase(cboLANGUAGE.Text)) & "',"
                    sql_command = sql_command & " RELEASE_DATE = '" & dtmRELEASE_DATE.Text & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " KODE_GAME = '" & Trim(UCase(txtKODE_GAME.Text)) & "'"

                    With game_info_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        trigger = "ADD"
        Call MIDDLE_OF_ADD()
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtKODE_GAME.Text = "" Or txtGAME_NAME.Text = "" Or cboPLATFORM.Text = "" Or cboREGION.Text = "" Or cboLANGUAGE.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            trigger = "EDIT"
            Call MIDDLE_OF_EDIT()
        End If
    End Sub



    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtKODE_GAME.Text = "" Or txtGAME_NAME.Text = "" Or cboPLATFORM.Text = "" Or cboREGION.Text = "" Or cboLANGUAGE.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM GAME_INFO WHERE KODE_GAME = '" & UCase(txtKODE_GAME.Text) & "'"
                    

                    With game_info_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Call NOT_IN_ADD_OR_EDIT()
        txtSEARCH_KODE.Text = ""
        Me.Hide()
        form_Main.ToolStripITEMxADDEDITITEMxGAMEINFO.Enabled = True
    End Sub

    Private Sub form_add_edit_item_Game_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NOT_IN_ADD_OR_EDIT()
        txtSEARCH_KODE.Text = ""
    End Sub
    
    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub

    Private Sub txtSEARCH_KODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSEARCH_KODE.TextChanged

        If txtSEARCH_KODE.Text <> "" Then
            Dim search_kode As String = txtSEARCH_KODE.Text
            Dim len_search_kode As Integer = Len(search_kode)

            With DG_ADD_EDIT_ITEM_GAME_INFO
                If rdKODE_GAME.Checked = True Then
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("KODE_GAME").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("KODE_GAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            txtKODE_GAME.Text = rows.Cells.Item(0).Value
                            txtGAME_NAME.Text = rows.Cells.Item(1).Value
                            cboPLATFORM.Text = rows.Cells.Item(2).Value
                            cboREGION.Text = rows.Cells.Item(3).Value
                            cboLANGUAGE.Text = rows.Cells.Item(4).Value
                            dtmRELEASE_DATE.Value = rows.Cells.Item(5).Value
                            Exit For
                        End If
                    Next
                Else
                    For Each rows As DataGridViewRow In .Rows
                        ' If Strings.Left(rows.Cells.Item("GAME_NAME").Value, len_search_kode) = search_kode Then
                        If StrComp(Strings.Left(rows.Cells.Item("GAME_NAME").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("GAME_NAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            txtKODE_GAME.Text = rows.Cells.Item(0).Value
                            txtGAME_NAME.Text = rows.Cells.Item(1).Value
                            cboPLATFORM.Text = rows.Cells.Item(2).Value
                            cboREGION.Text = rows.Cells.Item(3).Value
                            cboLANGUAGE.Text = rows.Cells.Item(4).Value
                            dtmRELEASE_DATE.Value = rows.Cells.Item(5).Value
                            Exit For
                        End If
                    Next
                End If
            End With
        End If
    End Sub

    

   
    Private Sub DG_ADD_EDIT_ITEM_GAME_INFO_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ITEM_GAME_INFO.SelectionChanged
        Dim rows As Integer
        With DG_ADD_EDIT_ITEM_GAME_INFO
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        txtKODE_GAME.Text = .Item(0, rows).Value
                        txtGAME_NAME.Text = .Item(1, rows).Value
                        cboPLATFORM.Text = .Item(2, rows).Value
                        cboREGION.Text = .Item(3, rows).Value
                        cboLANGUAGE.Text = .Item(4, rows).Value
                        dtmRELEASE_DATE.Value = .Item(5, rows).Value
                    Else
                        Call NOT_IN_ADD_OR_EDIT()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With
    End Sub

  

   
    Private Sub cboPLATFORM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPLATFORM.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_PLATFORM.Checked = True Then
                    If cboPLATFORM.Text <> "" Then

                        platform_command = New OleDb.OleDbCommand("DELETE FROM PLATFORM WHERE PLATFORM = '" & Trim(UCase(cboPLATFORM.Text)) & "'", conn)
                        platform_command.ExecuteNonQuery()
                        cboPLATFORM.Items.Remove(Trim(UCase(cboPLATFORM.Text)))

                    End If

                ElseIf chADD_PLATFORM.Checked = True And cboPLATFORM.Text <> "" Then
                    platform_command = New OleDb.OleDbCommand("INSERT INTO PLATFORM (PLATFORM) VALUES ('" & Trim(UCase(cboPLATFORM.Text)) & "')", conn)
                    platform_command.ExecuteNonQuery()
                    cboPLATFORM.Items.Add(Trim(UCase(cboPLATFORM.Text)))
                    cboPLATFORM.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


  
    Private Sub chADD_PLATFORM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_PLATFORM.CheckedChanged
        If chADD_PLATFORM.Checked = True Then
            Call PLATFORM_CHECKED()
            chDELETE_PLATFORM.Checked = False
        ElseIf chADD_PLATFORM.Checked = False And chDELETE_PLATFORM.Checked = False Then
            Call PLATFORM_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_PLATFORM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_PLATFORM.CheckedChanged
        If chDELETE_PLATFORM.Checked = True Then
            Call PLATFORM_CHECKED()
            chADD_PLATFORM.Checked = False
        ElseIf chADD_PLATFORM.Checked = False And chDELETE_PLATFORM.Checked = False Then
            Call PLATFORM_UNCHECKED()
        End If
    End Sub

    Private Sub chADD_REGION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_REGION.CheckedChanged
        If chADD_REGION.Checked = True Then
            Call REGION_CHECKED()
            chDELETE_REGION.Checked = False
        ElseIf chADD_REGION.Checked = False And chDELETE_REGION.Checked = False Then
            Call REGION_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_REGION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_REGION.CheckedChanged
        If chDELETE_REGION.Checked = True Then
            Call REGION_CHECKED()
            chADD_REGION.Checked = False
        ElseIf chADD_REGION.Checked = False And chDELETE_REGION.Checked = False Then
            Call REGION_UNCHECKED()
        End If
    End Sub

    Private Sub chADD_LANGUAGE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_LANGUAGE.CheckedChanged
        If chADD_LANGUAGE.Checked = True Then
            Call LANGUAGE_CHECKED()
            chDELETE_LANGUAGE.Checked = False
        ElseIf chADD_LANGUAGE.Checked = False And chDELETE_LANGUAGE.Checked = False Then
            Call LANGUAGE_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_LANGUAGE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_LANGUAGE.CheckedChanged
        If chDELETE_LANGUAGE.Checked = True Then
            Call LANGUAGE_CHECKED()
            chADD_LANGUAGE.Checked = False
        ElseIf chADD_LANGUAGE.Checked = False And chDELETE_LANGUAGE.Checked = False Then
            Call LANGUAGE_UNCHECKED()
        End If
    End Sub

    Private Sub cboREGION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboREGION.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_REGION.Checked = True Then
                    If cboREGION.Text <> "" Then

                        region_command = New OleDb.OleDbCommand("DELETE FROM REGIONS WHERE REGIONS = '" & Trim(UCase(cboREGION.Text)) & "'", conn)
                        region_command.ExecuteNonQuery()
                        cboREGION.Items.Remove(Trim(UCase(cboREGION.Text)))

                    End If

                ElseIf chADD_REGION.Checked = True And cboREGION.Text <> "" Then
                    region_command = New OleDb.OleDbCommand("INSERT INTO REGIONS (REGIONS) VALUES ('" & Trim(UCase(cboREGION.Text)) & "')", conn)
                    region_command.ExecuteNonQuery()
                    cboREGION.Items.Add(Trim(UCase(cboREGION.Text)))
                    cboREGION.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboLANGUAGE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLANGUAGE.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_LANGUAGE.Checked = True Then
                    If cboLANGUAGE.Text <> "" Then

                        languages_command = New OleDb.OleDbCommand("DELETE FROM LANGUAGES WHERE LANGUAGES = '" & Trim(UCase(cboLANGUAGE.Text)) & "'", conn)
                        languages_command.ExecuteNonQuery()
                        cboLANGUAGE.Items.Remove(Trim(UCase(cboLANGUAGE.Text)))

                    End If

                ElseIf chADD_LANGUAGE.Checked = True And cboLANGUAGE.Text <> "" Then
                    languages_command = New OleDb.OleDbCommand("INSERT INTO LANGUAGES (LANGUAGES) VALUES ('" & Trim(UCase(cboLANGUAGE.Text)) & "')", conn)
                    languages_command.ExecuteNonQuery()
                    cboLANGUAGE.Items.Add(Trim(UCase(cboLANGUAGE.Text)))
                    cboLANGUAGE.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class