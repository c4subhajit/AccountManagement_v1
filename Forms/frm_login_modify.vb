Imports System.Data
Imports System.Data.SqlClient

Public Class frm_login_modify
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string

    Private Sub frm_login_modify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_login_modify()
    End Sub

    Private Sub cmb_change_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_change.SelectedIndexChanged
        If cmb_change.Text = "Change Username" Then
            lbl_user.Enabled = True
            txt_user.Enabled = True
            lbl_pass.Enabled = False
            txt_pass.Enabled = False
            txt_pass.Text = ""
            txt_user.Focus()
        End If

        If cmb_change.Text = "Change Password" Then
            lbl_pass.Enabled = True
            txt_pass.Enabled = True
            lbl_user.Enabled = False
            txt_user.Enabled = False
            txt_user.Text = ""
            txt_pass.Focus()
        End If
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        con_cls.connect()
        If cmb_change.SelectedItem = "Change Username" Then
            If Not txt_user.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "UPDATE usacc SET un='" & txt_user.Text & "' WHERE pw='" & frm_home.password & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Username Updated Successfully, click continue to proceed to the application", MsgBoxStyle.OkOnly, "Information")
                    Call reset_login_modify()
                    con_cls.cn.Close()
                    Exit Sub
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            Else
                MsgBox("Please enter new username to update or click continue to proceed to the application", MsgBoxStyle.OkOnly, "Information")
            End If
        ElseIf cmb_change.SelectedItem = "Change Password" Then
            If Not txt_pass.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "UPDATE usacc set pw='" & txt_pass.Text & "' WHERE un='" & frm_home.username & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Password Updated Successfully, click continue to proceed to the application", MsgBoxStyle.OkOnly, "Information")
                    Call reset_login_modify()
                    con_cls.cn.Close()
                    Exit Sub
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            Else
                MsgBox("Please enter new password to update or click continue to proceed to the application", MsgBoxStyle.OkOnly, "Information")
            End If
        Else
            MsgBox("Click continue to proceed to the application", MsgBoxStyle.OkOnly, "Information")
        End If
    End Sub

    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        Me.Close()
    End Sub

    Public Sub reset_login_modify()
        cmb_change.SelectedIndex = 0
        lbl_user.Enabled = False
        txt_user.Enabled = False
        txt_user.Text = ""
        lbl_pass.Enabled = False
        txt_pass.Enabled = False
        txt_pass.Text = ""
        AcceptButton = cmd_continue
    End Sub

End Class