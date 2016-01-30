﻿Public Class dlgNewLog

    Public Property NewWorkout As Workout

#Region "UI"

    Private Sub btnManageShoes_Click(sender As Object, e As EventArgs) Handles btnManageShoes.Click
        Tabs.AddShoes()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyFields() Then
            CreateWorkout(combo_type.SelectedItem, dt_date.Value, txtNotes.Text, txtDistance.Text, combo_shoes.Text, txtPace.Text, txtInjury.Text, Convert.ToDateTime(txt_time.Text), txtDuration.Text)
            My.Settings.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Dim newmiles As Integer = CInt(txtDistance.Text) + 
        Else
            MetroFramework.MetroMessageBox.Show(frmManager, "Please make sure you properly fill out the form and all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub LoadShoes()
        For Each item As Shoe In ShoeManager.GetShoes()
            combo_shoes.Items.Add(item.ShoeName)
        Next
    End Sub

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If combo_type.SelectedIndex = -1 Then
            ret = False
        End If
        If Not IsDate(dt_date.Value) Then
            ret = False
        End If
        If Not IsDate(Convert.ToDateTime(txt_time.Text)) Then
            ret = False
        End If
        If Not IsNumeric(txtDuration.Text) Then
            ret = False
        End If
        Return ret
    End Function

    Private Sub CreateWorkout(ByVal type As String, ByVal wdate As Date, ByVal notes As String, ByVal distance As String, ByVal shoes As String, ByVal pace As String, ByVal injury As String, ByVal time As DateTime, ByVal duration As String)
        NewWorkout = New Workout(type, wdate, notes, distance, shoes, pace, injury, time, duration)
    End Sub

#End Region

End Class