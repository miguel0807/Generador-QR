<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LOGO
        '
        Me.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LOGO.Image = Global.Proyecto.My.Resources.Resources.Matthews_Marking_MAS_Spot
        Me.LOGO.Location = New System.Drawing.Point(272, 123)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(995, 599)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 1
        Me.LOGO.TabStop = False
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1680, 1015)
        Me.Controls.Add(Me.LOGO)
        Me.Name = "Presentacion"
        Me.Text = "Presentacion"
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LOGO As PictureBox
End Class
