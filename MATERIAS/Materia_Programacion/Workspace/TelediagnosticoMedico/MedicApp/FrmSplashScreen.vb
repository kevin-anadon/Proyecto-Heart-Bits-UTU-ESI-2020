Imports Logic

Public Class FrmSplashScreen
    Private record As Integer
    Private LQuery As New Controller()
    Private resultConnection As Boolean = False
    Private msgConnection As String = Nothing

    'Comportamientos
    Private Sub IdentifyMessage()
        Try
            LQuery.TryConnection()
            LblTitle4.Text = "Conexión exitosa. Iniciando el sistema."
            resultConnection = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            LblTitle4.Text = ex.Message
        End Try
    End Sub

    'Eventos
    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdentifyMessage()
        PrgbarLoadSplashScreen.Value = 0.0
        PrgbarLoadSplashScreen.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If resultConnection = True Then
            If record < 100 Then
                PrgbarLoadSplashScreen.Value = record
                record += 1
            Else
                Timer1.Enabled = False
                Me.Hide() 'Este formulario "SplashScreen" se cierra.
                FrmLogin.Show() 'Este formulario se mostrará en pantalla.
            End If
        End If
    End Sub



End Class 'FrmSplashScreen