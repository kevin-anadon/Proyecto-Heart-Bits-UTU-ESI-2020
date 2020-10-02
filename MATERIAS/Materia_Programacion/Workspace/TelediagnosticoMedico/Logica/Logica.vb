﻿Imports Persistencia
Imports Data

Public Class Logica
    'Atributos
    Private ReadOnly CQConnection As New DataBaseConn()

    'Herramientas de conexión
    Public Function TryConnection() As Boolean
        Dim resultConnection As Boolean = CQConnection.TryConnection
        Return resultConnection
    End Function



    'Conexión Otros
    Public Function ObtainRegions() As List(Of Region)
        Return CQConnection.ObtainRegions()
    End Function
    Public Function ObtainPriorities() As List(Of Priority)
        Return CQConnection.ObtainPriorities()
    End Function
    Public Function ObtainMortalityPath(pat As String) As Integer
        Return CQConnection.ObtainMortalityPath(pat)
    End Function
    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Return CQConnection.ObtainTreatments(pat)
    End Function



    'Conexión Patológias
    Public Function ObtainPath() As List(Of Pathology)
        Return CQConnection.ObtainPath()
    End Function



    'Conexión Síntomas
    Public Function ObtainSymptoms() As List(Of Symptom)
        Return CQConnection.ObtainSymptoms
    End Function



    'Conexión Personas
    Public Function matchPatientLoggedOn(ci As String) As Integer
        Return CQConnection.matchPatientLoggedOn(ci)
    End Function
    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        CQConnection.SetPatientSufferSymp(idPatient, idSympSuffered)
    End Sub
    Public Function ObtainPatholgiesSuffered() As List(Of Pathology)
        Return CQConnection.ObtainPatholgiesSuffered()
    End Function
    Public Function LogginPatient(ci As String) As Short
        Return CQConnection.LoginPatient(ci)
    End Function
    Public Function LoginAdmin(user As String, pass As String) As Admin
        Return CQConnection.LoginAdmin(user, pass)
    End Function












End Class 'Logic