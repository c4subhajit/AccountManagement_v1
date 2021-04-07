Public Class frm_stat_loan

    Private Sub frm_stat_loan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.installment' table. You can move, or remove it, as needed.
        Me.installmentTableAdapter.Fill(Me.DataSet1.installment, frm_home.acc_no)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class