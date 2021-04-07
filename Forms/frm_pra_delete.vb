Imports System.Data
Imports System.Data.SqlClient

Public Class frm_pra_delete

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry

    Private Sub frm_pra_delete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_pra_delete()
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click
        If Not IsNumeric(txt_acno.Text) Then
            MsgBox("Please check account number", MsgBoxStyle.OkOnly, "Validation error")
            txt_acno.Focus()
        ElseIf txt_acno.Text = "" Then
            MsgBox("Please enter account number", MsgBoxStyle.OkOnly, "Validation error")
            txt_acno.Focus()
        Else
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT * FROM account WHERE (acc_no=" & Trim(txt_acno.Text) & ")"
                dr = con_cls.cmd.ExecuteReader
                Try
                    If dr.HasRows Then
                        Call enable_pra_delete()
                        dr.Read()
                        txt_area.Text = dr.Item("area")
                        txt_div.Text = dr.Item("div")
                        txt_place.Text = dr.Item("place")
                        txt_po.Text = dr.Item("p_o")
                        txt_ps.Text = dr.Item("p_s")
                        txt_dis.Text = dr.Item("district")
                    Else
                        MsgBox("Account number doesnot exist", MsgBoxStyle.OkOnly, "Search result")
                        txt_acno.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read; column name error")
                End Try
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
            End Try
            dr.Close()
            con_cls.cn.Close()
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If MessageBox.Show("Confirm Record Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "DELETE FROM account WHERE (acc_no=" & txt_acno.Text & ")"
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("Record delete successful", MsgBoxStyle.OkOnly, "Information")
                Try
                    querry.update_trans(txt_acno.Text, "Pathian ram account deleted", "Pathian ram account")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
                Call reset_pra_delete()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
            End Try
            con_cls.cn.Close()
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_pra_delete()
    End Sub

    Public Sub reset_pra_delete()
        With txt_acno
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_area.Text = ""
        txt_div.Text = ""
        txt_place.Text = ""
        txt_po.Text = ""
        txt_ps.Text = ""
        txt_dis.Text = ""
        cmd_delete.Enabled = False
        cmd_search.Enabled = True
        AcceptButton = cmd_search
    End Sub

    Public Sub enable_pra_delete()
        txt_acno.ReadOnly = True
        cmd_delete.Enabled = True
        cmd_search.Enabled = False
        AcceptButton = cmd_delete
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_acno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_acno.Validating
        Try
            Call valid.acno_validate(txt_acno.Text, txt_acno)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class