' ====================
'      Crossword
' ====================

Public Class Play_ActivityType_Crossword
    Dim ColumnMaxIndex As Integer = -1

    Private Sub WipeDatagridView()
        DataGridView1.Columns.Clear()
        CellMap.Clear()
    End Sub

    ' CellMap
    '   => List (Of Integer) = X, Y
    '   => String = Data
    Dim CellMap As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Dim Score As Integer = 0
    Dim MaxScore As Integer = 0
    Public Sub LoadActivity()
        UseWaitCursor = True

        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = False

        WipeDatagridView() ' Try to wipe it.

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        StatusLabel.Text = String.Empty

        Dim ActivityPre As String = My.Settings.Activities(CurrentActivityIndex)
        For i = 0 To 3
            ActivityPre = ActivityPre.Remove(0, ActivityPre.IndexOf(";") + 1)
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
            Dim CurrentRow As String() = Row.Split(";")
            Dim ActivityRow As New DataGridViewRow()
            Dim ActivityCells As List(Of DataGridViewCell) = New List(Of DataGridViewCell)

            Dim DebugRowStr As String = CurrentRow.Length & ":"
            If CurrentRow.Length > 1 Then
                For X = 0 To CurrentRow.Length - 2
                    DebugRowStr &= " [" & CurrentRow(X) & "] "

                    Dim XY As String = X & ";" & Y
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

            Y += 1
        Next

        DataGridView1.Enabled = True
        DataGridView1.ReadOnly = False

        UseWaitCursor = False

#If DEBUG Then
        ' Report loaded keypairs and their values.
        For Each Key As String In CellMap.Keys
            Dim KeyArray As String() = Key.Split(";")
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

        ColumnMaxIndex = DataGridView1.Columns.GetColumnCount(0) - 1
        ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim TestPair As String = e.ColumnIndex & ";" & e.RowIndex

        Dim Out As String = String.Empty
        CellMap.TryGetValue(TestPair, Out)

        StatusLabel.Text = String.Empty

        If Not String.IsNullOrEmpty(Out) And Not String.IsNullOrEmpty(DataGridView1.CurrentCell.Value) Then
#If DEBUG Then
            LogD(Me, "Validating value...")
#End If
            If DataGridView1.CurrentCell.Value = Out Then
                DataGridView1.CurrentCell.Style.BackColor = My.Settings.UserRepOk
                Score += DefaultScoreMultiplier

                ScoreLabel.Text = Score.ToString & " / " & MaxScore.ToString

                StatusLabel.Text = My.Resources.Play_General_RightAnswer

#If DEBUG Then
                LogD(Me, "Done, the answer is right!")
#End If
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
            End If
        End If

        If Score = MaxScore Then
            MsgBox(My.Resources.Play_General_PerfectScore, MsgBoxStyle.Information, My.Resources.General_Info_Title)

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
            End If
            StatusResetTimer.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        If e.ColumnIndex = ColumnMaxIndex Or DataGridView1.CurrentCell.Style.BackColor = Color.LightGray Then
#If DEBUG Then
            LogD(Me, "Prevented editing of invalid cell.")
#End If
            e.Cancel = True
        End If
    End Sub

    Private Sub Play_ActivityType_Crossword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Score < MaxScore Then
            If MsgBox(My.Resources.Play_General_IncompleteActivityWarn, MsgBoxStyle.Information + MsgBoxStyle.YesNo, My.Resources.General_Warn_Title) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub StatusResetTImer_Tick(sender As Object, e As EventArgs) Handles StatusResetTimer.Tick
        StatusLabel.Text = String.Empty
        StatusResetTimer.Enabled = False
    End Sub
End Class