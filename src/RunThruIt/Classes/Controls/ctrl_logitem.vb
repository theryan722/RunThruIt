Public Class ctrl_logitem

    Public Property WorkoutItem As Workout

#Region "Buttons"

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MetroFramework.MetroMessageBox.Show(frmManager, "Are you sure you want to remove this workout?", "Remove Workout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LogManager.RemoveFromLog(WorkoutItem)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim newb As New dlgViewLog
        newb.DisplayWorkout(WorkoutItem)
        newb.Show()
    End Sub

#End Region
    
End Class
