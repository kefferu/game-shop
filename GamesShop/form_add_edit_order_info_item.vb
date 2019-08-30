Public Class form_add_edit_order_info_item
    Dim trigger As String

    Sub RELOAD_TABLE_ORDER_INFO_ITEM()
        table_order_info_item.Clear()
        table_view_order_info_item.Clear()
        order_info_item_adapter.Fill(table_order_info_item)
        order_info_item_adapter.Fill(table_view_order_info_item)
        DG_ADD_EDIT_ORDER_INFO_ITEM.DataSource = table_order_info_item
    End Sub

    Sub DATA_NOT_SELECTED()
        txtKODE_GAME.Text = ""
        txtORDER_ID.Text = ""
        txtQUANTITY.Text = ""
    End Sub


    Sub MIDDLE_OF_ADD()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtSEARCH_KODE.Enabled = False
        txtORDER_ID.Enabled = True
        txtORDER_ID.Text = ""

        txtKODE_GAME.Enabled = True
        txtKODE_GAME.Text = ""

        txtQUANTITY.Enabled = True

        txtQUANTITY.Text = ""


        DG_ADD_EDIT_ORDER_INFO_ITEM.Enabled = False

        txtORDER_ID.Focus()
    End Sub

    Sub MIDDLE_OF_EDIT()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtORDER_ID.Enabled = True
        txtSEARCH_KODE.Enabled = False
        txtKODE_GAME.Enabled = True
        txtQUANTITY.Enabled = True


        txtORDER_ID.Focus()

        DG_ADD_EDIT_ORDER_INFO_ITEM.Enabled = False
    End Sub

    Sub NOT_IN_ADD_OR_EDIT()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtORDER_ID.Enabled = False
        txtORDER_ID.Text = ""
        txtKODE_GAME.Enabled = False
        txtKODE_GAME.Text = ""
        txtQUANTITY.Enabled = False
        txtQUANTITY.Text = ""




        DG_ADD_EDIT_ORDER_INFO_ITEM.Enabled = True

    End Sub

    Sub AFTER_ADD_OR_EDIT_OR_DELETE()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtSEARCH_KODE.Enabled = True
        txtORDER_ID.Enabled = False
        txtKODE_GAME.Enabled = False
        txtQUANTITY.Enabled = False


        DG_ADD_EDIT_ORDER_INFO_ITEM.Enabled = True

    End Sub

    Private Sub form_order_info_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NOT_IN_ADD_OR_EDIT()
        txtSEARCH_KODE.Text = ""
    End Sub

   

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtORDER_ID.Text = "" Or txtKODE_GAME.Text = "" Or txtQUANTITY.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            trigger = "EDIT"
            Call MIDDLE_OF_EDIT()
        End If
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtORDER_ID.Text = "" Or txtKODE_GAME.Text = "" Or txtQUANTITY.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO ORDER_INFO_ITEM (ORDER_ID,KODE_GAME,QUANTITY)"
                    sql_command = sql_command + "VALUES('" & txtORDER_ID.Text & "','" & Trim(UCase(txtKODE_GAME.Text)) & "','" & Trim(txtQUANTITY.Text) & "')"

                    With order_info_item_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_ITEM()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                Try
                    sql_command = "UPDATE ORDER_INFO_ITEM SET"
                    sql_command = sql_command & " ORDER_ID= '" & txtORDER_ID.Text & "',"
                    sql_command = sql_command & " KODE_GAME = '" & Trim(UCase(txtKODE_GAME.Text)) & "',"
                    sql_command = sql_command & " QUANTITY = '" & Trim(txtQUANTITY.Text) & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " ORDER_ID= '" & lblORDER_ID.Text & "'"
                    sql_command = sql_command & " AND KODE_GAME = '" & UCase(lblKODE_GAME.Text) & "'"
                    sql_command = sql_command & " AND QUANTITY = '" & lblQUANTITY.Text & "'"


                    With order_info_item_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_ITEM()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtORDER_ID.Text = "" Or txtKODE_GAME.Text = "" Or txtQUANTITY.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM ORDER_INFO_ITEM WHERE "
                    sql_command = sql_command & " ORDER_ID = '" & lblORDER_ID.Text & "'"
                    sql_command = sql_command & " AND KODE_GAME = '" & lblKODE_GAME.Text & "'"
                    sql_command = sql_command & " AND QUANTITY = '" & lblQUANTITY.Text & "'"


                    With order_info_item_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_ITEM()
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
        form_Main.ToolStripORDERxADDEDITORDERxORDERINFOITEM.Enabled = True
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub



    Private Sub DG_ADD_EDIT_ORDER_INFO_ITEM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ORDER_INFO_ITEM.SelectionChanged
        Dim rows As Integer

        With DG_ADD_EDIT_ORDER_INFO_ITEM
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        rows = .CurrentRow.Index
                        lblORDER_ID.Text = .Item(0, rows).Value
                        lblKODE_GAME.Text = .Item(1, rows).Value
                        lblQUANTITY.Text = .Item(2, rows).Value
                        txtORDER_ID.Text = .Item(0, rows).Value
                        txtKODE_GAME.Text = .Item(1, rows).Value
                        txtQUANTITY.Text = .Item(2, rows).Value
                    Else
                        Call DATA_NOT_SELECTED()
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

            With DG_ADD_EDIT_ORDER_INFO_ITEM

                For Each rows As DataGridViewRow In .Rows
                    If StrComp(Strings.Left(rows.Cells.Item("ORDER_ID").Value, len_search_kode), search_kode, 1) = 0 Then
                        'SET FOCUS
                        .CurrentCell = rows.Cells("ORDER_ID")
                        'HIGHLIGHT THE ROWS
                        rows.Selected = True
                        txtORDER_ID.Text = rows.Cells.Item(0).Value
                        txtKODE_GAME.Text = rows.Cells.Item(1).Value
                        txtQUANTITY.Text = rows.Cells.Item(2).Value
                        Exit For
                    End If
                Next
            End With
        End If


    End Sub

 

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        trigger = "ADD"
        Call MIDDLE_OF_ADD()
    End Sub
End Class