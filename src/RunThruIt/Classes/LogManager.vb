Public Class LogManager

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

    End Function

#End Region

End Class