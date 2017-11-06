Module MainFunctions_NoReturns
    Friend Function join()
        Form1.Text = "Chatroom - " + Form1.RoomID.Text
        Form1.Leave.Enabled = True
        Form1.Send.Enabled = True
        Form1.MessageInput.Text = ""
    End Function
    Friend Function leave()
        Form1.Text = "Chatroom"
        Form1.RoomID.Text = ""
        Form1.Leave.Enabled = False
        Form1.MessageBoard.Text = ""
        Form1.Send.Enabled = False
        Form1.MessageInput.Text = ""
    End Function
    Friend Function send()
        Form1.MessageBoard.AppendText(Form1.MessageInput.Text + Environment.NewLine)
        Form1.MessageInput.Text = ""
    End Function
End Module
