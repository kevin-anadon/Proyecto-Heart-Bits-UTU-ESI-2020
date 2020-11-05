<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblInfoText_P_L = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicbxLogin = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnLogin_P_L = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtCredential1 = New System.Windows.Forms.TextBox()
        Me.BtnForeText1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlInfo = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCloseInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.LblNotification = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblTitle2_P_L = New System.Windows.Forms.Label()
        Me.LblTitle1_P_L = New System.Windows.Forms.Label()
        Me.RbnEng = New Guna.UI.WinForms.GunaImageRadioButton()
        Me.RbnSpanish = New Guna.UI.WinForms.GunaImageRadioButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbxLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(682, 330)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 8)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'LblInfoText_P_L
        '
        Me.LblInfoText_P_L.AccessibleDescription = "LblInfoText_P_L"
        Me.LblInfoText_P_L.AccessibleName = "LblInfoText_P_L"
        Me.LblInfoText_P_L.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInfoText_P_L.BackColor = System.Drawing.Color.Transparent
        Me.LblInfoText_P_L.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInfoText_P_L.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoText_P_L.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblInfoText_P_L.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInfoText_P_L.Location = New System.Drawing.Point(679, 223)
        Me.LblInfoText_P_L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfoText_P_L.Name = "LblInfoText_P_L"
        Me.LblInfoText_P_L.Size = New System.Drawing.Size(316, 105)
        Me.LblInfoText_P_L.TabIndex = 14
        Me.LblInfoText_P_L.Text = resources.GetString("LblInfoText_P_L.Text")
        Me.LblInfoText_P_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(779, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PicbxLogin
        '
        Me.PicbxLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicbxLogin.Image = CType(resources.GetObject("PicbxLogin.Image"), System.Drawing.Image)
        Me.PicbxLogin.Location = New System.Drawing.Point(0, 0)
        Me.PicbxLogin.Name = "PicbxLogin"
        Me.PicbxLogin.Size = New System.Drawing.Size(619, 640)
        Me.PicbxLogin.TabIndex = 11
        Me.PicbxLogin.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(697, 420)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(730, 430)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(5, 6)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 18
        Me.Guna2PictureBox2.TabStop = False
        '
        'BtnLogin_P_L
        '
        Me.BtnLogin_P_L.AccessibleDescription = "BtnLogin_P_L"
        Me.BtnLogin_P_L.AccessibleName = "BtnLogin_P_L"
        Me.BtnLogin_P_L.Animated = True
        Me.BtnLogin_P_L.BorderRadius = 10
        Me.BtnLogin_P_L.CheckedState.Parent = Me.BtnLogin_P_L
        Me.BtnLogin_P_L.CustomImages.Parent = Me.BtnLogin_P_L
        Me.BtnLogin_P_L.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin_P_L.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin_P_L.ForeColor = System.Drawing.Color.White
        Me.BtnLogin_P_L.HoverState.Parent = Me.BtnLogin_P_L
        Me.BtnLogin_P_L.Location = New System.Drawing.Point(683, 470)
        Me.BtnLogin_P_L.Name = "BtnLogin_P_L"
        Me.BtnLogin_P_L.ShadowDecoration.Parent = Me.BtnLogin_P_L
        Me.BtnLogin_P_L.Size = New System.Drawing.Size(312, 45)
        Me.BtnLogin_P_L.TabIndex = 1
        Me.BtnLogin_P_L.Text = "INICIAR SESIÓN"
        '
        'TxtCredential1
        '
        Me.TxtCredential1.AccessibleDescription = "TxtCredential1"
        Me.TxtCredential1.AccessibleName = "TxtCredential1"
        Me.TxtCredential1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCredential1.BackColor = System.Drawing.Color.White
        Me.TxtCredential1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCredential1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!)
        Me.TxtCredential1.ForeColor = System.Drawing.Color.Black
        Me.TxtCredential1.Location = New System.Drawing.Point(741, 423)
        Me.TxtCredential1.MaxLength = 8
        Me.TxtCredential1.Name = "TxtCredential1"
        Me.TxtCredential1.Size = New System.Drawing.Size(242, 19)
        Me.TxtCredential1.TabIndex = 0
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
        Me.BtnForeText1.Location = New System.Drawing.Point(684, 410)
        Me.BtnForeText1.Name = "BtnForeText1"
        Me.BtnForeText1.PressedDepth = 0
        Me.BtnForeText1.ShadowDecoration.Parent = Me.BtnForeText1
        Me.BtnForeText1.Size = New System.Drawing.Size(312, 45)
        Me.BtnForeText1.TabIndex = 19
        '
        'PnlInfo
        '
        Me.PnlInfo.AccessibleDescription = "PnlInfo"
        Me.PnlInfo.AccessibleName = "PnlInfo"
        Me.PnlInfo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlInfo.BorderRadius = 20
        Me.PnlInfo.BorderThickness = 4
        Me.PnlInfo.Controls.Add(Me.BtnCloseInfo)
        Me.PnlInfo.Controls.Add(Me.LblNotification)
        Me.PnlInfo.Location = New System.Drawing.Point(635, 588)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.ShadowDecoration.Parent = Me.PnlInfo
        Me.PnlInfo.Size = New System.Drawing.Size(404, 81)
        Me.PnlInfo.TabIndex = 20
        '
        'BtnCloseInfo
        '
        Me.BtnCloseInfo.AccessibleDescription = "BtnCloseInfo"
        Me.BtnCloseInfo.AccessibleName = "BtnCloseInfo"
        Me.BtnCloseInfo.BorderRadius = 2
        Me.BtnCloseInfo.CheckedState.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.CustomImages.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.BtnCloseInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCloseInfo.ForeColor = System.Drawing.Color.White
        Me.BtnCloseInfo.HoverState.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.Location = New System.Drawing.Point(364, 13)
        Me.BtnCloseInfo.Name = "BtnCloseInfo"
        Me.BtnCloseInfo.ShadowDecoration.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.Size = New System.Drawing.Size(29, 29)
        Me.BtnCloseInfo.TabIndex = 2
        Me.BtnCloseInfo.Text = "X"
        '
        'LblNotification
        '
        Me.LblNotification.AccessibleDescription = "LblNotification"
        Me.LblNotification.AccessibleName = "LblNotification"
        Me.LblNotification.AutoSize = False
        Me.LblNotification.BackColor = System.Drawing.Color.Transparent
        Me.LblNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotification.Location = New System.Drawing.Point(14, 13)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(344, 31)
        Me.LblNotification.TabIndex = 1
        Me.LblNotification.Text = "LblNotification"
        Me.LblNotification.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle2_P_L
        '
        Me.LblTitle2_P_L.AccessibleDescription = "LblTitle2_P_L"
        Me.LblTitle2_P_L.AccessibleName = "LblTitle2_P_L"
        Me.LblTitle2_P_L.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle2_P_L.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle2_P_L.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle2_P_L.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle2_P_L.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle2_P_L.Location = New System.Drawing.Point(676, 190)
        Me.LblTitle2_P_L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle2_P_L.Name = "LblTitle2_P_L"
        Me.LblTitle2_P_L.Size = New System.Drawing.Size(316, 27)
        Me.LblTitle2_P_L.TabIndex = 22
        Me.LblTitle2_P_L.Text = "NUEVAMENTE."
        Me.LblTitle2_P_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle1_P_L
        '
        Me.LblTitle1_P_L.AccessibleDescription = "LblTitle1_P_L"
        Me.LblTitle1_P_L.AccessibleName = "LblTitle1_P_L"
        Me.LblTitle1_P_L.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle1_P_L.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1_P_L.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1_P_L.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle1_P_L.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1_P_L.Location = New System.Drawing.Point(676, 159)
        Me.LblTitle1_P_L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle1_P_L.Name = "LblTitle1_P_L"
        Me.LblTitle1_P_L.Size = New System.Drawing.Size(316, 27)
        Me.LblTitle1_P_L.TabIndex = 21
        Me.LblTitle1_P_L.Text = "GUSTO EN VERLO "
        Me.LblTitle1_P_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RbnEng
        '
        Me.RbnEng.ImageCheckedOff = Global.PatientApp.My.Resources.Resources.Eng
        Me.RbnEng.ImageCheckedOn = Global.PatientApp.My.Resources.Resources.Eng_Selected
        Me.RbnEng.ImageSize = New System.Drawing.Size(20, 20)
        Me.RbnEng.Location = New System.Drawing.Point(994, 12)
        Me.RbnEng.Name = "RbnEng"
        Me.RbnEng.Size = New System.Drawing.Size(24, 24)
        Me.RbnEng.TabIndex = 23
        '
        'RbnSpanish
        '
        Me.RbnSpanish.Checked = True
        Me.RbnSpanish.ImageCheckedOff = Global.PatientApp.My.Resources.Resources.Es
        Me.RbnSpanish.ImageCheckedOn = Global.PatientApp.My.Resources.Resources.Es_Selected
        Me.RbnSpanish.ImageSize = New System.Drawing.Size(20, 20)
        Me.RbnSpanish.Location = New System.Drawing.Point(1024, 12)
        Me.RbnSpanish.Name = "RbnSpanish"
        Me.RbnSpanish.Size = New System.Drawing.Size(24, 24)
        Me.RbnSpanish.TabIndex = 24
        '
        'FrmLogin
        '
        Me.AccessibleDescription = "FrmLogin"
        Me.AccessibleName = "FrmLogin"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PatientApp.My.Resources.Resources.Login__Type_2
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.RbnSpanish)
        Me.Controls.Add(Me.RbnEng)
        Me.Controls.Add(Me.LblTitle2_P_L)
        Me.Controls.Add(Me.LblTitle1_P_L)
        Me.Controls.Add(Me.PnlInfo)
        Me.Controls.Add(Me.TxtCredential1)
        Me.Controls.Add(Me.BtnLogin_P_L)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblInfoText_P_L)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicbxLogin)
        Me.Controls.Add(Me.BtnForeText1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telediagnóstico Médico: PatientApp."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbxLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents LblInfoText_P_L As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicbxLogin As PictureBox
    Friend WithEvents TxtCredential1 As TextBox
    Friend WithEvents BtnLogin_P_L As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnForeText1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlInfo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCloseInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblNotification As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents LblTitle2_P_L As Label
    Public WithEvents LblTitle1_P_L As Label
    Friend WithEvents RbnSpanish As Guna.UI.WinForms.GunaImageRadioButton
    Friend WithEvents RbnEng As Guna.UI.WinForms.GunaImageRadioButton
End Class
