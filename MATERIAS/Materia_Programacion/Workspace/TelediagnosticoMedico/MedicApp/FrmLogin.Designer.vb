<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtCredPass = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lblbody = New System.Windows.Forms.Label()
        Me.LblTitle1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnForeText1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PicbxLogin = New System.Windows.Forms.PictureBox()
        Me.TxtCredUser = New System.Windows.Forms.TextBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbxLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCredPass
        '
        Me.TxtCredPass.AccessibleDescription = "TxtCredPass"
        Me.TxtCredPass.AccessibleName = "TxtCredPass"
        Me.TxtCredPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCredPass.BackColor = System.Drawing.Color.White
        Me.TxtCredPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCredPass.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!)
        Me.TxtCredPass.ForeColor = System.Drawing.Color.Black
        Me.TxtCredPass.Location = New System.Drawing.Point(747, 450)
        Me.TxtCredPass.MaxLength = 8
        Me.TxtCredPass.Name = "TxtCredPass"
        Me.TxtCredPass.Size = New System.Drawing.Size(242, 19)
        Me.TxtCredPass.TabIndex = 20
        '
        'BtnLogin
        '
        Me.BtnLogin.AccessibleDescription = "BtnLogin"
        Me.BtnLogin.AccessibleName = "BtnLogin"
        Me.BtnLogin.Animated = True
        Me.BtnLogin.BorderRadius = 10
        Me.BtnLogin.CheckedState.Parent = Me.BtnLogin
        Me.BtnLogin.CustomImages.Parent = Me.BtnLogin
        Me.BtnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.HoverState.Parent = Me.BtnLogin
        Me.BtnLogin.Location = New System.Drawing.Point(689, 497)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(312, 45)
        Me.BtnLogin.TabIndex = 21
        Me.BtnLogin.Text = "INICIAR SESIÓN"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(736, 457)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(5, 6)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 27
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.MedicApp.My.Resources.Resources.mdi_vpn_key
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(703, 447)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.Guna2PictureBox1.TabIndex = 26
        Me.Guna2PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MedicApp.My.Resources.Resources.Lines
        Me.PictureBox2.Location = New System.Drawing.Point(693, 335)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 8)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Lblbody
        '
        Me.Lblbody.AccessibleDescription = "LblTitle3"
        Me.Lblbody.AccessibleName = "LblTitle3"
        Me.Lblbody.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lblbody.BackColor = System.Drawing.Color.Transparent
        Me.Lblbody.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lblbody.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Lblbody.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lblbody.Location = New System.Drawing.Point(690, 250)
        Me.Lblbody.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblbody.Name = "Lblbody"
        Me.Lblbody.Size = New System.Drawing.Size(311, 83)
        Me.Lblbody.TabIndex = 24
        Me.Lblbody.Text = "Ingrese su usuario y contraseña " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para autenticar y verificar sus credenciales." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Este Software le permitirá tratar a sus Pacientes, brindándoles a estos, informa" &
    "ción para concluir un Tele Diagnóstico."
        Me.Lblbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle1
        '
        Me.LblTitle1.AccessibleDescription = "LblTitle2"
        Me.LblTitle1.AccessibleName = "LblTitle2"
        Me.LblTitle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1.Location = New System.Drawing.Point(689, 185)
        Me.LblTitle1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle1.Name = "LblTitle1"
        Me.LblTitle1.Size = New System.Drawing.Size(313, 65)
        Me.LblTitle1.TabIndex = 23
        Me.LblTitle1.Text = "GUSTO EN VERLO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NUEVAMENTE."
        Me.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.MedicApp.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(779, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'BtnForeText1
        '
        Me.BtnForeText1.AccessibleDescription = "BtnForeText"
        Me.BtnForeText1.AccessibleName = "BtnForeText"
        Me.BtnForeText1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnForeText1.BorderRadius = 10
        Me.BtnForeText1.BorderThickness = 2
        Me.BtnForeText1.CheckedState.Parent = Me.BtnForeText1
        Me.BtnForeText1.CustomImages.Parent = Me.BtnForeText1
        Me.BtnForeText1.FillColor = System.Drawing.Color.Transparent
        Me.BtnForeText1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnForeText1.ForeColor = System.Drawing.Color.Transparent
        Me.BtnForeText1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BtnForeText1.HoverState.Parent = Me.BtnForeText1
        Me.BtnForeText1.Location = New System.Drawing.Point(690, 437)
        Me.BtnForeText1.Name = "BtnForeText1"
        Me.BtnForeText1.PressedDepth = 0
        Me.BtnForeText1.ShadowDecoration.Parent = Me.BtnForeText1
        Me.BtnForeText1.Size = New System.Drawing.Size(312, 45)
        Me.BtnForeText1.TabIndex = 28
        '
        'PicbxLogin
        '
        Me.PicbxLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicbxLogin.Image = CType(resources.GetObject("PicbxLogin.Image"), System.Drawing.Image)
        Me.PicbxLogin.Location = New System.Drawing.Point(0, 0)
        Me.PicbxLogin.Name = "PicbxLogin"
        Me.PicbxLogin.Size = New System.Drawing.Size(619, 640)
        Me.PicbxLogin.TabIndex = 29
        Me.PicbxLogin.TabStop = False
        '
        'TxtCredUser
        '
        Me.TxtCredUser.AccessibleDescription = "TxtCredUser"
        Me.TxtCredUser.AccessibleName = "TxtCredUser"
        Me.TxtCredUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCredUser.BackColor = System.Drawing.Color.White
        Me.TxtCredUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCredUser.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!)
        Me.TxtCredUser.ForeColor = System.Drawing.Color.Black
        Me.TxtCredUser.Location = New System.Drawing.Point(747, 399)
        Me.TxtCredUser.MaxLength = 8
        Me.TxtCredUser.Name = "TxtCredUser"
        Me.TxtCredUser.Size = New System.Drawing.Size(242, 19)
        Me.TxtCredUser.TabIndex = 30
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(736, 406)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(5, 6)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox3.TabIndex = 32
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.Image = Global.MedicApp.My.Resources.Resources.Vector
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(705, 399)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.ShadowDecoration.Parent = Me.Guna2PictureBox4
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(18, 18)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox4.TabIndex = 31
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AccessibleDescription = "BtnForeText"
        Me.Guna2Button1.AccessibleName = "BtnForeText"
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(690, 386)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(312, 45)
        Me.Guna2Button1.TabIndex = 33
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmLogin
        '
        Me.AccessibleDescription = "FrmLogin"
        Me.AccessibleName = "FrmLogin"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MedicApp.My.Resources.Resources.Panel__Type_1
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtCredUser)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox4)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PicbxLogin)
        Me.Controls.Add(Me.TxtCredPass)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Lblbody)
        Me.Controls.Add(Me.LblTitle1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnForeText1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telediagnóstico Médico: MedicApp."
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbxLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCredPass As TextBox
    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents Lblbody As Label
    Public WithEvents LblTitle1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnForeText1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PicbxLogin As PictureBox
    Friend WithEvents TxtCredUser As TextBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
