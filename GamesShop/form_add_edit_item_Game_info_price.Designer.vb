<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_item_Game_info_price
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKODE_GAME = New System.Windows.Forms.TextBox()
        Me.txtPRICE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE = New System.Windows.Forms.DataGridView()
        Me.lblKODE_GAME = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE GAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRICE"
        '
        'txtKODE_GAME
        '
        Me.txtKODE_GAME.Location = New System.Drawing.Point(86, 19)
        Me.txtKODE_GAME.Name = "txtKODE_GAME"
        Me.txtKODE_GAME.Size = New System.Drawing.Size(80, 20)
        Me.txtKODE_GAME.TabIndex = 2
        '
        'txtPRICE
        '
        Me.txtPRICE.Location = New System.Drawing.Point(86, 47)
        Me.txtPRICE.Name = "txtPRICE"
        Me.txtPRICE.Size = New System.Drawing.Size(80, 20)
        Me.txtPRICE.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPRICE)
        Me.GroupBox1.Controls.Add(Me.txtKODE_GAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 90)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRICE INFO"
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
        Me.GroupBox2.Location = New System.Drawing.Point(194, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 174)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATE BUTTON"
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
        'btnADD
        '
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnADD.Location = New System.Drawing.Point(22, 30)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(65, 40)
        Me.btnADD.TabIndex = 12
        Me.btnADD.Text = "&ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEXIT.Location = New System.Drawing.Point(376, 95)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(63, 40)
        Me.btnEXIT.TabIndex = 18
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'DG_ADD_EDIT_ITEM_GAME_INFO_PRICE
        '
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.Location = New System.Drawing.Point(108, 192)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.MultiSelect = False
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.Name = "DG_ADD_EDIT_ITEM_GAME_INFO_PRICE"
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.ReadOnly = True
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.Size = New System.Drawing.Size(262, 199)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE.TabIndex = 19
        '
        'lblKODE_GAME
        '
        Me.lblKODE_GAME.AutoSize = True
        Me.lblKODE_GAME.Location = New System.Drawing.Point(51, 422)
        Me.lblKODE_GAME.Name = "lblKODE_GAME"
        Me.lblKODE_GAME.Size = New System.Drawing.Size(49, 13)
        Me.lblKODE_GAME.TabIndex = 20
        Me.lblKODE_GAME.Text = "LABEL 3"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(376, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 70)
        Me.GroupBox3.TabIndex = 25
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
        'form_add_edit_item_Game_info_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(494, 403)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblKODE_GAME)
        Me.Controls.Add(Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form_add_edit_item_Game_info_price"
        Me.Text = "ADD/EDIT ITEM GAME INFO PRICE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_PRICE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKODE_GAME As System.Windows.Forms.TextBox
    Friend WithEvents txtPRICE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents DG_ADD_EDIT_ITEM_GAME_INFO_PRICE As System.Windows.Forms.DataGridView
    Friend WithEvents lblKODE_GAME As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
End Class
