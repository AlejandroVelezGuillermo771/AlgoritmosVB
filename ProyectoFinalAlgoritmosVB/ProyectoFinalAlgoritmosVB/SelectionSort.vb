Imports System

Namespace SortingAlgorithm
    Public Class SelectionSort
        Public Shared Sub Sort(ByVal arr As Integer())
            Dim n As Integer = arr.Length

            For i As Integer = 0 To n - 1 - 1
                Dim minIndex As Integer = i

                For j As Integer = i + 1 To n - 1

                    If arr(j) < arr(minIndex) Then
                        minIndex = j
                    End If
                Next

                Dim temp As Integer = arr(minIndex)
                arr(minIndex) = arr(i)
                arr(i) = temp
            Next
        End Sub
    End Class
End Namespace
