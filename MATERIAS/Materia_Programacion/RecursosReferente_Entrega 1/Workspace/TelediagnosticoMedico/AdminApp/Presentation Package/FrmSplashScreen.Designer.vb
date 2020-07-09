<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplashScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicbxLogoCAS = New System.Windows.Forms.PictureBox()
        Me.LblTitle1 = New System.Windows.Forms.Label()
        Me.PrgbarLoadSplashScreen = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.LblTitle2 = New System.Windows.Forms.Label()
        Me.LblTitle3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicbxLogoCAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "LblSystemInfo1"
        Me.Label1.AccessibleName = "LblSystemInfo1"
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(-1, 766)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1349, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema: Sistema de Gestión para Administradores."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = "LblSystemInfo1"
        Me.Label2.AccessibleName = "LblSystemInfo1"
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-1, 744)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1349, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Versión del Sistema: V1.0.1 Alpha."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PicbxLogoCAS
        '
        Me.PicbxLogoCAS.AccessibleDescription = "PicbxLogoCAS"
        Me.PicbxLogoCAS.AccessibleName = "PicbxLogoCAS"
        Me.PicbxLogoCAS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicbxLogoCAS.BackColor = System.Drawing.Color.Transparent
        Me.PicbxLogoCAS.Image = CType(resources.GetObject("PicbxLogoCAS.Image"), System.Drawing.Image)
        Me.PicbxLogoCAS.Location = New System.Drawing.Point(174, 260)
        Me.PicbxLogoCAS.Name = "PicbxLogoCAS"
        Me.PicbxLogoCAS.Size = New System.Drawing.Size(250, 250)
        Me.PicbxLogoCAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbxLogoCAS.TabIndex = 2
        Me.PicbxLogoCAS.TabStop = False
        '
        'LblTitle1
        '
        Me.LblTitle1.AccessibleDescription = "LblTitle1"
        Me.LblTitle1.AccessibleName = "LblTitle1"
        Me.LblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1.Location = New System.Drawing.Point(430, 246)
        Me.LblTitle1.Name = "LblTitle1"
        Me.LblTitle1.Size = New System.Drawing.Size(689, 130)
        Me.LblTitle1.TabIndex = 3
        Me.LblTitle1.Text = "CENTRO DE ATENCIÓN DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SALUD MÉDICA"
        Me.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrgbarLoadSplashScreen
        '
        Me.PrgbarLoadSplashScreen.AccessibleDescription = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.AccessibleName = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.BorderRadius = 8
        Me.PrgbarLoadSplashScreen.FillColor = System.Drawing.Color.LightGray
        Me.PrgbarLoadSplashScreen.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrgbarLoadSplashScreen.Location = New System.Drawing.Point(441, 478)
        Me.PrgbarLoadSplashScreen.Name = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoadSplashScreen.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoadSplashScreen.ShadowDecoration.Parent = Me.PrgbarLoadSplashScreen
        Me.PrgbarLoadSplashScreen.Size = New System.Drawing.Size(638, 17)
        Me.PrgbarLoadSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PrgbarLoadSplashScreen.TabIndex = 5
        Me.PrgbarLoadSplashScreen.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PrgbarLoadSplashScreen.Value = 98
        '
        'LblTitle2
        '
        Me.LblTitle2.AccessibleDescription = "LblTitle2"
        Me.LblTitle2.AccessibleName = "LblTitle2"
        Me.LblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblTitle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle2.Location = New System.Drawing.Point(435, 359)
        Me.LblTitle2.Name = "LblTitle2"
        Me.LblTitle2.Size = New System.Drawing.Size(644, 73)
        Me.LblTitle2.TabIndex = 6
        Me.LblTitle2.Text = "SISTEMA DE TELEDIAGNÓSTICO MÉDICO"
        Me.LblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle3
        '
        Me.LblTitle3.AccessibleDescription = "LblTitle3"
        Me.LblTitle3.AccessibleName = "LblTitle3"
        Me.LblTitle3.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTitle3.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTitle3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitle3.Location = New System.Drawing.Point(438, 418)
        Me.LblTitle3.Name = "LblTitle3"
        Me.LblTitle3.Size = New System.Drawing.Size(641, 24)
        Me.LblTitle3.TabIndex = 7
        Me.LblTitle3.Text = "Generando conexión con la Base de Datos."
        Me.LblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = "LblTitle3"
        Me.Label3.AccessibleName = "LblTitle3"
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(438, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(641, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Conexión exitosa. Cargando formularios."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 508)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 10)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FrmSplashScreen
        '
        Me.AccessibleDescription = "FrmSplashScreen"
        Me.AccessibleName = "FrmSplashScreen"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTitle3)
        Me.Controls.Add(Me.PrgbarLoadSplashScreen)
        Me.Controls.Add(Me.PicbxLogoCAS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitle1)
        Me.Controls.Add(Me.LblTitle2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicbxLogoCAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents PicbxLogoCAS As PictureBox
    Friend WithEvents LblTitle1 As Label
    Friend WithEvents PrgbarLoadSplashScreen As Guna.UI2.WinForms.Guna2ProgressBar
    Public WithEvents LblTitle2 As Label
    Public WithEvents LblTitle3 As Label
    Public WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
