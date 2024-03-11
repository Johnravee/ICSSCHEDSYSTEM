Public Class PinLogin
    Dim pinNumber As String
    Public Property RFID As String

    'Close form
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()

    End Sub

    'Minimize form
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button1.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button1.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button1.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button1.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button2.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button2.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button2.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button2.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button3.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button3.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button3.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button3.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button4.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button4.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button4.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button4.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button5.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button5.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button5.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button5.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button6.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button6.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button2.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button6.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button7.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button7.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button7.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button7.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button8.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button8.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button8.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button8.Text
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button9.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button9.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button9.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button9.Text
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = Button10.Text
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Button10.Text
        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = Button10.Text
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = Button10.Text
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        pinNumber = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text
        'What to do if pin is valid? Add your logic below this comment
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        pinNumber = ""
    End Sub


End Class