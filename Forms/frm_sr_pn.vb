Imports System.Data
Imports System.Data.SqlClient

Public Class frm_sr_pn
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions_loan
    Dim querry As New class_querry
    Public empty_field_status, update_status As String

    Private Sub frm_sr_pn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                        txt_pmtno.Clear()
                        txt_pmtno.Focus()
                        Exit Sub
                    End If
                    dr.Close()
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
        AcceptButton = cmd_search
    End Sub

    Public Sub enable_loan_ins()
        txt_pmtno.ReadOnly = True
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_pmtno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pmtno.Validating
        Try
            Call valid.acno_validate(txt_pmtno.Text, txt_pmtno)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class