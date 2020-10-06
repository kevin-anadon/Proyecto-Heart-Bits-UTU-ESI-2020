Imports Data.City

Public Class People
    Public Property id As Integer = Nothing
    Public Property ci As Integer = 0
    Public Property allowed As Boolean = False
    Public Property fstName As String = Nothing
    Public Property scndName As String = Nothing
    Public Property fstSurname As String = Nothing
    Public Property scndSurname As String = Nothing
    Public Enum Genre
        Hombre
        Mujer
        Otro
    End Enum
    Public Property genrePeople As Genre = Nothing
    Public Property dateBirth As Date = #01/01/1999#
    Public Property email As String = "someone@example.com"
    Public Property numPhone As String = Nothing
    Public Property street As String = Nothing
    Public Property numDoor As Integer = 0
    Public Property city As City

    Public Sub New()

    End Sub 'Empty constructor (default)
    Public Sub New(ci As Integer)
        Me.ci = ci
    End Sub 'Necesary constructor

    Public Sub New(id As Integer, ci As Integer)
        Me.id = id
        Me.ci = ci
    End Sub 'Necesary constructor

    Public Sub New(id As Integer, ci As Integer, fstName As String, scndName As String, fstSurname As String, scndSurname As String, genrePeople As Integer, dateBirth As Date, email As String, numPhone As String, street As String, numDoor As Integer, city As City)
        Me.id = id
        Me.ci = ci
        Me.allowed = allowed
        Me.fstName = fstName
        Me.scndName = scndName
        Me.fstSurname = fstSurname
        Me.scndSurname = scndSurname
        IdentifyGenre(genrePeople)
        Me.dateBirth = dateBirth
        Me.email = email
        Me.numPhone = numPhone
        Me.street = street
        Me.numDoor = numDoor
        Me.city = city
    End Sub 'Admin Constructor

    Public Sub New(ci As Integer, allowed As Boolean, fstName As String, scndName As String, fstSurname As String, scndSurname As String, genrePeople As Integer, dateBirth As Date, email As String, numPhone As String, street As String, numDoor As Integer, city As City)
        Me.ci = ci
        Me.allowed = allowed
        Me.fstName = fstName
        Me.scndName = scndName
        Me.fstSurname = fstSurname
        Me.scndSurname = scndSurname
        IdentifyGenre(genrePeople)
        Me.dateBirth = dateBirth
        Me.email = email
        Me.numPhone = numPhone
        Me.street = street
        Me.numDoor = numDoor
        Me.city = city
    End Sub 'Full constructor


    ''' <summary>
    '''     Función que identifica al género a asignar para la Persona
    '''     Almacena a la Propiedad local, el tipo de Genero que posee la Persona.
    ''' </summary>
    ''' <param name="genrePeople">
    '''     El género a escoger. 
    '''     Valores posibles: 0:H, 1:M, 2:O.
    '''     Debe de ser número entero el parámetro.
    ''' </param>
    Protected Sub IdentifyGenre(ByVal genrePeople As Integer)
        Select Case genrePeople
            Case 0
                Me.genrePeople = Genre.Hombre
            Case 1
                Me.genrePeople = Genre.Mujer
            Case 2
                Me.genrePeople = Genre.Otro
        End Select
    End Sub

    Public Function CalcAge(BirthDate As Date) As Integer
        Dim age As Integer = 0

        If BirthDate.Month > Today.Month Then
            age = DateDiff(DateInterval.Year, BirthDate, Date.Today).ToString - 1
        Else
            age = DateDiff(DateInterval.Year, BirthDate, Date.Today).ToString

        End If
        Return age
    End Function

    Public Function CiScript(ci As String) As String
        Dim CiResult As String = ""
        CiResult = ci.ToString().Substring(0, 7) + "-" + ci.ToString().Substring((ci.ToString().Length() - 1), 1)
        Return CiResult
    End Function

End Class 'People
