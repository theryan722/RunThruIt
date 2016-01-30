Public Class Tabs

#Region "Tabs"

    Public Shared Sub AddAbout()
        Dim t As New TabPage
        Dim newtab As New Tab_About
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        frmManager.TabControl1.TabPages.Add(t)
        newtab.Parent.Text = newtab.Text
        frmManager.TabControl1.SelectedTab = t
    End Sub

    Public Shared Sub AddGoals()
        Dim t As New TabPage
        Dim newtab As New Tab_Goals
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        frmManager.TabControl1.TabPages.Add(t)
        newtab.Parent.Text = newtab.Text
        frmManager.TabControl1.SelectedTab = t
    End Sub

    Public Shared Sub AddInjury()
        Dim t As New TabPage
        Dim newtab As New Tab_Injury
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        frmManager.TabControl1.TabPages.Add(t)
        newtab.Parent.Text = newtab.Text
        frmManager.TabControl1.SelectedTab = t
    End Sub

    Public Shared Sub AddLog()
        Dim t As New TabPage
        Dim newtab As New Tab_Log
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        frmManager.TabControl1.TabPages.Add(t)
        newtab.Parent.Text = newtab.Text
        frmManager.TabControl1.SelectedTab = t
    End Sub

    Public Shared Sub AddOptions()
        Dim t As New TabPage
        Dim newtab As New Tab_Options
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        t.Controls.Add(newtab)
        frmManager.TabControl1.TabPages.Add(t)
        newtab.Parent.Text = newtab.Text
        frmManager.TabControl1.SelectedTab = t
    End Sub

#End Region

End Class
