Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Hide()
        Form2.ShowDialog()
        Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM user_tbl WHERE Username = @Username"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)
                cmd.Parameters.AddWithValue("@Username", Guna2TextBox1.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    If Guna2TextBox2.Text <> reader("UPassword").ToString() Then
                        MessageBox.Show("Wrong Password!")
                    Else

                        Dim frm3 As New Form3
                        frm3.onlineUser = Guna2TextBox1.Text
                        Hide()
                        frm3.ShowDialog()
                        Show()


                    End If

                End While

            End Using

            conn.Close()

        End Using

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2TextBox2.PasswordChar = "*" Then
            Guna2TextBox2.PasswordChar = ""
        Else
            Guna2TextBox2.PasswordChar = "*"
        End If

    End Sub

End Class
