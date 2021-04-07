Imports System.Data
Imports System.Data.SqlClient

Public Class frm_sub_new

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry
    Public empty_field_status, update_status As String

    Private Sub frm_sub_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_pra_sub()
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If empty_field_status = "OK" Then
                con_cls.connect()
                Call update_total()
                Try
                    con_cls.cmd.CommandText = "INSERT INTO submit (acc_no,area,dos,vr_no,p_ram,ramthar,buhtham,sacrament,ss_fee,inne,misc,total) VALUES (" & txt_acno.Text & ",'" & _
                    txt_area.Text & "','" & CDate(txt_dos.Text) & "'," & txt_vrn.Text & "," & txt_pram.Text & "," & txt_ram.Text & "," & txt_butm.Text & "," & txt_sacr.Text & "," & _
                    txt_ssaf.Text & "," & txt_inn.Text & "," & txt_misc.Text & "," & txt_total.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record insert successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Pathian ram account submission created", "Voucher number " & txt_vrn.Text)
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

    Private Sub dtp_dos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dos.ValueChanged
        txt_dos.Text = dtp_dos.Value
    End Sub

    Public Sub reset_pra_sub()
        With txt_acno
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_area.Text = ""
        txt_dos.Text = ""
        txt_vrn.Text = ""
        txt_pram.Text = ""
        txt_ram.Text = ""
        txt_butm.Text = ""
        txt_sacr.Text = ""
        txt_ssaf.Text = ""
        txt_inn.Text = ""
        txt_misc.Text = ""
        txt_total.Text = ""
        AcceptButton = cmd_ok
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
            empty_field_status = "OK"
        End If
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_acno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_acno.Validating
        Try
            Call valid.acno_validate(txt_acno.Text, txt_acno)
            con_cls.connect()
            update_status = ""
            If Not txt_acno.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "select * from account where (acc_no = " & Trim(txt_acno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If Not dr.HasRows Then
                        MsgBox("Account number doesnot exists.", MsgBoxStyle.OkOnly, "Validation error")
                        txt_acno.Clear()
                        txt_acno.Focus()
                        dr.Close()
                        Exit Sub
                    Else
                        dr.Read()
                        txt_area.Text = dr.Item("area")
                        dtp_dos.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation account number exception info")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_area_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_area.Validating
        Try
            Call valid.txt_name_validate(txt_area.Text, txt_area)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_dos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dos.Validating
        Try
            Call valid.txt_date_validate(txt_dos.Text, dtp_dos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub dtp_dos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Call valid.date_validate(txt_dos.Text, dtp_dos.Value, dtp_dos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_vrn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_vrn.Validating
        Try
            Call valid.acno_validate(txt_vrn.Text, txt_vrn)
            con_cls.connect()

            If Not txt_vrn.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "select * from submit where (vr_no=" & Trim(txt_vrn.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Voucher number already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        txt_vrn.Clear()
                        txt_vrn.Focus()
                        dr.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation account number exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
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