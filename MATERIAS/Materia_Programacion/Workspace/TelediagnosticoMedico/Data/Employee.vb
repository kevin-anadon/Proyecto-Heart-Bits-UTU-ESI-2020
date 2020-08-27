Public Class Employee
    Inherits People

    Protected Property username As String = Nothing
    Protected Property password As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(username As String, password As String)
        Me.username = username
        Me.password = password
    End Sub 'Full Constructor

End Class 'Employee
