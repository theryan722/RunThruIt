<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_shoes
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReload = New MetroFramework.Controls.MetroTile()
        Me.btnRemoveAll = New MetroFramework.Controls.MetroTile()
        Me.btnAdd = New MetroFramework.Controls.MetroTile()
        Me.pnl_list = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 357)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(527, 60)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnReload
        '
        Me.btnReload.ActiveControl = Nothing
        Me.btnReload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReload.Location = New System.Drawing.Point(3, 3)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(169, 54)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReload.UseSelectable = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.ActiveControl = Nothing
        Me.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveAll.Location = New System.Drawing.Point(178, 3)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(169, 54)
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
        Me.btnAdd.Location = New System.Drawing.Point(353, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 54)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Shoe"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.UseSelectable = True
        '
        'pnl_list
        '
        Me.pnl_list.AutoScroll = True
        Me.pnl_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_list.Location = New System.Drawing.Point(0, 0)
        Me.pnl_list.Name = "pnl_list"
        Me.pnl_list.Size = New System.Drawing.Size(527, 357)
        Me.pnl_list.TabIndex = 2
        '
        'Tab_shoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 417)
        Me.Controls.Add(Me.pnl_list)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_shoes"
        Me.ShowInTaskbar = False
        Me.Text = "Shoes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReload As MetroFramework.Controls.MetroTile
    Friend WithEvents btnRemoveAll As MetroFramework.Controls.MetroTile
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents pnl_list As System.Windows.Forms.Panel
End Class
