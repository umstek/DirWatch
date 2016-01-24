<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DirWatchMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Created", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Deleted", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Changed", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Renamed", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirWatchMainForm))
        Me.buttonStart = New System.Windows.Forms.Button()
        Me.buttonStop = New System.Windows.Forms.Button()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.groupTarget = New System.Windows.Forms.GroupBox()
        Me.checkListWatch = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelNotifyFilters = New System.Windows.Forms.Label()
        Me.checkSubdirs = New System.Windows.Forms.CheckBox()
        Me.textFilter = New System.Windows.Forms.TextBox()
        Me.labelFilter = New System.Windows.Forms.Label()
        Me.buttonBrowse = New System.Windows.Forms.Button()
        Me.labelPath = New System.Windows.Forms.Label()
        Me.textPath = New System.Windows.Forms.TextBox()
        Me.checkListNotifyFilters = New System.Windows.Forms.CheckedListBox()
        Me.groupTargets = New System.Windows.Forms.GroupBox()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.listViewTargets = New System.Windows.Forms.ListView()
        Me.ch1Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch1Filter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listViewResults = New System.Windows.Forms.ListView()
        Me.ch2Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch2Info = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contextMenuResults = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItemLocate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemOpenDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupTarget.SuspendLayout()
        Me.groupTargets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.contextMenuResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonStart
        '
        Me.buttonStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonStart.Location = New System.Drawing.Point(610, 526)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Size = New System.Drawing.Size(75, 23)
        Me.buttonStart.TabIndex = 0
        Me.buttonStart.Text = "Start"
        Me.buttonStart.UseVisualStyleBackColor = True
        '
        'buttonStop
        '
        Me.buttonStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonStop.Location = New System.Drawing.Point(691, 526)
        Me.buttonStop.Name = "buttonStop"
        Me.buttonStop.Size = New System.Drawing.Size(75, 23)
        Me.buttonStop.TabIndex = 1
        Me.buttonStop.Text = "Stop"
        Me.buttonStop.UseVisualStyleBackColor = True
        '
        'groupTarget
        '
        Me.groupTarget.Controls.Add(Me.checkListWatch)
        Me.groupTarget.Controls.Add(Me.Label1)
        Me.groupTarget.Controls.Add(Me.labelNotifyFilters)
        Me.groupTarget.Controls.Add(Me.checkSubdirs)
        Me.groupTarget.Controls.Add(Me.textFilter)
        Me.groupTarget.Controls.Add(Me.labelFilter)
        Me.groupTarget.Controls.Add(Me.buttonBrowse)
        Me.groupTarget.Controls.Add(Me.labelPath)
        Me.groupTarget.Controls.Add(Me.textPath)
        Me.groupTarget.Controls.Add(Me.checkListNotifyFilters)
        Me.groupTarget.Location = New System.Drawing.Point(6, 21)
        Me.groupTarget.Name = "groupTarget"
        Me.groupTarget.Size = New System.Drawing.Size(476, 194)
        Me.groupTarget.TabIndex = 2
        Me.groupTarget.TabStop = False
        Me.groupTarget.Text = "New Target"
        '
        'checkListWatch
        '
        Me.checkListWatch.CheckOnClick = True
        Me.checkListWatch.FormattingEnabled = True
        Me.checkListWatch.Location = New System.Drawing.Point(318, 93)
        Me.checkListWatch.Name = "checkListWatch"
        Me.checkListWatch.Size = New System.Drawing.Size(150, 89)
        Me.checkListWatch.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Events"
        '
        'labelNotifyFilters
        '
        Me.labelNotifyFilters.AutoSize = True
        Me.labelNotifyFilters.Location = New System.Drawing.Point(6, 77)
        Me.labelNotifyFilters.Name = "labelNotifyFilters"
        Me.labelNotifyFilters.Size = New System.Drawing.Size(72, 13)
        Me.labelNotifyFilters.TabIndex = 7
        Me.labelNotifyFilters.Text = "Notify Filters"
        '
        'checkSubdirs
        '
        Me.checkSubdirs.AutoSize = True
        Me.checkSubdirs.Checked = True
        Me.checkSubdirs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkSubdirs.Location = New System.Drawing.Point(345, 51)
        Me.checkSubdirs.Name = "checkSubdirs"
        Me.checkSubdirs.Size = New System.Drawing.Size(123, 17)
        Me.checkSubdirs.TabIndex = 6
        Me.checkSubdirs.Text = "Include Subfolders"
        Me.checkSubdirs.UseVisualStyleBackColor = True
        '
        'textFilter
        '
        Me.textFilter.AutoCompleteCustomSource.AddRange(New String() {"*", "*.*", "*.log", "*.bin", "*.dat", "*.tmp"})
        Me.textFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.textFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.textFilter.Location = New System.Drawing.Point(99, 49)
        Me.textFilter.Name = "textFilter"
        Me.textFilter.Size = New System.Drawing.Size(240, 22)
        Me.textFilter.TabIndex = 5
        Me.textFilter.Text = "*"
        '
        'labelFilter
        '
        Me.labelFilter.AutoSize = True
        Me.labelFilter.Location = New System.Drawing.Point(6, 52)
        Me.labelFilter.Name = "labelFilter"
        Me.labelFilter.Size = New System.Drawing.Size(54, 13)
        Me.labelFilter.TabIndex = 4
        Me.labelFilter.Text = "File Filter"
        '
        'buttonBrowse
        '
        Me.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonBrowse.Location = New System.Drawing.Point(393, 21)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse.TabIndex = 3
        Me.buttonBrowse.Text = "Browse..."
        Me.buttonBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.buttonBrowse.UseVisualStyleBackColor = True
        '
        'labelPath
        '
        Me.labelPath.AutoSize = True
        Me.labelPath.Location = New System.Drawing.Point(6, 24)
        Me.labelPath.Name = "labelPath"
        Me.labelPath.Size = New System.Drawing.Size(30, 13)
        Me.labelPath.TabIndex = 2
        Me.labelPath.Text = "Path"
        '
        'textPath
        '
        Me.textPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.textPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.textPath.Location = New System.Drawing.Point(99, 21)
        Me.textPath.Name = "textPath"
        Me.textPath.Size = New System.Drawing.Size(288, 22)
        Me.textPath.TabIndex = 1
        '
        'checkListNotifyFilters
        '
        Me.checkListNotifyFilters.CheckOnClick = True
        Me.checkListNotifyFilters.FormattingEnabled = True
        Me.checkListNotifyFilters.Location = New System.Drawing.Point(9, 93)
        Me.checkListNotifyFilters.MultiColumn = True
        Me.checkListNotifyFilters.Name = "checkListNotifyFilters"
        Me.checkListNotifyFilters.Size = New System.Drawing.Size(300, 89)
        Me.checkListNotifyFilters.TabIndex = 0
        '
        'groupTargets
        '
        Me.groupTargets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupTargets.Controls.Add(Me.buttonRemove)
        Me.groupTargets.Controls.Add(Me.buttonAdd)
        Me.groupTargets.Controls.Add(Me.groupTarget)
        Me.groupTargets.Controls.Add(Me.listViewTargets)
        Me.groupTargets.Location = New System.Drawing.Point(12, 12)
        Me.groupTargets.Name = "groupTargets"
        Me.groupTargets.Size = New System.Drawing.Size(760, 221)
        Me.groupTargets.TabIndex = 3
        Me.groupTargets.TabStop = False
        Me.groupTargets.Text = "Manage Target Folders"
        '
        'buttonRemove
        '
        Me.buttonRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonRemove.Location = New System.Drawing.Point(569, 192)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(75, 23)
        Me.buttonRemove.TabIndex = 1
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'buttonAdd
        '
        Me.buttonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonAdd.Location = New System.Drawing.Point(488, 192)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(75, 23)
        Me.buttonAdd.TabIndex = 1
        Me.buttonAdd.Text = "Add Target"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'listViewTargets
        '
        Me.listViewTargets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewTargets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch1Path, Me.ch1Filter})
        Me.listViewTargets.Location = New System.Drawing.Point(488, 21)
        Me.listViewTargets.Name = "listViewTargets"
        Me.listViewTargets.Size = New System.Drawing.Size(266, 165)
        Me.listViewTargets.TabIndex = 0
        Me.listViewTargets.UseCompatibleStateImageBehavior = False
        Me.listViewTargets.View = System.Windows.Forms.View.Details
        '
        'ch1Path
        '
        Me.ch1Path.Text = "Path"
        Me.ch1Path.Width = 200
        '
        'ch1Filter
        '
        Me.ch1Filter.Text = "Filter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.listViewResults)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 281)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'listViewResults
        '
        Me.listViewResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch2Path, Me.ch2Info})
        Me.listViewResults.ContextMenuStrip = Me.contextMenuResults
        ListViewGroup1.Header = "Created"
        ListViewGroup1.Name = "lvhCreated"
        ListViewGroup2.Header = "Deleted"
        ListViewGroup2.Name = "lvhDeleted"
        ListViewGroup3.Header = "Changed"
        ListViewGroup3.Name = "lvhChanged"
        ListViewGroup4.Header = "Renamed"
        ListViewGroup4.Name = "lvhRenamed"
        Me.listViewResults.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.listViewResults.Location = New System.Drawing.Point(6, 21)
        Me.listViewResults.Name = "listViewResults"
        Me.listViewResults.Size = New System.Drawing.Size(748, 254)
        Me.listViewResults.TabIndex = 0
        Me.listViewResults.UseCompatibleStateImageBehavior = False
        Me.listViewResults.View = System.Windows.Forms.View.Details
        '
        'ch2Path
        '
        Me.ch2Path.Text = "Path"
        Me.ch2Path.Width = 500
        '
        'ch2Info
        '
        Me.ch2Info.Text = "Info"
        Me.ch2Info.Width = 200
        '
        'contextMenuResults
        '
        Me.contextMenuResults.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemLocate, Me.menuItemOpenDir, Me.menuItemOpen})
        Me.contextMenuResults.Name = "contextMenuResults"
        Me.contextMenuResults.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.contextMenuResults.ShowImageMargin = False
        Me.contextMenuResults.Size = New System.Drawing.Size(160, 70)
        '
        'menuItemLocate
        '
        Me.menuItemLocate.Name = "menuItemLocate"
        Me.menuItemLocate.Size = New System.Drawing.Size(159, 22)
        Me.menuItemLocate.Text = "Locate"
        '
        'menuItemOpenDir
        '
        Me.menuItemOpenDir.Name = "menuItemOpenDir"
        Me.menuItemOpenDir.Size = New System.Drawing.Size(159, 22)
        Me.menuItemOpenDir.Text = "Open Folder"
        '
        'menuItemOpen
        '
        Me.menuItemOpen.Name = "menuItemOpen"
        Me.menuItemOpen.Size = New System.Drawing.Size(159, 22)
        Me.menuItemOpen.Text = "Open (Use with care)"
        '
        'buttonClear
        '
        Me.buttonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonClear.Location = New System.Drawing.Point(12, 526)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(75, 23)
        Me.buttonClear.TabIndex = 5
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'DirWatchMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupTargets)
        Me.Controls.Add(Me.buttonStop)
        Me.Controls.Add(Me.buttonStart)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DirWatchMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Watcher"
        Me.groupTarget.ResumeLayout(False)
        Me.groupTarget.PerformLayout()
        Me.groupTargets.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.contextMenuResults.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonStart As Button
    Friend WithEvents buttonStop As Button
    Friend WithEvents folderBrowserDialog As FolderBrowserDialog
    Friend WithEvents groupTarget As GroupBox
    Friend WithEvents checkListNotifyFilters As CheckedListBox
    Friend WithEvents textPath As TextBox
    Friend WithEvents labelPath As Label
    Friend WithEvents buttonBrowse As Button
    Friend WithEvents textFilter As TextBox
    Friend WithEvents labelFilter As Label
    Friend WithEvents checkSubdirs As CheckBox
    Friend WithEvents labelNotifyFilters As Label
    Friend WithEvents checkListWatch As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents groupTargets As GroupBox
    Friend WithEvents buttonRemove As Button
    Friend WithEvents buttonAdd As Button
    Friend WithEvents listViewTargets As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listViewResults As ListView
    Friend WithEvents ch1Path As ColumnHeader
    Friend WithEvents ch1Filter As ColumnHeader
    Friend WithEvents ch2Path As ColumnHeader
    Friend WithEvents ch2Info As ColumnHeader
    Friend WithEvents contextMenuResults As ContextMenuStrip
    Friend WithEvents menuItemLocate As ToolStripMenuItem
    Friend WithEvents menuItemOpenDir As ToolStripMenuItem
    Friend WithEvents menuItemOpen As ToolStripMenuItem
    Friend WithEvents buttonClear As Button
    Friend WithEvents toolTip As ToolTip
End Class
