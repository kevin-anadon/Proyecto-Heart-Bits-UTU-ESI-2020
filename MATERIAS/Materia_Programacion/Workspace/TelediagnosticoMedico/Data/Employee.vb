Public Class Employee
    Inherits People

    Public Property username As String = Nothing
    Public Property password As String = Nothing

    Public Sub New()
        MyBase.New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, ci As Integer, fstName As String, scndName As String, fstSurname As String, scndSurname As String, genrePeople As Integer, dateBirth As Date, email As String, numPhone As String, street As String, numDoor As Integer, city As City, username As String, password As String)
        MyBase.New(id, ci, fstName, scndName, fstSurname, scndSurname, genrePeople, dateBirth, email, numPhone, street, numDoor, city)
        Me.username = username
        Me.password = password
    End Sub 'Full Constructor

End Class 'Employee
