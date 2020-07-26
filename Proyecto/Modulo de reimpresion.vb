Imports System.Data.SqlClient
Imports Common
Public Class Modulo_de_reimpresion

    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim printController As New System.Drawing.Printing.StandardPrintController 'Se declara esta variable para evitar que se muestre el cuadro de impresion al genera licencia
    Dim Nombre As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


#Region "Busqueda por fecha y volumen"
        If RadioButton1.Checked = True Then

            Try
                conectar()

                Dim fecha
                Dim fecha2

                fecha = Format(dtpFechaI.Value, "yyy/MM/dd")
                fecha2 = Format(dtpFechaF.Value, "yyy/MM/dd")

                TextBox1.Text = fecha
                TextBox2.Text = fecha2


                Dim tabla As DataGridView = DataGridView1
                Dim etiqueta1 As String
                etiqueta1 = Comboetiqueta.Text
                Dim adaptador = New SqlDataAdapter("select * from BaseDatosOficial where Fecha between '" & fecha & "' and '" & fecha2 & "'   and CONVERT(VARCHAR,Volumen)= '" & etiqueta1 & "'", cn)
                'Dim adaptador = New SqlDataAdapter("select * from BaseDatos where Fecha between '" & fecha & "' and '" & fecha2 & "'", cn)
                Dim dataS As New DataSet
                adaptador.Fill(dataS, "BaseDatosOficial")
                tabla.DataSource = dataS.Tables("BaseDatosOficial")

                tabla.RowHeadersVisible = False
                tabla.Columns.Item(0).Visible = False

                tabla.Columns(1).Width = 130
                tabla.Columns(2).Width = 200
                tabla.Columns(3).Width = 130
                tabla.Columns(4).Width = 170
                tabla.Columns(6).Width = 100
                tabla.Columns(7).Width = 100
                tabla.Columns(8).Width = 100
                tabla.Columns(9).Width = 190
                tabla.Columns(5).Width = 162



                'Habilita conteo de filas en datagridview
                Label8.Visible = True
                'Label8.Text = tabla.DisplayedRowCount(0) - 1
                Label8.Text = tabla.RowCount - 1

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
#End Region

#Region "Busqueda por etiqueta"
        ElseIf RadioButton2.Checked = True Then
            Try
                conectar()

                Dim etiqueta As String
                etiqueta = MaskedTextBox1.Text



                Dim tabla As DataGridView = DataGridView1
                Dim adaptador As New SqlDataAdapter("select*from BaseDatosOficial where Etiqueta=" & "'" & etiqueta & "'" & "", cn)
                Dim dataS As New DataSet
                adaptador.Fill(dataS, "BaseDatosOficial")

                tabla.DataSource = dataS.Tables("BaseDatosOficial")
                tabla.RowHeadersVisible = False
                tabla.Columns.Item(0).Visible = False

                tabla.Columns(1).Width = 130
                tabla.Columns(2).Width = 200
                tabla.Columns(3).Width = 130
                tabla.Columns(4).Width = 170
                tabla.Columns(6).Width = 100
                tabla.Columns(7).Width = 100
                tabla.Columns(8).Width = 100
                tabla.Columns(9).Width = 190
                tabla.Columns(5).Width = 162

                'Habilita conteo de filas en datagridview
                Label8.Visible = True
                ' Label8.Text = tabla.DisplayedRowCount(0) - 1
                Label8.Text = tabla.RowCount - 1

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


#End Region

