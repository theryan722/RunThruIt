Public Class dlgRandom

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewQuote_Click(sender As Object, e As EventArgs) Handles btnNewQuote.Click
        TextBox1.Text = RandomInfo.GetRandomQuote()
    End Sub

    Private Sub btnNewTip_Click(sender As Object, e As EventArgs) Handles btnNewTip.Click
        TextBox1.Text = RandomInfo.GetRandomTip()
    End Sub

#End Region

#Region "dlgRandom"

    Private Sub dlgRandom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.set_displaytipsatstartup = check_displayatstartup.Checked
        My.Settings.Save()
    End Sub

    Private Sub dlgRandom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_displayatstartup.Checked = My.Settings.set_displaytipsatstartup
        Select Case New Random().Next(0, 2)
            Case 0
                btnNewQuote.PerformClick()
            Case 1
                btnNewTip.PerformClick()
        End Select
    End Sub

#End Region
    
End Class