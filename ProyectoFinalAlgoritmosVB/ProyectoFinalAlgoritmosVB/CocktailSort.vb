Public Class CocktailSort
    Public Shared Sub Sort(ByVal array As Integer())
        Dim swapped As Boolean

        Do
            swapped = False

            For i As Integer = 0 To array.Length - 2

                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next

            If Not swapped Then Exit Do
            swapped = False

            For i As Integer = array.Length - 2 To 0

                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
