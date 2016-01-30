Public Class Tab_Profile

#Region "UI"



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