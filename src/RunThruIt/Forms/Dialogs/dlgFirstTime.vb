Public Class dlgFirstTime

    Private okaytoclose As Boolean = False
    Private profpic As String = ""

#Region "UI"

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        PictureBox1.BackgroundImage = My.Resources.profile_128
        profpic = ""
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyAllFields() Then
            SetProfile(txtName.Text, txtAge.Text, txtWeight.Text, comboSex.SelectedItem, txtActivityLevel.Text, txtPassword.Text, profpic)
            okaytoclose = True
            Me.Close()
            Tabs.AddWelcome()
            My.Settings.set_firsttime = False
            My.Settings.Save()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Unfortunately, one or more fields was either left blank, or improperly filled out. Please check again.", "Error", vbOKOnly, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim newb As New OpenFileDialog
        newb.Title = "Browse for profile picture"
        newb.Filter = "All Files (*.*)|*.*|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp"
        If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
            profpic = newb.FileName
            PictureBox1.BackgroundImage = Image.FromFile(profpic)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        btnBrowse.PerformClick()
    End Sub

#End Region

#Region "Methods"

#Region "Verification"

    Private Function VerifyAllFields() As Boolean
        Return VerifyName() And VerifyAge() And VerifyWeight() And VerifySex() And VerifyActivityLevel() And VerifyPassword()
    End Function

#Region "Individual Fields"

    Private Function VerifyName() As Boolean
        Return txtName.Text <> ""
    End Function

    Private Function VerifyAge() As Boolean
        Dim ret As Boolean = True
        If txtAge.Text <> "" Then
            If Not IsNumeric(txtAge.Text) Then
                ret = False
            End If
        End If
        Return ret
    End Function

    Private Function VerifyWeight() As Boolean
        Dim ret As Boolean = True
        If txtWeight.Text <> "" Then
            If Not IsNumeric(txtWeight.Text) Then
                ret = False
            End If
        End If
        Return ret
    End Function

    Private Function VerifySex() As Boolean
        Dim ret As Boolean = True
        If comboSex.SelectedIndex = -1 Then
            ret = False
        End If
        Return ret
    End Function

    Private Function VerifyActivityLevel()
        Dim ret As Boolean = True
        If txtActivityLevel.Text <> "" Then
            If Not IsNumeric(txtActivityLevel.Text) Then
                ret = False
            End If
        End If
        Return ret
    End Function

    Private Function VerifyPassword()
        Dim ret As Boolean = True
        If txtPassword.Text <> "" Or txtPasswordConfirm.Text <> "" Then
            If txtPassword.Text <> txtPasswordConfirm.Text Then
                ret = False
            End If
        End If
        Return ret
    End Function

#End Region

#End Region

    Private Sub SetProfile(ByVal name As String, ByVal age As Integer, ByVal weight As Integer, ByVal sex As String, ByVal activitylevel As Integer, ByVal password As String, ByVal profilepicture As String)
        My.Settings.profile_name = name
        My.Settings.profile_age = age
        My.Settings.profile_weight = weight
        My.Settings.profile_sex = sex
        My.Settings.profile_activitylevel = activitylevel
        My.Settings.profile_password = password
        My.Settings.profile_picture = profilepicture
    End Sub

#End Region

#Region "dlgFirstTime"

    Private Sub dlgFirstTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not okaytoclose Then
            MetroFramework.MetroMessageBox.Show(Me, "You must fill out the first time setup in order to proceed. Application will now exit.", "Fill Out Form", vbOKOnly, MessageBoxIcon.Exclamation)
            okaytoclose = True
            Application.Exit()
        End If
    End Sub

#End Region

End Class