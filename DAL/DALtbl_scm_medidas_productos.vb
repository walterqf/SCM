Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_medidas_productos


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_medidas_productos as tbl_scm_medidas_productos_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_medidas_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_medida", ptbl_scm_medidas_productos.Idmedida)
            iCommand.Parameters.AddWithValue("@med_descripcion",ptbl_scm_medidas_productos.Meddescripcion )
            iCommand.Parameters.AddWithValue("@med_simbolo",ptbl_scm_medidas_productos.Medsimbolo )
            iCommand.Parameters.AddWithValue("@med_medidas",ptbl_scm_medidas_productos.Medmedidas )
            iCommand.Parameters.AddWithValue("@med_estado",ptbl_scm_medidas_productos.Medestado )
            iCommand.Parameters.AddWithValue("@med_nivel",ptbl_scm_medidas_productos.Mednivel )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_medidas_productos as tbl_scm_medidas_productos_Entity) As tbl_scm_medidas_productos_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_medidas_productos", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idmedida", ptbl_scm_medidas_productos.Idmedida) 
            lCommand.Parameters.AddWithValue("@meddescripcion", IIf(ptbl_scm_medidas_productos.Meddescripcion is nothing, DBNull.Value, ptbl_scm_medidas_productos.Meddescripcion)) 
                lCommand.Parameters.AddWithValue("@medsimbolo", IIf(ptbl_scm_medidas_productos.Medsimbolo is nothing, DBNull.Value, ptbl_scm_medidas_productos.Medsimbolo)) 
                lCommand.Parameters.AddWithValue("@medmedidas", IIf(ptbl_scm_medidas_productos.Medmedidas is nothing, DBNull.Value, ptbl_scm_medidas_productos.Medmedidas)) 
                lCommand.Parameters.AddWithValue("@medestado", IIf(ptbl_scm_medidas_productos.Medestado is nothing, DBNull.Value, ptbl_scm_medidas_productos.Medestado)) 
                lCommand.Parameters.AddWithValue("@mednivel", IIf(ptbl_scm_medidas_productos.Mednivel is nothing, DBNull.Value, ptbl_scm_medidas_productos.Mednivel)) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_medidas_productosID as Integer = CInt(lReturnValue)
                    ptbl_scm_medidas_productos.idmedida = ltbl_scm_medidas_productosID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_medidas_productos

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_medidas_productos As tbl_scm_medidas_productos_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_medidas_productos", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idmedida", ptbl_scm_medidas_productos.idmedida)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_medidas_productos as tbl_scm_medidas_productos_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_medidas_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_medida", iif(ptbl_scm_medidas_productos.Idmedida = 0, DbNull.Value, ptbl_scm_medidas_productos.Idmedida))
            iCommand.Parameters.AddWithValue("@med_descripcion", iif(ptbl_scm_medidas_productos.Meddescripcion is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Meddescripcion))
            iCommand.Parameters.AddWithValue("@med_simbolo", IIf(ptbl_scm_medidas_productos.Medsimbolo Is Nothing, DBNull.Value, ptbl_scm_medidas_productos.Medsimbolo))
            iCommand.Parameters.AddWithValue("@med_medidas", iif(ptbl_scm_medidas_productos.Medmedidas is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Medmedidas))
            iCommand.Parameters.AddWithValue("@med_estado", iif(ptbl_scm_medidas_productos.Medestado is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Medestado))
            iCommand.Parameters.AddWithValue("@med_nivel", iif(ptbl_scm_medidas_productos.Mednivel is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Mednivel))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_medidas_productos")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_medidas_productos as tbl_scm_medidas_productos_Entity) As tbl_scm_medidas_productos_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_medidas_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_medida", iif(ptbl_scm_medidas_productos.Idmedida = 0, DbNull.Value, ptbl_scm_medidas_productos.Idmedida))
            iCommand.Parameters.AddWithValue("@med_descripcion", iif(ptbl_scm_medidas_productos.Meddescripcion is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Meddescripcion))
            iCommand.Parameters.AddWithValue("@med_simbolo", IIf(ptbl_scm_medidas_productos.Medsimbolo Is Nothing, DBNull.Value, ptbl_scm_medidas_productos.Medsimbolo))
            iCommand.Parameters.AddWithValue("@med_medidas", iif(ptbl_scm_medidas_productos.Medmedidas is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Medmedidas))
            iCommand.Parameters.AddWithValue("@med_estado", iif(ptbl_scm_medidas_productos.Medestado is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Medestado))
            iCommand.Parameters.AddWithValue("@med_nivel", iif(ptbl_scm_medidas_productos.Mednivel is Nothing, DbNull.Value, ptbl_scm_medidas_productos.Mednivel))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_medidas_productos")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_medidas_productosResult As New tbl_scm_medidas_productos_Entity
                    itbl_scm_medidas_productosResult.Idmedida = IIf(iDTResult.Rows(0)("id_medida") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_medida"))
                    itbl_scm_medidas_productosResult.Meddescripcion = IIf(iDTResult.Rows(0)("med_descripcion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_descripcion"))
                    itbl_scm_medidas_productosResult.Medsimbolo = IIf(iDTResult.Rows(0)("med_simbolo") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_simbolo"))
                    itbl_scm_medidas_productosResult.Medmedidas = IIf(iDTResult.Rows(0)("med_medidas") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_medidas"))
                    itbl_scm_medidas_productosResult.Medestado = IIf(iDTResult.Rows(0)("med_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_estado"))
                    itbl_scm_medidas_productosResult.Mednivel = IIf(iDTResult.Rows(0)("med_nivel") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_nivel"))

                    Return itbl_scm_medidas_productosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

