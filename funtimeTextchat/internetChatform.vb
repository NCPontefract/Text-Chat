﻿Imports System.IO
Public Class internetChatform
    Friend nickname As String
    'nickname passes successfully
    Private Sub internetChatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        send.Enabled = False
        leave.Enabled = False
        RichTextBox1.Enabled = False
        Me.AcceptButton = join
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles join.Click 'JOIN
        If (ftpModule.download(Application.StartupPath + "/InternetRooms/", "ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password)) Then
            MainFunctions_NoReturns.joinInternet()
            'MsgBox("Exists") 'DEBUGGING
            File.Delete(Application.StartupPath + "/InternetRooms/" + TextBox1.Text + ".txt")
            send.Enabled = True
            leave.Enabled = True
            RichTextBox1.Enabled = True
        Else 'doesn't exist
            ftpModule.create(Application.StartupPath + "/InternetRooms", internetValidation.IP_Address, TextBox1.Text, internetValidation.username, internetValidation.password)
            MsgBox("Room Created", Title:="Information") 'DEBUGGING
            MainFunctions_NoReturns.joinInternet()
            send.Enabled = True
            leave.Enabled = True
            RichTextBox1.Enabled = True
        End If
        Me.TextBox1.ReadOnly = True
        Me.join.Enabled = False
        Me.leave.Enabled = True
        Me.RichTextBox1.Enabled = True
        Me.AcceptButton = send
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles leave.Click 'LEAVE
        Me.Updater.Enabled = False
        Me.TextBox1.ReadOnly = False
        Me.outputBox.Text = ""
        Me.RichTextBox1.Text = ""
        Me.send.Enabled = False
        Me.join.Enabled = True
        Me.leave.Enabled = False
        Me.RichTextBox1.Enabled = False
        Me.AcceptButton = send
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick

        ftpModule.checkForUpdate(Application.StartupPath + "/InternetRooms/", "ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password)
        'ftpModule.refresh()
        'MsgBox("Difference!")

    End Sub

    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click

        Me.Updater.Enabled = False
        'Manually refresh outputBox
        ftpModule.refresh(ftpModule.checkForUpdate(Application.StartupPath + "/InternetRooms/", "ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password))
        Dim toAppend
        Dim content

        content = ftpModule.read("ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password, "internet")
        toAppend = RichTextBox1.Text
        content = toAppend + content

        Dim sw As StreamWriter = New StreamWriter(Application.StartupPath + "/tempFiles/" + TextBox1.Text + ".txt")
        sw.Write(Environment.NewLine + nickname + ": " + content) 'writes to new file
        sw.Close()

        ftpModule.upload(Application.StartupPath + "/tempFiles/", "ftp://" + internetValidation.IP_Address, TextBox1.Text + ".txt", internetValidation.username, internetValidation.password)
        File.Delete(Application.StartupPath + "/tempFiles/" + TextBox1.Text + ".txt")

        Me.Updater.Enabled = True
        Me.RichTextBox1.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        internetValidation.Show()
        Me.Close()
    End Sub

    Private Sub me_close() Handles MyBase.Closing
        internetValidation.Show()
    End Sub
End Class