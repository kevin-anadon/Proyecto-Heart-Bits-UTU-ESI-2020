Imports Logic.Pathology

Public Class Treatment

    Private Property pathology As Pathology
    Private Property name As String = Nothing
    Private Property description As String = Nothing
    Private Property kind As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(pathology As Pathology, name As String, description As String, kind As String)
        Me.pathology = pathology
        Me.name = name
        Me.description = description
        Me.kind = kind
    End Sub 'Full Constructor 

End Class 'Treatment
