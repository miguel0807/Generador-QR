Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()

        connectionString = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Usuarios;integrated security=true" 'Miguel
        'connectionString = "Data Source=tcp:COS-F4Z1XQ2\SQLEXPRESS,49500;Initial Catalog=Usuarios; User Id=malvarado; Password=1234Admin" 'Choi

    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
