Imports System.Data.SqlClient
Imports vb = Microsoft.VisualBasic

Public Class Verificacion
    Public tiempo As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textboxcaja.Text = ""
        Timer1.Stop()
        textboxcaja.Focus()
        CircularProgressBar1.Visible = True

    End Sub



    Private Sub caja_LostFocus(sender As Object, e As EventArgs) Handles textboxcaja.LostFocus
        CircularProgressBar1.Visible = False
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
                    MsgBox("Correcto")

                    Dim extraccion As String = textboxcaja.Text
                    Dim orden As String
                    Dim caja As String
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

            End If
            If contador >= 14 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
            End If

            Button2.Focus()


        End If
        If controlTimer.Text = 7 Then
            controlTimer.Text = 0
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaskedTextBox1.Focus()
        CircularProgressBar2.Visible = True
    End Sub





    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.LostFocus
        CircularProgressBar2.Visible = False
        Timer2.Enabled = False
        tiempo = 0


    End Sub




    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox1.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then
            Timer2.Enabled = True

        End If

    End Sub



    Private Sub MaskedTextBox2_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.LostFocus
        CircularProgressBar3.Visible = False
    End Sub

    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.GotFocus

        CircularProgressBar3.Visible = True
    End Sub



    Private Sub MaskedTextBox3_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.GotFocus
        CircularProgressBar4.Visible = True
    End Sub

    Private Sub MaskedTextBox3_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.LostFocus
        CircularProgressBar4.Visible = False
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Timer2.Interval = 1000
        If tiempo = 1 Then
            MaskedTextBox2.Focus()
        End If
        tiempo = tiempo + 1
    End Sub
End Class