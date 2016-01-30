Public Class dlgViewLog

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Methods"

    Public Sub DisplayWorkout(ByVal nworkout As Workout)
        lblType.Text = "Type: " & nworkout.WorkoutType
        lblDate.Text = "Date: " & nworkout.WorkoutDate
        lblDistance.Text = "Distance: " & nworkout.Distance
        lblInjury.Text = "Injury: " & nworkout.Injury
        lblPace.Text = "Pace: " & nworkout.Pace
        lblShoes.Text = "Shoes: " & nworkout.Shoes
        txtNotes.Text = nworkout.Notes
    End Sub

#End Region
    
End Class