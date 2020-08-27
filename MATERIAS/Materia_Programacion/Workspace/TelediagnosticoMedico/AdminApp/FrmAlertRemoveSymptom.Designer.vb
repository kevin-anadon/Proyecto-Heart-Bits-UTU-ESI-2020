<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlertRemoveSymptom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlertRemoveSymptom))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.PicVector = New System.Windows.Forms.PictureBox()
        Me.TxtPin = New Guna.UI.WinForms.GunaTextBox()
        Me.BtnPin = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.LblSympt = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelTop.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.LightGray
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.GunaLabel1)
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(433, 32)
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
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(219, 30)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "ELIMINAR SÍNTOMA"
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.White
        Me.PanelBody.Controls.Add(Me.GunaLabel6)
        Me.PanelBody.Controls.Add(Me.PicVector)
        Me.PanelBody.Controls.Add(Me.TxtPin)
        Me.PanelBody.Controls.Add(Me.BtnPin)
        Me.PanelBody.Controls.Add(Me.GunaLabel5)
        Me.PanelBody.Controls.Add(Me.LblSympt)
        Me.PanelBody.Controls.Add(Me.GunaLabel4)
        Me.PanelBody.Controls.Add(Me.GunaLabel3)
        Me.PanelBody.Controls.Add(Me.GunaLabel2)
        Me.PanelBody.Location = New System.Drawing.Point(0, 33)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(433, 124)
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
        Me.TxtPin.TabIndex = 25
        Me.TxtPin.TextOffsetX = 5
        '
        'BtnPin
        '
        Me.BtnPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPin.Animated = True
        Me.BtnPin.AnimationHoverSpeed = 0.07!
        Me.BtnPin.AnimationSpeed = 0.03!
        Me.BtnPin.BackColor = System.Drawing.Color.Transparent
        Me.BtnPin.BaseColor = System.Drawing.Color.White
        Me.BtnPin.BorderColor = System.Drawing.Color.Black
        Me.BtnPin.BorderSize = 1
        Me.BtnPin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnPin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnPin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPin.ForeColor = System.Drawing.Color.Black
        Me.BtnPin.Image = Nothing
        Me.BtnPin.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnPin.Location = New System.Drawing.Point(129, 81)
        Me.BtnPin.Name = "BtnPin"
        Me.BtnPin.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnPin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnPin.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnPin.OnHoverImage = Nothing
        Me.BtnPin.OnPressedColor = System.Drawing.Color.Black
        Me.BtnPin.Radius = 6
        Me.BtnPin.Size = New System.Drawing.Size(135, 39)
        Me.BtnPin.TabIndex = 24
        Me.BtnPin.Text = "Remover"
        Me.BtnPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(3, 49)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(356, 17)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "¿Está usted seguro de que quiere eliminar este síntoma?"
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
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(142, 32)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(132, 17)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "Eliminar el síntoma:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 32)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(143, 17)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Usted está a punto de"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 2)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(120, 30)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "ATENCIÓN"
        '
        'FrmAlertRemoveSymptom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 156)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAlertRemoveSymptom"
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
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSympt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnPin As Guna.UI.WinForms.GunaButton
    Friend WithEvents TxtPin As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PicVector As PictureBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
End Class
