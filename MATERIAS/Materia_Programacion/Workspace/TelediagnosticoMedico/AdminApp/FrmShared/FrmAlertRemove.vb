Imports Data
Imports Logic
Public Class FrmAlertRemove
    Dim log As New Logic.Logic
    Dim NameX As String = ""
    Dim id As Integer = 0
    Public Shared idSympt As Integer = 0
    Public Shared idPath As Integer = 0
    Public Shared idAdmin As Integer = 0

    Public Sub Obtain(s As String, i As Integer)
        NameX = s
        id = i
    End Sub
    Private Sub FrmAlertRemoveSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSympt.Text = NameX
    End Sub

    Private Sub BtnPin_Click(sender As Object, e As EventArgs) Handles BtnPin.Click
        If TxtPin.Text.Trim.Length = 0 Then
            MessageBox.Show("Campos vacios")
        Else
            If FrmLogin.AdminLog.pin.ToString().Equals(TxtPin.Text) Then
                Console.WriteLine("----PIN CORRECTO----")
                If id = 0 Then
                    DeleteSymptom()
                ElseIf id = 1 Then
                    DeletePath()
                ElseIf id = 2 Then
                    DeleteAdmin()
                End If
            Else
                Console.WriteLine("----PIN INCORRECTO----")
                MessageBox.Show("Pin incorrecto")
            End If
        End If
    End Sub

    Public Sub DeleteAdmin()
        Try
            log.DeleteAdmin(idAdmin)
            MessageBox.Show(NameX & " eliminado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeleteSymptom()
        Try
            log.DeleteSymptoms(idSympt)
            MessageBox.Show(NameX & " eliminado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeletePath()
        Try
            log.DeletePathology(idPath)
            MessageBox.Show(NameX & " eliminado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPin.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class