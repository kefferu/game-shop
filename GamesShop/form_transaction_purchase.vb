
Public Class form_transaction_purchase
    Dim string_kode_game, string_game_name As String
    Dim via As String
    Dim no_order_print As String

    'parameter for sub take the kode,game name , quantity ()
    Dim checking_char As String
    Dim checking_kode As String
    Dim checking_name As String
    Dim checking_quantity As String
    Dim start_from_left As Integer
    Dim until_the_end_of_name As Integer
    Dim until_the_end_of_quantity As Integer
    Dim crop_from_left As Integer
    Dim total_symbol As Integer
    'parameter for sub take the kode,game name , quantity ()

    'parameter for each item in lstboxITEM_LIST
    Dim item As String
    'parameter for each item in lstboxITEM_LIST

    Sub PREVIEW()
        Dim STRUCK_DOCUMENT As Drawing.Printing.PrintDocument
        STRUCK_DOCUMENT = New Drawing.Printing.PrintDocument()
        STRUCK_DOCUMENT.DocumentName = "STRUCK PREVIEW"
        AddHandler STRUCK_DOCUMENT.PrintPage, AddressOf Me.PRINT_STRUCK

        STRUCK_PREVIEW.Document = STRUCK_DOCUMENT
        STRUCK_PREVIEW.ShowDialog()


    End Sub

    Private Sub PRINT_STRUCK(ByVal sender As Object, ByVal e As Drawing.Printing.PrintPageEventArgs)
        Dim MyPen As Pen = New Pen(Color.Black, 3)
        e.Graphics.DrawRectangle(MyPen, e.MarginBounds.X, e.MarginBounds.Y, 600, 350)
        Dim myfont As Font = New Font("Arial", 12, FontStyle.Bold)
        Dim S As String = "GamesShop"
        Dim SSize As SizeF = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + CInt(0.5 * (600 - _
                            SSize.Width)), e.MarginBounds.Y + 15)
        S = "#" & no_order_print
        SSize = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + CInt(0.5 * (600 - _
                            SSize.Width)), e.MarginBounds.Y + 40)

        e.Graphics.DrawLine(MyPen, e.MarginBounds.X, e.MarginBounds.Y + 70, e.MarginBounds.X + 600, e.MarginBounds.Y + 70)
        e.HasMorePages = False
        myfont = New Font("Arial", 9)
        Dim Y As Integer = e.MarginBounds.Y + 70
        For Each items As String In lstboxITEM_LIST.Items
            S = items
            SSize = e.Graphics.MeasureString(S, myfont)
            e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + 2, Y)
            Y += CInt(myfont.GetHeight(e.Graphics))
        Next
        e.Graphics.DrawLine(MyPen, e.MarginBounds.X, Y + 10, e.MarginBounds.X + 600, Y + 10)
        S = "VIA = " & cboVIA.Text
        SSize = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + 2, Y + 40)
        Y += CInt(myfont.GetHeight(e.Graphics))
        S = "DELIVERING FEE = " & txtDELIVERING_FEE.Text
        SSize = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + 2, Y + 50)
        Y += CInt(myfont.GetHeight(e.Graphics))
        S = "TOTAL PRICE = " & CLng(lblTOTAL_PRICE.Text) + CLng(txtDELIVERING_FEE.Text)
        SSize = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + 2, Y + 60)
        Y += CInt(myfont.GetHeight(e.Graphics))
        S = Date.Now.Date & "  " & Date.Now.ToLongTimeString
        SSize = e.Graphics.MeasureString(S, myfont)
        e.Graphics.DrawString(S, myfont, Brushes.Black, e.MarginBounds.X + 2, Y + 70)
        Y += CInt(myfont.GetHeight(e.Graphics))

    End Sub

    Sub RELOAD_TABLE_TRANSACTION_PURCHASE_HISTORY()
        table_purchase_history.Clear()
        purchase_history_adapter.Fill(table_purchase_history)
        form_transaction_purchase_history.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.DataSource = table_purchase_history
    End Sub

    Sub RELOAD_TABLE_TRANSACTION_PURCHASE_HISTORY_ITEM()
        table_purchase_history_item.Clear()
        purchase_history_item_adapter.Fill(table_purchase_history_item)
        form_transaction_purchase_history.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.DataSource = table_purchase_history_item
    End Sub


    Sub SHOW_TABLE_GAME_INFO_STOCK()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_transaction_game_info_stock.RowFilter = sql_command
        DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.DataSource = view_transaction_game_info_stock
    End Sub


    Sub SHOW_TABLE_GAME_INFO_PRICE()
        sql_command = "KODE_GAME ='" & string_kode_game & "'"
        view_transaction_game_info_price.RowFilter = sql_command
        DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.DataSource = view_transaction_game_info_price
    End Sub

    Sub REFRESH_THE_FORM()
        btnPURCHASE.Enabled = True
        cboVIA.Text = ""
        txtDELIVERING_FEE.Enabled = False
        txtDELIVERING_FEE.Text = "0"

    End Sub

    Sub TAKE_THE_KODE()
        checking_char = ""
        crop_from_left = 0
        checking_kode = ""

        'take the kode from lstbox ()
        Do Until (checking_char = " ")
            crop_from_left += 1
            checking_char = Strings.Mid(item, crop_from_left, 1)
        Loop
        checking_kode = Strings.Left(item, crop_from_left - 1)

        'take the kode from lstbox ()
    End Sub

    Sub TAKE_THE_GAME_NAME()
        checking_char = ""
        crop_from_left = 0
        checking_name = ""
        total_symbol = 0
        start_from_left = 0
        until_the_end_of_name = 0
        'take the name from lstbox ()

        Do Until (checking_char = "|") And (total_symbol = 2)
            crop_from_left += 1
            checking_char = Strings.Mid(item, crop_from_left, 1)
            If checking_char = "|" And total_symbol = 0 Then start_from_left = crop_from_left + 2
            If checking_char = "|" Then total_symbol += 1
        Loop
        until_the_end_of_name = crop_from_left - start_from_left
        checking_name = Strings.Mid(item, start_from_left, until_the_end_of_name - 1)

        'take the name from lstbox ()
    End Sub

    Sub TAKE_THE_QUANTITY()
        checking_char = ""
        crop_from_left = 0
        checking_quantity = ""
        start_from_left = 0
        until_the_end_of_quantity = 0
        'take the quantity from lstbox ()

        Do Until (checking_char = "=")
            crop_from_left += 1
            checking_char = Strings.Mid(item, crop_from_left, 1)
            If checking_char = "X" Then start_from_left = crop_from_left + 2
        Loop
        until_the_end_of_quantity = crop_from_left - start_from_left
        checking_quantity = Strings.Mid(item, start_from_left, until_the_end_of_quantity - 1)

        'take the quantity from lstbox ()
    End Sub

    Sub RELOAD_TABLE_GAME_INFO_STOCK()
        table_game_info_stock.Clear()
        table_view_game_info_stock.Clear()
        table_transaction_game_info_stock.Clear()
        game_info_stock_adapter.Fill(table_game_info_stock)
        game_info_stock_adapter.Fill(table_view_game_info_stock)
        game_info_stock_adapter.Fill(table_transaction_game_info_stock)
        form_add_edit_item_Game_info_stock.DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.DataSource = table_game_info_stock
    End Sub

   

   
    Private Sub txtSEARCH_KODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSEARCH_KODE.TextChanged
        If txtSEARCH_KODE.Text <> "" Then
            Dim search_kode As String = txtSEARCH_KODE.Text
            Dim len_search_kode As Integer = Len(search_kode)

            With DG_TRANSACTION_PURCHASE_GAME_INFO
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

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Hide()
        Call REFRESH_THE_FORM()
        form_Main.ToolStripTRANSACTIONxPURCHASE.Enabled = True
    End Sub



    Private Sub DG_TRANSACTION_PURCHASE_GAME_INFO_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_TRANSACTION_PURCHASE_GAME_INFO.SelectionChanged
        Dim rows As Integer

        With DG_TRANSACTION_PURCHASE_GAME_INFO
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        string_kode_game = .Item(0, rows).Value
                        Call SHOW_TABLE_GAME_INFO_PRICE()
                        Call SHOW_TABLE_GAME_INFO_STOCK()
                    Else
                        DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.DataSource = Nothing
                        DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.DataSource = Nothing
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("NO DATA IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End With
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        Dim item_list_kode_game, item_list_game_name, item_list_region, ITEM_LIST_PLATFORM As String
        Dim item_list_quantity As Integer = txtQUANTITY.Text
        Dim item_list_price As Long
        Dim total_price As Long
        Try
            With DG_TRANSACTION_PURCHASE_GAME_INFO
                item_list_kode_game = .CurrentRow.Cells("KODE_GAME").Value
                item_list_game_name = .CurrentRow.Cells("GAME_NAME").Value
                item_list_region = .CurrentRow.Cells("REGION").Value
                ITEM_LIST_PLATFORM = .CurrentRow.Cells("PLATFORM").Value
            End With

            With DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE
                item_list_price = .CurrentRow.Cells("PRICE").Value
            End With


            lstboxITEM_LIST.Items.Add(item_list_kode_game & " | " & item_list_game_name & " | " & ITEM_LIST_PLATFORM & " | " & item_list_region & " | " & _
                                      item_list_price & " X " & item_list_quantity & " = " & item_list_price * item_list_quantity)

            total_price = CLng(lblTOTAL_PRICE.Text) + (item_list_price * item_list_quantity)
            lblTOTAL_PRICE.Text = total_price
        Catch EX As Exception
            MessageBox.Show("DATA ITEM IS NOT COMPLETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtQUANTITY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQUANTITY.TextChanged
        If txtQUANTITY.Text = "" Then txtQUANTITY.Text = 1

    End Sub

    Private Sub form_transaction_purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Try
            If lstboxITEM_LIST.SelectedItem IsNot Nothing Then
                Dim checking_char As String = ""
                Dim crop_from_left As Integer
                Dim checking_total_price As Long
                Dim total_price As Long = lblTOTAL_PRICE.Text

                'take the total price from lstbox ()
                crop_from_left = 0
                Do Until (checking_char = "=")
                    crop_from_left += 1
                    checking_char = Strings.Mid(lstboxITEM_LIST.SelectedItem, crop_from_left, 1)
                Loop
                checking_total_price = Strings.Right(lstboxITEM_LIST.SelectedItem, Len(lstboxITEM_LIST.SelectedItem) - crop_from_left - 1)
                'take the total price from lstbox ()

                total_price = total_price - checking_total_price
                lblTOTAL_PRICE.Text = total_price
                lstboxITEM_LIST.Items.Remove(lstboxITEM_LIST.SelectedItem)

            End If

        Catch ex As Exception
            MessageBox.Show("NO ITEM IS SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub cboVIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVIA.SelectedIndexChanged
        If cboVIA.SelectedIndex = 0 Then
            via = "PICK UP ON STORE"
            btnPURCHASE.Enabled = True
            txtDELIVERING_FEE.Enabled = False
            txtDELIVERING_FEE.Text = "0"

        Else
            via = "DELIVERING"
            btnPURCHASE.Enabled = False
            txtDELIVERING_FEE.Enabled = True
            txtDELIVERING_FEE.Text = ""

        End If
    End Sub

    Private Sub btnPURCHASE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPURCHASE.Click
        Dim code_from_purchase_history_data_reader As OleDb.OleDbDataReader
        Dim code_from_purchase_history_data_command As New OleDb.OleDbCommand

        Dim quantity_from_purchase_history_item_data_command As New OleDb.OleDbCommand
        Dim stock_from_game_info_stock_data_command As New OleDb.OleDbCommand
        Dim checking_from_purchase_history_item_data_command As New OleDb.OleDbCommand
        Dim checking_from_game_info_stock_data_command As New OleDb.OleDbCommand

        Dim quantity_from_purchase_history_item_data_reader As OleDb.OleDbDataReader
        Dim stock_from_game_info_stock_data_reader As OleDb.OleDbDataReader
        Dim checking_from_purchase_history_item_data_reader As OleDb.OleDbDataReader
        Dim checking_from_game_info_stock_data_reader As OleDb.OleDbDataReader

        Dim stock_remaining As Integer

        'insert the data into table PURCHASE_HISTORY()
        Try



            sql_command = "INSERT INTO PURCHASE_HISTORY (PURCHASE_DATE,PURCHASE_TIME,TOTAL_PRICE,VIA)"
            sql_command = sql_command + "VALUES('" & Date.Now.Date & "','" & Date.Now.ToLongTimeString & "','" & CLng(lblTOTAL_PRICE.Text) + CLng(txtDELIVERING_FEE.Text) & "','" _
             & cboVIA.Text & "')"

            With purchase_history_command
                .CommandText = sql_command
                .Connection = conn
                .ExecuteNonQuery()
            End With
            'insert the data into table PURCHASE_HISTORY()

            'insert the data into table PURCHASE_HISTORY_ITEM()

            With code_from_purchase_history_data_command
                .CommandText = "SELECT CODE FROM PURCHASE_HISTORY WHERE PURCHASE_TIME = '" & Date.Now.ToLongTimeString & "'"
                .Connection = conn
                code_from_purchase_history_data_reader = code_from_purchase_history_data_command.ExecuteReader
                code_from_purchase_history_data_reader.Read()
                no_order_print = code_from_purchase_history_data_reader.Item("CODE")
            End With



            For Each Me.item In lstboxITEM_LIST.Items
                Call TAKE_THE_KODE()
                Call TAKE_THE_GAME_NAME()
                Call TAKE_THE_QUANTITY()
                sql_command = "INSERT INTO PURCHASE_HISTORY_ITEM (CODE,KODE_GAME,GAME_NAME,QUANTITY)"
                sql_command = sql_command + "VALUES('" & code_from_purchase_history_data_reader.Item("CODE") & "','" & checking_kode & "','" & checking_name & "','" _
                 & checking_quantity & "')"

                With purchase_history_item_command
                    .CommandText = sql_command
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
            Next
            'insert the data into table PURCHASE_HISTORY_ITEM


            'minus the stock from GAME_INFO_STOCK()
            With quantity_from_purchase_history_item_data_command
                .CommandText = "SELECT KODE_GAME,QUANTITY FROM PURCHASE_HISTORY_ITEM WHERE CODE = '" & code_from_purchase_history_data_reader.Item("CODE") & "'"
                .Connection = conn
                quantity_from_purchase_history_item_data_reader = .ExecuteReader
            End With

            'checking if the stock enough
            With checking_from_purchase_history_item_data_command
                .CommandText = "SELECT KODE_GAME,QUANTITY FROM PURCHASE_HISTORY_ITEM WHERE CODE = '" & code_from_purchase_history_data_reader.Item("CODE") & "'"
                .Connection = conn
                checking_from_purchase_history_item_data_reader = .ExecuteReader
            End With

            While checking_from_purchase_history_item_data_reader.Read()
                With checking_from_game_info_stock_data_command
                    .CommandText = "SELECT * FROM GAME_INFO_STOCK WHERE KODE_GAME = '" & checking_from_purchase_history_item_data_reader.Item("KODE_GAME") & "'"
                    .Connection = conn
                    checking_from_game_info_stock_data_reader = .ExecuteReader

                End With

                checking_from_game_info_stock_data_reader.Read()
                stock_remaining = checking_from_game_info_stock_data_reader.Item("STOCK") - checking_from_purchase_history_item_data_reader.Item("QUANTITY")
                If stock_remaining < 0 Then
                    With purchase_history_command
                        .CommandText = "DELETE FROM PURCHASE_HISTORY WHERE CODE =" & code_from_purchase_history_data_reader.Item("CODE")
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With

                    With purchase_history_item_command
                        .CommandText = "DELETE FROM PURCHASE_HISTORY_ITEM WHERE CODE ='" & code_from_purchase_history_data_reader.Item("CODE") & "'"
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("cannot complete the purchase because stock is not enough", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End If
                checking_from_game_info_stock_data_reader.Close()
            End While
            'checking if the stock enough


            While quantity_from_purchase_history_item_data_reader.Read()
                With stock_from_game_info_stock_data_command
                    .CommandText = "SELECT * FROM GAME_INFO_STOCK WHERE KODE_GAME = '" & quantity_from_purchase_history_item_data_reader.Item("KODE_GAME") & "'"
                    .Connection = conn
                    stock_from_game_info_stock_data_reader = .ExecuteReader

                End With

                stock_from_game_info_stock_data_reader.Read()
                stock_remaining = stock_from_game_info_stock_data_reader.Item("STOCK") - quantity_from_purchase_history_item_data_reader.Item("QUANTITY")
                If stock_remaining >= 0 Then

                    With game_info_stock_command
                        .CommandText = "UPDATE GAME_INFO_STOCK SET STOCK = " & stock_remaining & " WHERE KODE_GAME = '" & stock_from_game_info_stock_data_reader.Item("KODE_GAME") & "'"
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With

                    Call RELOAD_TABLE_GAME_INFO_STOCK()

                End If
                stock_from_game_info_stock_data_reader.Close()
            End While
            'minus the stock from GAME_INFO_STOCK()
            Call RELOAD_TABLE_TRANSACTION_PURCHASE_HISTORY()
            Call RELOAD_TABLE_TRANSACTION_PURCHASE_HISTORY_ITEM()
            MessageBox.Show("PURCHASE COMPLETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call PREVIEW()
            Call REFRESH_THE_FORM()
            lstboxITEM_LIST.Items.Clear()
            lblTOTAL_PRICE.Text = "0"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtDELIVERING_FEE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDELIVERING_FEE.TextChanged
        If cboVIA.Text = "DELIVERING" Then
            If txtDELIVERING_FEE.Text = "" Then
                btnPURCHASE.Enabled = False
            Else
                btnPURCHASE.Enabled = True
            End If


        End If
    End Sub
End Class