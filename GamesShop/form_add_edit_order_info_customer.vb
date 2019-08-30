Public Class form_add_edit_order_info_customer
    Dim trigger As String

    Sub RELOAD_TABLE_ORDER_INFO_CUSTOMER()
        table_order_info_customer.Clear()
        table_view_order_info_customer.Clear()
        order_info_customer_adapter.Fill(table_order_info_customer)
        order_info_customer_adapter.Fill(table_view_order_info_customer)
        DG_ADD_EDIT_ORDER_INFO_CUSTOMER.DataSource = table_order_info_customer
    End Sub

    Sub DATA_NOT_SELECTED()
        txtORDER_ID.Text = ""
        txtCUSTOMER_NAME.Text = ""
        txtPROVINCE.Text = ""
        txtCITY.Text = ""
        txtADDRESS.Text = ""
        txtHP.Text = ""
        txtEMAIL.Text = ""
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
        txtCUSTOMER_NAME.Enabled = True
        txtCUSTOMER_NAME.Text = ""
        txtPROVINCE.Enabled = True
        txtPROVINCE.Text = ""
        txtCITY.Enabled = True
        txtCITY.Text = ""
        txtADDRESS.Enabled = True
        txtADDRESS.Text = ""
        txtHP.Enabled = True
        txtHP.Text = ""
        txtEMAIL.Enabled = True
        txtEMAIL.Text = ""

        DG_ADD_EDIT_ORDER_INFO_CUSTOMER.Enabled = False

        txtORDER_ID.Focus()
    End Sub

    Sub MIDDLE_OF_EDIT()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False
        txtSEARCH_KODE.Enabled = False

        txtORDER_ID.Enabled = True
        txtCUSTOMER_NAME.Enabled = True
        txtPROVINCE.Enabled = True
        txtCITY.Enabled = True
        txtADDRESS.Enabled = True
        txtHP.Enabled = True
        txtEMAIL.Enabled = True


        txtORDER_ID.Focus()

        DG_ADD_EDIT_ORDER_INFO_CUSTOMER.Enabled = False
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
        txtCUSTOMER_NAME.Enabled = False
        txtCUSTOMER_NAME.Text = ""
        txtPROVINCE.Enabled = False
        txtPROVINCE.Text = ""
        txtCITY.Enabled = False
        txtCITY.Text = ""
        txtADDRESS.Enabled = False
        txtADDRESS.Text = ""
        txtHP.Enabled = False
        txtHP.Text = ""
        txtEMAIL.Enabled = False
        txtEMAIL.Text = ""


        DG_ADD_EDIT_ORDER_INFO_CUSTOMER.Enabled = True

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
        txtCUSTOMER_NAME.Enabled = False
        txtPROVINCE.Enabled = False
        txtCITY.Enabled = False
        txtADDRESS.Enabled = False
        txtHP.Enabled = False
        txtEMAIL.Enabled = False

        DG_ADD_EDIT_ORDER_INFO_CUSTOMER.Enabled = True

    End Sub

    Private Sub form_add_edit_order_info_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NOT_IN_ADD_OR_EDIT()
        txtSEARCH_KODE.Text = ""
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        trigger = "ADD"
        Call MIDDLE_OF_ADD()
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtORDER_ID.Text = "" Or txtCUSTOMER_NAME.Text = "" Or txtPROVINCE.Text = "" Or txtCITY.Text = "" Or txtADDRESS.Text = "" Or txtHP.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            trigger = "EDIT"
            Call MIDDLE_OF_EDIT()
        End If
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtORDER_ID.Text = "" Or txtCUSTOMER_NAME.Text = "" Or txtPROVINCE.Text = "" Or txtCITY.Text = "" Or txtADDRESS.Text = "" Or txtHP.Text = "" Then
            MessageBox.Show("All fields Are Required except Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO ORDER_INFO_CUSTOMER (ORDER_ID,CUSTOMER_NAME,PROVINCE,CITY,ADDRESS,HP,EMAIL)"
                    sql_command = sql_command + "VALUES('" & txtORDER_ID.Text & "','" & Trim(UCase(txtCUSTOMER_NAME.Text)) & "','" & Trim(UCase(txtPROVINCE.Text)) & "','" & Trim(UCase(txtCITY.Text)) & "','" & Trim(UCase(txtADDRESS.Text)) & "','" & Trim(txtHP.Text) & "','" & Trim(UCase(txtEMAIL.Text)) & "')"

                    With order_info_customer_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_CUSTOMER()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                Try
                    sql_command = "UPDATE ORDER_INFO_CUSTOMER SET"
                    sql_command = sql_command & " ORDER_ID= '" & txtORDER_ID.Text & "',"
                    sql_command = sql_command & " CUSTOMER_NAME = '" & Trim(UCase(txtCUSTOMER_NAME.Text)) & "',"
                    sql_command = sql_command & " PROVINCE = '" & Trim(UCase(txtPROVINCE.Text)) & "',"
                    sql_command = sql_command & " CITY = '" & Trim(UCase(txtCITY.Text)) & "',"
                    sql_command = sql_command & " ADDRESS = '" & Trim(UCase(txtADDRESS.Text)) & "',"
                    sql_command = sql_command & " HP = '" & Trim(txtHP.Text) & "',"
                    sql_command = sql_command & " EMAIL = '" & Trim(UCase(txtEMAIL.Text)) & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " ORDER_ID= '" & txtORDER_ID.Text & "'"


                    With order_info_customer_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_CUSTOMER()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtORDER_ID.Text = "" Or txtCUSTOMER_NAME.Text = "" Or txtPROVINCE.Text = "" Or txtCITY.Text = "" Or txtADDRESS.Text = "" Or txtHP.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM ORDER_INFO_CUSTOMER WHERE ORDER_ID = '" & txtORDER_ID.Text & "'"


                    With order_info_customer_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_ORDER_INFO_CUSTOMER()
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
        form_Main.ToolStripORDERxADDEDITORDERxORDERINFOCUSTOMER.Enabled = True
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub



    Private Sub DG_ADD_EDIT_ORDER_INFO_CUSTOMER_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ORDER_INFO_CUSTOMER.SelectionChanged
        Dim rows As Integer

        With DG_ADD_EDIT_ORDER_INFO_CUSTOMER
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        rows = .CurrentRow.Index
                        txtORDER_ID.Text = .Item(0, rows).Value
                        txtCUSTOMER_NAME.Text = .Item(1, rows).Value
                        txtPROVINCE.Text = .Item(2, rows).Value
                        txtCITY.Text = .Item(3, rows).Value
                        txtADDRESS.Text = .Item(4, rows).Value
                        txtHP.Text = .Item(5, rows).Value
                        txtEMAIL.Text = .Item(6, rows).Value
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

            With DG_ADD_EDIT_ORDER_INFO_CUSTOMER
                If rdORDER_ID.Checked = True Then
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("ORDER_ID").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("ORDER_ID")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            txtORDER_ID.Text = rows.Cells.Item(0).Value
                            txtCUSTOMER_NAME.Text = rows.Cells.Item(1).Value
                            txtPROVINCE.Text = rows.Cells.Item(2).Value
                            txtCITY.Text = rows.Cells.Item(3).Value
                            txtADDRESS.Text = rows.Cells.Item(4).Value
                            txtHP.Text = rows.Cells.Item(5).Value
                            txtEMAIL.Text = rows.Cells.Item(6).Value
                            Exit For

                        End If
                    Next
                Else
                    For Each rows As DataGridViewRow In .Rows
                        If Strings.Left(rows.Cells.Item("CUSTOMER_NAME").Value, len_search_kode) = search_kode Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("CUSTOMER_NAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            txtORDER_ID.Text = rows.Cells.Item(0).Value
                            txtCUSTOMER_NAME.Text = rows.Cells.Item(1).Value
                            txtPROVINCE.Text = rows.Cells.Item(2).Value
                            txtCITY.Text = rows.Cells.Item(3).Value
                            txtADDRESS.Text = rows.Cells.Item(4).Value
                            txtHP.Text = rows.Cells.Item(5).Value
                            txtEMAIL.Text = rows.Cells.Item(6).Value
                            Exit For
                        End If
                    Next
                End If
            End With
        End If
    End Sub
End Class