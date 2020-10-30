Imports Data
Imports Logic
Public Class FrmHome
    Dim time As Integer = 0
    Public Shared MedicName = "", Ci = "", Age = "", Email = "", Phone = "", Connect = ""
    Dim PatientName As String = ""
    Dim log As New Logic.Controller
    Dim Medic As New Medic()
    Dim idRoom As Integer = 0
    Dim chat As String = Nothing
    Dim row As DataGridViewRow
    Dim PatientSelected As People
    Dim TentativeDiagnostic As Diagnostic

    'Métodos relacionados a la Sala de chat
    Private Sub JoinRoom()
        Try
            'Creo una sala para que conversen
            Controller.Instance.SetRoom(log.CreateRoom())
            idRoom = Controller.Instance.ObtainRoom()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LeaveRoom()
        VerifyDiagnostic()
        log.LeaveRoom(idRoom, GetNowDateTime(1))
        ChangePanels(0)
        TimerChat.Stop()
    End Sub
    Private Function CheckStateRoom() As Integer
        Try
            log.CheckStateRoom(idRoom)
            Return 0
        Catch ex As Exception
            Return 1
        End Try
    End Function

    'Metodos relacionados al diagnóstico
    Private Sub VerifyDiagnostic()
        Try
            log.VerifyDiagnostic(Medic.id, TentativeDiagnostic.Id)
        Catch ex As Exception

        End Try
    End Sub

    'Metodos relacionados a la peticion
    Private Sub DgvRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRequests.CellContentClick 'Aceptar Peticion
        row = DgvRequests.CurrentRow
        If e.ColumnIndex = 0 Then 'Boton aceptar
            PatientName = CStr(row.Cells("Nombre").Value)
            Try
                PatientSelected = ObtainPatientAccepted()
                Dim dateI As Date = CDate(row.Cells("Fecha").Value)
                Dim timeI As TimeSpan = row.Cells("Hora").Value
                Dim dateTimeRequestI As String = dateI.ToString("yyy-MM-dd") + " " + CDate(timeI.ToString()).ToString("HH:mm:ss")
                Dim dateTimeRequestF As String = Me.GetNowDateTime(1)

                log.AcceptRequest(Medic.id, PatientSelected.id, dateTimeRequestI, dateTimeRequestF)
                ChangePanels(2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Botones
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        ChangePanels(1)
    End Sub

    Private Sub BtnRequest_Click(sender As Object, e As EventArgs) Handles BtnRequest.Click
        ChangePanels(0)
    End Sub
    Private Sub BtnMore_Click(sender As Object, e As EventArgs) Handles BtnMore.Click
        If PnlMoreInfo.Visible = True Then
            PnlMoreInfo.Visible = False
        ElseIf PnlMoreInfo.Visible = False And PnlViewPatientInfo.Visible = False Then
            PnlMoreInfo.Visible = True
        End If
    End Sub

    Private Sub BtnEndChat_Click(sender As Object, e As EventArgs) Handles BtnEndChat.Click
        If MsgBox("Está seguro que desea finalizar el chat ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            LeaveRoom()
        End If
    End Sub

    Private Sub BtnPatientInfo_Click(sender As Object, e As EventArgs) Handles BtnPatientInfo.Click
        PnlMoreInfo.Visible = False
        PnlViewPatientInfo.Visible = True
    End Sub
    Private Sub BtnInfoClose_Click(sender As Object, e As EventArgs) Handles BtnInfoClose.Click
        PnlViewPatientInfo.Visible = False
        PnlChat.Enabled = True
    End Sub
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If Not TxtChatSend.Text.Trim.Length = 0 Then
            Try

                log.SendMessage(Medic.id, idRoom, TxtChatSend.Text, DateTime.Now.ToString("HH:mm:ss"))
                ObtainMsg()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            TxtChatSend.Clear()
            TxtChatSend.Focus()
        End If
    End Sub
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    'Metodos relacionados al Chat
    Private Sub LoadPatientInfo()
        Dim Name2 As String = PatientSelected.scndName
        If Name2 = "" Then
            LblInfoPatientName.Location = New Point(142, 247)
            LblInfoPatientName.Text = PatientSelected.fstName + " " + PatientSelected.scndName
        Else
            LblInfoPatientName.Location = New Point(123, 247)
            LblInfoPatientName.Text = PatientSelected.fstName + " " + PatientSelected.scndName
        End If
        LblInfoPatientSurn.Text = PatientSelected.fstSurname + " " + PatientSelected.scndSurname
            LblInfoPatientAge.Text = PatientSelected.CalcAge(PatientSelected.dateBirth).ToString() + " Años"
        Try
            DgvInfoPatientSympts.Columns.Add("Sympt", "")
            Dim DateNow As String = GetNowDateTime(2)
            For Each Sympt As Symptom In log.ObtainSymptomsSuffered(PatientSelected.id, DateNow)
                DgvInfoPatientSympts.Rows.Add(Sympt.Description)
            Next
            DgvInfoPatientPaths.Columns.Add("Paths", "")
            DgvInfoPatientPaths.Columns.Add("Priority", "")
            DgvInfoPatientPaths.Rows(0).Cells(0).Value = TentativeDiagnostic.Pathology.name
            DgvInfoPatientPaths.Rows(0).Cells(1).Value = TentativeDiagnostic.Pathology.priority.name
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ObtainMsg()
        chat = Nothing
        Try
            For Each msg As Message In log.ObtainMessages(Medic.id, idRoom)
                If chat = Nothing And msg.idP = Medic.id Then
                    chat = "Tú: " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                ElseIf chat = Nothing And msg.idP <> Medic.id Then
                    chat = PatientName + ": " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                ElseIf msg.idP = Medic.id Then
                    chat = chat + vbCrLf + "Tú: " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                Else
                    chat = chat + vbCrLf + PatientName + ": " + msg.message + vbTab + msg.hour.Hour.ToString() + ":" + msg.hour.Minute.ToString()
                End If
            Next
            TxtChat.Text = chat
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub TxtChatSend_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChatSend.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSend.PerformClick()
        End If
    End Sub

    'Metodos de carga de controles
    Public Sub ReloadDgv()
        Try
            DgvRequests.DataSource = log.ObtainRequestsDataSet().Tables("Refresh")
            DgvRequests.Refresh()
            If TimerRequests.Enabled = False And Not DgvRequests.Columns.Count > 5 Then
                Dim btn As New DataGridViewButtonColumn()
                DgvRequests.Columns.Add(btn)
                btn.HeaderText = "Aceptar"
                btn.Text = "Aceptar"
                btn.Name = "btn"
                btn.UseColumnTextForButtonValue = True
                TimerRequests.Start()
            End If
            For Each row As DataGridViewRow In DgvRequests.Rows
                If Not IsNothing(row.Cells(1).Value) Then
                    If row.Cells(1).Value.ToString() = "Prioridad Alta" Then
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 135, 124)
                    ElseIf row.Cells(1).Value.ToString() = "Prioridad Media" Then
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(232, 235, 90)
                    ElseIf row.Cells(1).Value.ToString() = "Prioridad Baja" Then
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(98, 186, 172)
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Medic = FrmLogin.MedicLogged
        LblName.Text = MedicName
        LblCi.Text = Ci
        LblAge.Text = Age
        LblEmail.Text = Email
        LblPhone.Text = Phone
        LblConnect.Text = Connect
    End Sub

    'Timers
    Private Sub TimerRequests_Tick(sender As Object, e As EventArgs) Handles TimerRequests.Tick
        time = time + 1
        If time > 4 Then
            ReloadDgv()
            time = 0
        End If
    End Sub
    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        time = time + 1
        If time > 4 Then
            Try
                If CheckStateRoom() = 0 Then
                    ObtainMsg()
                    time = 0
                Else
                    TimerChat.Stop()
                    MessageBox.Show("El chat ha finalizado!")
                    ChangePanels(0)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Metodos relacionados con los paneles
    Public Sub ChangePanels(i As Integer)
        Select Case i
            Case 0 'Peticiones
                PanelHome.Visible = False
                PnlChat.Visible = False
                PnlRequest.Visible = True
                PicBar.Location = New Point(160, 58)
                BtnHome.FillColor = Color.White
                BtnHome.ForeColor = Color.Black
                BtnHome.Font = New Font(BtnHome.Font, FontStyle.Regular)
                BtnHome.Image = My.Resources.mdi_home

                BtnRequest.FillColor = Color.FromArgb(98, 186, 172)
                BtnRequest.ForeColor = Color.White
                BtnRequest.Font = New Font(BtnRequest.Font, FontStyle.Bold)
                BtnRequest.Image = My.Resources.AdminWhite
                ReloadDgv()
            Case 1 'Inicio
                TimerRequests.Stop()
                PnlRequest.Visible = False
                PnlChat.Visible = False
                PanelHome.Visible = True
                PicBar.Location = New Point(160, 22)
                BtnRequest.FillColor = Color.White
                BtnRequest.ForeColor = Color.Black
                BtnRequest.Font = New Font(BtnHome.Font, FontStyle.Regular)
                BtnRequest.Image = My.Resources.GreenPerson

                BtnHome.FillColor = Color.FromArgb(98, 186, 172)
                BtnHome.ForeColor = Color.White
                BtnHome.Font = New Font(BtnRequest.Font, FontStyle.Bold)
                BtnHome.Image = My.Resources.mdi_home_white
            Case 2 'Chat
                TimerRequests.Stop()
                JoinRoom()
                TentativeDiagnostic = log.ObtainTentativeDiagnostic(PatientSelected, GetNowDateTime(2))
                LoadPatientInfo()
                PnlRequest.Visible = False
                PnlChat.Visible = True
                LblPatient.Text = PatientName
                TxtChatSend.Focus()
                TimerChat.Start()
        End Select
    End Sub

    'Otros métodos
    Private Function ObtainPatientAccepted() As People
        Dim Patient As New People()
        Dim NameComplete As String = CStr(row.Cells("Nombre").Value)

        For Each Patients As People In log.ObtainPatients()
            Dim NameComplete2 As String = ""
            If Patients.scndName = "" Then
                NameComplete2 = Patients.fstName + " " + Patients.fstSurname + " " + Patients.scndSurname
            Else
                NameComplete2 = Patients.fstName + " " + Patients.scndName + " " + Patients.fstSurname + " " + Patients.scndSurname
            End If
            If NameComplete.Equals(NameComplete2) Then
                Patient = Patients
            End If
        Next

        Return Patient
    End Function
    Private Function GetNowDateTime(prefix As Short) As String
        Return log.GetNowDateTime(prefix)
    End Function

End Class