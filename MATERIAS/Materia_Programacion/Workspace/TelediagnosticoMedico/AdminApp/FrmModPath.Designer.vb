<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModPath
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModPath))
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.RbnQ = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.DgvTreat = New Guna.UI.WinForms.GunaDataGridView()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RbnMed = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.BtnAdd = New Guna.UI.WinForms.GunaButton()
        Me.BtnModTreat = New Guna.UI.WinForms.GunaButton()
        Me.BtnDelTreat = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddTreat = New Guna.UI.WinForms.GunaButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator6 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtTreatType = New Guna.UI.WinForms.GunaTextBox()
        Me.LblTreatmentType = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator5 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtTreatDesc = New Guna.UI.WinForms.GunaTextBox()
        Me.LblTreatmentDesc = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator4 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtTreatName = New Guna.UI.WinForms.GunaTextBox()
        Me.LblTreatmentName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtDescr = New System.Windows.Forms.RichTextBox()
        Me.LblPrioridad = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Spinner = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.LblMortality = New Guna.UI.WinForms.GunaLabel()
        Me.Asterisco = New Guna.UI.WinForms.GunaLabel()
        Me.LblDescr = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.LblPatName = New Guna.UI.WinForms.GunaLabel()
        Me.TxtName = New Guna.UI.WinForms.GunaTextBox()
        Me.PicPrior = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LblPat = New Guna.UI.WinForms.GunaLabel()
        Me.LblPatTop = New Guna.UI.WinForms.GunaLabel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.LblPathTop = New Guna.UI.WinForms.GunaLabel()
        Me.PanelMain.SuspendLayout()
        CType(Me.DgvTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPrior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.RbnQ)
        Me.PanelMain.Controls.Add(Me.DgvTreat)
        Me.PanelMain.Controls.Add(Me.RbnMed)
        Me.PanelMain.Controls.Add(Me.BtnAdd)
        Me.PanelMain.Controls.Add(Me.BtnModTreat)
        Me.PanelMain.Controls.Add(Me.BtnDelTreat)
        Me.PanelMain.Controls.Add(Me.BtnAddTreat)
        Me.PanelMain.Controls.Add(Me.Guna2PictureBox2)
        Me.PanelMain.Controls.Add(Me.GunaLabel4)
        Me.PanelMain.Controls.Add(Me.GunaLabel3)
        Me.PanelMain.Controls.Add(Me.Guna2PictureBox1)
        Me.PanelMain.Controls.Add(Me.GunaLabel8)
        Me.PanelMain.Controls.Add(Me.GunaLabel7)
        Me.PanelMain.Controls.Add(Me.GunaLabel6)
        Me.PanelMain.Controls.Add(Me.GunaSeparator6)
        Me.PanelMain.Controls.Add(Me.TxtTreatType)
        Me.PanelMain.Controls.Add(Me.LblTreatmentType)
        Me.PanelMain.Controls.Add(Me.GunaSeparator5)
        Me.PanelMain.Controls.Add(Me.TxtTreatDesc)
        Me.PanelMain.Controls.Add(Me.LblTreatmentDesc)
        Me.PanelMain.Controls.Add(Me.GunaSeparator4)
        Me.PanelMain.Controls.Add(Me.TxtTreatName)
        Me.PanelMain.Controls.Add(Me.LblTreatmentName)
        Me.PanelMain.Controls.Add(Me.GunaSeparator3)
        Me.PanelMain.Controls.Add(Me.TxtDescr)
        Me.PanelMain.Controls.Add(Me.LblPrioridad)
        Me.PanelMain.Controls.Add(Me.GunaLabel2)
        Me.PanelMain.Controls.Add(Me.Spinner)
        Me.PanelMain.Controls.Add(Me.GunaSeparator2)
        Me.PanelMain.Controls.Add(Me.GunaLabel1)
        Me.PanelMain.Controls.Add(Me.LblMortality)
        Me.PanelMain.Controls.Add(Me.Asterisco)
        Me.PanelMain.Controls.Add(Me.LblDescr)
        Me.PanelMain.Controls.Add(Me.GunaSeparator1)
        Me.PanelMain.Controls.Add(Me.LblPatName)
        Me.PanelMain.Controls.Add(Me.TxtName)
        Me.PanelMain.Controls.Add(Me.PicPrior)
        Me.PanelMain.Location = New System.Drawing.Point(0, 33)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(927, 443)
        Me.PanelMain.TabIndex = 35
        '
        'RbnQ
        '
        Me.RbnQ.AutoSize = True
        Me.RbnQ.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbnQ.CheckedState.BorderThickness = 0
        Me.RbnQ.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RbnQ.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RbnQ.CheckedState.InnerOffset = -4
        Me.RbnQ.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.RbnQ.Location = New System.Drawing.Point(153, 407)
        Me.RbnQ.Name = "RbnQ"
        Me.RbnQ.Size = New System.Drawing.Size(80, 19)
        Me.RbnQ.TabIndex = 82
        Me.RbnQ.Text = "Quirurjico"
        Me.RbnQ.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbnQ.UncheckedState.BorderThickness = 2
        Me.RbnQ.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RbnQ.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'DgvTreat
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvTreat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTreat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTreat.BackgroundColor = System.Drawing.Color.White
        Me.DgvTreat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvTreat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvTreat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTreat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTreat.ColumnHeadersHeight = 26
        Me.DgvTreat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.name, Me.desc, Me.type})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTreat.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvTreat.EnableHeadersVisualStyles = False
        Me.DgvTreat.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTreat.Location = New System.Drawing.Point(423, 53)
        Me.DgvTreat.Name = "DgvTreat"
        Me.DgvTreat.ReadOnly = True
        Me.DgvTreat.RowHeadersVisible = False
        Me.DgvTreat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTreat.Size = New System.Drawing.Size(491, 317)
        Me.DgvTreat.TabIndex = 79
        Me.DgvTreat.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgvTreat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvTreat.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvTreat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvTreat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvTreat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvTreat.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvTreat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTreat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTreat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvTreat.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvTreat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvTreat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvTreat.ThemeStyle.HeaderStyle.Height = 26
        Me.DgvTreat.ThemeStyle.ReadOnly = True
        Me.DgvTreat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvTreat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvTreat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvTreat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvTreat.ThemeStyle.RowsStyle.Height = 22
        Me.DgvTreat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTreat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'name
        '
        Me.name.HeaderText = "Nombre"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        '
        'desc
        '
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'type
        '
        Me.type.HeaderText = "Tipo"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'RbnMed
        '
        Me.RbnMed.AutoSize = True
        Me.RbnMed.CheckedState.BorderThickness = 0
        Me.RbnMed.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RbnMed.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RbnMed.CheckedState.InnerOffset = -4
        Me.RbnMed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnMed.Location = New System.Drawing.Point(18, 407)
        Me.RbnMed.Name = "RbnMed"
        Me.RbnMed.Size = New System.Drawing.Size(102, 19)
        Me.RbnMed.TabIndex = 81
        Me.RbnMed.Text = "Medicamento"
        Me.RbnMed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbnMed.UncheckedState.BorderThickness = 2
        Me.RbnMed.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RbnMed.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Animated = True
        Me.BtnAdd.AnimationHoverSpeed = 0.07!
        Me.BtnAdd.AnimationSpeed = 0.03!
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnAdd.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.BorderSize = 1
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = Nothing
        Me.BtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAdd.Location = New System.Drawing.Point(764, 389)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAdd.OnHoverImage = Nothing
        Me.BtnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAdd.Radius = 2
        Me.BtnAdd.Size = New System.Drawing.Size(150, 42)
        Me.BtnAdd.TabIndex = 78
        Me.BtnAdd.Text = "Modificar Patología"
        Me.BtnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnModTreat
        '
        Me.BtnModTreat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModTreat.Animated = True
        Me.BtnModTreat.AnimationHoverSpeed = 0.07!
        Me.BtnModTreat.AnimationSpeed = 0.03!
        Me.BtnModTreat.BackColor = System.Drawing.Color.Transparent
        Me.BtnModTreat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnModTreat.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnModTreat.BorderSize = 1
        Me.BtnModTreat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnModTreat.FocusedColor = System.Drawing.Color.Empty
        Me.BtnModTreat.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModTreat.ForeColor = System.Drawing.Color.White
        Me.BtnModTreat.Image = CType(resources.GetObject("BtnModTreat.Image"), System.Drawing.Image)
        Me.BtnModTreat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnModTreat.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnModTreat.Location = New System.Drawing.Point(505, 393)
        Me.BtnModTreat.Name = "BtnModTreat"
        Me.BtnModTreat.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnModTreat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnModTreat.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnModTreat.OnHoverImage = Nothing
        Me.BtnModTreat.OnPressedColor = System.Drawing.Color.Black
        Me.BtnModTreat.Radius = 2
        Me.BtnModTreat.Size = New System.Drawing.Size(33, 33)
        Me.BtnModTreat.TabIndex = 77
        Me.BtnModTreat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDelTreat
        '
        Me.BtnDelTreat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelTreat.Animated = True
        Me.BtnDelTreat.AnimationHoverSpeed = 0.07!
        Me.BtnDelTreat.AnimationSpeed = 0.03!
        Me.BtnDelTreat.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelTreat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnDelTreat.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDelTreat.BorderSize = 1
        Me.BtnDelTreat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDelTreat.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDelTreat.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelTreat.ForeColor = System.Drawing.Color.White
        Me.BtnDelTreat.Image = Nothing
        Me.BtnDelTreat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnDelTreat.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnDelTreat.Location = New System.Drawing.Point(466, 393)
        Me.BtnDelTreat.Name = "BtnDelTreat"
        Me.BtnDelTreat.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnDelTreat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnDelTreat.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnDelTreat.OnHoverImage = Nothing
        Me.BtnDelTreat.OnPressedColor = System.Drawing.Color.Black
        Me.BtnDelTreat.Radius = 2
        Me.BtnDelTreat.Size = New System.Drawing.Size(33, 33)
        Me.BtnDelTreat.TabIndex = 76
        Me.BtnDelTreat.Text = "-"
        Me.BtnDelTreat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddTreat
        '
        Me.BtnAddTreat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddTreat.Animated = True
        Me.BtnAddTreat.AnimationHoverSpeed = 0.07!
        Me.BtnAddTreat.AnimationSpeed = 0.03!
        Me.BtnAddTreat.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddTreat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnAddTreat.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddTreat.BorderSize = 1
        Me.BtnAddTreat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddTreat.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddTreat.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddTreat.ForeColor = System.Drawing.Color.White
        Me.BtnAddTreat.Image = CType(resources.GetObject("BtnAddTreat.Image"), System.Drawing.Image)
        Me.BtnAddTreat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAddTreat.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddTreat.Location = New System.Drawing.Point(427, 393)
        Me.BtnAddTreat.Name = "BtnAddTreat"
        Me.BtnAddTreat.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnAddTreat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddTreat.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddTreat.OnHoverImage = Nothing
        Me.BtnAddTreat.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddTreat.Radius = 2
        Me.BtnAddTreat.Size = New System.Drawing.Size(33, 33)
        Me.BtnAddTreat.TabIndex = 41
        Me.BtnAddTreat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(423, 389)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(339, 42)
        Me.Guna2PictureBox2.TabIndex = 75
        Me.Guna2PictureBox2.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(420, 373)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(187, 13)
        Me.GunaLabel4.TabIndex = 74
        Me.GunaLabel4.Text = "Administración de los Tratamientos"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(794, 2)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(120, 13)
        Me.GunaLabel3.TabIndex = 73
        Me.GunaLabel3.Text = "Campo Obligatorio [*]"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(423, 18)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(491, 38)
        Me.Guna2PictureBox1.TabIndex = 71
        Me.Guna2PictureBox1.TabStop = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(387, 376)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel8.TabIndex = 70
        Me.GunaLabel8.Text = "*"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(387, 314)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel7.TabIndex = 69
        Me.GunaLabel7.Text = "*"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(387, 242)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel6.TabIndex = 68
        Me.GunaLabel6.Text = "*"
        '
        'GunaSeparator6
        '
        Me.GunaSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator6.Location = New System.Drawing.Point(18, 430)
        Me.GunaSeparator6.Name = "GunaSeparator6"
        Me.GunaSeparator6.Size = New System.Drawing.Size(389, 1)
        Me.GunaSeparator6.TabIndex = 66
        '
        'TxtTreatType
        '
        Me.TxtTreatType.BackColor = System.Drawing.Color.White
        Me.TxtTreatType.BaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatType.BorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatType.BorderSize = 0
        Me.TxtTreatType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTreatType.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatType.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatType.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTreatType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTreatType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtTreatType.Location = New System.Drawing.Point(18, 401)
        Me.TxtTreatType.Multiline = True
        Me.TxtTreatType.Name = "TxtTreatType"
        Me.TxtTreatType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTreatType.SelectedText = ""
        Me.TxtTreatType.Size = New System.Drawing.Size(389, 30)
        Me.TxtTreatType.TabIndex = 67
        '
        'LblTreatmentType
        '
        Me.LblTreatmentType.AutoSize = True
        Me.LblTreatmentType.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreatmentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTreatmentType.Location = New System.Drawing.Point(13, 373)
        Me.LblTreatmentType.Name = "LblTreatmentType"
        Me.LblTreatmentType.Size = New System.Drawing.Size(180, 25)
        Me.LblTreatmentType.TabIndex = 65
        Me.LblTreatmentType.Text = "Tipo de Tratamiento"
        '
        'GunaSeparator5
        '
        Me.GunaSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator5.Location = New System.Drawing.Point(18, 369)
        Me.GunaSeparator5.Name = "GunaSeparator5"
        Me.GunaSeparator5.Size = New System.Drawing.Size(389, 1)
        Me.GunaSeparator5.TabIndex = 63
        '
        'TxtTreatDesc
        '
        Me.TxtTreatDesc.BackColor = System.Drawing.Color.White
        Me.TxtTreatDesc.BaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatDesc.BorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatDesc.BorderSize = 0
        Me.TxtTreatDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTreatDesc.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatDesc.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatDesc.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTreatDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTreatDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtTreatDesc.Location = New System.Drawing.Point(18, 340)
        Me.TxtTreatDesc.Multiline = True
        Me.TxtTreatDesc.Name = "TxtTreatDesc"
        Me.TxtTreatDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTreatDesc.SelectedText = ""
        Me.TxtTreatDesc.Size = New System.Drawing.Size(389, 30)
        Me.TxtTreatDesc.TabIndex = 64
        '
        'LblTreatmentDesc
        '
        Me.LblTreatmentDesc.AutoSize = True
        Me.LblTreatmentDesc.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreatmentDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTreatmentDesc.Location = New System.Drawing.Point(13, 312)
        Me.LblTreatmentDesc.Name = "LblTreatmentDesc"
        Me.LblTreatmentDesc.Size = New System.Drawing.Size(247, 25)
        Me.LblTreatmentDesc.TabIndex = 62
        Me.LblTreatmentDesc.Text = "Descripción del Tratamiento"
        '
        'GunaSeparator4
        '
        Me.GunaSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator4.Location = New System.Drawing.Point(18, 298)
        Me.GunaSeparator4.Name = "GunaSeparator4"
        Me.GunaSeparator4.Size = New System.Drawing.Size(389, 1)
        Me.GunaSeparator4.TabIndex = 60
        '
        'TxtTreatName
        '
        Me.TxtTreatName.BackColor = System.Drawing.Color.White
        Me.TxtTreatName.BaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatName.BorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatName.BorderSize = 0
        Me.TxtTreatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTreatName.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtTreatName.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtTreatName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTreatName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTreatName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtTreatName.Location = New System.Drawing.Point(18, 269)
        Me.TxtTreatName.Multiline = True
        Me.TxtTreatName.Name = "TxtTreatName"
        Me.TxtTreatName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTreatName.SelectedText = ""
        Me.TxtTreatName.Size = New System.Drawing.Size(389, 30)
        Me.TxtTreatName.TabIndex = 61
        '
        'LblTreatmentName
        '
        Me.LblTreatmentName.AutoSize = True
        Me.LblTreatmentName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreatmentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTreatmentName.Location = New System.Drawing.Point(13, 241)
        Me.LblTreatmentName.Name = "LblTreatmentName"
        Me.LblTreatmentName.Size = New System.Drawing.Size(217, 25)
        Me.LblTreatmentName.TabIndex = 59
        Me.LblTreatmentName.Text = "Nombre del Tratamiento"
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator3.Location = New System.Drawing.Point(18, 228)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(389, 1)
        Me.GunaSeparator3.TabIndex = 58
        '
        'TxtDescr
        '
        Me.TxtDescr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtDescr.Location = New System.Drawing.Point(18, 104)
        Me.TxtDescr.Name = "TxtDescr"
        Me.TxtDescr.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TxtDescr.Size = New System.Drawing.Size(389, 125)
        Me.TxtDescr.TabIndex = 57
        Me.TxtDescr.Text = ""
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblPrioridad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblPrioridad.ForeColor = System.Drawing.Color.White
        Me.LblPrioridad.Location = New System.Drawing.Point(288, 39)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(35, 15)
        Me.LblPrioridad.TabIndex = 55
        Me.LblPrioridad.Text = "BAJA"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(397, 81)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel2.TabIndex = 54
        Me.GunaLabel2.Text = "*"
        '
        'Spinner
        '
        Me.Spinner.BackColor = System.Drawing.Color.Transparent
        Me.Spinner.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Spinner.BorderRadius = 4
        Me.Spinner.Cursor = System.Windows.Forms.Cursors.Default
        Me.Spinner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Spinner.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Spinner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Spinner.DisabledState.Parent = Me.Spinner
        Me.Spinner.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Spinner.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Spinner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Spinner.FocusedState.Parent = Me.Spinner
        Me.Spinner.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Spinner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Spinner.Location = New System.Drawing.Point(225, 34)
        Me.Spinner.Name = "Spinner"
        Me.Spinner.ShadowDecoration.Parent = Me.Spinner
        Me.Spinner.Size = New System.Drawing.Size(50, 23)
        Me.Spinner.TabIndex = 53
        Me.Spinner.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Spinner.UpDownButtonForeColor = System.Drawing.Color.White
        Me.Spinner.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator2.Location = New System.Drawing.Point(223, 63)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(184, 1)
        Me.GunaSeparator2.TabIndex = 51
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(397, 13)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel1.TabIndex = 50
        Me.GunaLabel1.Text = "*"
        '
        'LblMortality
        '
        Me.LblMortality.AutoSize = True
        Me.LblMortality.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMortality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblMortality.Location = New System.Drawing.Point(218, 10)
        Me.LblMortality.Name = "LblMortality"
        Me.LblMortality.Size = New System.Drawing.Size(172, 25)
        Me.LblMortality.TabIndex = 49
        Me.LblMortality.Text = "Tasa de Mortalidad"
        '
        'Asterisco
        '
        Me.Asterisco.AutoSize = True
        Me.Asterisco.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Asterisco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Asterisco.Location = New System.Drawing.Point(192, 13)
        Me.Asterisco.Name = "Asterisco"
        Me.Asterisco.Size = New System.Drawing.Size(20, 25)
        Me.Asterisco.TabIndex = 47
        Me.Asterisco.Text = "*"
        '
        'LblDescr
        '
        Me.LblDescr.AutoSize = True
        Me.LblDescr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblDescr.Location = New System.Drawing.Point(13, 76)
        Me.LblDescr.Name = "LblDescr"
        Me.LblDescr.Size = New System.Drawing.Size(241, 25)
        Me.LblDescr.TabIndex = 46
        Me.LblDescr.Text = "Descripción de la Patología"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(18, 63)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(184, 1)
        Me.GunaSeparator1.TabIndex = 44
        '
        'LblPatName
        '
        Me.LblPatName.AutoSize = True
        Me.LblPatName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblPatName.Location = New System.Drawing.Point(13, 10)
        Me.LblPatName.Name = "LblPatName"
        Me.LblPatName.Size = New System.Drawing.Size(165, 25)
        Me.LblPatName.TabIndex = 42
        Me.LblPatName.Text = "Nombre Patología"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.BaseColor = System.Drawing.Color.Transparent
        Me.TxtName.BorderColor = System.Drawing.Color.Transparent
        Me.TxtName.BorderSize = 0
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtName.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(18, 34)
        Me.TxtName.Multiline = True
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.SelectedText = ""
        Me.TxtName.Size = New System.Drawing.Size(184, 30)
        Me.TxtName.TabIndex = 45
        '
        'PicPrior
        '
        Me.PicPrior.Image = CType(resources.GetObject("PicPrior.Image"), System.Drawing.Image)
        Me.PicPrior.Location = New System.Drawing.Point(283, 38)
        Me.PicPrior.Name = "PicPrior"
        Me.PicPrior.ShadowDecoration.Parent = Me.PicPrior
        Me.PicPrior.Size = New System.Drawing.Size(124, 19)
        Me.PicPrior.TabIndex = 56
        Me.PicPrior.TabStop = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.LightGray
        Me.PanelTop.Controls.Add(Me.LblPat)
        Me.PanelTop.Controls.Add(Me.LblPatTop)
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.LblPathTop)
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(927, 35)
        Me.PanelTop.TabIndex = 34
        '
        'LblPat
        '
        Me.LblPat.AutoSize = True
        Me.LblPat.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblPat.Location = New System.Drawing.Point(358, 0)
        Me.LblPat.Name = "LblPat"
        Me.LblPat.Size = New System.Drawing.Size(0, 30)
        Me.LblPat.TabIndex = 30
        '
        'LblPatTop
        '
        Me.LblPatTop.AutoSize = True
        Me.LblPatTop.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblPatTop.Location = New System.Drawing.Point(358, 0)
        Me.LblPatTop.Name = "LblPatTop"
        Me.LblPatTop.Size = New System.Drawing.Size(0, 30)
        Me.LblPatTop.TabIndex = 29
        '
        'BtnClose
        '
        Me.BtnClose.AnimationHoverSpeed = 0.07!
        Me.BtnClose.AnimationSpeed = 0.03!
        Me.BtnClose.BaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.BorderColor = System.Drawing.Color.Black
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnClose.FocusedColor = System.Drawing.Color.Empty
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnClose.Location = New System.Drawing.Point(884, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnClose.OnHoverImage = Nothing
        Me.BtnClose.OnPressedColor = System.Drawing.Color.Black
        Me.BtnClose.Size = New System.Drawing.Size(40, 24)
        Me.BtnClose.TabIndex = 28
        '
        'LblPathTop
        '
        Me.LblPathTop.AutoSize = True
        Me.LblPathTop.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPathTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblPathTop.Location = New System.Drawing.Point(3, 0)
        Me.LblPathTop.Name = "LblPathTop"
        Me.LblPathTop.Size = New System.Drawing.Size(356, 30)
        Me.LblPathTop.TabIndex = 0
        Me.LblPathTop.Text = "MODIFICACIÓN DE LA PATOLOGÍA"
        '
        'FrmModPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 477)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModPath"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.DgvTreat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPrior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents BtnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnModTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDelTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator6 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtTreatType As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblTreatmentType As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator5 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtTreatDesc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblTreatmentDesc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator4 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtTreatName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblTreatmentName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtDescr As RichTextBox
    Friend WithEvents LblPrioridad As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Spinner As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblMortality As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Asterisco As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblDescr As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents LblPatName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PicPrior As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblPathTop As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblPatTop As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DgvTreat As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents RbnQ As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbnMed As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LblPat As Guna.UI.WinForms.GunaLabel
End Class
