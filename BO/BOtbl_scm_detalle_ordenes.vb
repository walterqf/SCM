Imports DAL
Imports Entity

Public Class BOtbl_scm_detalle_ordenes

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) as tbl_scm_detalle_ordenes_Entity
        Try
            Return DALtbl_scm_detalle_ordenes.Insert(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) as Boolean
        Try
             Return DALtbl_scm_detalle_ordenes.Update(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) 
        Try
            DALtbl_scm_detalle_ordenes.Delete(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) as DataTable
        Try
            Return DALtbl_scm_detalle_ordenes.getAll(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_detalle_ordenes as tbl_scm_detalle_ordenes_Entity) as tbl_scm_detalle_ordenes_Entity
        Try
            Return DALtbl_scm_detalle_ordenes.getSingle(pConnection, ptbl_scm_detalle_ordenes)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

