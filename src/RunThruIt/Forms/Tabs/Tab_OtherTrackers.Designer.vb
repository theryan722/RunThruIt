<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_OtherTrackers
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabWater = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_water = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_water_removeselected = New MetroFramework.Controls.MetroButton()
        Me.btn_water_addintakefortoday = New MetroFramework.Controls.MetroButton()
        Me.TabWeight = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lb_weight = New System.Windows.Forms.ListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_weight_remove = New MetroFramework.Controls.MetroButton()
        Me.btn_weight_record = New MetroFramework.Controls.MetroButton()
        Me.TabSleep = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_sleep_remove = New MetroFramework.Controls.MetroButton()
        Me.btn_sleep_record = New MetroFramework.Controls.MetroButton()
        Me.lb_sleep = New System.Windows.Forms.ListBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabWater.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabWeight.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabSleep.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabWater)
        Me.MetroTabControl1.Controls.Add(Me.TabWeight)
        Me.MetroTabControl1.Controls.Add(Me.TabSleep)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(633, 557)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabWater
        '
        Me.TabWater.Controls.Add(Me.Panel2)
        Me.TabWater.Controls.Add(Me.Panel1)
        Me.TabWater.Location = New System.Drawing.Point(4, 38)
        Me.TabWater.Name = "TabWater"
        Me.TabWater.Size = New System.Drawing.Size(625, 515)
        Me.TabWater.TabIndex = 0
        Me.TabWater.Text = "Water"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lb_water)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(625, 492)
        Me.Panel2.TabIndex = 1
        '
        'lb_water
        '
        Me.lb_water.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_water.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_water.FormattingEnabled = True
        Me.lb_water.ItemHeight = 18
        Me.lb_water.Location = New System.Drawing.Point(0, 0)
        Me.lb_water.Name = "lb_water"
        Me.lb_water.ScrollAlwaysVisible = True
        Me.lb_water.Size = New System.Drawing.Size(625, 492)
        Me.lb_water.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_water_removeselected)
        Me.Panel1.Controls.Add(Me.btn_water_addintakefortoday)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 23)
        Me.Panel1.TabIndex = 0
        '
        'btn_water_removeselected
        '
        Me.btn_water_removeselected.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_water_removeselected.Location = New System.Drawing.Point(453, 0)
        Me.btn_water_removeselected.Name = "btn_water_removeselected"
        Me.btn_water_removeselected.Size = New System.Drawing.Size(172, 23)
        Me.btn_water_removeselected.TabIndex = 1
        Me.btn_water_removeselected.Text = "Remove Selected"
        Me.btn_water_removeselected.UseSelectable = True
        '
        'btn_water_addintakefortoday
        '
        Me.btn_water_addintakefortoday.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_water_addintakefortoday.Location = New System.Drawing.Point(0, 0)
        Me.btn_water_addintakefortoday.Name = "btn_water_addintakefortoday"
        Me.btn_water_addintakefortoday.Size = New System.Drawing.Size(172, 23)
        Me.btn_water_addintakefortoday.TabIndex = 0
        Me.btn_water_addintakefortoday.Text = "Add Water Intake For Today"
        Me.btn_water_addintakefortoday.UseSelectable = True
        '
        'TabWeight
        '
        Me.TabWeight.Controls.Add(Me.Panel3)
        Me.TabWeight.Location = New System.Drawing.Point(4, 38)
        Me.TabWeight.Name = "TabWeight"
        Me.TabWeight.Size = New System.Drawing.Size(625, 515)
        Me.TabWeight.TabIndex = 1
        Me.TabWeight.Text = "Weight"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lb_weight)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(625, 515)
        Me.Panel3.TabIndex = 0
        '
        'lb_weight
        '
        Me.lb_weight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_weight.FormattingEnabled = True
        Me.lb_weight.ItemHeight = 18
        Me.lb_weight.Location = New System.Drawing.Point(0, 0)
        Me.lb_weight.Name = "lb_weight"
        Me.lb_weight.ScrollAlwaysVisible = True
        Me.lb_weight.Size = New System.Drawing.Size(625, 492)
        Me.lb_weight.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_weight_remove)
        Me.Panel5.Controls.Add(Me.btn_weight_record)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 492)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(625, 23)
        Me.Panel5.TabIndex = 1
        '
        'btn_weight_remove
        '
        Me.btn_weight_remove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_weight_remove.Location = New System.Drawing.Point(453, 0)
        Me.btn_weight_remove.Name = "btn_weight_remove"
        Me.btn_weight_remove.Size = New System.Drawing.Size(172, 23)
        Me.btn_weight_remove.TabIndex = 1
        Me.btn_weight_remove.Text = "Remove Selected"
        Me.btn_weight_remove.UseSelectable = True
        '
        'btn_weight_record
        '
        Me.btn_weight_record.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_weight_record.Location = New System.Drawing.Point(0, 0)
        Me.btn_weight_record.Name = "btn_weight_record"
        Me.btn_weight_record.Size = New System.Drawing.Size(172, 23)
        Me.btn_weight_record.TabIndex = 0
        Me.btn_weight_record.Text = "Record Weight"
        Me.btn_weight_record.UseSelectable = True
        '
        'TabSleep
        '
        Me.TabSleep.Controls.Add(Me.Panel4)
        Me.TabSleep.Location = New System.Drawing.Point(4, 38)
        Me.TabSleep.Name = "TabSleep"
        Me.TabSleep.Size = New System.Drawing.Size(625, 515)
        Me.TabSleep.TabIndex = 2
        Me.TabSleep.Text = "Sleep"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lb_sleep)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(625, 515)
        Me.Panel4.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_sleep_remove)
        Me.Panel6.Controls.Add(Me.btn_sleep_record)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 492)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(625, 23)
        Me.Panel6.TabIndex = 2
        '
        'btn_sleep_remove
        '
        Me.btn_sleep_remove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_sleep_remove.Location = New System.Drawing.Point(453, 0)
        Me.btn_sleep_remove.Name = "btn_sleep_remove"
        Me.btn_sleep_remove.Size = New System.Drawing.Size(172, 23)
        Me.btn_sleep_remove.TabIndex = 1
        Me.btn_sleep_remove.Text = "Remove Selected"
        Me.btn_sleep_remove.UseSelectable = True
        '
        'btn_sleep_record
        '
        Me.btn_sleep_record.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_sleep_record.Location = New System.Drawing.Point(0, 0)
        Me.btn_sleep_record.Name = "btn_sleep_record"
        Me.btn_sleep_record.Size = New System.Drawing.Size(172, 23)
        Me.btn_sleep_record.TabIndex = 0
        Me.btn_sleep_record.Text = "Record Sleep"
        Me.btn_sleep_record.UseSelectable = True
        '
        'lb_sleep
        '
        Me.lb_sleep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_sleep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sleep.FormattingEnabled = True
        Me.lb_sleep.ItemHeight = 18
        Me.lb_sleep.Location = New System.Drawing.Point(0, 0)
        Me.lb_sleep.Name = "lb_sleep"
        Me.lb_sleep.ScrollAlwaysVisible = True
        Me.lb_sleep.Size = New System.Drawing.Size(625, 492)
        Me.lb_sleep.TabIndex = 3
        '
        'Tab_OtherTrackers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 557)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tab_OtherTrackers"
        Me.ShowInTaskbar = False
        Me.Text = "Other Trackers"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabWater.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabWeight.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabSleep.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabWater As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_water_removeselected As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_water_addintakefortoday As MetroFramework.Controls.MetroButton
    Friend WithEvents TabWeight As System.Windows.Forms.TabPage
    Friend WithEvents lb_water As System.Windows.Forms.ListBox
    Friend WithEvents TabSleep As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btn_weight_remove As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_weight_record As MetroFramework.Controls.MetroButton
    Friend WithEvents lb_weight As System.Windows.Forms.ListBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btn_sleep_remove As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_sleep_record As MetroFramework.Controls.MetroButton
    Friend WithEvents lb_sleep As System.Windows.Forms.ListBox
End Class
