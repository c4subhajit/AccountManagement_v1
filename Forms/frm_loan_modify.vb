Imports System.Data
Imports System.Data.SqlClient

Public Class frm_loan_modify

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_loan
    Dim querry As New class_querry
    Public initial_date As Date
    Dim start_date As Date
    Public empty_field_status As String

    Private Sub frm_loan_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_loan()
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
                con_cls.cmd.CommandText = "SELECT * FROM loan WHERE (acc_no=" & Trim(txt_acno.Text) & ")"
                dr = con_cls.cmd.ExecuteReader
                Try
                    If dr.HasRows Then
                        Call enable_all()
                        dr.Read()
                        txt_name.Text = dr.Item("name")
                        txt_lamt.Text = dr.Item("loan_amt")
                        txt_air.Text = dr.Item("air")
                        txt_lp.Text = dr.Item("period")
                        If dr.Item("p_type") = "MONTH(S)" Then
                            cmb_ptype.SelectedIndex = 1
                        ElseIf dr.Item("p_type") = "YEAR(S)" Then
                            cmb_ptype.SelectedIndex = 2
                        End If

                        txt_nppy.Text = dr.Item("nppy")
                        txt_start.Text = dr.Item("start")
                        initial_date = CDate(txt_start.Text)
                        txt_sp.Text = dr.Item("sp")
                        txt_snp.Text = dr.Item("snp")
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

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If MessageBox.Show("Confirm Record Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If empty_field_status = "OK" Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "UPDATE loan SET name='" & Trim(txt_name.Text) & "', loan_amt=" & txt_lamt.Text & ", air=" & _
                    txt_air.Text & ", period=" & txt_lp.Text & ", p_type='" & cmb_ptype.SelectedItem & "', nppy=" & txt_nppy.Text & ", start='" & _
                    txt_start.Text & "', snp=" & txt_snp.Text & ", sp=" & txt_sp.Text & " WHERE (acc_no=" & txt_acno.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record update successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Loan account modified", "Loan account")
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
        With txt_acno
            .Text = ""
            .Focus()
            .ReadOnly = False
        End With
        txt_name.Text = ""
        txt_lamt.Text = ""
        txt_air.Text = ""
        txt_lp.Text = ""
        txt_nppy.Text = ""
        txt_start.Text = ""
        txt_sp.Text = ""
        txt_snp.Text = ""
        cmb_ptype.SelectedIndex = 0
        AcceptButton = cmd_search
        txt_name.ReadOnly = True
        txt_lamt.ReadOnly = True
        txt_air.ReadOnly = True
        txt_lp.ReadOnly = True
        txt_nppy.ReadOnly = True
        txt_sp.ReadOnly = True
        txt_snp.ReadOnly = True
        dtp_date.Enabled = False
        cmb_ptype.Enabled = False
        cmd_update.Enabled = False
        cmd_search.Enabled = True
    End Sub

    Public Sub enable_all()
        txt_acno.ReadOnly = True
        txt_name.ReadOnly = False
        txt_lamt.ReadOnly = False
        txt_air.ReadOnly = False
        txt_lp.ReadOnly = False
        txt_nppy.ReadOnly = False
        txt_sp.ReadOnly = False
        txt_snp.ReadOnly = False
        dtp_date.Enabled = True
        cmb_ptype.Enabled = True
        cmd_update.Enabled = True
        cmd_search.Enabled = False
        AcceptButton = cmd_update
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
            Call valid.acno_validate(txt_acno.Text, txt_acno)
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

    Private Sub txt_lp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
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
            Call valid.date_range_validate(txt_start.Text, initial_date, dtp_date, txt_start)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub dtp_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtp_date.Validating
        Try
            Call valid.date_range_validate(txt_start.Text, initial_date, dtp_date, txt_start)
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