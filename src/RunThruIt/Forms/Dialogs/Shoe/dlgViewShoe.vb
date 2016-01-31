Public Class dlgViewShoe

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FlashTimer_Tick(sender As Object, e As EventArgs) Handles FlashTimer.Tick
        If lblLifespanLeft.Visible Then
            lblLifespanLeft.Hide()
        Else
            lblLifespanLeft.Show()
        End If
    End Sub

#End Region

#Region "Methods"

    Public Sub DisplayShoe(ByVal nshoe As Shoe)
        lblName.Text = "Name: " & nshoe.ShoeName
        lblMileage.Text = "Mileage: " & nshoe.Mileage
        lblMaxMileage.Text = "Max Recommended Mileage: " & nshoe.MaxMileage
        lblDatePurchased.Text = "Date Purchased: " & nshoe.DatePurchased.ToString("M/dd/yyyy")
        txtNotes.Text = nshoe.Notes
        lblLifespanLeft.Text = "Life Span Left: " & CStr(CDbl(nshoe.GetLifespanLeft) * 100) & "%"
        If CDbl(nshoe.GetLifespanLeft) < 0.2 Then
            FlashTimer.Start()
            lblLifespanLeft.ForeColor = Color.Red
        End If
        nshoe.InjuryCheck()
    End Sub

#End Region

End Class