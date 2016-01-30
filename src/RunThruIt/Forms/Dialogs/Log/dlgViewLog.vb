Public Class dlgViewLog

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Methods"

    Public Sub DisplayWorkout(ByVal nworkout As Workout)
        lblType.Text = "Type: " & nworkout.WorkoutType
        lblDate.Text = "Date: " & nworkout.WorkoutDate.ToString("M/dd/yyyy")
        lblDistance.Text = "Distance: " & nworkout.Distance & " miles"
        lblInjury.Text = "Injury: " & nworkout.Injury
        lblPace.Text = "Pace: " & nworkout.Pace
        lblShoes.Text = "Shoes: " & nworkout.Shoes
        txtNotes.Text = nworkout.Notes
        lblTime.Text = "Time: " & nworkout.WorkoutTime.ToString("H:mm")
        lblDuration.Text = "Duration: " & nworkout.Duration & " minutes"
    End Sub

#End Region
    
End Class