<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandom
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRandom))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnNewTip = New MetroFramework.Controls.MetroButton()
        Me.btnNewQuote = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.check_displayatstartup = New MetroFramework.Controls.MetroCheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 60)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(370, 150)
        Me.TextBox1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Location = New System.Drawing.Point(295, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'btnNewTip
        '
        Me.btnNewTip.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNewTip.Location = New System.Drawing.Point(0, 0)
        Me.btnNewTip.Name = "btnNewTip"
        Me.btnNewTip.Size = New System.Drawing.Size(75, 23)
        Me.btnNewTip.TabIndex = 2
        Me.btnNewTip.Text = "New Tip"
        Me.ToolTip1.SetToolTip(Me.btnNewTip, "Display a new running tip")
        Me.btnNewTip.UseSelectable = True
        '
        'btnNewQuote
        '
        Me.btnNewQuote.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNewQuote.Location = New System.Drawing.Point(75, 0)
        Me.btnNewQuote.Name = "btnNewQuote"
        Me.btnNewQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnNewQuote.TabIndex = 3
        Me.btnNewQuote.Text = "New Quote"
        Me.ToolTip1.SetToolTip(Me.btnNewQuote, "Display a new running quote")
        Me.btnNewQuote.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnNewQuote)
        Me.Panel1.Controls.Add(Me.btnNewTip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 23)
        Me.Panel1.TabIndex = 4
        '
        'check_displayatstartup
        '
        Me.check_displayatstartup.AutoSize = True
        Me.check_displayatstartup.Location = New System.Drawing.Point(245, 39)
        Me.check_displayatstartup.Name = "check_displayatstartup"
        Me.check_displayatstartup.Size = New System.Drawing.Size(115, 15)
        Me.check_displayatstartup.TabIndex = 5
        Me.check_displayatstartup.Text = "Display at Startup"
        Me.check_displayatstartup.UseSelectable = True
        '
        'dlgRandom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 233)
        Me.Controls.Add(Me.check_displayatstartup)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandom"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Tips && Quotes"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNewTip As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNewQuote As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents check_displayatstartup As MetroFramework.Controls.MetroCheckBox
End Class
