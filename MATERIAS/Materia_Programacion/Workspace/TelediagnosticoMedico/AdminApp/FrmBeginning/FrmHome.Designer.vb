<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnFaq = New Guna.UI.WinForms.GunaButton()
        Me.BtnLogout = New Guna.UI.WinForms.GunaButton()
        Me.BtnPath = New Guna.UI.WinForms.GunaButton()
        Me.BtnSympt = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnMed = New Guna.UI.WinForms.GunaButton()
        Me.BtnPac = New Guna.UI.WinForms.GunaButton()
        Me.BtnLogin = New Guna.UI.WinForms.GunaButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.LblConnect = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblCi = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblTitle1 = New System.Windows.Forms.Label()
        Me.Lblbody = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicHome = New System.Windows.Forms.PictureBox()
        Me.PicSys = New System.Windows.Forms.PictureBox()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHome.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PanelButtons)
        Me.PanelLeft.Controls.Add(Me.PicLogo)
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(188, 640)
        Me.PanelLeft.TabIndex = 3
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.PictureBox1)
        Me.PanelButtons.Controls.Add(Me.BtnFaq)
        Me.PanelButtons.Controls.Add(Me.BtnLogout)
        Me.PanelButtons.Controls.Add(Me.BtnPath)
        Me.PanelButtons.Controls.Add(Me.BtnSympt)
        Me.PanelButtons.Controls.Add(Me.BtnAdmin)
        Me.PanelButtons.Controls.Add(Me.BtnMed)
        Me.PanelButtons.Controls.Add(Me.BtnPac)
        Me.PanelButtons.Controls.Add(Me.BtnLogin)
        Me.PanelButtons.Location = New System.Drawing.Point(19, 108)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(166, 515)
        Me.PanelButtons.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 30)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BtnFaq
        '
        Me.BtnFaq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFaq.Animated = True
        Me.BtnFaq.AnimationHoverSpeed = 0.07!
        Me.BtnFaq.AnimationSpeed = 0.03!
        Me.BtnFaq.BackColor = System.Drawing.Color.Transparent
        Me.BtnFaq.BaseColor = System.Drawing.Color.White
        Me.BtnFaq.BorderColor = System.Drawing.Color.Black
        Me.BtnFaq.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnFaq.FocusedColor = System.Drawing.Color.Empty
        Me.BtnFaq.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFaq.ForeColor = System.Drawing.Color.Black
        Me.BtnFaq.Image = CType(resources.GetObject("BtnFaq.Image"), System.Drawing.Image)
        Me.BtnFaq.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnFaq.Location = New System.Drawing.Point(9, 447)
        Me.BtnFaq.Name = "BtnFaq"
        Me.BtnFaq.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnFaq.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnFaq.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnFaq.OnHoverImage = Nothing
        Me.BtnFaq.OnPressedColor = System.Drawing.Color.Black
        Me.BtnFaq.Radius = 6
        Me.BtnFaq.Size = New System.Drawing.Size(146, 30)
        Me.BtnFaq.TabIndex = 29
        Me.BtnFaq.Text = "FAQ"
        Me.BtnFaq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.Animated = True
        Me.BtnLogout.AnimationHoverSpeed = 0.07!
        Me.BtnLogout.AnimationSpeed = 0.03!
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.BaseColor = System.Drawing.Color.White
        Me.BtnLogout.BorderColor = System.Drawing.Color.Black
        Me.BtnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnLogout.Location = New System.Drawing.Point(9, 483)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnLogout.OnHoverImage = Nothing
        Me.BtnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.BtnLogout.Radius = 6
        Me.BtnLogout.Size = New System.Drawing.Size(146, 30)
        Me.BtnLogout.TabIndex = 28
        Me.BtnLogout.Text = "Cerrar sesión"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPath
        '
        Me.BtnPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPath.Animated = True
        Me.BtnPath.AnimationHoverSpeed = 0.07!
        Me.BtnPath.AnimationSpeed = 0.03!
        Me.BtnPath.BackColor = System.Drawing.Color.Transparent
        Me.BtnPath.BaseColor = System.Drawing.Color.White
        Me.BtnPath.BorderColor = System.Drawing.Color.Black
        Me.BtnPath.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPath.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPath.ForeColor = System.Drawing.Color.Black
        Me.BtnPath.Image = CType(resources.GetObject("BtnPath.Image"), System.Drawing.Image)
        Me.BtnPath.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPath.Location = New System.Drawing.Point(9, 202)
        Me.BtnPath.Name = "BtnPath"
        Me.BtnPath.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPath.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPath.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPath.OnHoverImage = Nothing
        Me.BtnPath.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPath.Radius = 6
        Me.BtnPath.Size = New System.Drawing.Size(146, 30)
        Me.BtnPath.TabIndex = 27
        Me.BtnPath.Text = "Patologías"
        Me.BtnPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSympt
        '
        Me.BtnSympt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSympt.Animated = True
        Me.BtnSympt.AnimationHoverSpeed = 0.07!
        Me.BtnSympt.AnimationSpeed = 0.03!
        Me.BtnSympt.BackColor = System.Drawing.Color.Transparent
        Me.BtnSympt.BaseColor = System.Drawing.Color.White
        Me.BtnSympt.BorderColor = System.Drawing.Color.Black
        Me.BtnSympt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSympt.FocusedColor = System.Drawing.Color.Empty
        Me.BtnSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSympt.ForeColor = System.Drawing.Color.Black
        Me.BtnSympt.Image = CType(resources.GetObject("BtnSympt.Image"), System.Drawing.Image)
        Me.BtnSympt.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnSympt.Location = New System.Drawing.Point(9, 166)
        Me.BtnSympt.Name = "BtnSympt"
        Me.BtnSympt.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnSympt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnSympt.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnSympt.OnHoverImage = Nothing
        Me.BtnSympt.OnPressedColor = System.Drawing.Color.Black
        Me.BtnSympt.Radius = 6
        Me.BtnSympt.Size = New System.Drawing.Size(146, 30)
        Me.BtnSympt.TabIndex = 26
        Me.BtnSympt.Text = "Síntomas"
        Me.BtnSympt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdmin.Animated = True
        Me.BtnAdmin.AnimationHoverSpeed = 0.07!
        Me.BtnAdmin.AnimationSpeed = 0.03!
        Me.BtnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdmin.BaseColor = System.Drawing.Color.White
        Me.BtnAdmin.BorderColor = System.Drawing.Color.Black
        Me.BtnAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.ForeColor = System.Drawing.Color.Black
        Me.BtnAdmin.Image = CType(resources.GetObject("BtnAdmin.Image"), System.Drawing.Image)
        Me.BtnAdmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdmin.Location = New System.Drawing.Point(9, 130)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdmin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdmin.OnHoverImage = Nothing
        Me.BtnAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdmin.Radius = 6
        Me.BtnAdmin.Size = New System.Drawing.Size(146, 30)
        Me.BtnAdmin.TabIndex = 25
        Me.BtnAdmin.Text = "Administradores"
        Me.BtnAdmin.TextOffsetX = 2
        '
        'BtnMed
        '
        Me.BtnMed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMed.Animated = True
        Me.BtnMed.AnimationHoverSpeed = 0.07!
        Me.BtnMed.AnimationSpeed = 0.03!
        Me.BtnMed.BackColor = System.Drawing.Color.Transparent
        Me.BtnMed.BaseColor = System.Drawing.Color.White
        Me.BtnMed.BorderColor = System.Drawing.Color.Black
        Me.BtnMed.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMed.FocusedColor = System.Drawing.Color.Empty
        Me.BtnMed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMed.ForeColor = System.Drawing.Color.Black
        Me.BtnMed.Image = CType(resources.GetObject("BtnMed.Image"), System.Drawing.Image)
        Me.BtnMed.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnMed.Location = New System.Drawing.Point(9, 94)
        Me.BtnMed.Name = "BtnMed"
        Me.BtnMed.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnMed.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnMed.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnMed.OnHoverImage = Nothing
        Me.BtnMed.OnPressedColor = System.Drawing.Color.Black
        Me.BtnMed.Radius = 6
        Me.BtnMed.Size = New System.Drawing.Size(146, 30)
        Me.BtnMed.TabIndex = 24
        Me.BtnMed.Text = "Médicos"
        Me.BtnMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPac
        '
        Me.BtnPac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPac.Animated = True
        Me.BtnPac.AnimationHoverSpeed = 0.07!
        Me.BtnPac.AnimationSpeed = 0.03!
        Me.BtnPac.BackColor = System.Drawing.Color.Transparent
        Me.BtnPac.BaseColor = System.Drawing.Color.White
        Me.BtnPac.BorderColor = System.Drawing.Color.Black
        Me.BtnPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPac.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPac.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPac.ForeColor = System.Drawing.Color.Black
        Me.BtnPac.Image = CType(resources.GetObject("BtnPac.Image"), System.Drawing.Image)
        Me.BtnPac.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPac.Location = New System.Drawing.Point(9, 58)
        Me.BtnPac.Name = "BtnPac"
        Me.BtnPac.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPac.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPac.OnHoverImage = Nothing
        Me.BtnPac.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPac.Radius = 6
        Me.BtnPac.Size = New System.Drawing.Size(146, 30)
        Me.BtnPac.TabIndex = 23
        Me.BtnPac.Text = "Pacientes"
        Me.BtnPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.Animated = True
        Me.BtnLogin.AnimationHoverSpeed = 0.07!
        Me.BtnLogin.AnimationSpeed = 0.03!
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.BtnLogin.BorderSize = 1
        Me.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnLogin.Location = New System.Drawing.Point(9, 22)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnLogin.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.BtnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnLogin.OnHoverImage = Nothing
        Me.BtnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnLogin.Radius = 6
        Me.BtnLogin.Size = New System.Drawing.Size(146, 30)
        Me.BtnLogin.TabIndex = 22
        Me.BtnLogin.Text = "Página principal"
        Me.BtnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(19, 13)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(77, 80)
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'PanelHome
        '
        Me.PanelHome.BackColor = System.Drawing.Color.Transparent
        Me.PanelHome.BackgroundImage = CType(resources.GetObject("PanelHome.BackgroundImage"), System.Drawing.Image)
        Me.PanelHome.Controls.Add(Me.LblConnect)
        Me.PanelHome.Controls.Add(Me.Label11)
        Me.PanelHome.Controls.Add(Me.LblPhone)
        Me.PanelHome.Controls.Add(Me.Label7)
        Me.PanelHome.Controls.Add(Me.LblEmail)
        Me.PanelHome.Controls.Add(Me.Label5)
        Me.PanelHome.Controls.Add(Me.LblAge)
        Me.PanelHome.Controls.Add(Me.Label3)
        Me.PanelHome.Controls.Add(Me.LblCi)
        Me.PanelHome.Controls.Add(Me.Label9)
        Me.PanelHome.Controls.Add(Me.LblName)
        Me.PanelHome.Controls.Add(Me.LblTitle1)
        Me.PanelHome.Controls.Add(Me.Lblbody)
        Me.PanelHome.Controls.Add(Me.PictureBox2)
        Me.PanelHome.Controls.Add(Me.PicHome)
        Me.PanelHome.Controls.Add(Me.PicSys)
        Me.PanelHome.ForeColor = System.Drawing.Color.Transparent
        Me.PanelHome.Location = New System.Drawing.Point(188, 0)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(872, 640)
        Me.PanelHome.TabIndex = 5
        '
        'LblConnect
        '
        Me.LblConnect.AccessibleDescription = "LblTitle3"
        Me.LblConnect.AccessibleName = "LblTitle3"
        Me.LblConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConnect.AutoSize = True
        Me.LblConnect.BackColor = System.Drawing.Color.Transparent
        Me.LblConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConnect.ForeColor = System.Drawing.Color.DarkGray
        Me.LblConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblConnect.Location = New System.Drawing.Point(484, 602)
        Me.LblConnect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblConnect.Name = "LblConnect"
        Me.LblConnect.Size = New System.Drawing.Size(51, 13)
        Me.LblConnect.TabIndex = 33
        Me.LblConnect.Text = "Conexion"
        Me.LblConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = "LblTitle3"
        Me.Label11.AccessibleName = "LblTitle3"
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(482, 585)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Conexión"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPhone
        '
        Me.LblPhone.AccessibleDescription = "LblTitle3"
        Me.LblPhone.AccessibleName = "LblTitle3"
        Me.LblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.ForeColor = System.Drawing.Color.DarkGray
        Me.LblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPhone.Location = New System.Drawing.Point(487, 525)
        Me.LblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(22, 13)
        Me.LblPhone.TabIndex = 31
        Me.LblPhone.Text = "Tel"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = "LblTitle3"
        Me.Label7.AccessibleName = "LblTitle3"
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(485, 508)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Número telefónico"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEmail
        '
        Me.LblEmail.AccessibleDescription = "LblTitle3"
        Me.LblEmail.AccessibleName = "LblTitle3"
        Me.LblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.LblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblEmail.Location = New System.Drawing.Point(486, 473)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(38, 13)
        Me.LblEmail.TabIndex = 29
        Me.LblEmail.Text = "Correo"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = "LblTitle3"
        Me.Label5.AccessibleName = "LblTitle3"
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(484, 456)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Dirección de correo electrónico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAge
        '
        Me.LblAge.AccessibleDescription = "LblTitle3"
        Me.LblAge.AccessibleName = "LblTitle3"
        Me.LblAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAge.AutoSize = True
        Me.LblAge.BackColor = System.Drawing.Color.Transparent
        Me.LblAge.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAge.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAge.Location = New System.Drawing.Point(485, 429)
        Me.LblAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(32, 13)
        Me.LblAge.TabIndex = 27
        Me.LblAge.Text = "Edad"
        Me.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = "LblTitle3"
        Me.Label3.AccessibleName = "LblTitle3"
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(483, 412)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Edad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCi
        '
        Me.LblCi.AccessibleDescription = "LblTitle3"
        Me.LblCi.AccessibleName = "LblTitle3"
        Me.LblCi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCi.AutoSize = True
        Me.LblCi.BackColor = System.Drawing.Color.Transparent
        Me.LblCi.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCi.ForeColor = System.Drawing.Color.DarkGray
        Me.LblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCi.Location = New System.Drawing.Point(484, 386)
        Me.LblCi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCi.Name = "LblCi"
        Me.LblCi.Size = New System.Drawing.Size(57, 13)
        Me.LblCi.TabIndex = 25
        Me.LblCi.Text = "Credencial"
        Me.LblCi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = "LblTitle3"
        Me.Label9.AccessibleName = "LblTitle3"
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(482, 369)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Documento o Credencial"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblName
        '
        Me.LblName.AccessibleDescription = "LblTitle3"
        Me.LblName.AccessibleName = "LblTitle3"
        Me.LblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.DarkGray
        Me.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblName.Location = New System.Drawing.Point(483, 342)
        Me.LblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(91, 13)
        Me.LblName.TabIndex = 17
        Me.LblName.Text = "Nombre Completo"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle1
        '
        Me.LblTitle1.AccessibleDescription = "LblTitle2"
        Me.LblTitle1.AccessibleName = "LblTitle2"
        Me.LblTitle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1.Location = New System.Drawing.Point(567, 294)
        Me.LblTitle1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle1.Name = "LblTitle1"
        Me.LblTitle1.Size = New System.Drawing.Size(215, 25)
        Me.LblTitle1.TabIndex = 16
        Me.LblTitle1.Text = "ACERCA DEL ADMINISTRADOR"
        Me.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lblbody
        '
        Me.Lblbody.AccessibleDescription = "LblTitle3"
        Me.Lblbody.AccessibleName = "LblTitle3"
        Me.Lblbody.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lblbody.BackColor = System.Drawing.Color.Transparent
        Me.Lblbody.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lblbody.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Lblbody.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lblbody.Location = New System.Drawing.Point(482, 325)
        Me.Lblbody.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblbody.Name = "Lblbody"
        Me.Lblbody.Size = New System.Drawing.Size(143, 15)
        Me.Lblbody.TabIndex = 15
        Me.Lblbody.Text = "Nombre Completo"
        Me.Lblbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(395, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PicHome
        '
        Me.PicHome.Image = CType(resources.GetObject("PicHome.Image"), System.Drawing.Image)
        Me.PicHome.Location = New System.Drawing.Point(18, 35)
        Me.PicHome.Name = "PicHome"
        Me.PicHome.Size = New System.Drawing.Size(842, 200)
        Me.PicHome.TabIndex = 0
        Me.PicHome.TabStop = False
        '
        'PicSys
        '
        Me.PicSys.BackColor = System.Drawing.Color.Transparent
        Me.PicSys.Image = CType(resources.GetObject("PicSys.Image"), System.Drawing.Image)
        Me.PicSys.Location = New System.Drawing.Point(22, 250)
        Me.PicSys.Name = "PicSys"
        Me.PicSys.Size = New System.Drawing.Size(408, 390)
        Me.PicSys.TabIndex = 2
        Me.PicSys.TabStop = False
        '
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me.PanelHome
        '
        'Elipse
        '
        Me.Elipse.BorderRadius = 10
        Me.Elipse.TargetControl = Me
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHome.ResumeLayout(False)
        Me.PanelHome.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents BtnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPath As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnSympt As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnMed As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnFaq As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelHome As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicSys As PictureBox
    Friend WithEvents PicHome As PictureBox
    Public WithEvents Lblbody As Label
    Public WithEvents LblName As Label
    Public WithEvents LblTitle1 As Label
    Public WithEvents LblConnect As Label
    Public WithEvents Label11 As Label
    Public WithEvents LblPhone As Label
    Public WithEvents Label7 As Label
    Public WithEvents LblEmail As Label
    Public WithEvents Label5 As Label
    Public WithEvents LblAge As Label
    Public WithEvents Label3 As Label
    Public WithEvents LblCi As Label
    Public WithEvents Label9 As Label
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Elipse As Guna.UI2.WinForms.Guna2Elipse
End Class
