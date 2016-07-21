Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_cliente


    'Derechos reservados     17/07/2016 7:10:02 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_cliente as tbl_scm_cliente_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_cliente", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_cliente",ptbl_scm_cliente.Idcliente )
            iCommand.Parameters.AddWithValue("@cli_primer_nombre",ptbl_scm_cliente.Cliprimernombre )
            iCommand.Parameters.AddWithValue("@cli_segundo_nombre",ptbl_scm_cliente.Clisegundonombre )
            iCommand.Parameters.AddWithValue("@cli_primer_apellido",ptbl_scm_cliente.Cliprimerapellido )
            iCommand.Parameters.AddWithValue("@cli_segundo_apellido",ptbl_scm_cliente.Clisegundoapellido )
            iCommand.Parameters.AddWithValue("@cli_direccion",ptbl_scm_cliente.Clidireccion )
            iCommand.Parameters.AddWithValue("@cli_telefono",ptbl_scm_cliente.Clitelefono )
            iCommand.Parameters.AddWithValue("@cli_nit",ptbl_scm_cliente.Clinit )
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


    'Derechos reservados     17/07/2016 7:10:02 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_cliente as tbl_scm_cliente_Entity) As tbl_scm_cliente_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_cliente", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            lCommand.Parameters.AddWithValue("@cliprimernombre", ptbl_scm_cliente.Cliprimernombre) 
                lCommand.Parameters.AddWithValue("@clisegundonombre", ptbl_scm_cliente.Clisegundonombre) 
                lCommand.Parameters.AddWithValue("@cliprimerapellido", ptbl_scm_cliente.Cliprimerapellido) 
                lCommand.Parameters.AddWithValue("@clisegundoapellido", ptbl_scm_cliente.Clisegundoapellido) 
                lCommand.Parameters.AddWithValue("@clidireccion", ptbl_scm_cliente.Clidireccion) 
                lCommand.Parameters.AddWithValue("@clitelefono", ptbl_scm_cliente.Clitelefono) 
                lCommand.Parameters.AddWithValue("@clinit", IIf(ptbl_scm_cliente.Clinit is nothing, DBNull.Value, ptbl_scm_cliente.Clinit)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_clienteID as Integer = CInt(lReturnValue)
                    ptbl_scm_cliente.idcliente = ltbl_scm_clienteID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_cliente

    End Function


    'Derechos reservados     17/07/2016 7:10:02 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_cliente As tbl_scm_cliente_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_cliente", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idcliente", ptbl_scm_cliente.idcliente)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     17/07/2016 7:10:02 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_cliente as tbl_scm_cliente_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_cliente", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_cliente.Idcliente = 0, DbNull.Value, ptbl_scm_cliente.Idcliente))
            iCommand.Parameters.AddWithValue("@cli_primer_nombre", iif(ptbl_scm_cliente.Cliprimernombre is Nothing, DbNull.Value, ptbl_scm_cliente.Cliprimernombre))
            iCommand.Parameters.AddWithValue("@cli_segundo_nombre", iif(ptbl_scm_cliente.Clisegundonombre is Nothing, DbNull.Value, ptbl_scm_cliente.Clisegundonombre))
            iCommand.Parameters.AddWithValue("@cli_primer_apellido", iif(ptbl_scm_cliente.Cliprimerapellido is Nothing, DbNull.Value, ptbl_scm_cliente.Cliprimerapellido))
            iCommand.Parameters.AddWithValue("@cli_segundo_apellido", iif(ptbl_scm_cliente.Clisegundoapellido is Nothing, DbNull.Value, ptbl_scm_cliente.Clisegundoapellido))
            iCommand.Parameters.AddWithValue("@cli_direccion", iif(ptbl_scm_cliente.Clidireccion is Nothing, DbNull.Value, ptbl_scm_cliente.Clidireccion))
            iCommand.Parameters.AddWithValue("@cli_telefono", iif(ptbl_scm_cliente.Clitelefono is Nothing, DbNull.Value, ptbl_scm_cliente.Clitelefono))
            iCommand.Parameters.AddWithValue("@cli_nit", iif(ptbl_scm_cliente.Clinit is Nothing, DbNull.Value, ptbl_scm_cliente.Clinit))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_cliente")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     17/07/2016 7:10:02 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_cliente as tbl_scm_cliente_Entity) As tbl_scm_cliente_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_cliente", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_cliente.Idcliente = 0, DbNull.Value, ptbl_scm_cliente.Idcliente))
            iCommand.Parameters.AddWithValue("@cli_primer_nombre", iif(ptbl_scm_cliente.Cliprimernombre is Nothing, DbNull.Value, ptbl_scm_cliente.Cliprimernombre))
            iCommand.Parameters.AddWithValue("@cli_segundo_nombre", iif(ptbl_scm_cliente.Clisegundonombre is Nothing, DbNull.Value, ptbl_scm_cliente.Clisegundonombre))
            iCommand.Parameters.AddWithValue("@cli_primer_apellido", iif(ptbl_scm_cliente.Cliprimerapellido is Nothing, DbNull.Value, ptbl_scm_cliente.Cliprimerapellido))
            iCommand.Parameters.AddWithValue("@cli_segundo_apellido", iif(ptbl_scm_cliente.Clisegundoapellido is Nothing, DbNull.Value, ptbl_scm_cliente.Clisegundoapellido))
            iCommand.Parameters.AddWithValue("@cli_direccion", iif(ptbl_scm_cliente.Clidireccion is Nothing, DbNull.Value, ptbl_scm_cliente.Clidireccion))
            iCommand.Parameters.AddWithValue("@cli_telefono", iif(ptbl_scm_cliente.Clitelefono is Nothing, DbNull.Value, ptbl_scm_cliente.Clitelefono))
            iCommand.Parameters.AddWithValue("@cli_nit", iif(ptbl_scm_cliente.Clinit is Nothing, DbNull.Value, ptbl_scm_cliente.Clinit))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_cliente")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_clienteResult As New tbl_scm_cliente_Entity
                    itbl_scm_clienteResult.Idcliente = IIf(iDTResult.Rows(0)("id_cliente") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_cliente"))
                    itbl_scm_clienteResult.Cliprimernombre = IIf(iDTResult.Rows(0)("cli_primer_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_primer_nombre"))
                    itbl_scm_clienteResult.Clisegundonombre = IIf(iDTResult.Rows(0)("cli_segundo_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_segundo_nombre"))
                    itbl_scm_clienteResult.Cliprimerapellido = IIf(iDTResult.Rows(0)("cli_primer_apellido") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_primer_apellido"))
                    itbl_scm_clienteResult.Clisegundoapellido = IIf(iDTResult.Rows(0)("cli_segundo_apellido") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_segundo_apellido"))
                    itbl_scm_clienteResult.Clidireccion = IIf(iDTResult.Rows(0)("cli_direccion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_direccion"))
                    itbl_scm_clienteResult.Clitelefono = IIf(iDTResult.Rows(0)("cli_telefono") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_telefono"))
                    itbl_scm_clienteResult.Clinit = IIf(iDTResult.Rows(0)("cli_nit") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cli_nit"))

                    Return itbl_scm_clienteResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

