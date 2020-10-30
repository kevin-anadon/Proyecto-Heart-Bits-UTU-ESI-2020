Public Class Medic
    Inherits Employee

    Public Property speciality As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, ci As Integer, fstName As String, scndName As String, fstSurname As String, scndSurname As String, genrePeople As Integer, dateBirth As Date, email As String, numPhone As String, street As String, numDoor As Integer, city As City, username As String, password As String, speciality As String)
        MyBase.New(id, ci, fstName, scndName, fstSurname, scndSurname, genrePeople, dateBirth, email, numPhone, street, numDoor, city, username, password)
        Me.speciality = speciality
    End Sub 'Full Constructor


End Class 'Medic
