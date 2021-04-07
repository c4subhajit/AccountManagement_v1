<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pra_delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pra_delete))
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_div = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_ps = New System.Windows.Forms.TextBox
        Me.txt_po = New System.Windows.Forms.TextBox
        Me.txt_place = New System.Windows.Forms.TextBox
        Me.txt_acno = New System.Windows.Forms.TextBox
        Me.txt_area = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_dis = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(105, 260)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(75, 23)
        Me.cmd_delete.TabIndex = 3
        Me.cmd_delete.Text = "&DELETE"
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(191, 260)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 4
        Me.cmd_reset.Text = "&RESET"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(19, 260)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "&SEARCH"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'txt_div
        '
        Me.txt_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_div.Location = New System.Drawing.Point(111, 225)
        Me.txt_div.Name = "txt_div"
        Me.txt_div.ReadOnly = True
        Me.txt_div.Size = New System.Drawing.Size(155, 20)
        Me.txt_div.TabIndex = 47
        Me.txt_div.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Division"
        '
        'txt_ps
        '
        Me.txt_ps.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ps.Location = New System.Drawing.Point(111, 190)
        Me.txt_ps.Name = "txt_ps"
        Me.txt_ps.ReadOnly = True
        Me.txt_ps.Size = New System.Drawing.Size(155, 20)
        Me.txt_ps.TabIndex = 45
        Me.txt_ps.TabStop = False
        '
        'txt_po
        '
        Me.txt_po.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_po.Location = New System.Drawing.Point(111, 155)
        Me.txt_po.Name = "txt_po"
        Me.txt_po.ReadOnly = True
        Me.txt_po.Size = New System.Drawing.Size(155, 20)
        Me.txt_po.TabIndex = 44
        Me.txt_po.TabStop = False
        '
        'txt_place
        '
        Me.txt_place.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_place.Location = New System.Drawing.Point(111, 120)
        Me.txt_place.Name = "txt_place"
        Me.txt_place.ReadOnly = True
        Me.txt_place.Size = New System.Drawing.Size(155, 20)
        Me.txt_place.TabIndex = 43
        Me.txt_place.TabStop = False
        '
        'txt_acno
        '
        Me.txt_acno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_acno.Location = New System.Drawing.Point(111, 15)
        Me.txt_acno.Name = "txt_acno"
        Me.txt_acno.Size = New System.Drawing.Size(155, 20)
        Me.txt_acno.TabIndex = 1
        '
        'txt_area
        '
        Me.txt_area.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_area.Location = New System.Drawing.Point(111, 50)
        Me.txt_area.Name = "txt_area"
        Me.txt_area.ReadOnly = True
        Me.txt_area.Size = New System.Drawing.Size(155, 20)
        Me.txt_area.TabIndex = 40
        Me.txt_area.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Police station"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Post office"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Place"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "District"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Account number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Name of area"
        '
        'txt_dis
        '
        Me.txt_dis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dis.Location = New System.Drawing.Point(111, 85)
        Me.txt_dis.Name = "txt_dis"
        Me.txt_dis.ReadOnly = True
        Me.txt_dis.Size = New System.Drawing.Size(155, 20)
        Me.txt_dis.TabIndex = 51
        Me.txt_dis.TabStop = False
        '
        'frm_pra_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 302)
        Me.Controls.Add(Me.txt_dis)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_div)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_ps)
        Me.Controls.Add(Me.txt_po)
        Me.Controls.Add(Me.txt_place)
        Me.Controls.Add(Me.txt_acno)
        Me.Controls.Add(Me.txt_area)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 340)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 340)
        Me.Name = "frm_pra_delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Delete Pathian Ram Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_div As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_ps As System.Windows.Forms.TextBox
    Friend WithEvents txt_po As System.Windows.Forms.TextBox
    Friend WithEvents txt_place As System.Windows.Forms.TextBox
    Friend WithEvents txt_acno As System.Windows.Forms.TextBox
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_dis As System.Windows.Forms.TextBox
End Class
