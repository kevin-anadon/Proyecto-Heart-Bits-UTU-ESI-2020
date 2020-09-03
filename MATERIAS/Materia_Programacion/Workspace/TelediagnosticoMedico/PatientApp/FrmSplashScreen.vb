Public Class FrmSplashScreen
    Dim instancia As Integer

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrgbarLoadSplashScreen.Value = 0.0
        PrgbarLoadSplashScreen.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If instancia < 100 Then
            PrgbarLoadSplashScreen.Value = instancia
            instancia += 1
        Else
            Timer1.Enabled = False
            Me.Dispose() 'Este formulario "SplashScreen" se cierra.
            FrmLogin.Show() 'Este formulario se mostrará en pantalla.
        End If

    End Sub
End Class