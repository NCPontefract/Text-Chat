Public Class Login
    Friend nickname As String
    Friend groupID As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If (Lan.Checked = True) Then
            'needs to check input sql
            If (DatabaseComms.login(UsernameTextBox.Text, PasswordTextBox.Text, "") = True And RoomTextBox.Text IsNot "") Then
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
            nickname = UsernameTextBox.Text
            MainFunctions_Returns.loginProcedure("Internet", UsernameTextBox.Text, PasswordTextBox.Text, nickname)
            Me.Close()
        Else
            MsgBox("Please Select A Login Method (LAN / Internet)", Title:="Error Information")
        End If
        'Pass ALL INFO
        'Check Login if necessary (LAN database, not internet as database would be hard)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
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
        register.Visible = True
    End Sub

    Private Sub Internet_CheckedChanged_1(sender As Object, e As EventArgs) Handles Internet.CheckedChanged
        RoomLabel.Visible = False
        RoomTextBox.Visible = False
        PasswordLabel.Visible = False
        PasswordTextBox.Visible = False
        UsernameTextBox.Visible = True
        UsernameLabel.Visible = True
        register.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'InternetHandler.Show()
        firewall()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SideFunctions.checkDir(Application.StartupPath)
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        DatabaseComms.createUsr(UsernameTextBox.Text, PasswordTextBox.Text)
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub
End Class
