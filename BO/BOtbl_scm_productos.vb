Imports DAL
Imports Entity

Public Class BOtbl_scm_productos

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) as tbl_scm_productos_Entity
        Try
            Return DALtbl_scm_productos.Insert(pConnection, ptbl_scm_productos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) as Boolean
        Try
             Return DALtbl_scm_productos.Update(pConnection, ptbl_scm_productos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) 
        Try
            DALtbl_scm_productos.Delete(pConnection, ptbl_scm_productos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) as DataTable
        Try
            Return DALtbl_scm_productos.getAll(pConnection, ptbl_scm_productos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados  10/07/2016 14:14:51
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_productos as tbl_scm_productos_Entity) as tbl_scm_productos_Entity
        Try
            Return DALtbl_scm_productos.getSingle(pConnection, ptbl_scm_productos)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

