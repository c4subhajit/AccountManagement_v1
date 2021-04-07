Imports System.Data
Imports System.Data.SqlClient

Public Class frm_ins_modify

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_loan
    Dim querry As New class_querry
    Public empty_field_status, update_status As String

    Private Sub frm_ins_modify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_loan_ins()
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        If Not IsNumeric(txt_pmtno.Text) Then
            MsgBox("Please check payment number", MsgBoxStyle.OkOnly, "Validation error")
            txt_pmtno.Focus()
        ElseIf txt_pmtno.Text = "" Then
            MsgBox("Please enter payment number", MsgBoxStyle.OkOnly, "Validation error")
            txt_pmtno.Focus()
        Else
            con_cls.connect()

            Try
                con_cls.cmd.CommandText = "SELECT * FROM installment WHERE (pmt_no=" & Trim(txt_pmtno.Text) & ")"
                dr = con_cls.cmd.ExecuteReader
                Try
                    If dr.HasRows Then
                        Call enable_loan_ins()
                        dr.Read()
                        txt_acno.Text = dr.Item("acc_no")
                        txt_name.Text = dr.Item("name")
                        txt_pmtdate.Text = dr.Item("pmt_date")
                        txt_bb.Text = dr.Item("bb")
                        txt_sp.Text = dr.Item("sp")
                        txt_ep.Text = dr.Item("ep")
                        txt_tp.Text = dr.Item("tp")
                        txt_ir.Text = dr.Item("ir")
                        txt_eb.Text = dr.Item("eb")
                        txt_rem.Text = dr.Item("rem")
                    Else
                        MsgBox("Payment number doesnot exist", MsgBoxStyle.OkOnly, "Search result")
                        txt_pmtno.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read; column name error")
                End Try
                dr.Close()
                con_cls.cn.Close()
                txt_acno.Focus()
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
                    con_cls.cmd.CommandText = "UPDATE installment SET ep=" & txt_ep.Text & ", tp=" & txt_tp.Text & ", ir=" & txt_ir.Text & ", eb=" & txt_eb.Text & ", rem='" & _
                    txt_rem.Text & "' WHERE (pmt_no=" & txt_pmtno.Text & " and acc_no=" & txt_acno.Text & ") "
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record update successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Loan account installment modified", "Payment number " & txt_pmtno.Text)
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

    Public Sub reset_loan_ins()
        With txt_pmtno
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_name.Text = ""
        txt_acno.Text = ""
        txt_pmtdate.Text = ""
        txt_bb.Text = ""
        txt_sp.Text = ""
        txt_ep.Text = ""
        txt_tp.Text = ""
        txt_ir.Text = ""
        txt_eb.Text = ""
        txt_rem.Text = ""
        txt_ep.ReadOnly = True
        txt_ir.ReadOnly = True
        txt_rem.ReadOnly = True
        AcceptButton = cmd_search
        cmd_search.Enabled = True
        cmd_update.Enabled = False
    End Sub

    Public Sub enable_loan_ins()
        txt_pmtno.ReadOnly = True
        txt_ep.ReadOnly = False
        txt_ir.ReadOnly = False
        txt_rem.ReadOnly = False
        AcceptButton = cmd_update
        cmd_search.Enabled = False
        cmd_update.Enabled = True
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

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_pmtno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pmtno.Validating
        Try
            Call valid.acno_validate(txt_pmtno.Text, txt_pmtno)
            con_cls.connect()

            If Not txt_pmtno.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "select * from installment where (pmt_no=" & Trim(txt_pmtno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If Not dr.HasRows Then
                        MsgBox("Payment number doesnot exists.", MsgBoxStyle.OkOnly, "Validation error")
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

    Private Sub txt_acno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_acno.Validating
        Try
            'Call valid.acno_validate(txt_acno.Text, txt_acno)
            con_cls.connect()
            update_status = ""
            If Not txt_acno.Text = "" Then
                Try
                    con_cls.cmd.CommandText = "SELECT MAX(pmt_date) FROM installment WHERE (acc_no=" & Trim(txt_acno.Text) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        If Not dr.IsDBNull(0) Then
                            If CDate(txt_pmtdate.Text).Date < CDate(dr.Item(0)).Date Then
                                MsgBox("Only last payment installment created on " & dr.Item(0) & " can be modified", MsgBoxStyle.OkOnly, "Validation error")
                                txt_pmtno.Focus()
                                Call reset_loan_ins()
                                dr.Close()
                                Exit Sub
                            Else
                                txt_acno.ReadOnly = True
                            End If
                        End If
                    Else
                        MsgBox("Account number not found while checking for payment date", MsgBoxStyle.OkOnly, "Validation error")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_connect_string error")
                End Try

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