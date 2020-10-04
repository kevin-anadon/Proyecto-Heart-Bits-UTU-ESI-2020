Imports Logic
Imports Data
Public Class FrmAdmin
    Dim log As New Logica()

    Dim row As DataGridViewRow

    Public Sub ReloadDgv()
        Try
            DgvAdmin.DataSource = log.ObtainAdmins().Tables("Refresh")
            DgvAdmin.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv()
        BtnAddAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnModAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelAdmin.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnSympt_Click(sender As Object, e As EventArgs) Handles BtnSympt.Click
        Dim frm As New FrmSympt()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPath.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
End Class