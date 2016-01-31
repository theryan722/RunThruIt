Public Class InjuryManager

    Public Shared Function CheckIfGreaterThanTenPercent()
        Dim ret As Boolean = False
        If My.Settings.set_inj_totmile_wk2 > (0.1 * My.Settings.set_inj_totmile_wk1) Then
            ret = True
        End If
        Return ret
    End Function

End Class
