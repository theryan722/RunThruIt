<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Profile
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
        Me.pb_profilepicture = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_sex = New System.Windows.Forms.Label()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.lbl_activitylevel = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.btnChangePassword = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        CType(Me.pb_profilepicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_profilepicture
        '
        Me.pb_profilepicture.BackgroundImage = Global.RunThruIt.My.Resources.Resources.profile_128
        Me.pb_profilepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_profilepicture.Location = New System.Drawing.Point(4, 0)
        Me.pb_profilepicture.Name = "pb_profilepicture"
        Me.pb_profilepicture.Size = New System.Drawing.Size(128, 128)
        Me.pb_profilepicture.TabIndex = 0
        Me.pb_profilepicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pb_profilepicture, "Click to change")
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(138, 2)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(66, 24)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name:"
        Me.ToolTip1.SetToolTip(Me.lbl_name, "Click to change")
        '
        'lbl_sex
        '
        Me.lbl_sex.AutoSize = True
        Me.lbl_sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sex.Location = New System.Drawing.Point(138, 38)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(48, 24)
        Me.lbl_sex.TabIndex = 2
        Me.lbl_sex.Text = "Sex:"
        Me.ToolTip1.SetToolTip(Me.lbl_sex, "Click to change")
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.Location = New System.Drawing.Point(138, 75)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(50, 24)
        Me.lbl_age.TabIndex = 3
        Me.lbl_age.Text = "Age:"
        Me.ToolTip1.SetToolTip(Me.lbl_age, "Click to change")
        '
        'lbl_activitylevel
        '
        Me.lbl_activitylevel.AutoSize = True
        Me.lbl_activitylevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_activitylevel.Location = New System.Drawing.Point(138, 152)
        Me.lbl_activitylevel.Name = "lbl_activitylevel"
        Me.lbl_activitylevel.Size = New System.Drawing.Size(122, 24)
        Me.lbl_activitylevel.TabIndex = 4
        Me.lbl_activitylevel.Text = "Activity Level:"
        Me.ToolTip1.SetToolTip(Me.lbl_activitylevel, "Click to change")
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(138, 114)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(74, 24)
        Me.lbl_weight.TabIndex = 5
        Me.lbl_weight.Text = "Weight:"
        Me.ToolTip1.SetToolTip(Me.lbl_weight, "Click to change")
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(4, 134)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(100, 23)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(4, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseSelectable = True
        '
        'Tab_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 217)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_activitylevel)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.lbl_sex)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.pb_profilepicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_Profile"
        Me.ShowInTaskbar = False
        Me.Text = "Profile"
        CType(Me.pb_profilepicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_profilepicture As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_sex As System.Windows.Forms.Label
    Friend WithEvents lbl_age As System.Windows.Forms.Label
    Friend WithEvents lbl_activitylevel As System.Windows.Forms.Label
    Friend WithEvents lbl_weight As System.Windows.Forms.Label
    Friend WithEvents btnChangePassword As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
End Class
