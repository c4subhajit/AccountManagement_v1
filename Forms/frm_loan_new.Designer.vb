<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loan_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loan_new))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_acno = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_lamt = New System.Windows.Forms.TextBox
        Me.txt_air = New System.Windows.Forms.TextBox
        Me.txt_lp = New System.Windows.Forms.TextBox
        Me.txt_nppy = New System.Windows.Forms.TextBox
        Me.txt_start = New System.Windows.Forms.TextBox
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.txt_snp = New System.Windows.Forms.TextBox
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.cmb_ptype = New System.Windows.Forms.ComboBox
        Me.dtp_date = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loan amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Interest rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Loan period"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Number of payments per year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Starting date of loan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Scheduled payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Scheduled number of payments"
        '
        'txt_acno
        '
        Me.txt_acno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_acno.Location = New System.Drawing.Point(174, 17)
        Me.txt_acno.Name = "txt_acno"
        Me.txt_acno.Size = New System.Drawing.Size(150, 20)
        Me.txt_acno.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(174, 42)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_lamt
        '
        Me.txt_lamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lamt.Location = New System.Drawing.Point(174, 67)
        Me.txt_lamt.Name = "txt_lamt"
        Me.txt_lamt.Size = New System.Drawing.Size(150, 20)
        Me.txt_lamt.TabIndex = 3
        '
        'txt_air
        '
        Me.txt_air.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_air.Location = New System.Drawing.Point(174, 92)
        Me.txt_air.Name = "txt_air"
        Me.txt_air.Size = New System.Drawing.Size(150, 20)
        Me.txt_air.TabIndex = 4
        '
        'txt_lp
        '
        Me.txt_lp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lp.Location = New System.Drawing.Point(174, 117)
        Me.txt_lp.Name = "txt_lp"
        Me.txt_lp.Size = New System.Drawing.Size(40, 20)
        Me.txt_lp.TabIndex = 5
        '
        'txt_nppy
        '
        Me.txt_nppy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nppy.Location = New System.Drawing.Point(174, 142)
        Me.txt_nppy.Name = "txt_nppy"
        Me.txt_nppy.Size = New System.Drawing.Size(150, 20)
        Me.txt_nppy.TabIndex = 7
        '
        'txt_start
        '
        Me.txt_start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_start.Location = New System.Drawing.Point(174, 167)
        Me.txt_start.Name = "txt_start"
        Me.txt_start.ReadOnly = True
        Me.txt_start.Size = New System.Drawing.Size(125, 20)
        Me.txt_start.TabIndex = 15
        Me.txt_start.TabStop = False
        '
        'txt_sp
        '
        Me.txt_sp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sp.Location = New System.Drawing.Point(174, 192)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.Size = New System.Drawing.Size(150, 20)
        Me.txt_sp.TabIndex = 9
        '
        'txt_snp
        '
        Me.txt_snp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_snp.Location = New System.Drawing.Point(174, 217)
        Me.txt_snp.Name = "txt_snp"
        Me.txt_snp.Size = New System.Drawing.Size(150, 20)
        Me.txt_snp.TabIndex = 10
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(190, 257)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 12
        Me.cmd_reset.Text = "&RESET"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(75, 257)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_ok.TabIndex = 11
        Me.cmd_ok.Text = "&OK"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'cmb_ptype
        '
        Me.cmb_ptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ptype.FormattingEnabled = True
        Me.cmb_ptype.Items.AddRange(New Object() {"", "MONTH(S)", "YEAR(S)"})
        Me.cmb_ptype.Location = New System.Drawing.Point(220, 117)
        Me.cmb_ptype.Name = "cmb_ptype"
        Me.cmb_ptype.Size = New System.Drawing.Size(104, 21)
        Me.cmb_ptype.TabIndex = 6
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(306, 167)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(18, 20)
        Me.dtp_date.TabIndex = 8
        '
        'frm_loan_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 302)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.cmb_ptype)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.txt_snp)
        Me.Controls.Add(Me.txt_sp)
        Me.Controls.Add(Me.txt_start)
        Me.Controls.Add(Me.txt_nppy)
        Me.Controls.Add(Me.txt_lp)
        Me.Controls.Add(Me.txt_air)
        Me.Controls.Add(Me.txt_lamt)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_acno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 340)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 340)
        Me.Name = "frm_loan_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New loan account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_acno As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_lamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_air As System.Windows.Forms.TextBox
    Friend WithEvents txt_lp As System.Windows.Forms.TextBox
    Friend WithEvents txt_nppy As System.Windows.Forms.TextBox
    Friend WithEvents txt_start As System.Windows.Forms.TextBox
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents txt_snp As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents cmb_ptype As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
End Class
