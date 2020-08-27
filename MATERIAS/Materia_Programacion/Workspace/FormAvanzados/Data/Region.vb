Public Class Region
    Public Property id As String = Nothing
    Public Property name As String = Nothing
    Public Sub New()

    End Sub

    Public Sub New(id As Integer, name As String)
        Me.id = id
        Me.name = name
    End Sub

End Class
