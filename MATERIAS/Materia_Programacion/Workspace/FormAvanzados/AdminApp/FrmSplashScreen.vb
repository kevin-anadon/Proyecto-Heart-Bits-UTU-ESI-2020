Imports System.Runtime.InteropServices
Public Class FrmSplashScreen
    Dim account As Integer

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrgbarLoadSplashScreen.Value = 0.0
        PrgbarLoadSplashScreen.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True

        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
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

End Class