Imports System.Runtime.InteropServices
Imports Data
Public Class FrmHome
    Public Shared AdmName = "", Ci = "", Age = "", Email = "", Phone = "", Connect = ""

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = AdmName
        LblCi.Text = Ci
        LblAge.Text = Age
        LblEmail.Text = Email
        LblPhone.Text = Phone
        LblConnect.Text = Connect
    End Sub

    Private Sub BtnSympt_Click(sender As Object, e As EventArgs) Handles BtnSympt.Click
        Dim frm As New FrmSympt
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPath.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(2)
        frm.Show()
    End Sub
    Private Sub BtnPac_Click(sender As Object, e As EventArgs) Handles BtnPac.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(1)
        frm.Show()
    End Sub

    Private Sub BtnMed_Click(sender As Object, e As EventArgs) Handles BtnMed.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(0)
        frm.Show()
    End Sub

End Class