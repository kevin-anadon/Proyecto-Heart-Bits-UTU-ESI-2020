Imports Persistencia
Imports Data

Public Class LogicPatientApp
    Private PConnection As New ConnectionDB()

    'Estado 1: "Login" [Form]








    'Try
    'Dim rslog As People = ConnectionDB.CheckLog(user, pass, TxtCredential1.Text)
    'If IsNothing(rslog) Then
    'Se trabaja con la UI.
    'Me.indicatorToolBtn = 0
    'Else
    'Me.indicatorToolBtn = 2
    'Me.ciPatientLoggedOn = TxtCredential1.Text
    '             FrmHome.ciPatientLoggedOn = Me.ciPatientLoggedOn 'Envío la CI del paciente que se logeó al atributo del FrmHome.
    '               FrmHome.Show() 'Inicio el Frame "Pantalla Inicial".
    '              Me.Close() 'Cierro el Frame de "Login".
    ' End If

    'Catch ex As Exception
    '          Console.WriteLine("ERROR: " & ex.ToString())
    'Me.indicatorToolBtn = 3
    'End Try
End Class 'LogicPatientApp
