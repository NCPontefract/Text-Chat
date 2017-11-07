Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Form1.Show()
        'Pass ALL INFO
        'Check Login if necessary (LAN database, not internet as database would be hard)        Me.Close()
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
End Class
