<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.caja4X4 = New System.Windows.Forms.Button()
        Me.caja6X1 = New System.Windows.Forms.Button()
        Me.caja2X4 = New System.Windows.Forms.Button()
        Me.ComprobacionL = New System.Windows.Forms.Button()
        Me.ReimpresionL = New System.Windows.Forms.Button()
        Me.VerficadorL = New System.Windows.Forms.Button()
        Me.GenerarL = New System.Windows.Forms.Button()
        Me.CargarL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConfiguracionL = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1366, 768)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelFormularios.Controls.Add(Me.LOGO)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(257, 39)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1109, 729)
        Me.PanelFormularios.TabIndex = 2
        '
        'LOGO
        '
        Me.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LOGO.Image = Global.Proyecto.My.Resources.Resources.Matthews_Marking_MAS_Spot
        Me.LOGO.Location = New System.Drawing.Point(57, 65)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(995, 599)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 2
        Me.LOGO.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DimGray
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 39)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(257, 729)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.ComprobacionL)
        Me.Panel3.Controls.Add(Me.ReimpresionL)
        Me.Panel3.Controls.Add(Me.VerficadorL)
        Me.Panel3.Controls.Add(Me.GenerarL)
        Me.Panel3.Controls.Add(Me.CargarL)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 565)
        Me.Panel3.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.caja4X4)
        Me.Panel2.Controls.Add(Me.caja6X1)
        Me.Panel2.Controls.Add(Me.caja2X4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 310)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 140)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'caja4X4
        '
        Me.caja4X4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.caja4X4.Dock = System.Windows.Forms.DockStyle.Top
        Me.caja4X4.FlatAppearance.BorderSize = 0
        Me.caja4X4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja4X4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja4X4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caja4X4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja4X4.ForeColor = System.Drawing.Color.Gainsboro
        Me.caja4X4.Image = Global.Proyecto.My.Resources.Resources.caja32
        Me.caja4X4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.caja4X4.Location = New System.Drawing.Point(0, 92)
        Me.caja4X4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.caja4X4.Name = "caja4X4"
        Me.caja4X4.Size = New System.Drawing.Size(255, 46)
        Me.caja4X4.TabIndex = 11
        Me.caja4X4.Text = "4x4"
        Me.caja4X4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.caja4X4.UseVisualStyleBackColor = False
        '
        'caja6X1
        '
        Me.caja6X1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.caja6X1.Dock = System.Windows.Forms.DockStyle.Top
        Me.caja6X1.FlatAppearance.BorderSize = 0
        Me.caja6X1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja6X1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja6X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caja6X1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja6X1.ForeColor = System.Drawing.Color.Gainsboro
        Me.caja6X1.Image = Global.Proyecto.My.Resources.Resources.caja32
        Me.caja6X1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.caja6X1.Location = New System.Drawing.Point(0, 46)
        Me.caja6X1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.caja6X1.Name = "caja6X1"
        Me.caja6X1.Size = New System.Drawing.Size(255, 46)
        Me.caja6X1.TabIndex = 9
        Me.caja6X1.Text = "6x1"
        Me.caja6X1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.caja6X1.UseVisualStyleBackColor = False
        '
        'caja2X4
        '
        Me.caja2X4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.caja2X4.Dock = System.Windows.Forms.DockStyle.Top
        Me.caja2X4.FlatAppearance.BorderSize = 0
        Me.caja2X4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja2X4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.caja2X4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caja2X4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja2X4.ForeColor = System.Drawing.Color.Gainsboro
        Me.caja2X4.Image = Global.Proyecto.My.Resources.Resources.caja32
        Me.caja2X4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.caja2X4.Location = New System.Drawing.Point(0, 0)
        Me.caja2X4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.caja2X4.Name = "caja2X4"
        Me.caja2X4.Size = New System.Drawing.Size(255, 46)
        Me.caja2X4.TabIndex = 10
        Me.caja2X4.Text = "2x4"
        Me.caja2X4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.caja2X4.UseVisualStyleBackColor = False
        '
        'ComprobacionL
        '
        Me.ComprobacionL.AutoSize = True
        Me.ComprobacionL.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ComprobacionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComprobacionL.Enabled = False
        Me.ComprobacionL.FlatAppearance.BorderSize = 0
        Me.ComprobacionL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ComprobacionL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ComprobacionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComprobacionL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComprobacionL.ForeColor = System.Drawing.Color.Gainsboro
        Me.ComprobacionL.Image = Global.Proyecto.My.Resources.Resources.comprobacion48
        Me.ComprobacionL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComprobacionL.Location = New System.Drawing.Point(0, 248)
        Me.ComprobacionL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComprobacionL.Name = "ComprobacionL"
        Me.ComprobacionL.Size = New System.Drawing.Size(255, 62)
        Me.ComprobacionL.TabIndex = 3
        Me.ComprobacionL.Text = "Comprobación"
        Me.ComprobacionL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ComprobacionL.UseVisualStyleBackColor = False
        '
        'ReimpresionL
        '
        Me.ReimpresionL.AutoSize = True
        Me.ReimpresionL.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ReimpresionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReimpresionL.Enabled = False
        Me.ReimpresionL.FlatAppearance.BorderSize = 0
        Me.ReimpresionL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ReimpresionL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ReimpresionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReimpresionL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReimpresionL.ForeColor = System.Drawing.Color.Gainsboro
        Me.ReimpresionL.Image = Global.Proyecto.My.Resources.Resources.buscar48
        Me.ReimpresionL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReimpresionL.Location = New System.Drawing.Point(0, 186)
        Me.ReimpresionL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReimpresionL.Name = "ReimpresionL"
        Me.ReimpresionL.Size = New System.Drawing.Size(255, 62)
        Me.ReimpresionL.TabIndex = 1
        Me.ReimpresionL.Text = "Reimpresion QR"
        Me.ReimpresionL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ReimpresionL.UseVisualStyleBackColor = False
        '
        'VerficadorL
        '
        Me.VerficadorL.AutoSize = True
        Me.VerficadorL.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VerficadorL.Dock = System.Windows.Forms.DockStyle.Top
        Me.VerficadorL.Enabled = False
        Me.VerficadorL.FlatAppearance.BorderSize = 0
        Me.VerficadorL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.VerficadorL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.VerficadorL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerficadorL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerficadorL.ForeColor = System.Drawing.Color.Gainsboro
        Me.VerficadorL.Image = Global.Proyecto.My.Resources.Resources.verficador48
        Me.VerficadorL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VerficadorL.Location = New System.Drawing.Point(0, 124)
        Me.VerficadorL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VerficadorL.Name = "VerficadorL"
        Me.VerficadorL.Size = New System.Drawing.Size(255, 62)
        Me.VerficadorL.TabIndex = 6
        Me.VerficadorL.Text = "Verificador"
        Me.VerficadorL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VerficadorL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VerficadorL.UseVisualStyleBackColor = False
        '
        'GenerarL
        '
        Me.GenerarL.AutoSize = True
        Me.GenerarL.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GenerarL.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerarL.Enabled = False
        Me.GenerarL.FlatAppearance.BorderSize = 0
        Me.GenerarL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GenerarL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GenerarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerarL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarL.ForeColor = System.Drawing.Color.Gainsboro
        Me.GenerarL.Image = Global.Proyecto.My.Resources.Resources.reimpresion48
        Me.GenerarL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarL.Location = New System.Drawing.Point(0, 62)
        Me.GenerarL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GenerarL.Name = "GenerarL"
        Me.GenerarL.Size = New System.Drawing.Size(255, 62)
        Me.GenerarL.TabIndex = 0
        Me.GenerarL.Text = "Generar Licencias"
        Me.GenerarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GenerarL.UseVisualStyleBackColor = False
        '
        'CargarL
        '
        Me.CargarL.AutoSize = True
        Me.CargarL.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CargarL.Dock = System.Windows.Forms.DockStyle.Top
        Me.CargarL.Enabled = False
        Me.CargarL.FlatAppearance.BorderSize = 0
        Me.CargarL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CargarL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CargarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CargarL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargarL.ForeColor = System.Drawing.Color.Gainsboro
        Me.CargarL.Image = Global.Proyecto.My.Resources.Resources.cargar
        Me.CargarL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CargarL.Location = New System.Drawing.Point(0, 0)
        Me.CargarL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CargarL.Name = "CargarL"
        Me.CargarL.Size = New System.Drawing.Size(255, 62)
        Me.CargarL.TabIndex = 2
        Me.CargarL.Text = "Cargar Licencias"
        Me.CargarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CargarL.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.ConfiguracionL)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 164)
        Me.Panel1.TabIndex = 5
        '
        'ConfiguracionL
        '
        Me.ConfiguracionL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConfiguracionL.AutoSize = True
        Me.ConfiguracionL.BackColor = System.Drawing.Color.DimGray
        Me.ConfiguracionL.Enabled = False
        Me.ConfiguracionL.FlatAppearance.BorderSize = 0
        Me.ConfiguracionL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ConfiguracionL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ConfiguracionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfiguracionL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguracionL.ForeColor = System.Drawing.Color.Gainsboro
        Me.ConfiguracionL.Image = Global.Proyecto.My.Resources.Resources.configuracion32
        Me.ConfiguracionL.Location = New System.Drawing.Point(3, 125)
        Me.ConfiguracionL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConfiguracionL.Name = "ConfiguracionL"
        Me.ConfiguracionL.Size = New System.Drawing.Size(38, 38)
        Me.ConfiguracionL.TabIndex = 7
        Me.ConfiguracionL.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Image = Global.Proyecto.My.Resources.Resources.logout__1_1
        Me.Button4.Location = New System.Drawing.Point(206, 121)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Posicion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1366, 39)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1303, 12)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1267, 12)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1303, 12)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1339, 12)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(549, 400)
        Me.Name = "FormPrincipal"
        Me.Text = "Generador QR"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents CargarL As Button
    Friend WithEvents ReimpresionL As Button
    Friend WithEvents GenerarL As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VerficadorL As Button
    Friend WithEvents ConfiguracionL As Button
    Friend WithEvents ComprobacionL As Button
    Friend WithEvents caja4X4 As Button
    Friend WithEvents caja2X4 As Button
    Friend WithEvents caja6X1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LOGO As PictureBox
End Class
