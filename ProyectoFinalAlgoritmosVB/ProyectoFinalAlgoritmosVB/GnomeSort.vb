Public Class GnomeSort
    Public Shared Sub Sort(ByVal array As Integer())
        Dim index As Integer = 0

        While index < array.Length

            If index = 0 OrElse array(index) >= array(index - 1) Then
                index += 1
            Else
                Swap(array(index), array(index - 1))
                index -= 1
            End If
        End While
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class

