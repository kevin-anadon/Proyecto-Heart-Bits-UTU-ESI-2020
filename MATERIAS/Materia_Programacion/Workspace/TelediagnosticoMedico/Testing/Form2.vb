Public Class Form2
    Private msgSelected As Integer = 0

    Private Sub init()
        PnlInfo.Visible = False
        LblInfo.Text = " "
        RdbtnCredentialF.Checked = False
        RdbtnFailC.Checked = False
        RdbtnLoginC.Checked = False
        RdbtnWhiteS.Checked = False
        PnlInfo.BorderColor = Color.FromArgb(97, 97, 97) 'Color Gris Mate = Default
    End Sub

    Private Sub selectMsg(msg As String, visible As Boolean)

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        PnlInfo.Visible = True
        Select Case msgSelected
            Case 1
                PnlInfo.BorderColor = Color.FromArgb(98, 186, 172) 'Color Turquesa = Correcto 
                LblInfo.Text = "Inicio de sesión correcto."
            Case 2
                PnlInfo.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
                LblInfo.Text = "Cédula de identidad errónea"
            Case 3
                PnlInfo.BorderColor = Color.FromArgb(255, 208, 52) 'Color Mostaza = En espera / Cuidado
                LblInfo.Text = "Hay espacios en blanco. Ingrese alguna CI."
            Case 4
                PnlInfo.BorderColor = Color.FromArgb(251, 136, 133) 'Color Corál = Error
                LblInfo.Text = "Conexión fallida."
            Case Else
                Me.init()
        End Select
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub RdbtnLoginC_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnLoginC.CheckedChanged
        msgSelected = 1
    End Sub

    Private Sub RdbtnCredentialF_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnCredentialF.CheckedChanged
        msgSelected = 2
    End Sub

    Private Sub RdbtnWhiteS_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnWhiteS.CheckedChanged
        msgSelected = 3
    End Sub

    Private Sub RdbtnFailC_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnFailC.CheckedChanged
        msgSelected = 4
    End Sub

    Private Sub BtnCloseInfo_Click(sender As Object, e As EventArgs) Handles BtnCloseInfo.Click
        init()
    End Sub
End Class