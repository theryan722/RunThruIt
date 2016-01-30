<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFirstTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFirstTime))
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtAge = New MetroFramework.Controls.MetroTextBox()
        Me.txtWeight = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.comboSex = New MetroFramework.Controls.MetroComboBox()
        Me.txtPasswordConfirm = New MetroFramework.Controls.MetroTextBox()
        Me.txtActivityLevel = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnOk.Location = New System.Drawing.Point(498, 321)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(109, 26)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Okay, lets go!"
        Me.btnOk.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*Sex:"
        '
        'txtName
        '
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(140, 127)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PromptText = "*Name"
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(166, 23)
        Me.txtName.TabIndex = 0
        Me.txtName.UseSelectable = True
        '
        'txtAge
        '
        Me.txtAge.Lines = New String(-1) {}
        Me.txtAge.Location = New System.Drawing.Point(140, 156)
        Me.txtAge.MaxLength = 32767
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PromptText = "Age"
        Me.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAge.SelectedText = ""
        Me.txtAge.Size = New System.Drawing.Size(166, 23)
        Me.txtAge.TabIndex = 1
        Me.txtAge.UseSelectable = True
        '
        'txtWeight
        '
        Me.txtWeight.Lines = New String(-1) {}
        Me.txtWeight.Location = New System.Drawing.Point(140, 185)
        Me.txtWeight.MaxLength = 32767
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PromptText = "Weight (e.x. 150) in lbs"
        Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.Size = New System.Drawing.Size(166, 23)
        Me.txtWeight.TabIndex = 2
        Me.txtWeight.UseSelectable = True
        '
        'txtPassword
        '
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(140, 279)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.PromptText = "Password"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(166, 23)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSelectable = True
        '
        'comboSex
        '
        Me.comboSex.FormattingEnabled = True
        Me.comboSex.ItemHeight = 23
        Me.comboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboSex.Location = New System.Drawing.Point(185, 214)
        Me.comboSex.Name = "comboSex"
        Me.comboSex.Size = New System.Drawing.Size(121, 29)
        Me.comboSex.TabIndex = 3
        Me.comboSex.UseSelectable = True
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Lines = New String(-1) {}
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(140, 308)
        Me.txtPasswordConfirm.MaxLength = 32767
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPasswordConfirm.PromptText = "Confirm Password"
        Me.txtPasswordConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordConfirm.SelectedText = ""
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(166, 23)
        Me.txtPasswordConfirm.TabIndex = 6
        Me.txtPasswordConfirm.UseSelectable = True
        '
        'txtActivityLevel
        '
        Me.txtActivityLevel.Lines = New String(-1) {}
        Me.txtActivityLevel.Location = New System.Drawing.Point(140, 249)
        Me.txtActivityLevel.MaxLength = 32767
        Me.txtActivityLevel.Name = "txtActivityLevel"
        Me.txtActivityLevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActivityLevel.PromptText = "Activity Level (1-5)"
        Me.txtActivityLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActivityLevel.SelectedText = ""
        Me.txtActivityLevel.Size = New System.Drawing.Size(166, 23)
        Me.txtActivityLevel.TabIndex = 4
        Me.txtActivityLevel.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 51)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.RunThruIt.My.Resources.Resources.profile_128
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Items marked with an asterisk (*) are required."
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(6, 203)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(51, 23)
        Me.btnBrowse.TabIndex = 17
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(63, 203)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(51, 23)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'dlgFirstTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 358)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtActivityLevel)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.comboSex)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "dlgFirstTime"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.Text = "Welcome!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAge As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtWeight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents comboSex As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtPasswordConfirm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtActivityLevel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
