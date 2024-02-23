Imports System.IO
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Form4

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Public Property onlineUser As String
    Public Property userId As Integer

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        FlowLayoutPanel1.Controls.Clear()

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM user_tbl WHERE Username = @Username AND UID = @UID"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@Username", Guna2TextBox1.Text)
                cmd.Parameters.AddWithValue("@UID", Val(Guna2TextBox2.Text))
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read

                    Dim imageData As Byte() = DirectCast(reader("ImageData"), Byte())
                    Dim Img As Image

                    Using mem As New MemoryStream(imageData)
                        Img = Image.FromStream(mem)
                    End Using

                    If Guna2TextBox1.Text = reader("Username").ToString() Then

                        Dim panel As New Panel()
                        panel.Width = 400
                        panel.Height = 110
                        panel.BackColor = Color.White
                        panel.BorderStyle = BorderStyle.FixedSingle
                        panel.Tag = Val(reader("UID")).ToString()
                        FlowLayoutPanel1.Controls.Add(panel)

                        Dim dp As New Guna2CirclePictureBox()
                        dp.Width = 80
                        dp.Height = 80
                        dp.SizeMode = PictureBoxSizeMode.StretchImage
                        dp.Location = New Point(20, 15)
                        dp.Image = Img
                        panel.Controls.Add(dp)

                        Dim label As New Label()
                        label.Font = New Font("Arial Rounded MT Bold", 16, FontStyle.Regular)
                        label.Text = reader("FirstName").ToString() + " " + reader("LastName").ToString()
                        label.Location = New Point(115, 17)
                        label.AutoSize = True
                        panel.Controls.Add(label)

                        Dim button As New Guna2CircleButton()
                        button.Width = 65
                        button.Height = 65
                        button.FillColor = Color.DarkGray
                        button.Location = New Point(310, 18)
                        button.Text = "+"
                        button.Font = New Font("Arial Rounded MT Bold", 30, FontStyle.Regular)
                        button.BringToFront()
                        AddHandler button.Click, AddressOf add_friend
                        panel.Controls.Add(button)

                    End If

                End While

            End Using
        End Using


    End Sub

    Private Sub add_friend(sender As Object, e As EventArgs)

        Dim clicked As Guna2CircleButton = DirectCast(sender, Guna2CircleButton)

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "UPDATE user_tbl SET UserFriends = CONCAT(UserFriends, @Friend) WHERE Username = @Username"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@Friend", "," + clicked.Parent.Tag)
                cmd.Parameters.AddWithValue("Username", onlineUser)

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()

        End Using

        Using conn1 As New MySqlConnection(connectionString)

            Dim qry1 As String = "UPDATE user_tbl SET UserFriends = CONCAT(UserFriends, @Friend) WHERE UID = @UID"

            conn1.Open()

            Using cmd1 As New MySqlCommand(qry1, conn1)

                cmd1.Parameters.AddWithValue("@UID", Val(clicked.Parent.Tag))
                cmd1.Parameters.AddWithValue("@Friend", "," + userId.ToString())

                cmd1.ExecuteNonQuery()

            End Using

            conn1.Close()

        End Using


        MessageBox.Show("Added Successfully!")
        clicked = DirectCast(sender, Guna2CircleButton)
        clicked.Enabled = False
        clicked.Visible = False
        Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class