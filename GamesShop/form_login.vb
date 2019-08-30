Public Class form_login
    Dim id, password As String
    Sub RELOAD_FORM_WITH_FOCUS()
        txtID.Text = ""
        txtPASSWORD.Text = ""

        txtID.Focus()
    End Sub

    Sub RELOAD_FORM_WITHOUT_FOCUS()
        txtID.Text = ""
        txtPASSWORD.Text = ""


    End Sub
    Public Sub Connection()
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = conn_string
                .Open()
            End With

        Catch ex As Exception
            MessageBox.Show("Unable to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Sub CEK_ACCOUNT()
        table_login.Clear()
        login_adapter = New OleDb.OleDbDataAdapter("SELECT ID FROM LOGIN WHERE ID ='" & LCase(txtID.Text) & "'", conn)
        login_adapter.Fill(table_login)
        
    End Sub

    Sub CEK_ID_AND_PASSWORD()

        login_command = New OleDb.OleDbCommand("SELECT * FROM LOGIN WHERE ID ='" & LCase(txtID.Text) & "'", conn)
        login_reader = login_command.ExecuteReader
        login_reader.Read()
        id = login_reader.Item("ID")
        password = login_reader.Item("PASSWORDS")
        If LCase(txtID.Text) = id And txtPASSWORD.Text = password Then
            MessageBox.Show("LOGIN SUCCESFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPASSWORD.Text = ""
            Me.Hide()
            form_Main.ToolStripLOGOUT.Text = id
            form_Main.Show()
        Else
            MessageBox.Show("LOGIN FAILED (ID/PASSWORD MIGHT BE WRONG)", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPASSWORD.Text = ""
            txtID.Focus()
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call CEK_ACCOUNT()
        If table_login.Rows.Count <= 0 Then
            MessageBox.Show("ACCOUNT DOESN'T EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call RELOAD_FORM_WITH_FOCUS()
            Exit Sub
        End If
        Call CEK_ID_AND_PASSWORD()
    End Sub

    Private Sub form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()

    End Sub

    Private Sub chSHOW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSHOW.CheckedChanged
        If chSHOW.Checked = True Then
            txtPASSWORD.PasswordChar = ""
        Else
            txtPASSWORD.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        conn.Close()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call RELOAD_FORM_WITHOUT_FOCUS()
        Me.Hide()
        form_change_password.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class