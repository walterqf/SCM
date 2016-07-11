Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALtbl_scm_usuarios


    '26/06/2016 16:42:14
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity) As Boolean

        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spu_tbl_scm_usuarios", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_usuario", ptbl_scm_usuarios.Idusuario)
            iCommand.Parameters.AddWithValue("@medloginid", IIf(ptbl_scm_usuarios.Medloginid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medloginid))
            iCommand.Parameters.AddWithValue("@medpassid", IIf(ptbl_scm_usuarios.Medpassid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medpassid))
            iCommand.Parameters.AddWithValue("@mednombre", IIf(ptbl_scm_usuarios.Mednombre Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednombre))
            iCommand.Parameters.AddWithValue("@medestado", IIf(ptbl_scm_usuarios.Medestado Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medestado))
            iCommand.Parameters.AddWithValue("@mednivel", IIf(ptbl_scm_usuarios.Mednivel Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednivel))
            iCommand.Parameters.AddWithValue("@medfechacreacion", IIf(ptbl_scm_usuarios.Medfechacreacion Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medfechacreacion))

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


    '26/06/2016 16:42:14
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity) As tbl_scm_usuarios_Entity

        'Validacion y estandarizacion de los datos
        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            'Acceso a los datos.
            Dim lCommand As New OleDbCommand("spi_tbl_scm_usuarios", iConnection)
            lCommand.CommandType = CommandType.StoredProcedure
            'lCommand.Parameters.AddWithValue("@idusuario", ptbl_scm_usuarios.Idusuario)
            lCommand.Parameters.AddWithValue("@medloginid", IIf(ptbl_scm_usuarios.Medloginid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medloginid))
            lCommand.Parameters.AddWithValue("@medpassid", IIf(ptbl_scm_usuarios.Medpassid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medpassid))
            lCommand.Parameters.AddWithValue("@mednombre", IIf(ptbl_scm_usuarios.Mednombre Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednombre))
            lCommand.Parameters.AddWithValue("@medestado", IIf(ptbl_scm_usuarios.Medestado Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medestado))
            lCommand.Parameters.AddWithValue("@mednivel", IIf(ptbl_scm_usuarios.Mednivel Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednivel))
            lCommand.Parameters.AddWithValue("@medfechacreacion", IIf(ptbl_scm_usuarios.Medfechacreacion Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medfechacreacion))

            iConnection.Open()
            Dim lReturnValue As Object = lCommand.ExecuteScalar()
            iConnection.Close()

            If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                Dim ltbl_scm_usuariosID As Integer = CInt(lReturnValue)
                ptbl_scm_usuarios.Idusuario = ltbl_scm_usuariosID
            End If
            ' NO TIENE COLUMNA GUI'



        End Using

        Return ptbl_scm_usuarios

    End Function


    '26/06/2016 16:42:14
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity)

        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Using lCommand As New OleDbCommand("spd_tbl_scm_usuarios", iConnection)

                lCommand.CommandType = CommandType.StoredProcedure
                lCommand.Parameters.AddWithValue("@idusuario", ptbl_scm_usuarios.Idusuario)

                iConnection.Open()
                lCommand.ExecuteNonQuery()
                iConnection.Close()

            End Using

        End Using

    End Sub


    '26/06/2016 16:42:14
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity) As DataTable

        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_usuarios", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_usuario", IIf(ptbl_scm_usuarios.Idusuario = 0, DBNull.Value, ptbl_scm_usuarios.Idusuario))
            iCommand.Parameters.AddWithValue("@med_loginid", IIf(ptbl_scm_usuarios.Medloginid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medloginid))
            iCommand.Parameters.AddWithValue("@med_passid", IIf(ptbl_scm_usuarios.Medpassid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medpassid))
            iCommand.Parameters.AddWithValue("@med_nombre", IIf(ptbl_scm_usuarios.Mednombre Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednombre))
            iCommand.Parameters.AddWithValue("@med_estado", IIf(ptbl_scm_usuarios.Medestado Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medestado))
            iCommand.Parameters.AddWithValue("@med_nivel", IIf(ptbl_scm_usuarios.Mednivel Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednivel))
            'iCommand.Parameters.AddWithValue("@med_fechacreacion", IIf(ptbl_scm_usuarios.Medfechacreacion Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medfechacreacion))
            Try
                Dim iDTResult As New DataTable("tbl_scm_usuarios")
                Dim iDAResult As New OleDbDataAdapter()
                iDAResult.SelectCommand = iCommand
                iDAResult.Fill(iDTResult)

                Return iDTResult
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try

        End Using
    End Function


    '26/06/2016 16:42:14
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function GetSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) As tbl_scm_usuarios_Entity

     Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_usuarios", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_usuario", iif(ptbl_scm_usuarios.Idusuario = 0, DbNull.Value, ptbl_scm_usuarios.Idusuario))
            iCommand.Parameters.AddWithValue("@med_loginid", iif(ptbl_scm_usuarios.Medloginid is Nothing, DbNull.Value, ptbl_scm_usuarios.Medloginid))
            iCommand.Parameters.AddWithValue("@med_passid", iif(ptbl_scm_usuarios.Medpassid is Nothing, DbNull.Value, ptbl_scm_usuarios.Medpassid))
            iCommand.Parameters.AddWithValue("@med_nombre", iif(ptbl_scm_usuarios.Mednombre is Nothing, DbNull.Value, ptbl_scm_usuarios.Mednombre))
            iCommand.Parameters.AddWithValue("@med_estado", iif(ptbl_scm_usuarios.Medestado is Nothing, DbNull.Value, ptbl_scm_usuarios.Medestado))
            iCommand.Parameters.AddWithValue("@med_nivel", iif(ptbl_scm_usuarios.Mednivel is Nothing, DbNull.Value, ptbl_scm_usuarios.Mednivel))
            'iCommand.Parameters.AddWithValue("@med_fechacreacion", iif(ptbl_scm_usuarios.Medfechacreacion is Nothing, DbNull.Value, ptbl_scm_usuarios.Medfechacreacion))
            Try
                    Dim iDTResult as New DataTable("tbl_scm_usuarios")
                    dim iDAResult as New OleDbDataAdapter()
                    iDAResult.SelectCommand = iCommand
                    iDAResult.Fill(iDTResult)

                    Dim itbl_scm_usuariosResult As New tbl_scm_usuarios_Entity
                    itbl_scm_usuariosResult.Idusuario = IIf(iDTResult.Rows(0)("id_usuario") Is DBNull.Value, Nothing, iDTResult.Rows(0)("id_usuario"))
                    itbl_scm_usuariosResult.Medloginid = IIf(iDTResult.Rows(0)("med_loginid") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_loginid"))
                    itbl_scm_usuariosResult.Medpassid = IIf(iDTResult.Rows(0)("med_passid") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_passid"))
                    itbl_scm_usuariosResult.Mednombre = IIf(iDTResult.Rows(0)("med_nombre") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_nombre"))
                    itbl_scm_usuariosResult.Medestado = IIf(iDTResult.Rows(0)("med_estado") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_estado"))
                    itbl_scm_usuariosResult.Mednivel = IIf(iDTResult.Rows(0)("med_nivel") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_nivel"))
                    itbl_scm_usuariosResult.Medfechacreacion = IIf(iDTResult.Rows(0)("med_fechacreacion") Is DBNull.Value, Nothing, iDTResult.Rows(0)("med_fechacreacion"))

                    Return itbl_scm_usuariosResult

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex.InnerException)
                End Try

            End Using
    End Function


End Class

