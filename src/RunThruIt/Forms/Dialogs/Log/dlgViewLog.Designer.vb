<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewLog))
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblPace = New System.Windows.Forms.Label()
        Me.lblInjury = New System.Windows.Forms.Label()
        Me.lblShoes = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotes = New MetroFramework.Controls.MetroTextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.Location = New System.Drawing.Point(0, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(327, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(3, 60)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(44, 17)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 17)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(3, 113)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(67, 17)
        Me.lblDistance.TabIndex = 3
        Me.lblDistance.Text = "Distance:"
        '
        'lblPace
        '
        Me.lblPace.AutoSize = True
        Me.lblPace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPace.Location = New System.Drawing.Point(3, 183)
        Me.lblPace.Name = "lblPace"
        Me.lblPace.Size = New System.Drawing.Size(44, 17)
        Me.lblPace.TabIndex = 4
        Me.lblPace.Text = "Pace:"
        '
        'lblInjury
        '
        Me.lblInjury.AutoSize = True
        Me.lblInjury.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInjury.Location = New System.Drawing.Point(3, 207)
        Me.lblInjury.Name = "lblInjury"
        Me.lblInjury.Size = New System.Drawing.Size(46, 17)
        Me.lblInjury.TabIndex = 5
        Me.lblInjury.Text = "Injury:"
        '
        'lblShoes
        '
        Me.lblShoes.AutoSize = True
        Me.lblShoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoes.Location = New System.Drawing.Point(3, 233)
        Me.lblShoes.Name = "lblShoes"
        Me.lblShoes.Size = New System.Drawing.Size(52, 17)
        Me.lblShoes.TabIndex = 6
        Me.lblShoes.Text = "Shoes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Lines = New String(-1) {}
        Me.txtNotes.Location = New System.Drawing.Point(47, 261)
        Me.txtNotes.MaxLength = 32767
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.Size = New System.Drawing.Size(275, 60)
        Me.txtNotes.TabIndex = 8
        Me.txtNotes.UseSelectable = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(3, 136)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 17)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(4, 159)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(66, 17)
        Me.lblDuration.TabIndex = 10
        Me.lblDuration.Text = "Duration:"
        '
        'dlgViewLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 346)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblShoes)
        Me.Controls.Add(Me.lblInjury)
        Me.Controls.Add(Me.lblPace)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewLog"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.Text = "View Workout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblPace As System.Windows.Forms.Label
    Friend WithEvents lblInjury As System.Windows.Forms.Label
    Friend WithEvents lblShoes As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
End Class
