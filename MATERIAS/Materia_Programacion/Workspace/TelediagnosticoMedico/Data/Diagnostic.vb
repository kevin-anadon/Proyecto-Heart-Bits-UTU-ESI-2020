Public Class Diagnostic

    Private Enum Kind
        Tentativo
        Definitivo
    End Enum
    Private Property kindDiagnostic As Kind
    Private Property patient As People
    Private Property symptom As Symptom
    Private Property dateD As Date

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
    ''' </summary>
    ''' <param name="kindDiagnostic">
    '''     El Diagnóstico a escoger. 
    '''     Valores posibles: 0:Tentativo, 1:Definitivo.
    '''     Debe de ser número entero el parámetro.
    ''' </param>
    ''' <returns>
    '''     Almacena a la Propiedad local, el tipo de Diagnóstico.
    ''' </returns>
    Private Sub IdentifyKindDiagnostic(ByVal kindDiagnostic As Integer)
        Select Case kindDiagnostic
            Case 0
                Me.kindDiagnostic = Kind.Tentativo
            Case 1
                Me.kindDiagnostic = Kind.Definitivo
        End Select
    End Sub

End Class 'Diagnostic
