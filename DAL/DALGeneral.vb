Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports Entity

Public Class DALGeneral


    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function GetAllUsuarios(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios As tbl_scm_usuarios_Entity) As DataTable

        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_scm_usuarios_mod", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_usuario", IIf(ptbl_scm_usuarios.Idusuario = 0, DBNull.Value, ptbl_scm_usuarios.Idusuario))
            iCommand.Parameters.AddWithValue("@med_loginid", IIf(ptbl_scm_usuarios.Medloginid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medloginid))
            iCommand.Parameters.AddWithValue("@med_passid", IIf(ptbl_scm_usuarios.Medpassid Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medpassid))
            iCommand.Parameters.AddWithValue("@med_nombre", IIf(ptbl_scm_usuarios.Mednombre Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednombre))
            iCommand.Parameters.AddWithValue("@med_estado", IIf(ptbl_scm_usuarios.Medestado Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medestado))
            iCommand.Parameters.AddWithValue("@med_nivel", IIf(ptbl_scm_usuarios.Mednivel Is Nothing, DBNull.Value, ptbl_scm_usuarios.Mednivel))
            iCommand.Parameters.AddWithValue("@med_fechacreacion", IIf(ptbl_scm_usuarios.Medfechacreacion Is Nothing, DBNull.Value, ptbl_scm_usuarios.Medfechacreacion))
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



    Public Shared Function GetAllGestores(ByVal pConnection As Connection_Entity, ByVal ptbl_gestor_ordenes As tbl_gestor_ordenes_Entity) As DataTable

        Using iConnection As New OleDbConnection("Provider=SQLOLEDB;Server=" & pConnection.ServerName & ";Database=" & pConnection.DataBaseName & ";Uid=" & pConnection.Login & "; Pwd=" & Entity.Seguridad.DesEncripta(pConnection.Password) & ";")

            Dim iCommand As New OleDbCommand("spc_tbl_gestor_ordenes_mod", iConnection)
            iCommand.CommandType = CommandType.StoredProcedure

            iCommand.Parameters.AddWithValue("@id_gestor_ordenes", IIf(ptbl_gestor_ordenes.Idgestorordenes = 0, DBNull.Value, ptbl_gestor_ordenes.Idgestorordenes))
            iCommand.Parameters.AddWithValue("@nombre_solicitante_orden", IIf(ptbl_gestor_ordenes.Nombresolicitanteorden Is Nothing, DBNull.Value, ptbl_gestor_ordenes.Nombresolicitanteorden))
            iCommand.Parameters.AddWithValue("@nombre_comercial_solicitante_orden", IIf(ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden Is Nothing, DBNull.Value, ptbl_gestor_ordenes.Nombrecomercialsolicitanteorden))
            iCommand.Parameters.AddWithValue("@nit_solicitante_orden", IIf(ptbl_gestor_ordenes.Nitsolicitanteorden Is Nothing, DBNull.Value, ptbl_gestor_ordenes.Nitsolicitanteorden))
            iCommand.Parameters.AddWithValue("@direccion_solicitante_orden", IIf(ptbl_gestor_ordenes.Direccionsolicitanteorden Is Nothing, DBNull.Value, ptbl_gestor_ordenes.Direccionsolicitanteorden))
            iCommand.Parameters.AddWithValue("@telefono_solicitante_orden", IIf(ptbl_gestor_ordenes.Telefonosolicitanteorden Is Nothing, DBNull.Value, ptbl_gestor_ordenes.Telefonosolicitanteorden))
            iCommand.Parameters.AddWithValue("@id_tipo_gestor", IIf(ptbl_gestor_ordenes.Idtipogestor = 0, DBNull.Value, ptbl_gestor_ordenes.Idtipogestor))
            iCommand.Parameters.AddWithValue("@id_empresa", IIf(ptbl_gestor_ordenes.Idempresa = 0, DBNull.Value, ptbl_gestor_ordenes.Idempresa))
            iCommand.Parameters.AddWithValue("@id_usuario", IIf(ptbl_gestor_ordenes.Idusuario = 0, DBNull.Value, ptbl_gestor_ordenes.Idusuario))
            Try
                Dim iDTResult As New DataTable("tbl_gestor_ordenes")
                Dim iDAResult As New OleDbDataAdapter()
                iDAResult.SelectCommand = iCommand
                iDAResult.Fill(iDTResult)

                Return iDTResult
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try

        End Using
    End Function

End Class
