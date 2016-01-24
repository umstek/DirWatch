Imports System.IO

Public Class WatchModel
    Public Property Path As String
    Public Property IncludeSubdirectories As Boolean
    Public Property Filter As String
    Public Property NotifyFilter As NotifyFilters
    Public Property Watch As WatcherChangeTypes

End Class
