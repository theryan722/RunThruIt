﻿Public Class Tab_shoes

#Region "UI"

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadShoes()
       
    End Sub

    Private Sub RemoveAllShoeItems()
        If pnl_list.Controls.Count > 0 Then
            For Each item As ctrl_shoeitem In pnl_list.Controls
                item.Dispose()
            Next
        End If
    End Sub

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