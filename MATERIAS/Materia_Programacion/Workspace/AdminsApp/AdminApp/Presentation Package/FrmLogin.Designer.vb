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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PicbxMiddleImage = New System.Windows.Forms.PictureBox()
        CType(Me.PicbxMiddleImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicbxMiddleImage
        '
        Me.PicbxMiddleImage.AccessibleDescription = "PicbxMiddleImage"
        Me.PicbxMiddleImage.AccessibleName = "PicbxMiddleImage"
        Me.PicbxMiddleImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicbxMiddleImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicbxMiddleImage.Image = CType(resources.GetObject("PicbxMiddleImage.Image"), System.Drawing.Image)
        Me.PicbxMiddleImage.Location = New System.Drawing.Point(-1, -3)
        Me.PicbxMiddleImage.Name = "PicbxMiddleImage"
        Me.PicbxMiddleImage.Size = New System.Drawing.Size(675, 810)
        Me.PicbxMiddleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbxMiddleImage.TabIndex = 0
        Me.PicbxMiddleImage.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicbxMiddleImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicbxMiddleImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents PicbxMiddleImage As PictureBox
End Class
