Public Class Admin
    Inherits Employee

    Private Property pin As Integer = 0

    Public Sub New()

    End Sub 'Empty Contructor (default)

    Public Sub New(pin As Integer)
        Me.pin = pin
    End Sub 'Full Constructor

End Class 'Admin
