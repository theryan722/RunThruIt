Public Class LogManager

    'type|date|notes|distance|shoes|pace|injury|time|duration

#Region "Public"

    Public Shared Sub AddToLog(ByVal nworkout As Workout)
        My.Settings.log_workout.Add(ConvertWorkoutToString(nworkout))
        InjuryManager.ProcessWorkout(nworkout)
    End Sub

    Public Shared Sub RemoveFromLog(ByVal nworkout As Workout)
        If My.Settings.log_workout.Contains(ConvertWorkoutToString(nworkout)) Then
            My.Settings.log_workout.Remove(ConvertWorkoutToString(nworkout))
        End If
    End Sub

    Public Shared Function GetWorkouts() As List(Of Workout)
        Dim ret As New List(Of Workout)
        For Each item As String In My.Settings.log_workout
            ret.Add(ConvertStringToWorkout(item))
        Next
        Return ret
    End Function

    Public Shared Sub ClearWorkouts()
        My.Settings.log_workout.Clear()
    End Sub

#End Region

#Region "Convert"

    Public Shared Function ConvertWorkoutToString(ByVal nworkout As Workout) As String
        Return nworkout.WorkoutType & "|" & nworkout.WorkoutDate.ToString() & "|" & nworkout.Notes & "|" & nworkout.Distance & "|" & nworkout.Shoes & "|" & nworkout.Pace & "|" & nworkout.Injury & "|" & nworkout.WorkoutTime.ToString("H:mm") & "|" & nworkout.Duration
    End Function

    Public Shared Function ConvertStringToWorkout(ByVal str As String) As Workout
        Dim arr() As String = str.Split("|")
        Return New Workout(arr(0), Date.Parse(arr(1)), arr(2), arr(3), arr(4), arr(5), arr(6), DateTime.Parse(arr(7)), arr(8))
    End Function

#End Region

End Class