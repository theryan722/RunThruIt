<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewShoe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewShoe))
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblMaxMileage = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New MetroFramework.Controls.MetroTextBox()
        Me.lblDatePurchased = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.Location = New System.Drawing.Point(0, 227)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(338, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(3, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 18)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(3, 85)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(63, 18)
        Me.lblMileage.TabIndex = 2
        Me.lblMileage.Text = "Mileage:"
        '
        'lblMaxMileage
        '
        Me.lblMaxMileage.AutoSize = True
        Me.lblMaxMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxMileage.Location = New System.Drawing.Point(3, 134)
        Me.lblMaxMileage.Name = "lblMaxMileage"
        Me.lblMaxMileage.Size = New System.Drawing.Size(201, 18)
        Me.lblMaxMileage.TabIndex = 3
        Me.lblMaxMileage.Text = "Max Recommended Mileage:"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(3, 160)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(52, 18)
        Me.lblNotes.TabIndex = 4
        Me.lblNotes.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Lines = New String(-1) {}
        Me.txtNotes.Location = New System.Drawing.Point(61, 160)
        Me.txtNotes.MaxLength = 32767
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.Size = New System.Drawing.Size(275, 60)
        Me.txtNotes.TabIndex = 5
        Me.txtNotes.UseSelectable = True
        '
        'lblDatePurchased
        '
        Me.lblDatePurchased.AutoSize = True
        Me.lblDatePurchased.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePurchased.Location = New System.Drawing.Point(3, 108)
        Me.lblDatePurchased.Name = "lblDatePurchased"
        Me.lblDatePurchased.Size = New System.Drawing.Size(118, 18)
        Me.lblDatePurchased.TabIndex = 6
        Me.lblDatePurchased.Text = "Date Purchased:"
        '
        'dlgViewShoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 250)
        Me.Controls.Add(Me.lblDatePurchased)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblMaxMileage)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dlgViewShoe"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.Text = "View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblMileage As System.Windows.Forms.Label
    Friend WithEvents lblMaxMileage As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDatePurchased As System.Windows.Forms.Label
End Class
