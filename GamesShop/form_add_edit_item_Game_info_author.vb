Public Class form_add_edit_item_Game_info_author
    Dim trigger As String

    Sub RELOAD_TABLE_GAME_INFO_AUTHOR()
        table_game_info_author.Clear()
        table_view_game_info_author.Clear()
        game_info_author_adapter.Fill(table_game_info_author)
        game_info_author_adapter.Fill(table_view_game_info_author)
        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.DataSource = table_game_info_author
    End Sub

    Sub MIDDLE_OF_ADD()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtSEARCH_KODE.Enabled = False
        txtGAME_NAME.Enabled = True
        txtGAME_NAME.Text = ""

        cboPUBLISHER.Enabled = True
        cboDEVELOPER.Enabled = True

        cboPUBLISHER.Text = ""
        cboDEVELOPER.Text = ""

        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = False

        txtGAME_NAME.Focus()
        chADD_PUBLISHER.Enabled = False
        chDELETE_PUBLISHER.Enabled = False
        chADD_DEVELOPER.Enabled = False
        chDELETE_DEVELOPER.Enabled = False
    End Sub

    Sub MIDDLE_OF_EDIT()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        btnEXIT.Enabled = False

        txtGAME_NAME.Enabled = True
        txtSEARCH_KODE.Enabled = False
        cboDEVELOPER.Enabled = True
        cboPUBLISHER.Enabled = True

        txtGAME_NAME.Focus()

        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = False

        chADD_PUBLISHER.Enabled = False
        chDELETE_PUBLISHER.Enabled = False
        chADD_DEVELOPER.Enabled = False
        chDELETE_DEVELOPER.Enabled = False
    End Sub

    Sub NOT_IN_ADD_OR_EDIT()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtGAME_NAME.Enabled = False

        txtGAME_NAME.Text = ""

        cboPUBLISHER.Enabled = False
        cboDEVELOPER.Enabled = False

        cboDEVELOPER.Text = ""
        cboPUBLISHER.Text = ""

        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = True
        chADD_PUBLISHER.Enabled = True
        chDELETE_PUBLISHER.Enabled = True
        chADD_DEVELOPER.Enabled = True
        chDELETE_DEVELOPER.Enabled = True

    End Sub

    Sub AFTER_ADD_OR_EDIT_OR_DELETE()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEXIT.Enabled = True

        txtSEARCH_KODE.Enabled = True
        txtGAME_NAME.Enabled = False
        cboPUBLISHER.Enabled = False
        cboDEVELOPER.Enabled = False

        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = True
        chADD_PUBLISHER.Enabled = True
        chDELETE_PUBLISHER.Enabled = True
        chADD_DEVELOPER.Enabled = True
        chDELETE_DEVELOPER.Enabled = True

    End Sub

    Sub PUBLISHER_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtGAME_NAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboPUBLISHER.Enabled = True
        cboDEVELOPER.Text = ""
        cboPUBLISHER.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = False

        chADD_PUBLISHER.Enabled = True
        chDELETE_PUBLISHER.Enabled = True
        chADD_DEVELOPER.Enabled = False
        chDELETE_DEVELOPER.Enabled = False
       
        cboPUBLISHER.Focus()
    End Sub

    Sub PUBLISHER_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtGAME_NAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboPUBLISHER.Enabled = False
        cboPUBLISHER.Text = ""
        cboDEVELOPER.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = True
        chADD_DEVELOPER.Enabled = True
        chDELETE_DEVELOPER.Enabled = True
        
    End Sub

    Sub DEVELOPER_CHECKED()
        btnADD.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnEXIT.Enabled = False

        txtGAME_NAME.Text = ""

        txtSEARCH_KODE.Enabled = False
        cboDEVELOPER.Enabled = True
        cboDEVELOPER.Text = ""
        cboPUBLISHER.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = False

        chADD_PUBLISHER.Enabled = False
        chDELETE_PUBLISHER.Enabled = False
        chADD_DEVELOPER.Enabled = True
        chDELETE_DEVELOPER.Enabled = True

        cboDEVELOPER.Focus()
    End Sub

    Sub DEVELOPER_UNCHECKED()
        btnADD.Enabled = True
        btnEDIT.Enabled = True
        btnDELETE.Enabled = True
        btnEXIT.Enabled = True

        txtGAME_NAME.Text = ""
        txtSEARCH_KODE.Enabled = True

        cboDEVELOPER.Enabled = False
        cboPUBLISHER.Text = ""
        cboDEVELOPER.Text = ""
        DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Enabled = True
        chADD_PUBLISHER.Enabled = True
        chDELETE_PUBLISHER.Enabled = True

    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        trigger = "ADD"
        Call MIDDLE_OF_ADD()
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If txtGAME_NAME.Text = "" Or cboPUBLISHER.Text = "" Or cboDEVELOPER.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            trigger = "EDIT"
            Call MIDDLE_OF_EDIT()
        End If
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtGAME_NAME.Text = "" Or cboPUBLISHER.Text = "" Or cboDEVELOPER.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If trigger = "ADD" Then
                Try
                    sql_command = "INSERT INTO GAME_INFO_AUTHOR (GAME_NAME,PUBLISHER,DEVELOPER)"
                    sql_command = sql_command + "VALUES('" & Trim(UCase(txtGAME_NAME.Text)) & "','" & Trim(UCase(cboPUBLISHER.Text)) & "','" & Trim(UCase(cboDEVELOPER.Text)) & "')"

                    With game_info_author_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_AUTHOR()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                Try
                    sql_command = "UPDATE GAME_INFO_AUTHOR SET"
                    sql_command = sql_command & " GAME_NAME= '" & Trim(UCase(txtGAME_NAME.Text)) & "',"
                    sql_command = sql_command & " PUBLISHER = '" & Trim(UCase(cboPUBLISHER.Text)) & "',"
                    sql_command = sql_command & " DEVELOPER = '" & Trim(UCase(cboDEVELOPER.Text)) & "'"
                    sql_command = sql_command & " WHERE"
                    sql_command = sql_command & " GAME_NAME= '" & Trim(UCase(lblGAME_NAME.Text)) & "'"


                    With game_info_author_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_AUTHOR()
                    Call AFTER_ADD_OR_EDIT_OR_DELETE()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If txtGAME_NAME.Text = "" Or cboPUBLISHER.Text = "" Or cboDEVELOPER.Text = "" Then
            MessageBox.Show("No data is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    sql_command = "DELETE FROM GAME_INFO_AUTHOR WHERE GAME_NAME = '" & UCase(txtGAME_NAME.Text) & "'"


                    With game_info_author_command
                        .CommandText = sql_command
                        .Connection = conn
                        .ExecuteNonQuery()
                    End With
                    Call RELOAD_TABLE_GAME_INFO_AUTHOR()
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
        form_Main.ToolStripITEMxADDEDITITEMxGAMEINFOAUTHOR.Enabled = True

    End Sub

  Private Sub form_add_edit_item_Game_info_author_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NOT_IN_ADD_OR_EDIT()
        txtSEARCH_KODE.Text = ""
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call AFTER_ADD_OR_EDIT_OR_DELETE()
    End Sub

    Private Sub DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.SelectionChanged
        Dim rows As Integer

        With DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR
            Try
                If .CurrentRow IsNot Nothing Then
                    rows = .CurrentRow.Index

                    If Not IsDBNull(.Item(0, rows).Value) Then
                        rows = .CurrentRow.Index

                        lblGAME_NAME.Text = .Item(0, rows).Value
                        txtGAME_NAME.Text = .Item(0, rows).Value
                        cboPUBLISHER.Text = .Item(1, rows).Value
                        cboDEVELOPER.Text = .Item(2, rows).Value
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

            With DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR
                For Each rows As DataGridViewRow In .Rows
                    If StrComp(Strings.Left(rows.Cells.Item("GAME_NAME").Value, len_search_kode), search_kode, 1) = 0 Then
                        'SET FOCUS
                        .CurrentCell = rows.Cells("GAME_NAME")

                        'HIGHLIGHT THE ROWS
                        rows.Selected = True

                        lblGAME_NAME.Text = rows.Cells.Item(0).Value
                        txtGAME_NAME.Text = rows.Cells.Item(0).Value
                        cboPUBLISHER.Text = rows.Cells.Item(1).Value
                        cboDEVELOPER.Text = rows.Cells.Item(2).Value
                        Exit For
                    End If
                Next
            End With
        End If
    End Sub

    Private Sub chADD_PUBLISHER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_PUBLISHER.CheckedChanged
        If chADD_PUBLISHER.Checked = True Then
            Call PUBLISHER_CHECKED()
            chDELETE_PUBLISHER.Checked = False
        ElseIf chADD_PUBLISHER.Checked = False And chDELETE_PUBLISHER.Checked = False Then
            Call PUBLISHER_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_PUBLISHER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_PUBLISHER.CheckedChanged
        If chDELETE_PUBLISHER.Checked = True Then
            Call PUBLISHER_CHECKED()
            chADD_PUBLISHER.Checked = False
        ElseIf chADD_PUBLISHER.Checked = False And chDELETE_PUBLISHER.Checked = False Then
            Call PUBLISHER_UNCHECKED()
        End If
    End Sub

    Private Sub chADD_DEVELOPER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chADD_DEVELOPER.CheckedChanged
        If chADD_DEVELOPER.Checked = True Then
            Call DEVELOPER_CHECKED()
            chDELETE_DEVELOPER.Checked = False
        ElseIf chADD_DEVELOPER.Checked = False And chDELETE_DEVELOPER.Checked = False Then
            Call DEVELOPER_UNCHECKED()
        End If
    End Sub

    Private Sub chDELETE_DEVELOPER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDELETE_DEVELOPER.CheckedChanged
        If chDELETE_DEVELOPER.Checked = True Then
            Call DEVELOPER_CHECKED()
            chADD_DEVELOPER.Checked = False
        ElseIf chADD_DEVELOPER.Checked = False And chDELETE_DEVELOPER.Checked = False Then
            Call DEVELOPER_UNCHECKED()
        End If
    End Sub

    Private Sub cboPUBLISHER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPUBLISHER.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_PUBLISHER.Checked = True Then
                    If cboPUBLISHER.Text <> "" Then

                        publisher_command = New OleDb.OleDbCommand("DELETE FROM PUBLISHER WHERE PUBLISHER = '" & Trim(UCase(cboPUBLISHER.Text)) & "'", conn)
                        publisher_command.ExecuteNonQuery()
                        cboPUBLISHER.Items.Remove(Trim(UCase(cboPUBLISHER.Text)))

                    End If

                ElseIf chADD_PUBLISHER.Checked = True And cboPUBLISHER.Text <> "" Then
                    publisher_command = New OleDb.OleDbCommand("INSERT INTO PUBLISHER (PUBLISHER) VALUES ('" & Trim(UCase(cboPUBLISHER.Text)) & "')", conn)
                    publisher_command.ExecuteNonQuery()
                    cboPUBLISHER.Items.Add(Trim(UCase(cboPUBLISHER.Text)))
                    cboPUBLISHER.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboDEVELOPER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDEVELOPER.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If chDELETE_DEVELOPER.Checked = True Then
                    If cboDEVELOPER.Text <> "" Then

                        developer_command = New OleDb.OleDbCommand("DELETE FROM DEVELOPER WHERE DEVELOPER = '" & Trim(UCase(cboDEVELOPER.Text)) & "'", conn)
                        developer_command.ExecuteNonQuery()
                        cboDEVELOPER.Items.Remove(Trim(UCase(cboDEVELOPER.Text)))

                    End If

                ElseIf chADD_DEVELOPER.Checked = True And cboDEVELOPER.Text <> "" Then
                    developer_command = New OleDb.OleDbCommand("INSERT INTO DEVELOPER (DEVELOPER) VALUES ('" & Trim(UCase(cboDEVELOPER.Text)) & "')", conn)
                    developer_command.ExecuteNonQuery()
                    cboDEVELOPER.Items.Add(Trim(UCase(cboDEVELOPER.Text)))
                    cboDEVELOPER.Text = ""
                End If

            End If
        Catch EX As Exception
            MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
End Class