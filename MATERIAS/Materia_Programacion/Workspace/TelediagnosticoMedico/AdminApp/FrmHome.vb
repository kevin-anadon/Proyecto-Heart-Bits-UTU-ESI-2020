Imports System.Runtime.InteropServices
Imports Data
Public Class FrmHome
    Dim AdminLog As New Admin()
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminLog = FrmLogin.AdminLog

        'Se actualizan los datos del administrador que se veran en pantalla utilizando el objeto AdminLog
        LblName.Text = AdminLog.fstName & " " & AdminLog.scndName & " " & AdminLog.fstSurname & " " & AdminLog.scndSurname
        LblCi.Text = AdminLog.CiScript(AdminLog.ci)
        LblAge.Text = AdminLog.CalcAge(AdminLog.dateBirth).ToString()
        LblEmail.Text = AdminLog.email
        LblPhone.Text = AdminLog.numPhone.ToString()
        LblConnect.Text = "Usuario " & AdminLog.username & " conectado a las " & TimeOfDay.Hour.ToString() & ":" & TimeOfDay.Minute.ToString() & ":" & TimeOfDay.Millisecond.ToString() & "."

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
End Class