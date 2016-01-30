Public Class Shoe

    Public Property ShoeName As String
    Public Property Mileage As String
    Public Property Notes As String

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal sname As String, ByVal smileage As String, ByVal snotes As String)
        ShoeName = sname
        Mileage = smileage
        Notes = snotes
    End Sub

#End Region

End Class
