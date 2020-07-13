Imports System.Deployment.Application
Imports System
Imports System.Drawing.Printing
Public Class Configuracion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("Desea actualizar la aplicacion?", "Proceso de actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
#Region "Actualizar"


            Dim info As UpdateCheckInfo = Nothing



            If (ApplicationDeployment.IsNetworkDeployed) Then

                Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

                Try
                    info = AD.CheckForDetailedUpdate()
                Catch dde As DeploymentDownloadException

                Catch ioe As InvalidOperationException

                End Try

                If (info.UpdateAvailable) Then

                    Try
                        AD.Update()

                        Application.Restart()
                        MsgBox("Actualizado con exito")
                    Catch dde As DeploymentDownloadException

                    End Try

                End If
            Else
                MsgBox("La aplicacion ya se encuentra en la ultima version")
            End If
#End Region
        End If

    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Cargar impresoras"
        Dim pd As New PrintDocument
        Dim Impresoras As String

        ' Default printer      
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas  
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ListBox1.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada  
        'ListBox1.Text = s_Default_Printer

        ListBox1.SelectedItem = My.Settings.Impresora

#End Region
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ListBox1.Select()
        My.Settings.Impresora = ListBox1.SelectedItem


        My.Settings.Save()
        MsgBox("Para que el cambio se complete correctamente, necesita reiniciar el programa")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(My.Settings.Impresora)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cn.State = ConnectionState.Open Then
            MsgBox("Error de conexion")
        Else
            MsgBox("Conexion exitosa")

        End If

    End Sub
End Class