<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CircularProgressBar2 = New CircularProgressBar.CircularProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ribbon = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaDatos = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.ParteDatos = New System.Windows.Forms.TextBox()
        Me.LoteDatos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VolumenDatos = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button7)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.CircularProgressBar2)
        Me.Panel8.Controls.Add(Me.Button3)
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Location = New System.Drawing.Point(-1161, 355)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(386, 368)
        Me.Panel8.TabIndex = 103
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(108, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(55, 17)
        Me.Button7.TabIndex = 80
        Me.Button7.Text = "5"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(163, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Finalizado"
        '
        'CircularProgressBar2
        '
        Me.CircularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar2.AnimationSpeed = 500
        Me.CircularProgressBar2.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar2.InnerMargin = 2
        Me.CircularProgressBar2.InnerWidth = -1
        Me.CircularProgressBar2.Location = New System.Drawing.Point(50, 49)
        Me.CircularProgressBar2.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar2.Name = "CircularProgressBar2"
        Me.CircularProgressBar2.OuterColor = System.Drawing.Color.Gray
        Me.CircularProgressBar2.OuterMargin = -25
        Me.CircularProgressBar2.OuterWidth = 26
        Me.CircularProgressBar2.ProgressColor = System.Drawing.Color.Teal
        Me.CircularProgressBar2.ProgressWidth = 25
        Me.CircularProgressBar2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar2.Size = New System.Drawing.Size(284, 229)
        Me.CircularProgressBar2.StartAngle = 270
        Me.CircularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar2.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar2.SubscriptText = ""
        Me.CircularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar2.SuperscriptText = ""
        Me.CircularProgressBar2.TabIndex = 79
        Me.CircularProgressBar2.Text = "0%"
        Me.CircularProgressBar2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar2.Value = 68
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(50, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 29)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Iniciar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(275, 313)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 29)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Reiniciar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ProgressBar2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1006, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 87)
        Me.Panel1.TabIndex = 102
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(125, 3)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(346, 40)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0 %"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.TextBox12)
        Me.Panel6.Location = New System.Drawing.Point(-1606, -133)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(547, 421)
        Me.Panel6.TabIndex = 101
        Me.Panel6.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(160, 378)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(221, 34)
        Me.TextBox7.TabIndex = 43
        Me.TextBox7.Text = "N/A"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(144, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(246, 228)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(58, 40)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(431, 34)
        Me.TextBox12.TabIndex = 40
        Me.TextBox12.Text = "prueba"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(-1812, 90)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(153, 58)
        Me.Button8.TabIndex = 100
        Me.Button8.Text = "Información"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button9)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Ribbon)
        Me.Panel5.Location = New System.Drawing.Point(-1812, 723)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(363, 55)
        Me.Panel5.TabIndex = 99
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(285, 13)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 63
        Me.Button9.Text = "Reiniciar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 29)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Ribbon:"
        '
        'Ribbon
        '
        Me.Ribbon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ribbon.AutoSize = True
        Me.Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ribbon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ribbon.Location = New System.Drawing.Point(142, 13)
        Me.Ribbon.Name = "Ribbon"
        Me.Ribbon.Size = New System.Drawing.Size(67, 26)
        Me.Ribbon.TabIndex = 60
        Me.Ribbon.Tag = ""
        Me.Ribbon.Text = "#1600"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Location = New System.Drawing.Point(-756, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 421)
        Me.Panel2.TabIndex = 98
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(160, 378)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(221, 34)
        Me.TextBox3.TabIndex = 43
        Me.TextBox3.Text = " N/A"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(144, 121)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(246, 228)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(58, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(431, 34)
        Me.TextBox4.TabIndex = 40
        Me.TextBox4.Text = " N/A"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Location = New System.Drawing.Point(-1505, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 116)
        Me.Panel3.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 29)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Ingrese Cantidad"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(95, 52)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(59, 34)
        Me.TextBox5.TabIndex = 47
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button10
        '
        Me.Button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button10.FlatAppearance.BorderSize = 2
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(-1585, 566)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(409, 98)
        Me.Button10.TabIndex = 96
        Me.Button10.Text = "Generar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.FechaDatos)
        Me.Panel10.Location = New System.Drawing.Point(-1812, 784)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(363, 55)
        Me.Panel10.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 29)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Fecha:"
        '
        'FechaDatos
        '
        Me.FechaDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FechaDatos.AutoSize = True
        Me.FechaDatos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDatos.Location = New System.Drawing.Point(143, 16)
        Me.FechaDatos.Name = "FechaDatos"
        Me.FechaDatos.Size = New System.Drawing.Size(72, 24)
        Me.FechaDatos.TabIndex = 59
        Me.FechaDatos.Text = "Label3"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(-666, 126)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(278, 22)
        Me.Nombre.TabIndex = 93
        Me.Nombre.Visible = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(-1418, 339)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(57, 38)
        Me.Button11.TabIndex = 92
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'ParteDatos
        '
        Me.ParteDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParteDatos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParteDatos.Location = New System.Drawing.Point(-728, 30)
        Me.ParteDatos.Name = "ParteDatos"
        Me.ParteDatos.ReadOnly = True
        Me.ParteDatos.Size = New System.Drawing.Size(519, 30)
        Me.ParteDatos.TabIndex = 91
        Me.ParteDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoteDatos
        '
        Me.LoteDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoteDatos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoteDatos.Location = New System.Drawing.Point(-728, -14)
        Me.LoteDatos.Name = "LoteDatos"
        Me.LoteDatos.ReadOnly = True
        Me.LoteDatos.Size = New System.Drawing.Size(519, 30)
        Me.LoteDatos.TabIndex = 90
        Me.LoteDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1022, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 29)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Volumen:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-1022, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Numero de parte:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1022, -14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 29)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Numero de lote:"
        '
        'VolumenDatos
        '
        Me.VolumenDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VolumenDatos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumenDatos.Location = New System.Drawing.Point(-728, 72)
        Me.VolumenDatos.Name = "VolumenDatos"
        Me.VolumenDatos.Size = New System.Drawing.Size(519, 30)
        Me.VolumenDatos.TabIndex = 86
        Me.VolumenDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(-1477, -1)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(83, 34)
        Me.TextBox6.TabIndex = 85
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1792, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(274, 29)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Cantidad de Licencias:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1045, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 58)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(506, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 82)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Probar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(67, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Total de licencias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(67, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Volumen"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(208, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 22)
        Me.TextBox1.TabIndex = 108
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 113)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(94, 22)
        Me.TextBox2.TabIndex = 109
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(208, 236)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(94, 22)
        Me.TextBox8.TabIndex = 110
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(208, 328)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(94, 22)
        Me.TextBox9.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(67, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "#Caja"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 707)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.ParteDatos)
        Me.Controls.Add(Me.LoteDatos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.VolumenDatos)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label11)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CircularProgressBar2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Ribbon As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaDatos As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents ParteDatos As TextBox
    Friend WithEvents LoteDatos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents VolumenDatos As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
End Class
