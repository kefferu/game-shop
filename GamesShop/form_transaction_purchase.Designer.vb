<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_transaction_purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_transaction_purchase))
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO = New System.Windows.Forms.DataGridView()
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE = New System.Windows.Forms.DataGridView()
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQUANTITY = New System.Windows.Forms.TextBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.cboVIA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstboxITEM_LIST = New System.Windows.Forms.ListBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTOTAL_PRICE = New System.Windows.Forms.Label()
        Me.btnPURCHASE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDELIVERING_FEE = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdGAME_NAME = New System.Windows.Forms.RadioButton()
        Me.rdKODE_GAME = New System.Windows.Forms.RadioButton()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.STRUCK_PREVIEW = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_TRANSACTION_PURCHASE_GAME_INFO
        '
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.Location = New System.Drawing.Point(4, 3)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.Name = "DG_TRANSACTION_PURCHASE_GAME_INFO"
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.Size = New System.Drawing.Size(645, 113)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO.TabIndex = 0
        '
        'DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE
        '
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.Location = New System.Drawing.Point(1, 122)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.Name = "DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE"
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.Size = New System.Drawing.Size(259, 66)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE.TabIndex = 1
        '
        'DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK
        '
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.Location = New System.Drawing.Point(266, 122)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.Name = "DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK"
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.Size = New System.Drawing.Size(259, 66)
        Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "QUANTITY"
        '
        'txtQUANTITY
        '
        Me.txtQUANTITY.Location = New System.Drawing.Point(156, 32)
        Me.txtQUANTITY.Name = "txtQUANTITY"
        Me.txtQUANTITY.Size = New System.Drawing.Size(31, 20)
        Me.txtQUANTITY.TabIndex = 4
        Me.txtQUANTITY.Text = "1"
        Me.txtQUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnADD
        '
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnADD.Location = New System.Drawing.Point(16, 16)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(52, 38)
        Me.btnADD.TabIndex = 5
        Me.btnADD.Text = "&ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'cboVIA
        '
        Me.cboVIA.FormattingEnabled = True
        Me.cboVIA.Items.AddRange(New Object() {"PICK UP ON STORE", "DELIVERING"})
        Me.cboVIA.Location = New System.Drawing.Point(16, 107)
        Me.cboVIA.Name = "cboVIA"
        Me.cboVIA.Size = New System.Drawing.Size(171, 21)
        Me.cboVIA.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "VIA"
        '
        'lstboxITEM_LIST
        '
        Me.lstboxITEM_LIST.FormattingEnabled = True
        Me.lstboxITEM_LIST.Location = New System.Drawing.Point(207, 16)
        Me.lstboxITEM_LIST.Name = "lstboxITEM_LIST"
        Me.lstboxITEM_LIST.Size = New System.Drawing.Size(494, 147)
        Me.lstboxITEM_LIST.TabIndex = 8
        '
        'btnDELETE
        '
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDELETE.Location = New System.Drawing.Point(74, 16)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(59, 38)
        Me.btnDELETE.TabIndex = 9
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TOTAL PRICE :"
        '
        'lblTOTAL_PRICE
        '
        Me.lblTOTAL_PRICE.AutoSize = True
        Me.lblTOTAL_PRICE.Location = New System.Drawing.Point(102, 69)
        Me.lblTOTAL_PRICE.Name = "lblTOTAL_PRICE"
        Me.lblTOTAL_PRICE.Size = New System.Drawing.Size(13, 13)
        Me.lblTOTAL_PRICE.TabIndex = 11
        Me.lblTOTAL_PRICE.Text = "0"
        '
        'btnPURCHASE
        '
        Me.btnPURCHASE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPURCHASE.Location = New System.Drawing.Point(6, 175)
        Me.btnPURCHASE.Name = "btnPURCHASE"
        Me.btnPURCHASE.Size = New System.Drawing.Size(81, 36)
        Me.btnPURCHASE.TabIndex = 12
        Me.btnPURCHASE.Text = "&PURCHASE"
        Me.btnPURCHASE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDELIVERING_FEE)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnPURCHASE)
        Me.GroupBox1.Controls.Add(Me.lstboxITEM_LIST)
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.lblTOTAL_PRICE)
        Me.GroupBox1.Controls.Add(Me.txtQUANTITY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboVIA)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 217)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PURCHASING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DELIVERING FEE"
        '
        'txtDELIVERING_FEE
        '
        Me.txtDELIVERING_FEE.Enabled = False
        Me.txtDELIVERING_FEE.Location = New System.Drawing.Point(114, 134)
        Me.txtDELIVERING_FEE.Name = "txtDELIVERING_FEE"
        Me.txtDELIVERING_FEE.Size = New System.Drawing.Size(73, 20)
        Me.txtDELIVERING_FEE.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdGAME_NAME)
        Me.GroupBox3.Controls.Add(Me.rdKODE_GAME)
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(531, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 79)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY"
        '
        'rdGAME_NAME
        '
        Me.rdGAME_NAME.AutoSize = True
        Me.rdGAME_NAME.Location = New System.Drawing.Point(8, 56)
        Me.rdGAME_NAME.Name = "rdGAME_NAME"
        Me.rdGAME_NAME.Size = New System.Drawing.Size(90, 17)
        Me.rdGAME_NAME.TabIndex = 20
        Me.rdGAME_NAME.TabStop = True
        Me.rdGAME_NAME.Text = "GAME NAME"
        Me.rdGAME_NAME.UseVisualStyleBackColor = True
        '
        'rdKODE_GAME
        '
        Me.rdKODE_GAME.AutoSize = True
        Me.rdKODE_GAME.Location = New System.Drawing.Point(8, 37)
        Me.rdKODE_GAME.Name = "rdKODE_GAME"
        Me.rdKODE_GAME.Size = New System.Drawing.Size(89, 17)
        Me.rdKODE_GAME.TabIndex = 19
        Me.rdKODE_GAME.TabStop = True
        Me.rdKODE_GAME.Text = "KODE GAME"
        Me.rdKODE_GAME.UseVisualStyleBackColor = True
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(6, 16)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(656, 12)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(63, 40)
        Me.btnEXIT.TabIndex = 21
        Me.btnEXIT.Text = "&EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'STRUCK_PREVIEW
        '
        Me.STRUCK_PREVIEW.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.STRUCK_PREVIEW.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.STRUCK_PREVIEW.ClientSize = New System.Drawing.Size(400, 300)
        Me.STRUCK_PREVIEW.Enabled = True
        Me.STRUCK_PREVIEW.Icon = CType(resources.GetObject("STRUCK_PREVIEW.Icon"), System.Drawing.Icon)
        Me.STRUCK_PREVIEW.Name = "STRUCK_PREVIEW"
        Me.STRUCK_PREVIEW.Visible = False
        '
        'form_transaction_purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 445)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_GAME_INFO)
        Me.Name = "form_transaction_purchase"
        Me.Text = "TRANSACTION PURCHASE"
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_TRANSACTION_PURCHASE_GAME_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents DG_TRANSACTION_PURCHASE_GAME_INFO_PRICE As System.Windows.Forms.DataGridView
    Friend WithEvents DG_TRANSACTION_PURCHASE_GAME_INFO_STOCK As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQUANTITY As System.Windows.Forms.TextBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents cboVIA As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstboxITEM_LIST As System.Windows.Forms.ListBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTOTAL_PRICE As System.Windows.Forms.Label
    Friend WithEvents btnPURCHASE As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGAME_NAME As System.Windows.Forms.RadioButton
    Friend WithEvents rdKODE_GAME As System.Windows.Forms.RadioButton
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDELIVERING_FEE As System.Windows.Forms.TextBox
    Friend WithEvents STRUCK_PREVIEW As System.Windows.Forms.PrintPreviewDialog
End Class
