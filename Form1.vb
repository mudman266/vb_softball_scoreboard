Public Class frmMain
    Dim intCurrentInning As Integer = 1
    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click
        If intCurrentInning <= 7 Then
            ' Gather the score from the user
            Dim strScoreEntered As String
            strScoreEntered = InputBox("Score for Inning " & intCurrentInning.ToString())

            ' Validate input
            ' Handle non numeric input
            While Not IsNumeric(strScoreEntered)
                MsgBox("Your input was non numeric. Try again.")
                strScoreEntered = InputBox("Score for Inning " & intCurrentInning.ToString())
            End While

            ' Handle negative values
            While strScoreEntered < 0
                MsgBox("Your input was negative. Try again.")
                strScoreEntered = InputBox("Score for Inning " & intCurrentInning.ToString())
                ' Handle non numeric input
                While Not IsNumeric(strScoreEntered)
                    MsgBox("Your input was non numeric. Try again.")
                    strScoreEntered = InputBox("Score for Inning " & intCurrentInning.ToString())
                End While
            End While

            ' Valid value. Update the correct inning's score and add to the total
            Select Case intCurrentInning
                Case 1
                    lblScore1.Text = strScoreEntered
                Case 2
                    lblScore2.Text = strScoreEntered
                Case 3
                    lblScore3.Text = strScoreEntered
                Case 4
                    lblScore4.Text = strScoreEntered
                Case 5
                    lblScore5.Text = strScoreEntered
                Case 6
                    lblScore6.Text = strScoreEntered
                Case 7
                    lblScore7.Text = strScoreEntered
            End Select

            ' Increase the total score
            Dim intCurrentTotal As Integer = lblTotalScore.Text
            intCurrentTotal += strScoreEntered
            lblTotalScore.Text = intCurrentTotal.ToString()

            ' List box to satisfy program's requirement
            lstScoreList.Items.Add(strScoreEntered & " " & intCurrentTotal.ToString())

            ' Handle total score for list box
            If intCurrentInning = 7 Then
                lstScoreList.Items.Add(intCurrentTotal.ToString())
            End If
            ' Increase inning number
            intCurrentInning += 1

        Else
            ' Trying to enter a score after inning 7
            MsgBox("You have completed the game!")
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstScoreList.Items.Clear()
        lblScore1.Text = ""
        lblScore2.Text = ""
        lblScore3.Text = ""
        lblScore4.Text = ""
        lblScore5.Text = ""
        lblScore6.Text = ""
        lblScore7.Text = ""
        lblTotalScore.Text = "0"
        intCurrentInning = 1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
