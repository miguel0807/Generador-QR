


Module Procesos
    Sub ComparacionMasket()
        If Proyecto.V6X1.MaskedTextBox1.Text = Proyecto.V6X1.MaskedTextBox2.Text Then
            MsgBox("funciono")
        End If

    End Sub
    Sub compararInvisible(sender As Object, e As EventArgs)


        V6X1.igual1.Visible = False
        V6X1.igual2.Visible = False
        V6X1.igual3.Visible = False
        V6X1.igual4.Visible = False
        V6X1.igual5.Visible = False
        V6X1.igual6.Visible = False
    End Sub

    Sub compararVisible(sender As Object, e As EventArgs)
        Proyecto.V6X1.igual1.Visible = True
        Proyecto.V6X1.igual2.Visible = True
        Proyecto.V6X1.igual3.Visible = True
        Proyecto.V6X1.igual4.Visible = True
        Proyecto.V6X1.igual5.Visible = True
        Proyecto.V6X1.igual6.Visible = True
    End Sub
End Module
