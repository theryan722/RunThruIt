Public Class Shoe

    Public Property ShoeName As String
    Public Property Mileage As String
    Public Property Notes As String
    Public Property ShoeIsDefault As Boolean
    Public Property DatePurchased As Date

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal sname As String, ByVal smileage As String, ByVal snotes As String, ByVal sdef As Boolean, ByVal sdate As Date)
        ShoeName = sname
        Mileage = smileage
        Notes = snotes
        ShoeIsDefault = sdef
        DatePurchased = sdate
    End Sub

#End Region

    Public Sub AlertIfHighMileage()

    End Sub

End Class
