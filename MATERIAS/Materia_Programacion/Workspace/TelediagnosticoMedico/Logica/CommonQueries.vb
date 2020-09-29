Imports Persistencia
Imports Data

Public Class CommonQueries
    Private PConnection As New ConnectionDB()

    Public Function TryConnection() As Boolean
        Dim resultConnection As Boolean = PConnection.TryConnection
        Return resultConnection
    End Function
    Public Function ObtainPriorities() As List(Of Priority)
        Return PConnection.ObtainPriorities()
    End Function

    Public Function ObtainRegions() As List(Of Region)
        Return PConnection.ObtainRegions()
    End Function

    Public Function ObtainPath() As List(Of Pathology)
        Return PConnection.ObtainPath()
    End Function

    Public Function ObtainMortalityPath(pat As String) As Integer
        Return PConnection.ObtainMortalityPath(pat)
    End Function

    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Return PConnection.ObtainTreatments(pat)
    End Function

    Public Function ObtainSymptoms() As List(Of Symptom)
        Return PConnection.ObtainSymptoms
    End Function

    Public Function matchPatientLoggedOn(ci As String) As Integer
        Return PConnection.matchPatientLoggedOn(ci)
    End Function

    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        PConnection.SetPatientSufferSymp(idPatient, idSympSuffered)
    End Sub

    Public Function ObtainPatholgiesSuffered() As List(Of Pathology)
        Return PConnection.ObtainPatholgiesSuffered()
    End Function


End Class 'Data
