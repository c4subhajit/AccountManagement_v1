<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loan_delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loan_delete))
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_snp = New System.Windows.Forms.TextBox
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.txt_start = New System.Windows.Forms.TextBox
        Me.txt_nppy = New System.Windows.Forms.TextBox
        Me.txt_lp = New System.Windows.Forms.TextBox
        Me.txt_air = New System.Windows.Forms.TextBox
        Me.txt_lamt = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_acno = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(136, 258)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(75, 23)
        Me.cmd_delete.TabIndex = 3
        Me.cmd_delete.Text = "&DELETE"
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(245, 258)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 4
        Me.cmd_reset.Text = "&RESET"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(26, 258)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "&SEARCH"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'txt_snp
        '
        Me.txt_snp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_snp.Location = New System.Drawing.Point(174, 217)
        Me.txt_snp.Name = "txt_snp"
        Me.txt_snp.ReadOnly = True
        Me.txt_snp.Size = New System.Drawing.Size(150, 20)
        Me.txt_snp.TabIndex = 62
        Me.txt_snp.TabStop = False
        '
        'txt_sp
        '
        Me.txt_sp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sp.Location = New System.Drawing.Point(174, 192)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.ReadOnly = True
        Me.txt_sp.Size = New System.Drawing.Size(150, 20)
        Me.txt_sp.TabIndex = 61
        Me.txt_sp.TabStop = False
        '
        'txt_start
        '
        Me.txt_start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_start.Location = New System.Drawing.Point(174, 167)
        Me.txt_start.Name = "txt_start"
        Me.txt_start.ReadOnly = True
        Me.txt_start.Size = New System.Drawing.Size(150, 20)
        Me.txt_start.TabIndex = 60
        Me.txt_start.TabStop = False
        '
        'txt_nppy
        '
        Me.txt_nppy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nppy.Location = New System.Drawing.Point(174, 142)
        Me.txt_nppy.Name = "txt_nppy"
        Me.txt_nppy.ReadOnly = True
        Me.txt_nppy.Size = New System.Drawing.Size(150, 20)
        Me.txt_nppy.TabIndex = 59
        Me.txt_nppy.TabStop = False
        '
        'txt_lp
        '
        Me.txt_lp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lp.Location = New System.Drawing.Point(174, 117)
        Me.txt_lp.Name = "txt_lp"
        Me.txt_lp.ReadOnly = True
        Me.txt_lp.Size = New System.Drawing.Size(150, 20)
        Me.txt_lp.TabIndex = 58
        Me.txt_lp.TabStop = False
        '
        'txt_air
        '
        Me.txt_air.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_air.Location = New System.Drawing.Point(174, 92)
        Me.txt_air.Name = "txt_air"
        Me.txt_air.ReadOnly = True
        Me.txt_air.Size = New System.Drawing.Size(150, 20)
        Me.txt_air.TabIndex = 57
        Me.txt_air.TabStop = False
        '
        'txt_lamt
        '
        Me.txt_lamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lamt.Location = New System.Drawing.Point(174, 67)
        Me.txt_lamt.Name = "txt_lamt"
        Me.txt_lamt.ReadOnly = True
        Me.txt_lamt.Size = New System.Drawing.Size(150, 20)
        Me.txt_lamt.TabIndex = 56
        Me.txt_lamt.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(174, 42)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_name.TabIndex = 2
        Me.txt_name.TabStop = False
        '
        'txt_acno
        '
        Me.txt_acno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_acno.Location = New System.Drawing.Point(174, 17)
        Me.txt_acno.Name = "txt_acno"
        Me.txt_acno.Size = New System.Drawing.Size(150, 20)
        Me.txt_acno.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Scheduled number of payments"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Scheduled payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Starting date of loan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Number of payments per year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Loan period"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Interest rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Loan amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Account number"
        '
        'frm_loan_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 302)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_search)
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
        Me.Name = "frm_loan_delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Delete loan account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_snp As System.Windows.Forms.TextBox
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents txt_start As System.Windows.Forms.TextBox
    Friend WithEvents txt_nppy As System.Windows.Forms.TextBox
    Friend WithEvents txt_lp As System.Windows.Forms.TextBox
    Friend WithEvents txt_air As System.Windows.Forms.TextBox
    Friend WithEvents txt_lamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_acno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
