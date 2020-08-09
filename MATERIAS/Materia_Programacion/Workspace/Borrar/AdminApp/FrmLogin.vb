Public Class FrmLogin
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If MsgBox("Está seguro que desea cerrar ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        Else
            Return
        End If
    End Sub
End Class