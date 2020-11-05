Imports Logic
Imports Data

Public Class FrmSympt
    Dim log As New Logic.Controller()

    Dim row As DataGridViewRow
    Dim SymptSelected As String
    Dim reg As String = Nothing
    Dim Pathologies As New List(Of String)

    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Translator.Instance.TranslateForm(Me)
        TxtSympt_A_S.Text = Translator.Instance.Translate("TxtSympt_A_S")
        ReloadDgv(0)
        BtnAddSympt_A_S.BackColor = Color.FromArgb(240, 240, 240)
        BtnMod_A_S.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelSympt_A_S.BackColor = Color.FromArgb(240, 240, 240)
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

    Private Sub TxtSympt_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtSympt_A_S.MouseClick
        TxtSympt_A_S.Text = Nothing
    End Sub

    Private Sub TxtSympt_TextChanged(sender As Object, e As EventArgs) Handles TxtSympt_A_S.TextChanged 'Buscar sintoma
        If Not TxtSympt_A_S.Text.Equals("") Or Not TxtSympt_A_S.Text = Nothing Then
            Try
                DgvSympt.DataSource = log.SearchSymptoms(TxtSympt_A_S.Text).Tables("Search")
                DgvSympt.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ReloadDgv(2)
        End If
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome_A_H.Click
        Me.Dispose()
        FrmHome.Show()
    End Sub

    Private Sub TxtSympt_Enter(sender As Object, e As EventArgs) Handles TxtSympt_A_S.Enter
        TxtSympt_A_S.Clear()
    End Sub

    Private Sub BtnAddSympt_Click(sender As Object, e As EventArgs) Handles BtnAddSympt_A_S.Click
        Dim frmAdd As New FrmAddModSympt()
        'Insercion de nuevo síntoma
        frmAdd.AddSympt()
        frmAdd.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub BtnDelSympt_Click(sender As Object, e As EventArgs) Handles BtnDelSympt_A_S.Click
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

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod_A_S.Click 'Otra manera de modificar un síntoma
        ModSympt()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout_A_H.Click
        If MsgBox(Translator.Instance.Translate("LogOut_M_H"), MsgBoxStyle.YesNoCancel, Translator.Instance.Translate("CloseProgram_M_H")) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPathologies_A_H.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmins_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(2)
        frm.Show()
    End Sub
    Private Sub BtnPac_Click(sender As Object, e As EventArgs) Handles BtnPatients_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(1)
        frm.Show()
    End Sub

    Private Sub BtnMed_Click(sender As Object, e As EventArgs) Handles BtnMedics_A_H.Click
        Dim frm As New FrmAdmin()
        Me.Dispose()
        frm.IdentifyPeople(0)
        frm.Show()
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class