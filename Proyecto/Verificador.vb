Imports System.Data.SqlClient
Imports System.IO
Imports vb = Microsoft.VisualBasic
Imports Common
Public Class Verificador
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Public second As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OrdenO.Text = "" And DescripcionL.Text = "" Then
            MsgBox("Problemas al tratar de comparar")
        Else
#Region "Comparar"
            Try

#Region "Borrar informacion final"
                OrdenP.Text = ""
                DescripcionP.Text = ""
                LoteP.Text = ""
                ParteP.Text = ""
                VolumenP.Text = ""

                OrdenL.Text = ""
                DescripcionL.Text = ""
                LoteL.Text = ""
                ParteL.Text = ""
                VolumenL.Text = ""

                OrdenO.Text = ""
                DescripcionO.Text = ""
                LoteO.Text = ""
                ParteO.Text = ""
                VolumenO.Text = ""


                Panel3.BackColor = Color.White
                OrdenP.BackColor = Color.White
                DescripcionP.BackColor = Color.White
                LoteP.BackColor = Color.White
                ParteP.BackColor = Color.White
                VolumenP.BackColor = Color.White

#End Region

#Region "Orden de produccion"
#Region "Conectarse a SAP"

                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador8 As New SqlDataAdapter("select*from BaseDatosOficial where [Order]=" & Orden.Text & "", cn) 'Funciona con lote y material

                Dim ds As New DataSet
                adaptador8.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    OrdenO.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                    DescripcionO.Text = ds.Tables("datos").Rows(0).Item(9).ToString
                    LoteO.Text = ds.Tables("datos").Rows(0).Item(7).ToString
                    ParteO.Text = ds.Tables("datos").Rows(0).Item(8).ToString
                    VolumenO.Text = ds.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                    Panel6.BackColor = Color.LightBlue
                    Panel1.BackColor = Color.LightBlue
                    Panel9.BackColor = Color.LightBlue


                    OrdenO.BackColor = Color.LightBlue
                    DescripcionO.BackColor = Color.LightBlue
                    LoteO.BackColor = Color.LightBlue
                    ParteO.BackColor = Color.LightBlue
                    VolumenO.BackColor = Color.LightBlue
                    OrdenO.Enabled = True
                    DescripcionO.Enabled = True
                    LoteO.Enabled = True
                    ParteO.Enabled = True
                    VolumenO.Enabled = True
                Else
                    Panel6.BackColor = Color.LightGray
                    Panel1.BackColor = Color.LightGray
                    Panel9.BackColor = Color.LightGray

                    OrdenO.BackColor = Color.LightGray
                    DescripcionO.BackColor = Color.LightGray
                    LoteO.BackColor = Color.LightGray
                    ParteO.BackColor = Color.LightGray
                    VolumenO.BackColor = Color.LightGray
                End If
#End Region
#End Region

#Region "Codigo de botella"
#Region "Conectarse a SAP"

                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador5 As New SqlDataAdapter("select*from BaseDatosOficial where Codigo=" & "'" & Licencia.Text & "'" & "", cn) 'Funciona con lote y material
                Dim ds1 As New DataSet
                adaptador5.Fill(ds1, "datos")
#End Region

#Region "Pregunta"
                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds1.Tables("datos").Rows.Count > 0 Then
                    OrdenL.Text = ds1.Tables("datos").Rows(0).Item(6).ToString
                    DescripcionL.Text = ds1.Tables("datos").Rows(0).Item(9).ToString
                    LoteL.Text = ds1.Tables("datos").Rows(0).Item(7).ToString
                    ParteL.Text = ds1.Tables("datos").Rows(0).Item(8).ToString
                    VolumenL.Text = ds1.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                    Panel10.BackColor = Color.LightBlue
                    Panel5.BackColor = Color.LightBlue
                    Panel2.BackColor = Color.LightBlue


                    OrdenL.BackColor = Color.LightBlue
                    DescripcionL.BackColor = Color.LightBlue
                    LoteL.BackColor = Color.LightBlue
                    ParteL.BackColor = Color.LightBlue
                    VolumenL.BackColor = Color.LightBlue
                    OrdenL.Enabled = True
                    DescripcionL.Enabled = True
                    LoteL.Enabled = True
                    ParteL.Enabled = True
                    VolumenL.Enabled = True
                Else
                    Panel5.BackColor = Color.LightGray
                    Panel2.BackColor = Color.LightGray
                    Panel10.BackColor = Color.LightGray

                    OrdenL.BackColor = Color.LightGray
                    DescripcionL.BackColor = Color.LightGray
                    LoteL.BackColor = Color.LightGray
                    ParteL.BackColor = Color.LightGray
                    VolumenL.BackColor = Color.LightGray


                End If
