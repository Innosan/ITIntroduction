Public Class Test3Task2
    Dim size As Integer = 10

    Dim minValue As Integer = -25
    Dim maxValue As Integer = 25

    Dim myArray(size - 1) As Integer

    Sub FillArrayWithRandomNumbers(ByRef arr() As Integer, ByVal minValue As Integer, ByVal maxValue As Integer)
        randomListBox.Items.Clear()

        Dim rand As New Random()
        For i As Integer = 0 To arr.Length - 1
            arr(i) = rand.Next(minValue, maxValue + 1)
        Next
    End Sub

    Sub ShiftSequence(ByRef sequence() As Integer)
        shiftedListBox.Items.Clear()
        Dim temp As Integer = sequence(0)

        For i As Integer = 0 To sequence.Length - 2
            sequence(i) = sequence(i + 1)
        Next

        sequence(sequence.Length - 1) = temp
    End Sub

    Private Sub fillArrayBtn_Click(sender As Object, e As EventArgs) Handles fillArrayBtn.Click
        FillArrayWithRandomNumbers(myArray, minValue, maxValue)

        For Each num As Integer In myArray
            randomListBox.Items.Add(num)
        Next
    End Sub

    Private Sub shiftArrayBtn_Click(sender As Object, e As EventArgs) Handles shiftArrayBtn.Click
        ShiftSequence(myArray)

        For Each num As Integer In myArray
            shiftedListBox.Items.Add(num)
        Next
    End Sub
End Class