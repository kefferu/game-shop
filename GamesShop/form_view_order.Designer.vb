<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_view_order
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
        Me.DG_VIEW_ORDER_ORDER_INFO = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER = New System.Windows.Forms.DataGridView()
        Me.DG_VIEW_ORDER_GAME_INFO = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdCUSTOMER_NAME = New System.Windows.Forms.RadioButton()
        Me.rdORDER_ID = New System.Windows.Forms.RadioButton()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        CType(Me.DG_VIEW_ORDER_ORDER_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ORDER_ORDER_INFO_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_VIEW_ORDER_GAME_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_VIEW_ORDER_ORDER_INFO
        '
        Me.DG_VIEW_ORDER_ORDER_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ORDER_ORDER_INFO.Location = New System.Drawing.Point(3, 91)
        Me.DG_VIEW_ORDER_ORDER_INFO.MultiSelect = False
        Me.DG_VIEW_ORDER_ORDER_INFO.Name = "DG_VIEW_ORDER_ORDER_INFO"
        Me.DG_VIEW_ORDER_ORDER_INFO.ReadOnly = True
        Me.DG_VIEW_ORDER_ORDER_INFO.Size = New System.Drawing.Size(477, 127)
        Me.DG_VIEW_ORDER_ORDER_INFO.TabIndex = 0
        '
        'DG_VIEW_ORDER_ORDER_INFO_ITEM
        '
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.Location = New System.Drawing.Point(486, 91)
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.MultiSelect = False
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.Name = "DG_VIEW_ORDER_ORDER_INFO_ITEM"
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.ReadOnly = True
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.Size = New System.Drawing.Size(303, 127)
        Me.DG_VIEW_ORDER_ORDER_INFO_ITEM.TabIndex = 1
        '
        'DG_VIEW_ORDER_ORDER_INFO_CUSTOMER
        '
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.Location = New System.Drawing.Point(3, 242)
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.Name = "DG_VIEW_ORDER_ORDER_INFO_CUSTOMER"
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.ReadOnly = True
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.Size = New System.Drawing.Size(786, 68)
        Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER.TabIndex = 2
        '
        'DG_VIEW_ORDER_GAME_INFO
        '
        Me.DG_VIEW_ORDER_GAME_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VIEW_ORDER_GAME_INFO.Location = New System.Drawing.Point(3, 329)
        Me.DG_VIEW_ORDER_GAME_INFO.Name = "DG_VIEW_ORDER_GAME_INFO"
        Me.DG_VIEW_ORDER_GAME_INFO.ReadOnly = True
        Me.DG_VIEW_ORDER_GAME_INFO.Size = New System.Drawing.Size(786, 80)
        Me.DG_VIEW_ORDER_GAME_INFO.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(206, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ORDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(577, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ITEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(303, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CUSTOMER INFO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(313, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GAME INFO"
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(661, 12)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(52, 42)
        Me.btnEXIT.TabIndex = 25
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdCUSTOMER_NAME)
        Me.GroupBox3.Controls.Add(Me.rdORDER_ID)
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 86)
        Me.GroupBox3.TabIndex = 26
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
        'form_view_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 433)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_VIEW_ORDER_GAME_INFO)
        Me.Controls.Add(Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER)
        Me.Controls.Add(Me.DG_VIEW_ORDER_ORDER_INFO_ITEM)
        Me.Controls.Add(Me.DG_VIEW_ORDER_ORDER_INFO)
        Me.Name = "form_view_order"
        Me.Text = "VIEW ORDER"
        CType(Me.DG_VIEW_ORDER_ORDER_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ORDER_ORDER_INFO_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ORDER_ORDER_INFO_CUSTOMER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_VIEW_ORDER_GAME_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_VIEW_ORDER_ORDER_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ORDER_ORDER_INFO_ITEM As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ORDER_ORDER_INFO_CUSTOMER As System.Windows.Forms.DataGridView
    Friend WithEvents DG_VIEW_ORDER_GAME_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCUSTOMER_NAME As System.Windows.Forms.RadioButton
    Friend WithEvents rdORDER_ID As System.Windows.Forms.RadioButton
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
End Class
