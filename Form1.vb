Public Class Form1

    'First task
    'f =
    '    (Math.Pow(x, 3) + a * Math.Pow(x, 2) + b * x + c) /
    '    Math.Sqrt(Math.Abs(x - a) + Math.Abs(y - b)) *
    '    (a * Math.Cos(x / p) + b * Math.Sin(y / b))

    Private Sub solveMathBtn_Click(sender As Object, e As EventArgs) Handles solveMathBtn.Click
        Dim a, b, x, y, answer As Double

        a = CInt(aVariableInput.Text)
        b = CInt(bVariableInput.Text)

        x = CSng(InputBox("Input X:"))
        y = CSng(InputBox("Input Y:"))

        answer =
            Math.Pow(x - a, 3) / (y + Math.Pow(x - a, 2)) *
            Math.Pow(Math.E, -Math.Pow(x / a, 2) - Math.Pow(y / b, 2))

        answerLabel1.Text = answer.ToString()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Form1.ActiveForm.Close()
    End Sub
End Class