#End Region
#End Region

#Region "Comparacion Datos"

                If OrdenO.Text = OrdenL.Text And DescripcionO.Text = DescripcionL.Text And LoteO.Text = LoteL.Text And ParteO.Text = ParteL.Text And VolumenO.Text = VolumenL.Text Then
                    OrdenP.Text = OrdenL.Text
                    DescripcionP.Text = DescripcionL.Text
                    LoteP.Text = LoteL.Text
                    ParteP.Text = ParteL.Text
                    VolumenP.Text = VolumenL.Text

                    Panel3.BackColor = Color.LightGreen
                    OrdenP.BackColor = Color.LightGreen
                    DescripcionP.BackColor = Color.LightGreen
                    LoteP.BackColor = Color.LightGreen
                    ParteP.BackColor = Color.LightGreen
                    VolumenP.BackColor = Color.LightGreen
                Else
                    Panel3.BackColor = Color.Red
                    OrdenP.BackColor = Color.Red
                    DescripcionP.BackColor = Color.Red
                    LoteP.BackColor = Color.Red
                    ParteP.BackColor = Color.Red
                    VolumenP.BackColor = Color.Red
                End If
#End Region
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
#End Region

        End If
    End Sub





    Private Sub Orden_TextChanged(sender As Object, e As EventArgs) Handles Orden.TextChanged
        Try


            Dim entrada As String
            Dim contador As Integer
            entrada = Orden.Text
            contador = Len(entrada)
            If contador = 1 Then
                Timer1.Start()
            End If

            If contador = 8 Then
                If IsNumeric(Orden.Text) Then
#Region "Orden de produccion"
#Region "Conectarse a SAP"

                    'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                    Dim adaptador As New SqlDataAdapter("select*from BaseDatosOficial where [Order]=" & Orden.Text & "", cn) 'Funciona con lote y material

                    Dim ds As New DataSet
                    adaptador.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds.Tables("datos").Rows.Count > 0 Then
                        OrdenO.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                        DescripcionO.Text = ds.Tables("datos").Rows(0).Item(9).ToString
                        LoteO.Text = ds.Tables("datos").Rows(0).Item(7).ToString
                        ParteO.Text = ds.Tables("datos").Rows(0).Item(8).ToString
                        VolumenO.Text = ds.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                        Panel6.BackColor = Color.LightBlue
                        Panel1.BackColor = Color.LightBlue
                        Panel9.BackColor = Color.LightBlue


                        OrdenO.BackColor = Color.LightBlue
                        DescripcionO.BackColor = Color.LightBlue
                        LoteO.BackColor = Color.LightBlue
                        ParteO.BackColor = Color.LightBlue
                        VolumenO.BackColor = Color.LightBlue
                        OrdenO.Enabled = True
                        DescripcionO.Enabled = True
                        LoteO.Enabled = True
                        ParteO.Enabled = True
                        VolumenO.Enabled = True
                    Else
                        Panel6.BackColor = Color.LightGray
                        Panel1.BackColor = Color.LightGray
                        Panel9.BackColor = Color.LightGray

                        OrdenO.BackColor = Color.LightGray
                        DescripcionO.BackColor = Color.LightGray
                        LoteO.BackColor = Color.LightGray
                        ParteO.BackColor = Color.LightGray
                        VolumenO.BackColor = Color.LightGray
                    End If
#End Region
#End Region
                    PictureBox1.Image = QR_Generator.Encode(Orden.Text)
                Else
                    MsgBox("QR Invalido")
                    Orden.Text = ""
                    Button6.Focus()
                End If
            End If
            CircularProgressBar2.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Licencia_TextChanged(sender As Object, e As EventArgs) Handles Licencia.TextChanged
        Try

            Dim entrada As String
            Dim contador As Integer
            entrada = Licencia.Text
            contador = Len(entrada)
            If contador = 1 Then
                Timer2.Start()
            End If



            If contador = 30 Then
                If IsNumeric(Licencia.Text) Then

                    MsgBox("QR Invalido")
                    Licencia.Text = ""
                    Button7.Focus()
                Else
