﻿Imports System.Net

Public Class Website
    'name|workouttype|distance|duration|sdatetime|pace|shoes
    Public Shared Sub PostWorkoutToFeed(ByVal name As String, ByVal workouttype As String, ByVal distance As String, ByVal duration As String, ByVal sdatetime As String, ByVal pace As String, ByVal shoes As String)
        Dim pub As String = name & "|" & workouttype & "|" & distance & "|" & duration & "|" & sdatetime & "|" & pace & "|" & shoes
        Dim request As WebRequest = WebRequest.Create("http://runthruit.net/scripts/addworkout.php?w=" & pub)
        request.GetResponse()
    End Sub

End Class
