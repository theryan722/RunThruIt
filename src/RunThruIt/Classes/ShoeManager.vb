Public Class ShoeManager

    'name|mileage|notes|date|mileage

#Region "Public"

    Public Shared Sub AddShoe(ByVal nshoe As Shoe)
        My.Settings.set_shoes.Add(ConvertShoeToString(nshoe))
    End Sub

    Public Shared Sub RemoveShoe(ByVal nshoe As Shoe)
        My.Settings.set_shoes.Remove(ConvertShoeToString(nshoe))
    End Sub

    Public Shared Sub ClearShoes()
        My.Settings.set_shoes.Clear()
    End Sub

    Public Shared Function GetShoes() As List(Of Shoe)
        Dim ret As New List(Of Shoe)
        For Each item As String In My.Settings.set_shoes
            ret.Add(ConvertStringToShoe(item))
        Next
        Return ret
    End Function

#End Region

#Region "Convert"

    Public Shared Function ConvertShoeToString(ByVal nshoe As Shoe) As String
        Return nshoe.ShoeName & "|" & nshoe.Mileage & "|" & nshoe.Notes & "|" & nshoe.DatePurchased.ToString & "|" & nshoe.MaxMileage
    End Function

    Public Shared Function ConvertStringToShoe(ByVal str As String) As Shoe
        Dim arr() As String = str.Split("|")
        Return New Shoe(arr(0), arr(1), arr(2), Date.Parse(arr(3)), arr(4))
    End Function

#End Region

End Class
