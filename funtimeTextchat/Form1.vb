Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Join.Click
        MainFunctions_NoReturns.join()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Leave.Click
        MainFunctions_NoReturns.leave()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Leave.Enabled = False
        Send.Enabled = False
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        MainFunctions_NoReturns.send()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
        'TEMPORARY
    End Sub
End Class
