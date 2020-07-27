Imports System.Data.SqlClient
Imports System.IO
Imports vb = Microsoft.VisualBasic
Imports Common


Public Class Cargar
    Public eliminar22 As String




    Private Sub Cargar_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try


            conectar()



            'Coloca la cantidad de filas que hay en la tabla temporal
            'Esta es la cadena de conexion siempre hay que usarla para conectarse


            ' Dim conexion As String
            ' Conexion = "Data Source=tcp:COS-F4Z1XQ2\SQLEXPRESS,49500;Initial Catalog=Licencias; User Id=malvarado; Password=1234Admin" 'Daniel Jimenez
            ' Dim cn As New SqlConnection
            ' cn.ConnectionString = conexion


            'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"
            ' cn.Open()

            Dim count As Integer
            Dim Query As String
            Query = ("select COUNT (Numero) from Temporal")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            TextBox5.Text = count
            'Coloca la cantidad de filas que hay en la tabla temporal


            'Actualiza textbox Volumen
            Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
            Dim ds As New DataSet
            textboxvolumen.Fill(ds, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            TextBox4.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            'Actualiza textbox Volumen
            cn.Close()


            If TextBox5.Text >= 1 Then
                'Actualiza textbox Datos para datos
                Dim textboxdatos1 As New SqlDataAdapter("select*from Temporal", cn)
                Dim ds1 As New DataSet
                textboxdatos1.Fill(ds1, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                TextBox3.Text = ds1.Tables("datos").Rows(0).Item(2).ToString
                'Actualiza textbox Datos para datos
            End If

            'Actualiza lote y numero de parte descripcion orden de produccion
            If count <= 0 Then
                TextBox2.Text = "N/A"
                TextBox1.Text = "N/A"
                TextBox6.Text = "N/A"
                TextBox7.Text = "N/A"
            Else
                Dim Cadena As String = TextBox3.Text
                Dim Cadena2 As String = TextBox3.Text
                TextBox1.Text = vb.Mid(Cadena, 14, 8)
                TextBox2.Text = vb.Mid(Cadena2, 23, 8)
            End If
            'Actualiza lote y numero de parte


#Region "Actualizar ORDEN Y DESCRIPCION"
            If TextBox2.Text = "N/A" And TextBox1.Text = "N/A" Then
                TextBox6.Text = "N/A"
                TextBox7.Text = "N/A"
            Else

                conectar()

                Dim adaptador As New SqlDataAdapter("select*from SAP where Batch=" & "'" & TextBox2.Text & "'" & "" & "And Material=" & TextBox1.Text & "", cn) 'Funciona con lote y material

                Dim ds1 As New DataSet
                adaptador.Fill(ds1, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds1.Tables("datos").Rows.Count > 0 Then

                    TextBox7.Text = ds1.Tables("datos").Rows(0).Item(3).ToString
                    TextBox6.Text = ds1.Tables("datos").Rows(0).Item(1).ToString 'Orden de produccion
                End If
                desconectar()
            End If
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'Condicional para verificar si quiere eliminar
            Dim Pregunta As Integer
            Pregunta = MsgBox("Presione Aceptar para eliminar las Licencias", vbOKCancel, "Eliminacion de Licencias")
            If Pregunta = 2 Then
                Exit Sub
            End If
            'Condicional para verificar si quiere eliminar


            conectar()

            'Eliminar tabla de licencias temporales
            Dim borrar As New SqlCommand("delete From Temporal", cn)
            borrar.ExecuteNonQuery()
            'Eliminar tabla de licencias temporales

            'Actualiza conteo de cantidad de licencias
            Dim count As Integer
            Dim Query As String
            Query = ("select COUNT (Numero) from Temporal")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            TextBox5.Text = count
            'Actualiza conteo de cantidad de licencias


            'Eliminar tabla de datos volumen
            Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
            borrarVolumen.ExecuteNonQuery()
            'Eliminar tabla de datos volumen

            'Eliminar volumen y coloca  N/A
            Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
            registrar.ExecuteNonQuery()
            'Eliminar volumen y coloca  N/A


            'Actualiza textbox Volumen
            Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
            Dim ds As New DataSet
            textboxvolumen.Fill(ds, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            TextBox4.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            'Actualiza textbox Volumen



            cn.Close()

            If TextBox5.Text <= 0 Then
                TextBox3.Text = "N/A"
            End If


            'Actualiza lote y numero de parte
            If count <= 0 Then
                TextBox2.Text = "N/A"
                TextBox1.Text = "N/A"
                TextBox6.Text = "N/A"
                TextBox7.Text = "N/A"
            Else
                Dim Cadena As String = TextBox3.Text
                Dim Cadena2 As String = TextBox3.Text
                TextBox1.Text = vb.Mid(Cadena, 14, 8)
                TextBox2.Text = vb.Mid(Cadena2, 23, 8)
            End If
            'Actualiza lote y numero de parte


            My.Settings.OrdenProduccion = 0
            My.Settings.Save()

            MsgBox("Licencias eliminadas correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files|*.txt"


        'Abro showdialog
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'Si ok procede y declara direccion de txt
            Dim direccion As String
            Dim eliminar As String
            direccion = "'" + OpenFileDialog1.FileName + "'" 'Se agregar ' para escribir en sql
            eliminar = " \\cor-sv-fs01\Costa Rica Share\Public\Production\Licencias Tintas\Licencias Temporales\"
            'direccion = Path.GetFileName(direccion)
            direccion = Path.GetFileNameWithoutExtension(direccion)

            MsgBox(direccion)
            My.Computer.FileSystem.DeleteFile("T:\Public\Production\Licencias Tintas\Licencias Temporales\" & direccion & ".txt")
            ' My.Computer.FileSystem.DeleteFile("T:\Public\Production\Licencias Tintas\Licencias Temporales\Pruebas - copia.txt")
        End If
    End Sub







    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
#Region "Cargar"
        Try
            conectar()

            'Configuro el showDialog
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Text Files|*.txt"

            'Abro showdialog
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'Si ok procede y declara direccion de txt
                Dim direccion As String

                direccion = "'" + OpenFileDialog1.FileName + "'" 'Se agregar ' para escribir en sql
                eliminar22 = direccion
                direccion = Path.GetFileName(direccion)
                eliminar22 = Path.GetFileNameWithoutExtension(eliminar22)

                'Se inserta datos de txt hacia tabla llamada Temporal

                'Dim prueba As New SqlCommand("BULK INSERT Temporal FROM" & direccion & "WITH(FIELDTERMINATOR = '\t',ROWTERMINATOR = '\n')", cn) 'original antes
                Dim prueba As New SqlCommand("BULK INSERT Temporal FROM" & "'" & "\\cor-sv-fs01\Costa Rica Share\Public\Production\Licencias Tintas\Licencias Temporales\" & direccion & "WITH(FIELDTERMINATOR = '\t',ROWTERMINATOR = '\n')", cn) 'Original NUEVO

                prueba.ExecuteNonQuery()



                'Actualiza cantidad de licencias
                Dim count1 As Integer
                Dim Query1 As String
                Query1 = ("select COUNT (Numero) from Temporal")
                Dim cmd1 As New SqlCommand(Query1, cn)
                count1 = cmd1.ExecuteScalar
                TextBox5.Text = count1
                'Actualiza cantidad de licencias

                'Abre formulario volumen y se espera a que cierre para proceder
                Volumen.ShowDialog()
                'Abre formulario volumen y se espera a que cierre para proceder

                'Actualiza textbox Volumen
                Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
                Dim ds As New DataSet
                textboxvolumen.Fill(ds, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                TextBox4.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                'Actualiza textbox Volumen

                cn.Close()
            Else
                cn.Close()
                Exit Sub
            End If
            If TextBox5.Text >= 1 Then
                'Actualiza textbox Datos para datos
                Dim textboxdatos1 As New SqlDataAdapter("select*from Temporal", cn)
                Dim ds1 As New DataSet
                textboxdatos1.Fill(ds1, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                TextBox3.Text = ds1.Tables("datos").Rows(0).Item(2).ToString
                'Actualiza textbox Datos para datos
            End If

            cn.Open()
            'Actualiza conteo de cantidad de licencias
            Dim count As Integer
            Dim Query As String
            Query = ("select COUNT (Numero) from Temporal")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            TextBox5.Text = count
            'Actualiza conteo de cantidad de licencias
            cn.Close()
            'Actualiza lote y numero de parte
            If count <= 0 Then
                TextBox2.Text = "N/A"
                TextBox1.Text = "N/A"
            Else
                Dim Cadena As String = TextBox3.Text
                Dim Cadena2 As String = TextBox3.Text
                TextBox1.Text = vb.Mid(Cadena, 14, 8)
                TextBox2.Text = vb.Mid(Cadena2, 23, 8)
            End If
            'Actualiza lote y numero de parte


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#End Region

#Region "Traer Datos"
        Try

            'Actualiza textbox Datos para datos
            Dim textboxdatos1 As New SqlDataAdapter("select*from Temporal", cn)
            Dim ds1 As New DataSet
            textboxdatos1.Fill(ds1, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            Original.Text = ds1.Tables("datos").Rows(0).Item(2).ToString
            'Actualiza textbox Datos para datos
            desconectar()

            Dim Cadena As String = Original.Text
            Dim Cadena2 As String = Original.Text
            Parte.Text = vb.Mid(Cadena, 14, 8)
            Lote.Text = vb.Mid(Cadena2, 23, 8)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#End Region

#Region "Traer Datos SAP"

#Region "Conectarse a SAP"
        Try
            'En el parentesis entre & & se coloca cual valor se usara para la busqueda
            'Dim adaptador As New SqlDataAdapter("select*from SAP where Material=" & Parte.Text & "", cn) 'Original material
            '  Dim adaptador As New SqlDataAdapter("select*from SAP where Batch=" & "'" & Lote.Text & "'" & "", cn) 'Original lote
            Dim adaptador As New SqlDataAdapter("select*from SAP where Batch=" & "'" & Lote.Text & "'" & "" & "And Material=" & Parte.Text & "", cn) 'Funciona con lote y material

            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")



#End Region



#Region "Pregunta"
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            If ds.Tables("datos").Rows.Count > 0 Then
                    Parte2.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                    Lote2.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                Orden.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                TextBox7.Text = ds.Tables("datos").Rows(0).Item(3).ToString
                TextBox6.Text = ds.Tables("datos").Rows(0).Item(1).ToString 'Orden de produccion

                MsgBox("Licencias cargadas con exito!!")
                Else
                    Dim resultado As DialogResult
                resultado = MessageBox.Show("Las licencias que trata de cargar no estan registradas en SAP.Presione el boton Si para actualizar archivo de SAP o presione No para Cancelar", "Error en Carga de licencias", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

#End Region
#Region "Respuesta NO"
                If resultado = DialogResult.No Then
                        Try
                            conectar()

                            'Eliminar tabla de licencias temporales
                            Dim borrar As New SqlCommand("delete From Temporal", cn)
                            borrar.ExecuteNonQuery()
                            'Eliminar tabla de licencias temporales

                            'Actualiza conteo de cantidad de licencias
                            Dim count As Integer
                            Dim Query As String
                            Query = ("select COUNT (Numero) from Temporal")
                            Dim cmd As New SqlCommand(Query, cn)
                            count = cmd.ExecuteScalar
                            TextBox5.Text = count
                            'Actualiza conteo de cantidad de licencias


                            'Eliminar tabla de datos volumen
                            Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
                            borrarVolumen.ExecuteNonQuery()
                            'Eliminar tabla de datos volumen

                            'Eliminar volumen y coloca  N/A
                            Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
                            registrar.ExecuteNonQuery()
                            'Eliminar volumen y coloca  N/A


                            'Actualiza textbox Volumen
                            Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
                            Dim dsa As New DataSet
                            textboxvolumen.Fill(dsa, "datos")
                            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                            TextBox4.Text = dsa.Tables("datos").Rows(0).Item(1).ToString
                            'Actualiza textbox Volumen

                            cn.Close()

                            If TextBox5.Text <= 0 Then
                                TextBox3.Text = "N/A"
                            End If


                            'Actualiza lote y numero de parte
                            If count <= 0 Then
                                TextBox2.Text = "N/A"
                                TextBox1.Text = "N/A"
                            Else
                                Dim Cadenaa As String = TextBox3.Text
                                Dim Cadena2 As String = TextBox3.Text
                                TextBox1.Text = vb.Mid(Cadenaa, 14, 8)
                                TextBox2.Text = vb.Mid(Cadena2, 23, 8)
                            End If
                        'Actualiza lote y numero de parte


                        'Borrar textbox de lote,parte ,codigo
                        Lote.Text = ""
                        Lote2.Text = ""
                        Parte.Text = ""
                        Parte2.Text = ""
                        Orden.Text = ""
                        Original.Text = ""
                        'Borrar textbox de lote,parte ,codigo

                        Exit Sub
                    Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If

                'Borrar textbox de lote,parte ,codigo
                Lote.Text = ""
                Lote2.Text = ""
                Parte.Text = ""
                Parte2.Text = ""
                Orden.Text = ""
                Original.Text = ""
                'Borrar textbox de lote,parte ,codigo


#End Region
#Region "Respuesta SI"
                Try
                        If resultado = DialogResult.Yes Then

                        conectar()


                        'Eliminar tabla de licencias temporales
                        Dim borrarSAP As New SqlCommand("delete From SAP", cn)
                        borrarSAP.ExecuteNonQuery()
                        'Eliminar tabla de licencias temporales

                        Dim prueba1 As New SqlCommand("BULK INSERT SAP FROM" & "'" & "\\cor-sv-fs01\Costa Rica Share\Public\Production\Licencias Tintas\Licencias Temporales\SAP\" & "SAP.txt'" & "WITH( FIRSTROW = 6 ,FIELDTERMINATOR = '\t',ROWTERMINATOR = '\n')", cn) 'Original NUEVO
                            prueba1.ExecuteNonQuery()
                        MsgBox("Archivo de SAP Actualizado")

#Region "Eliminar las licencias Temporales"
                        'Eliminar tabla de licencias temporales
                        Dim borrar As New SqlCommand("delete From Temporal", cn)
                        borrar.ExecuteNonQuery()
                        'Eliminar tabla de licencias temporales

                        'Actualiza conteo de cantidad de licencias
                        Dim count As Integer
                        Dim Query As String
                        Query = ("select COUNT (Numero) from Temporal")
                        Dim cmd As New SqlCommand(Query, cn)
                        count = cmd.ExecuteScalar
                        TextBox5.Text = count
                        'Actualiza conteo de cantidad de licencias


                        'Eliminar tabla de datos volumen
                        Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
                        borrarVolumen.ExecuteNonQuery()
                        'Eliminar tabla de datos volumen

                        'Eliminar volumen y coloca  N/A
                        Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
                        registrar.ExecuteNonQuery()
                        'Eliminar volumen y coloca  N/A


                        'Actualiza textbox Volumen
                        Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
                        Dim dsa As New DataSet
                        textboxvolumen.Fill(dsa, "datos")
                        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                        TextBox4.Text = dsa.Tables("datos").Rows(0).Item(1).ToString
                        'Actualiza textbox Volumen

                        cn.Close()

                        If TextBox5.Text <= 0 Then
                            TextBox3.Text = "N/A"
                        End If


                        'Actualiza lote y numero de parte
                        If count <= 0 Then
                            TextBox2.Text = "N/A"
                            TextBox1.Text = "N/A"
                        Else
                            Dim Cadenaa As String = TextBox3.Text
                            Dim Cadena2 As String = TextBox3.Text
                            TextBox1.Text = vb.Mid(Cadenaa, 14, 8)
                            TextBox2.Text = vb.Mid(Cadena2, 23, 8)
                        End If
                        'Actualiza lote y numero de parte

#End Region
                        'Borrar textbox de lote,parte ,codigo
                        Lote.Text = ""
                        Lote2.Text = ""
                        Parte.Text = ""
                        Parte2.Text = ""
                        Orden.Text = ""
                        Original.Text = ""
                        'Borrar textbox de lote,parte ,codigo
                        Exit Sub
                    End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
#Region "Elimina las licencias y actualiza formulario cuando falla"

                        'Eliminar tabla de licencias temporales
                        Dim borrar As New SqlCommand("delete From Temporal", cn)
                        borrar.ExecuteNonQuery()
                        'Eliminar tabla de licencias temporales

                        'Actualiza conteo de cantidad de licencias
                        Dim count As Integer
                        Dim Query As String
                        Query = ("select COUNT (Numero) from Temporal")
                        Dim cmd As New SqlCommand(Query, cn)
                        count = cmd.ExecuteScalar
                        TextBox5.Text = count
                        'Actualiza conteo de cantidad de licencias


                        'Eliminar tabla de datos volumen
                        Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
                        borrarVolumen.ExecuteNonQuery()
                        'Eliminar tabla de datos volumen

                        'Eliminar volumen y coloca  N/A
                        Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
                        registrar.ExecuteNonQuery()
                        'Eliminar volumen y coloca  N/A


                        'Actualiza textbox Volumen
                        Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
                        Dim dsa As New DataSet
                        textboxvolumen.Fill(dsa, "datos")
                        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                        TextBox4.Text = dsa.Tables("datos").Rows(0).Item(1).ToString
                        'Actualiza textbox Volumen

                        cn.Close()

                        If TextBox5.Text <= 0 Then
                            TextBox3.Text = "N/A"
                        End If


                        'Actualiza lote y numero de parte
                        If count <= 0 Then
                            TextBox2.Text = "N/A"
                            TextBox1.Text = "N/A"
                        Else
                            Dim Cadenaa As String = TextBox3.Text
                            Dim Cadena2 As String = TextBox3.Text
                            TextBox1.Text = vb.Mid(Cadenaa, 14, 8)
                            TextBox2.Text = vb.Mid(Cadena2, 23, 8)
                        End If
                    'Actualiza lote y numero de parte

                    MsgBox("Problemas al actualizar Base De Datos")

#End Region
                    'Borrar textbox de lote,parte ,codigo
                    Lote.Text = ""
                    Lote2.Text = ""
                    Parte.Text = ""
                    Parte2.Text = ""
                    Orden.Text = ""
                    Original.Text = ""
                    'Borrar textbox de lote,parte ,codigo




                    Exit Sub
                End Try

                End If

#End Region


#End Region

            My.Settings.OrdenProduccion = TextBox6.Text
            My.Settings.UltimaOrden = TextBox6.Text
            My.Settings.Save()

#Region "Actualizar formulario"

            'Cambia el lote por 8 digitos ya que en SAP viene con mas
            Dim Cadena As String = Lote2.Text
            Lote2.Text = vb.Mid(Cadena, 1, 8)
            'Cambia el lote por 8 digitos ya que en SAP viene con mas

#Region "Crear archivo y cambiar nombre"

            Dim direccioncompleta
                Dim direccion2 As String
                Dim nombrearchivo As String
                Dim completa As String
                Dim U125ml As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\125 ml"
                Dim U250ml As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\250 ml"
                Dim U500ml As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\500 ml"
                Dim U1litro As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\1 Liter"
                Dim U4litros As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\4 Liter"
                Dim U19litros As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\19 Liter (5 GAL)"
                Dim U209litros As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\209 Liters (55 Gals)"
                Dim U1042litros As String = "T:\Public\Production\Licencias Tintas\Licencias Temporales\Josef Temporales\1042  Liter (275 Gal)"
                Dim ruta As String

                direccioncompleta = (OpenFileDialog1.FileName)  'Se agregar ' para escribir en sql
                direccion2 = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName) 'Se agregar ' para escribir en sql
                nombrearchivo = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) 'Se agregar ' para escribir en sql
            ' completa = direccion & "\" & nombrearchivo & "1.txt"

            If TextBox4.Text = "125 ml" Then
                ruta = U125ml

            ElseIf TextBox4.Text = "250 ml" Then
                ruta = U250ml

            ElseIf TextBox4.Text = "500 ml" Then
                ruta = U500ml

            ElseIf TextBox4.Text = "1 litro" Then
                ruta = U1litro

            ElseIf TextBox4.Text = "4 litros" Then
                ruta = U4litros
            ElseIf TextBox4.Text = "19 litros (5 Galones)" Then
                ruta = U19litros
            ElseIf TextBox4.Text = "209 litros (55 Galones)" Then
                ruta = U209litros
            ElseIf TextBox4.Text = "1042 litros (275 Galones)" Then
                ruta = U1042litros
            Else
                MsgBox("La variable ruta no se pudo asignar con el volumen")
                Exit Sub
            End If


            completa = ruta & "\" & TextBox1.Text & TextBox2.Text & ".txt"


            My.Computer.FileSystem.CopyFile(
            direccioncompleta,
            completa,
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)



#End Region
            'Elimina el archivo seleccionado
            My.Computer.FileSystem.DeleteFile("T:\Public\Production\Licencias Tintas\Licencias Temporales\" & eliminar22 & ".txt")


            'Borrar textbox de lote,parte ,codigo
            Lote.Text = ""
            Lote2.Text = ""
            Parte.Text = ""
            Parte2.Text = ""
            Orden.Text = ""
            Original.Text = ""
            ' Borrar TextBox de lote, Parte, codigo



#Region "Actualizar ORDEN Y DESCRIPCION"
            If TextBox2.Text = "N/A" And TextBox1.Text = "N/A" Then
                TextBox6.Text = "N/A"
                TextBox7.Text = "N/A"
            Else

                conectar()

                Dim adaptador2 As New SqlDataAdapter("select*from SAP where Batch=" & "'" & TextBox2.Text & "'" & "" & "And Material=" & TextBox1.Text & "", cn) 'Funciona con lote y material

                Dim ds1 As New DataSet
                adaptador2.Fill(ds1, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds1.Tables("datos").Rows.Count > 0 Then

                    TextBox7.Text = ds1.Tables("datos").Rows(0).Item(3).ToString
                    TextBox6.Text = ds1.Tables("datos").Rows(0).Item(1).ToString 'Orden de produccion
                End If
                desconectar()
            End If
#End Region


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#End Region


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Try
            'Condicional para verificar si quiere eliminar
            Dim Pregunta As Integer
            Pregunta = MsgBox("¿Quiere eliminar licencias?", vbOKCancel, "")
            If Pregunta = 2 Then
                Exit Sub
            End If
            'Condicional para verificar si quiere eliminar


            conectar()

            'Eliminar tabla de licencias temporales
            Dim borrar As New SqlCommand("delete From Temporal", cn)
            borrar.ExecuteNonQuery()
            'Eliminar tabla de licencias temporales

            'Actualiza conteo de cantidad de licencias
            Dim count As Integer
            Dim Query As String
            Query = ("select COUNT (Numero) from Temporal")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            TextBox5.Text = count
            'Actualiza conteo de cantidad de licencias


            'Eliminar tabla de datos volumen
            Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
            borrarVolumen.ExecuteNonQuery()
            'Eliminar tabla de datos volumen

            'Eliminar volumen y coloca  N/A
            Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
            registrar.ExecuteNonQuery()
            'Eliminar volumen y coloca  N/A


            'Actualiza textbox Volumen
            Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
            Dim ds As New DataSet
            textboxvolumen.Fill(ds, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            TextBox4.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            'Actualiza textbox Volumen



            cn.Close()

            If TextBox5.Text <= 0 Then
                TextBox3.Text = "N/A"
            End If


            'Actualiza lote y numero de parte
            If count <= 0 Then
                TextBox2.Text = "N/A"
                TextBox1.Text = "N/A"
            Else
                Dim Cadena As String = TextBox3.Text
                Dim Cadena2 As String = TextBox3.Text
                TextBox1.Text = vb.Mid(Cadena, 14, 8)
                TextBox2.Text = vb.Mid(Cadena2, 23, 8)
            End If
            'Actualiza lote y numero de parte


            MsgBox("Se borro correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class