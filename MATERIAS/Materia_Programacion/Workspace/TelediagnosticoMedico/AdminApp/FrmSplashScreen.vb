Public Class FrmSplashScreen
    Dim account As Integer

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrgbarLoadSplashScreen.Value = 0.0
        PrgbarLoadSplashScreen.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If account < 100 Then
            PrgbarLoadSplashScreen.Value = account
            account += 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            FrmLogin.Show()
        End If

    End Sub

End Class 'FrmSplashScreen