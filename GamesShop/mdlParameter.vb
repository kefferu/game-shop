Module mdlParameter
    Public conn As New OleDb.OleDbConnection
    Public conn_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = GAME.accdb"

    Public game_info_adapter As New OleDb.OleDbDataAdapter
    Public game_info_supplier_adapter As New OleDb.OleDbDataAdapter
    Public game_info_author_adapter As New OleDb.OleDbDataAdapter
    Public game_info_stock_adapter As New OleDb.OleDbDataAdapter
    Public game_info_price_adapter As New OleDb.OleDbDataAdapter
    Public order_info_adapter As New OleDb.OleDbDataAdapter
    Public order_info_item_adapter As New OleDb.OleDbDataAdapter
    Public order_info_customer_adapter As New OleDb.OleDbDataAdapter
    Public purchase_history_adapter As New OleDb.OleDbDataAdapter
    Public purchase_history_item_adapter As New OleDb.OleDbDataAdapter
    Public login_adapter As New OleDb.OleDbDataAdapter

    Public game_info_command As New OleDb.OleDbCommand
    Public game_info_supplier_command As New OleDb.OleDbCommand
    Public game_info_author_command As New OleDb.OleDbCommand
    Public game_info_stock_command As New OleDb.OleDbCommand
    Public game_info_price_command As New OleDb.OleDbCommand
    Public order_info_command As New OleDb.OleDbCommand
    Public order_info_item_command As New OleDb.OleDbCommand
    Public order_info_customer_command As New OleDb.OleDbCommand
    Public purchase_history_command As New OleDb.OleDbCommand
    Public purchase_history_item_command As New OleDb.OleDbCommand
    Public login_command As New OleDb.OleDbCommand

    Public table_game_info As New DataTable
    Public table_game_info_supplier As New DataTable
    Public table_game_info_author As New DataTable
    Public table_game_info_stock As New DataTable
    Public table_game_info_price As New DataTable
    Public table_order_info As New DataTable
    Public table_order_info_item As New DataTable
    Public table_order_info_customer As New DataTable
    Public table_purchase_history As New DataTable
    Public table_purchase_history_item As New DataTable
    Public table_login As New DataTable

    Public table_view_game_info As New DataTable
    Public table_view_game_info_supplier As New DataTable
    Public table_view_game_info_author As New DataTable
    Public table_view_game_info_stock As New DataTable
    Public table_view_game_info_price As New DataTable
    Public table_view_order_info As New DataTable
    Public table_view_order_info_item As New DataTable
    Public table_view_order_info_customer As New DataTable
    Public table_view_order_game_info As New DataTable
    Public table_view_purchase_history_game_info As New DataTable

    Public table_transaction_game_info_stock As New DataTable
    Public table_transaction_game_info_price As New DataTable
    Public table_transaction_lstbox_delete_item_game_info_price As New DataTable

    Public view_game_info As New DataView
    Public view_game_info_supplier As New DataView
    Public view_game_info_author As New DataView
    Public view_game_info_stock As New DataView
    Public view_game_info_price As New DataView
    Public view_order_info As New DataView
    Public View_order_info_item As New DataView
    Public view_order_info_customer As New DataView
    Public view_order_game_info As New DataView
    Public view_purchase_history As New DataView
    Public view_purchase_history_item As New DataView
    Public view_purchase_history_game_info As New DataView

    Public view_transaction_game_info_stock As New DataView
    Public view_transaction_game_info_price As New DataView

    Public sql_command As String

    Public select_game_info As String = "SELECT * FROM GAME_INFO"
    Public select_game_info_supplier As String = "SELECT * FROM GAME_INFO_SUPPLIER"
    Public select_game_info_author As String = "SELECT * FROM GAME_INFO_AUTHOR"
    Public select_game_info_stock As String = "SELECT * FROM GAME_INFO_STOCK"
    Public select_game_info_price As String = "SELECT * FROM GAME_INFO_PRICE"
    Public select_order_info As String = "SELECT * FROM ORDER_INFO"
    Public select_order_info_item As String = "SELECT * FROM ORDER_INFO_ITEM"
    Public select_order_info_customer As String = "SELECT * FROM ORDER_INFO_CUSTOMER"
    Public select_purchase_history As String = "SELECT * FROM PURCHASE_HISTORY"
    Public select_purchase_history_item As String = "SELECT * FROM PURCHASE_HISTORY_ITEM"
    Public select_login As String = "SELECT * FROM LOGIN"

    Public login_reader As OleDb.OleDbDataReader
    Public platform_reader As OleDb.OleDbDataReader
    Public region_reader As OleDb.OleDbDataReader
    Public languages_reader As OleDb.OleDbDataReader
    Public supplier_reader As OleDb.OleDbDataReader
    Public publisher_reader As OleDb.OleDbDataReader
    Public developer_reader As OleDb.OleDbDataReader


    Public platform_command As OleDb.OleDbCommand
    Public region_command As OleDb.OleDbCommand
    Public languages_command As OleDb.OleDbCommand
    Public supplier_command As OleDb.OleDbCommand
    Public publisher_command As OleDb.OleDbCommand
    Public developer_command As OleDb.OleDbCommand
End Module
