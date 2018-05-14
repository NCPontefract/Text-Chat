Imports System.Data.OleDb
Imports System.IO

Module DatabaseComms
    Friend Function login(username, passwordPlain, passwordHash)
        If (checkSQL(username) = True) Then
            Return False
        End If
        If (checkSQL(passwordPlain) = True) Then
            Return False
        End If

        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim salt As String

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = Application.StartupPath + "\LanUsers.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        'First check if DB Exists
        Try
            myConnection.Open() 'Checking username & finding salt
            'Convert passwordPlain to passwordHash using SALT from Db
        Catch ex As Exception
            'If it doesn't exist
            'File.Create("./LanUsers.accdb").Dispose() 'Create's files and .Dispose() ensures it is closed thereafter 



        End Try

        myConnection.Open() 'Checking username & finding salt
        'Convert passwordPlain to passwordHash using SALT from Db

        Dim command As OleDbCommand = New OleDbCommand("SELECT * FROM [users] WHERE [username] ='" & username & "'", myConnection)
        Dim dr As OleDbDataReader = command.ExecuteReader
        Dim userFound As Boolean

        While dr.Read
            userFound = True
            username = dr("username").ToString
            salt = dr("salt".ToString)
        End While
        If (userFound = True) Then
            passwordHash = (Hash512(passwordPlain, salt))
        Else
            MsgBox("Username or password is incorrect, please try again.")
            Return False
        End If

        myConnection.Close()

        'Cofirming Password Connection
        myConnection.Open()

        command = New OleDbCommand("SELECT * FROM [users] WHERE [username] = '" & username & "' AND [password] = '" & passwordHash & "'", myConnection)
        dr = command.ExecuteReader
        userFound = False

        'if found:
        While dr.Read
            userFound = True
        End While
        myConnection.Close()

        'checking the result
        If userFound = True Then
            MsgBox("Logging in as: " & username)
            Return True
        Else
            MsgBox("Username or password is incorrect, please try again.")
            Return False
        End If
    End Function

    Friend Function createUsr(username, passwordPlain)
        Dim Salt As String = CreateRandomSalt()
        Dim hash = (Hash512(passwordPlain, Salt))
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = Application.StartupPath + "/LanUsers.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open() 'Verify user doesn't already exist
        Dim command1 As OleDbCommand = New OleDbCommand("SELECT * FROM [users] WHERE [username] ='" & username & "'", myConnection)
        Dim dr1 As OleDbDataReader = command1.ExecuteReader
        Dim userFound As Boolean
        While dr1.Read
            userFound = True
        End While
        If (userFound = True) Then
            MsgBox("Username already registered, please try again.", Title:="Information")
            Return False
        Else
            'carry on
        End If
        myConnection.Close()

        myConnection.Open()
        Dim command As OleDbCommand = New OleDbCommand("INSERT INTO [users] ([username], [password], [salt]) VALUES ('" & username & "' , '" & hash & "', '" & Salt & "');", myConnection)
        Dim dr As OleDbDataReader = command.ExecuteReader
        While dr.Read
        End While
        myConnection.Close()
        MsgBox("User Registered")

    End Function

End Module