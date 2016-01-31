Imports System.Net

Public Class Website

    'name|workouttype|distance|duration|sdatetime|pace|shoes
    Public Shared Sub PostWorkoutToFeed(ByVal name As String, ByVal workouttype As String, ByVal distance As String, ByVal duration As String, ByVal sdatetime As String, ByVal pace As String, ByVal shoes As String, ByVal snotes As String)
        Dim pub As String = name & "|" & workouttype & "|" & distance & "|" & duration & "|" & sdatetime & "|" & pace & "|" & shoes & "|" & snotes
        Dim request As WebRequest = WebRequest.Create("http://ryanoday.com/runthruit/scripts/addworkout.php?w=" & pub)
        request.GetResponse()
        MetroFramework.MetroMessageBox.Show(frmManager, "Workout published to the RunThruIt Feed!", "Published", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
