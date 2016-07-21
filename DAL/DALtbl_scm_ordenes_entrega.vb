Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_ordenes_entrega


    'Derechos reservados     20/07/2016 1:15:00 a. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_ordenes_entrega", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_entrega",ptbl_scm_ordenes_entrega.Idordenesentrega )
            iCommand.Parameters.AddWithValue("@ord_descripcion",ptbl_scm_ordenes_entrega.Orddescripcion )
            iCommand.Parameters.AddWithValue("@id_orden",ptbl_scm_ordenes_entrega.Idorden )
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden",ptbl_scm_ordenes_entrega.Idscmestadoorden )
            iCommand.Parameters.AddWithValue("@id_cliente",ptbl_scm_ordenes_entrega.Idcliente )
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


    'Derechos reservados     20/07/2016 1:15:00 a. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) As tbl_scm_ordenes_entrega_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_ordenes_entrega", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@orddescripcion", ptbl_scm_ordenes_entrega.Orddescripcion) 
                lCommand.Parameters.AddWithValue("@idorden", IIf(ptbl_scm_ordenes_entrega.Idorden is nothing, DBNull.Value, ptbl_scm_ordenes_entrega.Idorden)) 
                lCommand.Parameters.AddWithValue("@idscmestadoorden", IIf(ptbl_scm_ordenes_entrega.Idscmestadoorden is nothing, DBNull.Value, ptbl_scm_ordenes_entrega.Idscmestadoorden)) 
                lCommand.Parameters.AddWithValue("@idcliente", IIf(ptbl_scm_ordenes_entrega.Idcliente is nothing, DBNull.Value, ptbl_scm_ordenes_entrega.Idcliente)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_ordenes_entregaID as Integer = CInt(lReturnValue)
                    ptbl_scm_ordenes_entrega.idordenesentrega = ltbl_scm_ordenes_entregaID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_ordenes_entrega

    End Function


    'Derechos reservados     20/07/2016 1:15:00 a. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega As tbl_scm_ordenes_entrega_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_ordenes_entrega", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idordenesentrega", ptbl_scm_ordenes_entrega.idordenesentrega)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_ordenes_entrega", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_ordenes_entrega.Idordenesentrega = 0, DbNull.Value, ptbl_scm_ordenes_entrega.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@ord_descripcion", iif(ptbl_scm_ordenes_entrega.Orddescripcion is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Orddescripcion))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_scm_ordenes_entrega.Idorden is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idorden))
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_ordenes_entrega.Idscmestadoorden is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_ordenes_entrega.Idcliente is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idcliente))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_ordenes_entrega")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) As tbl_scm_ordenes_entrega_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_ordenes_entrega", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_ordenes_entrega.Idordenesentrega = 0, DbNull.Value, ptbl_scm_ordenes_entrega.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@ord_descripcion", iif(ptbl_scm_ordenes_entrega.Orddescripcion is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Orddescripcion))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_scm_ordenes_entrega.Idorden is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idorden))
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_ordenes_entrega.Idscmestadoorden is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_ordenes_entrega.Idcliente is Nothing, DbNull.Value, ptbl_scm_ordenes_entrega.Idcliente))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_ordenes_entrega")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_ordenes_entregaResult As New tbl_scm_ordenes_entrega_Entity
                    itbl_scm_ordenes_entregaResult.Idordenesentrega = IIf(iDTResult.Rows(0)("id_ordenes_entrega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ordenes_entrega"))
                    itbl_scm_ordenes_entregaResult.Orddescripcion = IIf(iDTResult.Rows(0)("ord_descripcion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("ord_descripcion"))
                    itbl_scm_ordenes_entregaResult.Idorden = IIf(iDTResult.Rows(0)("id_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden"))
                    itbl_scm_ordenes_entregaResult.Idscmestadoorden = IIf(iDTResult.Rows(0)("id_scm_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_scm_estado_orden"))
                    itbl_scm_ordenes_entregaResult.Idcliente = IIf(iDTResult.Rows(0)("id_cliente") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_cliente"))

                    Return itbl_scm_ordenes_entregaResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

