' ====================
'      Crossword
' ====================

Public Class ActivityType_Crossword
    Private Sub WipeDatagridView()
        For i = DataGridView1.DisplayedColumnCount(0) - 1 To 0 Step -1
            DataGridView1.Columns.RemoveAt(i)
        Next
    End Sub

    Public Sub PrepareNew()
        UseWaitCursor = True

        ' Initialize the Crossword configuration page.
        WipeDatagridView() ' Just in case, try to wipe it.
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        For i = 0 To CrosswordDefaultColumns
            Dim CellTemplate As New DataGridViewTextBoxCell With {
                .MaxInputLength = 1
            }
            Dim NewColumn As New DataGridViewColumn With {
                .CellTemplate = CellTemplate
            }
            DataGridView1.Columns.Add(NewColumn)
        Next

        Dim ReferenceTextColumn As New DataGridViewColumn
        Dim ReferenceTextCellTemplate As New DataGridViewTextBoxCell

        ' Add an extra column for references.
        ReferenceTextColumn.CellTemplate = ReferenceTextCellTemplate
        ReferenceTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ReferenceTextColumn.HeaderText = My.Resources.Crossword_ColumnHeader_ReferenceText
        DataGridView1.Columns.Add(ReferenceTextColumn)

        For i = 0 To CrosswordDefaultRows
            DataGridView1.Rows.Add(New DataGridViewRow)
        Next

        UseWaitCursor = False
    End Sub

    Dim IsModifying As Boolean = False
    Public Sub PrepareModification()
        UseWaitCursor = True

        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = False

        IsModifying = True
        WipeDatagridView() ' Try to wipe it.
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim ActivityPre As String = My.Settings.Activities(CurrentActivityIndex)
        For i = 0 To 3
            ActivityPre = ActivityPre.Remove(0, ActivityPre.IndexOf(";") + 1)
            LogD(Me, ActivityPre)
        Next

        Dim FirstPass As Boolean = True
        LogD(Me, "Parsing activity...")
        For Each Row As String In ActivityPre.Split(RowSplitter, options:=StringSplitOptions.None)
            Dim CurrentRow As String() = Row.Split(";")

            Dim CurIdx As Integer = 0
            Dim ActivityRow As New DataGridViewRow()
            Dim ActivityCells As List(Of DataGridViewCell) = New List(Of DataGridViewCell)

            Dim DebugRowStr As String = CurrentRow.Length & ":"
            If CurrentRow.Length > 1 Then
                For x = 0 To CurrentRow.Length - 2
                    DebugRowStr &= " [" & CurrentRow(x) & "] "
                    Dim Cell As DataGridViewCell = New DataGridViewTextBoxCell With {
                      .Value = CurrentRow(x)
                    }

                    ActivityCells.Add(Cell)

                    If FirstPass Then
                        Dim CellTemplate As New DataGridViewTextBoxCell With {
                                .MaxInputLength = 1
                        }
                        Dim NewColumn As New DataGridViewColumn With {
                                .CellTemplate = CellTemplate
                        }
                        DataGridView1.Columns.Add(NewColumn)
                    End If
                Next

                If Not String.IsNullOrEmpty(DebugRowStr) Then
                    LogD(Me, DebugRowStr)
                End If

                For Each CurrentCell As DataGridViewCell In ActivityCells
                    ActivityRow.Cells.Add(CurrentCell)
                Next
                DataGridView1.Rows.Add(ActivityRow)
            End If
            If FirstPass Then
                Dim ReferenceTextCellTemplate As New DataGridViewTextBoxCell

                ' Set up references column
                Dim CellBoundaries As Integer = -1
                ' TODO: Rework this, it's gonna cause performance issues
                '       at some point.
                For Each Cell As DataGridViewCell In DataGridView1.Rows(0).Cells
                    CellBoundaries += 1
                Next
                Dim ReferenceTextColumn As DataGridViewColumn = DataGridView1.Columns(CellBoundaries)
                ReferenceTextColumn.CellTemplate = ReferenceTextCellTemplate
                ReferenceTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                ReferenceTextColumn.HeaderText = My.Resources.Crossword_ColumnHeader_ReferenceText
                FirstPass = False
            End If

            CurIdx += 1
        Next

        DataGridView1.Enabled = True
        DataGridView1.ReadOnly = False

        UseWaitCursor = False
    End Sub

    Private Sub AddColumn_Click(sender As Object, e As EventArgs) Handles AddColumn.Click
        AddColumn.Enabled = False
        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = False

        Dim ColumnCount As Integer = DataGridView1.Columns.GetColumnCount(0)
        LogD(Me, "Column count: " & ColumnCount)

        If ColumnCount < MaximumCrosswordXIndex Then
            Dim CellTemplate As New DataGridViewTextBoxCell With {
                .MaxInputLength = 1
            }
            Dim NewColumn As New DataGridViewColumn With {
                .CellTemplate = CellTemplate
            }

            If ColumnCount > 1 Then
                DataGridView1.Columns.Insert(ColumnCount - 2, NewColumn)
            Else
                DataGridView1.Columns.Insert(0, NewColumn)
            End If

            For Each Column As DataGridViewColumn In DataGridView1.Columns

                Dim TempCellTemplate As New DataGridViewTextBoxCell With {
                    .MaxInputLength = 1
                }

                If Column.DisplayIndex > ColumnCount - 1 Then
                    Dim ReferenceTextCellTemplate As New DataGridViewTextBoxCell

                    Dim ReferenceTextColumn As DataGridViewColumn = DataGridView1.Columns(Column.DisplayIndex)
                    ReferenceTextColumn.CellTemplate = ReferenceTextCellTemplate
                    ReferenceTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    ReferenceTextColumn.HeaderText = My.Resources.Crossword_ColumnHeader_ReferenceText
                Else
                    Column.CellTemplate = TempCellTemplate
                End If
            Next

            RemoveColumn.Enabled = True
        End If

        If ColumnCount + 1 >= MaximumCrosswordXIndex Then
            AddColumn.Enabled = False
        Else
            AddColumn.Enabled = True
        End If

        DataGridView1.Enabled = True
        DataGridView1.Visible = True
        DataGridView1.ReadOnly = False

        ColumnCount = DataGridView1.Columns.GetColumnCount(0)
        Label12.Text = ColumnCount

        LogD(Me, "Column count: " & ColumnCount)
    End Sub

    Private Sub RemoveColumn_Click(sender As Object, e As EventArgs) Handles RemoveColumn.Click
        Dim ColumnCount As Integer = DataGridView1.Columns.GetColumnCount(0)

        If ColumnCount < 3 Then
            If ColumnCount > 1 Then
                DataGridView1.Columns.RemoveAt(ColumnCount - 2)
            End If
            RemoveColumn.Enabled = False
        Else
            DataGridView1.Columns.RemoveAt(ColumnCount - 2)
        End If

        ColumnCount = DataGridView1.Columns.GetColumnCount(0)
        Label12.Text = ColumnCount

        LogD(Me, "Column count: " & ColumnCount)
    End Sub

    Private Sub SaveActivity_Click(sender As Object, e As EventArgs) Handles SaveActivity.Click
        Dim ActivityString As String = ""
        For Each Row As DataGridViewRow In DataGridView1.Rows
            'ActivityString &= Row.Index & ";"

            Dim ColumnBoundaries As Integer = DataGridView1.DisplayedColumnCount(0) - 1

            Dim Cell As DataGridViewCell
            For i = 0 To ColumnBoundaries
                Cell = Row.Cells(i)
                If Cell.Value IsNot Nothing Then
                    ActivityString &= Cell.Value
                End If
                ActivityString &= ";"
            Next
            Cell = Row.Cells(ColumnBoundaries)
            ActivityString &= RowSplitter(0)
            LogD(Me, ActivityString)
            Try
                If Cell.Value IsNot Nothing Then
                    If Cell.Value.ToString.Contains(RowSplitter(0)) Then
                        MsgBox(String.Format(My.Resources.Settings_Crossword_IllegalStringException, RowSplitter), MsgBoxStyle.Critical, My.Resources.Settings_General_Err_Title)
                    End If
                End If
            Catch ex As Exception
                ' Do nothing.
            End Try
            LogD(Me, ActivityString)
        Next
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = Settings.ActivityListBox.SelectedIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & ActivityString
            LogD(Me, CurrentActivityIndex & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & ActivityString)
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & ActivityString)
            LogD(Me, GetNewID() & ";" & Settings.SettingsActivityName.Text & ";" & Settings.SettingsActivityDescription.Text & ";" & Settings.SettingsActivityType.SelectedIndex & ";" & ActivityString)
        End If
        SettingsSaver()
        Close()
    End Sub

    Private Sub ActivityType_Crossword_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Settings.UpdateActivities()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        ' Check if previous row has content
        For Each Cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
            If Cell.Value IsNot Nothing Then
                If Not String.IsNullOrEmpty(Cell.Value) Then
                    LogD(Me, "Cell at " & Cell.ColumnIndex & " in row index " & e.RowIndex & " is not null, processing...")
                    SaveActivity.Enabled = True
                    Exit For
                End If
            Else
                LogD(Me, "Cell at " & Cell.ColumnIndex & " in row index " & e.RowIndex & " is null, skipped.")
            End If
        Next
    End Sub
End Class