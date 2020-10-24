Imports Logic
Imports Data

Public Class FrmLogin
    Dim log As New Logic.Controller()
    Public Shared Property AdminLog As New Admin()
    Dim ci As String = Nothing

    Private Sub Cerrar()
        If MsgBox("Está seguro que desea cerrar ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Cerrar()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establecer conexión a la base de datos

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Then
            MessageBox.Show("Campos vacios!")
        Else
            Try
                AdminLog = log.LoginAdmin(TxtUser.Text.ToString(), TxtPass.Text.ToString())
                Console.WriteLine("--------------------EXISTEEE------------------")
                Me.Hide()
                'Se actualizan los datos del administrador que se veran en pantalla utilizando el objeto AdminLog
                FrmHome.AdmName = AdminLog.fstName & " " & AdminLog.scndName & " " & AdminLog.fstSurname & " " & AdminLog.scndSurname
                FrmHome.Ci = AdminLog.CiScript(AdminLog.ci)
                FrmHome.Age = AdminLog.CalcAge(AdminLog.dateBirth).ToString()
                FrmHome.Email = AdminLog.email
                FrmHome.Phone = AdminLog.numPhone.ToString()
                FrmHome.Connect = "Usuario " & AdminLog.username & " conectado a las " & TimeOfDay.Hour.ToString() & ":" & TimeOfDay.Minute.ToString() & ":" & TimeOfDay.Millisecond.ToString() & "."
                FrmHome.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub TxtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUser.KeyDown
        'Utilizable a modo de pruebas, luego para la version final se quitará
        If e.KeyCode = Keys.K AndAlso e.Modifiers = Keys.Control Then
            TxtUser.Text = "mel64"
            TxtPass.Text = "84ulkc"
            BtnLogin.PerformClick()
        End If
    End Sub
End Class