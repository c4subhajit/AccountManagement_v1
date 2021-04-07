<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_statistics))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.cmb_acno = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_from_stat = New System.Windows.Forms.DateTimePicker
        Me.dtp_to_stat = New System.Windows.Forms.DateTimePicker
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select type of account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select account number"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"", "Pathian ram account", "Loan account"})
        Me.cmb_type.Location = New System.Drawing.Point(132, 20)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(153, 21)
        Me.cmb_type.TabIndex = 1
        '
        'cmb_acno
        '
        Me.cmb_acno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_acno.FormattingEnabled = True
        Me.cmb_acno.Location = New System.Drawing.Point(132, 58)
        Me.cmb_acno.Name = "cmb_acno"
        Me.cmb_acno.Size = New System.Drawing.Size(153, 21)
        Me.cmb_acno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select session"
        '
        'dtp_from_stat
        '
        Me.dtp_from_stat.Location = New System.Drawing.Point(62, 122)
        Me.dtp_from_stat.Name = "dtp_from_stat"
        Me.dtp_from_stat.Size = New System.Drawing.Size(200, 20)
        Me.dtp_from_stat.TabIndex = 3
        '
        'dtp_to_stat
        '
        Me.dtp_to_stat.Location = New System.Drawing.Point(62, 158)
        Me.dtp_to_stat.Name = "dtp_to_stat"
        Me.dtp_to_stat.Size = New System.Drawing.Size(200, 20)
        Me.dtp_to_stat.TabIndex = 4
        '
        'cmd_view
        '
        Me.cmd_view.Location = New System.Drawing.Point(56, 197)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(75, 23)
        Me.cmd_view.TabIndex = 5
        Me.cmd_view.Text = "&VIEW"
        Me.cmd_view.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(170, 197)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 6
        Me.cmd_reset.Text = "&RESET"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "To"
        '
        'frm_statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 242)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_to_stat)
        Me.Controls.Add(Me.dtp_from_stat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.cmb_acno)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(320, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(320, 280)
        Me.Name = "frm_statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "View reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_acno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_from_stat As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_to_stat As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
