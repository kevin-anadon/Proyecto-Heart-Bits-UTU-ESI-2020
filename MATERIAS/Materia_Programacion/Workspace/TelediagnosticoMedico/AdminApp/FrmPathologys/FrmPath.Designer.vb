<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPath))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnDelPat = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddPat = New Guna.UI.WinForms.GunaButton()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnFaq = New Guna.UI.WinForms.GunaButton()
        Me.BtnLogout = New Guna.UI.WinForms.GunaButton()
        Me.BtnPath = New Guna.UI.WinForms.GunaButton()
        Me.BtnSympt = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnMed = New Guna.UI.WinForms.GunaButton()
        Me.BtnPac = New Guna.UI.WinForms.GunaButton()
        Me.BtnHome = New Guna.UI.WinForms.GunaButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.TxtPat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DgvPat = New Guna.UI.WinForms.GunaDataGridView()
        Me.PnlTittle = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCrit = New System.Windows.Forms.Label()
        Me.LblListado = New System.Windows.Forms.Label()
        Me.BtnMod = New Guna.UI.WinForms.GunaButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTittle.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelPat
        '
        Me.BtnDelPat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelPat.Animated = True
        Me.BtnDelPat.AnimationHoverSpeed = 0.07!
        Me.BtnDelPat.AnimationSpeed = 0.03!
        Me.BtnDelPat.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnDelPat.BorderColor = System.Drawing.Color.Black
        Me.BtnDelPat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDelPat.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDelPat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelPat.ForeColor = System.Drawing.Color.White
        Me.BtnDelPat.Image = CType(resources.GetObject("BtnDelPat.Image"), System.Drawing.Image)
        Me.BtnDelPat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnDelPat.ImageOffsetX = -10
        Me.BtnDelPat.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnDelPat.Location = New System.Drawing.Point(729, 214)
        Me.BtnDelPat.Name = "BtnDelPat"
        Me.BtnDelPat.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnDelPat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnDelPat.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnDelPat.OnHoverImage = Nothing
        Me.BtnDelPat.OnPressedColor = System.Drawing.Color.Black
        Me.BtnDelPat.Radius = 11
        Me.BtnDelPat.Size = New System.Drawing.Size(162, 20)
        Me.BtnDelPat.TabIndex = 42
        Me.BtnDelPat.Text = "ELIMINAR PATOLOGÍA"
        '
        'BtnAddPat
        '
        Me.BtnAddPat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPat.Animated = True
        Me.BtnAddPat.AnimationHoverSpeed = 0.07!
        Me.BtnAddPat.AnimationSpeed = 0.03!
        Me.BtnAddPat.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAddPat.BorderColor = System.Drawing.Color.Black
        Me.BtnAddPat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddPat.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddPat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPat.ForeColor = System.Drawing.Color.White
        Me.BtnAddPat.Image = CType(resources.GetObject("BtnAddPat.Image"), System.Drawing.Image)
        Me.BtnAddPat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnAddPat.ImageOffsetX = -10
        Me.BtnAddPat.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddPat.Location = New System.Drawing.Point(897, 214)
        Me.BtnAddPat.Name = "BtnAddPat"
        Me.BtnAddPat.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnAddPat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddPat.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddPat.OnHoverImage = Nothing
        Me.BtnAddPat.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddPat.Radius = 11
        Me.BtnAddPat.Size = New System.Drawing.Size(145, 20)
        Me.BtnAddPat.TabIndex = 39
        Me.BtnAddPat.Text = "NUEVA PATOLOGÍA"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PanelBody)
        Me.PanelLeft.Controls.Add(Me.PanelButtons)
        Me.PanelLeft.Controls.Add(Me.PicLogo)
        Me.PanelLeft.Location = New System.Drawing.Point(1, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(188, 640)
        Me.PanelLeft.TabIndex = 30
        '
        'PanelBody
        '
        Me.PanelBody.Location = New System.Drawing.Point(190, 2)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(869, 638)
        Me.PanelBody.TabIndex = 9
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
        Me.PanelButtons.Controls.Add(Me.BtnHome)
        Me.PanelButtons.Location = New System.Drawing.Point(19, 108)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(166, 515)
        Me.PanelButtons.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 202)
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
        Me.BtnPath.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnPath.BorderColor = System.Drawing.Color.Black
        Me.BtnPath.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPath.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPath.ForeColor = System.Drawing.Color.White
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
        'TxtPat
        '
        Me.TxtPat.BorderColor = System.Drawing.Color.DarkGray
        Me.TxtPat.BorderRadius = 8
        Me.TxtPat.BorderThickness = 2
        Me.TxtPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPat.DefaultText = "Realizar busqueda por patología"
        Me.TxtPat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPat.DisabledState.Parent = Me.TxtPat
        Me.TxtPat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPat.FocusedState.Parent = Me.TxtPat
        Me.TxtPat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtPat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPat.HoverState.Parent = Me.TxtPat
        Me.TxtPat.Location = New System.Drawing.Point(234, 153)
        Me.TxtPat.Name = "TxtPat"
        Me.TxtPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPat.PlaceholderText = ""
        Me.TxtPat.SelectedText = ""
        Me.TxtPat.SelectionStart = 31
        Me.TxtPat.ShadowDecoration.Parent = Me.TxtPat
        Me.TxtPat.Size = New System.Drawing.Size(192, 30)
        Me.TxtPat.TabIndex = 46
        '
        'DgvPat
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvPat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPat.BackgroundColor = System.Drawing.Color.White
        Me.DgvPat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvPat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPat.ColumnHeadersHeight = 26
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPat.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPat.EnableHeadersVisualStyles = False
        Me.DgvPat.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPat.Location = New System.Drawing.Point(211, 238)
        Me.DgvPat.Name = "DgvPat"
        Me.DgvPat.ReadOnly = True
        Me.DgvPat.RowHeadersVisible = False
        Me.DgvPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPat.Size = New System.Drawing.Size(843, 381)
        Me.DgvPat.TabIndex = 33
        Me.DgvPat.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgvPat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPat.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvPat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvPat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvPat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvPat.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvPat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvPat.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvPat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvPat.ThemeStyle.HeaderStyle.Height = 26
        Me.DgvPat.ThemeStyle.ReadOnly = True
        Me.DgvPat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvPat.ThemeStyle.RowsStyle.Height = 22
        Me.DgvPat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PnlTittle
        '
        Me.PnlTittle.AccessibleDescription = "PnlColorInfo"
        Me.PnlTittle.AccessibleName = "PnlColorInfo"
        Me.PnlTittle.BorderRadius = 11
        Me.PnlTittle.Controls.Add(Me.Label1)
        Me.PnlTittle.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlTittle.Location = New System.Drawing.Point(204, 42)
        Me.PnlTittle.Name = "PnlTittle"
        Me.PnlTittle.ShadowDecoration.Parent = Me.PnlTittle
        Me.PnlTittle.Size = New System.Drawing.Size(850, 51)
        Me.PnlTittle.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "LblResults"
        Me.Label1.AccessibleName = "LblResults"
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 51)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "GESTIÓN DE PATOLOGÍAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCrit
        '
        Me.LblCrit.AccessibleDescription = "LblResults"
        Me.LblCrit.AccessibleName = "LblResults"
        Me.LblCrit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblCrit.Location = New System.Drawing.Point(206, 108)
        Me.LblCrit.Name = "LblCrit"
        Me.LblCrit.Size = New System.Drawing.Size(848, 39)
        Me.LblCrit.TabIndex = 53
        Me.LblCrit.Text = "CRITERIOS DE BÚSQUEDA"
        Me.LblCrit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblListado
        '
        Me.LblListado.AccessibleDescription = "LblResults"
        Me.LblListado.AccessibleName = "LblResults"
        Me.LblListado.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblListado.Location = New System.Drawing.Point(211, 204)
        Me.LblListado.Name = "LblListado"
        Me.LblListado.Size = New System.Drawing.Size(844, 37)
        Me.LblListado.TabIndex = 54
        Me.LblListado.Text = "LISTADO PATOLOGÍAS"
        Me.LblListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnMod
        '
        Me.BtnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMod.Animated = True
        Me.BtnMod.AnimationHoverSpeed = 0.07!
        Me.BtnMod.AnimationSpeed = 0.03!
        Me.BtnMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnMod.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnMod.BorderColor = System.Drawing.Color.Black
        Me.BtnMod.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMod.FocusedColor = System.Drawing.Color.Empty
        Me.BtnMod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMod.ForeColor = System.Drawing.Color.White
        Me.BtnMod.Image = CType(resources.GetObject("BtnMod.Image"), System.Drawing.Image)
        Me.BtnMod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnMod.ImageOffsetX = -10
        Me.BtnMod.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnMod.Location = New System.Drawing.Point(550, 214)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnMod.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnMod.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnMod.OnHoverImage = Nothing
        Me.BtnMod.OnPressedColor = System.Drawing.Color.Black
        Me.BtnMod.Radius = 11
        Me.BtnMod.Size = New System.Drawing.Size(173, 20)
        Me.BtnMod.TabIndex = 55
        Me.BtnMod.Text = "MODIFICAR PATOLOGÍA"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(205, 158)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.Guna2PictureBox1.TabIndex = 45
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(968, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 63
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1015, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 62
        '
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me
        '
        'FrmPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.LblCrit)
        Me.Controls.Add(Me.PnlTittle)
        Me.Controls.Add(Me.TxtPat)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.BtnMod)
        Me.Controls.Add(Me.BtnDelPat)
        Me.Controls.Add(Me.BtnAddPat)
        Me.Controls.Add(Me.LblListado)
        Me.Controls.Add(Me.DgvPat)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTittle.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDelPat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddPat As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelBody As Panel
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
    Friend WithEvents TxtPat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DgvPat As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PnlTittle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCrit As Label
    Friend WithEvents LblListado As Label
    Friend WithEvents BtnMod As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
End Class
