Public Class Tab_OtherTrackers

#Region "Water"

#Region "UI"

    Private Sub btn_water_addintakefortoday_Click(sender As Object, e As EventArgs) Handles btn_water_addintakefortoday.Click

    End Sub

    Private Sub btn_water_removeselected_Click(sender As Object, e As EventArgs) Handles btn_water_removeselected.Click

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadWater()
        lb_water.Items.Clear()
        For Each item As String In My.Settings.log_water
            lb_water.Items.Add(item)
        Next
    End Sub

#End Region

#End Region

End Class