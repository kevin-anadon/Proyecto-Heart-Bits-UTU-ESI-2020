Imports Data
Imports Logic
Public Class FrmAlertRemove
    Dim log As New Logic.Controller
    Dim NameX As String = ""
    Dim id As Integer = 0
    Public Shared idSympt As Integer = 0
    Public Shared idPath As Integer = 0
    Public Shared idAdmin As Integer = 0
    Public Shared idMedic As Integer = 0
    Public Shared idPatient As Integer = 0

    Public Sub Obtain(s As String, i As Integer)
        NameX = s
        id = i
    End Sub
    Private Sub Identify()
        LblAttention_A_R.Text = Translator.Instance.Translate("LblAttention_A_R")
        Lbl1_A_R.Text = Translator.Instance.Translate("Lbl1_A_R")
        BtnPin_A_R.Text = Translator.Instance.Translate("BtnPin_A_R")
        Select Case id
            Case 0 'Eliminar Sintoma
                LblEliminar.Text = Translator.Instance.Translate("LblEliminarSympt")
                LblElimBody.Text = Translator.Instance.Translate("LblElimBodySympt")
                LblPregunta_A_R.Text = Translator.Instance.Translate("LblPregunta_A_RSympt")
            Case 1 'Eliminar Patología

            Case 2 'Eliminar Administrador

            Case 3 'Eliminar Médico

            Case 4 'Eliminar Paciente

        End Select
    End Sub
    Private Sub FrmAlertRemoveSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSympt.Text = NameX
        Identify() 'Traduzco según el caso
    End Sub

    Private Sub BtnPin_Click(sender As Object, e As EventArgs) Handles BtnPin_A_R.Click
        If TxtPin.Text.Trim.Length = 0 Then
            MessageBox.Show(Translator.Instance.Translate("HayCamposVacios"))
        Else
            If FrmLogin.AdminLog.pin.ToString().Equals(TxtPin.Text) Then
                Console.WriteLine("----PIN CORRECTO----")
                If id = 0 Then
                    DeleteSymptom()
                ElseIf id = 1 Then
                    DeletePath()
                ElseIf id = 2 Then
                    DeleteAdmin()
                ElseIf id = 3 Then
                    DeleteMedic()
                ElseIf id = 4 Then
                    DeletePatient()
                End If
            Else
                Console.WriteLine("----PIN INCORRECTO----")
                MessageBox.Show(Translator.Instance.Translate("WrongPin_A_R"))
            End If
        End If
    End Sub

    Public Sub DeleteAdmin()
        Try
            log.DeleteAdmin(idAdmin)
            MessageBox.Show(NameX & Translator.Instance.Translate("EliminatedSuccessfull_A_R"))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeleteMedic()
        Try
            log.DeleteMedic(idMedic)
            MessageBox.Show(NameX & Translator.Instance.Translate("EliminatedSuccessfull_A_R"))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeletePatient()
        Try
            log.DeletePatient(idPatient)
            MessageBox.Show(NameX & Translator.Instance.Translate("EliminatedSuccessfull_A_R"))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeleteSymptom()
        Try
            log.DeleteSymptoms(idSympt)
            MessageBox.Show(NameX & Translator.Instance.Translate("EliminatedSuccessfull_A_R"))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeletePath()
        Try
            log.DeletePathology(idPath)
            MessageBox.Show(NameX & Translator.Instance.Translate("EliminatedSuccessfull_A_R"))
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

    Private Sub TxtPin_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPin.KeyDown
        'Detectar si presiona enter, que accione el botón Remover
        If e.KeyCode = Keys.Enter Then
            BtnPin_A_R.PerformClick()
        End If
    End Sub
End Class