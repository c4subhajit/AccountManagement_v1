Imports System
Imports System.Text
Imports System.Windows.Forms

Public Class frm_home
    Dim filename As String
    Dim backUpPath As String
    Dim con_cls As New class_connect_string
    Public acc_no As Int64
    Public from_stat, to_stat As Date
    Public username, password As String

    Private Sub frm_home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim form As New frm_login
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

        Call dbExistCheck()
    End Sub


    Private Sub NewToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem4.Click
        Try
            Dim form As New frm_pra_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ModifyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem4.Click
        Try
            Dim form As New frm_pra_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem4.Click
        Try
            Dim form As New frm_pra_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim form As New frm_sub_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim form As New frm_sub_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Dim form As New frm_sub_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Try
            Dim form As New frm_loan_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Try
            Dim form As New frm_loan_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Try
            Dim form As New frm_loan_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Try
            Dim form As New frm_ins_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Try
            Dim form As New frm_ins_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Try
            Dim form As New frm_ins_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByAccountNumberToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAccountNumberToolStripMenuItem1.Click
        Try
            Dim form As New frm_sr_acno
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub


    Private Sub ByVoucherNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByVoucherNumberToolStripMenuItem.Click
        Try
            Dim form As New frm_sr_vn
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByPaymentNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPaymentNumberToolStripMenuItem.Click
        Try
            Dim form As New frm_sr_pn
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub StatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem.Click
        Try
            Dim form As New frm_statistics
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        Try
            Dim form As New frm_trans
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CalculatorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem1.Click

        Try
            System.Diagnostics.Process.Start("calc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try

    End Sub

    Private Sub NotepadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem1.Click

        Try
            System.Diagnostics.Process.Start("notepad")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try

    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        FBD_dbBackup.ShowDialog()
        Try
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db.mdf", FBD_dbBackup.SelectedPath & "\synod_db.mdf", True)
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db_log.LDF", FBD_dbBackup.SelectedPath & "\synod_db_log.LDF", True)
        Catch ex As Exception
            MsgBox("Backup unsuccessful", MsgBoxStyle.OkOnly, "Backup Information")
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        Try
            Dim form As New frm_about
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub LogoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem2.Click
        Me.Enabled = False
        frm_login.Show()
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub timer_clock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer_clock.Tick
        ToolStripStatusLabel6.Text = My.Computer.Clock.LocalTime.ToString
    End Sub

    Public Sub dbExistCheck()

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\synod_db.mdf") Then
            MsgBox("Software database not found. Please browse database file.", MsgBoxStyle.OkOnly, "Database information")
            OFD_db.ShowDialog()
            filename = My.Computer.FileSystem.GetName(OFD_db.FileName)
            If filename = "synod_db.mdf" Then
                Try
                    My.Computer.FileSystem.CopyFile(OFD_db.FileName, Application.StartupPath & "\" & filename, True)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Database information")
                End Try
            Else
                Call dbExistCheck()
            End If
        End If
        Call failsafe()
    End Sub

    Public Sub failsafe()
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db.mdf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db_log.LDF", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            MsgBox("Failsafe process (delete) unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
        Try
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\synod_db.mdf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db.mdf", True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\synod_db_log.LDF", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\synod_db_log.LDF", True)
        Catch ex As Exception
            MsgBox("Failsafe process unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
       
    End Sub
    
  

End Class
