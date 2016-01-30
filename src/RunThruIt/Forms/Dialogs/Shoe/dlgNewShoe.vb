Public Class dlgNewShoe

    Public Property NewShoe As Shoe

#Region "UI"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyFields() Then
            CreateShoe(txtName.Text, txtMileage.Text, txtMaxMileage.Text, txtNotes.Text, Convert.ToDateTime(dt_date.Value))
            My.Settings.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MetroFramework.MetroMessageBox.Show(frmManager, "Please make sure you properly fill out the form and all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If txtName.Text = "" Or Not IsNumeric(txtMileage.Text) Or Not IsNumeric(txtMaxMileage.Text) Then
            ret = False
        End If
        If Not IsDate(dt_date.Value) Then
            ret = False
        End If
        Return ret
    End Function

    Private Sub CreateShoe(ByVal sname As String, ByVal smileage As String, ByVal smaxmileage As String, ByVal snotes As String, ByVal sdate As Date)
        NewShoe = New Shoe(sname, smileage, snotes, sdate, smaxmileage)
    End Sub

#End Region

End Class