Imports Logic
Imports Data
Public Class FrmLogin 'Empleado Medico
    'Atributos
    Private ReadOnly L1 As New Logic.Controller()
    Private ci As String = Nothing
    Public Shared Property MedicLogged As New Data.Medic()


    'Comportamiento
    Private Sub ShowNotification(msj As String, red As Integer, green As Integer, blue As Integer)
        PnlInfo.BorderColor = Color.FromArgb(red, green, blue)
        LblNotification.Text = msj
    End Sub
    Private Sub IdentifyPreset(preset As Integer)
        Select Case preset
            Case 1 'Validando las Credenciales / En espera.
                ShowNotification(Translator.Instance.Translate("CheckingFields"), 255, 208, 52)
            Case 2 'Logeo Exitoso.
                ShowNotification(Translator.Instance.Translate("SuccessLogin"), 98, 186, 172)
            Case 3 'Error de Conexión.
                ShowNotification(Translator.Instance.Translate("ConnectionFailed"), 251, 136, 133)
            Case 4 'Cédula de identidad errónea.
                ShowNotification(Translator.Instance.Translate("UserOrPassWrong"), 251, 136, 133)
        End Select
    End Sub
    Private Function LoginMedic(user As String, passwd As String) As Data.Medic
        Return L1.LoginMedic(user, passwd)
    End Function
    Private Function InfoEmployeeLogged(user As String, passwd As String) As Data.Medic
        Dim preset As Short = L1.InfoEmployeeLogged(user, passwd)

        IdentifyPreset(preset)

        If preset = 2 Then
            Return LoginMedic(user, passwd)
        Else
            Return Nothing
        End If
    End Function


    'Eventos
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlInfo.Visible = False
        LblNotification.Text = " "
        PnlInfo.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin_M_L.Click
        PnlInfo.Visible = True

        If TxtCredUser.Text.Trim.Length = 0 Or TxtCredPass.Text.Trim.Length = 0 Then 'Verifico si hay algun espacio vacio en las credenciales
            Me.ShowNotification(Translator.Instance.Translate("HayCamposVacios"), 255, 208, 52) 'Notifico al usuario.
        Else 'No hay Espacio vacio
            Try
                MedicLogged = Me.InfoEmployeeLogged(TxtCredUser.Text.ToString(), TxtCredPass.Text.ToString())
                If Not IsNothing(MedicLogged) Then
                    'Se actualizan los datos del Medico que se veran en pantalla utilizando el objeto MedicLogged
                    FrmHome.MedicName = MedicLogged.fstName & " " & MedicLogged.scndName & " " & MedicLogged.fstSurname & " " & MedicLogged.scndSurname
                    FrmHome.Ci = MedicLogged.CiScript(MedicLogged.ci)
                    FrmHome.Age = MedicLogged.CalcAge(MedicLogged.dateBirth).ToString()
                    FrmHome.Email = MedicLogged.email
                    FrmHome.Phone = MedicLogged.numPhone.ToString()
                    FrmHome.Connect = Translator.Instance.Translate("UserInfoHome_A_H") & MedicLogged.username + " " + Translator.Instance.Translate("UserInfoHomeCon_A_H") & TimeOfDay.Hour.ToString() & ":" & TimeOfDay.Minute.ToString() & ":" & TimeOfDay.Millisecond.ToString() & "."

                    FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                    Me.Close() 'Cierro el Frame de "LoginEmployee".
                End If
            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub
    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredPass.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin_M_L.PerformClick()
        End If
    End Sub
    Private Sub TxtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredUser.KeyDown
        'Utilizable a modo de pruebas, luego para la version final se quitará
        If e.KeyCode = Keys.K AndAlso e.Modifiers = Keys.Control Then
            TxtCredUser.Text = "jul59"
            TxtCredPass.Text = "681nlo"
            BtnLogin_M_L.PerformClick()
        End If
    End Sub
    Private Sub BtnCloseInfo_Click(sender As Object, e As EventArgs) Handles BtnCloseInfo.Click
        PnlInfo.Visible = False
    End Sub

    Private Sub RbnEng_CheckedChanged(sender As Object, e As EventArgs) Handles RbnEng.CheckedChanged
        Translator.Instance.LoadLanguage("English")
        Translator.Instance.TranslateForm(Me)
        BtnCloseInfo.Text = "X"
    End Sub

    Private Sub RbnSpanish_CheckedChanged(sender As Object, e As EventArgs) Handles RbnSpanish.CheckedChanged
        Translator.Instance.LoadLanguage("Spanish")
        Translator.Instance.TranslateForm(Me)
        BtnCloseInfo.Text = "X"
    End Sub
End Class 'FrmLogin