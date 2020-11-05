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
        LblTittleAddSymp_A_SA.Text = Translator.Instance.Translate("LblAddSympt_A_SA")
        LblActual_A_SA.Text = Translator.Instance.Translate("LblActual_A_SA")
        Lblreg.Text = ""
        ChkReg_A_SA.Text = Translator.Instance.Translate("ChkRegAdd_A_SA")
        Add = True
    End Sub

    Public Sub ModSympt(Sympt As String, Region As String)
        LblSymptTop.Text = Sympt
        Lblreg.Text = Region
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
        Translator.Instance.TranslateForm(Me)
        If Add = False Then
            LblSymptTop.Visible = True
            LblSymptTop.Text = SymptBefore.ToUpper()
            Lblreg.Visible = True
            TxtDescr.Text = SymptBefore
            Lblreg.Text = reg
        Else
            AddSympt()
            BtnImportCsv.Visible = True
        End If
        ReloadCmb()
        ReloadPat()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub ChkReg_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReg_A_SA.CheckedChanged
        If ChkReg_A_SA.Checked Then
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
            If ChkReg_A_SA.Checked = True Then
                If regiones.name = Cmbreg.SelectedItem.ToString() Then
                    RegAfter = New Region(regiones.id, regiones.name)
                End If
            ElseIf ChkReg_A_SA.Checked = False And Add = True Then
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
            MessageBox.Show(Translator.Instance.Translate("EmptyFields_A_SA"))
        Else
            SymptAfter = TxtDescr.Text
            AddNewPaths()
            AddNewRegion()

            If Add = True Then
                symptSend = New Symptom(-1, RegAfter, SymptAfter)
                Try
                    log.AddSymptoms(symptSend, PatAfter)
                    MessageBox.Show(Translator.Instance.Translate("AddWithSuccess"))
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                symptSend = New Symptom(idSympt, RegAfter, SymptAfter)
                Try
                    log.UpdateSymptoms(symptSend, PatAfter)
                    MessageBox.Show(Translator.Instance.Translate("ModifyWithSuccess"))
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnImportCsv_Click(sender As Object, e As EventArgs) Handles BtnImportCsv.Click
        Dim Symptoms As New List(Of Symptom)
        Dim region As List(Of Region) = log.ObtainRegions()
        Try
            If OfdAddSympt.ShowDialog And OfdAddSympt.FileName.Length > 0 Then
                Dim lines As String() = IO.File.ReadAllLines(OfdAddSympt.FileName)
                For Each line As String In lines
                    Dim result As String() = line.Split(",")
                    For Each Reg As Region In region
                        If Reg.id.ToString().Equals(result(0)) Then
                            Symptoms.Add(New Symptom(-1, Reg, result(1)))
                        End If
                    Next
                    If result(0).Equals("NULL") Then
                        Symptoms.Add(New Symptom(-1, result(1)))
                    End If
                Next
            End If
            If Symptoms.Count > 0 Then
                log.AddSymptomsFromCsv(Symptoms)
                MessageBox.Show(Translator.Instance.Translate("AddWithSuccess") + vbCrLf + Translator.Instance.Translate("CsvSymptomsMsg"))
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class