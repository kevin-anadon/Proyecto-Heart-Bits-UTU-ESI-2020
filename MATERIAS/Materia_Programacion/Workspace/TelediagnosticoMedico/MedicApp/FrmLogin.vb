Imports Logic
Imports Data
Public Class FrmLogin
    Dim log As New Logic.Logic()
    Public Shared Property MedicLog As New Medic()
    Dim ci As String = Nothing

    'Private Sub Cerrar()
    '    If MsgBox("Está seguro que desea cerrar ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
    '        End
    '    End If
    'End Sub

    'Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
    '    Cerrar()
    'End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establecer conexión a la base de datos

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtCredUser.Text.Trim.Length = 0 Or TxtCredPass.Text.Trim.Length = 0 Then
            MessageBox.Show("Campos vacios!")
        Else
            Try
                MedicLog = log.LoginMedic(TxtCredUser.Text.ToString(), TxtCredPass.Text.ToString())
                Console.WriteLine("--------------------EXISTEEE------------------")
                Me.Hide()
                'Se actualizan los datos del administrador que se veran en pantalla utilizando el objeto AdminLog
                FrmHome.MedicName = MedicLog.fstName & " " & MedicLog.scndName & " " & MedicLog.fstSurname & " " & MedicLog.scndSurname
                FrmHome.Ci = MedicLog.CiScript(MedicLog.ci)
                FrmHome.Age = MedicLog.CalcAge(MedicLog.dateBirth).ToString()
                FrmHome.Email = MedicLog.email
                FrmHome.Phone = MedicLog.numPhone.ToString()
                FrmHome.Connect = "Usuario " & MedicLog.username & " conectado a las " & TimeOfDay.Hour.ToString() & ":" & TimeOfDay.Minute.ToString() & ":" & TimeOfDay.Millisecond.ToString() & "."
                FrmHome.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Console.WriteLine("ERROR: " & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredPass.KeyDown
        'Detectar si presiona enter, que accione el botón Iniciar Sesión
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub TxtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCredUser.KeyDown
        'Utilizable a modo de pruebas, luego para la version final se quitará
        If e.KeyCode = Keys.K AndAlso e.Modifiers = Keys.Control Then
            TxtCredUser.Text = "jul59"
            TxtCredPass.Text = "681nlo"
            BtnLogin.PerformClick()
        End If
    End Sub

End Class