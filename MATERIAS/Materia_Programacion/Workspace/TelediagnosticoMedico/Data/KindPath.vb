Public Class KindPath
    Public Property id As Integer
    Public Property name As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, name As String)
        Me.id = id
        Me.name = name
    End Sub 'Full Constructor
End Class
