Imports System.Runtime.CompilerServices

Public Module Helpers
    <Extension>
    Public Function [Or](source As IEnumerable(Of Integer)) As Integer
        Dim int = 0

        For Each s In source
            int = int Or s
        Next

        Return int
    End Function
End Module

' Aminda was here

