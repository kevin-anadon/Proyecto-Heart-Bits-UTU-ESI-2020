Public Class Pathology
    Public Property id As Integer
    Public Property priority As Priority
    Public Property name As String = Nothing
    Public Property description As String = Nothing
    Public Property mortalityIndex As Integer = 0
    Public Property evidence As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(name As String, evidence As String)
        Me.name = name
        Me.evidence = evidence
    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, name As String, mortalityIndex As Integer, priority As Priority)
        Me.id = id
        Me.name = name
        Me.mortalityIndex = mortalityIndex
        Me.priority = priority
    End Sub

    Public Sub New(id As Integer, priority As Priority, name As String, description As String, mortalityIndex As Integer)
        Me.id = id
        Me.priority = priority
        Me.name = name
        Me.description = description
        Me.mortalityIndex = mortalityIndex
    End Sub 'Full Constructor

End Class
