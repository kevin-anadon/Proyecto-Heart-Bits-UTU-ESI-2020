Imports Logica
Imports Data
Imports Persistencia
Imports ADODB
Public Class FrmPath
    Dim db As New ConnectionDB()
    Dim log As New Controller()

    Dim row As DataGridViewRow
    Dim PathSelected As String

    Dim rspath As Recordset = db.ObtainTable("pat_all")
    Public Sub ReloadDgv()
        Dim daInsert As New System.Data.OleDb.OleDbDataAdapter()
        Dim dsInsert = New DataSet
        daInsert.Fill(dsInsert, rspath, "Load")
        DgvPat.DataSource = (dsInsert.Tables("Load"))
        DgvPat.Refresh()
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
        ReloadDgv()
    End Sub

    Private Sub BtnPat_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtPat.MouseClick
        TxtPat.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub
End Class