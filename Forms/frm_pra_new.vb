Public Class frm_pra_new
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry
    Public empty_field_status As String

    Private Sub frm_pra_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_pra_new()
    End Sub


    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click

        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call check_empty_fields()
            If Not IsNumeric(txt_acno.Text) Then
                MsgBox("Please check account number", MsgBoxStyle.OkOnly, "Validation error")
            ElseIf txt_acno.Text = "" Then
                MsgBox("Please enter account number", MsgBoxStyle.OkOnly, "Validation error")
            ElseIf empty_field_status = "OK" Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "INSERT INTO account (acc_no,district,area,place,p_o,p_s,div) VALUES (" & Trim(txt_acno.Text) & ",'" & txt_dist.Text & "','" & _
                     Trim(txt_area.Text) & "','" & Trim(txt_place.Text) & "','" & Trim(txt_po.Text) & "','" & Trim(txt_ps.Text) & "','" & Trim(txt_div.Text) & "')"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record insert successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Pathian ram account created", "Pathian ram account")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Call reset_pra_new()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
                End Try
            End If
        End If

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_pra_new()
    End Sub

    Public Sub reset_pra_new()
        txt_acno.Text = ""
        txt_area.Text = ""
        txt_div.Text = ""
        txt_place.Text = ""
        txt_po.Text = ""
        txt_ps.Text = ""
        txt_dist.Text = ""
        txt_acno.Focus()
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
        ElseIf txt_area.Text = "" Then
            MsgBox("Please enter name of area", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_area.Focus()
            Exit Sub
        ElseIf txt_dist.Text = "" Then
            MsgBox("Please select one district", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_dist.Focus()
            Exit Sub
        ElseIf txt_place.Text = "" Then
            MsgBox("Please enter place", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_place.Focus()
            Exit Sub
        ElseIf txt_po.Text = "" Then
            MsgBox("Please enter post office", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_po.Focus()
            Exit Sub
        ElseIf txt_ps.Text = "" Then
            MsgBox("Please enter police station", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_ps.Focus()
            Exit Sub
        ElseIf txt_div.Text = "" Then
            MsgBox("Please enter division", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_div.Focus()
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

    Private Sub txt_area_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_area.Validating
        Try
            Call valid.txt_name_validate(txt_area.Text, txt_area)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_dist_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dist.Validating
        Try
            If txt_dist.Text = "" Then
                MsgBox("Please select one district", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                txt_dist.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_place_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_place.Validating
        Try
            Call valid.txt_name_validate(txt_place.Text, txt_place)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_po_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_po.Validating
        Try
            Call valid.txt_name_validate(txt_po.Text, txt_po)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_ps_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ps.Validating
        Try
            Call valid.txt_name_validate(txt_ps.Text, txt_ps)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_div_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_div.Validating
        Try
            Call valid.txt_name_validate(txt_div.Text, txt_div)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class