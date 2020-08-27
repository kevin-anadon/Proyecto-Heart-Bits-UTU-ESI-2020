Public Class FrmSplashScreen
    Private sesion As Integer

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrgbarLoad.Value = 0.0
        PrgbarLoad.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sesion < 100 Then
            PrgbarLoad.Value = sesion
            sesion = sesion + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            'FrmLogin.Show()
        End If
    End Sub
End Class
