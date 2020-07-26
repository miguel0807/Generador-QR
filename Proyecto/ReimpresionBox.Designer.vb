<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReimpresionBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.txtcaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtorden = New System.Windows.Forms.TextBox()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 61)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.TextBox3)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.TextBox12)
        Me.Panel6.Location = New System.Drawing.Point(12, 11)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(529, 433)
        Me.Panel6.TabIndex = 74
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(160, 378)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(221, 34)
        Me.TextBox7.TabIndex = 43
        Me.TextBox7.Text = "N/A"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(144, 121)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(237, 231)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(59, 39)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(431, 34)
        Me.TextBox12.TabIndex = 40
        Me.TextBox12.Text = "prueba"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.Location = New System.Drawing.Point(160, 12)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 11)
        Me.TextBox3.TabIndex = 75
        Me.TextBox3.Visible = False
        '
        'PrintDocument2
        '
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'txtcaja
        '
        Me.txtcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcaja.Location = New System.Drawing.Point(736, 149)
        Me.txtcaja.Name = "txtcaja"
        Me.txtcaja.Size = New System.Drawing.Size(117, 27)
        Me.txtcaja.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(586, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Caja:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(562, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 44)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Orden de produccion:"
        '
        'txtorden
        '
        Me.txtorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorden.Location = New System.Drawing.Point(736, 82)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(117, 27)
        Me.txtorden.TabIndex = 1
        '
        'ReimpresionBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtorden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcaja)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ReimpresionBox"
        Me.Text = "ReimpresionBox"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PrintDocument2 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents txtcaja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtorden As TextBox
End Class
