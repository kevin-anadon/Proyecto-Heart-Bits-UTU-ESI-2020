Imports System.Runtime.InteropServices
Imports Persistencia

Public Class FrmAlertRemove
    Dim Nom As String = Nothing
    Dim id As Integer = 0
    Dim db As New ConnectionDB()

    Public Sub Obtain(s As String, i As Integer)
        Nom = s
        id = i
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
                If id = 0 Then
                    Dim frm As New FrmSympt()
                    frm.DeleteSympt(Nom)
                Else
                    Dim frm As New FrmPath()
                    frm.DeletePath(Nom)
                End If
            End If
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAlertRemoveSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSympt.Text = Nom
    End Sub
End Class