Imports Logic
Imports Data
Public Class FrmAdmin
    Dim log As New Logic.Controller

    Dim SelectedAdmin As Admin = Nothing
    Dim SelectedMedic As Medic = Nothing
    Dim SelectedPatient As People = Nothing
    Dim row As DataGridViewRow
    Dim CiSelected As String = ""
    Dim AllowedSelected As Integer = 0
    Dim Identify As Integer = 0
    Dim Fix As Integer = 0

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

    Private Sub FixTranslate()
        Select Case Fix
            Case 0 'Para los Médicos
                LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittleMedic_A_M")
                LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoMedic_A_M")
                BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddMedic_A_M")
                BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelMedic_A_M")
                BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModMedic_A_M")
            Case 1 'Para los pacientes
                LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittlePatient_A_P")
                LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoPatient_A_P")
                BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddPatient_A_P")
                BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelPatient_A_P")
                BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModPatient_A_P")
            Case 2 'Para los Administradores
                LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittleAdmin_A_A")
                LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoAdmin_A_A")
                BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddAdmin_A_A")
                BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelAdmin_A_A")
                BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModAdmin_A_A")
        End Select
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Translator.Instance.TranslateForm(Me)
        FixTranslate()
        ReloadDgv()
        ObtainSelected()
        BtnAddAdmin_A_A.BackColor = Color.FromArgb(240, 240, 240)
        BtnModAdmin_A_A.BackColor = Color.FromArgb(240, 240, 240)
        BtnDelAdmin_A_A.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub BtnDelAdmin_Click(sender As Object, e As EventArgs) Handles BtnDelAdmin_A_A.Click
        Dim alerta As New FrmAlertRemove()
        If Identify = 1 Then 'Medico
            FrmAlertRemove.idMedic = SelectedMedic.id
            alerta.Obtain(SelectedMedic.CiScript(CiSelected), 3)
            alerta.LblPregunta_A_R.Text = "¿Está usted seguro de que quiere eliminar este médico?"
            alerta.LblEliminar.Text = "Eliminar Médico"
            alerta.LblElimBody.Text = "Eliminar al médico "
        ElseIf Identify = 2 Then 'Paciente
            FrmAlertRemove.idPatient = SelectedPatient.id
            alerta.Obtain(SelectedPatient.CiScript(CiSelected), 4)
            alerta.LblPregunta_A_R.Text = "¿Está usted seguro de que quiere eliminar este paciente?"
            alerta.LblEliminar.Text = "Eliminar Paciente"
            alerta.LblElimBody.Text = "Eliminar al paciente "
        ElseIf Identify = 3 Then 'Administrador
            FrmAlertRemove.idAdmin = SelectedAdmin.id
            alerta.Obtain(SelectedAdmin.CiScript(CiSelected), 2)
            alerta.LblPregunta_A_R.Text = "¿Está usted seguro de que quiere eliminar este administrador?"
            alerta.LblEliminar.Text = "Eliminar Administrador"
            alerta.LblElimBody.Text = "Eliminar al administrador "
            alerta.LblSympt.Location = New Point(312, 34)
        End If
        alerta.ShowDialog()
        ReloadDgv()
    End Sub

    Private Sub BtnAddAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddAdmin_A_A.Click
        Dim frm As New FrmAddModAdmin()
        FrmAddModAdmin.Add = True
        If Identify = 1 Then 'Medico
            FrmAddModAdmin.Identify = Identify
            frm.LblTittle.Text = Translator.Instance.Translate("InsertNewMedic")
        ElseIf Identify = 2 Then 'Paciente
            FrmAddModAdmin.Identify = Identify
            frm.LblPatTop.Text = Translator.Instance.Translate("InsertNewPatient")
        ElseIf Identify = 3 Then 'Administrador
            FrmAddModAdmin.Identify = Identify
            frm.LblPatTop.Text = Translator.Instance.Translate("InsertNewAdmin")
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
                frm.LblTittle.Text = Translator.Instance.Translate("ModifyMedic")
                frm.LblCiTop.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = Translator.Instance.Translate("Mod")
            ElseIf Identify = 2 Then
                FrmAddModAdmin.Patient = SelectedPatient
                FrmAddModAdmin.Identify = Identify
                frm.LblPatTop.Text = Translator.Instance.Translate("ModifyPatient")
                frm.LblPatPatient.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = Translator.Instance.Translate("Mod")
            ElseIf Identify = 3 Then
                FrmAddModAdmin.Admin = SelectedAdmin
                FrmAddModAdmin.Identify = Identify
                frm.LblTittle.Text = Translator.Instance.Translate("ModifyAdmin")
                frm.LblCiTop.Text = CStr(row.Cells("Nombre").Value)
                frm.BtnAdd.Text = Translator.Instance.Translate("Mod")
            End If
            FrmAddModAdmin.Add = False
            frm.ShowDialog()
            ReloadDgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnModAdmin_Click(sender As Object, e As EventArgs) Handles BtnModAdmin_A_A.Click 'Una manera de modificar
        ObtainSelected()
        ModAdmin()
    End Sub

    Private Sub DgvAdmin_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmin.CellDoubleClick 'Otra manera de modificar
        ModAdmin()
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub BtnSympt_Click(sender As Object, e As EventArgs) Handles BtnSymp_A_HP.Click
        Dim frm As New FrmSympt()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPathologies_A_HP.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome_A_HP.Click
        Dim frm As New FrmHome()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout_A_HP.Click
        If MsgBox(Translator.Instance.Translate("LogOut_M_H"), MsgBoxStyle.YesNoCancel, Translator.Instance.Translate("CloseProgram_M_H")) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub TxtCi_TextChanged(sender As Object, e As EventArgs) Handles TxtCi.TextChanged
        If TxtCi.Text.Equals("") Or TxtCi.Text.Equals("Realizar busqueda por c.i") Or TxtCi.Text.Equals(Translator.Instance.Translate("TxtCi")) Then
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
                    BtnAllow_A_P.Size = New Point(121, 20)
                    BtnAllow_A_P.Location = New Point(245, 214)
                    BtnAllow_A_P.Text = Translator.Instance.Translate("BtnDisable_A_P")
                Else
                    BtnAllow_A_P.Size = New Point(96, 20)
                    BtnAllow_A_P.Location = New Point(270, 214)
                    BtnAllow_A_P.Text = Translator.Instance.Translate("BtnAllow_A_P")
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
        TxtCi.Text = Translator.Instance.Translate("TxtCi")
        Select Case i
            Case 0 'Para los Médicos
                If Not Identify = 1 Then
                    LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittleMedic_A_M")
                    LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoMedic_A_M")
                    BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddMedic_A_M")
                    BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelMedic_A_M")
                    BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModMedic_A_M")
                    BtnAddAdmin_A_A.Size = New System.Drawing.Size(126, 20)
                    BtnAddAdmin_A_A.Location = New Point(718, 214)
                    BtnDelAdmin_A_A.Size = New System.Drawing.Size(144, 20)
                    BtnDelAdmin_A_A.Location = New Point(568, 214)
                    BtnModAdmin_A_A.Size = New System.Drawing.Size(154, 20)
                    BtnModAdmin_A_A.Location = New Point(408, 214)
                    PicBar.Location = New Point(159, 94)
                    If Identify = 3 Or Identify = 0 Then
                        BtnAdmins_A_HP.BaseColor = Color.White
                        BtnAdmins_A_HP.ForeColor = Color.Black
                        BtnAdmins_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnAdmins_A_HP.Image = My.Resources.GreenPerson
                    ElseIf Identify = 2 Then
                        BtnPatients_A_HP.BaseColor = Color.White
                        BtnPatients_A_HP.ForeColor = Color.Black
                        BtnPatients_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnPatients_A_HP.Image = My.Resources.GreenPerson
                        BtnAllow_A_P.Visible = False
                    End If
                    BtnMedics_A_HP.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnMedics_A_HP.ForeColor = Color.White
                    BtnMedics_A_HP.Font = New Font(BtnMedics_A_HP.Font, FontStyle.Bold)
                    BtnMedics_A_HP.Image = My.Resources.AdminWhite
                    Fix = i
                    Identify = 1
                    ReloadDgv()
                End If
            Case 1 'Para los pacientes
                If Not Identify = 2 Then
                    LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittlePatient_A_P")
                    LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoPatient_A_P")
                    BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddPatient_A_P")
                    BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelPatient_A_P")
                    BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModPatient_A_P")
                    BtnAddAdmin_A_A.Size = New System.Drawing.Size(138, 20)
                    BtnAddAdmin_A_A.Location = New Point(701, 214)
                    BtnDelAdmin_A_A.Size = New System.Drawing.Size(154, 20)
                    BtnDelAdmin_A_A.Location = New Point(541, 214)
                    BtnModAdmin_A_A.Size = New System.Drawing.Size(163, 20)
                    BtnModAdmin_A_A.Location = New Point(372, 214)
                    PicBar.Location = New Point(159, 58)
                    If Identify = 3 Or Identify = 0 Then
                        BtnAdmins_A_HP.BaseColor = Color.White
                        BtnAdmins_A_HP.ForeColor = Color.Black
                        BtnAdmins_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnAdmins_A_HP.Image = My.Resources.GreenPerson
                    ElseIf Identify = 1 Then
                        BtnMedics_A_HP.BaseColor = Color.White
                        BtnMedics_A_HP.ForeColor = Color.Black
                        BtnMedics_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnMedics_A_HP.Image = My.Resources.GreenPerson
                    End If
                    BtnPatients_A_HP.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnPatients_A_HP.ForeColor = Color.White
                    BtnPatients_A_HP.Font = New Font(BtnMedics_A_HP.Font, FontStyle.Bold)
                    BtnPatients_A_HP.Image = My.Resources.AdminWhite
                    BtnAllow_A_P.BackColor = Color.FromArgb(240, 240, 240)
                    BtnAllow_A_P.Visible = True
                    Fix = i
                    Identify = 2
                    ReloadDgv()
                    ObtainSelected()
                End If
            Case 2 'Para los Administradores
                If Not Identify = 3 Then
                    LblTittleAdmin_A_A.Text = Translator.Instance.Translate("LblTittleAdmin_A_A")
                    LblListadoAdmin_A_A.Text = Translator.Instance.Translate("LblListadoAdmin_A_A")
                    BtnAddAdmin_A_A.Text = Translator.Instance.Translate("BtnAddAdmin_A_A")
                    BtnDelAdmin_A_A.Text = Translator.Instance.Translate("BtnDelAdmin_A_A")
                    BtnModAdmin_A_A.Text = Translator.Instance.Translate("BtnModAdmin_A_A")
                    BtnAddAdmin_A_A.Size = New System.Drawing.Size(124, 20)
                    BtnAddAdmin_A_A.Location = New Point(718, 214)
                    BtnDelAdmin_A_A.Size = New System.Drawing.Size(138, 20)
                    BtnDelAdmin_A_A.Location = New Point(574, 214)
                    BtnModAdmin_A_A.Size = New System.Drawing.Size(148, 20)
                    BtnModAdmin_A_A.Location = New Point(420, 214)
                    PicBar.Location = New Point(159, 130)
                    BtnAdmins_A_HP.BaseColor = Color.FromArgb(98, 186, 172)
                    BtnAdmins_A_HP.ForeColor = Color.White
                    BtnAdmins_A_HP.Font = New Font(BtnMedics_A_HP.Font, FontStyle.Bold)
                    BtnAdmins_A_HP.Image = My.Resources.AdminWhite
                    If Identify = 1 Then
                        BtnMedics_A_HP.BaseColor = Color.White
                        BtnMedics_A_HP.ForeColor = Color.Black
                        BtnMedics_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnMedics_A_HP.Image = My.Resources.GreenPerson
                    ElseIf Identify = 2 Then
                        BtnPatients_A_HP.BaseColor = Color.White
                        BtnPatients_A_HP.ForeColor = Color.Black
                        BtnPatients_A_HP.Font = New Font(BtnAdmins_A_HP.Font, FontStyle.Regular)
                        BtnPatients_A_HP.Image = My.Resources.GreenPerson
                        BtnAllow_A_P.Visible = False
                    End If
                    Fix = i
                    Identify = 3
                    ReloadDgv()
                End If
        End Select


    End Sub

    Private Sub BtnMed_Click_1(sender As Object, e As EventArgs) Handles BtnMedics_A_HP.Click
        IdentifyPeople(0)
    End Sub

    Private Sub BtnPac_Click(sender As Object, e As EventArgs) Handles BtnPatients_A_HP.Click
        IdentifyPeople(1)
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmins_A_HP.Click
        IdentifyPeople(2)
    End Sub

    Private Sub BtnAllow_Click(sender As Object, e As EventArgs) Handles BtnAllow_A_P.Click
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