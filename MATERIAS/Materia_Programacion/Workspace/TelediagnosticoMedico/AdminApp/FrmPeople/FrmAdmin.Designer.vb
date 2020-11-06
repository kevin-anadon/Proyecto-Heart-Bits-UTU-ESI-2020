<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.BtnFaq_A_H = New Guna.UI.WinForms.GunaButton()
        Me.PicBar = New System.Windows.Forms.PictureBox()
        Me.BtnLogout_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnPathologies_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnSymp_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdmins_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnMedics_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnPatients_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.BtnHome_A_HP = New Guna.UI.WinForms.GunaButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PnlBod = New Guna.UI.WinForms.GunaPanel()
        Me.BtnAllow_A_P = New Guna.UI.WinForms.GunaButton()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnModAdmin_A_A = New Guna.UI.WinForms.GunaButton()
        Me.BtnDelAdmin_A_A = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddAdmin_A_A = New Guna.UI.WinForms.GunaButton()
        Me.LblListadoAdmin_A_A = New System.Windows.Forms.Label()
        Me.DgvAdmin = New Guna.UI.WinForms.GunaDataGridView()
        Me.PicBusqueda = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TxtCi = New Guna.UI.WinForms.GunaTextBox()
        Me.LblCrit_A_S = New System.Windows.Forms.Label()
        Me.PnlTittle = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTittleAdmin_A_A = New System.Windows.Forms.Label()
        Me.Elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBod.SuspendLayout()
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTittle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PanelButtons)
        Me.PanelLeft.Controls.Add(Me.PicLogo)
        Me.PanelLeft.Location = New System.Drawing.Point(1, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(188, 640)
        Me.PanelLeft.TabIndex = 11
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.BtnFaq_A_H)
        Me.PanelButtons.Controls.Add(Me.PicBar)
        Me.PanelButtons.Controls.Add(Me.BtnLogout_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnPathologies_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnSymp_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnAdmins_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnMedics_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnPatients_A_HP)
        Me.PanelButtons.Controls.Add(Me.BtnHome_A_HP)
        Me.PanelButtons.Location = New System.Drawing.Point(19, 108)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(166, 515)
        Me.PanelButtons.TabIndex = 1
        '
        'BtnFaq_A_H
        '
        Me.BtnFaq_A_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFaq_A_H.Animated = True
        Me.BtnFaq_A_H.AnimationHoverSpeed = 0.07!
        Me.BtnFaq_A_H.AnimationSpeed = 0.03!
        Me.BtnFaq_A_H.BackColor = System.Drawing.Color.Transparent
        Me.BtnFaq_A_H.BaseColor = System.Drawing.Color.White
        Me.BtnFaq_A_H.BorderColor = System.Drawing.Color.Black
        Me.BtnFaq_A_H.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnFaq_A_H.FocusedColor = System.Drawing.Color.Empty
        Me.BtnFaq_A_H.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFaq_A_H.ForeColor = System.Drawing.Color.Black
        Me.BtnFaq_A_H.Image = CType(resources.GetObject("BtnFaq_A_H.Image"), System.Drawing.Image)
        Me.BtnFaq_A_H.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnFaq_A_H.Location = New System.Drawing.Point(9, 447)
        Me.BtnFaq_A_H.Name = "BtnFaq_A_H"
        Me.BtnFaq_A_H.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnFaq_A_H.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnFaq_A_H.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnFaq_A_H.OnHoverImage = Nothing
        Me.BtnFaq_A_H.OnPressedColor = System.Drawing.Color.Black
        Me.BtnFaq_A_H.Radius = 6
        Me.BtnFaq_A_H.Size = New System.Drawing.Size(146, 30)
        Me.BtnFaq_A_H.TabIndex = 29
        Me.BtnFaq_A_H.Text = "FAQ"
        Me.BtnFaq_A_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicBar
        '
        Me.PicBar.BackColor = System.Drawing.Color.Transparent
        Me.PicBar.Image = CType(resources.GetObject("PicBar.Image"), System.Drawing.Image)
        Me.PicBar.Location = New System.Drawing.Point(159, 130)
        Me.PicBar.Name = "PicBar"
        Me.PicBar.Size = New System.Drawing.Size(10, 30)
        Me.PicBar.TabIndex = 30
        Me.PicBar.TabStop = False
        '
        'BtnLogout_A_HP
        '
        Me.BtnLogout_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout_A_HP.Animated = True
        Me.BtnLogout_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnLogout_A_HP.AnimationSpeed = 0.03!
        Me.BtnLogout_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout_A_HP.BaseColor = System.Drawing.Color.White
        Me.BtnLogout_A_HP.BorderColor = System.Drawing.Color.Black
        Me.BtnLogout_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogout_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLogout_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout_A_HP.Image = CType(resources.GetObject("BtnLogout_A_HP.Image"), System.Drawing.Image)
        Me.BtnLogout_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnLogout_A_HP.Location = New System.Drawing.Point(9, 483)
        Me.BtnLogout_A_HP.Name = "BtnLogout_A_HP"
        Me.BtnLogout_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnLogout_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnLogout_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnLogout_A_HP.OnHoverImage = Nothing
        Me.BtnLogout_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnLogout_A_HP.Radius = 6
        Me.BtnLogout_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnLogout_A_HP.TabIndex = 28
        Me.BtnLogout_A_HP.Text = "Cerrar sesión"
        Me.BtnLogout_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPathologies_A_HP
        '
        Me.BtnPathologies_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPathologies_A_HP.Animated = True
        Me.BtnPathologies_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnPathologies_A_HP.AnimationSpeed = 0.03!
        Me.BtnPathologies_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnPathologies_A_HP.BaseColor = System.Drawing.Color.White
        Me.BtnPathologies_A_HP.BorderColor = System.Drawing.Color.Black
        Me.BtnPathologies_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPathologies_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPathologies_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPathologies_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnPathologies_A_HP.Image = CType(resources.GetObject("BtnPathologies_A_HP.Image"), System.Drawing.Image)
        Me.BtnPathologies_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPathologies_A_HP.Location = New System.Drawing.Point(9, 202)
        Me.BtnPathologies_A_HP.Name = "BtnPathologies_A_HP"
        Me.BtnPathologies_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPathologies_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPathologies_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPathologies_A_HP.OnHoverImage = Nothing
        Me.BtnPathologies_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPathologies_A_HP.Radius = 6
        Me.BtnPathologies_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnPathologies_A_HP.TabIndex = 27
        Me.BtnPathologies_A_HP.Text = "Patologías"
        Me.BtnPathologies_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSymp_A_HP
        '
        Me.BtnSymp_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSymp_A_HP.Animated = True
        Me.BtnSymp_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnSymp_A_HP.AnimationSpeed = 0.03!
        Me.BtnSymp_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnSymp_A_HP.BaseColor = System.Drawing.Color.White
        Me.BtnSymp_A_HP.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.BtnSymp_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSymp_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnSymp_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSymp_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnSymp_A_HP.Image = CType(resources.GetObject("BtnSymp_A_HP.Image"), System.Drawing.Image)
        Me.BtnSymp_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnSymp_A_HP.Location = New System.Drawing.Point(9, 166)
        Me.BtnSymp_A_HP.Name = "BtnSymp_A_HP"
        Me.BtnSymp_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnSymp_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnSymp_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnSymp_A_HP.OnHoverImage = Nothing
        Me.BtnSymp_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnSymp_A_HP.Radius = 6
        Me.BtnSymp_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnSymp_A_HP.TabIndex = 26
        Me.BtnSymp_A_HP.Text = "Síntomas"
        Me.BtnSymp_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdmins_A_HP
        '
        Me.BtnAdmins_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdmins_A_HP.Animated = True
        Me.BtnAdmins_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnAdmins_A_HP.AnimationSpeed = 0.03!
        Me.BtnAdmins_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdmins_A_HP.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAdmins_A_HP.BorderColor = System.Drawing.Color.Black
        Me.BtnAdmins_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdmins_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdmins_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmins_A_HP.ForeColor = System.Drawing.Color.White
        Me.BtnAdmins_A_HP.Image = CType(resources.GetObject("BtnAdmins_A_HP.Image"), System.Drawing.Image)
        Me.BtnAdmins_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdmins_A_HP.Location = New System.Drawing.Point(9, 130)
        Me.BtnAdmins_A_HP.Name = "BtnAdmins_A_HP"
        Me.BtnAdmins_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnAdmins_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdmins_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdmins_A_HP.OnHoverImage = Nothing
        Me.BtnAdmins_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdmins_A_HP.Radius = 6
        Me.BtnAdmins_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnAdmins_A_HP.TabIndex = 25
        Me.BtnAdmins_A_HP.Text = "Administradores"
        '
        'BtnMedics_A_HP
        '
        Me.BtnMedics_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMedics_A_HP.Animated = True
        Me.BtnMedics_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnMedics_A_HP.AnimationSpeed = 0.03!
        Me.BtnMedics_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnMedics_A_HP.BaseColor = System.Drawing.Color.White
        Me.BtnMedics_A_HP.BorderColor = System.Drawing.Color.Black
        Me.BtnMedics_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMedics_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnMedics_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedics_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnMedics_A_HP.Image = CType(resources.GetObject("BtnMedics_A_HP.Image"), System.Drawing.Image)
        Me.BtnMedics_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnMedics_A_HP.Location = New System.Drawing.Point(9, 94)
        Me.BtnMedics_A_HP.Name = "BtnMedics_A_HP"
        Me.BtnMedics_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnMedics_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnMedics_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnMedics_A_HP.OnHoverImage = Nothing
        Me.BtnMedics_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnMedics_A_HP.Radius = 6
        Me.BtnMedics_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnMedics_A_HP.TabIndex = 24
        Me.BtnMedics_A_HP.Text = "Médicos"
        Me.BtnMedics_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPatients_A_HP
        '
        Me.BtnPatients_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPatients_A_HP.Animated = True
        Me.BtnPatients_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnPatients_A_HP.AnimationSpeed = 0.03!
        Me.BtnPatients_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnPatients_A_HP.BaseColor = System.Drawing.Color.White
        Me.BtnPatients_A_HP.BorderColor = System.Drawing.Color.Black
        Me.BtnPatients_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPatients_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPatients_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPatients_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnPatients_A_HP.Image = CType(resources.GetObject("BtnPatients_A_HP.Image"), System.Drawing.Image)
        Me.BtnPatients_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPatients_A_HP.Location = New System.Drawing.Point(9, 58)
        Me.BtnPatients_A_HP.Name = "BtnPatients_A_HP"
        Me.BtnPatients_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPatients_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPatients_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPatients_A_HP.OnHoverImage = Nothing
        Me.BtnPatients_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPatients_A_HP.Radius = 6
        Me.BtnPatients_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnPatients_A_HP.TabIndex = 23
        Me.BtnPatients_A_HP.Text = "Pacientes"
        Me.BtnPatients_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnHome_A_HP
        '
        Me.BtnHome_A_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHome_A_HP.Animated = True
        Me.BtnHome_A_HP.AnimationHoverSpeed = 0.07!
        Me.BtnHome_A_HP.AnimationSpeed = 0.03!
        Me.BtnHome_A_HP.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome_A_HP.BaseColor = System.Drawing.Color.Transparent
        Me.BtnHome_A_HP.BorderColor = System.Drawing.Color.Transparent
        Me.BtnHome_A_HP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnHome_A_HP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnHome_A_HP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome_A_HP.ForeColor = System.Drawing.Color.Black
        Me.BtnHome_A_HP.Image = CType(resources.GetObject("BtnHome_A_HP.Image"), System.Drawing.Image)
        Me.BtnHome_A_HP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnHome_A_HP.Location = New System.Drawing.Point(9, 22)
        Me.BtnHome_A_HP.Name = "BtnHome_A_HP"
        Me.BtnHome_A_HP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnHome_A_HP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnHome_A_HP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnHome_A_HP.OnHoverImage = Nothing
        Me.BtnHome_A_HP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnHome_A_HP.Radius = 6
        Me.BtnHome_A_HP.Size = New System.Drawing.Size(146, 30)
        Me.BtnHome_A_HP.TabIndex = 22
        Me.BtnHome_A_HP.Text = "Página principal"
        Me.BtnHome_A_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me.PnlBod
        '
        'PnlBod
        '
        Me.PnlBod.BackgroundImage = CType(resources.GetObject("PnlBod.BackgroundImage"), System.Drawing.Image)
        Me.PnlBod.Controls.Add(Me.BtnAllow_A_P)
        Me.PnlBod.Controls.Add(Me.Guna2ControlBox2)
        Me.PnlBod.Controls.Add(Me.Guna2ControlBox1)
        Me.PnlBod.Controls.Add(Me.BtnModAdmin_A_A)
        Me.PnlBod.Controls.Add(Me.BtnDelAdmin_A_A)
        Me.PnlBod.Controls.Add(Me.BtnAddAdmin_A_A)
        Me.PnlBod.Controls.Add(Me.LblListadoAdmin_A_A)
        Me.PnlBod.Controls.Add(Me.DgvAdmin)
        Me.PnlBod.Controls.Add(Me.PicBusqueda)
        Me.PnlBod.Controls.Add(Me.TxtCi)
        Me.PnlBod.Controls.Add(Me.LblCrit_A_S)
        Me.PnlBod.Controls.Add(Me.PnlTittle)
        Me.PnlBod.Location = New System.Drawing.Point(192, 0)
        Me.PnlBod.Name = "PnlBod"
        Me.PnlBod.Size = New System.Drawing.Size(870, 640)
        Me.PnlBod.TabIndex = 10
        '
        'BtnAllow_A_P
        '
        Me.BtnAllow_A_P.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAllow_A_P.Animated = True
        Me.BtnAllow_A_P.AnimationHoverSpeed = 0.07!
        Me.BtnAllow_A_P.AnimationSpeed = 0.03!
        Me.BtnAllow_A_P.BackColor = System.Drawing.Color.Transparent
        Me.BtnAllow_A_P.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAllow_A_P.BorderColor = System.Drawing.Color.Black
        Me.BtnAllow_A_P.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAllow_A_P.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAllow_A_P.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllow_A_P.ForeColor = System.Drawing.Color.White
        Me.BtnAllow_A_P.Image = CType(resources.GetObject("BtnAllow_A_P.Image"), System.Drawing.Image)
        Me.BtnAllow_A_P.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnAllow_A_P.ImageOffsetX = -4
        Me.BtnAllow_A_P.ImageSize = New System.Drawing.Size(13, 11)
        Me.BtnAllow_A_P.Location = New System.Drawing.Point(270, 214)
        Me.BtnAllow_A_P.Name = "BtnAllow_A_P"
        Me.BtnAllow_A_P.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnAllow_A_P.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAllow_A_P.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAllow_A_P.OnHoverImage = Nothing
        Me.BtnAllow_A_P.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAllow_A_P.Radius = 11
        Me.BtnAllow_A_P.Size = New System.Drawing.Size(96, 20)
        Me.BtnAllow_A_P.TabIndex = 60
        Me.BtnAllow_A_P.Text = "HABILITAR"
        Me.BtnAllow_A_P.Visible = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(778, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 59
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(825, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 58
        '
        'BtnModAdmin_A_A
        '
        Me.BtnModAdmin_A_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModAdmin_A_A.Animated = True
        Me.BtnModAdmin_A_A.AnimationHoverSpeed = 0.07!
        Me.BtnModAdmin_A_A.AnimationSpeed = 0.03!
        Me.BtnModAdmin_A_A.BackColor = System.Drawing.Color.Transparent
        Me.BtnModAdmin_A_A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnModAdmin_A_A.BorderColor = System.Drawing.Color.Black
        Me.BtnModAdmin_A_A.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnModAdmin_A_A.FocusedColor = System.Drawing.Color.Empty
        Me.BtnModAdmin_A_A.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModAdmin_A_A.ForeColor = System.Drawing.Color.White
        Me.BtnModAdmin_A_A.Image = CType(resources.GetObject("BtnModAdmin_A_A.Image"), System.Drawing.Image)
        Me.BtnModAdmin_A_A.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnModAdmin_A_A.ImageOffsetX = -10
        Me.BtnModAdmin_A_A.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnModAdmin_A_A.Location = New System.Drawing.Point(372, 214)
        Me.BtnModAdmin_A_A.Name = "BtnModAdmin_A_A"
        Me.BtnModAdmin_A_A.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnModAdmin_A_A.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnModAdmin_A_A.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnModAdmin_A_A.OnHoverImage = Nothing
        Me.BtnModAdmin_A_A.OnPressedColor = System.Drawing.Color.Black
        Me.BtnModAdmin_A_A.Radius = 11
        Me.BtnModAdmin_A_A.Size = New System.Drawing.Size(163, 20)
        Me.BtnModAdmin_A_A.TabIndex = 2
        Me.BtnModAdmin_A_A.Text = "MODIFICAR PACIENTE"
        '
        'BtnDelAdmin_A_A
        '
        Me.BtnDelAdmin_A_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelAdmin_A_A.Animated = True
        Me.BtnDelAdmin_A_A.AnimationHoverSpeed = 0.07!
        Me.BtnDelAdmin_A_A.AnimationSpeed = 0.03!
        Me.BtnDelAdmin_A_A.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelAdmin_A_A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnDelAdmin_A_A.BorderColor = System.Drawing.Color.Black
        Me.BtnDelAdmin_A_A.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDelAdmin_A_A.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDelAdmin_A_A.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelAdmin_A_A.ForeColor = System.Drawing.Color.White
        Me.BtnDelAdmin_A_A.Image = CType(resources.GetObject("BtnDelAdmin_A_A.Image"), System.Drawing.Image)
        Me.BtnDelAdmin_A_A.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnDelAdmin_A_A.ImageOffsetX = -10
        Me.BtnDelAdmin_A_A.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnDelAdmin_A_A.Location = New System.Drawing.Point(541, 214)
        Me.BtnDelAdmin_A_A.Name = "BtnDelAdmin_A_A"
        Me.BtnDelAdmin_A_A.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnDelAdmin_A_A.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnDelAdmin_A_A.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnDelAdmin_A_A.OnHoverImage = Nothing
        Me.BtnDelAdmin_A_A.OnPressedColor = System.Drawing.Color.Black
        Me.BtnDelAdmin_A_A.Radius = 11
        Me.BtnDelAdmin_A_A.Size = New System.Drawing.Size(154, 20)
        Me.BtnDelAdmin_A_A.TabIndex = 4
        Me.BtnDelAdmin_A_A.Text = "ELIMINAR PACIENTE"
        '
        'BtnAddAdmin_A_A
        '
        Me.BtnAddAdmin_A_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAdmin_A_A.Animated = True
        Me.BtnAddAdmin_A_A.AnimationHoverSpeed = 0.07!
        Me.BtnAddAdmin_A_A.AnimationSpeed = 0.03!
        Me.BtnAddAdmin_A_A.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddAdmin_A_A.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAddAdmin_A_A.BorderColor = System.Drawing.Color.Black
        Me.BtnAddAdmin_A_A.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddAdmin_A_A.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddAdmin_A_A.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddAdmin_A_A.ForeColor = System.Drawing.Color.White
        Me.BtnAddAdmin_A_A.Image = CType(resources.GetObject("BtnAddAdmin_A_A.Image"), System.Drawing.Image)
        Me.BtnAddAdmin_A_A.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnAddAdmin_A_A.ImageOffsetX = -10
        Me.BtnAddAdmin_A_A.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddAdmin_A_A.Location = New System.Drawing.Point(701, 214)
        Me.BtnAddAdmin_A_A.Name = "BtnAddAdmin_A_A"
        Me.BtnAddAdmin_A_A.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnAddAdmin_A_A.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddAdmin_A_A.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddAdmin_A_A.OnHoverImage = Nothing
        Me.BtnAddAdmin_A_A.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddAdmin_A_A.Radius = 11
        Me.BtnAddAdmin_A_A.Size = New System.Drawing.Size(138, 20)
        Me.BtnAddAdmin_A_A.TabIndex = 5
        Me.BtnAddAdmin_A_A.Text = "NUEVO PACIENTE"
        '
        'LblListadoAdmin_A_A
        '
        Me.LblListadoAdmin_A_A.AccessibleDescription = "LblResults"
        Me.LblListadoAdmin_A_A.AccessibleName = "LblResults"
        Me.LblListadoAdmin_A_A.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListadoAdmin_A_A.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblListadoAdmin_A_A.Location = New System.Drawing.Point(12, 204)
        Me.LblListadoAdmin_A_A.Name = "LblListadoAdmin_A_A"
        Me.LblListadoAdmin_A_A.Size = New System.Drawing.Size(844, 37)
        Me.LblListadoAdmin_A_A.TabIndex = 3
        Me.LblListadoAdmin_A_A.Text = "LISTADO ADMINISTRADORES"
        Me.LblListadoAdmin_A_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvAdmin
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAdmin.BackgroundColor = System.Drawing.Color.White
        Me.DgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAdmin.ColumnHeadersHeight = 26
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAdmin.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvAdmin.EnableHeadersVisualStyles = False
        Me.DgvAdmin.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvAdmin.Location = New System.Drawing.Point(13, 240)
        Me.DgvAdmin.Name = "DgvAdmin"
        Me.DgvAdmin.ReadOnly = True
        Me.DgvAdmin.RowHeadersVisible = False
        Me.DgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdmin.Size = New System.Drawing.Size(843, 381)
        Me.DgvAdmin.TabIndex = 0
        Me.DgvAdmin.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgvAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvAdmin.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvAdmin.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvAdmin.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvAdmin.ThemeStyle.HeaderStyle.Height = 26
        Me.DgvAdmin.ThemeStyle.ReadOnly = True
        Me.DgvAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAdmin.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvAdmin.ThemeStyle.RowsStyle.Height = 22
        Me.DgvAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PicBusqueda
        '
        Me.PicBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.PicBusqueda.Image = CType(resources.GetObject("PicBusqueda.Image"), System.Drawing.Image)
        Me.PicBusqueda.Location = New System.Drawing.Point(13, 158)
        Me.PicBusqueda.Name = "PicBusqueda"
        Me.PicBusqueda.ShadowDecoration.Parent = Me.PicBusqueda
        Me.PicBusqueda.Size = New System.Drawing.Size(23, 23)
        Me.PicBusqueda.TabIndex = 54
        Me.PicBusqueda.TabStop = False
        Me.PicBusqueda.UseTransparentBackground = True
        '
        'TxtCi
        '
        Me.TxtCi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtCi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtCi.BackColor = System.Drawing.Color.Transparent
        Me.TxtCi.BaseColor = System.Drawing.Color.White
        Me.TxtCi.BorderColor = System.Drawing.Color.Silver
        Me.TxtCi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCi.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtCi.FocusedBorderColor = System.Drawing.Color.Silver
        Me.TxtCi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtCi.Location = New System.Drawing.Point(42, 153)
        Me.TxtCi.Multiline = True
        Me.TxtCi.Name = "TxtCi"
        Me.TxtCi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCi.Radius = 8
        Me.TxtCi.SelectedText = ""
        Me.TxtCi.Size = New System.Drawing.Size(187, 30)
        Me.TxtCi.TabIndex = 1
        Me.TxtCi.Text = "Realizar busqueda por c.i"
        '
        'LblCrit_A_S
        '
        Me.LblCrit_A_S.AccessibleDescription = "LblResults"
        Me.LblCrit_A_S.AccessibleName = "LblResults"
        Me.LblCrit_A_S.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrit_A_S.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblCrit_A_S.Location = New System.Drawing.Point(13, 108)
        Me.LblCrit_A_S.Name = "LblCrit_A_S"
        Me.LblCrit_A_S.Size = New System.Drawing.Size(843, 39)
        Me.LblCrit_A_S.TabIndex = 55
        Me.LblCrit_A_S.Text = "CRITERIOS DE BÚSQUEDA"
        Me.LblCrit_A_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTittle
        '
        Me.PnlTittle.AccessibleDescription = "PnlColorInfo"
        Me.PnlTittle.AccessibleName = "PnlColorInfo"
        Me.PnlTittle.BorderRadius = 11
        Me.PnlTittle.Controls.Add(Me.LblTittleAdmin_A_A)
        Me.PnlTittle.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlTittle.Location = New System.Drawing.Point(6, 42)
        Me.PnlTittle.Name = "PnlTittle"
        Me.PnlTittle.ShadowDecoration.Parent = Me.PnlTittle
        Me.PnlTittle.Size = New System.Drawing.Size(850, 51)
        Me.PnlTittle.TabIndex = 52
        '
        'LblTittleAdmin_A_A
        '
        Me.LblTittleAdmin_A_A.AccessibleDescription = "LblResults"
        Me.LblTittleAdmin_A_A.AccessibleName = "LblResults"
        Me.LblTittleAdmin_A_A.BackColor = System.Drawing.Color.Transparent
        Me.LblTittleAdmin_A_A.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTittleAdmin_A_A.ForeColor = System.Drawing.Color.White
        Me.LblTittleAdmin_A_A.Location = New System.Drawing.Point(4, 0)
        Me.LblTittleAdmin_A_A.Name = "LblTittleAdmin_A_A"
        Me.LblTittleAdmin_A_A.Size = New System.Drawing.Size(758, 51)
        Me.LblTittleAdmin_A_A.TabIndex = 52
        Me.LblTittleAdmin_A_A.Text = "GESTIÓN DE ADMINISTRADORES"
        Me.LblTittleAdmin_A_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Elipse
        '
        Me.Elipse.BorderRadius = 10
        Me.Elipse.TargetControl = Me
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PnlBod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdmin"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBod.ResumeLayout(False)
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTittle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlBod As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents BtnFaq_A_H As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnLogout_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPathologies_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnSymp_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdmins_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnMedics_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPatients_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnHome_A_HP As Guna.UI.WinForms.GunaButton
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PnlTittle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTittleAdmin_A_A As Label
    Friend WithEvents PicBusqueda As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TxtCi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblCrit_A_S As Label
    Friend WithEvents BtnModAdmin_A_A As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDelAdmin_A_A As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddAdmin_A_A As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblListadoAdmin_A_A As Label
    Friend WithEvents DgvAdmin As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PicBar As PictureBox
    Friend WithEvents Elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnAllow_A_P As Guna.UI.WinForms.GunaButton
End Class
