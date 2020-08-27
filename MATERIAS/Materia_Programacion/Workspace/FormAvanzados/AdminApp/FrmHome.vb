Imports System.Runtime.InteropServices
Public Class FrmHome
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
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
End Class