Public Class Symptom
    Private Property region As Region = Nothing
    Private Property description As String = Nothing

    Public Sub New()

    End Sub
    Public Sub New(region As Region, description As String)
        Me.region = region
        Me.description = description
    End Sub
End Class
