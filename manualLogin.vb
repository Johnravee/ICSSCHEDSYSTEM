Public Class manualLogin
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        RFIDLogin.Show()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RFIDTxtBox.Text = "0618983539" Then
            MsgBox("Login success")
        End If
    End Sub
End Class