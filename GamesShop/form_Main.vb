Imports System.Data.OleDb
Public Class form_Main
    Private Sub ToolStripITEMxADDITEMxGAMEINFO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxADDEDITITEMxGAMEINFO.Click
        Try
            form_add_edit_item_Game_info.cboLANGUAGE.Items.Clear()
            languages_command = New OleDbCommand("SELECT * FROM LANGUAGES", conn)
            languages_reader = languages_command.ExecuteReader
            While languages_reader.Read
                form_add_edit_item_Game_info.cboLANGUAGE.Items.Add(languages_reader.Item("LANGUAGES"))
            End While

            form_add_edit_item_Game_info.cboREGION.Items.Clear()
            region_command = New OleDbCommand("SELECT * FROM REGIONS", conn)
            region_reader = region_command.ExecuteReader
            While region_reader.Read
                form_add_edit_item_Game_info.cboREGION.Items.Add(region_reader.Item("REGIONS"))
            End While

            form_add_edit_item_Game_info.cboPLATFORM.Items.Clear()
            platform_command = New OleDbCommand("SELECT * FROM PLATFORM", conn)
            platform_reader = platform_command.ExecuteReader
            While platform_reader.Read
                form_add_edit_item_Game_info.cboPLATFORM.Items.Add(platform_reader.Item("PLATFORM"))
            End While

            table_game_info.Clear()
            game_info_adapter = New OleDb.OleDbDataAdapter(select_game_info, conn)
            game_info_adapter.Fill(table_game_info)
            form_add_edit_item_Game_info.DG_ADD_EDIT_ITEM_GAME_INFO.DataSource = table_game_info
            form_add_edit_item_Game_info.Show()
            ToolStripITEMxADDEDITITEMxGAMEINFO.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToolStripITEMxADDEDITITEMxGAMEINFOSUPPLIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxADDEDITITEMxGAMEINFOSUPPLIER.Click
        Try
            form_add_edit_item_Game_info_supplier.cboSUPPLIER.Items.Clear()
            supplier_command = New OleDbCommand("SELECT * FROM SUPPLIER", conn)
            supplier_reader = supplier_command.ExecuteReader
            While supplier_reader.Read
                form_add_edit_item_Game_info_supplier.cboSUPPLIER.Items.Add(supplier_reader.Item("SUPPLIER"))
            End While

            table_game_info_supplier.Clear()
            game_info_supplier_adapter = New OleDb.OleDbDataAdapter(select_game_info_supplier, conn)
            game_info_supplier_adapter.Fill(table_game_info_supplier)
            form_add_edit_item_Game_info_supplier.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.DataSource = table_game_info_supplier
            form_add_edit_item_Game_info_supplier.Show()
            ToolStripITEMxADDEDITITEMxGAMEINFOSUPPLIER.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripITEMxADDEDITITEMxGAMEINFOAUTHOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxADDEDITITEMxGAMEINFOAUTHOR.Click
        Try

            form_add_edit_item_Game_info_author.cboPUBLISHER.Items.Clear()
            publisher_command = New OleDbCommand("SELECT * FROM PUBLISHER", conn)
            publisher_reader = publisher_command.ExecuteReader
            While publisher_reader.Read
                form_add_edit_item_Game_info_author.cboPUBLISHER.Items.Add(publisher_reader.Item("PUBLISHER"))
            End While

            form_add_edit_item_Game_info_author.cboDEVELOPER.Items.Clear()
            developer_command = New OleDbCommand("SELECT * FROM DEVELOPER", conn)
            developer_reader = developer_command.ExecuteReader
            While developer_reader.Read
                form_add_edit_item_Game_info_author.cboDEVELOPER.Items.Add(developer_reader.Item("DEVELOPER"))
            End While


            table_game_info_author.Clear()
            game_info_author_adapter = New OleDb.OleDbDataAdapter(select_game_info_author, conn)
            game_info_author_adapter.Fill(table_game_info_author)
            form_add_edit_item_Game_info_author.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.DataSource = table_game_info_author
            form_add_edit_item_Game_info_author.Show()
            ToolStripITEMxADDEDITITEMxGAMEINFOAUTHOR.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripITEMxADDEDITITEMxGAMEINFOSTOCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxADDEDITITEMxGAMEINFOSTOCK.Click
        Try
            table_game_info_stock.Clear()
            game_info_stock_adapter = New OleDb.OleDbDataAdapter(select_game_info_stock, conn)
            game_info_stock_adapter.Fill(table_game_info_stock)
            form_add_edit_item_Game_info_stock.DG_ADD_EDIT_ITEM_GAME_INFO_STOCK.DataSource = table_game_info_stock
            form_add_edit_item_Game_info_stock.Show()
            ToolStripITEMxADDEDITITEMxGAMEINFOSTOCK.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripITEMxADDEDITITEMxGAMEINFOPRICE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxADDEDITITEMxGAMEINFOPRICE.Click
        Try
            table_game_info_price.Clear()
            game_info_price_adapter = New OleDb.OleDbDataAdapter(select_game_info_price, conn)
            game_info_price_adapter.Fill(table_game_info_price)
            form_add_edit_item_Game_info_price.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.DataSource = table_game_info_price
            form_add_edit_item_Game_info_price.Show()
            form_add_edit_item_Game_info_price.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.DefaultCellStyle.ForeColor = Color.Black
            ToolStripITEMxADDEDITITEMxGAMEINFOPRICE.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripITEMxVIEWITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripITEMxVIEWITEM.Click
        Try
            table_view_game_info.Clear()
            table_view_game_info_author.Clear()
            table_view_game_info_supplier.Clear()
            table_view_game_info_price.Clear()
            table_view_game_info_stock.Clear()

            game_info_adapter = New OleDb.OleDbDataAdapter(select_game_info, conn)
            game_info_supplier_adapter = New OleDb.OleDbDataAdapter(select_game_info_supplier, conn)
            game_info_author_adapter = New OleDb.OleDbDataAdapter(select_game_info_author, conn)
            game_info_stock_adapter = New OleDb.OleDbDataAdapter(select_game_info_stock, conn)
            game_info_price_adapter = New OleDb.OleDbDataAdapter(select_game_info_price, conn)


            game_info_adapter.Fill(table_view_game_info)
            game_info_supplier_adapter.Fill(table_view_game_info_supplier)
            game_info_author_adapter.Fill(table_view_game_info_author)
            game_info_stock_adapter.Fill(table_view_game_info_stock)
            game_info_price_adapter.Fill(table_view_game_info_price)

            form_View_item.DG_VIEW_ITEM_GAME_INFO.DataSource = table_view_game_info

            view_game_info_author = table_view_game_info_author.DefaultView
            view_game_info_supplier = table_view_game_info_supplier.DefaultView
            view_game_info_stock = table_view_game_info_stock.DefaultView
            view_game_info_price = table_view_game_info_price.DefaultView
            form_View_item.Show()

            ToolStripITEMxVIEWITEM.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripORDERxADDEDITORDERxORDERINFO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripORDERxADDEDITORDERxORDERINFO.Click
        Try
            table_order_info.Clear()
            order_info_adapter = New OleDb.OleDbDataAdapter(select_order_info, conn)
            order_info_adapter.Fill(table_order_info)
            form_add_edit_order_info.DG_ADD_EDIT_ORDER_INFO.DataSource = table_order_info
            form_add_edit_order_info.Show()
            ToolStripORDERxADDEDITORDERxORDERINFO.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripORDERxADDEDITORDERxORDERINFOITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripORDERxADDEDITORDERxORDERINFOITEM.Click
        Try
            table_order_info_item.Clear()
            order_info_item_adapter = New OleDb.OleDbDataAdapter(select_order_info_item, conn)
            order_info_item_adapter.Fill(table_order_info_item)
            form_add_edit_order_info_item.DG_ADD_EDIT_ORDER_INFO_ITEM.DataSource = table_order_info_item
            form_add_edit_order_info_item.Show()
            ToolStripORDERxADDEDITORDERxORDERINFOITEM.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripORDERxADDEDITORDERxORDERINFOCUSTOMER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripORDERxADDEDITORDERxORDERINFOCUSTOMER.Click
        Try
            table_order_info_customer.Clear()
            order_info_customer_adapter = New OleDb.OleDbDataAdapter(select_order_info_customer, conn)
            order_info_customer_adapter.Fill(table_order_info_customer)
            form_add_edit_order_info_customer.DG_ADD_EDIT_ORDER_INFO_CUSTOMER.DataSource = table_order_info_customer
            form_add_edit_order_info_customer.Show()
            ToolStripORDERxADDEDITORDERxORDERINFOCUSTOMER.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripORDERxVIEWORDER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripORDERxVIEWORDER.Click
        Try
            table_view_order_info.Clear()
            table_view_order_info_item.Clear()
            table_view_order_info_customer.Clear()
            table_view_order_game_info.Clear()

            order_info_adapter = New OleDb.OleDbDataAdapter(select_order_info, conn)
            order_info_item_adapter = New OleDb.OleDbDataAdapter(select_order_info_item, conn)
            order_info_customer_adapter = New OleDb.OleDbDataAdapter(select_order_info_customer, conn)
            game_info_adapter = New OleDb.OleDbDataAdapter(select_game_info, conn)



            game_info_adapter.Fill(table_view_order_game_info)
            order_info_adapter.Fill(table_view_order_info)
            order_info_item_adapter.Fill(table_view_order_info_item)
            order_info_customer_adapter.Fill(table_view_order_info_customer)


            form_view_order.DG_VIEW_ORDER_ORDER_INFO.DataSource = table_view_order_info

            view_order_game_info = table_view_order_game_info.DefaultView
            view_order_info = table_view_order_info.DefaultView
            View_order_info_item = table_view_order_info_item.DefaultView
            view_order_info_customer = table_view_order_info_customer.DefaultView
            form_view_order.Show()

            ToolStripORDERxVIEWORDER.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripTRANSACTIONxPURCHASE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTRANSACTIONxPURCHASE.Click
        Try
            table_game_info.Clear()
            table_game_info_stock.Clear()
            table_game_info_price.Clear()
            table_transaction_lstbox_delete_item_game_info_price.Clear()

            purchase_history_adapter = New OleDb.OleDbDataAdapter(select_purchase_history, conn)
            purchase_history_item_adapter = New OleDb.OleDbDataAdapter(select_purchase_history_item, conn)
            game_info_adapter = New OleDb.OleDbDataAdapter(select_game_info, conn)
            game_info_stock_adapter = New OleDb.OleDbDataAdapter(select_game_info_stock, conn)
            game_info_price_adapter = New OleDb.OleDbDataAdapter(select_game_info_price, conn)

            game_info_adapter.Fill(table_game_info)
            game_info_stock_adapter.Fill(table_transaction_game_info_stock)
            game_info_price_adapter.Fill(table_transaction_game_info_price)
            game_info_price_adapter.Fill(table_transaction_lstbox_delete_item_game_info_price)

            view_transaction_game_info_stock = table_transaction_game_info_stock.DefaultView
            view_transaction_game_info_price = table_transaction_game_info_price.DefaultView


            form_transaction_purchase.DG_TRANSACTION_PURCHASE_GAME_INFO.DataSource = table_game_info
           
            form_transaction_purchase.lstboxITEM_LIST.Items.Clear()
            form_transaction_purchase.cboVIA.Text = ""
            form_transaction_purchase.txtQUANTITY.Text = "1"
            form_transaction_purchase.lblTOTAL_PRICE.Text = "0"
            form_transaction_purchase.Show()

            ToolStripTRANSACTIONxPURCHASE.Enabled = False


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripTRANSACTIONxHISTORY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTRANSACTIONxHISTORY.Click
        Try
            table_purchase_history.Clear()
            table_purchase_history_item.Clear()
            table_view_purchase_history_game_info.Clear()


            purchase_history_adapter = New OleDb.OleDbDataAdapter(select_purchase_history, conn)
            purchase_history_item_adapter = New OleDb.OleDbDataAdapter(select_purchase_history_item, conn)
            game_info_adapter = New OleDb.OleDbDataAdapter(select_game_info, conn)


            game_info_adapter.Fill(table_view_purchase_history_game_info)
            purchase_history_adapter.Fill(table_purchase_history)
            purchase_history_item_adapter.Fill(table_purchase_history_item)

            form_transaction_purchase_history.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.DataSource = table_purchase_history

            view_purchase_history = table_purchase_history.DefaultView
            view_purchase_history_item = table_purchase_history_item.DefaultView
            view_purchase_history_game_info = table_view_purchase_history_game_info.DefaultView

            form_transaction_purchase_history.Show()

            ToolStripTRANSACTIONxHISTORY.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripLOGOUTxLOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLOGOUTxLOGOUT.Click
        form_add_edit_item_Game_info.Hide()
        form_add_edit_item_Game_info_author.Hide()
        form_add_edit_item_Game_info_price.Hide()
        form_add_edit_item_Game_info_stock.Hide()
        form_add_edit_item_Game_info_supplier.Hide()

        form_add_edit_order_info.Hide()
        form_add_edit_order_info_customer.Hide()
        form_add_edit_order_info_item.Hide()

        form_transaction_purchase.Hide()
        form_transaction_purchase_history.Hide()

        form_View_item.Hide()
        form_view_order.Hide()

        ToolStripITEMxADDEDITITEMxGAMEINFO.Enabled = True
        ToolStripITEMxADDEDITITEMxGAMEINFOAUTHOR.Enabled = True
        ToolStripITEMxADDEDITITEMxGAMEINFOPRICE.Enabled = True
        ToolStripITEMxADDEDITITEMxGAMEINFOSTOCK.Enabled = True
        ToolStripITEMxADDEDITITEMxGAMEINFOSUPPLIER.Enabled = True
        ToolStripITEMxVIEWITEM.Enabled = True

        ToolStripORDERxADDEDITORDERxORDERINFO.Enabled = True
        ToolStripORDERxADDEDITORDERxORDERINFOCUSTOMER.Enabled = True
        ToolStripORDERxADDEDITORDERxORDERINFOITEM.Enabled = True
        ToolStripORDERxVIEWORDER.Enabled = True

        ToolStripTRANSACTIONxHISTORY.Enabled = True
        ToolStripTRANSACTIONxPURCHASE.Enabled = True

        Me.Hide()
        form_login.Show()


    End Sub
End Class
