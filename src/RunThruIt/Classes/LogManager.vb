Public Class LogManager

    'type|date|notes|distance|shoes|pace|injured

#Region "Public"

    Public Shared Sub AddToLog(ByVal nworkout As Workout)

    End Sub

    Public Shared Sub RemoveFromLog(ByVal nworkout As Workout)

    End Sub

    Public Shared Function GetWorkouts() As List(Of Workout)

    End Function


    Public Shared Sub ClearWorkouts()
        My.Settings.log_workout.Clear()
    End Sub

    Public Shared Function ConvertWorkoutToString(ByVal nworkout As Workout) As String
        Return nworkout.WorkoutType & "|" & nworkout.WorkoutDate.ToString() & "|" & nworkout.Notes & "|" & nworkout.Distance & "|" & nworkout.Shoes & "|" & nworkout.Pace & "|" & nworkout.Injured.ToString
    End Function

#End Region

#Region "Private"

    Private Function ParseSetting(ByVal str As String) As Workout
        Dim arr() As String = str.Split("|")
        Return New Workout(arr(0), Date.Parse(arr(1)), arr(2), arr(3), arr(4), arr(5), Boolean.Parse(arr(6)))
    End Function

#End Region

End Class