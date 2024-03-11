<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFIDLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFIDLogin))
        TextBox1 = New TextBox()
        scannerContainer = New Panel()
        deniedNotif = New PictureBox()
        loadingAnimation = New PictureBox()
        PictureBox1 = New PictureBox()
        RFIDTxtBox = New TextBox()
        manualLoginLink = New LinkLabel()
        Label3 = New Label()
        RFIDAnimation = New PictureBox()
        Label2 = New Label()
        closeBtn = New PictureBox()
        minimize = New PictureBox()
        scannerContainer.SuspendLayout()
        CType(deniedNotif, ComponentModel.ISupportInitialize).BeginInit()
        CType(loadingAnimation, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RFIDAnimation, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(minimize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        TextBox1.Location = New Point(-344, -730)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(154, 31)
        TextBox1.TabIndex = 4
        ' 
        ' scannerContainer
        ' 
        scannerContainer.BackColor = Color.WhiteSmoke
        scannerContainer.BorderStyle = BorderStyle.FixedSingle
        scannerContainer.Controls.Add(deniedNotif)
        scannerContainer.Controls.Add(loadingAnimation)
        scannerContainer.Controls.Add(PictureBox1)
        scannerContainer.Controls.Add(RFIDTxtBox)
        scannerContainer.Controls.Add(manualLoginLink)
        scannerContainer.Controls.Add(Label3)
        scannerContainer.Controls.Add(RFIDAnimation)
        scannerContainer.Controls.Add(Label2)
        scannerContainer.Location = New Point(90, 87)
        scannerContainer.Margin = New Padding(0)
        scannerContainer.Name = "scannerContainer"
        scannerContainer.Size = New Size(498, 687)
        scannerContainer.TabIndex = 8
        ' 
        ' deniedNotif
        ' 
        deniedNotif.BackColor = Color.Transparent
        deniedNotif.Image = My.Resources.Resources.denied1
        deniedNotif.Location = New Point(104, 277)
        deniedNotif.Margin = New Padding(4, 5, 4, 5)
        deniedNotif.Name = "deniedNotif"
        deniedNotif.Size = New Size(287, 303)
        deniedNotif.SizeMode = PictureBoxSizeMode.Zoom
        deniedNotif.TabIndex = 16
        deniedNotif.TabStop = False
        deniedNotif.Visible = False
        ' 
        ' loadingAnimation
        ' 
        loadingAnimation.BackColor = Color.Transparent
        loadingAnimation.Image = My.Resources.Resources.loading_unscreen
        loadingAnimation.Location = New Point(104, 277)
        loadingAnimation.Margin = New Padding(4, 5, 4, 5)
        loadingAnimation.Name = "loadingAnimation"
        loadingAnimation.Size = New Size(287, 303)
        loadingAnimation.SizeMode = PictureBoxSizeMode.Zoom
        loadingAnimation.TabIndex = 15
        loadingAnimation.TabStop = False
        loadingAnimation.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = My.Resources.Resources.gagecdm1
        PictureBox1.Location = New Point(171, 27)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' RFIDTxtBox
        ' 
        RFIDTxtBox.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RFIDTxtBox.Location = New Point(-286, 118)
        RFIDTxtBox.Margin = New Padding(4, 5, 4, 5)
        RFIDTxtBox.Name = "RFIDTxtBox"
        RFIDTxtBox.Size = New Size(141, 29)
        RFIDTxtBox.TabIndex = 13
        ' 
        ' manualLoginLink
        ' 
        manualLoginLink.AutoSize = True
        manualLoginLink.BackColor = Color.Transparent
        manualLoginLink.Cursor = Cursors.Hand
        manualLoginLink.Font = New Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        manualLoginLink.Location = New Point(293, 607)
        manualLoginLink.Margin = New Padding(4, 0, 4, 0)
        manualLoginLink.Name = "manualLoginLink"
        manualLoginLink.Size = New Size(91, 24)
        manualLoginLink.TabIndex = 12
        manualLoginLink.TabStop = True
        manualLoginLink.Text = "Clck here!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(120, 607)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 24)
        Label3.TabIndex = 11
        Label3.Text = "Scanner won't work?"
        ' 
        ' RFIDAnimation
        ' 
        RFIDAnimation.Image = My.Resources.Resources.giphy
        RFIDAnimation.Location = New Point(104, 277)
        RFIDAnimation.Margin = New Padding(4, 5, 4, 5)
        RFIDAnimation.Name = "RFIDAnimation"
        RFIDAnimation.Size = New Size(287, 303)
        RFIDAnimation.SizeMode = PictureBoxSizeMode.Zoom
        RFIDAnimation.TabIndex = 10
        RFIDAnimation.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(120, 228)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 39)
        Label2.TabIndex = 9
        Label2.Text = "TAP RFID TO LOGIN"
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Image = My.Resources.Resources.xButton_removebg_preview1
        closeBtn.Location = New Point(647, 7)
        closeBtn.Margin = New Padding(4, 5, 4, 5)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(33, 42)
        closeBtn.SizeMode = PictureBoxSizeMode.Zoom
        closeBtn.TabIndex = 9
        closeBtn.TabStop = False
        ' 
        ' minimize
        ' 
        minimize.BackColor = Color.Transparent
        minimize.Cursor = Cursors.Hand
        minimize.Image = My.Resources.Resources.minimize_removebg_preview
        minimize.Location = New Point(606, 7)
        minimize.Margin = New Padding(4, 5, 4, 5)
        minimize.Name = "minimize"
        minimize.Size = New Size(33, 42)
        minimize.SizeMode = PictureBoxSizeMode.Zoom
        minimize.TabIndex = 10
        minimize.TabStop = False
        ' 
        ' RFIDLogin
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(686, 873)
        Controls.Add(minimize)
        Controls.Add(closeBtn)
        Controls.Add(scannerContainer)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "RFIDLogin"
        Padding = New Padding(14, 17, 14, 17)
        StartPosition = FormStartPosition.CenterScreen
        Text = "RFID"
        scannerContainer.ResumeLayout(False)
        scannerContainer.PerformLayout()
        CType(deniedNotif, ComponentModel.ISupportInitialize).EndInit()
        CType(loadingAnimation, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(RFIDAnimation, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(minimize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents scannerContainer As Panel
    Friend WithEvents manualLoginLink As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents RFIDAnimation As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RFIDTxtBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents loadingAnimation As PictureBox
    Friend WithEvents deniedNotif As PictureBox

End Class
