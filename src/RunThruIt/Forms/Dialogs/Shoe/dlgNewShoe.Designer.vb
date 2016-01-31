<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNewShoe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNewShoe))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_date = New MetroFramework.Controls.MetroDateTime()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNotes = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtMileage = New MetroFramework.Controls.MetroTextBox()
        Me.txtMaxMileage = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "*Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Mileage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*Max Recommended Mileage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "*Date Purchased:"
        '
        'dt_date
        '
        Me.dt_date.Location = New System.Drawing.Point(102, 114)
        Me.dt_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(210, 29)
        Me.dt_date.TabIndex = 1
        Me.dt_date.Value = New Date(2016, 1, 30, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Lines = New String(-1) {}
        Me.txtNotes.Location = New System.Drawing.Point(52, 205)
        Me.txtNotes.MaxLength = 32767
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.Size = New System.Drawing.Size(246, 68)
        Me.txtNotes.TabIndex = 4
        Me.txtNotes.UseSelectable = True
        '
        'txtName
        '
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(130, 70)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(182, 23)
        Me.txtName.TabIndex = 0
        Me.txtName.UseSelectable = True
        '
        'txtMileage
        '
        Me.txtMileage.Lines = New String(-1) {}
        Me.txtMileage.Location = New System.Drawing.Point(65, 149)
        Me.txtMileage.MaxLength = 32767
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMileage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMileage.SelectedText = ""
        Me.txtMileage.Size = New System.Drawing.Size(75, 23)
        Me.txtMileage.TabIndex = 2
        Me.txtMileage.UseSelectable = True
        '
        'txtMaxMileage
        '
        Me.txtMaxMileage.Lines = New String(-1) {}
        Me.txtMaxMileage.Location = New System.Drawing.Point(163, 176)
        Me.txtMaxMileage.MaxLength = 32767
        Me.txtMaxMileage.Name = "txtMaxMileage"
        Me.txtMaxMileage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaxMileage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMaxMileage.SelectedText = ""
        Me.txtMaxMileage.Size = New System.Drawing.Size(75, 23)
        Me.txtMaxMileage.TabIndex = 3
        Me.txtMaxMileage.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 23)
        Me.Panel1.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(275, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Okay!"
        Me.btnOk.UseSelectable = True
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Items marked with an asterisk (*) are required."
        '
        'dlgNewShoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 317)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtMaxMileage)
        Me.Controls.Add(Me.txtMileage)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dt_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewShoe"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.Text = "Add Shoe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMileage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMaxMileage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
