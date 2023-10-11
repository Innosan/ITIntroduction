Public Class Test3Task1
    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        Dim x, sum As Single
        Dim i As Int32

        sum = 0.0

        x = CSng(xVariableInput.Text)

        For i = -5 To 5 Step 2
            sum += Math.Pow(x, i + 5) / Factorial(i + 7)
        Next i

        sumLabel.Text = sum.ToString()
    End Sub

    Function Factorial(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        End If
        Return Factorial(n - 1) * n
    End Function
End Class