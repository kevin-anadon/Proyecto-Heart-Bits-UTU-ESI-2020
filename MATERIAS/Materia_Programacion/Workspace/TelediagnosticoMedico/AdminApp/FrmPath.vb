Imports Logic
Imports Data
Imports Persistencia
Imports ADODB
Public Class FrmPath
    Dim db As New DataBaseConn()
    Dim log As New Logic.Logica()

    Dim row As DataGridViewRow
    Dim PathSelected As String = Nothing
    Dim DescSelected As String = Nothing

    Dim rspath As Recordset = db.ObtainTable("pat_all")
    Public Sub ReloadDgv(i As Integer)
        If i = 0 Then
            'Opción para el load
            Dim daInsert As New System.Data.OleDb.OleDbDataAdapter()
            Dim dsInsert = New DataSet
            daInsert.Fill(dsInsert, rspath, "Load")
            DgvPat.DataSource = (dsInsert.Tables("Load"))
            DgvPat.Refresh()
        Else
            'Opción para el refresh
            Dim rspathrefresh As Recordset = db.ObtainTable("pat_all")
            Dim daInsert As New System.Data.OleDb.OleDbDataAdapter()
            Dim dsInsert = New DataSet
            daInsert.Fill(dsInsert, rspathrefresh, "Refresh")
            DgvPat.DataSource = (dsInsert.Tables("Refresh"))
            DgvPat.Refresh()
        End If
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

    Private Sub FrmPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv(0)
    End Sub

    Private Sub BtnPat_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtPat.MouseClick
        TxtPat.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnAddPat_Click(sender As Object, e As EventArgs) Handles BtnAddPat.Click
        Dim frm As New FrmAddPath()
        Dim listP As New List(Of String)
        For rows As Integer = 0 To DgvPat.Rows.Count - 1
            listP.Add(DgvPat.Rows(rows).Cells("Patología").Value)
        Next
        frm.ObtainExistingPaths(listP)
        frm.ShowDialog()
        ReloadDgv(3)
    End Sub

    Public Sub DeletePath(Pat As String)
        db.DelPath(Pat)
    End Sub

    Private Sub BtnDelPat_Click(sender As Object, e As EventArgs) Handles BtnDelPat.Click
        Dim alerta As New FrmAlertRemove()
        row = DgvPat.CurrentRow
        PathSelected = CStr(row.Cells("Patología").Value)
        'Obtengo la Patología seleccionada
        'Hago comprobación con PIN, mandó la patología que se desea borrar a un método de la clase FrmAlertRemove
        alerta.Obtain(PathSelected, 1)
        alerta.LblEliminar.Text = "ELIMINAR PATOLOGÍA"
        alerta.LblElimBody.Text = "Eliminar la patología: "
        alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar esta patología?"
        alerta.ShowDialog()
        ReloadDgv(1)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadDgv(2)
    End Sub

    Private Sub TxtPat_TextChanged(sender As Object, e As EventArgs) Handles TxtPat.TextChanged
        Dim rsearchpat As Recordset = db.SearchPath(TxtPat.Text)
        Dim dasearch As New System.Data.OleDb.OleDbDataAdapter()
        Dim dsearch = New DataSet
        dasearch.Fill(dsearch, rsearchpat, "patologia")
        DgvPat.DataSource = (dsearch.Tables("patologia"))
        DgvPat.Refresh()
    End Sub

    Private Sub DgvPat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPat.CellDoubleClick
        Dim frmMod As New FrmModPath()
        Dim treatments As New List(Of Treatment)
        Dim Mortality As Integer = 0
        'Modificación de patología

        row = DgvPat.CurrentRow
        PathSelected = CStr(row.Cells("Patología").Value)
        DescSelected = CStr(row.Cells("Descripción").Value)
        treatments = log.ObtainTreatments(PathSelected)
        Mortality = log.ObtainMortalityPath(PathSelected)

        frmMod.Obtain(PathSelected, DescSelected, Mortality, treatments)
        frmMod.ShowDialog()
        ReloadDgv(4)
    End Sub


End Class