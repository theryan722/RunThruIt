Public Class dlgFirstTime

#Region "UI"

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyAllFields() Then

        End If
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

    Private Sub SetProfile(ByVal name As String, ByVal age As Integer, ByVal weight As Integer, ByVal sex As String, ByVal activitylevel As Integer, ByVal password As String)
        My.Settings.profile_name = name
        My.Settings.profile_age = age
        My.Settings.profile_weight = weight
        My.Settings.profile_sex = sex
        My.Settings.profile_activitylevel = activitylevel
        My.Settings.profile_password = password
    End Sub

#End Region

#Region "dlgFirstTime"

    Private Sub dlgFirstTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Parent = Nothing
    End Sub

    Private Sub dlgFirstTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Parent = frmManager
    End Sub

#End Region

    
End Class