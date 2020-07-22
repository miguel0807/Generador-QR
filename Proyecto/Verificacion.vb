Imports System.Data.SqlClient
Imports vb = Microsoft.VisualBasic

Public Class Verificacion
    Public tiempo As Integer = 0
    Public basedatos(5) As String
    Public manual As Boolean = False
    Dim caja As String

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        MaskedTextBox2.Text = ""
        PictureBox8.Visible = False
        PictureBox2.Visible = False
        MaskedTextBox2.ReadOnly = False
        MaskedTextBox2.Enabled = True
        MaskedTextBox2.Focus()
        PictureBox14.Visible = False
        MaskedTextBox2.BackColor = Color.White
        manual = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textboxcaja.Text = ""



        Automatico.Enabled = False
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()
        MaskedTextBox4.Clear()
        MaskedTextBox5.Clear()
        MaskedTextBox6.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        textboxcaja.Enabled = True
        textboxcaja.Focus()


        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False


        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False

        TextBox14.BackColor = SystemColors.Control
        TextBox13.BackColor = SystemColors.Control
        TextBox12.BackColor = SystemColors.Control
        TextBox11.BackColor = SystemColors.Control
        TextBox10.BackColor = SystemColors.Control
        TextBox9.BackColor = SystemColors.Control

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

                    Automatico.Enabled = True

                    Dim extraccion As String = textboxcaja.Text
                    Dim orden As String

                    orden = vb.Mid(extraccion, 1, 8)
                    caja = vb.Mid(extraccion, 9, 5)
                    Label1.Text = "Caja #" & (caja - 90000)

#Region "Orden de produccion"
#Region "Conectarse a SAP"

                    'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                    Dim adaptador As New SqlDataAdapter("select * from BaseDatosOficial where [Order]=" & orden & " and [Caja]=" & caja & "", cn) 'Funciona con lote y material



                    Dim ds As New DataSet
                    adaptador.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds.Tables("datos").Rows.Count > 0 Then
                        TextBox14.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                        TextBox13.Text = ds.Tables("datos").Rows(1).Item(1).ToString
                        TextBox12.Text = ds.Tables("datos").Rows(2).Item(1).ToString
                        TextBox11.Text = ds.Tables("datos").Rows(3).Item(1).ToString
                        TextBox10.Text = ds.Tables("datos").Rows(4).Item(1).ToString
                        TextBox9.Text = ds.Tables("datos").Rows(5).Item(1).ToString



                        basedatos(0) = TextBox14.Text
                        basedatos(1) = TextBox13.Text
                        basedatos(2) = TextBox12.Text
                        basedatos(3) = TextBox11.Text
                        basedatos(4) = TextBox10.Text
                        basedatos(5) = TextBox9.Text


                    Else

                        MsgBox(orden)
                    End If
