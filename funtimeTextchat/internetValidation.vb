Public Class internetValidation

    Friend IP_Address
    Friend username
    Friend password
    Friend portNo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Pass variables to main Internet chat form
        internetChatform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Do a test (upload, delete -> if works then continue)'

        IP_Address = IP_Textbox.Text
        username = Username_Textbox.Text
        password = Password_Textbox.Text
        portNo = portTextbox.Text

        If (ftpModule.verify(Application.StartupPath + "/testingItems", "ftp://" + IP_Address, "verify.txt", username, password) = True) Then
            MsgBox("Connection Successful!")
            Button2.Enabled = True
        Else
            MsgBox("Connection Failed")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub internetValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class