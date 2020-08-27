Public Class Symptom
    Public Property region As Region = Nothing
    Public Property description As String = Nothing

    Public Sub New()

    End Sub
    Public Sub New(region As Region, description As String)
        Me.region = region
        Me.description = description
    End Sub
End Class
