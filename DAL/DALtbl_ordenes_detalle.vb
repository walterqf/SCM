Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_ordenes_detalle


    'Derechos reservados  12/07/2016 18:01:33
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_ordenes_detalle", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_detalle",ptbl_ordenes_detalle.Idordenesdetalle )
            iCommand.Parameters.AddWithValue("@costo_unitario_producto",ptbl_ordenes_detalle.Costounitarioproducto )
            iCommand.Parameters.AddWithValue("@cantidad_producto",ptbl_ordenes_detalle.Cantidadproducto )
            iCommand.Parameters.AddWithValue("@tipo_cambio",ptbl_ordenes_detalle.Tipocambio )
            iCommand.Parameters.AddWithValue("@id_orden",ptbl_ordenes_detalle.Idorden )
            iCommand.Parameters.AddWithValue("@id_moneda",ptbl_ordenes_detalle.Idmoneda )
            iCommand.Parameters.AddWithValue("@id_producto",ptbl_ordenes_detalle.Idproducto )
            iCommand.Parameters.AddWithValue("@id_bodega",ptbl_ordenes_detalle.Idbodega )
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


    'Derechos reservados  12/07/2016 18:01:33
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) As tbl_ordenes_detalle_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_ordenes_detalle", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            ' lCommand.Parameters.AddWithValue("@idordenesdetalle", ptbl_ordenes_detalle.Idordenesdetalle) 
            lCommand.Parameters.AddWithValue("@costounitarioproducto", ptbl_ordenes_detalle.Costounitarioproducto) 
                lCommand.Parameters.AddWithValue("@cantidadproducto", ptbl_ordenes_detalle.Cantidadproducto) 
                lCommand.Parameters.AddWithValue("@tipocambio", ptbl_ordenes_detalle.Tipocambio) 
                lCommand.Parameters.AddWithValue("@idorden", ptbl_ordenes_detalle.Idorden) 
                lCommand.Parameters.AddWithValue("@idmoneda", ptbl_ordenes_detalle.Idmoneda) 
                lCommand.Parameters.AddWithValue("@idproducto", ptbl_ordenes_detalle.Idproducto) 
                lCommand.Parameters.AddWithValue("@idbodega", ptbl_ordenes_detalle.Idbodega) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_ordenes_detalleID as Integer = CInt(lReturnValue)
                    ptbl_ordenes_detalle.idordenesdetalle = ltbl_ordenes_detalleID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_ordenes_detalle

    End Function


    'Derechos reservados  12/07/2016 18:01:33
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle As tbl_ordenes_detalle_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_ordenes_detalle", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idordenesdetalle", ptbl_ordenes_detalle.idordenesdetalle)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados  12/07/2016 18:01:33
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_ordenes_detalle", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_detalle", iif(ptbl_ordenes_detalle.Idordenesdetalle = 0, DbNull.Value, ptbl_ordenes_detalle.Idordenesdetalle))
            iCommand.Parameters.AddWithValue("@costo_unitario_producto", IIf(ptbl_ordenes_detalle.Costounitarioproducto = 0, DBNull.Value, ptbl_ordenes_detalle.Costounitarioproducto))
            iCommand.Parameters.AddWithValue("@cantidad_producto", iif(ptbl_ordenes_detalle.Cantidadproducto = 0, DbNull.Value, ptbl_ordenes_detalle.Cantidadproducto))
            iCommand.Parameters.AddWithValue("@tipo_cambio", IIf(ptbl_ordenes_detalle.Tipocambio = 0, DBNull.Value, ptbl_ordenes_detalle.Tipocambio))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_ordenes_detalle.Idorden = 0, DbNull.Value, ptbl_ordenes_detalle.Idorden))
            iCommand.Parameters.AddWithValue("@id_moneda", iif(ptbl_ordenes_detalle.Idmoneda = 0, DbNull.Value, ptbl_ordenes_detalle.Idmoneda))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_ordenes_detalle.Idproducto = 0, DbNull.Value, ptbl_ordenes_detalle.Idproducto))
            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_ordenes_detalle.Idbodega = 0, DbNull.Value, ptbl_ordenes_detalle.Idbodega))
                Try
                    Dim iDTResult as New DataTable("tbl_ordenes_detalle")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados  12/07/2016 18:01:33
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_detalle as tbl_ordenes_detalle_Entity) As tbl_ordenes_detalle_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_ordenes_detalle", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ordenes_detalle", iif(ptbl_ordenes_detalle.Idordenesdetalle = 0, DbNull.Value, ptbl_ordenes_detalle.Idordenesdetalle))
            iCommand.Parameters.AddWithValue("@costo_unitario_producto", IIf(ptbl_ordenes_detalle.Costounitarioproducto = 0, DBNull.Value, ptbl_ordenes_detalle.Costounitarioproducto))
            iCommand.Parameters.AddWithValue("@cantidad_producto", iif(ptbl_ordenes_detalle.Cantidadproducto = 0, DbNull.Value, ptbl_ordenes_detalle.Cantidadproducto))
            iCommand.Parameters.AddWithValue("@tipo_cambio", IIf(ptbl_ordenes_detalle.Tipocambio = 0, DBNull.Value, ptbl_ordenes_detalle.Tipocambio))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_ordenes_detalle.Idorden = 0, DbNull.Value, ptbl_ordenes_detalle.Idorden))
            iCommand.Parameters.AddWithValue("@id_moneda", iif(ptbl_ordenes_detalle.Idmoneda = 0, DbNull.Value, ptbl_ordenes_detalle.Idmoneda))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_ordenes_detalle.Idproducto = 0, DbNull.Value, ptbl_ordenes_detalle.Idproducto))
            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_ordenes_detalle.Idbodega = 0, DbNull.Value, ptbl_ordenes_detalle.Idbodega))
                Try
                    Dim iDTResult as New DataTable("tbl_ordenes_detalle")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_ordenes_detalleResult As New tbl_ordenes_detalle_Entity
                    itbl_ordenes_detalleResult.Idordenesdetalle = IIf(iDTResult.Rows(0)("id_ordenes_detalle") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ordenes_detalle"))
                    itbl_ordenes_detalleResult.Costounitarioproducto = IIf(iDTResult.Rows(0)("costo_unitario_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("costo_unitario_producto"))
                    itbl_ordenes_detalleResult.Cantidadproducto = IIf(iDTResult.Rows(0)("cantidad_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cantidad_producto"))
                    itbl_ordenes_detalleResult.Tipocambio = IIf(iDTResult.Rows(0)("tipo_cambio") Is DBNull.Value, Nothing, iDTResult.Rows(0)("tipo_cambio"))
                    itbl_ordenes_detalleResult.Idorden = IIf(iDTResult.Rows(0)("id_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden"))
                    itbl_ordenes_detalleResult.Idmoneda = IIf(iDTResult.Rows(0)("id_moneda") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_moneda"))
                    itbl_ordenes_detalleResult.Idproducto = IIf(iDTResult.Rows(0)("id_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_producto"))
                    itbl_ordenes_detalleResult.Idbodega = IIf(iDTResult.Rows(0)("id_bodega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_bodega"))

                    Return itbl_ordenes_detalleResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

