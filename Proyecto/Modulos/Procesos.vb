


Module Procesos
    Sub ComparacionMasket()
        If Proyecto.Verificacion.MaskedTextBox1.Text = Proyecto.Verificacion.MaskedTextBox2.Text Then
            MsgBox("funciono")
        End If

    End Sub
    Sub compararInvisible(sender As Object, e As EventArgs)


        Verificacion.PictureBox1.Visible = False
        Verificacion.PictureBox2.Visible = False
        Verificacion.PictureBox3.Visible = False
        Verificacion.PictureBox4.Visible = False
        Verificacion.PictureBox5.Visible = False
        Verificacion.PictureBox6.Visible = False
    End Sub

    Sub compararVisible(sender As Object, e As EventArgs)
        Proyecto.Verificacion.PictureBox1.Visible = True
        Proyecto.Verificacion.PictureBox2.Visible = True
        Proyecto.Verificacion.PictureBox3.Visible = True
        Proyecto.Verificacion.PictureBox4.Visible = True
        Proyecto.Verificacion.PictureBox5.Visible = True
        Proyecto.Verificacion.PictureBox6.Visible = True
    End Sub
End Module
