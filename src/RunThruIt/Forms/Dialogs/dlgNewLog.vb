Public Class dlgNewLog

    Public Property NewWorkout As Workout

#Region "UI"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyFields() Then
            CreateWorkout(combo_type.SelectedItem, dt_date.Value, txtNotes.Text, txtDistance.Text, txtShoes.Text, txtPace.Text, txtInjury.Text)
            If My.Settings.set_defaultshoe <> txtShoes.Text Then
                My.Settings.set_defaultshoe = txtShoes.Text
            End If
            My.Settings.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MetroFramework.MetroMessageBox.Show(frmManager, "Please make sure you properly fill out the form and all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If combo_type.SelectedIndex = -1 Then
            ret = False
        End If
        If Not IsDate(dt_date.Value) Then
            ret = False
        End If
        Return ret
    End Function

    Private Sub CreateWorkout(ByVal type As String, ByVal wdate As Date, ByVal notes As String, ByVal distance As String, ByVal shoes As String, ByVal pace As String, ByVal injury As String)
        NewWorkout = New Workout(type, wdate, notes, distance, shoes, pace, injury)
    End Sub

#End Region

#Region "dlgNewLog"

    Private Sub dlgNewLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtShoes.Text = My.Settings.set_defaultshoe
    End Sub

#End Region

End Class