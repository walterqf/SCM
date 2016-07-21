Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_empleados


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_empleados as tbl_scm_empleados_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_empleados", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado",ptbl_scm_empleados.Idempleado )
            iCommand.Parameters.AddWithValue("@emp_telefono",ptbl_scm_empleados.Emptelefono )
            iCommand.Parameters.AddWithValue("@emp_primer_nombre",ptbl_scm_empleados.Empprimernombre )
            iCommand.Parameters.AddWithValue("@emp_segundo_nombre",ptbl_scm_empleados.Empsegundonombre )
            iCommand.Parameters.AddWithValue("@emp_primer_apellido",ptbl_scm_empleados.Empprimerapellido )
            iCommand.Parameters.AddWithValue("@emp_segundo_apellido",ptbl_scm_empleados.Empsegundoapellido )
            iCommand.Parameters.AddWithValue("@emp_cargo",ptbl_scm_empleados.Empcargo )
            iCommand.Parameters.AddWithValue("@emp_sueldo",ptbl_scm_empleados.Empsueldo )
            iConnection.Open()
            iCommand.Connection = iConnection
            Try
                iCommand.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try
        End Using
    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_empleados as tbl_scm_empleados_Entity) As tbl_scm_empleados_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_empleados", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure 
                lCommand.Parameters.AddWithValue("@emptelefono", ptbl_scm_empleados.Emptelefono) 
                lCommand.Parameters.AddWithValue("@empprimernombre", ptbl_scm_empleados.Empprimernombre) 
                lCommand.Parameters.AddWithValue("@empsegundonombre", ptbl_scm_empleados.Empsegundonombre) 
                lCommand.Parameters.AddWithValue("@empprimerapellido", ptbl_scm_empleados.Empprimerapellido) 
                lCommand.Parameters.AddWithValue("@empsegundoapellido", ptbl_scm_empleados.Empsegundoapellido) 
                lCommand.Parameters.AddWithValue("@empcargo", ptbl_scm_empleados.Empcargo) 
                lCommand.Parameters.AddWithValue("@empsueldo", ptbl_scm_empleados.Empsueldo) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_empleadosID as Integer = CInt(lReturnValue)
                    ptbl_scm_empleados.idempleado = ltbl_scm_empleadosID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_empleados

    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_empleados As tbl_scm_empleados_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_empleados", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idempleado", ptbl_scm_empleados.idempleado)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_empleados as tbl_scm_empleados_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_empleados", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado", iif(ptbl_scm_empleados.Idempleado = 0, DbNull.Value, ptbl_scm_empleados.Idempleado))
            iCommand.Parameters.AddWithValue("@emp_telefono", iif(ptbl_scm_empleados.Emptelefono is Nothing, DbNull.Value, ptbl_scm_empleados.Emptelefono))
            iCommand.Parameters.AddWithValue("@emp_primer_nombre", iif(ptbl_scm_empleados.Empprimernombre is Nothing, DbNull.Value, ptbl_scm_empleados.Empprimernombre))
            iCommand.Parameters.AddWithValue("@emp_segundo_nombre", iif(ptbl_scm_empleados.Empsegundonombre is Nothing, DbNull.Value, ptbl_scm_empleados.Empsegundonombre))
            iCommand.Parameters.AddWithValue("@emp_primer_apellido", iif(ptbl_scm_empleados.Empprimerapellido is Nothing, DbNull.Value, ptbl_scm_empleados.Empprimerapellido))
            iCommand.Parameters.AddWithValue("@emp_segundo_apellido", iif(ptbl_scm_empleados.Empsegundoapellido is Nothing, DbNull.Value, ptbl_scm_empleados.Empsegundoapellido))
            iCommand.Parameters.AddWithValue("@emp_cargo", iif(ptbl_scm_empleados.Empcargo is Nothing, DbNull.Value, ptbl_scm_empleados.Empcargo))
            iCommand.Parameters.AddWithValue("@emp_sueldo", IIf(ptbl_scm_empleados.Empsueldo = 0, DBNull.Value, ptbl_scm_empleados.Empsueldo))
            Try
                    Dim iDTResult as New DataTable("tbl_scm_empleados")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_empleados as tbl_scm_empleados_Entity) As tbl_scm_empleados_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_empleados", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado", iif(ptbl_scm_empleados.Idempleado = 0, DbNull.Value, ptbl_scm_empleados.Idempleado))
            iCommand.Parameters.AddWithValue("@emp_telefono", iif(ptbl_scm_empleados.Emptelefono is Nothing, DbNull.Value, ptbl_scm_empleados.Emptelefono))
            iCommand.Parameters.AddWithValue("@emp_primer_nombre", iif(ptbl_scm_empleados.Empprimernombre is Nothing, DbNull.Value, ptbl_scm_empleados.Empprimernombre))
            iCommand.Parameters.AddWithValue("@emp_segundo_nombre", iif(ptbl_scm_empleados.Empsegundonombre is Nothing, DbNull.Value, ptbl_scm_empleados.Empsegundonombre))
            iCommand.Parameters.AddWithValue("@emp_primer_apellido", iif(ptbl_scm_empleados.Empprimerapellido is Nothing, DbNull.Value, ptbl_scm_empleados.Empprimerapellido))
            iCommand.Parameters.AddWithValue("@emp_segundo_apellido", iif(ptbl_scm_empleados.Empsegundoapellido is Nothing, DbNull.Value, ptbl_scm_empleados.Empsegundoapellido))
            iCommand.Parameters.AddWithValue("@emp_cargo", iif(ptbl_scm_empleados.Empcargo is Nothing, DbNull.Value, ptbl_scm_empleados.Empcargo))
            iCommand.Parameters.AddWithValue("@emp_sueldo", IIf(ptbl_scm_empleados.Empsueldo = 0, DBNull.Value, ptbl_scm_empleados.Empsueldo))
            Try
                    Dim iDTResult as New DataTable("tbl_scm_empleados")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_empleadosResult As New tbl_scm_empleados_Entity
                    itbl_scm_empleadosResult.Idempleado = IIf(iDTResult.Rows(0)("id_empleado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_empleado"))
                    itbl_scm_empleadosResult.Emptelefono = IIf(iDTResult.Rows(0)("emp_telefono") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_telefono"))
                    itbl_scm_empleadosResult.Empprimernombre = IIf(iDTResult.Rows(0)("emp_primer_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_primer_nombre"))
                    itbl_scm_empleadosResult.Empsegundonombre = IIf(iDTResult.Rows(0)("emp_segundo_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_segundo_nombre"))
                    itbl_scm_empleadosResult.Empprimerapellido = IIf(iDTResult.Rows(0)("emp_primer_apellido") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_primer_apellido"))
                    itbl_scm_empleadosResult.Empsegundoapellido = IIf(iDTResult.Rows(0)("emp_segundo_apellido") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_segundo_apellido"))
                    itbl_scm_empleadosResult.Empcargo = IIf(iDTResult.Rows(0)("emp_cargo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_cargo"))
                    itbl_scm_empleadosResult.Empsueldo = IIf(iDTResult.Rows(0)("emp_sueldo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_sueldo"))

                    Return itbl_scm_empleadosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

