Imports ADODB
Imports Data
Public Class ConnectionDB
    Private Function connect() As Connection
        Dim connection As New Connection()
        connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.0.0.1;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
        connection.Open()
        Return connection
    End Function

    Public Sub InsertPath(name As String, desc As String, indiceM As Integer, Prior As Integer, treatments As List(Of Treatment))
        Dim con As Connection = connect()
        Dim treatname As String = Nothing
        Dim treatdesc As String = Nothing
        Dim treatkind As String = Nothing

        Dim rsIinsert As Recordset = con.Execute("INSERT INTO patologia(id_prioridad,nombre,descripcion,indiceMortalidad) VALUES(" & Prior & "," + "'" & name & "','" & desc & "'," & indiceM & ");")
        'Inserta en la tabla patología
        Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
        Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)

        For Each i As Treatment In treatments
            treatname = i.name
            treatdesc = i.description
            treatkind = i.kind
            Dim rsInsertTr As Recordset = con.Execute("INSERT INTO tratamiento(id_patologia, nombre, descripcion, tipo) VALUES(" & idpat & "," + "'" & treatname & "'" + "," + "'" & treatdesc & "'" + "," + "'" & treatkind & "');")
        Next
        con.Close()
    End Sub

    Public Sub InsertSympt(sympt As String, region As String, Pat As List(Of String))
        Dim con As Connection = connect()

        If region = "NULL" Then
            Dim rsIinsert As Recordset = con.Execute("INSERT INTO sintoma(descripcion) VALUES('" & sympt & "');")
            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            For Each name As String In Pat
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")
            Next
        Else
            Dim rsSelectIdReg As Recordset = con.Execute("SELECT id FROM region WHERE nombre='" + region + "';")
            Dim idreg As Integer = DirectCast(rsSelectIdReg.Fields("id").Value, Integer)
            Dim rsIinsert As Recordset = con.Execute("INSERT INTO sintoma(id_region,descripcion) VALUES(" & idreg & "," + "'" & sympt & "');")
            'Inserta en la tabla sintoma
            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)

            For Each name As String In Pat
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")
            Next

        End If
        con.Close()
    End Sub

    Public Sub UpdatePath(patname As String, patdesc As String, patmortality As Integer, idprior As Integer, treatments As List(Of Treatment), patnamebefore As String)
        Dim con As Connection = connect()

        Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + patnamebefore + "';")
        Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
        Dim rsInsert As Recordset = con.Execute("UPDATE patologia SET id_prioridad=" & idprior & ", nombre='" & patname & "', descripcion='" & patdesc & "', indiceMortalidad='" & patmortality & "' WHERE id=" & idpat & ";")
        Dim rsDelTreat As Recordset = con.Execute("DELETE From tratamiento Where id_patologia =" & idpat & ";")


        For Each treat As Treatment In treatments
            Dim rsIinsertTreat As Recordset = con.Execute("INSERT INTO tratamiento(id_patologia, nombre, descripcion, tipo) VALUES(" & idpat & ",'" & treat.name & "','" & treat.description & "','" & treat.kind & "');")
        Next
        con.Close()
    End Sub


    Public Sub UpdateSympt(sympt As String, region As String, symptbefore As String, patafter As List(Of String))
        Dim con As Connection = connect()

        If sympt.Equals("NULL") And Not region.Equals("NULL") Then 'Si el usuario solo modifico la región

            Dim rsSelectIdReg As Recordset = con.Execute("SELECT id FROM region WHERE nombre='" + region + "';")
            Dim idregion As Integer = DirectCast(rsSelectIdReg.Fields("id").Value, Integer)
            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + symptbefore + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            Dim rsDelPats As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idsympt & ";")
            For Each name As String In patafter
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsInsert As Recordset = con.Execute("UPDATE sintoma SET id_region=" & idregion & " WHERE id=" & idsympt & ";")
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")
            Next

        ElseIf region.Equals("NULL") And Not sympt.Equals("NULL") Then 'Si el usuario solo modifico la descripción

            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + symptbefore + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            Dim rsDelPats As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idsympt & ";")
            For Each name As String In patafter
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsInsert As Recordset = con.Execute("UPDATE sintoma SET descripcion='" & sympt & "' WHERE id=" & idsympt & ";")
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")
            Next

        ElseIf sympt.Equals("NULL") And region.Equals("NULL") Then 'Si el usuario únicamente modificó patología

            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + symptbefore + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            Dim rsDelPats As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idsympt & ";")
            For Each name As String In patafter
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")

            Next

        Else 'Si el usuario modifico ambas
            Dim rsSelectIdReg As Recordset = con.Execute("SELECT id FROM region WHERE nombre='" + region + "';")
            Dim idregion As Integer = DirectCast(rsSelectIdReg.Fields("id").Value, Integer)
            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + symptbefore + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            Dim rsDelPats As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idsympt & ";")
            For Each name As String In patafter
                Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + name + "';")
                Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
                Dim rsInsert As Recordset = con.Execute("UPDATE sintoma SET descripcion='" & sympt & "', id_region=" & idregion & " WHERE id=" & idsympt & ";")
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & idpat & ");")
            Next
        End If

        con.Close()
    End Sub

    Public Sub DelPath(pat As String)
        Dim con As Connection = connect()

        Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + pat + "';")
        Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)

        Dim rsDelTratamiento As Recordset = con.Execute("DELETE FROM tratamiento WHERE id_patologia=" & idpat)
        Dim rsDelPat As Recordset = con.Execute("DELETE FROM patologia WHERE id=" & idpat)
        Console.WriteLine(pat + " Eliminado con exito, con sus tratamientos!!")
        con.Close()
    End Sub


    Public Sub DelSympt(sympt As String)
        Dim con As Connection = connect()

        Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
        Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)

        Dim rsDelSintomaCompone As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idsympt)
        Dim rsDel As Recordset = con.Execute("DELETE FROM sintoma WHERE id=" & idsympt)
        Console.WriteLine(sympt + " Eliminado con exito!!")
        con.Close()
    End Sub

    Public Function CheckLog(user As String, pass As String, ci As String) As Object
        Dim con As Connection = connect()
        Dim rs, rsMed As Recordset
        Dim empleado As Employee = Nothing
        Dim paciente As People = Nothing


        If ci = Nothing Then 'Es empleado
            rs = con.Execute("SELECT ci FROM persona WHERE id_tipo=1 and usuario='" + user + "' and contrasena='" + pass + "';")
            If rs.EOF Then 'Si no es administrador verifica si es medico
                rsMed = con.Execute("SELECT ci FROM persona WHERE id_tipo=2 and usuario='" + user + "' and contrasena='" + pass + "';")
                If rsMed.EOF Then 'Si tampoco es médico
                    con.Close()
                    Return empleado
                Else 'Si es médico
                    con.Close()
                    Return empleado
                End If
            Else 'En el caso que sea Administrador
                con.Close()
                Dim e As New Employee(user, pass)
                Return e
            End If
        Else 'Es Paciente
            rs = con.Execute("SELECT p.ci, p.id FROM persona p WHERE id_tipo=3 and ci='" + ci + "';")
            If rs.EOF Then
                con.Close()
                Return paciente
            Else
                Dim patient As New People(ci)
                con.Close()
                Return patient
            End If
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

    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Dim con As Connection = connect()
        Dim treatments As New List(Of Treatment)

        Dim rs As Recordset = con.Execute("SELECT t.nombre, t.descripcion, t.tipo FROM tratamiento t JOIN patologia p ON(t.id_patologia=p.id) WHERE p.nombre='" & pat & "' ORDER BY t.nombre;")

        While (Not rs.EOF)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            Dim desc As String = TryCast(rs.Fields("descripcion").Value, String)
            Dim kind As String = TryCast(rs.Fields("tipo").Value, String)

            treatments.Add(New Treatment(name, desc, kind))
            rs.MoveNext()
        End While
        con.Close()
        Return treatments
    End Function

    Public Function ObtainMortalityPath(pat As String) As Integer
        Dim con As Connection = connect()

        Dim rsSelectMortality As Recordset = con.Execute("SELECT indiceMortalidad FROM patologia WHERE nombre='" + pat + "';")
        Dim Mortality As Integer = DirectCast(rsSelectMortality.Fields("indiceMortalidad").Value, Integer)

        con.Close()
        Return Mortality
    End Function

    Public Function ObtainRegions() As List(Of Region)
        Dim con As Connection = connect()
        Dim regions As New List(Of Region)

        Dim rs As Recordset = con.Execute("SELECT id, nombre FROM region ORDER BY id;")

        While (Not rs.EOF)
            Dim id As Integer = DirectCast(rs.Fields("id").Value, Integer)
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
            Dim id As Integer = DirectCast(rs.Fields("id").Value, Integer)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            priorities.Add(New Priority(id, name))
            rs.MoveNext()
        End While
        con.Close()
        Return priorities
    End Function

    Public Function ListPath(sympt As String) As List(Of String)
        Dim Pathologies As New List(Of String)
        Dim con As Connection = connect()

        Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
        Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
        Dim rs As Recordset = con.Execute("SELECT p.nombre FROM patologia p JOIN sintoma_compone sc ON(p.id=sc.id_patologia) WHERE sc.id_sintoma=" & idsympt & ";")

        While (Not rs.EOF)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            Pathologies.Add(name)
            rs.MoveNext()
        End While
        con.Close()
        Return Pathologies
    End Function

    Public Function ObtainPath() As List(Of Pathology)
        Dim Pathologies As New List(Of Pathology)
        Dim con As Connection = connect()

        Dim rs As Recordset = con.Execute("SELECT id, nombre, descripcion, id_prioridad, indiceMortalidad FROM patologia ORDER BY nombre;")

        While (Not rs.EOF)
            Dim id As Integer = DirectCast(rs.Fields("id").Value, Integer)
            Dim priority As Priority = TryCast(rs.Fields("id_prioridad").Value, Priority)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            Dim description As String = TryCast(rs.Fields("descripcion").Value, String)
            Dim mortalityIndex As Integer = DirectCast(rs.Fields("indiceMortalidad").Value, Integer)

            Pathologies.Add(New Pathology(id, priority, name, description, mortalityIndex))
            rs.MoveNext()
        End While
        con.Close()
        Return Pathologies
    End Function

    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = connect()
        If nameTable = "sintoma" Then
            Return con.Execute("Select s.descripcion As Síntoma, r.nombre As Región FROM sintoma s LEFT JOIN region r On(s.id_region=r.id) ORDER BY s.descripcion, r.nombre;")

        ElseIf nameTable = "region" Then
            Return con.Execute("Select nombre FROM region ORDER BY nombre;")

        ElseIf nameTable = "patologia" Then
            Return con.Execute("Select nombre FROM patologia ORDER BY nombre;")
        ElseIf nameTable = "pat_all" Then
            Return con.Execute("Select p.nombre As Patología,p.descripcion As Descripción,pr.nombre As Prioridad FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) ORDER BY p.nombre,pr.id;")
        Else
            Return Nothing
        End If
    End Function

    Public Function SearchSympt(nameDesc As String) As Recordset
        Dim con As Connection = connect()

        Return con.Execute("Select s.descripcion As Síntoma,r.nombre As Región FROM sintoma s LEFT JOIN region r On(s.id_region=r.id) WHERE s.descripcion Like '" & nameDesc & "%' ORDER BY s.descripcion, r.nombre;")
    End Function

    Public Function SearchPath(namePat As String) As Recordset
        Dim con As Connection = connect()

        Return con.Execute("Select p.nombre As Patología,p.descripcion As Descripción,pr.nombre As Prioridad FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) WHERE p.nombre Like '" & namePat & "%' ORDER BY p.nombre,pr.id")
    End Function

    Public Function matchPatientLoggedOn(ci As String) As Integer
        Dim con As Connection = connect()
        Dim rsSelectIdPatient As Recordset = con.Execute("SELECT id FROM persona pat WHERE ci='" + ci + "';")
        Dim idPatientLoggedOn As Integer = DirectCast(rsSelectIdPatient.Fields("id").Value, Integer)
        con.Close()

        Return idPatientLoggedOn
    End Function

    Public Function ObtainSymptoms() As List(Of Symptom)
        Dim con As Connection = connect()
        Dim Symptoms As New List(Of Symptom)
        Dim rsSelectSymptoms As Recordset = con.Execute("SELECT id, descripcion FROM sintoma;")


        While (Not rsSelectSymptoms.EOF)
            Dim idSymptom As Integer = DirectCast(rsSelectSymptoms.Fields("id").Value, Integer)
            Dim descSymptom As String = TryCast(rsSelectSymptoms.Fields("descripcion").Value, String)
            Dim S1 As New Symptom
            S1.Id = idSymptom
            S1.Description = descSymptom
            Symptoms.Add(S1)
            rsSelectSymptoms.MoveNext()
        End While

        con.Close()
        Return Symptoms
    End Function

    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        Dim con As Connection = connect()
        For Each e As Integer In idSympSuffered
            Dim rsInsert As Recordset = con.Execute("INSERT INTO paciente_sufre(id_sintoma, id_paciente) VALUES(" & e & "," & idPatient & ");")
        Next
        con.Close()
    End Sub

    Public Function ObtainPatholgiesSuffered() As List(Of Pathology)
        Dim con As Connection = connect()
        Dim Pathologies As New List(Of Pathology)
        Dim rsPathologiesSuffered As Recordset = con.Execute("SELECT DISTINCT p.id, p.nombre, p.indiceMortalidad, p.id_prioridad FROM paciente_sufre ps JOIN sintoma s ON(ps.id_sintoma = s.id) JOIN sintoma_compone sc ON(s.id = sc.id_sintoma) JOIN patologia p ON(sc.id_patologia = p.id) WHERE ps.id_paciente=2 GROUP BY ps.id_sintoma ")

        While (Not rsPathologiesSuffered.EOF)
            Dim idPathology As Integer = DirectCast(rsPathologiesSuffered.Fields("id").Value, Integer)
            Dim indexMort As Integer = DirectCast(rsPathologiesSuffered.Fields("indiceMortalidad").Value, Integer)
            Dim idPriority As Integer = DirectCast(rsPathologiesSuffered.Fields("id_prioridad").Value, Integer)
            Dim namePathology As String = TryCast(rsPathologiesSuffered.Fields("nombre").Value, String)

            Dim priority As New Priority(idPriority)
            Pathologies.Add(New Pathology(idPathology, namePathology, indexMort, priority))
            rsPathologiesSuffered.MoveNext()
        End While

        con.Close()

        Return Pathologies
    End Function
End Class 'ConnectionDB
