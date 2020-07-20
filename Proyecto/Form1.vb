Imports System.Deployment.Application
Imports vb = Microsoft.VisualBasic


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



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim extraccion1 As String = TextBox10.Text
        Dim Cadena2 As String = TextBox10.Text
        TextBox11.Text = vb.Mid(extraccion1, 1, 8)
        TextBox13.Text = vb.Mid(extraccion1, 9, 5)



    End Sub
End Class