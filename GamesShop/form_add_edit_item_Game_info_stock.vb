﻿Public Class form_add_edit_item_Game_info_stock
    Dim trigger As String

    Sub RELOAD_TABLE_GAME_INFO_STOCK()
        table_game_info_stock.Clear()
        table_view_game_info_stock.Clear()
        table_transaction_game_info_stock.Clear()
        game_info_stock_adapter.Fill(table_game_info_stock)
        game_info_stock_adapter.Fill(table_view_game_info_stock)
        game_info_stock_adapter.Fill(table_transaction_game_info_stock)
        DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.DataSource = table_game_info_stock
    End Sub

    Sub MIDDLE_OF_ADD()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtSEARCH_KODE.Enabled = False
        txtKODE_GAME.Enabled = True
        txtKODE_GAME.Text = ""

        txtSTOCK.Enabled = True
        txtSTOCK.Text = ""


        DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.Enabled = False

        txtKODE_GAME.Focus()
    End Sub

    Sub MIDDLE_OF_EDIT()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtSEARCH_KODE.Enabled = False
        txtKODE_GAME.Enabled = True
        txtSTOCK.Enabled = True


        txtKODE_GAME.Focus()

        DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.Enabled = False
    End Sub

    Sub NOT_IN_ADD_OR_EDIT()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtKODE_GAME.Enabled = False
        txtKODE_GAME.Text = ""

        txtSTOCK.Enabled = False
        txtSTOCK.Text = ""


        DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.Enabled = True

    End Sub

    Sub AFTER_ADD_OR_EDIT_OR_DELETE()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtSEARCH_KODE.Enabled = True
        txtKODE_GAME.Enabled = False
        txtSTOCK.Enabled = False

        DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.Enabled = True
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        trigger = "ADD"
        Call MIDDLE_OF_ADD()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtKODE_GAME.Text = "" Or txtSTOCK.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO GAME_INFO_STOCK (KODE_GAME,STOCK)"
                    sql_command = sql_command + "VALUES('" & Trim(UCase(txtKODE_GAME.Text)) & "','" & Trim(txtSTOCK.Text) & "')"

                    With game_info_stock_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_STOCK()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                Try
                    sql_command = "UPDATE GAME_INFO_STOCK SET"
                    sql_command = sql_command & " KODE_GAME= '" & Trim(UCase(txtKODE_GAME.Text)) & "',"
                    sql_command = sql_command & " STOCK = '" & Trim(txtSTOCK.Text) & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " KODE_GAME= '" & UCase(lblKODE_GAME.Text) & "'"


                    With game_info_stock_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_STOCK()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub



    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Call NOT_IN_ADD_OR_EDIT()
        Me.Hide()
        form_Main.ToolStripITEMxADDEDITITEMxGAMEINFOSTOCK.Enabled = True
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtKODE_GAME.Text = "" Or txtSTOCK.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            trigger = "EDIT"
            Call MIDDLE_OF_EDIT()
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtKODE_GAME.Text = "" Or txtSTOCK.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM GAME_INFO_STOCK WHERE KODE_GAME = '" & UCase(lblKODE_GAME.Text) & "'"


                    With game_info_stock_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_STOCK()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

  

   
    Private Sub form_add_edit_item_Game_info_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSEARCH_KODE.Text = ""
        Call NOT_IN_ADD_OR_EDIT()
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub

    Private Sub DG_ADD_EDIT_ITEM_GAME_INFO_STOCK_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.SelectionChanged
        Dim rows As Integer

        With DG_ADD_EDIT_ITEM_GAME_INFO_STOCK
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index
                    If Not IsDBNull(.Item(0, rows).Value) Then
                        rows = .CurrentRow.Index

                        lblKODE_GAME.Text = .Item(0, rows).Value
                        txtKODE_GAME.Text = .Item(0, rows).Value
                        txtSTOCK.Text = .Item(1, rows).Value
                    Else
                        Call NOT_IN_ADD_OR_EDIT()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub txtSEARCH_KODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSEARCH_KODE.TextChanged
        If txtSEARCH_KODE.Text <> "" Then
            Dim search_kode As String = txtSEARCH_KODE.Text
            Dim len_search_kode As Integer = Len(search_kode)

            With DG_ADD_EDIT_ITEM_GAME_INFO_STOCK
                For Each rows As DataGridViewRow In .Rows
                    If StrComp(Strings.Left(rows.Cells.Item("KODE_GAME").Value, len_search_kode), search_kode, 1) = 0 Then
                        'SET FOCUS
                        .CurrentCell = rows.Cells("KODE_GAME")

                        'HIGHLIGHT THE ROWS
                        rows.Selected = True
                        lblKODE_GAME.Text = rows.Cells.Item(0).Value
                        txtKODE_GAME.Text = rows.Cells.Item(0).Value
                        txtSTOCK.Text = rows.Cells.Item(1).Value
                        Exit For
                    End If
                Next
            End With
        End If
    End Sub
End Class