<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNewLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNewLog))
        Me.dt_date = New MetroFramework.Controls.MetroDateTime()
        Me.combo_type = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNotes = New MetroFramework.Controls.MetroTextBox()
        Me.txtDistance = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPace = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInjury = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_time = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuration = New MetroFramework.Controls.MetroTextBox()
        Me.combo_shoes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_date
        '
        Me.dt_date.Location = New System.Drawing.Point(113, 99)
        Me.dt_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(210, 29)
        Me.dt_date.TabIndex = 1
        Me.dt_date.Value = New Date(2016, 1, 30, 0, 0, 0, 0)
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.ItemHeight = 23
        Me.combo_type.Items.AddRange(New Object() {"Run", "Bike", "Walk", "Swim", "Hike", "Strength Training", "Yoga"})
        Me.combo_type.Location = New System.Drawing.Point(113, 64)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(121, 29)
        Me.combo_type.TabIndex = 0
        Me.combo_type.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*Type:"
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(294, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Okay!"
        Me.btnOk.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 23)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Lines = New String(-1) {}
        Me.txtNotes.Location = New System.Drawing.Point(62, 231)
        Me.txtNotes.MaxLength = 32767
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.Size = New System.Drawing.Size(229, 43)
        Me.txtNotes.TabIndex = 6
        Me.txtNotes.UseSelectable = True
        '
        'txtDistance
        '
        Me.txtDistance.Lines = New String(-1) {}
        Me.txtDistance.Location = New System.Drawing.Point(62, 173)
        Me.txtDistance.MaxLength = 32767
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDistance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDistance.SelectedText = ""
        Me.txtDistance.Size = New System.Drawing.Size(75, 23)
        Me.txtDistance.TabIndex = 4
        Me.txtDistance.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Distance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pace:"
        '
        'txtPace
        '
        Me.txtPace.Lines = New String(-1) {}
        Me.txtPace.Location = New System.Drawing.Point(62, 202)
        Me.txtPace.MaxLength = 32767
        Me.txtPace.Name = "txtPace"
        Me.txtPace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPace.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPace.SelectedText = ""
        Me.txtPace.Size = New System.Drawing.Size(75, 23)
        Me.txtPace.TabIndex = 5
        Me.txtPace.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Shoes:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 59)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(0, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Items marked with an asterisk (*) are required."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Injury:"
        '
        'txtInjury
        '
        Me.txtInjury.Lines = New String(-1) {}
        Me.txtInjury.Location = New System.Drawing.Point(62, 280)
        Me.txtInjury.MaxLength = 32767
        Me.txtInjury.Name = "txtInjury"
        Me.txtInjury.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInjury.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInjury.SelectedText = ""
        Me.txtInjury.Size = New System.Drawing.Size(229, 23)
        Me.txtInjury.TabIndex = 7
        Me.txtInjury.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "miles"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "*Time:"
        '
        'txt_time
        '
        Me.txt_time.Location = New System.Drawing.Point(113, 134)
        Me.txt_time.Mask = "00:00"
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(49, 20)
        Me.txt_time.TabIndex = 2
        Me.txt_time.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(171, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "*Duration:"
        '
        'txtDuration
        '
        Me.txtDuration.Lines = New String(-1) {}
        Me.txtDuration.Location = New System.Drawing.Point(231, 134)
        Me.txtDuration.MaxLength = 32767
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDuration.SelectedText = ""
        Me.txtDuration.Size = New System.Drawing.Size(45, 23)
        Me.txtDuration.TabIndex = 3
        Me.txtDuration.UseSelectable = True
        '
        'combo_shoes
        '
        Me.combo_shoes.FormattingEnabled = True
        Me.combo_shoes.Location = New System.Drawing.Point(62, 311)
        Me.combo_shoes.Name = "combo_shoes"
        Me.combo_shoes.Size = New System.Drawing.Size(229, 21)
        Me.combo_shoes.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(278, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "minutes"
        '
        'dlgNewLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 373)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.combo_shoes)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_time)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInjury)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPace)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combo_type)
        Me.Controls.Add(Me.dt_date)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewLog"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.Text = "Add Workout"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents combo_type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDistance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPace As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInjury As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDuration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents combo_shoes As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
