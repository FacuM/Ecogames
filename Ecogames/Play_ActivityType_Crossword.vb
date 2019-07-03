' ====================
'      Crossword
' ====================

Public Class Play_ActivityType_Crossword
    Dim ColumnMaxIndex As Integer = -1
    Dim CrosswordMaxTimePerRow As Integer = 0

    Private Sub WipeDatagridView()
        DataGridView1.Columns.Clear()
        CellMap.Clear()
        ColumnMaxIndex = -1
    End Sub

    ' CellMap
    '   => List (Of Integer) = X, Y
    '   => String = Data
    Dim CellMap As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Dim Score As Integer = 0
    Dim MaxScore As Integer = 0

    Dim RemainingSeconds As Integer
    Dim ClockMode As Boolean = True

    Public Sub LoadActivity()
        UseWaitCursor = True

        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = False

        WipeDatagridView() ' Try to wipe it.

        ' Cleanup
        Score = 0
        MaxScore = 0

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        StatusLabel.Text = String.Empty

        Dim ActivityPre As String = My.Settings.Activities(CurrentActivityIndex)

        CrosswordMaxTimePerRow = Integer.Parse(ActivityPre.Split(SemicolonChar)(4))

        For i = 0 To 4
            ActivityPre = ActivityPre.Remove(0, ActivityPre.IndexOf(SemicolonChar) + 1)
#If DEBUG Then
            LogD(Me, ActivityPre)
#End If
        Next

        Dim FirstPass As Boolean = True
#If DEBUG Then
        LogD(Me, "Parsing activity...")
#End If
        Dim Y As Integer = 0
        For Each Row As String In ActivityPre.Split(RowSplitter, options:=StringSplitOptions.None)
            Dim CurrentRow As String() = Row.Split(SemicolonChar)
            Dim ActivityRow As New DataGridViewRow()
            Dim ActivityCells As List(Of DataGridViewCell) = New List(Of DataGridViewCell)

#If DEBUG Then
            Dim DebugRowStr As String = CurrentRow.Length & ":"
#End If
            If CurrentRow.Length > 1 Then
                For X = 0 To CurrentRow.Length - 2
#If DEBUG Then
                    DebugRowStr &= " [" & CurrentRow(X) & "] "
#End If

                    Dim XY As String = X & SemicolonChar & Y
                    CellMap.Add(XY, CurrentRow(X))

                    If Not String.IsNullOrEmpty(CurrentRow(X)) And X <> CurrentRow.Length - 2 Then
                        MaxScore += DefaultScoreMultiplier
                    End If

                    Dim Cell As DataGridViewCell = New DataGridViewTextBoxCell

                    Dim HasData As Boolean = False

                    For Each CellData As String In CurrentRow
                        If Not String.IsNullOrEmpty(CellData) Then
                            HasData = True
                            Exit For
                        End If
                    Next

                    If X <> CurrentRow.Length - 2 Then
                        If String.IsNullOrEmpty(CurrentRow(X)) Then
                            If HasData Then
                                Cell.Style.BackColor = Color.LightGray
                            Else
                                Cell.Style.BackColor = Color.DimGray
                            End If
                        End If
                    Else
                        Cell.Value = CurrentRow(X)
                    End If

                    ActivityCells.Add(Cell)

                    If FirstPass Then
                        Dim CellTemplate As New DataGridViewTextBoxCell
                        Dim NewColumn As New DataGridViewTextBoxColumn With {
                            .CellTemplate = CellTemplate
                        }
                        DataGridView1.Columns.Add(NewColumn)

                        ColumnMaxIndex += 1
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
                FirstPass = False
            End If

            Y += 1
        Next

        For i = 0 To ColumnMaxIndex - 1
            DirectCast(DataGridView1.Columns(i), DataGridViewTextBoxColumn).MaxInputLength = 1
        Next

        Dim ReferenceTextCellTemplate As New DataGridViewTextBoxCell

        Dim ReferenceTextColumn As DataGridViewColumn = DataGridView1.Columns(ColumnMaxIndex)
        ReferenceTextColumn.CellTemplate = ReferenceTextCellTemplate
        ReferenceTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ReferenceTextColumn.HeaderText = My.Resources.Crossword_ColumnHeader_ReferenceText

        DataGridView1.Enabled = True
        DataGridView1.ReadOnly = False

        UseWaitCursor = False

#If DEBUG Then
        ' Report loaded keypairs and their values.
        For Each Key As String In CellMap.Keys
            Dim KeyArray As String() = Key.Split(SemicolonChar)
            Dim CurX As Integer = Integer.Parse(KeyArray(0))
            Dim CurY As Integer = Integer.Parse(KeyArray(1))

            Dim Out As String = String.Empty

            CellMap.TryGetValue(Key, Out)

            If String.IsNullOrEmpty(Out) Then
                Out = "(empty)"
            End If
            LogD(Me, "X = " & CurX & "; Y = " & CurY & "; DATA = " & Out)
        Next
#End If

        ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString

        If CrosswordMaxTimePerRow > 0 Then
            TimeManager.Enabled = True

            RemainingSeconds = CrosswordMaxTimePerRow
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim TestPair As String = e.ColumnIndex & SemicolonChar & e.RowIndex

        Dim Out As String = String.Empty
        CellMap.TryGetValue(TestPair, Out)

        StatusLabel.Text = String.Empty

        If DataGridView1.CurrentCell.Value IsNot Nothing Then
            If Not String.IsNullOrEmpty(Out) And Not String.IsNullOrEmpty(DataGridView1.CurrentCell.Value.ToString) Then
#If DEBUG Then
                LogD(Me, "Validating value...")
