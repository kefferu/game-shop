<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_item_Game_info_author
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
        Me.txtGAME_NAME = New System.Windows.Forms.TextBox()
        Me.cboPUBLISHER = New System.Windows.Forms.ComboBox()
        Me.cboDEVELOPER = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR = New System.Windows.Forms.DataGridView()
        Me.lblGAME_NAME = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chDELETE_DEVELOPER = New System.Windows.Forms.CheckBox()
        Me.chDELETE_PUBLISHER = New System.Windows.Forms.CheckBox()
        Me.chADD_DEVELOPER = New System.Windows.Forms.CheckBox()
        Me.chADD_PUBLISHER = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GAME NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PUBLISHER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DEVELOPER"
        '
        'txtGAME_NAME
        '
        Me.txtGAME_NAME.Location = New System.Drawing.Point(84, 41)
        Me.txtGAME_NAME.Name = "txtGAME_NAME"
        Me.txtGAME_NAME.Size = New System.Drawing.Size(131, 20)
        Me.txtGAME_NAME.TabIndex = 3
        '
        'cboPUBLISHER
        '
        Me.cboPUBLISHER.FormattingEnabled = True
        Me.cboPUBLISHER.Location = New System.Drawing.Point(84, 73)
        Me.cboPUBLISHER.Name = "cboPUBLISHER"
        Me.cboPUBLISHER.Size = New System.Drawing.Size(131, 21)
        Me.cboPUBLISHER.TabIndex = 4
        '
        'cboDEVELOPER
        '
        Me.cboDEVELOPER.FormattingEnabled = True
        Me.cboDEVELOPER.Location = New System.Drawing.Point(84, 106)
        Me.cboDEVELOPER.Name = "cboDEVELOPER"
        Me.cboDEVELOPER.Size = New System.Drawing.Size(131, 21)
        Me.cboDEVELOPER.TabIndex = 5
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
        Me.GroupBox2.Location = New System.Drawing.Point(295, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 180)
        Me.GroupBox2.TabIndex = 18
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
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(477, 80)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(52, 42)
        Me.btnEXIT.TabIndex = 20
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboDEVELOPER)
        Me.GroupBox1.Controls.Add(Me.cboPUBLISHER)
        Me.GroupBox1.Controls.Add(Me.txtGAME_NAME)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(64, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 144)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AUTHOR INFO"
        '
        'DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR
        '
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Location = New System.Drawing.Point(10, 210)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.MultiSelect = False
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Name = "DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR"
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.ReadOnly = True
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.Size = New System.Drawing.Size(461, 172)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR.TabIndex = 22
        '
        'lblGAME_NAME
        '
        Me.lblGAME_NAME.AutoSize = True
        Me.lblGAME_NAME.Location = New System.Drawing.Point(151, 417)
        Me.lblGAME_NAME.Name = "lblGAME_NAME"
        Me.lblGAME_NAME.Size = New System.Drawing.Size(39, 13)
        Me.lblGAME_NAME.TabIndex = 23
        Me.lblGAME_NAME.Text = "Label4"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(477, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 53)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY GAME NAME"
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(8, 20)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(36, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "DEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(8, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "ADD"
        '
        'chDELETE_DEVELOPER
        '
        Me.chDELETE_DEVELOPER.AutoSize = True
        Me.chDELETE_DEVELOPER.Location = New System.Drawing.Point(40, 128)
        Me.chDELETE_DEVELOPER.Name = "chDELETE_DEVELOPER"
        Me.chDELETE_DEVELOPER.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_DEVELOPER.TabIndex = 32
        Me.chDELETE_DEVELOPER.UseVisualStyleBackColor = True
        '
        'chDELETE_PUBLISHER
        '
        Me.chDELETE_PUBLISHER.AutoSize = True
        Me.chDELETE_PUBLISHER.Location = New System.Drawing.Point(40, 94)
        Me.chDELETE_PUBLISHER.Name = "chDELETE_PUBLISHER"
        Me.chDELETE_PUBLISHER.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_PUBLISHER.TabIndex = 31
        Me.chDELETE_PUBLISHER.UseVisualStyleBackColor = True
        '
        'chADD_DEVELOPER
        '
        Me.chADD_DEVELOPER.AutoSize = True
        Me.chADD_DEVELOPER.Location = New System.Drawing.Point(14, 128)
        Me.chADD_DEVELOPER.Name = "chADD_DEVELOPER"
        Me.chADD_DEVELOPER.Size = New System.Drawing.Size(15, 14)
        Me.chADD_DEVELOPER.TabIndex = 30
        Me.chADD_DEVELOPER.UseVisualStyleBackColor = True
        '
        'chADD_PUBLISHER
        '
        Me.chADD_PUBLISHER.AutoSize = True
        Me.chADD_PUBLISHER.Location = New System.Drawing.Point(14, 94)
        Me.chADD_PUBLISHER.Name = "chADD_PUBLISHER"
        Me.chADD_PUBLISHER.Size = New System.Drawing.Size(15, 14)
        Me.chADD_PUBLISHER.TabIndex = 29
        Me.chADD_PUBLISHER.UseVisualStyleBackColor = True
        '
        'form_add_edit_item_Game_info_author
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(651, 394)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chDELETE_DEVELOPER)
        Me.Controls.Add(Me.chDELETE_PUBLISHER)
        Me.Controls.Add(Me.chADD_DEVELOPER)
        Me.Controls.Add(Me.chADD_PUBLISHER)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblGAME_NAME)
        Me.Controls.Add(Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form_add_edit_item_Game_info_author"
        Me.Text = "ADD/EDIT ITEM GAME INFO AUTHOR"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGAME_NAME As System.Windows.Forms.TextBox
    Friend WithEvents cboPUBLISHER As System.Windows.Forms.ComboBox
    Friend WithEvents cboDEVELOPER As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_ADD_EDIT_ITEM_GAME_INFO_AUTHOR As System.Windows.Forms.DataGridView
    Friend WithEvents lblGAME_NAME As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chDELETE_DEVELOPER As System.Windows.Forms.CheckBox
    Friend WithEvents chDELETE_PUBLISHER As System.Windows.Forms.CheckBox
    Friend WithEvents chADD_DEVELOPER As System.Windows.Forms.CheckBox
    Friend WithEvents chADD_PUBLISHER As System.Windows.Forms.CheckBox
End Class
