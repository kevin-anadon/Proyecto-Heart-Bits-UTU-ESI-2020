<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModSympt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModSympt))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LblSymptTop = New Guna.UI.WinForms.GunaLabel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicLogo = New Guna.UI.WinForms.GunaPictureBox()
        Me.ChkReg = New Guna.UI.WinForms.GunaCheckBox()
        Me.Cmbreg = New Guna.UI.WinForms.GunaComboBox()
        Me.BtnCancel = New Guna.UI.WinForms.GunaButton()
        Me.BtnMod = New Guna.UI.WinForms.GunaButton()
        Me.Lblreg = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtDescr = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.ChkListPath = New System.Windows.Forms.CheckedListBox()
        Me.PanelTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.LightGray
        Me.PanelTop.Controls.Add(Me.LblSymptTop)
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.GunaLabel1)
        Me.PanelTop.Location = New System.Drawing.Point(1, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(674, 35)
        Me.PanelTop.TabIndex = 2
        '
        'LblSymptTop
        '
        Me.LblSymptTop.AutoSize = True
        Me.LblSymptTop.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSymptTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblSymptTop.Location = New System.Drawing.Point(326, 0)
        Me.LblSymptTop.Name = "LblSymptTop"
        Me.LblSymptTop.Size = New System.Drawing.Size(0, 30)
        Me.LblSymptTop.TabIndex = 29
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
        Me.BtnClose.Location = New System.Drawing.Point(631, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnClose.OnHoverImage = Nothing
        Me.BtnClose.OnPressedColor = System.Drawing.Color.Black
        Me.BtnClose.Size = New System.Drawing.Size(40, 24)
        Me.BtnClose.TabIndex = 28
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(317, 30)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "MODIFICACIÓN DEL SÍNTOMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PicLogo)
        Me.Panel1.Controls.Add(Me.ChkReg)
        Me.Panel1.Controls.Add(Me.Cmbreg)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnMod)
        Me.Panel1.Controls.Add(Me.Lblreg)
        Me.Panel1.Controls.Add(Me.GunaLabel5)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.ChkListPath)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.GunaSeparator1)
        Me.Panel1.Controls.Add(Me.TxtDescr)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 202)
        Me.Panel1.TabIndex = 32
        '
        'PicLogo
        '
        Me.PicLogo.BaseColor = System.Drawing.Color.White
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(630, 151)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(39, 44)
        Me.PicLogo.TabIndex = 45
        Me.PicLogo.TabStop = False
        '
        'ChkReg
        '
        Me.ChkReg.BackColor = System.Drawing.Color.White
        Me.ChkReg.BaseColor = System.Drawing.Color.White
        Me.ChkReg.CheckedOffColor = System.Drawing.SystemColors.Desktop
        Me.ChkReg.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ChkReg.FillColor = System.Drawing.Color.White
        Me.ChkReg.Location = New System.Drawing.Point(232, 138)
        Me.ChkReg.Name = "ChkReg"
        Me.ChkReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkReg.Size = New System.Drawing.Size(110, 20)
        Me.ChkReg.TabIndex = 43
        Me.ChkReg.Text = "Modificar región"
        '
        'Cmbreg
        '
        Me.Cmbreg.BackColor = System.Drawing.Color.Transparent
        Me.Cmbreg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Cmbreg.BorderColor = System.Drawing.Color.Silver
        Me.Cmbreg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbreg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbreg.FocusedColor = System.Drawing.Color.Empty
        Me.Cmbreg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Cmbreg.ForeColor = System.Drawing.Color.White
        Me.Cmbreg.FormattingEnabled = True
        Me.Cmbreg.Location = New System.Drawing.Point(232, 164)
        Me.Cmbreg.Name = "Cmbreg"
        Me.Cmbreg.OnHoverItemBaseColor = System.Drawing.Color.Teal
        Me.Cmbreg.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Cmbreg.Radius = 5
        Me.Cmbreg.Size = New System.Drawing.Size(203, 26)
        Me.Cmbreg.TabIndex = 42
        Me.Cmbreg.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Animated = True
        Me.BtnCancel.AnimationHoverSpeed = 0.07!
        Me.BtnCancel.AnimationSpeed = 0.03!
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnCancel.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.BorderSize = 1
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnCancel.Location = New System.Drawing.Point(481, 151)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnCancel.OnHoverImage = Nothing
        Me.BtnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.BtnCancel.Radius = 6
        Me.BtnCancel.Size = New System.Drawing.Size(39, 39)
        Me.BtnCancel.TabIndex = 41
        Me.BtnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnMod
        '
        Me.BtnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMod.Animated = True
        Me.BtnMod.AnimationHoverSpeed = 0.07!
        Me.BtnMod.AnimationSpeed = 0.03!
        Me.BtnMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnMod.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnMod.BorderColor = System.Drawing.Color.Silver
        Me.BtnMod.BorderSize = 1
        Me.BtnMod.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMod.FocusedColor = System.Drawing.Color.Empty
        Me.BtnMod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMod.ForeColor = System.Drawing.Color.Black
        Me.BtnMod.Image = CType(resources.GetObject("BtnMod.Image"), System.Drawing.Image)
        Me.BtnMod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnMod.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnMod.Location = New System.Drawing.Point(526, 151)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnMod.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnMod.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnMod.OnHoverImage = Nothing
        Me.BtnMod.OnPressedColor = System.Drawing.Color.Black
        Me.BtnMod.Radius = 6
        Me.BtnMod.Size = New System.Drawing.Size(76, 39)
        Me.BtnMod.TabIndex = 40
        Me.BtnMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lblreg
        '
        Me.Lblreg.AutoSize = True
        Me.Lblreg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Lblreg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Lblreg.Location = New System.Drawing.Point(282, 104)
        Me.Lblreg.Name = "Lblreg"
        Me.Lblreg.Size = New System.Drawing.Size(0, 15)
        Me.Lblreg.TabIndex = 39
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(229, 104)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel5.TabIndex = 38
        Me.GunaLabel5.Text = "Actual: "
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(227, 71)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(217, 30)
        Me.GunaLabel4.TabIndex = 37
        Me.GunaLabel4.Text = "Asociación a la región"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(6, 71)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(215, 30)
        Me.GunaLabel3.TabIndex = 35
        Me.GunaLabel3.Text = "Asociación patologías"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(11, 58)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(650, 10)
        Me.GunaSeparator1.TabIndex = 34
        '
        'TxtDescr
        '
        Me.TxtDescr.BackColor = System.Drawing.Color.White
        Me.TxtDescr.BaseColor = System.Drawing.Color.Transparent
        Me.TxtDescr.BorderColor = System.Drawing.Color.Transparent
        Me.TxtDescr.BorderSize = 0
        Me.TxtDescr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescr.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtDescr.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtDescr.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtDescr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDescr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtDescr.Location = New System.Drawing.Point(2, 38)
        Me.TxtDescr.Multiline = True
        Me.TxtDescr.Name = "TxtDescr"
        Me.TxtDescr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDescr.SelectedText = ""
        Me.TxtDescr.Size = New System.Drawing.Size(204, 30)
        Me.TxtDescr.TabIndex = 33
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 5)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(121, 30)
        Me.GunaLabel2.TabIndex = 32
        Me.GunaLabel2.Text = "Descripción"
        '
        'ChkListPath
        '
        Me.ChkListPath.CheckOnClick = True
        Me.ChkListPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkListPath.FormattingEnabled = True
        Me.ChkListPath.Location = New System.Drawing.Point(11, 104)
        Me.ChkListPath.Name = "ChkListPath"
        Me.ChkListPath.Size = New System.Drawing.Size(200, 94)
        Me.ChkListPath.TabIndex = 36
        '
        'FrmModSympt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 236)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModSympt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModSympt"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSymptTop As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDescr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lblreg As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnMod As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents ChkReg As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Cmbreg As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PicLogo As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents ChkListPath As CheckedListBox
End Class
