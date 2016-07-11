Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_gestor_ordenes


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes as tbl_gestor_ordenes_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_gestor_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", ptbl_gestor_ordenes.Idgestorordenes)
            iCommand.Parameters.AddWithValue("@nombre_solicitante_orden",ptbl_gestor_ordenes.Nombresolicitanteorden )
            iCommand.Parameters.AddWithValue("@nombre_comercial_solicitante_orden",ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden )
            iCommand.Parameters.AddWithValue("@nit_solicitante_orden",ptbl_gestor_ordenes.Nitsolicitanteorden )
            iCommand.Parameters.AddWithValue("@direccion_solicitante_orden",ptbl_gestor_ordenes.Direccionsolicitanteorden )
            iCommand.Parameters.AddWithValue("@telefono_solicitante_orden",ptbl_gestor_ordenes.Telefonosolicitanteorden )
            iCommand.Parameters.AddWithValue("@id_tipo_gestor",ptbl_gestor_ordenes.Idtipogestor )
            iCommand.Parameters.AddWithValue("@id_empresa",ptbl_gestor_ordenes.Idempresa )
            iCommand.Parameters.AddWithValue("@id_usuario",ptbl_gestor_ordenes.Idusuario )
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


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes as tbl_gestor_ordenes_Entity) As tbl_gestor_ordenes_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_gestor_ordenes", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idgestorordenes", ptbl_gestor_ordenes.Idgestorordenes) 
            lCommand.Parameters.AddWithValue("@nombresolicitanteorden", IIf(ptbl_gestor_ordenes.Nombresolicitanteorden is nothing, DBNull.Value, ptbl_gestor_ordenes.Nombresolicitanteorden)) 
                lCommand.Parameters.AddWithValue("@nombrecomercialsolicitanteorden", IIf(ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden is nothing, DBNull.Value, ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden)) 
                lCommand.Parameters.AddWithValue("@nitsolicitanteorden", IIf(ptbl_gestor_ordenes.Nitsolicitanteorden is nothing, DBNull.Value, ptbl_gestor_ordenes.Nitsolicitanteorden)) 
                lCommand.Parameters.AddWithValue("@direccionsolicitanteorden", IIf(ptbl_gestor_ordenes.Direccionsolicitanteorden is nothing, DBNull.Value, ptbl_gestor_ordenes.Direccionsolicitanteorden)) 
                lCommand.Parameters.AddWithValue("@telefonosolicitanteorden", IIf(ptbl_gestor_ordenes.Telefonosolicitanteorden is nothing, DBNull.Value, ptbl_gestor_ordenes.Telefonosolicitanteorden)) 
                lCommand.Parameters.AddWithValue("@idtipogestor", ptbl_gestor_ordenes.Idtipogestor) 
                lCommand.Parameters.AddWithValue("@idempresa", ptbl_gestor_ordenes.Idempresa) 
                lCommand.Parameters.AddWithValue("@idusuario", ptbl_gestor_ordenes.Idusuario) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_gestor_ordenesID as Integer = CInt(lReturnValue)
                    ptbl_gestor_ordenes.idgestorordenes = ltbl_gestor_ordenesID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_gestor_ordenes

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes As tbl_gestor_ordenes_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_gestor_ordenes", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idgestorordenes", ptbl_gestor_ordenes.idgestorordenes)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes as tbl_gestor_ordenes_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_gestor_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", iif(ptbl_gestor_ordenes.Idgestorordenes = 0, DbNull.Value, ptbl_gestor_ordenes.Idgestorordenes))
            iCommand.Parameters.AddWithValue("@nombre_solicitante_orden", iif(ptbl_gestor_ordenes.Nombresolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nombresolicitanteorden))
            iCommand.Parameters.AddWithValue("@nombre_comercial_solicitante_orden", iif(ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden))
            iCommand.Parameters.AddWithValue("@nit_solicitante_orden", iif(ptbl_gestor_ordenes.Nitsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nitsolicitanteorden))
            iCommand.Parameters.AddWithValue("@direccion_solicitante_orden", iif(ptbl_gestor_ordenes.Direccionsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Direccionsolicitanteorden))
            iCommand.Parameters.AddWithValue("@telefono_solicitante_orden", iif(ptbl_gestor_ordenes.Telefonosolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Telefonosolicitanteorden))
            iCommand.Parameters.AddWithValue("@id_tipo_gestor", iif(ptbl_gestor_ordenes.Idtipogestor = 0, DbNull.Value, ptbl_gestor_ordenes.Idtipogestor))
            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_gestor_ordenes.Idempresa = 0, DbNull.Value, ptbl_gestor_ordenes.Idempresa))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_gestor_ordenes.Idusuario = 0, DbNull.Value, ptbl_gestor_ordenes.Idusuario))
                Try
                    Dim iDTResult as New DataTable("tbl_gestor_ordenes")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes as tbl_gestor_ordenes_Entity) As tbl_gestor_ordenes_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_gestor_ordenes", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", iif(ptbl_gestor_ordenes.Idgestorordenes = 0, DbNull.Value, ptbl_gestor_ordenes.Idgestorordenes))
            iCommand.Parameters.AddWithValue("@nombre_solicitante_orden", iif(ptbl_gestor_ordenes.Nombresolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nombresolicitanteorden))
            iCommand.Parameters.AddWithValue("@nombre_comercial_solicitante_orden", iif(ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden))
            iCommand.Parameters.AddWithValue("@nit_solicitante_orden", iif(ptbl_gestor_ordenes.Nitsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Nitsolicitanteorden))
            iCommand.Parameters.AddWithValue("@direccion_solicitante_orden", iif(ptbl_gestor_ordenes.Direccionsolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Direccionsolicitanteorden))
            iCommand.Parameters.AddWithValue("@telefono_solicitante_orden", iif(ptbl_gestor_ordenes.Telefonosolicitanteorden is Nothing, DbNull.Value, ptbl_gestor_ordenes.Telefonosolicitanteorden))
            iCommand.Parameters.AddWithValue("@id_tipo_gestor", iif(ptbl_gestor_ordenes.Idtipogestor = 0, DbNull.Value, ptbl_gestor_ordenes.Idtipogestor))
            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_gestor_ordenes.Idempresa = 0, DbNull.Value, ptbl_gestor_ordenes.Idempresa))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_gestor_ordenes.Idusuario = 0, DbNull.Value, ptbl_gestor_ordenes.Idusuario))
                Try
                    Dim iDTResult as New DataTable("tbl_gestor_ordenes")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_gestor_ordenesResult As New tbl_gestor_ordenes_Entity
                    itbl_gestor_ordenesResult.Idgestorordenes = IIf(iDTResult.Rows(0)("id_gestor_ordenes") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_gestor_ordenes"))
                    itbl_gestor_ordenesResult.Nombresolicitanteorden = IIf(iDTResult.Rows(0)("nombre_solicitante_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_solicitante_orden"))
                    itbl_gestor_ordenesResult.Nombrecomercialsolicitanteorden = IIf(iDTResult.Rows(0)("nombre_comercial_solicitante_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_comercial_solicitante_orden"))
                    itbl_gestor_ordenesResult.Nitsolicitanteorden = IIf(iDTResult.Rows(0)("nit_solicitante_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nit_solicitante_orden"))
                    itbl_gestor_ordenesResult.Direccionsolicitanteorden = IIf(iDTResult.Rows(0)("direccion_solicitante_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("direccion_solicitante_orden"))
                    itbl_gestor_ordenesResult.Telefonosolicitanteorden = IIf(iDTResult.Rows(0)("telefono_solicitante_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("telefono_solicitante_orden"))
                    itbl_gestor_ordenesResult.Idtipogestor = IIf(iDTResult.Rows(0)("id_tipo_gestor") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_tipo_gestor"))
                    itbl_gestor_ordenesResult.Idempresa = IIf(iDTResult.Rows(0)("id_empresa") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_empresa"))
                    itbl_gestor_ordenesResult.Idusuario = IIf(iDTResult.Rows(0)("id_usuario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_usuario"))

                    Return itbl_gestor_ordenesResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

