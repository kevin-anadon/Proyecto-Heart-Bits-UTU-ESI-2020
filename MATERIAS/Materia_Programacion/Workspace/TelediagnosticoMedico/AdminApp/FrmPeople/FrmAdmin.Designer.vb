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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BtnFaq = New Guna.UI.WinForms.GunaButton()
        Me.BtnLogout = New Guna.UI.WinForms.GunaButton()
        Me.BtnPath = New Guna.UI.WinForms.GunaButton()
        Me.BtnSympt = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnMed = New Guna.UI.WinForms.GunaButton()
        Me.BtnPac = New Guna.UI.WinForms.GunaButton()
        Me.BtnHome = New Guna.UI.WinForms.GunaButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PnlBod = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnModAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnDelAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddAdmin = New Guna.UI.WinForms.GunaButton()
        Me.LblListado = New System.Windows.Forms.Label()
        Me.DgvAdmin = New Guna.UI.WinForms.GunaDataGridView()
        Me.PicBusqueda = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TxtCi = New Guna.UI.WinForms.GunaTextBox()
        Me.LblCrit = New System.Windows.Forms.Label()
        Me.PnlTittle = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.PicBar = New System.Windows.Forms.PictureBox()
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBod.SuspendLayout()
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTittle.SuspendLayout()
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelButtons.Controls.Add(Me.BtnFaq)
        Me.PanelButtons.Controls.Add(Me.PicBar)
        Me.PanelButtons.Controls.Add(Me.BtnLogout)
        Me.PanelButtons.Controls.Add(Me.BtnPath)
        Me.PanelButtons.Controls.Add(Me.BtnSympt)
        Me.PanelButtons.Controls.Add(Me.BtnAdmin)
        Me.PanelButtons.Controls.Add(Me.BtnMed)
        Me.PanelButtons.Controls.Add(Me.BtnPac)
        Me.PanelButtons.Controls.Add(Me.BtnHome)
        Me.PanelButtons.Location = New System.Drawing.Point(19, 108)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(166, 515)
        Me.PanelButtons.TabIndex = 1
        '
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me.PnlBod
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
        Me.BtnSympt.BorderColor = System.Drawing.Color.BlanchedAlmond
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
        Me.BtnAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAdmin.BorderColor = System.Drawing.Color.Black
        Me.BtnAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.ForeColor = System.Drawing.Color.White
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
        'BtnHome
        '
        Me.BtnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHome.Animated = True
        Me.BtnHome.AnimationHoverSpeed = 0.07!
        Me.BtnHome.AnimationSpeed = 0.03!
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.BaseColor = System.Drawing.Color.Transparent
        Me.BtnHome.BorderColor = System.Drawing.Color.Transparent
        Me.BtnHome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnHome.FocusedColor = System.Drawing.Color.Empty
        Me.BtnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.Black
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnHome.Location = New System.Drawing.Point(9, 22)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnHome.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnHome.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnHome.OnHoverImage = Nothing
        Me.BtnHome.OnPressedColor = System.Drawing.Color.Black
        Me.BtnHome.Radius = 6
        Me.BtnHome.Size = New System.Drawing.Size(146, 30)
        Me.BtnHome.TabIndex = 22
        Me.BtnHome.Text = "Página principal"
        Me.BtnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'PnlBod
        '
        Me.PnlBod.BackgroundImage = CType(resources.GetObject("PnlBod.BackgroundImage"), System.Drawing.Image)
        Me.PnlBod.Controls.Add(Me.Guna2ControlBox2)
        Me.PnlBod.Controls.Add(Me.Guna2ControlBox1)
        Me.PnlBod.Controls.Add(Me.BtnModAdmin)
        Me.PnlBod.Controls.Add(Me.BtnDelAdmin)
        Me.PnlBod.Controls.Add(Me.BtnAddAdmin)
        Me.PnlBod.Controls.Add(Me.LblListado)
        Me.PnlBod.Controls.Add(Me.DgvAdmin)
        Me.PnlBod.Controls.Add(Me.PicBusqueda)
        Me.PnlBod.Controls.Add(Me.TxtCi)
        Me.PnlBod.Controls.Add(Me.LblCrit)
        Me.PnlBod.Controls.Add(Me.PnlTittle)
        Me.PnlBod.Location = New System.Drawing.Point(192, 0)
        Me.PnlBod.Name = "PnlBod"
        Me.PnlBod.Size = New System.Drawing.Size(870, 640)
        Me.PnlBod.TabIndex = 10
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
        'BtnModAdmin
        '
        Me.BtnModAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModAdmin.Animated = True
        Me.BtnModAdmin.AnimationHoverSpeed = 0.07!
        Me.BtnModAdmin.AnimationSpeed = 0.03!
        Me.BtnModAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnModAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnModAdmin.BorderColor = System.Drawing.Color.Black
        Me.BtnModAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnModAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnModAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnModAdmin.Image = CType(resources.GetObject("BtnModAdmin.Image"), System.Drawing.Image)
        Me.BtnModAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnModAdmin.ImageOffsetX = -10
        Me.BtnModAdmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnModAdmin.Location = New System.Drawing.Point(372, 214)
        Me.BtnModAdmin.Name = "BtnModAdmin"
        Me.BtnModAdmin.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnModAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnModAdmin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnModAdmin.OnHoverImage = Nothing
        Me.BtnModAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnModAdmin.Radius = 11
        Me.BtnModAdmin.Size = New System.Drawing.Size(163, 20)
        Me.BtnModAdmin.TabIndex = 2
        Me.BtnModAdmin.Text = "MODIFICAR PACIENTE"
        '
        'BtnDelAdmin
        '
        Me.BtnDelAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelAdmin.Animated = True
        Me.BtnDelAdmin.AnimationHoverSpeed = 0.07!
        Me.BtnDelAdmin.AnimationSpeed = 0.03!
        Me.BtnDelAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnDelAdmin.BorderColor = System.Drawing.Color.Black
        Me.BtnDelAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDelAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDelAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnDelAdmin.Image = CType(resources.GetObject("BtnDelAdmin.Image"), System.Drawing.Image)
        Me.BtnDelAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnDelAdmin.ImageOffsetX = -10
        Me.BtnDelAdmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnDelAdmin.Location = New System.Drawing.Point(541, 214)
        Me.BtnDelAdmin.Name = "BtnDelAdmin"
        Me.BtnDelAdmin.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnDelAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnDelAdmin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnDelAdmin.OnHoverImage = Nothing
        Me.BtnDelAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnDelAdmin.Radius = 11
        Me.BtnDelAdmin.Size = New System.Drawing.Size(154, 20)
        Me.BtnDelAdmin.TabIndex = 4
        Me.BtnDelAdmin.Text = "ELIMINAR PACIENTE"
        '
        'BtnAddAdmin
        '
        Me.BtnAddAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAdmin.Animated = True
        Me.BtnAddAdmin.AnimationHoverSpeed = 0.07!
        Me.BtnAddAdmin.AnimationSpeed = 0.03!
        Me.BtnAddAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAddAdmin.BorderColor = System.Drawing.Color.Black
        Me.BtnAddAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnAddAdmin.Image = CType(resources.GetObject("BtnAddAdmin.Image"), System.Drawing.Image)
        Me.BtnAddAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnAddAdmin.ImageOffsetX = -10
        Me.BtnAddAdmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddAdmin.Location = New System.Drawing.Point(701, 214)
        Me.BtnAddAdmin.Name = "BtnAddAdmin"
        Me.BtnAddAdmin.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnAddAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddAdmin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddAdmin.OnHoverImage = Nothing
        Me.BtnAddAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddAdmin.Radius = 11
        Me.BtnAddAdmin.Size = New System.Drawing.Size(138, 20)
        Me.BtnAddAdmin.TabIndex = 5
        Me.BtnAddAdmin.Text = "NUEVO PACIENTE"
        '
        'LblListado
        '
        Me.LblListado.AccessibleDescription = "LblResults"
        Me.LblListado.AccessibleName = "LblResults"
        Me.LblListado.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblListado.Location = New System.Drawing.Point(12, 204)
        Me.LblListado.Name = "LblListado"
        Me.LblListado.Size = New System.Drawing.Size(844, 37)
        Me.LblListado.TabIndex = 3
        Me.LblListado.Text = "LISTADO ADMINISTRADORES"
        Me.LblListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvAdmin
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.DgvAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAdmin.BackgroundColor = System.Drawing.Color.White
        Me.DgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvAdmin.ColumnHeadersHeight = 26
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAdmin.DefaultCellStyle = DataGridViewCellStyle12
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
        'LblCrit
        '
        Me.LblCrit.AccessibleDescription = "LblResults"
        Me.LblCrit.AccessibleName = "LblResults"
        Me.LblCrit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblCrit.Location = New System.Drawing.Point(13, 108)
        Me.LblCrit.Name = "LblCrit"
        Me.LblCrit.Size = New System.Drawing.Size(843, 39)
        Me.LblCrit.TabIndex = 55
        Me.LblCrit.Text = "CRITERIOS DE BÚSQUEDA"
        Me.LblCrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTittle
        '
        Me.PnlTittle.AccessibleDescription = "PnlColorInfo"
        Me.PnlTittle.AccessibleName = "PnlColorInfo"
        Me.PnlTittle.BorderRadius = 11
        Me.PnlTittle.Controls.Add(Me.LblTittle)
        Me.PnlTittle.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlTittle.Location = New System.Drawing.Point(6, 42)
        Me.PnlTittle.Name = "PnlTittle"
        Me.PnlTittle.ShadowDecoration.Parent = Me.PnlTittle
        Me.PnlTittle.Size = New System.Drawing.Size(850, 51)
        Me.PnlTittle.TabIndex = 52
        '
        'LblTittle
        '
        Me.LblTittle.AccessibleDescription = "LblResults"
        Me.LblTittle.AccessibleName = "LblResults"
        Me.LblTittle.BackColor = System.Drawing.Color.Transparent
        Me.LblTittle.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTittle.ForeColor = System.Drawing.Color.White
        Me.LblTittle.Location = New System.Drawing.Point(4, 0)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(567, 51)
        Me.LblTittle.TabIndex = 52
        Me.LblTittle.Text = "GESTIÓN DE ADMINISTRADORES"
        Me.LblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBod.ResumeLayout(False)
        CType(Me.DgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTittle.ResumeLayout(False)
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlBod As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents BtnFaq As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPath As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnSympt As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnMed As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnHome As Guna.UI.WinForms.GunaButton
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PnlTittle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTittle As Label
    Friend WithEvents PicBusqueda As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TxtCi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblCrit As Label
    Friend WithEvents BtnModAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDelAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblListado As Label
    Friend WithEvents DgvAdmin As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PicBar As PictureBox
End Class
