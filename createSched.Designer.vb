<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createSched))
        Panel1 = New Panel()
        minimize = New PictureBox()
        closeBtn = New PictureBox()
        Label1 = New Label()
        backBtn = New PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        ComboBox3 = New ComboBox()
        Label3 = New Label()
        ComboBox4 = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox5 = New ComboBox()
        Label6 = New Label()
        ComboBox6 = New ComboBox()
        Label7 = New Label()
        Button1 = New Button()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(minimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(backBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.darkgreenbg
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(minimize)
        Panel1.Controls.Add(closeBtn)
        Panel1.Location = New Point(534, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(497, 603)
        Panel1.TabIndex = 0
        ' 
        ' minimize
        ' 
        minimize.BackColor = Color.Transparent
        minimize.Cursor = Cursors.Hand
        minimize.Image = My.Resources.Resources.minimize_removebg_preview
        minimize.Location = New Point(438, 11)
        minimize.Margin = New Padding(0)
        minimize.Name = "minimize"
        minimize.Size = New Size(23, 25)
        minimize.SizeMode = PictureBoxSizeMode.Zoom
        minimize.TabIndex = 13
        minimize.TabStop = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Image = My.Resources.Resources.xButton_removebg_preview1
        closeBtn.Location = New Point(461, 11)
        closeBtn.Margin = New Padding(0)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(23, 25)
        closeBtn.SizeMode = PictureBoxSizeMode.Zoom
        closeBtn.TabIndex = 12
        closeBtn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(81, 97)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 23)
        Label1.TabIndex = 2
        Label1.Text = "INSTRUCTOR NAME"
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
        backBtn.TabIndex = 8
        backBtn.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.Items.AddRange(New Object() {"Jhep", "Kalaw", "Lamadora", "Bruhh", "Galgo", "Jhep", "Kalaw", "Lamadora", "Bruhh", "Galgo"})
        ComboBox1.Location = New Point(81, 123)
        ComboBox1.MaxDropDownItems = 5
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(373, 27)
        ComboBox1.TabIndex = 9
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.Items.AddRange(New Object() {"BSIT-2D", "BSIT-2F"})
        ComboBox2.Location = New Point(81, 202)
        ComboBox2.MaxDropDownItems = 5
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(373, 27)
        ComboBox2.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(81, 176)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 10
        Label2.Text = "SECTION"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.IntegralHeight = False
        ComboBox3.Items.AddRange(New Object() {"PROG 3", "ETHICS", "ACSS", "SSDEV", "IT ELEC 2", "IPTECH"})
        ComboBox3.Location = New Point(81, 283)
        ComboBox3.MaxDropDownItems = 5
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(373, 27)
        ComboBox3.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(81, 257)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 23)
        Label3.TabIndex = 12
        Label3.Text = "SUBJECT"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        ComboBox4.Location = New Point(81, 369)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(138, 27)
        ComboBox4.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(81, 343)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 23)
        Label4.TabIndex = 14
        Label4.Text = "DAY"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(316, 343)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 23)
        Label5.TabIndex = 16
        Label5.Text = "TIME"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(316, 369)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(138, 23)
        DateTimePicker1.TabIndex = 17
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox5.FormattingEnabled = True
        ComboBox5.IntegralHeight = False
        ComboBox5.Location = New Point(81, 453)
        ComboBox5.MaxDropDownItems = 5
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(138, 27)
        ComboBox5.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(81, 427)
        Label6.Margin = New Padding(0)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 23)
        Label6.TabIndex = 18
        Label6.Text = "ROOM"
        ' 
        ' ComboBox6
        ' 
        ComboBox6.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Old", "New"})
        ComboBox6.Location = New Point(316, 453)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(138, 27)
        ComboBox6.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(316, 427)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 23)
        Label7.TabIndex = 20
        Label7.Text = "BUILDING"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.darkgreenbg
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(316, 535)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 44)
        Button1.TabIndex = 22
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(190, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 39)
        Label8.TabIndex = 14
        Label8.Text = "FACILITIES"
        ' 
        ' createSched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1027, 599)
        Controls.Add(Button1)
        Controls.Add(ComboBox6)
        Controls.Add(Label7)
        Controls.Add(ComboBox5)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(ComboBox4)
        Controls.Add(Label4)
        Controls.Add(ComboBox3)
        Controls.Add(Label3)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(backBtn)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "createSched"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CREATE SCHEDULES"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(minimize, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(backBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents backBtn As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