#End If
                If DataGridView1.CurrentCell.Value.ToString.ToLower() = Out.ToLower() Then
                    RemainingSeconds = CrosswordMaxTimePerRow

                    DataGridView1.CurrentCell.Value = Out
                    DataGridView1.CurrentCell.Style.BackColor = My.Settings.UserRepOk
                    Score += DefaultScoreMultiplier

                    ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString

                    StatusLabel.Text = My.Resources.Play_General_RightAnswer

#If DEBUG Then
                    LogD(Me, "Done, the answer is right!")
#End If
                    My.Computer.Audio.Play(My.Resources.Right, AudioPlayMode.Background)
                Else
                    If DataGridView1.CurrentCell.Style.BackColor = My.Settings.UserRepOk Then
                        Score -= DefaultScoreMultiplier

                        ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString
                    Else
                        DataGridView1.CurrentCell.Style.BackColor = My.Settings.UserRepWrong
                    End If

                    StatusLabel.Text = My.Resources.Play_General_WrongAnswer

#If DEBUG Then
                    LogD(Me, "Done, wrong answer.")
#End If
                    My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
                End If
            End If
        End If


        If Score = MaxScore Then
            TimeManager.Enabled = False

            My.Computer.Audio.Play(My.Resources.Perfect, AudioPlayMode.Background)
            MessageBox.Show(My.Resources.Play_General_PerfectScore, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

            StatusLabel.Text = My.Resources.Play_General_PerfectScore
            DataGridView1.ReadOnly = True

            For i = 0 To ColumnMaxIndex - 1
                Dim Row As DataGridViewRow = DataGridView1.Rows(i)

                For Each Cell As DataGridViewCell In Row.Cells
                    If Cell.Style.BackColor = Color.LightGray Then
                        Cell.Style.BackColor = Color.DimGray
                    End If
                Next
            Next

        Else
            Dim RowIsDone As Boolean = True
            For i = 0 To ColumnMaxIndex - 1
                Dim Cell As DataGridViewCell = DataGridView1.CurrentRow.Cells(i)
                If Cell.Style.BackColor <> Color.LightGray Then
                    If Cell.Style.BackColor <> My.Settings.UserRepOk Then
                        RowIsDone = False
                        Exit For
                    End If
                End If
            Next

            If RowIsDone Then
                For Each Cell As DataGridViewCell In DataGridView1.CurrentRow.Cells
                    If Cell.Style.BackColor = Color.LightGray Then
                        Cell.Style.BackColor = Color.DimGray
                    End If
                    Cell.ReadOnly = True
                Next
                StatusLabel.Text = My.Resources.Play_Crossword_RowDone
                My.Computer.Audio.Play(My.Resources.Completed, AudioPlayMode.Background)

                RemainingSeconds = CrosswordMaxTimePerRow
            End If
            StatusResetTimer.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        If e.ColumnIndex = ColumnMaxIndex Or DataGridView1.CurrentCell.Style.BackColor = Color.LightGray Or DataGridView1.CurrentCell.Style.BackColor = Color.DimGray Then
#If DEBUG Then
            LogD(Me, "Prevented editing of invalid cell at " & e.RowIndex & SemicolonChar & e.ColumnIndex & ".")
#End If
            e.Cancel = True
        End If
    End Sub

    Private Sub Play_ActivityType_Crossword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Score < MaxScore And PreventClose Then
            If MessageBox.Show(My.Resources.Play_General_IncompleteActivityWarn, My.Resources.General_Info_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub StatusResetTImer_Tick(sender As Object, e As EventArgs) Handles StatusResetTimer.Tick
        StatusLabel.Text = String.Empty
        StatusResetTimer.Enabled = False
    End Sub

    Private Sub TimeManager_Tick(sender As Object, e As EventArgs) Handles TimeManager.Tick
        If Not (StatusResetTimer.Enabled And SplashScreen.SeparateThreadBusy) Then
            If RemainingSeconds > 0 Then
                If RemainingSeconds = 1 Then
                    StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Singular, RemainingSeconds)
                Else
                    StatusLabel.Text = String.Format(My.Resources.Play_General_RemainingSeconds_Plural, RemainingSeconds)
                End If
#If DEBUG Then
                LogD(Me, RemainingSeconds & " seconds remaining.")
#End If
                RemainingSeconds -= 1

                If RemainingSeconds < 5 Then
                    If ClockMode Then
                        My.Computer.Audio.Play(My.Resources.Clock_tic, AudioPlayMode.Background)
                    Else
                        My.Computer.Audio.Play(My.Resources.Clock_tac, AudioPlayMode.Background)
                    End If

                    ClockMode = Not ClockMode
                End If
            Else
                PreventClose = False
                DataGridView1.ReadOnly = True
                TimeManager.Enabled = False

                StatusLabel.Text = My.Resources.Play_General_Timedout

                If Score = 0 Then
                    My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
                    MessageBox.Show(My.Resources.Play_General_Timedout & vbCrLf & vbCrLf & My.Resources.Play_General_NoCompletion, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    My.Computer.Audio.Play(My.Resources.Completed, AudioPlayMode.Background)
                    MessageBox.Show(My.Resources.Play_General_Timedout & vbCrLf & vbCrLf & String.Format(My.Resources.Play_General_CompletionLevel, Score, MaxScore, ((Score * MaxScore) / 100)), My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf SplashScreen.SeparateThreadBusy Then
            TimeManager.Enabled = False
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        TimeManager.Enabled = False
        Hide()
        MessageBox.Show(My.Resources.Play_General_Paused, My.Resources.General_Info_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Show()
        TimeManager.Enabled = True
    End Sub
End Class
