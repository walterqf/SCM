Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_tipo_orden


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_orden as tbl_tipo_orden_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_tipo_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_orden", ptbl_tipo_orden.Idtipoorden)
            iCommand.Parameters.AddWithValue("@descripcion_orden",ptbl_tipo_orden.Descripcionorden )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_orden as tbl_tipo_orden_Entity) As tbl_tipo_orden_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_tipo_orden", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idtipoorden", ptbl_tipo_orden.Idtipoorden) 
            lCommand.Parameters.AddWithValue("@descripcionorden", ptbl_tipo_orden.Descripcionorden) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_tipo_ordenID as Integer = CInt(lReturnValue)
                    ptbl_tipo_orden.idtipoorden = ltbl_tipo_ordenID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_tipo_orden

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_orden As tbl_tipo_orden_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_tipo_orden", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idtipoorden", ptbl_tipo_orden.idtipoorden)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_orden as tbl_tipo_orden_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_tipo_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_orden", iif(ptbl_tipo_orden.Idtipoorden = 0, DbNull.Value, ptbl_tipo_orden.Idtipoorden))
            iCommand.Parameters.AddWithValue("@descripcion_orden", iif(ptbl_tipo_orden.Descripcionorden is Nothing, DbNull.Value, ptbl_tipo_orden.Descripcionorden))
                Try
                    Dim iDTResult as New DataTable("tbl_tipo_orden")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_orden as tbl_tipo_orden_Entity) As tbl_tipo_orden_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_tipo_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_orden", iif(ptbl_tipo_orden.Idtipoorden = 0, DbNull.Value, ptbl_tipo_orden.Idtipoorden))
            iCommand.Parameters.AddWithValue("@descripcion_orden", iif(ptbl_tipo_orden.Descripcionorden is Nothing, DbNull.Value, ptbl_tipo_orden.Descripcionorden))
                Try
                    Dim iDTResult as New DataTable("tbl_tipo_orden")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_tipo_ordenResult As New tbl_tipo_orden_Entity
                    itbl_tipo_ordenResult.Idtipoorden = IIf(iDTResult.Rows(0)("id_tipo_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_tipo_orden"))
                    itbl_tipo_ordenResult.Descripcionorden = IIf(iDTResult.Rows(0)("descripcion_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("descripcion_orden"))

                    Return itbl_tipo_ordenResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

