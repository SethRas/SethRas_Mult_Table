'Seth Rasmussen
'RCET 0265
'Spring 2022
'Multiplication Table
'

Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()

        Dim Dimensions As Integer
        Dim run As Boolean = False

        Console.WriteLine("Enter the Dimension of the table")
        Dimensions = CInt(Console.ReadLine())
        For col = 1 To Dimensions
            For row = 1 To Dimensions
                Console.Write(Str(col * row).PadLeft(5))
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

End Module