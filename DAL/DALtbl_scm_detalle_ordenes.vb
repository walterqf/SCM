Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_detalle_ordenes


    'Derechos reservados     14/07/2016 6:44:05 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_detalle_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_detalle_ordenes",ptbl_scm_detalle_ordenes.Iddetalleordenes )
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega",ptbl_scm_detalle_ordenes.Idordenesentrega )
            iCommand.Parameters.AddWithValue("@det_costo_total",ptbl_scm_detalle_ordenes.Detcostototal )
            iCommand.Parameters.AddWithValue("@id_ruta",ptbl_scm_detalle_ordenes.Idruta )
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden",ptbl_scm_detalle_ordenes.Idscmestadoorden )
            iCommand.Parameters.AddWithValue("@id_cliente",ptbl_scm_detalle_ordenes.Idcliente )
            iCommand.Parameters.AddWithValue("@det_cantidad_producto",ptbl_scm_detalle_ordenes.Detcantidadproducto )
            iCommand.Parameters.AddWithValue("@det_fecha_solicitud",ptbl_scm_detalle_ordenes.Detfechasolicitud )
            iCommand.Parameters.AddWithValue("@det_fecha_entrega",ptbl_scm_detalle_ordenes.Detfechaentrega )
            iCommand.Parameters.AddWithValue("@id_producto",ptbl_scm_detalle_ordenes.Idproducto )
            iCommand.Parameters.AddWithValue("@det_volumen_peso",ptbl_scm_detalle_ordenes.Detvolumenpeso )
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


    'Derechos reservados     14/07/2016 6:44:05 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) As tbl_scm_detalle_ordenes_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_detalle_ordenes", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            lCommand.Parameters.AddWithValue("@idordenesentrega", ptbl_scm_detalle_ordenes.Idordenesentrega) 
                lCommand.Parameters.AddWithValue("@detcostototal", ptbl_scm_detalle_ordenes.Detcostototal) 
                lCommand.Parameters.AddWithValue("@idruta", ptbl_scm_detalle_ordenes.Idruta) 
                lCommand.Parameters.AddWithValue("@idscmestadoorden", ptbl_scm_detalle_ordenes.Idscmestadoorden) 
                lCommand.Parameters.AddWithValue("@idcliente", ptbl_scm_detalle_ordenes.Idcliente) 
                lCommand.Parameters.AddWithValue("@detcantidadproducto", ptbl_scm_detalle_ordenes.Detcantidadproducto) 
                lCommand.Parameters.AddWithValue("@detfechasolicitud", ptbl_scm_detalle_ordenes.Detfechasolicitud) 
                lCommand.Parameters.AddWithValue("@detfechaentrega", IIf(ptbl_scm_detalle_ordenes.Detfechaentrega is nothing, DBNull.Value, ptbl_scm_detalle_ordenes.Detfechaentrega)) 
                lCommand.Parameters.AddWithValue("@idproducto", IIf(ptbl_scm_detalle_ordenes.Idproducto is nothing, DBNull.Value, ptbl_scm_detalle_ordenes.Idproducto)) 
                lCommand.Parameters.AddWithValue("@detvolumenpeso", IIf(ptbl_scm_detalle_ordenes.Detvolumenpeso is nothing, DBNull.Value, ptbl_scm_detalle_ordenes.Detvolumenpeso)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_detalle_ordenesID as Integer = CInt(lReturnValue)
                    ptbl_scm_detalle_ordenes.iddetalleordenes = ltbl_scm_detalle_ordenesID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_detalle_ordenes

    End Function


    'Derechos reservados     14/07/2016 6:44:06 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes As tbl_scm_detalle_ordenes_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_detalle_ordenes", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@iddetalleordenes", ptbl_scm_detalle_ordenes.iddetalleordenes)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     14/07/2016 6:44:06 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_detalle_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_detalle_ordenes", iif(ptbl_scm_detalle_ordenes.Iddetalleordenes = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Iddetalleordenes))
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_detalle_ordenes.Idordenesentrega = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@det_costo_total", IIf(ptbl_scm_detalle_ordenes.Detcostototal = 0, DBNull.Value, ptbl_scm_detalle_ordenes.Detcostototal))
            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_detalle_ordenes.Idruta = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idruta))
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_detalle_ordenes.Idscmestadoorden = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_detalle_ordenes.Idcliente = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idcliente))
            iCommand.Parameters.AddWithValue("@det_cantidad_producto", iif(ptbl_scm_detalle_ordenes.Detcantidadproducto is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detcantidadproducto))
            iCommand.Parameters.AddWithValue("@det_fecha_solicitud", iif(ptbl_scm_detalle_ordenes.Detfechasolicitud is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detfechasolicitud))
            iCommand.Parameters.AddWithValue("@det_fecha_entrega", iif(ptbl_scm_detalle_ordenes.Detfechaentrega is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detfechaentrega))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_scm_detalle_ordenes.Idproducto is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Idproducto))
            iCommand.Parameters.AddWithValue("@det_volumen_peso", iif(ptbl_scm_detalle_ordenes.Detvolumenpeso is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detvolumenpeso))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_detalle_ordenes")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     14/07/2016 6:44:06 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) As tbl_scm_detalle_ordenes_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_detalle_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_detalle_ordenes", iif(ptbl_scm_detalle_ordenes.Iddetalleordenes = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Iddetalleordenes))
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_detalle_ordenes.Idordenesentrega = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@det_costo_total", iif(ptbl_scm_detalle_ordenes.Detcostototal =0, DbNull.Value, ptbl_scm_detalle_ordenes.Detcostototal))
            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_detalle_ordenes.Idruta = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idruta))
            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_detalle_ordenes.Idscmestadoorden = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_detalle_ordenes.Idcliente = 0, DbNull.Value, ptbl_scm_detalle_ordenes.Idcliente))
            iCommand.Parameters.AddWithValue("@det_cantidad_producto", iif(ptbl_scm_detalle_ordenes.Detcantidadproducto is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detcantidadproducto))
            iCommand.Parameters.AddWithValue("@det_fecha_solicitud", iif(ptbl_scm_detalle_ordenes.Detfechasolicitud is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detfechasolicitud))
            iCommand.Parameters.AddWithValue("@det_fecha_entrega", iif(ptbl_scm_detalle_ordenes.Detfechaentrega is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detfechaentrega))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_scm_detalle_ordenes.Idproducto is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Idproducto))
            iCommand.Parameters.AddWithValue("@det_volumen_peso", iif(ptbl_scm_detalle_ordenes.Detvolumenpeso is Nothing, DbNull.Value, ptbl_scm_detalle_ordenes.Detvolumenpeso))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_detalle_ordenes")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_detalle_ordenesResult As New tbl_scm_detalle_ordenes_Entity
                    itbl_scm_detalle_ordenesResult.Iddetalleordenes = IIf(iDTResult.Rows(0)("id_detalle_ordenes") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_detalle_ordenes"))
                    itbl_scm_detalle_ordenesResult.Idordenesentrega = IIf(iDTResult.Rows(0)("id_ordenes_entrega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ordenes_entrega"))
                    itbl_scm_detalle_ordenesResult.Detcostototal = IIf(iDTResult.Rows(0)("det_costo_total") Is DBNull.Value, Nothing, iDTResult.Rows(0)("det_costo_total"))
                    itbl_scm_detalle_ordenesResult.Idruta = IIf(iDTResult.Rows(0)("id_ruta") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ruta"))
                    itbl_scm_detalle_ordenesResult.Idscmestadoorden = IIf(iDTResult.Rows(0)("id_scm_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_scm_estado_orden"))
                    itbl_scm_detalle_ordenesResult.Idcliente = IIf(iDTResult.Rows(0)("id_cliente") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_cliente"))
                    itbl_scm_detalle_ordenesResult.Detcantidadproducto = IIf(iDTResult.Rows(0)("det_cantidad_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("det_cantidad_producto"))
                    itbl_scm_detalle_ordenesResult.Detfechasolicitud = IIf(iDTResult.Rows(0)("det_fecha_solicitud") Is DBNull.Value, Nothing, iDTResult.Rows(0)("det_fecha_solicitud"))
                    itbl_scm_detalle_ordenesResult.Detfechaentrega = IIf(iDTResult.Rows(0)("det_fecha_entrega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("det_fecha_entrega"))
                    itbl_scm_detalle_ordenesResult.Idproducto = IIf(iDTResult.Rows(0)("id_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_producto"))
                    itbl_scm_detalle_ordenesResult.Detvolumenpeso = IIf(iDTResult.Rows(0)("det_volumen_peso") Is DBNull.Value, Nothing, iDTResult.Rows(0)("det_volumen_peso"))

                    Return itbl_scm_detalle_ordenesResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

