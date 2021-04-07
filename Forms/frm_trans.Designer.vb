<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_trans))
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.cmd_show = New System.Windows.Forms.Button
        Me.dgv_tt = New System.Windows.Forms.DataGridView
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select tansaction type"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"", "Pathian ram account created", "Pathian ram account modified", "Pathian ram account deleted", "Pathian ram account submission created", "Pathian ram account submission modified", "Pathian ram account submission deleted", "Loan account created", "Loan account modified", "Loan account deleted", "Loan account closed", "Loan account installment created", "Loan account installment modified", "Loan account installment deleted", "Loan account installment(s) cleared", "Scheduled backup"})
        Me.cmb_type.Location = New System.Drawing.Point(251, 12)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(220, 21)
        Me.cmb_type.TabIndex = 4
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(489, 11)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(75, 23)
        Me.cmd_show.TabIndex = 5
        Me.cmd_show.Text = "&SHOW"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'dgv_tt
        '
        Me.dgv_tt.AllowUserToAddRows = False
        Me.dgv_tt.AllowUserToDeleteRows = False
        Me.dgv_tt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tt.Location = New System.Drawing.Point(17, 50)
        Me.dgv_tt.Name = "dgv_tt"
        Me.dgv_tt.ReadOnly = True
        Me.dgv_tt.Size = New System.Drawing.Size(710, 350)
        Me.dgv_tt.TabIndex = 8
        '
        'frm_trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 412)
        Me.Controls.Add(Me.dgv_tt)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(760, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(760, 450)
        Me.Name = "frm_trans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transactions"
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents dgv_tt As System.Windows.Forms.DataGridView
End Class
