Imports ADODB
Imports Data
Public Class DataBaseConn
    'Herramientas de conexión
    Private Function Connect() As Connection
        Try
            Dim connection As New Connection()
            'connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=192.168.5.50;port=3306;database=kevin_anadon;uid=kevin.anadon;pwd=52108971"
            'connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=vdo.dyndns.org;port=3306;database=telediagnosticomedico_heartbits;uid=heartbits;pwd=h34rtbits;"
            connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.17.0.0;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
            connection.Open()
            Return connection
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        End Try
    End Function
    Public Sub TryConnection()
        Dim connnection As New Connection()
        Try
            'connnection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=192.168.5.50;port=3306;database=kevin_anadon;uid=kevin.anadon;pwd=52108971"
            'connnection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=vdo.dyndns.org;port=3306;database=telediagnosticomedico_heartbits;uid=heartbits;pwd=h34rtbits;"
            connnection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};server=127.17.0.0;port=3306;database=telediagnosticomedico_heartbits;uid=root;pwd=;"
            connnection.Open()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("No se pudo conectar. Inicie la aplicación nuevamente")
        End Try
    End Sub


    'Query Otros
    Public Function ObtainSymptomsSuffered(idPatient As Integer, DateNow As String) As List(Of Symptom)
        Dim con As Connection = Me.Connect()
        Dim Symptoms As New List(Of Symptom)

        Try
            Dim rsSelectSymptomsSuffered As Recordset = con.Execute("SELECT s.id, s.descripcion FROM sintoma s JOIN paciente_sufre ps ON(s.id=ps.id_sintoma) WHERE ps.id_paciente=" & idPatient & " AND ps.fecha='" + DateNow + "';")

            While (Not rsSelectSymptomsSuffered.EOF)
                Dim idSymptom As Integer = DirectCast(rsSelectSymptomsSuffered.Fields("id").Value, Integer)
                Dim descSymptom As String = TryCast(rsSelectSymptomsSuffered.Fields("descripcion").Value, String)
                Dim S1 As New Symptom
                S1.Id = idSymptom
                S1.Description = descSymptom
                Symptoms.Add(S1)
                rsSelectSymptomsSuffered.MoveNext()
            End While

            Return Symptoms
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener los síntomas seleccionados")
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainTentativeDiagnostic(Patient As People, DateNow As String) As Diagnostic
        Dim con As Connection = Me.Connect()
        Dim Diag As Diagnostic

        Try
            Dim rsSelectTentativeDiagnostic As Recordset = con.Execute("SELECT id IdDiag,id_tipo, id_patologia IdPat FROM diagnostico WHERE id_paciente=" & Patient.id & " AND fecha='" + DateNow + "';")
            Dim idDiag As Integer = DirectCast(rsSelectTentativeDiagnostic.Fields("IdDiag").Value, Integer)
            Dim idKindDiag As Integer = DirectCast(rsSelectTentativeDiagnostic.Fields("id_tipo").Value, Integer)
            Dim idPathDiag As Integer = DirectCast(rsSelectTentativeDiagnostic.Fields("idPat").Value, Integer)

            Dim rsSelectPaths As Recordset = con.Execute("Select p.id As idPath,p.nombre As nomPath,p.descripcion,p.indiceMortalidad,pr.id As idPrior,pr.nombre As nomPrior,t.id As idTipo,t.nombre As nomTipo FROM patologia p JOIN prioridad pr On(p.id_prioridad=pr.id) JOIN tipo_patologia t ON(p.id_tipo=t.id) WHERE p.id='" & idPathDiag & "';")
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
            Dim Path = New Pathology(idPath, Prior, name, desc, indexM, Kind)

            Diag = New Diagnostic(idDiag, idKind, Patient, Path, CDate(DateNow))
            Return Diag
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener el diagnóstico")
        Finally
            con.Close()
        End Try
    End Function
    Public Sub VerifyDiagnostic(idMed As Integer, idDiag As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsInsertVerification As Recordset = con.Execute("INSERT INTO verifica VALUES(" & idDiag & "," & idMed & ");")
        Catch ex As Exception
            Throw New Exception("Error al verificar el diagnóstico")
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub UpdateDiagnostic(idDiagnostic As Integer, idPath As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsInsertVerification As Recordset = con.Execute("UPDATE diagnostico SET id_patologia=" & idPath & " WHERE id=" & idDiagnostic & ";")
        Catch ex As Exception
            Throw New Exception("Error al modificar el diagnóstico")
        Finally
            con.Close()
        End Try

    End Sub
    Public Function ObtainTreatments(pat As String) As List(Of Treatment)
        Dim con As Connection = Me.Connect()
        Dim treatments As New List(Of Treatment)

        Dim rs As Recordset = con.Execute("Select t.nombre, t.descripcion, t.tipo FROM tratamiento t JOIN patologia p On(t.id_patologia=p.id) WHERE p.nombre='" & pat & "' ORDER BY t.nombre;")

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
    Public Function ObtainSpecialities() As List(Of String)
        Dim con As Connection = Me.Connect()
        Dim specialities As New List(Of String)

        Try
            Dim rs As Recordset = con.Execute("SELECT DISTINCT especialidad FROM vista_medico;")
            While (Not rs.EOF)
                Dim name As String = TryCast(rs.Fields("especialidad").Value, String)
                specialities.Add(name)
                rs.MoveNext()
            End While
            Return specialities
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener las especialidades")
        Finally
            con.Close()
        End Try
        Return Nothing
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
    Public Function ObtainIdSymptoms(desc As List(Of String), idPathology As Integer) As List(Of String)
        Dim con As Connection = Me.Connect()
        Dim descSymptoms As New List(Of String)
        Dim rsSelectSymptoms As Recordset

        Try
            rsSelectSymptoms = con.Execute("SELECT s.descripcion FROM sintoma_compone sc JOIN sintoma s ON(sc.id_sintoma = s.id)WHERE sc.id_patologia='" & idPathology & "';")

            While (Not rsSelectSymptoms.EOF)
                Dim rsDescSymptom As String = TryCast(rsSelectSymptoms.Fields("descripcion").Value, String)

                descSymptoms.Add(rsDescSymptom)

                rsSelectSymptoms.MoveNext()
            End While

            Return descSymptoms
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw New Exception("Error al obtener sintomas")
        Finally
            con.Close()
        End Try
    End Function
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
    Public Function ObtainSymptoms() As List(Of Data.Symptom)
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


    'Query Chat
    Public Function CreateRoom() As Integer
        Dim con As Connection = Me.Connect

        Try
            con.BeginTrans()

            Dim fecha As String = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss")
            Dim rsAllowed As Recordset = con.Execute("INSERT INTO salaChat(estado,fechaHoraInicio) VALUES(1,'" & fecha & "');")
            Dim rsSelectIdRoom As Recordset = con.Execute("SELECT id FROM salaChat WHERE fechaHoraInicio='" + fecha + "';")
            Dim idRoom As Integer = DirectCast(rsSelectIdRoom.Fields("id").Value, Integer)
            con.CommitTrans()

            Return idRoom
        Catch ex As Exception
            con.RollbackTrans()

            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al crear la Sala de chat")
        Finally
            con.Close()
        End Try

    End Function

    Public Sub LeaveRoom(idRoom As Integer, DateNow As String)
        Dim con As Connection = Me.Connect

        Try
            con.BeginTrans()

            Dim rsLeaveRoom As Recordset = con.Execute("UPDATE salaChat SET estado=0,motivo='El médico finalizó el chat',fechaHoraFin='" + DateNow + "' WHERE id=" & idRoom & ";")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al finalizar la Sala de Chat")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub CheckStateRoom(idRoom As Integer)
        Dim con As Connection = Me.Connect

        Try
            Dim rsLeaveRoom As Recordset = con.Execute("SELECT * FROM salaChat WHERE id=" & idRoom & " AND estado=1;")
            If rsLeaveRoom.EOF Then
                Throw New Exception("La sala ya finalizó")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener el estado de la sala")
        Finally
            con.Close()
        End Try
    End Sub


    Public Sub SendMessage(idPeople As Integer, idRoom As Integer, msg As String, Hour As String)
        Dim con As Connection = Me.Connect

        Try
            con.BeginTrans()

            Dim rsSendMessage As Recordset = con.Execute("INSERT INTO conversa VALUES(" & idPeople & "," & idRoom & ",'" & msg & "','" & Hour & "');")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al enviar el mensaje")
        Finally
            con.Close()
        End Try
    End Sub
    Public Function ObtainMessages(idRoom As Integer) As List(Of Message)
        Dim con As Connection = Me.Connect
        Dim Msgs As New List(Of Message)

        Try
            Dim rsObtainMessage As Recordset = con.Execute("SELECT mensaje,id_persona,hora FROM conversa WHERE id_sala=" & idRoom & " ORDER BY hora asc;")

            While Not rsObtainMessage.EOF
                Dim Msg As String = TryCast(rsObtainMessage.Fields("mensaje").Value, String)
                Dim idP As Integer = DirectCast(rsObtainMessage.Fields("id_persona").Value, Integer)
                Dim hour As DateTime = DirectCast(rsObtainMessage.Fields("hora").Value, DateTime)
                Msgs.Add(New Message(Msg, idP, hour))
                rsObtainMessage.MoveNext()
            End While
            Return Msgs
        Catch ex As Exception
            Throw New Exception("Error al obtener los mensajes")
        End Try
    End Function


    'Query Personas
    Public Function PatientAllowed(ci As String) As Short
        Dim con As Connection = Me.Connect

        Try
            Dim rsAllowed As Recordset = con.Execute("Select p.habilitado FROM persona p WHERE id_tipo='3' AND p.ci=" & Integer.Parse(ci))
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
                    codeMsg = 2 'Habilitado
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

            Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_admin va JOIN ciudad c ON(va.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE va.id=" & id & ";") 'Consulta para Obtener el Departamento y Ciudad

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
    Public Function ObtainAdmins() As List(Of Admin)
        Dim con As Connection = Me.Connect()
        Dim ListAdmins As New List(Of Admin)

        Try
            Dim rsSelectAdmin As Recordset = con.Execute("SELECT * FROM vista_admin;")

            While Not rsSelectAdmin.EOF

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

                Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_admin va JOIN ciudad c ON(va.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE va.id=" & id & ";") 'Consulta para Obtener Departamento y Ciudad

                Dim rsSelectPhones As Recordset = con.Execute("SELECT group_concat(c.celular) As Celulares FROM vista_admin va JOIN cel_empleado c ON(va.id=c.id_empleado) WHERE id_empleado=" & id & ";") 'Consulta para Obtener celulares del Admin

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
                ListAdmins.Add(AdminLog)
                rsSelectAdmin.MoveNext()
                rsSelectCity_Dpto.MoveNext()
                rsSelectPhones.MoveNext()
            End While

            Return ListAdmins
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener lista de Admins")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function SearchAdmin(Ci As Integer) As DataSet
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
            GROUP BY va.id HAVING va.ci Like '" & Ci & "%';")

            da.Fill(ds, rsSelectAdmin, "Search")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al buscar administradores")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function ObtainAdminsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectAdmin As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(va.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(va.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email
            FROM vista_admin va LEFT JOIN cel_empleado c ON(va.id=c.id_empleado)
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
    Public Sub DeleteAdmin(idAdmin As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsDeleteAdminCel As Recordset = con.Execute("DELETE FROM cel_empleado WHERE id_empleado=" & idAdmin & ";")
            Dim rsDeleteAdmin As Recordset = con.Execute("DELETE FROM persona WHERE id_tipo=1 AND id=" & idAdmin & ";")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al eliminar el Administrador")
        End Try

    End Sub
    Public Sub AddAdmin(Admin As Admin)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            If Admin.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Admin.dateBirth.ToString("yyy-MM-dd")

            Dim rsAddAdmin As Recordset = con.Execute("INSERT INTO persona(ci,primerNom,segundoNom,primerApe,segundoApe,genero,fechaNacimiento,email,calle,npuerta,id_ciudad,id_tipo,usuario,contrasena,pin) VALUES(" & Admin.ci & ",'" & Admin.fstName & "','" & Admin.scndName & "','" & Admin.fstSurname & "','" & Admin.scndSurname & "','" & genre & "','" & BirthdateString & "','" & Admin.email & "','" & Admin.street & "'," & Admin.numDoor & "," & Admin.city.Id & ",1,'" & Admin.username & "','" & Admin.password & "'," & Admin.pin & ");")
            Dim rsSelectId As Recordset = con.Execute("SELECT id FROM persona WHERE ci=" & Admin.ci & ";")
            Dim id As Integer = DirectCast(rsSelectId.Fields("id").Value, Integer)

            Dim rsAddPhone As Recordset = con.Execute("INSERT INTO cel_empleado VALUES(" & id & ",'" & Admin.numPhone & "');")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al añadir el Administrador")
        End Try

    End Sub
    Public Sub UpdateAdmin(Admin As Admin)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            con.BeginTrans()

            If Admin.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Admin.dateBirth.ToString("yyy-MM-dd")

            Dim rsUpdateAdmin As Recordset = con.Execute("UPDATE persona SET primerNom='" & Admin.fstName & "',segundoNom='" & Admin.scndName & "',primerApe='" & Admin.fstSurname & "',segundoApe='" & Admin.scndSurname & "',genero='" & genre & "',fechaNacimiento='" & BirthdateString & "',email='" & Admin.email & "',calle='" & Admin.street & "',npuerta=" & Admin.numDoor & ",id_ciudad=" & Admin.city.Id & ",usuario='" & Admin.username & "',contrasena='" & Admin.password & "',pin=" & Admin.pin & " WHERE id=" & Admin.id & ";")
            Dim rsUpdatePhone As Recordset = con.Execute("UPDATE cel_empleado SET celular='" & Admin.numPhone & "' WHERE id_empleado=" & Admin.id & ";")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al modificar el Administrador")
        End Try

    End Sub
    Public Function ObtainMedics() As List(Of Medic)
        Dim con As Connection = Me.Connect()
        Dim ListMedics As New List(Of Medic)

        Try
            Dim rsSelectMedic As Recordset = con.Execute("SELECT * FROM vista_medico;")

            While Not rsSelectMedic.EOF

                Dim id As Integer = DirectCast(rsSelectMedic.Fields("id").Value, Integer)
                Dim ci As Integer = DirectCast(rsSelectMedic.Fields("ci").Value, Integer)
                Dim name1 As String = TryCast(rsSelectMedic.Fields("primerNom").Value, String)
                Dim name2 As String = TryCast(rsSelectMedic.Fields("segundoNom").Value, String)
                Dim surn1 As String = TryCast(rsSelectMedic.Fields("primerApe").Value, String)
                Dim surn2 As String = TryCast(rsSelectMedic.Fields("segundoApe").Value, String)
                Dim genre As String = TryCast(rsSelectMedic.Fields("genero").Value, String)
                Dim birthdate As Date = DirectCast(rsSelectMedic.Fields("fechaNacimiento").Value, Date)
                Dim email As String = TryCast(rsSelectMedic.Fields("email").Value, String)
                Dim street As String = TryCast(rsSelectMedic.Fields("calle").Value, String)
                Dim ndoor As Integer = DirectCast(rsSelectMedic.Fields("npuerta").Value, Integer)
                Dim userSelect As String = TryCast(rsSelectMedic.Fields("usuario").Value, String)
                Dim password As String = TryCast(rsSelectMedic.Fields("contrasena").Value, String)
                Dim speciality As String = TryCast(rsSelectMedic.Fields("especialidad").Value, String)

                Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_medico vm JOIN ciudad c ON(vm.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE vm.id=" & id & ";") 'Consulta para Obtener Departamento y Ciudad

                Dim rsSelectPhones As Recordset = con.Execute("SELECT group_concat(c.celular) As Celulares FROM vista_medico vm LEFT JOIN cel_empleado c ON(vm.id=c.id_empleado) WHERE id_empleado=" & id & ";") 'Consulta para Obtener celulares del Admin

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

                Dim Medic As New Medic(id, ci, name1, name2, surn1, surn2, genrenumber, birthdate, email, Phones, street, ndoor, City, userSelect, password, speciality)
                ListMedics.Add(Medic)
                rsSelectMedic.MoveNext()
                rsSelectCity_Dpto.MoveNext()
                rsSelectPhones.MoveNext()
            End While

            Return ListMedics
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener lista de Médicos")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function LoginMedic(user As String, passwd As String) As Medic
        Dim con As Connection = Me.Connect()
        Try
            Dim rsSelectMedic As Recordset = con.Execute("SELECT * FROM vista_medico WHERE usuario='" & user & "' AND contrasena='" & passwd & "';")

            Dim id As Integer = DirectCast(rsSelectMedic.Fields("id").Value, Integer)
            Dim ci As Integer = DirectCast(rsSelectMedic.Fields("ci").Value, Integer)
            Dim name1 As String = TryCast(rsSelectMedic.Fields("primerNom").Value, String)
            Dim name2 As String = TryCast(rsSelectMedic.Fields("segundoNom").Value, String)
            Dim surn1 As String = TryCast(rsSelectMedic.Fields("primerApe").Value, String)
            Dim surn2 As String = TryCast(rsSelectMedic.Fields("segundoApe").Value, String)
            Dim genre As String = TryCast(rsSelectMedic.Fields("genero").Value, String)
            Dim birthdate As Date = DirectCast(rsSelectMedic.Fields("fechaNacimiento").Value, Date)
            Dim email As String = TryCast(rsSelectMedic.Fields("email").Value, String)
            Dim street As String = TryCast(rsSelectMedic.Fields("calle").Value, String)
            Dim ndoor As Integer = DirectCast(rsSelectMedic.Fields("npuerta").Value, Integer)
            Dim speciality As String = TryCast(rsSelectMedic.Fields("especialidad").Value, String)
            Dim userSelect As String = TryCast(rsSelectMedic.Fields("usuario").Value, String)
            Dim password As String = TryCast(rsSelectMedic.Fields("contrasena").Value, String)

            Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_medico vm JOIN ciudad c ON(vm.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE vm.id=" & id & ";") 'Consulta para Obtener Departamento y Ciudad

            Dim rsSelectPhones As Recordset = con.Execute("SELECT group_concat(c.celular) As Celulares FROM vista_medico vm JOIN cel_empleado c ON(vm.id=c.id_empleado) WHERE vm.id=" & id & ";") 'Consulta para Obtener celulares del Médico

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

            Dim MedicLog As New Medic(id, ci, name1, name2, surn1, surn2, genrenumber, birthdate, email, Phones, street, ndoor, City, userSelect, password, speciality)
            Return MedicLog
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Usuario y/o Contraseña equivocado")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function InfoEmployeeLogged(user As String, passwd As String) As Short
        Dim con As Connection = Me.Connect
        Dim codeMsg As Short = 4
        Dim rsSelectMedic As Recordset

        Try
            rsSelectMedic = con.Execute("SELECT * FROM vista_medico WHERE usuario='" & user & "' AND contrasena='" & passwd & "';")
            If IsNothing(rsSelectMedic) Or rsSelectMedic.EOF Then
                'No se encuentra ningun Empleado con estos campos.
                codeMsg = 4 'Usuario y/o Contraseña erroneos.
            Else
                codeMsg = 2 'Inicio de sesión exitoso.
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Throw New Exception("Error de conexión: " & ex.Message)
            codeMsg = 3 'Error de Conexión.
        Finally
            con.Close()
        End Try

        Return codeMsg
    End Function
    Public Function ObtainMedicsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectMedics As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(vm.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(vm.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email
            FROM vista_medico vm LEFT JOIN cel_empleado c ON(vm.id=c.id_empleado)
            GROUP BY vm.id;")

            da.Fill(ds, rsSelectMedics, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al cargar la tabla de medicos")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Sub AddMedic(Medic As Medic)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            If Medic.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Medic.dateBirth.ToString("yyy-MM-dd")

            Dim rsAddMedic As Recordset = con.Execute("INSERT INTO persona(ci,primerNom,segundoNom,primerApe,segundoApe,genero,fechaNacimiento,email,calle,npuerta,id_ciudad,id_tipo,especialidad,usuario,contrasena) VALUES(" & Medic.ci & ",'" & Medic.fstName & "','" & Medic.scndName & "','" & Medic.fstSurname & "','" & Medic.scndSurname & "','" & genre & "','" & BirthdateString & "','" & Medic.email & "','" & Medic.street & "'," & Medic.numDoor & "," & Medic.city.Id & ",2,'" & Medic.speciality & "','" & Medic.username & "','" & Medic.password & "');")
            Dim rsSelectId As Recordset = con.Execute("SELECT id FROM persona WHERE ci=" & Medic.ci & ";")
            Dim id As Integer = DirectCast(rsSelectId.Fields("id").Value, Integer)

            Dim rsAddPhone As Recordset = con.Execute("INSERT INTO cel_empleado VALUES(" & id & ",'" & Medic.numPhone & "');")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al añadir el Médico")
        End Try

    End Sub
    Public Sub UpdateMedic(Medic As Medic)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            con.BeginTrans()

            If Medic.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Medic.dateBirth.ToString("yyy-MM-dd")

            Dim rsUpdateAdmin As Recordset = con.Execute("UPDATE persona SET primerNom='" & Medic.fstName & "',segundoNom='" & Medic.scndName & "',primerApe='" & Medic.fstSurname & "',segundoApe='" & Medic.scndSurname & "',genero='" & genre & "',fechaNacimiento='" & BirthdateString & "',email='" & Medic.email & "',calle='" & Medic.street & "',npuerta=" & Medic.numDoor & ",id_ciudad=" & Medic.city.Id & ",usuario='" & Medic.username & "',contrasena='" & Medic.password & "',especialidad='" & Medic.speciality & "' WHERE id=" & Medic.id & ";")
            Dim rsUpdatePhone As Recordset = con.Execute("UPDATE cel_empleado SET celular='" & Medic.numPhone & "' WHERE id_empleado=" & Medic.id & ";")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()

            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al modificar el Médico")
        End Try

    End Sub
    Public Sub DeleteMedic(idMedic As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsDeleteMedicCel As Recordset = con.Execute("DELETE FROM cel_empleado WHERE id_empleado=" & idMedic & ";")
            Dim rsDeleteMedicAcceptPeticion As Recordset = con.Execute("DELETE FROM acepta WHERE id_medico=" & idMedic & ";")
            Dim rsDeleteMedicVerifyDiagnostic As Recordset = con.Execute("DELETE FROM verifica WHERE id_medico=" & idMedic & ";")
            Dim rsDeleteMedicChat As Recordset = con.Execute("DELETE FROM conversa WHERE id_persona=" & idMedic & ";")
            Dim rsDeleteMedic As Recordset = con.Execute("DELETE FROM persona WHERE id=" & idMedic & ";")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al eliminar el Médico")
        End Try

    End Sub
    Public Function SearchMedic(Ci As Integer) As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectMedic As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(vm.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(vm.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email
            FROM vista_medico vm LEFT JOIN cel_empleado c ON(vm.id=c.id_empleado)
            GROUP BY vm.id HAVING vm.ci Like '" & Ci & "%';")

            da.Fill(ds, rsSelectMedic, "Search")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al buscar médicos")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function ObtainPatients() As List(Of People)
        Dim con As Connection = Me.Connect()
        Dim ListPatient As New List(Of People)

        Try
            Dim rsSelectPatient As Recordset = con.Execute("SELECT * FROM vista_paciente;")

            While Not rsSelectPatient.EOF

                Dim id As Integer = DirectCast(rsSelectPatient.Fields("id").Value, Integer)
                Dim ci As Integer = DirectCast(rsSelectPatient.Fields("ci").Value, Integer)
                Dim name1 As String = TryCast(rsSelectPatient.Fields("primerNom").Value, String)
                Dim name2 As String = TryCast(rsSelectPatient.Fields("segundoNom").Value, String)
                Dim surn1 As String = TryCast(rsSelectPatient.Fields("primerApe").Value, String)
                Dim surn2 As String = TryCast(rsSelectPatient.Fields("segundoApe").Value, String)
                Dim genre As String = TryCast(rsSelectPatient.Fields("genero").Value, String)
                Dim birthdate As Date = DirectCast(rsSelectPatient.Fields("fechaNacimiento").Value, Date)
                Dim email As String = TryCast(rsSelectPatient.Fields("email").Value, String)
                Dim street As String = TryCast(rsSelectPatient.Fields("calle").Value, String)
                Dim ndoor As Integer = DirectCast(rsSelectPatient.Fields("npuerta").Value, Integer)

                Dim rsSelectCity_Dpto As Recordset = con.Execute("SELECT c.id As Idc,c.nombre As Cnombre,d.id As Idd,d.nombre As Dnombre FROM vista_paciente vp JOIN ciudad c ON(vp.id_ciudad=c.id) JOIN departamento d ON(c.id_dpto=d.id) WHERE vp.id=" & id & ";") 'Consulta para Obtener Departamento y Ciudad

                Dim rsSelectPhones As Recordset = con.Execute("SELECT group_concat(c.celular) As Celulares FROM vista_paciente vp LEFT JOIN cel_paciente c ON(vp.id=c.id_paciente) WHERE id_paciente=" & id & ";") 'Consulta para Obtener celulares del Paciente

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

                Dim Patient As New People(id, ci, name1, name2, surn1, surn2, genrenumber, birthdate, email, Phones, street, ndoor, City)

                ListPatient.Add(Patient)
                rsSelectPatient.MoveNext()
                rsSelectCity_Dpto.MoveNext()
                rsSelectPhones.MoveNext()
            End While

            Return ListPatient
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener lista de Pacientes")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Function ObtainPatientsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectPatients As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(vp.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(vp.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email,habilitado As Habilitado
            FROM vista_paciente vp LEFT JOIN cel_paciente c ON(vp.id=c.id_paciente)
            GROUP BY vp.id;")

            da.Fill(ds, rsSelectPatients, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al cargar la tabla de pacientes")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Sub AddPatient(Patient As People)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            If Patient.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Patient.dateBirth.ToString("yyy-MM-dd")

            Dim rsAddMedic As Recordset = con.Execute("INSERT INTO persona(ci,primerNom,segundoNom,primerApe,segundoApe,genero,fechaNacimiento,email,calle,npuerta,id_ciudad,id_tipo) VALUES(" & Patient.ci & ",'" & Patient.fstName & "','" & Patient.scndName & "','" & Patient.fstSurname & "','" & Patient.scndSurname & "','" & genre & "','" & BirthdateString & "','" & Patient.email & "','" & Patient.street & "'," & Patient.numDoor & "," & Patient.city.Id & ",3);")
            Dim rsSelectId As Recordset = con.Execute("SELECT id FROM persona WHERE ci=" & Patient.ci & ";")
            Dim id As Integer = DirectCast(rsSelectId.Fields("id").Value, Integer)

            Dim rsAddPhone As Recordset = con.Execute("INSERT INTO cel_paciente VALUES(" & id & ",'" & Patient.numPhone & "');")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al añadir el Paciente")
        End Try

    End Sub
    Public Sub UpdatePatient(Patient As People)
        Dim con As Connection = Me.Connect()
        Dim genre As Char = ""

        Try
            con.BeginTrans()

            If Patient.genrePeople = 0 Then
                genre = "H"
            Else
                genre = "M"
            End If
            Dim BirthdateString As String = Patient.dateBirth.ToString("yyy-MM-dd")

            Dim rsUpdateAdmin As Recordset = con.Execute("UPDATE persona SET primerNom='" & Patient.fstName & "',segundoNom='" & Patient.scndName & "',primerApe='" & Patient.fstSurname & "',segundoApe='" & Patient.scndSurname & "',genero='" & genre & "',fechaNacimiento='" & BirthdateString & "',email='" & Patient.email & "',calle='" & Patient.street & "',npuerta=" & Patient.numDoor & ",id_ciudad=" & Patient.city.Id & " WHERE id=" & Patient.id & ";")
            Dim rsUpdatePhone As Recordset = con.Execute("UPDATE cel_paciente SET celular='" & Patient.numPhone & "' WHERE id_paciente=" & Patient.id & ";")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al modificar el Paciente")
        End Try

    End Sub
    Public Sub DeletePatient(idPatient As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsDeletePatientCel As Recordset = con.Execute("DELETE FROM cel_paciente WHERE id_paciente=" & idPatient & ";")
            Dim rsSelectIdPet As Recordset = con.Execute("SELECT id FROM peticion WHERE id_paciente=" & idPatient & ";")
            If Not rsSelectIdPet.EOF Then
                Dim idPet As Integer = DirectCast(rsSelectIdPet.Fields("id").Value, Integer)
                Dim rsDeleteMedicAcceptPet As Recordset = con.Execute("DELETE FROM acepta WHERE id_peticion=" & idPet & ";")
                Dim rsDeletePatientSendPeticion As Recordset = con.Execute("DELETE FROM peticion WHERE id=" & idPet & ";")
            End If
            Dim rsDeletePatientSelectSympt As Recordset = con.Execute("DELETE FROM paciente_sufre WHERE id_paciente=" & idPatient & ";")

            Dim rsSelectIdDiag As Recordset = con.Execute("SELECT id FROM diagnostico WHERE id_paciente=" & idPatient & ";")
            If Not rsSelectIdDiag.EOF Then
                Dim idDiag As Integer = DirectCast(rsSelectIdDiag.Fields("id").Value, Integer)
                Dim rsDeletePatientVerifyDiag As Recordset = con.Execute("DELETE FROM verifica WHERE id_tentativo=" & idDiag & ";")
                Dim rsDeletePatientObtainDiag As Recordset = con.Execute("DELETE FROM diagnostico WHERE id=" & idDiag & ";")
            End If
            Dim rsSelectidPeopleChat As Recordset = con.Execute("SELECT id_persona FROM conversa WHERE id_persona=" & idPatient & ";")
            If Not rsSelectidPeopleChat.EOF Then
                Dim rsDeletePatientChat As Recordset = con.Execute("DELETE FROM conversa WHERE id_persona=" & idPatient & ";")
            End If
            Dim rsDeletePatient As Recordset = con.Execute("DELETE FROM persona WHERE id=" & idPatient & ";")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al eliminar el Paciente")
        End Try

    End Sub
    Public Function SearchPatient(Ci As Integer) As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        Try
            Dim rsSelectPatient As Recordset = con.Execute(
            "SELECT ci As Ci,concat_ws(' ',primerNom, segundoNom, primerApe, segundoApe) As Nombre,
            YEAR(CURDATE())-YEAR(vp.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(vp.fechaNacimiento,'%m-%d'), 0 , -1 ) AS Edad,
            group_concat(c.celular) As Celular, email As Email
            FROM vista_paciente vp LEFT JOIN cel_paciente c ON(vp.id=c.id_paciente)
            GROUP BY vp.id HAVING vp.ci Like '" & Ci & "%';")

            da.Fill(ds, rsSelectPatient, "Search")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al buscar paciente")
        Finally
            con.Close()
        End Try

        Return Nothing
    End Function
    Public Sub AllowPatient(idPatient As Integer)
        Dim con As Connection = Me.Connect()

        Try
            con.BeginTrans()

            Dim rsAllow As Recordset = con.Execute("UPDATE persona SET habilitado=True WHERE id=" & idPatient & ";")

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al habilitar al paciente")
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub DisablePatient(idPatient As Integer)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsDisable As Recordset = con.Execute("UPDATE persona SET habilitado=False WHERE id=" & idPatient & ";")
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al deshabilitar al paciente")
        Finally
            con.Close()
        End Try
    End Sub
    Public Function matchPatientLoggedOn(ci As String) As Integer
        Dim con As Connection = Me.Connect()
        Try
            Dim rsSelectIdPatient As Recordset = con.Execute("SELECT id FROM persona WHERE ci='" + ci + "';")
            Dim idPatientLoggedOn As Integer = DirectCast(rsSelectIdPatient.Fields("id").Value, Integer)
            Return idPatientLoggedOn
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Sub SetPatientSufferSymp(idPatient As Integer, idSympSuffered As List(Of Integer), nowDate As String)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsIsThere As Recordset = con.Execute("SELECT id_sintoma FROM paciente_sufre WHERE id_paciente=" & idPatient)
            If Not rsIsThere.EOF Then
                Dim rsDelete As Recordset = con.Execute("DELETE FROM paciente_sufre WHERE id_paciente=" & idPatient)
                rsIsThere.MoveNext()
            End If

            For Each id As Integer In idSympSuffered
                Dim rsInsert As Recordset = con.Execute("INSERT INTO paciente_sufre(id_sintoma, id_paciente,fecha) VALUES(" & id & "," & idPatient & ",'" & nowDate & "');")
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function ObtainPatholgiesSuffered(idPatient As Integer, DateI As String) As List(Of Pathology)
        Dim con As Connection = Me.Connect()
        Dim Pathologies As New List(Of Pathology)
        Try
            Dim rsPathologiesSuffered As Recordset = con.Execute("SELECT DISTINCT p.id, p.nombre, p.indiceMortalidad, p.id_prioridad FROM paciente_sufre ps JOIN sintoma s ON(ps.id_sintoma = s.id) JOIN sintoma_compone sc ON(s.id = sc.id_sintoma) JOIN patologia p ON(sc.id_patologia = p.id) WHERE ps.id_paciente=" & idPatient & " AND ps.fecha='" + DateI + "' ORDER BY p.indiceMortalidad DESC;")

            While (Not rsPathologiesSuffered.EOF)
                Dim idPathology As Integer = DirectCast(rsPathologiesSuffered.Fields("id").Value, Integer)
                Dim indexMort As Integer = DirectCast(rsPathologiesSuffered.Fields("indiceMortalidad").Value, Integer)
                Dim idPriority As Integer = DirectCast(rsPathologiesSuffered.Fields("id_prioridad").Value, Integer)
                Dim namePathology As String = TryCast(rsPathologiesSuffered.Fields("nombre").Value, String)

                Dim priority As New Priority(idPriority)
                Pathologies.Add(New Pathology(idPathology, namePathology, indexMort, priority))
                rsPathologiesSuffered.MoveNext()
            End While

            Dim idPathEvidenceHigh As Integer = 0
            Dim laMayor As Integer = 0
            Dim fecha As String = Date.Now.ToString("yyy-MM-dd")
            For Each Path As Pathology In Pathologies
                If Path.mortalityIndex > laMayor Then
                    laMayor = Path.mortalityIndex
                    idPathEvidenceHigh = Path.id
                End If
            Next

            Dim rsInsertDiagnostic As Recordset = con.Execute("INSERT INTO diagnostico(id_tipo,id_paciente,id_patologia,fecha) VALUES(1," & idPatient & "," & idPathEvidenceHigh & ",'" & fecha & "');")

            Return Pathologies
        Catch ex As Exception
            Console.WriteLine(ex)
            Throw New Exception(ex.Message)
        Finally
            con.Close()
        End Try
    End Function
    Public Sub UnsuscribePatient(idPatient As Integer)
        Dim con As Connection = Me.Connect
        Try
            con.BeginTrans()

            Dim rsUpdate As Recordset = con.Execute("UPDATE persona SET habilitado='" & 0 & "' WHERE id=" & idPatient)

            con.CommitTrans()
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function ObtainRequestsDataSet() As DataSet
        Dim con As Connection = Me.Connect()
        Dim ds = New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Try
            Dim rsSelectRequestsTable As Recordset = con.Execute("SELECT CONCAT('Prioridad ',prior.nombre) As Prioridad, date(pet.fechaHoraInicio) As Fecha,time(pet.fechaHoraInicio) As Hora,
            CONCAT_WS(' ',pac.primerNom,pac.segundoNom,pac.primerApe,pac.segundoApe) As Nombre,
            CONCAT(year(curdate())-year(pac.fechaNacimiento) + IF(DATE_FORMAT(CURDATE(),'%m-%d') > 
            DATE_FORMAT(pac.fechaNacimiento,'%m-%d'),0,-1),' años') As Edad
            FROM prioridad prior JOIN patologia pat ON(prior.id=pat.id_prioridad) JOIN diagnostico diag
            ON(pat.id=diag.id_patologia) JOIN persona pac ON(diag.id_paciente=pac.id) JOIN peticion pet
            ON(pac.id=pet.id_paciente)
            WHERE pet.estado=True
            GROUP BY pet.id
            ORDER BY prior.id;")
            da.Fill(ds, rsSelectRequestsTable, "Refresh")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener la tabla de peticion")
        Finally
            con.Close()
        End Try

    End Function
    Public Function ObtainRoomMed()
        Dim con As Connection = Me.Connect()
        Dim idRoom As Integer = 0
        Try
            Dim dateToday As String = Date.Now.ToString("yyy-MM-dd")
            Dim hora As Integer = Now.Hour
            Dim rsSelectRoom As Recordset = con.Execute("SELECT s.id FROM salachat s WHERE date(s.fechaHoraInicio)='" & dateToday & "' AND hour(s.fechaHoraInicio) = " & hora & " ORDER BY s.id DESC LIMIT 1;")
            If Not rsSelectRoom.EOF Then
                idRoom = DirectCast(rsSelectRoom.Fields("id").Value, Integer)
            Else
                Throw New Exception("Sala no encontrada")
            End If
            Return idRoom
        Catch ex As Exception
            Throw New Exception("Error al obtener la sala")
        End Try

    End Function
    Public Sub AcceptRequest(idMed As Integer, idPatient As Integer, datetI As String, dateF As String)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsSearchRequest As Recordset = con.Execute("SELECT id FROM peticion WHERE id_paciente=" & idPatient & " AND fechaHoraInicio='" + datetI + "'")
            If rsSearchRequest.EOF Then
                Throw New Exception("No existe la peticion")
            Else
                con.BeginTrans()

                Dim IdRequest As Integer = DirectCast(rsSearchRequest.Fields("id").Value, Integer)
                Dim rsAcceptRequestA As Recordset = con.Execute("UPDATE peticion p SET p.estado=" & 0 & " WHERE p.id=" & IdRequest)
                Dim rsStopPetitionB As Recordset = con.Execute("UPDATE peticion p SET p.motivo='" + "Peticion aceptada" + "' WHERE p.id=" & IdRequest)
                Dim rsStopPetitionC As Recordset = con.Execute("UPDATE peticion p SET p.fechaHoraFin='" + dateF + "' WHERE p.id=" & IdRequest)
                Dim rsInsertAcepta As Recordset = con.Execute("INSERT INTO acepta VALUES(" & idMed & "," & IdRequest & ");")

                con.CommitTrans()
            End If
        Catch ex As Exception
            con.RollbackTrans()
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al aceptar la peticion")
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub WaitingAccept(idPatient As Integer, datetI As String)
        Dim con As Connection = Me.Connect()

        Try
            Dim rsSearchPetition As Recordset = con.Execute("SELECT p.id FROM peticion p WHERE id_paciente=" & idPatient & " AND fechaHoraInicio='" + datetI + "' AND estado=0;")
            If rsSearchPetition.EOF Then
                Throw New Exception("La peticion todavia no fue aceptada")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener las peticiones")
        Finally
            con.Close()
        End Try

    End Sub
    Public Function ObtainTalkingMed(idPatient As Integer, datetI As String) As Medic
        Dim con As Connection = Me.Connect()
        Dim TalkingMed As New Medic()
        Try
            Dim rsSearchPetition As Recordset = con.Execute("SELECT p.id FROM peticion p WHERE id_paciente=" & idPatient & " AND fechaHoraInicio='" + datetI + "' AND estado=0;")
            If rsSearchPetition.EOF Then
                Throw New Exception("La peticion no existe")
            Else
                Dim idRequest As Integer = DirectCast(rsSearchPetition.Fields("id").Value, Integer)
                Dim rsSelectMedicId As Recordset = con.Execute("SELECT ac.id_medico As Id FROM peticion p JOIN acepta ac ON(p.id=ac.id_peticion) WHERE p.id=" & idRequest & ";")
                Dim idMedic As Integer = DirectCast(rsSelectMedicId.Fields("Id").Value, Integer)
                For Each medic As Medic In ObtainMedics()
                    If medic.id = idMedic Then
                        TalkingMed = medic
                    End If
                Next
                Return TalkingMed
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener el médico a charlar")
        Finally
            con.Close()
        End Try

    End Function
    Public Function MakePetition(idPatient As Integer, motive As String, datetI As String, datetF As String) As Boolean
        Dim con As Connection = Me.Connect
        Try
            Dim rsInsertPetition As Recordset = con.Execute("INSERT INTO peticion (id_paciente, estado, fechaHoraInicio) VALUES (" & idPatient & "," & 1 & ",'" + datetI + "')")
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
                con.BeginTrans()

                Dim rsIdPetition As Integer = DirectCast(rsSearchPetition.Fields("id").Value, Integer)
                Dim rsStopPetitionA As Recordset = con.Execute("UPDATE peticion p SET p.estado=" & 0 & " WHERE p.id=" & rsIdPetition)
                Dim rsStopPetitionB As Recordset = con.Execute("UPDATE peticion p SET p.motivo='" + motive + "' WHERE p.id=" & rsIdPetition)
                Dim rsStopPetitionC As Recordset = con.Execute("UPDATE peticion p SET p.fechaHoraFin='" + datetF + "' WHERE p.id=" & rsIdPetition)

                con.CommitTrans()
                Return True
            End If
        Catch ex As Exception
            con.RollbackTrans
            Console.WriteLine(ex)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
    Public Function ObtainCities() As List(Of City)
        Dim con As Connection = Me.Connect()
        Dim ListCitys As New List(Of City)

        Try
            Dim rsSelectCitysDeps As Recordset = con.Execute("SELECT d.id As idDep, d.nombre As nomDep, c.id As idCity, c.nombre As nomCity 
            FROM departamento d JOIN ciudad c ON(d.id=c.id_dpto)")
            While Not rsSelectCitysDeps.EOF
                Dim idDpto As Integer = DirectCast(rsSelectCitysDeps.Fields("idDep").Value, Integer)
                Dim nameDpto As String = TryCast(rsSelectCitysDeps.Fields("nomDep").Value, String)
                Dim Dpto As New Department(idDpto, nameDpto)

                Dim idCity As Integer = DirectCast(rsSelectCitysDeps.Fields("idCity").Value, Integer)
                Dim nameCity As String = TryCast(rsSelectCitysDeps.Fields("nomCity").Value, String)
                Dim City As New City(idCity, Dpto, nameCity)

                ListCitys.Add(City)
                rsSelectCitysDeps.MoveNext()
            End While
            Return ListCitys
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Throw New Exception("Error al obtener las ciudades")
        End Try
        Return Nothing
    End Function

    'Add From CSV
    Public Sub AddSymptomsFromCsv(Symptoms As List(Of Symptom))
        Dim con As Connection = Me.Connect()

        Try
            For Each Sympt As Symptom In Symptoms
                If IsNothing(Sympt.Region) Then
                    Dim rsInsertSympt As Recordset = con.Execute("INSERT INTO sintoma(id_region,descripcion) VALUES(NULL,'" + Sympt.Description + "');")

                Else
                    Dim rsInsertSympt As Recordset = con.Execute("INSERT INTO sintoma(id_region,descripcion) VALUES(" & Sympt.Region.id & ",'" + Sympt.Description + "');")
                End If
            Next
        Catch ex As Exception
            Throw New Exception("Error al añadir síntomas desde archivo csv")
        End Try
    End Sub
    Public Sub AddPathologyFromCsv(Pathologies As List(Of Pathology))
        Dim con As Connection = Me.Connect()

        Try
            For Each Path As Pathology In Pathologies
                Dim rsInsertPath As Recordset = con.Execute("INSERT INTO patologia(id_prioridad,nombre,descripcion,indiceMortalidad,id_tipo) VALUES(" & Path.priority.id & ",'" & Path.name & "','" & Path.description & "'," & Path.mortalityIndex & "," & Path.kind.id & ");")
            Next
        Catch ex As Exception
            Throw New Exception("Error al añadir patologías desde archivo csv")
        End Try
    End Sub


End Class 'DataBaseConn
