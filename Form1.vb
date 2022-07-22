Public Class Form1
    Dim Tic As Char = "X"
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If btnA.Text = "" Then
            btnA.Text = Tic

            If Tic = "X" Then
                Tic = "O"
            Else
                Tic = "X"
            End If
        End If
    End Sub

    Private Sub btnAA_Click(sender As Object, e As EventArgs) Handles btnAA.Click
        If btnAA.Text = "" Then
            btnAA.Text = Tic

            If Tic = "X" Then
                Tic = "O"
            Else
                Tic = "X"
            End If
        End If
    End Sub

    Private Sub btnAAA_Click(sender As Object, e As EventArgs) Handles btnAAA.Click
        If btnAAA.Text = "" Then
            btnAAA.Text = Tic

            If Tic = "X" Then
                Tic = "O"
            Else
                Tic = "X"
            End If
        End If
    End Sub
End Class
