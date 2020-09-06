Imports Persistencia
Imports Data
Public Class Controller
    Dim db As New ConnectionDB()

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


End Class
