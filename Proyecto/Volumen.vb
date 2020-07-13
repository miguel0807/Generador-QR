Imports System.Data.SqlClient
Public Class Volumen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            conectar()


            'Eliminar tabla 
            Dim borrar As New SqlCommand("delete From Datos", cn)
            borrar.ExecuteNonQuery()
            'Eliminar tabla
            cn.Close()

            Dim constante As String
            constante = "           No seleccionó un volumen"




            If RadioButton1.Checked = True Then constante = "125 ml"
            If RadioButton2.Checked = True Then constante = "250 ml"
            If RadioButton3.Checked = True Then constante = "500 ml"
            If RadioButton4.Checked = True Then constante = "1 litro"
            If RadioButton8.Checked = True Then constante = "4 litros"
            If RadioButton7.Checked = True Then constante = "19 litros (5 Galones)"
            If RadioButton6.Checked = True Then constante = "209 litros (55 Galones)"
            If RadioButton5.Checked = True Then constante = "1042 litros (275 Galones)"

            'If RadioButton1.Checked = True Then constante = "                     125 ml"
            'If RadioButton2.Checked = True Then constante = "                     250 ml"
            'If RadioButton3.Checked = True Then constante = "                     500 ml"
            'If RadioButton4.Checked = True Then constante = "                    1 litro"
            'If RadioButton8.Checked = True Then constante = "                    4 litros"
            'If RadioButton7.Checked = True Then constante = "               19 litros (5 Galones)"
            'If RadioButton6.Checked = True Then constante = "              209 litros (55 Galones)"
            'If RadioButton5.Checked = True Then constante = "              1042 litros (275 Galones)"





            'Guarda la etiqueta en baseDatos
            Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & constante & "')", cn)
            cn.Open()
            registrar.ExecuteNonQuery()
            'Guarda la etiqueta en baseDatos

            cn.Close()
            ActiveForm.Close()
        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)

        End Try
    End Sub

    Private Sub Volumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class