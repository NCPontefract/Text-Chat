Public Class Form1
    Friend nick As String
    Friend room As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Join.Click
        MainFunctions_NoReturns.join()
        Me.RoomID.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Leave.Click
        MainFunctions_NoReturns.leave()
        Me.RoomID.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Leave.Enabled = False
        Send.Enabled = False
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        MainFunctions_Returns.writeLanRoom(MessageInput.Text, nick)
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub RoomID_TextChanged(sender As Object, e As EventArgs) Handles RoomID.TextChanged

    End Sub

    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick

        If (MainFunctions_Returns.checkLanTextChange(Application.StartupPath + "/LocalRooms/" + Me.RoomID.Text + ".txt", MessageBoard.Text) = True) Then
            MainFunctions_NoReturns.updateBox()
        End If

    End Sub
End Class
