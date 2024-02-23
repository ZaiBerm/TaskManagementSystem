Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Close()
        Form1.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2TextBox5.PasswordChar = "*" Then
            Guna2TextBox5.PasswordChar = ""
        Else
            Guna2TextBox5.PasswordChar = "*"
        End If


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Dim img As Image = PictureBox1.Image
        Dim imgData() As Byte

        Using mem As New MemoryStream()
            img.Save(mem, img.RawFormat)
            imgData = mem.ToArray()
        End Using


        Using conn As New MySqlConnection()
            conn.ConnectionString = connectionString

            Dim qry As String = "INSERT INTO user_tbl (FirstName, LastName, Email, Username, UPassword, ImageData, UserFriends)
                                VALUES (@FirstName, @LastName, @Email, @Username, @UPassword, @ImageData, @UserFriends)"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@FirstName", Guna2TextBox1.Text)
                cmd.Parameters.AddWithValue("@LastName", Guna2TextBox2.Text)
                cmd.Parameters.AddWithValue("@Email", Guna2TextBox3.Text)
                cmd.Parameters.AddWithValue("@Username", Guna2TextBox4.Text)
                cmd.Parameters.AddWithValue("@UPassword", Guna2TextBox5.Text)
                cmd.Parameters.Add("@ImageData", MySqlDbType.LongBlob).Value = imgData
                cmd.Parameters.AddWithValue("@UserFriends", "^")

                cmd.ExecuteNonQuery()

                MessageBox.Show("Successfully Created!")
                Controls.Clear()
                InitializeComponent()

            End Using

            conn.Close()

        End Using
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim ofd As New OpenFileDialog()

        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Close()
    End Sub
End Class