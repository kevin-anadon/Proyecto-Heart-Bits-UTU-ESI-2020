Imports Logic
Imports Data

Public Class FrmHome 'Paciente
    'Resource Manager: Administrador de Recursos propios del Proyecto 'PatientApp'.
    Private ReadOnly RM As Resources.ResourceManager = New Resources.ResourceManager("PatientApp.Resources", System.Reflection.Assembly.GetExecutingAssembly)


    'Atributos:
    Private ReadOnly L1 As New Logic.Controller()
    Private ReadOnly Translator As New Logic.Translator()
    Public ciPatientLoggedOn As String
    Private idPatientLoggedOn As Integer
    Private patientLoggedOn As New Data.People
    Private dateTimeMadePetition As String
    Private time As Integer = 0
    Private idRoom As Integer = 0
    Private talkingMed As Medic
    Private chat As String = ""
    Private PatholgiesSuffered As List(Of Pathology)

    'Private a As String = Me.Translator.Translate("a", "asd")

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
                Lbl1_Intro_P_H.ForeColor = Color.Black
                Lbl1_Intro_P_H.Font = New Font(Lbl1_Intro_P_H.Font, FontStyle.Bold)

                Lbl2_Patient_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl2_Patient_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl3_Symptom_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl3_Symptom_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl4_Result_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl5_Chat_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Green")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 2 '3 = Stage Patient
                Lbl1_Intro_P_H.ForeColor = Color.Black
                Lbl1_Intro_P_H.Font = New Font(Lbl1_Intro_P_H.Font, FontStyle.Regular)

                Lbl2_Patient_P_H.ForeColor = Color.Black
                Lbl2_Patient_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Bold)

                Lbl3_Symptom_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl3_Symptom_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl4_Result_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl5_Chat_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Green")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 3 '3 = Stage Symptom
                Lbl1_Intro_P_H.ForeColor = Color.Black
                Lbl1_Intro_P_H.Font = New Font(Lbl1_Intro_P_H.Font, FontStyle.Regular)

                Lbl2_Patient_P_H.ForeColor = Color.Black
                Lbl2_Patient_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl3_Symptom_P_H.ForeColor = Color.Black
                Lbl3_Symptom_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Bold)

                Lbl4_Result_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl4_Result_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl5_Chat_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Green")
                Line4_Result.Image = RM.GetObject("BarVertical_Grey")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 4 '4 = Stage Result
                Lbl1_Intro_P_H.ForeColor = Color.Black
                Lbl1_Intro_P_H.Font = New Font(Lbl1_Intro_P_H.Font, FontStyle.Regular)

                Lbl2_Patient_P_H.ForeColor = Color.Black
                Lbl2_Patient_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl3_Symptom_P_H.ForeColor = Color.Black
                Lbl3_Symptom_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl4_Result_P_H.ForeColor = Color.Black
                Lbl4_Result_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Bold)

                Lbl5_Chat_P_H.ForeColor = Color.FromArgb(181, 181, 181)
                Lbl5_Chat_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                'Vertical Bar: Imágenes variantes - Vertical Bar 
                Line1_Intro.Image = RM.GetObject("BarVertical_Grey")
                Line2_Patient.Image = RM.GetObject("BarVertical_Grey")
                Line3_Symptom.Image = RM.GetObject("BarVertical_Grey")
                Line4_Result.Image = RM.GetObject("BarVertical_Green")
                Line5_Chat.Image = RM.GetObject("BarVertical_Grey")

            Case 5
                Lbl1_Intro_P_H.ForeColor = Color.Black
                Lbl1_Intro_P_H.Font = New Font(Lbl1_Intro_P_H.Font, FontStyle.Regular)

                Lbl2_Patient_P_H.ForeColor = Color.Black
                Lbl2_Patient_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl3_Symptom_P_H.ForeColor = Color.Black
                Lbl3_Symptom_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl4_Result_P_H.ForeColor = Color.Black
                Lbl4_Result_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Regular)

                Lbl5_Chat_P_H.ForeColor = Color.Black
                Lbl5_Chat_P_H.Font = New Font(Lbl2_Patient_P_H.Font, FontStyle.Bold)

                Try
                    talkingMed = L1.ObtainTalkingMed(idPatientLoggedOn, dateTimeMadePetition)
                    LblMedic.Text = talkingMed.fstName + " " + talkingMed.scndName + " " + talkingMed.fstSurname + " " + talkingMed.scndSurname
                    idRoom = Controller.Instance.ObtainRoomMed()
                Catch ex As Exception

                End Try
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
        BtnSendChatP_P_H.Visible = b1
        BtnSendChatP_P_H.Enabled = b2
        BtnEnd_P_H.Visible = b3
        BtnEnd_P_H.Enabled = b4
        PnlPetition.Visible = b5
        PnlPetition.Enabled = b6
        BtnCancelPetition.Visible = b7
        BtnCancelPetition.Enabled = b8
        LblPetitionInfo_P_H.Text = info
        PctbxPetition.Image = RM.GetObject(image)

    End Sub
    Private Sub LoadIdPatientLoggedOn()
        Me.idPatientLoggedOn = L1.matchPatientLoggedOn(Me.ciPatientLoggedOn)
    End Sub
    Private Function FilterPathologies(descSympPath As List(Of String), pathology As Data.Pathology) As Data.Pathology
        Return L1.FilterPathologies(ObtainDescSympSuffered(LbxSufferedPatient), descSympPath, pathology)
    End Function
    Private Function ObtainDescSympSuffered(lbxSuffredPatient As System.Windows.Forms.ListBox) As List(Of String)
        Dim sympSuffred As New List(Of String)

        For Each lbxSympSuffred In lbxSuffredPatient.Items
            sympSuffred.Add(lbxSympSuffred.ToString)
        Next

        Return sympSuffred
    End Function
    Private Function ObtainSymptoms()
        Return L1.ObtainSymptoms()
    End Function
    Private Function ObtainIdSymptoms(idPathology As Integer) As List(Of String)
        Return L1.ObtainIdSymptoms(ObtainDescSympSuffered(LbxSufferedPatient), idPathology)
    End Function
    Private Sub LoadSympSuffered(lbxSuffredPatient As System.Windows.Forms.ListBox)
        Dim sympSuffred As List(Of String) = ObtainDescSympSuffered(lbxSuffredPatient)
        L1.LoadSympSuffred(Me.idPatientLoggedOn, sympSuffred)
    End Sub
    Private Function GetNowDateTime(prefix As Short) As String
        Return L1.GetNowDateTime(prefix)
    End Function


    'Eventos:
    Private Sub BtnNext_Intro2_Click(sender As Object, e As EventArgs) Handles BtnNext_Intro2_P_H.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False, False)
    End Sub
    Private Sub BtnNext_Patient_Click(sender As Object, e As EventArgs) Handles BtnNext_Patient_P_H.Click
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False, False)
    End Sub
    Private Sub BtnNext_Symptom1_Click(sender As Object, e As EventArgs) Handles BtnNext_Symptom1_P_H.Click
        VisualSettings(3, False, False, True, False, False, False, False, False, True, False, False)
    End Sub
    Private Sub BtnBack_Intro2_Click(sender As Object, e As EventArgs) Handles BtnBack_Intro2_P_H.Click
        VisualSettings(1, True, False, False, False, False, False, True, False, False, False, False)
    End Sub
    Private Sub BtnNext_Result_Click(sender As Object, e As EventArgs) Handles BtnNext_Result_P_H.Click
        If LbxSufferedPatient.Items.Contains(" ") Then
            Console.WriteLine("No se asignaron sintomas para proceder.")
        Else 'Hay sintomas para defenir la patologia
            Dim patholgiesSuffered As List(Of Data.Pathology) 'Colección de Data.Patologia sufridas
            Dim filteredPathologies As New List(Of Data.Pathology) 'Lista filtrada con las Patologias con mas probabilidad.
            Dim qtySympSelected As Integer = LbxSufferedPatient.Items.Count()

            VisualSettings(4, False, False, False, True, False, False, False, False, False, True, False)

            Me.LoadSympSuffered(LbxSufferedPatient)
            Try 'Intento cargar las Patologias Sufridas en una Lista
                patholgiesSuffered = L1.ObtainPatholgiesSuffered(idPatientLoggedOn)

                'Cargo la lista "chargePathology"
                For Each pathology As Data.Pathology In patholgiesSuffered
                    'Analizo las evidencias para cada Patologia obtenida.
                    If pathology.mortalityIndex < 33 Then
                        pathology.evidence = "EVIDENCIA BAJA"
                    ElseIf pathology.mortalityIndex > 32 And pathology.mortalityIndex < 66 Then
                        pathology.evidence = "EVIDENCIA MEDIA"
                    ElseIf pathology.mortalityIndex > 65 Then
                        pathology.evidence = "EVIDENCIA ALTA"
                    End If
                Next

                For Each pathology As Data.Pathology In patholgiesSuffered
                    Dim descSympSuffered As List(Of String) = Me.ObtainIdSymptoms(pathology.id) 'Me traigo la lista de Sintomas que posee una Patologia
                    Dim pathFiltered As Data.Pathology = Me.FilterPathologies(descSympSuffered, pathology)

                    If Not IsNothing(pathFiltered) Then
                        'Si no pertenece a la probabilidad esperada, tengo un Nothing
                        filteredPathologies.Add(pathFiltered)
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Cargo el resultado en el DataGridView de Patologias Sufridas
            If filteredPathologies.Count() <> 0 Then
                For Each pat As Data.Pathology In filteredPathologies
                    DgvPhatologies.Rows.Add(pat.name, pat.evidence)
                Next
            Else
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                Dim pat As Data.Pathology = patholgiesSuffered.Item(0)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                DgvPhatologies.Rows.Add(pat.name, pat.evidence)
            End If
            DgvPhatologies.Refresh()
        End If
    End Sub
    Private Sub BtnBack_Patient1_Click(sender As Object, e As EventArgs) Handles BtnBack_Patient1_P_H.Click
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
    Private Sub BtnDropPathology_Click(sender As Object, e As EventArgs) Handles BtnDropPathology_P_H.Click
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
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd_P_H.Click
        L1.UnsuscribePatient(idPatientLoggedOn)
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False, False)
        PatientApp.FrmLogin.Show()
        Me.Close()
    End Sub
    Private Sub BtnSendChatP_Click(sender As Object, e As EventArgs) Handles BtnSendChatP_P_H.Click
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
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If Not TxtChatSend.Text.Trim.Length = 0 Then
            Try
                L1.SendMessage(idPatientLoggedOn, idRoom, TxtChatSend.Text, DateTime.Now.ToString("HH:mm:ss"))
                ObtainMsg()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            TxtChatSend.Clear()
            TxtChatSend.Focus()
        End If
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
    Private Function CheckStateRoom() As Integer
        Try
            L1.CheckStateRoom(idRoom)
            Return 0
        Catch ex As Exception
            Return 1
        End Try
    End Function
    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        time = time + 1
        If time > 4 Then
            Try
                If CheckStateRoom() = 0 Then
                    ObtainMsg()
                    time = 0
                Else
                    TimerChat.Stop()
                    MessageBox.Show("El chat ha finalizado!")
                    L1.DisablePatient(idPatientLoggedOn)
                    FrmLogin.Show()
                    Me.Close()
                End If
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