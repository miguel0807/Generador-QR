Imports DataAccess
Public Class UserModel
    Dim userDao As New UserDao()
    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function
End Class
