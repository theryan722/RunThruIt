﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblPace = New System.Windows.Forms.Label()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnView = New MetroFramework.Controls.MetroButton()
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
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(6, 19)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(52, 13)
        Me.lblDistance.TabIndex = 1
        Me.lblDistance.Text = "Distance:"
        '
        'lblPace
        '
        Me.lblPace.AutoSize = True
        Me.lblPace.Location = New System.Drawing.Point(6, 32)
        Me.lblPace.Name = "lblPace"
        Me.lblPace.Size = New System.Drawing.Size(35, 13)
        Me.lblPace.TabIndex = 2
        Me.lblPace.Text = "Pace:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(3, 46)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(55, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseSelectable = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(64, 47)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(46, 23)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseSelectable = True
        '
        'ctrl_logitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblPace)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblType)
        Me.Name = "ctrl_logitem"
        Me.Size = New System.Drawing.Size(200, 70)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblPace As System.Windows.Forms.Label
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents btnView As MetroFramework.Controls.MetroButton

End Class
