Imports System.Data.OleDb
Imports System.IO

Module MainFunctions_Returns
    Friend Function loginProcedure(type As String, name As String, password As String)
        Dim provider, datafile, connectionstring, nickname
        Dim myConnection As OleDbConnection
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = Application.StartupPath + "\LanUsers.accdb"
        connectionstring = provider + datafile
        myConnection = New OleDbConnection()
        myConnection.ConnectionString = connectionstring
        'Setting up databse connection requirements
        Try
            If (type = "LAN") Then
                If (checkSQL(name) = False And checkSQL(password) = False) Then 'Check against DB now

                    myConnection.Open()
                    Dim command As OleDbCommand = New OleDbCommand("SELECT * FROM Users WHERE Username = '" & name & "' AND Password = '" & password & "'", myConnection)
                    Dim dataReader As OleDbDataReader = command.ExecuteReader
                    Dim userFound As Boolean = False

                    While dataReader.Read
                        userFound = True
                    End While
                    myConnection.Close()

                    If userFound = True Then
                        'Found!
                        'setNickname(name)
                        Return True
                    Else
                        MsgBox("Sorry, incorrect username or password detected. Please try again.", MsgBoxStyle.OkOnly, "Invalid Login")
                    End If

                Else
                    'Illegal character detected
                    Login.Lan.Checked = False
                    Login.UsernameTextBox.Text = ""
                    Login.PasswordTextBox.Text = ""
                End If
            Else 'Internet Selected
                internetValidation.Show()
                internetChatform.nickname = name
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
    Friend Function inputCheck(message1, message2)

    End Function


    Friend Function checkSQL(input)
        Dim flagged As Boolean = False
        Dim checkinginput = input
        Dim checkingInputArray As Char() = checkinginput.ToCharArray()
        Dim i = 0
        For length As Integer = 0 To checkingInputArray.Length - 1
            If (checkingInputArray(i) = "'") Then
                If (flagged = True) Then
                    'By leaving blank and setting the var to true in the else, a loop is avoided if more than 1 "'" is used
                Else
                    MsgBox("Illegal character detected")
                    flagged = True
                    Return True
                End If
            End If
            i = i + 1
        Next
        Return False
    End Function

    Friend Function checkLanTextChange(path, currentText)
        Dim oldText As String = currentText
        Dim newText As String
        Dim file As String = path
        Dim srFile As StreamReader = New StreamReader(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt") 'Read File Stream Data
        Dim text As String = srFile.ReadToEnd
        srFile.Close()
        newText = text

        If (oldText = newText) Then
            Return False
            'they're the same
        Else
            Return True
        End If

    End Function
    Friend Function writeLanRoom(toSend, name) 'updates local only

        Dim srFile As StreamReader = New StreamReader(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt")
        Dim old As String = srFile.ReadToEnd 'current display
        srFile.Close()

        Dim newer As String = toSend 'send box text
        Dim newBoard As String = newer + old 'both in right order

        Dim swFile As StreamWriter = New StreamWriter(Application.StartupPath + "/LocalRooms/" + Form1.RoomID.Text + ".txt") 'Read File Stream Data
        swFile.Write(Environment.NewLine + name + ": " + newBoard) 'writes to new file
        swFile.Close()

    End Function
End Module
