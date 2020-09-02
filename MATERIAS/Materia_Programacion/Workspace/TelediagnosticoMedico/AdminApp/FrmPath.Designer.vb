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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPath))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnClose = New BWCMM.MZButtonWindows()
        Me.BtnMax = New BWCMM.MZButtonWindows()
        Me.BtnMin = New BWCMM.MZButtonWindows()
        Me.BtnDelPat = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddPat = New Guna.UI.WinForms.GunaButton()
        Me.BtnRefresh = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicListado = New System.Windows.Forms.PictureBox()
        Me.PicTittle = New System.Windows.Forms.PictureBox()
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
        Me.PicFondo = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TxtPat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DgvPat = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTittle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClose.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.BtnClose.Location = New System.Drawing.Point(1020, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ParentControl = Me
        Me.BtnClose.Size = New System.Drawing.Size(40, 24)
        Me.BtnClose.TabIndex = 13
        Me.BtnClose.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'BtnMax
        '
        Me.BtnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMax.BackColor = System.Drawing.Color.White
        Me.BtnMax.BackgroundImage = CType(resources.GetObject("BtnMax.BackgroundImage"), System.Drawing.Image)
        Me.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnMax.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.BtnMax.Location = New System.Drawing.Point(980, 0)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.ParentControl = Me
        Me.BtnMax.Size = New System.Drawing.Size(40, 24)
        Me.BtnMax.TabIndex = 14
        Me.BtnMax.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'BtnMin
        '
        Me.BtnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMin.BackColor = System.Drawing.Color.White
        Me.BtnMin.BackgroundImage = CType(resources.GetObject("BtnMin.BackgroundImage"), System.Drawing.Image)
        Me.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnMin.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.BtnMin.Location = New System.Drawing.Point(940, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.ParentControl = Me
        Me.BtnMin.Size = New System.Drawing.Size(40, 24)
        Me.BtnMin.TabIndex = 15
        Me.BtnMin.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
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
        Me.BtnDelPat.Location = New System.Drawing.Point(582, 298)
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
        Me.BtnAddPat.Location = New System.Drawing.Point(897, 298)
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
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.Animated = True
        Me.BtnRefresh.AnimationHoverSpeed = 0.07!
        Me.BtnRefresh.AnimationSpeed = 0.03!
        Me.BtnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.BtnRefresh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnRefresh.BorderColor = System.Drawing.Color.Black
        Me.BtnRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnRefresh.ImageOffsetX = -10
        Me.BtnRefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnRefresh.Location = New System.Drawing.Point(750, 298)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnRefresh.OnHoverImage = Nothing
        Me.BtnRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.BtnRefresh.Radius = 11
        Me.BtnRefresh.Size = New System.Drawing.Size(141, 20)
        Me.BtnRefresh.TabIndex = 38
        Me.BtnRefresh.Text = "REFRESCAR TABLA"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(205, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(843, 39)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PicListado
        '
        Me.PicListado.Image = CType(resources.GetObject("PicListado.Image"), System.Drawing.Image)
        Me.PicListado.Location = New System.Drawing.Point(204, 288)
        Me.PicListado.Name = "PicListado"
        Me.PicListado.Size = New System.Drawing.Size(844, 37)
        Me.PicListado.TabIndex = 34
        Me.PicListado.TabStop = False
        '
        'PicTittle
        '
        Me.PicTittle.Image = CType(resources.GetObject("PicTittle.Image"), System.Drawing.Image)
        Me.PicTittle.Location = New System.Drawing.Point(198, 42)
        Me.PicTittle.Name = "PicTittle"
        Me.PicTittle.Size = New System.Drawing.Size(850, 51)
        Me.PicTittle.TabIndex = 31
        Me.PicTittle.TabStop = False
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
        Me.BtnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'PicFondo
        '
        Me.PicFondo.Image = CType(resources.GetObject("PicFondo.Image"), System.Drawing.Image)
        Me.PicFondo.Location = New System.Drawing.Point(191, 0)
        Me.PicFondo.Name = "PicFondo"
        Me.PicFondo.Size = New System.Drawing.Size(869, 640)
        Me.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicFondo.TabIndex = 32
        Me.PicFondo.TabStop = False
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
        Me.DgvPat.Location = New System.Drawing.Point(205, 324)
        Me.DgvPat.Name = "DgvPat"
        Me.DgvPat.RowHeadersVisible = False
        Me.DgvPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPat.Size = New System.Drawing.Size(843, 297)
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
        Me.DgvPat.ThemeStyle.ReadOnly = False
        Me.DgvPat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvPat.ThemeStyle.RowsStyle.Height = 22
        Me.DgvPat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FrmPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.TxtPat)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.BtnDelPat)
        Me.Controls.Add(Me.BtnAddPat)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicListado)
        Me.Controls.Add(Me.DgvPat)
        Me.Controls.Add(Me.PicTittle)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnMax)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PicFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTittle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As BWCMM.MZButtonWindows
    Friend WithEvents BtnMin As BWCMM.MZButtonWindows
    Friend WithEvents BtnMax As BWCMM.MZButtonWindows
    Friend WithEvents BtnDelPat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddPat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnRefresh As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicListado As PictureBox
    Friend WithEvents PicTittle As PictureBox
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
    Friend WithEvents PicFondo As PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TxtPat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DgvPat As Guna.UI.WinForms.GunaDataGridView
End Class
