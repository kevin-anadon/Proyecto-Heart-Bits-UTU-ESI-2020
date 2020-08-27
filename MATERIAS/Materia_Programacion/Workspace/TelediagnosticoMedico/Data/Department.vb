Public Class Department

    Private Property name As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(name As String)
        Me.name = name
    End Sub 'Full Constructor 

End Class 'Department
