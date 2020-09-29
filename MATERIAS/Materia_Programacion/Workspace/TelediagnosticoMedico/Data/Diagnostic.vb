Public Class Diagnostic

    Public Enum Kind
        Tentativo
        Definitivo
    End Enum
    Public Property KindDiagnostic As Kind
    Public Property Patient As People
    Public Property Symptom As Symptom
    Public Property DateD As Date

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(kindDiagnostic As Integer, patient As People, symptom As Symptom, dateD As Date)
        IdentifyKindDiagnostic(kindDiagnostic)
        Me.patient = patient
        Me.symptom = symptom
        Me.dateD = dateD
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
