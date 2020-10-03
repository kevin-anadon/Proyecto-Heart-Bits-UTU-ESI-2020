Public Class Admin
    Inherits Employee

    Public Property pin As Integer = 0

    Public Sub New()

    End Sub 'Empty Contructor (default)

    Public Sub New(id As Integer, ci As Integer, fstName As String, scndName As String, fstSurname As String, scndSurname As String, genrePeople As Integer, dateBirth As Date, email As String, numPhone As String, street As String, numDoor As Integer, city As City, username As String, password As String, pin As Integer)
        MyBase.New(id, ci, fstName, scndName, fstSurname, scndSurname, genrePeople, dateBirth, email, numPhone, street, numDoor, city, username, password)
        Me.pin = pin
    End Sub 'Full Constructor

End Class 'Admin
