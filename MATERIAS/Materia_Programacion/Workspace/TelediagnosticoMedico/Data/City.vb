Imports Data.Department

Public Class City

    Public Property Department As Department
    Public Property Name As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(department As Department, name As String)
        Me.department = department
        Me.name = name
    End Sub 'Full Constructor

End Class 'City
