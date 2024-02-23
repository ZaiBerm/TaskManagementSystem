Imports MySql.Data.MySqlClient

Public Class Form5

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Public Property onlineUser As String
    Public Property userId As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "INSERT INTO personaltask_tbl (UserID, TaskName, TaskCategory, TaskStatus) VALUES
                                (@UserID, @TaskName, @TaskCategory, @TaskStatus)"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@TaskName", Guna2TextBox1.Text)
                cmd.Parameters.AddWithValue("@TaskCategory", Guna2ComboBox1.SelectedItem)
                cmd.Parameters.AddWithValue("@TaskStatus", "Pending")

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()
            MessageBox.Show("New Task Added!")
            Close()

        End Using

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Close()
    End Sub
End Class