#Region "Codigo de botella"
#Region "Conectarse a SAP"

                    'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                    Dim adaptador1 As New SqlDataAdapter("select*from BaseDatosOficial where Codigo=" & "'" & Licencia.Text & "'" & "", cn) 'Funciona con lote y material
                    Dim ds1 As New DataSet
                    adaptador1.Fill(ds1, "datos")
#End Region

#Region "Pregunta"
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds1.Tables("datos").Rows.Count > 0 Then
                        OrdenL.Text = ds1.Tables("datos").Rows(0).Item(6).ToString
                        DescripcionL.Text = ds1.Tables("datos").Rows(0).Item(9).ToString
                        LoteL.Text = ds1.Tables("datos").Rows(0).Item(7).ToString
                        ParteL.Text = ds1.Tables("datos").Rows(0).Item(8).ToString
                        VolumenL.Text = ds1.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                        Panel10.BackColor = Color.LightBlue
                        Panel5.BackColor = Color.LightBlue
                        Panel2.BackColor = Color.LightBlue


                        If OrdenO.Text = "" Then

                        Else

#Region "Comparar"
                            Try

#Region "Borrar informacion final"
                                OrdenP.Text = ""
                                DescripcionP.Text = ""
                                LoteP.Text = ""
                                ParteP.Text = ""
                                VolumenP.Text = ""

                                OrdenL.Text = ""
                                DescripcionL.Text = ""
                                LoteL.Text = ""
                                ParteL.Text = ""
                                VolumenL.Text = ""

                                OrdenO.Text = ""
                                DescripcionO.Text = ""
                                LoteO.Text = ""
                                ParteO.Text = ""
                                VolumenO.Text = ""


                                Panel3.BackColor = Color.White
                                OrdenP.BackColor = Color.White
                                DescripcionP.BackColor = Color.White
                                LoteP.BackColor = Color.White
                                ParteP.BackColor = Color.White
                                VolumenP.BackColor = Color.White

#End Region

#Region "Orden de produccion"
#Region "Conectarse a SAP"

                                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                                Dim adaptador8 As New SqlDataAdapter("select*from BaseDatosOficial where [Order]=" & Orden.Text & "", cn) 'Funciona con lote y material

                                Dim ds As New DataSet
                                adaptador8.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                                If ds.Tables("datos").Rows.Count > 0 Then
                                    OrdenO.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                                    DescripcionO.Text = ds.Tables("datos").Rows(0).Item(9).ToString
                                    LoteO.Text = ds.Tables("datos").Rows(0).Item(7).ToString
                                    ParteO.Text = ds.Tables("datos").Rows(0).Item(8).ToString
                                    VolumenO.Text = ds.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                                    Panel6.BackColor = Color.LightBlue
                                    Panel1.BackColor = Color.LightBlue
                                    Panel9.BackColor = Color.LightBlue


                                    OrdenO.BackColor = Color.LightBlue
                                    DescripcionO.BackColor = Color.LightBlue
                                    LoteO.BackColor = Color.LightBlue
                                    ParteO.BackColor = Color.LightBlue
                                    VolumenO.BackColor = Color.LightBlue
                                    OrdenO.Enabled = True
                                    DescripcionO.Enabled = True
                                    LoteO.Enabled = True
                                    ParteO.Enabled = True
                                    VolumenO.Enabled = True
                                Else
                                    Panel6.BackColor = Color.LightGray
                                    Panel1.BackColor = Color.LightGray
                                    Panel9.BackColor = Color.LightGray

                                    OrdenO.BackColor = Color.LightGray
                                    DescripcionO.BackColor = Color.LightGray
                                    LoteO.BackColor = Color.LightGray
                                    ParteO.BackColor = Color.LightGray
                                    VolumenO.BackColor = Color.LightGray
                                End If
#End Region
#End Region

#Region "Codigo de botella"
#Region "Conectarse a SAP"

                                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                                Dim adaptador5 As New SqlDataAdapter("select*from BaseDatosOficial where Codigo=" & "'" & Licencia.Text & "'" & "", cn) 'Funciona con lote y material
                                Dim ds9 As New DataSet
                                adaptador5.Fill(ds9, "datos")
#End Region

