Imports System.Data
Imports System.Data.SqlClient


Public Class class_validation_functions_loan
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
                    con_cls.cmd.CommandText = "select * from loan where (acc_no = " & Trim(a) & ")"
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
                If Not (ascii = 32 Or ascii = 46 Or (ascii >= 65 And ascii <= 90) _
                        Or (ascii >= 97 And ascii <= 122)) Then
                    err_code = 1
                    MsgBox("Number(s) and special charecter(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit For
                End If
            Next
            If Not Len(a) <= 50 Then
                err_code = 1
                MsgBox("Account name limitation within 50 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' AMOUNT VALIDATION
    Public Sub txt_lamt_validate(ByVal a, ByRef b)
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

    ' ANNUAL INTEREST RATE
    Public Sub txt_air_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            digit_before_decimal = 0
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
                If decimal_count = 0 Then
                    digit_before_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 4 Then
                err_code = 1
                MsgBox("Only three digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_before_decimal > 2 Then
                err_code = 1
                MsgBox("Only two digits allowed before decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 6 Then
                err_code = 1
                MsgBox("Please enter proper interest rate", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' LOAN PERIOD
    Public Sub txt_lp_validate(ByVal a, ByRef b)
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
            If Not Len(a) <= 2 Then
                err_code = 1
                MsgBox("Time period limitation within 2 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'LOAN PERIOD TYPE
    Public Sub cmb_ptype_validate(ByVal a, ByVal c, ByRef b, ByRef e)
        If Not a = "" Then
            err_code = 0
            If a = "MONTH(S)" Then
                If Not CInt(c) <= 96 Then
                    err_code = 1
                    MsgBox("Time period limitation 96 month(s)", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
            ElseIf a = "YEAR(S)" Then
                If Not CInt(c) <= 30 Then
                    err_code = 1
                    MsgBox("Time period limitation 30 year(s)", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    ' NUMBER OF PAYMENTS PER YEAR
    Public Sub txt_nppy_validate(ByVal a, ByRef b)
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
            If Not Len(a) <= 2 Then
                err_code = 1
                MsgBox("Number of payment per year limitation within 2 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not CInt(a) <= 12 Then
                err_code = 1
                MsgBox("Upto 12 number of payment per year allowed", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' SCHEDULED PAYMENT
    Public Sub txt_sp_validate(ByVal a, ByVal c, ByRef b)
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
                MsgBox("Payment limitation within 20 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If CDbl(a) > CDbl(c) Then
                err_code = 1
                MsgBox("Payment cannot be more than main amount", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' SCHEDULED NUMBER OF PAYMENTS
    Public Sub txt_snp_validate(ByVal a, ByRef b)
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
            If Not Len(a) <= 2 Then
                err_code = 1
                MsgBox("Scheduled number of payment limitation within 2 digits", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    ' STARTING DATE OF LOAN
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

    ' REMARK VALIDATION
    Public Sub remark_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not (ascii = 32 Or (ascii > 43 And ascii < 47) Or (ascii >= 65 And ascii <= 90) _
                        Or (ascii >= 97 And ascii <= 122)) Then
                    err_code = 1
                    MsgBox("Number(s) and special charecter(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit For
                End If
            Next
            If Not Len(a) <= 250 Then
                err_code = 1
                MsgBox("Remark charecter limitation within 250 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

End Class
