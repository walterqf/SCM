Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_monedas


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_monedas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_moneda", ptbl_monedas.Idmoneda)
            iCommand.Parameters.AddWithValue("@simbolo_moneda",ptbl_monedas.Simbolomoneda )
            iCommand.Parameters.AddWithValue("@nombre_moneda",ptbl_monedas.Nombremoneda )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) As tbl_monedas_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_monedas", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idmoneda", ptbl_monedas.Idmoneda) 
            lCommand.Parameters.AddWithValue("@simbolomoneda", ptbl_monedas.Simbolomoneda) 
                lCommand.Parameters.AddWithValue("@nombremoneda", IIf(ptbl_monedas.Nombremoneda is nothing, DBNull.Value, ptbl_monedas.Nombremoneda)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_monedasID as Integer = CInt(lReturnValue)
                    ptbl_monedas.idmoneda = ltbl_monedasID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_monedas

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas As tbl_monedas_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_monedas", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idmoneda", ptbl_monedas.idmoneda)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_monedas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_moneda", iif(ptbl_monedas.Idmoneda = 0, DbNull.Value, ptbl_monedas.Idmoneda))
            iCommand.Parameters.AddWithValue("@simbolo_moneda", iif(ptbl_monedas.Simbolomoneda is Nothing, DbNull.Value, ptbl_monedas.Simbolomoneda))
            iCommand.Parameters.AddWithValue("@nombre_moneda", iif(ptbl_monedas.Nombremoneda is Nothing, DbNull.Value, ptbl_monedas.Nombremoneda))
                Try
                    Dim iDTResult as New DataTable("tbl_monedas")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_monedas as tbl_monedas_Entity) As tbl_monedas_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_monedas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_moneda", iif(ptbl_monedas.Idmoneda = 0, DbNull.Value, ptbl_monedas.Idmoneda))
            iCommand.Parameters.AddWithValue("@simbolo_moneda", iif(ptbl_monedas.Simbolomoneda is Nothing, DbNull.Value, ptbl_monedas.Simbolomoneda))
            iCommand.Parameters.AddWithValue("@nombre_moneda", iif(ptbl_monedas.Nombremoneda is Nothing, DbNull.Value, ptbl_monedas.Nombremoneda))
                Try
                    Dim iDTResult as New DataTable("tbl_monedas")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_monedasResult As New tbl_monedas_Entity
                    itbl_monedasResult.Idmoneda = IIf(iDTResult.Rows(0)("id_moneda") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_moneda"))
                    itbl_monedasResult.Simbolomoneda = IIf(iDTResult.Rows(0)("simbolo_moneda") Is DBNull.Value, Nothing, iDTResult.Rows(0)("simbolo_moneda"))
                    itbl_monedasResult.Nombremoneda = IIf(iDTResult.Rows(0)("nombre_moneda") Is DBNull.Value, Nothing, iDTResult.Rows(0)("nombre_moneda"))

                    Return itbl_monedasResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

