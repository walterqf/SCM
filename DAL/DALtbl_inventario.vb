Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_inventario


    'Derechos reservados   12/07/2016 19:26:33
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_inventario", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_inventario",ptbl_inventario.Idinventario )
            iCommand.Parameters.AddWithValue("@costo_unitario_producto",ptbl_inventario.Costounitarioproducto )
            iCommand.Parameters.AddWithValue("@tipo_cambio",ptbl_inventario.Tipocambio )
            iCommand.Parameters.AddWithValue("@id_orden",ptbl_inventario.Idorden )
            iCommand.Parameters.AddWithValue("@cantidad_producto",ptbl_inventario.Cantidadproducto )
            iCommand.Parameters.AddWithValue("@cantidad_real",ptbl_inventario.Cantidadreal )
            iCommand.Parameters.AddWithValue("@id_bodega",ptbl_inventario.Idbodega )
            iCommand.Parameters.AddWithValue("@cantidad_actual",ptbl_inventario.Cantidadactual )
            iCommand.Parameters.AddWithValue("@producto_minimo",ptbl_inventario.Productominimo )
            iCommand.Parameters.AddWithValue("@producto_maximo",ptbl_inventario.Productomaximo )
            iCommand.Parameters.AddWithValue("@producto_optimo",ptbl_inventario.Productooptimo )
            iCommand.Parameters.AddWithValue("@id_usuario",ptbl_inventario.Idusuario )
            iCommand.Parameters.AddWithValue("@id_producto",ptbl_inventario.Idproducto )
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


    'Derechos reservados   12/07/2016 19:26:33
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) As tbl_inventario_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_inventario", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idinventario", ptbl_inventario.Idinventario) 
            lCommand.Parameters.AddWithValue("@costounitarioproducto", ptbl_inventario.Costounitarioproducto) 
                lCommand.Parameters.AddWithValue("@tipocambio", ptbl_inventario.Tipocambio) 
                lCommand.Parameters.AddWithValue("@idorden", ptbl_inventario.Idorden) 
                lCommand.Parameters.AddWithValue("@cantidadproducto", ptbl_inventario.Cantidadproducto) 
                lCommand.Parameters.AddWithValue("@cantidadreal", ptbl_inventario.Cantidadreal) 
                lCommand.Parameters.AddWithValue("@idbodega", ptbl_inventario.Idbodega) 
                lCommand.Parameters.AddWithValue("@cantidadactual", ptbl_inventario.Cantidadactual) 
                lCommand.Parameters.AddWithValue("@productominimo", ptbl_inventario.Productominimo) 
                lCommand.Parameters.AddWithValue("@productomaximo", ptbl_inventario.Productomaximo) 
                lCommand.Parameters.AddWithValue("@productooptimo", ptbl_inventario.Productooptimo) 
                lCommand.Parameters.AddWithValue("@idusuario", ptbl_inventario.Idusuario) 
                lCommand.Parameters.AddWithValue("@idproducto", ptbl_inventario.Idproducto) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_inventarioID as Integer = CInt(lReturnValue)
                    ptbl_inventario.idinventario = ltbl_inventarioID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_inventario

    End Function


    'Derechos reservados   12/07/2016 19:26:33
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario As tbl_inventario_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_inventario", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idinventario", ptbl_inventario.idinventario)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   12/07/2016 19:26:33
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_inventario", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_inventario", iif(ptbl_inventario.Idinventario = 0, DbNull.Value, ptbl_inventario.Idinventario))
            iCommand.Parameters.AddWithValue("@costo_unitario_producto", IIf(ptbl_inventario.Costounitarioproducto = 0, DBNull.Value, ptbl_inventario.Costounitarioproducto))
            iCommand.Parameters.AddWithValue("@tipo_cambio", IIf(ptbl_inventario.Tipocambio = 0, DBNull.Value, ptbl_inventario.Tipocambio))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_inventario.Idorden = 0, DbNull.Value, ptbl_inventario.Idorden))
            iCommand.Parameters.AddWithValue("@cantidad_producto", iif(ptbl_inventario.Cantidadproducto = 0, DbNull.Value, ptbl_inventario.Cantidadproducto))
            iCommand.Parameters.AddWithValue("@cantidad_real", iif(ptbl_inventario.Cantidadreal = 0, DbNull.Value, ptbl_inventario.Cantidadreal))
            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_inventario.Idbodega = 0, DbNull.Value, ptbl_inventario.Idbodega))
            iCommand.Parameters.AddWithValue("@cantidad_actual", iif(ptbl_inventario.Cantidadactual = 0, DbNull.Value, ptbl_inventario.Cantidadactual))
            iCommand.Parameters.AddWithValue("@producto_minimo", iif(ptbl_inventario.Productominimo = 0, DbNull.Value, ptbl_inventario.Productominimo))
            iCommand.Parameters.AddWithValue("@producto_maximo", iif(ptbl_inventario.Productomaximo = 0, DbNull.Value, ptbl_inventario.Productomaximo))
            iCommand.Parameters.AddWithValue("@producto_optimo", iif(ptbl_inventario.Productooptimo = 0, DbNull.Value, ptbl_inventario.Productooptimo))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_inventario.Idusuario = 0, DbNull.Value, ptbl_inventario.Idusuario))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_inventario.Idproducto = 0, DbNull.Value, ptbl_inventario.Idproducto))
                Try
                    Dim iDTResult as New DataTable("tbl_inventario")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados   12/07/2016 19:26:33
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_inventario as tbl_inventario_Entity) As tbl_inventario_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_inventario", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_inventario", iif(ptbl_inventario.Idinventario = 0, DbNull.Value, ptbl_inventario.Idinventario))
            iCommand.Parameters.AddWithValue("@costo_unitario_producto", IIf(ptbl_inventario.Costounitarioproducto = 0, DBNull.Value, ptbl_inventario.Costounitarioproducto))
            iCommand.Parameters.AddWithValue("@tipo_cambio", IIf(ptbl_inventario.Tipocambio = 0, DBNull.Value, ptbl_inventario.Tipocambio))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_inventario.Idorden = 0, DbNull.Value, ptbl_inventario.Idorden))
            iCommand.Parameters.AddWithValue("@cantidad_producto", iif(ptbl_inventario.Cantidadproducto = 0, DbNull.Value, ptbl_inventario.Cantidadproducto))
            iCommand.Parameters.AddWithValue("@cantidad_real", iif(ptbl_inventario.Cantidadreal = 0, DbNull.Value, ptbl_inventario.Cantidadreal))
            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_inventario.Idbodega = 0, DbNull.Value, ptbl_inventario.Idbodega))
            iCommand.Parameters.AddWithValue("@cantidad_actual", iif(ptbl_inventario.Cantidadactual = 0, DbNull.Value, ptbl_inventario.Cantidadactual))
            iCommand.Parameters.AddWithValue("@producto_minimo", iif(ptbl_inventario.Productominimo = 0, DbNull.Value, ptbl_inventario.Productominimo))
            iCommand.Parameters.AddWithValue("@producto_maximo", iif(ptbl_inventario.Productomaximo = 0, DbNull.Value, ptbl_inventario.Productomaximo))
            iCommand.Parameters.AddWithValue("@producto_optimo", iif(ptbl_inventario.Productooptimo = 0, DbNull.Value, ptbl_inventario.Productooptimo))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_inventario.Idusuario = 0, DbNull.Value, ptbl_inventario.Idusuario))
            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_inventario.Idproducto = 0, DbNull.Value, ptbl_inventario.Idproducto))
                Try
                    Dim iDTResult as New DataTable("tbl_inventario")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_inventarioResult As New tbl_inventario_Entity
                    itbl_inventarioResult.Idinventario = IIf(iDTResult.Rows(0)("id_inventario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_inventario"))
                    itbl_inventarioResult.Costounitarioproducto = IIf(iDTResult.Rows(0)("costo_unitario_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("costo_unitario_producto"))
                    itbl_inventarioResult.Tipocambio = IIf(iDTResult.Rows(0)("tipo_cambio") Is DBNull.Value, Nothing, iDTResult.Rows(0)("tipo_cambio"))
                    itbl_inventarioResult.Idorden = IIf(iDTResult.Rows(0)("id_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden"))
                    itbl_inventarioResult.Cantidadproducto = IIf(iDTResult.Rows(0)("cantidad_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cantidad_producto"))
                    itbl_inventarioResult.Cantidadreal = IIf(iDTResult.Rows(0)("cantidad_real") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cantidad_real"))
                    itbl_inventarioResult.Idbodega = IIf(iDTResult.Rows(0)("id_bodega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_bodega"))
                    itbl_inventarioResult.Cantidadactual = IIf(iDTResult.Rows(0)("cantidad_actual") Is DBNull.Value, Nothing, iDTResult.Rows(0)("cantidad_actual"))
                    itbl_inventarioResult.Productominimo = IIf(iDTResult.Rows(0)("producto_minimo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("producto_minimo"))
                    itbl_inventarioResult.Productomaximo = IIf(iDTResult.Rows(0)("producto_maximo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("producto_maximo"))
                    itbl_inventarioResult.Productooptimo = IIf(iDTResult.Rows(0)("producto_optimo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("producto_optimo"))
                    itbl_inventarioResult.Idusuario = IIf(iDTResult.Rows(0)("id_usuario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_usuario"))
                    itbl_inventarioResult.Idproducto = IIf(iDTResult.Rows(0)("id_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_producto"))

                    Return itbl_inventarioResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

