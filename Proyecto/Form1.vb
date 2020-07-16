Imports System.Deployment.Application


Public Class Form1
#Region "Actualizar"
    Public Sub actualizar()

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
                Catch dde As DeploymentDownloadException

                End Try

            End If

        End If
#End Region
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim TotalLicencias As Integer
        Dim Volumen As Integer = 6
        Dim resultado As Double
        Dim caja As Integer


        TotalLicencias = TextBox1.Text

        resultado = TotalLicencias / Volumen
        TextBox8.Text = resultado
        caja = Math.Ceiling(resultado)
        TextBox9.Text = caja
        If (TextBox8.Text Mod 1) = 0 Then
            TextBox2.Text = "Aprobado"
        Else
            TextBox2.Text = "NO Aprobado"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class