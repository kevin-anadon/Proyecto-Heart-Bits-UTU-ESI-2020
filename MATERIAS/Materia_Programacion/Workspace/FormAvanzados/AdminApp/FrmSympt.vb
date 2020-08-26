Imports System.Runtime.InteropServices
Imports Logica
Imports Data
Imports Persistencia
Imports ADODB

Public Class FrmSympt
    Dim db As New ConnectionDB()
    Dim rsympt As Recordset = db.ObtainTable("sintoma")
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

    Public Sub ReloadCmb()
        Dim dacmb As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds = New DataSet
        'Inserta todas las regiones en el cmbbox
        dacmb.Fill(ds, rreg, "region")
        cmbregion.DataSource = (ds.Tables("region"))
        cmbregion.DisplayMember = "nombre"
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
        ReloadDgv(0)
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

    Private Sub cmbregion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbregion.SelectedIndexChanged
        'ACA DEBERIA ACTUALIZARSE EL DATAGRIDVIEW CON LO QUE SELECCIONAS DEL COMBO BOX
        'ESTÁ COMENTADO YA QUE NO LOGRAMOS QUE AL MOSTRARSE EL FRAME NO SE EJECUTE EL METODO cmbSympSelectedIndexChanged

        'If cmbregion.Text.ToString() = "Seleccione region" Then
        'Else
        'Dim rsearchreg As Recordset = db.SearchRegion(cmbregion.Text.ToString())
        'Dim dasearchreg As New System.Data.OleDb.OleDbDataAdapter()
        'dsearch = New DataSet
        'dasearchreg.Fill(dsearch, rsearchreg, "sintomas_regiones")
        'DgvSympt.DataSource = (dsearch.Tables("sintomas_regiones"))
        'DgvSympt.Refresh()
        'End If
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
        If TxtAddSympt.Text.Trim.Length = 0 Then
            MessageBox.Show("CAMPOS VACIOS!!")
        Else
            If Not ChkReg.Checked Then
                Dim region As String = "NULL"
                db.InsertSympt(TxtAddSympt.Text.ToString(), region)
            Else
                db.InsertSympt(TxtAddSympt.Text.ToString(), cmbregion.Text.ToString())
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

    Private Sub BtnDelSympt_Click(sender As Object, e As EventArgs) Handles BtnDelSympt.Click
        Dim row As DataGridViewRow = DgvSympt.CurrentRow
        Dim SymptSelected As String = CStr(row.Cells("Síntoma").Value)
        'Obtengo la el síntoma seleccionado

        db.DelSympt(SymptSelected)
    End Sub
End Class