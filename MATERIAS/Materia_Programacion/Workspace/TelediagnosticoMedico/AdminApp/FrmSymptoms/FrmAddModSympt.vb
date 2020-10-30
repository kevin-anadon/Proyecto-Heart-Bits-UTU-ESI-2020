Imports Data
Imports Logic
Public Class FrmAddModSympt
    Dim log As New Logic.Controller()

    Dim PatAfter As New List(Of Pathology)
    Dim PathBefore As New List(Of Pathology)
    Dim SymptBefore As String = Nothing
    Dim RegBefore As New List(Of Region)
    Dim reg As String = Nothing
    Dim Add As Boolean = False
    Dim RegAfter As Region = Nothing
    Dim symptSend As Symptom = Nothing
    Dim idSympt As Integer = 0

    Public Sub AddSympt()
        LblTittle.Text = "INSERTAR NUEVO SÍNTOMA"
        LblActual.Text = ""
        ChkReg.Text = "Agregar región"
        Add = True
    End Sub

    Public Sub ObtainSympt(s As String, r As String)
        SymptBefore = s
        reg = r
        For Each sympt As Symptom In log.ObtainSymptoms()
            If sympt.Description.Equals(SymptBefore) Then
                idSympt = sympt.Id
            End If
        Next
    End Sub

    Public Sub ReloadCmb()
        RegBefore = log.ObtainRegions()
        For Each Region As Region In RegBefore
            Cmbreg.Items.Add(Region.name)
        Next
    End Sub

    Public Sub ReloadPat()
        PathBefore = log.ObtainPath()
        For Each pat As Pathology In PathBefore
            ChkListPath.Items.Add(pat.name)
        Next
        If Add = False Then
            For Each Path As Pathology In log.ObtainPathForSymptoms(SymptBefore)
                For i = 0 To ChkListPath.Items.Count - 1
                    If ChkListPath.Items(i).ToString().Contains(Path.name) Then
                        ChkListPath.SetItemChecked(i, True)
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub FrmModSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Add = False Then
            LblSymptTop.Text = SymptBefore.ToUpper()
            TxtDescr.Text = SymptBefore
            Lblreg.Text = reg
        End If
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

        For i = 0 To ChkListPath.CheckedItems.Count - 1
            For Each pat As Pathology In PathBefore
                If pat.name = ChkListPath.Items(i).ToString() Then
                    PatAfter.Add(New Pathology(pat.id, pat.name, pat.mortalityIndex, pat.priority))
                End If
            Next
        Next
    End Sub
    Public Sub AddNewRegion()
        For Each regiones As Region In RegBefore
            If ChkReg.Checked = True Then
                If regiones.name = Cmbreg.SelectedItem.ToString() Then
                    RegAfter = New Region(regiones.id, regiones.name)
                End If
            ElseIf ChkReg.Checked = False And Add = True Then
                RegAfter = New Region(-1, "Null")
            ElseIf Not Lblreg.Text.Equals("No tiene") Then
                If regiones.name = Lblreg.Text Then
                    RegAfter = New Region(regiones.id, regiones.name)
                End If
            Else
                RegAfter = New Region(-1, "Null")
            End If

        Next
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        Dim SymptAfter As String = ""

        If TxtDescr.Text.Trim.Length = 0 Or ChkListPath.CheckedItems.Count = 0 Then
            MessageBox.Show("Campos vacios o No selecciono patología asociada")
        Else
            SymptAfter = TxtDescr.Text
            AddNewPaths()
            AddNewRegion()

            If Add = True Then
                symptSend = New Symptom(-1, RegAfter, SymptAfter)
                Try
                    log.AddSymptoms(symptSend, PatAfter)
                    MessageBox.Show("Agregado con exito")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                symptSend = New Symptom(idSympt, RegAfter, SymptAfter)
                Try
                    log.UpdateSymptoms(symptSend, PatAfter)
                    MessageBox.Show("Modificado con exito!!")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class