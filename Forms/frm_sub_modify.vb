Imports System.Data
Imports System.Data.SqlClient

Public Class frm_sub_modify

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry
    Public empty_field_status As String

    Private Sub frm_sub_modify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If MessageBox.Show("Confirm Record Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If empty_field_status = "OK" Then
                con_cls.connect()
                Call update_total()
                Try
                    con_cls.cmd.CommandText = "UPDATE submit SET p_ram=" & txt_pram.Text & ", ramthar=" & txt_ram.Text & ", buhtham=" & txt_butm.Text & ", sacrament=" & txt_sacr.Text & _
                    ", ss_fee=" & txt_ssaf.Text & ", inne=" & txt_inn.Text & ", misc=" & txt_misc.Text & ", total=" & txt_total.Text & " WHERE (vr_no=" & txt_vrn.Text & " and acc_no=" & txt_acno.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record update successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Pathian ram account submission modified", "Voucher number " & txt_vrn.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Call reset_pra_sub()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
                End Try
                con_cls.cn.Close()
            End If
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
        txt_pram.ReadOnly = True
        txt_ram.ReadOnly = True
        txt_butm.ReadOnly = True
        txt_sacr.ReadOnly = True
        txt_ssaf.ReadOnly = True
        txt_inn.ReadOnly = True
        txt_misc.ReadOnly = True
        cmd_search.Enabled = True
        cmd_update.Enabled = False
        AcceptButton = cmd_search
    End Sub

    Public Sub enable_pra_sub()
        txt_vrn.ReadOnly = True
        txt_pram.ReadOnly = False
        txt_ram.ReadOnly = False
        txt_butm.ReadOnly = False
        txt_sacr.ReadOnly = False
        txt_ssaf.ReadOnly = False
        txt_inn.ReadOnly = False
        txt_misc.ReadOnly = False
        cmd_search.Enabled = False
        cmd_update.Enabled = True
        AcceptButton = cmd_update
    End Sub

    Public Sub update_total()
        If txt_pram.Text = "" Then
            MsgBox("Please enter pathian ram amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_pram.Focus()
            Exit Sub
        ElseIf txt_ram.Text = "" Then
            MsgBox("Please enter ramthar amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ram.Focus()
            Exit Sub
        ElseIf txt_butm.Text = "" Then
            MsgBox("Please enter buhtham amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_butm.Focus()
            Exit Sub
        ElseIf txt_sacr.Text = "" Then
            MsgBox("Please enter sacrament amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_sacr.Focus()
            Exit Sub
        ElseIf txt_ssaf.Text = "" Then
            MsgBox("Please enter affiliation fee (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ssaf.Focus()
            Exit Sub
        ElseIf txt_inn.Text = "" Then
            MsgBox("Please enter inneihna amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_inn.Focus()
            Exit Sub
        ElseIf txt_misc.Text = "" Then
            MsgBox("Please enter misc. amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_misc.Focus()
            Exit Sub
        Else
            txt_total.Text = (CDbl(txt_pram.Text) + CDbl(txt_ram.Text) + CDbl(txt_butm.Text) + CDbl(txt_sacr.Text) + CDbl(txt_ssaf.Text) + CDbl(txt_inn.Text) + CDbl(txt_misc.Text)).ToString
        End If
    End Sub

    '=================================================================
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_acno.Text = "" Then
            MsgBox("Please enter account number", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_acno.Focus()
            Exit Sub
        ElseIf txt_area.Text = "" Then
            MsgBox("Please enter name of area", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_area.Focus()
            Exit Sub
        ElseIf txt_dos.Text = "" Then
            MsgBox("Please enter date of submission", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_dos.Focus()
            Exit Sub
        ElseIf txt_vrn.Text = "" Then
            MsgBox("Please enter voucher number", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_vrn.Focus()
            Exit Sub
        ElseIf txt_pram.Text = "" Then
            MsgBox("Please enter pathian ram amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_pram.Focus()
            Exit Sub
        ElseIf txt_ram.Text = "" Then
            MsgBox("Please enter ramthar amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ram.Focus()
            Exit Sub
        ElseIf txt_butm.Text = "" Then
            MsgBox("Please enter buhtham amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_butm.Focus()
            Exit Sub
        ElseIf txt_sacr.Text = "" Then
            MsgBox("Please enter sacrament amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_sacr.Focus()
            Exit Sub
        ElseIf txt_ssaf.Text = "" Then
            MsgBox("Please enter affiliation fee (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ssaf.Focus()
            Exit Sub
        ElseIf txt_inn.Text = "" Then
            MsgBox("Please enter inneihna amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_inn.Focus()
            Exit Sub
        ElseIf txt_misc.Text = "" Then
            MsgBox("Please enter misc. amount (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_misc.Focus()
            Exit Sub
        ElseIf txt_total.Text = "" Then
            MsgBox("Please enter total amount", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_total.Focus()
            Exit Sub
        Else
            txt_total.Text = (CDbl(txt_pram.Text) + CDbl(txt_ram.Text) + CDbl(txt_butm.Text) + CDbl(txt_sacr.Text) + CDbl(txt_ssaf.Text) + CDbl(txt_inn.Text) + CDbl(txt_misc.Text)).ToString
            empty_field_status = "OK"
        End If
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

    Private Sub txt_pram_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pram.Validating
        Try
            Call valid.txt_amt_validate(txt_pram.Text, txt_pram)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_ram_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ram.Validating
        Try
            Call valid.txt_amt_validate(txt_ram.Text, txt_ram)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_butm_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_butm.Validating
        Try
            Call valid.txt_amt_validate(txt_butm.Text, txt_butm)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_sacr_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sacr.Validating
        Try
            Call valid.txt_amt_validate(txt_sacr.Text, txt_sacr)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_ssaf_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ssaf.Validating
        Try
            Call valid.txt_amt_validate(txt_ssaf.Text, txt_ssaf)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_inn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_inn.Validating
        Try
            Call valid.txt_amt_validate(txt_inn.Text, txt_inn)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_misc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_misc.Validating
        Try
            Call valid.txt_amt_validate(txt_misc.Text, txt_misc)
            Call update_total()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_total_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_total.Validating
        Try
            Call update_total()
            Call valid.txt_amt_validate(txt_total.Text, txt_total)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class