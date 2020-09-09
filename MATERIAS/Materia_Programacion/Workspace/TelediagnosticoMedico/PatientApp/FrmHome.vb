Imports Logic
Imports Data
Imports Persistencia
Imports ADODB

Public Class FrmHome
    'Resource Manager: Administrador de Recursos propios del Proyecto 'PatientApp'.
    Private ReadOnly RM As Resources.ResourceManager = New Resources.ResourceManager("PatientApp.Resources", System.Reflection.Assembly.GetExecutingAssembly)
    'Atributos:
    Public ciPatientLoggedOn As String
    Private idPatientLoggedOn As Integer
    Private patientLoggedOn As New Data.People
    Private ReadOnly db As New Persistencia.ConnectionDB()
    Private log As New Logic.Controller()

    'Query's:
    Private Symptoms As List(Of Data.Symptom)
    Private idSympSuffered As New List(Of Integer)


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
        PnlPatient1.Visible = myBool8
        PnlSymptom1.Visible = myBool9
    End Sub

    Public Sub GetIdPatientLoggedOn()
        Me.idPatientLoggedOn = log.matchPatientLoggedOn(Me.ciPatientLoggedOn)
    End Sub

    Public Sub LoadSymptoms()
        Me.Symptoms = log.ObtainSymptoms()
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
        For i As Integer = 0 To LbxSufferedPatient.Items.Count - 1
            For n As Integer = 0 To Symptoms.Count
                If CStr(LbxSufferedPatient.Items(i)).Equals(Symptoms.Item(n).Description) Then
                    idSympSuffered.Add(Symptoms.Item(n).Id)
                End If
            Next 'For [n] para cada Síntoma existente. 
        Next 'For [i] para cada item del ListBox que contiene los Síntomas que Sufre el Paciente.
    End Sub

    Private Sub BtnBack_Patient1_Click(sender As Object, e As EventArgs) Handles BtnBack_Patient1.Click
        VisualSettings(2, False, True, False, False, False, False, False, True, False, False)
    End Sub

    Dim usedSymptoms As New List(Of String) 'Los Sintomas que se cargan al Listbox

    Private Sub CbxSysSymptoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSysSymptoms.SelectedIndexChanged
        Dim position As Integer = 1


        Do While position <= LbxSufferedPatient.Items.Count
            If CStr(LbxSufferedPatient.Items(position - 1)).Equals(" ") Then
                'Quiere decir que GhostItem existe, y como solo existe al inicio o cuando Item de Lbx<1, hago:
                LbxSufferedPatient.Items.Clear()
                LbxSufferedPatient.Items.Add(CbxSysSymptoms.SelectedItem)

            ElseIf Not usedSymptoms.Contains(CStr(CbxSysSymptoms.SelectedItem)) Then
                usedSymptoms.Add(CStr(CbxSysSymptoms.SelectedItem))
                LbxSufferedPatient.Items.Add(CbxSysSymptoms.SelectedItem)
            End If

            position += 1
        Loop
    End Sub

    Private Sub BtnDropPathology_Click(sender As Object, e As EventArgs) Handles BtnDropPathology.Click
        If LbxSufferedPatient.Items.Count = 0 Then
            LbxSufferedPatient.Items.RemoveAt(LbxSufferedPatient.SelectedIndex)
            LbxSufferedPatient.Items.Add(" ")
        Else
            Try
                LbxSufferedPatient.Items.RemoveAt(LbxSufferedPatient.SelectedIndex)
            Catch ex As Exception
                'Debe de seleccionar un item para eliminarlo.
            End Try
            If LbxSufferedPatient.Items.Count = 0 Then
                LbxSufferedPatient.Items.Add(" ")
            End If
        End If

    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualSettings(1, True, False, False, False, False, True, False, False, False, False)

        'GhostItem: Es mi elemento del Lbx que me permite utilizarlo (For, recorrer) cuando hay elemento != de Symptoms (Cmbx)
        'Este existe al inicio (instancia de FrmHome) y cada vez que Lbx se queda con 1 Item de Symptoms (Cmbx)
        LbxSufferedPatient.Items.Clear()
        LbxSufferedPatient.Items.Add(" ") 'Mi GhostItem del Lbx


        'Opero con los Sintomas:
        GetIdPatientLoggedOn()
        LoadSymptoms()
        For Each symp As Symptom In Symptoms
            CbxSysSymptoms.Items.Add(symp.description)
        Next
    End Sub


End Class 'FrmHome