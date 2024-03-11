Public Class createSched
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
    End Sub
End Class