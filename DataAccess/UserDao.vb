Imports System.Data
Imports System.Data.SqlClient
Imports Common

Public Class UserDao
    Inherits ConnectionToSql
    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from users where loginName=@user and password=@pass"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.idUser = reader.GetInt32(0)
                        ActiveUser.loginName = reader.GetString(1)
                        ActiveUser.password = reader.GetString(2)
                        ActiveUser.firstName = reader.GetString(3)
                        ActiveUser.lastName = reader.GetString(4)
                        ActiveUser.position = reader.GetString(5)
                        ActiveUser.email = reader.GetString(6)

                    End While
                    reader.Dispose()


                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
