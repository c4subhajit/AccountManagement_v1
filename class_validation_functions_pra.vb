Imports System.Data
Imports System.Data.SqlClient

Public Class class_validation_functions_pra
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string

    Public a, c As String
    Public b, e As Control
    Public d As Date
    Public charecter As Char
    Public ascii As Integer
    Public decimal_count, digit_after_decimal, digit_before_decimal As Integer
    Private acctype As String
    Public err_code As Integer

    ' ACCOUNT NUMBER AND ACCOUNT NUMBER EXIST VALIDATION
    Public Sub txt_acno_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not (ascii >= 48 And ascii <= 57) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
            Next
            If Not Len(a) <= 18 Then
                err_code = 1
                MsgBox("Account number limitation within 18 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If

            con_cls.connect()

            If Not a = "" Then
                Try
                    con_cls.cmd.CommandText = "select * from account where (acc_no = " & Trim(a) & ")"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Account number already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        b.Focus()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation account number exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        End If
    End Sub

    ' ACCOUNT NUMBER FOR SEARCH VALIDATION
    Public Sub acno_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not (ascii >= 48 And ascii <= 57) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
            Next
            If Not Len(a) <= 18 Then
                err_code = 1
                MsgBox("Account number limitation within 18 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' NAME VALIDATION
    Public Sub txt_name_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not (ascii = 32 Or (ascii > 43 And ascii < 47) Or (ascii >= 65 And ascii <= 90) _
                        Or (ascii >= 97 And ascii <= 122) Or (ascii > 47 And ascii < 58)) Then
                    err_code = 1
                    MsgBox("Number(s) and special charecter(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit For
                End If
            Next
            If Not Len(a) <= 50 Then
                err_code = 1
                MsgBox("Name field limitation within 50 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub
	
	    ' SUBMISSION DATE OF PATHIAN RAM ACCOUNT
    Public Sub txt_date_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            Dim current_date As Date
            current_date = System.DateTime.Today
            If CDate(a) < current_date Then
                err_code = 1
                MsgBox("Please check the date, earlier date not allowed", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub
	
	' STARTING DATE
    Public Sub date_validate(ByVal a, ByVal d, ByRef b)
        If Not a = "" Then
            err_code = 0
            Dim current_date As Date
            current_date = System.DateTime.Today
            If d < current_date Then
                err_code = 1
                MsgBox("Please check the date, earlier date not allowed", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

	    ' STARTING DATE RANGE
    Public Sub date_range_validate(ByVal a, ByVal d, ByRef b, ByRef e)
        If Not a = "" Then
            err_code = 0
            Dim lower_date_range, upper_date_range As Date
            lower_date_range = CDate(d).AddMonths(-1)
            upper_date_range = CDate(d).AddMonths(+1)
            If Not ((CDate(a) >= lower_date_range) And (CDate(a) <= upper_date_range)) Then
                err_code = 1
                MsgBox("Please check the date, modification of date not allowed beyond +/- 1 month range", MsgBoxStyle.OkOnly, "Validation error")
                e.text = d
                b.value = d
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub
	
	    ' AMOUNT VALIDATION
    Public Sub txt_amt_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 3 Then
                err_code = 1
                MsgBox("Only two digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 20 Then
                err_code = 1
                MsgBox("Amount limitation within 20 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub
End Class
