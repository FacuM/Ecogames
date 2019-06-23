' ====================
'      Crossword
' ====================

Public Class ActivityType_Crossword
    Private Sub WipeDatagridView()
        DataGridView1.Columns.Clear()
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

        ColumnCountLabel.Text = DataGridView1.Columns.GetColumnCount(0).ToString

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
            ActivityPre = ActivityPre.Remove(0, ActivityPre.IndexOf(SemicolonChar) + 1)
#If DEBUG Then
            LogD(Me, ActivityPre)
#End If
        Next

        Dim FirstPass As Boolean = True
#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        For Each Row As String In ActivityPre.Split(RowSplitter, options:=StringSplitOptions.None)
            Dim CurrentRow As String() = Row.Split(SemicolonChar)

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

#If DEBUG Then
                If Not String.IsNullOrEmpty(DebugRowStr) Then
                    LogD(Me, DebugRowStr)
                End If
#End If

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

        ColumnCountLabel.Text = DataGridView1.Columns.GetColumnCount(0).ToString

        DataGridView1.Enabled = True
        DataGridView1.ReadOnly = False

        UseWaitCursor = False
    End Sub

    Private Sub AddColumn_Click(sender As Object, e As EventArgs) Handles AddColumn.Click
        AddColumn.Enabled = False
        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = False

        Dim ColumnCount As Integer = DataGridView1.Columns.GetColumnCount(0)
#If DEBUG Then
        LogD(Me, "Column count: " & ColumnCount)
#End If

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
        Me.ColumnCountLabel.Text = ColumnCount.ToString

#If DEBUG Then
        LogD(Me, "Column count: " & ColumnCount)
#End If
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
        Me.ColumnCountLabel.Text = ColumnCount.ToString

#If DEBUG Then
        LogD(Me, "Column count: " & ColumnCount)
#End If
    End Sub

    Private Sub SaveActivity_Click(sender As Object, e As EventArgs) Handles SaveActivity.Click
        Dim ActivityString As String = ""
        For Each Row As DataGridViewRow In DataGridView1.Rows
            'ActivityString &= Row.Index & SemicolonChar

            Dim ColumnBoundaries As Integer = DataGridView1.DisplayedColumnCount(False) - 1

            Dim Cell As DataGridViewCell
            For i = 0 To ColumnBoundaries
                Cell = Row.Cells(i)
                If Cell.Value IsNot Nothing Then
                    ActivityString &= Cell.Value.ToString
                End If
                ActivityString &= SemicolonChar
            Next
            Cell = Row.Cells(ColumnBoundaries)
            ActivityString &= RowSplitter(0)
#If DEBUG Then
            LogD(Me, ActivityString)
#End If
            Try
                If Cell.Value IsNot Nothing Then
                    If Cell.Value.ToString.Contains(RowSplitter(0)) Then
                        MessageBox.Show(String.Format(My.Resources.Settings_Crossword_IllegalStringException, RowSplitter), My.Resources.General_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Catch ex As Exception
                ' Do nothing.
            End Try
#If DEBUG Then
            LogD(Me, ActivityString)
#End If
        Next
        If IsModifying Then
            My.Settings.Activities(CurrentActivityIndex) = Settings.ActivityListBox.SelectedIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & ActivityString
#If DEBUG Then
            LogD(Me, CurrentActivityIndex & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & ActivityString)
#End If
        Else
            Dim NewActivityID As Integer = GetNewID()
            My.Settings.Activities.Add(NewActivityID & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & ActivityString)
#If DEBUG Then
            LogD(Me, GetNewID() & SemicolonChar & Settings.SettingsActivityName.Text & SemicolonChar & Settings.SettingsActivityDescription.Text & SemicolonChar & Settings.SettingsActivityType.SelectedIndex & SemicolonChar & ActivityString)
#End If
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
                If Not String.IsNullOrEmpty(Cell.Value.ToString) Then
#If DEBUG Then
                    LogD(Me, "Cell at " & Cell.ColumnIndex & " in row index " & e.RowIndex & " is not null, processing...")
#End If
                    SaveActivity.Enabled = True
                    Exit For
                End If
#If DEBUG Then
            Else
                LogD(Me, "Cell at " & Cell.ColumnIndex & " in row index " & e.RowIndex & " is null, skipped.")
#End If
            End If
        Next
    End Sub
End Class