Imports Data
Imports Logic
Public Class FrmHome
    Dim time As Integer = 0
    Public Shared MedicName = "", Ci = "", Age = "", Email = "", Phone = "", Connect = ""
    Dim PatientName As String = ""
    Dim log As New Logic.Logic
    Dim Medic As New Medic()
    Dim idRoom As Integer = 0
    Dim chat As String = Nothing
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        ChangePanels(1)
    End Sub

    Private Sub BtnRequest_Click(sender As Object, e As EventArgs) Handles BtnRequest.Click
        ChangePanels(0)
    End Sub
    Public Sub JoinRoom()
        Try
            'Creo una sala para que conversen
            idRoom = log.CreateRoom()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

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
                JoinRoom()
                PnlRequest.Visible = False
                PnlChat.Visible = True
                LblPatient.Text = PatientName
                TxtChatSend.Focus()
                TimerChat.Start()
        End Select
    End Sub

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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles TimerRequests.Tick
        time = time + 1
        If time > 4 Then
            ReloadDgv()
            time = 0
        End If
    End Sub

    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        time = time + 1
        If time > 4 Then
            ObtainMsg()
            time = 0
        End If
    End Sub

    Private Sub DgvRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRequests.CellContentClick
        Dim row As DataGridViewRow
        row = DgvRequests.CurrentRow
        If e.ColumnIndex = 0 Then
            PatientName = CStr(row.Cells("Nombre").Value)
            ChangePanels(2)
        End If
    End Sub
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Try
            log.SendMessage(Medic.id, idRoom, TxtChatSend.Text, DateTime.Now.ToString("HH:mm:ss"))
            ObtainMsg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TxtChatSend.Clear()
        TxtChatSend.Focus()
    End Sub

    Public Sub ObtainMsg()
        chat = Nothing
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
    End Sub

    Private Sub TxtChatSend_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChatSend.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSend.PerformClick()
        End If
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Medic = FrmLogin.MedicLog
        LblName.Text = MedicName
        LblCi.Text = Ci
        LblAge.Text = Age
        LblEmail.Text = Email
        LblPhone.Text = Phone
        LblConnect.Text = Connect
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class