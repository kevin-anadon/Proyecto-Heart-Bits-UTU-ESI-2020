<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PicInfo = New System.Windows.Forms.PictureBox()
        Me.PicLogin = New System.Windows.Forms.PictureBox()
        Me.ChkRememberUser = New System.Windows.Forms.CheckBox()
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicInfo
        '
        Me.PicInfo.Image = CType(resources.GetObject("PicInfo.Image"), System.Drawing.Image)
        Me.PicInfo.Location = New System.Drawing.Point(0, 0)
        Me.PicInfo.Name = "PicInfo"
        Me.PicInfo.Size = New System.Drawing.Size(618, 648)
        Me.PicInfo.TabIndex = 1
        Me.PicInfo.TabStop = False
        '
        'PicLogin
        '
        Me.PicLogin.Image = CType(resources.GetObject("PicLogin.Image"), System.Drawing.Image)
        Me.PicLogin.Location = New System.Drawing.Point(618, 0)
        Me.PicLogin.Name = "PicLogin"
        Me.PicLogin.Size = New System.Drawing.Size(443, 640)
        Me.PicLogin.TabIndex = 2
        Me.PicLogin.TabStop = False
        '
        'ChkRememberUser
        '
        Me.ChkRememberUser.AccessibleDescription = "CheckBox"
        Me.ChkRememberUser.AccessibleName = "ChkRememberUser"
        Me.ChkRememberUser.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChkRememberUser.AutoSize = True
        Me.ChkRememberUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChkRememberUser.Checked = True
        Me.ChkRememberUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRememberUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkRememberUser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkRememberUser.Location = New System.Drawing.Point(681, 475)
        Me.ChkRememberUser.MaximumSize = New System.Drawing.Size(40, 40)
        Me.ChkRememberUser.MinimumSize = New System.Drawing.Size(15, 15)
        Me.ChkRememberUser.Name = "ChkRememberUser"
        Me.ChkRememberUser.Size = New System.Drawing.Size(15, 15)
        Me.ChkRememberUser.TabIndex = 3
        Me.ChkRememberUser.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AccessibleName = "FrmLogin"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.ChkRememberUser)
        Me.Controls.Add(Me.PicLogin)
        Me.Controls.Add(Me.PicInfo)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicInfo As PictureBox
    Friend WithEvents PicLogin As PictureBox
    Friend WithEvents ChkRememberUser As CheckBox
End Class
