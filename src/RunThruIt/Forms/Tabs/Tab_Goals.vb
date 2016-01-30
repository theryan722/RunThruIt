Public Class Tab_Goals

#Region "UI"

#Region "TabGoals"

#Region "Context Menu Strip"



#End Region

#End Region

#Region "TabCompleted"

#Region "Context Menu Strip"



#End Region

#End Region

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

#End Region

#Region "Methods"

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

    End Sub

    Private Sub MarkGoalAsCompleted()

    End Sub

    Private Sub MarkGoalAsIncomplete()

    End Sub

    Private Sub RemoveGoal()

    End Sub

    Private Sub RemoveCompleted()

    End Sub

    Private Sub RemoveAllCompleted()

    End Sub

    Private Sub RemoveAllGoals()

    End Sub

#End Region

#Region "Tab_Goals"

    Private Sub Tab_Goals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region
    
End Class