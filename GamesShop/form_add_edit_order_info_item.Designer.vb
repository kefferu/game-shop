<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_order_info_item
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
        Me.txtORDER_ID = New System.Windows.Forms.TextBox()
        Me.txtKODE_GAME = New System.Windows.Forms.TextBox()
        Me.txtQUANTITY = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM = New System.Windows.Forms.DataGridView()
        Me.lblORDER_ID = New System.Windows.Forms.Label()
        Me.lblKODE_GAME = New System.Windows.Forms.Label()
        Me.lblQUANTITY = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ORDER_INFO_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE GAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QUANTITY"
        '
        'txtORDER_ID
        '
        Me.txtORDER_ID.Location = New System.Drawing.Point(110, 25)
        Me.txtORDER_ID.Name = "txtORDER_ID"
        Me.txtORDER_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtORDER_ID.TabIndex = 3
        '
        'txtKODE_GAME
        '
        Me.txtKODE_GAME.Location = New System.Drawing.Point(110, 52)
        Me.txtKODE_GAME.Name = "txtKODE_GAME"
        Me.txtKODE_GAME.Size = New System.Drawing.Size(100, 20)
        Me.txtKODE_GAME.TabIndex = 4
        '
        'txtQUANTITY
        '
        Me.txtQUANTITY.Location = New System.Drawing.Point(110, 78)
        Me.txtQUANTITY.Name = "txtQUANTITY"
        Me.txtQUANTITY.Size = New System.Drawing.Size(100, 20)
        Me.txtQUANTITY.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtQUANTITY)
        Me.GroupBox1.Controls.Add(Me.txtKODE_GAME)
        Me.GroupBox1.Controls.Add(Me.txtORDER_ID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 122)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORDER ITEM INFO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnADD)
        Me.GroupBox2.Controls.Add(Me.btnDELETE)
        Me.GroupBox2.Controls.Add(Me.btnEDIT)
        Me.GroupBox2.Controls.Add(Me.btnCANCEL)
        Me.GroupBox2.Controls.Add(Me.btnSAVE)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 180)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATE BUTTON"
        '
        'btnADD
        '
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnADD.Location = New System.Drawing.Point(25, 30)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(62, 40)
        Me.btnADD.TabIndex = 19
        Me.btnADD.Text = "&ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDELETE.Location = New System.Drawing.Point(93, 30)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(62, 40)
        Me.btnDELETE.TabIndex = 18
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEDIT.Location = New System.Drawing.Point(93, 76)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(62, 40)
        Me.btnEDIT.TabIndex = 16
        Me.btnEDIT.Text = "&EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCANCEL.Location = New System.Drawing.Point(56, 122)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(63, 46)
        Me.btnCANCEL.TabIndex = 14
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'btnSAVE
        '
        Me.btnSAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSAVE.Location = New System.Drawing.Point(22, 76)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(65, 40)
        Me.btnSAVE.TabIndex = 13
        Me.btnSAVE.Text = "&SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(427, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 70)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY ORDER ID"
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(13, 34)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(59, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(427, 90)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(52, 42)
        Me.btnEXIT.TabIndex = 25
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'DG_ADD_EDIT_ORDER_INFO_ITEM
        '
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.Location = New System.Drawing.Point(87, 198)
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.MultiSelect = False
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.Name = "DG_ADD_EDIT_ORDER_INFO_ITEM"
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.ReadOnly = True
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.Size = New System.Drawing.Size(334, 148)
        Me.DG_ADD_EDIT_ORDER_INFO_ITEM.TabIndex = 26
        '
        'lblORDER_ID
        '
        Me.lblORDER_ID.AutoSize = True
        Me.lblORDER_ID.Location = New System.Drawing.Point(141, 379)
        Me.lblORDER_ID.Name = "lblORDER_ID"
        Me.lblORDER_ID.Size = New System.Drawing.Size(39, 13)
        Me.lblORDER_ID.TabIndex = 27
        Me.lblORDER_ID.Text = "Label4"
        '
        'lblKODE_GAME
        '
        Me.lblKODE_GAME.AutoSize = True
        Me.lblKODE_GAME.Location = New System.Drawing.Point(217, 379)
        Me.lblKODE_GAME.Name = "lblKODE_GAME"
        Me.lblKODE_GAME.Size = New System.Drawing.Size(39, 13)
        Me.lblKODE_GAME.TabIndex = 28
        Me.lblKODE_GAME.Text = "Label5"
        '
        'lblQUANTITY
        '
        Me.lblQUANTITY.AutoSize = True
        Me.lblQUANTITY.Location = New System.Drawing.Point(293, 379)
        Me.lblQUANTITY.Name = "lblQUANTITY"
        Me.lblQUANTITY.Size = New System.Drawing.Size(39, 13)
        Me.lblQUANTITY.TabIndex = 29
        Me.lblQUANTITY.Text = "Label6"
        '
        'form_add_edit_order_info_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(539, 359)
        Me.Controls.Add(Me.lblQUANTITY)
        Me.Controls.Add(Me.lblKODE_GAME)
        Me.Controls.Add(Me.lblORDER_ID)
        Me.Controls.Add(Me.DG_ADD_EDIT_ORDER_INFO_ITEM)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_add_edit_order_info_item"
        Me.Text = "ADD/EDIT ORDER INFO ITEM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DG_ADD_EDIT_ORDER_INFO_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtORDER_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtKODE_GAME As System.Windows.Forms.TextBox
    Friend WithEvents txtQUANTITY As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents DG_ADD_EDIT_ORDER_INFO_ITEM As System.Windows.Forms.DataGridView
    Friend WithEvents lblORDER_ID As System.Windows.Forms.Label
    Friend WithEvents lblKODE_GAME As System.Windows.Forms.Label
    Friend WithEvents lblQUANTITY As System.Windows.Forms.Label
    Friend WithEvents btnADD As System.Windows.Forms.Button
End Class
