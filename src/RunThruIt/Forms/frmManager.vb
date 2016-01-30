Public Class frmManager

#Region "MenuStrip"

#Region "File"



#End Region

#Region "Tabs"

    Private Sub CloseAllTabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllTabsToolStripMenuItem.Click
        If AtLeastOneTab() Then
            For i As Integer = TabControl1.TabCount - 1 To 0 Step -1
                RemoveTab(i)
            Next
        End If
    End Sub

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

    Public Sub RemoveTab(ByVal index As Integer)
        Try
            Dim d As Integer = TabControl1.SelectedIndex
            TabControl1.SelectTab(index)
            If d = TabControl1.TabCount - 1 Then
                CloseCurrentTabToolStripMenuItem.PerformClick()
            Else
                RemoveTab()
                TabControl1.SelectTab(d)
            End If
        Catch
        End Try
    End Sub

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
