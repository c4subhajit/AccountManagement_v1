<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_acno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sr_acno))
        Me.tc_sr_acno = New System.Windows.Forms.TabControl
        Me.tab_sr_pra = New System.Windows.Forms.TabPage
        Me.txt_dis = New System.Windows.Forms.TextBox
        Me.cmd_reset_pra = New System.Windows.Forms.Button
        Me.cmd_search_pra = New System.Windows.Forms.Button
        Me.txt_div = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_ps = New System.Windows.Forms.TextBox
        Me.txt_po = New System.Windows.Forms.TextBox
        Me.txt_place = New System.Windows.Forms.TextBox
        Me.txt_acno_pra = New System.Windows.Forms.TextBox
        Me.txt_area = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tab_sr_loan = New System.Windows.Forms.TabPage
        Me.cmd_reset_loan = New System.Windows.Forms.Button
        Me.cmd_search_loan = New System.Windows.Forms.Button
        Me.txt_snp = New System.Windows.Forms.TextBox
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.txt_start = New System.Windows.Forms.TextBox
        Me.txt_nppy = New System.Windows.Forms.TextBox
        Me.txt_lp = New System.Windows.Forms.TextBox
        Me.txt_air = New System.Windows.Forms.TextBox
        Me.txt_lamt = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_acno_loan = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tc_sr_acno.SuspendLayout()
        Me.tab_sr_pra.SuspendLayout()
        Me.tab_sr_loan.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_sr_acno
        '
        Me.tc_sr_acno.Controls.Add(Me.tab_sr_pra)
        Me.tc_sr_acno.Controls.Add(Me.tab_sr_loan)
        Me.tc_sr_acno.Location = New System.Drawing.Point(0, 0)
        Me.tc_sr_acno.Name = "tc_sr_acno"
        Me.tc_sr_acno.SelectedIndex = 0
        Me.tc_sr_acno.Size = New System.Drawing.Size(360, 340)
        Me.tc_sr_acno.TabIndex = 1
        '
        'tab_sr_pra
        '
        Me.tab_sr_pra.Controls.Add(Me.txt_dis)
        Me.tab_sr_pra.Controls.Add(Me.cmd_reset_pra)
        Me.tab_sr_pra.Controls.Add(Me.cmd_search_pra)
        Me.tab_sr_pra.Controls.Add(Me.txt_div)
        Me.tab_sr_pra.Controls.Add(Me.Label7)
        Me.tab_sr_pra.Controls.Add(Me.txt_ps)
        Me.tab_sr_pra.Controls.Add(Me.txt_po)
        Me.tab_sr_pra.Controls.Add(Me.txt_place)
        Me.tab_sr_pra.Controls.Add(Me.txt_acno_pra)
        Me.tab_sr_pra.Controls.Add(Me.txt_area)
        Me.tab_sr_pra.Controls.Add(Me.Label6)
        Me.tab_sr_pra.Controls.Add(Me.Label5)
        Me.tab_sr_pra.Controls.Add(Me.Label4)
        Me.tab_sr_pra.Controls.Add(Me.Label3)
        Me.tab_sr_pra.Controls.Add(Me.Label2)
        Me.tab_sr_pra.Controls.Add(Me.Label1)
        Me.tab_sr_pra.Location = New System.Drawing.Point(4, 22)
        Me.tab_sr_pra.Name = "tab_sr_pra"
        Me.tab_sr_pra.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_sr_pra.Size = New System.Drawing.Size(352, 314)
        Me.tab_sr_pra.TabIndex = 0
        Me.tab_sr_pra.Text = "Pathian ram account"
        Me.tab_sr_pra.UseVisualStyleBackColor = True
        '
        'txt_dis
        '
        Me.txt_dis.Location = New System.Drawing.Point(139, 92)
        Me.txt_dis.Name = "txt_dis"
        Me.txt_dis.ReadOnly = True
        Me.txt_dis.Size = New System.Drawing.Size(155, 20)
        Me.txt_dis.TabIndex = 68
        Me.txt_dis.TabStop = False
        '
        'cmd_reset_pra
        '
        Me.cmd_reset_pra.Location = New System.Drawing.Point(190, 264)
        Me.cmd_reset_pra.Name = "cmd_reset_pra"
        Me.cmd_reset_pra.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset_pra.TabIndex = 4
        Me.cmd_reset_pra.Text = "&RESET"
        Me.cmd_reset_pra.UseVisualStyleBackColor = True
        '
        'cmd_search_pra
        '
        Me.cmd_search_pra.Location = New System.Drawing.Point(92, 264)
        Me.cmd_search_pra.Name = "cmd_search_pra"
        Me.cmd_search_pra.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search_pra.TabIndex = 3
        Me.cmd_search_pra.Text = "&SEARCH"
        Me.cmd_search_pra.UseVisualStyleBackColor = True
        '
        'txt_div
        '
        Me.txt_div.Location = New System.Drawing.Point(139, 226)
        Me.txt_div.Name = "txt_div"
        Me.txt_div.ReadOnly = True
        Me.txt_div.Size = New System.Drawing.Size(155, 20)
        Me.txt_div.TabIndex = 64
        Me.txt_div.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Division"
        '
        'txt_ps
        '
        Me.txt_ps.Location = New System.Drawing.Point(139, 192)
        Me.txt_ps.Name = "txt_ps"
        Me.txt_ps.ReadOnly = True
        Me.txt_ps.Size = New System.Drawing.Size(155, 20)
        Me.txt_ps.TabIndex = 62
        Me.txt_ps.TabStop = False
        '
        'txt_po
        '
        Me.txt_po.Location = New System.Drawing.Point(139, 157)
        Me.txt_po.Name = "txt_po"
        Me.txt_po.ReadOnly = True
        Me.txt_po.Size = New System.Drawing.Size(155, 20)
        Me.txt_po.TabIndex = 61
        Me.txt_po.TabStop = False
        '
        'txt_place
        '
        Me.txt_place.Location = New System.Drawing.Point(139, 124)
        Me.txt_place.Name = "txt_place"
        Me.txt_place.ReadOnly = True
        Me.txt_place.Size = New System.Drawing.Size(155, 20)
        Me.txt_place.TabIndex = 60
        Me.txt_place.TabStop = False
        '
        'txt_acno_pra
        '
        Me.txt_acno_pra.Location = New System.Drawing.Point(139, 28)
        Me.txt_acno_pra.Name = "txt_acno_pra"
        Me.txt_acno_pra.Size = New System.Drawing.Size(155, 20)
        Me.txt_acno_pra.TabIndex = 2
        '
        'txt_area
        '
        Me.txt_area.Location = New System.Drawing.Point(139, 60)
        Me.txt_area.Name = "txt_area"
        Me.txt_area.ReadOnly = True
        Me.txt_area.Size = New System.Drawing.Size(155, 20)
        Me.txt_area.TabIndex = 58
        Me.txt_area.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Police station"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Post office"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Place"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "District"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Account number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Name of area"
        '
        'tab_sr_loan
        '
        Me.tab_sr_loan.Controls.Add(Me.cmd_reset_loan)
        Me.tab_sr_loan.Controls.Add(Me.cmd_search_loan)
        Me.tab_sr_loan.Controls.Add(Me.txt_snp)
        Me.tab_sr_loan.Controls.Add(Me.txt_sp)
        Me.tab_sr_loan.Controls.Add(Me.txt_start)
        Me.tab_sr_loan.Controls.Add(Me.txt_nppy)
        Me.tab_sr_loan.Controls.Add(Me.txt_lp)
        Me.tab_sr_loan.Controls.Add(Me.txt_air)
        Me.tab_sr_loan.Controls.Add(Me.txt_lamt)
        Me.tab_sr_loan.Controls.Add(Me.txt_name)
        Me.tab_sr_loan.Controls.Add(Me.txt_acno_loan)
        Me.tab_sr_loan.Controls.Add(Me.Label9)
        Me.tab_sr_loan.Controls.Add(Me.Label8)
        Me.tab_sr_loan.Controls.Add(Me.Label10)
        Me.tab_sr_loan.Controls.Add(Me.Label11)
        Me.tab_sr_loan.Controls.Add(Me.Label12)
        Me.tab_sr_loan.Controls.Add(Me.Label13)
        Me.tab_sr_loan.Controls.Add(Me.Label14)
        Me.tab_sr_loan.Controls.Add(Me.Label15)
        Me.tab_sr_loan.Controls.Add(Me.Label16)
        Me.tab_sr_loan.Location = New System.Drawing.Point(4, 22)
        Me.tab_sr_loan.Name = "tab_sr_loan"
        Me.tab_sr_loan.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_sr_loan.Size = New System.Drawing.Size(352, 314)
        Me.tab_sr_loan.TabIndex = 1
        Me.tab_sr_loan.Text = "Loan account"
        Me.tab_sr_loan.UseVisualStyleBackColor = True
        '
        'cmd_reset_loan
        '
        Me.cmd_reset_loan.Location = New System.Drawing.Point(190, 264)
        Me.cmd_reset_loan.Name = "cmd_reset_loan"
        Me.cmd_reset_loan.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset_loan.TabIndex = 7
        Me.cmd_reset_loan.Text = "RESE&T"
        Me.cmd_reset_loan.UseVisualStyleBackColor = True
        '
        'cmd_search_loan
        '
        Me.cmd_search_loan.Location = New System.Drawing.Point(92, 264)
        Me.cmd_search_loan.Name = "cmd_search_loan"
        Me.cmd_search_loan.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search_loan.TabIndex = 6
        Me.cmd_search_loan.Text = "SEARC&H"
        Me.cmd_search_loan.UseVisualStyleBackColor = True
        '
        'txt_snp
        '
        Me.txt_snp.Location = New System.Drawing.Point(182, 225)
        Me.txt_snp.Name = "txt_snp"
        Me.txt_snp.ReadOnly = True
        Me.txt_snp.Size = New System.Drawing.Size(150, 20)
        Me.txt_snp.TabIndex = 84
        Me.txt_snp.TabStop = False
        '
        'txt_sp
        '
        Me.txt_sp.Location = New System.Drawing.Point(182, 200)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.ReadOnly = True
        Me.txt_sp.Size = New System.Drawing.Size(150, 20)
        Me.txt_sp.TabIndex = 83
        Me.txt_sp.TabStop = False
        '
        'txt_start
        '
        Me.txt_start.Location = New System.Drawing.Point(182, 175)
        Me.txt_start.Name = "txt_start"
        Me.txt_start.ReadOnly = True
        Me.txt_start.Size = New System.Drawing.Size(150, 20)
        Me.txt_start.TabIndex = 82
        Me.txt_start.TabStop = False
        '
        'txt_nppy
        '
        Me.txt_nppy.Location = New System.Drawing.Point(182, 150)
        Me.txt_nppy.Name = "txt_nppy"
        Me.txt_nppy.ReadOnly = True
        Me.txt_nppy.Size = New System.Drawing.Size(150, 20)
        Me.txt_nppy.TabIndex = 81
        Me.txt_nppy.TabStop = False
        '
        'txt_lp
        '
        Me.txt_lp.Location = New System.Drawing.Point(182, 125)
        Me.txt_lp.Name = "txt_lp"
        Me.txt_lp.ReadOnly = True
        Me.txt_lp.Size = New System.Drawing.Size(150, 20)
        Me.txt_lp.TabIndex = 80
        Me.txt_lp.TabStop = False
        '
        'txt_air
        '
        Me.txt_air.Location = New System.Drawing.Point(182, 100)
        Me.txt_air.Name = "txt_air"
        Me.txt_air.ReadOnly = True
        Me.txt_air.Size = New System.Drawing.Size(150, 20)
        Me.txt_air.TabIndex = 79
        Me.txt_air.TabStop = False
        '
        'txt_lamt
        '
        Me.txt_lamt.Location = New System.Drawing.Point(182, 75)
        Me.txt_lamt.Name = "txt_lamt"
        Me.txt_lamt.ReadOnly = True
        Me.txt_lamt.Size = New System.Drawing.Size(150, 20)
        Me.txt_lamt.TabIndex = 78
        Me.txt_lamt.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(182, 50)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_name.TabIndex = 77
        Me.txt_name.TabStop = False
        '
        'txt_acno_loan
        '
        Me.txt_acno_loan.Location = New System.Drawing.Point(182, 25)
        Me.txt_acno_loan.Name = "txt_acno_loan"
        Me.txt_acno_loan.Size = New System.Drawing.Size(150, 20)
        Me.txt_acno_loan.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Scheduled number of payments"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Scheduled payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Starting date of loan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Number of payments per year"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Loan period"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(78, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Annual interest rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(107, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Loan amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(141, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(91, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Account number"
        '
        'frm_sr_acno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 341)
        Me.Controls.Add(Me.tc_sr_acno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 379)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(376, 379)
        Me.Name = "frm_sr_acno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Search by account number"
        Me.tc_sr_acno.ResumeLayout(False)
        Me.tab_sr_pra.ResumeLayout(False)
        Me.tab_sr_pra.PerformLayout()
        Me.tab_sr_loan.ResumeLayout(False)
        Me.tab_sr_loan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_sr_acno As System.Windows.Forms.TabControl
    Friend WithEvents tab_sr_pra As System.Windows.Forms.TabPage
    Friend WithEvents tab_sr_loan As System.Windows.Forms.TabPage
    Friend WithEvents txt_dis As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset_pra As System.Windows.Forms.Button
    Friend WithEvents cmd_search_pra As System.Windows.Forms.Button
    Friend WithEvents txt_div As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_ps As System.Windows.Forms.TextBox
    Friend WithEvents txt_po As System.Windows.Forms.TextBox
    Friend WithEvents txt_place As System.Windows.Forms.TextBox
    Friend WithEvents txt_acno_pra As System.Windows.Forms.TextBox
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset_loan As System.Windows.Forms.Button
    Friend WithEvents cmd_search_loan As System.Windows.Forms.Button
    Friend WithEvents txt_snp As System.Windows.Forms.TextBox
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents txt_start As System.Windows.Forms.TextBox
    Friend WithEvents txt_nppy As System.Windows.Forms.TextBox
    Friend WithEvents txt_lp As System.Windows.Forms.TextBox
    Friend WithEvents txt_air As System.Windows.Forms.TextBox
    Friend WithEvents txt_lamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_acno_loan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
