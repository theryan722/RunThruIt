﻿Public Class Tab_Log

#Region "Methods"""

    Private Sub LoadWorkouts()
        For Each item As Workout In LogManager.GetWorkouts()

        Next
    End Sub

    Private Function ConvertWorkoutTypeToColor(ByVal workouttype As String) As Color
        Dim ret As Color = Color.Green
        Select Case workouttype
            Case "Run"
                ret = Color.Green
            Case "Bike"
                ret = Color.Orange
            Case "Walk"
                ret = Color.Turquoise
            Case "Swim"
                ret = Color.Blue
            Case "Hike"
                ret = Color.Red
            Case "Strength Training"
                ret = Color.Yellow
            Case "Yoga"
                ret = Color.Purple
            Case Else
                ret = Color.Gray
        End Select
        Return ret
    End Function

    Private Sub RemoveAllWorkoutItems()
        If pnl_list.Controls.Count > 0 Then
            For Each item As ctrl_logitem In pnl_list.Controls
                item.Dispose()
            Next
        End If
    End Sub

#End Region

#Region "UI"

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        LoadWorkouts()
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If MetroFramework.MetroMessageBox.Show(frmManager, "Are you sure you want to clear all workouts?", "Clear Workouts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LogManager.ClearWorkouts()
            RemoveAllWorkoutItems()
        End If
    End Sub

#End Region

#Region "Tab_Log"

    Private Sub Tab_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWorkouts()
    End Sub

#End Region

End Class