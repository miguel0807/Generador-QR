Module Conexion1

    'Public impresora As String = "SATO CG408"
    'Public impresora As String = "Send To OneNote 2016"
    Public impresora As String = My.Settings.Impresora

    'Public conexion As String = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Licencias;integrated security=true" 'Miguel
    Public conexion As String = "Data Source=tcp:COS-F4Z1XQ2\SQLEXPRESS,49500;Initial Catalog=Licencias; User Id=malvarado; Password=1234Admin" 'Choi


    Public cn As New SqlClient.SqlConnection(conexion)

    Sub conectar()
        If cn.State = ConnectionState.Open Then
        Else
            cn.Open()

        End If

    End Sub

    Sub desconectar()

        cn.Close()
    End Sub
End Module
