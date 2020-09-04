Public Class Form1
    Private Dim inidicatorToolBtn As Short = 0


    Public Sub ToolTipSetMessage(ByVal myToolTip As ToolTip, ByVal btnReference As Guna.UI2.WinForms.Guna2Button, ByVal num As Short)
        'Trabajo con el ToolTip:
        myToolTip.RemoveAll()
        Select Case num 'Controlo los mensajes que puedo mostrar en mi ToolTip.
            Case 0 'Error de Campo vacío.
                myToolTip.SetToolTip(btnReference, "Error de campo vacio. Ingrese las Credenciales para continuar.")
                BtnMsg.CustomBorderColor = Color.FromArgb(1, 251, 136, 133) 'Color Corál = Error
            Case 1 'Validando las Credenciales / En espera.
                myToolTip.SetToolTip(btnReference, "Validando credenciales.")
                BtnMsg.CustomBorderColor = Color.FromArgb(1, 255, 208, 52) 'Color Mostaza = En espera / Cuidado 
            Case 2 'Error de Autenticación.
                myToolTip.SetToolTip(btnReference, "Credenciales ingresada, inválida.")
                BtnMsg.CustomBorderColor = Color.FromArgb(1, 98, 186, 172) 'Color Turquesa = Correcto 
        End Select
        myToolTip.InitialDelay = 10000
        myToolTip.IsBalloon = False
    End Sub



    Private Sub BtnMsg_MouseEnter(sender As Object, e As EventArgs) Handles BtnMsg.MouseEnter
        Guna2HtmlToolTip1.SetToolTip(BtnMsg, "Hello there")
    End Sub

    Private Sub BtnMsg0_Click(sender As Object, e As EventArgs) Handles BtnMsg0.Click
        BtnMsg.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
    End Sub

    Private Sub BtnMsg1_Click(sender As Object, e As EventArgs) Handles BtnMsg1.Click
        BtnMsg.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado 
    End Sub

    Private Sub BtnMsg2_Click(sender As Object, e As EventArgs) Handles BtnMsg2.Click
        BtnMsg.BorderColor = Color.FromArgb(98, 186, 172) 'Color Turquesa = Correcto 
    End Sub
End Class
