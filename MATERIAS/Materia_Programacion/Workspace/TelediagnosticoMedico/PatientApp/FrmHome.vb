Imports Logic
Imports Data

Public Class FrmHome
    'Resource Manager: Administrador de Recursos propios del Proyecto 'PatientApp'.
    Private ReadOnly RM As Resources.ResourceManager = New Resources.ResourceManager("PatientApp.Resources", System.Reflection.Assembly.GetExecutingAssembly)


    'Atributos:
    Private ReadOnly L1 As New Logic.Controller()
    Public ciPatientLoggedOn As String
    Private idPatientLoggedOn As Integer
    Private patientLoggedOn As New Data.People
    Private dateTimeMadePetition As String
    Private chargePathology As List(Of Pathology)
    Private time As Integer = 0
    Private idRoom As Integer = 0
    Private talkingMed As Medic
    Private chat As String = ""


    'Query:
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
    Private Sub VisualSettings(myConfigPreset As Short, myBool1 As Boolean, myBool2 As Boolean, myBool3 As Boolean, myBool4 As Boolean, myBool5 As Boolean, myBool6 As Boolean, myBool7 As Boolean, myBool8 As Boolean, myBool9 As Boolean, myBool10 As Boolean, myBool11 As Boolean)
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

            Case 5
                Lbl1_Intro.ForeColor = Color.Black
                Lbl1_Intro.Font = New Font(Lbl1_Intro.Font, FontStyle.Regular)

                Lbl2_Patient.ForeColor = Color.Black
                Lbl2_Patient.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl3_Symptom.ForeColor = Color.Black
                Lbl3_Symptom.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl4_Result.ForeColor = Color.Black
                Lbl4_Result.Font = New Font(Lbl2_Patient.Font, FontStyle.Regular)

                Lbl5_Chat.ForeColor = Color.Black
                Lbl5_Chat.Font = New Font(Lbl2_Patient.Font, FontStyle.Bold)

                talkingMed = L1.ObtainTalkingMed(idPatientLoggedOn, dateTimeMadePetition)
                LblMedic.Text = talkingMed.fstName + " " + talkingMed.scndName + " " + talkingMed.fstSurname + " " + talkingMed.scndSurname
                idRoom = Controller.Instance.idRoom
                TxtChatSend.Focus()
                TimerChat.Start()

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Green")
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
        PnlChat.Visible = myBool11
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
    Private Function ObtainSymptoms()
        Return L1.ObtainSymptoms()
    End Function
    Private Sub LoadIdPatientLoggedOn()
        Me.idPatientLoggedOn = L1.matchPatientLoggedOn(Me.ciPatientLoggedOn)
    End Sub
    Private Sub LoadSympSuffred(lbxSuffredPatient As System.Windows.Forms.ListBox)
        Dim sympSuffred As New List(Of String)

        For Each lbxSympSuffred In lbxSuffredPatient.Items
            sympSuffred.Add(lbxSympSuffred.ToString)
        Next

        L1.LoadSympSuffred(Me.idPatientLoggedOn, sympSuffred)
    End Sub
    Private Function GetNowDateTime(prefix As Short) As String
        Return L1.GetNowDateTime(prefix)
    End Function


    'Eventos:
    Private Sub BtnNext_Intro2_Click(sender As Object, e As EventArgs) Handles BtnNext_Intro2.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False, False)
    End Sub
    Private Sub BtnNext_Patient_Click(sender As Object, e As EventArgs) Handles BtnNext_Patient.Click
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False, False)
    End Sub
    Private Sub BtnNext_Symptom1_Click(sender As Object, e As EventArgs) Handles BtnNext_Symptom1.Click
        VisualSettings(3, False, False, True, False, False, False, False, False, True, False, False)
    End Sub
    Private Sub BtnBack_Intro2_Click(sender As Object, e As EventArgs) Handles BtnBack_Intro2.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False, False)
    End Sub
    Private Sub BtnNext_Result_Click(sender As Object, e As EventArgs) Handles BtnNext_Result.Click
        If LbxSufferedPatient.Items.Contains(" ") Then
            Console.WriteLine("No se asignaron sintomas para proceder.")
        Else
            VisualSettings(4, False, False, False, True, False, False, False, False, False, True, False)

            Me.LoadSympSuffred(LbxSufferedPatient)

            'Cargo las Patologias Sufridas en una Lista
            PatholgiesSuffered = New List(Of Pathology)
            Try
                Me.PatholgiesSuffered = L1.ObtainPatholgiesSuffered(idPatientLoggedOn)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

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
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False, False)
    End Sub
    Private Sub CbxSysSymptoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSysSymptoms.SelectedIndexChanged
        Dim doesExistInTheLbx As Boolean
        Dim a As Object = " "
        Dim doesItemGhostExist As Boolean = False

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
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False, False)
        VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)
        LoadIdPatientLoggedOn()

        'GhostItem: Es mi elemento del Lbx que me permite utilizarlo (For, recorrer) cuando hay elemento != de Symptoms (Cmbx)
        'Este existe al inicio (record de FrmHome) y cada vez que Lbx se queda con 1 Item de Symptoms (Cmbx)
        LbxSufferedPatient.Items.Clear()
        LbxSufferedPatient.Items.Add(" ") 'Mi GhostItem del Lbx

        'Opero con los Sintomas:
        Dim symptoms As List(Of Symptom) = Me.ObtainSymptoms
        For Each symp As Symptom In symptoms
            CbxSysSymptoms.Items.Add(symp.Description)
        Next

        'Operar el Dgv Patologias
        Dim col1, col2 As New DataGridViewTextBoxColumn
        DgvPhatologies.ReadOnly = True
        col1.Name = "Patología"
        col2.Name = "Evidencia"
        DgvPhatologies.Columns.Add(col1)
        DgvPhatologies.Columns.Add(col2)
    End Sub
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        L1.UnsuscribePatient(idPatientLoggedOn)
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False, False)
        PatientApp.FrmLogin.Show()
        Me.Close()
    End Sub
    Private Sub BtnSendChatP_Click(sender As Object, e As EventArgs) Handles BtnSendChatP.Click
        VisualSettingPetition("GENERANDO PETICIÓN", "loading", False, False, False, False, True, True, True, True)

        Me.dateTimeMadePetition = Me.GetNowDateTime(1)
        Dim validate As Boolean = L1.MakePetition(idPatientLoggedOn, "Empty", Me.dateTimeMadePetition, Me.GetNowDateTime(1))

        If validate Then
            VisualSettingPetition("PETICIÓN GENERADA CORRECTAMENTE", "check", False, False, False, False, True, True, True, True)
            time = 0
            TimerRequest.Start()
        Else
            VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)
        End If
    End Sub
    Private Sub BtnCancelPetition_Click(sender As Object, e As EventArgs) Handles BtnCancelPetition.Click
        Dim validate As Boolean = L1.StopPetition(idPatientLoggedOn, "Paciente solicitó cancelar la petición.", Me.dateTimeMadePetition, Me.GetNowDateTime(1))

        If validate Then
            VisualSettingPetition("GENERANDO PETICIÓN", "loading", True, True, True, True, False, False, False, False)
        End If
    End Sub

    'Chat
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Try
            L1.SendMessage(idPatientLoggedOn, idRoom, TxtChatSend.Text, DateTime.Now.ToString("HH:mm:ss"))
            ObtainMsg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TxtChatSend.Clear()
        TxtChatSend.Focus()
    End Sub

    Public Sub ObtainMsg()
        chat = Nothing
        Try
            For Each msg As Message In L1.ObtainMessages(idPatientLoggedOn, idRoom)
                If chat = Nothing And msg.idP = idPatientLoggedOn Then
                    chat = "Tú: " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                ElseIf chat = Nothing And msg.idP <> idPatientLoggedOn Then
                    chat = talkingMed.fstName + " " + talkingMed.scndName + " " + talkingMed.fstSurname + " " + talkingMed.scndSurname +
                        ": " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                ElseIf msg.idP = idPatientLoggedOn Then
                    chat = chat + vbCrLf + "Tú: " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                Else
                    chat = chat + vbCrLf + talkingMed.fstName + " " + talkingMed.scndName + " " + talkingMed.fstSurname + " " + talkingMed.scndSurname +
                        ": " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                End If
            Next
            TxtChat.Text = chat
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtChatSend_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChatSend.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSend.PerformClick()
        End If
    End Sub
    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        time = time + 1
        If time > 4 Then
            Try
                ObtainMsg()
                time = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub TimerRequest_Tick(sender As Object, e As EventArgs) Handles TimerRequest.Tick
        time = time + 1
        If time > 4 Then
            Try 'Verificar si la peticion ha sido aceptada
                L1.WaitingAccept(idPatientLoggedOn, dateTimeMadePetition)
                VisualSettings(5, False, False, False, False, False, True, False, False, False, False, True)
                TimerRequest.Stop()
            Catch ex As Exception

            End Try
            time = 0
        End If
    End Sub
End Class 'FrmHome