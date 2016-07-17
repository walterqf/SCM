Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_estado_orden


    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado_orden as tbl_scm_estado_orden_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_scm_estado_orden",ptbl_scm_estado_orden.Idscmestadoorden )
            iCommand.Parameters.AddWithValue("@std_nombre",ptbl_scm_estado_orden.Stdnombre )
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


    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado_orden as tbl_scm_estado_orden_Entity) As tbl_scm_estado_orden_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_estado_orden", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idscmestadoorden", ptbl_scm_estado_orden.Idscmestadoorden) 
                lCommand.Parameters.AddWithValue("@stdnombre", ptbl_scm_estado_orden.Stdnombre) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_estado_ordenID as Integer = CInt(lReturnValue)
                    ptbl_scm_estado_orden.idscmestadoorden = ltbl_scm_estado_ordenID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_estado_orden

    End Function


    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado_orden As tbl_scm_estado_orden_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_estado_orden", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idscmestadoorden", ptbl_scm_estado_orden.idscmestadoorden)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado_orden as tbl_scm_estado_orden_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_estado_orden.Idscmestadoorden = 0, DbNull.Value, ptbl_scm_estado_orden.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@std_nombre", iif(ptbl_scm_estado_orden.Stdnombre is Nothing, DbNull.Value, ptbl_scm_estado_orden.Stdnombre))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_estado_orden")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados    12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado_orden as tbl_scm_estado_orden_Entity) As tbl_scm_estado_orden_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_estado_orden", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_scm_estado_orden", iif(ptbl_scm_estado_orden.Idscmestadoorden = 0, DbNull.Value, ptbl_scm_estado_orden.Idscmestadoorden))
            iCommand.Parameters.AddWithValue("@std_nombre", iif(ptbl_scm_estado_orden.Stdnombre is Nothing, DbNull.Value, ptbl_scm_estado_orden.Stdnombre))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_estado_orden")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_estado_ordenResult As New tbl_scm_estado_orden_Entity
                    itbl_scm_estado_ordenResult.Idscmestadoorden = IIf(iDTResult.Rows(0)("id_scm_estado_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_scm_estado_orden"))
                    itbl_scm_estado_ordenResult.Stdnombre = IIf(iDTResult.Rows(0)("std_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("std_nombre"))

                    Return itbl_scm_estado_ordenResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

