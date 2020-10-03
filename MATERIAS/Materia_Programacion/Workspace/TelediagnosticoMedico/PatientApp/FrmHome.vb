﻿Imports Logic
Imports Data
Imports ADODB

Public Class FrmHome
    'Resource Manager: Administrador de Recursos propios del Proyecto 'PatientApp'.
    Private ReadOnly RM As Resources.ResourceManager = New Resources.ResourceManager("PatientApp.Resources", System.Reflection.Assembly.GetExecutingAssembly)
    'Atributos:
    Public ciPatientLoggedOn As String
    Private idPatientLoggedOn As Integer
    Private patientLoggedOn As New Data.People
    Private chargePathology As List(Of Pathology)
    Private L1 As New Logic.Logica()

    'Query:
    Private Symptoms As List(Of Data.Symptom)
    Private idSympSuffered As New List(Of Integer)
    Private PatholgiesSuffered As List(Of Pathology)

    'Comportamientos:
    ''' <summary>
    ''' Preset precargado que ayuda a tratar la disposición de paneles y sus elementos.
    ''' </summary>
    ''' <param name="myConfigPreset">Selecciona un preset para Labels</param>
    ''' <param name="myBool1">Si es Visible BarVertical Pctbx1_Intro</param>
    ''' <param name="myBool2">Si es Visible BarVertical Pctbx2_Patient</param>
    ''' <param name="myBool3">Si es Visible BarVertical Pctbx3_Symptom</param>
    ''' <param name="myBool4">Si es Visible BarVertical Pctbx4_Result</param>
    ''' <param name="myBool5">Si es Visible BarVertical Pctbx5_Chat</param>
    ''' <param name="myBool6">Si es Visible Panel PnlIntro1</param>
    ''' <param name="myBool7">Si es Visible Panel PnlIntro2</param>
    ''' <param name="myBool8">Si es Visible Panel PnlPatient1</param>
    ''' <param name="myBool9">Si es Visible Panel PnlSymptom</param>
    ''' <param name="myBool10">Si es Visible Panel PnlResult</param>
    Public Sub VisualSettings(myConfigPreset As Short, myBool1 As Boolean, myBool2 As Boolean, myBool3 As Boolean, myBool4 As Boolean, myBool5 As Boolean, myBool6 As Boolean, myBool7 As Boolean, myBool8 As Boolean, myBool9 As Boolean, myBool10 As Boolean)
        'Label: Me centro en los atributos variantes para cada Panel.
        Select Case myConfigPreset
            Case 1 '1 = Stage Intro
                Lbl1_Intro.ForeColor = Color.Black
                Lbl1_Intro.Font = New Font(Lbl1_Intro.Font, FontStyle.Bold)

                Lbl2_Patient.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl2_Patient.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl3_Symptom.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl3_Symptom.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl4_Result.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl5_Chat.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Green")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 2 '3 = Stage Patient
                Lbl1_Intro.ForeColor = Color.Black
                Lbl1_Intro.Font = New Font(Lbl1_Intro.Font, FontStyle.Regular)

                Lbl2_Patient.ForeColor = Color.Black
                Lbl2_Patient.Font = New Font(Lbl2_Patient.Font, FontStyle.Bold)

                Lbl3_Symptom.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl3_Symptom.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl4_Result.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl5_Chat.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Green")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 3 '3 = Stage Symptom
                Lbl1_Intro.ForeColor = Color.Black
                Lbl1_Intro.Font = New Font(Lbl1_Intro.Font, FontStyle.Regular)

                Lbl2_Patient.ForeColor = Color.Black
                Lbl2_Patient.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl3_Symptom.ForeColor = Color.Black
                Lbl3_Symptom.Font = New Font(Lbl2_Patient.Font, FontStyle.Bold)

                Lbl4_Result.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl5_Chat.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Green")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 4 '4 = Stage Result
                Lbl1_Intro.ForeColor = Color.Black
                Lbl1_Intro.Font = New Font(Lbl1_Intro.Font, FontStyle.Regular)

                Lbl2_Patient.ForeColor = Color.Black
                Lbl2_Patient.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl3_Symptom.ForeColor = Color.Black
                Lbl3_Symptom.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl4_Result.ForeColor = Color.Black
                Lbl4_Result.Font = New Font(Lbl2_Patient.Font, FontStyle.Bold)

                Lbl5_Chat.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Green")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")
        End Select

        'Glovo flotante: Glovo visible del panel posicionado.
        Pctbx1_Intro.Visible = myBool1
        Pctbx2_Patient.Visible = myBool2
        Pctbx3_Symptom.Visible = myBool3
        Pctbx4_Result.Visible = myBool4
        Pctbx5_Chat.Visible = myBool5

        'Panel: El primero en visualizar.
        PnlIntro1.Visible = myBool6
        PnlIntro2.Visible = myBool7
        PnlPatient.Visible = myBool8
        PnlSymptom.Visible = myBool9
        PnlResult.Visible = myBool10
    End Sub

    Public Sub GetIdPatientLoggedOn()
        Me.idPatientLoggedOn = L1.matchPatientLoggedOn(Me.ciPatientLoggedOn)
    End Sub

    Public Sub LoadSymptoms()
        Me.Symptoms = L1.ObtainSymptoms()
    End Sub

    'Eventos:
    Private Sub BtnNext_Intro2_Click(sender As Object, e As EventArgs) Handles BtnNext_Intro2.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False)
    End Sub

    Private Sub BtnNext_Patient_Click(sender As Object, e As EventArgs) Handles BtnNext_Patient.Click
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False)
    End Sub

    Private Sub BtnNext_Symptom1_Click(sender As Object, e As EventArgs) Handles BtnNext_Symptom1.Click
        VisualSettings(3, False, False, True, False, False, False, False, False, True, False)
    End Sub

    Private Sub BtnBack_Intro2_Click(sender As Object, e As EventArgs) Handles BtnBack_Intro2.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False)
    End Sub

    Private Sub BtnNext_Result_Click(sender As Object, e As EventArgs) Handles BtnNext_Result.Click
        'Reconozco los Id de cada Sintoma que sufre el Paciente.
        For Each symptomsSuffred In LbxSufferedPatient.Items
            For Each symptom As Symptom In Symptoms
                If symptom.Description.Equals(symptomsSuffred.ToString) Then
                    idSympSuffered.Add(symptom.Id)
                End If
            Next 'For [symptom] para cada Síntoma existente. 
        Next 'For [symptomsSuffred] para cada item del ListBox que contiene los Síntomas que Sufre el Paciente.

        'Almaceno en la Base de Datos los Sintomas que sufre el Paciente, y su Id para referenciarlo
        L1.SetPatientSufferSymp(idPatientLoggedOn, idSympSuffered)

        'Cargo las Patologias Sufridas en una Lista
        PatholgiesSuffered = New List(Of Pathology)
        Me.PatholgiesSuffered = L1.ObtainPatholgiesSuffered

        'Trato el Panel con los Resultados
        ''Hago un diagnostico (resumen/media) de los datos de "id_prioridad" -> Me define el color y mensaje del header.
        Dim leve1 As Integer = Nothing
        Dim urgente2o3 As Integer = Nothing

        chargePathology = New List(Of Pathology)
        For Each pathology As Pathology In PatholgiesSuffered
            If pathology.priority.id > 1 Then
                leve1 = leve1 + 1
            Else
                urgente2o3 = urgente2o3 + 1
            End If

            If pathology.mortalityIndex < 33 Then
                chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA BAJA"))
            ElseIf pathology.mortalityIndex > 32 And pathology.mortalityIndex < 66 Then
                chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA MEDIA"))
            ElseIf pathology.mortalityIndex > 65 Then
                chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA ALTA"))
            End If
        Next

        If leve1 > urgente2o3 Then
            ''Panel informativo de color Verde = Poco o Leve Riesgo de Salud
            ''No requiere valoración médica urgente
            PnlColorInfo.FillColor = Color.FromArgb(98, 186, 172)
            LblResultUrgent.Text = "No requiere de una valoración Médica urgente."

        Else
            ''Panel informativo de color Corál = Grave Riesgo de Salud
            ''Requiere valoración médica urgente
            PnlColorInfo.FillColor = Color.FromArgb(251, 136, 133)
            LblResultUrgent.Text = "Requiere de una valoración Médica urgente."
        End If

        VisualSettings(4, False, False, False, True, False, False, False, False, False, True)

        For Each pat As Pathology In chargePathology
            DgvPhatologies.Rows.Add(pat.name, pat.evidence)
        Next
        DgvPhatologies.Refresh()

    End Sub

    Private Sub BtnBack_Patient1_Click(sender As Object, e As EventArgs) Handles BtnBack_Patient1.Click
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False)
    End Sub



    Private Sub CbxSysSymptoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSysSymptoms.SelectedIndexChanged
        Dim doesExistInTheLbx As Boolean
        Dim a As Object = " "
        Dim doesItemGhostExist As Boolean = False 'Existe ItemGhost?

        For Each LbxItem In LbxSufferedPatient.Items
            If LbxItem.ToString = a.ToString Then
                doesItemGhostExist = True 'Existe el ItemGhost 
            End If
        Next

        If doesItemGhostExist Then
            LbxSufferedPatient.Items.Clear()
            doesExistInTheLbx = False 'Misma accion de agregar. 
        Else
            For Each itemSelectedFormLbx In LbxSufferedPatient.Items
                If CbxSysSymptoms.SelectedItem.ToString.Equals(itemSelectedFormLbx.ToString) Then
                    doesExistInTheLbx = True 'Es decir, que ya existe en la lista
                End If
            Next
        End If

        If doesExistInTheLbx = False Then
            LbxSufferedPatient.Items.Add(CbxSysSymptoms.SelectedItem)
        End If

    End Sub

    Private Sub BtnDropPathology_Click(sender As Object, e As EventArgs) Handles BtnDropPathology.Click
        'Quiero eliminar el GhostItem?
        If LbxSufferedPatient.Items.Count = 0 Then
            LbxSufferedPatient.Items.RemoveAt(LbxSufferedPatient.SelectedIndex)
            LbxSufferedPatient.Items.Add(" ")
        Else
            'Intento borrar el item seleccionado, porque puede que no se haya seleccionado uno
            Try
                LbxSufferedPatient.Items.RemoveAt(LbxSufferedPatient.SelectedIndex)
            Catch ex As Exception
                'Debe de seleccionar un item para eliminarlo.
            End Try

            'No hay ningun elemento en el Lbx: Porque se borró el último existente?
            If LbxSufferedPatient.Items.Count = 0 Then
                LbxSufferedPatient.Items.Add(" ")
            End If
        End If

    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False)

        'GhostItem: Es mi elemento del Lbx que me permite utilizarlo (For, recorrer) cuando hay elemento != de Symptoms (Cmbx)
        'Este existe al inicio (record de FrmHome) y cada vez que Lbx se queda con 1 Item de Symptoms (Cmbx)
        LbxSufferedPatient.Items.Clear()
        LbxSufferedPatient.Items.Add(" ") 'Mi GhostItem del Lbx

        'Opero con los Sintomas:
        GetIdPatientLoggedOn()
        LoadSymptoms()
        For Each symp As Symptom In Symptoms
            CbxSysSymptoms.Items.Add(symp.description)
        Next
        Dim col1, col2 As New DataGridViewTextBoxColumn

        'Operar el Dgv Patologias
        DgvPhatologies.ReadOnly = True
        col1.Name = "Patología"
        col2.Name = "Evidencia"
        DgvPhatologies.Columns.Add(col1)
        DgvPhatologies.Columns.Add(col2)
    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False)
        PatientApp.FrmLogin.Show()
        Me.Close()
    End Sub
End Class 'FrmHome