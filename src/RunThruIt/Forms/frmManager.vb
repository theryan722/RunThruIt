Public Class frmManager

#Region "MenuStrip"

#Region "File"

    Private Sub WelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeToolStripMenuItem.Click
        Tabs.AddWelcome()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Tabs"

    Private Sub CloseAllTabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllTabsToolStripMenuItem.Click
        If AtLeastOneTab() Then
            For i As Integer = TabControl1.TabCount - 1 To 0 Step -1
                RemoveTab(i)
            Next
        End If
    End Sub

    Private Sub CloseCurrentTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCurrentTabToolStripMenuItem.Click
        If AtLeastOneTab() Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region "About"

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Tabs.AddAbout()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Tabs.AddOptions()
    End Sub

#End Region

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Tabs.AddProfile()
    End Sub

    Private Sub GoalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoalsToolStripMenuItem.Click
        Tabs.AddGoals()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        Tabs.AddLog()
    End Sub

    Private Sub InjuryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InjuryToolStripMenuItem.Click
        Tabs.AddInjury()
    End Sub

#End Region

#Region "Methods"

    Public Sub RemoveTab(ByVal index As Integer)
        Try
            Dim d As Integer = TabControl1.SelectedIndex
            TabControl1.SelectTab(index)
            If d = TabControl1.TabCount - 1 Then
                CloseCurrentTabToolStripMenuItem.PerformClick()
            Else
                RemoveTab()
                TabControl1.SelectTab(d)
            End If
        Catch
        End Try
    End Sub

    Public Function AtLeastOneTab() As Boolean
        If TabControl1.TabCount < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub RemoveTab()
        If AtLeastOneTab() Then
            Try
                TabControl1.SelectedTab.Dispose()
            Catch
            End Try
        End If
    End Sub

#End Region

#Region "frmManager"

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabs.AddWelcome()
    End Sub

#End Region   
    
End Class
