<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login_modify))
        Me.cmd_continue = New System.Windows.Forms.Button
        Me.cmd_save = New System.Windows.Forms.Button
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.lbl_user = New System.Windows.Forms.Label
        Me.cmb_change = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_continue
        '
        Me.cmd_continue.Location = New System.Drawing.Point(324, 137)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(75, 23)
        Me.cmd_continue.TabIndex = 14
        Me.cmd_continue.Text = "Continue"
        Me.cmd_continue.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(234, 137)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(75, 23)
        Me.cmd_save.TabIndex = 13
        Me.cmd_save.Text = "Save"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(298, 98)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(115, 20)
        Me.txt_pass.TabIndex = 12
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(298, 65)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(115, 20)
        Me.txt_user.TabIndex = 11
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(212, 101)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(78, 13)
        Me.lbl_pass.TabIndex = 10
        Me.lbl_pass.Text = "New Password"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(212, 68)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(80, 13)
        Me.lbl_user.TabIndex = 9
        Me.lbl_user.Text = "New Username"
        '
        'cmb_change
        '
        Me.cmb_change.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_change.FormattingEnabled = True
        Me.cmb_change.Items.AddRange(New Object() {"", "Change Username", "Change Password"})
        Me.cmb_change.Location = New System.Drawing.Point(237, 28)
        Me.cmb_change.Name = "cmb_change"
        Me.cmb_change.Size = New System.Drawing.Size(156, 21)
        Me.cmb_change.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TripuraSynod_v1.My.Resources.Resources.Useraccount
        Me.PictureBox1.Image = Global.TripuraSynod_v1.My.Resources.Resources.Useraccount
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frm_login_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_continue)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.cmb_change)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 224)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(440, 224)
        Me.Name = "frm_login_modify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Change login details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents cmb_change As System.Windows.Forms.ComboBox
End Class
