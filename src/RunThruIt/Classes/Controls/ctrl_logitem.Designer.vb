<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_logitem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnView = New MetroFramework.Controls.MetroButton()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.pnl_bottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 6)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(6, 33)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(50, 13)
        Me.lblDuration.TabIndex = 1
        Me.lblDuration.Text = "Duration:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(7, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRemove.Location = New System.Drawing.Point(99, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(55, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseSelectable = True
        '
        'btnView
        '
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnView.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnView.Location = New System.Drawing.Point(154, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(46, 23)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseSelectable = True
        '
        'pnl_bottom
        '
        Me.pnl_bottom.BackColor = System.Drawing.Color.Transparent
        Me.pnl_bottom.Controls.Add(Me.btnRemove)
        Me.pnl_bottom.Controls.Add(Me.btnView)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 47)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(200, 23)
        Me.pnl_bottom.TabIndex = 5
        '
        'ctrl_logitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_bottom)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblType)
        Me.Name = "ctrl_logitem"
        Me.Size = New System.Drawing.Size(200, 70)
        Me.pnl_bottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents btnView As MetroFramework.Controls.MetroButton
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel

End Class
