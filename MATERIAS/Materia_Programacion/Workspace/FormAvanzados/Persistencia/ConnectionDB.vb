Imports ADODB
Imports Data
Public Class ConnectionDB

    Private Function connect() As Connection
        Dim connection As New Connection()
        connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.0.0.1;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
        connection.Open()
        Return connection
    End Function

    Public Sub InsertSympt(sympt As String, region As String)
        Dim con As Connection = connect()

        If region = "NULL" Then
            Dim rsIinsert As Recordset = con.Execute("INSERT INTO sintoma(descripcion) VALUES('" & sympt & "');")
        Else
            Dim rsSelectIdReg As Recordset = con.Execute("SELECT id FROM region WHERE nombre='" + region + "';")
            Dim idreg As Integer = DirectCast(rsSelectIdReg.Fields("id").Value, Integer)
            Dim rsIinsert As Recordset = con.Execute("INSERT INTO sintoma(id_region,descripcion) VALUES(" & idreg & "," + "'" & sympt & "');")
        End If
        con.Close()
    End Sub

    Public Sub DelSympt(sympt As String)
        Dim con As Connection = connect()

        Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
        Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
        Dim rsDel As Recordset = con.Execute("DELETE FROM sintoma WHERE id=" & idsympt)
        Console.WriteLine(sympt + " Eliminado con exito!!")
        con.Close()
    End Sub

    Public Function CheckLog(user As String, pass As String) As Boolean
        Dim con As Connection = connect()
        Dim check As Boolean = False
        Dim rs As Recordset
        rs = con.Execute("SELECT ci FROM persona WHERE id_tipo=1 and usuario='" + user + "' and contrasena='" + pass + "';")
        If rs.EOF Then
            con.Close()
            Return check
        Else
            check = True
            con.Close()
            Return check
        End If
    End Function

    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = connect()
        If nameTable = "sintoma" Then

            Return con.Execute("SELECT s.descripcion As Síntoma,r.nombre As Región FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) ORDER BY s.descripcion, r.nombre;")
        ElseIf nameTable = "region" Then

            Return con.Execute("SELECT nombre FROM region ORDER BY nombre;")
        Else
            con.Close()
            Return Nothing
        End If
    End Function

    Public Function SearchSympt(nameDesc As String) As Recordset
        Dim con As Connection = connect()

        Return con.Execute("SELECT s.descripcion As Síntoma,r.nombre As Región FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) WHERE s.descripcion like '" & nameDesc & "%' ORDER BY s.descripcion, r.nombre;")
    End Function

    Public Function SearchRegion(nameRegion As String) As Recordset 'SIN UTILIZAR HASTA EL MOMENTO
        Dim conreg As Connection = connect()

        Return conreg.Execute("SELECT s.descripcion Síntoma,r.nombre Región FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) WHERE r.nombre ='" + nameRegion + "';")
    End Function
End Class
