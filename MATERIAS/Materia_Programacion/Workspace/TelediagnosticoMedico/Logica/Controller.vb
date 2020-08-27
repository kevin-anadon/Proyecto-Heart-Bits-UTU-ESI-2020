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

End Class
