﻿Public Class frmManager

#Region "MenuStrip"

#Region "File"



#End Region

#Region "Tabs"

    Private Sub CloseCurrentTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCurrentTabToolStripMenuItem.Click
        If AtLeastOneTab() Then
            RemoveTab()
        End If
    End Sub

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

    Public Sub RemoveTab()
        If AtLeastOneTab() Then
            Try
                TabControl1.SelectedTab.Dispose()
            Catch
            End Try
        End If
    End Sub

#End Region

#Region "frmManager"



#End Region

    
End Class
