Imports System.Data
Imports System.Data.SqlClient

Public Class frm_statistics
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string


    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        cmb_acno.Items.Clear()
        If cmb_type.SelectedItem = "" Then
            dtp_from_stat.Value = System.DateTime.Today
            dtp_to_stat.Value = System.DateTime.Today
            dtp_from_stat.Enabled = False
            dtp_to_stat.Enabled = False
        End If
        If cmb_type.SelectedItem = "Pathian ram account" Then
            con_cls.connect()
            dtp_from_stat.Value = System.DateTime.Today
            dtp_to_stat.Value = System.DateTime.Today
            dtp_from_stat.Enabled = True
            dtp_to_stat.Enabled = True
            Try
                con_cls.cmd.CommandText = "SELECT DISTINCT(acc_no) FROM account"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_acno.Items.Add(dr.Item("acc_no"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
            End Try
            con_cls.cn.Close()
        End If
        If cmb_type.SelectedItem = "Loan account" Then
            con_cls.connect()
            dtp_from_stat.Value = System.DateTime.Today
            dtp_to_stat.Value = System.DateTime.Today
            dtp_from_stat.Enabled = False
            dtp_to_stat.Enabled = False
            Try
                con_cls.cmd.CommandText = "SELECT DISTINCT(acc_no) FROM loan"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_acno.Items.Add(dr.Item("acc_no"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
            End Try
            con_cls.cn.Close()
        End If
    End Sub

    Private Sub cmb_acno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_acno.SelectedIndexChanged
        frm_home.acc_no = CLng(cmb_acno.SelectedItem)
    End Sub

    Private Sub dtp_from_stat_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_from_stat.ValueChanged
        frm_home.from_stat = dtp_from_stat.Value
    End Sub

    Private Sub dtp_to_stat_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_to_stat.ValueChanged
        frm_home.to_stat = dtp_to_stat.Value
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        If cmb_type.SelectedItem = "Pathian ram account" Then
            Try
                Dim form As New frm_stat_pra
                form.MdiParent = frm_home
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        ElseIf cmb_type.SelectedItem = "Loan account" Then
            Try
                Dim form As New frm_stat_loan
                form.MdiParent = frm_home
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        cmb_type.SelectedIndex = 0
        cmb_acno.Items.Clear()
    End Sub

    Private Sub frm_statistics_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_from_stat.Value = System.DateTime.Today
        dtp_to_stat.Value = System.DateTime.Today
        dtp_from_stat.Enabled = False
        dtp_to_stat.Enabled = False
    End Sub
End Class