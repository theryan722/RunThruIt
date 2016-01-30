Public Class ShoeManager

    'name|mileage|notes|default

#Region "Public"

    Public Shared Sub AddShoe(ByVal nshoe As Shoe)

    End Sub

    Public Shared Sub RemoveShoe(ByVal nshoe As Shoe)

    End Sub

    Public Shared Function GetDefaultShoe() As Shoe

    End Function

    Public Shared Sub ClearShoes()

    End Sub

    Public Shared Sub AddMileageToShoe(ByVal nshoe As Shoe, ByVal miles As Integer)

    End Sub

#End Region

#Region "Convert"

    Public Shared Function ConvertShoeToString(ByVal nshoe As Shoe) As String

    End Function

    Public Shared Function ConvertStringToShoe(ByVal str As String) As Shoe
        
    End Function

#End Region

End Class
