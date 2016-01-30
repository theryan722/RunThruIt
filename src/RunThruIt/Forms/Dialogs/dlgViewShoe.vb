Public Class dlgViewShoe

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Methods"

    Public Sub DisplayShoe(ByVal nshoe As Shoe)
        lblName.Text = "Name: " & nshoe.ShoeName
        lblMileage.Text = "Mileage: " & nshoe.Mileage
        lblMaxMileage.Text = "Max Recommended Mileage: " & nshoe.MaxMileage
        lblDatePurchased.Text = "Date Purchased: " & nshoe.DatePurchased.ToString("mm:dd:yyyy")
        txtNotes.Text = nshoe.Notes
    End Sub

#End Region

End Class