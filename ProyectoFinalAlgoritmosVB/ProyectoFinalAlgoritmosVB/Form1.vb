Imports MergeSortApp
Imports ProyectoFinalAlgoritmosVB.MergeSortApp
Imports ProyectoFinalAlgoritmosVB.RadixSortExample
Imports ProyectoFinalAlgoritmosVB.SortingAlgorithm
Imports RadixSortExample
Imports SortingAlgorithm
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ProyectoFinalAlgoritmos
    Partial Public Class Form1
        Inherits Form

        Private binaryTree As BinaryTree
        Private arrayToSort As Integer()
        Private arrayToSort1 As Integer()
        Private txtNumbers As TextBox
        Private btnSort14 As Button

        Public Sub New()
            InitializeComponent()
            binaryTree = New BinaryTree()
            txtNumbers2345 = New TextBox With {
                .Location = New System.Drawing.Point(10, 10),
                .Size = New System.Drawing.Size(200, 20)
            }
            Controls.Add(txtNumbers2345)
            btnSort14 = New Button With {
                .Location = New System.Drawing.Point(220, 10),
                .Size = New System.Drawing.Size(75, 23),
                .Text = "Ordenar"
            }
            btnSort14.Click += AddressOf btnSort_Click
            Controls.Add(btnSort14)
        End Sub
        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim number As Integer = Nothing

            If Integer.TryParse(txtNumber.Text, number) Then
                binaryTree.Insert(number)
                txtNumber.Clear()
            Else
                MessageBox.Show("Ingrese Un Numero Etero.")
            End If
        End Sub

        Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim sortedList As List(Of Integer) = binaryTree.InOrderTraversal()
            MessageBox.Show("Numeros Ordenados: " & String.Join(", ", sortedList))
        End Sub

        Private Sub btnSortBubble_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim numbersString As String() = txtNumbers2345.Text.Split(","c)
            Dim numbers As Integer() = Array.ConvertAll(numbersString, AddressOf Integer.Parse)
            BubbleSort.Sort(numbers)
            MessageBox.Show("Numeros Ordenados: " & String.Join(", ", numbers))
        End Sub

        Private Sub btnSortBucket_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim input As String = txtInput.Text

            If String.IsNullOrWhiteSpace(input) Then
                MessageBox.Show("Ingrese al menos un número.", "Error")
                Return
            End If

            Dim arrayToSort As Integer()

            Try
                arrayToSort = input.Split(","c).[Select](AddressOf Integer.Parse).ToArray()
            Catch __unusedFormatException1__ As FormatException
                MessageBox.Show("Formato de entrada incorrecto. Ingrese números separados por comas.", "Error")
                Return
            End Try

            Dim sortedArray As Integer() = BucketSort.Sort(arrayToSort)
            MessageBox.Show("Array ordenado: " & String.Join(", ", sortedArray), "Resultado")
        End Sub

        Private Sub btnSortCocktailSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            If arrayToSort IsNot Nothing Then
                CocktailSort.Sort(arrayToSort)
                DisplaySortedArray()
            Else
                MessageBox.Show("Por favor genere una matriz primero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnGenerateArray_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim arraySize As Integer

            If Integer.TryParse(txtArraySize.Text, arraySize) Then
                Dim rand As Random = New Random()
                arrayToSort = New Integer(arraySize - 1) {}

                For i As Integer = 0 To arraySize - 1
                    arrayToSort(i) = rand.[Next](1, 100)
                Next

                DisplayOriginalArray()
            Else
                MessageBox.Show("Por favor ingrese un tamaño de matriz válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        End Sub

        Private Sub DisplayOriginalArray()
            lblOriginalArray.Text = "Matriz original: " & String.Join(", ", arrayToSort)
            lblSortedArray.Text = "Matriz ordenada: "
        End Sub

        Private Sub DisplaySortedArray()
            lblSortedArray.Text = "Matriz ordenada: " & String.Join(", ", arrayToSort)
        End Sub

        Private Sub btnSortCombsort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputText As String = txtInput1.Text
            Dim numberStrings As String() = inputText.Split(","c)
            Dim numbers As Integer() = Array.ConvertAll(numberStrings, AddressOf Integer.Parse)
            Combsort.Sort(numbers)
            txtOutput1.Text = String.Join(", ", numbers)
        End Sub

        Private Sub btnSortCountingSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputArray As String() = txtInput2.Text.Split(","c)
            Dim array As Integer() = array.ConvertAll(inputArray, AddressOf Integer.Parse)
            CountingSort.Sort(array)
            txtOutput2.Text = String.Join(", ", array)
        End Sub

        Private Sub btnSortGnomeSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            If arrayToSort IsNot Nothing AndAlso arrayToSort.Length > 0 Then
                GnomeSort.Sort(arrayToSort)
                DisplaySortedArray()
            Else
                MessageBox.Show("Please enter valid numbers to sort.")
            End If
        End Sub

        Private Sub btnGenerateArray1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim arraySize As Integer = Nothing

            If Integer.TryParse(txtInput3.Text, arraySize) Then
                Dim random As Random = New Random()
                arrayToSort = New Integer(arraySize - 1) {}

                For i As Integer = 0 To arraySize - 1
                    arrayToSort(i) = random.[Next](1, 100)
                Next

                DisplayOriginalArray1()
            Else
                MessageBox.Show("Please enter a valid array size.")
            End If
        End Sub

        Private Sub DisplayOriginalArray1()
            lblOriginalArray3.Text = $"Original Array: {String.Join(", ", arrayToSort)}"
            lblSortedArray4.Text = "Sorted Array: "
        End Sub

        Private Sub DisplaySortedArray1()
            lblSortedArray4.Text = $"Sorted Array: {String.Join(", ", arrayToSort)}"
        End Sub

        Private Sub btnSortHeapSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputArray As String() = txtInput8.Text.Split(","c)
            Dim arr As Integer() = Array.ConvertAll(inputArray, Function(s) Integer.Parse(s))
            Dim heapSort As HeapSort = New HeapSort()
            heapSort.Sort(arr)
            txtOutput9.Text = String.Join(", ", arr)
        End Sub

        Private Sub btnSortInsertionsort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim input As String = txtInput34.Text
            Dim arrayToSort As Integer() = input.Split(","c).[Select](AddressOf Integer.Parse).ToArray()
            InsertionSort.Sort(arrayToSort)
            MessageBox.Show("Sorted Array: " & String.Join(", ", arrayToSort), "Insertion Sort")
        End Sub

        Private Sub btnSortMergesort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputArray As String() = txtInput12.Text.Split(","c)
            Dim numbers As Integer() = Array.ConvertAll(inputArray, AddressOf Integer.Parse)
            Mergesort.Sort(numbers)
            txtOutput11.Text = String.Join(", ", numbers)
        End Sub

        Private Sub btnSortPigeonholeSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim input As String = txtInputNumbers88.Text
            Dim numberStrings As String() = input.Split(","c)
            Dim arrayToSort As Integer() = New Integer(numberStrings.Length - 1) {}
            Dim num As Integer = Nothing

            For i As Integer = 0 To numberStrings.Length - 1

                If Integer.TryParse(numberStrings(i), num) Then
                    arrayToSort(i) = num
                Else
                    MessageBox.Show("Por favor, ingrese números separados por comas.", "Error de entrada")
                    Return
                End If
            Next

            PigeonholeSort.Sort(arrayToSort)
            Dim sortedArray As String = String.Join(", ", arrayToSort)
            MessageBox.Show($"Arreglo ordenado: {sortedArray}", "Resultado")
        End Sub

        Private Sub btnSortQuickSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputArray As String() = txtInput67.Text.Split(","c)
            Dim numbers As Integer() = Array.ConvertAll(inputArray, AddressOf Integer.Parse)
            QuickSort.Sort(numbers)
            txtOutput43.Text = String.Join(", ", numbers)
        End Sub

        Private Sub btnSortRadixSor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim input As String = txtInputNumbers76.Text
            Dim arr As Integer() = ParseInput(input)
            RadixSort.Sort(arr)
            txtSortedNumbers09.Text = String.Join(", ", arr.[Select](Function(x) x.ToString()))
        End Sub

        Private Function ParseInput(ByVal input As String) As Integer()
            Try
                Return input.Split(","c).[Select](Function(x) Integer.Parse(x.Trim())).ToArray()
            Catch __unusedException1__ As Exception
                MessageBox.Show("Por favor, ingrese números válidos separados por comas.")
                Return New Integer(-1) {}
            End Try
        End Function

        Private Sub btnSortSelectionsort_Click(ByVal sender As Object, ByVal e As EventArgs)
            If String.IsNullOrWhiteSpace(txtNumbers98.Text) Then
                MessageBox.Show("Por favor, ingrese al menos un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            Try
                Dim arrayToSort As Integer() = txtNumbers98.Text.Split(","c).[Select](AddressOf Integer.Parse).ToArray()
                SelectionSort.Sort(arrayToSort)
                lblSortedArray73.Text = "Sorted array: " & String.Join(", ", arrayToSort)
            Catch __unusedFormatException1__ As FormatException
                MessageBox.Show("Por favor, ingrese números válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Sub

        Private Sub btnSortShellSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inputArray As String() = txtInput732.Text.Split({" "c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            Dim arrayToSort As Integer() = Array.ConvertAll(inputArray, AddressOf Integer.Parse)
            ShellSort(arrayToSort)
            txtOutput843.Text = String.Join(",", arrayToSort)
        End Sub

        Private Sub ShellSort(ByVal arr As Integer())
            Dim n As Integer = arr.Length
                        ''' Cannot convert ForStatementSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: op
''' Actual value was DivideAssignmentStatement.
'''    at ICSharpCode.CodeConverter.Util.VBUtil.GetExpressionOperatorTokenKind(SyntaxKind op)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.MakeAssignmentStatement(AssignmentExpressionSyntax node)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.ConvertForToSimpleForNext(ForStatementSyntax node, StatementSyntax& block)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitForStatement(ForStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input: 
'''             for (int gap = n / 2; gap > 0; gap /= 2)
            {
                For (Int() i = gap; i < n; i += 1)
                {
                    Int temp = arr[i];
                    Int j;
                    For (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }

''' 
        End Sub

        Private Sub btnSortSmoothSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim arrayToSort As Integer() = txtNumbers2345.Text.Split(","c).[Select](Function(str) Integer.Parse(str.Trim())).ToArray()
                Console.WriteLine("Arreglo sin ordenar:")
                PrintArray(arrayToSort)
                SmoothSort.Sort(arrayToSort)
                Console.WriteLine(vbLf & "Arreglo ordenado:")
                PrintArray(arrayToSort)
            Catch ex As Exception
                MessageBox.Show("Error al procesar los números. Asegúrate de ingresar números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Sub

        Private Sub PrintArray(ByVal arr As Integer())
            For Each element In arr
                Console.Write(element & " ")
            Next

            Console.WriteLine()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(282, 253)
            Me.Name = "Form1"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
