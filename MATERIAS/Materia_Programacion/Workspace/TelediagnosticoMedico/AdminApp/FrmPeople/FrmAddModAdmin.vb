Imports Data
Imports Logic
Public Class FrmAddModAdmin
    Dim log As New Logic.Logic()

    Dim BtnM As Boolean = False
    Dim BtnW As Boolean = False
    Dim Cities As New List(Of City)
    Public Shared Add As Boolean = False
    Public Shared Admin As Admin = Nothing

    Public Sub ReloadCmb(i As Integer)
        Cities = log.ObtainCities()
        For Each city As City In Cities
            CmbCities.Items.Add(city.Name)
        Next
        If i = 0 Then
            For x = 0 To CmbCities.Items.Count - 1
                If CmbCities.Items(x).ToString().Equals(Admin.city.Name) Then
                    CmbCities.SelectedIndex = x
                End If
            Next
        End If
    End Sub

    Public Sub ReloadData()
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
        TxtCi.ReadOnly = True
    End Sub

    Private Sub FrmAddModAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Add = True Then
            ReloadCmb(1)
        Else
            ReloadCmb(0)
            ReloadData()
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CheckEmpty() = True Then
            MessageBox.Show("Campos vacios!")
        Else
            If CheckPass() = True Then
                Dim Genre As Integer = ObtainGenre()
                Dim DateBirth As Date = ObtainDate()
                Dim City As City = Nothing
                For Each cit As City In Cities
                    If CmbCities.SelectedItem.ToString().Equals(cit.Name) Then
                        City = cit
                    End If
                Next

                Try
                    If Add = True Then
                        log.AddAdmin(New Admin(-1, CInt(TxtCi.Text), TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtStreet.Text, CInt(TxtDoor.Text), City, TxtUser.Text, TxtPass.Text, TxtPin.Text))
                        MessageBox.Show("Agregado con exito")
                        Me.Close()
                    Else
                        log.UpdateAdmin(New Admin(Admin.id, CInt(TxtCi.Text), TxtFstName.Text, TxtScndName.Text, TxtFstSurn.Text, TxtScndSurn.Text, Genre, DateBirth, TxtEmail.Text, TxtPhone.Text, TxtStreet.Text, CInt(TxtDoor.Text), City, TxtUser.Text, TxtPass.Text, TxtPin.Text))
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
        Dim x As String = Format(BirthDate.Value, "yyy/MM/dd")
        Dim DateD As Date = CDate(x)
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

        If TxtPass.Text.Equals(TxtPassRepeat.Text) Then
            Check = True
        End If

        Return Check
    End Function

    Public Function CheckEmpty() As Boolean
        Dim Check As Boolean = False

        If TxtFstName.Text.Trim.Length = 0 Or TxtFstSurn.Text.Trim.Length = 0 Or TxtScndSurn.Text.Trim.Length = 0 Or TxtCi.Text.Trim.Length = 0 Or TxtEmail.Text.Trim.Length = 0 Or TxtPin.Text.Trim.Length = 0 Or TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Or TxtPassRepeat.Text.Trim.Length = 0 Or TxtStreet.Text.Trim.Length = 0 Or TxtDoor.Text = 0 Or TxtPhone.Text.Trim.Length = 0 Then
            Check = True
        End If

        Return Check
    End Function
    Private Sub TxtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPin.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDoor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDoor.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class