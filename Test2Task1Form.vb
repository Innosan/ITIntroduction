Public Class Test2Task1Form
    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        Dim a As Single, b As Single, h As Single
        Dim x As Single, y As Single

        a = CSng(aVariableInput.Text)
        b = CSng(bVariableInput.Text)
        h = CSng(hVarInput.Text)

        xVars.Items.Clear()
        yVars.Items.Clear()

        For x = a To b Step h
            If x <= -1 Then
                y = 0
            ElseIf x >= 1 Then
                y = Math.Cos(Math.PI * (x / 2))
            Else y = 1 + x
            End If

            xVars.Items.Add(CStr(x))
            yVars.Items.Add(CStr(y))
        Next x
    End Sub
End Class