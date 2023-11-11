<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtun = New TextBox()
        Label3 = New Label()
        txtpw = New TextBox()
        logprof = New Button()
        LinkLabel1 = New LinkLabel()
        btnadmin = New Button()
        CheckBox2 = New CheckBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, -11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(754, 71)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(704, 23)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 33)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(661, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 33)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 33)
        Label1.TabIndex = 1
        Label1.Text = "Student Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(55, 52)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(213, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 20)
        Label2.TabIndex = 1
        Label2.Text = "Email / Username"
        ' 
        ' txtun
        ' 
        txtun.BorderStyle = BorderStyle.FixedSingle
        txtun.Location = New Point(213, 267)
        txtun.Multiline = True
        txtun.Name = "txtun"
        txtun.Size = New Size(318, 30)
        txtun.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(213, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' txtpw
        ' 
        txtpw.BorderStyle = BorderStyle.FixedSingle
        txtpw.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtpw.Location = New Point(213, 359)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(318, 30)
        txtpw.TabIndex = 6
        txtpw.UseSystemPasswordChar = True
        ' 
        ' logprof
        ' 
        logprof.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        logprof.Image = CType(resources.GetObject("logprof.Image"), Image)
        logprof.ImageAlign = ContentAlignment.MiddleLeft
        logprof.Location = New Point(298, 421)
        logprof.Name = "logprof"
        logprof.Size = New Size(154, 46)
        logprof.TabIndex = 7
        logprof.Text = "  Log In " & vbCrLf
        logprof.TextImageRelation = TextImageRelation.ImageBeforeText
        logprof.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Transparent
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Red
        LinkLabel1.Location = New Point(340, 470)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(70, 23)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign Up"
        ' 
        ' btnadmin
        ' 
        btnadmin.BackColor = Color.Transparent
        btnadmin.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnadmin.Image = CType(resources.GetObject("btnadmin.Image"), Image)
        btnadmin.ImageAlign = ContentAlignment.MiddleLeft
        btnadmin.Location = New Point(298, 688)
        btnadmin.Name = "btnadmin"
        btnadmin.Size = New Size(154, 46)
        btnadmin.TabIndex = 9
        btnadmin.Text = " Log In As  Admin"
        btnadmin.TextAlign = ContentAlignment.TopCenter
        btnadmin.TextImageRelation = TextImageRelation.ImageBeforeText
        btnadmin.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(213, 393)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(147, 22)
        CheckBox2.TabIndex = 10
        CheckBox2.Text = "Show Password"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(753, 746)
        Controls.Add(CheckBox2)
        Controls.Add(btnadmin)
        Controls.Add(LinkLabel1)
        Controls.Add(txtpw)
        Controls.Add(Label3)
        Controls.Add(txtun)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(logprof)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtun As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpw As TextBox
    Friend WithEvents logprof As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnadmin As Button
    Friend WithEvents CheckBox2 As CheckBox
End Class
