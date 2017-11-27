Imports System.Net
Imports System.IO

Module ftpModule
    Friend Function upload(localFileAddr, ftpAddr, fileName, username, password) 'Upload File to FTP site
        Try
            'Create Request To Upload File'
            Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create(ftpAddr + "/" + fileName), FtpWebRequest)

            wrUpload.Method = WebRequestMethods.Ftp.UploadFile 'Start Upload Process'
            wrUpload.Credentials = New NetworkCredential(username.ToString, password.ToString) 'Specify Username & Password
            Dim btfile() As Byte = File.ReadAllBytes(localFileAddr + "\" + fileName) 'Locate File And Store It In Byte Array'
            Dim strFile As Stream = wrUpload.GetRequestStream() 'Get File'
            strFile.Write(btfile, 0, btfile.Length) 'Upload Each Byte'

            strFile.Close()
            strFile.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function download(localStorage As String, ftpAddr As String, fileName As String, username As String, password As String) 'Download A File From FTP Site'
        Try
            ' Dim toDownload As String = (ftpAddr + "/" + fileName) 'Complete string of what to downlaod
            Dim toDownload As String = (ftpAddr + "/" + fileName)
            ' Debugging tool -> MsgBox(toDownload)
            Dim wrDownload As FtpWebRequest = WebRequest.Create(toDownload) 'Create Request To Download File

            wrDownload.Method = WebRequestMethods.Ftp.DownloadFile 'Specify That You Want To Download A File
            wrDownload.Credentials = New NetworkCredential(username, password) 'Specify Username & Password
            Dim rDownloadResponse As FtpWebResponse = wrDownload.GetResponse() 'Response Object
            Dim strFileStream As Stream = rDownloadResponse.GetResponseStream() 'Incoming File Stream
            Dim srFile As StreamReader = New StreamReader(strFileStream) 'Read File Stream Data
            Dim text As String = srFile.ReadToEnd

            Console.WriteLine("Download Complete, status {0}", rDownloadResponse.StatusDescription) 'Show Status Of Download
            File.WriteAllText(localStorage + "/" + fileName, text)

            srFile.Close() 'Close streamReader
            rDownloadResponse.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Friend Function delete(ftpAddr, fileName, usrName, password) 'Delete File On FTP Server'
        Dim toDelete As String = (ftpAddr + "/" + fileName)
        Try
            Dim wrDelete As FtpWebRequest = CType(WebRequest.Create(toDelete), FtpWebRequest) 'Create Request To Delete File'
            wrDelete.Credentials = New NetworkCredential(usrName.ToString, password.ToString) 'Specify Username & Password
            wrDelete.Method = WebRequestMethods.Ftp.DeleteFile 'Specify That You Want To Delete A File'
            Dim rDeleteResponse As FtpWebResponse = CType(wrDelete.GetResponse(), FtpWebResponse) 'Response Object'
            Console.WriteLine("Delete status: {0}", rDeleteResponse.StatusDescription) 'Show Status Of Delete'
            rDeleteResponse.Close() 'Close'
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function verify(localFileAddr, ftpAddr, fileName, username, password) 'Verifying FTP Addr
        Try
            'ftpModule.verify(Application.StartupPath + "/testingItems", IP_Address, "verify.txt", username, password
            'Create Request To Upload File'
            Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create(ftpAddr + "/" + fileName), FtpWebRequest)

            wrUpload.Method = WebRequestMethods.Ftp.UploadFile 'Start Upload Process'
            wrUpload.Credentials = New NetworkCredential(username.ToString, password.ToString) 'Specify Username & Password
            Dim btfile() As Byte = File.ReadAllBytes(localFileAddr + "\" + fileName) 'Locate File And Store It In Byte Array'
            Dim strFile As Stream = wrUpload.GetRequestStream() 'Get File'
            strFile.Write(btfile, 0, btfile.Length) 'Upload Each Byte'

            strFile.Close()
            strFile.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Dim toDelete As String = (ftpAddr + "/" + fileName)
        Try
            Dim wrDelete As FtpWebRequest = CType(WebRequest.Create(toDelete), FtpWebRequest) 'Create Request To Delete File'
            wrDelete.Credentials = New NetworkCredential(username.ToString, password.ToString) 'Specify Username & Password
            wrDelete.Method = WebRequestMethods.Ftp.DeleteFile 'Specify That You Want To Delete A File'
            Dim rDeleteResponse As FtpWebResponse = CType(wrDelete.GetResponse(), FtpWebResponse) 'Response Object'
            Console.WriteLine("Delete status: {0}", rDeleteResponse.StatusDescription) 'Show Status Of Delete'
            rDeleteResponse.Close() 'Close'
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Friend Function create(localFilePathToUpload, ftpAddress, filename, username, password) ' If not detected on ftp site
        filename = filename + ".txt"
        Using sw As FileStream = File.Create(localFilePathToUpload + "/" + filename)
        End Using
        upload(localFilePathToUpload, "ftp://" + ftpAddress, filename, username, password)
        File.Delete(localFilePathToUpload + "/" + filename)

        MainFunctions_NoReturns.writeToElementFromCreation("internet", "")

    End Function

    Friend Function read(ftpAddr As String, fileName As String, username As String, password As String, type As String)
        Try
            If (type = "internet") Then
                ' Dim toDownload As String = (ftpAddr + "/" + fileName) 'Complete string of what to downlaod
                Dim toRead As String = (ftpAddr + "/" + fileName)
                ' Debugging tool -> MsgBox(toDownload)
                Dim wrRead As FtpWebRequest = WebRequest.Create(toRead) 'Create Request To Download File

                wrRead.Method = WebRequestMethods.Ftp.DownloadFile 'Specify That You Want To Download A File
                wrRead.Credentials = New NetworkCredential(username, password) 'Specify Username & Password
                Dim rDownloadResponse As FtpWebResponse = wrRead.GetResponse() 'Response Object
                Dim strFileStream As Stream = rDownloadResponse.GetResponseStream() 'Incoming File Stream
                Dim srFile As StreamReader = New StreamReader(strFileStream) 'Read File Stream Data
                Dim text As String = srFile.ReadToEnd

                'Console.WriteLine(text)
                Return text
                Console.WriteLine("Download Complete, status {0}", rDownloadResponse.StatusDescription) 'Show Status Of Download
                'internetChatform.outputBox.Text = text

                srFile.Close() 'Close streamReader
                rDownloadResponse.Close()

            Else 'lanRead
                'do lan stuff
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function checkForUpdate(localStorage As String, ftpAddr As String, fileName As String, username As String, password As String)

        Try
            Dim currentDisp As String = internetChatform.outputBox.Text
            Dim toDownload As String = (ftpAddr + "/" + fileName)
            Dim wrDownload As FtpWebRequest = WebRequest.Create(toDownload)

            wrDownload.Method = WebRequestMethods.Ftp.DownloadFile 'Specify That You Want To Download A File
            wrDownload.Credentials = New NetworkCredential(username, password) 'Specify Username & Password
            Dim rDownloadResponse As FtpWebResponse = wrDownload.GetResponse() 'Response Object
            Dim strFileStream As Stream = rDownloadResponse.GetResponseStream() 'Incoming File Stream
            Dim srFile As StreamReader = New StreamReader(strFileStream) 'Read File Stream Data
            Dim content As String = srFile.ReadToEnd
            srFile.Close() 'Close streamReader
            rDownloadResponse.Close()


            If (content = currentDisp) Then
                'Return False

            Else
                'Return True
                refresh(content)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Friend Function refresh(newText)
        'Refreshes the form
        internetChatform.outputBox.Text = newText
    End Function

End Module
