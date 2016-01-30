Public Class dlgFirstTime

#Region "UI"



#End Region

#Region "Methods"

#Region "Verification"

    Private Function VerifyAllFields() As Boolean
        Return VerifyName() And VerifyAge() And VerifyWeight() And VerifySex() And VerifyActivityLevel() And VerifyPassword()
    End Function

    Private Function VerifyName() As Boolean
        Dim ret As Boolean = True
        If txtName.Text = "" Then
            ret = False
        End If
        Return ret
    End Function

    Private Function VerifyAge() As Boolean
        Dim ret As Boolean = True
        If IsNumeric(txtAge.Text) Then
            ret = False
        End If
        Return ret
    End Function

    Private Function VerifyWeight() As Boolean
        Dim ret As Boolean = True

        Return ret
    End Function

    Private Function VerifySex() As Boolean
        Dim ret As Boolean = True

        Return ret
    End Function

    Private Function VerifyActivityLevel()
        Dim ret As Boolean = True

        Return ret
    End Function

    Private Function VerifyPassword()
        Dim ret As Boolean = True

        Return ret
    End Function

#End Region

    

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