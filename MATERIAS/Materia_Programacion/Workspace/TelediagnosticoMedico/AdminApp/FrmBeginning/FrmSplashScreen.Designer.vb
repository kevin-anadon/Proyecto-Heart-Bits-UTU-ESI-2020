<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplashScreen))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTitle4 = New System.Windows.Forms.Label()
        Me.LblInfo1_A_SS = New System.Windows.Forms.Label()
        Me.PicbxLogoCAS = New System.Windows.Forms.PictureBox()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.LblTitle1 = New System.Windows.Forms.Label()
        Me.LblTitle2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PrgbarLoadSplashScreen = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbxLogoCAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(378, 412)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 8)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'LblTitle4
        '
        Me.LblTitle4.AccessibleDescription = "LblTitle4"
        Me.LblTitle4.AccessibleName = "LblTitle4"
        Me.LblTitle4.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle4.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTitle4.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTitle4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitle4.Location = New System.Drawing.Point(374, 360)
        Me.LblTitle4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle4.Name = "LblTitle4"
        Me.LblTitle4.Size = New System.Drawing.Size(513, 19)
        Me.LblTitle4.TabIndex = 24
        Me.LblTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInfo1_A_SS
        '
        Me.LblInfo1_A_SS.AccessibleDescription = "LblInfo1_A_SS"
        Me.LblInfo1_A_SS.AccessibleName = "LblInfo1_A_SS"
        Me.LblInfo1_A_SS.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo1_A_SS.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfo1_A_SS.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo1_A_SS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfo1_A_SS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo1_A_SS.Location = New System.Drawing.Point(374, 340)
        Me.LblInfo1_A_SS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo1_A_SS.Name = "LblInfo1_A_SS"
        Me.LblInfo1_A_SS.Size = New System.Drawing.Size(513, 19)
        Me.LblInfo1_A_SS.TabIndex = 23
        Me.LblInfo1_A_SS.Text = "Generando conexión con la Base de Datos."
        Me.LblInfo1_A_SS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicbxLogoCAS
        '
        Me.PicbxLogoCAS.AccessibleDescription = "PicbxLogoCAS"
        Me.PicbxLogoCAS.AccessibleName = "PicbxLogoCAS"
        Me.PicbxLogoCAS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicbxLogoCAS.BackColor = System.Drawing.Color.Transparent
        Me.PicbxLogoCAS.Image = CType(resources.GetObject("PicbxLogoCAS.Image"), System.Drawing.Image)
        Me.PicbxLogoCAS.Location = New System.Drawing.Point(164, 220)
        Me.PicbxLogoCAS.Margin = New System.Windows.Forms.Padding(2)
        Me.PicbxLogoCAS.Name = "PicbxLogoCAS"
        Me.PicbxLogoCAS.Size = New System.Drawing.Size(200, 200)
        Me.PicbxLogoCAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbxLogoCAS.TabIndex = 20
        Me.PicbxLogoCAS.TabStop = False
        '
        'LblInfo1
        '
        Me.LblInfo1.AccessibleDescription = "LblInfo1"
        Me.LblInfo1.AccessibleName = "LblInfo1"
        Me.LblInfo1.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfo1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblInfo1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblInfo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblInfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfo1.Location = New System.Drawing.Point(820, 586)
        Me.LblInfo1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(224, 22)
        Me.LblInfo1.TabIndex = 19
        Me.LblInfo1.Text = "Versión del Sistema: V1.0.1 Alpha."
        Me.LblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInfo2
        '
        Me.LblInfo2.AccessibleDescription = "LblInfo2"
        Me.LblInfo2.AccessibleName = "LblInfo2"
        Me.LblInfo2.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfo2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblInfo2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblInfo2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblInfo2.Location = New System.Drawing.Point(704, 608)
        Me.LblInfo2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(340, 22)
        Me.LblInfo2.TabIndex = 18
        Me.LblInfo2.Text = "Sistema: Sistema de Cliente para Administradores."
        Me.LblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTitle1
        '
        Me.LblTitle1.AccessibleDescription = "LblTitle1"
        Me.LblTitle1.AccessibleName = "LblTitle1"
        Me.LblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LblTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1.Location = New System.Drawing.Point(368, 203)
        Me.LblTitle1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle1.Name = "LblTitle1"
        Me.LblTitle1.Size = New System.Drawing.Size(551, 104)
        Me.LblTitle1.TabIndex = 21
        Me.LblTitle1.Text = "CENTRO DE ATENCIÓN DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SALUD MÉDICA"
        Me.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle2
        '
        Me.LblTitle2.AccessibleDescription = "LblTitle2"
        Me.LblTitle2.AccessibleName = "LblTitle2"
        Me.LblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblTitle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle2.Location = New System.Drawing.Point(372, 293)
        Me.LblTitle2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle2.Name = "LblTitle2"
        Me.LblTitle2.Size = New System.Drawing.Size(515, 58)
        Me.LblTitle2.TabIndex = 22
        Me.LblTitle2.Text = "SISTEMA DE TELEDIAGNÓSTICO MÉDICO"
        Me.LblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PrgbarLoadSplashScreen
        '
        Me.PrgbarLoadSplashScreen.AccessibleDescription = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.AccessibleName = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.AutoRoundedCorners = True
        Me.PrgbarLoadSplashScreen.BackColor = System.Drawing.Color.Transparent
        Me.PrgbarLoadSplashScreen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoadSplashScreen.BorderRadius = 7
        Me.PrgbarLoadSplashScreen.BorderThickness = 2
        Me.PrgbarLoadSplashScreen.FillColor = System.Drawing.Color.Transparent
        Me.PrgbarLoadSplashScreen.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrgbarLoadSplashScreen.Location = New System.Drawing.Point(378, 385)
        Me.PrgbarLoadSplashScreen.Name = "PrgbarLoadSplashScreen"
        Me.PrgbarLoadSplashScreen.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoadSplashScreen.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PrgbarLoadSplashScreen.ShadowDecoration.Parent = Me.PrgbarLoadSplashScreen
        Me.PrgbarLoadSplashScreen.Size = New System.Drawing.Size(509, 16)
        Me.PrgbarLoadSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PrgbarLoadSplashScreen.TabIndex = 26
        Me.PrgbarLoadSplashScreen.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PrgbarLoadSplashScreen.UseTransparentBackground = True
        Me.PrgbarLoadSplashScreen.Value = 80
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 40
        '
        'FrmSplashScreen
        '
        Me.AccessibleDescription = "FrmSplashScreen"
        Me.AccessibleName = "FrmSplashScreen"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.AdminApp.My.Resources.Resources.Login__Type_2
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.PrgbarLoadSplashScreen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTitle4)
        Me.Controls.Add(Me.LblInfo1_A_SS)
        Me.Controls.Add(Me.PicbxLogoCAS)
        Me.Controls.Add(Me.LblInfo1)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblTitle1)
        Me.Controls.Add(Me.LblTitle2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbxLogoCAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents LblTitle4 As Label
    Public WithEvents LblInfo1_A_SS As Label
    Public WithEvents PicbxLogoCAS As PictureBox
    Public WithEvents LblInfo1 As Label
    Private WithEvents LblInfo2 As Label
    Friend WithEvents LblTitle1 As Label
    Public WithEvents LblTitle2 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PrgbarLoadSplashScreen As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
