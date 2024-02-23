Public Class Users

    Public Property UserId As Integer
    Public Property UserName As String

    Public Sub Users(ByVal uid As Integer, ByVal username As String)
        Me.UserId = uid
        Me.UserName = username
    End Sub


End Class
