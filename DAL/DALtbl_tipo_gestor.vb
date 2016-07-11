Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_tipo_gestor


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_gestor as tbl_tipo_gestor_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_tipo_gestor", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_gestor", ptbl_tipo_gestor.Idtipogestor)
            iCommand.Parameters.AddWithValue("@nombre_tipo_gestor",ptbl_tipo_gestor.Nombretipogestor )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_gestor as tbl_tipo_gestor_Entity) As tbl_tipo_gestor_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_tipo_gestor", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idtipogestor", ptbl_tipo_gestor.Idtipogestor) 
            lCommand.Parameters.AddWithValue("@nombretipogestor", ptbl_tipo_gestor.Nombretipogestor) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_tipo_gestorID as Integer = CInt(lReturnValue)
                    ptbl_tipo_gestor.idtipogestor = ltbl_tipo_gestorID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_tipo_gestor

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_gestor As tbl_tipo_gestor_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_tipo_gestor", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idtipogestor", ptbl_tipo_gestor.idtipogestor)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_gestor as tbl_tipo_gestor_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_tipo_gestor", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_gestor", iif(ptbl_tipo_gestor.Idtipogestor = 0, DbNull.Value, ptbl_tipo_gestor.Idtipogestor))
            iCommand.Parameters.AddWithValue("@nombre_tipo_gestor", iif(ptbl_tipo_gestor.Nombretipogestor is Nothing, DbNull.Value, ptbl_tipo_gestor.Nombretipogestor))
                Try
                    Dim iDTResult as New DataTable("tbl_tipo_gestor")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_tipo_gestor as tbl_tipo_gestor_Entity) As tbl_tipo_gestor_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_tipo_gestor", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_tipo_gestor", iif(ptbl_tipo_gestor.Idtipogestor = 0, DbNull.Value, ptbl_tipo_gestor.Idtipogestor))
            iCommand.Parameters.AddWithValue("@nombre_tipo_gestor", iif(ptbl_tipo_gestor.Nombretipogestor is Nothing, DbNull.Value, ptbl_tipo_gestor.Nombretipogestor))
                Try
                    Dim iDTResult as New DataTable("tbl_tipo_gestor")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_tipo_gestorResult As New tbl_tipo_gestor_Entity
                    itbl_tipo_gestorResult.Idtipogestor = IIf(iDTResult.Rows(0)("id_tipo_gestor") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_tipo_gestor"))
                    itbl_tipo_gestorResult.Nombretipogestor = IIf(iDTResult.Rows(0)("nombre_tipo_gestor") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_tipo_gestor"))

                    Return itbl_tipo_gestorResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

