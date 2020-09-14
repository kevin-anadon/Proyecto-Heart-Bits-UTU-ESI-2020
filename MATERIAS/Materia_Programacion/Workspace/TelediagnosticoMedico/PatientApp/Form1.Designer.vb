<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        '
        'BtnLogin
        '
        Me.BtnLogin.AccessibleDescription = "BtnLogin"
        Me.BtnLogin.AccessibleName = "BtnLogin"
        Me.BtnLogin.Animated = True
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
        Me.BtnLogin.Location = New System.Drawing.Point(480, 567)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(313, 53)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "INICIAR SESIÓN"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(632, 18)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 740)
        Me.Guna2VSeparator1.TabIndex = 4
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 3
        Me.Guna2Panel1.Location = New System.Drawing.Point(480, 40)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(313, 511)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1270, 770)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testing Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
