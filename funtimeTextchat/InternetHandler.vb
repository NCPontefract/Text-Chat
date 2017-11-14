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
            ftpModule.download(Application.StartupPath + "\downloads", "ftp://10.0.2.15", fileNameVar)
        ElseIf (UploadBttn.Checked = True) Then

        ElseIf (DeleteBttn.Checked = True) Then

        Else
            MsgBox("Please Select An Option", Title:="Error Information")
        End If
    End Sub
End Class