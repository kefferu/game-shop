Public Class form_view_order
    Dim string_kode_game, string_order_id As String

    Sub SHOW_TABLE_ORDER_INFO_ITEM()
        sql_command = "ORDER_ID ='" & string_order_id & "'"
        View_order_info_item.RowFilter = sql_command
        DG_VIEW_ORDER_ORDER_INFO_ITEM.DataSource = View_order_info_item
    End Sub

    Sub SHOW_TABLE_ORDER_INFO_CUSTOMER()
        sql_command = "ORDER_ID ='" & string_order_id & "'"
        view_order_info_customer.RowFilter = sql_command
        DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.DataSource = view_order_info_customer
    End Sub

    Sub SHOW_TABLE_ORDER_GAME_INFO()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_order_game_info.RowFilter = sql_command
        DG_VIEW_ORDER_GAME_INFO.DataSource = view_order_game_info
    End Sub

   

    Private Sub DG_VIEW_ORDER_ORDER_INFO_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_VIEW_ORDER_ORDER_INFO.SelectionChanged
        Dim rows As Integer

        With DG_VIEW_ORDER_ORDER_INFO
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then

                        string_order_id = .Item(0, rows).Value
                        Call SHOW_TABLE_ORDER_INFO_ITEM()
                        Call SHOW_TABLE_ORDER_INFO_CUSTOMER()
                        
                    Else
                        DG_VIEW_ORDER_ORDER_INFO_ITEM.DataSource = Nothing
                        DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.DataSource = Nothing
                        DG_VIEW_ORDER_GAME_INFO.DataSource = Nothing

                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With
    End Sub

    

    Private Sub DG_VIEW_ORDER_ORDER_INFO_ITEM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_VIEW_ORDER_ORDER_INFO_ITEM.SelectionChanged
        Dim rows As Integer

        With DG_VIEW_ORDER_ORDER_INFO_ITEM
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        string_kode_game = .Item(1, rows).Value
                        Call SHOW_TABLE_ORDER_GAME_INFO()
                    Else
                        DG_VIEW_ORDER_GAME_INFO.DataSource = Nothing
               

                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        DG_VIEW_ORDER_ORDER_INFO.DataSource = Nothing
        DG_VIEW_ORDER_ORDER_INFO_ITEM.DataSource = Nothing
        DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.DataSource = Nothing
        DG_VIEW_ORDER_GAME_INFO.DataSource = Nothing
        Me.Hide()
        form_Main.ToolStripORDERxVIEWORDER.Enabled = True
    End Sub

    Private Sub txtSEARCH_KODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSEARCH_KODE.TextChanged
        If txtSEARCH_KODE.Text <> "" Then
            Dim search_kode As String = txtSEARCH_KODE.Text
            Dim len_search_kode As Integer = Len(search_kode)

            With DG_VIEW_ORDER_ORDER_INFO
                If rdORDER_ID.Checked = True Then
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("ORDER_ID").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("ORDER_ID")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                           Exit For
                        End If
                    Next
                Else
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("CUSTOMER_NAME").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("CUSTOMER_NAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            Exit For
                        End If
                    Next
                End If
            End With
        End If
    End Sub


End Class