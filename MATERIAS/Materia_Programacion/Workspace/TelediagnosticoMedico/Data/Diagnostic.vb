Public Class Diagnostic

    Public Enum Kind
        Tentativo
        Definitivo
    End Enum

    Public Property Id As Integer
    Public Property KindDiagnostic As Kind
    Public Property Patient As People
    Public Property Pathology As Pathology
    Public Property DateD As Date

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, kindDiagnostic As Integer, patient As People, pathology As Pathology, dateD As Date)
        Me.Id = id
        IdentifyKindDiagnostic(kindDiagnostic)
        Me.Patient = patient
        Me.Pathology = pathology
        Me.DateD = dateD
    End Sub 'Full Constructor

    ''' <summary>
    '''     Función que identifica al tipo a asignar para el Diagnóstico
    '''     Almacena a la Propiedad local, el tipo de Diagnóstico.
    ''' </summary>
    ''' <param name="kindDiagnostic">
    '''     El Diagnóstico a escoger. 
    '''     Valores posibles: 0:Tentativo, 1:Definitivo.
    '''     Debe de ser número entero el parámetro.
    ''' </param>
    Private Sub IdentifyKindDiagnostic(ByVal kindDiagnostic As Integer)
        Select Case kindDiagnostic
            Case 0
                Me.kindDiagnostic = Kind.Tentativo
            Case 1
                Me.kindDiagnostic = Kind.Definitivo
        End Select
    End Sub

End Class 'Diagnostic
