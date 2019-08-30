<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_View_item
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
        Me.DG_VIEW_ITEM_GAME_INFO = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE = New System.Windows.Forms.DataGridView()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdGAME_NAME = New System.Windows.Forms.RadioButton()
        Me.rdKODE_GAME = New System.Windows.Forms.RadioButton()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        CType(Me.DG_VIEW_ITEM_GAME_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_STOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_VIEW_ITEM_GAME_INFO
        '
        Me.DG_VIEW_ITEM_GAME_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ITEM_GAME_INFO.Location = New System.Drawing.Point(19, 114)
        Me.DG_VIEW_ITEM_GAME_INFO.MultiSelect = False
        Me.DG_VIEW_ITEM_GAME_INFO.Name = "DG_VIEW_ITEM_GAME_INFO"
        Me.DG_VIEW_ITEM_GAME_INFO.ReadOnly = True
        Me.DG_VIEW_ITEM_GAME_INFO.Size = New System.Drawing.Size(750, 133)
        Me.DG_VIEW_ITEM_GAME_INFO.TabIndex = 0
        '
        'DG_VIEW_ITEM_GAME_INFO_SUPPLIER
        '
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.Location = New System.Drawing.Point(19, 272)
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.MultiSelect = False
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.Name = "DG_VIEW_ITEM_GAME_INFO_SUPPLIER"
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.ReadOnly = True
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.Size = New System.Drawing.Size(346, 112)
        Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER.TabIndex = 1
        '
        'DG_VIEW_ITEM_GAME_INFO_AUTHOR
        '
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.Location = New System.Drawing.Point(371, 272)
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.MultiSelect = False
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.Name = "DG_VIEW_ITEM_GAME_INFO_AUTHOR"
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.ReadOnly = True
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.Size = New System.Drawing.Size(398, 112)
        Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR.TabIndex = 2
        '
        'DG_VIEW_ITEM_GAME_INFO_STOCK
        '
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.Location = New System.Drawing.Point(371, 403)
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.MultiSelect = False
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.Name = "DG_VIEW_ITEM_GAME_INFO_STOCK"
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.ReadOnly = True
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.Size = New System.Drawing.Size(246, 57)
        Me.DG_VIEW_ITEM_GAME_INFO_STOCK.TabIndex = 3
        '
        'DG_VIEW_ITEM_GAME_INFO_PRICE
        '
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.Location = New System.Drawing.Point(113, 403)
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.MultiSelect = False
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.Name = "DG_VIEW_ITEM_GAME_INFO_PRICE"
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.ReadOnly = True
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.Size = New System.Drawing.Size(252, 57)
        Me.DG_VIEW_ITEM_GAME_INFO_PRICE.TabIndex = 4
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(677, 12)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(63, 40)
        Me.btnEXIT.TabIndex = 16
        Me.btnEXIT.Text = "&EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(353, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "GAME INFO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(110, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "GAME INFO SUPPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(480, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "GAME INFO AUTHOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(440, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "GAME INFO STOCK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(193, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "GAME INFO PRICE"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdGAME_NAME)
        Me.GroupBox3.Controls.Add(Me.rdKODE_GAME)
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 86)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY"
        '
        'rdGAME_NAME
        '
        Me.rdGAME_NAME.AutoSize = True
        Me.rdGAME_NAME.Location = New System.Drawing.Point(8, 61)
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
        Me.rdKODE_GAME.Location = New System.Drawing.Point(8, 42)
        Me.rdKODE_GAME.Name = "rdKODE_GAME"
        Me.rdKODE_GAME.Size = New System.Drawing.Size(89, 17)
        Me.rdKODE_GAME.TabIndex = 19
        Me.rdKODE_GAME.TabStop = True
        Me.rdKODE_GAME.Text = "KODE GAME"
        Me.rdKODE_GAME.UseVisualStyleBackColor = True
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(8, 20)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'form_View_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 475)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.DG_VIEW_ITEM_GAME_INFO_PRICE)
        Me.Controls.Add(Me.DG_VIEW_ITEM_GAME_INFO_STOCK)
        Me.Controls.Add(Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR)
        Me.Controls.Add(Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER)
        Me.Controls.Add(Me.DG_VIEW_ITEM_GAME_INFO)
        Me.Name = "form_View_item"
        Me.Text = "VIEW ITEM"
        CType(Me.DG_VIEW_ITEM_GAME_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_SUPPLIER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_AUTHOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_STOCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ITEM_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_VIEW_ITEM_GAME_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ITEM_GAME_INFO_SUPPLIER As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ITEM_GAME_INFO_AUTHOR As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ITEM_GAME_INFO_STOCK As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ITEM_GAME_INFO_PRICE As System.Windows.Forms.DataGridView
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGAME_NAME As System.Windows.Forms.RadioButton
    Friend WithEvents rdKODE_GAME As System.Windows.Forms.RadioButton
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
End Class
