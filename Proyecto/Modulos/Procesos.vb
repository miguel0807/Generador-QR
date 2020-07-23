


Module Procesos
    Sub ComparacionMasket()
        If Proyecto.Verificacion.MaskedTextBox1.Text = Proyecto.Verificacion.MaskedTextBox2.Text Then
            MsgBox("funciono")
        End If

    End Sub
    Sub compararInvisible(sender As Object, e As EventArgs)


        Verificacion.igual1.Visible = False
        Verificacion.igual2.Visible = False
        Verificacion.igual3.Visible = False
        Verificacion.igual4.Visible = False
        Verificacion.igual5.Visible = False
        Verificacion.igual6.Visible = False
    End Sub

    Sub compararVisible(sender As Object, e As EventArgs)
        Proyecto.Verificacion.igual1.Visible = True
        Proyecto.Verificacion.igual2.Visible = True
        Proyecto.Verificacion.igual3.Visible = True
        Proyecto.Verificacion.igual4.Visible = True
        Proyecto.Verificacion.igual5.Visible = True
        Proyecto.Verificacion.igual6.Visible = True
    End Sub
End Module
