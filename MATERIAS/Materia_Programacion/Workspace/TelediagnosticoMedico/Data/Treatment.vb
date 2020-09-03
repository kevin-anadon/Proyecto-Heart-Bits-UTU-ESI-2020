Imports Data.Pathology

Public Class Treatment


    Public Property pathology As Pathology
    Public Property name As String = Nothing
    Public Property description As String = Nothing
    Public Property kind As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)
    Public Sub New(name As String, description As String, kind As String)
        Me.pathology = pathology
        Me.name = name
        Me.description = description
        Me.kind = kind
    End Sub 'Constructor for insert 

    Public Sub New(pathology As Pathology, name As String, description As String, kind As String)
        Me.pathology = pathology
        Me.name = name
        Me.description = description
        Me.kind = kind
    End Sub 'Full Constructor 

End Class 'Treatment
