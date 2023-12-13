Public Class HeapSort
    Public Sub Sort(ByVal arr As Integer())
        Dim n As Integer = arr.Length

        For i As Integer = n / 2 - 1 To 0
            Heapify(arr, n, i)
        Next

        For i As Integer = n - 1 To 0 + 1
            Dim temp As Integer = arr(0)
            arr(0) = arr(i)
            arr(i) = temp
            Heapify(arr, i, 0)
        Next
    End Sub

    Private Sub Heapify(ByVal arr As Integer(), ByVal n As Integer, ByVal i As Integer)
        Dim largest As Integer = i
        Dim left As Integer = 2 * i + 1
        Dim right As Integer = 2 * i + 2

        If left < n AndAlso arr(left) > arr(largest) Then
            largest = left
        End If

        If right < n AndAlso arr(right) > arr(largest) Then
            largest = right
        End If

        If largest <> i Then
            Dim swap As Integer = arr(i)
            arr(i) = arr(largest)
            arr(largest) = swap
            Heapify(arr, n, largest)
        End If
    End Sub
End Class
