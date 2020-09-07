Imports Persistencia
Imports Data
Public Class Controller
    Private db As New ConnectionDB()
    Private Property user As String

    Public Function ObtainPriorities() As List(Of Priority)
        Return db.ObtainPriorities()
    End Function

    Public Function ObtainRegions() As List(Of Region)
        Return db.ObtainRegions()
    End Function

    Public Function ObtainPath() As List(Of Pathology)
        Return db.ObtainPath()
    End Function

    Public Function ObtainMortalityPath(pat As String) As Integer
        Return db.ObtainMortalityPath(pat)
    End Function

    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Return db.ObtainTreatments(pat)
    End Function

    Public Function ObtainSymptoms() As List(Of Symptom)
        Return db.ObtainSymptoms
    End Function

    Public Function matchPatientLoggedOn(ci As String) As Integer
        Return db.matchPatientLoggedOn(ci)
    End Function

    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        db.SetPatientSufferSymp(idPatient, idSympSuffered)
    End Sub

End Class 'Data
