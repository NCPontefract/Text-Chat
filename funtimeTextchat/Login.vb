Public Class Login
    Friend nickname As String
    Friend groupID As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If (Lan.Checked = True) Then
            If (loginProcedure("LAN", UsernameTextBox.Text, PasswordTextBox.Text) And RoomTextBox.Text IsNot "") = True Then
                Form1.Show()
                groupID = RoomTextBox.Text
                nickname = Me.UsernameTextBox.Text
                Form1.room = groupID
                Form1.RoomID.Text = groupID
                Form1.nick = nickname
                Me.Close()
                'InternetHandler.Show()
            End If
        ElseIf (Internet.Checked = True) Then
            loginProcedure("Internet", UsernameTextBox.Text, PasswordTextBox.Text)
        Else
            MsgBox("Please Select A Login Method (LAN / Internet)", Title:="Error Information")
        End If
        'Pass ALL INFO
        'Check Login if necessary (LAN database, not internet as database would be hard)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Internet_CheckedChanged(sender As Object, e As EventArgs) Handles Internet.Click

    End Sub

    Private Sub Lan_CheckedChanged(sender As Object, e As EventArgs) Handles Lan.Click

    End Sub

    Private Sub Lan_CheckedChanged_1(sender As Object, e As EventArgs) Handles Lan.CheckedChanged
        RoomLabel.Visible = True
        RoomTextBox.Visible = True
        UsernameLabel.Visible = True
        UsernameTextBox.Visible = True
        PasswordLabel.Visible = True
        PasswordTextBox.Visible = True
    End Sub

    Private Sub Internet_CheckedChanged_1(sender As Object, e As EventArgs) Handles Internet.CheckedChanged
        RoomLabel.Visible = False
        RoomTextBox.Visible = False
        PasswordLabel.Visible = False
        PasswordTextBox.Visible = False
        UsernameTextBox.Visible = True
        UsernameLabel.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InternetHandler.Show()
    End Sub
End Class
