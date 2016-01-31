Public Class frmManager

#Region "MenuStrip"

#Region "File"

    Private Sub WelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeToolStripMenuItem.Click
        Tabs.AddWelcome()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TipsQuotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipsQuotesToolStripMenuItem.Click
        dlgRandom.ShowDialog()
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

    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to reset all settings? Any non backed up data will be lost.", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            My.Settings.Reset()
            MetroFramework.MetroMessageBox.Show(Me, "Settings Successfully reset! Application will now restart!", "Application Restart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        End If
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

    Private Sub OtherTrackersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherTrackersToolStripMenuItem.Click
        Tabs.AddOtherTrackers()
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
        If My.Settings.set_firsttime Then
            dlgFirstTime.ShowDialog()
        Else
            Tabs.AddWelcome()

        End If
    End Sub

    Private Sub frmManager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.set_displaytipsatstartup Then
            dlgRandom.ShowDialog()
        End If
    End Sub

#End Region

End Class