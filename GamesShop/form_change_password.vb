Public Class form_change_password
    Dim id, old_password, new_password As String

    Sub RELOAD_FORM_WITH_FOCUS()
        txtID.Text = ""
        txtNEW_PASSWORD.Text = ""
        txtOLD_PASSWORD.Text = ""
        txtID.Focus()
    End Sub

    Sub RELOAD_FORM_WITHOUT_FOCUS()
        txtID.Text = ""
        txtNEW_PASSWORD.Text = ""
        txtOLD_PASSWORD.Text = ""

    End Sub
    Sub CEK_ACCOUNT()
        table_login.Clear()
        login_adapter = New OleDb.OleDbDataAdapter("SELECT ID FROM LOGIN WHERE ID ='" & LCase(txtID.Text) & "'", conn)
        login_adapter.Fill(table_login)

    End Sub

    Sub CEK_ID_AND_OLD_PASSWORD()

        login_command = New OleDb.OleDbCommand("SELECT * FROM LOGIN WHERE ID ='" & LCase(txtID.Text) & "'", conn)
        login_reader = login_command.ExecuteReader
        login_reader.Read()
        id = login_reader.Item("ID")
        old_password = login_reader.Item("PASSWORDS")
    End Sub

    Sub CHANGE_PASSWORD()
        If txtNEW_PASSWORD.Text <> "" Then

            login_command = New OleDb.OleDbCommand("UPDATE LOGIN SET PASSWORDS = '" & txtNEW_PASSWORD.Text & "' WHERE ID = '" & LCase(txtID.Text) & "'", conn)
            login_command.ExecuteNonQuery()
            MessageBox.Show("PASSWORD CHANGE SUCCESFUL", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call RELOAD_FORM_WITH_FOCUS()
        Else
            MessageBox.Show("PLEASE FILL THE NEW PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNEW_PASSWORD.Focus()
        End If
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call CEK_ACCOUNT()
        If table_login.Rows.Count <= 0 Then
                MessageBox.Show("ACCOUNT DOESN'T EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call RELOAD_FORM_WITH_FOCUS()
                Exit Sub
            End If

        Call CEK_ID_AND_OLD_PASSWORD()
        If LCase(txtID.Text) = id And txtOLD_PASSWORD.Text = old_password Then
            Call CHANGE_PASSWORD()
        Else
            MessageBox.Show("CHANGE PASSWORD FAILED (ID/OLD PASSWORD MIGHT BE WRONG)", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOLD_PASSWORD.Text = ""
            txtNEW_PASSWORD.Text = ""
            txtID.Focus()
        End If
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Call RELOAD_FORM_WITHOUT_FOCUS()
        Me.Hide()
        form_login.Show()

    End Sub

    Private Sub chSHOW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSHOW.CheckedChanged
        If chSHOW.Checked = True Then
            txtOLD_PASSWORD.PasswordChar = ""
            txtNEW_PASSWORD.PasswordChar = ""
        Else
            txtOLD_PASSWORD.PasswordChar = "*"
            txtNEW_PASSWORD.PasswordChar = "*"
        End If
    End Sub

   
End Class