Imports System.Runtime.InteropServices
Imports Persistencia
Imports Data

Public Class FrmLogin
    Private connectionDB As New ConnectionDB() 'Mi conexión
    Private inidicatorToolBtn As Short = 0 'Me define que Mensaje debo de utilizar en el ToolTip.
    ReadOnly user As String = Nothing
    ReadOnly pass As String = Nothing

    'Comportamenientos:
    ''' <summary>
    ''' Permite establecer un ToolTip a los Botones necesarios.
    ''' </summary>
    ''' <param name="myToolTip">El ToolTip que usaremos para trabajar.</param>
    ''' <param name="btnReference">El botón que tendrá el ToolTip.</param>
    ''' <param name="num">Índice que permite escoger el Mensaje que se mostrará en el ToolTip.</param>
    Public Sub ToolTipSetMessage(ByVal myToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip, ByVal btnReference As Guna.UI2.WinForms.Guna2Button, ByVal num As Short)
        'Trabajo con el ToolTip:
        myToolTip.RemoveAll()
        Select Case num 'Controlo los mensajes que puedo mostrar en mi ToolTip.
            Case 0 'Error de Campo vacío.
                myToolTip.SetToolTip(btnReference, "Error de campo vacio. Ingrese las Credenciales para continuar.")
            Case 1 'Validando las Credenciales / En espera.
                myToolTip.SetToolTip(btnReference, "Validando credenciales.")
            Case 2 'Error de Autenticación.
                myToolTip.SetToolTip(btnReference, "Credenciales ingresada, inválida.")
        End Select
        myToolTip.InitialDelay = 10000
        myToolTip.IsBalloon = False
    End Sub

    'Eventos:
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtCredential1.Text.Trim.Length = 0 Then
            'Se trabaja con la UI.
            BtnForeText.CustomBorderColor = Color.FromArgb(1, 251, 136, 133) 'Color Corál = Error
            Me.inidicatorToolBtn = 0
        Else
            'Se trabaja con la UI.
            BtnForeText.CustomBorderColor = Color.FromArgb(1, 255, 208, 52) 'Color Mostaza = En espera / Cuidado 
            Me.inidicatorToolBtn = 1

            Try
                Dim rslog As People = connectionDB.CheckLog(user, pass, TxtCredential1.Text)
                If IsNothing(rslog) Then
                    Console.WriteLine("Ci Erronea")
                    'Se trabaja con la UI.
                    BtnForeText.CustomBorderColor = Color.FromArgb(1, 251, 136, 133) 'Color Corál = Error
                    Me.inidicatorToolBtn = 2
                Else
                    Console.WriteLine("Logueo exitoso")
                    BtnForeText.CustomBorderColor = Color.FromArgb(1, 98, 186, 172) 'Color Turquesa = Correcto 
                    Me.Hide() 'Cierro el Frame de "Login".
                    FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                End If

            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnForeText.Enabled = True 'El Boton permanece encendido.
    End Sub

    Private Sub BtnForeText_MouseEnter(sender As Object, e As EventArgs) Handles BtnForeText.MouseEnter
        ToolTipSetMessage(ToolTipMsgError, BtnForeText, Me.inidicatorToolBtn)
        'inidicatorToolBtn = 0 = Error de Campo vacío.
        'inidicatorToolBtn = 1 = Validando las Credenciales / En espera.
        'inidicatorToolBtn = 2 = Error de Autenticación
    End Sub

    Private Sub TxtCredential1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCredential1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class

