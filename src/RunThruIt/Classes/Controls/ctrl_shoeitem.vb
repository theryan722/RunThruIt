Public Class ctrl_shoeitem

    Private sitem As Shoe

    Public Property ShoeItem As Shoe
        Get
            Return sitem
        End Get
        Set(value As Shoe)
            sitem = value
            lblName.Text = "Name: " & value.ShoeName
            lblMileage.Text = "Name: " & value.Mileage
        End Set
    End Property

#Region "UI"

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub

#End Region

End Class
