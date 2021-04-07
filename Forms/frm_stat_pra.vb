Public Class frm_stat_pra

    Private Sub frm_stat_pra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1, frm_home.acc_no, frm_home.from_stat, frm_home.to_stat)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class