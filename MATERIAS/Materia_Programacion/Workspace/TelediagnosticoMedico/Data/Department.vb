Public Class Department

    Public Property Id As Integer
    Public Property name As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, name As String)
        Me.Id = id
        Me.name = name
    End Sub 'Full Constructor 

End Class 'Department
