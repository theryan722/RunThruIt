Public Class Tab_Goals

#Region "UI"

#Region "TabGoals"

#Region "Context Menu Strip"

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveGoal()
    End Sub

    Private Sub MarkAsCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsCompletedToolStripMenuItem.Click
        MarkGoalAsCompleted()
    End Sub

    Private Sub AddGoalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGoalToolStripMenuItem.Click
        AddGoal()
    End Sub

#End Region

#End Region

#Region "TabCompleted"

#Region "Context Menu Strip"

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        RemoveCompleted()
    End Sub

    Private Sub MarkAsIncompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsIncompleteToolStripMenuItem.Click
        MarkGoalAsIncomplete()
    End Sub

#End Region

#End Region

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        LoadAll()
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If MetroFramework.MetroMessageBox.Show(frmManager, "Are you sure you want to remove all goals, both complete and incomplete?", "Remove All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            RemoveAllGoals()
            RemoveAllCompleted()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddGoal()
    End Sub

#End Region

#Region "Methods"

    Private Sub AddGoal()
        Dim newg As String = InputBox("Please enter a new goal:", "New Goal", "")
        My.Settings.log_goals.Add(newg)
        LoadGoals()
    End Sub

    Private Sub LoadGoals()
        lb_goals.Items.Clear()
        For Each item As String In My.Settings.log_goals
            lb_goals.Items.Add(item)
        Next
    End Sub

    Private Sub LoadCompleted()
        lb_completed.Items.Clear()
        For Each item As String In My.Settings.log_completedgoals
            lb_completed.Items.Add(item)
        Next
    End Sub

    Private Sub LoadAll()
        LoadGoals()
        LoadCompleted()
    End Sub

    Private Sub MarkGoalAsCompleted()
        If lb_goals.SelectedIndex <> -1 Then
            My.Settings.log_completedgoals.Add(lb_goals.SelectedItem)
            My.Settings.log_goals.Remove(lb_goals.SelectedItem)
            LoadAll()
        End If
    End Sub

    Private Sub MarkGoalAsIncomplete()
        If lb_completed.SelectedIndex <> -1 Then
            My.Settings.log_goals.Add(lb_completed.SelectedItem)
            My.Settings.log_completedgoals.Remove(lb_completed.SelectedItem)
            LoadAll()
        End If
    End Sub

    Private Sub RemoveGoal()
        If lb_goals.SelectedIndex <> -1 Then
            My.Settings.log_goals.Remove(lb_goals.SelectedItem)
            LoadGoals()
        End If
    End Sub

    Private Sub RemoveCompleted()
        If lb_completed.SelectedIndex <> -1 Then
            My.Settings.log_completedgoals.Remove(lb_completed.SelectedItem)
            LoadCompleted()
        End If
    End Sub

    Private Sub RemoveAllCompleted()
        My.Settings.log_completedgoals.Clear()
        LoadCompleted()
    End Sub

    Private Sub RemoveAllGoals()
        My.Settings.log_goals.Clear()
        LoadGoals()
    End Sub

#End Region

#Region "Tab_Goals"

    Private Sub Tab_Goals_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub Tab_Goals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAll()
    End Sub

#End Region
    
End Class