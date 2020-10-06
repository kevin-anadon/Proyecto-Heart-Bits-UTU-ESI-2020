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
    Public Function ObtainTreatmentsAll() As List(Of Treatment)
        Dim con As Connection = Me.Connect()
        Dim treatments As New List(Of Treatment)

        Dim rs As Recordset = con.Execute("SELECT p.id As idPath,p.nombre namePath,t.nombre, t.descripcion, t.tipo FROM tratamiento t JOIN patologia p ON(t.id_patologia=p.id) ORDER BY t.nombre;")

        While (Not rs.EOF)
            Dim idPath As Integer = DirectCast(rs.Fields("idPath").Value, Integer)
            Dim namePath As String = TryCast(rs.Fields("namePath").Value, String)
            Dim Path As New Pathology(idPath, namePath)

            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            Dim desc As String = TryCast(rs.Fields("descripcion").Value, String)
            Dim kind As String = TryCast(rs.Fields("tipo").Value, String)
            treatments.Add(New Treatment(Path, name, desc, kind))
            rs.MoveNext()
        End While
        con.Close()
        Return treatments
    End Function
    Public Function ObtainTreatmentsForMod(idPath As Integer) As List(Of Treatment)
        Dim con As Connection = Me.Connect()
        Dim treatments As New List(Of Treatment)

        Try
            Dim rs As Recordset = con.Execute("SELECT t.nombre, t.descripcion, t.tipo FROM tratamiento t JOIN patologia p ON(t.id_patologia=p.id) WHERE p.id=" & idPath & " ORDER BY t.nombre;")

            While (Not rs.EOF)
                Dim name As String = TryCast(rs.Fields("nombre").Value, String)
                Dim desc As String = TryCast(rs.Fields("descripcion").Value, String)
                Dim kind As String = TryCast(rs.Fields("tipo").Value, String)

                treatments.Add(New Treatment(name, desc, kind))
                rs.MoveNext()
            End While
            Return treatments
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener los tratamientos para modificar")
        Finally
            con.Close()
        End Try

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
    Public Function ObtainKindPath() As List(Of KindPath)
        Dim con As Connection = Me.Connect()
        Dim kindPath As New List(Of KindPath)

        Try
            Dim rs As Recordset = con.Execute("SELECT id,nombre FROM tipo_patologia ORDER BY nombre;")

            While (Not rs.EOF)
                Dim id As Integer = DirectCast(rs.Fields("id").Value, Integer)
                Dim name As String = TryCast(rs.Fields("nombre").Value, String)
                kindPath.Add(New KindPath(id, name))
                rs.MoveNext()
            End While
            Return kindPath
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener los tipos de patologia")
        Finally
            con.Close()
        End Try
        Return Nothing
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
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainPathsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Try
            Dim rsSelectPathsTable As Recordset = con.Execute("Select p.nombre As Patología,p.descripcion As Descripción,pr.nombre As Prioridad FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) ORDER BY p.nombre, pr.id;")
            da.Fill(ds, rsSelectPathsTable, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener la tabla de patologías")
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainTable(nameTable As String) As Recordset
        Dim con As Connection = Me.Connect()
        If nameTable = "sintoma" Then 'Sentencia "Slect Case" mas favorable para estos casos...
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
    Public Sub AddPathology(Path As Pathology, Treatments As List(Of Treatment))
        Dim con As Connection = Me.Connect()
        Try
            Dim rsInsertPath As Recordset = con.Execute("INSERT INTO patologia(id_prioridad,nombre,descripcion,indiceMortalidad,id_tipo) VALUES(" & Path.priority.id & ",'" & Path.name & "','" & Path.description & "'," & Path.mortalityIndex & "," & Path.kind.id & ");")
            Dim rsSelectIdPath As Recordset = con.Execute("SELECT id FROM patologia WHERE nombre='" & Path.name & "';")
            Dim idPath As Integer = DirectCast(rsSelectIdPath.Fields("id").Value, Integer)

            For Each treat As Treatment In Treatments
                Dim rsIinsertTreat As Recordset = con.Execute("INSERT INTO tratamiento(id_patologia, nombre, descripcion, tipo) VALUES(" & idPath & ",'" & treat.name & "','" & treat.description & "','" & treat.kind & "');")
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al agregar la patología")
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub UpdatePathology(Path As Pathology, Treatments As List(Of Treatment))
        Dim con As Connection = Me.Connect()
        Try
            Dim rsUpdatePath As Recordset = con.Execute("UPDATE patologia SET id_prioridad=" & Path.priority.id & ", nombre='" & Path.name & "', descripcion='" & Path.description & "', indiceMortalidad=" & Path.mortalityIndex & ",id_tipo=" & Path.kind.id & " WHERE id=" & Path.id & ";")
            Dim rsDelTreat As Recordset = con.Execute("DELETE From tratamiento Where id_patologia =" & Path.id & ";")
            For Each treat As Treatment In Treatments
                Dim rsIinsertTreat As Recordset = con.Execute("INSERT INTO tratamiento(id_patologia, nombre, descripcion, tipo) VALUES(" & Path.id & ",'" & treat.name & "','" & treat.description & "','" & treat.kind & "');")
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al modificar la patología")
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub DeletePathology(idPath As Integer)
        Dim con As Connection = Me.Connect()
        Dim idDiag As Integer = 0
        Try
            Dim rsDelTreatment As Recordset = con.Execute("DELETE FROM tratamiento WHERE id_patologia=" & idPath & ";") 'Borro los tratamientos asociados
            Dim rsDelSintomaCompone As Recordset = con.Execute("DELETE FROM sintoma_compone WHERE id_patologia=" & idPath & ";") 'Borro la asociación con los sintomas

            Dim rsSelectIdDiag As Recordset = con.Execute("SELECT id FROM diagnostico WHERE id_patologia=" & idPath & ";")
            While (Not rsSelectIdDiag.EOF)
                idDiag = DirectCast(rsSelectIdDiag.Fields("id").Value, Integer)
                Dim rsDelVerifica As Recordset = con.Execute("DELETE FROM verifica WHERE id_tentativo=" & idDiag & ";") 'Borro la asociacion de médicos con diagnósticos
                rsSelectIdDiag.MoveNext()
            End While

            If rsSelectIdDiag.EOF Then 'En el caso de que todavia no exista ningun diagnostico que contenga esa Patología
                Dim rsDelPath As Recordset = con.Execute("DELETE FROM patologia WHERE id=" & idPath & ";")
            Else
                Dim rsDelDiag As Recordset = con.Execute("DELETE FROM diagnostico WHERE id_patologia=" & idPath & ";")
                Dim rsDelPath As Recordset = con.Execute("DELETE FROM patologia WHERE id=" & idPath & ";")
            End If

        Catch ex As Exception
            Throw New Exception("Error al eliminar Patología")
        Finally
            con.Close()
        End Try

    End Sub
    Public Function SearchPathology(NamePath As String) As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Try
            Dim rsSelectPathsTable As Recordset = con.Execute("Select p.nombre As Patología,p.descripcion As Descripción,pr.nombre As Prioridad FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) WHERE p.nombre Like '" & NamePath & "%' ORDER BY p.nombre,pr.id")
            da.Fill(ds, rsSelectPathsTable, "Search")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener la tabla de patologías")
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainPathForMod(NamePath As String) As Pathology
        Dim con As Connection = Me.Connect()
        Dim Path As Pathology = Nothing

        Try
            Dim rsSelectPaths As Recordset = con.Execute("Select p.id As idPath,p.nombre As nomPath,p.descripcion,p.indiceMortalidad,pr.id As idPrior,pr.nombre As nomPrior,t.id As idTipo,t.nombre As nomTipo FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) JOIN tipo_patologia t ON(p.id_tipo=t.id) WHERE p.nombre='" & NamePath & "';")
            Dim idPath As Integer = DirectCast(rsSelectPaths.Fields("idPath").Value, Integer)
            Dim name As String = TryCast(rsSelectPaths.Fields("nomPath").Value, String)
            Dim desc As String = TryCast(rsSelectPaths.Fields("descripcion").Value, String)
            Dim indexM As Integer = DirectCast(rsSelectPaths.Fields("indiceMortalidad").Value, Integer)
            Dim idPrior As Integer = DirectCast(rsSelectPaths.Fields("idPrior").Value, Integer)
            Dim namePrior As String = TryCast(rsSelectPaths.Fields("nomPrior").Value, String)
            Dim idKind As Integer = DirectCast(rsSelectPaths.Fields("idTipo").Value, Integer)
            Dim nameKind As String = TryCast(rsSelectPaths.Fields("nomTipo").Value, String)

            Dim Prior As New Priority(idPrior, namePrior)
            Dim Kind As New KindPath(idKind, nameKind)
            Path = New Pathology(idPath, Prior, name, desc, indexM, Kind)
            Return Path
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener la tabla de patologías")
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function
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

        Dim rs As Recordset = con.Execute("SELECT p.id, p.nombre, p.descripcion, prior.id As idPrior,prior.nombre As nomPrior,p.indiceMortalidad, t.id As idTipo, t.nombre As nomTipo FROM patologia p JOIN tipo_patologia t ON(p.id_tipo=t.id) JOIN prioridad prior ON(p.id_prioridad=prior.id) ORDER BY nombre;")

        While (Not rs.EOF)
            Dim id As Integer = DirectCast(rs.Fields("id").Value, Integer)
            Dim idPrior As Integer = DirectCast(rs.Fields("idPrior").Value, Integer)
            Dim namePrior As String = TryCast(rs.Fields("nomPrior").Value, String)
            Dim priority As New Priority(idPrior, namePrior)
            Dim name As String = TryCast(rs.Fields("nombre").Value, String)
            Dim description As String = TryCast(rs.Fields("descripcion").Value, String)
            Dim mortalityIndex As Integer = DirectCast(rs.Fields("indiceMortalidad").Value, Integer)
            Dim idKindPath As Integer = DirectCast(rs.Fields("idTipo").Value, Integer)
            Dim nameKindPath As String = TryCast(rs.Fields("nomTipo").Value, String)
            Dim kind As New KindPath(idKindPath, nameKindPath)

            Pathologies.Add(New Pathology(id, priority, name, description, mortalityIndex, kind))
            rs.MoveNext()
        End While
        con.Close()
        Return Pathologies
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

        Try
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

            Return Symptoms
        Catch ex As Exception
            Console.WriteLine(ex)
            Throw New Exception("Error al obtener sintomas")
        Finally
            con.Close()
        End Try




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
    Public Function ObtainAdmins() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectAdmin As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(va.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(va.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email
            FROM vista_admin va JOIN cel_empleado c ON(va.id=c.id_empleado)
            GROUP BY va.id;")

            da.Fill(ds, rsSelectAdmin, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al cargar la tabla de administradores")
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
        Try
            Dim rsSelectIdPatient As Recordset = con.Execute("SELECT id FROM persona pat WHERE ci='" + ci + "';")
            Dim idPatientLoggedOn As Integer = DirectCast(rsSelectIdPatient.Fields("id").Value, Integer)
            Return idPatientLoggedOn
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer))
        Dim con As Connection = Me.Connect()

        Try
            Dim rsIsThere As Recordset = con.Execute("SELECT id_sintoma FROM paciente_sufre WHERE id_paciente=" & idPatient)
            If Not rsIsThere.EOF Then
                Dim rsDelete As Recordset = con.Execute("DELETE FROM paciente_sufre WHERE id_paciente=" & idPatient)
                rsIsThere.MoveNext()
            End If

            For Each e As Integer In idSympSuffered
                Dim rsInsert As Recordset = con.Execute("INSERT INTO paciente_sufre(id_sintoma, id_paciente) VALUES(" & e & "," & idPatient & ");")
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function ObtainPatholgiesSuffered(idPatient As Integer) As List(Of Pathology)
        Dim con As Connection = Me.Connect()
        Dim Pathologies As New List(Of Pathology)
        Try
            Dim rsPathologiesSuffered As Recordset = con.Execute("SELECT DISTINCT p.id, p.nombre, p.indiceMortalidad, p.id_prioridad FROM paciente_sufre ps JOIN sintoma s ON(ps.id_sintoma = s.id) JOIN sintoma_compone sc ON(s.id = sc.id_sintoma) JOIN patologia p ON(sc.id_patologia = p.id) WHERE ps.id_paciente=" & idPatient)

            While (Not rsPathologiesSuffered.EOF)
                Dim idPathology As Integer = DirectCast(rsPathologiesSuffered.Fields("id").Value, Integer)
                Dim indexMort As Integer = DirectCast(rsPathologiesSuffered.Fields("indiceMortalidad").Value, Integer)
                Dim idPriority As Integer = DirectCast(rsPathologiesSuffered.Fields("id_prioridad").Value, Integer)
                Dim namePathology As String = TryCast(rsPathologiesSuffered.Fields("nombre").Value, String)

                Dim priority As New Priority(idPriority)
                Pathologies.Add(New Pathology(idPathology, namePathology, indexMort, priority))
                rsPathologiesSuffered.MoveNext()
            End While
            Return Pathologies
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
    Public Sub UnsuscribePatient(idPatient As Integer)
        Dim con As Connection = Me.Connect
        Dim rsUpdate As Recordset = con.Execute("UPDATE persona  SET habilitado=false WHERE ci=" & idPatient)
        con.Close()
    End Sub
    Public Function MakePetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Dim con As Connection = Me.Connect
        Try
            Dim rsInsertPetition As Recordset = con.Execute("INSERT INTO peticion (id_paciente, estado, motivo, fechaHoraInicio, fechaHoraFin) VALUES (" & idPatient & "," & 1 & ",'" + motive + "','" + datetI + "','" + datetF + "')")
            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function StopPetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Dim con As Connection = Me.Connect
        Try
            Dim rsSearchPetition As Recordset = con.Execute("SELECT p.id FROM peticion p WHERE id_paciente=" & idPatient & " AND fechaHoraInicio='" + datetI + "'")
            If rsSearchPetition.EOF Then
                Console.WriteLine("No existe tal petición.")
                Return False
            Else
                Dim rsIdPetition As Integer = DirectCast(rsSearchPetition.Fields("id").Value, Integer)
                Dim rsStopPetitionA As Recordset = con.Execute("UPDATE peticion p SET p.estado=" & 0 & " WHERE p.id=" & rsIdPetition)
                Dim rsStopPetitionB As Recordset = con.Execute("UPDATE peticion p SET p.motivo='" + motive + "' WHERE p.id=" & rsIdPetition)
                Dim rsStopPetitionC As Recordset = con.Execute("UPDATE peticion p SET p.fechaHoraFin='" + datetF + "' WHERE p.id=" & rsIdPetition)
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function




End Class 'DataBaseConn
