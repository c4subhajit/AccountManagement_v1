Imports System.Data
Imports System.Data.SqlClient

Public Class frm_sub_delete
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry
   
    Private Sub frm_sub_delete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_pra_sub()
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click
        If Not IsNumeric(txt_vrn.Text) Then
            MsgBox("Please check voucher number", MsgBoxStyle.OkOnly, "Validation error")
            txt_vrn.Focus()
        ElseIf txt_vrn.Text = "" Then
            MsgBox("Please enter voucher number", MsgBoxStyle.OkOnly, "Validation error")
            txt_vrn.Focus()
        Else
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT * FROM submit WHERE (vr_no=" & Trim(txt_vrn.Text) & ")"
                dr = con_cls.cmd.ExecuteReader
                Try
                    If dr.HasRows Then
                        Call enable_pra_sub()
                        dr.Read()
                        txt_acno.Text = dr.Item("acc_no")
                        txt_area.Text = dr.Item("area")
                        txt_dos.Text = dr.Item("dos")
                        txt_pram.Text = dr.Item("p_ram")
                        txt_ram.Text = dr.Item("ramthar")
                        txt_butm.Text = dr.Item("buhtham")
                        txt_sacr.Text = dr.Item("sacrament")
                        txt_ssaf.Text = dr.Item("ss_fee")
                        txt_inn.Text = dr.Item("inne")
                        txt_misc.Text = dr.Item("misc")
                        txt_total.Text = dr.Item("total")
                    Else
                        MsgBox("Voucher number doesnot exist", MsgBoxStyle.OkOnly, "Search result")
                        txt_vrn.Focus()
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
                con_cls.cmd.CommandText = "DELETE FROM submit WHERE (vr_no=" & txt_vrn.Text & ")"
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("Record delete successful", MsgBoxStyle.OkOnly, "Information")
                Try
                    querry.update_trans(txt_acno.Text, "Pathian ram account submission deleted", "Voucher number " & txt_vrn.Text)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                End Try
                Call reset_pra_sub()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
            End Try
            con_cls.cn.Close()
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_pra_sub()
    End Sub

    Public Sub reset_pra_sub()
        With txt_vrn
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_acno.Text = ""
        txt_area.Text = ""
        txt_dos.Text = ""
        txt_pram.Text = ""
        txt_ram.Text = ""
        txt_butm.Text = ""
        txt_sacr.Text = ""
        txt_ssaf.Text = ""
        txt_inn.Text = ""
        txt_misc.Text = ""
        txt_total.Text = ""
        cmd_search.Enabled = True
        cmd_delete.Enabled = False
        AcceptButton = cmd_search
    End Sub

    Public Sub enable_pra_sub()
        txt_vrn.ReadOnly = True
        cmd_search.Enabled = False
        cmd_delete.Enabled = True
        AcceptButton = cmd_delete
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_vrn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_vrn.Validating
        Try
            Call valid.acno_validate(txt_vrn.Text, txt_vrn)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub
End Class