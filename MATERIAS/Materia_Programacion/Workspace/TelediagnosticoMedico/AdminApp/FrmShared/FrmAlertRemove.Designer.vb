<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlertRemove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlertRemove))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.LblEliminar = New Guna.UI.WinForms.GunaLabel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.PicVector = New System.Windows.Forms.PictureBox()
        Me.TxtPin = New Guna.UI.WinForms.GunaTextBox()
        Me.BtnPin_A_R = New Guna.UI.WinForms.GunaButton()
        Me.LblPregunta_A_R = New Guna.UI.WinForms.GunaLabel()
        Me.LblSympt = New Guna.UI.WinForms.GunaLabel()
        Me.LblElimBody = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl1_A_R = New Guna.UI.WinForms.GunaLabel()
        Me.LblAttention_A_R = New Guna.UI.WinForms.GunaLabel()
        Me.PanelTop.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.LightGray
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.LblEliminar)
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(433, 33)
        Me.PanelTop.TabIndex = 1
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
        Me.BtnClose.Location = New System.Drawing.Point(390, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnClose.OnHoverImage = Nothing
        Me.BtnClose.OnPressedColor = System.Drawing.Color.Black
        Me.BtnClose.Size = New System.Drawing.Size(40, 24)
        Me.BtnClose.TabIndex = 28
        '
        'LblEliminar
        '
        Me.LblEliminar.AutoSize = True
        Me.LblEliminar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblEliminar.Location = New System.Drawing.Point(3, 0)
        Me.LblEliminar.Name = "LblEliminar"
        Me.LblEliminar.Size = New System.Drawing.Size(219, 30)
        Me.LblEliminar.TabIndex = 0
        Me.LblEliminar.Text = "ELIMINAR SÍNTOMA"
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.White
        Me.PanelBody.BackgroundImage = CType(resources.GetObject("PanelBody.BackgroundImage"), System.Drawing.Image)
        Me.PanelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBody.Controls.Add(Me.GunaLabel6)
        Me.PanelBody.Controls.Add(Me.PicVector)
        Me.PanelBody.Controls.Add(Me.TxtPin)
        Me.PanelBody.Controls.Add(Me.BtnPin_A_R)
        Me.PanelBody.Controls.Add(Me.LblPregunta_A_R)
        Me.PanelBody.Controls.Add(Me.LblSympt)
        Me.PanelBody.Controls.Add(Me.LblElimBody)
        Me.PanelBody.Controls.Add(Me.Lbl1_A_R)
        Me.PanelBody.Controls.Add(Me.LblAttention_A_R)
        Me.PanelBody.Location = New System.Drawing.Point(0, 33)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(433, 123)
        Me.PanelBody.TabIndex = 2
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(7, 67)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(26, 13)
        Me.GunaLabel6.TabIndex = 27
        Me.GunaLabel6.Text = "PIN"
        '
        'PicVector
        '
        Me.PicVector.Image = CType(resources.GetObject("PicVector.Image"), System.Drawing.Image)
        Me.PicVector.Location = New System.Drawing.Point(13, 98)
        Me.PicVector.Name = "PicVector"
        Me.PicVector.Size = New System.Drawing.Size(4, 7)
        Me.PicVector.TabIndex = 26
        Me.PicVector.TabStop = False
        '
        'TxtPin
        '
        Me.TxtPin.BackColor = System.Drawing.Color.Transparent
        Me.TxtPin.BaseColor = System.Drawing.Color.White
        Me.TxtPin.BorderColor = System.Drawing.Color.Silver
        Me.TxtPin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPin.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtPin.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TxtPin.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPin.Location = New System.Drawing.Point(8, 81)
        Me.TxtPin.Name = "TxtPin"
        Me.TxtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPin.Radius = 5
        Me.TxtPin.SelectedText = ""
        Me.TxtPin.Size = New System.Drawing.Size(115, 39)
        Me.TxtPin.TabIndex = 0
        Me.TxtPin.TextOffsetX = 5
        '
        'BtnPin_A_R
        '
        Me.BtnPin_A_R.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPin_A_R.Animated = True
        Me.BtnPin_A_R.AnimationHoverSpeed = 0.07!
        Me.BtnPin_A_R.AnimationSpeed = 0.03!
        Me.BtnPin_A_R.BackColor = System.Drawing.Color.Transparent
        Me.BtnPin_A_R.BaseColor = System.Drawing.Color.White
        Me.BtnPin_A_R.BorderColor = System.Drawing.Color.Black
        Me.BtnPin_A_R.BorderSize = 1
        Me.BtnPin_A_R.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPin_A_R.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPin_A_R.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPin_A_R.ForeColor = System.Drawing.Color.Black
        Me.BtnPin_A_R.Image = Nothing
        Me.BtnPin_A_R.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPin_A_R.Location = New System.Drawing.Point(127, 78)
        Me.BtnPin_A_R.Name = "BtnPin_A_R"
        Me.BtnPin_A_R.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPin_A_R.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPin_A_R.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPin_A_R.OnHoverImage = Nothing
        Me.BtnPin_A_R.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPin_A_R.Radius = 6
        Me.BtnPin_A_R.Size = New System.Drawing.Size(135, 39)
        Me.BtnPin_A_R.TabIndex = 24
        Me.BtnPin_A_R.Text = "Remover"
        Me.BtnPin_A_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPregunta_A_R
        '
        Me.LblPregunta_A_R.AutoSize = True
        Me.LblPregunta_A_R.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPregunta_A_R.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblPregunta_A_R.Location = New System.Drawing.Point(3, 49)
        Me.LblPregunta_A_R.Name = "LblPregunta_A_R"
        Me.LblPregunta_A_R.Size = New System.Drawing.Size(356, 17)
        Me.LblPregunta_A_R.TabIndex = 5
        Me.LblPregunta_A_R.Text = "¿Está usted seguro de que quiere eliminar este síntoma?"
        '
        'LblSympt
        '
        Me.LblSympt.AutoSize = True
        Me.LblSympt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSympt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblSympt.Location = New System.Drawing.Point(280, 34)
        Me.LblSympt.Name = "LblSympt"
        Me.LblSympt.Size = New System.Drawing.Size(0, 15)
        Me.LblSympt.TabIndex = 4
        '
        'LblElimBody
        '
        Me.LblElimBody.AutoSize = True
        Me.LblElimBody.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblElimBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblElimBody.Location = New System.Drawing.Point(142, 32)
        Me.LblElimBody.Name = "LblElimBody"
        Me.LblElimBody.Size = New System.Drawing.Size(132, 17)
        Me.LblElimBody.TabIndex = 3
        Me.LblElimBody.Text = "Eliminar el síntoma:"
        '
        'Lbl1_A_R
        '
        Me.Lbl1_A_R.AutoSize = True
        Me.Lbl1_A_R.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1_A_R.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Lbl1_A_R.Location = New System.Drawing.Point(3, 32)
        Me.Lbl1_A_R.Name = "Lbl1_A_R"
        Me.Lbl1_A_R.Size = New System.Drawing.Size(143, 17)
        Me.Lbl1_A_R.TabIndex = 2
        Me.Lbl1_A_R.Text = "Usted está a punto de"
        '
        'LblAttention_A_R
        '
        Me.LblAttention_A_R.AutoSize = True
        Me.LblAttention_A_R.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAttention_A_R.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAttention_A_R.Location = New System.Drawing.Point(3, 2)
        Me.LblAttention_A_R.Name = "LblAttention_A_R"
        Me.LblAttention_A_R.Size = New System.Drawing.Size(120, 30)
        Me.LblAttention_A_R.TabIndex = 1
        Me.LblAttention_A_R.Text = "ATENCIÓN"
        '
        'FrmAlertRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 156)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAlertRemove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBody As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents LblEliminar As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl1_A_R As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblAttention_A_R As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblElimBody As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSympt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblPregunta_A_R As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnPin_A_R As Guna.UI.WinForms.GunaButton
    Friend WithEvents TxtPin As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PicVector As PictureBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
End Class
