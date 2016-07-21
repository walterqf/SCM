Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_ordenes_encabezado


    'Derechos reservados  12/07/2016 18:01:34
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_ordenes_encabezado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden",ptbl_ordenes_encabezado.Idorden )
            'iCommand.Parameters.AddWithValue("@fecha_movmiento",ptbl_ordenes_encabezado.Fechamovmiento )
            iCommand.Parameters.AddWithValue("@iva_orden",ptbl_ordenes_encabezado.Ivaorden )
            iCommand.Parameters.AddWithValue("@iva_orden_1",ptbl_ordenes_encabezado.Ivaorden1 )
            iCommand.Parameters.AddWithValue("@total_orden",ptbl_ordenes_encabezado.Totalorden )
            iCommand.Parameters.AddWithValue("@id_usuario",ptbl_ordenes_encabezado.Idusuario )
            iCommand.Parameters.AddWithValue("@id_tipo_orden",ptbl_ordenes_encabezado.Idtipoorden )
            iCommand.Parameters.AddWithValue("@id_gestor_ordenes",ptbl_ordenes_encabezado.Idgestorordenes )
            iCommand.Parameters.AddWithValue("@id_estado_orden",ptbl_ordenes_encabezado.Idestadoorden )
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


    'Derechos reservados  12/07/2016 18:01:34
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) As tbl_ordenes_encabezado_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_ordenes_encabezado", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure

            'lCommand.Parameters.AddWithValue("@fechamovmiento", ptbl_ordenes_encabezado.Fechamovmiento) 
            lCommand.Parameters.AddWithValue("@ivaorden", IIf(ptbl_ordenes_encabezado.Ivaorden is nothing, DBNull.Value, ptbl_ordenes_encabezado.Ivaorden)) 
                lCommand.Parameters.AddWithValue("@ivaorden1", ptbl_ordenes_encabezado.Ivaorden1) 
                lCommand.Parameters.AddWithValue("@totalorden", ptbl_ordenes_encabezado.Totalorden) 
                lCommand.Parameters.AddWithValue("@idusuario", ptbl_ordenes_encabezado.Idusuario) 
                lCommand.Parameters.AddWithValue("@idtipoorden", ptbl_ordenes_encabezado.Idtipoorden) 
                lCommand.Parameters.AddWithValue("@idgestorordenes", ptbl_ordenes_encabezado.Idgestorordenes) 
                lCommand.Parameters.AddWithValue("@idestadoorden", ptbl_ordenes_encabezado.Idestadoorden) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_ordenes_encabezadoID as Integer = CInt(lReturnValue)
                    ptbl_ordenes_encabezado.idorden = ltbl_ordenes_encabezadoID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_ordenes_encabezado

    End Function


    'Derechos reservados  12/07/2016 18:01:34
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado As tbl_ordenes_encabezado_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_ordenes_encabezado", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idorden", ptbl_ordenes_encabezado.idorden)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados  12/07/2016 18:01:34
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_ordenes_encabezado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_ordenes_encabezado.Idorden = 0, DbNull.Value, ptbl_ordenes_encabezado.Idorden))
            'iCommand.Parameters.AddWithValue("@fecha_movmiento", iif(ptbl_ordenes_encabezado.Fechamovmiento is Nothing, DbNull.Value, ptbl_ordenes_encabezado.Fechamovmiento))
            iCommand.Parameters.AddWithValue("@iva_orden", iif(ptbl_ordenes_encabezado.Ivaorden is Nothing, DbNull.Value, ptbl_ordenes_encabezado.Ivaorden))
            iCommand.Parameters.AddWithValue("@iva_orden_1", IIf(ptbl_ordenes_encabezado.Ivaorden1 = 0, DBNull.Value, ptbl_ordenes_encabezado.Ivaorden1))
            iCommand.Parameters.AddWithValue("@total_orden", IIf(ptbl_ordenes_encabezado.Totalorden = 0, DBNull.Value, ptbl_ordenes_encabezado.Totalorden))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_ordenes_encabezado.Idusuario = 0, DbNull.Value, ptbl_ordenes_encabezado.Idusuario))
            iCommand.Parameters.AddWithValue("@id_tipo_orden", iif(ptbl_ordenes_encabezado.Idtipoorden = 0, DbNull.Value, ptbl_ordenes_encabezado.Idtipoorden))
            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", iif(ptbl_ordenes_encabezado.Idgestorordenes = 0, DbNull.Value, ptbl_ordenes_encabezado.Idgestorordenes))
            iCommand.Parameters.AddWithValue("@id_estado_orden", IIf(ptbl_ordenes_encabezado.Idestadoorden = 0, DBNull.Value, ptbl_ordenes_encabezado.Idestadoorden))
            iCommand.Parameters.AddWithValue("@id_empresa", IIf(ptbl_ordenes_encabezado.Idempresa = 0, DBNull.Value, ptbl_ordenes_encabezado.Idempresa))

            Try
                    Dim iDTResult as New DataTable("tbl_ordenes_encabezado")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados  12/07/2016 18:01:34
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_ordenes_encabezado as tbl_ordenes_encabezado_Entity) As tbl_ordenes_encabezado_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_ordenes_encabezado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_ordenes_encabezado.Idorden = 0, DbNull.Value, ptbl_ordenes_encabezado.Idorden))
            'iCommand.Parameters.AddWithValue("@fecha_movmiento", iif(ptbl_ordenes_encabezado.Fechamovmiento is Nothing, DbNull.Value, ptbl_ordenes_encabezado.Fechamovmiento))
            iCommand.Parameters.AddWithValue("@iva_orden", iif(ptbl_ordenes_encabezado.Ivaorden is Nothing, DbNull.Value, ptbl_ordenes_encabezado.Ivaorden))
            iCommand.Parameters.AddWithValue("@iva_orden_1", IIf(ptbl_ordenes_encabezado.Ivaorden1 = 0, DBNull.Value, ptbl_ordenes_encabezado.Ivaorden1))
            iCommand.Parameters.AddWithValue("@total_orden", IIf(ptbl_ordenes_encabezado.Totalorden = 0, DBNull.Value, ptbl_ordenes_encabezado.Totalorden))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_ordenes_encabezado.Idusuario = 0, DbNull.Value, ptbl_ordenes_encabezado.Idusuario))
            iCommand.Parameters.AddWithValue("@id_tipo_orden", iif(ptbl_ordenes_encabezado.Idtipoorden = 0, DbNull.Value, ptbl_ordenes_encabezado.Idtipoorden))
            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", iif(ptbl_ordenes_encabezado.Idgestorordenes = 0, DbNull.Value, ptbl_ordenes_encabezado.Idgestorordenes))
            iCommand.Parameters.AddWithValue("@id_estado_orden", iif(ptbl_ordenes_encabezado.Idestadoorden = 0, DbNull.Value, ptbl_ordenes_encabezado.Idestadoorden))
                Try
                    Dim iDTResult as New DataTable("tbl_ordenes_encabezado")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_ordenes_encabezadoResult As New tbl_ordenes_encabezado_Entity
                    itbl_ordenes_encabezadoResult.Idorden = IIf(iDTResult.Rows(0)("id_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden"))
                    itbl_ordenes_encabezadoResult.Fechamovmiento = IIf(iDTResult.Rows(0)("fecha_movmiento") Is DBNull.Value, Nothing, iDTResult.Rows(0)("fecha_movmiento"))
                    itbl_ordenes_encabezadoResult.Ivaorden = IIf(iDTResult.Rows(0)("iva_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("iva_orden"))
                    itbl_ordenes_encabezadoResult.Ivaorden1 = IIf(iDTResult.Rows(0)("iva_orden_1") Is DBNull.Value, Nothing, iDTResult.Rows(0)("iva_orden_1"))
                    itbl_ordenes_encabezadoResult.Totalorden = IIf(iDTResult.Rows(0)("total_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("total_orden"))
                    itbl_ordenes_encabezadoResult.Idusuario = IIf(iDTResult.Rows(0)("id_usuario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_usuario"))
                    itbl_ordenes_encabezadoResult.Idtipoorden = IIf(iDTResult.Rows(0)("id_tipo_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_tipo_orden"))
                    itbl_ordenes_encabezadoResult.Idgestorordenes = IIf(iDTResult.Rows(0)("id_gestor_ordenes") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_gestor_ordenes"))
                    itbl_ordenes_encabezadoResult.Idestadoorden = IIf(iDTResult.Rows(0)("id_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_estado_orden"))

                    Return itbl_ordenes_encabezadoResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

