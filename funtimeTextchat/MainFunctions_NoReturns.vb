Imports System.IO
Module MainFunctions_NoReturns
    Friend Function join()
        Form1.Text = "Chatroom - " + Form1.RoomID.Text
        Form1.Leave.Enabled = True
        Form1.Send.Enabled = True
        Form1.MessageInput.Text = ""
        Form1.room = Form1.RoomID.Text

        If (File.Exists(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt")) Then
            Form1.updateTimer.Enabled = True
            MainFunctions_Returns.writeLanRoom(Form1.nick + " Joined The Room", "")
        Else
            MsgBox("Creating Local Room", Title:="Information")
            Dim swFile As StreamWriter = New StreamWriter(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt")
            swFile.Write("")
            swFile.Close()
            Form1.updateTimer.Enabled = True
        End If

    End Function
    Friend Function joinInternet()
        internetChatform.outputBox.Text = ftpModule.read("ftp://" + internetValidation.IP_Address, internetChatform.TextBox1.Text + ".txt", internetValidation.username, internetValidation.password, "internet") 'do read from download
    End Function


    Friend Function leave()
        Form1.updateTimer.Enabled = False
        Form1.Text = "Chatroom"
        Form1.RoomID.Text = ""
        Form1.Leave.Enabled = False
        Form1.MessageBoard.Text = ""
        Form1.Send.Enabled = False
        Form1.MessageInput.Text = ""
        Form1.updateTimer.Enabled = False



    End Function

    Friend Function writeToElementFromCreation(calledFrom, downloadStream)
        Dim newText
        If (calledFrom = "internet") Then
            'Update element procedure for internetChatroom
            internetChatform.outputBox.Text = ""
            internetChatform.outputBox.Text = downloadStream
        Else
            'Update element procedure for lanChatroom
        End If
    End Function
    Friend Function updateBox()
        Dim srFile As StreamReader = New StreamReader(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt")
        Form1.MessageBoard.Text = srFile.ReadToEnd
        srFile.Close()
    End Function
End Module
