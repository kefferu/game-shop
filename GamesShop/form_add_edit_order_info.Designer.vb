<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_order_info
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbVIA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboORDER_STATUS = New System.Windows.Forms.ComboBox()
        Me.dtmORDER_DATE = New System.Windows.Forms.DateTimePicker()
        Me.txtCUSTOMER_NAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtORDER_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.DG_ADD_EDIT_ORDER_INFO = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdCUSTOMER_NAME = New System.Windows.Forms.RadioButton()
        Me.rdORDER_ID = New System.Windows.Forms.RadioButton()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ORDER_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ORDER STATUS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbVIA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboORDER_STATUS)
        Me.GroupBox1.Controls.Add(Me.dtmORDER_DATE)
        Me.GroupBox1.Controls.Add(Me.txtCUSTOMER_NAME)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 180)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORDER INFO"
        '
        'cbVIA
        '
        Me.cbVIA.FormattingEnabled = True
        Me.cbVIA.Items.AddRange(New Object() {"DELIVERING", "PICK UP ON STORE", ""})
        Me.cbVIA.Location = New System.Drawing.Point(111, 129)
        Me.cbVIA.Name = "cbVIA"
        Me.cbVIA.Size = New System.Drawing.Size(127, 21)
        Me.cbVIA.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VIA"
        '
        'cboORDER_STATUS
        '
        Me.cboORDER_STATUS.FormattingEnabled = True
        Me.cboORDER_STATUS.Items.AddRange(New Object() {"CANCELLED", "UNCONFIRMED", "IN-HOLD", "CONFIRMED", "DELIVERED"})
        Me.cboORDER_STATUS.Location = New System.Drawing.Point(111, 102)
        Me.cboORDER_STATUS.Name = "cboORDER_STATUS"
        Me.cboORDER_STATUS.Size = New System.Drawing.Size(127, 21)
        Me.cboORDER_STATUS.TabIndex = 8
        '
        'dtmORDER_DATE
        '
        Me.dtmORDER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmORDER_DATE.Location = New System.Drawing.Point(111, 76)
        Me.dtmORDER_DATE.Name = "dtmORDER_DATE"
        Me.dtmORDER_DATE.Size = New System.Drawing.Size(127, 20)
        Me.dtmORDER_DATE.TabIndex = 7
        '
        'txtCUSTOMER_NAME
        '
        Me.txtCUSTOMER_NAME.Location = New System.Drawing.Point(111, 50)
        Me.txtCUSTOMER_NAME.Name = "txtCUSTOMER_NAME"
        Me.txtCUSTOMER_NAME.Size = New System.Drawing.Size(127, 20)
        Me.txtCUSTOMER_NAME.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ORDER DATE"
        '
        'txtORDER_ID
        '
        Me.txtORDER_ID.Enabled = False
        Me.txtORDER_ID.Location = New System.Drawing.Point(332, 461)
        Me.txtORDER_ID.Name = "txtORDER_ID"
        Me.txtORDER_ID.Size = New System.Drawing.Size(127, 20)
        Me.txtORDER_ID.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnDELETE)
        Me.GroupBox2.Controls.Add(Me.btnEDIT)
        Me.GroupBox2.Controls.Add(Me.btnCANCEL)
        Me.GroupBox2.Controls.Add(Me.btnSAVE)
        Me.GroupBox2.Controls.Add(Me.btnADD)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(283, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 180)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATE BUTTON"
        '
        'btnDELETE
        '
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDELETE.Location = New System.Drawing.Point(93, 30)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(62, 40)
        Me.btnDELETE.TabIndex = 18
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEDIT.Location = New System.Drawing.Point(93, 76)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(62, 40)
        Me.btnEDIT.TabIndex = 16
        Me.btnEDIT.Text = "&EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCANCEL.Location = New System.Drawing.Point(56, 122)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(63, 46)
        Me.btnCANCEL.TabIndex = 14
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'btnSAVE
        '
        Me.btnSAVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSAVE.Location = New System.Drawing.Point(22, 76)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(65, 40)
        Me.btnSAVE.TabIndex = 13
        Me.btnSAVE.Text = "&SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnADD.Location = New System.Drawing.Point(22, 30)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(65, 40)
        Me.btnADD.TabIndex = 12
        Me.btnADD.Text = "&ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'DG_ADD_EDIT_ORDER_INFO
        '
        Me.DG_ADD_EDIT_ORDER_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ADD_EDIT_ORDER_INFO.Location = New System.Drawing.Point(10, 202)
        Me.DG_ADD_EDIT_ORDER_INFO.MultiSelect = False
        Me.DG_ADD_EDIT_ORDER_INFO.Name = "DG_ADD_EDIT_ORDER_INFO"
        Me.DG_ADD_EDIT_ORDER_INFO.ReadOnly = True
        Me.DG_ADD_EDIT_ORDER_INFO.Size = New System.Drawing.Size(525, 196)
        Me.DG_ADD_EDIT_ORDER_INFO.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdCUSTOMER_NAME)
        Me.GroupBox3.Controls.Add(Me.rdORDER_ID)
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(465, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 86)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY"
        '
        'rdCUSTOMER_NAME
        '
        Me.rdCUSTOMER_NAME.AutoSize = True
        Me.rdCUSTOMER_NAME.Location = New System.Drawing.Point(8, 61)
        Me.rdCUSTOMER_NAME.Name = "rdCUSTOMER_NAME"
        Me.rdCUSTOMER_NAME.Size = New System.Drawing.Size(120, 17)
        Me.rdCUSTOMER_NAME.TabIndex = 20
        Me.rdCUSTOMER_NAME.TabStop = True
        Me.rdCUSTOMER_NAME.Text = "CUSTOMER NAME"
        Me.rdCUSTOMER_NAME.UseVisualStyleBackColor = True
        '
        'rdORDER_ID
        '
        Me.rdORDER_ID.AutoSize = True
        Me.rdORDER_ID.Location = New System.Drawing.Point(8, 42)
        Me.rdORDER_ID.Name = "rdORDER_ID"
        Me.rdORDER_ID.Size = New System.Drawing.Size(78, 17)
        Me.rdORDER_ID.TabIndex = 19
        Me.rdORDER_ID.TabStop = True
        Me.rdORDER_ID.Text = "ORDER ID"
        Me.rdORDER_ID.UseVisualStyleBackColor = True
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(8, 20)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(465, 108)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(52, 42)
        Me.btnEXIT.TabIndex = 24
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'form_add_edit_order_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 416)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DG_ADD_EDIT_ORDER_INFO)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtORDER_ID)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "form_add_edit_order_info"
        Me.Text = "ADD/EDIT ORDER INFO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_ADD_EDIT_ORDER_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboORDER_STATUS As System.Windows.Forms.ComboBox
    Friend WithEvents dtmORDER_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCUSTOMER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents txtORDER_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents DG_ADD_EDIT_ORDER_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCUSTOMER_NAME As System.Windows.Forms.RadioButton
    Friend WithEvents rdORDER_ID As System.Windows.Forms.RadioButton
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents cbVIA As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
