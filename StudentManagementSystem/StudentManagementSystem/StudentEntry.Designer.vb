<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEntry
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StudentEntry))
        Panel1 = New Panel()
        Button5 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        txtsection = New TextBox()
        Label12 = New Label()
        cbyear = New ComboBox()
        cbprogram = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        txtstudid = New TextBox()
        Label9 = New Label()
        btndelete = New Button()
        btnsave = New Button()
        btnnew = New Button()
        btnupddate = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        txtmname = New TextBox()
        cbgender = New ComboBox()
        Label8 = New Label()
        dtbirth = New DateTimePicker()
        txtfname = New TextBox()
        Label5 = New Label()
        txtaddress = New TextBox()
        txtlname = New TextBox()
        Label13 = New Label()
        txtemail = New TextBox()
        GroupBox2 = New GroupBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Linen
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1398, 75)
        Panel1.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(1348, 23)
        Button5.Name = "Button5"
        Button5.Size = New Size(37, 33)
        Button5.TabIndex = 4
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(79, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(303, 33)
        Label1.TabIndex = 1
        Label1.Text = "Student Entry Form"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 72)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(txtsection)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(cbyear)
        GroupBox1.Controls.Add(cbprogram)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtstudid)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(712, 141)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(629, 583)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "School Info"
        ' 
        ' txtsection
        ' 
        txtsection.BorderStyle = BorderStyle.FixedSingle
        txtsection.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtsection.Location = New Point(163, 110)
        txtsection.Name = "txtsection"
        txtsection.Size = New Size(334, 34)
        txtsection.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(44, 119)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 20)
        Label12.TabIndex = 20
        Label12.Text = "Section"
        ' 
        ' cbyear
        ' 
        cbyear.DropDownStyle = ComboBoxStyle.DropDownList
        cbyear.FlatStyle = FlatStyle.Flat
        cbyear.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbyear.FormattingEnabled = True
        cbyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cbyear.Location = New Point(163, 238)
        cbyear.Name = "cbyear"
        cbyear.Size = New Size(250, 32)
        cbyear.TabIndex = 19
        ' 
        ' cbprogram
        ' 
        cbprogram.DropDownStyle = ComboBoxStyle.DropDownList
        cbprogram.FlatStyle = FlatStyle.Flat
        cbprogram.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbprogram.FormattingEnabled = True
        cbprogram.Items.AddRange(New Object() {"BSCS", "BSIT", "BSIS"})
        cbprogram.Location = New Point(163, 175)
        cbprogram.Name = "cbprogram"
        cbprogram.Size = New Size(250, 32)
        cbprogram.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(44, 244)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 20)
        Label11.TabIndex = 18
        Label11.Text = "Year"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(44, 184)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 20)
        Label10.TabIndex = 17
        Label10.Text = "Program"
        ' 
        ' txtstudid
        ' 
        txtstudid.BorderStyle = BorderStyle.FixedSingle
        txtstudid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtstudid.Location = New Point(163, 54)
        txtstudid.Name = "txtstudid"
        txtstudid.Size = New Size(334, 34)
        txtstudid.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(44, 63)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 20)
        Label9.TabIndex = 16
        Label9.Text = "Student ID"
        ' 
        ' btndelete
        ' 
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Image = CType(resources.GetObject("btndelete.Image"), Image)
        btndelete.Location = New Point(712, 753)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(170, 59)
        btndelete.TabIndex = 22
        btndelete.Text = " Delete"
        btndelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnsave
        ' 
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Image = CType(resources.GetObject("btnsave.Image"), Image)
        btnsave.Location = New Point(212, 753)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(170, 59)
        btnsave.TabIndex = 24
        btnsave.Text = " Save"
        btnsave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' btnnew
        ' 
        btnnew.FlatStyle = FlatStyle.Popup
        btnnew.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnnew.Image = CType(resources.GetObject("btnnew.Image"), Image)
        btnnew.Location = New Point(955, 753)
        btnnew.Name = "btnnew"
        btnnew.Size = New Size(170, 59)
        btnnew.TabIndex = 25
        btnnew.Text = " New"
        btnnew.TextImageRelation = TextImageRelation.ImageBeforeText
        btnnew.UseVisualStyleBackColor = True
        ' 
        ' btnupddate
        ' 
        btnupddate.FlatStyle = FlatStyle.Popup
        btnupddate.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnupddate.Image = CType(resources.GetObject("btnupddate.Image"), Image)
        btnupddate.Location = New Point(456, 753)
        btnupddate.Name = "btnupddate"
        btnupddate.Size = New Size(170, 59)
        btnupddate.TabIndex = 26
        btnupddate.Text = " Update"
        btnupddate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnupddate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(42, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 20)
        Label3.TabIndex = 6
        Label3.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(42, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "Lastname"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(42, 516)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 11
        Label6.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(42, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 7
        Label4.Text = "Middlename"
        ' 
        ' txtmname
        ' 
        txtmname.BorderStyle = BorderStyle.FixedSingle
        txtmname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtmname.ForeColor = Color.Silver
        txtmname.Location = New Point(167, 178)
        txtmname.Name = "txtmname"
        txtmname.Size = New Size(334, 34)
        txtmname.TabIndex = 4
        txtmname.Text = "(optional)"
        ' 
        ' cbgender
        ' 
        cbgender.DropDownStyle = ComboBoxStyle.DropDownList
        cbgender.FlatStyle = FlatStyle.Flat
        cbgender.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbgender.FormattingEnabled = True
        cbgender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        cbgender.Location = New Point(167, 510)
        cbgender.Name = "cbgender"
        cbgender.Size = New Size(250, 32)
        cbgender.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(42, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 14
        Label8.Text = "Address"
        ' 
        ' dtbirth
        ' 
        dtbirth.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dtbirth.Format = DateTimePickerFormat.Short
        dtbirth.Location = New Point(167, 444)
        dtbirth.Name = "dtbirth"
        dtbirth.Size = New Size(250, 31)
        dtbirth.TabIndex = 8
        ' 
        ' txtfname
        ' 
        txtfname.BorderStyle = BorderStyle.FixedSingle
        txtfname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfname.Location = New Point(167, 118)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(334, 34)
        txtfname.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(42, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 9
        Label5.Text = "Birthday"
        ' 
        ' txtaddress
        ' 
        txtaddress.BorderStyle = BorderStyle.FixedSingle
        txtaddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtaddress.Location = New Point(167, 254)
        txtaddress.Multiline = True
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(334, 96)
        txtaddress.TabIndex = 15
        ' 
        ' txtlname
        ' 
        txtlname.BorderStyle = BorderStyle.FixedSingle
        txtlname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtlname.Location = New Point(167, 57)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(334, 34)
        txtlname.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(45, 379)
        Label13.Name = "Label13"
        Label13.Size = New Size(59, 20)
        Label13.TabIndex = 16
        Label13.Text = "Email"
        ' 
        ' txtemail
        ' 
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemail.Location = New Point(167, 370)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(334, 34)
        txtemail.TabIndex = 17
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(txtemail)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(txtlname)
        GroupBox2.Controls.Add(txtaddress)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtfname)
        GroupBox2.Controls.Add(dtbirth)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(cbgender)
        GroupBox2.Controls.Add(txtmname)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(52, 138)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(574, 586)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Personal Info"
        ' 
        ' StudentEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1397, 824)
        Controls.Add(btnupddate)
        Controls.Add(btndelete)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(btnnew)
        Controls.Add(btnsave)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentEntry"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbyear As ComboBox
    Friend WithEvents cbprogram As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtstudid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents btnupddate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents cbgender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
