<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_change_password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOLD_PASSWORD = New System.Windows.Forms.TextBox()
        Me.txtNEW_PASSWORD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chSHOW = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OLD PASSWORD"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(125, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'txtOLD_PASSWORD
        '
        Me.txtOLD_PASSWORD.Location = New System.Drawing.Point(125, 49)
        Me.txtOLD_PASSWORD.Name = "txtOLD_PASSWORD"
        Me.txtOLD_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOLD_PASSWORD.Size = New System.Drawing.Size(100, 20)
        Me.txtOLD_PASSWORD.TabIndex = 3
        '
        'txtNEW_PASSWORD
        '
        Me.txtNEW_PASSWORD.Location = New System.Drawing.Point(125, 75)
        Me.txtNEW_PASSWORD.Name = "txtNEW_PASSWORD"
        Me.txtNEW_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNEW_PASSWORD.Size = New System.Drawing.Size(100, 20)
        Me.txtNEW_PASSWORD.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NEW PASSWORD"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chSHOW)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNEW_PASSWORD)
        Me.GroupBox1.Controls.Add(Me.txtOLD_PASSWORD)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(29, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHANGE PASSWORD"
        '
        'chSHOW
        '
        Me.chSHOW.AutoSize = True
        Me.chSHOW.Location = New System.Drawing.Point(231, 78)
        Me.chSHOW.Name = "chSHOW"
        Me.chSHOW.Size = New System.Drawing.Size(60, 17)
        Me.chSHOW.TabIndex = 9
        Me.chSHOW.Text = "SHOW"
        Me.chSHOW.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(87, 152)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 37)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.Location = New System.Drawing.Point(179, 152)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(75, 37)
        Me.btnCANCEL.TabIndex = 8
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'form_change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(344, 205)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_change_password"
        Me.Text = "CHANGE PASSWORD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtOLD_PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents txtNEW_PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents chSHOW As System.Windows.Forms.CheckBox
End Class
