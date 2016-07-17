Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_marca_vehiculo


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_marca_vehiculo as tbl_scm_marca_vehiculo_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_marca_vehiculo", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_marca",ptbl_scm_marca_vehiculo.Idmarca )
            iCommand.Parameters.AddWithValue("@mrc_marca",ptbl_scm_marca_vehiculo.Mrcmarca )
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


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_marca_vehiculo as tbl_scm_marca_vehiculo_Entity) As tbl_scm_marca_vehiculo_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_marca_vehiculo", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idmarca", ptbl_scm_marca_vehiculo.Idmarca) 
                lCommand.Parameters.AddWithValue("@mrcmarca", ptbl_scm_marca_vehiculo.Mrcmarca) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_marca_vehiculoID as Integer = CInt(lReturnValue)
                    ptbl_scm_marca_vehiculo.idmarca = ltbl_scm_marca_vehiculoID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_marca_vehiculo

    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_marca_vehiculo As tbl_scm_marca_vehiculo_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_marca_vehiculo", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idmarca", ptbl_scm_marca_vehiculo.idmarca)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_marca_vehiculo as tbl_scm_marca_vehiculo_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_marca_vehiculo", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_marca", iif(ptbl_scm_marca_vehiculo.Idmarca = 0, DbNull.Value, ptbl_scm_marca_vehiculo.Idmarca))
            iCommand.Parameters.AddWithValue("@mrc_marca", iif(ptbl_scm_marca_vehiculo.Mrcmarca is Nothing, DbNull.Value, ptbl_scm_marca_vehiculo.Mrcmarca))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_marca_vehiculo")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_marca_vehiculo as tbl_scm_marca_vehiculo_Entity) As tbl_scm_marca_vehiculo_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_marca_vehiculo", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_marca", iif(ptbl_scm_marca_vehiculo.Idmarca = 0, DbNull.Value, ptbl_scm_marca_vehiculo.Idmarca))
            iCommand.Parameters.AddWithValue("@mrc_marca", iif(ptbl_scm_marca_vehiculo.Mrcmarca is Nothing, DbNull.Value, ptbl_scm_marca_vehiculo.Mrcmarca))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_marca_vehiculo")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_marca_vehiculoResult As New tbl_scm_marca_vehiculo_Entity
                    itbl_scm_marca_vehiculoResult.Idmarca = IIf(iDTResult.Rows(0)("id_marca") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_marca"))
                    itbl_scm_marca_vehiculoResult.Mrcmarca = IIf(iDTResult.Rows(0)("mrc_marca") Is DBNull.Value, Nothing, iDTResult.Rows(0)("mrc_marca"))

                    Return itbl_scm_marca_vehiculoResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

