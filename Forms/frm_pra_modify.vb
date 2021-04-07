Imports System.Data
Imports System.Data.SqlClient

Public Class frm_pra_modify

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_pra
    Dim querry As New class_querry
    Public initial_date As Date
    Dim start_date As Date
    Public empty_field_status As String

    Private Sub frm_pra_modify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_pra_modify()
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
                        Call enable_pra_modify()
                        dr.Read()
                        txt_area.Text = dr.Item("area")
                        txt_div.Text = dr.Item("div")
                        txt_place.Text = dr.Item("place")
                        txt_po.Text = dr.Item("p_o")
                        txt_ps.Text = dr.Item("p_s")
                        txt_dist.Text = dr.Item("district")
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
                    con_cls.cmd.CommandText = "UPDATE account SET district='" & Trim(txt_dist.Text) & "', area='" & txt_area.Text & "', place='" & _
                    txt_place.Text & "', p_o='" & txt_po.Text & "', p_s='" & txt_ps.Text & "', div='" & txt_div.Text & "' WHERE (acc_no=" & txt_acno.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    MsgBox("Record update successful", MsgBoxStyle.OkOnly, "Information")
                    Try
                        querry.update_trans(txt_acno.Text, "Pathian ram account modified", "Pathian ram account")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_querry error")
                    End Try
                    Call reset_pra_modify()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
                End Try
                con_cls.cn.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset_pra_modify()
    End Sub

    Public Sub reset_pra_modify()
        With txt_acno
            .Text = ""
            .Focus()
            .ReadOnly = False
        End With
        txt_area.Text = ""
        txt_div.Text = ""
        txt_place.Text = ""
        txt_po.Text = ""
        txt_ps.Text = ""
        txt_dist.Text = ""
        txt_area.ReadOnly = True
        txt_place.ReadOnly = True
        txt_po.ReadOnly = True
        txt_ps.ReadOnly = True
        txt_div.ReadOnly = True
        txt_dist.Enabled = False
        cmd_update.Enabled = False
        cmd_search.Enabled = True
        AcceptButton = cmd_search
    End Sub

    Public Sub enable_pra_modify()
        txt_acno.ReadOnly = True
        txt_area.ReadOnly = False
        txt_place.ReadOnly = False
        txt_po.ReadOnly = False
        txt_ps.ReadOnly = False
        txt_div.ReadOnly = False
        txt_dist.Enabled = True
        cmd_update.Enabled = True
        cmd_search.Enabled = False
        AcceptButton = cmd_update
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
            Call valid.acno_validate(txt_acno.Text, txt_acno)
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

    Private Sub cmb_dis_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
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