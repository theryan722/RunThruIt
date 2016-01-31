Public Class InjuryManager

    Public Shared Function CheckIfGreaterThanTenPercent()
        Dim ret As Boolean = False
        If (GetWeekTwoMileage() - GetWeekOneMileage()) > (0.1 * GetWeekOneMileage()) Then
            ret = True
        End If
        Return ret
    End Function

#Region "Week One"

    Public Shared Sub SetWeekOneMileage(ByVal miles As Integer)
        My.Settings.set_inj_totmile_wk1 = miles
    End Sub

    Public Shared Function GetWeekOneMileage() As Integer
        Return My.Settings.set_inj_totmile_wk1
    End Function

    Public Shared Sub SetWeekOneDate(ByVal dt As Date)
        My.Settings.set_inj_wk1_ldate = dt.ToString("H/dd/yyyy")
    End Sub

    Public Shared Function GetWeekOneDate() As Date
        If My.Settings.set_inj_wk1_ldate = "" Then
            Return Nothing
        Else
            Return Date.Parse(My.Settings.set_inj_wk1_ldate)
        End If
    End Function

#End Region

#Region "Week Two"

    Public Shared Sub SetWeekTwoMileage(ByVal miles As Integer)
        My.Settings.set_inj_totmile_wk2 = miles
    End Sub

    Public Shared Function GetWeekTwoMileage() As Integer
        Return My.Settings.set_inj_totmile_wk2
    End Function

    Public Shared Sub SetWeekTwoDate(ByVal dt As Date)
        My.Settings.set_inj_wk2_ldate = dt.ToString("H/dd/yyyy")
    End Sub

    Public Shared Function GetWeekTwoDate() As Date
        If My.Settings.set_inj_wk2_ldate = "" Then
            Return Nothing
        Else
            Return Date.Parse(My.Settings.set_inj_wk2_ldate)
        End If
    End Function

#End Region
    
    Public Shared Function GetDifferenceBetweenDates(ByVal date1 As Date, ByVal date2 As Date) As TimeSpan
        Dim ret As New TimeSpan
        ret = date1.Subtract(date2)
        Return ret
    End Function

    Public Shared Sub DisplayAlert()
        MetroFramework.MetroMessageBox.Show(frmManager, "Warning: You have increased your mileage by more than the recommended maximum of 10% per week. You are putting yourself at risk of injury. Please consider reducing your mileage or resting.", "Injury Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Shared Sub ProcessWorkout(ByVal nworkout As Workout)
        If GetWeekOneDate() = Nothing Then
            SetWeekOneDate(nworkout.WorkoutDate)
            SetWeekOneMileage(GetWeekOneMileage() + nworkout.Distance)
        Else
            If GetDifferenceBetweenDates(nworkout.WorkoutDate, GetWeekOneDate) <= New TimeSpan(7, 0, 0, 0) Then
                SetWeekOneMileage(GetWeekOneMileage() + nworkout.Distance)
            Else
                If GetDifferenceBetweenDates(nworkout.WorkoutDate, GetWeekOneDate) <= New TimeSpan(14, 0, 0, 0) Then
                    SetWeekTwoMileage(GetWeekTwoMileage() + nworkout.Distance)
                    If CheckIfGreaterThanTenPercent() Then
                        DisplayAlert()
                    End If
                Else
                    If GetDifferenceBetweenDates(nworkout.WorkoutDate, GetWeekOneDate) <= New TimeSpan(15, 0, 0, 0) Then
                        SetWeekTwoMileage(GetWeekTwoMileage() + nworkout.Distance)
                        If CheckIfGreaterThanTenPercent() Then
                            DisplayAlert()
                        End If
                    Else
                        SetWeekOneDate(nworkout.WorkoutDate)
                        SetWeekOneMileage(nworkout.Distance)
                        SetWeekTwoDate(Nothing)
                        SetWeekTwoMileage(0)
                    End If
                End If
            End If
        End If
    End Sub

End Class
