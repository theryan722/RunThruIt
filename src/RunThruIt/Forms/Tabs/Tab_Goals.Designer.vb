<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Goals
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReload = New MetroFramework.Controls.MetroTile()
        Me.btnRemoveAll = New MetroFramework.Controls.MetroTile()
        Me.btnAdd = New MetroFramework.Controls.MetroTile()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabGoals = New System.Windows.Forms.TabPage()
        Me.TabCompleted = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_goals = New System.Windows.Forms.ListBox()
        Me.lb_completed = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip_Goals = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip_Completed = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddGoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkAsIncompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsCompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnl_bottom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabGoals.SuspendLayout()
        Me.TabCompleted.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip_Goals.SuspendLayout()
        Me.ContextMenuStrip_Completed.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Controls.Add(Me.TableLayoutPanel1)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 470)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(707, 60)
        Me.pnl_bottom.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReload, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRemoveAll, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 60)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReload
        '
        Me.btnReload.ActiveControl = Nothing
        Me.btnReload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReload.Location = New System.Drawing.Point(3, 3)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(229, 54)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReload.UseSelectable = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.ActiveControl = Nothing
        Me.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveAll.Location = New System.Drawing.Point(238, 3)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(229, 54)
        Me.btnRemoveAll.Style = MetroFramework.MetroColorStyle.Red
        Me.btnRemoveAll.TabIndex = 1
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemoveAll.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.ActiveControl = Nothing
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Location = New System.Drawing.Point(473, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(231, 54)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Goal"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.UseSelectable = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGoals)
        Me.TabControl1.Controls.Add(Me.TabCompleted)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(707, 470)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.UseSelectable = True
        '
        'TabGoals
        '
        Me.TabGoals.Controls.Add(Me.Panel1)
        Me.TabGoals.Location = New System.Drawing.Point(4, 38)
        Me.TabGoals.Name = "TabGoals"
        Me.TabGoals.Size = New System.Drawing.Size(699, 428)
        Me.TabGoals.TabIndex = 0
        Me.TabGoals.Text = "Goals"
        '
        'TabCompleted
        '
        Me.TabCompleted.Controls.Add(Me.Panel2)
        Me.TabCompleted.Location = New System.Drawing.Point(4, 38)
        Me.TabCompleted.Name = "TabCompleted"
        Me.TabCompleted.Size = New System.Drawing.Size(699, 428)
        Me.TabCompleted.TabIndex = 1
        Me.TabCompleted.Text = "Completed"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lb_goals)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 428)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lb_completed)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(699, 428)
        Me.Panel2.TabIndex = 0
        '
        'lb_goals
        '
        Me.lb_goals.ContextMenuStrip = Me.ContextMenuStrip_Goals
        Me.lb_goals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_goals.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_goals.FormattingEnabled = True
        Me.lb_goals.ItemHeight = 18
        Me.lb_goals.Location = New System.Drawing.Point(0, 0)
        Me.lb_goals.Name = "lb_goals"
        Me.lb_goals.ScrollAlwaysVisible = True
        Me.lb_goals.Size = New System.Drawing.Size(699, 428)
        Me.lb_goals.TabIndex = 0
        '
        'lb_completed
        '
        Me.lb_completed.ContextMenuStrip = Me.ContextMenuStrip_Completed
        Me.lb_completed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_completed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_completed.FormattingEnabled = True
        Me.lb_completed.ItemHeight = 18
        Me.lb_completed.Location = New System.Drawing.Point(0, 0)
        Me.lb_completed.Name = "lb_completed"
        Me.lb_completed.ScrollAlwaysVisible = True
        Me.lb_completed.Size = New System.Drawing.Size(699, 428)
        Me.lb_completed.TabIndex = 1
        '
        'ContextMenuStrip_Goals
        '
        Me.ContextMenuStrip_Goals.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.ToolStripSeparator1, Me.MarkAsCompletedToolStripMenuItem, Me.ToolStripSeparator3, Me.AddGoalToolStripMenuItem})
        Me.ContextMenuStrip_Goals.Name = "ContextMenuStrip_Goals"
        Me.ContextMenuStrip_Goals.Size = New System.Drawing.Size(178, 82)
        '
        'ContextMenuStrip_Completed
        '
        Me.ContextMenuStrip_Completed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem1, Me.ToolStripSeparator2, Me.MarkAsIncompleteToolStripMenuItem})
        Me.ContextMenuStrip_Completed.Name = "ContextMenuStrip_Completed"
        Me.ContextMenuStrip_Completed.Size = New System.Drawing.Size(179, 76)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'AddGoalToolStripMenuItem
        '
        Me.AddGoalToolStripMenuItem.Name = "AddGoalToolStripMenuItem"
        Me.AddGoalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddGoalToolStripMenuItem.Text = "Add Goal"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'MarkAsIncompleteToolStripMenuItem
        '
        Me.MarkAsIncompleteToolStripMenuItem.Name = "MarkAsIncompleteToolStripMenuItem"
        Me.MarkAsIncompleteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MarkAsIncompleteToolStripMenuItem.Text = "Mark as Incomplete"
        '
        'MarkAsCompletedToolStripMenuItem
        '
        Me.MarkAsCompletedToolStripMenuItem.Name = "MarkAsCompletedToolStripMenuItem"
        Me.MarkAsCompletedToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MarkAsCompletedToolStripMenuItem.Text = "Mark as Completed"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(174, 6)
        '
        'Tab_Goals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnl_bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_Goals"
        Me.ShowInTaskbar = False
        Me.Text = "Goals"
        Me.pnl_bottom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabGoals.ResumeLayout(False)
        Me.TabCompleted.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ContextMenuStrip_Goals.ResumeLayout(False)
        Me.ContextMenuStrip_Completed.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReload As MetroFramework.Controls.MetroTile
    Friend WithEvents btnRemoveAll As MetroFramework.Controls.MetroTile
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabGoals As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabCompleted As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lb_goals As System.Windows.Forms.ListBox
    Friend WithEvents lb_completed As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip_Goals As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip_Completed As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MarkAsCompletedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddGoalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MarkAsIncompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
