
'Imports


'Package Design
Public Class FrmHome





    'initComponents
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub cbxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartment.SelectedIndexChanged
        Select Case cbxDepartment.SelectedIndex
            Case Is = 0
                lbxCities.Items.Clear()
                lbxCities.Items.Add("Salinas")
                lbxCities.Items.Add("Atlántida")
                lbxCities.Items.Add("Marindia")
                lbxCities.Items.Add("Neptunia")
                lbxCities.Items.Add("Pinepark")
            Case Is = 1
                lbxCities.Items.Clear()
                lbxCities.Items.Add("Maldonado")
                lbxCities.Items.Add("Punta del este")
                lbxCities.Items.Add("La fortuna")
                lbxCities.Items.Add("Miguez")
            Case Is = 2
                lbxCities.Items.Clear()
                lbxCities.Items.Add("Montevido")
                lbxCities.Items.Add("Reducto")
                lbxCities.Items.Add("Rivera")
                lbxCities.Items.Add("Piedras blancas")
                lbxCities.Items.Add("La teja")
        End Select
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class
