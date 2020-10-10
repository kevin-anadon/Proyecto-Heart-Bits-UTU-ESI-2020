Imports Persistencia
Imports Data

Public Class Logic
    'Atributos
    Private ReadOnly CQConnection As New DataBaseConn()

    'Herramientas de conexión
    Public Sub TryConnection()
        Try
            CQConnection.TryConnection()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub



    'Conexión Otros
    Public Function ObtainRegions() As List(Of Region)
        Return CQConnection.ObtainRegions()
    End Function
    Public Function ObtainCities() As List(Of City)
        Return CQConnection.ObtainCities()
    End Function
    Public Function ObtainPriorities() As List(Of Priority)
        Return CQConnection.ObtainPriorities()
    End Function
    Public Function ObtainKindPath() As List(Of KindPath)
        Try
            Return CQConnection.ObtainKindPath()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function ObtainMortalityPath(pat As String) As Integer
        Return CQConnection.ObtainMortalityPath(pat)
    End Function
    Public Function ObtainSpecialities() As List(Of String)
        Return CQConnection.ObtainSpecialities()
    End Function
    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Return CQConnection.ObtainTreatments(pat)
    End Function
    Public Function ObtainTreatmentsAll() As List(Of Treatment)
        Return CQConnection.ObtainTreatmentsAll()
    End Function
    Public Function ObtainTreatmentsForMod(idPath As Integer) As List(Of Treatment)
        Try
            Return CQConnection.ObtainTreatmentsForMod(idPath)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function



    'Conexión Patológias
    Public Function ObtainPath() As List(Of Pathology)
        Return CQConnection.ObtainPath()
    End Function
    Public Function ObtainPathForSymptoms(Sympt As String) As List(Of Pathology)
        Return CQConnection.ObtainPathForSymptoms(Sympt)
    End Function
    Public Function ObtainPathsDataSet() As DataSet
        Try
            Return CQConnection.ObtainPathsDataSet()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return Nothing
    End Function
    Public Function ObtainPathForMod(NamePath As String) As Pathology
        Try
            Return CQConnection.ObtainPathForMod(NamePath)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return Nothing
    End Function
    Public Sub AddPathology(Path As Pathology, Treatments As List(Of Treatment))
        Try
            CQConnection.AddPathology(Path, Treatments)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub DeletePathology(idPath As Integer)
        Try
            CQConnection.DeletePathology(idPath)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function SearchPathology(NamePath As String) As DataSet
        Try
            Return CQConnection.SearchPathology(NamePath)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return Nothing
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
            Throw New Exception(ex.Message)
        End Try
    End Sub


    'Conexión Síntomas
    Public Function ObtainSymptoms() As List(Of Symptom)
        Return CQConnection.ObtainSymptoms
    End Function
    Public Function ObtainSymptomsDataSet() As DataSet
        Try
            Return CQConnection.ObtainSymptomsDataSet()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return Nothing
    End Function
    Public Sub AddSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
            CQConnection.AddSymptoms(Sympt, Paths)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub UpdateSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Try
            CQConnection.UpdateSymptoms(Sympt, Paths)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub DeleteSymptoms(idSympt As Integer)
        Try
            CQConnection.DeleteSymptoms(idSympt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function SearchSymptoms(Descr As String) As DataSet
        Try
            Return CQConnection.SearchSymptoms(Descr)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function


    'Conexión Personas
    Public Sub LoadSympSuffred(idPatientLoggedOn As Integer, sympSuffred As List(Of String))
        Dim symptoms As New List(Of Data.Symptom)
        Dim idSympSuffered As New List(Of Integer)

        For Each symptomsSuffred In sympSuffred
            For Each symptom As Symptom In symptoms
                If symptom.Description.Equals(symptomsSuffred.ToString) Then
                    idSympSuffered.Add(symptom.Id) 'Reconozco los Id de cada Sintoma que sufre el Paciente.
                End If
            Next 'For [symptom] para cada Síntoma existente. 
        Next 'For [symptomsSuffred] para cada item del ListBox que contiene los Síntomas que Sufre el Paciente.

        'Almaceno en la Base de Datos los Sintomas que sufre el Paciente, y su Id para referenciarlo
        Me.SetPatientSufferSymp(idPatientLoggedOn, idSympSuffered, Me.GetNowDateTime(3))

    End Sub
    Public Function GetNowDateTime(prefix As Short)
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

    Public Function matchPatientLoggedOn(ci As String) As Integer
        Return CQConnection.matchPatientLoggedOn(ci)
    End Function
    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer), nowDate As String)
        CQConnection.SetPatientSufferSymp(idPatient, idSympSuffered, nowDate)
    End Sub
    Public Sub UnsuscribePatient(idPatient As Integer)
        CQConnection.UnsuscribePatient(idPatient)
    End Sub
    Public Function ObtainPatholgiesSuffered(idPatient As Integer) As List(Of Pathology)
        Return CQConnection.ObtainPatholgiesSuffered(idPatient)
    End Function
    Public Function LogginPatient(ci As String) As Short
        Return CQConnection.LoginPatient(ci)
    End Function
    Public Function LoginAdmin(user As String, pass As String) As Admin
        Return CQConnection.LoginAdmin(user, pass)
    End Function
    Public Function SearchAdmin(Ci As Integer) As DataSet
        Return CQConnection.SearchAdmin(Ci)
    End Function
    Public Function ObtainAdmins() As List(Of Admin)
        Return CQConnection.ObtainAdmins()
    End Function
    Public Function ObtainAdminsDataSet() As DataSet
        Return CQConnection.ObtainAdminsDataSet()
    End Function
    Public Sub DeleteAdmin(idAdmin As Integer)
        Try
            CQConnection.DeleteAdmin(idAdmin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub AddAdmin(Admin As Admin)
        Try
            CQConnection.AddAdmin(Admin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub UpdateAdmin(Admin As Admin)
        Try
            CQConnection.UpdateAdmin(Admin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function ObtainMedics() As List(Of Medic)
        Return CQConnection.ObtainMedics()
    End Function
    Public Function ObtainMedicsDataSet() As DataSet
        Return CQConnection.ObtainMedicsDataSet()
    End Function
    Public Sub AddMedic(Medic As Medic)
        Try
            CQConnection.AddMedic(Medic)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub UpdateMedic(Medic As Medic)
        Try
            CQConnection.UpdateMedic(Medic)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub DeleteMedic(idMedic As Integer)
        Try
            CQConnection.DeleteMedic(idMedic)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function SearchMedic(Ci As Integer) As DataSet
        Return CQConnection.SearchMedic(Ci)
    End Function
    Public Function ObtainPatients() As List(Of People)
        Return CQConnection.ObtainPatients()
    End Function
    Public Function ObtainPatientsDataSet() As DataSet
        Return CQConnection.ObtainPatientsDataSet()
    End Function
    Public Sub AddPatient(Patient As People)
        Try
            CQConnection.AddPatient(Patient)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub UpdatePatient(Patient As People)
        Try
            CQConnection.UpdatePatient(Patient)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub DeletePatient(idPatient As Integer)
        Try
            CQConnection.DeletePatient(idPatient)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub AllowPatient(idPatient As Integer)
        CQConnection.AllowPatient(idPatient)
    End Sub
    Public Sub DisablePatient(idPatient As Integer)
        CQConnection.DisablePatient(idPatient)
    End Sub
    Public Function SearchPatient(Ci As Integer) As DataSet
        Return CQConnection.SearchPatient(Ci)
    End Function
    Public Function MakePetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Return CQConnection.MakePetition(idPatient, motive, datetI, datetF)
    End Function
    Public Function StopPetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Return CQConnection.StopPetition(idPatient, motive, datetI, datetF)
    End Function




End Class 'Logic
