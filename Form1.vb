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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
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
        Xwins()
        Owins()
        NoWinner()
    End Sub


    Private Sub Xwins()
        If btnA.Text = "X" And btnAA.Text = "X" And btnAAA.Text = "X" Then
            MessageBox.Show("X Wins")

        ElseIf btnB.Text = "X" And btnBB.Text = "X" And btnBBB.Text = "X" Then
            MessageBox.Show("X Wins")

        ElseIf btnC.Text = "X" And btnCC.Text = "X" And btnCCC.Text = "X" Then
            MessageBox.Show("X Wins")

        End If

        If btnA.Text = "X" And btnB.Text = "X" And btnC.Text = "X" Then
            MessageBox.Show("X Wins")
        ElseIf btnAA.Text = "X" And btnBB.Text = "X" And btnCC.Text = "X" Then
            MessageBox.Show("X Wins")
        ElseIf btnAAA.Text = "X" And btnBBB.Text = "X" And btnCCC.Text = "X" Then
            MessageBox.Show("X Wins")
        End If

        If btnA.Text = "X" And btnBB.Text = "X" And btnCCC.Text = "X" Then
            MessageBox.Show("X Wins")
        ElseIf btnAAA.Text = "X" And btnBB.Text = "X" And btnC.Text = "X" Then
            MessageBox.Show("X Wins")
        End If
    End Sub

    Private Sub Owins()
        If btnA.Text = "O" And btnAA.Text = "O" And btnAAA.Text = "O" Then
            MessageBox.Show("O Wins")

        ElseIf btnB.Text = "O" And btnBB.Text = "O" And btnBBB.Text = "O" Then
            MessageBox.Show("O Wins")

        ElseIf btnC.Text = "O" And btnCC.Text = "O" And btnCCC.Text = "O" Then
            MessageBox.Show("O Wins")

        End If

        If btnA.Text = "O" And btnB.Text = "O" And btnC.Text = "O" Then
            MessageBox.Show("O Wins")
        ElseIf btnAA.Text = "O" And btnBB.Text = "O" And btnCC.Text = "O" Then
            MessageBox.Show("O Wins")
        ElseIf btnAAA.Text = "O" And btnBBB.Text = "O" And btnCCC.Text = "O" Then
            MessageBox.Show("O Wins")
        End If

        If btnA.Text = "O" And btnBB.Text = "O" And btnCCC.Text = "O" Then
            MessageBox.Show("O Wins")
        ElseIf btnAAA.Text = "O" And btnBB.Text = "O" And btnC.Text = "O" Then
            MessageBox.Show("O Wins")
        End If
    End Sub
    Private Sub NoWinner()
        If btnA.Enabled = False And btnAA.Enabled = False And btnAAA.Enabled = False And btnB.Enabled = False _
And btnBB.Enabled = False And btnBBB.Enabled = False And btnC.Enabled = False And btnCC.Enabled = False _
And btnCCC.Enabled = False Then MsgBox("No Winner")
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btnA.Text = ""
        btnAA.Text = ""
        btnAAA.Text = ""
        btnB.Text = ""
        btnBB.Text = ""
        btnBBB.Text = ""
        btnC.Text = ""
        btnCC.Text = ""
        btnCCC.Text = ""

        btnA.Enabled = True
        btnAA.Enabled = True
        btnAAA.Enabled = True
        btnB.Enabled = True
        btnBB.Enabled = True
        btnBBB.Enabled = True
        btnC.Enabled = True
        btnCC.Enabled = True
        btnCCC.Enabled = True


    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        Dim Quit As DialogResult = MessageBox.Show("Do you wish to quit the game?", "MyTictactoe", MessageBoxButtons.YesNo)

        If Quit = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class