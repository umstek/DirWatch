Imports System.IO
Imports DirWatch.Helpers

Public Class DirWatchMainForm

    Private Property Session As New WatchSession

    Private Sub DirWatchMainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Populate Checked list boxes. 
        checkListNotifyFilters.Items.AddRange([Enum].GetNames(GetType(NotifyFilters)))
        checkListWatch.Items.AddRange([Enum].GetNames(GetType(WatcherChangeTypes)))

        ' Add handlers to handle all events. 
        AddHandler Session.Created, AddressOf session_Created
        AddHandler Session.Changed, AddressOf session_Changed
        AddHandler Session.Deleted, AddressOf session_Deleted
        AddHandler Session.Renamed, AddressOf session_Renamed

    End Sub

    ' Created/Changed/Renamed all have same signature so we can use the same delegate. 
    Delegate Sub SessionFileSystemEventArgsCallback(sender As Object, e As FileSystemEventArgs)
    Delegate Sub SessionRenamedEventArgsCallback(sender As Object, e As RenamedEventArgs)

    Private Sub session_Created(sender As Object, e As FileSystemEventArgs)
        ' Avoid illegal cross-thread call to UI component list view by using a delegate function.
        If listViewResults.InvokeRequired Then
            Dim d As New SessionFileSystemEventArgsCallback(AddressOf session_Created)
            Me.Invoke(d, New Object() {sender, e}) ' Call the same function in the thread which created the UI component. 
        Else
            listViewResults.Items.Add(New ListViewItem({e.FullPath, e.ChangeType.ToString()}, listViewResults.Groups(0)))
        End If

    End Sub

    Private Sub session_Changed(sender As Object, e As FileSystemEventArgs)
        ' Avoid illegal cross-thread call to UI component list view by using a delegate function.
        If listViewResults.InvokeRequired Then
            Dim d As New SessionFileSystemEventArgsCallback(AddressOf session_Changed)
            Me.Invoke(d, New Object() {sender, e}) ' Call the same function in the thread which created the UI component. 
        Else
            listViewResults.Items.Add(New ListViewItem({e.FullPath, e.ChangeType.ToString()}, listViewResults.Groups(2)))
        End If

    End Sub
    Private Sub session_Deleted(sender As Object, e As FileSystemEventArgs)
        ' Avoid illegal cross-thread call to UI component list view by using a delegate function.
        If listViewResults.InvokeRequired Then
            Dim d As New SessionFileSystemEventArgsCallback(AddressOf session_Deleted)
            Me.Invoke(d, New Object() {sender, e}) ' Call the same function in the thread which created the UI component. 
        Else
            listViewResults.Items.Add(New ListViewItem({e.FullPath, e.ChangeType.ToString()}, listViewResults.Groups(1)))
        End If

    End Sub

    Private Sub session_Renamed(sender As Object, e As RenamedEventArgs)
        ' Avoid illegal cross-thread call to UI component list view by using a delegate function.
        If listViewResults.InvokeRequired Then
            Dim d As New SessionRenamedEventArgsCallback(AddressOf session_Renamed)
            Me.Invoke(d, New Object() {sender, e}) ' Call the same function in the thread which created the UI component. 
        Else
            listViewResults.Items.Add(New ListViewItem({e.FullPath, e.ChangeType.ToString()}, listViewResults.Groups(3)))
        End If
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        Dim notifyFilter = Aggregate ' Enum is multi-selectable. Get an all-packed value. 
                               item In checkListNotifyFilters.CheckedItems
                               Select CInt([Enum].Parse(GetType(NotifyFilters), item))
                                   Into [Or]()
        Dim watchFilter = Aggregate ' Enum is multi-selectable. Get an all-packed value. 
                              item In checkListWatch.CheckedItems
                              Select CInt([Enum].Parse(GetType(WatcherChangeTypes), item))
                                  Into [Or]()

        ' Add target details to watch session. Check for null. 
        Session?.AddTarget(textPath.Text, checkSubdirs.Checked, textFilter.Text, notifyFilter, watchFilter)

        ' Add target details to list view. 
        listViewTargets.Items.Add(New ListViewItem({textPath.Text, textFilter.Text}))
    End Sub

    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click
        groupTargets.Enabled = False

        Try
            Session.Start()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Operation successful with errors", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub buttonBrowse_Click(sender As Object, e As EventArgs) Handles buttonBrowse.Click
        If folderBrowserDialog.ShowDialog = DialogResult.OK Then
            textPath.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        Dim items = listViewTargets.SelectedItems
        For Each item In items
            listViewTargets.Items.Remove(item)
        Next
    End Sub

    Private Sub buttonStop_Click(sender As Object, e As EventArgs) Handles buttonStop.Click

        ' Remove handlers before deleting session. 
        RemoveHandler Session.Created, AddressOf session_Created
        RemoveHandler Session.Changed, AddressOf session_Changed
        RemoveHandler Session.Deleted, AddressOf session_Deleted
        RemoveHandler Session.Renamed, AddressOf session_Renamed

        Session = New WatchSession()
        listViewTargets.Items.Clear()

        ' Add handlers to handle all events. 
        AddHandler Session.Created, AddressOf session_Created
        AddHandler Session.Changed, AddressOf session_Changed
        AddHandler Session.Deleted, AddressOf session_Deleted
        AddHandler Session.Renamed, AddressOf session_Renamed

        groupTargets.Enabled = True
    End Sub

    Private Sub menuItemLocate_Click(sender As Object, e As EventArgs) Handles menuItemLocate.Click
        For Each result In listViewResults.SelectedItems
            Process.Start("explorer", "/select," + CType(result, ListViewItem).Text)
        Next
    End Sub

    Private Sub menuItemOpenDir_Click(sender As Object, e As EventArgs) Handles menuItemOpenDir.Click
        For Each result In listViewResults.SelectedItems
            Process.Start("explorer", New FileInfo(CType(result, ListViewItem).Text).DirectoryName)
        Next
    End Sub

    Private Sub menuItemOpen_Click(sender As Object, e As EventArgs) Handles menuItemOpen.Click
        For Each result In listViewResults.SelectedItems
            Process.Start("explorer", CType(result, ListViewItem).Text)
        Next
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        listViewResults.Items.Clear()
    End Sub
End Class
