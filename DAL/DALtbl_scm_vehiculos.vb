Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_vehiculos


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos as tbl_scm_vehiculos_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_vehiculos",ptbl_scm_vehiculos.Idvehiculos )
            iCommand.Parameters.AddWithValue("@id_estado_vehiculo",ptbl_scm_vehiculos.Idestadovehiculo )
            iCommand.Parameters.AddWithValue("@id_tipo_vehiculo",ptbl_scm_vehiculos.Idtipovehiculo )
            iCommand.Parameters.AddWithValue("@id_marca",ptbl_scm_vehiculos.Idmarca )
            iCommand.Parameters.AddWithValue("@vhc_matricula",ptbl_scm_vehiculos.Vhcmatricula )
            iCommand.Parameters.AddWithValue("@vhc_color",ptbl_scm_vehiculos.Vhccolor )
            iCommand.Parameters.AddWithValue("@vhc_modelo",ptbl_scm_vehiculos.Vhcmodelo )
            iCommand.Parameters.AddWithValue("@vhc_km_original",ptbl_scm_vehiculos.Vhckmoriginal )
            iCommand.Parameters.AddWithValue("@vhc_km_actual",ptbl_scm_vehiculos.Vhckmactual )
            'iCommand.Parameters.AddWithValue("@vhc_fecha_ultimoservicio",ptbl_scm_vehiculos.Vhcfechaultimoservicio )
            'iCommand.Parameters.AddWithValue("@vhc_fecha_compra",ptbl_scm_vehiculos.Vhcfechacompra )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos as tbl_scm_vehiculos_Entity) As tbl_scm_vehiculos_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_vehiculos", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idestadovehiculo", ptbl_scm_vehiculos.Idestadovehiculo) 
                lCommand.Parameters.AddWithValue("@idtipovehiculo", ptbl_scm_vehiculos.Idtipovehiculo) 
                lCommand.Parameters.AddWithValue("@idmarca", ptbl_scm_vehiculos.Idmarca) 
                lCommand.Parameters.AddWithValue("@vhcmatricula", ptbl_scm_vehiculos.Vhcmatricula) 
                lCommand.Parameters.AddWithValue("@vhccolor", ptbl_scm_vehiculos.Vhccolor) 
                lCommand.Parameters.AddWithValue("@vhcmodelo", ptbl_scm_vehiculos.Vhcmodelo) 
                lCommand.Parameters.AddWithValue("@vhckmoriginal", ptbl_scm_vehiculos.Vhckmoriginal) 
                lCommand.Parameters.AddWithValue("@vhckmactual", ptbl_scm_vehiculos.Vhckmactual)
            ''lCommand.Parameters.AddWithValue("@vhcfechaultimoservicio", ptbl_scm_vehiculos.Vhcfechaultimoservicio) 
            ''lCommand.Parameters.AddWithValue("@vhcfechacompra", ptbl_scm_vehiculos.Vhcfechacompra) 

            iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_vehiculosID as Integer = CInt(lReturnValue)
                    ptbl_scm_vehiculos.idvehiculos = ltbl_scm_vehiculosID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_vehiculos

    End Function


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos As tbl_scm_vehiculos_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_vehiculos", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idvehiculos", ptbl_scm_vehiculos.idvehiculos)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados     12/07/2016 6:50:52 p. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos as tbl_scm_vehiculos_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_vehiculos", iif(ptbl_scm_vehiculos.Idvehiculos = 0, DbNull.Value, ptbl_scm_vehiculos.Idvehiculos))
            iCommand.Parameters.AddWithValue("@id_estado_vehiculo", iif(ptbl_scm_vehiculos.Idestadovehiculo = 0, DbNull.Value, ptbl_scm_vehiculos.Idestadovehiculo))
            iCommand.Parameters.AddWithValue("@id_tipo_vehiculo", iif(ptbl_scm_vehiculos.Idtipovehiculo = 0, DbNull.Value, ptbl_scm_vehiculos.Idtipovehiculo))
            iCommand.Parameters.AddWithValue("@id_marca", iif(ptbl_scm_vehiculos.Idmarca = 0, DbNull.Value, ptbl_scm_vehiculos.Idmarca))
            iCommand.Parameters.AddWithValue("@vhc_matricula", iif(ptbl_scm_vehiculos.Vhcmatricula is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcmatricula))
            iCommand.Parameters.AddWithValue("@vhc_color", iif(ptbl_scm_vehiculos.Vhccolor is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhccolor))
            iCommand.Parameters.AddWithValue("@vhc_modelo", iif(ptbl_scm_vehiculos.Vhcmodelo is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcmodelo))
            iCommand.Parameters.AddWithValue("@vhc_km_original", IIf(ptbl_scm_vehiculos.Vhckmoriginal = 0, DBNull.Value, ptbl_scm_vehiculos.Vhckmoriginal))
            iCommand.Parameters.AddWithValue("@vhc_km_actual", IIf(ptbl_scm_vehiculos.Vhckmactual = 0, DBNull.Value, ptbl_scm_vehiculos.Vhckmactual))
            'iCommand.Parameters.AddWithValue("@vhc_fecha_ultimoservicio", iif(ptbl_scm_vehiculos.Vhcfechaultimoservicio is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcfechaultimoservicio))
            'iCommand.Parameters.AddWithValue("@vhc_fecha_compra", iif(ptbl_scm_vehiculos.Vhcfechacompra is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcfechacompra))
            Try
                    Dim iDTResult as New DataTable("tbl_scm_vehiculos")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_vehiculos as tbl_scm_vehiculos_Entity) As tbl_scm_vehiculos_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_vehiculos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_vehiculos", iif(ptbl_scm_vehiculos.Idvehiculos = 0, DbNull.Value, ptbl_scm_vehiculos.Idvehiculos))
            iCommand.Parameters.AddWithValue("@id_estado_vehiculo", iif(ptbl_scm_vehiculos.Idestadovehiculo = 0, DbNull.Value, ptbl_scm_vehiculos.Idestadovehiculo))
            iCommand.Parameters.AddWithValue("@id_tipo_vehiculo", iif(ptbl_scm_vehiculos.Idtipovehiculo = 0, DbNull.Value, ptbl_scm_vehiculos.Idtipovehiculo))
            iCommand.Parameters.AddWithValue("@id_marca", iif(ptbl_scm_vehiculos.Idmarca = 0, DbNull.Value, ptbl_scm_vehiculos.Idmarca))
            iCommand.Parameters.AddWithValue("@vhc_matricula", iif(ptbl_scm_vehiculos.Vhcmatricula is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcmatricula))
            iCommand.Parameters.AddWithValue("@vhc_color", iif(ptbl_scm_vehiculos.Vhccolor is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhccolor))
            iCommand.Parameters.AddWithValue("@vhc_modelo", iif(ptbl_scm_vehiculos.Vhcmodelo is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcmodelo))
            iCommand.Parameters.AddWithValue("@vhc_km_original", IIf(ptbl_scm_vehiculos.Vhckmoriginal = 0, DBNull.Value, ptbl_scm_vehiculos.Vhckmoriginal))
            iCommand.Parameters.AddWithValue("@vhc_km_actual", IIf(ptbl_scm_vehiculos.Vhckmactual = 0, DBNull.Value, ptbl_scm_vehiculos.Vhckmactual))
            ' iCommand.Parameters.AddWithValue("@vhc_fecha_ultimoservicio", iif(ptbl_scm_vehiculos.Vhcfechaultimoservicio is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcfechaultimoservicio))
            ' iCommand.Parameters.AddWithValue("@vhc_fecha_compra", iif(ptbl_scm_vehiculos.Vhcfechacompra is Nothing, DbNull.Value, ptbl_scm_vehiculos.Vhcfechacompra))
            Try
                    Dim iDTResult as New DataTable("tbl_scm_vehiculos")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_vehiculosResult As New tbl_scm_vehiculos_Entity
                    itbl_scm_vehiculosResult.Idvehiculos = IIf(iDTResult.Rows(0)("id_vehiculos") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_vehiculos"))
                    itbl_scm_vehiculosResult.Idestadovehiculo = IIf(iDTResult.Rows(0)("id_estado_vehiculo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_estado_vehiculo"))
                    itbl_scm_vehiculosResult.Idtipovehiculo = IIf(iDTResult.Rows(0)("id_tipo_vehiculo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_tipo_vehiculo"))
                    itbl_scm_vehiculosResult.Idmarca = IIf(iDTResult.Rows(0)("id_marca") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_marca"))
                    itbl_scm_vehiculosResult.Vhcmatricula = IIf(iDTResult.Rows(0)("vhc_matricula") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_matricula"))
                    itbl_scm_vehiculosResult.Vhccolor = IIf(iDTResult.Rows(0)("vhc_color") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_color"))
                    itbl_scm_vehiculosResult.Vhcmodelo = IIf(iDTResult.Rows(0)("vhc_modelo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_modelo"))
                    itbl_scm_vehiculosResult.Vhckmoriginal = IIf(iDTResult.Rows(0)("vhc_km_original") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_km_original"))
                    itbl_scm_vehiculosResult.Vhckmactual = IIf(iDTResult.Rows(0)("vhc_km_actual") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_km_actual"))
                    itbl_scm_vehiculosResult.Vhcfechaultimoservicio = IIf(iDTResult.Rows(0)("vhc_fecha_ultimoservicio") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_fecha_ultimoservicio"))
                    itbl_scm_vehiculosResult.Vhcfechacompra = IIf(iDTResult.Rows(0)("vhc_fecha_compra") Is DBNull.Value, Nothing, iDTResult.Rows(0)("vhc_fecha_compra"))

                    Return itbl_scm_vehiculosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

