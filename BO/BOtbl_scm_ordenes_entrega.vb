Imports DAL
Imports Entity

Public Class BOtbl_scm_ordenes_entrega

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE GRABADO DE DATOS
    Public Shared Function Insert(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) as tbl_scm_ordenes_entrega_Entity
        Try
            Return DALtbl_scm_ordenes_entrega.Insert(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE ACTUALIZACION DE DATOS
    Public Shared Function Update(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) as Boolean
        Try
             Return DALtbl_scm_ordenes_entrega.Update(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE ELIMINACION DE DATOS
    Public Shared Sub Delete(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) 
        Try
            DALtbl_scm_ordenes_entrega.Delete(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS TODOS LOS REGISTRO REGRESADO EN UN DATATABLE
    Public Shared Function getAll(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) as DataTable
        Try
            Return DALtbl_scm_ordenes_entrega.getAll(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    'Derechos reservados    20/07/2016 1:15:00 a. m.
    'CLASE DE OBTENCION DE DATOS UN SOLO REGISTRO REGRESADO EN UN ENTITY
    Public Shared Function getSingle(ByVal pConnection As Connection_Entity, ByVal ptbl_scm_ordenes_entrega as tbl_scm_ordenes_entrega_Entity) as tbl_scm_ordenes_entrega_Entity
        Try
            Return DALtbl_scm_ordenes_entrega.getSingle(pConnection, ptbl_scm_ordenes_entrega)
        Catch ex as Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Function

End Class

