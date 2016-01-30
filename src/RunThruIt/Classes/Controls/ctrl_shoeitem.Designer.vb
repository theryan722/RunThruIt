<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_shoeitem
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
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnView = New MetroFramework.Controls.MetroButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnl_divider = New System.Windows.Forms.Panel()
        Me.pnl_bottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_bottom
        '
        Me.pnl_bottom.BackColor = System.Drawing.Color.Transparent
        Me.pnl_bottom.Controls.Add(Me.btnRemove)
        Me.pnl_bottom.Controls.Add(Me.btnView)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 45)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(150, 23)
        Me.pnl_bottom.TabIndex = 6
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRemove.Location = New System.Drawing.Point(49, 0)
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
        Me.btnView.Location = New System.Drawing.Point(104, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(46, 23)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseSelectable = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(4, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(102, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date Purchased:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(3, 28)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(55, 13)
        Me.lblMileage.TabIndex = 8
        Me.lblMileage.Text = "Mileage:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(3, 1)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        '
        'pnl_divider
        '
        Me.pnl_divider.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_divider.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_divider.Location = New System.Drawing.Point(0, 68)
        Me.pnl_divider.Name = "pnl_divider"
        Me.pnl_divider.Size = New System.Drawing.Size(150, 5)
        Me.pnl_divider.TabIndex = 10
        '
        'ctrl_shoeitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_bottom)
        Me.Controls.Add(Me.pnl_divider)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ctrl_shoeitem"
        Me.Size = New System.Drawing.Size(150, 73)
        Me.pnl_bottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents btnView As MetroFramework.Controls.MetroButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblMileage As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents pnl_divider As System.Windows.Forms.Panel

End Class
