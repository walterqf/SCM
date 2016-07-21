Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_hist_mant_vehiculos


    'Derechos reservados   19/07/2016 18:02:10
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_hist_mant_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden_hist_mant",ptbl_hist_mant_vehiculos.Idordenhistmant )
            'iCommand.Parameters.AddWithValue("@fecha_mant",ptbl_hist_mant_vehiculos.Fechamant )
            iCommand.Parameters.AddWithValue("@id_orden",ptbl_hist_mant_vehiculos.Idorden )
            iCommand.Parameters.AddWithValue("@id_estado",ptbl_hist_mant_vehiculos.Idestado )
            iCommand.Parameters.AddWithValue("@id_nivel",ptbl_hist_mant_vehiculos.Idnivel )
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


    'Derechos reservados   19/07/2016 18:02:10
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) As tbl_hist_mant_vehiculos_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_hist_mant_vehiculos", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                'lCommand.Parameters.AddWithValue("@idordenhistmant", ptbl_hist_mant_vehiculos.Idordenhistmant) 
                'lCommand.Parameters.AddWithValue("@fechamant", IIf(ptbl_hist_mant_vehiculos.Fechamant is nothing, DBNull.Value, ptbl_hist_mant_vehiculos.Fechamant)) 
                lCommand.Parameters.AddWithValue("@idorden", IIf(ptbl_hist_mant_vehiculos.Idorden is nothing, DBNull.Value, ptbl_hist_mant_vehiculos.Idorden)) 
                lCommand.Parameters.AddWithValue("@idestado", IIf(ptbl_hist_mant_vehiculos.Idestado is nothing, DBNull.Value, ptbl_hist_mant_vehiculos.Idestado)) 
                lCommand.Parameters.AddWithValue("@idnivel", IIf(ptbl_hist_mant_vehiculos.Idnivel is nothing, DBNull.Value, ptbl_hist_mant_vehiculos.Idnivel)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_hist_mant_vehiculosID as Integer = CInt(lReturnValue)
                    ptbl_hist_mant_vehiculos.idordenhistmant = ltbl_hist_mant_vehiculosID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_hist_mant_vehiculos

    End Function


    'Derechos reservados   19/07/2016 18:02:10
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos As tbl_hist_mant_vehiculos_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_hist_mant_vehiculos", iConnection)
				lCommand.Parameters.AddWithValue("@idordenhistmant", ptbl_hist_mant_vehiculos.Idordenhistmant) 
                lCommand.CommandType = CommandType.StoredProcedure

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   19/07/2016 18:02:10
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_hist_mant_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden_hist_mant", iif(ptbl_hist_mant_vehiculos.Idordenhistmant = 0, DbNull.Value, ptbl_hist_mant_vehiculos.Idordenhistmant))
            'iCommand.Parameters.AddWithValue("@fecha_mant", iif(ptbl_hist_mant_vehiculos.Fechamant is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Fechamant))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_hist_mant_vehiculos.Idorden is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idorden))
            iCommand.Parameters.AddWithValue("@id_estado", iif(ptbl_hist_mant_vehiculos.Idestado is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idestado))
            iCommand.Parameters.AddWithValue("@id_nivel", iif(ptbl_hist_mant_vehiculos.Idnivel is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idnivel))
                Try
                    Dim iDTResult as New DataTable("tbl_hist_mant_vehiculos")
                    Dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Return iDTResult
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


    'Derechos reservados   19/07/2016 18:02:10
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_hist_mant_vehiculos as tbl_hist_mant_vehiculos_Entity) As tbl_hist_mant_vehiculos_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_hist_mant_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_orden_hist_mant", iif(ptbl_hist_mant_vehiculos.Idordenhistmant = 0, DbNull.Value, ptbl_hist_mant_vehiculos.Idordenhistmant))
            'iCommand.Parameters.AddWithValue("@fecha_mant", iif(ptbl_hist_mant_vehiculos.Fechamant is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Fechamant))
            iCommand.Parameters.AddWithValue("@id_orden", iif(ptbl_hist_mant_vehiculos.Idorden is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idorden))
            iCommand.Parameters.AddWithValue("@id_estado", iif(ptbl_hist_mant_vehiculos.Idestado is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idestado))
            iCommand.Parameters.AddWithValue("@id_nivel", iif(ptbl_hist_mant_vehiculos.Idnivel is Nothing, DbNull.Value, ptbl_hist_mant_vehiculos.Idnivel))
                Try
                    Dim iDTResult as New DataTable("tbl_hist_mant_vehiculos")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_hist_mant_vehiculosResult As New tbl_hist_mant_vehiculos_Entity
                    itbl_hist_mant_vehiculosResult.Idordenhistmant = IIf(iDTResult.Rows(0)("id_orden_hist_mant") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden_hist_mant"))
                    itbl_hist_mant_vehiculosResult.Fechamant = IIf(iDTResult.Rows(0)("fecha_mant") Is DBNull.Value, Nothing, iDTResult.Rows(0)("fecha_mant"))
                    itbl_hist_mant_vehiculosResult.Idorden = IIf(iDTResult.Rows(0)("id_orden") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_orden"))
                    itbl_hist_mant_vehiculosResult.Idestado = IIf(iDTResult.Rows(0)("id_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_estado"))
                    itbl_hist_mant_vehiculosResult.Idnivel = IIf(iDTResult.Rows(0)("id_nivel") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_nivel"))

                    Return itbl_hist_mant_vehiculosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

