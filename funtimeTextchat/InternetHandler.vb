Public Class InternetHandler
    Friend downloadLocationVar
    Friend ftpAddrVar
    Friend fileNameVar
    Friend filePathVar

    Private Sub setIP_Click(sender As Object, e As EventArgs) Handles setIP.Click
        ftpAddrVar = setIP.Text
    End Sub

    Private Sub SetPath_Click(sender As Object, e As EventArgs) Handles SetPath.Click
        filePathVar = FilePathAddr.Text
    End Sub

    Private Sub SetName_Click(sender As Object, e As EventArgs) Handles SetName.Click
        fileNameVar = FileName.Text
    End Sub

    Private Sub SetDownloadLocation_Click(sender As Object, e As EventArgs) Handles SetDownloadLocation.Click
        downloadLocationVar = DownloadLocation.Text
    End Sub

    Private Sub action_Click(sender As Object, e As EventArgs) Handles action.Click
        If (DownloadBttn.Checked = True) Then
            ftpModule.download(DownloadLocation.Text, "ftp://" + IPAddr.Text, fileNameVar)
        ElseIf (UploadBttn.Checked = True) Then

        ElseIf (DeleteBttn.Checked = True) Then

        Else
            MsgBox("Please Select An Option", Title:="Error Information")
        End If
    End Sub

    Private Sub DownloadBttn_CheckedChanged(sender As Object, e As EventArgs) Handles DownloadBttn.CheckedChanged
        FileName.Visible = True
        SetName.Visible = True
        SetDownloadLocation.Visible = True
        DownloadLocation.Visible = True
        setIP.Visible = True
        IPAddr.Visible = True

        SetPath.Visible = False
        FilePathAddr.Visible = False
    End Sub

    Private Sub UploadBttn_CheckedChanged(sender As Object, e As EventArgs) Handles UploadBttn.CheckedChanged
        SetDownloadLocation.Visible = False
        DownloadLocation.Visible = False

        FileName.Visible = True
        setIP.Visible = True
        IPAddr.Visible = True
        SetPath.Visible = True
        FilePathAddr.Visible = True
        SetName.Visible = True
    End Sub

    Private Sub DeleteBttn_CheckedChanged(sender As Object, e As EventArgs) Handles DeleteBttn.CheckedChanged
        setIP.Visible = True
        IPAddr.Visible = True
        SetName.Visible = True
        FileName.Visible = True

        SetDownloadLocation.Visible = False
        DownloadLocation.Visible = False
        SetPath.Visible = False
        FilePathAddr.Visible = False
    End Sub
End Class