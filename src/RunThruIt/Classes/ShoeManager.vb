Public Class ShoeManager

    'name|mileage|notes|default|date

#Region "Public"

    Public Shared Sub AddShoe(ByVal nshoe As Shoe)
        My.Settings.set_shoes.Add(ConvertShoeToString(nshoe))
    End Sub

    Public Shared Sub RemoveShoe(ByVal nshoe As Shoe)
        My.Settings.set_shoes.Remove(ConvertShoeToString(nshoe))
    End Sub

    Public Shared Function GetDefaultShoe() As Shoe
        Dim ret As New Shoe
        For Each item As String In My.Settings.set_shoes
            Dim arr() As String = item.Split("|")
            If Boolean.Parse(arr(3)) = True Then
                ret = ConvertStringToShoe(item)
                Exit For
            End If
        Next
        Return ret
    End Function

    Public Shared Sub ClearShoes()
        My.Settings.set_shoes.Clear()
    End Sub

    Public Shared Sub AddMileageToShoe(ByVal nshoe As Shoe, ByVal miles As Integer)
        Dim oshoe As New Shoe(nshoe.ShoeName, nshoe.Mileage, nshoe.Notes, nshoe.ShoeIsDefault, nshoe.DatePurchased)
        Dim t As Integer = CInt(nshoe.Mileage)
        t += miles
        nshoe.Mileage = t
        UpdateShoe(oshoe, nshoe)
    End Sub

    Public Shared Sub SetDefaultShoe(ByVal nshoe As Shoe)
        For Each item As String In My.Settings.set_shoes
            Dim arr() As String = item.Split("|")
            If Boolean.Parse(arr(3)) = True Then
                Dim bb As New Shoe
                bb = ConvertStringToShoe(item)
                Dim cc As New Shoe
                cc = ConvertStringToShoe(item)
                cc.ShoeIsDefault = False
                UpdateShoe(bb, cc)
                Exit For
            End If
        Next
    End Sub

    Public Shared Sub UpdateShoe(ByVal oshoe As Shoe, ByVal nshoe As Shoe)
        My.Settings.set_shoes.Remove(ConvertShoeToString(oshoe))
        My.Settings.set_shoes.Add(ConvertShoeToString(nshoe))
    End Sub

#End Region

#Region "Convert"

    Public Shared Function ConvertShoeToString(ByVal nshoe As Shoe) As String
        Return nshoe.ShoeName & "|" & nshoe.Mileage & "|" & nshoe.Notes & "|" & nshoe.ShoeIsDefault.ToString & "|" & nshoe.DatePurchased.ToString
    End Function

    Public Shared Function ConvertStringToShoe(ByVal str As String) As Shoe
        Dim arr() As String = str.Split("|")
        Return New Shoe(arr(0), arr(1), arr(2), Boolean.Parse(arr(3)), Date.Parse(arr(4)))
    End Function

#End Region

End Class
