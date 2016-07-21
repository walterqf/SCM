Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_detalle_ruta


    'Derechos reservados    18/07/2016 11:48:13 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta as tbl_scm_detalle_ruta_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_detalle_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado",ptbl_scm_detalle_ruta.Idempleado )
            iCommand.Parameters.AddWithValue("@id_vehiculos",ptbl_scm_detalle_ruta.Idvehiculos )
            iCommand.Parameters.AddWithValue("@id_cliente",ptbl_scm_detalle_ruta.Idcliente )
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega",ptbl_scm_detalle_ruta.Idordenesentrega )
            iCommand.Parameters.AddWithValue("@id_det_ruta",ptbl_scm_detalle_ruta.Iddetruta )
            iCommand.Parameters.AddWithValue("@id_ruta",ptbl_scm_detalle_ruta.Idruta )
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


    'Derechos reservados    18/07/2016 11:48:13 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta as tbl_scm_detalle_ruta_Entity) As tbl_scm_detalle_ruta_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_detalle_ruta", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idempleado", ptbl_scm_detalle_ruta.Idempleado) 
                lCommand.Parameters.AddWithValue("@idvehiculos", ptbl_scm_detalle_ruta.Idvehiculos) 
                lCommand.Parameters.AddWithValue("@idcliente", ptbl_scm_detalle_ruta.Idcliente) 
                lCommand.Parameters.AddWithValue("@idordenesentrega", IIf(ptbl_scm_detalle_ruta.Idordenesentrega is nothing, DBNull.Value, ptbl_scm_detalle_ruta.Idordenesentrega)) 
                lCommand.Parameters.AddWithValue("@idruta", IIf(ptbl_scm_detalle_ruta.Idruta is nothing, DBNull.Value, ptbl_scm_detalle_ruta.Idruta)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_detalle_rutaID as Integer = CInt(lReturnValue)
                    ptbl_scm_detalle_ruta.iddetruta = ltbl_scm_detalle_rutaID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_detalle_ruta

    End Function


    'Derechos reservados    18/07/2016 11:48:13 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta As tbl_scm_detalle_ruta_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_detalle_ruta", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@iddetruta", ptbl_scm_detalle_ruta.iddetruta)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados    18/07/2016 11:48:13 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta as tbl_scm_detalle_ruta_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_detalle_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado", iif(ptbl_scm_detalle_ruta.Idempleado = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idempleado))
            iCommand.Parameters.AddWithValue("@id_vehiculos", iif(ptbl_scm_detalle_ruta.Idvehiculos = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idvehiculos))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_detalle_ruta.Idcliente = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idcliente))
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_detalle_ruta.Idordenesentrega is Nothing, DbNull.Value, ptbl_scm_detalle_ruta.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@id_det_ruta", iif(ptbl_scm_detalle_ruta.Iddetruta = 0, DbNull.Value, ptbl_scm_detalle_ruta.Iddetruta))
            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_detalle_ruta.Idruta is Nothing, DbNull.Value, ptbl_scm_detalle_ruta.Idruta))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_detalle_ruta")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados    18/07/2016 11:48:13 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ruta as tbl_scm_detalle_ruta_Entity) As tbl_scm_detalle_ruta_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_detalle_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empleado", iif(ptbl_scm_detalle_ruta.Idempleado = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idempleado))
            iCommand.Parameters.AddWithValue("@id_vehiculos", iif(ptbl_scm_detalle_ruta.Idvehiculos = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idvehiculos))
            iCommand.Parameters.AddWithValue("@id_cliente", iif(ptbl_scm_detalle_ruta.Idcliente = 0, DbNull.Value, ptbl_scm_detalle_ruta.Idcliente))
            iCommand.Parameters.AddWithValue("@id_ordenes_entrega", iif(ptbl_scm_detalle_ruta.Idordenesentrega is Nothing, DbNull.Value, ptbl_scm_detalle_ruta.Idordenesentrega))
            iCommand.Parameters.AddWithValue("@id_det_ruta", iif(ptbl_scm_detalle_ruta.Iddetruta = 0, DbNull.Value, ptbl_scm_detalle_ruta.Iddetruta))
            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_detalle_ruta.Idruta is Nothing, DbNull.Value, ptbl_scm_detalle_ruta.Idruta))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_detalle_ruta")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_detalle_rutaResult As New tbl_scm_detalle_ruta_Entity
                    itbl_scm_detalle_rutaResult.Idempleado = IIf(iDTResult.Rows(0)("id_empleado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_empleado"))
                    itbl_scm_detalle_rutaResult.Idvehiculos = IIf(iDTResult.Rows(0)("id_vehiculos") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_vehiculos"))
                    itbl_scm_detalle_rutaResult.Idcliente = IIf(iDTResult.Rows(0)("id_cliente") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_cliente"))
                    itbl_scm_detalle_rutaResult.Idordenesentrega = IIf(iDTResult.Rows(0)("id_ordenes_entrega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ordenes_entrega"))
                    itbl_scm_detalle_rutaResult.Iddetruta = IIf(iDTResult.Rows(0)("id_det_ruta") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_det_ruta"))
                    itbl_scm_detalle_rutaResult.Idruta = IIf(iDTResult.Rows(0)("id_ruta") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ruta"))

                    Return itbl_scm_detalle_rutaResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