#Region "Busqueda por fecha"
        ElseIf RadioButton3.Checked = True Then
            Try
                conectar()

                Dim fecha
                Dim fecha2

                fecha = Format(DateTimePicker1.Value, "yyy/MM/dd")
                fecha2 = Format(DateTimePicker2.Value, "yyy/MM/dd")

                TextBox1.Text = fecha
                TextBox2.Text = fecha2


                Dim tabla As DataGridView = DataGridView1


                Dim adaptador = New SqlDataAdapter("select * from BaseDatosOficial where Fecha between '" & fecha & "' and '" & fecha2 & "'", cn)
                Dim dataS As New DataSet
                adaptador.Fill(dataS, "BaseDatosOficial")

                tabla.DataSource = dataS.Tables("BaseDatosOficial")

                tabla.RowHeadersVisible = False
                tabla.Columns.Item(0).Visible = False

                tabla.Columns(1).Width = 130
                tabla.Columns(2).Width = 200
                tabla.Columns(3).Width = 130
                tabla.Columns(4).Width = 170
                tabla.Columns(6).Width = 100
                tabla.Columns(7).Width = 100
                tabla.Columns(8).Width = 100
                tabla.Columns(9).Width = 190
                tabla.Columns(5).Width = 162

                'Habilita conteo de filas en datagridview
                Label8.Visible = True
                ' Label8.Text = tabla.DisplayedRowCount(1) - 1
                Label8.Text = tabla.RowCount - 1


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
#End Region

        End If

    End Sub

    Private Sub Modulo_de_reimpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nombre = ActiveUser.firstName + " " + ActiveUser.lastName 'Guarda el usuario en variable llamada nombre
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
#Region "Reimprime licencia"
        Try

            PrintDocument1.PrintController = printController 'Se declara la variable para quitar cuadro de impresion 



            Me.DataGridView1.Select() 'Seleccionar primera fila del datagridview



            'Almacena informacion para ser impresa
            TextBox3.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
            TextBox4.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
            'Almacena informacion para ser impresa


            'Configuracion Impresora
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDialog1.PrinterSettings.PrinterName = impresora
            'PrintDialog1.PrinterSettings.PrinterName = "SATO CG408"
            'PrintDialog1.PrinterSettings.PrinterName = "Send To OneNote 2016"
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






            PrintDocument1.Print()
            MsgBox("Licencias generadas con exito")




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#End Region

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try
            PictureBox1.Image = QR_Generator.Encode(TextBox4.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
#Region "Configura impresion de QR"
        Try
            Dim LAPIZ As New SolidBrush(TextBox3.ForeColor)
            Dim AREA_IMPRESION As Graphics = e.Graphics

            Dim POSICION As Point
            Dim TEXTO As String
            TEXTO = TextBox3.Text
            Dim FUENTE As Font
            Dim maximoE As String
            Dim maximoQR As String
            Dim medioQR As String
            Dim medioE As String

            maximoE = TextBox1.Width
            medioE = maximoE / 2
            maximoQR = PictureBox1.Image.Width
            medioQR = PictureBox1.Image.Width / 2




            'Selecciona textbox3 para configurar el tipo de letra
            FUENTE = New Font(TextBox2.Font, FontStyle.Bold)
            'Calcula la posicion para ser impresa en picturebox1

            POSICION = New Point(98, 105)

            AREA_IMPRESION.DrawString(TextBox3.Text, TextBox5.Font, LAPIZ, POSICION)

            e.Graphics.DrawImage(PictureBox1.Image, 160, 20, 70, 70)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#End Region
    End Sub

#Region "Configuracion de los radiobutton"
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            dtpFechaI.Enabled = True
            dtpFechaF.Enabled = True
            Comboetiqueta.Enabled = True
            Comboetiqueta.Enabled = True
            MaskedTextBox1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker1.Enabled = False
        End If
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            dtpFechaI.Enabled = False
            dtpFechaF.Enabled = False
            Comboetiqueta.Enabled = False
            Comboetiqueta.Enabled = False
            MaskedTextBox1.Enabled = False
            DateTimePicker2.Enabled = True
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            dtpFechaI.Enabled = False
            dtpFechaF.Enabled = False
            Comboetiqueta.Enabled = False
            Comboetiqueta.Enabled = False
            MaskedTextBox1.Enabled = True
            DateTimePicker2.Enabled = False
            DateTimePicker1.Enabled = False


        End If
    End Sub
#End Region

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
#Region "Seleccionar y eliminar licencia"
        Try

            Me.DataGridView1.Select() 'Seleccionar primera fila del datagridview
#Region "Verifica si la licencia se elimino"
            If Me.DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red Then

                MsgBox("Esta licencia ya fue eliminada")
                Exit Sub

#End Region

            Else
#Region "Pregunta si se elimina licencia"
                If MessageBox.Show("Esta seguro de eliminar la licencia?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then



#End Region

#Region "Respuesta SI"
                    'Cambia color de fila cuando se elimina
                    Me.DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red

                    'Declaracion variable
                    Dim Etiqueta As String
                    Dim Codigo As String
                    Dim Fecha As String
                    Dim Volumen As String
                    Dim Usuario As String
                    Dim Order As String
                    Dim Batch As String
                    Dim Material As String
                    Dim MaterialDescription As String
                    Dim FechaEliminacion As String


                    Etiqueta = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
                    Codigo = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()
                    Fecha = Me.DataGridView1.CurrentRow.Cells.Item(3).Value.ToString()
                    Volumen = Me.DataGridView1.CurrentRow.Cells.Item(4).Value.ToString()
                    Usuario = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString()
                    Order = Me.DataGridView1.CurrentRow.Cells.Item(6).Value.ToString()
                    Batch = Me.DataGridView1.CurrentRow.Cells.Item(7).Value.ToString()
                    Material = Me.DataGridView1.CurrentRow.Cells.Item(8).Value.ToString()
                    MaterialDescription = Me.DataGridView1.CurrentRow.Cells.Item(9).Value.ToString()



                    'Establece fecha de eliminacion
                    FechaEliminacion = DateTime.Now
                    Dim fechacreacion As Date
                    fechacreacion = FechaEliminacion
                    FechaEliminacion = Format(fechacreacion, "yyyy/MM/dd HH:mm:ss")





                    'Guarda licencia eliminada en basedatos Eliminadas
                    conectar()
                    Dim registrar As New SqlCommand("insert into Eliminados (Etiqueta, Codigo, Fecha, Volumen, Usuario, [Order], Batch, Material, MaterialDescription,Responsable,FechaHora) values (" & "'" & Etiqueta & "'" & ",'" & Codigo & "','" & Fecha & "','" & Volumen & "','" & Usuario & "'," & Order & ",'" & Batch & "'," & Material & ",'" & MaterialDescription & "','" & Nombre & "','" & FechaEliminacion & "')", cn)
                    registrar.ExecuteNonQuery()
                    desconectar()


                    'Elimina Licencia de basedatosOficial
                    conectar()
                    Dim borrar As New SqlCommand("delete From BaseDatosOficial where Etiqueta= '" & Etiqueta & "'   and CONVERT(VARCHAR,Usuario)= '" & Usuario & "'", cn)
                    borrar.ExecuteNonQuery() 'Ejecutar el comando
                    desconectar()


                    MsgBox("Licencia Eliminada")
                End If
#End Region
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#End Region

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        MaskedTextBox1.Clear()

        MaskedTextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReimpresionBox.Show()
    End Sub
End Class