Public Class InjuryManager

    Public Shared Function CheckIfGreaterThanTenPercent()
        Dim ret As Boolean = False
        If My.Settings.set_inj_totmile_wk2 > (0.1 * My.Settings.set_inj_totmile_wk1) Then
            ret = True
        End If
        Return ret
    End Function

    Public Shared Sub SetWeekOneMileage(ByVal miles As Integer)
        My.Settings.set_inj_totmile_wk1 = miles
    End Sub

    Public Shared Function GetWeekOneMileage() As Integer
        Return My.Settings.set_inj_totmile_wk1
    End Function

    Public Shared Sub SetWeekTwoMileage(ByVal miles As Integer)
        My.Settings.set_inj_totmile_wk2 = miles
    End Sub

    Public Shared Function GetWeekTwoMileage() As Integer
        Return My.Settings.set_inj_totmile_wk2
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

    Public Shared Sub SetWeekTwoDate(ByVal dt As Date)
        My.Settings.set_inj_wk2_ldate = dt.ToString("H/dd/yyyy")
    End Sub

End Class
