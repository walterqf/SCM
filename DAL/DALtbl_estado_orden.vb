Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_estado_orden


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_estado_orden as tbl_estado_orden_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado_orden", ptbl_estado_orden.Idestadoorden)
            iCommand.Parameters.AddWithValue("@nombre_estado_orden",ptbl_estado_orden.Nombreestadoorden )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_estado_orden as tbl_estado_orden_Entity) As tbl_estado_orden_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_estado_orden", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idestadoorden", ptbl_estado_orden.Idestadoorden) 
            lCommand.Parameters.AddWithValue("@nombreestadoorden", IIf(ptbl_estado_orden.Nombreestadoorden is nothing, DBNull.Value, ptbl_estado_orden.Nombreestadoorden)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_estado_ordenID as Integer = CInt(lReturnValue)
                    ptbl_estado_orden.idestadoorden = ltbl_estado_ordenID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_estado_orden

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_estado_orden As tbl_estado_orden_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_estado_orden", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idestadoorden", ptbl_estado_orden.idestadoorden)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_estado_orden as tbl_estado_orden_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado_orden", iif(ptbl_estado_orden.Idestadoorden = 0, DbNull.Value, ptbl_estado_orden.Idestadoorden))
            iCommand.Parameters.AddWithValue("@nombre_estado_orden", iif(ptbl_estado_orden.Nombreestadoorden is Nothing, DbNull.Value, ptbl_estado_orden.Nombreestadoorden))
                Try
                    Dim iDTResult as New DataTable("tbl_estado_orden")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_estado_orden as tbl_estado_orden_Entity) As tbl_estado_orden_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado_orden", iif(ptbl_estado_orden.Idestadoorden = 0, DbNull.Value, ptbl_estado_orden.Idestadoorden))
            iCommand.Parameters.AddWithValue("@nombre_estado_orden", iif(ptbl_estado_orden.Nombreestadoorden is Nothing, DbNull.Value, ptbl_estado_orden.Nombreestadoorden))
                Try
                    Dim iDTResult as New DataTable("tbl_estado_orden")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_estado_ordenResult As New tbl_estado_orden_Entity
                    itbl_estado_ordenResult.Idestadoorden = IIf(iDTResult.Rows(0)("id_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_estado_orden"))
                    itbl_estado_ordenResult.Nombreestadoorden = IIf(iDTResult.Rows(0)("nombre_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_estado_orden"))

                    Return itbl_estado_ordenResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

