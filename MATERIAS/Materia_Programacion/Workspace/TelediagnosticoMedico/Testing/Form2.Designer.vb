<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.GpbxMsgList = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.RdbtnFailC = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RdbtnWhiteS = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RdbtnCredentialF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RdbtnLoginC = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.PblLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PnlInfo = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCloseInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.LblInfo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GpbxMsgList.SuspendLayout()
        Me.PblLogin.SuspendLayout()
        Me.PnlInfo.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.AccessibleDescription = "BtnLogin"
        Me.BtnLogin.AccessibleName = "BtnLogin"
        Me.BtnLogin.Animated = True
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.BorderRadius = 25
        Me.BtnLogin.BorderThickness = 3
        Me.BtnLogin.CheckedState.Parent = Me.BtnLogin
        Me.BtnLogin.CustomImages.Parent = Me.BtnLogin
        Me.BtnLogin.FillColor = System.Drawing.Color.White
        Me.BtnLogin.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.HoverState.Parent = Me.BtnLogin
        Me.BtnLogin.Location = New System.Drawing.Point(471, 620)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(313, 55)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "INICIAR SESIÓN"
        '
        'GpbxMsgList
        '
        Me.GpbxMsgList.AccessibleDescription = "GpbxMsgList"
        Me.GpbxMsgList.AccessibleName = "GpbxMsgList"
        Me.GpbxMsgList.BackColor = System.Drawing.Color.Transparent
        Me.GpbxMsgList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GpbxMsgList.BorderRadius = 20
        Me.GpbxMsgList.BorderThickness = 4
        Me.GpbxMsgList.Controls.Add(Me.RdbtnFailC)
        Me.GpbxMsgList.Controls.Add(Me.RdbtnWhiteS)
        Me.GpbxMsgList.Controls.Add(Me.RdbtnCredentialF)
        Me.GpbxMsgList.Controls.Add(Me.RdbtnLoginC)
        Me.GpbxMsgList.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GpbxMsgList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GpbxMsgList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GpbxMsgList.Location = New System.Drawing.Point(30, 21)
        Me.GpbxMsgList.Name = "GpbxMsgList"
        Me.GpbxMsgList.ShadowDecoration.Parent = Me.GpbxMsgList
        Me.GpbxMsgList.Size = New System.Drawing.Size(253, 140)
        Me.GpbxMsgList.TabIndex = 4
        Me.GpbxMsgList.Text = "Listado de mensajes."
        '
        'RdbtnFailC
        '
        Me.RdbtnFailC.AccessibleDescription = "RdbtnFailC"
        Me.RdbtnFailC.AccessibleName = "RdbtnFailC"
        Me.RdbtnFailC.BackColor = System.Drawing.Color.Transparent
        Me.RdbtnFailC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnFailC.CheckedState.BorderThickness = 0
        Me.RdbtnFailC.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnFailC.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdbtnFailC.CheckedState.InnerOffset = -4
        Me.RdbtnFailC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnFailC.Location = New System.Drawing.Point(22, 114)
        Me.RdbtnFailC.Name = "RdbtnFailC"
        Me.RdbtnFailC.Size = New System.Drawing.Size(211, 17)
        Me.RdbtnFailC.TabIndex = 3
        Me.RdbtnFailC.Text = "CONEXION FALLIDA"
        Me.RdbtnFailC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RdbtnFailC.UncheckedState.BorderThickness = 3
        Me.RdbtnFailC.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnFailC.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdbtnFailC.UseVisualStyleBackColor = False
        '
        'RdbtnWhiteS
        '
        Me.RdbtnWhiteS.AccessibleDescription = "RdbtnWhiteS"
        Me.RdbtnWhiteS.AccessibleName = "RdbtnWhiteS"
        Me.RdbtnWhiteS.BackColor = System.Drawing.Color.Transparent
        Me.RdbtnWhiteS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnWhiteS.CheckedState.BorderThickness = 0
        Me.RdbtnWhiteS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnWhiteS.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdbtnWhiteS.CheckedState.InnerOffset = -4
        Me.RdbtnWhiteS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnWhiteS.Location = New System.Drawing.Point(22, 91)
        Me.RdbtnWhiteS.Name = "RdbtnWhiteS"
        Me.RdbtnWhiteS.Size = New System.Drawing.Size(211, 17)
        Me.RdbtnWhiteS.TabIndex = 2
        Me.RdbtnWhiteS.Text = "HAY UN ESPACIO EN BLANCO"
        Me.RdbtnWhiteS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RdbtnWhiteS.UncheckedState.BorderThickness = 3
        Me.RdbtnWhiteS.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnWhiteS.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdbtnWhiteS.UseVisualStyleBackColor = False
        '
        'RdbtnCredentialF
        '
        Me.RdbtnCredentialF.AccessibleDescription = "RdbtnCredentialF"
        Me.RdbtnCredentialF.AccessibleName = "RdbtnCredentialF"
        Me.RdbtnCredentialF.BackColor = System.Drawing.Color.Transparent
        Me.RdbtnCredentialF.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnCredentialF.CheckedState.BorderThickness = 0
        Me.RdbtnCredentialF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnCredentialF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdbtnCredentialF.CheckedState.InnerOffset = -4
        Me.RdbtnCredentialF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnCredentialF.Location = New System.Drawing.Point(22, 68)
        Me.RdbtnCredentialF.Name = "RdbtnCredentialF"
        Me.RdbtnCredentialF.Size = New System.Drawing.Size(211, 17)
        Me.RdbtnCredentialF.TabIndex = 1
        Me.RdbtnCredentialF.Text = "CREDENCIALES INCORRECTAS"
        Me.RdbtnCredentialF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RdbtnCredentialF.UncheckedState.BorderThickness = 3
        Me.RdbtnCredentialF.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnCredentialF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdbtnCredentialF.UseVisualStyleBackColor = False
        '
        'RdbtnLoginC
        '
        Me.RdbtnLoginC.AccessibleDescription = "RdbtnLoginC"
        Me.RdbtnLoginC.AccessibleName = "RdbtnLoginC"
        Me.RdbtnLoginC.BackColor = System.Drawing.Color.Transparent
        Me.RdbtnLoginC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnLoginC.CheckedState.BorderThickness = 0
        Me.RdbtnLoginC.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnLoginC.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdbtnLoginC.CheckedState.InnerOffset = -4
        Me.RdbtnLoginC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RdbtnLoginC.Location = New System.Drawing.Point(22, 45)
        Me.RdbtnLoginC.Name = "RdbtnLoginC"
        Me.RdbtnLoginC.Size = New System.Drawing.Size(211, 17)
        Me.RdbtnLoginC.TabIndex = 0
        Me.RdbtnLoginC.Text = "INICIO SESIÓN CORRECTAMENTE"
        Me.RdbtnLoginC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RdbtnLoginC.UncheckedState.BorderThickness = 3
        Me.RdbtnLoginC.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdbtnLoginC.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdbtnLoginC.UseVisualStyleBackColor = False
        '
        'PblLogin
        '
        Me.PblLogin.AccessibleDescription = "PblLogin"
        Me.PblLogin.AccessibleName = "PblLogin"
        Me.PblLogin.BackColor = System.Drawing.Color.Transparent
        Me.PblLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PblLogin.BorderRadius = 20
        Me.PblLogin.BorderThickness = 4
        Me.PblLogin.Controls.Add(Me.GpbxMsgList)
        Me.PblLogin.Location = New System.Drawing.Point(471, 137)
        Me.PblLogin.Name = "PblLogin"
        Me.PblLogin.ShadowDecoration.Parent = Me.PblLogin
        Me.PblLogin.Size = New System.Drawing.Size(313, 464)
        Me.PblLogin.TabIndex = 6
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PnlInfo
        '
        Me.PnlInfo.AccessibleDescription = "PnlInfo"
        Me.PnlInfo.AccessibleName = "PnlInfo"
        Me.PnlInfo.BackColor = System.Drawing.Color.Transparent
        Me.PnlInfo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlInfo.BorderRadius = 20
        Me.PnlInfo.BorderThickness = 4
        Me.PnlInfo.Controls.Add(Me.BtnCloseInfo)
        Me.PnlInfo.Controls.Add(Me.LblInfo)
        Me.PnlInfo.Location = New System.Drawing.Point(394, 681)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.ShadowDecoration.Parent = Me.PnlInfo
        Me.PnlInfo.Size = New System.Drawing.Size(466, 81)
        Me.PnlInfo.TabIndex = 9
        '
        'BtnCloseInfo
        '
        Me.BtnCloseInfo.AccessibleDescription = "BtnCloseInfo"
        Me.BtnCloseInfo.AccessibleName = "BtnCloseInfo"
        Me.BtnCloseInfo.BorderRadius = 2
        Me.BtnCloseInfo.CheckedState.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.CustomImages.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.BtnCloseInfo.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCloseInfo.ForeColor = System.Drawing.Color.White
        Me.BtnCloseInfo.HoverState.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.Location = New System.Drawing.Point(421, 13)
        Me.BtnCloseInfo.Name = "BtnCloseInfo"
        Me.BtnCloseInfo.ShadowDecoration.Parent = Me.BtnCloseInfo
        Me.BtnCloseInfo.Size = New System.Drawing.Size(29, 29)
        Me.BtnCloseInfo.TabIndex = 1
        Me.BtnCloseInfo.Text = "X"
        '
        'LblInfo
        '
        Me.LblInfo.AccessibleDescription = "LblInfo"
        Me.LblInfo.AccessibleName = "LblInfo"
        Me.LblInfo.AutoSize = False
        Me.LblInfo.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo.Font = New System.Drawing.Font("Roboto Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(12, 11)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(403, 31)
        Me.LblInfo.TabIndex = 0
        Me.LblInfo.Text = "Guna2HtmlLabel1"
        Me.LblInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Testing.My.Resources.Resources.LOGO
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(576, 16)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(105, 105)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Testing.My.Resources.Resources.Login__Type_1
        Me.ClientSize = New System.Drawing.Size(1254, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PnlInfo)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.PblLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GpbxMsgList.ResumeLayout(False)
        Me.PblLogin.ResumeLayout(False)
        Me.PnlInfo.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GpbxMsgList As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PblLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents RdbtnLoginC As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RdbtnWhiteS As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RdbtnCredentialF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RdbtnFailC As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents PnlInfo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCloseInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblInfo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
