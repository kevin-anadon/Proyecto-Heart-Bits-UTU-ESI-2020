Imports Logic
Imports Data
Public Class FrmAdmin
    Dim log As New Logic.Logic

    Dim SelectedAdmin As Admin = Nothing
    Dim row As DataGridViewRow
    Dim CiSelected As String = ""

    Public Sub ReloadDgv()
        Try
            DgvAdmin.DataSource = log.ObtainAdminsDataSet().Tables("Refresh")
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

    Private Sub BtnDelAdmin_Click(sender As Object, e As EventArgs) Handles BtnDelAdmin.Click
        Dim alerta As New FrmAlertRemove()
        FrmAlertRemove.idAdmin = SelectedAdmin.id
        alerta.Obtain(SelectedAdmin.CiScript(CiSelected), 2)
        alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar este administrador?"
        alerta.LblEliminar.Text = "Eliminar Administrador"
        alerta.LblElimBody.Text = "Eliminar al administrador "
        alerta.LblSympt.Location = New Point(312, 34)
        alerta.ShowDialog()
        ReloadDgv()
    End Sub

    Private Sub BtnAddAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddAdmin.Click
        Dim frm As New FrmAddModAdmin()
        FrmAddModAdmin.Add = True
        frm.ShowDialog()
        ReloadDgv()
    End Sub

    Public Sub ModAdmin()
        Dim frm As New FrmAddModAdmin()

        Try
            FrmAddModAdmin.Admin = SelectedAdmin
            frm.ShowDialog()
            ReloadDgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnModAdmin_Click(sender As Object, e As EventArgs) Handles BtnModAdmin.Click 'Una manera de modificar
        ModAdmin()
    End Sub

    Private Sub DgvAdmin_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmin.CellDoubleClick 'Otra manera de modificar
        ModAdmin()
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs)
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
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim frm As New FrmHome()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub TxtCi_TextChanged(sender As Object, e As EventArgs) Handles TxtCi.TextChanged
        If TxtCi.Text.Equals("") Or TxtCi.Text.Equals("Realizar busqueda por c.i") Then
            ReloadDgv()
        Else
            Dim ci As String = TxtCi.Text
            Try
                Dim ciInt As Integer = CInt(ci)
                DgvAdmin.DataSource = log.SearchAdmin(ciInt).Tables("Search")
                DgvAdmin.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TxtCi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCi.KeyPress 'Verifica que unicamente ingrese números
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCi_Click(sender As Object, e As EventArgs) Handles TxtCi.Click
        TxtCi.Text = ""
    End Sub

    Private Sub DgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmin.CellClick
        row = DgvAdmin.CurrentRow
        If IsDBNull(row.Cells("Ci").Value) Then

        Else
            row = DgvAdmin.CurrentRow
            CiSelected = CStr(row.Cells("Ci").Value) 'Obtengo el ci seleccionado
            For Each Admin As Admin In log.ObtainAdmins()
                If Admin.ci.ToString().Equals(CiSelected) Then
                    SelectedAdmin = Admin
                End If
            Next
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class