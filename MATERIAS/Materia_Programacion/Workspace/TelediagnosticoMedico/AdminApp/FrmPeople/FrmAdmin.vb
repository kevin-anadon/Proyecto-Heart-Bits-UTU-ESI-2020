Imports Logic
Imports Data
Public Class FrmAdmin
    Dim log As New Logic.Logic

    Dim SelectedAdmin As Admin = Nothing
    Dim row As DataGridViewRow
    Dim CiSelected As String = ""
    Dim Identify As Integer = 0

    Public Sub ReloadDgv()
        Try
            DgvAdmin.DataSource = log.ObtainAdminsDataSet().Tables("Refresh")
            DgvAdmin.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv()
        BtnAddAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnModAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelAdmin.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub BtnDelAdmin_Click(sender As Object, e As EventArgs) Handles BtnDelAdmin.Click
        Dim alerta As New FrmAlertRemove()
        FrmAlertRemove.idAdmin = SelectedAdmin.id
        alerta.Obtain(SelectedAdmin.CiScript(CiSelected), 2)
        alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar este administrador?"
        alerta.LblEliminar.Text = "Eliminar Administrador"
        alerta.LblElimBody.Text = "Eliminar al administrador "
        alerta.LblSympt.Location = New Point(312, 34)
        alerta.ShowDialog()
        ReloadDgv()
    End Sub

    Private Sub BtnAddAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddAdmin.Click
        Dim frm As New FrmAddModAdmin()
        FrmAddModAdmin.Add = True
        frm.ShowDialog()
        ReloadDgv()
    End Sub

    Public Sub ModAdmin()
        Dim frm As New FrmAddModAdmin()

        Try
            FrmAddModAdmin.Admin = SelectedAdmin
            frm.LblTittle.Text = "MODIFICAR ADMINISTRADOR "
            frm.LblCiTop.Text = CStr(row.Cells("Nombre").Value)
            frm.BtnAdd.Text = "MODIFICAR"
            frm.ShowDialog()
            ReloadDgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnModAdmin_Click(sender As Object, e As EventArgs) Handles BtnModAdmin.Click 'Una manera de modificar
        ObtainSelectedAdmin()
        ModAdmin()
    End Sub

    Private Sub DgvAdmin_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmin.CellDoubleClick 'Otra manera de modificar
        ModAdmin()
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub BtnSympt_Click(sender As Object, e As EventArgs) Handles BtnSympt.Click
        Dim frm As New FrmSympt()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPath.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim frm As New FrmHome()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub TxtCi_TextChanged(sender As Object, e As EventArgs) Handles TxtCi.TextChanged
        If TxtCi.Text.Equals("") Or TxtCi.Text.Equals("Realizar busqueda por c.i") Then
            ReloadDgv()
        Else
            Dim ci As String = TxtCi.Text
            Try
                Dim ciInt As Integer = CInt(ci)
                DgvAdmin.DataSource = log.SearchAdmin(ciInt).Tables("Search")
                DgvAdmin.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TxtCi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCi.KeyPress 'Verifica que unicamente ingrese números
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub DgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmin.CellClick
        ObtainSelectedAdmin()
    End Sub

    Public Sub ObtainSelectedAdmin()
        row = DgvAdmin.CurrentRow
        If IsDBNull(row.Cells("Ci").Value) Then

        Else
            row = DgvAdmin.CurrentRow
            CiSelected = CStr(row.Cells("Ci").Value) 'Obtengo el ci seleccionado
            For Each Admin As Admin In log.ObtainAdmins()
                If Admin.ci.ToString().Equals(CiSelected) Then
                    SelectedAdmin = Admin
                End If
            Next
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub

    Private Sub TxtCi_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtCi.MouseClick
        TxtCi.Text = ""
    End Sub

    Public Sub IdentifyPeople(i As Integer)
        Select Case i
            Case 0 'Para los Médicos
                If Not Identify = 1 Then
                    LblTittle.Text = "GESTIÓN DE MÉDICOS"
                    LblListado.Text = "LISTADO MÉDICOS"
                    BtnAddAdmin.Text = "NUEVO MÉDICO"
                    BtnDelAdmin.Text = "ELIMINAR MÉDICO"
                    BtnModAdmin.Text = "MODIFICAR MÉDICO"
                    BtnAddAdmin.Size = New System.Drawing.Size(126, 20)
                    BtnAddAdmin.Location = New Point(718, 214)
                    BtnDelAdmin.Size = New System.Drawing.Size(144, 20)
                    BtnDelAdmin.Location = New Point(568, 214)
                    BtnModAdmin.Size = New System.Drawing.Size(154, 20)
                    BtnModAdmin.Location = New Point(408, 214)
                    PicBar.Location = New Point(159, 94)
                    If Identify = 0 Then
                        BtnAdmin.BaseColor = Color.White
                        BtnAdmin.ForeColor = Color.Black
                        BtnAdmin.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnAdmin.Image = My.Resources.GreenPerson
                    ElseIf Identify = 2 Then
                        BtnPac.BaseColor = Color.White
                        BtnPac.ForeColor = Color.Black
                        BtnPac.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnPac.Image = My.Resources.GreenPerson
                    End If
                    BtnMed.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnMed.ForeColor = Color.White
                    BtnMed.Font = New Font(BtnMed.Font, FontStyle.Bold)
                    BtnMed.Image = My.Resources.AdminWhite
                    Identify = 1
                End If
            Case 1 'Para los pacientes
                If Not Identify = 2 Then
                    LblTittle.Text = "GESTIÓN DE PACIENTES"
                    LblListado.Text = "LISTADO PACIENTES"
                    BtnAddAdmin.Text = "NUEVO PACIENTE"
                    BtnDelAdmin.Text = "ELIMINAR PACIENTE"
                    BtnModAdmin.Text = "MODIFICAR PACIENTE"
                    BtnAddAdmin.Size = New System.Drawing.Size(138, 20)
                    BtnAddAdmin.Location = New Point(701, 214)
                    BtnDelAdmin.Size = New System.Drawing.Size(154, 20)
                    BtnDelAdmin.Location = New Point(541, 214)
                    BtnModAdmin.Size = New System.Drawing.Size(163, 20)
                    BtnModAdmin.Location = New Point(372, 214)
                    PicBar.Location = New Point(159, 58)
                    If Identify = 0 Then
                        BtnAdmin.BaseColor = Color.White
                        BtnAdmin.ForeColor = Color.Black
                        BtnAdmin.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnAdmin.Image = My.Resources.GreenPerson
                    ElseIf Identify = 1 Then
                        BtnMed.BaseColor = Color.White
                        BtnMed.ForeColor = Color.Black
                        BtnMed.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnMed.Image = My.Resources.GreenPerson
                    End If
                    BtnPac.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnPac.ForeColor = Color.White
                    BtnPac.Font = New Font(BtnMed.Font, FontStyle.Bold)
                    BtnPac.Image = My.Resources.AdminWhite
                    Identify = 2
                End If
            Case 2 'Para los Administradores
                If Not Identify = 0 Then
                    LblTittle.Text = "GESTIÓN DE ADMINISTRADORES"
                    LblListado.Text = "LISTADO ADMINISTRADORES"
                    BtnAddAdmin.Text = "NUEVO ADMIN"
                    BtnDelAdmin.Text = "ELIMINAR ADMIN"
                    BtnModAdmin.Text = "MODIFICAR ADMIN"
                    BtnAddAdmin.Size = New System.Drawing.Size(124, 20)
                    BtnAddAdmin.Location = New Point(718, 214)
                    BtnDelAdmin.Size = New System.Drawing.Size(138, 20)
                    BtnDelAdmin.Location = New Point(574, 214)
                    BtnModAdmin.Size = New System.Drawing.Size(148, 20)
                    BtnModAdmin.Location = New Point(420, 214)
                    PicBar.Location = New Point(159, 130)
                    BtnAdmin.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnAdmin.ForeColor = Color.White
                    BtnAdmin.Font = New Font(BtnMed.Font, FontStyle.Bold)
                    BtnAdmin.Image = My.Resources.AdminWhite
                    If Identify = 1 Then
                        BtnMed.BaseColor = Color.White
                        BtnMed.ForeColor = Color.Black
                        BtnMed.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnMed.Image = My.Resources.GreenPerson
                    ElseIf Identify = 2 Then
                        BtnPac.BaseColor = Color.White
                        BtnPac.ForeColor = Color.Black
                        BtnPac.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnPac.Image = My.Resources.GreenPerson
                    End If
                    Identify = 0
                End If
        End Select


    End Sub

    Private Sub BtnMed_Click_1(sender As Object, e As EventArgs) Handles BtnMed.Click
        IdentifyPeople(0)
    End Sub

    Private Sub BtnPac_Click(sender As Object, e As EventArgs) Handles BtnPac.Click
        IdentifyPeople(1)
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        IdentifyPeople(2)
    End Sub
End Class