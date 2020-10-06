﻿Imports Logic
Imports Data
Public Class FrmPath
    Dim log As New Logic.Logic()

    Dim row As DataGridViewRow
    Dim PathSelected As String = Nothing
    Dim DescSelected As String = Nothing

    Private Sub FrmPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv(0)
        BtnAddPat.BackColor = Color.FromArgb(240, 240, 240)
        BtnMod.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelPat.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Public Sub ReloadDgv(i As Integer)
        If i = 0 Then
            Try
                DgvPat.DataSource = log.ObtainPathsDataSet().Tables("Refresh")
                DgvPat.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            'Opcion para los demas
            Try
                DgvPat.DataSource = log.ObtainPathsDataSet().Tables("Refresh")
                DgvPat.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnAddPat_Click(sender As Object, e As EventArgs) Handles BtnAddPat.Click
        Dim frm As New FrmAddModPath()
        FrmAddModPath.Add = True
        frm.LblPathTop.Text = "INSERTAR NUEVA PATOLOGÍA"
        frm.BtnAdd.Text = "ALMACENAR PATOLOGÍA"
        frm.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub BtnDelPat_Click(sender As Object, e As EventArgs) Handles BtnDelPat.Click
        Dim alerta As New FrmAlertRemove()
        row = DgvPat.CurrentRow
        PathSelected = CStr(row.Cells("Patología").Value) 'Obtengo la Patología seleccionada
        For Each Path As Pathology In log.ObtainPath()
            If Path.name.Equals(PathSelected) Then
                FrmAlertRemove.idPath = Path.id
            End If
        Next
        alerta.Obtain(PathSelected, 1)
        alerta.LblEliminar.Text = "ELIMINAR PATOLOGÍA"
        alerta.LblElimBody.Text = "Eliminar la patología: "
        alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar esta patología?"
        alerta.ShowDialog()
        ReloadDgv(1)
    End Sub

    Public Sub ModPath()
        Dim frmMod As New FrmAddModPath()
        Dim Pathmod As Pathology = Nothing
        Dim treatments As New List(Of Treatment)
        'Modificación de patología

        Try
            row = DgvPat.CurrentRow
            PathSelected = CStr(row.Cells("Patología").Value)
            Pathmod = log.ObtainPathForMod(PathSelected)
            treatments = log.ObtainTreatmentsForMod(Pathmod.id)
            FrmAddModPath.PathMod = Pathmod
            FrmAddModPath.TreatmentsMod = treatments
            frmMod.ShowDialog()
            ReloadDgv(4)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DgvPat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPat.CellDoubleClick  'Una forma de modificar una patología
        ModPath()
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click  'Otra manera de modificar una patología
        ModPath()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim frmhome As New FrmHome()
        Me.Dispose()
        frmhome.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnSympt_Click(sender As Object, e As EventArgs) Handles BtnSympt.Click
        Dim frm As New FrmSympt
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnPat_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtPat.MouseClick
        TxtPat.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub TxtPat_TextChanged(sender As Object, e As EventArgs) Handles TxtPat.TextChanged
        If Not TxtPat.Text.Equals("") Or Not TxtPat.Text = Nothing Then
            Try
                DgvPat.DataSource = log.SearchPathology(TxtPat.Text).Tables("Search")
                DgvPat.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ReloadDgv(3)
        End If
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class