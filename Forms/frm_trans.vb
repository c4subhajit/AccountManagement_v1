Imports System.Data
Imports System.Data.SqlClient

Public Class frm_trans
    Dim dt As DataTable
    Dim con_cls As New class_connect_string

    Private Sub frm_trans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click

        '===================================================
        '            TRANSACTION BY TYPE SEARCH
        '===================================================

        If Not cmb_type.SelectedItem = "" Then
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT tid,doe,acc_no,type,rem FROM ttable WHERE (type='" & cmb_type.SelectedItem & "')"
            Dim dt As New DataTable
            dt.Load(con_cls.cmd.ExecuteReader)
            dgv_tt.AutoGenerateColumns = True
            dgv_tt.DataSource = dt
            con_cls.cn.Close()
        End If

    End Sub

End Class