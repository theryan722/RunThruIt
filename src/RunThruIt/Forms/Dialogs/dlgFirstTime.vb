Public Class dlgFirstTime

#Region "UI"



#End Region

#Region "Methods"



#End Region

#Region "dlgFirstTime"

    Private Sub dlgFirstTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Parent = Nothing
    End Sub

    Private Sub dlgFirstTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Parent = frmManager
    End Sub

#End Region


End Class