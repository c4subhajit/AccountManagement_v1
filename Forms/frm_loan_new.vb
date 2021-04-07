Public Class frm_loan_new

    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_loan
    Dim querry As New class_querry
    Public empty_field_status As String

    Private Sub frm_loan_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AcceptButton = cmd_ok
        Call reset_loan()
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If empty_field_status = "OK" Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "INSERT INTO loan (acc_no,name,loan_amt,air,period,p_type,nppy,start,snp,sp) VALUES (" & txt_acno.Text & ",'" & Trim(txt_name.Text) & "'," & _
                    txt_lamt.Text & "," & txt_air.Text & "," & txt_lp.Text & ",'" & cmb_ptype.SelectedItem & "'," & txt_nppy.Text & ",'" & CDate(txt_start.Text) & "'," & _
                    txt_snp.Text & "," & txt_sp.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record insert successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Loan account created", "Loan account")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Call reset_loan()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
                End Try
                con_cls.cn.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_loan()
    End Sub

    Public Sub reset_loan()
        txt_acno.Text = ""
        txt_name.Text = ""
        txt_lamt.Text = ""
        txt_air.Text = ""
        txt_lp.Text = ""
        txt_nppy.Text = ""
        txt_start.Text = ""
        txt_sp.Text = ""
        txt_snp.Text = ""
        cmb_ptype.SelectedIndex = 0
        txt_acno.Focus()
    End Sub

    Private Sub dtp_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_date.ValueChanged
        txt_start.Text = dtp_date.Value
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
        ElseIf txt_lamt.Text = "" Then
            MsgBox("Please enter loan amount", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_lamt.Focus()
            Exit Sub
        ElseIf txt_air.Text = "" Then
            MsgBox("Please enter interest rate", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_air.Focus()
            Exit Sub
        ElseIf txt_lp.Text = "" Then
            MsgBox("Please enter loan period", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_lp.Focus()
            Exit Sub
        ElseIf cmb_ptype.SelectedItem = "" Then
            MsgBox("Please select loan period type", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_ptype.Focus()
            Exit Sub
        ElseIf txt_nppy.Text = "" Then
            MsgBox("Please enter number of payment per year", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_nppy.Focus()
            Exit Sub
        ElseIf txt_start.Text = "" Then
            MsgBox("Please enter starting date", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            dtp_date.Focus()
            Exit Sub
        ElseIf txt_snp.Text = "" Then
            MsgBox("Please enter scheduled number of payment", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_snp.Focus()
            Exit Sub
        ElseIf txt_sp.Text = "" Then
            MsgBox("Please enter schedule payment", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_sp.Focus()
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
            Call valid.txt_acno_validate(txt_acno.Text, txt_acno)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_name_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_name.Validating
        Try
            Call valid.txt_name_validate(txt_name.Text, txt_name)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_lamt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lamt.Validating
        Try
            Call valid.txt_lamt_validate(txt_lamt.Text, txt_lamt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_air_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_air.Validating
        Try
            Call valid.txt_air_validate(txt_air.Text, txt_air)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_lp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lp.Validating
        Try
            Call valid.txt_lp_validate(txt_lp.Text, txt_lp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub cmb_ptype_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_ptype.Validating
        Try
            Call valid.cmb_ptype_validate(cmb_ptype.SelectedItem, txt_lp.Text, txt_lp, cmb_ptype)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nppy_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nppy.Validating
        Try
            Call valid.txt_nppy_validate(txt_nppy.Text, txt_nppy)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_start_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_start.Validating
        Try
            Call valid.txt_date_validate(txt_start.Text, txt_start)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub dtp_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtp_date.Validating
        Try
            Call valid.date_validate(txt_start.Text, dtp_date.Value, dtp_date)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_snp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_snp.Validating
        Try
            Call valid.txt_snp_validate(txt_snp.Text, txt_snp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_sp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sp.Validating
        Try
            Call valid.txt_sp_validate(txt_sp.Text, txt_lamt.Text, txt_sp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class