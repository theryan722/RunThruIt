Public Class Shoe

    Public Property ShoeName As String
    Public Property Mileage As String
    Public Property Notes As String
    Public Property ShoeIsDefault As Boolean

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal sname As String, ByVal smileage As String, ByVal snotes As String, ByVal sdef As Boolean)
        ShoeName = sname
        Mileage = smileage
        Notes = snotes
        ShoeIsDefault = sdef
    End Sub

#End Region

End Class
