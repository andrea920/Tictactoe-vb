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

    Private Sub btnAA_Click(sender As Object, e As EventArgs) Handles btnAA.Click
        If turn = "X" Then
            btnAA.Text = "X"
            turn = "O"
        Else
            btnAA.Text = "O"
            turn = "X"
        End If
        btnAA.Enabled = False
    End Sub

    Private Sub btnAAA_Click(sender As Object, e As EventArgs) Handles btnAAA.Click
        If turn = "X" Then
            btnAAA.Text = "X"
            turn = "O"
        Else
            btnAAA.Text = "O"
            turn = "X"
        End If
        btnAAA.Enabled = False
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If turn = "X" Then
            btnB.Text = "X"
            turn = "O"
        Else
            btnB.Text = "O"
            turn = "X"
        End If
        btnB.Enabled = False
    End Sub

    Private Sub btnBB_Click(sender As Object, e As EventArgs) Handles btnBB.Click
        If turn = "X" Then
            btnBB.Text = "X"
            turn = "O"
        Else
            btnBB.Text = "O"
            turn = "X"
        End If
        btnBB.Enabled = False
    End Sub

    Private Sub btnBBB_Click(sender As Object, e As EventArgs) Handles btnBBB.Click
        If turn = "X" Then
            btnBBB.Text = "X"
            turn = "O"
        Else
            btnBBB.Text = "O"
            turn = "X"
        End If
        btnBBB.Enabled = False
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If turn = "X" Then
            btnC.Text = "X"
            turn = "O"
        Else
            btnC.Text = "O"
            turn = "X"
        End If
        btnC.Enabled = False
    End Sub

    Private Sub btnCC_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        If turn = "X" Then
            btnCC.Text = "X"
            turn = "O"
        Else
            btnCC.Text = "O"
            turn = "X"
        End If
        btnCC.Enabled = False
    End Sub

    Private Sub btnCCC_Click(sender As Object, e As EventArgs) Handles btnCCC.Click
        If turn = "X" Then
            btnCCC.Text = "X"
            turn = "O"
        Else
            btnCCC.Text = "O"
            turn = "X"
        End If
        btnCCC.Enabled = False
    End Sub
End Class