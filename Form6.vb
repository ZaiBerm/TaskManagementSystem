Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Form6

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"
    Dim groupConnectionString = "server=127.0.0.1; port=3306; database=tms_groups_db; uid=root; password=QZr8408o;"

    Public Property onlineUser As String
    Public Property userId As Integer
    Dim userFriend As New List(Of Integer)


    Dim groupMembers As New List(Of Integer)

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT UserFriends FROM user_tbl WHERE UID = @UID"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@UID", userId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Dim friendString As String = reader("UserFriends").ToString()
                    Dim friendArray As New List(Of String)(Split(friendString, ","))
                    friendArray.RemoveAt(0)

                    For Each fren In friendArray
                        userFriend.Add(Val(fren))
                    Next

                End While

                reader.Close()

            End Using

            conn.Close()

        End Using

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM user_tbl WHERE UID = @UID"

            conn.Open()

            For Each frens In userFriend

                Using cmd As New MySqlCommand(qry, conn)

                    cmd.Parameters.AddWithValue("@UID", frens)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read()

                        Dim pnl As New Guna2Panel()
                        pnl.Width = 276
                        pnl.Height = 60
                        pnl.FillColor = Form3.Guna2Panel4.FillColor
                        pnl.BorderRadius = 10
                        pnl.BorderStyle = Drawing2D.DashStyle.Solid
                        pnl.BorderColor = Color.DimGray
                        pnl.BorderThickness = 1
                        pnl.Tag = frens
                        FlowLayoutPanel1.Controls.Add(pnl)

                        Dim dp As New Guna2CirclePictureBox()
                        dp.Width = 40
                        dp.Height = 40
                        dp.SizeMode = PictureBoxSizeMode.StretchImage
                        dp.Image = globalFunctions.ToImage(DirectCast(reader("ImageData"), Byte()))
                        dp.Location = New Point(13, 12)
                        pnl.Controls.Add(dp)

                        Dim name As New Label()
                        name.Text = reader("FirstName").ToString() + " " + reader("LastName").ToString()
                        name.AutoSize = True
                        name.Font = New Font("Arial Rounded MT Bold", 14, FontStyle.Regular)
                        name.ForeColor = Color.White
                        name.Location = New Point(60, 18)
                        pnl.Controls.Add(name)

                        Dim btn As New Guna2CircleButton()
                        btn.Height = 38
                        btn.Width = 38
                        btn.Text = "+"
                        btn.Font = New Font("Arial Rounded MT Bold", 20, FontStyle.Regular)
                        btn.FillColor = Color.WhiteSmoke
                        btn.ForeColor = Color.DimGray
                        btn.Location = New Point(220, 12)
                        AddHandler btn.Click, AddressOf addMember
                        pnl.Controls.Add(btn)

                    End While

                    reader.Close()

                End Using

            Next

        End Using

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Using conn As New MySqlConnection(groupConnectionString)

            Dim qry As String = "CREATE TABLE " + Guna2TextBox1.Text + "_task(
	                                TaskID Int primary key auto_increment,
                                    AssignedUserID Int Not null,
                                    TaskName varchar(3000) Not null,
                                    DueDate DateTime
                                );"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()

        End Using

        Using conn As New MySqlConnection(groupConnectionString)

            Dim qry As String = "CREATE TABLE " + Guna2TextBox1.Text + "_chat(
                                Message varchar(5000),
                                UserID int not null,
                                MessageDate varchar(80) not null
                            )"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()

        End Using

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "INSERT INTO group_tbl (GroupName, GroupOwner, GroupOwnerID, GroupMembers, DateCreated) VALUES
                                (@GroupName, @GroupOwner, @GroupOwnerID, @GroupMembers, @DateCreated)"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@GroupName", Guna2TextBox1.Text)
                cmd.Parameters.AddWithValue("@GroupOwner", onlineUser)
                cmd.Parameters.AddWithValue("@GroupOwnerID", userId)
                cmd.Parameters.AddWithValue("@GroupMembers", String.Join(",", groupMembers))
                cmd.Parameters.AddWithValue("@DateCreated", DateAndTime.Now.ToString("D"))

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()

        End Using

        MessageBox.Show("Group Successfully Created!")

        Close()

    End Sub

    Private Sub addMember(sender As Object, e As EventArgs)

        Dim pressedButton As Guna2CircleButton = DirectCast(sender, Guna2CircleButton)


        If pressedButton.Parent.Parent.Name = "FlowLayoutPanel1" Then
            groupMembers.Add(pressedButton.Parent.Tag)
            FlowLayoutPanel1.Controls.RemoveAt(FlowLayoutPanel1.Controls.IndexOf(pressedButton.Parent))
            FlowLayoutPanel2.Controls.Add(pressedButton.Parent)
            pressedButton.Text = "-"
        Else
            groupMembers.RemoveAt(FlowLayoutPanel2.Controls.IndexOf(pressedButton.Parent))
            FlowLayoutPanel2.Controls.RemoveAt(FlowLayoutPanel2.Controls.IndexOf(pressedButton.Parent))
            FlowLayoutPanel1.Controls.Add(pressedButton.Parent)
            pressedButton.Text = "+"
        End If


    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Close()
    End Sub
End Class