Imports System.Runtime.InteropServices
Imports Persistencia
Imports Data

Public Class FrmLogin
    Private connectionDB As New ConnectionDB() 'Mi conexión
    Private inidicatorToolBtn As Short = 90 'Me define que Mensaje debo de utilizar en el ToolTip.
    Private ReadOnly user As String = Nothing
    Private ReadOnly pass As String = Nothing

    'Comportamenientos:


    'Eventos:
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtCredential1.Text.Trim.Length = 0 Then
            'Se trabaja con la UI.
            BtnForeText1.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
            Me.inidicatorToolBtn = 0
        Else
            'Se trabaja con la UI.
            BtnForeText1.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado 
            Me.inidicatorToolBtn = 1

            Try
                Dim rslog As People = connectionDB.CheckLog(user, pass, TxtCredential1.Text)
                If IsNothing(rslog) Then
                    Console.WriteLine("Ci Erronea")
                    'Se trabaja con la UI.
                    BtnForeText1.CustomBorderColor = Color.FromArgb(1, 251, 136, 133) 'Color Corál = Error
                    Me.inidicatorToolBtn = 0
                Else
                    Console.WriteLine("Logueo exitoso")
                    BtnForeText1.BorderColor = Color.FromArgb(98, 186, 172) 'Color Turquesa = Correcto 
                    Me.inidicatorToolBtn = 2
                    Me.Hide() 'Cierro el Frame de "Login".
                    FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                End If

            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnForeText1.Enabled = True 'El Boton permanece encendido.
        BtnForeText1.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
    End Sub

    Private Sub TxtCredential1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCredential1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnForeText1_MouseEnter(sender As Object, e As EventArgs) Handles BtnForeText1.MouseEnter
        Select Case inidicatorToolBtn 'Controlo los mensajes que puedo mostrar en mi ToolTip.
            Case 0 'Error de Campo vacío.
                ToolTipMsgError.SetToolTip(BtnForeText1, "Error de campo vacio. Ingrese las Credenciales para continuar.")
            Case 1 'Validando las Credenciales / En espera.
                ToolTipMsgError.SetToolTip(BtnForeText1, "Validando credenciales.")
            Case 2 'Error de Autenticación.
                ToolTipMsgError.SetToolTip(BtnForeText1, "Credenciales ingresada, inválida.")
            Case Else
                BtnForeText1.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
                ToolTipMsgError.SetToolTip(BtnForeText1, "Introduzca su credencial.")
        End Select
    End Sub
End Class 'FrmLogin

