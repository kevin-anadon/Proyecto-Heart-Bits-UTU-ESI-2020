﻿Imports ADODB
Imports Data
Public Class ConnectionDB

    Private Function connect() As Connection
        Dim connection As New Connection()
        connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.0.0.1;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
        connection.Open()
        Return connection
    End Function

    'Public Function listarPriorities() As List(Of Priority)
    'Dim coleccion As New List(Of Priority)

    'Dim conn As Connection = connect()
    'Dim rs As Recordset = conn.Execute("SELECT nombre FROM prioridad")

    'While (Not rs.EOF)
    'pr As New Priority()
    '   pr.name = rs.Fields("nombre").Value.ToString()

    '    coleccion.Add(pr)
    '    rs.MoveNext()
    'End While
    ' conn.Close()
    'Return coleccion
    'End Function

    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = connect()
        If nameTable = "sintoma" Then
            Return con.Execute("SELECT s.descripcion,r.nombre FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id)")
        ElseIf nameTable = "region" Then
            Return con.Execute("SELECT nombre FROM region")
        End If
    End Function

    Public Function SearchSympt(nameDesc As String) As Recordset
        Dim con As Connection = connect()
        Return con.Execute("SELECT s.descripcion,r.nombre FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) WHERE s.descripcion like '" & nameDesc & "%'")
    End Function

    Public Function SearchRegion(nameRegion As String) As Recordset
        Dim conreg As Connection = connect()
        Return conreg.Execute("SELECT s.descripcion,r.nombre FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) WHERE r.nombre ='" + nameRegion + "'")
    End Function
End Class