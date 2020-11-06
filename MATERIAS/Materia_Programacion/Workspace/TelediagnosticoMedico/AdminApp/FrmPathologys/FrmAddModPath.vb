Imports Logic
Imports Data
Public Class FrmAddModPath
    Dim log As New Logic.Controller()
    Dim row As DataGridViewRow
    Dim KindPath As New List(Of KindPath)
    Dim Kind As String = Nothing

    Public Shared PathMod As Pathology = Nothing
    Public Shared TreatmentsMod As List(Of Treatment) = Nothing
    Public Shared Add As Boolean = False

    Public Sub ReloadDgv()
        For Each Treatment As Treatment In TreatmentsMod
            DgvTreat.Rows.Add(Treatment.name, Treatment.description, Treatment.kind)
        Next
    End Sub

    Public Sub ReloadPat()
        TxtName.Text = PathMod.name
        TxtDescr.Text = PathMod.description
        Spinner.Value = PathMod.mortalityIndex
        For i = 0 To CmbTipo.Items.Count - 1
            If CmbTipo.Items(i).ToString().Equals(PathMod.kind.name) Then
                CmbTipo.SelectedIndex = i
            End If
        Next
    End Sub

    Public Sub ReloadCmb()
        KindPath = log.ObtainKindPath()
        For Each kind As KindPath In KindPath
            CmbTipo.Items.Add(kind.name)
        Next
    End Sub

    Private Sub FixTranslate()
        Asterisco.Text = "*"
        GunaLabel1.Text = "*"
        GunaLabel2.Text = "*"
        GunaLabel9.Text = "*"
        GunaLabel6.Text = "*"
        GunaLabel7.Text = "*"
        GunaLabel8.Text = "*"
        GunaLabel1.Text = "*"
        BtnDelTreat.Text = "-"
        LblPat.Text = ""
        LblPatTop.Text = ""
        LblPrioridad.Text = "BAJA"
    End Sub

    Private Sub FrmModPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Translator.Instance.TranslateForm(Me)
        FixTranslate()
        ReloadCmb()
        If Add = False Then
            LblPat.Text = PathMod.name.ToUpper()
            ReloadDgv()
            ReloadPat()
        Else
            LblTitle1_A_HPP.Text = Translator.Instance.Translate("LblTitle1_A_HPP_Add")
            BtnAddPath_A_HPP.Text = Translator.Instance.Translate("BtnAddPath_A_HPP_Add")
            BtnImportCsv.Visible = True
        End If
    End Sub

    Public Sub AddTreat()
        DgvTreat.Rows.Add(TxtTreatName.Text, TxtTreatDesc.Text, Kind)
        DgvTreat.Refresh()
        TxtTreatName.Clear()
        TxtTreatDesc.Clear()
        If RdbtnMedicine_A_HPP.Checked Then
            RdbtnMedicine_A_HPP.Checked = False
        ElseIf RdbtnQuir_A_HPP.Checked Then
            RdbtnQuir_A_HPP.Checked = False
        End If
    End Sub

    Private Sub BtnAddTreat_Click(sender As Object, e As EventArgs) Handles BtnAddTreat.Click
        Dim Exist As Boolean = False
        If Not TxtTreatDesc.Text.Trim.Length = 0 Or Not TxtTreatName.Text.Trim.Length = 0 Or RdbtnMedicine_A_HPP.Checked Or RdbtnQuir_A_HPP.Checked Then
            If RdbtnMedicine_A_HPP.Checked Then
                Kind = "Medicamento"
            ElseIf RdbtnQuir_A_HPP.Checked Then
                Kind = "Quirurjico"
            Else
                MessageBox.Show(Translator.Instance.Translate("TreatmentsEmpty_A_P"))
                Return
            End If

            If DgvTreat.Rows.Count - 1 > 0 Then
                For i As Integer = 0 To DgvTreat.Rows.Count - 1
                    If (CStr(DgvTreat.Rows(i).Cells("name").Value) = TxtTreatName.Text) Then
                        MessageBox.Show(Translator.Instance.Translate("TreatmentAlreadyExists_A_P"))
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
            MessageBox.Show(Translator.Instance.Translate("TreatmentsEmpty_A_P"))
            Return
        End If
    End Sub
    Private Sub BtnDelTreat_Click(sender As Object, e As EventArgs) Handles BtnDelTreat.Click
        If DgvTreat.Rows.Count - 1 > 0 Then
            row = DgvTreat.CurrentRow
            DgvTreat.Rows.Remove(row)
            TxtTreatName.Clear()
            TxtTreatDesc.Clear()
            RdbtnMedicine_A_HPP.Checked = False
            RdbtnQuir_A_HPP.Checked = False
        Else
            MessageBox.Show(Translator.Instance.Translate("NotExistTreatmentsToDel_A_P"))
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
            RdbtnMedicine_A_HPP.Checked = True
        Else
            RdbtnQuir_A_HPP.Checked = True
        End If
    End Sub

    Private Sub BtnModTreat_Click(sender As Object, e As EventArgs) Handles BtnModTreat.Click

        If DgvTreat.Rows.Count - 1 > 0 Then
            If RdbtnMedicine_A_HPP.Checked Then
                Kind = "Medicamento"
            ElseIf RdbtnQuir_A_HPP.Checked Then
                Kind = "Quirurjico"
            Else
                MessageBox.Show(Translator.Instance.Translate("TreatmentsEmpty_A_P"))
                Return
            End If
            row = DgvTreat.CurrentRow
            Dim nametreat As String = CStr(row.Cells("name").Value)
            row.SetValues(TxtTreatName.Text, TxtTreatDesc.Text, Kind)
            TxtTreatName.Clear()
            TxtTreatDesc.Clear()
            If RdbtnMedicine_A_HPP.Checked Then
                RdbtnMedicine_A_HPP.Checked = False
            ElseIf RdbtnQuir_A_HPP.Checked Then
                RdbtnQuir_A_HPP.Checked = False
            End If
        Else
            MessageBox.Show(Translator.Instance.Translate("NotExistTreatmentsToMod_A_P"))
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
        Add = False
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAddPath_A_HPP.Click
        Dim Prior As Integer = 0

        If Not TxtName.Text.Trim.Length = 0 Or Not TxtDescr.Text.Trim.Length = 0 Then
            Dim PatAfter As String = TxtName.Text
            Dim PatDescAfter As String = TxtDescr.Text
            Dim PatMortalityAfter As Integer = Spinner.Value
            Dim PriorityAfter As String = LblPrioridad.Text
            Dim PathSend As Pathology = Nothing
            Dim KindSend As KindPath = Nothing
            Dim TreatmentsSend As New List(Of Treatment)

            Try
                If DgvTreat.Rows.Count - 1 = 0 Then
                    MessageBox.Show(Translator.Instance.Translate("TreatmentsEmpty_A_P_Add") & vbCrLf & Translator.Instance.Translate("TreatmentsEmpty_A_P_AddComment"))
                    Return
                End If

                If PriorityAfter.Equals("BAJA") Then
                    Prior = 3
                ElseIf PriorityAfter.Equals("MEDIA") Then
                    Prior = 2
                Else
                    Prior = 1
                End If

                For Each kind As KindPath In KindPath
                    If kind.name.Equals(CmbTipo.SelectedItem.ToString()) Then
                        KindSend = New KindPath(kind.id, kind.name)
                    End If
                Next

                If Add = False Then
                    PathSend = New Pathology(PathMod.id, New Priority(Prior, PriorityAfter), PatAfter, PatDescAfter, PatMortalityAfter, KindSend)
                Else
                    PathSend = New Pathology(-1, New Priority(Prior, PriorityAfter), PatAfter, PatDescAfter, PatMortalityAfter, KindSend)
                End If

                For i As Integer = 0 To DgvTreat.Rows.Count - 1
                    If IsNothing(DgvTreat.Rows(i).Cells("name").Value) Then

                    Else
                        Dim treatname As String = CStr(DgvTreat.Rows(i).Cells("name").Value)
                        Dim treatdesc As String = CStr(DgvTreat.Rows(i).Cells("desc").Value)
                        Dim treatkind As String = CStr(DgvTreat.Rows(i).Cells("type").Value)
                        TreatmentsSend.Add(New Treatment(PathSend, treatname, treatdesc, treatkind))
                    End If
                Next

                Dim check As Integer = log.CheckUpdatePathology(PathSend, TreatmentsSend)

                If check = 0 And Add = False Then
                    log.UpdatePathology(PathSend, TreatmentsSend) 'Actualizo la patología en conjunto con sus tratamientos asociados
                    MessageBox.Show(Translator.Instance.Translate("ModifyWithSuccess"))
                    Me.Close()
                ElseIf check = 0 And Add = True Then
                    log.AddPathology(PathSend, TreatmentsSend) 'Inserto la patología en conjunto con sus tratamientos asociados
                    MessageBox.Show(Translator.Instance.Translate("AddWithSuccess"))
                    Add = False
                    Me.Close()
                ElseIf check = 1 Then
                    MessageBox.Show(Translator.Instance.Translate("CheckPathName_A_P"))
                    Return
                ElseIf check = 3 Then
                    MessageBox.Show(Translator.Instance.Translate("CheckPathTreat_A_P"))
                    Return
                Else
                    MessageBox.Show(Translator.Instance.Translate("CheckPathN&T_A_P"))
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show(Translator.Instance.Translate("PathologyEmpty_A_P"))
        End If
    End Sub

    Private Sub BtnImportCsv_Click(sender As Object, e As EventArgs) Handles BtnImportCsv.Click
        Dim Pathologies As New List(Of Pathology)
        Dim priorities As List(Of Priority) = log.ObtainPriorities()
        Dim kinds As List(Of KindPath) = log.ObtainKindPath()

        Try
            If OfdAddPathology.ShowDialog And OfdAddPathology.FileName.Length > 0 Then
                Dim lines As String() = IO.File.ReadAllLines(OfdAddPathology.FileName)
                For Each line As String In lines
                    Dim result As String() = line.Split(",")
                    For Each Prior As Priority In priorities
                        For Each Kind As KindPath In kinds
                            If Prior.id.ToString().Equals(result(0)) And Kind.id.ToString().Equals(result(4)) Then
                                Pathologies.Add(New Pathology(-1, Prior, result(1), result(2), result(3), Kind))
                            End If
                        Next
                    Next
                Next
            End If
            If Pathologies.Count > 0 Then
                log.AddPathologyFromCsv(Pathologies)
                MessageBox.Show(Translator.Instance.Translate("AddWithSuccess") + vbCrLf + Translator.Instance.Translate("CsvPath_A_P"))
                Add = False
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class