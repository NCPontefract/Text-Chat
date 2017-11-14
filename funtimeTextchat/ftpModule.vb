Imports System.Net
Imports System.IO

Module ftpModule
    Friend Function upload(localFileAddr, ftpAddr, fileName) 'Upload File to FTP site
        'Create Request To Upload File'
        Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create(ftpAddr + "/" + fileName), FtpWebRequest)

        wrUpload.Method = WebRequestMethods.Ftp.UploadFile 'Start Upload Process'
        Dim btfile() As Byte = File.ReadAllBytes(localFileAddr) 'Locate File And Store It In Byte Array'
        Dim strFile As Stream = wrUpload.GetRequestStream() 'Get File'
        strFile.Write(btfile, 0, btfile.Length) 'Upload Each Byte'

        strFile.Close()
        strFile.Dispose()
    End Function

    Friend Function download(localStorage, ftpAddr, fileName) 'Download A File From FTP Site'
        Try
            Dim toDownload As String = (ftpAddr + "/" + fileName)
            MsgBox(toDownload)
            Dim wrDownload As FtpWebRequest = WebRequest.Create(toDownload) 'Create Request To Download File'

            wrDownload.Method = WebRequestMethods.Ftp.DownloadFile 'Specify That You Want To Download A File'
            'Specify Username & Password'
            wrDownload.Credentials = New NetworkCredential("IEUser", "Passw0rd!")
            Dim rDownloadResponse As FtpWebResponse = wrDownload.GetResponse() 'Response Object'
            Dim strFileStream As Stream = rDownloadResponse.GetResponseStream() 'Incoming File Stream'
            Dim srFile As StreamReader = New StreamReader(strFileStream) 'Read File Stream Data'
            Dim text As String = srFile.ReadToEnd

            'Console.WriteLine(srFile.ReadToEnd())
            Console.WriteLine("Download Complete, status {0}", rDownloadResponse.StatusDescription) 'Show Status Of Download'

            File.WriteAllText(localStorage + "/" + fileName, text)
            srFile.Close() 'Close
            rDownloadResponse.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Friend Function delete(ftpAddr, fileName) 'Delete File On FTP Server'
        Dim todelete As String = (ftpAddr + "/" + fileName)

        Dim wrDelete As FtpWebRequest = CType(WebRequest.Create(todelete), FtpWebRequest) 'Create Request To Delete File'
        wrDelete.Method = WebRequestMethods.Ftp.DeleteFile 'Specify That You Want To Delete A File'
        Dim rDeleteResponse As FtpWebResponse = CType(wrDelete.GetResponse(), FtpWebResponse) 'Response Object'
        Console.WriteLine("Delete status: {0}", rDeleteResponse.StatusDescription) 'Show Status Of Delete'
        rDeleteResponse.Close() 'Close'

    End Function
End Module
