Public Class Symptom
    Inherits Region

    Public Property region As Region
    Public Property description As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(region As Region, description As String)
        Me.region = region
        Me.description = description
    End Sub 'Full Constructor

End Class 'Symptom
