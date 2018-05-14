Imports System.Data.OleDb
Imports System.IO

Module SideFunctions
    Friend Function errorControl(ex As String)
        MsgBox(ex, Title:="Error Information")
    End Function

    Friend Function checkDir(startpath)
        checkDo(startpath, "downloads")
        checkDo(startpath, "InternetRooms")
        checkDo(startpath, "LocalRooms")
        checkDo(startpath, "rooms")
        checkDo(startpath, "tempFiles")
        If (checkDo(startpath, "testingItems") = False) Then
            Dim sw As StreamWriter = New StreamWriter(startpath.ToString + "/testingItems/verify.txt")
            sw.Write("testing")
            sw.Close()
        End If
    End Function

    Friend Function checkDo(startpath, dir)
        If (Directory.Exists(startpath + "/" + dir)) Then
            'Exists
            Return True
        Else
            'Doesn't exist, creating
            Directory.CreateDirectory(startpath + "/" + dir)
            Return False
        End If
    End Function

    Friend Function firewall()
        Dim psi As New ProcessStartInfo()
        psi.Verb = "runas"
        psi.FileName = "C:\Windows\System32\cmd.exe"
        psi.Arguments = "/c " + "netsh advfirewall firewall add rule name='" + InputBox("Display Name", "Add to Firewall") + "FTP-Chat' dir=In action=allow program='C:\Windows\System32\ftp.exe' enable=yes" ' Arguments for the process that you're going to run
        Try
            Process.Start(psi) ' Run the process (User is required to press Yes to run the program with Administrator access)
        Catch
            MsgBox("User cancelled the operation", 16, "") ' User pressed No
        End Try
    End Function

    Friend Function CreateDB()
        Dim cat As New ADOX.Catalog()
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        Dim dataFile = Application.StartupPath + "/LanUsers.accdb"
        Dim connString = provider & dataFile
        myConnection.ConnectionString = connString
        cat.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/LanUsers.accdb")
        cat = Nothing

        myConnection.Open()
        Dim createCommand As OleDbCommand = New OleDbCommand("CREATE TABLE [users]([UserID] int, [username] varchar(255), [password] varchar(255), [salt] varchar(255), [hash] varchar(255))", myConnection)
        Dim createDataReader As OleDbDataReader = createCommand.ExecuteReader
        While createDataReader.Read

        End While
        myConnection.Close()

    End Function
End Module
