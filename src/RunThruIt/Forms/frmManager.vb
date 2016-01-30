Public Class frmManager

#Region "MenuStrip"

#Region "File"



#End Region

#Region "Tabs"



#End Region

#Region "About"



#End Region

#End Region

#Region "Methods"

    Public Function AtLeastOneTab() As Boolean
        If TabControl1.TabCount < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "frmManager"



#End Region

End Class
