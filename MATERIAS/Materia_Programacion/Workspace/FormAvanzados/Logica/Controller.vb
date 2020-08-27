Imports Persistencia
Imports Data

Public Class Controller
    Dim db As New ConnectionDB()

    Public Function ObtainPriorities() As List(Of Priority)
        Return db.ObtainPriorities()
    End Function



End Class
