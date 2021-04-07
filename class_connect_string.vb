Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class class_connect_string

    Public cn As New SqlConnection
    Public cmd As New SqlCommand

    Public Sub connect()
        If Not cn.State = Data.ConnectionState.Open Then
            cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\synod_db.mdf" & ";Integrated Security=True;User Instance=True")
            cmd.Connection = cn
            cn.Open()
        End If
    End Sub

End Class
