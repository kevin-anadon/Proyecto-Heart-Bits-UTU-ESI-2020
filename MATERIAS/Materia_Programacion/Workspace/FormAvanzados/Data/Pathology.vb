Public Class Pathology
    Public Property priority As Priority
    Public Property name As String = Nothing
    Public Property description As String = Nothing
    Public Property mortalityIndex As Integer = 0

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(priority As Priority, name As String, description As String, mortalityIndex As Integer)
        Me.priority = priority
        Me.name = name
        Me.description = description
        Me.mortalityIndex = mortalityIndex
    End Sub 'Full Constructor

End Class
