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
        Me.BtnLogout_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPathologies_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSymp_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdmins_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMedics_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPatients_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnHome_A_H = New Guna.UI2.WinForms.Guna2Button()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblConnect = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTitle2_A_H = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblSubTitleConn_A_H = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblCi = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LblSubTitleTel_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitleName_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitleCred_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitleAge_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitleEmail_A_H = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblInfo4_A_H = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblSubTitle4_A_H = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblSubTitle3_A_H = New System.Windows.Forms.Label()
        Me.LblInfo3_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitle2_A_H = New System.Windows.Forms.Label()
        Me.LblInfo2_A_H = New System.Windows.Forms.Label()
        Me.LblSubTitle1_A_H = New System.Windows.Forms.Label()
        Me.LblInfo1_A_H = New System.Windows.Forms.Label()
        Me.LblTitle1_A_H = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelLeft.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHome.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.BtnLogout_A_H)
        Me.PanelLeft.Controls.Add(Me.BtnPathologies_A_H)
        Me.PanelLeft.Controls.Add(Me.BtnSymp_A_H)
        Me.PanelLeft.Controls.Add(Me.BtnAdmins_A_H)
        Me.PanelLeft.Controls.Add(Me.BtnMedics_A_H)
        Me.PanelLeft.Controls.Add(Me.BtnPatients_A_H)
        Me.PanelLeft.Controls.Add(Me.Guna2PictureBox3)
        Me.PanelLeft.Controls.Add(Me.BtnHome_A_H)
        Me.PanelLeft.Location = New System.Drawing.Point(-1, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(189, 755)
        Me.PanelLeft.TabIndex = 3
        '
        'BtnLogout_A_H
        '
        Me.BtnLogout_A_H.AccessibleDescription = "BtnLogout_A_H"
        Me.BtnLogout_A_H.AccessibleName = "BtnLogout_A_H"
        Me.BtnLogout_A_H.Animated = True
        Me.BtnLogout_A_H.BorderRadius = 10
        Me.BtnLogout_A_H.CheckedState.Parent = Me.BtnLogout_A_H
        Me.BtnLogout_A_H.CustomImages.Parent = Me.BtnLogout_A_H
        Me.BtnLogout_A_H.FillColor = System.Drawing.Color.White
        Me.BtnLogout_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnLogout_A_H.HoverState.Parent = Me.BtnLogout_A_H
        Me.BtnLogout_A_H.Image = Global.AdminApp.My.Resources.Resources.logout
        Me.BtnLogout_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnLogout_A_H.Location = New System.Drawing.Point(19, 693)
        Me.BtnLogout_A_H.Name = "BtnLogout_A_H"
        Me.BtnLogout_A_H.ShadowDecoration.Parent = Me.BtnLogout_A_H
        Me.BtnLogout_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnLogout_A_H.TabIndex = 36
        Me.BtnLogout_A_H.Text = "Cerrar sesión"
        Me.BtnLogout_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnPathologies_A_H
        '
        Me.BtnPathologies_A_H.AccessibleDescription = "BtnPathologies_A_H"
        Me.BtnPathologies_A_H.AccessibleName = "BtnPathologies_A_H"
        Me.BtnPathologies_A_H.Animated = True
        Me.BtnPathologies_A_H.BorderRadius = 10
        Me.BtnPathologies_A_H.CheckedState.Parent = Me.BtnPathologies_A_H
        Me.BtnPathologies_A_H.CustomImages.Parent = Me.BtnPathologies_A_H
        Me.BtnPathologies_A_H.FillColor = System.Drawing.Color.White
        Me.BtnPathologies_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPathologies_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnPathologies_A_H.HoverState.Parent = Me.BtnPathologies_A_H
        Me.BtnPathologies_A_H.Image = Global.AdminApp.My.Resources.Resources.Pathology
        Me.BtnPathologies_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPathologies_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnPathologies_A_H.Location = New System.Drawing.Point(19, 360)
        Me.BtnPathologies_A_H.Name = "BtnPathologies_A_H"
        Me.BtnPathologies_A_H.ShadowDecoration.Parent = Me.BtnPathologies_A_H
        Me.BtnPathologies_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnPathologies_A_H.TabIndex = 35
        Me.BtnPathologies_A_H.Text = "Patologías"
        Me.BtnPathologies_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnSymp_A_H
        '
        Me.BtnSymp_A_H.AccessibleDescription = "BtnSymp_A_H"
        Me.BtnSymp_A_H.AccessibleName = "BtnSymp_A_H"
        Me.BtnSymp_A_H.Animated = True
        Me.BtnSymp_A_H.BorderRadius = 10
        Me.BtnSymp_A_H.CheckedState.Parent = Me.BtnSymp_A_H
        Me.BtnSymp_A_H.CustomImages.Parent = Me.BtnSymp_A_H
        Me.BtnSymp_A_H.FillColor = System.Drawing.Color.White
        Me.BtnSymp_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSymp_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnSymp_A_H.HoverState.Parent = Me.BtnSymp_A_H
        Me.BtnSymp_A_H.Image = Global.AdminApp.My.Resources.Resources.symp
        Me.BtnSymp_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSymp_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnSymp_A_H.Location = New System.Drawing.Point(19, 315)
        Me.BtnSymp_A_H.Name = "BtnSymp_A_H"
        Me.BtnSymp_A_H.ShadowDecoration.Parent = Me.BtnSymp_A_H
        Me.BtnSymp_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnSymp_A_H.TabIndex = 34
        Me.BtnSymp_A_H.Text = "Síntomas"
        Me.BtnSymp_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnAdmins_A_H
        '
        Me.BtnAdmins_A_H.AccessibleDescription = "BtnAdmins_A_H"
        Me.BtnAdmins_A_H.AccessibleName = "BtnAdmins_A_H"
        Me.BtnAdmins_A_H.Animated = True
        Me.BtnAdmins_A_H.BorderRadius = 10
        Me.BtnAdmins_A_H.CheckedState.Parent = Me.BtnAdmins_A_H
        Me.BtnAdmins_A_H.CustomImages.Parent = Me.BtnAdmins_A_H
        Me.BtnAdmins_A_H.FillColor = System.Drawing.Color.White
        Me.BtnAdmins_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmins_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnAdmins_A_H.HoverState.Parent = Me.BtnAdmins_A_H
        Me.BtnAdmins_A_H.Image = Global.AdminApp.My.Resources.Resources.person
        Me.BtnAdmins_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAdmins_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnAdmins_A_H.Location = New System.Drawing.Point(19, 270)
        Me.BtnAdmins_A_H.Name = "BtnAdmins_A_H"
        Me.BtnAdmins_A_H.ShadowDecoration.Parent = Me.BtnAdmins_A_H
        Me.BtnAdmins_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnAdmins_A_H.TabIndex = 33
        Me.BtnAdmins_A_H.Text = "Administradores"
        Me.BtnAdmins_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnMedics_A_H
        '
        Me.BtnMedics_A_H.AccessibleDescription = "BtnMedics_A_H"
        Me.BtnMedics_A_H.AccessibleName = "BtnMedics_A_H"
        Me.BtnMedics_A_H.Animated = True
        Me.BtnMedics_A_H.BorderRadius = 10
        Me.BtnMedics_A_H.CheckedState.Parent = Me.BtnMedics_A_H
        Me.BtnMedics_A_H.CustomImages.Parent = Me.BtnMedics_A_H
        Me.BtnMedics_A_H.FillColor = System.Drawing.Color.White
        Me.BtnMedics_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedics_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnMedics_A_H.HoverState.Parent = Me.BtnMedics_A_H
        Me.BtnMedics_A_H.Image = Global.AdminApp.My.Resources.Resources.person
        Me.BtnMedics_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnMedics_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnMedics_A_H.Location = New System.Drawing.Point(19, 225)
        Me.BtnMedics_A_H.Name = "BtnMedics_A_H"
        Me.BtnMedics_A_H.ShadowDecoration.Parent = Me.BtnMedics_A_H
        Me.BtnMedics_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnMedics_A_H.TabIndex = 32
        Me.BtnMedics_A_H.Text = "Médicos"
        Me.BtnMedics_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnPatients_A_H
        '
        Me.BtnPatients_A_H.AccessibleDescription = "BtnPatients_A_H"
        Me.BtnPatients_A_H.AccessibleName = "BtnPatients_A_H"
        Me.BtnPatients_A_H.Animated = True
        Me.BtnPatients_A_H.BorderRadius = 10
        Me.BtnPatients_A_H.CheckedState.Parent = Me.BtnPatients_A_H
        Me.BtnPatients_A_H.CustomImages.Parent = Me.BtnPatients_A_H
        Me.BtnPatients_A_H.FillColor = System.Drawing.Color.White
        Me.BtnPatients_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPatients_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnPatients_A_H.HoverState.Parent = Me.BtnPatients_A_H
        Me.BtnPatients_A_H.Image = Global.AdminApp.My.Resources.Resources.person
        Me.BtnPatients_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPatients_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnPatients_A_H.Location = New System.Drawing.Point(19, 180)
        Me.BtnPatients_A_H.Name = "BtnPatients_A_H"
        Me.BtnPatients_A_H.ShadowDecoration.Parent = Me.BtnPatients_A_H
        Me.BtnPatients_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnPatients_A_H.TabIndex = 31
        Me.BtnPatients_A_H.Text = "Pacientes"
        Me.BtnPatients_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.AdminApp.My.Resources.Resources.Logo2
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(19, 35)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(77, 76)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox3.TabIndex = 30
        Me.Guna2PictureBox3.TabStop = False
        '
        'BtnHome_A_H
        '
        Me.BtnHome_A_H.AccessibleDescription = "BtnHome_A_H"
        Me.BtnHome_A_H.AccessibleName = "BtnHome_A_H"
        Me.BtnHome_A_H.Animated = True
        Me.BtnHome_A_H.AutoRoundedCorners = True
        Me.BtnHome_A_H.BorderRadius = 18
        Me.BtnHome_A_H.CheckedState.Parent = Me.BtnHome_A_H
        Me.BtnHome_A_H.CustomImages.Parent = Me.BtnHome_A_H
        Me.BtnHome_A_H.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnHome_A_H.Font = New System.Drawing.Font("Roboto", 11.25!)
        Me.BtnHome_A_H.ForeColor = System.Drawing.Color.White
        Me.BtnHome_A_H.HoverState.Parent = Me.BtnHome_A_H
        Me.BtnHome_A_H.Image = Global.AdminApp.My.Resources.Resources.home
        Me.BtnHome_A_H.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnHome_A_H.ImageOffset = New System.Drawing.Point(0, -2)
        Me.BtnHome_A_H.ImageSize = New System.Drawing.Size(20, 17)
        Me.BtnHome_A_H.Location = New System.Drawing.Point(19, 130)
        Me.BtnHome_A_H.Name = "BtnHome_A_H"
        Me.BtnHome_A_H.ShadowDecoration.Parent = Me.BtnHome_A_H
        Me.BtnHome_A_H.Size = New System.Drawing.Size(160, 39)
        Me.BtnHome_A_H.TabIndex = 29
        Me.BtnHome_A_H.Text = "Página principal"
        Me.BtnHome_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me.PanelLeft
        '
        'Elipse
        '
        Me.Elipse.BorderRadius = 20
        Me.Elipse.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.LblConnect)
        Me.Guna2Panel1.Controls.Add(Me.LblEmail)
        Me.Guna2Panel1.Controls.Add(Me.LblTitle2_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleConn_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblName)
        Me.Guna2Panel1.Controls.Add(Me.LblPhone)
        Me.Guna2Panel1.Controls.Add(Me.LblCi)
        Me.Guna2Panel1.Controls.Add(Me.LblAge)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleTel_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleName_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleCred_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleAge_A_H)
        Me.Guna2Panel1.Controls.Add(Me.LblSubTitleEmail_A_H)
        Me.Guna2Panel1.Location = New System.Drawing.Point(558, 328)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(516, 404)
        Me.Guna2Panel1.TabIndex = 35
        '
        'LblConnect
        '
        Me.LblConnect.AccessibleDescription = "LblTitle3"
        Me.LblConnect.AccessibleName = "LblTitle3"
        Me.LblConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConnect.BackColor = System.Drawing.Color.Transparent
        Me.LblConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblConnect.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblConnect.Location = New System.Drawing.Point(138, 349)
        Me.LblConnect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblConnect.Name = "LblConnect"
        Me.LblConnect.Size = New System.Drawing.Size(376, 25)
        Me.LblConnect.TabIndex = 33
        Me.LblConnect.Text = "Conexion"
        Me.LblConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEmail
        '
        Me.LblEmail.AccessibleDescription = "LblTitle3"
        Me.LblEmail.AccessibleName = "LblTitle3"
        Me.LblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmail.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblEmail.Location = New System.Drawing.Point(14, 267)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(497, 19)
        Me.LblEmail.TabIndex = 29
        Me.LblEmail.Text = "Correo"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle2_A_H
        '
        Me.LblTitle2_A_H.AccessibleDescription = "LblTitle2_A_H"
        Me.LblTitle2_A_H.AccessibleName = "LblTitle2_A_H"
        Me.LblTitle2_A_H.AutoSize = False
        Me.LblTitle2_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle2_A_H.Font = New System.Drawing.Font("Roboto Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle2_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LblTitle2_A_H.Location = New System.Drawing.Point(3, 46)
        Me.LblTitle2_A_H.Name = "LblTitle2_A_H"
        Me.LblTitle2_A_H.Size = New System.Drawing.Size(513, 30)
        Me.LblTitle2_A_H.TabIndex = 35
        Me.LblTitle2_A_H.Text = "ACERCA DEL ADMINISTRADOR"
        Me.LblTitle2_A_H.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSubTitleConn_A_H
        '
        Me.LblSubTitleConn_A_H.AccessibleDescription = "LblSubTitleConn_A_H"
        Me.LblSubTitleConn_A_H.AccessibleName = "LblSubTitleConn_A_H"
        Me.LblSubTitleConn_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleConn_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleConn_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleConn_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleConn_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleConn_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleConn_A_H.Location = New System.Drawing.Point(15, 349)
        Me.LblSubTitleConn_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleConn_A_H.Name = "LblSubTitleConn_A_H"
        Me.LblSubTitleConn_A_H.Size = New System.Drawing.Size(504, 25)
        Me.LblSubTitleConn_A_H.TabIndex = 32
        Me.LblSubTitleConn_A_H.Text = "Última Conexión"
        Me.LblSubTitleConn_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblName
        '
        Me.LblName.AccessibleDescription = "LblTitle3"
        Me.LblName.AccessibleName = "LblTitle3"
        Me.LblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblName.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblName.Location = New System.Drawing.Point(13, 115)
        Me.LblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(498, 19)
        Me.LblName.TabIndex = 17
        Me.LblName.Text = "Nombre Completo"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPhone
        '
        Me.LblPhone.AccessibleDescription = "LblTitle3"
        Me.LblPhone.AccessibleName = "LblTitle3"
        Me.LblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPhone.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPhone.Location = New System.Drawing.Point(16, 315)
        Me.LblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(495, 19)
        Me.LblPhone.TabIndex = 31
        Me.LblPhone.Text = "Tel"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCi
        '
        Me.LblCi.AccessibleDescription = "LblTitle3"
        Me.LblCi.AccessibleName = "LblTitle3"
        Me.LblCi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCi.BackColor = System.Drawing.Color.Transparent
        Me.LblCi.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCi.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCi.Location = New System.Drawing.Point(12, 166)
        Me.LblCi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCi.Name = "LblCi"
        Me.LblCi.Size = New System.Drawing.Size(499, 19)
        Me.LblCi.TabIndex = 25
        Me.LblCi.Text = "Credencial"
        Me.LblCi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAge
        '
        Me.LblAge.AccessibleDescription = "LblTitle3"
        Me.LblAge.AccessibleName = "LblTitle3"
        Me.LblAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAge.BackColor = System.Drawing.Color.Transparent
        Me.LblAge.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAge.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAge.Location = New System.Drawing.Point(14, 217)
        Me.LblAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(497, 19)
        Me.LblAge.TabIndex = 27
        Me.LblAge.Text = "Edad"
        Me.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.AdminApp.My.Resources.Resources.User
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(234, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(51, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 35
        Me.Guna2PictureBox1.TabStop = False
        '
        'LblSubTitleTel_A_H
        '
        Me.LblSubTitleTel_A_H.AccessibleDescription = "LblSubTitleTel_A_H"
        Me.LblSubTitleTel_A_H.AccessibleName = "LblSubTitleTel_A_H"
        Me.LblSubTitleTel_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleTel_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleTel_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleTel_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleTel_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleTel_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleTel_A_H.Location = New System.Drawing.Point(15, 295)
        Me.LblSubTitleTel_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleTel_A_H.Name = "LblSubTitleTel_A_H"
        Me.LblSubTitleTel_A_H.Size = New System.Drawing.Size(501, 25)
        Me.LblSubTitleTel_A_H.TabIndex = 30
        Me.LblSubTitleTel_A_H.Text = "Número telefónico"
        Me.LblSubTitleTel_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitleName_A_H
        '
        Me.LblSubTitleName_A_H.AccessibleDescription = "LblSubTitleName_A_H"
        Me.LblSubTitleName_A_H.AccessibleName = "LblSubTitleName_A_H"
        Me.LblSubTitleName_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleName_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleName_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleName_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleName_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleName_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleName_A_H.Location = New System.Drawing.Point(12, 95)
        Me.LblSubTitleName_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleName_A_H.Name = "LblSubTitleName_A_H"
        Me.LblSubTitleName_A_H.Size = New System.Drawing.Size(502, 25)
        Me.LblSubTitleName_A_H.TabIndex = 15
        Me.LblSubTitleName_A_H.Text = "Nombre Completo"
        Me.LblSubTitleName_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitleCred_A_H
        '
        Me.LblSubTitleCred_A_H.AccessibleDescription = "LblSubTitleCred_A_H"
        Me.LblSubTitleCred_A_H.AccessibleName = "LblSubTitleCred_A_H"
        Me.LblSubTitleCred_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleCred_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleCred_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleCred_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleCred_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleCred_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleCred_A_H.Location = New System.Drawing.Point(12, 146)
        Me.LblSubTitleCred_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleCred_A_H.Name = "LblSubTitleCred_A_H"
        Me.LblSubTitleCred_A_H.Size = New System.Drawing.Size(502, 25)
        Me.LblSubTitleCred_A_H.TabIndex = 24
        Me.LblSubTitleCred_A_H.Text = "Documento o Credencial"
        Me.LblSubTitleCred_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitleAge_A_H
        '
        Me.LblSubTitleAge_A_H.AccessibleDescription = "LblSubTitleAge_A_H"
        Me.LblSubTitleAge_A_H.AccessibleName = "LblSubTitleAge_A_H"
        Me.LblSubTitleAge_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleAge_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleAge_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleAge_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleAge_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleAge_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleAge_A_H.Location = New System.Drawing.Point(13, 196)
        Me.LblSubTitleAge_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleAge_A_H.Name = "LblSubTitleAge_A_H"
        Me.LblSubTitleAge_A_H.Size = New System.Drawing.Size(503, 25)
        Me.LblSubTitleAge_A_H.TabIndex = 26
        Me.LblSubTitleAge_A_H.Text = "Edad"
        Me.LblSubTitleAge_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitleEmail_A_H
        '
        Me.LblSubTitleEmail_A_H.AccessibleDescription = "LblSubTitleEmail_A_H"
        Me.LblSubTitleEmail_A_H.AccessibleName = "LblSubTitleEmail_A_H"
        Me.LblSubTitleEmail_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitleEmail_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitleEmail_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitleEmail_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitleEmail_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitleEmail_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitleEmail_A_H.Location = New System.Drawing.Point(14, 249)
        Me.LblSubTitleEmail_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitleEmail_A_H.Name = "LblSubTitleEmail_A_H"
        Me.LblSubTitleEmail_A_H.Size = New System.Drawing.Size(502, 25)
        Me.LblSubTitleEmail_A_H.TabIndex = 28
        Me.LblSubTitleEmail_A_H.Text = "Dirección de correo electrónico"
        Me.LblSubTitleEmail_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 4
        Me.Guna2Panel2.Controls.Add(Me.LblInfo4_A_H)
        Me.Guna2Panel2.Controls.Add(Me.Label15)
        Me.Guna2Panel2.Controls.Add(Me.Label13)
        Me.Guna2Panel2.Controls.Add(Me.LblSubTitle4_A_H)
        Me.Guna2Panel2.Controls.Add(Me.Label12)
        Me.Guna2Panel2.Controls.Add(Me.LblSubTitle3_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblInfo3_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblSubTitle2_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblInfo2_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblSubTitle1_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblInfo1_A_H)
        Me.Guna2Panel2.Controls.Add(Me.LblTitle1_A_H)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.Label16)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 325)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(516, 407)
        Me.Guna2Panel2.TabIndex = 36
        '
        'LblInfo4_A_H
        '
        Me.LblInfo4_A_H.AccessibleDescription = "LblInfo4_A_H"
        Me.LblInfo4_A_H.AccessibleName = "LblInfo4_A_H"
        Me.LblInfo4_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInfo4_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo4_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfo4_A_H.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.LblInfo4_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo4_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo4_A_H.Location = New System.Drawing.Point(28, 352)
        Me.LblInfo4_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo4_A_H.Name = "LblInfo4_A_H"
        Me.LblInfo4_A_H.Size = New System.Drawing.Size(487, 25)
        Me.LblInfo4_A_H.TabIndex = 47
        Me.LblInfo4_A_H.Text = "© Telediagnóstico Médico 2020. Derechos reservados"
        Me.LblInfo4_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AccessibleDescription = "LblTitle3"
        Me.Label15.AccessibleName = "LblTitle3"
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(29, 310)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(487, 25)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Mayza Daniela Ferreira Hernández."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AccessibleDescription = "LblTitle3"
        Me.Label13.AccessibleName = "LblTitle3"
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(29, 290)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(487, 25)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Agustín Yorel Acosta Bergonzoni."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitle4_A_H
        '
        Me.LblSubTitle4_A_H.AccessibleDescription = "LblSubTitle4_A_H"
        Me.LblSubTitle4_A_H.AccessibleName = "LblSubTitle4_A_H"
        Me.LblSubTitle4_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitle4_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitle4_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitle4_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle4_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitle4_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitle4_A_H.Location = New System.Drawing.Point(27, 252)
        Me.LblSubTitle4_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitle4_A_H.Name = "LblSubTitle4_A_H"
        Me.LblSubTitle4_A_H.Size = New System.Drawing.Size(491, 25)
        Me.LblSubTitle4_A_H.TabIndex = 42
        Me.LblSubTitle4_A_H.Text = "Desarrolladores del Sistema"
        Me.LblSubTitle4_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = "LblTitle3"
        Me.Label12.AccessibleName = "LblTitle3"
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(28, 270)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(487, 25)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Kevin Mathew Anadón Wappler."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitle3_A_H
        '
        Me.LblSubTitle3_A_H.AccessibleDescription = "LblSubTitle3_A_H"
        Me.LblSubTitle3_A_H.AccessibleName = "LblSubTitle3_A_H"
        Me.LblSubTitle3_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitle3_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitle3_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitle3_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle3_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitle3_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitle3_A_H.Location = New System.Drawing.Point(26, 199)
        Me.LblSubTitle3_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitle3_A_H.Name = "LblSubTitle3_A_H"
        Me.LblSubTitle3_A_H.Size = New System.Drawing.Size(491, 25)
        Me.LblSubTitle3_A_H.TabIndex = 40
        Me.LblSubTitle3_A_H.Text = "Versión del Sistema"
        Me.LblSubTitle3_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInfo3_A_H
        '
        Me.LblInfo3_A_H.AccessibleDescription = "LblInfo3_A_H"
        Me.LblInfo3_A_H.AccessibleName = "LblInfo3_A_H"
        Me.LblInfo3_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInfo3_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo3_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfo3_A_H.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.LblInfo3_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo3_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo3_A_H.Location = New System.Drawing.Point(27, 217)
        Me.LblInfo3_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo3_A_H.Name = "LblInfo3_A_H"
        Me.LblInfo3_A_H.Size = New System.Drawing.Size(487, 25)
        Me.LblInfo3_A_H.TabIndex = 41
        Me.LblInfo3_A_H.Text = "V2.0.1 Beta."
        Me.LblInfo3_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitle2_A_H
        '
        Me.LblSubTitle2_A_H.AccessibleDescription = "LblSubTitle2_A_H"
        Me.LblSubTitle2_A_H.AccessibleName = "LblSubTitle2_A_H"
        Me.LblSubTitle2_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitle2_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitle2_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitle2_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle2_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitle2_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitle2_A_H.Location = New System.Drawing.Point(25, 149)
        Me.LblSubTitle2_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitle2_A_H.Name = "LblSubTitle2_A_H"
        Me.LblSubTitle2_A_H.Size = New System.Drawing.Size(491, 25)
        Me.LblSubTitle2_A_H.TabIndex = 38
        Me.LblSubTitle2_A_H.Text = "Sistema"
        Me.LblSubTitle2_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInfo2_A_H
        '
        Me.LblInfo2_A_H.AccessibleDescription = "LblInfo2_A_H"
        Me.LblInfo2_A_H.AccessibleName = "LblInfo2_A_H"
        Me.LblInfo2_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInfo2_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo2_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfo2_A_H.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.LblInfo2_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo2_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo2_A_H.Location = New System.Drawing.Point(26, 167)
        Me.LblInfo2_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo2_A_H.Name = "LblInfo2_A_H"
        Me.LblInfo2_A_H.Size = New System.Drawing.Size(487, 25)
        Me.LblInfo2_A_H.TabIndex = 39
        Me.LblInfo2_A_H.Text = "Sistema de Gestión para Administradores."
        Me.LblInfo2_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubTitle1_A_H
        '
        Me.LblSubTitle1_A_H.AccessibleDescription = "LblSubTitle1_A_H"
        Me.LblSubTitle1_A_H.AccessibleName = "LblTitle3"
        Me.LblSubTitle1_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitle1_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitle1_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSubTitle1_A_H.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle1_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblSubTitle1_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSubTitle1_A_H.Location = New System.Drawing.Point(23, 98)
        Me.LblSubTitle1_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTitle1_A_H.Name = "LblSubTitle1_A_H"
        Me.LblSubTitle1_A_H.Size = New System.Drawing.Size(491, 25)
        Me.LblSubTitle1_A_H.TabIndex = 15
        Me.LblSubTitle1_A_H.Text = "Propietario"
        Me.LblSubTitle1_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInfo1_A_H
        '
        Me.LblInfo1_A_H.AccessibleDescription = "LblInfo1_A_H"
        Me.LblInfo1_A_H.AccessibleName = "LblInfo1_A_H"
        Me.LblInfo1_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInfo1_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo1_A_H.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfo1_A_H.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.LblInfo1_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo1_A_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo1_A_H.Location = New System.Drawing.Point(24, 116)
        Me.LblInfo1_A_H.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo1_A_H.Name = "LblInfo1_A_H"
        Me.LblInfo1_A_H.Size = New System.Drawing.Size(487, 25)
        Me.LblInfo1_A_H.TabIndex = 37
        Me.LblInfo1_A_H.Text = "Centro de Atención de Salud."
        Me.LblInfo1_A_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle1_A_H
        '
        Me.LblTitle1_A_H.AccessibleDescription = "LblTitle1_A_H"
        Me.LblTitle1_A_H.AccessibleName = "LblTitle1_A_H"
        Me.LblTitle1_A_H.AutoSize = False
        Me.LblTitle1_A_H.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1_A_H.Font = New System.Drawing.Font("Roboto Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1_A_H.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LblTitle1_A_H.Location = New System.Drawing.Point(0, 46)
        Me.LblTitle1_A_H.Name = "LblTitle1_A_H"
        Me.LblTitle1_A_H.Size = New System.Drawing.Size(516, 30)
        Me.LblTitle1_A_H.TabIndex = 36
        Me.LblTitle1_A_H.Text = "ACERCA DEL SISTEMA"
        Me.LblTitle1_A_H.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.AdminApp.My.Resources.Resources.AboutSystem
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(233, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 35
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.AccessibleDescription = "LblTitle3"
        Me.Label16.AccessibleName = "LblTitle3"
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(29, 329)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(487, 25)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Ignacio Rodríguez Sosa."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelHome
        '
        Me.PanelHome.BackColor = System.Drawing.Color.Transparent
        Me.PanelHome.BackgroundImage = CType(resources.GetObject("PanelHome.BackgroundImage"), System.Drawing.Image)
        Me.PanelHome.Controls.Add(Me.Guna2PictureBox4)
        Me.PanelHome.Controls.Add(Me.Guna2Panel2)
        Me.PanelHome.Controls.Add(Me.Guna2Panel1)
        Me.PanelHome.ForeColor = System.Drawing.Color.Transparent
        Me.PanelHome.Location = New System.Drawing.Point(188, 0)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(1110, 755)
        Me.PanelHome.TabIndex = 5
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BorderRadius = 20
        Me.Guna2PictureBox4.Image = Global.AdminApp.My.Resources.Resources.Medics
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(18, 35)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.ShadowDecoration.Parent = Me.Guna2PictureBox4
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(1056, 274)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox4.TabIndex = 37
        Me.Guna2PictureBox4.TabStop = False
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1299, 754)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHome.ResumeLayout(False)
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnHome_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnPathologies_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSymp_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdmins_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMedics_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPatients_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnLogout_A_H As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelHome As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Public WithEvents LblInfo4_A_H As Label
    Public WithEvents Label15 As Label
    Public WithEvents Label13 As Label
    Public WithEvents LblSubTitle4_A_H As Label
    Public WithEvents Label12 As Label
    Public WithEvents LblSubTitle3_A_H As Label
    Public WithEvents LblInfo3_A_H As Label
    Public WithEvents LblSubTitle2_A_H As Label
    Public WithEvents LblInfo2_A_H As Label
    Public WithEvents LblSubTitle1_A_H As Label
    Public WithEvents LblInfo1_A_H As Label
    Friend WithEvents LblTitle1_A_H As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Public WithEvents Label16 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Public WithEvents LblConnect As Label
    Public WithEvents LblEmail As Label
    Friend WithEvents LblTitle2_A_H As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents LblSubTitleConn_A_H As Label
    Public WithEvents LblName As Label
    Public WithEvents LblPhone As Label
    Public WithEvents LblCi As Label
    Public WithEvents LblAge As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Public WithEvents LblSubTitleTel_A_H As Label
    Public WithEvents LblSubTitleName_A_H As Label
    Public WithEvents LblSubTitleCred_A_H As Label
    Public WithEvents LblSubTitleAge_A_H As Label
    Public WithEvents LblSubTitleEmail_A_H As Label
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
End Class
