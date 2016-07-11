Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_productos


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
     Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) As Boolean

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_producto", ptbl_scm_productos.Idproducto)
            iCommand.Parameters.AddWithValue("@prd_descripcion",ptbl_scm_productos.Prddescripcion )
            iCommand.Parameters.AddWithValue("@prd_estado",ptbl_scm_productos.Prdestado )
            iCommand.Parameters.AddWithValue("@prd_nivel",ptbl_scm_productos.Prdnivel )
            iCommand.Parameters.AddWithValue("@id_medida",ptbl_scm_productos.Idmedida )
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
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) As tbl_scm_productos_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_productos", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idproducto", ptbl_scm_productos.Idproducto) 
            lCommand.Parameters.AddWithValue("@prddescripcion", IIf(ptbl_scm_productos.Prddescripcion is nothing, DBNull.Value, ptbl_scm_productos.Prddescripcion)) 
                lCommand.Parameters.AddWithValue("@prdestado", IIf(ptbl_scm_productos.Prdestado is nothing, DBNull.Value, ptbl_scm_productos.Prdestado)) 
                lCommand.Parameters.AddWithValue("@prdnivel", IIf(ptbl_scm_productos.Prdnivel is nothing, DBNull.Value, ptbl_scm_productos.Prdnivel)) 
                lCommand.Parameters.AddWithValue("@idmedida", ptbl_scm_productos.Idmedida) 

                iConnection.Open()
                Dim lReturnValue As Object = lCommand.ExecuteScalar()
                iConnection.Close()

                If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                    Dim ltbl_scm_productosID as Integer = CInt(lReturnValue)
                    ptbl_scm_productos.idproducto = ltbl_scm_productosID
                End If
 ' NO TIENE COLUMNA GUI'



        End Using

        return ptbl_scm_productos

    End Function


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos As tbl_scm_productos_Entity)

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_productos", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idproducto", ptbl_scm_productos.idproducto)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    'Derechos reservados   10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) As DataTable

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_scm_productos.Idproducto = 0, DbNull.Value, ptbl_scm_productos.Idproducto))
            iCommand.Parameters.AddWithValue("@prd_descripcion", iif(ptbl_scm_productos.Prddescripcion is Nothing, DbNull.Value, ptbl_scm_productos.Prddescripcion))
            iCommand.Parameters.AddWithValue("@prd_estado", iif(ptbl_scm_productos.Prdestado is Nothing, DbNull.Value, ptbl_scm_productos.Prdestado))
            iCommand.Parameters.AddWithValue("@prd_nivel", iif(ptbl_scm_productos.Prdnivel is Nothing, DbNull.Value, ptbl_scm_productos.Prdnivel))
            iCommand.Parameters.AddWithValue("@id_medida", iif(ptbl_scm_productos.Idmedida = 0, DbNull.Value, ptbl_scm_productos.Idmedida))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_productos")
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
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) As tbl_scm_productos_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_productos", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_producto", iif(ptbl_scm_productos.Idproducto = 0, DbNull.Value, ptbl_scm_productos.Idproducto))
            iCommand.Parameters.AddWithValue("@prd_descripcion", iif(ptbl_scm_productos.Prddescripcion is Nothing, DbNull.Value, ptbl_scm_productos.Prddescripcion))
            iCommand.Parameters.AddWithValue("@prd_estado", iif(ptbl_scm_productos.Prdestado is Nothing, DbNull.Value, ptbl_scm_productos.Prdestado))
            iCommand.Parameters.AddWithValue("@prd_nivel", iif(ptbl_scm_productos.Prdnivel is Nothing, DbNull.Value, ptbl_scm_productos.Prdnivel))
            iCommand.Parameters.AddWithValue("@id_medida", iif(ptbl_scm_productos.Idmedida = 0, DbNull.Value, ptbl_scm_productos.Idmedida))
                Try
                    Dim iDTResult as New DataTable("tbl_scm_productos")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_productosResult As New tbl_scm_productos_Entity
                    itbl_scm_productosResult.Idproducto = IIf(iDTResult.Rows(0)("id_producto") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_producto"))
                    itbl_scm_productosResult.Prddescripcion = IIf(iDTResult.Rows(0)("prd_descripcion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("prd_descripcion"))
                    itbl_scm_productosResult.Prdestado = IIf(iDTResult.Rows(0)("prd_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("prd_estado"))
                    itbl_scm_productosResult.Prdnivel = IIf(iDTResult.Rows(0)("prd_nivel") Is DBNull.Value, Nothing, iDTResult.Rows(0)("prd_nivel"))
                    itbl_scm_productosResult.Idmedida = IIf(iDTResult.Rows(0)("id_medida") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_medida"))

                    Return itbl_scm_productosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

