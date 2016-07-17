Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_ruta


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ruta",ptbl_scm_ruta.Idruta )
            iCommand.Parameters.AddWithValue("@rta_nombre",ptbl_scm_ruta.Rtanombre )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) As tbl_scm_ruta_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_ruta", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idruta", ptbl_scm_ruta.Idruta) 
                lCommand.Parameters.AddWithValue("@rtanombre", ptbl_scm_ruta.Rtanombre) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_rutaID as Integer = CInt(lReturnValue)
                    ptbl_scm_ruta.idruta = ltbl_scm_rutaID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_ruta

    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta As tbl_scm_ruta_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_ruta", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idruta", ptbl_scm_ruta.idruta)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_ruta.Idruta = 0, DbNull.Value, ptbl_scm_ruta.Idruta))
            iCommand.Parameters.AddWithValue("@rta_nombre", iif(ptbl_scm_ruta.Rtanombre is Nothing, DbNull.Value, ptbl_scm_ruta.Rtanombre))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_ruta")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ruta as tbl_scm_ruta_Entity) As tbl_scm_ruta_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_ruta", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_ruta", iif(ptbl_scm_ruta.Idruta = 0, DbNull.Value, ptbl_scm_ruta.Idruta))
            iCommand.Parameters.AddWithValue("@rta_nombre", iif(ptbl_scm_ruta.Rtanombre is Nothing, DbNull.Value, ptbl_scm_ruta.Rtanombre))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_ruta")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_rutaResult As New tbl_scm_ruta_Entity
                    itbl_scm_rutaResult.Idruta = IIf(iDTResult.Rows(0)("id_ruta") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_ruta"))
                    itbl_scm_rutaResult.Rtanombre = IIf(iDTResult.Rows(0)("rta_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("rta_nombre"))

                    Return itbl_scm_rutaResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

