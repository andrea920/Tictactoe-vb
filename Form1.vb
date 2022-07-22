Public Class Form1
    Dim turn As Char = "X"

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If turn = "X" Then
            btnA.Text = "X"
            turn = "O"
        Else
            btnA.Text = "O"
            turn = "X"
        End If
        btnA.Enabled = False
    End Sub
End Class