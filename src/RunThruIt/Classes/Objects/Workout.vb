Public Class Workout

    'Run
    'Bike
    'Walk
    'Swim
    'Hike
    'Strength Training
    'Yoga

#Region "Properties"

    Public Property WorkoutType As String
    Public Property WorkoutDate As Date
    Public Property WorkoutTime As DateTime
    Public Property Notes As String
    Public Property Distance As String
    Public Property Shoes As String
    Public Property Pace As String
    Public Property Injury As String
    Public Property Duration As String

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal wtype As String, ByVal wdate As Date, ByVal wnotes As String, ByVal wdistance As String, ByVal wshoes As String, ByVal wpace As String, ByVal winjury As String, ByVal wtime As DateTime, ByVal wduration As String)
        WorkoutType = wtype
        WorkoutDate = wdate
        Notes = wnotes
        Distance = wdistance
        Shoes = wshoes
        Pace = wpace
        Injury = winjury
        WorkoutTime = wtime
        Duration = wduration
    End Sub

#End Region

End Class
