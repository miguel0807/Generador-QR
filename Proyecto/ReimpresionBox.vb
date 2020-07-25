Public Class ReimpresionBox
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        TextBox7.Text = "Box #" & TextBox1.Text
        PrintDocument2.Print()


    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

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
        Dim distanciaqr As Integer = 160 + 6 + 65
        Dim extra As Integer = 0




        'Selecciona textbox3 para configurar el tipo de letra
        FUENTE = New Font(TextBox12.Font, FontStyle.Bold)
        'Calcula la posicion para ser impresa en picturebox1


        maximoE = TextBox7.Width - 12
        medioE = maximoE / 2
        maximoQR = 65
        medioQR = maximoQR / 2

        If TextBox1.Text <= 9 Then
            extra = 5
        End If

        If TextBox1.Text >= 100 Then
            extra = -5
        End If

        If TextBox1.Text >= 1000 Then
            extra = -15
        End If
        POSICION = New Point(distanciaqr - medioE + extra, 105) 'Pruebas

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