Imports System.IO
Public Class internetChatform
    Friend nickname As String
    'nickname passes successfully
    Private Sub internetChatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ftpModule.download(Application.StartupPath + "/InternetRooms/", "ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password)) Then
            MainFunctions_NoReturns.joinInternet()
            'MsgBox("Exists")
            File.Delete(Application.StartupPath + "/InternetRooms/" + TextBox1.Text + ".txt")
        Else 'doesn't exist
            ftpModule.create(Application.StartupPath + "/InternetRooms", internetValidation.IP_Address, TextBox1.Text, internetValidation.username, internetValidation.password)
            MsgBox("Room Created")
            'join
        End If
    End Sub
End Class