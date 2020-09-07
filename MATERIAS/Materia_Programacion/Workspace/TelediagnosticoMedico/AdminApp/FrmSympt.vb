Imports System.Runtime.InteropServices
Imports Logic
Imports Data
Imports Persistencia
Imports ADODB

Public Class FrmSympt
    Dim db As New ConnectionDB()
    Dim log As New Controller()

    Dim row As DataGridViewRow
    Dim SymptSelected As String
    Dim reg As String = Nothing
    Dim Pathologies As New List(Of String)


    Dim rsympt As Recordset = db.ObtainTable("sintoma")
    Dim rspath As Recordset = db.ObtainTable("patologia")
    Dim rreg As Recordset = db.ObtainTable("region")

    Public Sub ReloadDgv(i As Integer)
        If i = 0 Then
            'Opción para el load
            Dim daInsert As New System.Data.OleDb.OleDbDataAdapter()
            Dim dsInsert = New DataSet
            daInsert.Fill(dsInsert, rsympt, "Refresh")
            DgvSympt.DataSource = (dsInsert.Tables("Refresh"))
            DgvSympt.Refresh()
        Else
            'Opcion para el btn refresh
            Dim rsymptRef As Recordset = db.ObtainTable("sintoma")
            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim ds = New DataSet
            da.Fill(ds, rsymptRef, "Refresh")
            DgvSympt.DataSource = (ds.Tables("Refresh"))
            DgvSympt.Refresh()
        End If
    End Sub

    Public Sub ReloadChkL()
        For Each path As Pathology In log.ObtainPath()
            ChkList.Items.Add(path.name)
        Next
    End Sub

    Public Sub ReloadCmb()
        For Each Region As Region In log.ObtainRegions()
            cmbregion.Items.Add(Region.name)
        Next
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
        ReloadDgv(0)
        ReloadChkL()
        ReloadCmb()
    End Sub

    Private Sub MzButtonWindows1_Click(sender As Object, e As EventArgs) Handles MzButtonWindows1.Click
        End
    End Sub

    Private Sub TxtSympt_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtSympt.MouseClick
        TxtSympt.Text = Nothing
    End Sub

    Private Sub TxtSympt_TextChanged(sender As Object, e As EventArgs) Handles TxtSympt.TextChanged
        Dim rsearchsympt As Recordset = db.SearchSympt(TxtSympt.Text)
        Dim dasearch As New System.Data.OleDb.OleDbDataAdapter()
        Dim dsearch = New DataSet
        dasearch.Fill(dsearch, rsearchsympt, "sintoma")
        DgvSympt.DataSource = (dsearch.Tables("sintoma"))
        DgvSympt.Refresh()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim frmhome As New FrmHome()
        Me.Dispose()
        frmhome.Show()
    End Sub

    Private Sub TxtSympt_Enter(sender As Object, e As EventArgs) Handles TxtSympt.Enter
        TxtSympt.Clear()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadDgv(1)
    End Sub

    Private Sub BtnAddSympt_Click(sender As Object, e As EventArgs) Handles BtnAddSympt.Click
        Pathologies.Clear()
        Dim i As Integer
        Dim Valor As String
        For i = 0 To Me.ChkList.CheckedItems.Count - 1
            Valor = ChkList.CheckedItems(i)
            Pathologies.Add(Valor)
        Next
        If TxtAddSympt.Text.Trim.Length = 0 Or TxtAddSympt.Text = "Ingrese nombre de nuevo síntoma" Or ChkList.CheckedItems.Count = 0 Then
            MessageBox.Show("CAMPOS VACIOS!!")
        Else
            For rows As Integer = 0 To DgvSympt.Rows.Count - 1
                If (CStr(DgvSympt.Rows(rows).Cells("Síntoma").Value) = TxtAddSympt.Text) Then
                    MessageBox.Show("Síntoma ya existente!!")
                    Return
                End If
            Next
            If Not ChkReg.Checked Then
                Dim region As String = "NULL"
                db.InsertSympt(TxtAddSympt.Text.ToString(), region, Pathologies)
                MessageBox.Show("INGRESADO CON EXITO!!")
                TxtAddSympt.Text = "Ingrese nombre de nuevo síntoma"
                For patselected As Integer = 0 To ChkList.Items.Count - 1
                    ChkList.SetItemChecked(patselected, False)
                Next
                ReloadDgv(2)
            Else
                If cmbregion.Text.Trim.Length() = 0 Then
                    MessageBox.Show("INGRESE UNA REGIÓN!!")
                Else
                    db.InsertSympt(TxtAddSympt.Text.ToString(), cmbregion.Text.ToString(), Pathologies)
                    MessageBox.Show("INGRESADO CON EXITO!!")
                    TxtAddSympt.Text = "Ingrse nombre de nuevo síntoma"
                    For patselected As Integer = 0 To ChkList.Items.Count - 1
                        ChkList.SetItemChecked(patselected, False)
                    Next
                    ReloadDgv(2)
                End If
            End If
        End If
    End Sub

    Private Sub TxtAddSympt_Enter(sender As Object, e As EventArgs) Handles TxtAddSympt.Enter
        TxtAddSympt.Clear()
    End Sub

    Private Sub ChkReg_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReg.CheckedChanged
        If ChkReg.Checked Then
            cmbregion.Show()
        Else
            cmbregion.Hide()
        End If
    End Sub

    Public Sub DeleteSympt(Sympt As String)
        db.DelSympt(Sympt)
    End Sub

    Private Sub BtnDelSympt_Click(sender As Object, e As EventArgs) Handles BtnDelSympt.Click
        Dim alerta As New FrmAlertRemove()
        row = DgvSympt.CurrentRow
        SymptSelected = CStr(row.Cells("Síntoma").Value)
        'Obtengo el síntoma seleccionado
        'Hago comprobación con PIN, mandó el sintoma que se desea borrar a un método de la clase FrmAlertRemoveSymptom
        alerta.Obtain(SymptSelected, 0)
        alerta.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub DgvSympt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSympt.CellDoubleClick
        Dim frmMod As New FrmModSympt()
        'Modificación de síntoma

        row = DgvSympt.CurrentRow
        SymptSelected = CStr(row.Cells("Síntoma").Value)
        Try
            reg = CStr(row.Cells("Región").Value)
            frmMod.ObtainSympt(SymptSelected, reg)
            frmMod.ShowDialog()
            ReloadDgv(4)
        Catch ex As Exception
            reg = "No tiene"
            frmMod.ObtainSympt(SymptSelected, reg)
            frmMod.ShowDialog()
            ReloadDgv(4)
        End Try
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