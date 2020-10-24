Public Class Message
    Public Property message As String
    Public Property idP As Integer
    Public Property hour As DateTime


    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(message As String, idp As Integer, hour As Date)
        Me.message = message
        Me.idP = idp
        Me.hour = hour
    End Sub 'Full Constructor



End Class
