Imports Persistencia
Imports Data
Imports System.Net
Imports System.Net.Mail
Public Class Controller 'Logic
    'Atributos
    Private ReadOnly CQConnection As New DataBaseConn()
    Public Shared Property Instance As New Controller
    Private Property idRoom As Integer = 0
    Dim ProbabilitySelected As Integer = 0 'Indicador de cuanta probabilidad tiene una patología de ser la diagnosticada
    Dim PathMostProbably As Pathology = Nothing 'Patología que será la que tenga más probabilidad de tener el usuario


    'Herramientas de conexión
    Public Sub TryConnection()
        Try
            CQConnection.TryConnection()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Conexión CSV
    Private Sub ValidateSymptFromCsv(Symptoms As List(Of Symptom))
        For Each Symptom As Symptom In ObtainSymptoms()
            For Each sympsAdd As Symptom In Symptoms
                If Symptom.Description.ToLower().Equals(sympsAdd.Description.ToLower()) And Symptom.Id <> sympsAdd.Id Then
                    Throw New Exception("Descripcion de síntoma ya existente")
                End If
            Next
        Next
    End Sub
    Public Sub AddSymptomsFromCsv(Symptoms As List(Of Symptom))
        Try
            ValidateSymptFromCsv(Symptoms)
            CQConnection.AddSymptomsFromCsv(Symptoms)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Conexión Chat
    Public Sub SetRoom(id As Integer)
        Me.idRoom = id
    End Sub
    Public Function ObtainRoom() As Integer
        Return Me.idRoom
    End Function
    Public Function ObtainRoomMed() As Integer
        Try
            Return CQConnection.ObtainRoomMed()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainMessages(idRoom As Integer) As List(Of Message)
        Try
            Return CQConnection.ObtainMessages(idRoom)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainRequestsDataSet() As DataSet
        Try
            Return CQConnection.ObtainRequestsDataSet()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainTalkingMed(idPatient As Integer, dateI As String) As Medic
        Try
            Return CQConnection.ObtainTalkingMed(idPatient, dateI)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CreateRoom() As Integer
        Try
            Return CQConnection.CreateRoom()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub SendMessage(idPeople As Integer, idRoom As Integer, msg As String, Hour As String)
        Try
            CQConnection.SendMessage(idPeople, idRoom, msg, Hour)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AcceptRequest(idMed As Integer, idPatient As Integer, dateI As String, dateF As String)
        Try
            CQConnection.AcceptRequest(idMed, idPatient, dateI, dateF)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub WaitingAccept(idPatient As Integer, dateI As String)
        Try
            CQConnection.WaitingAccept(idPatient, dateI)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function MakePetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Try
            Return CQConnection.MakePetition(idPatient, motive, datetI, datetF)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function StopPetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Try
            Return CQConnection.StopPetition(idPatient, motive, datetI, datetF)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainTentativeDiagnostic(Patient As People, DateI As String) As Diagnostic
        Try
            If Not IsNothing(Patient) Or Not IsNothing(DateI) Then
                Return CQConnection.ObtainTentativeDiagnostic(Patient, DateI)
            ElseIf IsNothing(Patient) Then
                Throw New Exception("Paciente nulo")
            ElseIf IsNothing(DateI) Then
                Throw New Exception("Fecha nula")
            Else
                Throw New Exception("Paciente y Fecha nulos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub VerifyDiagnostic(idMed As Integer, idDiag As Integer)
        Try
            CQConnection.VerifyDiagnostic(idMed, idDiag)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateDiagnostic(idDiagnostic As Integer, idPath As Integer)
        Try
            CQConnection.UpdateDiagnostic(idDiagnostic, idPath)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Conexión Otros
    Public Function GetNowDateTime(prefix As Short) As String
        Select Case prefix
            Case 1 'Devuelve 'YYYY-MM-DD HH:MM:SS'
                Dim nowDate As String = Now.ToString("yyy-MM-dd")
                Dim nowHMS As String = Now.ToLongTimeString
                Return nowDate + " " + nowHMS
            Case 2 'Devuelve 'YYYY-MM-DD'
                Return Now.ToString("yyy-MM-dd")
            Case 3
                Return Now.ToString("yyy")
            Case Else
                Return Nothing
        End Select
    End Function
    Public Function ObtainRegions() As List(Of Region)
        Try
            Return CQConnection.ObtainRegions()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainCities() As List(Of City)
        Try
            Return CQConnection.ObtainCities()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainPriorities() As List(Of Priority)
        Try
            Return CQConnection.ObtainPriorities()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainKindPath() As List(Of KindPath)
        Try
            Return CQConnection.ObtainKindPath()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainMortalityPath(pat As String) As Integer
        Try
            If pat.Equals(" ") Then
                Return 0
            ElseIf pat.Trim.Length = 0 Then
                Return 0
            Else
                Return CQConnection.ObtainMortalityPath(pat)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainSpecialities() As List(Of String)
        Try
            Return CQConnection.ObtainSpecialities()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Try
            Return CQConnection.ObtainTreatments(pat)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainTreatmentsAll() As List(Of Treatment)
        Try
            Return CQConnection.ObtainTreatmentsAll()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainTreatmentsForMod(idPath As Integer) As List(Of Treatment)
        Try
            Return CQConnection.ObtainTreatmentsForMod(idPath)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Conexión Patológias
    Public Function ObtainPath() As List(Of Pathology)
        Try
            Return CQConnection.ObtainPath()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainPathForSymptoms(Sympt As String) As List(Of Pathology)
        Try
            Return CQConnection.ObtainPathForSymptoms(Sympt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainPathsDataSet() As DataSet
        Try
            Return CQConnection.ObtainPathsDataSet()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Function
    Public Function ObtainPathForMod(NamePath As String) As Pathology
        Try
            Return CQConnection.ObtainPathForMod(NamePath)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw ex
        End Try
    End Function
    Public Sub AddPathology(Path As Pathology, Treatments As List(Of Treatment))
        Try
            If Not Path.name.Equals("") Then
                CQConnection.AddPathology(Path, Treatments)
            Else
                Throw New Exception("Nombre vacio")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeletePathology(idPath As Integer)
        Try
            CQConnection.DeletePathology(idPath)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function SearchPathology(NamePath As String) As DataSet
        Try
            If NamePath.Equals(" ") Then
                Throw New Exception("Espacio en lugar de la patologia")
            Else
                Return CQConnection.SearchPathology(NamePath)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw ex
        End Try
    End Function
    Public Function CheckUpdatePathology(Path As Pathology, Treatments As List(Of Treatment)) As Integer
        Dim checkPat As Boolean = False
        Dim checkTreat As Boolean = False
        Dim check As Integer = 0

        For Each pat As Pathology In ObtainPath()
            If pat.name.Equals(Path.name) And Not pat.id = Path.id Then 'Comprueba si el nuevo nombre ya existe
                checkPat = True
            End If
        Next
        For Each treats As Treatment In ObtainTreatmentsAll()
            For Each treatmentsmod As Treatment In Treatments
                If treats.name.Equals(treatmentsmod.name) And Not treats.pathology.id = treatmentsmod.pathology.id Then 'Comprueba si el nuevo nombre ya existe en los tratamientos
                    checkTreat = True
                End If
            Next
        Next

        If checkPat = True And checkTreat = True Then
            check = 4
        ElseIf checkPat = True And checkTreat = False Then
            check = 1
        ElseIf checkPat = False And checkTreat = True Then
            check = 3
        End If

        Return check
    End Function
    Public Sub UpdatePathology(Path As Pathology, Treatments As List(Of Treatment))
        Try
            If Not Path.name.Equals("") Then
                CQConnection.UpdatePathology(Path, Treatments)
            Else
                Throw New Exception("Nombre vacio")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    'Conexión Síntomas
    Public Function ObtainIdSymptoms(desc As List(Of String), idPathology As Integer) As List(Of String)
        Try
            Return CQConnection.ObtainIdSymptoms(desc, idPathology)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainSymptoms() As List(Of Symptom)
        Try
            Return CQConnection.ObtainSymptoms
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainSymptomsDataSet() As DataSet
        Try
            Return CQConnection.ObtainSymptomsDataSet()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw ex
        End Try
    End Function
    Private Sub ValidateSymptom(Sympt As Symptom)
        If Not IsNothing(Sympt) Then
            Dim Check As Boolean = False
            For Each i As Char In Sympt.Description
                If Char.IsNumber(i) Then
                    Check = True
                End If
            Next
            If Check = True Then
                Throw New Exception("La descripción tiene un formato incorrecto")
            Else

                For Each Symptom As Symptom In ObtainSymptoms()
                    If Symptom.Description.ToLower().Equals(Sympt.Description.ToLower()) And Symptom.Id <> Sympt.Id Then
                        Throw New Exception("Descripcion de síntoma ya existente")
                    End If
                Next
            End If
        ElseIf IsNothing(Sympt) Then
            Throw New Exception("Descripcion vacia")
        End If
    End Sub
    Public Sub AddSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
            ValidateSymptom(Sympt)
            CQConnection.AddSymptoms(Sympt, Paths)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
            ValidateSymptom(Sympt)
            CQConnection.UpdateSymptoms(Sympt, Paths)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeleteSymptoms(idSympt As Integer)
        Try
            CQConnection.DeleteSymptoms(idSympt)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function SearchSymptoms(Descr As String) As DataSet
        Try
            Return CQConnection.SearchSymptoms(Descr)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Conexión Personas
    Public Sub FilterPathologies(descSympSuffered As List(Of String), descSympPath As List(Of String), pathology As Data.Pathology)
        Dim qtyMatchA As Integer = 0 'La cantidad de veces que el Sintoma que tiene la patología, coincide con el Sintoma Sufrido  
        Dim ProbabilityPathCompare As Integer = 0
        Dim pat As Data.Pathology = Nothing

        For Each sympSuffered As String In descSympSuffered 'Por cada síntoma que el paciente seleccionó se recorre
            For Each sympPath As String In descSympPath 'Por cada síntoma que componen a las posibles patologías se recorre
                If sympPath.Equals(sympSuffered) Then
                    qtyMatchA = qtyMatchA + 1
                End If
            Next
        Next

        ProbabilityPathCompare = (qtyMatchA * 100) / descSympPath.Count 'Aplico una regla de tres para obtener la probabilidad que tiene de ser esa patología

        If ProbabilityPathCompare > ProbabilitySelected Then 'Comparo si la probabilidad actual es mayor a la actual
            ProbabilitySelected = ProbabilityPathCompare
            PathMostProbably = pathology
            PathMostProbably.evidence = ProbabilitySelected
        End If
    End Sub
    Public Function ObtainMostProbablyPath() As Pathology
        Return PathMostProbably
    End Function
    Public Function ObtainSymptomsSuffered(idPatient As Integer, DateNow As String) As List(Of Symptom)
        Try
            Return CQConnection.ObtainSymptomsSuffered(idPatient, DateNow)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LeaveRoom(idRoom As Integer, DateNow As String)
        Try
            CQConnection.LeaveRoom(idRoom, DateNow)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CheckStateRoom(idRoom As Integer)
        Try
            CQConnection.CheckStateRoom(idRoom)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub LoadSympSuffred(idPatientLoggedOn As Integer, sympSuffred As List(Of String))
        Dim symptoms As List(Of Data.Symptom) = Me.ObtainSymptoms()
        Dim idSympSuffered As New List(Of Integer)

        For Each symptomsSuffred In sympSuffred
            For Each symptom As Data.Symptom In symptoms
                If symptom.Description.Equals(symptomsSuffred.ToString) Then
                    idSympSuffered.Add(symptom.Id) 'Reconozco los Id de cada Sintoma que sufre el Paciente.
                End If
            Next 'For [symptom] para cada Síntoma existente. 
        Next 'For [symptomsSuffred] para cada item del ListBox que contiene los Síntomas que Sufre el Paciente.

        'Almaceno en la Base de Datos los Sintomas que sufre el Paciente, y su Id para referenciarlo
        Me.SetPatientSufferSymp(idPatientLoggedOn, idSympSuffered, Me.GetNowDateTime(2))
    End Sub
    Public Function matchPatientLoggedOn(ci As String) As Integer
        Try
            Return CQConnection.matchPatientLoggedOn(ci)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer), nowDate As String)
        CQConnection.SetPatientSufferSymp(idPatient, idSympSuffered, nowDate)
    End Sub
    Public Sub UnsuscribePatient(idPatient As Integer)
        CQConnection.UnsuscribePatient(idPatient)
    End Sub
    Public Function ObtainPatholgiesSuffered(idPatient As Integer) As List(Of Pathology)
        Try
            Return CQConnection.ObtainPatholgiesSuffered(idPatient, GetNowDateTime(2))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LoginPatient(ci As String) As Short
        Try
            Return CQConnection.LoginPatient(ci)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LoginAdmin(user As String, pass As String) As Admin
        Try
            Return CQConnection.LoginAdmin(user, pass)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SearchAdmin(Ci As Integer) As DataSet
        Try
            Return CQConnection.SearchAdmin(Ci)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainAdmins() As List(Of Admin)
        Return CQConnection.ObtainAdmins()
    End Function
    Public Function ObtainAdminsDataSet() As DataSet
        Try
            Return CQConnection.ObtainAdminsDataSet()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub DeleteAdmin(idAdmin As Integer)
        Try
            CQConnection.DeleteAdmin(idAdmin)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AddAdmin(Admin As Admin)
        Try
            ValidateAdmin(Admin)
            CQConnection.AddAdmin(Admin)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateAdmin(Admin As Admin)
        Try
            ValidateAdmin(Admin)
            CQConnection.UpdateAdmin(Admin)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function LoginMedic(user As String, passwd As String) As Medic
        Try
            Return CQConnection.LoginMedic(user, passwd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function InfoEmployeeLogged(user As String, passwd As String) As Short
        Try
            Return CQConnection.InfoEmployeeLogged(user, passwd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainMedics() As List(Of Medic)
        Try
            Return CQConnection.ObtainMedics()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainMedicsDataSet() As DataSet
        Try
            Return CQConnection.ObtainMedicsDataSet()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub AddMedic(Medic As Medic)
        Try
            ValidateMedic(Medic)
            CQConnection.AddMedic(Medic)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateMedic(Medic As Medic)
        Try
            ValidateMedic(Medic)
            CQConnection.UpdateMedic(Medic)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeleteMedic(idMedic As Integer)
        Try
            CQConnection.DeleteMedic(idMedic)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function SearchMedic(Ci As Integer) As DataSet
        Try
            Return CQConnection.SearchMedic(Ci)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainPatients() As List(Of People)
        Try
            Return CQConnection.ObtainPatients()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtainPatientsDataSet() As DataSet
        Try
            Return CQConnection.ObtainPatientsDataSet()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub AddPatient(Patient As People)
        Try
            ValidatePatient(Patient)
            CQConnection.AddPatient(Patient)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdatePatient(Patient As People)
        Try
            ValidatePatient(Patient)
            CQConnection.UpdatePatient(Patient)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeletePatient(idPatient As Integer)
        Try
            CQConnection.DeletePatient(idPatient)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AllowPatient(idPatient As Integer)
        CQConnection.AllowPatient(idPatient)
    End Sub
    Public Sub DisablePatient(idPatient As Integer)
        CQConnection.DisablePatient(idPatient)
    End Sub
    Public Function SearchPatient(Ci As Integer) As DataSet
        Try
            Return CQConnection.SearchPatient(Ci)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Validaciones
    Private Sub ValidateAdmin(Admin As Admin)
        For Each Admins As Admin In ObtainAdmins()
            If Admins.id <> Admin.id Then 'Compara con Administradores diferentes
                If Admins.ci = Admin.ci Then
                    Throw New Exception("Cédula de identidad Ya existente")
                End If

                If Admins.numPhone.Equals(Admin.numPhone) Then
                    Throw New Exception("Número de telefono ya existente")
                End If

                If Admins.email.Equals(Admin.email) Then
                    Throw New Exception("Email ya existente")
                End If

                If Admins.username.Equals(Admin.username) Then
                    Throw New Exception("Nombre de usuario ya existente")
                End If
            End If
        Next
    End Sub

    Private Sub ValidateMedic(Medic As Medic)
        For Each Medics As Medic In ObtainMedics()
            If Medics.id <> Medic.id Then 'Compara con médicos diferentes
                If Medics.ci = Medic.ci Then
                    Throw New Exception("Cédula de identidad Ya existente")
                End If
                If Medics.numPhone.Equals(Medic.numPhone) Then
                    Throw New Exception("Número de telefono ya existente")
                End If

                If Medics.email.Equals(Medic.email) Then
                    Throw New Exception("Email ya existente")
                End If

                If Medics.username.Equals(Medic.username) Then
                    Throw New Exception("Nombre de usuario ya existente")
                End If
            End If
        Next
    End Sub
    Private Sub ValidatePatient(Patient As People)
        For Each Patients As People In ObtainPatients()
            If Patients.id <> Patient.id Then 'Compara con pacientes diferentes
                If Patients.ci = Patient.ci Then
                    Throw New Exception("Cédula de identidad Ya existente")
                End If
                If Patients.numPhone.Equals(Patient.numPhone) Then
                    Throw New Exception("Número de telefono ya existente")
                End If

                If Patients.email.Equals(Patient.email) Then
                    Throw New Exception("Email ya existente")
                End If
            End If
        Next
    End Sub

    'Mail
    Public Sub SendEMail(Email As String, Subject As String, Body As String)
        Dim Mail As New MailMessage()

        Try
            'Declaramos nuestro objeto servidor SMTP
            Dim SMTPServer As New SmtpClient

            Mail.From = New MailAddress("group.heartbits@gmail.com")
            Mail.To.Add(New MailAddress("mathewanadon@gmail.com"))
            Mail.Subject = Subject
            Mail.Body = Body

            'Especificamos cual es nuestro servidor SMTP
            SMTPServer.Host = "smtp.gmail.com"
            'Puerto SMTP de nuestro server
            SMTPServer.Port = 587
            'Credenciales de acceso de la cuenta de envio
            SMTPServer.Credentials = New System.Net.NetworkCredential("group.heartbits@gmail.com", "heartbits2002")
            'Si nuestro servidor de correo admite SSL
            SMTPServer.EnableSsl = True
            'Enviamos el correo
            SMTPServer.Send(Mail)

            'Destruimos el objeto de correo
            Mail.Dispose()

            Console.WriteLine("Correo enviado")

        Catch ex As Exception
            Throw New Exception("Error al enviar el mail")
        End Try
    End Sub
    Public Sub Mail(TentativeDiagnostic As Diagnostic, idRoom As Integer, Medic As Medic)
        Dim Tratamientos As String = ""
        Try
            Dim Treatments As List(Of Treatment) = ObtainTreatmentsForMod(TentativeDiagnostic.Pathology.id)
            For Each Treat As Treatment In Treatments
                Dim x As String = ""
                x = Treat.name
                If Tratamientos.Equals("") Then
                    Tratamientos = x + ", "
                ElseIf Treatments.Count > 2 Then
                    Tratamientos = Tratamientos + x + ","
                Else
                    Tratamientos = Tratamientos + x
                End If
            Next
            Dim Email As String = TentativeDiagnostic.Patient.email
            Dim Text As String = ObtainConversation(TentativeDiagnostic, idRoom, Medic)
            Dim Subject As String = "Centro de Atención de Salud - Informe - NOREPLY"
            Dim Body As String = "Diagnóstico: " + TentativeDiagnostic.Pathology.name + vbCrLf + "Tratamientos: " + Tratamientos + vbCrLf + "Historial de chat: " + vbCrLf + Text

            SendEMail(Email, Subject, Body)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Chat
    Private Function ObtainConversation(TentativeDiagnostic As Diagnostic, idRoom As Integer, Medic As Medic) As String
        Try
            Dim Conver As List(Of Message) = ObtainMessages(idRoom)
            Dim msg As String = Nothing
            Dim PatientName = ""
            Dim MedicName = ""

            If Medic.scndName = "" Then
                MedicName = Medic.fstName + " " + Medic.fstSurname + " " + Medic.scndSurname
            Else
                MedicName = Medic.fstName + " " + Medic.scndName + " " + Medic.fstSurname + " " + Medic.scndSurname
            End If

            For Each Text As Message In Conver
                If msg = Nothing And Text.idP = Medic.id Then
                    msg = MedicName + ": " + Text.message + vbTab + Text.hour.Hour.ToString() + ":" + Text.hour.Minute.ToString()
                ElseIf msg = Nothing And Text.idP <> Medic.id Then
                    msg = "Tú: " + Text.message + vbTab + Text.hour.Hour.ToString() + ":" + Text.hour.Minute.ToString()
                ElseIf Text.idP = Medic.id Then
                    msg = msg + vbCrLf + MedicName + ": " + Text.message + vbTab + Text.hour.Hour.ToString() + ":" + Text.hour.Minute.ToString()
                Else
                    msg = msg + vbCrLf + "Tú: " + Text.message + vbTab + Text.hour.Hour.ToString() + ":" + Text.hour.Minute.ToString()
                End If
            Next

            Return msg
        Catch ex As Exception
            Throw New Exception("Error al obtener la conversación")
        End Try
    End Function

End Class 'Logic
