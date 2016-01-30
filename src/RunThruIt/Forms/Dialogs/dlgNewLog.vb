Public Class dlgNewLog

    Public Property NewWorkout As Workout

#Region "UI"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

    End Sub

#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If combo_type.SelectedIndex = -1 Then
            ret = False
        End If
        If Not IsDate(dt_date.Value) Then
            ret = False
        End If
        Return ret
    End Function

    Private Sub CreateWorkout(ByVal type As String, ByVal wdate As Date, ByVal notes As String, ByVal distance As String, ByVal shoes As String, ByVal pace As String, ByVal injured As Boolean)
        Dim b As Workout = New Workout
        b.WorkoutType = type
        b.WorkoutDate = wdate
        b.Notes = notes
        b.Distance = distance
        b.Shoes = shoes
        b.Pace = pace
        b.Injured = injured
        NewWorkout = b
    End Sub

#End Region

End Class