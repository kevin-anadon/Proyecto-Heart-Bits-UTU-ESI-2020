Imports Logic
Imports Data
Imports Persistencia
Imports ADODB
Public Class FrmModPath
    Dim db As New DataBaseConn()
    Dim log As New Logic.Logica()
    Dim frm As New FrmPath()
    Dim row As DataGridViewRow

    Dim Kind As String = Nothing
    Dim Priority As String = Nothing
    Dim Exist As Boolean = False
    Dim PatName As String = Nothing
    Dim PatDesc As String = Nothing
    Dim PatMortality As Integer = 0
    Dim ListTreatments As New List(Of Treatment)
    Dim listP As New List(Of Pathology)

    Public Sub ObtainExistingPaths()
        listP = log.ObtainPath()
    End Sub

    Public Sub Obtain(namePat As String, DescSelected As String, Mortality As Integer, treatments As List(Of Treatment))
        PatName = namePat
        PatDesc = DescSelected
        PatMortality = Mortality
        ListTreatments = treatments
        Priority = LblPrioridad.Text
    End Sub

    Public Sub ReloadDgv()
        For Each Treatment As Treatment In ListTreatments
            DgvTreat.Rows.Add(Treatment.name, Treatment.description, Treatment.kind)
        Next
    End Sub

    Public Sub ReloadPat()
        TxtName.Text = PatName
        TxtDescr.Text = PatDesc
        Spinner.Value = PatMortality
    End Sub

    Private Sub FrmModPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblPat.Text = PatName.ToUpper()
        ReloadDgv()
        ReloadPat()
    End Sub

    Public Sub AddTreat()
        DgvTreat.Rows.Add(TxtTreatName.Text, TxtTreatDesc.Text, Kind)
        DgvTreat.Refresh()
        TxtTreatName.Clear()
        TxtTreatDesc.Clear()
        If RbnMed.Checked Then
            RbnMed.Checked = False
        ElseIf RbnQ.Checked Then
            RbnQ.Checked = False
        End If
    End Sub

    Private Sub BtnAddTreat_Click(sender As Object, e As EventArgs) Handles BtnAddTreat.Click
        Exist = False
        If Not TxtTreatDesc.Text.Trim.Length = 0 Or Not TxtTreatName.Text.Trim.Length = 0 Or RbnMed.Checked Or RbnQ.Checked Then
            If RbnMed.Checked Then
                Kind = "Medicamento"
            ElseIf RbnQ.Checked Then
                Kind = "Quirurjico"
            Else
                MessageBox.Show("CAMPOS DE TRATAMIENTO VACIO!!")
                Return
            End If

            If DgvTreat.Rows.Count - 1 > 0 Then
                For i As Integer = 0 To DgvTreat.Rows.Count - 1
                    If (CStr(DgvTreat.Rows(i).Cells("name").Value) = TxtTreatName.Text) Then
                        MessageBox.Show("Tratamiento ya existente!!")
                        Exist = True
                    End If
                Next
                If Exist = False Then
                    AddTreat()
                End If
                Return
            End If
            BtnAddTreat.BaseColor = Color.DimGray
            BtnDelTreat.BaseColor = Color.Teal
            BtnModTreat.BaseColor = Color.Teal
            AddTreat()
        Else
            MessageBox.Show("CAMPOS DE TRATAMIENTO VACIO!!")
            Return
        End If
    End Sub
    Private Sub BtnDelTreat_Click(sender As Object, e As EventArgs) Handles BtnDelTreat.Click
        If DgvTreat.Rows.Count - 1 > 0 Then
            row = DgvTreat.CurrentRow
            DgvTreat.Rows.Remove(row)
        Else
            MessageBox.Show("No existen tratamientos que eliminar!!")
        End If
    End Sub

    Private Sub DgvTreat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTreat.CellClick
        row = DgvTreat.CurrentRow
        TxtTreatName.Text = CStr(row.Cells("name").Value)
        TxtTreatDesc.Text = CStr(row.Cells("desc").Value)
        If IsNothing(row.Cells("type").Value) Then
            Return
        End If
        If CStr(row.Cells("type").Value).Equals("Medicamento") Then
            RbnMed.Checked = True
        Else
            RbnQ.Checked = True
        End If
    End Sub

    Private Sub BtnModTreat_Click(sender As Object, e As EventArgs) Handles BtnModTreat.Click

        If DgvTreat.Rows.Count - 1 > 0 Then
            If RbnMed.Checked Then
                Kind = "Medicamento"
            ElseIf RbnQ.Checked Then
                Kind = "Quirurjico"
            Else
                MessageBox.Show("CAMPOS DE TRATAMIENTO VACIO!!")
                Return
            End If
            row = DgvTreat.CurrentRow
            Dim nametreat As String = CStr(row.Cells("name").Value)
            row.SetValues(TxtTreatName.Text, TxtTreatDesc.Text, Kind)
            TxtTreatName.Clear()
            TxtTreatDesc.Clear()
            If RbnMed.Checked Then
                RbnMed.Checked = False
            ElseIf RbnQ.Checked Then
                RbnQ.Checked = False
            End If
        Else
            MessageBox.Show("No existen tratamientos que modificar!!")
        End If
    End Sub

    Private Sub Spinner_ValueChanged(sender As Object, e As EventArgs) Handles Spinner.ValueChanged
        If Spinner.Value <= 10 Then
            LblPrioridad.Text = "BAJA"
        ElseIf Spinner.Value <= 40 Then
            LblPrioridad.Text = "MEDIA"
        Else
            LblPrioridad.Text = "ALTA"
        End If
    End Sub

    Private Sub TxtDescr_Enter_1(sender As Object, e As EventArgs) Handles TxtDescr.Enter
        TxtDescr.ForeColor = Color.Black
    End Sub

    Private Sub TxtDescr_Leave_1(sender As Object, e As EventArgs) Handles TxtDescr.Leave
        TxtDescr.ForeColor = Color.DarkGray
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Public Function CheckExist(name As String) As Boolean
        Dim exist As Boolean = False
        ObtainExistingPaths()
        For Each pat As Pathology In listP
            If name.Equals(pat.name) Then
                exist = True
            End If
        Next
        Return exist
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim TreatmentsAfter As New List(Of Treatment)
        Dim treatname As String = Nothing
        Dim treatdesc As String = Nothing
        Dim treatkind As String = Nothing
        Dim Prior As Integer = 0

        If Not TxtName.Text.Trim.Length = 0 Or Not TxtDescr.Text.Trim.Length = 0 Then
            Dim PatAfter As String = TxtName.Text
            Dim PatDescAfter As String = TxtDescr.Text
            Dim PatMortalityAfter As Integer = Spinner.Value
            Dim PriorityAfter As String = LblPrioridad.Text

            If Not PatAfter.Equals(PatName) Then
                If CheckExist(PatAfter) = True Then
                    MessageBox.Show("Nombre de patología ya existente!!")
                    Return
                End If
            End If

            If DgvTreat.Rows.Count - 1 = 0 Then
                MessageBox.Show("Tratamientos vacios!!" & vbCrLf & "Debe almacenar uno por lo menos")
                Return
            End If

            For i As Integer = 0 To DgvTreat.Rows.Count - 1
                If IsNothing(DgvTreat.Rows(i).Cells("name").Value) Then

                Else
                    treatname = CStr(DgvTreat.Rows(i).Cells("name").Value)
                    treatdesc = CStr(DgvTreat.Rows(i).Cells("desc").Value)
                    treatkind = CStr(DgvTreat.Rows(i).Cells("type").Value)
                    TreatmentsAfter.Add(New Treatment(treatname, treatdesc, treatkind))
                End If
            Next

            If PriorityAfter.Equals("BAJA") Then
                Prior = 3
            ElseIf PriorityAfter.Equals("MEDIA") Then
                Prior = 2
            Else
                Prior = 1
            End If

            db.UpdatePath(PatAfter, PatDescAfter, PatMortalityAfter, Prior, TreatmentsAfter, PatName)
            MessageBox.Show("Patología modificada correctamente!!")
            Me.Close()
        Else
            MessageBox.Show("Campos de patología vacios!!")
        End If
    End Sub
End Class