Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic
Imports Data

<TestClass()> Public Class WhiteBoxTesting
    Private ReadOnly log As New Controller()

    <TestMethod()> Public Sub Test_ObtainMessages_0()
        Dim Exception As Boolean = False
        Try
            log.ObtainMessages(0)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub

    <TestMethod()> Public Sub Test_ObtainMessages_Nothing()
        Dim Exception As Boolean = False
        Try
            log.ObtainMessages(Nothing)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub

    <TestMethod()> Public Sub Test_ObtainTalkingMed_Nothing()
        Dim Exception As Boolean = False
        Try
            log.ObtainTalkingMed(Nothing, Nothing)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub
    <TestMethod()> Public Sub Test_ObtainTentativeDiagnostic_Nothing()
        Dim Exception As Boolean = False
        Try
            log.ObtainTentativeDiagnostic(Nothing, Nothing)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub

    <TestMethod()> Public Sub Test_ObtainMortalityPath_Space()
        Dim x As Integer = log.ObtainMortalityPath(" ")
        Assert.AreEqual(0, x)
    End Sub

    <TestMethod()> Public Sub Test_ObtainTreatments_Space()
        Dim x As List(Of Treatment) = log.ObtainTreatments(" ")
        Assert.AreEqual(0, x.Count)
    End Sub

    <TestMethod()> Public Sub Test_SearchPathology_Space()
        Dim Exception As Boolean = False
        Try
            log.SearchPathology(" ")
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub

    <TestMethod()> Public Sub Test_ObtainIdSymptoms_Nothing()
        Dim x As List(Of String) = log.ObtainIdSymptoms(Nothing, Nothing)
        Assert.AreEqual(0, x.Count)
    End Sub

    <TestMethod()> Public Sub Test_ObtainSymptomsSuffered_Nothing()
        Dim x As List(Of Symptom) = log.ObtainSymptomsSuffered(Nothing, Nothing)
        Assert.AreEqual(0, x.Count)
    End Sub

    <TestMethod()> Public Sub Test_MatchPatientLoggedOn_Empty()
        Dim x As Integer = log.matchPatientLoggedOn("")
        Assert.AreEqual(0, x)
    End Sub

    <TestMethod()> Public Sub Test_LoginMedic_Nothing()
        Dim Exception As Boolean = False
        Try
            log.LoginMedic(Nothing, Nothing)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub

    <TestMethod()> Public Sub Test_InfoEmployeeLogged_Empty()
        Dim x As Short = log.InfoEmployeeLogged("", "")
        Assert.AreEqual(Convert.ToInt16(4), x)
    End Sub

    <TestMethod()> Public Sub Test_AddSymptoms_Empty()
        Dim Exception As Boolean = False
        Try
            log.AddSymptoms(Nothing, Nothing)
        Catch ex As Exception
            Exception = True
        End Try
        Assert.AreEqual(True, Exception)
    End Sub
End Class