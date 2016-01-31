Public Class Tab_Welcome

#Region "Buttons"

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Tabs.AddProfile()
    End Sub

    Private Sub btnGoals_Click(sender As Object, e As EventArgs) Handles btnGoals.Click
        Tabs.AddGoals()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Tabs.AddLog()
    End Sub

    Private Sub btnOtherTrackers_Click(sender As Object, e As EventArgs) Handles btnOtherTrackers.Click
        Tabs.AddOtherTrackers()
    End Sub

#End Region

End Class