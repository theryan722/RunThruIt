Public Class Tab_About

    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

End Class