Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number As Integer

        number = TextBox1.Text

        If (number >= 85) Then
            TextBox2.Text = "A+"
        End If
        If (number >= 70) And (number <= 84) Then
            TextBox2.Text = "A"
        End If
        If (number >= 65) And (number <= 69) Then
            TextBox2.Text = "B+"
        End If
        If (number >= 60) And (number <= 64) Then
            TextBox2.Text = "B"
        End If
        If (number >= 50) And (number <= 59) Then
            TextBox2.Text = "C"
        End If
        If (number < 50) Then
            TextBox2.Text = "D"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Application.ExitThread()

    End Sub
End Class
