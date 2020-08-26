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
        Me.BtnFaq = New Guna.UI.WinForms.GunaButton()
        Me.BtnLogout = New Guna.UI.WinForms.GunaButton()
        Me.BtnPath = New Guna.UI.WinForms.GunaButton()
        Me.BtnSympt = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdmin = New Guna.UI.WinForms.GunaButton()
        Me.BtnMed = New Guna.UI.WinForms.GunaButton()
        Me.BtnPac = New Guna.UI.WinForms.GunaButton()
        Me.BtnHome = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.BtnRefresh = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddSympt = New Guna.UI.WinForms.GunaButton()
        Me.TxtAddSympt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ChkReg = New Guna.UI.WinForms.GunaCheckBox()
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
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1020, 0)
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
        Me.MzButtonWindows2.Location = New System.Drawing.Point(980, 0)
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
        Me.MzButtonWindows3.Location = New System.Drawing.Point(940, 0)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 7
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'PanelButtons
        '
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(178, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 30)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
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
        Me.DgvSympt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSympt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSympt.ColumnHeadersHeight = 26
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
        Me.DgvSympt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvSympt.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSympt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSympt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvSympt.ThemeStyle.HeaderStyle.Height = 26
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
        Me.TxtSympt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSympt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSympt.BackColor = System.Drawing.Color.Transparent
        Me.TxtSympt.BaseColor = System.Drawing.Color.White
        Me.TxtSympt.BorderColor = System.Drawing.Color.Silver
        Me.TxtSympt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSympt.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtSympt.FocusedBorderColor = System.Drawing.Color.Silver
        Me.TxtSympt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSympt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtSympt.Location = New System.Drawing.Point(204, 153)
        Me.TxtSympt.Multiline = True
        Me.TxtSympt.Name = "TxtSympt"
        Me.TxtSympt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSympt.Radius = 8
        Me.TxtSympt.SelectedText = ""
        Me.TxtSympt.Size = New System.Drawing.Size(187, 30)
        Me.TxtSympt.TabIndex = 14
        Me.TxtSympt.Text = "Realizar busqueda por síntoma"
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
        Me.cmbregion.Location = New System.Drawing.Point(832, 220)
        Me.cmbregion.Name = "cmbregion"
        Me.cmbregion.OnHoverItemBaseColor = System.Drawing.Color.Teal
        Me.cmbregion.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbregion.Radius = 5
        Me.cmbregion.Size = New System.Drawing.Size(203, 26)
        Me.cmbregion.TabIndex = 15
        Me.cmbregion.Visible = False
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
        Me.BtnRefresh.Location = New System.Drawing.Point(733, 298)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnRefresh.OnHoverImage = Nothing
        Me.BtnRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.BtnRefresh.Radius = 11
        Me.BtnRefresh.Size = New System.Drawing.Size(141, 20)
        Me.BtnRefresh.TabIndex = 22
        Me.BtnRefresh.Text = "REFRESCAR TABLA"
        '
        'BtnAddSympt
        '
        Me.BtnAddSympt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddSympt.Animated = True
        Me.BtnAddSympt.AnimationHoverSpeed = 0.07!
        Me.BtnAddSympt.AnimationSpeed = 0.03!
        Me.BtnAddSympt.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddSympt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAddSympt.BorderColor = System.Drawing.Color.Black
        Me.BtnAddSympt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddSympt.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSympt.ForeColor = System.Drawing.Color.White
        Me.BtnAddSympt.Image = CType(resources.GetObject("BtnAddSympt.Image"), System.Drawing.Image)
        Me.BtnAddSympt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtnAddSympt.ImageOffsetX = -10
        Me.BtnAddSympt.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddSympt.Location = New System.Drawing.Point(897, 298)
        Me.BtnAddSympt.Name = "BtnAddSympt"
        Me.BtnAddSympt.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.BtnAddSympt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddSympt.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddSympt.OnHoverImage = Nothing
        Me.BtnAddSympt.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddSympt.Radius = 11
        Me.BtnAddSympt.Size = New System.Drawing.Size(138, 20)
        Me.BtnAddSympt.TabIndex = 23
        Me.BtnAddSympt.Text = "NUEVO SÍNTOMA"
        '
        'TxtAddSympt
        '
        Me.TxtAddSympt.BackColor = System.Drawing.Color.Transparent
        Me.TxtAddSympt.BaseColor = System.Drawing.Color.White
        Me.TxtAddSympt.BorderColor = System.Drawing.Color.Silver
        Me.TxtAddSympt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddSympt.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtAddSympt.FocusedBorderColor = System.Drawing.Color.Silver
        Me.TxtAddSympt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAddSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtAddSympt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtAddSympt.Location = New System.Drawing.Point(832, 252)
        Me.TxtAddSympt.Multiline = True
        Me.TxtAddSympt.Name = "TxtAddSympt"
        Me.TxtAddSympt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddSympt.Radius = 8
        Me.TxtAddSympt.SelectedText = ""
        Me.TxtAddSympt.Size = New System.Drawing.Size(203, 30)
        Me.TxtAddSympt.TabIndex = 24
        Me.TxtAddSympt.Text = "Ingrese nombre de nuevo síntoma"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(842, 202)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(178, 15)
        Me.GunaLabel1.TabIndex = 25
        Me.GunaLabel1.Text = "Elija la región del nuevo síntoma"
        '
        'ChkReg
        '
        Me.ChkReg.BackColor = System.Drawing.Color.White
        Me.ChkReg.BaseColor = System.Drawing.Color.White
        Me.ChkReg.CheckedOffColor = System.Drawing.SystemColors.Desktop
        Me.ChkReg.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ChkReg.FillColor = System.Drawing.Color.White
        Me.ChkReg.Location = New System.Drawing.Point(733, 224)
        Me.ChkReg.Name = "ChkReg"
        Me.ChkReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkReg.Size = New System.Drawing.Size(93, 20)
        Me.ChkReg.TabIndex = 26
        Me.ChkReg.Text = "Tiene región"
        '
        'FrmSympt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.ChkReg)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TxtAddSympt)
        Me.Controls.Add(Me.BtnAddSympt)
        Me.Controls.Add(Me.BtnRefresh)
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
        Me.PerformLayout()

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
    Friend WithEvents BtnHome As Guna.UI.WinForms.GunaButton
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PicTittle As PictureBox
    Friend WithEvents PanelBody As Panel
    Friend WithEvents DgvSympt As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PicListado As PictureBox
    Friend WithEvents PicFondo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbregion As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TxtSympt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BtnRefresh As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddSympt As Guna.UI.WinForms.GunaButton
    Friend WithEvents TxtAddSympt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ChkReg As Guna.UI.WinForms.GunaCheckBox
End Class
