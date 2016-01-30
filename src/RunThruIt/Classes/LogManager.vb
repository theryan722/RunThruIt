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

    End Sub

#End Region

#Region "Private"

    Private Function ParseSetting(ByVal str As String) As Workout
        Dim arr() As String = str.Split("|")
        Return New Workout(arr(0), Date.Parse(arr(1)), arr(2), arr(3), arr(4), arr(5), Boolean.Parse(arr(6)))
    End Function

#End Region

End Class