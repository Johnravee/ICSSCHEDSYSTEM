
Public Class RFIDLogin
    'response to events when called
    Private WithEvents inputTimer As Timer
    Private Sub scannerContainer_Paint(sender As Object, e As PaintEventArgs) Handles scannerContainer.Paint
        RFIDTxtBox.Focus()
    End Sub


    Private Sub RFIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RFIDTxtBox.TextChanged
        ' If the input timer is already running, stop it and restart
        If inputTimer IsNot Nothing AndAlso inputTimer.Enabled Then
            inputTimer.Stop()
        End If

        ' Check the characters length of txtbox 
        If RFIDTxtBox.TextLength = 10 Then
            RFIDTxtBox.Enabled = False
            RFIDAnimation.Visible = False
            loadingAnimation.Visible = True
        End If

        'Sample login
        If RFIDTxtBox.Text = "0619434387" Then
            'instance Pin login form
            Dim pinLogin As New PinLogin
            pinLogin.RFID = RFIDTxtBox.Text
            pinLogin.Show()
            Me.Hide()
        Else
            deniedNotif.Visible = True
            RFIDAnimation.Visible = False
            loadingAnimation.Visible = False
        End If

        inputTimer = New Timer()
        inputTimer.Interval = 2000
        'get the timer event then invoke inputTimer_Tick when interval is meet.
        AddHandler inputTimer.Tick, AddressOf InputTimer_Tick
        inputTimer.Start()
    End Sub

    'Run when invoked / when meet the time interval
    Private Sub InputTimer_Tick(sender As Object, e As EventArgs)
        inputTimer.Stop()
        RFIDTxtBox.Clear()
        RFIDTxtBox.Enabled = True
        loadingAnimation.Visible = False
        deniedNotif.Visible = False
        RFIDAnimation.Visible = True
        RFIDTxtBox.Focus()
    End Sub

    'To manual login form
    Private Sub manualLoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles manualLoginLink.LinkClicked
        Me.Hide()
        manualLogin.Show()
    End Sub

    'Close Form
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    'Minimize Form
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
