Imports System.Data
Imports System.Data.SqlClient

Public Class class_querry

    Dim con_cls As New class_connect_string
    Dim dr As SqlDataReader
    Dim acc_no, type, remark As String
    Dim t_id As Integer
    
    Public Sub update_trans(ByVal acc_no, ByVal type, ByVal remark)
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "SELECT MAX(tid) FROM ttable"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    t_id = CInt(dr.Item(0))
                    t_id += 1
                Else
                    t_id = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Transaction ID sql querry block error")
        End Try
        dr.Close()
        Try
            con_cls.cmd.CommandText = "INSERT INTO ttable (tid,doe,acc_no,type,rem) VALUES (" & t_id & ",'" & System.DateTime.Now & "'," & acc_no & ",'" & type & "','" & remark & "')"
            con_cls.cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Transaction Sql querry block error")
        End Try
        con_cls.cn.Close()
    End Sub

End Class
