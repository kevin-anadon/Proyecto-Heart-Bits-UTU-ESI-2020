Imports System.Runtime.InteropServices
Public Class FrmLogin
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If MsgBox("Está seguro que desea cerrar ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        Else
            Return
        End If
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
    End Sub
End Class