Imports DAL
Imports Entity

Public Class BOtbl_scm_usuarios

    ' 26/06/2016 16:42:14
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) as tbl_scm_usuarios_Entity
        Try
            Return DALtbl_scm_usuarios.Insert(pConnection, ptbl_scm_usuarios)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    ' 26/06/2016 16:42:14
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) as Boolean
        Try
             Return DALtbl_scm_usuarios.Update(pConnection, ptbl_scm_usuarios)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    ' 26/06/2016 16:42:14
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) 
        Try
            DALtbl_scm_usuarios.Delete(pConnection, ptbl_scm_usuarios)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    ' 26/06/2016 16:42:14
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) as DataTable
        Try
            Return DALtbl_scm_usuarios.getAll(pConnection, ptbl_scm_usuarios)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    ' 26/06/2016 16:42:14
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_usuarios as tbl_scm_usuarios_Entity) as tbl_scm_usuarios_Entity
        Try
            Return DALtbl_scm_usuarios.getSingle(pConnection, ptbl_scm_usuarios)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