#End Region
#End Region

                Else
                    MsgBox("QR Invalido")
                    textboxcaja.Text = ""
                    Button2.Focus()
                End If
            End If
            CircularProgressBar1.Visible = False
            Automatico.Focus()
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
                Button2.Focus()
            End If
            If contador >= 14 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
                Button2.Focus()
            End If




        End If
        If controlTimer.Text = 7 Then
            controlTimer.Text = 0
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Automatico.Click




        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()
        MaskedTextBox4.Clear()
        MaskedTextBox5.Clear()
        MaskedTextBox6.Clear()


        MaskedTextBox1.BackColor = Color.White
        MaskedTextBox2.BackColor = Color.White
        MaskedTextBox3.BackColor = Color.White
        MaskedTextBox4.BackColor = Color.White
        MaskedTextBox5.BackColor = Color.White
        MaskedTextBox6.BackColor = Color.White

        MaskedTextBox1.Enabled = True
        MaskedTextBox1.Focus()
        tiempo = 0


        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False

        TextBox14.BackColor = SystemColors.Control
        TextBox13.BackColor = SystemColors.Control
        TextBox12.BackColor = SystemColors.Control
        TextBox11.BackColor = SystemColors.Control
        TextBox10.BackColor = SystemColors.Control
        TextBox9.BackColor = SystemColors.Control

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


            For Each elemento As String In basedatos
                If MaskedTextBox1.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 
                    If manual = False Then
                        Botella1.Enabled = True
                    End If
                    PictureBox13.Visible = True
                        If ret = 0 Then
                            TextBox14.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If

                        If ret = 1 Then
                            TextBox13.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If

                        If ret = 2 Then
                            TextBox12.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If

                        If ret = 3 Then
                            TextBox11.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If

                        If ret = 4 Then
                            TextBox10.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If

                        If ret = 5 Then
                            TextBox9.BackColor = Color.ForestGreen
                            PictureBox7.Visible = True
                            PictureBox13.Visible = False
                        End If



                        If MaskedTextBox1.Text = MaskedTextBox2.Text Or MaskedTextBox1.Text = MaskedTextBox3.Text Or MaskedTextBox1.Text = MaskedTextBox4.Text Or MaskedTextBox1.Text = MaskedTextBox5.Text Or MaskedTextBox1.Text = MaskedTextBox6.Text Then
                            MaskedTextBox1.BackColor = Color.LightSlateGray
                            PictureBox7.Visible = False
                            PictureBox1.Visible = True
                            PictureBox13.Visible = True
                        End If
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



    Private Sub MaskedTextBox3_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.GotFocus
        If manual = False Then
            CircularProgressBar4.Visible = True
        End If
        MaskedTextBox3.Clear()
    End Sub

    Private Sub MaskedTextBox3_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.LostFocus
        CircularProgressBar4.Visible = False
        Botella3.Enabled = False
        tiempo = 0
        MaskedTextBox3.Enabled = False

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
                        TextBox14.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False

                    End If

                    If ret = 1 Then
                        TextBox13.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False
                    End If

                    If ret = 2 Then
                        TextBox12.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False
                    End If

                    If ret = 3 Then
                        TextBox11.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False
                    End If

                    If ret = 4 Then
                        TextBox10.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False
                    End If

                    If ret = 5 Then
                        TextBox9.BackColor = Color.ForestGreen
                        PictureBox8.Visible = True
                        PictureBox14.Visible = False
                    End If


                    If MaskedTextBox2.Text = MaskedTextBox1.Text Or MaskedTextBox2.Text = MaskedTextBox3.Text Or MaskedTextBox2.Text = MaskedTextBox4.Text Or MaskedTextBox2.Text = MaskedTextBox5.Text Or MaskedTextBox2.Text = MaskedTextBox6.Text Then
                        MaskedTextBox2.BackColor = Color.LightSlateGray
                        PictureBox8.Visible = False
                        PictureBox2.Visible = True
                        PictureBox14.Visible = True


                    End If
                End If
            Next
        End If
    End Sub





    Private Sub MaskedTextBox3_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox3.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox3.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella3.Enabled = True



            For Each elemento As String In basedatos
                If MaskedTextBox3.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        TextBox14.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                        PictureBox15.Visible = False
                    End If

                    If ret = 1 Then
                        TextBox13.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                        PictureBox15.Visible = False
                    End If

                    If ret = 2 Then
                        TextBox12.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                    End If

                    If ret = 3 Then
                        TextBox11.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                        PictureBox15.Visible = False
                    End If

                    If ret = 4 Then
                        TextBox10.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                        PictureBox15.Visible = False
                    End If

                    If ret = 5 Then
                        TextBox9.BackColor = Color.ForestGreen
                        PictureBox9.Visible = True
                        PictureBox15.Visible = False
                    End If
                    If MaskedTextBox3.Text = MaskedTextBox1.Text Or MaskedTextBox3.Text = MaskedTextBox2.Text Or MaskedTextBox3.Text = MaskedTextBox4.Text Or MaskedTextBox3.Text = MaskedTextBox5.Text Or MaskedTextBox3.Text = MaskedTextBox6.Text Then
                        MaskedTextBox3.BackColor = Color.LightSlateGray
                        PictureBox9.Visible = False
                        PictureBox3.Visible = True
                        PictureBox15.Visible = True



                    End If
                End If
            Next
        End If
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Botella3_Tick(sender As Object, e As EventArgs) Handles Botella3.Tick
        Botella3.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox4.Enabled = True
                MaskedTextBox4.Focus()
            End If
        Else
            Automatico.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub Botella1_Tick(sender As Object, e As EventArgs) Handles Botella1.Tick

        Botella1.Interval = 300
        If tiempo = 1 Then
            MaskedTextBox2.Enabled = True
            MaskedTextBox2.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub Botella2_Tick(sender As Object, e As EventArgs) Handles Botella2.Tick

        Botella2.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox3.Enabled = True
                MaskedTextBox3.Focus()
            End If
        Else
            Automatico.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If

        tiempo = tiempo + 1
    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox4.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox4_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox4.GotFocus
        If manual = False Then
            CircularProgressBar5.Visible = True
        End If
        MaskedTextBox4.Clear()
    End Sub

    Private Sub MaskedTextBox4_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox4.LostFocus
        CircularProgressBar5.Visible = False
        Botella4.Enabled = False
        tiempo = 0
        MaskedTextBox4.Enabled = False

    End Sub

    Private Sub Botella4_Tick(sender As Object, e As EventArgs) Handles Botella4.Tick
        Botella4.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox5.Enabled = True
                MaskedTextBox5.Focus()
            End If
        Else
            Automatico.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub MaskedTextBox4_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox4.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox4.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella4.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox4.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        TextBox14.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If

                    If ret = 1 Then
                        TextBox13.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If

                    If ret = 2 Then
                        TextBox12.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If

                    If ret = 3 Then
                        TextBox11.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If

                    If ret = 4 Then
                        TextBox10.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If

                    If ret = 5 Then
                        TextBox9.BackColor = Color.ForestGreen
                        PictureBox10.Visible = True
                        PictureBox16.Visible = False
                    End If
                    If MaskedTextBox4.Text = MaskedTextBox1.Text Or MaskedTextBox4.Text = MaskedTextBox2.Text Or MaskedTextBox4.Text = MaskedTextBox3.Text Or MaskedTextBox4.Text = MaskedTextBox5.Text Or MaskedTextBox4.Text = MaskedTextBox6.Text Then
                        MaskedTextBox4.BackColor = Color.LightSlateGray
                        PictureBox10.Visible = False
                        PictureBox4.Visible = True
                        PictureBox16.Visible = True


                    End If
                End If
            Next
        End If
    End Sub

    Private Sub MaskedTextBox5_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox5.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox5_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox5.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox5.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella5.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox5.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        TextBox14.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If

                    If ret = 1 Then
                        TextBox13.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If

                    If ret = 2 Then
                        TextBox12.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If

                    If ret = 3 Then
                        TextBox11.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If

                    If ret = 4 Then
                        TextBox10.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If

                    If ret = 5 Then
                        TextBox9.BackColor = Color.ForestGreen
                        PictureBox11.Visible = True
                        PictureBox17.Visible = False
                    End If
                    If MaskedTextBox5.Text = MaskedTextBox1.Text Or MaskedTextBox5.Text = MaskedTextBox2.Text Or MaskedTextBox5.Text = MaskedTextBox3.Text Or MaskedTextBox5.Text = MaskedTextBox4.Text Or MaskedTextBox5.Text = MaskedTextBox6.Text Then
                        MaskedTextBox5.BackColor = Color.LightSlateGray
                        PictureBox11.Visible = False
                        PictureBox5.Visible = True
                        PictureBox17.Visible = True


                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Botella5_Tick(sender As Object, e As EventArgs) Handles Botella5.Tick
        Botella5.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox6.Enabled = True
                MaskedTextBox6.Focus()
            End If
        Else
            Automatico.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub MaskedTextBox5_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox5.LostFocus
        CircularProgressBar6.Visible = False
        Botella5.Enabled = False
        tiempo = 0
        MaskedTextBox5.Enabled = False

    End Sub

    Private Sub MaskedTextBox5_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox5.GotFocus
        If manual = False Then
            CircularProgressBar6.Visible = True
        End If
        MaskedTextBox5.Clear()
    End Sub

    Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox6_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox6.GotFocus
        If manual = False Then
            CircularProgressBar7.Visible = True
        End If
        MaskedTextBox6.Clear()
    End Sub

    Private Sub MaskedTextBox6_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox6.LostFocus
        CircularProgressBar7.Visible = False
        Botella6.Enabled = False
        tiempo = 0
        MaskedTextBox6.Enabled = False

    End Sub

    Private Sub Botella6_Tick(sender As Object, e As EventArgs) Handles Botella6.Tick
        Botella6.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                Automatico.Focus()
            End If
        Else
            Automatico.Focus()
        End If
        If PictureBox7.Visible = True And PictureBox8.Visible = True And PictureBox9.Visible = True And PictureBox10.Visible = True And PictureBox11.Visible = True And PictureBox12.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()
            MsgBox("TODO COMPLETO")
        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub MaskedTextBox6_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox6.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox6.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella6.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox6.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        TextBox14.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If

                    If ret = 1 Then
                        TextBox13.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If

                    If ret = 2 Then
                        TextBox12.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If

                    If ret = 3 Then
                        TextBox11.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If

                    If ret = 4 Then
                        TextBox10.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If

                    If ret = 5 Then
                        TextBox9.BackColor = Color.ForestGreen
                        PictureBox12.Visible = True
                        PictureBox18.Visible = False
                    End If
                    If MaskedTextBox6.Text = MaskedTextBox1.Text Or MaskedTextBox6.Text = MaskedTextBox2.Text Or MaskedTextBox6.Text = MaskedTextBox3.Text Or MaskedTextBox6.Text = MaskedTextBox4.Text Or MaskedTextBox5.Text = MaskedTextBox6.Text Then
                        MaskedTextBox6.BackColor = Color.LightSlateGray
                        PictureBox12.Visible = False
                        PictureBox6.Visible = True
                        PictureBox18.Visible = True


                    End If
                End If
            Next
        End If
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

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub MaskedTextBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles MaskedTextBox4.MouseClick

    End Sub

    Private Sub MaskedTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles MaskedTextBox1.MouseClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CircularProgressBar2_Click(sender As Object, e As EventArgs) Handles CircularProgressBar2.Click

    End Sub

    Private Sub MaskedTextBox1_RightToLeftChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.RightToLeftChanged

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        MaskedTextBox1.Text = ""
        PictureBox7.Visible = False
        PictureBox1.Visible = False
        MaskedTextBox1.ReadOnly = False
        MaskedTextBox1.Focus()

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        MaskedTextBox3.Text = ""
        PictureBox9.Visible = False
        PictureBox3.Visible = False
        MaskedTextBox3.ReadOnly = False
        MaskedTextBox3.Enabled = True
        MaskedTextBox3.Focus()
        PictureBox15.Visible = False
        MaskedTextBox3.BackColor = Color.White
        manual = True
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        MaskedTextBox4.Text = ""
        PictureBox10.Visible = False
        PictureBox4.Visible = False
        MaskedTextBox4.ReadOnly = False
        MaskedTextBox4.Enabled = True
        MaskedTextBox4.Focus()
        PictureBox16.Visible = False
        MaskedTextBox4.BackColor = Color.White
        manual = True
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        MaskedTextBox5.Text = ""
        PictureBox11.Visible = False
        PictureBox5.Visible = False
        MaskedTextBox5.ReadOnly = False
        MaskedTextBox5.Enabled = True
        MaskedTextBox5.Focus()
        PictureBox17.Visible = False
        MaskedTextBox5.BackColor = Color.White
        manual = True
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        MaskedTextBox6.Text = ""
        PictureBox12.Visible = False
        PictureBox6.Visible = False
        MaskedTextBox6.ReadOnly = False
        MaskedTextBox6.Enabled = True
        MaskedTextBox6.Focus()
        PictureBox18.Visible = False
        MaskedTextBox6.BackColor = Color.White
        manual = True
    End Sub

    Private Sub Verificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
        Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")", cn)


        cn.Open()
        registrarVerificado.ExecuteNonQuery()
        'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
        cn.Close()




    End Sub
End Class