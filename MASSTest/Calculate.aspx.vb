Public Class Calculate
    Inherits System.Web.UI.Page

    Dim dt As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not (Session("db") Is Nothing) Then
            dt = CType(Session("db"), DataTable)

        Else
            dt = getTable()
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        Dim first As Decimal
        Dim last As Decimal
        Dim num1 As String = Field1.Text
        Dim num2 As String = Field2.Text
        Dim num3 As Decimal

        'Checks if first input is a fraction
        'and converts to decimal
        If (IsFraction(num1)) Then
            num1 = FractionToDecimal(num1)
        End If

        'Checks if second input is a fraction
        'and converts to decimal
        If (IsFraction(num2)) Then
            num2 = FractionToDecimal(num2)
        End If

        'Checks if valid numbers then converts to decimal
        If (IsNumeric(num1) And IsNumeric(num2)) Then
            first = CDec(Val(num1))
            last = CDec(Val(num2))

            'Checks if either value is negative
            If (first < 0 Or last < 0) Then
                Return
            End If

            num3 = first + last
            Field3.Text = num3

            dt.Rows.Add(DateTime.Now, num1, num2, num3)
            Session("db") = dt

            'Error handling for neither input being valid
        ElseIf (IsNumeric(num1) = False And IsNumeric(num2) = False) Then

            Field3.Text = "Neither Value is a number"

            'Error Handling for num1 not being valid
        ElseIf (IsNumeric(num1) = False) Then

            Field3.Text = "1st Value is not a number"

            'Error Handling for num2 not being valid
        ElseIf (IsNumeric(num2) = False) Then

            Field3.Text = "2nd Value is not a number"

        End If
    End Sub

    Protected Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        Response.Redirect("Summary.aspx")

    End Sub

    'Build DataTable
    Private Function getTable() As DataTable

        Dim myTable = New DataTable

        myTable.Columns.Add("Timestamp", GetType(DateTime))
        myTable.Columns.Add("Input 1", GetType(Decimal))
        myTable.Columns.Add("Input 2", GetType(Decimal))
        myTable.Columns.Add("Sum", GetType(Decimal))

        Session("db") = myTable

        Return myTable
    End Function

    'Convert Fraction to decimal
    Private Function FractionToDecimal(ByVal frac As String) As String
        Dim number As String = "0"
        Dim numerator As Decimal = 0
        Dim denominator As Decimal = 0
        Dim remainder As Decimal = 0

        'Handle mixed fractions
        If frac.IndexOf("/") <> -1 Then

            If frac.IndexOf(" ") <> -1 Then
                remainder = CType(frac.Substring(0, frac.IndexOf(" ")), Decimal)
                frac = frac.Substring(frac.IndexOf(" "))
            End If
            numerator = CType(frac.Substring(0, frac.IndexOf("/")), Decimal)
            denominator = CType(frac.Substring(frac.IndexOf("/") + 1), Decimal)
            number = (remainder + (numerator / denominator)).ToString
        End If
        Return number
    End Function

    'Check for Fraction input
    Private Function IsFraction(ByVal num As String) As Boolean
        If num.IndexOf("/") <> -1 Then
            If IsNumeric(num.Substring(0, num.IndexOf("/"))) And IsNumeric(num.Substring(num.IndexOf("/"))) Then
                Return True
            End If
        Else
                Return False
        End If
    End Function

End Class