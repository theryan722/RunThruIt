Public Class Tab_OtherTrackers

#Region "Water"

#Region "UI"

    Private Sub btn_water_addintakefortoday_Click(sender As Object, e As EventArgs) Handles btn_water_addintakefortoday.Click
        Dim wat As String = InputBox("Please enter the amount of water you have consumed today, in fl.oz.", "Enter Water Intake", "0")
        My.Settings.log_water.Add(DateTime.Today.ToString("M/dd/yyyy") & "|" & wat & " oz")
        LoadWater()
    End Sub

    Private Sub btn_water_removeselected_Click(sender As Object, e As EventArgs) Handles btn_water_removeselected.Click
        If lb_water.SelectedIndex <> -1 Then
            My.Settings.log_water.Remove(lb_water.SelectedItem)
            LoadWater()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub CheckWaterIntake(ByVal wat As Integer)
        If wat < 40 Then
            MetroFramework.MetroMessageBox.Show(frmManager, "Notice: Your water consumption for today was low. Please consider increasing your water intake.", "Water Intake Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LoadWater()
        lb_water.Items.Clear()
        For Each item As String In My.Settings.log_water
            lb_water.Items.Add(item)
        Next
    End Sub

#End Region

#End Region

#Region "Weight"

#Region "UI"

    Private Sub btn_weight_record_Click(sender As Object, e As EventArgs) Handles btn_weight_record.Click

    End Sub

    Private Sub btn_weight_remove_Click(sender As Object, e As EventArgs) Handles btn_weight_remove.Click

    End Sub

#End Region

#Region "Methods"



#End Region

#End Region

#Region "Tab_OtherTrackers"

    Private Sub Tab_OtherTrackers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWater()
    End Sub

#End Region

    
End Class