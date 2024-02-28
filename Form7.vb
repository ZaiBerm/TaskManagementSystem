Imports MySql.Data.MySqlClient

Public Class Form7

    Public Property onlineUser As String
    Public Property userId As Integer

    Public Property groupID As Integer
    Public Property groupOwnerID As Integer

    Dim groupMembers As New List(Of Integer)

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub load_member()

        FlowLayoutPanel1.Controls.Clear()

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM group_tbl WHERE GroupID = @GroupID"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@GroupID", groupID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Dim memberString = reader("GroupMembers").ToString()
                    Dim membersArray As New List(Of String)(Split(memberString))

                    For Each member In membersArray

                        groupMembers.Add(Val(member))

                    Next

                End While

                reader.Close()

            End Using

            conn.Close()

        End Using



    End Sub

End Class