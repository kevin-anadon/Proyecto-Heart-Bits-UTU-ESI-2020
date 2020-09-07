Imports Data.Region

Public Class Symptom

    Public Property Id As Integer = Nothing
    Public Property Region As Region = Nothing
    Public Property Description As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(desc As String)
        Me.Description = desc

    End Sub

    Public Sub New(id As Integer, desc As String)
        Me.Id = id
        Me.Description = desc
    End Sub 'Necesary Constructor 

    Public Sub New(id As Integer, region As Region, description As String)
        Me.Id = id
        Me.Region = region
        Me.Description = description
    End Sub 'Full Constructor

End Class 'Symptom
