Public Class Employee
    Inherits People

    Public Property username As String = Nothing
    Public Property password As String = Nothing

    Public Sub New()
        MyBase.New()

    End Sub 'Empty Constructor (default)

    Public Sub New(username As String, password As String)
        MyBase.New()
        Me.username = username
        Me.password = password
    End Sub 'Full Constructor

End Class 'Employee
