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
        If MetroFramework.MetroMessageBox.Show(frmManager, "Are you sure you want to remove this shoe?", "Remove Shoe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ShoeManager.RemoveShoe(ShoeItem)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub

#End Region

End Class
