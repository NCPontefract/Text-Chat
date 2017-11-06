Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Join.Click
        Me.Text = "Chatroom - " + RoomID.Text
        Leave.Enabled = True
        Send.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Leave.Click
        Me.Text = "Chatroom"
        RoomID.Text = ""
        Leave.Enabled = False
        MessageBoard.Text = ""
        Send.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Leave.Enabled = False
        Send.Enabled = False
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        MessageBoard.AppendText(MessageInput.Text + Environment.NewLine)
        MessageInput.Text = ""
    End Sub
End Class
