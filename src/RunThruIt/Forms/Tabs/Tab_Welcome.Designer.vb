<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Welcome
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
        Me.btnGoals = New MetroFramework.Controls.MetroTile()
        Me.btnInjury = New MetroFramework.Controls.MetroTile()
        Me.btnLog = New MetroFramework.Controls.MetroTile()
        Me.btnProfile = New MetroFramework.Controls.MetroTile()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGoals
        '
        Me.btnGoals.ActiveControl = Nothing
        Me.btnGoals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGoals.Location = New System.Drawing.Point(267, 3)
        Me.btnGoals.Name = "btnGoals"
        Me.btnGoals.Size = New System.Drawing.Size(259, 225)
        Me.btnGoals.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGoals.TabIndex = 0
        Me.btnGoals.Text = "Goals"
        Me.btnGoals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGoals.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnGoals.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.btnGoals.UseSelectable = True
        '
        'btnInjury
        '
        Me.btnInjury.ActiveControl = Nothing
        Me.btnInjury.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInjury.Location = New System.Drawing.Point(267, 234)
        Me.btnInjury.Name = "btnInjury"
        Me.btnInjury.Size = New System.Drawing.Size(259, 225)
        Me.btnInjury.Style = MetroFramework.MetroColorStyle.Red
        Me.btnInjury.TabIndex = 1
        Me.btnInjury.Text = "Injury"
        Me.btnInjury.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnInjury.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnInjury.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.btnInjury.UseSelectable = True
        '
        'btnLog
        '
        Me.btnLog.ActiveControl = Nothing
        Me.btnLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLog.Location = New System.Drawing.Point(3, 234)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(258, 225)
        Me.btnLog.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "Log"
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLog.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnLog.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.btnLog.UseSelectable = True
        '
        'btnProfile
        '
        Me.btnProfile.ActiveControl = Nothing
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProfile.Location = New System.Drawing.Point(3, 3)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(258, 225)
        Me.btnProfile.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnProfile.TabIndex = 3
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.btnProfile.UseSelectable = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnGoals, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnProfile, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInjury, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLog, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(529, 462)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Tab_Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_Welcome"
        Me.ShowInTaskbar = False
        Me.Text = "Welcome"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGoals As MetroFramework.Controls.MetroTile
    Friend WithEvents btnInjury As MetroFramework.Controls.MetroTile
    Friend WithEvents btnLog As MetroFramework.Controls.MetroTile
    Friend WithEvents btnProfile As MetroFramework.Controls.MetroTile
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
