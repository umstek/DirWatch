Imports System.IO

Public Class WatchSession
    Private ReadOnly Property WatchModels As New List(Of WatchModel)
    Private ReadOnly _watchers As New List(Of FileSystemWatcher)

    Public Sub AddTarget(path As String, subdirs As Boolean, filter As String,
                         notifyFilter As NotifyFilters, watch As WatcherChangeTypes)
        WatchModels.Add(New WatchModel With {
                           .Path = path,
                           .IncludeSubdirectories = subdirs,
                           .Filter = filter,
                           .NotifyFilter = notifyFilter,
                           .Watch = watch})
    End Sub

    Public Sub Start()
        ' An error message to be displayed if any directory name is invalid. 
        Dim errorMessage = ""

        For Each wm In WatchModels
            '' Checks whether a valid path is specified. 
            'If Not Uri.IsWellFormedUriString(wm.Path, UriKind.RelativeOrAbsolute) Then
            '    errorMessage &= "Invalid path: " + wm.Path + Environment.NewLine
            '    Continue For
            'End If
            ' Checks whether path exists. 
            If Not Directory.Exists(wm.Path) Then
                errorMessage &= "Folder not found: " + wm.Path + Environment.NewLine
                Continue For
            End If

            ' Create an fs watcher to monitor the given folder in watch model. 
            Dim watcher = New FileSystemWatcher With {
                    .Path = wm.Path,
                    .IncludeSubdirectories = wm.IncludeSubdirectories,
                    .Filter = wm.Filter,
                    .NotifyFilter = wm.NotifyFilter,
                    .EnableRaisingEvents = True}

            ' Add handlers so that changes get reflected. 
            If wm.Watch And WatcherChangeTypes.Created Then
                AddHandler watcher.Created,
                    Sub(sender As Object, e As FileSystemEventArgs) RaiseEvent Created(sender, e)
            End If
            If wm.Watch And WatcherChangeTypes.Changed Then
                AddHandler watcher.Changed,
                    Sub(sender As Object, e As FileSystemEventArgs) RaiseEvent Changed(sender, e)
            End If
            If wm.Watch And WatcherChangeTypes.Deleted Then
                AddHandler watcher.Deleted,
                    Sub(sender As Object, e As FileSystemEventArgs) RaiseEvent Deleted(sender, e)
            End If
            If wm.Watch And WatcherChangeTypes.Renamed Then
                AddHandler watcher.Renamed, Sub(sender As Object, e As RenamedEventArgs) RaiseEvent Renamed(sender, e)
            End If

            ' Store the fs watcher so it doesn't get disposed. 
            _watchers.Add(watcher)
        Next

        ' Throw exception instead of MessageBox.  
        If Not errorMessage.Length = 0 Then Throw New Exception(errorMessage)
    End Sub

    Public Event Created(sender As Object, e As FileSystemEventArgs)
    Public Event Changed(sender As Object, e As FileSystemEventArgs)
    Public Event Deleted(sender As Object, e As FileSystemEventArgs)
    Public Event Renamed(sender As Object, e As FileSystemEventArgs)
End Class
