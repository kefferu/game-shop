<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_edit_item_Game_info
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKODE_GAME = New System.Windows.Forms.TextBox()
        Me.txtGAME_NAME = New System.Windows.Forms.TextBox()
        Me.cboPLATFORM = New System.Windows.Forms.ComboBox()
        Me.cboREGION = New System.Windows.Forms.ComboBox()
        Me.cboLANGUAGE = New System.Windows.Forms.ComboBox()
        Me.dtmRELEASE_DATE = New System.Windows.Forms.DateTimePicker()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.DG_ADD_EDIT_ITEM_GAME_INFO = New System.Windows.Forms.DataGridView()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdGAME_NAME = New System.Windows.Forms.RadioButton()
        Me.rdKODE_GAME = New System.Windows.Forms.RadioButton()
        Me.chADD_PLATFORM = New System.Windows.Forms.CheckBox()
        Me.chADD_REGION = New System.Windows.Forms.CheckBox()
        Me.chADD_LANGUAGE = New System.Windows.Forms.CheckBox()
        Me.chDELETE_PLATFORM = New System.Windows.Forms.CheckBox()
        Me.chDELETE_REGION = New System.Windows.Forms.CheckBox()
        Me.chDELETE_LANGUAGE = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE GAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GAME NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PLATFORM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "REGION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LANGUAGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RELEASE DATE"
        '
        'txtKODE_GAME
        '
        Me.txtKODE_GAME.Location = New System.Drawing.Point(103, 15)
        Me.txtKODE_GAME.Name = "txtKODE_GAME"
        Me.txtKODE_GAME.Size = New System.Drawing.Size(165, 20)
        Me.txtKODE_GAME.TabIndex = 6
        '
        'txtGAME_NAME
        '
        Me.txtGAME_NAME.Location = New System.Drawing.Point(103, 41)
        Me.txtGAME_NAME.Name = "txtGAME_NAME"
        Me.txtGAME_NAME.Size = New System.Drawing.Size(165, 20)
        Me.txtGAME_NAME.TabIndex = 7
        '
        'cboPLATFORM
        '
        Me.cboPLATFORM.FormattingEnabled = True
        Me.cboPLATFORM.Items.AddRange(New Object() {"PS3", "PS4", "3DS", "VITA", "PC"})
        Me.cboPLATFORM.Location = New System.Drawing.Point(102, 65)
        Me.cboPLATFORM.Name = "cboPLATFORM"
        Me.cboPLATFORM.Size = New System.Drawing.Size(165, 21)
        Me.cboPLATFORM.TabIndex = 8
        '
        'cboREGION
        '
        Me.cboREGION.FormattingEnabled = True
        Me.cboREGION.Location = New System.Drawing.Point(102, 93)
        Me.cboREGION.Name = "cboREGION"
        Me.cboREGION.Size = New System.Drawing.Size(165, 21)
        Me.cboREGION.TabIndex = 9
        '
        'cboLANGUAGE
        '
        Me.cboLANGUAGE.FormattingEnabled = True
        Me.cboLANGUAGE.Location = New System.Drawing.Point(103, 121)
        Me.cboLANGUAGE.Name = "cboLANGUAGE"
        Me.cboLANGUAGE.Size = New System.Drawing.Size(165, 21)
        Me.cboLANGUAGE.TabIndex = 10
        '
        'dtmRELEASE_DATE
        '
        Me.dtmRELEASE_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmRELEASE_DATE.Location = New System.Drawing.Point(103, 150)
        Me.dtmRELEASE_DATE.Name = "dtmRELEASE_DATE"
        Me.dtmRELEASE_DATE.Size = New System.Drawing.Size(165, 20)
        Me.dtmRELEASE_DATE.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtmRELEASE_DATE)
        Me.GroupBox1.Controls.Add(Me.cboLANGUAGE)
        Me.GroupBox1.Controls.Add(Me.cboREGION)
        Me.GroupBox1.Controls.Add(Me.cboPLATFORM)
        Me.GroupBox1.Controls.Add(Me.txtGAME_NAME)
        Me.GroupBox1.Controls.Add(Me.txtKODE_GAME)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(51, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 180)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM INFO"
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
        Me.GroupBox2.Location = New System.Drawing.Point(337, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 180)
        Me.GroupBox2.TabIndex = 16
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
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(519, 103)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(63, 40)
        Me.btnEXIT.TabIndex = 15
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'DG_ADD_EDIT_ITEM_GAME_INFO
        '
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.Location = New System.Drawing.Point(18, 194)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.MultiSelect = False
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.Name = "DG_ADD_EDIT_ITEM_GAME_INFO"
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.ReadOnly = True
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.Size = New System.Drawing.Size(646, 260)
        Me.DG_ADD_EDIT_ITEM_GAME_INFO.TabIndex = 17
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(8, 20)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Controls.Add(Me.rdGAME_NAME)
        Me.GroupBox3.Controls.Add(Me.rdKODE_GAME)
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(519, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 86)
        Me.GroupBox3.TabIndex = 19
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
        'chADD_PLATFORM
        '
        Me.chADD_PLATFORM.AutoSize = True
        Me.chADD_PLATFORM.Location = New System.Drawing.Point(4, 76)
        Me.chADD_PLATFORM.Name = "chADD_PLATFORM"
        Me.chADD_PLATFORM.Size = New System.Drawing.Size(15, 14)
        Me.chADD_PLATFORM.TabIndex = 20
        Me.chADD_PLATFORM.UseVisualStyleBackColor = True
        '
        'chADD_REGION
        '
        Me.chADD_REGION.AutoSize = True
        Me.chADD_REGION.Location = New System.Drawing.Point(4, 101)
        Me.chADD_REGION.Name = "chADD_REGION"
        Me.chADD_REGION.Size = New System.Drawing.Size(15, 14)
        Me.chADD_REGION.TabIndex = 21
        Me.chADD_REGION.UseVisualStyleBackColor = True
        '
        'chADD_LANGUAGE
        '
        Me.chADD_LANGUAGE.AutoSize = True
        Me.chADD_LANGUAGE.Location = New System.Drawing.Point(4, 130)
        Me.chADD_LANGUAGE.Name = "chADD_LANGUAGE"
        Me.chADD_LANGUAGE.Size = New System.Drawing.Size(15, 14)
        Me.chADD_LANGUAGE.TabIndex = 22
        Me.chADD_LANGUAGE.UseVisualStyleBackColor = True
        '
        'chDELETE_PLATFORM
        '
        Me.chDELETE_PLATFORM.AutoSize = True
        Me.chDELETE_PLATFORM.Location = New System.Drawing.Point(30, 76)
        Me.chDELETE_PLATFORM.Name = "chDELETE_PLATFORM"
        Me.chDELETE_PLATFORM.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_PLATFORM.TabIndex = 24
        Me.chDELETE_PLATFORM.UseVisualStyleBackColor = True
        '
        'chDELETE_REGION
        '
        Me.chDELETE_REGION.AutoSize = True
        Me.chDELETE_REGION.Location = New System.Drawing.Point(30, 101)
        Me.chDELETE_REGION.Name = "chDELETE_REGION"
        Me.chDELETE_REGION.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_REGION.TabIndex = 25
        Me.chDELETE_REGION.UseVisualStyleBackColor = True
        '
        'chDELETE_LANGUAGE
        '
        Me.chDELETE_LANGUAGE.AutoSize = True
        Me.chDELETE_LANGUAGE.Location = New System.Drawing.Point(30, 130)
        Me.chDELETE_LANGUAGE.Name = "chDELETE_LANGUAGE"
        Me.chDELETE_LANGUAGE.Size = New System.Drawing.Size(15, 14)
        Me.chDELETE_LANGUAGE.TabIndex = 26
        Me.chDELETE_LANGUAGE.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(-3, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "ADD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(25, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "DEL"
        '
        'form_add_edit_item_Game_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 474)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chDELETE_LANGUAGE)
        Me.Controls.Add(Me.chDELETE_REGION)
        Me.Controls.Add(Me.chDELETE_PLATFORM)
        Me.Controls.Add(Me.chADD_LANGUAGE)
        Me.Controls.Add(Me.chADD_REGION)
        Me.Controls.Add(Me.chADD_PLATFORM)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DG_ADD_EDIT_ITEM_GAME_INFO)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form_add_edit_item_Game_info"
        Me.Text = "ADD/EDIT ITEM GAME INFO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_ADD_EDIT_ITEM_GAME_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKODE_GAME As System.Windows.Forms.TextBox
    Friend WithEvents txtGAME_NAME As System.Windows.Forms.TextBox
    Friend WithEvents cboPLATFORM As System.Windows.Forms.ComboBox
    Friend WithEvents cboREGION As System.Windows.Forms.ComboBox
    Friend WithEvents cboLANGUAGE As System.Windows.Forms.ComboBox
    Friend WithEvents dtmRELEASE_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_ADD_EDIT_ITEM_GAME_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGAME_NAME As System.Windows.Forms.RadioButton
    Friend WithEvents rdKODE_GAME As System.Windows.Forms.RadioButton
    Friend WithEvents chADD_PLATFORM As System.Windows.Forms.CheckBox
    Friend WithEvents chADD_REGION As System.Windows.Forms.CheckBox
    Friend WithEvents chADD_LANGUAGE As System.Windows.Forms.CheckBox
    Friend WithEvents chDELETE_PLATFORM As System.Windows.Forms.CheckBox
    Friend WithEvents chDELETE_REGION As System.Windows.Forms.CheckBox
    Friend WithEvents chDELETE_LANGUAGE As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
