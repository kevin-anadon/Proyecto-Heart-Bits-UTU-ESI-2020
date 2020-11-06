Imports Logic
Imports Data
Public Class FrmLogin
    Dim log As New Logic.Controller()
    Public Shared Property AdminLog As New Admin()
    Dim ci As String = Nothing

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
            Case 4 'Usuario y/o contraseña erroneo.
                ShowNotification(Translator.Instance.Translate("UserOrPassWrong"), 251, 136, 133)
        End Select
    End Sub
    Private Function LoginAdmin(user As String, passwd As String) As Data.Admin
        Try
            Dim adm As Admin = log.LoginAdmin(user, passwd)
            IdentifyPreset(1)

            If Not IsNothing(adm) Then
                IdentifyPreset(2)
                Return adm
            Else
                IdentifyPreset(4)
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Eventos
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlInfo.Visible = False
        LblNotification.Text = " "
        PnlInfo.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin_A_L.Click
        PnlInfo.Visible = True

        If TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Then 'Verifico si hay algun espacio vacio en las credenciales
            Me.ShowNotification(Translator.Instance.Translate("HayCamposVacios"), 255, 208, 52) 'Notifico al usuario.
        Else 'No hay Espacio vacio
            Try
                AdminLog = Me.LoginAdmin(TxtUser.Text.ToString(), TxtPass.Text.ToString())
                If Not IsNothing(AdminLog) Then
                    'Se actualizan los datos del Medico que se veran en pantalla utilizando el objeto AdminLog
                    FrmHome.AdmName = AdminLog.fstName & " " & AdminLog.scndName & " " & AdminLog.fstSurname & " " & AdminLog.scndSurname
                    FrmHome.Ci = AdminLog.CiScript(AdminLog.ci)
                    FrmHome.Age = AdminLog.CalcAge(AdminLog.dateBirth).ToString()
                    FrmHome.Email = AdminLog.email
                    FrmHome.Phone = AdminLog.numPhone.ToString()
                    FrmHome.Connect = Translator.Instance.Translate("UserInfoHome_A_H") & AdminLog.username + " " + Translator.Instance.Translate("UserInfoHomeCon_A_H") + TimeOfDay.Hour.ToString() & ":" & TimeOfDay.Minute.ToString() & ":" & TimeOfDay.Millisecond.ToString() & "."

                    FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
                    Me.Close() 'Cierro el Frame de "LoginEmployee".
                End If
            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin_A_L.PerformClick()
        End If
    End Sub
    Private Sub BtnCloseInfo_Click(sender As Object, e As EventArgs) Handles BtnCloseInfo.Click
        PnlInfo.Visible = False
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit_A_L.Click
        If MsgBox(Translator.Instance.Translate("MsgExit"), MsgBoxStyle.YesNoCancel, Translator.Instance.Translate("CloseProgram_M_H")) = MsgBoxResult.Yes Then
            End
        End If
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
End Class