Imports System
Imports System.Collections.Generic

Public Class PigeonholeSort
    Public Shared Sub Sort(ByVal arr As Integer())
        Dim min As Integer = arr(0)
        Dim max As Integer = arr(0)
        Dim range, i, j, index As Integer

        For a As Integer = 0 To arr.Length - 1
            If arr(a) > max Then max = arr(a)
            If arr(a) < min Then min = arr(a)
        Next

        range = max - min + 1
        Dim pigeonhole As List(Of Integer)() = New List(Of Integer)(range - 1) {}

        For i = 0 To range - 1
            pigeonhole(i) = New List(Of Integer)()
        Next

        For i = 0 To arr.Length - 1
            pigeonhole(arr(i) - min).Add(arr(i))
        Next

        index = 0

        For i = 0 To range - 1
            Dim list As List(Of Integer) = pigeonhole(i)

            For j = 0 To list.Count - 1
                arr(Math.Min(System.Threading.Interlocked.Increment(index), index - 1)) = list(j)
            Next
        Next
    End Sub
End Class
