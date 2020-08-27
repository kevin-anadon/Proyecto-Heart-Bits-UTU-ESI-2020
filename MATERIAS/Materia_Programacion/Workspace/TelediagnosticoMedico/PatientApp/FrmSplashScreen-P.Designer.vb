<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplashScreen))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PrgbarLoad = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PrgbarLoad
        '
        Me.PrgbarLoad.AccessibleDescription = "PrgbarLoad"
        Me.PrgbarLoad.AccessibleName = "PrgbarLoad"
        Me.PrgbarLoad.AutoRoundedCorners = True
        Me.PrgbarLoad.BackColor = System.Drawing.Color.Transparent
        Me.PrgbarLoad.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoad.BorderRadius = 6
        Me.PrgbarLoad.BorderThickness = 2
        Me.PrgbarLoad.FillColor = System.Drawing.Color.Transparent
        Me.PrgbarLoad.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrgbarLoad.Location = New System.Drawing.Point(361, 353)
        Me.PrgbarLoad.Name = "PrgbarLoad"
        Me.PrgbarLoad.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoad.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoad.ShadowDecoration.Parent = Me.PrgbarLoad
        Me.PrgbarLoad.Size = New System.Drawing.Size(411, 14)
        Me.PrgbarLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PrgbarLoad.TabIndex = 0
        Me.PrgbarLoad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PrgbarLoad.Value = 28
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(153, 204)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(185, 185)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Lbl1
        '
        Me.Lbl1.AccessibleDescription = "Lbl1"
        Me.Lbl1.AccessibleName = "Lbl1"
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Lbl1.Location = New System.Drawing.Point(350, 204)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl1.Size = New System.Drawing.Size(410, 90)
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.Text = "CENTRO DE ATENCIÓN DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SALUD MÉDICA."
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(361, 377)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(88, 12)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox2.TabIndex = 3
        Me.Guna2PictureBox2.TabStop = False
        '
        'Lbl2
        '
        Me.Lbl2.AccessibleDescription = "Lbl2"
        Me.Lbl2.AccessibleName = "Lbl2"
        Me.Lbl2.AutoSize = True
        Me.Lbl2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Lbl2.Location = New System.Drawing.Point(353, 292)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl2.Size = New System.Drawing.Size(419, 29)
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "SISTEMA DE TELEDIAGNÓSTICO MÉDICO."
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl3
        '
        Me.Lbl3.AccessibleDescription = "Lbl3"
        Me.Lbl3.AccessibleName = "Lbl3"
        Me.Lbl3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Lbl3.Location = New System.Drawing.Point(358, 324)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl3.Size = New System.Drawing.Size(414, 13)
        Me.Lbl3.TabIndex = 6
        Me.Lbl3.Text = "Generando conexión con la Base de Datos."
        '
        'LblInfo
        '
        Me.LblInfo.AccessibleDescription = "LblInfo"
        Me.LblInfo.AccessibleName = "LblInfo"
        Me.LblInfo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo.Location = New System.Drawing.Point(358, 337)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblInfo.Size = New System.Drawing.Size(414, 13)
        Me.LblInfo.TabIndex = 5
        Me.LblInfo.Text = "ASD"
        Me.LblInfo.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(478, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(510, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Versión del Sistema: 1.0.1 Alpha."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(478, 564)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(510, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Sistema: Sistema de Consulta para Pacientes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        '
        'FrmSplashScreen
        '
        Me.AccessibleDescription = "FrmSplashScreen-P"
        Me.AccessibleName = "FrmSplashScreen-P"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PrgbarLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSplashScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PrgbarLoad As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents LblInfo As Label
    Friend WithEvents Timer1 As Timer
End Class
