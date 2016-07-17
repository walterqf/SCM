Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_estado


    'Derechos reservados     11/07/2016 7:21:37 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_estado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado",ptbl_scm_estado.Idestado )
            iCommand.Parameters.AddWithValue("@nbr_estado",ptbl_scm_estado.Nbrestado )
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


    'Derechos reservados     11/07/2016 7:21:37 p. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) As tbl_scm_estado_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_estado", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idestado", ptbl_scm_estado.Idestado) 
                lCommand.Parameters.AddWithValue("@nbrestado", ptbl_scm_estado.Nbrestado) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_estadoID as Integer = CInt(lReturnValue)
                    ptbl_scm_estado.idestado = ltbl_scm_estadoID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_estado

    End Function


    'Derechos reservados     11/07/2016 7:21:37 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado As tbl_scm_estado_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_estado", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idestado", ptbl_scm_estado.idestado)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     11/07/2016 7:21:37 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_estado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado", iif(ptbl_scm_estado.Idestado = 0, DbNull.Value, ptbl_scm_estado.Idestado))
            iCommand.Parameters.AddWithValue("@nbr_estado", iif(ptbl_scm_estado.Nbrestado is Nothing, DbNull.Value, ptbl_scm_estado.Nbrestado))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_estado")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados     11/07/2016 7:21:37 p. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_estado as tbl_scm_estado_Entity) As tbl_scm_estado_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_estado", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_estado", iif(ptbl_scm_estado.Idestado = 0, DbNull.Value, ptbl_scm_estado.Idestado))
            iCommand.Parameters.AddWithValue("@nbr_estado", iif(ptbl_scm_estado.Nbrestado is Nothing, DbNull.Value, ptbl_scm_estado.Nbrestado))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_estado")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_estadoResult As New tbl_scm_estado_Entity
                    itbl_scm_estadoResult.Idestado = IIf(iDTResult.Rows(0)("id_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_estado"))
                    itbl_scm_estadoResult.Nbrestado = IIf(iDTResult.Rows(0)("nbr_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nbr_estado"))

                    Return itbl_scm_estadoResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

