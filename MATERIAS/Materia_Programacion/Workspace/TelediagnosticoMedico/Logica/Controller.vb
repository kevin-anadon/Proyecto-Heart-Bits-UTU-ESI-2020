Imports Persistencia
Imports Data

Public Class Controller 'Logic
    'Atributos
    Private ReadOnly CQConnection As New DataBaseConn()
    Public Shared Property Instance As New Controller
    Private Property idRoom As Integer = 0


    'Herramientas de conexión
    Public Sub TryConnection()
        Try
            CQConnection.TryConnection()
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
    Public Function ObtainMessages(id As Integer, idRoom As Integer) As List(Of Message)
        Try
            Return CQConnection.ObtainMessages(id, idRoom)
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
    Public Sub SendMessage(id As Integer, idRoom As Integer, msg As String, Hour As String)
        Try
            CQConnection.SendMessage(id, idRoom, msg, Hour)
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
            Return CQConnection.ObtainTentativeDiagnostic(Patient, DateI)
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
            Return CQConnection.ObtainMortalityPath(pat)
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
        End Try
    End Function
    Public Sub AddPathology(Path As Pathology, Treatments As List(Of Treatment))
        Try
            CQConnection.AddPathology(Path, Treatments)
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
            Return CQConnection.SearchPathology(NamePath)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
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
            CQConnection.UpdatePathology(Path, Treatments)
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
        End Try
    End Function
    Public Sub AddSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
            CQConnection.AddSymptoms(Sympt, Paths)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
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
    Public Function FilterPathologies(descSympSuffered As List(Of String), descSympPath As List(Of String), pathology As Data.Pathology) As Data.Pathology
        Dim qtyMatch As Integer = 0 'La cantidad de veces que el Sintoma que tiene la patología, coincide con el Sintoma Sufrido
        Dim pat As Data.Pathology
        For Each sympSuffered As String In descSympSuffered

            For Each sympPath As String In descSympPath
                If sympPath.Equals(sympSuffered) Then
                    qtyMatch = qtyMatch + 1
                End If
            Next
        Next

        pat = Me.SetProbability(qtyMatch, descSympSuffered.Count(), pathology)

        If IsNothing(pat) Then
            Return Nothing
        Else
            Return pat
        End If
    End Function

    Private Function SetProbability(qtyMatch As Integer, maxSympSuffered As Integer, pathology As Data.Pathology) As Data.Pathology
        Dim probability As Double = (qtyMatch * 100) / maxSympSuffered 'Regla de tres.

        If probability > 60 Then
            'Si es mayor a 60% de coincidencia, entonces:
            pathology.probability = probability
            Return pathology
        Else
            Return Nothing
        End If
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
            Return CQConnection.ObtainPatholgiesSuffered(idPatient)
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
            CQConnection.AddAdmin(Admin)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateAdmin(Admin As Admin)
        Try
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
            CQConnection.AddMedic(Medic)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateMedic(Medic As Medic)
        Try
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
            CQConnection.AddPatient(Patient)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdatePatient(Patient As People)
        Try
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


End Class 'Logic
