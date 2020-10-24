Imports Logic
Imports Data

Public Class FrmSympt
    Dim log As New Logic.Controller()

    Dim row As DataGridViewRow
    Dim SymptSelected As String
    Dim reg As String = Nothing
    Dim Pathologies As New List(Of String)

    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv(0)
        BtnAddSympt.BackColor = Color.FromArgb(240, 240, 240)
        BtnMod.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelSympt.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Public Sub ReloadDgv(i As Integer)
        If i = 0 Then
            'Opción para el load
            Try
                DgvSympt.DataSource = log.ObtainSymptomsDataSet().Tables("Refresh")
                DgvSympt.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            'Opcion para los demas
            Try
                DgvSympt.DataSource = log.ObtainSymptomsDataSet().Tables("Refresh")
                DgvSympt.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MzButtonWindows1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub TxtSympt_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtSympt.MouseClick
        TxtSympt.Text = Nothing
    End Sub

    Private Sub TxtSympt_TextChanged(sender As Object, e As EventArgs) Handles TxtSympt.TextChanged 'Buscar sintoma
        If Not TxtSympt.Text.Equals("") Or Not TxtSympt.Text = Nothing Then
            Try
                DgvSympt.DataSource = log.SearchSymptoms(TxtSympt.Text).Tables("Search")
                DgvSympt.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ReloadDgv(2)
        End If
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Dispose()
        FrmHome.Show()
    End Sub

    Private Sub TxtSympt_Enter(sender As Object, e As EventArgs) Handles TxtSympt.Enter
        TxtSympt.Clear()
    End Sub

    Private Sub BtnAddSympt_Click(sender As Object, e As EventArgs) Handles BtnAddSympt.Click
        Dim frmAdd As New FrmAddModSympt()
        'Insercion de nuevo síntoma
        frmAdd.AddSympt()
        frmAdd.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub BtnDelSympt_Click(sender As Object, e As EventArgs) Handles BtnDelSympt.Click
        Dim alerta As New FrmAlertRemove()
        row = DgvSympt.CurrentRow
        SymptSelected = CStr(row.Cells("Síntoma").Value) 'Obtengo el síntoma seleccionado
        For Each Sympt As Symptom In log.ObtainSymptoms()
            If Sympt.Description.Equals(SymptSelected) Then
                FrmAlertRemove.idSympt = Sympt.Id
            End If
        Next
        alerta.Obtain(SymptSelected, 0)
        alerta.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub DgvSympt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSympt.CellDoubleClick 'Una manera de acceder a las modificaciones, haciendo doble clic en la tabla.
        ModSympt()
    End Sub

    Public Sub ModSympt()
        Dim frmMod As New FrmAddModSympt()
        'Modificación de síntoma

        row = DgvSympt.CurrentRow
        If IsDBNull(row.Cells("Síntoma").Value) Then

        Else
            SymptSelected = CStr(row.Cells("Síntoma").Value)
            Try
                reg = CStr(row.Cells("Región").Value)
                frmMod.ObtainSympt(SymptSelected, reg)
                frmMod.ShowDialog()
                ReloadDgv(4)
            Catch ex As Exception
                Console.WriteLine("Sintoma a modificar sin region")
                reg = "No tiene"
                frmMod.ObtainSympt(SymptSelected, reg)
                frmMod.ShowDialog()
                ReloadDgv(4)
            End Try
        End If
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click 'Otra manera de modificar un síntoma
        ModSympt()
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
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class