#Region "Pregunta"
                                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                                If ds9.Tables("datos").Rows.Count > 0 Then
                                    OrdenL.Text = ds9.Tables("datos").Rows(0).Item(6).ToString
                                    DescripcionL.Text = ds9.Tables("datos").Rows(0).Item(9).ToString
                                    LoteL.Text = ds9.Tables("datos").Rows(0).Item(7).ToString
                                    ParteL.Text = ds9.Tables("datos").Rows(0).Item(8).ToString
                                    VolumenL.Text = ds9.Tables("datos").Rows(0).Item(4).ToString 'Orden de produccion
                                    Panel10.BackColor = Color.LightBlue
                                    Panel5.BackColor = Color.LightBlue
                                    Panel2.BackColor = Color.LightBlue


                                    OrdenL.BackColor = Color.LightBlue
                                    DescripcionL.BackColor = Color.LightBlue
                                    LoteL.BackColor = Color.LightBlue
                                    ParteL.BackColor = Color.LightBlue
                                    VolumenL.BackColor = Color.LightBlue
                                    OrdenL.Enabled = True
                                    DescripcionL.Enabled = True
                                    LoteL.Enabled = True
                                    ParteL.Enabled = True
                                    VolumenL.Enabled = True
                                Else
                                    Panel5.BackColor = Color.LightGray
                                    Panel2.BackColor = Color.LightGray
                                    Panel10.BackColor = Color.LightGray

                                    OrdenL.BackColor = Color.LightGray
                                    DescripcionL.BackColor = Color.LightGray
                                    LoteL.BackColor = Color.LightGray
                                    ParteL.BackColor = Color.LightGray
                                    VolumenL.BackColor = Color.LightGray


                                End If
#End Region
#End Region

#Region "Comparacion Datos"

                                If OrdenO.Text = OrdenL.Text And DescripcionO.Text = DescripcionL.Text And LoteO.Text = LoteL.Text And ParteO.Text = ParteL.Text And VolumenO.Text = VolumenL.Text Then
                                    OrdenP.Text = OrdenL.Text
                                    DescripcionP.Text = DescripcionL.Text
                                    LoteP.Text = LoteL.Text
                                    ParteP.Text = ParteL.Text
                                    VolumenP.Text = VolumenL.Text

                                    Panel3.BackColor = Color.LightGreen
                                    OrdenP.BackColor = Color.LightGreen
                                    DescripcionP.BackColor = Color.LightGreen
                                    LoteP.BackColor = Color.LightGreen
                                    ParteP.BackColor = Color.LightGreen
                                    VolumenP.BackColor = Color.LightGreen
                                Else
                                    Panel3.BackColor = Color.Red
                                    OrdenP.BackColor = Color.Red
                                    DescripcionP.BackColor = Color.Red
                                    LoteP.BackColor = Color.Red
                                    ParteP.BackColor = Color.Red
                                    VolumenP.BackColor = Color.Red
                                End If
#End Region
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
#End Region

                        End If




                        OrdenL.BackColor = Color.LightBlue
                        DescripcionL.BackColor = Color.LightBlue
                        LoteL.BackColor = Color.LightBlue
                        ParteL.BackColor = Color.LightBlue
                        VolumenL.BackColor = Color.LightBlue
                        OrdenL.Enabled = True
                        DescripcionL.Enabled = True
                        LoteL.Enabled = True
                        ParteL.Enabled = True
                        VolumenL.Enabled = True








                    Else
                        Panel5.BackColor = Color.LightGray
                        Panel2.BackColor = Color.LightGray
                        Panel10.BackColor = Color.LightGray

                        OrdenL.BackColor = Color.LightGray
                        DescripcionL.BackColor = Color.LightGray
                        LoteL.BackColor = Color.LightGray
                        ParteL.BackColor = Color.LightGray
                        VolumenL.BackColor = Color.LightGray


                    End If
#End Region
#End Region
                    PictureBox2.Image = QR_Generator.Encode(Licencia.Text)

                End If
            End If

            CircularProgressBar1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Timer1.Stop()
        Orden.Text = ""
        TextBox1.Text = 0
        Orden.Focus()


        OrdenO.Text = ""
        DescripcionO.Text = ""
        LoteO.Text = ""
        ParteO.Text = ""
        VolumenO.Text = ""
