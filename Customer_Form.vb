Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Public Class Customer_Form
    Dim cnoo As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\hp1\documents\Integrated Security=True;User Instance=True")
    Dim cmddd As New SqlCommand
    Dim dr As SqlDataAdapter
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged, TextBox9.TextChanged, TextBox8.TextChanged
        Label12.Text = Val(TextBox5.Text) + Val(TextBox7.Text)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Label12.Text = Val(TextBox7.Text) - Val(TextBox6.Text)
    End Sub

    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = Label12.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Fill Number Box")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Fill Name Box")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Fill cnic Box")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Fill address Box")
        Else
            Dim cmded As New SqlCommand
            cmded.Connection = cnoo
            cnoo.Open()
            cmded.CommandText = "insert into TC (Number,Name,Class,Address,Image) values (@Number,@Name,@Class,@Address,@Image)"
            cmded.Parameters.AddWithValue("@number", TextBox1.Text)
            cmded.Parameters.AddWithValue("@name", TextBox2.Text)
            cmded.Parameters.AddWithValue("@class", TextBox3.Text)
            cmded.Parameters.AddWithValue("@address", TextBox4.Text)
            cmded.ExecuteNonQuery()
            cnoo.Close()
            TextBox2.Text = ""
            TextBox2.Text = ""
            TextBox2.Text = ""
            TextBox2.Text = ""
            MessageBox.Show("Record  SAVED!")
        End If
        Else
        End If
    End Sub
End Class