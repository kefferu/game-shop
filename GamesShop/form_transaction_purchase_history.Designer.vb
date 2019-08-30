<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_transaction_purchase_history
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
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY = New System.Windows.Forms.DataGridView()
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM = New System.Windows.Forms.DataGridView()
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSEARCH_KODE = New System.Windows.Forms.TextBox()
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY
        '
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.Location = New System.Drawing.Point(35, 61)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.Name = "DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY"
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.Size = New System.Drawing.Size(579, 136)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY.TabIndex = 0
        '
        'DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM
        '
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.Location = New System.Drawing.Point(62, 221)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.Name = "DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM"
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.Size = New System.Drawing.Size(501, 115)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM.TabIndex = 1
        '
        'DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO
        '
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.Location = New System.Drawing.Point(12, 355)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.MultiSelect = False
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.Name = "DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO"
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.ReadOnly = True
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.Size = New System.Drawing.Size(651, 74)
        Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(229, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PURCHASE HISTORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(291, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ITEMS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(262, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "GAME INFO"
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(606, 8)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(63, 40)
        Me.btnEXIT.TabIndex = 22
        Me.btnEXIT.Text = "&EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSEARCH_KODE)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 46)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BY CODE"
        '
        'txtSEARCH_KODE
        '
        Me.txtSEARCH_KODE.Location = New System.Drawing.Point(6, 16)
        Me.txtSEARCH_KODE.Name = "txtSEARCH_KODE"
        Me.txtSEARCH_KODE.Size = New System.Drawing.Size(151, 20)
        Me.txtSEARCH_KODE.TabIndex = 18
        '
        'form_transaction_purchase_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 456)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM)
        Me.Controls.Add(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY)
        Me.Name = "form_transaction_purchase_history"
        Me.Text = "PURCHASE HISTORY"
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY As System.Windows.Forms.DataGridView
    Friend WithEvents DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_ITEM As System.Windows.Forms.DataGridView
    Friend WithEvents DG_TRANSACTION_PURCHASE_HISTORY_PURCHASE_HISTORY_GAME_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSEARCH_KODE As System.Windows.Forms.TextBox
End Class
