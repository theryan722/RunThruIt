Public Class Tab_Log

#Region "Methods"

    'Run
    'Bike
    'Walk
    'Swim
    'Hike
    'Strength Training
    'Yoga

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

#End Region

#Region "UI"



#End Region

#Region "Tab_Log"

    Private Sub Tab_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class