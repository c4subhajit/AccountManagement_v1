Imports System.Data
Imports System.Data.SqlClient

Public Class frm_sr_acno

    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string


    Private Sub cmd_search_pra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search_pra.Click
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT * FROM account WHERE acc_no=" & txt_acno_pra.Text
            dr = con_cls.cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
        End Try
        Try
            If dr.HasRows Then
                dr.Read()
                txt_area.Text = dr.Item("area")
                txt_dis.Text = dr.Item("district")
                txt_place.Text = dr.Item("place")
                txt_po.Text = dr.Item("p_o")
                txt_ps.Text = dr.Item("p_s")
                txt_div.Text = dr.Item("div")
            Else
                MsgBox("Account number doesnot exist", MsgBoxStyle.OkOnly, "Search error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read; column name error")
        End Try
        dr.Close()
        con_cls.cn.Close()
    End Sub

    Private Sub cmd_reset_pra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset_pra.Click
        Call reset_pra()
    End Sub

    Private Sub cmd_search_loan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search_loan.Click

        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT * FROM loan WHERE (acc_no=" & Trim(txt_acno_loan.Text) & ")"
            dr = con_cls.cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
        End Try
        Try
            If dr.HasRows Then
                dr.Read()
                txt_name.Text = dr.Item("name")
                txt_lamt.Text = dr.Item("loan_amt")
                txt_air.Text = dr.Item("air")
                txt_lp.Text = dr.Item("period") & " " & dr.Item("p_type")
                txt_nppy.Text = dr.Item("nppy")
                txt_start.Text = dr.Item("start")
                txt_sp.Text = dr.Item("sp")
                txt_snp.Text = dr.Item("snp")
            Else
                MsgBox("Account number doesnot exist", MsgBoxStyle.OkOnly, "Search error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read; column name error")
        End Try
        dr.Close()
        con_cls.cn.Close()
    End Sub

    Private Sub cmd_reset_loan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset_loan.Click
        Call reset_loan()
    End Sub

    Public Sub reset_pra()
        txt_acno_pra.Text = ""
        txt_area.Text = ""
        txt_div.Text = ""
        txt_place.Text = ""
        txt_po.Text = ""
        txt_ps.Text = ""
        txt_acno_pra.Focus()
    End Sub

    Public Sub reset_loan()
        txt_acno_loan.Text = ""
        txt_name.Text = ""
        txt_lamt.Text = ""
        txt_air.Text = ""
        txt_lp.Text = ""
        txt_nppy.Text = ""
        txt_start.Text = ""
        txt_sp.Text = ""
        txt_snp.Text = ""
        txt_acno_loan.Focus()
    End Sub

End Class