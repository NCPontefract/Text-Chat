Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Form1.Show()
        'Pass ALL INFO
        'Check Login if necessary
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub lan_Click(sender As Object, e As EventArgs) Handles lan.Click
        internet.Enabled = False
    End Sub

    Private Sub internet_Click(sender As Object, e As EventArgs) Handles internet.Click
        lan.Enabled = False
    End Sub
End Class
