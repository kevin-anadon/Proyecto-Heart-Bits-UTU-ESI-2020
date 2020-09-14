Imports System.Runtime.InteropServices
Imports Persistencia
Imports Data

Public Class FrmLogin
    Private connectionDB As New ConnectionDB()
    Public ciPatientLoggedOn As String = Nothing
    Private indicatorToolBtn As Short = 90 'Me define que Mensaje debo de utilizar en el ToolTip.
    Private ReadOnly user As String = Nothing
    Private ReadOnly pass As String = Nothing

    'Comportamenientos:


    'Eventos:
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtCredential1.Text.Trim.Length = 0 Then
            'Se trabaja con la UI.
            Me.indicatorToolBtn = 0
        Else
            'Se trabaja con la UI.
            Me.indicatorToolBtn = 1
            Try
                Dim rslog As People = connectionDB.CheckLog(user, pass, TxtCredential1.Text)
                If IsNothing(rslog) Then
                    'Se trabaja con la UI.
                    Me.indicatorToolBtn = 0
                Else
                    Me.indicatorToolBtn = 2
                    Me.ciPatientLoggedOn = TxtCredential1.Text
                    FrmHome.ciPatientLoggedOn = Me.ciPatientLoggedOn 'Envío la CI del paciente que se logeó al atributo del FrmHome.
                    FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                    Me.Close() 'Cierro el Frame de "Login".
                End If

            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.ToString())
                Me.indicatorToolBtn = 3
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

    Private Sub TxtCredential1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredential1.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub TxtCredential1_Enter(sender As Object, e As EventArgs) Handles TxtCredential1.Enter
        TxtCredential1.Clear()
    End Sub

    Private Sub BtnForeText1_MouseEnter(sender As Object, e As EventArgs) Handles BtnForeText1.MouseEnter
        Select Case indicatorToolBtn 'Controlo los mensajes que puedo mostrar en mi ToolTip.
            Case 0 'Error de Campo vacío.
                BtnForeText1.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado 
                ToolTipMsgError.SetToolTip(BtnForeText1, "Hay algún campo vacío. Ingrese alguna C.I.")
            Case 1 'Validando las Credenciales / En espera.
                BtnForeText1.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado 
                ToolTipMsgError.SetToolTip(BtnForeText1, "Validando C.I.")
            Case 2 'Logeo Exitoso.
                BtnForeText1.BorderColor = Color.FromArgb(98, 186, 172) 'Color Turquesa = Correcto 
                ToolTipMsgError.SetToolTip(BtnForeText1, "Inicio de sesión exitoso.")
            Case 3 'Error de Conexión.
                BtnForeText1.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
                ToolTipMsgError.SetToolTip(BtnForeText1, "Conexión fallida. Intentado recopilar datos...")
            Case 4 'Cédula de identidad errónea.
                BtnForeText1.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
                ToolTipMsgError.SetToolTip(BtnForeText1, "Cédula de identidad errónea.")
            Case 5 'Paciente inhabilitado.
                BtnForeText1.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado
                ToolTipMsgError.SetToolTip(BtnForeText1, "No se encuentra habilitado.")
            Case Else
                BtnForeText1.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
                ToolTipMsgError.SetToolTip(BtnForeText1, "Introduzca su credencial.")
        End Select
    End Sub


End Class 'FrmLogin

