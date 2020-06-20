<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.lbxCities = New System.Windows.Forms.ListBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lbxCities
        '
        Me.lbxCities.AccessibleDescription = "lbxCities"
        Me.lbxCities.AccessibleName = "lbxCities"
        Me.lbxCities.FormattingEnabled = True
        Me.lbxCities.Location = New System.Drawing.Point(12, 12)
        Me.lbxCities.Name = "lbxCities"
        Me.lbxCities.Size = New System.Drawing.Size(120, 95)
        Me.lbxCities.TabIndex = 0
        '
        'cbxDepartment
        '
        Me.cbxDepartment.AccessibleDescription = "Combobox"
        Me.cbxDepartment.AccessibleName = "cbxDepartment"
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Items.AddRange(New Object() {"Canelones", "Maldonado", "Montevideo"})
        Me.cbxDepartment.Location = New System.Drawing.Point(12, 113)
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cbxDepartment.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(138, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(229, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(298, 160)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(433, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'FrmHome
        '
        Me.AccessibleDescription = "Form"
        Me.AccessibleName = "FrmHome"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 415)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxDepartment)
        Me.Controls.Add(Me.lbxCities)
        Me.Name = "FrmHome"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxCities As ListBox
    Friend WithEvents cbxDepartment As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
