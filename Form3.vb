Imports System.Diagnostics.Eventing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form3

    Public Property onlineUser As String
    Public Property userId As Integer

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FriendListNum As New List(Of Integer)

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM user_tbl WHERE Username = @Username"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@Username", onlineUser)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Label1.Text = reader("FirstName").ToString() + " " + reader("LastName").ToString()
                    userId = reader("UID")
                    Label2.Text = "UID: " + userId.ToString()

                    Dim imageData As Byte() = DirectCast(reader("ImageData"), Byte())

                    Using mem As New MemoryStream(imageData)
                        Guna2CirclePictureBox1.Image = Image.FromStream(mem)
                    End Using

                End While

                reader.Close()

            End Using

            conn.Close()


            conn.Open()

            Dim qry1 As String = "SELECT UserFriends FROM user_tbl WHERE Username = @Username"

            Using cmd1 As New MySqlCommand(qry1, conn)

                cmd1.Parameters.AddWithValue("@Username", onlineUser)

                Dim reader1 As MySqlDataReader = cmd1.ExecuteReader()

                While reader1.Read()

                    Dim Friends As String = reader1("UserFriends").ToString()
                    Dim FriendList As New List(Of String)(Split(Friends, ","))
                    FriendList.RemoveAt(0)

                    For Each afriend As String In FriendList
                        FriendListNum.Add(Val(afriend))
                    Next

                End While

                reader1.Close()

            End Using

            conn.Close()


            conn.Open()

            Dim query As String = "SELECT UserFriends FROM user_tbl WHERE UID = @UID"

            For Each xfriend In FriendListNum

                Using command As New MySqlCommand(query, conn)

                    command.Parameters.AddWithValue("@UID", xfriend)

                    Dim Reader As MySqlDataReader = command.ExecuteReader()

                    While Reader.Read()

                        Dim pnl As New Panel()
                        pnl.Width = 345
                        pnl.Height = 80
                        pnl.BackColor = Color.Red
                        pnl.Tag = xfriend
                        FlowLayoutPanel1.Controls.Add(pnl)

                    End While

                    Reader.Close()

                End Using

            Next

            conn.Close()




        End Using

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm4 As New Form4
        frm4.onlineUser = onlineUser
        frm4.userId = userId
        frm4.ShowDialog()
    End Sub

End Class