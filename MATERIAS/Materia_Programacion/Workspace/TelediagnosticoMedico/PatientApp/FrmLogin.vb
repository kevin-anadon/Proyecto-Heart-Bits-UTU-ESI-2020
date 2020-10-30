Imports Data
Imports Logic

Public Class FrmLogin 'Paciente
    'Atributos
    Private ReadOnly L1 As New Logic.Controller()
    Public ciPatientLoggedOn As String = Nothing


    'Comportamenientos:
    Private Sub ShowNotification(msj As String, red As Integer, green As Integer, blue As Integer)
        PnlInfo.BorderColor = Color.FromArgb(red, green, blue)
        LblNotification.Text = msj
    End Sub
    Private Sub IdentifyPreset(preset As Integer)
        Select Case preset
            Case 1 'Validando las Credenciales / En espera.
                ShowNotification("Validando C.I.", 255, 208, 52)
            Case 2 'Logeo Exitoso.
                ShowNotification("Inicio de sesión exitoso.", 98, 186, 172)
            Case 3 'Error de Conexión.
                ShowNotification("Conexión fallida. Intentado recopilar datos...", 251, 136, 133)
            Case 4 'Cédula de identidad errónea.
                ShowNotification("Cédula de identidad errónea.", 251, 136, 133)
            Case 5 'Paciente inhabilitado.
                ShowNotification("No se encuentra habilitado.", 255, 208, 52)
        End Select
    End Sub

    'Eventos:
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin_P_L.Click
        PnlInfo.Visible = True
        If TxtCredential1.Text.Trim.Length = 0 Then 'Verifico si hay algun espacio vacio
            Me.ShowNotification("Hay algún campo vacío. Ingrese alguna C.I.", 255, 208, 52) 'Notifico al usuario.
        Else 'No hay Espacio vacio
            Dim preset As Short = L1.LoginPatient(TxtCredential1.Text)
            IdentifyPreset(preset) 'Notifico al usuario.

            If preset = 2 Then
                Me.ciPatientLoggedOn = TxtCredential1.Text
                FrmHome.ciPatientLoggedOn = Me.ciPatientLoggedOn 'Envío la CI del paciente que se logeó al atributo del FrmHome.
                FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                Me.Close() 'Cierro el Frame de "LoginPatient".
            End If
        End If
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlInfo.Visible = False
        LblNotification.Text = " "
        PnlInfo.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
    End Sub
    Private Sub TxtCredential1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCredential1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCredential1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredential1.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin_P_L.PerformClick()
        End If
    End Sub
    Private Sub TxtCredential1_Enter(sender As Object, e As EventArgs) Handles TxtCredential1.Enter
        TxtCredential1.Clear()
    End Sub
    Private Sub BtnCloseInfo_Click(sender As Object, e As EventArgs) Handles BtnCloseInfo.Click
        PnlInfo.Visible = False
    End Sub
End Class 'FrmLogin

