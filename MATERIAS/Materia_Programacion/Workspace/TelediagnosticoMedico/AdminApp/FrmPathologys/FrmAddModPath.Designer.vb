<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddModPath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddModPath))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LblPrioridad = New Guna.UI.WinForms.GunaLabel()
        Me.PicPrior = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnImportCsv = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.CmbTipo = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaSeparator7 = New Guna.UI.WinForms.GunaSeparator()
        Me.LblSubTitle4_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.RdbtnQuir_A_HPP = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.DgvTreat = New Guna.UI.WinForms.GunaDataGridView()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RdbtnMedicine_A_HPP = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.BtnAddPath_A_HPP = New Guna.UI.WinForms.GunaButton()
        Me.BtnModTreat = New Guna.UI.WinForms.GunaButton()
        Me.BtnDelTreat = New Guna.UI.WinForms.GunaButton()
        Me.BtnAddTreat = New Guna.UI.WinForms.GunaButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LblInfo2_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.LblInfo1_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator6 = New Guna.UI.WinForms.GunaSeparator()
        Me.LblSubTitle7_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator5 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtTreatDesc = New Guna.UI.WinForms.GunaTextBox()
        Me.LblSubTitle6_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator4 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtTreatName = New Guna.UI.WinForms.GunaTextBox()
        Me.LblSubTitle5_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtDescr = New System.Windows.Forms.RichTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Spinner = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.LblSubTitle2_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.Asterisco = New Guna.UI.WinForms.GunaLabel()
        Me.LblSubTitle3_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.LblSubTitle1_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.TxtName = New Guna.UI.WinForms.GunaTextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LblPat = New Guna.UI.WinForms.GunaLabel()
        Me.LblPatTop = New Guna.UI.WinForms.GunaLabel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.LblTitle1_A_HPP = New Guna.UI.WinForms.GunaLabel()
        Me.LblSubTitle8_A_HPP = New System.Windows.Forms.Label()
        Me.OfdAddPathology = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelMain.SuspendLayout()
        CType(Me.PicPrior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.BackgroundImage = CType(resources.GetObject("PanelMain.BackgroundImage"), System.Drawing.Image)
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.LblPrioridad)
        Me.PanelMain.Controls.Add(Me.PicPrior)
        Me.PanelMain.Controls.Add(Me.BtnImportCsv)
        Me.PanelMain.Controls.Add(Me.GunaLabel9)
        Me.PanelMain.Controls.Add(Me.CmbTipo)
        Me.PanelMain.Controls.Add(Me.GunaSeparator7)
        Me.PanelMain.Controls.Add(Me.LblSubTitle4_A_HPP)
        Me.PanelMain.Controls.Add(Me.RdbtnQuir_A_HPP)
        Me.PanelMain.Controls.Add(Me.DgvTreat)
        Me.PanelMain.Controls.Add(Me.RdbtnMedicine_A_HPP)
        Me.PanelMain.Controls.Add(Me.BtnAddPath_A_HPP)
        Me.PanelMain.Controls.Add(Me.BtnModTreat)
        Me.PanelMain.Controls.Add(Me.BtnDelTreat)
        Me.PanelMain.Controls.Add(Me.BtnAddTreat)
        Me.PanelMain.Controls.Add(Me.Guna2PictureBox2)
        Me.PanelMain.Controls.Add(Me.LblInfo2_A_HPP)
        Me.PanelMain.Controls.Add(Me.LblInfo1_A_HPP)
        Me.PanelMain.Controls.Add(Me.GunaLabel8)
        Me.PanelMain.Controls.Add(Me.GunaLabel7)
        Me.PanelMain.Controls.Add(Me.GunaLabel6)
        Me.PanelMain.Controls.Add(Me.GunaSeparator6)
        Me.PanelMain.Controls.Add(Me.LblSubTitle7_A_HPP)
        Me.PanelMain.Controls.Add(Me.GunaSeparator5)
        Me.PanelMain.Controls.Add(Me.TxtTreatDesc)
        Me.PanelMain.Controls.Add(Me.LblSubTitle6_A_HPP)
        Me.PanelMain.Controls.Add(Me.GunaSeparator4)
        Me.PanelMain.Controls.Add(Me.TxtTreatName)
        Me.PanelMain.Controls.Add(Me.LblSubTitle5_A_HPP)
        Me.PanelMain.Controls.Add(Me.GunaSeparator3)
        Me.PanelMain.Controls.Add(Me.TxtDescr)
        Me.PanelMain.Controls.Add(Me.GunaLabel2)
        Me.PanelMain.Controls.Add(Me.Spinner)
        Me.PanelMain.Controls.Add(Me.GunaSeparator2)
        Me.PanelMain.Controls.Add(Me.GunaLabel1)
        Me.PanelMain.Controls.Add(Me.LblSubTitle2_A_HPP)
        Me.PanelMain.Controls.Add(Me.Asterisco)
        Me.PanelMain.Controls.Add(Me.LblSubTitle3_A_HPP)
        Me.PanelMain.Controls.Add(Me.GunaSeparator1)
        Me.PanelMain.Controls.Add(Me.LblSubTitle1_A_HPP)
        Me.PanelMain.Controls.Add(Me.TxtName)
        Me.PanelMain.Location = New System.Drawing.Point(0, 33)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(927, 443)
        Me.PanelMain.TabIndex = 35
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
        'PicPrior
        '
        Me.PicPrior.Image = CType(resources.GetObject("PicPrior.Image"), System.Drawing.Image)
        Me.PicPrior.Location = New System.Drawing.Point(283, 36)
        Me.PicPrior.Name = "PicPrior"
        Me.PicPrior.ShadowDecoration.Parent = Me.PicPrior
        Me.PicPrior.Size = New System.Drawing.Size(124, 21)
        Me.PicPrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPrior.TabIndex = 56
        Me.PicPrior.TabStop = False
        '
        'BtnImportCsv
        '
        Me.BtnImportCsv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImportCsv.Animated = True
        Me.BtnImportCsv.AnimationHoverSpeed = 0.07!
        Me.BtnImportCsv.AnimationSpeed = 0.03!
        Me.BtnImportCsv.BackColor = System.Drawing.Color.Transparent
        Me.BtnImportCsv.BaseColor = System.Drawing.Color.Transparent
        Me.BtnImportCsv.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnImportCsv.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnImportCsv.FocusedColor = System.Drawing.Color.Empty
        Me.BtnImportCsv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportCsv.ForeColor = System.Drawing.Color.Black
        Me.BtnImportCsv.Image = CType(resources.GetObject("BtnImportCsv.Image"), System.Drawing.Image)
        Me.BtnImportCsv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnImportCsv.ImageSize = New System.Drawing.Size(39, 39)
        Me.BtnImportCsv.Location = New System.Drawing.Point(872, 328)
        Me.BtnImportCsv.Name = "BtnImportCsv"
        Me.BtnImportCsv.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnImportCsv.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnImportCsv.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnImportCsv.OnHoverImage = Nothing
        Me.BtnImportCsv.OnPressedColor = System.Drawing.Color.Black
        Me.BtnImportCsv.Radius = 6
        Me.BtnImportCsv.Size = New System.Drawing.Size(39, 39)
        Me.BtnImportCsv.TabIndex = 87
        Me.BtnImportCsv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnImportCsv.Visible = False
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(387, 171)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel9.TabIndex = 86
        Me.GunaLabel9.Text = "*"
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.Transparent
        Me.CmbTipo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CmbTipo.BorderColor = System.Drawing.Color.Silver
        Me.CmbTipo.BorderSize = 0
        Me.CmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FocusedColor = System.Drawing.Color.Empty
        Me.CmbTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbTipo.ForeColor = System.Drawing.Color.White
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(18, 202)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.OnHoverItemBaseColor = System.Drawing.Color.Teal
        Me.CmbTipo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CmbTipo.Radius = 5
        Me.CmbTipo.Size = New System.Drawing.Size(203, 26)
        Me.CmbTipo.TabIndex = 3
        '
        'GunaSeparator7
        '
        Me.GunaSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator7.Location = New System.Drawing.Point(18, 170)
        Me.GunaSeparator7.Name = "GunaSeparator7"
        Me.GunaSeparator7.Size = New System.Drawing.Size(389, 1)
        Me.GunaSeparator7.TabIndex = 84
        '
        'LblSubTitle4_A_HPP
        '
        Me.LblSubTitle4_A_HPP.AccessibleDescription = "LblSubTitle4_A_HPP"
        Me.LblSubTitle4_A_HPP.AccessibleName = "LblSubTitle4_A_HPP"
        Me.LblSubTitle4_A_HPP.AutoSize = True
        Me.LblSubTitle4_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle4_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle4_A_HPP.Location = New System.Drawing.Point(13, 174)
        Me.LblSubTitle4_A_HPP.Name = "LblSubTitle4_A_HPP"
        Me.LblSubTitle4_A_HPP.Size = New System.Drawing.Size(159, 25)
        Me.LblSubTitle4_A_HPP.TabIndex = 83
        Me.LblSubTitle4_A_HPP.Text = "Tipo de Patología"
        '
        'RdbtnQuir_A_HPP
        '
        Me.RdbtnQuir_A_HPP.AccessibleDescription = "RdbtnQuir_A_HPP"
        Me.RdbtnQuir_A_HPP.AccessibleName = "RdbtnQuir_A_HPP"
        Me.RdbtnQuir_A_HPP.AutoSize = True
        Me.RdbtnQuir_A_HPP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdbtnQuir_A_HPP.CheckedState.BorderThickness = 0
        Me.RdbtnQuir_A_HPP.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RdbtnQuir_A_HPP.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RdbtnQuir_A_HPP.CheckedState.InnerOffset = -4
        Me.RdbtnQuir_A_HPP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnQuir_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.RdbtnQuir_A_HPP.Location = New System.Drawing.Point(153, 407)
        Me.RdbtnQuir_A_HPP.Name = "RdbtnQuir_A_HPP"
        Me.RdbtnQuir_A_HPP.Size = New System.Drawing.Size(84, 19)
        Me.RdbtnQuir_A_HPP.TabIndex = 7
        Me.RdbtnQuir_A_HPP.Text = "Quirúrgico"
        Me.RdbtnQuir_A_HPP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdbtnQuir_A_HPP.UncheckedState.BorderThickness = 2
        Me.RdbtnQuir_A_HPP.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnQuir_A_HPP.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        'RdbtnMedicine_A_HPP
        '
        Me.RdbtnMedicine_A_HPP.AccessibleDescription = "RdbtnMedicine_A_HPP"
        Me.RdbtnMedicine_A_HPP.AccessibleName = "RdbtnMedicine_A_HPP"
        Me.RdbtnMedicine_A_HPP.AutoSize = True
        Me.RdbtnMedicine_A_HPP.CheckedState.BorderThickness = 0
        Me.RdbtnMedicine_A_HPP.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RdbtnMedicine_A_HPP.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RdbtnMedicine_A_HPP.CheckedState.InnerOffset = -4
        Me.RdbtnMedicine_A_HPP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnMedicine_A_HPP.Location = New System.Drawing.Point(18, 407)
        Me.RdbtnMedicine_A_HPP.Name = "RdbtnMedicine_A_HPP"
        Me.RdbtnMedicine_A_HPP.Size = New System.Drawing.Size(102, 19)
        Me.RdbtnMedicine_A_HPP.TabIndex = 6
        Me.RdbtnMedicine_A_HPP.Text = "Medicamento"
        Me.RdbtnMedicine_A_HPP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdbtnMedicine_A_HPP.UncheckedState.BorderThickness = 2
        Me.RdbtnMedicine_A_HPP.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnMedicine_A_HPP.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'BtnAddPath_A_HPP
        '
        Me.BtnAddPath_A_HPP.AccessibleDescription = "BtnAddPath_A_HPP"
        Me.BtnAddPath_A_HPP.AccessibleName = "BtnAddPath_A_HPP"
        Me.BtnAddPath_A_HPP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPath_A_HPP.Animated = True
        Me.BtnAddPath_A_HPP.AnimationHoverSpeed = 0.07!
        Me.BtnAddPath_A_HPP.AnimationSpeed = 0.03!
        Me.BtnAddPath_A_HPP.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddPath_A_HPP.BaseColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnAddPath_A_HPP.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddPath_A_HPP.BorderSize = 1
        Me.BtnAddPath_A_HPP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddPath_A_HPP.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddPath_A_HPP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPath_A_HPP.ForeColor = System.Drawing.Color.White
        Me.BtnAddPath_A_HPP.Image = Nothing
        Me.BtnAddPath_A_HPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnAddPath_A_HPP.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnAddPath_A_HPP.Location = New System.Drawing.Point(764, 389)
        Me.BtnAddPath_A_HPP.Name = "BtnAddPath_A_HPP"
        Me.BtnAddPath_A_HPP.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnAddPath_A_HPP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnAddPath_A_HPP.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnAddPath_A_HPP.OnHoverImage = Nothing
        Me.BtnAddPath_A_HPP.OnPressedColor = System.Drawing.Color.Black
        Me.BtnAddPath_A_HPP.Radius = 2
        Me.BtnAddPath_A_HPP.Size = New System.Drawing.Size(150, 42)
        Me.BtnAddPath_A_HPP.TabIndex = 11
        Me.BtnAddPath_A_HPP.Text = "Modificar Patología"
        Me.BtnAddPath_A_HPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BtnModTreat.TabIndex = 10
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
        Me.BtnDelTreat.TabIndex = 9
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
        Me.BtnAddTreat.TabIndex = 8
        Me.BtnAddTreat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(423, 389)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(339, 42)
        Me.Guna2PictureBox2.TabIndex = 75
        Me.Guna2PictureBox2.TabStop = False
        '
        'LblInfo2_A_HPP
        '
        Me.LblInfo2_A_HPP.AccessibleDescription = "LblInfo2_A_HPP"
        Me.LblInfo2_A_HPP.AccessibleName = "LblInfo2_A_HPP"
        Me.LblInfo2_A_HPP.AutoSize = True
        Me.LblInfo2_A_HPP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo2_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblInfo2_A_HPP.Location = New System.Drawing.Point(420, 373)
        Me.LblInfo2_A_HPP.Name = "LblInfo2_A_HPP"
        Me.LblInfo2_A_HPP.Size = New System.Drawing.Size(187, 13)
        Me.LblInfo2_A_HPP.TabIndex = 74
        Me.LblInfo2_A_HPP.Text = "Administración de los Tratamientos"
        '
        'LblInfo1_A_HPP
        '
        Me.LblInfo1_A_HPP.AccessibleDescription = "LblInfo1_A_HPP"
        Me.LblInfo1_A_HPP.AccessibleName = "LblInfo1_A_HPP"
        Me.LblInfo1_A_HPP.AutoSize = True
        Me.LblInfo1_A_HPP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo1_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblInfo1_A_HPP.Location = New System.Drawing.Point(794, 1)
        Me.LblInfo1_A_HPP.Name = "LblInfo1_A_HPP"
        Me.LblInfo1_A_HPP.Size = New System.Drawing.Size(120, 13)
        Me.LblInfo1_A_HPP.TabIndex = 73
        Me.LblInfo1_A_HPP.Text = "Campo Obligatorio [*]"
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
        'LblSubTitle7_A_HPP
        '
        Me.LblSubTitle7_A_HPP.AccessibleDescription = "LblSubTitle7_A_HPP"
        Me.LblSubTitle7_A_HPP.AccessibleName = "LblSubTitle7_A_HPP"
        Me.LblSubTitle7_A_HPP.AutoSize = True
        Me.LblSubTitle7_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle7_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle7_A_HPP.Location = New System.Drawing.Point(13, 373)
        Me.LblSubTitle7_A_HPP.Name = "LblSubTitle7_A_HPP"
        Me.LblSubTitle7_A_HPP.Size = New System.Drawing.Size(180, 25)
        Me.LblSubTitle7_A_HPP.TabIndex = 65
        Me.LblSubTitle7_A_HPP.Text = "Tipo de Tratamiento"
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
        Me.TxtTreatDesc.BackColor = System.Drawing.Color.Transparent
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
        Me.TxtTreatDesc.TabIndex = 5
        '
        'LblSubTitle6_A_HPP
        '
        Me.LblSubTitle6_A_HPP.AccessibleDescription = "LblSubTitle6_A_HPP"
        Me.LblSubTitle6_A_HPP.AccessibleName = "LblSubTitle6_A_HPP"
        Me.LblSubTitle6_A_HPP.AutoSize = True
        Me.LblSubTitle6_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle6_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle6_A_HPP.Location = New System.Drawing.Point(13, 312)
        Me.LblSubTitle6_A_HPP.Name = "LblSubTitle6_A_HPP"
        Me.LblSubTitle6_A_HPP.Size = New System.Drawing.Size(247, 25)
        Me.LblSubTitle6_A_HPP.TabIndex = 62
        Me.LblSubTitle6_A_HPP.Text = "Descripción del Tratamiento"
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
        Me.TxtTreatName.BackColor = System.Drawing.Color.Transparent
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
        Me.TxtTreatName.TabIndex = 4
        '
        'LblSubTitle5_A_HPP
        '
        Me.LblSubTitle5_A_HPP.AccessibleDescription = "LblSubTitle5_A_HPP"
        Me.LblSubTitle5_A_HPP.AccessibleName = "LblSubTitle5_A_HPP"
        Me.LblSubTitle5_A_HPP.AutoSize = True
        Me.LblSubTitle5_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle5_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle5_A_HPP.Location = New System.Drawing.Point(13, 241)
        Me.LblSubTitle5_A_HPP.Name = "LblSubTitle5_A_HPP"
        Me.LblSubTitle5_A_HPP.Size = New System.Drawing.Size(217, 25)
        Me.LblSubTitle5_A_HPP.TabIndex = 59
        Me.LblSubTitle5_A_HPP.Text = "Nombre del Tratamiento"
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator3.Location = New System.Drawing.Point(18, 233)
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
        Me.TxtDescr.Size = New System.Drawing.Size(389, 64)
        Me.TxtDescr.TabIndex = 2
        Me.TxtDescr.Text = ""
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(387, 76)
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
        Me.Spinner.TabIndex = 1
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
        Me.GunaLabel1.Location = New System.Drawing.Point(387, 13)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(20, 25)
        Me.GunaLabel1.TabIndex = 50
        Me.GunaLabel1.Text = "*"
        '
        'LblSubTitle2_A_HPP
        '
        Me.LblSubTitle2_A_HPP.AccessibleDescription = "LblSubTitle2_A_HPP"
        Me.LblSubTitle2_A_HPP.AccessibleName = "LblSubTitle2_A_HPP"
        Me.LblSubTitle2_A_HPP.AutoSize = True
        Me.LblSubTitle2_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle2_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle2_A_HPP.Location = New System.Drawing.Point(218, 10)
        Me.LblSubTitle2_A_HPP.Name = "LblSubTitle2_A_HPP"
        Me.LblSubTitle2_A_HPP.Size = New System.Drawing.Size(172, 25)
        Me.LblSubTitle2_A_HPP.TabIndex = 49
        Me.LblSubTitle2_A_HPP.Text = "Tasa de Mortalidad"
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
        'LblSubTitle3_A_HPP
        '
        Me.LblSubTitle3_A_HPP.AccessibleDescription = "LblSubTitle3_A_HPP"
        Me.LblSubTitle3_A_HPP.AccessibleName = "LblSubTitle3_A_HPP"
        Me.LblSubTitle3_A_HPP.AutoSize = True
        Me.LblSubTitle3_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle3_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle3_A_HPP.Location = New System.Drawing.Point(13, 76)
        Me.LblSubTitle3_A_HPP.Name = "LblSubTitle3_A_HPP"
        Me.LblSubTitle3_A_HPP.Size = New System.Drawing.Size(241, 25)
        Me.LblSubTitle3_A_HPP.TabIndex = 46
        Me.LblSubTitle3_A_HPP.Text = "Descripción de la Patología"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(18, 63)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(184, 1)
        Me.GunaSeparator1.TabIndex = 44
        '
        'LblSubTitle1_A_HPP
        '
        Me.LblSubTitle1_A_HPP.AccessibleDescription = "LblSubTitle1_A_HPP"
        Me.LblSubTitle1_A_HPP.AccessibleName = "LblSubTitle1_A_HPP"
        Me.LblSubTitle1_A_HPP.AutoSize = True
        Me.LblSubTitle1_A_HPP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle1_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblSubTitle1_A_HPP.Location = New System.Drawing.Point(13, 10)
        Me.LblSubTitle1_A_HPP.Name = "LblSubTitle1_A_HPP"
        Me.LblSubTitle1_A_HPP.Size = New System.Drawing.Size(165, 25)
        Me.LblSubTitle1_A_HPP.TabIndex = 42
        Me.LblSubTitle1_A_HPP.Text = "Nombre Patología"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.Transparent
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
        Me.TxtName.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LblPat)
        Me.PanelTop.Controls.Add(Me.LblPatTop)
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.LblTitle1_A_HPP)
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
        'LblTitle1_A_HPP
        '
        Me.LblTitle1_A_HPP.AccessibleDescription = "LblTitle1_A_HPP"
        Me.LblTitle1_A_HPP.AccessibleName = "LblTitle1_A_HPP"
        Me.LblTitle1_A_HPP.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTitle1_A_HPP.Location = New System.Drawing.Point(3, 3)
        Me.LblTitle1_A_HPP.Name = "LblTitle1_A_HPP"
        Me.LblTitle1_A_HPP.Size = New System.Drawing.Size(728, 30)
        Me.LblTitle1_A_HPP.TabIndex = 0
        Me.LblTitle1_A_HPP.Text = "MODIFICACIÓN DE LA PATOLOGÍA"
        '
        'LblSubTitle8_A_HPP
        '
        Me.LblSubTitle8_A_HPP.AccessibleDescription = "LblSubTitle8_A_HPP"
        Me.LblSubTitle8_A_HPP.AccessibleName = "LblSubTitle8_A_HPP"
        Me.LblSubTitle8_A_HPP.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle8_A_HPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblSubTitle8_A_HPP.Location = New System.Drawing.Point(423, 50)
        Me.LblSubTitle8_A_HPP.Name = "LblSubTitle8_A_HPP"
        Me.LblSubTitle8_A_HPP.Size = New System.Drawing.Size(491, 38)
        Me.LblSubTitle8_A_HPP.TabIndex = 83
        Me.LblSubTitle8_A_HPP.Text = "LISTADO DE TRATAMIENTOS PARA LA PATOLOGÍA"
        Me.LblSubTitle8_A_HPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OfdAddPathology
        '
        Me.OfdAddPathology.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"" ;"
        Me.OfdAddPathology.Title = "Agregar patología"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmAddModPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 477)
        Me.Controls.Add(Me.LblSubTitle8_A_HPP)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModPath"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PicPrior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTreat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents BtnAddPath_A_HPP As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnModTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDelTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAddTreat As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LblInfo2_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblInfo1_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator6 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents LblSubTitle7_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator5 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtTreatDesc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblSubTitle6_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator4 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtTreatName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblSubTitle5_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TxtDescr As RichTextBox
    Friend WithEvents LblPrioridad As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Spinner As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSubTitle2_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Asterisco As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSubTitle3_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents LblSubTitle1_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PicPrior As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblTitle1_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblPatTop As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DgvTreat As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents RdbtnMedicine_A_HPP As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LblPat As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSubTitle8_A_HPP As Label
    Friend WithEvents GunaSeparator7 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents LblSubTitle4_A_HPP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CmbTipo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnImportCsv As Guna.UI.WinForms.GunaButton
    Friend WithEvents OfdAddPathology As OpenFileDialog
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents RdbtnQuir_A_HPP As Guna.UI2.WinForms.Guna2RadioButton
End Class
