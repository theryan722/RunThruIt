﻿Public Class Tab_Profile

#Region "UI"



#End Region

#Region "Methods"

    Private Sub LoadProfile()
        lbl_name.Text = "Name: " & My.Settings.profile_name
        lbl_age.Text = "Age: " & My.Settings.profile_age
        lbl_sex.Text = "Sex: " & My.Settings.profile_sex
        lbl_activitylevel.Text = "Activity Level: " & My.Settings.profile_activitylevel
        lbl_weight.Text = "Weight: " & My.Settings.profile_weight
        pb_profilepicture.BackgroundImage = Image.FromFile(My.Settings.profile_picture)
    End Sub

#End Region

#Region "Tab_Profile"



#End Region

End Class