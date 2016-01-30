Public Class dlgFirstTime

#Region "UI"



#End Region

#Region "Methods"

#Region "Verification"

    Private Function VerifyAllFields() As Boolean
        Return VerifyName() And VerifyAge() And VerifyWeight() And VerifySex() And VerifyActivityLevel() And VerifyPassword()
    End Function

    Private Function VerifyName() As Boolean

    End Function

    Private Function VerifyAge() As Boolean

    End Function

    Private Function VerifyWeight() As Boolean

    End Function

    Private Function VerifySex() As Boolean

    End Function

    Private Function VerifyActivityLevel()

    End Function

    Private Function VerifyPassword()

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