Public Class form_transaction_purchase_history
    Dim string_code, string_kode_game As String

    Sub SHOW_TABLE_PURCHASE_HISTORY_ITEM()
        sql_command = "CODE ='" & string_code & "'"
        view_purchase_history_item.RowFilter = sql_command
        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.DataSource = view_purchase_history_item
    End Sub

    Sub SHOW_TABLE_PURCHASE_HISTORY_GAME_INFO()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_purchase_history_game_info.RowFilter = sql_command
        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.DataSource = view_purchase_history_game_info
    End Sub



    Private Sub DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_PURCHASE_HISTORY_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.SelectionChanged
        Dim rows As Integer

        With DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then

                        string_code = .Item(0, rows).Value
                        Call SHOW_TABLE_PURCHASE_HISTORY_ITEM()

                    Else
                        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.DataSource = Nothing
                        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.DataSource = Nothing


                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With
    End Sub



    Private Sub DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.SelectionChanged
        Dim rows As Integer

        With DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        string_kode_game = .Item(1, rows).Value
                        Call SHOW_TABLE_PURCHASE_HISTORY_GAME_INFO()
                    Else
                        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.DataSource = Nothing


                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.DataSource = Nothing
        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.DataSource = Nothing
        DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.DataSource = Nothing

        Me.Hide()
        form_Main.ToolStripTRANSACTIONxHISTORY.Enabled = True
    End Sub

    Private Sub txtSEARCH_KODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSEARCH_KODE.TextChanged
        If txtSEARCH_KODE.Text <> "" Then
            Dim search_kode As String = txtSEARCH_KODE.Text
            Dim len_search_kode As Integer = Len(search_kode)

            With DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY

                For Each rows As DataGridViewRow In .Rows
                    If StrComp(Strings.Left(rows.Cells.Item("CODE").Value, len_search_kode), search_kode, 1) = 0 Then
                        'SET FOCUS
                        .CurrentCell = rows.Cells("CODE")
                        'HIGHLIGHT THE ROWS
                        rows.Selected = True
                            Exit For
                    End If
                Next
            End With
        End If
    End Sub

    Private Sub form_transaction_purchase_history_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class