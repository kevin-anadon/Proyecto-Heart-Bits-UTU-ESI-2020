Public Class Translator 'Logic

    'Comportamientos
    Public Shared Function Translate(lang As String, id As String) As String
        Dim translated As String = Nothing

        Select Case lang
            Case "Spanish"
                translated = My.Resources.Spanish.ResourceManager.GetString(id)
            Case "English"
                translated = My.Resources.English.ResourceManager.GetString(id)
            Case Else
                translated = id
        End Select

        Return translated
    End Function
End Class 'Translator
