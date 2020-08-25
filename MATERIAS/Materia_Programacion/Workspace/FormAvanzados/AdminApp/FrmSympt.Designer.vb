<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSympt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSympt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
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
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PicTittle = New System.Windows.Forms.PictureBox()
        Me.DgvSympt = New Guna.UI.WinForms.GunaDataGridView()
        Me.PicListado = New System.Windows.Forms.PictureBox()
        Me.PicFondo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtSympt = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbregion = New Guna.UI.WinForms.GunaComboBox()
        Me.PanelButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTittle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSympt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackColor = System.Drawing.Color.White
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1017, 2)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 5
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackColor = System.Drawing.Color.White
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Default
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(977, 2)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 6
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackColor = System.Drawing.Color.White
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Default
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(937, 2)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 7
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
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
        Me.PictureBox1.Location = New System.Drawing.Point(161, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2, 30)
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
        Me.BtnSympt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnSympt.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.BtnSympt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSympt.FocusedColor = System.Drawing.Color.Empty
        Me.BtnSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSympt.ForeColor = System.Drawing.Color.White
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
        'BtnLogin
        '
        Me.BtnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.Animated = True
        Me.BtnLogin.AnimationHoverSpeed = 0.07!
        Me.BtnLogin.AnimationSpeed = 0.03!
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BaseColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderSize = 1
        Me.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Black
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
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PanelBody)
        Me.PanelLeft.Controls.Add(Me.PanelButtons)
        Me.PanelLeft.Controls.Add(Me.PicLogo)
        Me.PanelLeft.Location = New System.Drawing.Point(1, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(188, 640)
        Me.PanelLeft.TabIndex = 8
        '
        'PanelBody
        '
        Me.PanelBody.Location = New System.Drawing.Point(190, 2)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(869, 638)
        Me.PanelBody.TabIndex = 9
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
        'PicTittle
        '
        Me.PicTittle.Image = CType(resources.GetObject("PicTittle.Image"), System.Drawing.Image)
        Me.PicTittle.Location = New System.Drawing.Point(198, 42)
        Me.PicTittle.Name = "PicTittle"
        Me.PicTittle.Size = New System.Drawing.Size(850, 51)
        Me.PicTittle.TabIndex = 9
        Me.PicTittle.TabStop = False
        '
        'DgvSympt
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvSympt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSympt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSympt.BackgroundColor = System.Drawing.Color.White
        Me.DgvSympt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvSympt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSympt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSympt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSympt.ColumnHeadersHeight = 5
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSympt.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSympt.EnableHeadersVisualStyles = False
        Me.DgvSympt.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSympt.Location = New System.Drawing.Point(205, 324)
        Me.DgvSympt.Name = "DgvSympt"
        Me.DgvSympt.RowHeadersVisible = False
        Me.DgvSympt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSympt.Size = New System.Drawing.Size(843, 297)
        Me.DgvSympt.TabIndex = 11
        Me.DgvSympt.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgvSympt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSympt.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvSympt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvSympt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvSympt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvSympt.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvSympt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSympt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSympt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSympt.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSympt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSympt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvSympt.ThemeStyle.HeaderStyle.Height = 5
        Me.DgvSympt.ThemeStyle.ReadOnly = False
        Me.DgvSympt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSympt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSympt.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSympt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvSympt.ThemeStyle.RowsStyle.Height = 22
        Me.DgvSympt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSympt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PicListado
        '
        Me.PicListado.Image = CType(resources.GetObject("PicListado.Image"), System.Drawing.Image)
        Me.PicListado.Location = New System.Drawing.Point(204, 288)
        Me.PicListado.Name = "PicListado"
        Me.PicListado.Size = New System.Drawing.Size(844, 37)
        Me.PicListado.TabIndex = 12
        Me.PicListado.TabStop = False
        '
        'PicFondo
        '
        Me.PicFondo.Image = CType(resources.GetObject("PicFondo.Image"), System.Drawing.Image)
        Me.PicFondo.Location = New System.Drawing.Point(191, 0)
        Me.PicFondo.Name = "PicFondo"
        Me.PicFondo.Size = New System.Drawing.Size(869, 640)
        Me.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicFondo.TabIndex = 10
        Me.PicFondo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(205, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(843, 39)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'TxtSympt
        '
        Me.TxtSympt.BackColor = System.Drawing.Color.Transparent
        Me.TxtSympt.BaseColor = System.Drawing.Color.White
        Me.TxtSympt.BorderColor = System.Drawing.Color.Silver
        Me.TxtSympt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSympt.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtSympt.FocusedBorderColor = System.Drawing.Color.Silver
        Me.TxtSympt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSympt.Location = New System.Drawing.Point(204, 153)
        Me.TxtSympt.Multiline = True
        Me.TxtSympt.Name = "TxtSympt"
        Me.TxtSympt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSympt.Radius = 8
        Me.TxtSympt.SelectedText = ""
        Me.TxtSympt.Size = New System.Drawing.Size(187, 30)
        Me.TxtSympt.TabIndex = 14
        '
        'cmbregion
        '
        Me.cmbregion.BackColor = System.Drawing.Color.Transparent
        Me.cmbregion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmbregion.BorderColor = System.Drawing.Color.Silver
        Me.cmbregion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbregion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbregion.FocusedColor = System.Drawing.Color.Empty
        Me.cmbregion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbregion.ForeColor = System.Drawing.Color.White
        Me.cmbregion.FormattingEnabled = True
        Me.cmbregion.Location = New System.Drawing.Point(205, 185)
        Me.cmbregion.Name = "cmbregion"
        Me.cmbregion.OnHoverItemBaseColor = System.Drawing.Color.Teal
        Me.cmbregion.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbregion.Radius = 5
        Me.cmbregion.Size = New System.Drawing.Size(186, 26)
        Me.cmbregion.TabIndex = 15
        '
        'FrmSympt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.cmbregion)
        Me.Controls.Add(Me.TxtSympt)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicListado)
        Me.Controls.Add(Me.DgvSympt)
        Me.Controls.Add(Me.PicTittle)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.MzButtonWindows3)
        Me.Controls.Add(Me.MzButtonWindows2)
        Me.Controls.Add(Me.MzButtonWindows1)
        Me.Controls.Add(Me.PicFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSympt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTittle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSympt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnFaq As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPath As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnSympt As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdmin As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnMed As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PicTittle As PictureBox
    Friend WithEvents PanelBody As Panel
    Friend WithEvents DgvSympt As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PicListado As PictureBox
    Friend WithEvents PicFondo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbregion As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TxtSympt As Guna.UI.WinForms.GunaTextBox
End Class
