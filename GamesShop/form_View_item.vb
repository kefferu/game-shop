Public Class form_View_item
    Dim string_kode_game, string_game_name As String

    Sub SHOW_TABLE_GAME_INFO_AUTHOR()
        sql_command = "GAME_NAME ='" & string_game_name & "'"
        view_game_info_author.RowFilter = sql_command
        DG_VIEW_ITEM_GAME_INFO_AUTHOR.DataSource = view_game_info_author
    End Sub

    Sub SHOW_TABLE_GAME_INFO_SUPPLIER()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_game_info_supplier.RowFilter = sql_command
        DG_VIEW_ITEM_GAME_INFO_SUPPLIER.DataSource = view_game_info_supplier
    End Sub

    Sub SHOW_TABLE_GAME_INFO_STOCK()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_game_info_stock.RowFilter = sql_command
        DG_VIEW_ITEM_GAME_INFO_STOCK.DataSource = view_game_info_stock
    End Sub

    Sub SHOW_TABLE_GAME_INFO_PRICE()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_game_info_price.RowFilter = sql_command
        DG_VIEW_ITEM_GAME_INFO_PRICE.DataSource = view_game_info_price
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        DG_VIEW_ITEM_GAME_INFO_AUTHOR.DataSource = Nothing
        DG_VIEW_ITEM_GAME_INFO_SUPPLIER.DataSource = Nothing
        DG_VIEW_ITEM_GAME_INFO_STOCK.DataSource = Nothing
        DG_VIEW_ITEM_GAME_INFO_PRICE.DataSource = Nothing
        Me.Hide()
        form_Main.ToolStripITEMxVIEWITEM.Enabled = True

    End Sub

    Private Sub DG_VIEW_ITEM_GAME_INFO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_VIEW_ITEM_GAME_INFO.Click
        
    End Sub

    Private Sub DG_VIEW_ITEM_GAME_INFO_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DG_VIEW_ITEM_GAME_INFO.MouseClick
        
    End Sub

   
  
    Private Sub DG_VIEW_ITEM_GAME_INFO_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_VIEW_ITEM_GAME_INFO.SelectionChanged
        Dim rows As Integer

        With DG_VIEW_ITEM_GAME_INFO
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        string_kode_game = .Item(0, rows).Value
                        string_game_name = .Item(1, rows).Value
                        Call SHOW_TABLE_GAME_INFO_AUTHOR()
                        Call SHOW_TABLE_GAME_INFO_PRICE()
                        Call SHOW_TABLE_GAME_INFO_STOCK()
                        Call SHOW_TABLE_GAME_INFO_SUPPLIER()
                    Else
                        DG_VIEW_ITEM_GAME_INFO_AUTHOR.DataSource = Nothing
                        DG_VIEW_ITEM_GAME_INFO_SUPPLIER.DataSource = Nothing
                        DG_VIEW_ITEM_GAME_INFO_STOCK.DataSource = Nothing
                        DG_VIEW_ITEM_GAME_INFO_PRICE.DataSource = Nothing
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

            With DG_VIEW_ITEM_GAME_INFO
                If rdKODE_GAME.Checked = True Then
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("KODE_GAME").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("KODE_GAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            Exit For
                        End If
                    Next
                Else
                    For Each rows As DataGridViewRow In .Rows
                        If StrComp(Strings.Left(rows.Cells.Item("GAME_NAME").Value, len_search_kode), search_kode, 1) = 0 Then
                            'SET FOCUS
                            .CurrentCell = rows.Cells("GAME_NAME")
                            'HIGHLIGHT THE ROWS
                            rows.Selected = True
                            Exit For
                        End If
                    Next
                End If
            End With
        End If
    End Sub

    Private Sub form_View_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSEARCH_KODE.Text = ""
    End Sub
End Class