Public Class Tab_shoes

#Region "UI"

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        LoadShoes()
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If MetroFramework.MetroMessageBox.Show(frmManager, "Are you sure you want to remove all shoes?", "Clear Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ShoeManager.ClearShoes()
            RemoveAllShoeItems()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bb As New dlgNewShoe
        If bb.ShowDialog = Windows.Forms.DialogResult.OK Then
            ShoeManager.AddShoe(bb.NewShoe)
            frmManager.CloseCurrentTabToolStripMenuItem.PerformClick()
            Tabs.AddShoes()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub LoadShoes()
        RemoveAllShoeItems()
        For Each item As Shoe In ShoeManager.GetShoes()
            Dim newb As New ctrl_shoeitem
            newb.ShoeItem = item
            newb.BackColor = ConvertShoeLifespanToColor(item.GetLifespanLeft)
            newb.Dock = DockStyle.Top
            pnl_list.Controls.Add(newb)
        Next
    End Sub

    Private Sub RemoveAllShoeItems()
        If pnl_list.Controls.Count > 0 Then
            For Each item As ctrl_shoeitem In pnl_list.Controls
                item.Dispose()
            Next
        End If
    End Sub

    Private Function ConvertShoeLifespanToColor(ByVal ls As String) As Color
        Select Case CDbl(ls)
            Case Is > 0.5
                Return Color.Green
            Case Is > 0.4
                Return Color.LimeGreen
            Case Is > 0.3
                Return Color.Yellow
            Case Is > 0.2
                Return Color.Orange
            Case Is > 0.15
                Return Color.OrangeRed
            Case Else
                Return Color.Red
        End Select
    End Function


#End Region

#Region "Tab_Shoes"

    Private Sub Tab_shoes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub Tab_shoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShoes()
    End Sub

#End Region

End Class