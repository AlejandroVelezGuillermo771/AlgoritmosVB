Public Class CountingSort
    Public Shared Sub Sort(ByVal array As Integer())
        Dim max As Integer = FindMax(array)
        Dim count As Integer() = New Integer(max + 1 - 1) {}
        Dim output As Integer() = New Integer(array.Length - 1) {}

        For i As Integer = 0 To count.Length - 1
            count(i) = 0
        Next

        For i As Integer = 0 To array.Length - 1
            count(array(i)) += 1
        Next

        For i As Integer = 1 To max
            count(i) += count(i - 1)
        Next

        For i As Integer = array.Length - 1 To 0
            output(count(array(i)) - 1) = array(i)
            count(array(i)) -= 1
        Next

        For i As Integer = 0 To array.Length - 1
            array(i) = output(i)
        Next
    End Sub

    Private Shared Function FindMax(ByVal array As Integer()) As Integer
        Dim max As Integer = array(0)

        For i As Integer = 1 To array.Length - 1

            If array(i) > max Then
                max = array(i)
            End If
        Next

        Return max
    End Function
End Class
