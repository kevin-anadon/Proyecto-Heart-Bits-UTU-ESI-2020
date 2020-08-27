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

    Public Sub UpdateSympt(sympt As String, region As String, symptbefore As String)
        Dim con As Connection = connect()

        Dim rsSelectIdReg As Recordset = con.Execute("SELECT id FROM region WHERE nombre='" + region + "';")
        Dim idregion As Integer = DirectCast(rsSelectIdReg.Fields("id").Value, Integer)
        Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + symptbefore + "';")
        Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
        Dim rsIinsert As Recordset = con.Execute("UPDATE sintoma SET descripcion='" & sympt & "', id_region=" & idregion & " WHERE id=" & idsympt & ";")
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

    Public Function CheckPin(pin As String) As Boolean
        Dim con As Connection = connect()
        Dim check As Boolean = False
        Dim rs As Recordset
        rs = con.Execute("SELECT ci FROM persona WHERE id_tipo=1 and pin='" + pin + "';")
        If rs.EOF Then
            con.Close()
            Return check
        Else
            check = True
            con.Close()
            Return check
        End If
    End Function

    Public Function ObtainRegions() As List(Of Region)
        Dim con As Connection = connect()
        Dim regions As New List(Of Region)

        Dim rs As Recordset = con.Execute("SELECT id, nombre FROM region ORDER BY id;")

        While (Not rs.EOF)
            Dim id As String = DirectCast(rs.Fields("id").Value, Integer)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            regions.Add(New Region(id, name))
            rs.MoveNext()
        End While
        con.Close()
        Return regions
    End Function

    Public Function ObtainPriorities() As List(Of Priority)
        Dim con As Connection = connect()
        Dim priorities As New List(Of Priority)

        Dim rs As Recordset = con.Execute("SELECT id, nombre FROM prioridad ORDER BY id;")

        While (Not rs.EOF)
            Dim id As String = DirectCast(rs.Fields("id").Value, Integer)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            priorities.Add(New Priority(id, name))
            rs.MoveNext()
        End While
        con.Close()
        Return priorities
    End Function

    Public Function ObtainListSympt() As List(Of String)
        Dim result As New List(Of String)
        Dim con As Connection = connect()

        Dim rs As Recordset = con.Execute("SELECT nombre FROM patologia ORDER BY nombre;")

        While (Not rs.EOF)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            result.Add(name)
            rs.MoveNext()
        End While
        con.Close()
        Return result
    End Function

    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = connect()
        If nameTable = "sintoma" Then
            Return con.Execute("SELECT s.descripcion As Síntoma,r.nombre As Región FROM sintoma s LEFT JOIN region r ON(s.id_region=r.id) ORDER BY s.descripcion, r.nombre;")

        ElseIf nameTable = "region" Then
            Return con.Execute("SELECT nombre FROM region ORDER BY nombre;")

        ElseIf nameTable = "patologia" Then
            Return con.Execute("SELECT nombre FROM patologia ORDER BY nombre;")

        Else
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
