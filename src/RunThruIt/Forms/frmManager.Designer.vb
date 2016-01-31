<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManager
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipsQuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseCurrentTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllTabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherTrackersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.ResetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(0, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.UseSelectable = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TabsToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.GoalsToolStripMenuItem, Me.LogToolStripMenuItem, Me.OtherTrackersToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WelcomeToolStripMenuItem, Me.TipsQuotesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'WelcomeToolStripMenuItem
        '
        Me.WelcomeToolStripMenuItem.Name = "WelcomeToolStripMenuItem"
        Me.WelcomeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.WelcomeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.WelcomeToolStripMenuItem.Text = "Welcome"
        '
        'TipsQuotesToolStripMenuItem
        '
        Me.TipsQuotesToolStripMenuItem.Name = "TipsQuotesToolStripMenuItem"
        Me.TipsQuotesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TipsQuotesToolStripMenuItem.Text = "Tips && Quotes"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabsToolStripMenuItem
        '
        Me.TabsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseCurrentTabToolStripMenuItem, Me.CloseAllTabsToolStripMenuItem})
        Me.TabsToolStripMenuItem.Name = "TabsToolStripMenuItem"
        Me.TabsToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.TabsToolStripMenuItem.Text = "Tabs"
        '
        'CloseCurrentTabToolStripMenuItem
        '
        Me.CloseCurrentTabToolStripMenuItem.Name = "CloseCurrentTabToolStripMenuItem"
        Me.CloseCurrentTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CloseCurrentTabToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CloseCurrentTabToolStripMenuItem.Text = "Close Current Tab"
        '
        'CloseAllTabsToolStripMenuItem
        '
        Me.CloseAllTabsToolStripMenuItem.Name = "CloseAllTabsToolStripMenuItem"
        Me.CloseAllTabsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CloseAllTabsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CloseAllTabsToolStripMenuItem.Text = "Close All Tabs"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'GoalsToolStripMenuItem
        '
        Me.GoalsToolStripMenuItem.Name = "GoalsToolStripMenuItem"
        Me.GoalsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.GoalsToolStripMenuItem.Text = "Goals"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'OtherTrackersToolStripMenuItem
        '
        Me.OtherTrackersToolStripMenuItem.Name = "OtherTrackersToolStripMenuItem"
        Me.OtherTrackersToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.OtherTrackersToolStripMenuItem.Text = "Other Trackers"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.ResetSettingsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(192, 61)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(704, 429)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.UseSelectable = True
        '
        'ResetSettingsToolStripMenuItem
        '
        Me.ResetSettingsToolStripMenuItem.Name = "ResetSettingsToolStripMenuItem"
        Me.ResetSettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetSettingsToolStripMenuItem.Text = "Reset Settings"
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 533)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManager"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 20)
        Me.Text = "RunThruIt"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseCurrentTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllTabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherTrackersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelcomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipsQuotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
