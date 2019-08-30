Public Class form_add_edit_item_Game_info_supplier
    Dim trigger As String

    Sub SUPPLIER_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtKODE_GAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboSUPPLIER.Enabled = True
        cboSUPPLIER.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = False

        chADD_SUPPLIER.Enabled = True
        chDELETE_SUPPLIER.Enabled = True

        cboSUPPLIER.Focus()
    End Sub

    Sub SUPPLIER_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtKODE_GAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboSUPPLIER.Enabled = False
        cboSUPPLIER.Text = ""

        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = True


    End Sub


    Sub RELOAD_TABLE_GAME_INFO_SUPPLIER()
        table_game_info_supplier.Clear()
        table_view_game_info_supplier.Clear()
        game_info_supplier_adapter.Fill(table_game_info_supplier)
        game_info_supplier_adapter.Fill(table_view_game_info_supplier)
        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.DataSource = table_game_info_supplier
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

        cboSUPPLIER.Enabled = True
        txtSUPPLIER_PRICE.Enabled = True

        cboSUPPLIER.Text = ""
        txtSUPPLIER_PRICE.Text = ""

        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = False

        txtKODE_GAME.Focus()
        chADD_SUPPLIER.Enabled = False
        chDELETE_SUPPLIER.Enabled = False
        
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

        cboSUPPLIER.Enabled = True
        txtSUPPLIER_PRICE.Enabled = True

        txtKODE_GAME.Focus()

        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = False
        chADD_SUPPLIER.Enabled = False
        chDELETE_SUPPLIER.Enabled = False
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

        cboSUPPLIER.Enabled = False
        txtSUPPLIER_PRICE.Enabled = False

        cboSUPPLIER.Text = ""
        txtSUPPLIER_PRICE.Text = ""

        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = True
        chADD_SUPPLIER.Enabled = True
        chDELETE_SUPPLIER.Enabled = True

    End Sub

    Sub AFTER_ADD_OR_EDIT_OR_DELETE()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtKODE_GAME.Enabled = False
        txtSEARCH_KODE.Enabled = True

        cboSUPPLIER.Enabled = False
        txtSUPPLIER_PRICE.Enabled = False


        DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Enabled = True
        chADD_SUPPLIER.Enabled = True
        chDELETE_SUPPLIER.Enabled = True
    End Sub
   
    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtKODE_GAME.Text = "" Or cboSUPPLIER.Text = "" Or txtSUPPLIER_PRICE.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO GAME_INFO_SUPPLIER (KODE_GAME,SUPPLIER,SUPPLIER_PRICE)"
                    sql_command = sql_command + "VALUES('" & Trim(UCase(txtKODE_GAME.Text)) & "','" & Trim(UCase(cboSUPPLIER.Text)) & "','" & Trim(txtSUPPLIER_PRICE.Text) & "')"

                    With game_info_supplier_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_SUPPLIER()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                Try
                    sql_command = "UPDATE GAME_INFO_SUPPLIER SET"
                    sql_command = sql_command & " KODE_GAME= '" & Trim(UCase(txtKODE_GAME.Text)) & "',"
                    sql_command = sql_command & " SUPPLIER = '" & Trim(UCase(cboSUPPLIER.Text)) & "',"
                    sql_command = sql_command & " SUPPLIER_PRICE = '" & Trim(txtSUPPLIER_PRICE.Text) & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " KODE_GAME = '" & UCase(lblKODE_GAME.Text) & "'"
                    sql_command = sql_command & " AND SUPPLIER = '" & UCase(lblSUPPLIER.Text) & "'"
                    sql_command = sql_command & " AND SUPPLIER_PRICE = '" & lblSUPPLIER_PRICE.Text & "'"


                    With game_info_supplier_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_SUPPLIER()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        Call MIDDLE_OF_ADD()
        trigger = "ADD"
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtKODE_GAME.Text = "" Or cboSUPPLIER.Text = "" Or txtSUPPLIER_PRICE.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call MIDDLE_OF_EDIT()
            trigger = "EDIT"
            END IF
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtKODE_GAME.Text = "" Or cboSUPPLIER.Text = "" Or txtSUPPLIER_PRICE.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM GAME_INFO_SUPPLIER WHERE "
                    sql_command = sql_command & " KODE_GAME = '" & UCase(lblKODE_GAME.Text) & "'"
                    sql_command = sql_command & " AND SUPPLIER = '" & UCase(lblSUPPLIER.Text) & "'"
                    sql_command = sql_command & " AND SUPPLIER_PRICE = '" & lblSUPPLIER_PRICE.Text & "'"


                    With game_info_supplier_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_SUPPLIER()
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
        form_Main.ToolStripITEMxADDEDITITEMxGAMEINFOSUPPLIER.Enabled = True
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub

    Private Sub form_add_edit_item_Game_info_supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NOT_IN_ADD_OR_EDIT()
    End Sub

    Private Sub DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.SelectionChanged
        Dim rows As Integer

        With DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index
                    If Not IsDBNull(.Item(0, rows).Value) Then
                        rows = .CurrentRow.Index
                        lblKODE_GAME.Text = .Item(0, rows).Value
                        lblSUPPLIER.Text = .Item(1, rows).Value
                        lblSUPPLIER_PRICE.Text = .Item(2, rows).Value
                        txtKODE_GAME.Text = .Item(0, rows).Value
                        cboSUPPLIER.Text = .Item(1, rows).Value
                        txtSUPPLIER_PRICE.Text = .Item(2, rows).Value
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

            With DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER
                For Each rows As DataGridViewRow In .Rows
                    If StrComp(Strings.Left(rows.Cells.Item("KODE_GAME").Value, len_search_kode), search_kode, 1) = 0 Then
                        'SET FOCUS
                        .CurrentCell = rows.Cells("KODE_GAME")

                        'HIGHLIGHT THE ROWS
                        rows.Selected = True
                        lblKODE_GAME.Text = rows.Cells.Item(0).Value
                        txtKODE_GAME.Text = rows.Cells.Item(0).Value
                        cboSUPPLIER.Text = rows.Cells.Item(1).Value
                        txtSUPPLIER_PRICE.Text = rows.Cells.Item(2).Value
                        Exit For
                    End If
                Next
            End With
        End If
    End Sub

    Private Sub chADD_SUPPLIER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_SUPPLIER.CheckedChanged
        If chADD_SUPPLIER.Checked = True Then
            Call SUPPLIER_CHECKED()
            chDELETE_SUPPLIER.Checked = False
        ElseIf chADD_SUPPLIER.Checked = False And chDELETE_SUPPLIER.Checked = False Then
            Call SUPPLIER_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_SUPPLIER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_SUPPLIER.CheckedChanged
        If chDELETE_SUPPLIER.Checked = True Then
            Call SUPPLIER_CHECKED()
            chADD_SUPPLIER.Checked = False
        ElseIf chADD_SUPPLIER.Checked = False And chDELETE_SUPPLIER.Checked = False Then
            Call SUPPLIER_UNCHECKED()
        End If
    End Sub

    Private Sub cboSUPPLIER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSUPPLIER.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_SUPPLIER.Checked = True Then
                    If cboSUPPLIER.Text <> "" Then

                        supplier_command = New OleDb.OleDbCommand("DELETE FROM SUPPLIER WHERE SUPPLIER = '" & Trim(UCase(cboSUPPLIER.Text)) & "'", conn)
                        supplier_command.ExecuteNonQuery()
                        cboSUPPLIER.Items.Remove(Trim(UCase(cboSUPPLIER.Text)))

                    End If

                ElseIf chADD_SUPPLIER.Checked = True And cboSUPPLIER.Text <> "" Then
                    supplier_command = New OleDb.OleDbCommand("INSERT INTO SUPPLIER (SUPPLIER) VALUES ('" & Trim(UCase(cboSUPPLIER.Text)) & "')", conn)
                    supplier_command.ExecuteNonQuery()
                    cboSUPPLIER.Items.Add(Trim(UCase(cboSUPPLIER.Text)))
                    cboSUPPLIER.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
End Class