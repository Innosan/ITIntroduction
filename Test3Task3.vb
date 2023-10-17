Public Class Test3Task3
    Dim n As Integer = 5 ' size of the matrix
    Dim firstMatrix(n - 1, n - 1) As Integer
    Dim secondMatrix(n - 1, n - 1) As Integer
    Dim sumMatrix(n - 1, n - 1) As Integer

    Sub FillTriangleMatrixWithRandomNumbers(ByRef arr(,) As Integer, ByVal minValue As Integer, ByVal maxValue As Integer, ByVal isUpperTriangular As Boolean)
        Dim rand As New Random()

        Dim rows As Integer = arr.GetLength(0)
        Dim columns As Integer = arr.GetLength(1)

        If isUpperTriangular Then
            For i As Integer = 0 To rows - 1
                For j As Integer = i To columns - 1
                    arr(i, j) = rand.Next(minValue, maxValue + 1)
                Next
            Next
        ElseIf isUpperTriangular = False Then
            For i As Integer = 0 To rows - 1
                For j As Integer = 0 To i
                    arr(i, j) = rand.Next(minValue, maxValue + 1)
                Next
            Next
        End If
    End Sub

    Private Sub fillMatrixesBtn_Click(sender As Object, e As EventArgs) Handles fillMatrixesBtn.Click
        firstMatrixView.Items.Clear()
        secondMatrixView.Items.Clear()

        FillTriangleMatrixWithRandomNumbers(firstMatrix, -25, 25, True)
        FillTriangleMatrixWithRandomNumbers(secondMatrix, -25, 25, False)

        For i As Integer = 0 To n - 1
            Dim firstViewRow As New ListViewItem(firstMatrix(i, 0).ToString())
            Dim secondViewRow As New ListViewItem(secondMatrix(i, 0).ToString())

            For j As Integer = 1 To n - 1
                firstViewRow.SubItems.Add(firstMatrix(i, j).ToString())
                secondViewRow.SubItems.Add(secondMatrix(i, j).ToString())
            Next
            firstMatrixView.Items.Add(firstViewRow)
            secondMatrixView.Items.Add(secondViewRow)
        Next

    End Sub

    Private Sub getSumBtn_Click_1(sender As Object, e As EventArgs) Handles getSumBtn.Click
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1
                sumMatrix(i, j) = firstMatrix(i, j) + secondMatrix(i, j)
            Next
        Next

        For i As Integer = 0 To n - 1
            Dim row As New ListViewItem(sumMatrix(i, 0).ToString())
            For j As Integer = 1 To n - 1
                row.SubItems.Add(sumMatrix(i, j).ToString())
            Next
            ListView1.Items.Add(row)
        Next
    End Sub
End Class