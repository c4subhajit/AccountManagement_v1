Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login

    Dim prebackup As String
    Dim prebackupdate As Date
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim trans_querry As New class_querry

    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_home.MenuStrip_synod.Enabled = False

        If frm_home.Enabled = False Then
            cmd_exit.Enabled = False
        Else
            cmd_exit.Enabled = True
        End If
        
        Call reset_login()
    End Sub

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_login.Click
        con_cls.connect()
        If txt_user.Text = "" Then
            MsgBox("Please enter username")
        ElseIf txt_pass.Text = "" Then
            MsgBox("Please enter password")
        Else
            If chk_change.Checked = False Then
                Try
                    con_cls.cmd.CommandText = "SELECT un,pw FROM usacc"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read()
                            If (txt_user.Text = dr.Item("un") And txt_pass.Text = dr.Item("pw")) Then
                                frm_home.username = txt_user.Text
                                frm_home.password = txt_pass.Text
                                dr.Close()
                                con_cls.cn.Close()
                                Call reset_login()
                                Me.Close()
                                frm_home.MenuStrip_synod.Enabled = True
                                frm_home.Enabled = True
                                Call scheduled_backup()
                                Exit Sub
                            End If
                        End While
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        dr.Close()
                        con_cls.cn.Close()
                    Else
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        dr.Close()
                        con_cls.cn.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            End If

            If chk_change.Checked = True Then
                Try
                    con_cls.cmd.CommandText = "SELECT un,pw FROM usacc"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read()
                            If (txt_user.Text = dr.Item("un") And txt_pass.Text = dr.Item("pw")) Then
                                frm_home.username = txt_user.Text
                                frm_home.password = txt_pass.Text
                                dr.Close()
                                con_cls.cn.Close()
                                Me.Close()
                                frm_home.MenuStrip_synod.Enabled = True
                                frm_home.Enabled = True
                                Try
                                    Dim form As New frm_login_modify
                                    form.MdiParent = frm_home
                                    form.Show()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, "Open Child")
                                End Try
                                Me.Close()
                                Call scheduled_backup()
                                Exit Sub
                            End If
                        End While
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        Call reset_login()
                        dr.Close()
                        con_cls.cn.Close()
                    Else
                        MsgBox("Incorrect username or password", MsgBoxStyle.OkOnly, "Login error")
                        Call reset_login()
                        dr.Close()
                        con_cls.cn.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            End If
        End If

        txt_user.Text = ""
        txt_pass.Text = ""
        txt_user.Focus()

    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_login()
    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        If MessageBox.Show("Do u want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frm_home.Close()
        End If
    End Sub

    Public Sub reset_login()
        txt_user.Text = ""
        txt_pass.Text = ""
        chk_change.Checked = False
        txt_user.Focus()
        AcceptButton = cmd_login
    End Sub

    Public Sub scheduled_backup()

        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT MAX(doe) FROM ttable WHERE (type='Scheduled backup' AND rem='Successful')"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    prebackupdate = dr.Item(0)
                    prebackup = (prebackupdate.Date.AddDays(7)).ToString("MM.dd.yyyy")
                End If
            Else
                prebackup = System.DateTime.Today.ToString("MM.dd.yyyy")
                prebackupdate = System.DateTime.Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
        dr.Close()
        con_cls.cn.Close()
        If DateDiff(DateInterval.Day, prebackupdate.Date, System.DateTime.Today, FirstDayOfWeek.System, FirstWeekOfYear.System) >= 7 Then
            Try
                If Not My.Computer.FileSystem.DirectoryExists("D:\BACKUP") Then
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP")
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP\" & prebackup)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db.mdf", "D:\BACKUP\" & prebackup & "\synod_db.mdf", True)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db_log.LDF", "D:\BACKUP\" & prebackup & "\synod_db_log.LDF", True)
                Else
                    My.Computer.FileSystem.CreateDirectory("D:\BACKUP\" & prebackup)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db.mdf", "D:\BACKUP\" & prebackup & "\synod_db.mdf", True)
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db_log.LDF", "D:\BACKUP\" & prebackup & "\synod_db_log.LDF", True)
                End If
                Try
                    trans_querry.update_trans(0, "Scheduled backup", "Successful")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
            Catch ex As Exception
                Try
                    trans_querry.update_trans(0, "Scheduled backup", "Unsuccessful")
                    MsgBox("Scheduled backup unsuccessful", MsgBoxStyle.OkOnly, "Scheduled backup information")
                Catch ex2 As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
            End Try
        End If

    End Sub

End Class
