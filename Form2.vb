Public Class Form2
    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        Dim x, answer As Double

        x = CDbl(xInputBox.Text)

        If x < -1.25 Then
            answer = 3 * Math.Sqrt(Math.Abs(x - 1)) - 3.25
        ElseIf x >= -1.25 And x < 1.25 Then
            answer = -x
        Else
            answer = 3.25 - 3 * Math.Sqrt(x + 1)
        End If

        answerLabel1.Text = answer.ToString()
    End Sub
End Class