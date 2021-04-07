<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ins_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ins_new))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_acno = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_pmtno = New System.Windows.Forms.TextBox
        Me.txt_pmtdate = New System.Windows.Forms.TextBox
        Me.txt_bb = New System.Windows.Forms.TextBox
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.txt_ep = New System.Windows.Forms.TextBox
        Me.txt_tp = New System.Windows.Forms.TextBox
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.txt_eb = New System.Windows.Forms.TextBox
        Me.txt_rem = New System.Windows.Forms.TextBox
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.dtp_pmtdate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Payment date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Beginning balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Scheduled payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Extra payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Interest"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ending balance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Remarks"
        '
        'txt_acno
        '
        Me.txt_acno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_acno.Location = New System.Drawing.Point(119, 17)
        Me.txt_acno.Name = "txt_acno"
        Me.txt_acno.Size = New System.Drawing.Size(150, 20)
        Me.txt_acno.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(119, 47)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_name.TabIndex = 2
        Me.txt_name.TabStop = False
        '
        'txt_pmtno
        '
        Me.txt_pmtno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pmtno.Location = New System.Drawing.Point(119, 77)
        Me.txt_pmtno.Name = "txt_pmtno"
        Me.txt_pmtno.Size = New System.Drawing.Size(150, 20)
        Me.txt_pmtno.TabIndex = 2
        '
        'txt_pmtdate
        '
        Me.txt_pmtdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pmtdate.Location = New System.Drawing.Point(119, 107)
        Me.txt_pmtdate.Name = "txt_pmtdate"
        Me.txt_pmtdate.ReadOnly = True
        Me.txt_pmtdate.Size = New System.Drawing.Size(124, 20)
        Me.txt_pmtdate.TabIndex = 14
        Me.txt_pmtdate.TabStop = False
        '
        'txt_bb
        '
        Me.txt_bb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bb.Location = New System.Drawing.Point(119, 137)
        Me.txt_bb.Name = "txt_bb"
        Me.txt_bb.ReadOnly = True
        Me.txt_bb.Size = New System.Drawing.Size(150, 20)
        Me.txt_bb.TabIndex = 5
        Me.txt_bb.TabStop = False
        '
        'txt_sp
        '
        Me.txt_sp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sp.Location = New System.Drawing.Point(119, 167)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.ReadOnly = True
        Me.txt_sp.Size = New System.Drawing.Size(150, 20)
        Me.txt_sp.TabIndex = 6
        Me.txt_sp.TabStop = False
        '
        'txt_ep
        '
        Me.txt_ep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ep.Location = New System.Drawing.Point(119, 197)
        Me.txt_ep.Name = "txt_ep"
        Me.txt_ep.Size = New System.Drawing.Size(150, 20)
        Me.txt_ep.TabIndex = 4
        '
        'txt_tp
        '
        Me.txt_tp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tp.Location = New System.Drawing.Point(119, 227)
        Me.txt_tp.Name = "txt_tp"
        Me.txt_tp.ReadOnly = True
        Me.txt_tp.Size = New System.Drawing.Size(150, 20)
        Me.txt_tp.TabIndex = 8
        Me.txt_tp.TabStop = False
        '
        'txt_ir
        '
        Me.txt_ir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ir.Location = New System.Drawing.Point(119, 257)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.Size = New System.Drawing.Size(150, 20)
        Me.txt_ir.TabIndex = 5
        '
        'txt_eb
        '
        Me.txt_eb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eb.Location = New System.Drawing.Point(119, 287)
        Me.txt_eb.Name = "txt_eb"
        Me.txt_eb.ReadOnly = True
        Me.txt_eb.Size = New System.Drawing.Size(150, 20)
        Me.txt_eb.TabIndex = 10
        Me.txt_eb.TabStop = False
        '
        'txt_rem
        '
        Me.txt_rem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_rem.Location = New System.Drawing.Point(119, 313)
        Me.txt_rem.Multiline = True
        Me.txt_rem.Name = "txt_rem"
        Me.txt_rem.Size = New System.Drawing.Size(150, 50)
        Me.txt_rem.TabIndex = 6
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(44, 376)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_ok.TabIndex = 7
        Me.cmd_ok.Text = "&OK"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(168, 376)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 8
        Me.cmd_reset.Text = "&RESET"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'dtp_pmtdate
        '
        Me.dtp_pmtdate.Location = New System.Drawing.Point(250, 107)
        Me.dtp_pmtdate.Name = "dtp_pmtdate"
        Me.dtp_pmtdate.Size = New System.Drawing.Size(18, 20)
        Me.dtp_pmtdate.TabIndex = 3
        '
        'frm_ins_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 412)
        Me.Controls.Add(Me.dtp_pmtdate)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.txt_rem)
        Me.Controls.Add(Me.txt_eb)
        Me.Controls.Add(Me.txt_ir)
        Me.Controls.Add(Me.txt_tp)
        Me.Controls.Add(Me.txt_ep)
        Me.Controls.Add(Me.txt_sp)
        Me.Controls.Add(Me.txt_bb)
        Me.Controls.Add(Me.txt_pmtdate)
        Me.Controls.Add(Me.txt_pmtno)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_acno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
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
        Me.MaximumSize = New System.Drawing.Size(305, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(305, 450)
        Me.Name = "frm_ins_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New loan account installment"
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_acno As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_pmtno As System.Windows.Forms.TextBox
    Friend WithEvents txt_pmtdate As System.Windows.Forms.TextBox
    Friend WithEvents txt_bb As System.Windows.Forms.TextBox
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents txt_ep As System.Windows.Forms.TextBox
    Friend WithEvents txt_tp As System.Windows.Forms.TextBox
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
    Friend WithEvents txt_eb As System.Windows.Forms.TextBox
    Friend WithEvents txt_rem As System.Windows.Forms.TextBox
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents dtp_pmtdate As System.Windows.Forms.DateTimePicker
End Class
