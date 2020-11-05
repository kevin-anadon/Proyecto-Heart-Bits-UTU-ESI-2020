Imports Data
Imports Logic
Public Class FrmHome 'AdminApp
    Public Shared AdmName = "", Ci = "", Age = "", Email = "", Phone = "", Connect = ""

    'Eventos
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Translator.Instance.TranslateForm(Me)
        LoadAdmin()
    End Sub
    Private Sub LoadAdmin()
        LblName.Text = AdmName
        LblCi.Text = Ci
        LblAge.Text = Age
        LblEmail.Text = Email
        LblPhone.Text = Phone
        LblConnect.Text = Connect
    End Sub

    '---BtnNavegadores
    Private Sub BtnPatients_A_H_Click(sender As Object, e As EventArgs) Handles BtnPatients_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(1)
        frm.Show()
    End Sub
    Private Sub BtnMedics_A_H_Click(sender As Object, e As EventArgs) Handles BtnMedics_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(0)
        frm.Show()
    End Sub
    Private Sub BtnAdmins_A_H_Click(sender As Object, e As EventArgs) Handles BtnAdmins_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(2)
        frm.Show()
    End Sub
    Private Sub BtnSymp_A_H_Click(sender As Object, e As EventArgs) Handles BtnSymp_A_H.Click
        Dim frm As New FrmSympt
        Me.Dispose()
        frm.Show()
    End Sub
    Private Sub BtnPathologies_A_H_Click(sender As Object, e As EventArgs) Handles BtnPathologies_A_H.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
    Private Sub BtnLogout_A_H_Click(sender As Object, e As EventArgs) Handles BtnLogout_A_H.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

End Class 'FrmHome