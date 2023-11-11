Imports MySql.Data.MySqlClient

Public Class StudentEntry
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        studrecord.Show()
        Me.Dispose()
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim today As String = DateTime.Now.ToShortDateString
        If txtlname.Text.Equals("") OrElse txtfname.Text.Equals("") OrElse txtaddress.Text.Equals("") OrElse txtstudid.Text.Equals("") OrElse cbgender.Text.Equals("") OrElse cbyear.Text.Equals("") OrElse cbprogram.Text.Equals("") OrElse txtemail.Text.Equals("") OrElse txtsection.Text.Equals("") Then
            MsgBox("Missing field required", vbInformation)
            Return
        ElseIf dtbirth.Text.Equals(today) Then
            MsgBox("Birthday must not be today", vbInformation)

        Else
            cn.Open()
            cm = New MySqlCommand("insert into tbleinfo (studentID, lastname, firstname, middlename,birthday ,gender, year, section, program, email, address) values (@studentid,@lname,@nname,@mname,@bday,@gender,@year,@section,@program,@email,@address)", cn)
            With cm.Parameters
                .AddWithValue("@studentID", txtstudid.Text)
                .AddWithValue("@lname", txtlname.Text)
                .AddWithValue("@nname", txtfname.Text)
                .AddWithValue("@mname", txtmname.Text)
                .AddWithValue("@bday", dtbirth.Text.ToString)
                .AddWithValue("@gender", cbgender.Text)
                .AddWithValue("@year", cbyear.Text)
                .AddWithValue("@section", txtsection.Text)
                .AddWithValue("@program", cbprogram.Text)
                .AddWithValue("@email", txtemail.Text)
                .AddWithValue("@address", txtaddress.Text)
            End With
            cm.ExecuteNonQuery()
            MessageBox.Show("Data successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
        End If



    End Sub
    Private Sub StudentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtmname_Enter(sender As Object, e As EventArgs) Handles txtmname.Enter
        If txtmname.Text.Equals("(optional)") Then
            txtmname.Text = ""
            txtmname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtmname_Leave(sender As Object, e As EventArgs) Handles txtmname.Leave
        If txtmname.Text.Equals("") Then
            txtmname.Text = "(optional)"
            txtmname.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnupddate_Click(sender As Object, e As EventArgs) Handles btnupddate.Click
        Dim today As String = DateTime.Now.ToShortDateString
        MsgBox(today)
    End Sub
End Class
