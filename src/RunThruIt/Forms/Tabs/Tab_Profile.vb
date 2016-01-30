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
        Dim page As String = InputBox("Please enter an age", "Modify Age", My.Settings.profile_age)
        If Not IsNumeric(page) Or page = "" Then
            MetroFramework.MetroMessageBox.Show(frmManager, "Please enter a valid age.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.profile_age = CInt(page)
            LoadProfile()
        End If
    End Sub

    Private Sub lbl_weight_Click(sender As Object, e As EventArgs) Handles lbl_weight.Click
        Dim pweight As String = InputBox("Please enter a weight", "Modify Weight", My.Settings.profile_weight)
        If Not IsNumeric(pweight) Or pweight = "" Then
            MetroFramework.MetroMessageBox.Show(frmManager, "Please enter a valid weight.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.profile_weight = CInt(pweight)
            LoadProfile()
        End If
    End Sub

    Private Sub lbl_activitylevel_Click(sender As Object, e As EventArgs) Handles lbl_activitylevel.Click
        Dim pactivitylevel As String = InputBox("Please enter an activity level between 1 and 5", "Modify Weight", My.Settings.profile_activitylevel)
        If Not IsNumeric(pactivitylevel) Or pactivitylevel = "" Or pactivitylevel > 5 Or pactivitylevel < 1 Then
            MetroFramework.MetroMessageBox.Show(frmManager, "Please enter a valid activity level.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.profile_activitylevel = CInt(pactivitylevel)
            LoadProfile()
        End If
    End Sub

#End Region

#End Region

#Region "Methods"

    Private Sub LoadProfile()
        lbl_name.Text = "Name: " & My.Settings.profile_name
        lbl_age.Text = If(My.Settings.profile_age = "", "Age: Unknown", "Age: " & My.Settings.profile_age.ToString)
        lbl_sex.Text = "Sex: " & My.Settings.profile_sex
        lbl_activitylevel.Text = If(My.Settings.profile_activitylevel = "", "Activity Level: Unknown", "Activity Level: " & My.Settings.profile_activitylevel.ToString)
        lbl_weight.Text = If(My.Settings.profile_weight = "", "Weight: Unknown", "Weight: " & My.Settings.profile_weight.ToString)
        pb_profilepicture.BackgroundImage = If(My.Settings.profile_picture = "", My.Resources.profile_128, Image.FromFile(My.Settings.profile_picture))
    End Sub

#End Region

#Region "Tab_Profile"

    Private Sub Tab_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

#End Region
   
End Class