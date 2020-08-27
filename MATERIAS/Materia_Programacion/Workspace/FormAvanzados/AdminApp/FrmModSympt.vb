Imports System.Runtime.InteropServices
Imports ADODB
Imports Persistencia

Public Class FrmModSympt
    Dim db As New ConnectionDB()
    Dim rreg As Recordset = db.ObtainTable("region")


    Dim Sympt As String = Nothing
    Dim reg As String = Nothing


    Public Sub ObtainSympt(s As String, r As String)
        Sympt = s
        reg = r
    End Sub

    Private Sub FrmModSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSymptTop.Text = Sympt.ToUpper()
        TxtDescr.Text = Sympt
        Lblreg.Text = reg
        Dim dacmb As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds = New DataSet
        'Inserta todas las regiones en el cmbbox
        dacmb.Fill(ds, rreg, "region")
        Cmbreg.DataSource = (ds.Tables("region"))
        Cmbreg.DisplayMember = "nombre"

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub ChkReg_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReg.CheckedChanged
        If ChkReg.Checked Then
            Cmbreg.Show()
        Else
            Cmbreg.Hide()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        Dim SymptAfter, SymptBefore As String

        If ChkReg.Checked = True Then
            reg = Cmbreg.Text.ToString()
        End If
        SymptAfter = TxtDescr.Text
        SymptBefore = Sympt
        db.UpdateSympt(SymptAfter, reg, SymptBefore)
        MessageBox.Show("Ha sido modificado con exito!!")
        Me.Close()

    End Sub
End Class