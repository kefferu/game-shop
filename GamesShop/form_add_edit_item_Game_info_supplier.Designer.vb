<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_item_Game_info_supplier
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
        Me.txtKODE_GAME = New System.Windows.Forms.TextBox()
        Me.cboSUPPLIER = New System.Windows.Forms.ComboBox()
        Me.txtSUPPLIER_PRICE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER = New System.Windows.Forms.DataGridView()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.lblKODE_GAME = New System.Windows.Forms.Label()
        Me.lblSUPPLIER = New System.Windows.Forms.Label()
        Me.lblSUPPLIER_PRICE = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chDELETE_SUPPLIER = New System.Windows.Forms.CheckBox()
        Me.chADD_SUPPLIER = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE GAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SUPPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SUPPLIER PRICE"
        '
        'txtKODE_GAME
        '
        Me.txtKODE_GAME.Location = New System.Drawing.Point(102, 59)
        Me.txtKODE_GAME.Name = "txtKODE_GAME"
        Me.txtKODE_GAME.Size = New System.Drawing.Size(116, 20)
        Me.txtKODE_GAME.TabIndex = 3
        '
        'cboSUPPLIER
        '
        Me.cboSUPPLIER.FormattingEnabled = True
        Me.cboSUPPLIER.Location = New System.Drawing.Point(101, 85)
        Me.cboSUPPLIER.Name = "cboSUPPLIER"
        Me.cboSUPPLIER.Size = New System.Drawing.Size(117, 21)
        Me.cboSUPPLIER.TabIndex = 4
        '
        'txtSUPPLIER_PRICE
        '
        Me.txtSUPPLIER_PRICE.Location = New System.Drawing.Point(101, 113)
        Me.txtSUPPLIER_PRICE.Name = "txtSUPPLIER_PRICE"
        Me.txtSUPPLIER_PRICE.Size = New System.Drawing.Size(117, 20)
        Me.txtSUPPLIER_PRICE.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtKODE_GAME)
        Me.GroupBox1.Controls.Add(Me.txtSUPPLIER_PRICE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSUPPLIER)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(59, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 180)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SUPPLIER INFO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnDELETE)
        Me.GroupBox2.Controls.Add(Me.btnEDIT)
        Me.GroupBox2.Controls.Add(Me.btnCANCEL)
        Me.GroupBox2.Controls.Add(Me.btnSAVE)
        Me.GroupBox2.Controls.Add(Me.btnADD)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(291, 12)
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
        'DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER
        '
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Location = New System.Drawing.Point(12, 198)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.MultiSelect = False
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Name = "DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER"
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.ReadOnly = True
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.Size = New System.Drawing.Size(345, 193)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER.TabIndex = 18
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(473, 88)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(52, 42)
        Me.btnEXIT.TabIndex = 19
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'lblKODE_GAME
        '
        Me.lblKODE_GAME.AutoSize = True
        Me.lblKODE_GAME.Location = New System.Drawing.Point(152, 427)
        Me.lblKODE_GAME.Name = "lblKODE_GAME"
        Me.lblKODE_GAME.Size = New System.Drawing.Size(39, 13)
        Me.lblKODE_GAME.TabIndex = 20
        Me.lblKODE_GAME.Text = "Label5"
        '
        'lblSUPPLIER
        '
        Me.lblSUPPLIER.AutoSize = True
        Me.lblSUPPLIER.Location = New System.Drawing.Point(197, 427)
        Me.lblSUPPLIER.Name = "lblSUPPLIER"
        Me.lblSUPPLIER.Size = New System.Drawing.Size(39, 13)
        Me.lblSUPPLIER.TabIndex = 21
        Me.lblSUPPLIER.Text = "Label4"
        '
        'lblSUPPLIER_PRICE
        '
        Me.lblSUPPLIER_PRICE.AutoSize = True
        Me.lblSUPPLIER_PRICE.Location = New System.Drawing.Point(242, 427)
        Me.lblSUPPLIER_PRICE.Name = "lblSUPPLIER_PRICE"
        Me.lblSUPPLIER_PRICE.Size = New System.Drawing.Size(39, 13)
        Me.lblSUPPLIER_PRICE.TabIndex = 22
        Me.lblSUPPLIER_PRICE.Text = "Label5"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(473, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 70)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY KODE GAME"
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(15, 34)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(62, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(33, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "DEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(5, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ADD"
        '
        'chDELETE_SUPPLIER
        '
        Me.chDELETE_SUPPLIER.AutoSize = True
        Me.chDELETE_SUPPLIER.Location = New System.Drawing.Point(38, 98)
        Me.chDELETE_SUPPLIER.Name = "chDELETE_SUPPLIER"
        Me.chDELETE_SUPPLIER.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_SUPPLIER.TabIndex = 30
        Me.chDELETE_SUPPLIER.UseVisualStyleBackColor = True
        '
        'chADD_SUPPLIER
        '
        Me.chADD_SUPPLIER.AutoSize = True
        Me.chADD_SUPPLIER.Location = New System.Drawing.Point(12, 98)
        Me.chADD_SUPPLIER.Name = "chADD_SUPPLIER"
        Me.chADD_SUPPLIER.Size = New System.Drawing.Size(15, 14)
        Me.chADD_SUPPLIER.TabIndex = 29
        Me.chADD_SUPPLIER.UseVisualStyleBackColor = True
        '
        'form_add_edit_item_Game_info_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(602, 404)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chDELETE_SUPPLIER)
        Me.Controls.Add(Me.chADD_SUPPLIER)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblSUPPLIER_PRICE)
        Me.Controls.Add(Me.lblSUPPLIER)
        Me.Controls.Add(Me.lblKODE_GAME)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form_add_edit_item_Game_info_supplier"
        Me.Text = "ADD/EDIT ITEM GAME INFO SUPPLIER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKODE_GAME As System.Windows.Forms.TextBox
    Friend WithEvents cboSUPPLIER As System.Windows.Forms.ComboBox
    Friend WithEvents txtSUPPLIER_PRICE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents DG_ADD_EDIT_ITEM_GAME_INFO_SUPPLIER As System.Windows.Forms.DataGridView
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents lblKODE_GAME As System.Windows.Forms.Label
    Friend WithEvents lblSUPPLIER As System.Windows.Forms.Label
    Friend WithEvents lblSUPPLIER_PRICE As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chDELETE_SUPPLIER As System.Windows.Forms.CheckBox
    Friend WithEvents chADD_SUPPLIER As System.Windows.Forms.CheckBox
End Class
