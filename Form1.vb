Public Class Form1
    Private Sub btnTrimm_Click(sender As Object, e As EventArgs) Handles btnTrimm.Click
        Dim myPhrase As String

        myPhrase = InputBox("Enter your phrase")
        lbTrim.Text = Trim(myPhrase)
    End Sub
End Class
