Public Class InsertionSort
    Public Shared Sub Sort(ByVal array As Integer())
        Dim n As Integer = array.Length

        For i As Integer = 1 To n - 1
            Dim key As Integer = array(i)
            Dim j As Integer = i - 1

            While j >= 0 AndAlso array(j) > key
                array(j + 1) = array(j)
                j = j - 1
            End While

            array(j + 1) = key
        Next
    End Sub
End Class
