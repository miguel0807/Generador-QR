
Imports System.Data.SqlClient
    Imports vb = Microsoft.VisualBasic

Public Class _4_litros
    Public tiempo As Integer = 0
    Public basedatos(1) As String
    Public manual As Boolean = False
    Dim caja As String
    Dim orden As String

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles refrescar2.Click
        MaskedTextBox2.Text = ""
        bueno2.Visible = False
        igual2.Visible = False
        equis2.Visible = False
        refrescar2.Visible = False

        MaskedTextBox2.ReadOnly = False
        MaskedTextBox2.Enabled = True
        MaskedTextBox2.Focus()

        MaskedTextBox2.BackColor = Color.White
        manual = True



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botoncaja.Click
        textboxcaja.Text = ""



        botonAutomatico.Enabled = False
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()

        txtBasedatos2.Clear()
        txtBasedatos1.Clear()
        textboxcaja.Enabled = True
        textboxcaja.Focus()


        igual1.Visible = False
        igual2.Visible = False



        bueno1.Visible = False
        bueno2.Visible = False


        txtBasedatos1.BackColor = SystemColors.Control
        txtBasedatos2.BackColor = SystemColors.Control

        Label1.Text = "Caja # "

    End Sub



    Private Sub caja_LostFocus(sender As Object, e As EventArgs) Handles textboxcaja.LostFocus
        CircularProgressBar1.Visible = False
        Timer1.Enabled = False
        textboxcaja.Enabled = False
    End Sub

    Private Sub caja_TextChanged(sender As Object, e As EventArgs) Handles textboxcaja.TextChanged
        Try


            Dim entrada As String
            Dim contador As Integer
            entrada = textboxcaja.Text
            contador = Len(entrada)
            If contador = 1 Then
                Timer1.Start()
            End If

            If contador = 13 Then
                If IsNumeric(textboxcaja.Text) Then

                    botonAutomatico.Enabled = True

                    Dim extraccion As String = textboxcaja.Text


                    orden = vb.Mid(extraccion, 1, 8)
                    caja = vb.Mid(extraccion, 9, 5)
                    Label1.Text = "Caja #" & (caja - 90000)

#Region "Orden de produccion"
#Region "Conectarse a SAP"

                    'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                    Dim adaptador As New SqlDataAdapter("select * from BaseDatosOficial where [Order]=" & orden & " and [Verificado]=" & 0 & " and [Caja]=" & caja & "", cn) 'Funciona con lote y material



                    Dim ds As New DataSet
                    adaptador.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds.Tables("datos").Rows.Count > 0 Then
                        txtBasedatos1.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                        txtBasedatos2.Text = ds.Tables("datos").Rows(1).Item(1).ToString




                        basedatos(0) = txtBasedatos1.Text
                        basedatos(1) = txtBasedatos2.Text



                    Else

                        MsgBox("La caja ya se encuentra registrada")
                        botoncaja.Focus()
                        botonAutomatico.Enabled = False
                        Label1.Text = "Caja # "
                        Exit Sub
                    End If
