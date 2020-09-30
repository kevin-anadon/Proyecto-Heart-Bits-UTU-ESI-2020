Imports System.Runtime.InteropServices
Imports ADODB
Imports Data
Imports Persistencia
Imports Logic
Public Class FrmModSympt
    Dim db As New DataBaseConn()
    Dim log As New Logic.Logica()
    Dim rreg As Recordset = db.ObtainTable("region")

    Dim PatAfter As New List(Of String)
    Dim Pat As List(Of String)
    Dim Sympt As String = Nothing
    Dim reg As String = Nothing


    Public Sub ObtainSympt(s As String, r As String)
        Sympt = s
        reg = r
    End Sub

    Public Sub ReloadCmb()
        Dim dacmb As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds = New DataSet
        'Inserta todas las regiones en el cmbbox
        dacmb.Fill(ds, rreg, "region")
        Cmbreg.DataSource = (ds.Tables("region"))
        Cmbreg.DisplayMember = "nombre"
    End Sub

    Public Sub ReloadPat()
        Pat = db.ListPath(Sympt)
        Dim i As Integer
        For Each pat As Pathology In log.ObtainPath()
            ChkListPath.Items.Add(pat.name)
        Next
        For Each name As String In Pat
            For i = 0 To ChkListPath.Items.Count - 1
                If ChkListPath.Items(i).ToString().Contains(name) Then
                    ChkListPath.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub

    Private Sub FrmModSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSymptTop.Text = Sympt.ToUpper()
        TxtDescr.Text = Sympt
        Lblreg.Text = reg
        ReloadCmb()
        ReloadPat()
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

    Public Sub AddNewPaths()
        PatAfter.Clear()
        Dim i As Integer
        For i = 0 To ChkListPath.CheckedItems.Count - 1
            PatAfter.Add(ChkListPath.CheckedItems(i))
        Next
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        Dim SymptAfter, SymptBefore As String
        Dim regAfter As String = Nothing

        If ChkReg.Checked = True Then
            regAfter = Cmbreg.Text.ToString()
        End If
        SymptAfter = TxtDescr.Text
        SymptBefore = Sympt
        AddNewPaths()
        'Descarto posibilidades de ingreso, para así aprovechar mejor los recursos del motor de BD
        If (SymptAfter.Equals(SymptBefore) And (reg.Equals(regAfter) Or Not Cmbreg.Visible)) And PatAfter.Count = 0 Then
            MessageBox.Show("No ha hecho ninguna modificación!!")
            Return
        ElseIf Not PatAfter.Count = 0 And (SymptAfter.Equals(SymptBefore) And (reg.Equals(regAfter) Or Not Cmbreg.Visible)) Then
            Console.WriteLine("Patología diferente")
            SymptAfter = "NULL"
            regAfter = "NULL"
        ElseIf SymptAfter.Equals(SymptBefore) And Not reg.Equals(regAfter) Then
            Console.WriteLine("Sintoma igual y región diferente")
            SymptAfter = "NULL"
        ElseIf Not SymptAfter.Equals(SymptBefore) And (reg.Equals(regAfter) Or Not Cmbreg.Visible) Then
            Console.WriteLine("Sintoma diferente y región igual")
            regAfter = "NULL"
        Else
            Console.WriteLine("Sintoma diferente y región diferente")
        End If
        db.UpdateSympt(SymptAfter, regAfter, SymptBefore, PatAfter)
        MessageBox.Show("Modificado con exito!!")
        Me.Close()
    End Sub
End Class