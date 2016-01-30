Public Class Tab_Profile

#Region "UI"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Save()
        MetroFramework.MetroMessageBox.Show(frmManager, "Changes to profile saved!", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "Change Settings"

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If My.Settings.profile_password = "" Then
            Dim pass As String = InputBox("Please enter a new password: ", "Password", "")
            My.Settings.profile_password = pass
            LoadProfile()
        Else
            Dim check As String = InputBox("Please enter your current password to modify this setting.", "Authenticate", "")
            If check <> My.Settings.profile_password Then
                MetroFramework.MetroMessageBox.Show(frmManager, "The password you entered did not match.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim pass As String = InputBox("Please enter a new password: ", "Password", "")
                My.Settings.profile_password = pass
                LoadProfile()
            End If
        End If
    End Sub

    Private Sub pb_profilepicture_Click(sender As Object, e As EventArgs) Handles pb_profilepicture.Click
        Dim newb As New OpenFileDialog
        newb.Title = "Browse for profile picture"
        newb.Filter = "All Files (*.*)|*.*|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp"
        If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.profile_picture = newb.FileName
            LoadProfile()
        End If
    End Sub

    Private Sub lbl_name_Click(sender As Object, e As EventArgs) Handles lbl_name.Click
        Dim pname As String = InputBox("Please enter a name", "Modify Name", My.Settings.profile_name)
        If pname <> "" Then
            My.Settings.profile_name = pname
            LoadProfile()
        Else
            MetroFramework.MetroMessageBox.Show(frmManager, "Please enter a name.'.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lbl_sex_Click(sender As Object, e As EventArgs) Handles lbl_sex.Click
        Dim psex As String = InputBox("Please enter a sex", "Modify Sex", My.Settings.profile_sex)
        If psex.ToLower = "male" Then
            My.Settings.profile_sex = "Male"
            LoadProfile()
        ElseIf psex.ToLower = "female" Then
            My.Settings.profile_sex = "Female"
            LoadProfile()
        Else
            MetroFramework.MetroMessageBox.Show(frmManager, "Please enter either 'Female' or 'Male'.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lbl_age_Click(sender As Object, e As EventArgs) Handles lbl_age.Click

    End Sub

    Private Sub lbl_weight_Click(sender As Object, e As EventArgs) Handles lbl_weight.Click

    End Sub

    Private Sub lbl_activitylevel_Click(sender As Object, e As EventArgs) Handles lbl_activitylevel.Click

    End Sub

#End Region

#End Region

#Region "Methods"

    Private Sub LoadProfile()
        lbl_name.Text = "Name: " & My.Settings.profile_name
        lbl_age.Text = If(My.Settings.profile_age = "", "Age: Unknown", "Age: " & My.Settings.profile_age)
        lbl_sex.Text = "Sex: " & My.Settings.profile_sex
        lbl_activitylevel.Text = If(My.Settings.profile_activitylevel = "", "Activity Level: Unknown", "Activity Level: " & My.Settings.profile_activitylevel)
        lbl_weight.Text = If(My.Settings.profile_weight = "", "Weight: Unknown", "Weight: " & My.Settings.profile_weight)
        pb_profilepicture.BackgroundImage = If(My.Settings.profile_picture = "", My.Resources.profile_128, Image.FromFile(My.Settings.profile_picture))
    End Sub

#End Region

#Region "Tab_Profile"

    Private Sub Tab_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

#End Region
   
End Class