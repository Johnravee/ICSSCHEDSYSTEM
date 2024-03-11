<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manualLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manualLogin))
        manualLoginContainer = New Panel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        RFIDTxtBox = New TextBox()
        Label1 = New Label()
        backBtn = New PictureBox()
        closeBtn = New PictureBox()
        minimize = New PictureBox()
        manualLoginContainer.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(backBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(minimize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' manualLoginContainer
        ' 
        manualLoginContainer.BackColor = Color.WhiteSmoke
        manualLoginContainer.BorderStyle = BorderStyle.FixedSingle
        manualLoginContainer.Controls.Add(Button1)
        manualLoginContainer.Controls.Add(PictureBox1)
        manualLoginContainer.Controls.Add(Panel2)
        manualLoginContainer.Controls.Add(Label1)
        manualLoginContainer.Location = New Point(49, 80)
        manualLoginContainer.Margin = New Padding(0)
        manualLoginContainer.Name = "manualLoginContainer"
        manualLoginContainer.Size = New Size(341, 367)
        manualLoginContainer.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(123, 270)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 41)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = My.Resources.Resources.gagecdm1
        PictureBox1.Location = New Point(123, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(RFIDTxtBox)
        Panel2.Location = New Point(37, 182)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(256, 47)
        Panel2.TabIndex = 1
        ' 
        ' RFIDTxtBox
        ' 
        RFIDTxtBox.BorderStyle = BorderStyle.None
        RFIDTxtBox.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RFIDTxtBox.Location = New Point(17, 13)
        RFIDTxtBox.Name = "RFIDTxtBox"
        RFIDTxtBox.Size = New Size(222, 20)
        RFIDTxtBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 23)
        Label1.TabIndex = 0
        Label1.Text = "RFID"
        ' 
        ' backBtn
        ' 
        backBtn.BackColor = Color.Transparent
        backBtn.Cursor = Cursors.Hand
        backBtn.Image = My.Resources.Resources.backBTN_removebg_preview1
        backBtn.Location = New Point(12, 12)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(54, 50)
        backBtn.SizeMode = PictureBoxSizeMode.Zoom
        backBtn.TabIndex = 7
        backBtn.TabStop = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Image = My.Resources.Resources.xButton_removebg_preview1
        closeBtn.Location = New Point(408, 2)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(23, 25)
        closeBtn.SizeMode = PictureBoxSizeMode.Zoom
        closeBtn.TabIndex = 10
        closeBtn.TabStop = False
        ' 
        ' minimize
        ' 
        minimize.BackColor = Color.Transparent
        minimize.Cursor = Cursors.Hand
        minimize.Image = My.Resources.Resources.minimize_removebg_preview
        minimize.Location = New Point(379, 2)
        minimize.Name = "minimize"
        minimize.Size = New Size(23, 25)
        minimize.SizeMode = PictureBoxSizeMode.Zoom
        minimize.TabIndex = 11
        minimize.TabStop = False
        ' 
        ' manualLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.darkgreenbg
        ClientSize = New Size(433, 504)
        Controls.Add(minimize)
        Controls.Add(closeBtn)
        Controls.Add(backBtn)
        Controls.Add(manualLoginContainer)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "manualLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        manualLoginContainer.ResumeLayout(False)
        manualLoginContainer.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(backBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(minimize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents manualLoginContainer As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RFIDTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimize As PictureBox
End Class
