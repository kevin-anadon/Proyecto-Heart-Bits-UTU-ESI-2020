Imports Logic
Imports Data
Public Class FrmAdmin
    Dim log As New Logic.Logic

    Dim SelectedAdmin As Admin = Nothing
    Dim SelectedMedic As Medic = Nothing
    Dim SelectedPatient As People = Nothing
    Dim row As DataGridViewRow
    Dim CiSelected As String = ""
    Dim AllowedSelected As Integer = 0
    Dim Identify As Integer = 0

    Public Sub ReloadDgv()
        Try
            If Identify = 1 Then
                DgvAdmin.DataSource = log.ObtainMedicsDataSet().Tables("Refresh")
            ElseIf Identify = 2 Then
                DgvAdmin.DataSource = log.ObtainPatientsDataSet().Tables("Refresh")
            ElseIf Identify = 3 Then
                DgvAdmin.DataSource = log.ObtainAdminsDataSet().Tables("Refresh")
            End If
            DgvAdmin.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDgv()
        ObtainSelected()
        BtnAddAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnModAdmin.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelAdmin.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub BtnDelAdmin_Click(sender As Object, e As EventArgs) Handles BtnDelAdmin.Click
        Dim alerta As New FrmAlertRemove()
        If Identify = 1 Then 'Medico
            FrmAlertRemove.idMedic = SelectedMedic.id
            alerta.Obtain(SelectedMedic.CiScript(CiSelected), 3)
            alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar este médico?"
            alerta.LblEliminar.Text = "Eliminar Médico"
            alerta.LblElimBody.Text = "Eliminar al médico "
        ElseIf Identify = 2 Then 'Paciente
            FrmAlertRemove.idPatient = SelectedPatient.id
            alerta.Obtain(SelectedPatient.CiScript(CiSelected), 4)
            alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar este paciente?"
            alerta.LblEliminar.Text = "Eliminar Paciente"
            alerta.LblElimBody.Text = "Eliminar al paciente "
        ElseIf Identify = 3 Then 'Administrador
            FrmAlertRemove.idAdmin = SelectedAdmin.id
            alerta.Obtain(SelectedAdmin.CiScript(CiSelected), 2)
            alerta.LblPregunta.Text = "¿Está usted seguro de que quiere eliminar este administrador?"
            alerta.LblEliminar.Text = "Eliminar Administrador"
            alerta.LblElimBody.Text = "Eliminar al administrador "
            alerta.LblSympt.Location = New Point(312, 34)
        End If
        alerta.ShowDialog()
        ReloadDgv()
    End Sub

    Private Sub BtnAddAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddAdmin.Click
        Dim frm As New FrmAddModAdmin()
        FrmAddModAdmin.Add = True
        If Identify = 1 Then 'Medico
            FrmAddModAdmin.Identify = Identify
            frm.LblTittle.Text = "INSERTAR NUEVO MÉDICO "
        ElseIf Identify = 2 Then 'Paciente
            FrmAddModAdmin.Identify = Identify
            frm.LblPatTop.Text = "INSERTAR NUEVO PACIENTE "
        ElseIf Identify = 3 Then 'Administrador
            FrmAddModAdmin.Identify = Identify
            frm.LblPatTop.Text = "INSERTAR NUEVO ADMINISTRADOR "
        End If
        frm.ShowDialog()
        ReloadDgv()
    End Sub

    Public Sub ModAdmin()
        Dim frm As New FrmAddModAdmin()
        Try
            If Identify = 1 Then
                FrmAddModAdmin.Medic = SelectedMedic
                FrmAddModAdmin.Identify = Identify
                frm.LblTittle.Text = "MODIFICAR MÉDICO "
                frm.LblCiTop.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = "MODIFICAR"
            ElseIf Identify = 2 Then
                FrmAddModAdmin.Patient = SelectedPatient
                FrmAddModAdmin.Identify = Identify
                frm.LblPatTop.Text = "MODIFICAR PACIENTE "
                frm.LblPatPatient.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = "MODIFICAR"
            ElseIf Identify = 3 Then
                FrmAddModAdmin.Admin = SelectedAdmin
                FrmAddModAdmin.Identify = Identify
                frm.LblTittle.Text = "MODIFICAR ADMINISTRADOR "
                frm.LblCiTop.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = "MODIFICAR"
            End If
            FrmAddModAdmin.Add = False
            frm.ShowDialog()
            ReloadDgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnModAdmin_Click(sender As Object, e As EventArgs) Handles BtnModAdmin.Click 'Una manera de modificar
        ObtainSelected()
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
                If Identify = 1 Then
                    DgvAdmin.DataSource = log.SearchMedic(ciInt).Tables("Search")
                ElseIf Identify = 2 Then
                    DgvAdmin.DataSource = log.SearchPatient(ciInt).Tables("Search")
                ElseIf Identify = 3 Then
                    DgvAdmin.DataSource = log.SearchAdmin(ciInt).Tables("Search")
                End If
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
        ObtainSelected()
    End Sub

    Public Sub ObtainSelected()
        row = DgvAdmin.CurrentRow
        If IsDBNull(row.Cells("Ci").Value) Then

        Else
            row = DgvAdmin.CurrentRow
            CiSelected = CStr(row.Cells("Ci").Value) 'Obtengo el ci seleccionado
            If Identify = 1 Then
                For Each Medic As Medic In log.ObtainMedics()
                    If Medic.ci.ToString().Equals(CiSelected) Then
                        SelectedMedic = Medic
                    End If
                Next
            ElseIf Identify = 2 Then
                For Each Patient As People In log.ObtainPatients()
                    If Patient.ci.ToString().Equals(CiSelected) Then
                        SelectedPatient = Patient
                    End If
                Next
                AllowedSelected = CInt(row.Cells("Habilitado").Value) 'Obtengo el estado, es decir, si se encuentra habilitado para utilizar el autodiagnóstico
                If AllowedSelected = 1 Then
                    BtnAllow.Size = New Point(121, 20)
                    BtnAllow.Location = New Point(245, 214)
                    BtnAllow.Text = "DESHABILITAR"
                Else
                    BtnAllow.Size = New Point(96, 20)
                    BtnAllow.Location = New Point(270, 214)
                    BtnAllow.Text = "HABILITAR"
                End If
            ElseIf Identify = 3 Then
                For Each Admin As Admin In log.ObtainAdmins()
                    If Admin.ci.ToString().Equals(CiSelected) Then
                        SelectedAdmin = Admin
                    End If
                Next
            End If
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
                    If Identify = 3 Or Identify = 0 Then
                        BtnAdmin.BaseColor = Color.White
                        BtnAdmin.ForeColor = Color.Black
                        BtnAdmin.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnAdmin.Image = My.Resources.GreenPerson
                    ElseIf Identify = 2 Then
                        BtnPac.BaseColor = Color.White
                        BtnPac.ForeColor = Color.Black
                        BtnPac.Font = New Font(BtnAdmin.Font, FontStyle.Regular)
                        BtnPac.Image = My.Resources.GreenPerson
                        BtnAllow.Visible = False
                    End If
                    BtnMed.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnMed.ForeColor = Color.White
                    BtnMed.Font = New Font(BtnMed.Font, FontStyle.Bold)
                    BtnMed.Image = My.Resources.AdminWhite
                    Identify = 1
                    ReloadDgv()
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
                    If Identify = 3 Or Identify = 0 Then
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
                    BtnAllow.BackColor = Color.FromArgb(240, 240, 240)
                    BtnAllow.Visible = True
                    Identify = 2
                    ReloadDgv()
                End If
            Case 2 'Para los Administradores
                If Not Identify = 3 Then
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
                        BtnAllow.Visible = False
                    End If
                    Identify = 3
                    ReloadDgv()
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

    Private Sub BtnAllow_Click(sender As Object, e As EventArgs) Handles BtnAllow.Click
        Try
            If AllowedSelected = 0 Then
                log.AllowPatient(SelectedPatient.id)
            Else
                log.DisablePatient(SelectedPatient.id)
            End If
            ReloadDgv()
            ObtainSelected()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class