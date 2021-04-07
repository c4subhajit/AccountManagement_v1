<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frm_login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.cmd_login = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.chk_change = New System.Windows.Forms.CheckBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(212, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(170, 25)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(212, 60)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(170, 25)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(214, 44)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(170, 20)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(214, 84)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(170, 20)
        Me.txt_pass.TabIndex = 3
        '
        'cmd_login
        '
        Me.cmd_login.Location = New System.Drawing.Point(214, 142)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(52, 22)
        Me.cmd_login.TabIndex = 4
        Me.cmd_login.Text = "&Login"
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(272, 142)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(52, 22)
        Me.cmd_reset.TabIndex = 5
        Me.cmd_reset.Text = "&Reset"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.TripuraSynod_v1.My.Resources.Resources.main_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(187, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'cmd_exit
        '
        Me.cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_exit.Location = New System.Drawing.Point(330, 142)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(52, 22)
        Me.cmd_exit.TabIndex = 6
        Me.cmd_exit.Text = "&Exit"
        '
        'chk_change
        '
        Me.chk_change.AutoSize = True
        Me.chk_change.Location = New System.Drawing.Point(236, 116)
        Me.chk_change.Name = "chk_change"
        Me.chk_change.Size = New System.Drawing.Size(121, 17)
        Me.chk_change.TabIndex = 7
        Me.chk_change.Text = "Change login details"
        Me.chk_change.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AcceptButton = Me.cmd_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_reset
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_change)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(407, 220)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(407, 220)
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Presbyterian Church Of India"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents chk_change As System.Windows.Forms.CheckBox

End Class
