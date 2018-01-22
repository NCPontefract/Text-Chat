Public Class Login
    Friend nickname As String
    Friend groupID As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (Lan.Checked = True) Then
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
        If (InputBox("Enter Admin Password:") = "MXRNWSAN") Then
            If (UsernameTextBox.Text IsNot "" And PasswordTextBox.Text IsNot "") Then
                DatabaseComms.createUsr(UsernameTextBox.Text, PasswordTextBox.Text)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            Else
                MsgBox("Please enter a username or password.")
            End If
        End If
    End Sub
End Class
