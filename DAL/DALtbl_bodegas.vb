Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_bodegas


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_bodegas as tbl_bodegas_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_bodegas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_bodega", ptbl_bodegas.Idbodega)
            iCommand.Parameters.AddWithValue("@nombre_bodega",ptbl_bodegas.Nombrebodega )
            iCommand.Parameters.AddWithValue("@id_empresa",ptbl_bodegas.Idempresa )
            iCommand.Parameters.AddWithValue("@bdg_direccion",ptbl_bodegas.Bdgdireccion )
            iCommand.Parameters.AddWithValue("@id_usuario",ptbl_bodegas.Idusuario )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_bodegas as tbl_bodegas_Entity) As tbl_bodegas_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_bodegas", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                'lCommand.Parameters.AddWithValue("@idbodega", ptbl_bodegas.Idbodega) 
                lCommand.Parameters.AddWithValue("@nombrebodega", ptbl_bodegas.Nombrebodega) 
                lCommand.Parameters.AddWithValue("@idempresa", ptbl_bodegas.Idempresa) 
                lCommand.Parameters.AddWithValue("@bdgdireccion", ptbl_bodegas.Bdgdireccion) 
                lCommand.Parameters.AddWithValue("@idusuario", ptbl_bodegas.Idusuario) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_bodegasID as Integer = CInt(lReturnValue)
                    ptbl_bodegas.idbodega = ltbl_bodegasID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_bodegas

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_bodegas As tbl_bodegas_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_bodegas", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idbodega", ptbl_bodegas.idbodega)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_bodegas as tbl_bodegas_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_bodegas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_bodegas.Idbodega = 0, DbNull.Value, ptbl_bodegas.Idbodega))
            iCommand.Parameters.AddWithValue("@nombre_bodega", iif(ptbl_bodegas.Nombrebodega is Nothing, DbNull.Value, ptbl_bodegas.Nombrebodega))
            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_bodegas.Idempresa = 0, DbNull.Value, ptbl_bodegas.Idempresa))
            iCommand.Parameters.AddWithValue("@bdg_direccion", iif(ptbl_bodegas.Bdgdireccion is Nothing, DbNull.Value, ptbl_bodegas.Bdgdireccion))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_bodegas.Idusuario = 0, DbNull.Value, ptbl_bodegas.Idusuario))
                Try
                    Dim iDTResult as New DataTable("tbl_bodegas")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_bodegas as tbl_bodegas_Entity) As tbl_bodegas_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_bodegas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_bodega", iif(ptbl_bodegas.Idbodega = 0, DbNull.Value, ptbl_bodegas.Idbodega))
            iCommand.Parameters.AddWithValue("@nombre_bodega", iif(ptbl_bodegas.Nombrebodega is Nothing, DbNull.Value, ptbl_bodegas.Nombrebodega))
            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_bodegas.Idempresa = 0, DbNull.Value, ptbl_bodegas.Idempresa))
            iCommand.Parameters.AddWithValue("@bdg_direccion", iif(ptbl_bodegas.Bdgdireccion is Nothing, DbNull.Value, ptbl_bodegas.Bdgdireccion))
            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_bodegas.Idusuario = 0, DbNull.Value, ptbl_bodegas.Idusuario))
                Try
                    Dim iDTResult as New DataTable("tbl_bodegas")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_bodegasResult As New tbl_bodegas_Entity
                    itbl_bodegasResult.Idbodega = IIf(iDTResult.Rows(0)("id_bodega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_bodega"))
                    itbl_bodegasResult.Nombrebodega = IIf(iDTResult.Rows(0)("nombre_bodega") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_bodega"))
                    itbl_bodegasResult.Idempresa = IIf(iDTResult.Rows(0)("id_empresa") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_empresa"))
                    itbl_bodegasResult.Bdgdireccion = IIf(iDTResult.Rows(0)("bdg_direccion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("bdg_direccion"))
                    itbl_bodegasResult.Idusuario = IIf(iDTResult.Rows(0)("id_usuario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_usuario"))

                    Return itbl_bodegasResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

