Imports System.Runtime.InteropServices
Imports Domain
Imports Proyecto

Public Class Login
#Region "Customize Controls - Personalizar Controles"

    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

#End Region

#Region "Close and Minimize Form - Cerrar y Minimizar Formulario"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form - Arrastrar/ mover Formulario"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = My.Settings.usuario
        CustomizeComponents()
        Me.CenterToScreen()
        txtPass.Focus()

        If My.Settings.recordarusuario = 1 Then
            CheckBox1.Checked = True
            txtPass.Focus()
        Else
            CheckBox1.Checked = False
        End If

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try


            Dim userModel As New UserModel()
            Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
            If validLogin = True Then
                'Dim frm As New FormPrincipal()

                Dim frm As New Proyecto.FormPrincipal()
                frm.Show()

                AddHandler frm.FormClosed, AddressOf Me.logout
                If CheckBox1.Checked = True Then
                    My.Settings.usuario = txtUser.Text
                    My.Settings.logout = 1
                    My.Settings.recordarusuario = 1
                    My.Settings.Save()
                End If
                Me.Hide()

            Else
                My.Settings.logout = 0

                My.Settings.Save()
                MessageBox.Show("Usuario o contraseña incorrectos." + vbNewLine + "Trate nuevamente.")
                txtPass.Clear()
                txtPass.Focus()
            End If
        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub logout(sender As Object, e As FormClosedEventArgs)
        If My.Settings.logout = 1 Then

            txtPass.Clear()
            Me.Show()
            txtPass.Focus()
        ElseIf My.Settings.logout = 0 Then
            txtUser.Clear()
            txtPass.Clear()
            Me.Show()
            txtPass.Focus()
        End If



    End Sub



    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Try


                    Dim userModel As New UserModel()
                    Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
                    If validLogin = True Then
                        'Dim frm As New FormPrincipal()

                        Dim frm As New Proyecto.FormPrincipal()
                        frm.Show()

                        AddHandler frm.FormClosed, AddressOf Me.logout

                        Me.Hide()

                    Else

                        MessageBox.Show("Usuario o contraseña incorrectos." + vbNewLine + "Trate nuevamente.")
                        txtPass.Clear()
                        txtPass.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(vbCrLf & ex.Message)
                End Try
        End Select
    End Sub

End Class
