<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Log
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
        Me.pnl_list = New System.Windows.Forms.Panel()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.btnAdd = New MetroFramework.Controls.MetroTile()
        Me.btnRemoveAll = New MetroFramework.Controls.MetroTile()
        Me.btnReload = New MetroFramework.Controls.MetroTile()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnShoes = New MetroFramework.Controls.MetroTile()
        Me.pnl_bottom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_list
        '
        Me.pnl_list.AutoScroll = True
        Me.pnl_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_list.Location = New System.Drawing.Point(0, 0)
        Me.pnl_list.Name = "pnl_list"
        Me.pnl_list.Size = New System.Drawing.Size(592, 451)
        Me.pnl_list.TabIndex = 1
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Controls.Add(Me.TableLayoutPanel1)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 451)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(592, 60)
        Me.pnl_bottom.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.ActiveControl = Nothing
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Location = New System.Drawing.Point(357, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 54)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Workout"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.UseSelectable = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.ActiveControl = Nothing
        Me.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveAll.Location = New System.Drawing.Point(180, 3)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(171, 54)
        Me.btnRemoveAll.Style = MetroFramework.MetroColorStyle.Red
        Me.btnRemoveAll.TabIndex = 1
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemoveAll.UseSelectable = True
        '
        'btnReload
        '
        Me.btnReload.ActiveControl = Nothing
        Me.btnReload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReload.Location = New System.Drawing.Point(3, 3)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(171, 54)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReload.UseSelectable = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReload, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRemoveAll, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnShoes, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 60)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnShoes
        '
        Me.btnShoes.ActiveControl = Nothing
        Me.btnShoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShoes.Location = New System.Drawing.Point(534, 3)
        Me.btnShoes.Name = "btnShoes"
        Me.btnShoes.Size = New System.Drawing.Size(55, 54)
        Me.btnShoes.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnShoes.TabIndex = 3
        Me.btnShoes.Text = "Shoes"
        Me.btnShoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnShoes.UseSelectable = True
        '
        'Tab_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 511)
        Me.Controls.Add(Me.pnl_list)
        Me.Controls.Add(Me.pnl_bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_Log"
        Me.ShowInTaskbar = False
        Me.Text = "Log"
        Me.pnl_bottom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_list As System.Windows.Forms.Panel
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReload As MetroFramework.Controls.MetroTile
    Friend WithEvents btnRemoveAll As MetroFramework.Controls.MetroTile
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents btnShoes As MetroFramework.Controls.MetroTile
End Class
