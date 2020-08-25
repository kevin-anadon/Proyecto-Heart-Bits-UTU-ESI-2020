Imports System.Runtime.InteropServices
Imports Logica
Imports Data
Imports Persistencia
Imports ADODB

Public Class FrmSympt
    Dim db As New ConnectionDB()
    Dim rsympt As Recordset = db.ObtainTable("sintoma")
    Dim rreg As Recordset = db.ObtainTable("region")

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Dim da, daa As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds = New DataSet
        da.Fill(ds, rsympt, "sintoma")
        DgvSympt.DataSource = (ds.Tables("sintoma"))
        DgvSympt.Refresh()
        daa.Fill(ds, rreg, "region")
        cmbregion.DataSource = (ds.Tables("region"))
        cmbregion.DisplayMember = "nombre"
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
        Dim region As String = cmbregion.SelectedItem.ToString()

        Dim rsearchregion As Recordset = db.SearchRegion(region)
        Dim dasearchreg As New System.Data.OleDb.OleDbDataAdapter()
        Dim dsearchreg = New DataSet
        dasearchreg.Fill(dsearchreg, rsearchregion, "sintoma")
        DgvSympt.DataSource = (dsearchreg.Tables("sintoma"))
        DgvSympt.Refresh()
    End Sub
End Class