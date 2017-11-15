Public Class internetChatform
    Friend nickname As String
    'nickname passes successfully
    Private Sub internetChatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ftpModule.create(Application.StartupPath + "/InternetRooms", internetValidation.IP_Address, TextBox1.Text, internetValidation.username, internetValidation.password)
    End Sub
End Class