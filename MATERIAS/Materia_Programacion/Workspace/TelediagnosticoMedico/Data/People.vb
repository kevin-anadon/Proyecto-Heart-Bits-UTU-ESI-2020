Imports Data.City

Public Class People
    Protected Property id As Integer = Nothing
    Protected Property ci As Integer = 0
    Protected Property allowed As Boolean = False
    Protected Property fstName As String = Nothing
    Protected Property scndName As String = Nothing
    Protected Property fstSurname As String = Nothing
    Protected Property scndSurname As String = Nothing
    Protected Enum Genre
        Hombre
        Mujer
        Otro
    End Enum
    Protected Property genrePeople As Genre = Nothing
    Protected Property dateBirth As Date = #01/01/1999#
    Protected Property email As String = "someone@example.com"
    Protected Property numPhone As String = Nothing
    Protected Property street As String = Nothing
    Protected Property numDoor As Integer = 0
    Protected Property city As City

    Public Sub New()

    End Sub 'Empty constructor (default)
    Public Sub New(ci As Integer)
        Me.ci = ci
    End Sub 'Necesary constructor

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

End Class 'People
