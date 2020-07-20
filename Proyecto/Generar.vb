Imports System.Data.SqlClient
Imports vb = Microsoft.VisualBasic
Imports System.Math
Imports Common
Public Class Generar
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    'Se declara variable cantidad de licencias
    Dim u As Long
    Dim f As Long
    Dim printController As New System.Drawing.Printing.StandardPrintController 'Se declara esta variable para evitar que se muestre el cuadro de impresion al genera licencia
    Dim cantidadCajas As Integer
    Dim cantidadbotella As Integer
    Dim caja As Integer
    Dim sumacaja As Integer



    'Se declara variable cantidad de licencias


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles EtiquetaDatos.TextChanged
        Try
            PictureBox1.Image = QR_Generator.Encode(LicenciaDatos.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

#Region "Impresion"
        Dim LAPIZ As New SolidBrush(TextBox3.ForeColor)
        Dim AREA_IMPRESION As Graphics = e.Graphics

        Dim POSICION As Point
        Dim TEXTO As String
        TEXTO = EtiquetaDatos.Text
        Dim FUENTE As Font
        Dim maximoE As String
        Dim maximoQR As String
        Dim medioQR As String
        Dim medioE As String

        maximoE = EtiquetaDatos.Width
        medioE = maximoE / 2
        maximoQR = PictureBox1.Image.Width
        medioQR = PictureBox1.Image.Width / 2



        'Selecciona textbox3 para configurar el tipo de letra
        FUENTE = New Font(LicenciaDatos.Font, FontStyle.Bold)
        'Calcula la posicion para ser impresa en picturebox1

        POSICION = New Point(98, 105) 'Pruebas

        'Escribe etiqueta usando textbox1
        AREA_IMPRESION.DrawString(EtiquetaDatos.Text, TextBox3.Font, LAPIZ, POSICION)
        'Imprime el qr
        e.Graphics.DrawImage(PictureBox1.Image, 160, 20, 70, 70) 'Original 65,65


#End Region

    End Sub

    Private Sub Generar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Nombre.Text = ActiveUser.firstName + " " + ActiveUser.lastName

        'Coloca fecha
        FechaDatos.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = FechaDatos.Text
        FechaDatos.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
        'Label2.Text = Format(fechacreacion, "yyyy/MM/dd")


        conectar()


        'Actualiza conteo de licencias temporales
        Dim count As Integer
        Dim Query As String
        Query = ("select COUNT (Numero) from Temporal")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar
        TextBox4.Text = count
        'Actualiza conteo de licencias temporales


        If TextBox4.Text >= 1 Then
            'Actualiza textbox Datos para datos
            Dim textboxdatos1 As New SqlDataAdapter("select*from Temporal", cn)
            Dim ds1 As New DataSet
            textboxdatos1.Fill(ds1, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            TextBox10.Text = ds1.Tables("datos").Rows(0).Item(2).ToString
            'Actualiza textbox Datos para datos
        End If

        cn.Close()


        'Actualiza textbox Volumen
        Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
        Dim ds As New DataSet
        textboxvolumen.Fill(ds, "datos")
        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        VolumenDatos.Text = ds.Tables("datos").Rows(0).Item(1).ToString
        'Actualiza textbox Volumen

        cn.Close()

        'Bloquea textbox para no escribir
        EtiquetaDatos.ReadOnly = True
        LicenciaDatos.ReadOnly = True
        TextBox4.ReadOnly = True
        VolumenDatos.ReadOnly = True
        'Bloquea textbox para no escribir





        'Actualiza lote y numero de parte
        If count <= 0 Then
            ParteDatos.Text = "N/A"
            LoteDatos.Text = "N/A"
            OrdenDatos.Text = "N/A"
            DescripcionDatos.Text = "N/A"
        Else
            Dim Cadena As String = TextBox10.Text
            Dim Cadena2 As String = TextBox10.Text
            ParteDatos.Text = vb.Mid(Cadena, 14, 8)
            LoteDatos.Text = vb.Mid(Cadena2, 23, 8)
        End If
        'Actualiza lote y numero de parte



        'Actualiza Conteo de Ribbon
        Dim conteo1 As New SqlDataAdapter("select*from Conteo", cn)
        Dim dsconteo As New DataSet
        conteo1.Fill(dsconteo, "datos")
        Ribbon.Text = dsconteo.Tables("datos").Rows(0).Item(0)
        'Actualiza Conteo de Ribbon

        cn.Close()


#Region "Actualizar ORDEN Y DESCRIPCION"
        If ParteDatos.Text = "N/A" And LoteDatos.Text = "N/A" Then
            DescripcionDatos.Text = "N/A"
            OrdenDatos.Text = "N/A"
            Label16.Text = "N/A"
        Else

            conectar()

            Dim adaptador As New SqlDataAdapter("select*from SAP where Batch=" & "'" & LoteDatos.Text & "'" & "" & "And Material=" & ParteDatos.Text & "", cn) 'Funciona con lote y material

            Dim ds1 As New DataSet
            adaptador.Fill(ds1, "datos")
            'El item selecciona de cual columna de la base de datos se conectara y row es la fila
            If ds1.Tables("datos").Rows.Count > 0 Then

                DescripcionDatos.Text = ds1.Tables("datos").Rows(0).Item(3).ToString
                OrdenDatos.Text = ds1.Tables("datos").Rows(0).Item(1).ToString 'Orden de produccion


            End If
            desconectar()
        End If

#End Region

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        conectar()


        'Eliminar tabla Conteo
        Dim borrar As New SqlCommand("delete From Conteo", cn)
        borrar.ExecuteNonQuery()
        'Eliminar tabla Conteo




        'Restablece el conteo de ribbon
        Dim restar As New SqlCommand("insert into Conteo values ('" & "1600" & "')", cn)
        restar.ExecuteNonQuery()
        'Restablece el conteo de ribbon

        cn.Close()

        cn.Open()
        'Actualiza Conteo de Ribbon
        Dim conteo3 As New SqlDataAdapter("select*from Conteo", cn)
        Dim dsconteo3 As New DataSet
        conteo3.Fill(dsconteo3, "datos")
        Ribbon.Text = dsconteo3.Tables("datos").Rows(0).Item(0)
        'Actualiza Conteo de Ribbon

        cn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Boton Generar"
        Try
#Region "Declaracion de variables y actualizacion ProgressBar1"
            PrintDocument1.PrintController = printController 'Se declara la variable para quitar cuadro de impresion 
            Dim licenciarestante As Integer = TextBox4.Text
            Dim cantidadlicencias As Integer = TextBox5.Text

            u = TextBox5.Text
            conectar()
            ProgressBar1.Refresh()
            ProgressBar1.Value = 0
#End Region

#Region "Condicional para solicitar licencias"
            'Condicional para verificar si hay licencias en tabla Temporal
            If licenciarestante <= 0 Or licenciarestante < cantidadlicencias Then
                MsgBox("No hay licencias, favor cargar")
                Exit Sub
            End If
#End Region

#Region "Configuracion Impresora"
            'Configuracion Impresora
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDialog1.PrinterSettings.PrinterName = impresora
            '  PrintDialog1.PrinterSettings.PrinterName = "SATO CG408"
            ' PrintDialog1.PrinterSettings.PrinterName = "Send To OneNote 2016"
            PrintDialog1.PrinterSettings.Copies = 1
            PrintDialog1.PrinterSettings.Collate = False
            PrintDialog1.PrinterSettings.Duplex = Printing.Duplex.Simplex
            PrintDialog1.PrinterSettings.FromPage = 0
            'PrintDialog1.PrinterSettings.LandscapeAngle.Equals = 90
            'PrintDialog1.PrinterSettings.MaximumCopies = 999
            PrintDocument1.DefaultPageSettings.Color = False
            PrintDocument1.DefaultPageSettings.Landscape = False
            ' PrintDocument1.DefaultPageSettings.Margins =
            PrintDialog1.PrinterSettings.ToPage = 0
            'Configuracion Impresora
#End Region

#Region "Configuracion impresora 2"
            'Configuracion Impresora
            PrintDocument2.PrinterSettings = PrintDialog2.PrinterSettings
            PrintDialog2.PrinterSettings.PrinterName = impresora
            ' PrintDialog2.PrinterSettings.PrinterName = "SATO CG408"
            ' PrintDialog2.PrinterSettings.PrinterName = "Send To OneNote 2016"
            PrintDialog2.PrinterSettings.Copies = 1
            PrintDialog2.PrinterSettings.Collate = False
            PrintDialog2.PrinterSettings.Duplex = Printing.Duplex.Simplex
            PrintDialog2.PrinterSettings.FromPage = 0
            PrintDocument2.DefaultPageSettings.Color = False
            PrintDocument2.DefaultPageSettings.Landscape = False
            PrintDialog2.PrinterSettings.ToPage = 0
            'Configuracion Impresora

#End Region
#Region "Bucle"

            For f = 1 To u

#Region "Traer datos de temporal a texbox"
                'Mover datos
                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                ' Dim adaptador As New SqlDataAdapter("select*from Temporal where Numero=" & "3961" & "", cn)
                Dim adaptador As New SqlDataAdapter("select*from Temporal", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    LicenciaDatos.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                    EtiquetaDatos.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                    TextBox6.Text = ds.Tables("datos").Rows(0).Item(0).ToString

                End If
                'Mover Datos Finalizado

                cn.Close()

#End Region
#Region "Condicionales por Volumen"
#Region "125ml"
                If VolumenDatos.Text = "125 ml" Then

                    PrintDocument1.Print()
                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 1", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
#End Region
#Region "250 ml"
                ElseIf VolumenDatos.Text = "250 ml" Then
                    PrintDocument1.Print()
                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 1", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
#End Region
#Region "500 ml"
                ElseIf VolumenDatos.Text = "500 ml" Then
                    PrintDocument1.Print()
                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 1", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
#End Region
#Region "1 litro"
                ElseIf VolumenDatos.Text = "1 litro" Then


#Region "Conectarse SAP Y determinar cantidad total de cajas en orden"
                    conectar()

                    Dim adaptador5 As New SqlDataAdapter("select*from SAP where Batch=" & "'" & LoteDatos.Text & "'" & "" & "And Material=" & ParteDatos.Text & "", cn) 'Funciona con lote y material

                    Dim ds1 As New DataSet
                    adaptador5.Fill(ds1, "datos")
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds1.Tables("datos").Rows.Count > 0 Then


                        Label15.Text = ds1.Tables("datos").Rows(0).Item(6).ToString
                        cantidadCajas = Label15.Text
                        Label16.Text = cantidadCajas
                        cantidadbotella = cantidadCajas * 6
                    End If
                    desconectar()

#End Region


#Region "Determinar # de caja para etiqueta"

                    Dim TotalLicencias As Integer
                    Dim Volumen As Integer = 6
                    Dim resultado As Double

                    TotalLicencias = TextBox4.Text
                    resultado = TotalLicencias / Volumen
                    caja = Math.Ceiling(resultado)
                    sumacaja = caja + 90000
                    If resultado Mod 1 Then

                    Else



                        TextBox12.Text = OrdenDatos.Text + sumacaja
                        TextBox7.Text = "Caja #" & caja
                        PrintDocument2.Print()

                    End If


#End Region

                    PrintDocument1.Print()


                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 1", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo

#End Region
#Region "4 litros"
                ElseIf VolumenDatos.Text = "4 litros" Then
                    PrintDocument1.Print()


                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 1", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
#End Region
#Region "5 Galones"
                ElseIf VolumenDatos.Text = "19 litros (5 Galones)" Then
                    PrintDocument1.Print()
                    PrintDocument1.Print()
                    PrintDocument1.Print()

                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 3", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
#End Region
#Region "209 litros(55 Galones)"
                ElseIf VolumenDatos.Text = "209 litros (55 Galones)" Then
                    PrintDocument1.Print()
                    PrintDocument1.Print()
                    PrintDocument1.Print()

                    'Resta el conteo de Ribbon
                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 3", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo

#End Region
#Region "1042 litros (275 Galones)"
                ElseIf VolumenDatos.Text = "1042 litros (275 Galones)" Then
                    PrintDocument1.Print()
                    PrintDocument1.Print()
                    PrintDocument1.Print()
                    PrintDocument1.Print()
                    PrintDocument1.Print()

                    cn.Open()
                    'Resta Conteo
                    Dim conteo1 As New SqlCommand("update Conteo Set Ribbon= Ribbon- 5", cn)
                    conteo1.ExecuteNonQuery()
                    cn.Close()
                    'Resta Conteo
                End If
#End Region


#End Region
#Region "Colocacion de fecha cuando se genera la licencia"
                'Coloca fecha
                FechaDatos.Text = DateTime.Now
                Dim fechacreacion As Date
                fechacreacion = FechaDatos.Text
                FechaDatos.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm:ss")
#End Region
#Region "Guardado de QR impreso en BaseDatosOficial"


                'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
                Dim registrar As New SqlCommand("insert into BaseDatosOficial values (" & TextBox6.Text & ",'" & EtiquetaDatos.Text & "','" & LicenciaDatos.Text & "','" & FechaDatos.Text & "','" & VolumenDatos.Text & "','" & Nombre.Text & "','" & OrdenDatos.Text & "','" & LoteDatos.Text & "','" & ParteDatos.Text & "','" & DescripcionDatos.Text & "'," & sumacaja & "," & 0 & ")", cn)
                cn.Open()
                registrar.ExecuteNonQuery()
                'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
                cn.Close()

#End Region
#Region "Eliminacion de QR impreso en TEMPORAL"
                'Eliminar primera fila de la tabla 
                Try
                    cn.Open()
                    Dim borrar As New SqlCommand("DELETE TOP(1) FROM Temporal", cn)
                    borrar.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(vbCrLf & ex.Message)
                End Try
                'Eliminar primera fila de la tabla 

                cn.Close()
#End Region
#Region "Actualizacion de Conteo de licencias en vivo"
                cn.Open()
                'Actualizar cantidad de licencias temporales
                Dim count As Integer
                Dim Query As String
                Query = ("Select COUNT (Numero) from Temporal")
                Dim cmd As New SqlCommand(Query, cn)
                count = cmd.ExecuteScalar
                TextBox4.Text = count
                'Actualiza cantidad de licencias temporales
                cn.Close()
#End Region
#Region "Modulo Carga Barra"

                ProgressBar1.Maximum = u
                ProgressBar1.Minimum = 0
                ProgressBar1.Increment(1)
                ProgressBar1.Refresh()
                Dim Var1 As Double = (ProgressBar1.Value / u * 100)
                Dim Var2 As Double
                Var2 = Round(Var1)


                Porcentaje.Text = Var2 & (" %")
                Porcentaje.Refresh()
                Application.DoEvents()
#End Region


            Next f

#End Region


#Region "Condicional cuando se acaban las etiquetas"
            cn.Open()
            'Borra volumen cuando no hay etiquetas
            If TextBox4.Text = 0 Then
                'Eliminar tabla 
                Dim borrarVolumen As New SqlCommand("delete From Datos", cn)
                borrarVolumen.ExecuteNonQuery()
                'Eliminar tabla
                cn.Close()



                cn.Open()
                'Eliminar volumen y coloca  N/A
                Dim registrar As New SqlCommand("insert into Datos values (" & "1" & ",'" & "N/A" & "')", cn)
                registrar.ExecuteNonQuery()
                'Eliminar volumen y coloca  N/A
                cn.Close()


                cn.Open()
                'Actualiza textbox Volumen
                Dim textboxvolumen As New SqlDataAdapter("select*from Datos", cn)
                Dim ds1 As New DataSet
                textboxvolumen.Fill(ds1, "datos")
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                VolumenDatos.Text = ds1.Tables("datos").Rows(0).Item(1).ToString
                'Actualiza textbox Volumen


            End If

            'Borra volumen cuando no hay etiquetas
#End Region
#Region "Actualizacion de Datos"
#Region "Conteo licencias temporales"
            'Actualiza conteo de licencias temporales
            Dim count1 As Integer
            Dim Query1 As String
            Query1 = ("select COUNT (Numero) from Temporal")
            Dim cmd1 As New SqlCommand(Query1, cn)
            count1 = cmd1.ExecuteScalar

            TextBox4.Text = count1
            cn.Close()
            'Actualiza conteo de licencias temporales
            cn.Close()
#End Region

#Region "Lote y Numero de parte"
            'Actualiza lote y numero de parte
            If count1 <= 0 Then
                ParteDatos.Text = "N/A"
                LoteDatos.Text = "N/A"
                OrdenDatos.Text = "N/A"
                DescripcionDatos.Text = "N/A"
                My.Settings.OrdenProduccion = 0
                My.Settings.Save()
            Else
                Dim Cadena As String = TextBox10.Text
                Dim Cadena2 As String = TextBox10.Text
                ParteDatos.Text = vb.Mid(Cadena, 14, 8)
                LoteDatos.Text = vb.Mid(Cadena2, 23, 8)
            End If
            'Actualiza lote y numero de parte
#End Region

#Region "Conteo de Ribbon"
            'Actualiza Conteo de Ribbon
            Dim conteo2 As New SqlDataAdapter("select*from Conteo", cn)
            Dim dsconteo2 As New DataSet
            conteo2.Fill(dsconteo2, "datos")
            Ribbon.Text = dsconteo2.Tables("datos").Rows(0).Item(0)
            'Actualiza Conteo de Ribbon

            cn.Close()
#End Region
#Region "Conteo de ribbon 2"
            cn.Open()
            'Actualiza Conteo de Ribbon
            Dim conteo3 As New SqlDataAdapter("select*from Conteo", cn)
            Dim dsconteo3 As New DataSet
            conteo3.Fill(dsconteo3, "datos")
            Ribbon.Text = dsconteo3.Tables("datos").Rows(0).Item(0)
            'Actualiza Conteo de Ribbon

            cn.Close()
#End Region

#End Region

            MsgBox("Licencias generadas con exito")


        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try
#End Region
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            PrintDocument1.PrintController = printController 'Se declara la variable para quitar cuadro de impresion 


#Region "Comentario"
            'TextBox7.Text = "Licencias"
            'If TextBox8.Text = "125 ml" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "1"
            'ElseIf TextBox8.Text = "250 ml" Then
            '    TextBox12.Text = TextBox11.Text ' comentario
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "2"
            'ElseIf TextBox8.Text = "500 ml" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "3"
            'ElseIf TextBox8.Text = "1 litro" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "4"
            'ElseIf TextBox8.Text = "4 litros" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "5"
            'ElseIf TextBox8.Text = "19 litros (5 Galones)" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "6"
            'ElseIf TextBox8.Text = "209 litros (55 Galones)" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "7"
            'ElseIf TextBox8.Text = "1042 litros (275 Galones)" Then
            '    TextBox12.Text = TextBox11.Text
            '    TextBox12.Text = TextBox12.Text + TextBox9.Text
            '    TextBox12.Text = TextBox12.Text + "8"

            'End If
#End Region
#Region "Configuracion impresora 2"
            'Configuracion Impresora
            PrintDocument2.PrinterSettings = PrintDialog2.PrinterSettings
            PrintDialog2.PrinterSettings.PrinterName = impresora
            ' PrintDialog2.PrinterSettings.PrinterName = "SATO CG408"
            ' PrintDialog2.PrinterSettings.PrinterName = "Send To OneNote 2016"
            PrintDialog2.PrinterSettings.Copies = 1
            PrintDialog2.PrinterSettings.Collate = False
            PrintDialog2.PrinterSettings.Duplex = Printing.Duplex.Simplex
            PrintDialog2.PrinterSettings.FromPage = 0
            PrintDocument2.DefaultPageSettings.Color = False
            PrintDocument2.DefaultPageSettings.Landscape = False
            PrintDialog2.PrinterSettings.ToPage = 0
            'Configuracion Impresora

#End Region
            If ParteDatos.Text = "N/A" Then
                MsgBox("No hay licencias cargadas")
            Else
                TextBox12.Text = OrdenDatos.Text
                TextBox7.Text = "Licencias"
                PrintDocument2.Print()
                MsgBox("Información Generada")
            End If





        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage


        Dim LAPIZ As New SolidBrush(TextBox3.ForeColor)
        Dim AREA_IMPRESION As Graphics = e.Graphics

        Dim POSICION As Point
        Dim TEXTO As String
        TEXTO = TextBox7.Text
        Dim FUENTE As Font
        Dim maximoE As String
        Dim maximoQR As String
        Dim medioQR As String
        Dim medioE As String

        maximoE = TextBox7.Width
        medioE = maximoE / 2
        maximoQR = PictureBox2.Image.Width
        medioQR = PictureBox2.Image.Width / 2



        'Selecciona textbox3 para configurar el tipo de letra
        FUENTE = New Font(TextBox12.Font, FontStyle.Bold)
        'Calcula la posicion para ser impresa en picturebox1

        POSICION = New Point(144, 105) 'Pruebas

        'Escribe etiqueta usando textbox1
        AREA_IMPRESION.DrawString(TextBox7.Text, TextBox3.Font, LAPIZ, POSICION)
        'Imprime el qr
        e.Graphics.DrawImage(PictureBox2.Image, 160, 20, 70, 70) 'Original 65,65





    End Sub


    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Try
            PictureBox2.Image = QR_Generator.Encode(TextBox12.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class