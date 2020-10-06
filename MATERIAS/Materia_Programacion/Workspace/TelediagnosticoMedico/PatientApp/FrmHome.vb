﻿Imports Logic
Imports Data
Imports ADODB

Public Class FrmHome
    'Resource Manager: Administrador de Recursos propios del Proyecto 'PatientApp'.
    Private ReadOnly RM As Resources.ResourceManager = New Resources.ResourceManager("PatientApp.Resources", System.Reflection.Assembly.GetExecutingAssembly)


    'Atributos:
    Public ciPatientLoggedOn As String
    Private idPatientLoggedOn As Integer
    Dim dateRhtNow As String = Nothing
    Private patientLoggedOn As New Data.People
    Private chargePathology As List(Of Pathology)
    Private L1 As New Logic.Logic()

    

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
    Private Sub VisualSettings(myConfigPreset As Short, myBool1 As Boolean, myBool2 As Boolean, myBool3 As Boolean, myBool4 As Boolean, myBool5 As Boolean, myBool6 As Boolean, myBool7 As Boolean, myBool8 As Boolean, myBool9 As Boolean, myBool10 As Boolean)
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
    Private Sub VisualSettingPetition(info As String, image As String, b1 As Boolean, b2 As Boolean, b3 As Boolean, b4 As Boolean, b5 As Boolean, b6 As Boolean, b7 As Boolean, b8 As Boolean)
        BtnSendChatP.Visible = b1
        BtnSendChatP.Enabled = b2
        BtnEnd.Visible = b3
        BtnEnd.Enabled = b4
        PnlPetition.Visible = b5
        PnlPetition.Enabled = b6
        BtnCancelPetition.Visible = b7
        BtnCancelPetition.Enabled = b8
        LblPetitionInfo.Text = info
        PctbxPetition.Image = RM.GetObject(image)

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
        If LbxSufferedPatient.Items.Contains(" ") Then
            Console.WriteLine("No se asignaron sintomas para proceder.")
        Else
            VisualSettings(4, False, False, False, True, False, False, False, False, False, True)
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
            Me.PatholgiesSuffered = L1.ObtainPatholgiesSuffered(idPatientLoggedOn)

            'Trato el Panel con los Resultados
            'Hago un diagnostico (resumen/media) de los datos de "id_prioridad" -> Me define el color y mensaje del header.
            Dim qtyLeve As Integer = Nothing
            Dim qtyMedia As Integer = Nothing
            Dim qtyUrgente As Integer = Nothing

            chargePathology = New List(Of Pathology)
            Dim evidences As New List(Of String)
            evidences.Add("EVIDENCIA ALTA")
            evidences.Add("EVIDENCIA MEDIA")
            evidences.Add("EVIDENCIA BAJA")
            Dim orderedChargePathology As New List(Of Pathology)

            For Each pathology As Pathology In PatholgiesSuffered
                'Analizo mis cantidades de tipos de prioridades.
                Select Case pathology.priority.id
                    Case 1 'Prioridad = 1 "Alta"
                        qtyUrgente = qtyUrgente + 1
                    Case 2 'Prioridad = 2 "Media"
                        qtyMedia = qtyMedia + 1
                    Case 3 'Prioridad = 3 "Baja"
                        qtyLeve = qtyLeve + 1
                End Select

                'Analizo las evidencias para cada patologia obtenida.
                If pathology.mortalityIndex < 33 Then
                    chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA BAJA"))
                ElseIf pathology.mortalityIndex > 32 And pathology.mortalityIndex < 66 Then
                    chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA MEDIA"))
                ElseIf pathology.mortalityIndex > 65 Then
                    chargePathology.Add(New Pathology(pathology.name, "EVIDENCIA ALTA"))
                End If
            Next

            'Defino el resultado general.
            If qtyLeve > qtyMedia And qtyLeve > qtyUrgente Then
                'Panel informativo de color Verde = Poco o Leve Riesgo de Salud
                'No requiere valoración médica urgente
                PnlColorInfo.FillColor = Color.FromArgb(98, 186, 172)
                LblResultUrgent.Text = "No requiere de una valoración médica urgente."

            ElseIf qtyMedia > qtyUrgente Then
                'Panel informativo de color Ambar = Riesgo de Salud
                'Requiere valoración médica urgente
                PnlColorInfo.FillColor = Color.FromArgb(255, 208, 52)
                LblResultUrgent.Text = "Requiere de una pronta valoración médica."
            Else
                'Panel informativo de color Corál = Grave Riesgo de Salud
                'Requiere valoración médica urgente
                PnlColorInfo.FillColor = Color.FromArgb(251, 136, 133)
                LblResultUrgent.Text = "Requiere de una valoración médica urgente."
            End If

            'Ordeno por Evidencia la lista a cargar de patologias sufridas. Se ordena de mas alto a mas bajo las evidencias de las patologias
            For Each evidencess In evidences
                For Each path In chargePathology
                    If path.evidence.Equals(evidencess) Then
                        orderedChargePathology.Add(path)
                    End If
                Next
            Next

            For Each pat As Pathology In orderedChargePathology
                DgvPhatologies.Rows.Add(pat.name, pat.evidence)
            Next
            DgvPhatologies.Refresh()

        End If




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

            If LbxSufferedPatient.SelectedIndex = -1 Then
                Console.WriteLine("Debe de seleccionar un ítem para eliminarlo.")
            Else
                LbxSufferedPatient.Items.RemoveAt(LbxSufferedPatient.SelectedIndex)
            End If

            'No hay ningun elemento en el Lbx: Porque se borró el último existente?
            If LbxSufferedPatient.Items.Count = 0 Then
                LbxSufferedPatient.Items.Add(" ")
            End If
        End If

    End Sub
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False)
        VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)

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
        L1.UnsuscribePatient(idPatientLoggedOn)
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False)
        PatientApp.FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnSendChatP_Click(sender As Object, e As EventArgs) Handles BtnSendChatP.Click
        Dim d2 As String = DateTime.Now.Year
        Dim d3 As String = DateTime.Now.Month
        Dim d4 As String = DateTime.Now.Day
        Dim d5 As String = DateTime.Now.Hour
        Dim d6 As String = DateTime.Now.Minute
        Dim d7 As String = DateTime.Now.Second
        Me.dateRhtNow = d2 + "-" + d3 + "-" + d4 + " " + d5 + ":" + d6 + ":" + d7

        VisualSettingPetition("GENERANDO PETICIÓN", "loading", False, False, False, False, True, True, True, True)
        Dim a As Boolean = L1.MakePetition(idPatientLoggedOn, "Kjgkhchjccnbcv", Me.dateRhtNow, Me.dateRhtNow)
        If a Then
            VisualSettingPetition("PETICIÓN GENERADA CORRECTAMENTE", "check", False, False, False, False, True, True, True, True)
        Else
            VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)
        End If
    End Sub

    Private Sub BtnCancelPetition_Click(sender As Object, e As EventArgs) Handles BtnCancelPetition.Click
        Dim dateRhtNowCancel As String = Nothing
        Dim d2 As String = DateTime.Now.Year
        Dim d3 As String = DateTime.Now.Month
        Dim d4 As String = DateTime.Now.Day
        Dim d5 As String = DateTime.Now.Hour
        Dim d6 As String = DateTime.Now.Minute
        Dim d7 As String = DateTime.Now.Second
        dateRhtNowCancel = d2 + "-" + d3 + "-" + d4 + " " + d5 + ":" + d6 + ":" + d7
        Dim a As Boolean = L1.StopPetition(idPatientLoggedOn, "Se canceló la petición por parte del Paciente", Me.dateRhtNow, dateRhtNowCancel)
        If a Then
            VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)
        End If
    End Sub
End Class 'FrmHome