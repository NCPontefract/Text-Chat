Imports System.Data.OleDb
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
                        setNickname(name)
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
            Else
                nickname = setNickname(name) 'internet selected
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
    Friend Function inputCheck(message1, message2)

    End Function

    Friend Function setNickname(name As String)
        Login.nickname = name

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
End Module
