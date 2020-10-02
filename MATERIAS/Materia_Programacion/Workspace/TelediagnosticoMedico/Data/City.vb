Imports Data.Department

Public Class City

    Public Property Id As Integer
    Public Property Department As Department
    Public Property Name As String = Nothing

    Public Sub New()

    End Sub 'Empty Constructor (default)

    Public Sub New(id As Integer, department As Department, name As String)
        Me.Id = id
        Me.Department = department
        Me.Name = name
    End Sub 'Full Constructor

End Class 'City
