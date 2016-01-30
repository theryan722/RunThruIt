Public Class dlgNewShoe

    Public Property NewShoe As Shoe

#Region "UI"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

    End Sub

#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean

    End Function

    Private Sub CreateShoe(ByVal sname As String, ByVal smileage As String, ByVal smaxmileage As String, ByVal snotes As String, ByVal sdate As Date)
        NewShoe = New Shoe(sname, smileage, snotes, sdate, smaxmileage)
    End Sub

#End Region

#Region "dlgNewShoe"

    Private Sub dlgNewShoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class