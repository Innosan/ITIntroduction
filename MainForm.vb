Public Class MainForm
    Private Sub OpenForm(formType As Type)
        Dim form As Form = CType(Activator.CreateInstance(formType), Form)
        form.DesktopLocation = Me.DesktopLocation

        form.Show()
    End Sub

    Private Sub firstTaskFormBtn_Click(sender As Object, e As EventArgs) Handles firstTaskFormBtn.Click
        OpenForm(GetType(Form1))
    End Sub

    Private Sub secondTaskFormBtn_Click(sender As Object, e As EventArgs) Handles secondTaskFormBtn.Click
        OpenForm(GetType(Form2))
    End Sub

    Private Sub firstSecTaskFormBtn_Click(sender As Object, e As EventArgs) Handles firstSecTaskFormBtn.Click
        OpenForm(GetType(Test2Task1Form))
    End Sub

    Private Sub secSecTaskFormBtn_Click(sender As Object, e As EventArgs) Handles secSecTaskFormBtn.Click
        OpenForm(GetType(Test2Task2Form))
    End Sub

    Private Sub thirdSecTaskFormBtn_Click(sender As Object, e As EventArgs) Handles thirdSecTaskFormBtn.Click
        OpenForm(GetType(Test2Task3Form))
    End Sub

    Private Sub firstThirdTaskFormBtn_Click(sender As Object, e As EventArgs) Handles firstThirdTaskFormBtn.Click
        OpenForm(GetType(Test3Task1))
    End Sub

    Private Sub secThirdTaskFormBtn_Click(sender As Object, e As EventArgs) Handles secThirdTaskFormBtn.Click
        OpenForm(GetType(Test3Task2))
    End Sub

    Private Sub thirdThirdTaskFormBtn_Click(sender As Object, e As EventArgs) Handles thirdThirdTaskFormBtn.Click
        OpenForm(GetType(Test3Task3))
    End Sub
End Class