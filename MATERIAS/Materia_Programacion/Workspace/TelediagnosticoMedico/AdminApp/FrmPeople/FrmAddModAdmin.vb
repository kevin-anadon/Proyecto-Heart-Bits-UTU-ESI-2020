Imports Data
Imports Logic
Public Class FrmAddModAdmin
    Dim log As New Logic.Controller()

    Dim BtnM As Boolean = False
    Dim BtnW As Boolean = False
    Dim Cities As New List(Of City)
    Public Shared Identify As Integer = 0
    Public Shared Add As Boolean = False
    Public Shared Admin As Admin = Nothing
    Public Shared Medic As Medic = Nothing
    Public Shared Patient As People = Nothing

    Private Sub TranslatePatient()
        LblPN1.Text = Translator.Instance.Translate("nom1P")
        LblPN2.Text = Translator.Instance.Translate("nom2P")
        LblPS1.Text = Translator.Instance.Translate("surn1P")
        LblPS2.Text = Translator.Instance.Translate("surn2P")
        LblPCI.Text = Translator.Instance.Translate("ciP")
        LblPDate.Text = Translator.Instance.Translate("DateP")
        LblStreet.Text = Translator.Instance.Translate("streetP")
        LblDoor.Text = Translator.Instance.Translate("doorP")
        LblPCity.Text = Translator.Instance.Translate("cityP")
        LblPTel.Text = Translator.Instance.Translate("telP")
        BtnAdd.Text = Translator.Instance.Translate("Mod")
    End Sub

    Private Sub FrmAddModAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Add = True Then
            If Identify = 2 Then
                TranslatePatient()
            End If
            ReloadCmb(1)
            Else
                ReloadCmb(0)
            ReloadData()
        End If
        LoadData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click, BtnPatAdd.Click
        If CheckEmpty() = True Then
            MessageBox.Show("Campos vacios!")
        Else
            If CheckPass() = True Then
                Dim Genre As Integer = ObtainGenre()
                Dim DateBirth As Date = ObtainDate()
                Dim City As City = Nothing
                If Not Identify = 2 Then
                    For Each cit As City In Cities
                        If CmbCities.SelectedItem.ToString().Equals(cit.Name) Then
                            City = cit
                        End If
                    Next
                Else
                    For Each cit As City In Cities
                        If CmbPatCity.SelectedItem.ToString().Equals(cit.Name) Then
                            City = cit
                        End If
                    Next
                End If

                Try
                    If Add = True Then
                        If Identify = 1 Then
                            log.AddMedic(New Medic(-1, CInt(TxtCi.Text), TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtPassRepeat.Text, CInt(TxtStreet.Text), City, TxtPin.Text, TxtUser.Text, CmbSpecialities.SelectedItem.ToString()))
                        ElseIf Identify = 2 Then
                            log.AddPatient(New People(-1, CInt(TxtPatCi.Text), TxtPatFstName.Text, TxtPatScndName.Text, TxtPatFstSurn.Text, TxtPatScndSurn.Text, Genre, DateBirth, TxtPatEmail.Text, TxtPatPhone.Text, TxtPatStreet.Text, CInt(TxtPatDoor.Text), City))
                        ElseIf Identify = 3 Then
                            log.AddAdmin(New Admin(-1, CInt(TxtCi.Text), TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtStreet.Text, CInt(TxtDoor.Text), City, TxtUser.Text, TxtPass.Text, TxtPin.Text))
                        End If
                        MessageBox.Show("Agregado con exito")
                        Add = False
                        Me.Close()
                    Else
                        If Identify = 1 Then
                                log.UpdateMedic(New Medic(Medic.id, Medic.ci, TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtPassRepeat.Text, CInt(TxtStreet.Text), City, TxtPin.Text, TxtUser.Text, CmbSpecialities.SelectedItem.ToString()))
                            ElseIf Identify = 2 Then
                            log.UpdatePatient(New People(Patient.id, Patient.ci, TxtPatFstName.Text, TxtPatScndName.Text, TxtPatFstSurn.Text, TxtPatScndSurn.Text, Genre, DateBirth, TxtPatEmail.Text, TxtPatPhone.Text, TxtPatStreet.Text, CInt(TxtPatDoor.Text), City))
                        ElseIf Identify = 3 Then
                                log.UpdateAdmin(New Admin(Admin.id, CInt(TxtCi.Text), TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtStreet.Text, CInt(TxtDoor.Text), City, TxtUser.Text, TxtPass.Text, TxtPin.Text))
                            End If
                            MessageBox.Show("Modificado con exito")
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MessageBox.Show("La contraseña no coincide")
            End If
        End If
    End Sub

    Private Sub BtnMen_Click(sender As Object, e As EventArgs) Handles BtnMen.Click 'En caso de que el usuario eliga Sexo Hombre
        BtnWomen.BackColor = Color.FromArgb(98, 186, 172) 'Verde
        BtnMen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
        BtnM = True
        BtnW = False
    End Sub

    Private Sub BtnWomen_Click(sender As Object, e As EventArgs) Handles BtnWomen.Click 'En caso de que el usuario eliga Sexo Mujer
        BtnMen.BackColor = Color.FromArgb(98, 186, 172) 'Verde
        BtnWomen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
        BtnW = True
        BtnM = False
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Public Function ObtainDate() As Date
        Dim DateD As Date = Nothing
        If Not Identify = 2 Then
            Dim x As String = Format(BirthDate.Value, "yyy/MM/dd")
            DateD = CDate(x)
        Else
            Dim x As String = Format(DatetimePatPicker.Value, "yyy/MM/dd")
            DateD = CDate(x)
        End If
        Return DateD
    End Function

    Public Function ObtainGenre() As Integer
        Dim genre As Integer = 0

        If BtnM = True Then
            genre = 0
        Else
            genre = 1
        End If

        Return genre
    End Function

    Public Function CheckPass() As Boolean
        Dim Check As Boolean = False
        If Identify = 1 Then
            If TxtUser.Text.Equals(TxtPass.Text) Then
                Check = True
            End If
        ElseIf Identify = 2 Then
            Check = True
        ElseIf Identify = 3 Then
            If TxtPass.Text.Equals(TxtPassRepeat.Text) Then
                Check = True
            End If
        End If

        Return Check
    End Function

    Public Function CheckEmpty() As Boolean
        Dim Check As Boolean = False
        If Identify = 1 Then 'Medico
            If TxtFstName.Text.Trim.Length = 0 Or TxtFstSurn.Text.Trim.Length = 0 Or TxtScndSurn.Text.Trim.Length = 0 Or TxtCi.Text.Trim.Length = 0 Or TxtEmail.Text.Trim.Length = 0 Or TxtPin.Text.Trim.Length = 0 Or TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Or TxtPassRepeat.Text.Trim.Length = 0 Or TxtStreet.Text.Trim.Length = 0 Or TxtPhone.Text.Trim.Length = 0 Then
                Check = True
            End If
        ElseIf Identify = 2 Then 'Paciente
            If TxtPatFstName.Text.Trim.Length = 0 Or TxtPatFstSurn.Text.Trim.Length = 0 Or TxtPatScndSurn.Text.Trim.Length = 0 Or TxtPatCi.Text.Trim.Length = 0 Or TxtPatEmail.Text.Trim.Length = 0 Or TxtPatStreet.Text.Trim.Length = 0 Or TxtPatDoor.Text.Trim.Length = 0 Or TxtPatPhone.Text.Trim.Length = 0 Then
                Check = True
            End If
        ElseIf Identify = 3 Then
            If TxtFstName.Text.Trim.Length = 0 Or TxtFstSurn.Text.Trim.Length = 0 Or TxtScndSurn.Text.Trim.Length = 0 Or TxtCi.Text.Trim.Length = 0 Or TxtEmail.Text.Trim.Length = 0 Or TxtPin.Text.Trim.Length = 0 Or TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Or TxtPassRepeat.Text.Trim.Length = 0 Or TxtStreet.Text.Trim.Length = 0 Or TxtDoor.Text.Trim.Length = 0 Or TxtPhone.Text.Trim.Length = 0 Then
                Check = True
            End If
        End If

        Return Check
    End Function

    Public Sub LoadData()
        If Identify = 1 Then 'Médicos
            LblStarDoor.Location = New Point(835, 10)
            LblStarPass.Location = New Point(647, 75)
            LblPin.Text = "Usuario"
            TxtUser.PasswordChar = "*"
            TxtPin.PasswordChar = ""
            TxtPassRepeat.PasswordChar = ""
            LblUser.Text = "Contraseña"
            LblPass.Text = "Repetir contraseña"
            LblPass2.Text = "Calle"
            LblStreet.Text = "Puerta"
            LblDoor.Text = "Especialidad"
        ElseIf Identify = 2 Then 'Pacientes
            PnlBodyAdminMed.Visible = False
            PanelTop.Visible = False
            Me.Size = New Point(706, 351)
            Me.StartPosition = FormStartPosition.CenterScreen
            PnlPatient.Visible = True
            PnlPatTop.Visible = True
        ElseIf Identify = 3 Then 'Administradores

        End If
    End Sub

    Public Sub ReloadCmb(i As Integer)
        Cities = log.ObtainCities()
        For Each city As City In Cities
            CmbCities.Items.Add(city.Name)
        Next
        If Identify = 1 Then
            CmbSpecialities.Visible = True
            For Each Speciality As String In log.ObtainSpecialities()
                CmbSpecialities.Items.Add(Speciality)
            Next
        ElseIf Identify = 2 Then
            For Each city As City In Cities
                CmbPatCity.Items.Add(city.Name)
            Next
        End If
        If i = 0 Then
            If Identify = 1 Then 'Medicos
                For x = 0 To CmbCities.Items.Count - 1
                    If CmbCities.Items(x).ToString().Equals(Medic.city.Name) Then
                        CmbCities.SelectedIndex = x
                    End If
                Next
                For x = 0 To CmbSpecialities.Items.Count - 1
                    If CmbSpecialities.Items(x).ToString().Equals(Medic.speciality) Then
                        CmbSpecialities.SelectedIndex = x
                    End If
                Next
            ElseIf Identify = 2 Then 'Pacientes
                For x = 0 To CmbPatCity.Items.Count - 1
                    If CmbPatCity.Items(x).ToString().Equals(Patient.city.Name) Then
                        CmbPatCity.SelectedIndex = x
                    End If
                Next
            ElseIf Identify = 3 Then 'Administrador
                For x = 0 To CmbCities.Items.Count - 1
                    If CmbCities.Items(x).ToString().Equals(Admin.city.Name) Then
                        CmbCities.SelectedIndex = x
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub ReloadData()
        If Identify = 1 Then 'Medico
            TxtFstName.Text = Medic.fstName
            TxtScndName.Text = Medic.scndName
            TxtFstSurn.Text = Medic.fstSurname
            TxtScndSurn.Text = Medic.scndSurname
            TxtCi.Text = Medic.ci.ToString()
            BirthDate.Value = Medic.dateBirth
            TxtEmail.Text = Medic.email
            TxtPin.Text = Medic.username
            TxtUser.Text = Medic.password
            TxtPass.Text = Medic.password
            TxtPassRepeat.Text = Medic.street
            TxtStreet.Text = Medic.numDoor.ToString()
            TxtPhone.Text = Medic.numPhone
            If Medic.genrePeople = 0 Then
                BtnMen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
            Else
                BtnWomen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
            End If
        ElseIf Identify = 2 Then 'Paciente
            TxtPatCi.ReadOnly = True
            TxtPatFstName.Text = Patient.fstName
            TxtPatScndName.Text = Patient.scndName
            TxtPatFstSurn.Text = Patient.fstSurname
            TxtPatScndSurn.Text = Patient.scndSurname
            TxtPatCi.Text = Patient.ci.ToString()
            DatetimePatPicker.Value = Patient.dateBirth
            TxtPatEmail.Text = Patient.email
            TxtPatStreet.Text = Patient.street
            TxtPatDoor.Text = Patient.numDoor.ToString()
            TxtPatPhone.Text = Patient.numPhone
            If Patient.genrePeople = 0 Then
                BtnPatMen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
                BtnM = True
            Else
                BtnPatWomen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
                BtnW = True
            End If
        ElseIf Identify = 3 Then 'Administrador
            TxtFstName.Text = Admin.fstName
            TxtScndName.Text = Admin.scndName
            TxtFstSurn.Text = Admin.fstSurname
            TxtScndSurn.Text = Admin.scndSurname
            TxtCi.Text = Admin.ci.ToString()
            BirthDate.Value = Admin.dateBirth
            TxtEmail.Text = Admin.email
            TxtPin.Text = Admin.pin.ToString()
            TxtUser.Text = Admin.username
            TxtPass.Text = Admin.password
            TxtPassRepeat.Text = Admin.password
            TxtStreet.Text = Admin.street
            TxtDoor.Text = Admin.numDoor.ToString()
            TxtPhone.Text = Admin.numPhone
            If Admin.genrePeople = 0 Then
                BtnMen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
            Else
                BtnWomen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
            End If
        End If

        TxtCi.ReadOnly = True
    End Sub
    Private Sub TxtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPin.KeyPress
        If Identify = 1 Then

        Else
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtDoor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDoor.KeyPress, TxtPatDoor.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress, TxtPatPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtFstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtScndSurn.KeyPress, TxtScndName.KeyPress, TxtFstSurn.KeyPress, TxtFstName.KeyPress, TxtPatFstName.KeyPress, TxtPatScndName.KeyPress, TxtPatFstSurn.KeyPress, TxtPatScndSurn.KeyPress
        If Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnClosePat_Click(sender As Object, e As EventArgs) Handles BtnClosePat.Click
        Me.Close()
    End Sub

    Private Sub BtnPatMen_Click(sender As Object, e As EventArgs) Handles BtnPatMen.Click
        BtnPatWomen.BackColor = Color.FromArgb(98, 186, 172) 'Verde
        BtnPatMen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
        BtnM = True
        BtnW = False
    End Sub

    Private Sub BtnPatWomen_Click(sender As Object, e As EventArgs) Handles BtnPatWomen.Click
        BtnPatMen.BackColor = Color.FromArgb(98, 186, 172) 'Verde
        BtnPatWomen.BackColor = Color.FromArgb(246, 135, 124) 'Rojo
        BtnW = True
        BtnM = False
    End Sub

    Private Sub TxtPatCi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPatCi.KeyPress, TxtCi.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStreet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStreet.KeyPress
        If Identify = 1 Then
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
            End If
        End If
    End Sub
End Class