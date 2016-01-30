﻿Public Class ctrl_logitem

    Dim witem As Workout

    Public Property WorkoutItem As Workout
        Get
            Return witem
        End Get
        Set(value As Workout)
            witem = value
            lblType.Text = "Type: " & value.WorkoutType
            lblDuration.Text = "Duration: " & value.Duration & " minutes"
            lblDate.Text = "Date: " & value.WorkoutDate.ToString("M/dd/yy") & " at " & value.WorkoutTime.ToString("H:mm")
        End Set
    End Property

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
        newb.ShowDialog()
    End Sub

#End Region

#Region "ctrl_logitem"

    Private Sub ctrl_logitem_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        btnView.PerformClick()
    End Sub

#End Region
    
End Class
