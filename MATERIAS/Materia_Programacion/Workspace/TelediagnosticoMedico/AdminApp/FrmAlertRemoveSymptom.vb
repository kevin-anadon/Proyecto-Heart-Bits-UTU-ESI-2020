Imports System.Runtime.InteropServices
Imports Persistencia

Public Class FrmAlertRemoveSymptom
    Dim Sympt As String = Nothing
    Dim db As New ConnectionDB()

    Public Sub ObtainSympt(s As String)
        Sympt = s
    End Sub

    Private Sub BtnPin_Click(sender As Object, e As EventArgs) Handles BtnPin.Click
        If TxtPin.Text.Trim.Length = 0 Then
            MessageBox.Show("CAMPOS VACIOS!!")
        Else
            Dim rsPin As Boolean = db.CheckPin(TxtPin.Text.ToString())
            If rsPin = False Then
                Console.WriteLine("PIN INCORRECTO")
                MessageBox.Show("PIN Incorrecto!!")
            Else
                Console.WriteLine("----------------PIN CORRECTO--------------")
                MessageBox.Show("Eliminado con exito!!")
                Me.Close()
                Dim frm As New FrmSympt()
                frm.DeleteSympt(Sympt)
            End If
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAlertRemoveSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSympt.Text = Sympt
    End Sub
End Class