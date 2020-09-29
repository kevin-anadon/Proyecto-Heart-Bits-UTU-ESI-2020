Public Class Medic
    Inherits Employee

    Public Property speciality As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(speciality As String)
        Me.speciality = speciality
    End Sub 'Full Constructor

End Class 'Medic
