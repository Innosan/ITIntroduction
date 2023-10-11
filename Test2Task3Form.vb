Public Class Test2Task3Form
    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        Dim a As Single, b As Single, h As Single
        Dim x As Single, y As Single

        a = CSng(aVariableInput.Text)
        b = CSng(bVariableInput.Text)
        h = CSng(hVarInput.Text)
        x = a

        xVars.Items.Clear()
        yVars.Items.Clear()

        Do
            If x < -Math.PI / 2 Then
                y = 0
            ElseIf x > 0 Then
                y = 1
            Else y = Math.Cos(x)
            End If

            xVars.Items.Add(CStr(x))
            yVars.Items.Add(CStr(y))

            x = x + h
        Loop While x <= b
    End Sub
End Class