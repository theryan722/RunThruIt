Public Class Shoe

    Public Property ShoeName As String
    Public Property Mileage As String
    Public Property Notes As String
    Public Property DatePurchased As Date
    Public Property MaxMileage As String

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal sname As String, ByVal smileage As String, ByVal snotes As String, ByVal sdate As Date, ByVal smaxmileage As String)
        ShoeName = sname
        Mileage = smileage
        Notes = snotes
        DatePurchased = sdate
        MaxMileage = smaxmileage
    End Sub

#End Region

    Public Function GetLifespanLeft() As String
        Dim per As Double = 1.0 - (CDbl(Mileage) / CDbl(MaxMileage))
        Return per.ToString()
    End Function

End Class
