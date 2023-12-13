Namespace MergeSortApp
    Module Mergesort
        Sub Sort(ByVal array As Integer())
            If array.Length <= 1 Then Return
            Dim middle As Integer = array.Length / 2
            Dim left As Integer() = New Integer(middle - 1) {}
            Dim right As Integer() = New Integer(array.Length - middle - 1) {}

            For i As Integer = 0 To middle - 1
                left(i) = array(i)
            Next

            For i As Integer = middle To array.Length - 1
                right(i - middle) = array(i)
            Next

            Sort(left)
            Sort(right)
            Merge(array, left, right)
        End Sub

        Private Sub Merge(ByVal result As Integer(), ByVal left As Integer(), ByVal right As Integer())
            Dim i As Integer = 0, j As Integer = 0, k As Integer = 0

            While i < left.Length AndAlso j < right.Length

                If left(i) < right(j) Then
                    result(k) = left(i)
                    i += 1
                Else
                    result(k) = right(j)
                    j += 1
                End If

                k += 1
            End While

            While i < left.Length
                result(k) = left(i)
                i += 1
                k += 1
            End While

            While j < right.Length
                result(k) = right(j)
                j += 1
                k += 1
            End While
        End Sub
    End Module
End Namespace

