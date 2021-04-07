Imports System.Data
Imports System.Data.SqlClient

Public Class frm_ins_new

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_loan
    Dim querry As New class_querry
    Public empty_field_status, update_status As String

    Private Sub frm_ins_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_loan_ins()
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If empty_field_status = "OK" Then
                con_cls.connect()
                Call update_total()
                Try
                    con_cls.cmd.CommandText = "INSERT INTO installment (acc_no,name,pmt_no,pmt_date,bb,sp,ep,tp,ir,eb,rem) VALUES (" & txt_acno.Text & ",'" & Trim(txt_name.Text) & "'," & _
                    txt_pmtno.Text & ",'" & CDate(txt_pmtdate.Text) & "'," & txt_bb.Text & "," & txt_sp.Text & "," & txt_ep.Text & "," & txt_tp.Text & "," & _
                    txt_ir.Text & "," & txt_eb.Text & ",'" & txt_rem.Text & "')"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record insert successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Loan account installment created", "Payment number " & txt_pmtno.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Try
                        If CDbl(txt_eb.Text) = 0.0 Then
                            querry.update_trans(txt_acno.Text, "Loan account installment(s) cleared", "Payment number " & txt_pmtno.Text)
                            querry.update_trans(txt_acno.Text, "Loan account closed", "Loan account number " & txt_acno.Text)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Call reset_loan_ins()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
                End Try
                con_cls.cn.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_loan_ins()
    End Sub

    Private Sub dtp_start_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_pmtdate.ValueChanged
        txt_pmtdate.Text = dtp_pmtdate.Value
    End Sub

    Public Sub reset_loan_ins()
        With txt_acno
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_name.Text = ""
        txt_pmtno.Text = ""
        txt_pmtdate.Text = ""
        txt_bb.Text = ""
        txt_sp.Text = ""
        txt_ep.Text = ""
        txt_tp.Text = ""
        txt_ir.Text = ""
        txt_eb.Text = ""
        txt_rem.Text = ""
        AcceptButton = cmd_ok
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
        ElseIf txt_name.Text = "" Then
            MsgBox("Please enter account name", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_name.Focus()
            Exit Sub
        ElseIf txt_pmtno.Text = "" Then
            MsgBox("Please enter payment number", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_pmtno.Focus()
            Exit Sub
        ElseIf txt_pmtdate.Text = "" Then
            MsgBox("Please enter payment date", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_pmtdate.Focus()
            Exit Sub
        ElseIf txt_bb.Text = "" Then
            MsgBox("Please enter beginning balance", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_bb.Focus()
            Exit Sub
        ElseIf txt_sp.Text = "" Then
            MsgBox("Please enter scheduled payment", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_sp.Focus()
            Exit Sub
        ElseIf txt_ep.Text = "" Then
            MsgBox("Please enter extra payment (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ep.Focus()
            Exit Sub
        ElseIf txt_tp.Text = "" Then
            MsgBox("Please enter total payment", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_tp.Focus()
            Exit Sub
        ElseIf txt_ir.Text = "" Then
            MsgBox("Please enter interest (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ir.Focus()
            Exit Sub
        ElseIf txt_eb.Text = "" Then
            MsgBox("Please enter ending balance", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_eb.Focus()
            Exit Sub
        ElseIf txt_rem.Text = "" Then
            MsgBox("Please enter remarks", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_rem.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    Public Sub update_total()
        If txt_ep.Text = "" Then
            MsgBox("Please enter extra payment (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ep.Focus()
            Exit Sub
        ElseIf txt_ir.Text = "" Then
            MsgBox("Please enter interest (Zero(0) if nil)", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ir.Focus()
            Exit Sub
        Else
            txt_eb.Text = (CDbl(txt_bb.Text) - (CDbl(txt_sp.Text) + CDbl(txt_ep.Text) + CDbl(txt_ir.Text))).ToString
        End If
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================


    Private Sub txt_acno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_acno.Validating
        Try
            If Not txt_acno.Text = "" Then
                Call valid.acno_validate(txt_acno.Text, txt_acno)
                con_cls.connect()
                update_status = ""
                Try
                    con_cls.cmd.CommandText = "select * from loan where (acc_no = " & Trim(txt_acno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If Not dr.HasRows Then
                        MsgBox("Account number doesnot exists.", MsgBoxStyle.OkOnly, "Validation error")
                        txt_acno.Clear()
                        txt_acno.Focus()
                        dr.Close()
                        Exit Sub
                    Else
                        dr.Read()
                        txt_name.Text = dr.Item("name")
                        txt_sp.Text = dr.Item("sp")
                        txt_pmtno.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation account number exception info")
                End Try
                dr.Close()
                Try
                    con_cls.cmd.CommandText = "SELECT MIN(eb) FROM installment WHERE (acc_no=" & txt_acno.Text & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If Not dr.IsDBNull(0) Then
                            txt_bb.Text = dr.Item(0)
                        Else
                            update_status = "failed"
                        End If
                        dr.Close()
                    End If
                    If update_status = "failed" Then
                        Try
                            con_cls.cmd.CommandText = "SELECT loan_amt FROM loan WHERE (acc_no=" & txt_acno.Text & ")"
                            dr = con_cls.cmd.ExecuteReader
                            If dr.HasRows Then
                                dr.Read()
                                If Not dr.IsDBNull(0) Then
                                    txt_bb.Text = dr.Item(0)
                                End If
                            End If
                            dr.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                        End Try
                    End If
                    Try
                        con_cls.cmd.CommandText = "SELECT MIN(eb) FROM installment WHERE (acc_no=" & txt_acno.Text & ")"
                        dr = con_cls.cmd.ExecuteReader
                        If dr.HasRows Then
                            dr.Read()
                            If Not dr.IsDBNull(0) Then
                                If CDbl(dr.Item(0)) = 0.0 Then
                                    MsgBox("Loan amount cleared, no more installment due.", MsgBoxStyle.OkOnly, "Loan Status")
                                    Call reset_loan_ins()
                                    dr.Close()
                                    Exit Sub
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_pmtno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pmtno.Validating
        Try
            If Not txt_pmtno.Text = "" Then
                Call valid.acno_validate(txt_pmtno.Text, txt_pmtno)
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "select * from installment where (pmt_no=" & Trim(txt_pmtno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Payment number already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        txt_pmtno.Clear()
                        txt_pmtno.Focus()
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

    Private Sub txt_pmtdate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pmtdate.Validating
        Try
            Call valid.txt_date_validate(txt_pmtdate.Text, txt_pmtdate)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub dtp_start_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtp_pmtdate.Validating
        Try
            If txt_pmtdate.Text <> "" And txt_acno.Text <> "" Then
                Call valid.date_validate(txt_pmtdate.Text, dtp_pmtdate.Value, dtp_pmtdate)
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "SELECT start FROM loan WHERE (acc_no=" & Trim(txt_acno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If CDate(txt_pmtdate.Text) < CDate(dr.Item("start")) Then
                            MsgBox("Payment date cannot be earlier to account creation date", MsgBoxStyle.OkOnly, "Validation error")
                            dtp_pmtdate.Focus()
                            dr.Close()
                            Exit Sub
                        End If
                    Else
                        MsgBox("Account number not found while checking for payment date", MsgBoxStyle.OkOnly, "Validation error")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                End Try
                dr.Close()
                Try
                    con_cls.cmd.CommandText = "SELECT MAX(pmt_date) FROM installment WHERE (acc_no=" & Trim(txt_acno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If Not dr.IsDBNull(0) Then
                            If CDate(txt_pmtdate.Text) < CDate(dr.Item(0)) Then
                                MsgBox("Payment date cannot be earlier to the last payment creation date " & dr.Item(0), MsgBoxStyle.OkOnly, "Validation error")
                                dtp_pmtdate.Focus()
                                dr.Close()
                                Exit Sub
                            End If
                        End If
                    Else
                        MsgBox("Account number not found while checking for payment date", MsgBoxStyle.OkOnly, "Validation error")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_ep_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ep.Validating
        Try
            Call valid.txt_lamt_validate(txt_ep.Text, txt_ep)
            If Not valid.err_code = 1 Then
                If txt_ir.Text = "" And txt_ep.Text <> "" Then
                    If CDbl(txt_ep.Text) > CDbl(txt_bb.Text) Then
                        MsgBox("Extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ep.Clear()
                        txt_ep.Focus()
                        Exit Sub
                    End If
                    If (CDbl(txt_ep.Text) + CDbl(txt_sp.Text)) > CDbl(txt_bb.Text) Then
                        MsgBox("Total of scheduled payment and extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ep.Clear()
                        txt_ep.Focus()
                        Exit Sub
                    End If
                End If
                If Not (txt_ir.Text = "" Or txt_ep.Text = "") Then
                    If (CDbl(txt_ep.Text) + CDbl(txt_sp.Text) + CDbl(txt_ir.Text)) > CDbl(txt_bb.Text) Then
                        MsgBox("Total of scheduled payment, interest and extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ep.Clear()
                        txt_ep.Focus()
                        Exit Sub
                    End If
                End If

                If Not txt_ep.Text = "" Then
                    txt_tp.Text = (CDbl(txt_sp.Text) + CDbl(txt_ep.Text)).ToString
                Else
                    txt_tp.Text = txt_sp.Text
                End If
                txt_ir.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try

    End Sub

    Private Sub txt_ir_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ir.Validating
        Try
            Call valid.txt_lamt_validate(txt_ir.Text, txt_ir)
            If Not valid.err_code = 1 Then
                If txt_ir.Text = "" And txt_ep.Text <> "" Then
                    If CDbl(txt_ep.Text) > CDbl(txt_bb.Text) Then
                        MsgBox("Extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ep.Clear()
                        txt_ep.Focus()
                        Exit Sub
                    End If
                    If (CDbl(txt_ep.Text) + CDbl(txt_sp.Text)) > CDbl(txt_bb.Text) Then
                        MsgBox("Total of scheduled payment and extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ep.Clear()
                        txt_ep.Focus()
                        Exit Sub
                    End If
                End If
                If Not (txt_ir.Text = "" Or txt_ep.Text = "") Then
                    If (CDbl(txt_ep.Text) + CDbl(txt_sp.Text) + CDbl(txt_ir.Text)) > CDbl(txt_bb.Text) Then
                        MsgBox("Total of scheduled payment, interest and extra payment cannot be more than beginning balance", MsgBoxStyle.OkOnly, "Validation error")
                        txt_ir.Clear()
                        txt_ir.Focus()
                        Exit Sub
                    End If
                End If
                Call update_total()
                txt_rem.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_rem_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_rem.Validating
        Try
            Call valid.remark_validate(txt_rem.Text, txt_rem)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class