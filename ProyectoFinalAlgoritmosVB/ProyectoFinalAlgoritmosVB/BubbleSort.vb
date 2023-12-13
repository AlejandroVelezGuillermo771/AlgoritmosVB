Public Class BubbleSort
    Public Shared Sub Sort(ByVal array As Integer())
        Dim n As Integer = array.Length

        For i As Integer = 0 To n - 1 - 1

            For j As Integer = 0 To n - i - 1 - 1

                If array(j) > array(j + 1) Then
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp
                End If
            Next
        Next
    End Sub
End Class