#Region "Restablecer color"

        Panel6.BackColor = Color.White
        Panel1.BackColor = Color.White
        Panel9.BackColor = Color.White


        OrdenO.BackColor = Color.White
        DescripcionO.BackColor = Color.White
        LoteO.BackColor = Color.White
        ParteO.BackColor = Color.White
        VolumenO.BackColor = Color.White
        OrdenO.Enabled = False
        DescripcionO.Enabled = False
        LoteO.Enabled = False
        ParteO.Enabled = False
        VolumenO.Enabled = False
#End Region
        CircularProgressBar2.Visible = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click





        Timer2.Stop()
        Licencia.Text = ""
        TextBox2.Text = 0
        Licencia.Focus()
        OrdenL.Text = ""
        DescripcionL.Text = ""
        LoteL.Text = ""
        ParteL.Text = ""
        VolumenL.Text = ""
#Region "Restablecer color"
        Panel10.BackColor = Color.White
        Panel5.BackColor = Color.White
        Panel2.BackColor = Color.White


        OrdenL.BackColor = Color.White
        DescripcionL.BackColor = Color.White
        LoteL.BackColor = Color.White
        ParteL.BackColor = Color.White
        VolumenL.BackColor = Color.White
        OrdenL.Enabled = False
        DescripcionL.Enabled = False
        LoteL.Enabled = False
        ParteL.Enabled = False
        VolumenL.Enabled = False
#End Region
        CircularProgressBar1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 500
        TextBox1.Text = TextBox1.Text + 1
        Dim entrada As String
        Dim contador As Integer
        entrada = Orden.Text
        contador = Len(entrada)

        If TextBox1.Text = 1 Then



            If contador < 8 Then
                MsgBox("Favor utilizar el scaner")

                TextBox1.Text = 0
                Orden.Text = ""
                Timer1.Stop()

            End If
            If contador >= 9 Then
                MsgBox("Favor utilizar el scaner")

                TextBox1.Text = 0
                Orden.Text = ""
                Timer1.Stop()
            End If

            Button6.Focus()


        End If
        If TextBox1.Text = 2 Then
            TextBox1.Text = 0
            Timer1.Stop()

        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 500
        TextBox2.Text = TextBox2.Text + 1
        Dim entrada As String
        Dim contador As Integer
        entrada = Licencia.Text
        contador = Len(entrada)

        If TextBox2.Text = 1 Then

            If contador < 30 Then
                MsgBox("QR Invalido")
                Timer2.Stop()
                TextBox2.Text = 0
                Licencia.Text = ""

            End If
            If contador >= 31 Then
                MsgBox("Favor utilizar el scaner")
                Timer2.Stop()
                TextBox2.Text = 0
                Licencia.Text = ""
            End If
        End If
    End Sub




    Private Sub Verificador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Orden_LostFocus(sender As Object, e As EventArgs) Handles Orden.LostFocus
        CircularProgressBar2.Visible = False
    End Sub

    Private Sub Licencia_LostFocus(sender As Object, e As EventArgs) Handles Licencia.LostFocus
        CircularProgressBar1.Visible = False
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Timer1.Stop()
        Orden.Text = ""
        TextBox1.Text = 0
        Orden.Focus()


        OrdenO.Text = ""
        DescripcionO.Text = ""
        LoteO.Text = ""
        ParteO.Text = ""
        VolumenO.Text = ""
#Region "Restablecer color"

        Panel6.BackColor = Color.White
        Panel1.BackColor = Color.White
        Panel9.BackColor = Color.White


        OrdenO.BackColor = Color.White
        DescripcionO.BackColor = Color.White
        LoteO.BackColor = Color.White
        ParteO.BackColor = Color.White
        VolumenO.BackColor = Color.White
        OrdenO.Enabled = False
        DescripcionO.Enabled = False
        LoteO.Enabled = False
        ParteO.Enabled = False
        VolumenO.Enabled = False
#End Region


        If RadioButton1.Checked Then
            If My.Settings.OrdenProduccion = 0 Then
                MsgBox("No hay ninguna orden cargada")
                Button6.Enabled = Enabled
                RadioButton1.Checked = False
                Exit Sub
            End If
            Button6.Enabled = False
            Orden.Text = My.Settings.OrdenProduccion
        End If
        If RadioButton1.Checked = False Then
            Button6.Enabled = Enabled

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then

            Button6.Enabled = False
            Orden.Text = My.Settings.UltimaOrden
        End If
    End Sub







End Class