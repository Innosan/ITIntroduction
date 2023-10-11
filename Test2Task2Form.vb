Public Class Test2Task2Form
    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        Dim a As Single, b As Single, h As Single
        Dim x As Single, y As Single

        a = CSng(aVariableInput.Text)
        b = CSng(bVariableInput.Text)
        h = CSng(hVarInput.Text)
        x = a

        xVars.Items.Clear()
        yVars.Items.Clear()

        Do While x <= b
            If x < 0 Then
                y = Math.Exp(-x)
            ElseIf x > 1 Then
                y = 0
            Else y = Math.Cos(x * (Math.PI / 2))
            End If

            xVars.Items.Add(CStr(x))
            yVars.Items.Add(CStr(y))

            x = x + h
        Loop
    End Sub
End Class