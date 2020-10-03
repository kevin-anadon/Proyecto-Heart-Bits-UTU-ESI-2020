Imports ADODB
Imports Data
Public Class DataBaseConn

    'Herramientas de conexión
    Private Function Connect() As Connection
        Try
            Dim connection As New Connection()
            connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.0.0.1;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
            connection.Open()
            Return connection
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        End Try
    End Function

    Public Sub TryConnection()
        Dim con As New Connection()

        Try
            con.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.0.0.1;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
            con.Open()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("No se pudo conectar. Inicie la aplicación nuevamente")
        End Try

    End Sub


    'Query Otros
    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Dim con As Connection = Me.Connect()
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
        Dim con As Connection = Me.Connect()

        Dim rsSelectMortality As Recordset = con.Execute("SELECT indiceMortalidad FROM patologia WHERE nombre='" + pat + "';")
        Dim Mortality As Integer = DirectCast(rsSelectMortality.Fields("indiceMortalidad").Value, Integer)

        con.Close()
        Return Mortality
    End Function
    Public Function ObtainRegions() As List(Of Region)
        Dim con As Connection = Me.Connect()
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
        Dim con As Connection = Me.Connect()
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
    Public Function ObtainSymptomsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Try
            Dim rsSelectSymptomsTable As Recordset = con.Execute("Select s.descripcion As Síntoma, r.nombre As Región FROM sintoma s LEFT JOIN region r On(s.id_region=r.id) ORDER BY s.descripcion, r.nombre;")
            da.Fill(ds, rsSelectSymptomsTable, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener la tabla de síntomas")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = Me.Connect()
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



    'Query Patologias
    Public Sub InsertPath(name As String, desc As String, indiceM As Integer, Prior As Integer, treatments As List(Of Treatment))
        Dim con As Connection = Me.Connect()
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
    Public Sub UpdatePath(patname As String, patdesc As String, patmortality As Integer, idprior As Integer, treatments As List(Of Treatment), patnamebefore As String)
        Dim con As Connection = Me.Connect()

        Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + patnamebefore + "';")
        Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)
        Dim rsInsert As Recordset = con.Execute("UPDATE patologia SET id_prioridad=" & idprior & ", nombre='" & patname & "', descripcion='" & patdesc & "', indiceMortalidad='" & patmortality & "' WHERE id=" & idpat & ";")
        Dim rsDelTreat As Recordset = con.Execute("DELETE From tratamiento Where id_patologia =" & idpat & ";")


        For Each treat As Treatment In treatments
            Dim rsIinsertTreat As Recordset = con.Execute("INSERT INTO tratamiento(id_patologia, nombre, descripcion, tipo) VALUES(" & idpat & ",'" & treat.name & "','" & treat.description & "','" & treat.kind & "');")
        Next
        con.Close()
    End Sub
    Public Sub DelPath(pat As String)
        Dim con As Connection = Me.Connect()

        Dim rsSelectIdPat As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" + pat + "';")
        Dim idpat As Integer = DirectCast(rsSelectIdPat.Fields("id").Value, Integer)

        Dim rsDelTratamiento As Recordset = con.Execute("DELETE FROM tratamiento WHERE id_patologia=" & idpat)
        Dim rsDelPat As Recordset = con.Execute("DELETE FROM patologia WHERE id=" & idpat)
        Console.WriteLine(pat + " Eliminado con exito, con sus tratamientos!!")
        con.Close()
    End Sub
    Public Function ObtainPathForSymptoms(sympt As String) As List(Of Pathology)
        Dim Pathologies As New List(Of Pathology)
        Dim con As Connection = Me.Connect()

        Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + sympt + "';")
        Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
        Dim rsSelectPath As Recordset = con.Execute("SELECT * FROM patologia p JOIN sintoma_compone sc ON(p.id=sc.id_patologia) WHERE sc.id_sintoma=" & idsympt & ";")

        While (Not rsSelectPath.EOF)
            Dim id As Integer = DirectCast(rsSelectPath.Fields("id").Value, Integer)
            Dim priority As Priority = TryCast(rsSelectPath.Fields("id_prioridad").Value, Priority)
            Dim name As String = TryCast(rsSelectPath.Fields("nombre").Value, String)
            Dim description As String = TryCast(rsSelectPath.Fields("descripcion").Value, String)
            Dim mortalityIndex As Integer = DirectCast(rsSelectPath.Fields("indiceMortalidad").Value, Integer)
            Pathologies.Add(New Pathology(id, priority, name, description, mortalityIndex))
            rsSelectPath.MoveNext()
        End While
        con.Close()
        Return Pathologies
    End Function
    Public Function ObtainPath() As List(Of Pathology)
        Dim Pathologies As New List(Of Pathology)
        Dim con As Connection = Me.Connect()

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
    Public Function SearchPath(namePat As String) As Recordset
        Dim con As Connection = Me.Connect()

        Return con.Execute("Select p.nombre As Patología,p.descripcion As Descripción,pr.nombre As Prioridad FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) WHERE p.nombre Like '" & namePat & "%' ORDER BY p.nombre,pr.id")
    End Function



    'Query Sintomas
    Public Sub AddSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Dim con As Connection = Me.Connect()

        Try
            If Sympt.Region.id = -1 Then 'En el caso de que haya añadido un síntoma sin región
                Dim rsInsert As Recordset = con.Execute("INSERT INTO sintoma(descripcion) VALUES('" & Sympt.Description & "');")
            Else
                Dim rsInsert As Recordset = con.Execute("INSERT INTO sintoma(id_region,descripcion) VALUES(" & Sympt.Region.id & ",'" & Sympt.Description & "');")
            End If
            Dim rsSelectIdSympt As Recordset = con.Execute("SELECT id FROM sintoma WHERE descripcion='" + Sympt.Description + "';")
            Dim idsympt As Integer = DirectCast(rsSelectIdSympt.Fields("id").Value, Integer)
            For Each Pathologies As Pathology In Paths
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & idsympt & "," & Pathologies.id & ");")
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al añadir Sintomas")
        Finally
            con.Close()
        End Try

    End Sub

    Public Sub UpdateSymptoms(Sympt As Symptom, Paths As List(Of Pathology))
        Dim con As Connection = Me.Connect()

        Try
            If Sympt.Region.id = -1 Then 'En el caso de que haya modificado un síntoma y le haya sacado la region
                Dim rsInsert As Recordset = con.Execute("UPDATE sintoma SET sintoma='" & Sympt.Description & "' WHERE id=" & Sympt.Id & ";")
            Else
                Dim rsInsert As Recordset = con.Execute("UPDATE sintoma SET id_region=" & Sympt.Region.id & ",descripcion='" & Sympt.Description & "' WHERE id=" & Sympt.Id & ";")
            End If
            Dim rsDelSintoma_Compone As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & Sympt.Id & ";")

            For Each Pathologies As Pathology In Paths
                Dim rsIinsertSC As Recordset = con.Execute("INSERT INTO sintoma_compone VALUES(" & Sympt.Id & "," & Pathologies.id & ");")
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al modificar Sintomas")
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub DeleteSymptoms(idSympt As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsDelSintomaCompone As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_sintoma=" & idSympt)
            Dim rsDel As Recordset = con.Execute("DELETE FROM sintoma WHERE id=" & idSympt)
        Catch ex As Exception
            Throw New Exception("Error al eliminar Síntoma")
        Finally
            con.Close()
        End Try

    End Sub
    Public Function SearchSymptoms(Desc As String) As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSearchSympts As Recordset = con.Execute("Select s.descripcion As Síntoma,r.nombre As Región FROM sintoma s LEFT JOIN region r On(s.id_region=r.id) WHERE s.descripcion Like '" & Desc & "%' ORDER BY s.descripcion, r.nombre;")
            da.Fill(ds, rsSearchSympts, "Search")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al buscar")
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainSymptoms() As List(Of Symptom)
        Dim con As Connection = Me.Connect()
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



    'Query Personas
    Public Function PatientAllowed(ci As String) As Short
        Dim con As Connection = Me.Connect

        Try
            Dim rsAllowed As Recordset = con.Execute("SELECT p.habilitado FROM persona p WHERE id_tipo='3' AND p.ci=" & Integer.Parse(ci))
            Dim allowed As Integer = DirectCast(rsAllowed.Fields("habilitado").Value, Short)

            If allowed = 1 Then '1 Significa True, 0 False
                Return 2 'Habilidato
            Else
                Return 5 'No habilitado
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            'Este error se debe a que no está determinado el valor de "Habilitado", pues la CI usada no corresponde a una existente
            Return 4 'Cédula de identidad errónea.
        End Try

        con.Close()
    End Function
    Public Function LoginPatient(ci As String) As Short
        Dim allowed As Short = Me.PatientAllowed(ci)

        Dim con As Connection = Me.Connect
        Dim codeMsg As Short = allowed

        If allowed = 2 Then
            Try
                Dim rsSelectPatientCi As Recordset = con.Execute("SELECT p.ci FROM persona p WHERE id_tipo=3 AND ci=" & Integer.Parse(ci))
                If IsNothing(rsSelectPatientCi) Then
                    'No se encuentra ningun Paciente con esta CI
                    codeMsg = 4 'Cédula de identidad errónea.
                Else
                    codeMsg = 2 'Habilidato
                End If
            Catch ex As Exception
                Console.WriteLine(ex)
                codeMsg = 3 'Error de Conexión.
            End Try
        End If

        con.Close()
        Return codeMsg
    End Function
    Public Function LoginAdmin(user As String, pass As String) As Admin
        Dim con As Connection = Me.Connect()
        Try
            Dim rsSelectAdmin As Recordset = con.Execute("SELECT * FROM vista_admin WHERE usuario='" & user & "' AND contrasena='" & pass & "';")

            Dim id As Integer = DirectCast(rsSelectAdmin.Fields("id").Value, Integer)
            Dim ci As Integer = DirectCast(rsSelectAdmin.Fields("ci").Value, Integer)
            Dim name1 As String = TryCast(rsSelectAdmin.Fields("primerNom").Value, String)
            Dim name2 As String = TryCast(rsSelectAdmin.Fields("segundoNom").Value, String)
            Dim surn1 As String = TryCast(rsSelectAdmin.Fields("primerApe").Value, String)
            Dim surn2 As String = TryCast(rsSelectAdmin.Fields("segundoApe").Value, String)
            Dim genre As String = TryCast(rsSelectAdmin.Fields("genero").Value, String)
            Dim birthdate As Date = DirectCast(rsSelectAdmin.Fields("fechaNacimiento").Value, Date)
            Dim email As String = TryCast(rsSelectAdmin.Fields("email").Value, String)
            Dim street As String = TryCast(rsSelectAdmin.Fields("calle").Value, String)
            Dim ndoor As Integer = DirectCast(rsSelectAdmin.Fields("npuerta").Value, Integer)
            Dim userSelect As String = TryCast(rsSelectAdmin.Fields("usuario").Value, String)
            Dim password As String = TryCast(rsSelectAdmin.Fields("contrasena").Value, String)
            Dim pin As Integer = DirectCast(rsSelectAdmin.Fields("pin").Value, Integer)

            Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_admin va JOIN ciudad c ON(va.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE va.id=" & id & ";") 'Consulta para Obtenere Departamento y Ciudad

            Dim rsSelectPhones As Recordset = con.Execute("SELECT group_concat(c.celular) As Celulares FROM vista_admin va JOIN cel_empleado c ON(va.id=c.id_empleado) WHERE va.id=" & id & ";") 'Consulta para Obtener celulares del Admin

            Dim id_city As Integer = DirectCast(rsSelectCity_Dpto.Fields("Idc").Value, Integer)
            Dim CityName As String = TryCast(rsSelectCity_Dpto.Fields("Cnombre").Value, String)
            Dim id_dpto As Integer = DirectCast(rsSelectCity_Dpto.Fields("Idd").Value, Integer)
            Dim DptoName As String = TryCast(rsSelectCity_Dpto.Fields("Dnombre").Value, String)
            Dim Phones As String = TryCast(rsSelectPhones.Fields("Celulares").Value, String)

            Dim Dpto As New Department(id_dpto, DptoName) 'Creo el objeto Departamento
            Dim City As New City(id_city, Dpto, CityName) 'Creo el objeto Ciudad

            Dim genrenumber As Integer = 0
            If genre.Equals("M") Then
                genrenumber = 1
            Else
                genrenumber = 0
            End If

            Dim AdminLog As New Admin(id, ci, name1, name2, surn1, surn2, genrenumber, birthdate, email, Phones, street, ndoor, City, userSelect, password, pin)
            Return AdminLog
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Usuario y/o Contraseña equivocado")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function CheckPin(pin As String) As Boolean
        Dim con As Connection = Me.Connect()
        Dim checked As Boolean = False
        Dim rsSelectPin As Recordset
        rsSelectPin = con.Execute("SELECT ci FROM persona WHERE id_tipo=1 and pin='" + pin + "';")
        If rsSelectPin.EOF Then
            con.Close()
            Return checked
        Else
            checked = True
            con.Close()
            Return checked
        End If
    End Function
    Public Function matchPatientLoggedOn(ci As String) As Integer
        Dim con As Connection = Me.Connect()
        Dim rsSelectIdPatient As Recordset = con.Execute("SELECT id FROM persona pat WHERE ci='" + ci + "';")
        Dim idPatientLoggedOn As Integer = DirectCast(rsSelectIdPatient.Fields("id").Value, Integer)
        con.Close()

        Return idPatientLoggedOn
    End Function
    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        Dim con As Connection = Me.Connect()
        Dim rsIsThere As Recordset = con.Execute("SELECT id_sintoma FROM paciente_sufre WHERE id_paciente=" & idPatient)
        If Not rsIsThere.EOF Then
            Dim rsDelete As Recordset = con.Execute("DELETE FROM paciente_sufre WHERE id_paciente=" & idPatient)
            rsIsThere.MoveNext()
        End If

        For Each e As Integer In idSympSuffered
            Dim rsInsert As Recordset = con.Execute("INSERT INTO paciente_sufre(id_sintoma, id_paciente) VALUES(" & e & "," & idPatient & ");")
        Next
        con.Close()
    End Sub
    Public Function ObtainPatholgiesSuffered() As List(Of Pathology)
        Dim con As Connection = Me.Connect()
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



End Class 'DataBaseConn