#End Region
#End Region

                Else
                    MsgBox("QR Invalido")
                    textboxcaja.Text = ""
                    botoncaja.Focus()
                End If
            End If
            CircularProgressBar1.Visible = False
            botonAutomatico.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 500
        controlTimer.Text = controlTimer.Text + 1
        Dim entrada As String
        Dim contador As Integer
        entrada = textboxcaja.Text
        contador = Len(entrada)

        If controlTimer.Text = 6 Then



            If contador < 11 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
                botoncaja.Focus()
            End If
            If contador >= 14 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
                botoncaja.Focus()
            End If




        End If
        If controlTimer.Text = 7 Then
            controlTimer.Text = 0
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonAutomatico.Click




        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()



        MaskedTextBox1.BackColor = Color.White
        MaskedTextBox2.BackColor = Color.White


        MaskedTextBox1.Enabled = True
        MaskedTextBox1.Focus()
        tiempo = 0


        igual1.Visible = False
        igual2.Visible = False


        bueno1.Visible = False
        bueno2.Visible = False


        refrescar1.Visible = False
        refrescar2.Visible = False


        equis1.Visible = False
        equis2.Visible = False


        txtBasedatos1.BackColor = SystemColors.Control
        txtBasedatos2.BackColor = SystemColors.Control


        manual = False
    End Sub





    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.LostFocus
        CircularProgressBar2.Visible = False
        Botella1.Enabled = False
        tiempo = 0
        MaskedTextBox1.Enabled = False



    End Sub




    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox1.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then


            Botella1.Enabled = True
            For Each elemento As String In basedatos
                If MaskedTextBox1.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 



                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False

                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If



                End If
                If MaskedTextBox1.Text = MaskedTextBox2.Text Then
                    MaskedTextBox1.BackColor = Color.LightSlateGray
                    bueno1.Visible = False
                    equis1.Visible = False
                    igual1.Visible = True
                    refrescar1.Visible = True
                End If



                If MaskedTextBox1.Text = txtBasedatos1.Text Or MaskedTextBox1.Text = txtBasedatos2.Text Then

                Else
                    MaskedTextBox1.BackColor = Color.LightSlateGray
                    igual1.Visible = False
                    bueno1.Visible = False
                    equis1.Visible = True
                    refrescar1.Visible = True

                End If

            Next
        End If




    End Sub



    Private Sub MaskedTextBox2_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.LostFocus





        CircularProgressBar3.Visible = False
        Botella2.Enabled = False
        tiempo = 0
        MaskedTextBox2.Enabled = False

    End Sub

    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.GotFocus

        CircularProgressBar3.Visible = True

        MaskedTextBox2.Clear()
    End Sub












    Private Sub MaskedTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox2.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox2.Text
        contador2 = Len(entrada1)


        If contador2 = 14 Then

            Botella2.Enabled = True




            For Each elemento As String In basedatos
                If MaskedTextBox2.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then

                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False


                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If






                End If

                If MaskedTextBox2.Text = MaskedTextBox1.Text Then
                    MaskedTextBox2.BackColor = Color.LightSlateGray
                    bueno2.Visible = False
                    equis2.Visible = False
                    igual2.Visible = True
                    refrescar2.Visible = True


                End If
                If MaskedTextBox2.Text = txtBasedatos1.Text Or MaskedTextBox2.Text = txtBasedatos2.Text Then

                Else
                    MaskedTextBox2.BackColor = Color.LightSlateGray
                    igual2.Visible = False
                    bueno2.Visible = False
                    equis2.Visible = True
                    refrescar2.Visible = True

                End If
            Next



        End If
    End Sub



    Private Sub Botella1_Tick(sender As Object, e As EventArgs) Handles Botella1.Tick


        Botella1.Interval = 500

        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox2.Enabled = True
                MaskedTextBox2.Focus()
            End If

        Else
            botonAutomatico.Focus()
        End If


        If bueno1.Visible = True And bueno2.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub Botella2_Tick(sender As Object, e As EventArgs) Handles Botella2.Tick
        Botella2.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                botonAutomatico.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If


        If bueno1.Visible = True And bueno2.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If

        tiempo = tiempo + 1
    End Sub




    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.GotFocus
        If manual = False Then
            CircularProgressBar2.Visible = True
        End If
        MaskedTextBox1.Clear()


    End Sub

    Private Sub textboxcaja_GotFocus(sender As Object, e As EventArgs) Handles textboxcaja.GotFocus
        CircularProgressBar1.Visible = True
    End Sub


    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles refrescar1.Click
        MaskedTextBox1.Text = ""
        bueno1.Visible = False
        igual1.Visible = False
        equis1.Visible = False
        refrescar1.Visible = False

        MaskedTextBox1.ReadOnly = False
        MaskedTextBox1.Enabled = True
        MaskedTextBox1.Focus()
        MaskedTextBox1.BackColor = Color.White
        manual = True




    End Sub








    Private Sub OrdenVerificacion_Click(sender As Object, e As EventArgs) Handles botonVerificacionOrden.Click
        MaskedTextBox7.Enabled = True
        MaskedTextBox7.Clear()
        MaskedTextBox7.Focus()
        DataGridView1.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub _4_litros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class