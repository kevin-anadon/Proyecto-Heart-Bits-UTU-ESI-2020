Imports System.Runtime.InteropServices
Imports Data
Imports Logic
Public Class FrmAlertRemove
    Dim log As New Logica
    Dim Name As String = ""
    Dim id As Integer = 0
    Public Shared idSympt As Integer = 0
    Public Shared idPath As Integer = 0

    Public Sub Obtain(s As String, i As Integer)
        Name = s
        id = i
    End Sub

    Private Sub BtnPin_Click(sender As Object, e As EventArgs) Handles BtnPin.Click
        If TxtPin.Text.Trim.Length = 0 Then
            MessageBox.Show("Campos vacios")
        Else
            If FrmLogin.AdminLog.pin.ToString().Equals(TxtPin.Text) Then
                Console.WriteLine("----PIN CORRECTO----")
                If id = 0 Then
                    DeleteSymptom()
                Else
                    DeletePath()
                End If
            Else
                Console.WriteLine("----PIN INCORRECTO----")
                MessageBox.Show("Pin incorrecto")
            End If
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAlertRemoveSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSympt.Text = Name
    End Sub

    Public Sub DeleteSymptom()
        Try
            log.DeleteSymptoms(idSympt)
            MessageBox.Show(Name & " eliminado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DeletePath()
        Try
            log.DeletePathology(idPath)
            MessageBox.Show(Name & " eliminado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class