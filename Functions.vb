﻿Option Strict On
Option Explicit On

Module Functions

    Sub Main()
        Dim aLetter As String
        aLetter = "Q"
        'Console.WriteLine(aLetter)
        'Console.ReadLine()

        ''Letter()

        'Console.WriteLine(Letter())
        'Console.ReadLine()

        'Console.WriteLine(DoesNotReturnStuff())
        'Console.ReadLine()

        'Console.WriteLine(AddNumbers(3I, 7I))
        'Console.ReadLine()

        'For i = 1 To 3
        '    Console.WriteLine(RunningTotal(5))
        '    Console.ReadLine()
        'Next

        AccumulateMessage("Hello Johnny", False)
        AccumulateMessage("That's Not a Number", False)
        AccumulateMessage("User Name is required", False)

        'MsgBox(AccumulateMessage(""))

        Console.WriteLine(AccumulateMessage("", False))
        Console.ReadLine()

        'clear
        AccumulateMessage("", True)
        'add new stuff
        AccumulateMessage("New Stuff.....", False)
        Console.WriteLine(AccumulateMessage("", False))
        Console.ReadLine()

    End Sub

    Function Letter() As String
        Dim someOtherLetter As String
        someOtherLetter = "Y"
        Return someOtherLetter
    End Function

    Sub DoesNotReturnStuff()
        Dim someOtherLetter As String
        someOtherLetter = "X"
        'Return someOtherLetter
    End Sub

    Function AddNumbers(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer
        Return firstNumber + secondNumber
    End Function

    Function RunningTotal(ByVal currentAmount As Decimal) As Decimal
        Static total As Decimal
        total += currentAmount
        Return total
    End Function

    Function AccumulateMessage(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static userMessage As String

        If clear = True Then
            userMessage = ""
        Else
            userMessage &= newMessage & vbNewLine
        End If

        Return userMessage

    End Function




End Module
