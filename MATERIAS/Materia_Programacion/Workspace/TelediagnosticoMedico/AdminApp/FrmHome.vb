﻿Imports System.Runtime.InteropServices
Public Class FrmHome
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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