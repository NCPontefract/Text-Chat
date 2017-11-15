Public Class InternetHandler
    Friend downloadLocationVar
    Friend ftpAddrVar
    Friend fileNameVar
    Friend filePathVar

    Private Sub setIP_Click(sender As Object, e As EventArgs) Handles setIP.Click
        ftpAddrVar = IPAddr.Text
    End Sub

    Private Sub SetPath_Click(sender As Object, e As EventArgs) Handles SetFilePath.Click
        filePathVar = FilePathAddr.Text
    End Sub

    Private Sub SetName_Click(sender As Object, e As EventArgs) Handles SetFileName.Click
        fileNameVar = FileName.Text
    End Sub

    Private Sub SetDownloadLocation_Click(sender As Object, e As EventArgs) Handles SetDownloadLocation.Click
        downloadLocationVar = DownloadLocation.Text
    End Sub

    Private Sub action_Click(sender As Object, e As EventArgs) Handles action.Click
        If (DownloadBttn.Checked = True) Then
            ftpModule.download(DownloadLocation.Text, "ftp://" + ftpAddrVar, fileNameVar, InputBox("Username"), InputBox("Password"))
        ElseIf (UploadBttn.Checked = True) Then
            ftpModule.upload(filePathVar, "ftp://" + ftpAddrVar, fileNameVar, InputBox("Username"), InputBox("Password"))
        ElseIf (DeleteBttn.Checked = True) Then
            ftpModule.delete("ftp://" + ftpAddrVar, fileNameVar, InputBox("Username"), InputBox("Password"))
        Else
            MsgBox("Please Select An Option", Title:="Error Information")
        End If
    End Sub

    Private Sub DownloadBttn_CheckedChanged(sender As Object, e As EventArgs) Handles DownloadBttn.CheckedChanged
        FileName.Visible = True
        SetFileName.Visible = True
        SetDownloadLocation.Visible = True
        DownloadLocation.Visible = True
        setIP.Visible = True
        IPAddr.Visible = True

        SetFilePath.Visible = False
        FilePathAddr.Visible = False
    End Sub

    Private Sub UploadBttn_CheckedChanged(sender As Object, e As EventArgs) Handles UploadBttn.CheckedChanged
        SetDownloadLocation.Visible = False
        DownloadLocation.Visible = False

        FileName.Visible = True
        setIP.Visible = True
        IPAddr.Visible = True
        SetFilePath.Visible = True
        FilePathAddr.Visible = True
        SetFileName.Visible = True
    End Sub

    Private Sub DeleteBttn_CheckedChanged(sender As Object, e As EventArgs) Handles DeleteBttn.CheckedChanged
        setIP.Visible = True
        IPAddr.Visible = True
        SetFileName.Visible = True
        FileName.Visible = True

        SetDownloadLocation.Visible = False
        DownloadLocation.Visible = False
        SetFilePath.Visible = False
        FilePathAddr.Visible = False
    End Sub

    Private Sub InternetHandler_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        internetValidation.Show()
    End Sub
End Class