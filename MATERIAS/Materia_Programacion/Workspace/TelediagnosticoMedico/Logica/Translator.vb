Imports System.Windows.Forms
Public Class Translator 'Clase dedicada a las traducciones
    Dim lang As String = ""
    Public Shared Property Instance As New Translator

    'Patron Singletone
    Public Sub LoadLanguage(language As String)
        lang = language
    End Sub

    'Comportamientos
    Public Function Translate(id As String) As String
        Dim translated As String = Nothing

        Select Case lang
            Case "Spanish"
                translated = My.Resources.Spanish.ResourceManager.GetString(id)
            Case "English"
                translated = My.Resources.English.ResourceManager.GetString(id)
            Case Else
                translated = id
        End Select

        If translated = Nothing Then
            translated = id
        End If

        Return translated
    End Function
    Public Sub TranslateForm(formulario As Form)
        For Each control As Control In formulario.Controls
            'Analizo dentro del form los distintos tipos de controles que me puedo encontrar
            If TypeOf control Is Label Then
                TranslateLabel(control)
            ElseIf TypeOf control Is Button Then
                TranslateButton(control)
            ElseIf TypeOf control Is Guna.UI2.WinForms.Guna2Button Then
                TranslateGuna2Button(control)
            ElseIf TypeOf control Is Guna.UI2.WinForms.Guna2HtmlLabel Then
                TranslateGunaHtmlLabel(control)
            ElseIf TypeOf control Is Guna.UI2.WinForms.Guna2CheckBox Then
                TranslateGuna2CheckBox(control)
            ElseIf TypeOf control Is Guna.UI.WinForms.GunaCheckBox Then
                TranslateGunaCheckBox(control)
            ElseIf TypeOf control Is Guna.UI.WinForms.GunaButton Then
                TranslateGunaButton(control)
            ElseIf TypeOf control Is Panel Then
                TranslatePanel(control)
            ElseIf TypeOf control Is Guna.UI2.WinForms.Guna2Panel Then
                TranslateGunaPanel(control)
            End If
        Next
    End Sub

    'Métodos de traduccion de controles específicos
    'Paneles
    'En el caso de los paneles recorro por cada elemento que contengan
    Private Sub TranslatePanel(ctrl As Control)
        Dim Panels As Panel = DirectCast(ctrl, Panel)
        For Each ctrl2 As Control In Panels.Controls
            If TypeOf ctrl2 Is Label Then
                TranslateLabel(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2HtmlLabel Then
                TranslateGunaHtmlLabel(ctrl2)
            End If
            If TypeOf ctrl2 Is Button Then
                TranslateButton(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2Button Then
                TranslateGuna2Button(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI.WinForms.GunaButton Then
                TranslateGunaButton(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2CheckBox Then
                TranslateGuna2CheckBox(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI.WinForms.GunaCheckBox Then
                TranslateGunaCheckBox(ctrl2)
            End If
            If TypeOf ctrl2 Is Panel Then
                TranslatePanel(ctrl2)
            End If
        Next
    End Sub
    Private Sub TranslateGunaPanel(ctrl As Control)
        Dim Panels As Guna.UI2.WinForms.Guna2Panel = DirectCast(ctrl, Guna.UI2.WinForms.Guna2Panel)
        For Each ctrl2 As Control In Panels.Controls
            If TypeOf ctrl2 Is Label Then
                TranslateLabel(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2HtmlLabel Then
                TranslateGunaHtmlLabel(ctrl2)
            End If
            If TypeOf ctrl2 Is Button Then
                TranslateButton(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2Button Then
                TranslateGuna2Button(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI.WinForms.GunaButton Then
                TranslateGunaButton(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2CheckBox Then
                TranslateGuna2CheckBox(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI.WinForms.GunaCheckBox Then
                TranslateGunaCheckBox(ctrl2)
            End If
            If TypeOf ctrl2 Is Guna.UI2.WinForms.Guna2Panel Then
                TranslateGunaPanel(ctrl2)
            End If
        Next
    End Sub
    'Otros controles
    Private Sub TranslateLabel(ctrl As Control)
        Dim label As Label = DirectCast(ctrl, Label)
        label.Text = Translate(label.Name)
    End Sub

    Private Sub TranslateButton(ctrl As Control)
        Dim Btn As Button = DirectCast(ctrl, Button)
        If Btn.Text = "" Then

        Else
            Btn.Text = Translate(Btn.Name)
        End If
    End Sub

    Private Sub TranslateGuna2Button(ctrl As Control)
        Dim Btn As Guna.UI2.WinForms.Guna2Button = DirectCast(ctrl, Guna.UI2.WinForms.Guna2Button)
        If Btn.Text = "" Then

        Else
            Btn.Text = Translate(Btn.Name)
        End If
    End Sub
    Private Sub TranslateGunaButton(ctrl As Control)
        Dim Btn As Guna.UI.WinForms.GunaButton = DirectCast(ctrl, Guna.UI.WinForms.GunaButton)
        If Btn.Text = "" Then

        Else
            Btn.Text = Translate(Btn.Name)
        End If
    End Sub
    Private Sub TranslateGunaHtmlLabel(ctrl As Control)
        Dim label As Guna.UI2.WinForms.Guna2HtmlLabel = DirectCast(ctrl, Guna.UI2.WinForms.Guna2HtmlLabel)
        label.Text = Translate(label.Name)
    End Sub

    Private Sub TranslateGuna2CheckBox(ctrl As Control)
        Dim chk As Guna.UI2.WinForms.Guna2CheckBox = DirectCast(ctrl, Guna.UI2.WinForms.Guna2CheckBox)
        chk.Text = Translate(chk.Name)
    End Sub
    Private Sub TranslateGunaCheckBox(ctrl As Control)
        Dim chk As Guna.UI.WinForms.GunaCheckBox = DirectCast(ctrl, Guna.UI.WinForms.GunaCheckBox)
        chk.Text = Translate(chk.Name)
    End Sub

End Class 'TranslatorS
