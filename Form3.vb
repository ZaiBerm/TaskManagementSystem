Imports System.Diagnostics.Eventing
Imports System.IO
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Public Class Form3

    Public Property onlineUser As String
    Public Property userId As Integer

    Dim connectionString = "server=127.0.0.1; port=3306; database=tms_db; uid=root; password=QZr8408o;"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        End Using

        loadFriends()
        loadGroups()
        loadPersonalTask()

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Close()
        Form1.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim frm5 As New Form5()
        frm5.onlineUser = onlineUser
        frm5.userId = userId

        frm5.ShowDialog()
        loadPersonalTask()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm4 As New Form4()
        frm4.onlineUser = onlineUser
        frm4.userId = userId

        frm4.ShowDialog()
        loadFriends()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim frm6 As New Form6()
        frm6.onlineUser = onlineUser
        frm6.userId = userId

        Hide()
        frm6.ShowDialog()
        Show()
    End Sub

    Private Sub load_form3()
        loadFriends()
        loadPersonalTask()
    End Sub

    Private Sub loadFriends()

        FlowLayoutPanel1.Controls.Clear()

        Dim FriendListNum As New List(Of Integer)

        Using conn As New MySqlConnection(connectionString)

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

            Dim query As String = "SELECT * FROM user_tbl WHERE UID = @UID"

            For Each xfriend In FriendListNum

                Using command As New MySqlCommand(query, conn)

                    command.Parameters.AddWithValue("@UID", xfriend)

                    Dim Reader As MySqlDataReader = command.ExecuteReader()

                    While Reader.Read()

                        Dim pnl As New Guna2Panel()
                        pnl.Width = 345
                        pnl.Height = 80
                        pnl.FillColor = Guna2Panel4.FillColor
                        pnl.BorderRadius = 10
                        pnl.BorderStyle = Drawing2D.DashStyle.Solid
                        pnl.BorderColor = Color.DimGray
                        pnl.BorderThickness = 1
                        pnl.Tag = xfriend
                        FlowLayoutPanel1.Controls.Add(pnl)

                        Dim dp As New Guna2CirclePictureBox()
                        dp.Width = 60
                        dp.Height = 60
                        dp.SizeMode = PictureBoxSizeMode.StretchImage
                        dp.Image = globalFunctions.ToImage(DirectCast(Reader("ImageData"), Byte()))
                        dp.Location = New Point(13, 9)
                        pnl.Controls.Add(dp)

                        Dim name As New Label()
                        name.Text = Reader("FirstName").ToString() + " " + Reader("LastName").ToString()
                        name.AutoSize = True
                        name.Font = New Font("Arial Rounded MT Bold", 18, FontStyle.Regular)
                        name.ForeColor = Color.White
                        name.Location = New Point(80, 21)
                        pnl.Controls.Add(name)

                    End While

                    Reader.Close()

                End Using

            Next

            conn.Close()

        End Using

    End Sub

    Private Sub loadPersonalTask()

        FlowLayoutPanel2.Controls.Clear()

        Using con As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM personaltask_tbl WHERE userID = @userID"

            con.Open()

            Using cmd As New MySqlCommand(qry, con)

                cmd.Parameters.AddWithValue("@userID", userId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Dim pnl As New Guna2Panel()
                    pnl.Width = 431
                    pnl.Height = 100
                    pnl.Tag = Val(reader("TaskID"))
                    pnl.FillColor = Color.White
                    pnl.BorderRadius = 10
                    pnl.BorderThickness = 1
                    pnl.BorderColor = Color.Purple
                    FlowLayoutPanel2.Controls.Add(pnl)

                    Dim pnl1 As New Panel()
                    pnl1.Width = 316
                    pnl1.Height = 60
                    pnl1.AutoScroll = True
                    pnl1.Location = New Point(10, 10)
                    pnl.Controls.Add(pnl1)

                    Dim lbl1 As New Label()
                    lbl1.Text = reader("TaskName").ToString()
                    lbl1.Font = New Font("Arial Rounded MT Bold", 18, FontStyle.Regular)
                    lbl1.ForeColor = Color.Purple()
                    lbl1.Width = 316
                    lbl1.AutoSize = True
                    lbl1.SendToBack()
                    pnl1.Controls.Add(lbl1)

                    Dim lbl2 As New Label()
                    lbl2.Text = reader("TaskCategory").ToString()
                    lbl2.Font = New Font("Arial Rounded MT Bold", 16, FontStyle.Regular)
                    lbl2.ForeColor = Color.Gray()
                    lbl2.Location = New Point(10, 68)
                    lbl2.Width = 231
                    lbl2.Height = 60
                    lbl2.BringToFront()
                    pnl.Controls.Add(lbl2)

                    Dim chk As New Guna2CustomCheckBox()
                    chk.Height = 60
                    chk.Width = 60
                    chk.Location = New Point(356, 20)
                    AddHandler chk.CheckedChanged, AddressOf delete_personal_task
                    pnl.Controls.Add(chk)

                End While

            End Using

            con.Close()

        End Using

    End Sub

    Private Sub loadGroups()

        FlowLayoutPanel3.Controls.Clear()

        Dim Groups As New List(Of Integer)
        Dim GroupOwnerID As New List(Of Integer)

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT GroupOwnerID, GroupID, GroupMembers FROM group_tbl"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Dim memberString As String = reader("GroupMembers").ToString
                    Dim membersArray As New List(Of String)(Split(memberString, ","))

                    For Each member In membersArray
                        If reader("GroupOwnerID") = userId Then
                            Groups.Add(Val(reader("GroupID")))
                            Exit For
                        ElseIf member = userId Then
                            Groups.Add(Val(reader("GroupID")))
                        End If
                    Next

                End While

                reader.Close()

            End Using

            conn.Close()

        End Using

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "SELECT * FROM group_tbl WHERE GroupID = @GroupID"

            conn.Open()

            For Each group In Groups

                Using cmd As New MySqlCommand(qry, conn)

                    cmd.Parameters.AddWithValue("@GroupID", group)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        Dim pnl As New Guna2Panel()
                        pnl.Width = 440
                        pnl.Height = 80
                        pnl.FillColor = Guna2Panel4.FillColor
                        pnl.BorderRadius = 10
                        pnl.BorderStyle = Drawing2D.DashStyle.Solid
                        pnl.BorderColor = Color.DimGray
                        pnl.BorderThickness = 1
                        pnl.Tag = group
                        FlowLayoutPanel3.Controls.Add(pnl)

                        Dim name As New Label()
                        name.Text = reader("GroupName").ToString()
                        name.Width = 440
                        name.Height = 80
                        name.Font = New Font("Arial Rounded MT Bold", 18, FontStyle.Regular)
                        name.ForeColor = Color.White
                        name.Location = New Point(10, 21)
                        AddHandler name.Click, AddressOf open_group
                        pnl.Controls.Add(name)

                    End While

                    reader.Close()

                End Using

            Next

            conn.Close()

        End Using

    End Sub

    Private Sub delete_personal_task(sender As Object, e As EventArgs)

        Dim checkbox As Guna2CustomCheckBox = DirectCast(sender, Guna2CustomCheckBox)

        Using conn As New MySqlConnection(connectionString)

            Dim qry As String = "DELETE FROM personaltask_tbl WHERE TaskID = @TaskID"

            conn.Open()

            Using cmd As New MySqlCommand(qry, conn)

                cmd.Parameters.AddWithValue("@TaskID", Val(checkbox.Parent.Tag))

                cmd.ExecuteNonQuery()

            End Using

            conn.Close()

        End Using

        FlowLayoutPanel2.Controls.RemoveAt(FlowLayoutPanel2.Controls.IndexOf(checkbox.Parent))

    End Sub

    Private Sub open_group(sender As Object, e As EventArgs)

        Dim clickedLabel As Label = DirectCast(sender, Label)

        Dim frm7 As New Form7()
        frm7.userId = userId
        frm7.onlineUser = onlineUser
        frm7.groupID = Val(clickedLabel.Parent.Tag)
        frm7.Show()

    End Sub



End Class