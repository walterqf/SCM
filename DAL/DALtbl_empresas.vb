Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_empresas


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_empresas as tbl_empresas_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_empresas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empresa", ptbl_empresas.Idempresa)
            iCommand.Parameters.AddWithValue("@emp_direccion",ptbl_empresas.Empdireccion )
            iCommand.Parameters.AddWithValue("@emp_nit",ptbl_empresas.Empnit )
            iCommand.Parameters.AddWithValue("@emp_nombre",ptbl_empresas.Empnombre )
            iCommand.Parameters.AddWithValue("@emp_activo",ptbl_empresas.Empactivo )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_empresas as tbl_empresas_Entity) As tbl_empresas_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_empresas", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idempresa", ptbl_empresas.Idempresa) 
            lCommand.Parameters.AddWithValue("@empdireccion", ptbl_empresas.Empdireccion) 
                lCommand.Parameters.AddWithValue("@empnit", ptbl_empresas.Empnit) 
                lCommand.Parameters.AddWithValue("@empnombre", ptbl_empresas.Empnombre) 
                lCommand.Parameters.AddWithValue("@empactivo", ptbl_empresas.Empactivo) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_empresasID as Integer = CInt(lReturnValue)
                    ptbl_empresas.idempresa = ltbl_empresasID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_empresas

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_empresas As tbl_empresas_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_empresas", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idempresa", ptbl_empresas.idempresa)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_empresas as tbl_empresas_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_empresas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_empresas.Idempresa = 0, DbNull.Value, ptbl_empresas.Idempresa))
            iCommand.Parameters.AddWithValue("@emp_direccion", iif(ptbl_empresas.Empdireccion is Nothing, DbNull.Value, ptbl_empresas.Empdireccion))
            iCommand.Parameters.AddWithValue("@emp_nit", iif(ptbl_empresas.Empnit is Nothing, DbNull.Value, ptbl_empresas.Empnit))
            iCommand.Parameters.AddWithValue("@emp_nombre", iif(ptbl_empresas.Empnombre is Nothing, DbNull.Value, ptbl_empresas.Empnombre))
            iCommand.Parameters.AddWithValue("@emp_activo", iif(ptbl_empresas.Empactivo = 0, DbNull.Value, ptbl_empresas.Empactivo))
                Try
                    Dim iDTResult as New DataTable("tbl_empresas")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_empresas as tbl_empresas_Entity) As tbl_empresas_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_empresas", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_empresa", iif(ptbl_empresas.Idempresa = 0, DbNull.Value, ptbl_empresas.Idempresa))
            iCommand.Parameters.AddWithValue("@emp_direccion", iif(ptbl_empresas.Empdireccion is Nothing, DbNull.Value, ptbl_empresas.Empdireccion))
            iCommand.Parameters.AddWithValue("@emp_nit", iif(ptbl_empresas.Empnit is Nothing, DbNull.Value, ptbl_empresas.Empnit))
            iCommand.Parameters.AddWithValue("@emp_nombre", iif(ptbl_empresas.Empnombre is Nothing, DbNull.Value, ptbl_empresas.Empnombre))
            iCommand.Parameters.AddWithValue("@emp_activo", iif(ptbl_empresas.Empactivo = 0, DbNull.Value, ptbl_empresas.Empactivo))
                Try
                    Dim iDTResult as New DataTable("tbl_empresas")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_empresasResult As New tbl_empresas_Entity
                    itbl_empresasResult.Idempresa = IIf(iDTResult.Rows(0)("id_empresa") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_empresa"))
                    itbl_empresasResult.Empdireccion = IIf(iDTResult.Rows(0)("emp_direccion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_direccion"))
                    itbl_empresasResult.Empnit = IIf(iDTResult.Rows(0)("emp_nit") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_nit"))
                    itbl_empresasResult.Empnombre = IIf(iDTResult.Rows(0)("emp_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_nombre"))
                    itbl_empresasResult.Empactivo = IIf(iDTResult.Rows(0)("emp_activo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("emp_activo"))

                    Return itbl_empresasResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

